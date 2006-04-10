
''' <summary>
''' Steuerelement zum Auflisten von einer Genre-Liste
''' </summary>
Public Class ListGenre

    Public Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

#Region " Eigenschaft List "

    ''' <summary>
    ''' Speichert die Liste der Genres, die angezeigt werden
    ''' </summary>
    Private _list As Basisklassen.BindableIList(Of BusinessObjects.Genre)

    ''' <summary>
    ''' Liste der Genres, die angezeigt werden
    ''' </summary>
    Public Property List() As Basisklassen.BindableIList(Of BusinessObjects.Genre)
        Get
            Return _list
        End Get
        Set(ByVal value As Basisklassen.BindableIList(Of BusinessObjects.Genre))
            If DesignMode Then Exit Property

            ' Werte zuweisen
            _list = value
            bndGenre.DataSource = _list
        End Set
    End Property

#End Region

#Region " Eigenschaft Columns "

    ''' <summary>
    ''' Reicht die Eigenschaften der Columns durch. Dadurch können diese auch
    ''' leicht individuell geändert werden.
    ''' </summary>
    Public ReadOnly Property Columns() As DataGridViewColumnCollection
        Get
            Return Liste.Columns
        End Get
    End Property

#End Region

#Region " Eigenschaft SelectedItem "

    ''' <summary>
    ''' Ausgewählte Genre in der Tabelle
    ''' </summary>
    ''' <returns>Ausgewählte Genre</returns>
    Public ReadOnly Property SelectedItem() As BusinessObjects.Genre
        Get
            If DesignMode Then Return Nothing
            If _list Is Nothing Then Return Nothing

            ' Pessimistisches Cast
            If TypeOf bndGenre.Current Is BusinessObjects.Genre Then
                Return CType(bndGenre.Current, BusinessObjects.Genre)
            End If

            Return Nothing
        End Get
    End Property

#End Region

#Region " Eigenschaft Sort "

    Private _sort As String = ""

    Public Property Sort() As String
        Get
            Return _sort
        End Get
        Set(ByVal value As String)
            _sort = value
            bndGenre.Sort = value
        End Set
    End Property

#End Region

#Region " Methoden "

#End Region

#Region " Eventhandler "

    Private Sub Liste_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Liste.DoubleClick
        RaiseEvent DoubleClick(Me, e)
    End Sub

#End Region

End Class
