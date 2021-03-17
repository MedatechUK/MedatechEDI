Imports System.IO
Imports WinSCP

Public Class ftpEventArgs : Inherits EventArgs

    Private _session As WinSCP.Session

    Sub New(ByRef Act As ftpconfigModeAct, ByRef session As WinSCP.Session)

        _session = session
        ' Create Folders
        With New DirectoryInfo(Path.Combine(curdir.FullName, Act.dir))
            If Not .Exists Then .Create()
            _dir = New DirectoryInfo(.FullName)
            If Act.actType = eActType.send Then
                With New DirectoryInfo(Path.Combine(.FullName, "save"))
                    If Not .Exists Then .Create()
                    _save = New DirectoryInfo(.FullName)
                End With
            End If
        End With

    End Sub

    Public ReadOnly Property session As WinSCP.Session
        Get
            Return _session
        End Get
    End Property

    Private _dir As DirectoryInfo = Nothing
    Public ReadOnly Property Dir As DirectoryInfo
        Get
            Return _dir
        End Get
    End Property

    Private _save As DirectoryInfo = Nothing
    Public ReadOnly Property Save As DirectoryInfo
        Get
            Return _save
        End Get
    End Property

End Class
