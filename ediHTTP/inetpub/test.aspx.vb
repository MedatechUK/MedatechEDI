
Partial Class test
    Inherits System.Web.UI.Page

    Private Sub test_Load(sender As Object, e As EventArgs) Handles Me.Load
        Response.Write(Server.MapPath("/api"))
    End Sub
End Class
