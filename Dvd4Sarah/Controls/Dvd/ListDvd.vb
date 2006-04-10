
''' <summary>
''' Steuerelement zum Auflisten von einer DVD-Liste
''' </summary>
Public Class ListDvd

    Public Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

#Region " Eigenschaft List "

    ''' <summary>
    ''' Speichert die Liste der Dvds, die angezeigt werden
    ''' </summary>
    Private _list As Basisklassen.BindableIList(Of BusinessObjects.Dvd)

    ''' <summary>
    ''' Liste der Dvds, die angezeigt werden
    ''' </summary>
    Public Property List() As Basisklassen.BindableIList(Of BusinessObjects.Dvd)
        Get
            Return _list
        End Get
        Set(ByVal value As Basisklassen.BindableIList(Of BusinessObjects.Dvd))
            If DesignMode Then Exit Property

            ' Werte zuweisen
            _list = value
            bndDvd.DataSource = _list
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
    ''' Ausgewählte Dvd in der Tabelle
    ''' </summary>
    ''' <returns>Ausgewählte Dvd</returns>
    Public ReadOnly Property SelectedItem() As BusinessObjects.Dvd
        Get
            If DesignMode Then Return Nothing
            If _list Is Nothing Then Return Nothing

            ' Pessimistisches Cast
            If TypeOf bndDvd.Current Is BusinessObjects.Dvd Then
                Return CType(bndDvd.Current, BusinessObjects.Dvd)
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
            bndDvd.Sort = value
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
