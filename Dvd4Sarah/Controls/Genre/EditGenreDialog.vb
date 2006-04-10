Imports DotNetUC.Validation.Common
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Steuerelement zum Bearbieteun und Hinzufügen von Genres
''' </summary>
Public Class EditGenreDialog

#Region " Eigenschaft Modus "

    ''' <summary>
    ''' Speichert den Bearbeitung-/Anzeigemodus
    ''' </summary>
    Private _modus As Enums.EditType = Enums.EditType.Add

    ''' <summary>
    ''' Ändert den Bearbeitungs-/Anzeigemodus
    ''' </summary>
    Public Property Modus() As Enums.EditType
        Get
            Return _modus
        End Get
        Set(ByVal value As Enums.EditType)
            _modus = value
            Select Case _modus
                Case Enums.EditType.Add
                    oEditGenre.ReadOnly = False
                    btnAdd.Visible = True
                    btnOK.Visible = True
                    btnAbbrechen.Text = "&Abbrechen"
                Case Enums.EditType.Edit
                    oEditGenre.ReadOnly = False
                    btnAdd.Visible = False
                    btnOK.Visible = True
                    btnAbbrechen.Text = "&Abbrechen"
                Case Enums.EditType.View
                    oEditGenre.ReadOnly = True
                    btnAdd.Visible = False
                    btnOK.Visible = False
                    btnAbbrechen.Text = "&OK"
            End Select
        End Set
    End Property

#End Region

#Region " Konstruktor / Member "

    ''' <summary>
    ''' Genre, dass gerade bearbeitet wird
    ''' </summary>
    Private _Genre As BusinessObjects.Genre

    ''' <summary>
    ''' Erzeugt einen neuen Dialog
    ''' </summary>
    Public Sub New(ByVal Genre As BusinessObjects.Genre)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Genre = Genre
        oEditGenre.Genre = _Genre
    End Sub

#End Region

#Region " Eventhandler "

    ''' <summary>
    ''' Speichern und schliessen des Dialoges
    ''' </summary>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        _Genre.Save()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Schliesst den Dialog ohne zu speichern
    ''' </summary>
    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Speichert das aktuelle Genre und erstellt ein neues
    ''' </summary>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        _Genre.Save()
        _Genre = New BusinessObjects.Genre
        oEditGenre.Genre = _Genre
    End Sub

    ''' <summary>
    ''' Eventhandler des EditGenre-Dialog bei geänderten Fehlerstatus
    ''' </summary>
    Private Sub oEditGenre_StateChanged(ByVal sender As Object, ByVal e As ValidationEventArgs) Handles oEditGenre.StateChanged
        Dim enab As Boolean = False
        If e.Info Is Nothing Then
            enab = True
        ElseIf e.Info.Severity = ValidationSeverity.None Then
            enab = True
        End If
        btnOK.Enabled = enab
        btnAdd.Enabled = enab
    End Sub

#End Region

End Class