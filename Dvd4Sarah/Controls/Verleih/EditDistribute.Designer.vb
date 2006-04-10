<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDistribute
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditDistribute))
        Me.pntFelder = New System.Windows.Forms.TableLayoutPanel
        Me.lblAdresse = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblMail = New System.Windows.Forms.Label
        Me.txtDvd = New System.Windows.Forms.TextBox
        Me.bndDistribute = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtLeiher = New System.Windows.Forms.TextBox
        Me.lblEigentümer = New System.Windows.Forms.Label
        Me.txtBemerkung = New System.Windows.Forms.TextBox
        Me.lblLendDate = New System.Windows.Forms.Label
        Me.dtpLeihen = New System.Windows.Forms.DateTimePicker
        Me.dtpZurueck = New System.Windows.Forms.DateTimePicker
        Me.stripLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolHinzufügen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolEntfernen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolLogoSep = New System.Windows.Forms.ToolStripSeparator
        Me.toolLogoSizeImage = New System.Windows.Forms.ToolStripMenuItem
        Me.ofdOpenImage = New System.Windows.Forms.OpenFileDialog
        Me.oLengthValidator = New Softwarekueche.Dvd4Sarah.Validation.LengthValidator(Me.components)
        Me.oControlValidator = New Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator(Me.components)
        Me.errError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pntFelder.SuspendLayout()
        CType(Me.bndDistribute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stripLogo.SuspendLayout()
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pntFelder
        '
        resources.ApplyResources(Me.pntFelder, "pntFelder")
        Me.pntFelder.Controls.Add(Me.lblAdresse, 0, 4)
        Me.pntFelder.Controls.Add(Me.lblName, 0, 0)
        Me.pntFelder.Controls.Add(Me.lblMail, 0, 1)
        Me.pntFelder.Controls.Add(Me.txtDvd, 1, 0)
        Me.pntFelder.Controls.Add(Me.txtLeiher, 1, 1)
        Me.pntFelder.Controls.Add(Me.lblEigentümer, 0, 3)
        Me.pntFelder.Controls.Add(Me.txtBemerkung, 1, 4)
        Me.pntFelder.Controls.Add(Me.lblLendDate, 0, 2)
        Me.pntFelder.Controls.Add(Me.dtpLeihen, 1, 2)
        Me.pntFelder.Controls.Add(Me.dtpZurueck, 1, 3)
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
        'txtDvd
        '
        Me.txtDvd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndDistribute, "Dvd", True))
        resources.ApplyResources(Me.txtDvd, "txtDvd")
        Me.txtDvd.Name = "txtDvd"
        Me.txtDvd.ReadOnly = True
        Me.oControlValidator.SetValidator(Me.txtDvd, Me.oLengthValidator)
        Me.oControlValidator.SetVisualizer(Me.txtDvd, Me.errError)
        '
        'bndDistribute
        '
        Me.bndDistribute.AllowNew = False
        Me.bndDistribute.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.Distribute)
        '
        'txtLeiher
        '
        Me.txtLeiher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndDistribute, "Lender", True))
        resources.ApplyResources(Me.txtLeiher, "txtLeiher")
        Me.txtLeiher.Name = "txtLeiher"
        Me.txtLeiher.ReadOnly = True
        '
        'lblEigentümer
        '
        resources.ApplyResources(Me.lblEigentümer, "lblEigentümer")
        Me.lblEigentümer.Name = "lblEigentümer"
        '
        'txtBemerkung
        '
        Me.txtBemerkung.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndDistribute, "Bemerkung", True))
        resources.ApplyResources(Me.txtBemerkung, "txtBemerkung")
        Me.txtBemerkung.Name = "txtBemerkung"
        '
        'lblLendDate
        '
        resources.ApplyResources(Me.lblLendDate, "lblLendDate")
        Me.lblLendDate.Name = "lblLendDate"
        '
        'dtpLeihen
        '
        Me.dtpLeihen.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bndDistribute, "LeihDatum", True))
        resources.ApplyResources(Me.dtpLeihen, "dtpLeihen")
        Me.dtpLeihen.Name = "dtpLeihen"
        '
        'dtpZurueck
        '
        Me.dtpZurueck.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bndDistribute, "ZuruechDatum", True))
        resources.ApplyResources(Me.dtpZurueck, "dtpZurueck")
        Me.dtpZurueck.Name = "dtpZurueck"
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
        'EditDistribute
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pntFelder)
        Me.Name = "EditDistribute"
        Me.pntFelder.ResumeLayout(False)
        Me.pntFelder.PerformLayout()
        CType(Me.bndDistribute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stripLogo.ResumeLayout(False)
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndDistribute As System.Windows.Forms.BindingSource
    Friend WithEvents pntFelder As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtDvd As System.Windows.Forms.TextBox
    Friend WithEvents txtLeiher As System.Windows.Forms.TextBox
    Friend WithEvents ofdOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents stripLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolHinzufügen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolEntfernen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolLogoSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolLogoSizeImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEigentümer As System.Windows.Forms.Label
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents txtBemerkung As System.Windows.Forms.TextBox
    Friend WithEvents oControlValidator As Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator
    Friend WithEvents errError As System.Windows.Forms.ErrorProvider
    Friend WithEvents oLengthValidator As Softwarekueche.Dvd4Sarah.Validation.LengthValidator
    Friend WithEvents lblLendDate As System.Windows.Forms.Label
    Friend WithEvents dtpLeihen As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpZurueck As System.Windows.Forms.DateTimePicker

End Class
