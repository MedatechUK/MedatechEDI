Imports System.IO

Public Class OutFile : Inherits List(Of recordType) : Implements IDisposable

    Private _o As makeconfigOutput

    Private _config As makeconfig
    Public ReadOnly Property config As makeconfig
        Get
            Return _config
        End Get
    End Property

    Private lineendField As String

    Private filespecField As String
    Public ReadOnly Property OutFile As FileInfo
        Get
            Return New FileInfo(
                Path.Combine(
                    Environment.CurrentDirectory,
                    filespecField
                )
            )
        End Get
    End Property

    Public ReadOnly Property Deliminator As String
        Get
            Return Replace(_o.deliminator, "\t", Chr(8))
        End Get

    End Property

    Private _format As String
    Public ReadOnly Property format As String
        Get
            If _format Is Nothing Then
                Return "{0}"
            Else
                Return _format
            End If
        End Get
    End Property

#Region "Constructor"

    Sub New(ByRef o As makeconfigOutput, ByRef config As makeconfig)

        _config = config
        _o = o

        With _o
            _format = .format
            _format = Replace(_format, "''", Chr(34))


            filespecField = .filespec
            filespecField = Replace(filespecField, "wk", Right("00" & DatePart(DateInterval.WeekOfYear, Now).ToString, 2))
            filespecField = Replace(filespecField, "dd", Right("00" & DatePart(DateInterval.Minute, Now).ToString, 2))
            filespecField = Replace(filespecField, "MM", Right("00" & DatePart(DateInterval.Month, Now).ToString, 2))
            filespecField = Replace(filespecField, "yyyy", Right(DatePart(DateInterval.Year, Now).ToString, 4))
            filespecField = Replace(filespecField, "yy", Right(DatePart(DateInterval.Year, Now).ToString, 2))
            filespecField = Replace(filespecField, "mm", Right("00" & DatePart(DateInterval.Minute, Now).ToString, 2))
            filespecField = Replace(filespecField, "hh", Right("00" & DatePart(DateInterval.Hour, Now).ToString, 2))
            filespecField = Replace(filespecField, "ss", Right("00" & DatePart(DateInterval.Second, Now).ToString, 2))

            Dim C As String = Right(Strings.StrDup(filespecField.Split("N").Length - 1, "0") & _o.runcount.ToString, filespecField.Split("N").Length - 1)
            filespecField = Replace(filespecField, Strings.StrDup(filespecField.Split("N").Length - 1, "N"), C)


            lineendField = .lineend
            lineendField = Replace(lineendField, "cr", Chr(13),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "lf", Chr(10),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "vt", Chr(11),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "dle", Chr(16),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "ht", Chr(9),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "fs", Chr(28),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "gs", Chr(29),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "rs", Chr(30),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "us", Chr(31),,, CompareMethod.Text)
            lineendField = Replace(lineendField, "ff", Chr(12),,, CompareMethod.Text)


            For Each t As table In o.table
                Me.Add(New recordType(Nothing, t, Me))

            Next

        End With

    End Sub

#End Region

#Region "Write to file"

    Public Sub Write()

        Dim fo As FileInfo = OutFile
        args.Log("Writing file {0}", fo.FullName)
        args.line("Writing file {0}", fo.Name)

        Using _sw As New StreamWriter(
            fo.FullName,
            False,
            _o.sEncoding
        )
            _sw.NewLine = lineendField

            For Each rt As recordType In Me
                rt.write(_sw)

            Next

            ' Increment run count
            _o.runcount = (CInt(_o.runcount) + 1).ToString

        End Using

    End Sub

#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).                

            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class
