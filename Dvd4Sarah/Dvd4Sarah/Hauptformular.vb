
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' <!-- ProgramName --> - <!-- ProgramWeb -->
' Copyright (C) <!-- ProgramYear -->  <!-- ProgramAuthor -->
'
' This program is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 2 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program; if not, write to the Free Software
' Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports Softwarekueche.Dvd4Sarah.Basisklassen
Imports Softwarekueche.Dvd4Sarah.Basisklassen.AnsichtTyp

Public Class Hauptformular

#Region " Konstruktor "

    Private _fileName As String

    Public Sub New()
        InitializeComponent()
        sfdNew.InitialDirectory = Application.StartupPath
        ofdOpen.InitialDirectory = Application.StartupPath

        UnInit()
        CreateListView()
    End Sub

#End Region

#Region " Liste mit 'Ansichten' erstellen "

    Public Sub CreateListView()
        ' Imageliste definieren
        Dim imlListe As New ImageList
        imlListe.ImageSize = New Size(30, 30)

        ' Gruppe und Item definieren
        Dim itm As ListViewItemAnsicht
        Dim grp As ListViewGroup
        Dim key As String
        lsvAnsichten.LargeImageList = imlListe

        ' Stammdaten
        grp = New ListViewGroup("Stammdaten", "Stammdaten")
        lsvAnsichten.Groups.Add(grp)

        ' Liste mit DVDs
        key = "DVDs"
        imlListe.Images.Add(key, My.Resources.DvdList)
        itm = New ListViewItemAnsicht
        itm.Ansicht = DVDs
        itm.Text = key
        itm.ImageKey = key
        itm.Group = grp
        lsvAnsichten.Items.Add(itm)

        ' Liste mit Personen
        key = "Personen"
        imlListe.Images.Add(key, My.Resources.OwnerList)
        itm = New ListViewItemAnsicht
        itm.Ansicht = Personen
        itm.Text = key
        itm.ImageKey = key
        itm.Group = grp
        lsvAnsichten.Items.Add(itm)

        ' Liste mit FSK Stufen
        key = "FSK"
        imlListe.Images.Add(key, My.Resources.FskList)
        itm = New ListViewItemAnsicht
        itm.Ansicht = FSK
        itm.Text = key
        itm.ImageKey = key
        itm.Group = grp
        lsvAnsichten.Items.Add(itm)

        ' Liste mit Genres
        key = "Genre"
        imlListe.Images.Add(key, My.Resources.GenreList)
        itm = New ListViewItemAnsicht
        itm.Ansicht = Genre
        itm.Text = key
        itm.ImageKey = key
        itm.Group = grp
        lsvAnsichten.Items.Add(itm)

        ' Auswertung
        grp = New ListViewGroup("Statistik", "Statistik")
        lsvAnsichten.Groups.Add(grp)

        ' DVD Verleih
        key = "Verleih"
        imlListe.Images.Add(key, My.Resources.VerleihList)
        itm = New ListViewItemAnsicht
        itm.Ansicht = Verleih
        itm.Text = key
        itm.ImageKey = key
        itm.Group = grp
        ' TODO lsvAnsichten.Items.Add(itm)

    End Sub

#End Region

#Region " Initialisieren und Deinitialisieren "

    Private Sub Init(ByVal fileName As String)
        _fileName = fileName
        BusinessObjects.BoBase.Init(New BusinessObjects.Db4oPersister(fileName))
        tscMain.ContentPanel.Visible = True
        lsvAnsichten.SelectedItems.Clear()
        toolAnsicht.Enabled = True
    End Sub

    Public Sub UnInit()
        _fileName = Nothing
        pnlAnsicht.Controls.Clear()
        BusinessObjects.BoBase.UnInit()
        tscMain.ContentPanel.Visible = False
        lsvAnsichten.SelectedItems.Clear()
        toolAnsicht.Enabled = False
    End Sub

#End Region

