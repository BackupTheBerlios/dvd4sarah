<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hauptformular
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Übersicht", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hauptformular))
        Me.stripMenü = New System.Windows.Forms.MenuStrip
        Me.toolDatei = New System.Windows.Forms.ToolStripMenuItem
        Me.toolDateiNeu = New System.Windows.Forms.ToolStripMenuItem
        Me.toolDateiÖffnen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolDateiSchliessen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolDateiSep0 = New System.Windows.Forms.ToolStripSeparator
        Me.toolDateiBeenden = New System.Windows.Forms.ToolStripMenuItem
        Me.toolAnsicht = New System.Windows.Forms.ToolStripMenuItem
        Me.toolAnsichtDvd = New System.Windows.Forms.ToolStripMenuItem
        Me.toolAnsichtOwner = New System.Windows.Forms.ToolStripMenuItem
        Me.toolAnsichtFsk = New System.Windows.Forms.ToolStripMenuItem
        Me.toolAnsichtGenre = New System.Windows.Forms.ToolStripMenuItem
        Me.toolAnsichtSep0 = New System.Windows.Forms.ToolStripSeparator
        Me.toolTools = New System.Windows.Forms.ToolStripMenuItem
        Me.toolToolsDatenbank = New System.Windows.Forms.ToolStripMenuItem
        Me.toolToolsDatenbankDefragmentieren = New System.Windows.Forms.ToolStripMenuItem
        Me.toolHilfe = New System.Windows.Forms.ToolStripMenuItem
        Me.toolHilfeHilfe = New System.Windows.Forms.ToolStripMenuItem
        Me.toolHilfeLizenz = New System.Windows.Forms.ToolStripMenuItem
        Me.toolHilfeSep0 = New System.Windows.Forms.ToolStripSeparator
        Me.toolHilfeInfo = New System.Windows.Forms.ToolStripMenuItem
        Me.stripStatus = New System.Windows.Forms.StatusStrip
        Me.tscMain = New System.Windows.Forms.ToolStripContainer
        Me.pnlAnsicht = New System.Windows.Forms.Panel
        Me.sptAnsichten = New System.Windows.Forms.Splitter
        Me.lsvAnsichten = New System.Windows.Forms.ListView
        Me.sfdNew = New System.Windows.Forms.SaveFileDialog
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog
        Me.stripMenü.SuspendLayout()
        Me.tscMain.ContentPanel.SuspendLayout()
        Me.tscMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'stripMenü
        '
        Me.stripMenü.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolDatei, Me.toolAnsicht, Me.toolTools, Me.toolHilfe})
        Me.stripMenü.Location = New System.Drawing.Point(0, 0)
        Me.stripMenü.Name = "stripMenü"
        Me.stripMenü.Size = New System.Drawing.Size(679, 24)
        Me.stripMenü.TabIndex = 0
        Me.stripMenü.Text = "MenuStrip1"
        '
        'toolDatei
        '
        Me.toolDatei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolDateiNeu, Me.toolDateiÖffnen, Me.toolDateiSchliessen, Me.toolDateiSep0, Me.toolDateiBeenden})
        Me.toolDatei.Name = "toolDatei"
        Me.toolDatei.Size = New System.Drawing.Size(44, 20)
        Me.toolDatei.Text = "&Datei"
        '
        'toolDateiNeu
        '
        Me.toolDateiNeu.Name = "toolDateiNeu"
        Me.toolDateiNeu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.toolDateiNeu.Size = New System.Drawing.Size(171, 22)
        Me.toolDateiNeu.Text = "&Neu..."
        '
        'toolDateiÖffnen
        '
        Me.toolDateiÖffnen.Name = "toolDateiÖffnen"
        Me.toolDateiÖffnen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.toolDateiÖffnen.Size = New System.Drawing.Size(171, 22)
        Me.toolDateiÖffnen.Text = "Ö&ffnen..."
        '
        'toolDateiSchliessen
        '
        Me.toolDateiSchliessen.Name = "toolDateiSchliessen"
        Me.toolDateiSchliessen.Size = New System.Drawing.Size(171, 22)
        Me.toolDateiSchliessen.Text = "S&chließen"
        '
        'toolDateiSep0
        '
        Me.toolDateiSep0.Name = "toolDateiSep0"
        Me.toolDateiSep0.Size = New System.Drawing.Size(168, 6)
        '
        'toolDateiBeenden
        '
        Me.toolDateiBeenden.Name = "toolDateiBeenden"
        Me.toolDateiBeenden.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.toolDateiBeenden.Size = New System.Drawing.Size(171, 22)
        Me.toolDateiBeenden.Text = "&Beenden"
        '
        'toolAnsicht
        '
        Me.toolAnsicht.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolAnsichtDvd, Me.toolAnsichtOwner, Me.toolAnsichtFsk, Me.toolAnsichtGenre, Me.toolAnsichtSep0})
        Me.toolAnsicht.Name = "toolAnsicht"
        Me.toolAnsicht.Size = New System.Drawing.Size(54, 20)
        Me.toolAnsicht.Text = "&Ansicht"
        '
        'toolAnsichtDvd
        '
        Me.toolAnsichtDvd.Image = Global.Softwarekueche.Dvd4Sarah.My.Resources.Resources.DvdList
        Me.toolAnsichtDvd.Name = "toolAnsichtDvd"
        Me.toolAnsichtDvd.Size = New System.Drawing.Size(169, 22)
        Me.toolAnsichtDvd.Text = "&DVDs"
        '
        'toolAnsichtOwner
        '
        Me.toolAnsichtOwner.Image = Global.Softwarekueche.Dvd4Sarah.My.Resources.Resources.OwnerList
        Me.toolAnsichtOwner.Name = "toolAnsichtOwner"
        Me.toolAnsichtOwner.Size = New System.Drawing.Size(169, 22)
        Me.toolAnsichtOwner.Text = "&Besitzer"
        '
        'toolAnsichtFsk
        '
        Me.toolAnsichtFsk.Image = Global.Softwarekueche.Dvd4Sarah.My.Resources.Resources.FskList
        Me.toolAnsichtFsk.Name = "toolAnsichtFsk"
        Me.toolAnsichtFsk.Size = New System.Drawing.Size(169, 22)
        Me.toolAnsichtFsk.Text = "&FSK Einstufungen"
        '
        'toolAnsichtGenre
        '
        Me.toolAnsichtGenre.Image = Global.Softwarekueche.Dvd4Sarah.My.Resources.Resources.GenreList
        Me.toolAnsichtGenre.Name = "toolAnsichtGenre"
        Me.toolAnsichtGenre.Size = New System.Drawing.Size(169, 22)
        Me.toolAnsichtGenre.Text = "&Genres"
        '
        'toolAnsichtSep0
        '
        Me.toolAnsichtSep0.Name = "toolAnsichtSep0"
        Me.toolAnsichtSep0.Size = New System.Drawing.Size(166, 6)
        '
        'toolTools
        '
        Me.toolTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolToolsDatenbank})
        Me.toolTools.Name = "toolTools"
        Me.toolTools.Size = New System.Drawing.Size(44, 20)
        Me.toolTools.Text = "&Tools"
        '
        'toolToolsDatenbank
        '
        Me.toolToolsDatenbank.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolToolsDatenbankDefragmentieren})
        Me.toolToolsDatenbank.Name = "toolToolsDatenbank"
        Me.toolToolsDatenbank.Size = New System.Drawing.Size(152, 22)
        Me.toolToolsDatenbank.Text = "&Datenbank"
        '
        'toolToolsDatenbankDefragmentieren
        '
        Me.toolToolsDatenbankDefragmentieren.Name = "toolToolsDatenbankDefragmentieren"
        Me.toolToolsDatenbankDefragmentieren.Size = New System.Drawing.Size(166, 22)
        Me.toolToolsDatenbankDefragmentieren.Text = "&Defragmentieren"
        '
        'toolHilfe
        '
        Me.toolHilfe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolHilfeHilfe, Me.toolHilfeLizenz, Me.toolHilfeSep0, Me.toolHilfeInfo})
        Me.toolHilfe.Name = "toolHilfe"
        Me.toolHilfe.Size = New System.Drawing.Size(40, 20)
        Me.toolHilfe.Text = "&Hilfe"
        '
        'toolHilfeHilfe
        '
        Me.toolHilfeHilfe.Name = "toolHilfeHilfe"
        Me.toolHilfeHilfe.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.toolHilfeHilfe.Size = New System.Drawing.Size(152, 22)
        Me.toolHilfeHilfe.Text = "&Hilfe..."
        '
        'toolHilfeLizenz
        '
        Me.toolHilfeLizenz.Name = "toolHilfeLizenz"
        Me.toolHilfeLizenz.Size = New System.Drawing.Size(152, 22)
        Me.toolHilfeLizenz.Text = "&Lizenz..."
        '
        'toolHilfeSep0
        '
        Me.toolHilfeSep0.Name = "toolHilfeSep0"
        Me.toolHilfeSep0.Size = New System.Drawing.Size(149, 6)
        '
        'toolHilfeInfo
        '
        Me.toolHilfeInfo.Name = "toolHilfeInfo"
        Me.toolHilfeInfo.Size = New System.Drawing.Size(152, 22)
        Me.toolHilfeInfo.Text = "Info..."
        '
        'stripStatus
        '
        Me.stripStatus.Location = New System.Drawing.Point(0, 526)
        Me.stripStatus.Name = "stripStatus"
        Me.stripStatus.Size = New System.Drawing.Size(679, 22)
        Me.stripStatus.TabIndex = 1
        Me.stripStatus.Text = "StatusStrip1"
        '
        'tscMain
        '
        '
        'tscMain.ContentPanel
        '
        Me.tscMain.ContentPanel.Controls.Add(Me.pnlAnsicht)
        Me.tscMain.ContentPanel.Controls.Add(Me.sptAnsichten)
        Me.tscMain.ContentPanel.Controls.Add(Me.lsvAnsichten)
        Me.tscMain.ContentPanel.Size = New System.Drawing.Size(679, 477)
        Me.tscMain.ContentPanel.Visible = False
        Me.tscMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tscMain.Location = New System.Drawing.Point(0, 24)
        Me.tscMain.Name = "tscMain"
        Me.tscMain.Size = New System.Drawing.Size(679, 502)
        Me.tscMain.TabIndex = 2
        Me.tscMain.Text = "tscMain"
        '
        'pnlAnsicht
        '
        Me.pnlAnsicht.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAnsicht.Location = New System.Drawing.Point(170, 0)
        Me.pnlAnsicht.Name = "pnlAnsicht"
        Me.pnlAnsicht.Size = New System.Drawing.Size(509, 477)
        Me.pnlAnsicht.TabIndex = 2
        '
        'sptAnsichten
        '
        Me.sptAnsichten.Location = New System.Drawing.Point(167, 0)
        Me.sptAnsichten.Name = "sptAnsichten"
        Me.sptAnsichten.Size = New System.Drawing.Size(3, 477)
        Me.sptAnsichten.TabIndex = 1
        Me.sptAnsichten.TabStop = False
        '
        'lsvAnsichten
        '
        Me.lsvAnsichten.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lsvAnsichten.Dock = System.Windows.Forms.DockStyle.Left
        ListViewGroup1.Header = "Übersicht"
        ListViewGroup1.Name = "lsgÜbersicht"
        Me.lsvAnsichten.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lsvAnsichten.Location = New System.Drawing.Point(0, 0)
        Me.lsvAnsichten.MultiSelect = False
        Me.lsvAnsichten.Name = "lsvAnsichten"
        Me.lsvAnsichten.Scrollable = False
        Me.lsvAnsichten.Size = New System.Drawing.Size(167, 477)
        Me.lsvAnsichten.TabIndex = 0
        Me.lsvAnsichten.UseCompatibleStateImageBehavior = False
        '
        'sfdNew
        '
        Me.sfdNew.DefaultExt = "Dvd4Sarah"
        Me.sfdNew.Filter = "Dvd4Sarah Dateien|*.Dvd4Sarah|Alle Dateien|*.*"
        '
        'ofdOpen
        '
        Me.ofdOpen.DefaultExt = "Dvd4Sarah"
        Me.ofdOpen.Filter = "Dvd4Sarah Dateien|*.Dvd4Sarah|Alle Dateien|*.*"
        '
        'Hauptformular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 548)
        Me.Controls.Add(Me.tscMain)
        Me.Controls.Add(Me.stripStatus)
        Me.Controls.Add(Me.stripMenü)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.stripMenü
        Me.Name = "Hauptformular"
        Me.Text = "[DVD4Sarah]"
        Me.stripMenü.ResumeLayout(False)
        Me.stripMenü.PerformLayout()
        Me.tscMain.ContentPanel.ResumeLayout(False)
        Me.tscMain.ResumeLayout(False)
        Me.tscMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stripMenü As System.Windows.Forms.MenuStrip
    Friend WithEvents stripStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents tscMain As System.Windows.Forms.ToolStripContainer
    Friend WithEvents toolDatei As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolDateiNeu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolDateiÖffnen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolDateiSep0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolDateiBeenden As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfdNew As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlAnsicht As System.Windows.Forms.Panel
    Friend WithEvents sptAnsichten As System.Windows.Forms.Splitter
    Friend WithEvents lsvAnsichten As System.Windows.Forms.ListView
    Friend WithEvents toolAnsicht As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolAnsichtDvd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolAnsichtOwner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolAnsichtFsk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolAnsichtGenre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolAnsichtSep0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolToolsDatenbank As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolToolsDatenbankDefragmentieren As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolDateiSchliessen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolHilfe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolHilfeHilfe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolHilfeLizenz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolHilfeSep0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolHilfeInfo As System.Windows.Forms.ToolStripMenuItem
End Class
