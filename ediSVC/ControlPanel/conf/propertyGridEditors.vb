Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Text

Public Class FolderBrowse
    Inherits UITypeEditor

    Private brws As New System.Windows.Forms.FolderBrowserDialog()

    Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function

    Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
        With brws
            .SelectedPath = IO.Path.Combine(value)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Return .SelectedPath
            Else
                Return MyBase.EditValue(context, provider, value)
            End If
        End With
    End Function
End Class

Public Class BinSelEdit
    Inherits UITypeEditor


    Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function

    Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object

        Using sel As New binSelect()
            With sel
                .Value = value
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Return .Value
                Else
                    Return MyBase.EditValue(context, provider, value)
                End If
            End With

        End Using

    End Function

End Class
