Public Class AnsichtDvd

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oListDvd.List = BusinessObjects.Dvd.List()
    End Sub

#Region " Neu, Bearbeiten, Anzeigen, Löschen Events "

    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click
        Dim dlg As New EditDvdDialog(New BusinessObjects.Dvd)
        dlg.Text = "Dvd hinzufügen"
        dlg.Modus = Enums.EditType.Add

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

        oListDvd.List = BusinessObjects.Dvd.List()
    End Sub

    Private Sub btnBearbeiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnBearbeiten.Click, oListDvd.DoubleClick
        If oListDvd.SelectedItem Is Nothing Then Exit Sub

        Dim dlg As New EditDvdDialog(oListDvd.SelectedItem)
        dlg.Text = "Dvd bearbeiten"
        dlg.Modus = Enums.EditType.Edit

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            oListDvd.List = BusinessObjects.Dvd.List()
        End If
    End Sub

    Private Sub btnLöschen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLöschen.Click
        If oListDvd.SelectedItem Is Nothing Then Exit Sub

        If Basisklassen.MessageDialog.Show(1, oListDvd.SelectedItem.Title) = DialogResult.Yes Then
            oListDvd.SelectedItem.Delete()
            oListDvd.List = BusinessObjects.Dvd.List
        End If
    End Sub

    Private Sub btnAnzeigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnzeigen.Click
        If oListDvd.SelectedItem Is Nothing Then Exit Sub

        Dim dlg As New EditDvdDialog(oListDvd.SelectedItem)
        dlg.Text = "Dvd anzeigen"
        dlg.Modus = Enums.EditType.View

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

#End Region

End Class
