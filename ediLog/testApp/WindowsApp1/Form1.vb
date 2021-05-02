Public Class Form1
    Private Sub FrmLog1_Load(sender As Object, e As EventArgs) Handles FrmLog1.Load
        With Me.FrmLog1
            .Root = New IO.DirectoryInfo("C:\Program Files\MedatechUK\MedatechEDI\log")
            .Date = Now
        End With
    End Sub

End Class
