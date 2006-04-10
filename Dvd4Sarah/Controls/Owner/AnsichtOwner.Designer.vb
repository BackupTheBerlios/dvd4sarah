<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsichtOwner
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
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.oListOwner = New Softwarekueche.Dvd4Sarah.Controls.ListOwner
        Me.btnAnzeigen = New System.Windows.Forms.Button
        Me.btnLöschen = New System.Windows.Forms.Button
        Me.btnBearbeiten = New System.Windows.Forms.Button
        Me.btnNeu = New System.Windows.Forms.Button
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnAnzeigen)
        Me.pnlButtons.Controls.Add(Me.btnLöschen)
        Me.pnlButtons.Controls.Add(Me.btnBearbeiten)
        Me.pnlButtons.Controls.Add(Me.btnNeu)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 324)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(554, 34)
        Me.pnlButtons.TabIndex = 0
        '
        'oListOwner
        '
        Me.oListOwner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListOwner.List = Nothing
        Me.oListOwner.Location = New System.Drawing.Point(0, 0)
        Me.oListOwner.Name = "oListOwner"
        Me.oListOwner.Size = New System.Drawing.Size(554, 324)
        Me.oListOwner.TabIndex = 1
        '
        'btnAnzeigen
        '
        Me.btnAnzeigen.Location = New System.Drawing.Point(165, 6)
        Me.btnAnzeigen.Name = "btnAnzeigen"
        Me.btnAnzeigen.Size = New System.Drawing.Size(75, 23)
        Me.btnAnzeigen.TabIndex = 7
        Me.btnAnzeigen.Text = "&Anzeigen"
        Me.btnAnzeigen.UseVisualStyleBackColor = True
        '
        'btnLöschen
        '
        Me.btnLöschen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLöschen.Location = New System.Drawing.Point(476, 6)
        Me.btnLöschen.Name = "btnLöschen"
        Me.btnLöschen.Size = New System.Drawing.Size(75, 23)
        Me.btnLöschen.TabIndex = 6
        Me.btnLöschen.Text = "&Löschen"
        Me.btnLöschen.UseVisualStyleBackColor = True
        '
        'btnBearbeiten
        '
        Me.btnBearbeiten.Location = New System.Drawing.Point(84, 6)
        Me.btnBearbeiten.Name = "btnBearbeiten"
        Me.btnBearbeiten.Size = New System.Drawing.Size(75, 23)
        Me.btnBearbeiten.TabIndex = 5
        Me.btnBearbeiten.Text = "&Bearbeiten"
        Me.btnBearbeiten.UseVisualStyleBackColor = True
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(3, 6)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(75, 23)
        Me.btnNeu.TabIndex = 4
        Me.btnNeu.Text = "&Neu"
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'AnsichtOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.oListOwner)
        Me.Controls.Add(Me.pnlButtons)
        Me.Name = "AnsichtOwner"
        Me.Size = New System.Drawing.Size(554, 358)
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents oListOwner As Softwarekueche.Dvd4Sarah.Controls.ListOwner
    Friend WithEvents btnAnzeigen As System.Windows.Forms.Button
    Friend WithEvents btnLöschen As System.Windows.Forms.Button
    Friend WithEvents btnBearbeiten As System.Windows.Forms.Button
    Friend WithEvents btnNeu As System.Windows.Forms.Button

End Class
