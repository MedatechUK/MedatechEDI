Imports System.Windows.Forms

Public Class binSelect

    Public Property Value As String
        Get
            Select Case RadioButton1.Checked
                Case True ' bin
                    Return binpath.Text

                Case Else ' lex
                    Return Lexor.text

            End Select

        End Get
        Set(value As String)
            For Each s As String In lexors
                If String.Compare(s, value, True) = 0 Then
                    RadioButton2.Checked = True
                    Lexor.Text = s
                    Lexor.SelectedText = s
                    Exit Property
                End If
            Next
            Me.binpath.Text = value

        End Set

    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Lexor.Enabled = RadioButton2.Checked
        Browse.Enabled = RadioButton1.Checked

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        RadioButton1.Checked = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        RadioButton2.Checked = True
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Using filedialog As New OpenFileDialog
            With filedialog
                .Title = "Choose Binary"
                Try
                    If New IO.FileInfo(Me.binpath.Text).Exists Then
                        .InitialDirectory = New IO.FileInfo(Me.binpath.Text).Directory.FullName
                    Else
                        .InitialDirectory = "C:\"
                    End If

                Catch ex As Exception
                    .InitialDirectory = "C:\"

                End Try

                .Filter = "All files (*.*)|*.*|Batch Files (*.bat)|*.bat|Executable Files (*.exe)|*.exe"
                .FilterIndex = 2
                .RestoreDirectory = True
                .Multiselect = False
                If .ShowDialog = DialogResult.OK Then
                    Me.binpath.Text = filedialog.FileName

                End If
            End With
        End Using
    End Sub

    Private Sub binSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each s As String In lexors
            Me.Lexor.Items.Add(s)

        Next
    End Sub

End Class
