<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditGenre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditGenre))
        Me.pntFelder = New System.Windows.Forms.TableLayoutPanel
        Me.lblName = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.bndGenre = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.sptFelder = New System.Windows.Forms.Splitter
        Me.ofdOpenImage = New System.Windows.Forms.OpenFileDialog
        Me.pnlLogo = New System.Windows.Forms.Panel
        Me.pcbLogo = New System.Windows.Forms.PictureBox
        Me.stripLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolHinzufügen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolEntfernen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolLogoSep = New System.Windows.Forms.ToolStripSeparator
        Me.toolLogoSizeImage = New System.Windows.Forms.ToolStripMenuItem
        Me.errError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.oControlValidator = New Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator(Me.components)
        Me.oLengthValidator = New Softwarekueche.Dvd4Sarah.Validation.LengthValidator(Me.components)
        Me.pntFelder.SuspendLayout()
        CType(Me.bndGenre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogo.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stripLogo.SuspendLayout()
        CType(Me.errError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pntFelder
        '
        resources.ApplyResources(Me.pntFelder, "pntFelder")
        Me.pntFelder.Controls.Add(Me.lblName, 0, 0)
        Me.pntFelder.Controls.Add(Me.lblDescription, 0, 1)
        Me.pntFelder.Controls.Add(Me.txtName, 1, 0)
        Me.pntFelder.Controls.Add(Me.txtDescription, 1, 1)
        Me.pntFelder.Name = "pntFelder"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'lblDescription
        '
        resources.ApplyResources(Me.lblDescription, "lblDescription")
        Me.lblDescription.Name = "lblDescription"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGenre, "Name", True))
        resources.ApplyResources(Me.txtName, "txtName")
        Me.oControlValidator.SetErrorMessage(Me.txtName, "Die Eingabe muss mindestens ein Zeichen besitzen")
        Me.txtName.Name = "txtName"
        Me.oControlValidator.SetValidator(Me.txtName, Me.oLengthValidator)
        '
        'bndGenre
        '
        Me.bndGenre.AllowNew = False
        Me.bndGenre.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.Genre)
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGenre, "Description", True))
        resources.ApplyResources(Me.txtDescription, "txtDescription")
        Me.txtDescription.Name = "txtDescription"
        '
        'sptFelder
        '
        resources.ApplyResources(Me.sptFelder, "sptFelder")
        Me.sptFelder.Name = "sptFelder"
        Me.sptFelder.TabStop = False
        '
        'ofdOpenImage
        '
        resources.ApplyResources(Me.ofdOpenImage, "ofdOpenImage")
        Me.ofdOpenImage.RestoreDirectory = True
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
        resources.ApplyResources(Me.pcbLogo, "pcbLogo")
        Me.pcbLogo.ErrorImage = Nothing
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
        'errError
        '
        Me.errError.ContainerControl = Me
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
        'EditGenre
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlLogo)
        Me.Controls.Add(Me.sptFelder)
        Me.Controls.Add(Me.pntFelder)
        Me.Name = "EditGenre"
        Me.pntFelder.ResumeLayout(False)
        Me.pntFelder.PerformLayout()
        CType(Me.bndGenre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stripLogo.ResumeLayout(False)
        CType(Me.errError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndGenre As System.Windows.Forms.BindingSource
    Friend WithEvents pntFelder As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents sptFelder As System.Windows.Forms.Splitter
    Friend WithEvents ofdOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents pcbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents stripLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolHinzufügen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolEntfernen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolLogoSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolLogoSizeImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents oControlValidator As Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator
    Friend WithEvents errError As System.Windows.Forms.ErrorProvider
    Friend WithEvents oLengthValidator As Softwarekueche.Dvd4Sarah.Validation.LengthValidator

End Class
