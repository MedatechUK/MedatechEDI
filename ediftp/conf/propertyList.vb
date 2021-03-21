Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms.Design

Public Class ServerList
    Inherits StringConverter

    Public Overloads Overrides Function GetStandardValuesSupported(
                    ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overloads Overrides Function GetStandardValues(
                     ByVal context As ITypeDescriptorContext) _
                  As StandardValuesCollection

        Dim ret As String()
        For Each s In config.server
            Try
                ReDim Preserve ret(UBound(ret) + 1)
            Catch ex As Exception
                ReDim ret(0)
            End Try
            ret(UBound(ret)) = s.name
        Next
        Return New StandardValuesCollection(ret)
    End Function

    Public Overloads Overrides Function GetStandardValuesExclusive(
           ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

End Class

Public Class ModeList
    Inherits StringConverter

    Public Overloads Overrides Function GetStandardValuesSupported(
                    ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overloads Overrides Function GetStandardValues(
                     ByVal context As ITypeDescriptorContext) _
                  As StandardValuesCollection

        Dim ret As String()
        For Each m In config.mode
            Try
                ReDim Preserve ret(UBound(ret) + 1)
            Catch ex As Exception
                ReDim ret(0)
            End Try
            ret(UBound(ret)) = m.name
        Next
        Return New StandardValuesCollection(ret)

    End Function

    Public Overloads Overrides Function GetStandardValuesExclusive(
               ByVal context As ITypeDescriptorContext) As Boolean
        Return False
    End Function

End Class

Public Class FolderBrowse
    Inherits UITypeEditor

    Private brws As New System.Windows.Forms.FolderBrowserDialog()

    Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function

    Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
        With brws
            .SelectedPath = IO.Path.Combine(curdir.FullName, value.ToString)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Return .SelectedPath
            Else
                Return MyBase.EditValue(context, provider, value)
            End If
        End With
    End Function

End Class