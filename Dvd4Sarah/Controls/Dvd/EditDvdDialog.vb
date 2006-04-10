Imports DotNetUC.Validation.Common
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Dialog zum Erstellen und Bearbieten von Altersfreigaben
''' </summary>
Public Class EditDvdDialog

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
                    oEditDvd.ReadOnly = False
                    btnAdd.Visible = True
                    btnOK.Visible = True
                    btnAbbrechen.Text = "&Abbrechen"
                Case Enums.EditType.Edit
                    oEditDvd.ReadOnly = False
                    btnAdd.Visible = False
                    btnOK.Visible = True
                    btnAbbrechen.Text = "&Abbrechen"
                Case Enums.EditType.View
                    oEditDvd.ReadOnly = True
                    btnAdd.Visible = False
                    btnOK.Visible = False
                    btnAbbrechen.Text = "&OK"
            End Select
        End Set
    End Property

#End Region

#Region " Konstruktor / Member "

    ''' <summary>
    ''' Speichert das aktuelle bearbeitete Objekt
    ''' </summary>
    Private _Dvd As BusinessObjects.Dvd

    Public Sub New(ByVal Dvd As BusinessObjects.Dvd)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Dvd = Dvd
        oEditDvd.Dvd = _Dvd
    End Sub

#End Region

#Region " Eventhandler "

    ''' <summary>
    ''' Speichert die Altersfreigabe und schliesst den Dialog
    ''' </summary>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        _Dvd.Save()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Schliesst den Dialog ohne zu speichern.
    ''' </summary>
    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Speichert die aktuelle Altersfreigabe und fügt eine neue hinzu
    ''' </summary>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        _Dvd.Save()
        _Dvd = New BusinessObjects.Dvd
        oEditDvd.Dvd = _Dvd
    End Sub

    ''' <summary>
    ''' Eventhandler des EditGenre-Dialog bei geänderten Fehlerstatus
    ''' </summary>
    Private Sub oEditDvd_StateChanged(ByVal sender As Object, ByVal e As ValidationEventArgs) Handles oEditDvd.StateChanged
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