#Region " Ansichten wechseln "

    Private Sub lsvAnsichten_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvAnsichten.SelectedIndexChanged
        If lsvAnsichten.SelectedItems.Count = 0 Then Exit Sub

        SelectAnsicht(CType(lsvAnsichten.SelectedItems(0), ListViewItemAnsicht).Ansicht)
    End Sub

    Private Sub SelectAnsicht(ByVal oselected As AnsichtTyp)
        If oselected = AnsichtTyp.DVDs Then
            If Not pnlAnsicht.Controls.Count = 0 AndAlso TypeOf pnlAnsicht.Controls(0) Is Controls.AnsichtDvd Then Exit Sub
            pnlAnsicht.Controls.Clear()
            pnlAnsicht.Controls.Add(New Controls.AnsichtDvd())
            pnlAnsicht.Controls(0).Dock = DockStyle.Fill

        ElseIf oselected = AnsichtTyp.Personen Then
            If Not pnlAnsicht.Controls.Count = 0 AndAlso TypeOf pnlAnsicht.Controls(0) Is Controls.AnsichtOwner Then Exit Sub
            pnlAnsicht.Controls.Clear()
            pnlAnsicht.Controls.Add(New Controls.AnsichtOwner())
            pnlAnsicht.Controls(0).Dock = DockStyle.Fill

        ElseIf oselected = AnsichtTyp.FSK Then
            If Not pnlAnsicht.Controls.Count = 0 AndAlso TypeOf pnlAnsicht.Controls(0) Is Controls.AnsichtFsk Then Exit Sub
            pnlAnsicht.Controls.Clear()
            pnlAnsicht.Controls.Add(New Controls.AnsichtFsk())
            pnlAnsicht.Controls(0).Dock = DockStyle.Fill

        ElseIf oselected = AnsichtTyp.Genre Then
            If Not pnlAnsicht.Controls.Count = 0 AndAlso TypeOf pnlAnsicht.Controls(0) Is Controls.AnsichtGenre Then Exit Sub
            pnlAnsicht.Controls.Clear()
            pnlAnsicht.Controls.Add(New Controls.AnsichtGenre())
            pnlAnsicht.Controls(0).Dock = DockStyle.Fill

        ElseIf oselected = AnsichtTyp.Verleih Then
            If Not pnlAnsicht.Controls.Count = 0 AndAlso TypeOf pnlAnsicht.Controls(0) Is Controls.AnsichtDistribute Then Exit Sub
            pnlAnsicht.Controls.Clear()
            pnlAnsicht.Controls.Add(New Controls.AnsichtDistribute())
            pnlAnsicht.Controls(0).Dock = DockStyle.Fill

        End If
    End Sub

#End Region

#Region " Form Eventhandler "

    Private Sub Hauptformular_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        BusinessObjects.BoBase.UnInit()
    End Sub

#End Region

#Region " Menü Datei Eventhandler "

    Public Sub DateiÖffnen(ByVal file As String)
        UnInit()
        Init(file)
    End Sub

    Private Sub ToolDateiBeenden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolDateiBeenden.Click
        Me.Close()
    End Sub

    Private Sub ToolDateiNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolDateiNeu.Click
        If sfdNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            UnInit()
            Init(sfdNew.FileName)
        End If
    End Sub

    Private Sub ToolDateiÖffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolDateiÖffnen.Click
        If ofdOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            DateiÖffnen(ofdOpen.FileName)
        End If
    End Sub

    Private Sub toolDateiSchliessen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolDateiSchliessen.Click
        UnInit()
    End Sub

#End Region

#Region " Menü Ansichten Eventhandler "

    Private Sub toolAnsichtDvd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolAnsichtDvd.Click
        SelectAnsicht(DVDs)
    End Sub

    Private Sub toolAnsichtOwner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolAnsichtOwner.Click
        SelectAnsicht(Personen)
    End Sub

    Private Sub toolAnsichtFsk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolAnsichtFsk.Click
        SelectAnsicht(FSK)
    End Sub

    Private Sub toolAnsichtGenre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolAnsichtGenre.Click
        SelectAnsicht(Genre)
    End Sub

#End Region

#Region " Menü Tools Eventhandler "

    Private Sub toolToolsDatenbankDefragmentieren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolToolsDatenbankDefragmentieren.Click
        ' TODO Grössenänderung, Infobox mit status? Backup?

        Dim oldTitle As String = ofdOpen.Title
        ofdOpen.Title = "Datenbank zum Defragmentieren wählen"
        If ofdOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            If String.Compare(BusinessObjects.BoBase.FileName, ofdOpen.FileName, True) = 0 Then
                MessageBox.Show("Datei ist geöffnet und kann daher nicht Defragmentiert werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Exit Sub
            End If
            Dim oDef As New com.db4o.tools.Defragment
            oDef.Run(ofdOpen.FileName, False)
        End If
    End Sub

#End Region

#Region " Menü Hilfe Eventhandler "

    Private singletonHelpBox As BrowserBox

    Private Sub toolHilfeHilfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolHilfeHilfe.Click
        If singletonHelpBox Is Nothing Then singletonHelpBox = New BrowserBox
        singletonHelpBox.Show()
    End Sub

    Private Sub toolHilfeLizenz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolHilfeLizenz.Click
        Dim f As New Basisklassen.LizenzBox
        f.ShowDialog()
    End Sub

    Private Sub toolHilfeInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolHilfeInfo.Click

    End Sub

#End Region

End Class