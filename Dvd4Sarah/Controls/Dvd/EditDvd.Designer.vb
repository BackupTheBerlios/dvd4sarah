<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDvd
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditDvd))
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.bndDvd = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblSubtitle = New System.Windows.Forms.Label
        Me.txtSubtitle = New System.Windows.Forms.TextBox
        Me.lblBesitzer = New System.Windows.Forms.Label
        Me.cmbOwner = New System.Windows.Forms.ComboBox
        Me.bndOwner = New System.Windows.Forms.BindingSource(Me.components)
        Me.pntFelder = New System.Windows.Forms.TableLayoutPanel
        Me.lblFsk = New System.Windows.Forms.Label
        Me.lblGenre = New System.Windows.Forms.Label
        Me.cmbGenre = New System.Windows.Forms.ComboBox
        Me.bndGenre = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbFsk = New System.Windows.Forms.ComboBox
        Me.bndFsk = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDescription = New System.Windows.Forms.Label
        Me.pnlDescription = New System.Windows.Forms.Panel
        Me.rtbDescription = New System.Windows.Forms.RichTextBox
        Me.stripFormat = New System.Windows.Forms.ToolStrip
        Me.sptFelder = New System.Windows.Forms.Splitter
        Me.pnlCover = New System.Windows.Forms.Panel
        Me.pcbCover = New System.Windows.Forms.PictureBox
        Me.stripLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolHinzufügen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolEntfernen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolLogoSep = New System.Windows.Forms.ToolStripSeparator
        Me.toolLogoSizeImage = New System.Windows.Forms.ToolStripMenuItem
        Me.ofdOpenImage = New System.Windows.Forms.OpenFileDialog
        Me.oControlValidator = New Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator(Me.components)
        Me.oLengthValidator = New Softwarekueche.Dvd4Sarah.Validation.LengthValidator(Me.components)
        Me.errError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.bndDvd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pntFelder.SuspendLayout()
        CType(Me.bndGenre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndFsk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDescription.SuspendLayout()
        Me.pnlCover.SuspendLayout()
        CType(Me.pcbCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stripLogo.SuspendLayout()
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        resources.ApplyResources(Me.txtTitle, "txtTitle")
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndDvd, "Title", True))
        Me.txtTitle.Name = "txtTitle"
        Me.oControlValidator.SetValidator(Me.txtTitle, Me.oLengthValidator)
        '
        'bndDvd
        '
        Me.bndDvd.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.Dvd)
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        '
        'lblSubtitle
        '
        resources.ApplyResources(Me.lblSubtitle, "lblSubtitle")
        Me.lblSubtitle.Name = "lblSubtitle"
        '
        'txtSubtitle
        '
        resources.ApplyResources(Me.txtSubtitle, "txtSubtitle")
        Me.txtSubtitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndDvd, "Subtitle", True))
        Me.txtSubtitle.Name = "txtSubtitle"
        '
        'lblBesitzer
        '
        resources.ApplyResources(Me.lblBesitzer, "lblBesitzer")
        Me.lblBesitzer.Name = "lblBesitzer"
        '
        'cmbOwner
        '
        resources.ApplyResources(Me.cmbOwner, "cmbOwner")
        Me.cmbOwner.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bndDvd, "Owner", True))
        Me.cmbOwner.DataSource = Me.bndOwner
        Me.cmbOwner.DisplayMember = "Name"
        Me.cmbOwner.FormattingEnabled = True
        Me.cmbOwner.Name = "cmbOwner"
        '
        'bndOwner
        '
        Me.bndOwner.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.Owner)
        Me.bndOwner.Filter = "isEigentümer = true"
        Me.bndOwner.Sort = "Name"
        '
        'pntFelder
        '
        resources.ApplyResources(Me.pntFelder, "pntFelder")
        Me.pntFelder.Controls.Add(Me.lblFsk, 0, 4)
        Me.pntFelder.Controls.Add(Me.lblGenre, 0, 3)
        Me.pntFelder.Controls.Add(Me.lblTitle, 0, 0)
        Me.pntFelder.Controls.Add(Me.lblSubtitle, 0, 1)
        Me.pntFelder.Controls.Add(Me.cmbOwner, 1, 2)
        Me.pntFelder.Controls.Add(Me.lblBesitzer, 0, 2)
        Me.pntFelder.Controls.Add(Me.txtSubtitle, 1, 1)
        Me.pntFelder.Controls.Add(Me.txtTitle, 1, 0)
        Me.pntFelder.Controls.Add(Me.cmbGenre, 1, 3)
        Me.pntFelder.Controls.Add(Me.cmbFsk, 1, 4)
        Me.pntFelder.Controls.Add(Me.lblDescription, 0, 5)
        Me.pntFelder.Controls.Add(Me.pnlDescription, 1, 5)
        Me.pntFelder.Name = "pntFelder"
        '
        'lblFsk
        '
        resources.ApplyResources(Me.lblFsk, "lblFsk")
        Me.lblFsk.Name = "lblFsk"
        '
        'lblGenre
        '
        resources.ApplyResources(Me.lblGenre, "lblGenre")
        Me.lblGenre.Name = "lblGenre"
        '
        'cmbGenre
        '
        resources.ApplyResources(Me.cmbGenre, "cmbGenre")
        Me.cmbGenre.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bndDvd, "Genre", True))
        Me.cmbGenre.DataSource = Me.bndGenre
        Me.cmbGenre.DisplayMember = "Name"
        Me.cmbGenre.FormattingEnabled = True
        Me.cmbGenre.Name = "cmbGenre"
        '
        'bndGenre
        '
        Me.bndGenre.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.Genre)
        Me.bndGenre.Sort = "Name"
        '
        'cmbFsk
        '
        resources.ApplyResources(Me.cmbFsk, "cmbFsk")
        Me.cmbFsk.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bndDvd, "FSK", True))
        Me.cmbFsk.DataSource = Me.bndFsk
        Me.cmbFsk.DisplayMember = "Name"
        Me.cmbFsk.FormattingEnabled = True
        Me.cmbFsk.Name = "cmbFsk"
        '
        'bndFsk
        '
        Me.bndFsk.AllowNew = False
        Me.bndFsk.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.FSK)
        Me.bndFsk.Sort = "MinAlter"
        '
        'lblDescription
        '
        resources.ApplyResources(Me.lblDescription, "lblDescription")
        Me.lblDescription.Name = "lblDescription"
        '
        'pnlDescription
        '
        Me.pnlDescription.Controls.Add(Me.rtbDescription)
        Me.pnlDescription.Controls.Add(Me.stripFormat)
        resources.ApplyResources(Me.pnlDescription, "pnlDescription")
        Me.pnlDescription.Name = "pnlDescription"
        '
        'rtbDescription
        '
        Me.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.rtbDescription, "rtbDescription")
        Me.rtbDescription.Name = "rtbDescription"
        '
        'stripFormat
        '
        Me.stripFormat.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        resources.ApplyResources(Me.stripFormat, "stripFormat")
        Me.stripFormat.Name = "stripFormat"
        '
        'sptFelder
        '
        resources.ApplyResources(Me.sptFelder, "sptFelder")
        Me.sptFelder.Name = "sptFelder"
        Me.sptFelder.TabStop = False
        '
        'pnlCover
        '
        Me.pnlCover.Controls.Add(Me.pcbCover)
        resources.ApplyResources(Me.pnlCover, "pnlCover")
        Me.pnlCover.Name = "pnlCover"
        '
        'pcbCover
        '
        Me.pcbCover.BackColor = System.Drawing.SystemColors.Window
        Me.pcbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbCover.ContextMenuStrip = Me.stripLogo
        Me.pcbCover.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.bndDvd, "Cover", True))
        resources.ApplyResources(Me.pcbCover, "pcbCover")
        Me.pcbCover.Name = "pcbCover"
        Me.pcbCover.TabStop = False
        '
        'stripLogo
        '
        Me.stripLogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolHinzufügen, Me.toolEntfernen, Me.toolLogoSep, Me.toolLogoSizeImage})
        Me.stripLogo.Name = "StripCover"
        resources.ApplyResources(Me.stripLogo, "stripLogo")
        '
        'toolHinzufügen
        '
        Me.toolHinzufügen.Name = "toolHinzufügen"
        resources.ApplyResources(Me.toolHinzufügen, "toolHinzufügen")
        '
        'toolEntfernen
        '
        Me.toolEntfernen.Name = "toolEntfernen"
        resources.ApplyResources(Me.toolEntfernen, "toolEntfernen")
        '
        'toolLogoSep
        '
        Me.toolLogoSep.Name = "toolLogoSep"
        resources.ApplyResources(Me.toolLogoSep, "toolLogoSep")
        '
        'toolLogoSizeImage
        '
        Me.toolLogoSizeImage.Checked = True
        Me.toolLogoSizeImage.CheckOnClick = True
        Me.toolLogoSizeImage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toolLogoSizeImage.Name = "toolLogoSizeImage"
        resources.ApplyResources(Me.toolLogoSizeImage, "toolLogoSizeImage")
        '
        'ofdOpenImage
        '
        resources.ApplyResources(Me.ofdOpenImage, "ofdOpenImage")
        Me.ofdOpenImage.RestoreDirectory = True
        '
        'oControlValidator
        '
        Me.oControlValidator.DefaultApplicationData = Nothing
        Me.oControlValidator.Visualizer = Me.errError
        '
        'oLengthValidator
        '
        Me.oLengthValidator.MaximumLength = 0
        Me.oLengthValidator.MinimumLength = 1
        '
        'errError
        '
        Me.errError.ContainerControl = Me
        '
        'EditDvd
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlCover)
        Me.Controls.Add(Me.sptFelder)
        Me.Controls.Add(Me.pntFelder)
        Me.Name = "EditDvd"
        CType(Me.bndDvd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndOwner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pntFelder.ResumeLayout(False)
        Me.pntFelder.PerformLayout()
        CType(Me.bndGenre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndFsk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDescription.ResumeLayout(False)
        Me.pnlDescription.PerformLayout()
        Me.pnlCover.ResumeLayout(False)
        CType(Me.pcbCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stripLogo.ResumeLayout(False)
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents txtSubtitle As System.Windows.Forms.TextBox
    Friend WithEvents lblBesitzer As System.Windows.Forms.Label
    Friend WithEvents cmbOwner As System.Windows.Forms.ComboBox
    Private WithEvents bndDvd As System.Windows.Forms.BindingSource
    Private WithEvents bndOwner As System.Windows.Forms.BindingSource
    Friend WithEvents pntFelder As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents sptFelder As System.Windows.Forms.Splitter
    Private WithEvents bndGenre As System.Windows.Forms.BindingSource
    Friend WithEvents lblFsk As System.Windows.Forms.Label
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents cmbGenre As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFsk As System.Windows.Forms.ComboBox
    Private WithEvents bndFsk As System.Windows.Forms.BindingSource
    Friend WithEvents pnlCover As System.Windows.Forms.Panel
    Friend WithEvents pcbCover As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents pnlDescription As System.Windows.Forms.Panel
    Friend WithEvents rtbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents stripFormat As System.Windows.Forms.ToolStrip
    Friend WithEvents stripLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolHinzufügen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolEntfernen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolLogoSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolLogoSizeImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents oControlValidator As Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator
    Friend WithEvents errError As System.Windows.Forms.ErrorProvider
    Friend WithEvents oLengthValidator As Softwarekueche.Dvd4Sarah.Validation.LengthValidator

End Class
