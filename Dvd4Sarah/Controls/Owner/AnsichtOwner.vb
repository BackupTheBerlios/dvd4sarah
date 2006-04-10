Public Class AnsichtOwner

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oListOwner.List = BusinessObjects.Owner.List()
    End Sub

#Region " Neu, Bearbeiten, Anzeigen, Löschen Events "

    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click
        Dim dlg As New EditOwnerDialog(New BusinessObjects.Owner)
        dlg.Text = "Person hinzufügen"
        dlg.Modus = Enums.EditType.Add

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

        oListOwner.List = BusinessObjects.Owner.List()
    End Sub

    Private Sub btnBearbeiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnBearbeiten.Click, oListOwner.DoubleClick
        If oListOwner.SelectedItem Is Nothing Then Exit Sub

        Dim dlg As New EditOwnerDialog(oListOwner.SelectedItem)
        dlg.Text = "Person bearbeiten"
        dlg.Modus = Enums.EditType.Edit

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            oListOwner.List = BusinessObjects.Owner.List()
        End If
    End Sub

    Private Sub btnLöschen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLöschen.Click
        If oListOwner.SelectedItem Is Nothing Then Exit Sub

        If Basisklassen.MessageDialog.Show(2, oListOwner.SelectedItem.Name) = DialogResult.Yes Then
            oListOwner.SelectedItem.Delete()
            oListOwner.List = BusinessObjects.Owner.List
        End If
    End Sub

    Private Sub btnAnzeigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnzeigen.Click
        If oListOwner.SelectedItem Is Nothing Then Exit Sub

        Dim dlg As New EditOwnerDialog(oListOwner.SelectedItem)
        dlg.Text = "Person anzeigen"
        dlg.Modus = Enums.EditType.View

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

#End Region

End Class
