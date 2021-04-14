Public Class recordColumn

    Private _Name As String
    Private _Ord As Integer
    Private _Width As Integer

    Sub New(ByRef col As tableCol)
        _Name = col.name
        _Ord = col.line
        _Width = col.width

    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property
    Public ReadOnly Property Ord As Integer
        Get
            Return _Ord
        End Get
    End Property

    Public ReadOnly Property Width As Integer
        Get
            Return _Width
        End Get
    End Property

End Class
