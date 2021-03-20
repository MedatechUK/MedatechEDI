Imports System.ComponentModel

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