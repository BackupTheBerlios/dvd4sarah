Public Class AnsichtGenre

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oListGenre.List = BusinessObjects.Genre.List()
    End Sub

#Region " Neu, Bearbeiten, Anzeigen, Löschen Events "

    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click
        Dim dlg As New EditGenreDialog(New BusinessObjects.Genre)
        dlg.Text = "Genre hinzufügen"
        dlg.Modus = Enums.EditType.Add

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

        oListGenre.List = BusinessObjects.Genre.List()
    End Sub

    Private Sub btnBearbeiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnBearbeiten.Click, oListGenre.DoubleClick
        If oListGenre.SelectedItem Is Nothing Then Exit Sub

        Dim dlg As New EditGenreDialog(oListGenre.SelectedItem)
        dlg.Text = "Genre bearbeiten"
        dlg.Modus = Enums.EditType.Edit

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            oListGenre.List = BusinessObjects.Genre.List()
        End If
    End Sub

    Private Sub btnLöschen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLöschen.Click
        If oListGenre.SelectedItem Is Nothing Then Exit Sub

        If Basisklassen.MessageDialog.Show(4, oListGenre.SelectedItem.Name) = DialogResult.Yes Then
            oListGenre.SelectedItem.Delete()
            oListGenre.List = BusinessObjects.Genre.List
        End If
    End Sub

    Private Sub btnAnzeigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnzeigen.Click
        If oListGenre.SelectedItem Is Nothing Then Exit Sub

        Dim dlg As New EditGenreDialog(oListGenre.SelectedItem)
        dlg.Text = "Genre anzeigen"
        dlg.Modus = Enums.EditType.View

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

#End Region

End Class
