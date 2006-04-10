
''' <summary>
''' Steuerelement zum Auflisten von einer Owner-Liste
''' </summary>
Public Class ListOwner
    Public Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

#Region " Eigenschaft List "

    ''' <summary>
    ''' Speichert die Liste der Owners, die angezeigt werden
    ''' </summary>
    Private _list As Basisklassen.BindableIList(Of BusinessObjects.Owner)

    ''' <summary>
    ''' Liste der Owners, die angezeigt werden
    ''' </summary>
    Public Property List() As Basisklassen.BindableIList(Of BusinessObjects.Owner)
        Get
            Return _list
        End Get
        Set(ByVal value As Basisklassen.BindableIList(Of BusinessObjects.Owner))
            If DesignMode Then Exit Property

            ' Werte zuweisen
            _list = value
            bndOwner.DataSource = _list
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
    ''' Ausgewählte Owner in der Tabelle
    ''' </summary>
    ''' <returns>Ausgewählte Owner</returns>
    Public ReadOnly Property SelectedItem() As BusinessObjects.Owner
        Get
            If DesignMode Then Return Nothing
            If _list Is Nothing Then Return Nothing

            ' Pessimistisches Cast
            If TypeOf bndOwner.Current Is BusinessObjects.Owner Then
                Return CType(bndOwner.Current, BusinessObjects.Owner)
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
            bndOwner.Sort = value
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
