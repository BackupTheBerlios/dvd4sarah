<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditOwner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditOwner))
        Me.pntFelder = New System.Windows.Forms.TableLayoutPanel
        Me.lblAdresse = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblMail = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.bndOwner = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.lblEigentümer = New System.Windows.Forms.Label
        Me.chkEigentümer = New System.Windows.Forms.CheckBox
        Me.txtAdresse = New System.Windows.Forms.TextBox
        Me.pnlLogo = New System.Windows.Forms.Panel
        Me.pcbLogo = New System.Windows.Forms.PictureBox
        Me.stripLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolHinzufügen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolEntfernen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolLogoSep = New System.Windows.Forms.ToolStripSeparator
        Me.toolLogoSizeImage = New System.Windows.Forms.ToolStripMenuItem
        Me.ofdOpenImage = New System.Windows.Forms.OpenFileDialog
        Me.sptFelder = New System.Windows.Forms.Splitter
        Me.oLengthValidator = New Softwarekueche.Dvd4Sarah.Validation.LengthValidator(Me.components)
        Me.oControlValidator = New Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator(Me.components)
        Me.errError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pntFelder.SuspendLayout()
        CType(Me.bndOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogo.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stripLogo.SuspendLayout()
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pntFelder
        '
        resources.ApplyResources(Me.pntFelder, "pntFelder")
        Me.pntFelder.Controls.Add(Me.lblAdresse, 0, 3)
        Me.pntFelder.Controls.Add(Me.lblName, 0, 0)
        Me.pntFelder.Controls.Add(Me.lblMail, 0, 1)
        Me.pntFelder.Controls.Add(Me.txtName, 1, 0)
        Me.pntFelder.Controls.Add(Me.txtMail, 1, 1)
        Me.pntFelder.Controls.Add(Me.lblEigentümer, 0, 2)
        Me.pntFelder.Controls.Add(Me.chkEigentümer, 1, 2)
        Me.pntFelder.Controls.Add(Me.txtAdresse, 1, 3)
        Me.pntFelder.Name = "pntFelder"
        '
        'lblAdresse
        '
        resources.ApplyResources(Me.lblAdresse, "lblAdresse")
        Me.lblAdresse.Name = "lblAdresse"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'lblMail
        '
        resources.ApplyResources(Me.lblMail, "lblMail")
        Me.lblMail.Name = "lblMail"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOwner, "Name", True))
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        Me.oControlValidator.SetValidator(Me.txtName, Me.oLengthValidator)
        Me.oControlValidator.SetVisualizer(Me.txtName, Me.errError)
        '
        'bndOwner
        '
        Me.bndOwner.AllowNew = False
        Me.bndOwner.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.Owner)
        '
        'txtMail
        '
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOwner, "Mail", True))
        resources.ApplyResources(Me.txtMail, "txtMail")
        Me.txtMail.Name = "txtMail"
        '
        'lblEigentümer
        '
        resources.ApplyResources(Me.lblEigentümer, "lblEigentümer")
        Me.lblEigentümer.Name = "lblEigentümer"
        '
        'chkEigentümer
        '
        resources.ApplyResources(Me.chkEigentümer, "chkEigentümer")
        Me.chkEigentümer.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndOwner, "isEigentümer", True))
        Me.chkEigentümer.Name = "chkEigentümer"
        Me.chkEigentümer.UseVisualStyleBackColor = True
        '
        'txtAdresse
        '
        Me.txtAdresse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOwner, "Address", True))
        resources.ApplyResources(Me.txtAdresse, "txtAdresse")
        Me.txtAdresse.Name = "txtAdresse"
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.pcbLogo)
        resources.ApplyResources(Me.pnlLogo, "pnlLogo")
        Me.pnlLogo.Name = "pnlLogo"
        '
        'pcbLogo
        '
        Me.pcbLogo.BackColor = System.Drawing.SystemColors.Window
        Me.pcbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbLogo.ContextMenuStrip = Me.stripLogo
        Me.pcbLogo.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.bndOwner, "Foto", True))
        resources.ApplyResources(Me.pcbLogo, "pcbLogo")
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.TabStop = False
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
        'sptFelder
        '
        resources.ApplyResources(Me.sptFelder, "sptFelder")
        Me.sptFelder.Name = "sptFelder"
        Me.sptFelder.TabStop = False
        '
        'oLengthValidator
        '
        Me.oLengthValidator.MaximumLength = 0
        Me.oLengthValidator.MinimumLength = 1
        '
        'oControlValidator
        '
        Me.oControlValidator.DefaultApplicationData = Nothing
        Me.oControlValidator.Visualizer = Me.errError
        '
        'errError
        '
        Me.errError.ContainerControl = Me
        '
        'EditOwner
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.sptFelder)
        Me.Controls.Add(Me.pnlLogo)
        Me.Controls.Add(Me.pntFelder)
        Me.Name = "EditOwner"
        Me.pntFelder.ResumeLayout(False)
        Me.pntFelder.PerformLayout()
        CType(Me.bndOwner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stripLogo.ResumeLayout(False)
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndOwner As System.Windows.Forms.BindingSource
    Friend WithEvents pntFelder As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents pcbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ofdOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents stripLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolHinzufügen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolEntfernen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolLogoSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolLogoSizeImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sptFelder As System.Windows.Forms.Splitter
    Friend WithEvents lblEigentümer As System.Windows.Forms.Label
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents chkEigentümer As System.Windows.Forms.CheckBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents oControlValidator As Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator
    Friend WithEvents errError As System.Windows.Forms.ErrorProvider
    Friend WithEvents oLengthValidator As Softwarekueche.Dvd4Sarah.Validation.LengthValidator

End Class
