Imports MedatechUK.Deserialiser

Public Class moddef
    Inherits List(Of modrt)
    Implements IDisposable

    Private names As New List(Of String)
    Public RecordTypes As New Dictionary(Of Integer, String)

    Public ReadOnly Property Props(r As Integer, Optional t As ptype = ptype.all) As List(Of modrt)
        Get
            Dim ret As New List(Of modrt)
            For Each i As modrt In Me
                If i.rt = r Then
                    If (t = i.pType) Then
                        ret.Add(i)
                    ElseIf (t = ptype.all) Then
                        ret.Add(i)
                    End If
                End If
            Next
            Return ret
        End Get
    End Property

    Sub New(ByRef l As lexdef)

        For Each r In l.recordtypes
            RecordTypes.Add(r.type, r.name.ToUpper)
            With l.assemblyByName(r.assembly)
                For Each p In .property
                    If p.PropType = ePropertyType.field Then
                        Dim m As New modrt()
                        With m
                            .Name = p.name
                            .rt = r.type
                            .DestName = p.destname

                            Select Case Left(p.destname, 1).ToLower
                                Case "i"
                                    .pType = ptype.i
                                Case "r"
                                    .pType = ptype.r
                                Case "t"
                                    .pType = ptype.t

                            End Select
                            If names.Contains(.Name) Then
                                .ModName = String.Format("{0}_{1}", .Name.ToUpper, r.type.ToString)
                            Else
                                .ModName = String.Format("{0}", .Name.ToUpper)
                            End If
                            names.Add(.ModName)

                        End With
                        Me.Add(m)

                    End If
                Next
            End With
        Next

    End Sub

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

Public Enum ptype
    all = 0
    i = 1
    t = 2
    r = 3

End Enum


Public Class modrt

    Public rt As Integer
    Public Name As String
    Public ModName As String
    Public pType As ptype
    Public DestName As String

    Public ReadOnly Property VarName As String
        Get
            Return String.Format(":{0}", ModName)
        End Get
    End Property

End Class