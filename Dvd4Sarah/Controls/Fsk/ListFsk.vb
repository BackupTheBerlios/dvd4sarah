
''' <summary>
''' Steuerelement zum Auflisten von einer Fsk-Liste
''' </summary>
Public Class ListFsk

    Public Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

#Region " Eigenschaft List "

    ''' <summary>
    ''' Speichert die Liste der Fsks, die angezeigt werden
    ''' </summary>
    Private _list As Basisklassen.BindableIList(Of BusinessObjects.FSK)

    ''' <summary>
    ''' Liste der Fsks, die angezeigt werden
    ''' </summary>
    Public Property List() As Basisklassen.BindableIList(Of BusinessObjects.FSK)
        Get
            Return _list
        End Get
        Set(ByVal value As Basisklassen.BindableIList(Of BusinessObjects.FSK))
            If DesignMode Then Exit Property

            ' Werte zuweisen
            _list = value
            bndFsk.DataSource = _list
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
    ''' Ausgewählte Fsk in der Tabelle
    ''' </summary>
    ''' <returns>Ausgewählte Fsk</returns>
    Public ReadOnly Property SelectedItem() As BusinessObjects.FSK
        Get
            If DesignMode Then Return Nothing
            If _list Is Nothing Then Return Nothing

            ' Pessimistisches Cast
            If TypeOf bndFsk.Current Is BusinessObjects.FSK Then
                Return CType(bndFsk.Current, BusinessObjects.FSK)
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
            bndFsk.Sort = value
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
