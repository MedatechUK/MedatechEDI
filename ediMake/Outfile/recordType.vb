Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports MedatechUK.CLI

Public Class recordType : Inherits List(Of recordType)

#Region "Variables"

    Private o As Integer
    Private _Params As List(Of String)
    Private _cn As SqlConnection
    Private _view As String

#End Region

#Region "Properties"
    Public ReadOnly Property deliminator As String
        Get
            Return _ouf.Deliminator
        End Get
    End Property

    Private _r As SqlDataReader
    Public ReadOnly Property Reader As SqlDataReader
        Get
            Return _r
        End Get
    End Property

    Private _parent As recordType
    Public ReadOnly Property Parent As recordType
        Get
            Return _parent
        End Get
    End Property

    Private _rColumns As New Dictionary(Of Integer, recordColumn)
    Public ReadOnly Property Columns As Dictionary(Of Integer, recordColumn)
        Get
            Return _rColumns
        End Get
    End Property

    Private _db As String
    Public ReadOnly Property db As String
        Get
            If _db Is Nothing Then
                Dim e As recordType = Me
                While _db Is Nothing And Not e.Parent Is Nothing
                    e = e.Parent
                    _db = e.db
                End While
            End If
            If _db Is Nothing Then
                _db = _ouf.config.db
            End If
            Return _db
        End Get
    End Property

    Private _constr As String
    Public ReadOnly Property constr As String
        Get
            If _constr Is Nothing Then
                Dim e As recordType = Me
                While _db Is Nothing And Not e.Parent Is Nothing
                    e = e.Parent
                    _constr = e.constr
                End While
            End If
            If _constr Is Nothing Then
                _constr = _ouf.config.connectionString
            End If
            Return _constr
        End Get
    End Property

#End Region

#Region "Ctor"

    Private _ouf As OutFile
    Sub New(ByRef parent As recordType, ByRef t As table, ByRef ouf As OutFile)

        _ouf = ouf
        _parent = parent

        With t
            _constr = .connectionString
            _db = .db
            _view = .name
        End With

        If constr Is Nothing Then
            Throw New Exception("No connection string provided.")
        End If

        Try
            _cn = New SqlConnection(constr)
            _cn.Open()

        Catch ex As Exception
            Throw New Exception(String.Format("Could not connect to database. {0}", ex.Message))

        End Try

        If Me.db Is Nothing Then
            Throw New Exception(String.Format("Could not USE db [{0}].", "MISSING!"))
        End If

        Try
            _cn.ChangeDatabase(Me.db)

        Catch ex As Exception
            Throw New Exception(String.Format("Could not USE db [{0}].", Me.db))

        End Try

        o = getObjectID(t.name)
        If o = 0 Then
            Throw New Exception(String.Format("Invalid view or procedure [{0}].", t.name))

        End If

        _Params = ObjectPar(o)

        If configMode Then
            UpdateCols(t)

        Else
            For Each c As tableCol In t.col
                _rColumns.Add(c.line, New recordColumn(c))

            Next

        End If

        If Not t.subtable Is Nothing Then
            For Each st As table In t.subtable
                Me.Add(New recordType(Me, st, ouf))

            Next
        End If

    End Sub

#End Region

