
Public Class AnsichtFsk

#Region " Konstruktor "

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oListFsk.List = BusinessObjects.FSK.List()
        oListFsk.Sort = "MinAlter"
    End Sub

#End Region

#Region " Neu, Bearbeiten, Anzeigen, Löschen Events "

    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click
        Dim dlg As New EditFskDialog(New BusinessObjects.FSK)
        dlg.Text = "Altersfreigabe hinzufügen"
        dlg.Modus = Enums.EditType.Add

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

        oListFsk.List = BusinessObjects.FSK.List()
    End Sub

    Private Sub btnBearbeiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnBearbeiten.Click, oListFsk.DoubleClick
        If oListFsk.SelectedItem Is Nothing Then Exit Sub

        Dim dlg As New EditFskDialog(oListFsk.SelectedItem)
        dlg.Text = "Altersfreigabe bearbeiten"
        dlg.Modus = Enums.EditType.Edit

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            oListFsk.List = BusinessObjects.FSK.List()
        End If
    End Sub

    Private Sub btnLöschen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLöschen.Click
        If oListFsk.SelectedItem Is Nothing Then Exit Sub

        If Basisklassen.MessageDialog.Show(3, oListFsk.SelectedItem.Name) = DialogResult.Yes Then
            oListFsk.SelectedItem.Delete()
            oListFsk.List = BusinessObjects.FSK.List
        End If
    End Sub

    Private Sub btnAnzeigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnzeigen.Click
        If oListFsk.SelectedItem Is Nothing Then Exit Sub

        Dim dlg As New EditFskDialog(oListFsk.SelectedItem)
        dlg.Text = "Altersfreigabe anzeigen"
        dlg.Modus = Enums.EditType.View

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

#End Region

End Class
