Imports DotNetUC.Validation.Common
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Steuerelement zum Bearbieteun und Hinzufügen von Besitzern
''' </summary>
Public Class EditOwnerDialog

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
                    oEditOwner.ReadOnly = False
                    btnAdd.Visible = True
                    btnOK.Visible = True
                    btnAbbrechen.Text = "&Abbrechen"
                Case Enums.EditType.Edit
                    oEditOwner.ReadOnly = False
                    btnAdd.Visible = False
                    btnOK.Visible = True
                    btnAbbrechen.Text = "&Abbrechen"
                Case Enums.EditType.View
                    oEditOwner.ReadOnly = True
                    btnAdd.Visible = False
                    btnOK.Visible = False
                    btnAbbrechen.Text = "&OK"
            End Select
        End Set
    End Property

#End Region

#Region " Konstruktor / Member "

    ''' <summary>
    ''' Owner, dass gerade bearbeitet wird
    ''' </summary>
    Private _Owner As BusinessObjects.Owner

    ''' <summary>
    ''' Erzeugt einen neuen Dialog
    ''' </summary>
    Public Sub New(ByVal Owner As BusinessObjects.Owner)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Owner = Owner
        oEditOwner.Owner = _Owner
    End Sub

#End Region

#Region " Eventhandler "

    ''' <summary>
    ''' Speichern und schliessen des Dialoges
    ''' </summary>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        _owner.Save()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Schliesst den Dialog ohne zu speichern
    ''' </summary>
    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Speichert das aktuelle Owner und erstellt ein neues
    ''' </summary>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        _owner.Save()
        _owner = New BusinessObjects.Owner
        oEditOwner.Owner = _owner
    End Sub

    ''' <summary>
    ''' Eventhandler des EditOwner-Dialog bei geänderten Fehlerstatus
    ''' </summary>
    Private Sub oEditOwner_StateChanged(ByVal sender As Object, ByVal e As ValidationEventArgs) Handles oEditOwner.StateChanged
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