#Region "Private functions"

    Private Sub UpdateCols(ByRef t As table)

        Dim ecols As New List(Of String)
        Dim dcols As New List(Of tableCol)
        Dim ncols As New List(Of tableCol)
        Dim ocols As List(Of String) = ObjectCols(o)
        Dim last As Integer = 0

        For Each c As tableCol In t.col
            If Not ocols.Contains(c.name) Then
                dcols.Add(c)

            Else
                ecols.Add(c.name)
                If c.line > last Then
                    last = c.line
                End If

            End If

        Next

        If dcols.Count > 0 Then
            Console.WriteLine("Found the following columns missing from table [{0}].", t.name)
            For Each c As tableCol In dcols
                Console.WriteLine(" > [{0}].[{1}]", t.name, c.name)

            Next
            If args.YesNo("Delete these references? (Y/N)") Then
                For Each c As tableCol In dcols
                    t.col.Remove(c)
                Next
            End If

        End If

        For Each c As String In ocols
            If Not ecols.Contains(c) Then
                last += 1
                ncols.Add(New tableCol(last, c))

            End If
        Next

        If ncols.Count > 0 Then
            Console.WriteLine("Found the following columns from table [{0}] are unreferenced.", t.name)
            For Each c As tableCol In ncols
                Console.WriteLine(" > [{0}].[{1}]", t.name, c.name)

            Next
            If args.YesNo("Add these references? (Y/N)") Then
                For Each c As tableCol In ncols
                    t.col.Add(c)

                Next
            End If

        End If

    End Sub

    Private Function getObjectID(name As String) As Integer

        Dim sql As String = String.Format(
            "Select object_id " &
            "From sys.objects " &
            "Where 0 = 0 " &
            "	And type in ('V','IF','TF') " &
            "	And name = '{0}' ",
            name
        )

        Using c As New SqlCommand(sql, _cn)
            Dim ret As Object = c.ExecuteScalar
            If ret Is Nothing Then
                Return 0
            Else
                Return CInt(ret)
            End If
        End Using

    End Function

    Private Function ObjectPar(ObjectID As Integer) As List(Of String)

        Dim ret As New List(Of String)

        Dim sql As String = String.Format(
            "select p.name " &
            "from sys.objects o	" &
            "	join sys.all_parameters p on p.object_id = o.object_id " &
            "where 0=0 " &
            "	and o.object_id = {0} ",
            ObjectID.ToString
        )

        Using c As New SqlCommand(sql, _cn)
            Using r As SqlDataReader = c.ExecuteReader()
                While r.Read
                    ret.Add(r(0))
                End While
            End Using
        End Using

        Return ret
    End Function

    Private Function ObjectCols(ObjectID As Integer) As List(Of String)

        Dim ret As New List(Of String)

        Dim sql As String = String.Format(
            "select 	 " &
            "	c.name " &
            "from sys.columns c " &
            "	join sys.objects o on o.object_id = c.object_id 	" &
            "where 0=0	" &
            "	and o.object_id = {0} ",
            ObjectID.ToString()
        )

        Using c As New SqlCommand(sql, _cn)
            Using r As SqlDataReader = c.ExecuteReader()
                While r.Read
                    ret.Add(r(0))
                End While
            End Using
        End Using

        Return ret
    End Function

    Private Function ObjectType(ObjectID As Integer) As String

        Dim sql As String = String.Format(
            "Select type " &
            "From sys.objects " &
            "Where 0 = 0 " &
            "	And object_id = '{0}' ",
            ObjectID
        )

        Using c As New SqlCommand(sql, _cn)
            Return c.ExecuteScalar

        End Using

    End Function

    Private Function cmd() As SqlCommand

        Return New SqlCommand(String.Format("SELECT * FROM dbo.{0} {1}", _view, strparams), _cn)

    End Function

    Private Function cmdCount() As SqlCommand

        Return New SqlCommand(String.Format("SELECT count(*) FROM dbo.{0} {1}", _view, strparams), _cn)

    End Function

    Private Function strparams() As String

        If String.Compare(ObjectType(o).ToLower, "v") = 0 Then Return ""
        Dim str As New StringBuilder
        With str
            .Append("(")
            For Each s As String In _Params
                If _parent Is Nothing Then
                    Throw New Exception(String.Format("Root view {0} may not have parameters.", _view))
                End If

                str.Append(_parent.ColumnValue(s.Substring(1)))
                If Not String.Compare(_Params.Last, s) = 0 Then
                    str.Append(", ")
                End If

            Next
            .Append(")")

        End With

        Return str.ToString

    End Function

#End Region

#Region "Public Methods"

    Private _map As Dictionary(Of String, Integer) = Nothing
    Public Sub write(ByRef sw As StreamWriter)

        If _parent Is Nothing Then
            args.StartProgress(cmdCount.ExecuteScalar)

        End If

        _r = cmd().ExecuteReader

        If _map Is Nothing Then
            _map = New Dictionary(Of String, Integer)
            For i As Integer = 0 To _r.FieldCount - 1
                _map.Add(_r.GetName(i), i)

            Next
        End If

        While _r.Read

            For i As Integer = 1 To _rColumns.Count
                If Not _map.Keys.Contains(_rColumns(i).Name) Then
                    Throw New Exception(String.Format("Column {0} does not exist in view {1}.", _rColumns(i).Name, _view))
                End If

                Dim st As String = _r(_map(_rColumns(i).Name))
                If _rColumns(i).Width > 0 And st.Length > _rColumns(i).Width Then
                    sw.Write(
                        String.Format(
                            _ouf.format, st.Substring(1, _rColumns(i).Width)
                        )
                    )

                Else
                    sw.Write(
                        String.Format(
                            _ouf.format, st
                        )
                    )

                End If

                If i < _rColumns.Count Then sw.Write(deliminator)

            Next

            sw.Write(sw.NewLine)

            For Each rt As recordType In Me
                rt.write(sw)

            Next

            If _parent Is Nothing Then
                args.Progress += 1

            End If

        End While

    End Sub

    Public Sub config()



    End Sub

    Public Function ColumnValue(col As String) As String
        If _map.Keys.Contains(col) Then
            Return _r(_map(col))

        Else
            Throw New Exception(String.Format("Column {0} does not exist in view {1}.", col, _view))

        End If

    End Function

#End Region

End Class
