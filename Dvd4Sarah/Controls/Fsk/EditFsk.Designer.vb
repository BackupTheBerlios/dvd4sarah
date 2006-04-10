<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditFsk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditFsk))
        Me.pntFelder = New System.Windows.Forms.TableLayoutPanel
        Me.lblName = New System.Windows.Forms.Label
        Me.lblMinAlter = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.bndFsk = New System.Windows.Forms.BindingSource(Me.components)
        Me.nupMinAlter = New System.Windows.Forms.NumericUpDown
        Me.sptFelder = New System.Windows.Forms.Splitter
        Me.pnlLogo = New System.Windows.Forms.Panel
        Me.pcbLogo = New System.Windows.Forms.PictureBox
        Me.stripLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolHinzufügen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolEntfernen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolLogoSep = New System.Windows.Forms.ToolStripSeparator
        Me.toolLogoSizeImage = New System.Windows.Forms.ToolStripMenuItem
        Me.ofdOpenImage = New System.Windows.Forms.OpenFileDialog
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.oControlValidator = New Softwarekueche.Dvd4Sarah.Basisklassen.ControlValidator(Me.components)
        Me.oLengthValidator = New Softwarekueche.Dvd4Sarah.Validation.LengthValidator(Me.components)
        Me.oBetweenValidator = New Softwarekueche.Dvd4Sarah.Validation.BetweenValidator(Me.components)
        Me.pntFelder.SuspendLayout()
        CType(Me.bndFsk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMinAlter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogo.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stripLogo.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pntFelder
        '
        resources.ApplyResources(Me.pntFelder, "pntFelder")
        Me.pntFelder.Controls.Add(Me.lblName, 0, 0)
        Me.pntFelder.Controls.Add(Me.lblMinAlter, 0, 1)
        Me.pntFelder.Controls.Add(Me.txtName, 1, 0)
        Me.pntFelder.Controls.Add(Me.nupMinAlter, 1, 1)
        Me.pntFelder.Name = "pntFelder"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'lblMinAlter
        '
        resources.ApplyResources(Me.lblMinAlter, "lblMinAlter")
        Me.lblMinAlter.Name = "lblMinAlter"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndFsk, "Name", True))
        resources.ApplyResources(Me.txtName, "txtName")
        Me.oControlValidator.SetErrorMessage(Me.txtName, "Eingabe muss mindestens ein Zeichen besitzen")
        Me.txtName.Name = "txtName"
        Me.oControlValidator.SetValidator(Me.txtName, Me.oLengthValidator)
        '
        'bndFsk
        '
        Me.bndFsk.AllowNew = False
        Me.bndFsk.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.FSK)
        '
        'nupMinAlter
        '
        Me.nupMinAlter.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bndFsk, "MinAlter", True))
        resources.ApplyResources(Me.nupMinAlter, "nupMinAlter")
        Me.nupMinAlter.Name = "nupMinAlter"
        Me.oControlValidator.SetValidator(Me.nupMinAlter, Me.oBetweenValidator)
        '
        'sptFelder
        '
        resources.ApplyResources(Me.sptFelder, "sptFelder")
        Me.sptFelder.Name = "sptFelder"
        Me.sptFelder.TabStop = False
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
        Me.pcbLogo.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.bndFsk, "Logo", True))
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
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'oControlValidator
        '
        Me.oControlValidator.DefaultApplicationData = Nothing
        Me.oControlValidator.Visualizer = Me.errProvider
        '
        'oLengthValidator
        '
        Me.oLengthValidator.MaximumLength = 0
        Me.oLengthValidator.MinimumLength = 1
        '
        'oBetweenValidator
        '
        Me.oBetweenValidator.ExcludeBound = False
        Me.oBetweenValidator.LowerBound = New Decimal(New Integer() {0, 0, 0, 0})
        Me.oBetweenValidator.Severity = Global.DotNetUC.Validation.Common.ValidationSeverity.Error
        Me.oBetweenValidator.UpperBound = New Decimal(New Integer() {21, 0, 0, 0})
        '
        'EditFsk
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlLogo)
        Me.Controls.Add(Me.sptFelder)
        Me.Controls.Add(Me.pntFelder)
        Me.Name = "EditFsk"
        Me.pntFelder.ResumeLayout(False)
        Me.pntFelder.PerformLayout()
        CType(Me.bndFsk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMinAlter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stripLogo.ResumeLayout(False)
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oControlValidator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndFsk As System.Windows.Forms.BindingSource
    Friend WithEvents pntFelder As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMinAlter As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents nupMinAlter As System.Windows.Forms.NumericUpDown
    Friend WithEvents sptFelder As System.Windows.Forms.Splitter
    Friend WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents pcbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents stripLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolHinzufügen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolEntfernen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents toolLogoSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolLogoSizeImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents oControlValidator As Basisklassen.ControlValidator
    Friend WithEvents errProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents oLengthValidator As Validation.LengthValidator
    Friend WithEvents oBetweenValidator As Softwarekueche.Dvd4Sarah.Validation.BetweenValidator

End Class
