Imports DotNetUC.Validation.Common
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Dialog zum Erstellen und Bearbieten von Altersfreigaben
''' </summary>
Public Class EditFskDialog

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
                    oEditFsk.ReadOnly = False
                    btnAdd.Visible = True
                    btnOK.Visible = True
                    btnAbbrechen.Text = "&Abbrechen"
                Case Enums.EditType.Edit
                    oEditFsk.ReadOnly = False
                    btnAdd.Visible = False
                    btnOK.Visible = True
                    btnAbbrechen.Text = "&Abbrechen"
                Case Enums.EditType.View
                    oEditFsk.ReadOnly = True
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
    Private _Fsk As BusinessObjects.FSK

    Public Sub New(ByVal Fsk As BusinessObjects.FSK)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Fsk = Fsk
        oEditFsk.Fsk = _Fsk
    End Sub

#End Region

#Region " Eventhandler "

    ''' <summary>
    ''' Speichert die Altersfreigabe und schliesst den Dialog
    ''' </summary>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        _Fsk.Save()
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
        _Fsk.Save()
        _Fsk = New BusinessObjects.FSK
        oEditFsk.Fsk = _Fsk
    End Sub

    ''' <summary>
    ''' Eventhandler des EditGenre-Dialog bei geänderten Fehlerstatus
    ''' </summary>
    Private Sub oEditFsk_StateChanged(ByVal sender As Object, ByVal e As ValidationEventArgs) Handles oEditFsk.StateChanged
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