Public Class SortEventArgs
    Inherits EventArgs

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal sortString As String)
        Me.New()
        _sort = sortString
    End Sub

    Private _sort As String

    Public Property Sort() As String
        Get
            Return _sort
        End Get
        Set(ByVal value As String)
            _sort = value
        End Set
    End Property

End Class
