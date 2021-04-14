Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Text
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
            .SelectedPath = IO.Path.Combine(curdir.FullName)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim cur As New List(Of String)
                For Each p As String In Split(curdir.FullName, "\")
                    cur.Add(p)
                Next
                Dim add As New List(Of String)
                For Each p As String In Split(.SelectedPath, "\")
                    add.Add(p)
                Next

                For i As Integer = 0 To cur.Count - 1
                    If Not String.Compare(cur(i), add(i), True) = 0 Then
                        MsgBox(String.Format("The folder must be located in the [{0}] directory.", curdir.FullName))
                        Return MyBase.EditValue(context, provider, value)
                    End If
                Next
                Dim str As New StringBuilder
                For i As Integer = cur.Count To add.Count - 1
                    str.Append(add(i))
                    If i < add.Count - 1 Then
                        str.Append("\")
                    End If
                Next
                Return str.ToString
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
