<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsichtGenre
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
        Me.btnAnzeigen = New System.Windows.Forms.Button
        Me.btnLöschen = New System.Windows.Forms.Button
        Me.btnBearbeiten = New System.Windows.Forms.Button
        Me.btnNeu = New System.Windows.Forms.Button
        Me.oListGenre = New Softwarekueche.Dvd4Sarah.Controls.ListGenre
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
        Me.pnlButtons.Location = New System.Drawing.Point(0, 137)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(380, 34)
        Me.pnlButtons.TabIndex = 0
        '
        'btnAnzeigen
        '
        Me.btnAnzeigen.Location = New System.Drawing.Point(165, 6)
        Me.btnAnzeigen.Name = "btnAnzeigen"
        Me.btnAnzeigen.Size = New System.Drawing.Size(75, 23)
        Me.btnAnzeigen.TabIndex = 5
        Me.btnAnzeigen.Text = "&Anzeigen"
        Me.btnAnzeigen.UseVisualStyleBackColor = True
        '
        'btnLöschen
        '
        Me.btnLöschen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLöschen.Location = New System.Drawing.Point(302, 6)
        Me.btnLöschen.Name = "btnLöschen"
        Me.btnLöschen.Size = New System.Drawing.Size(75, 23)
        Me.btnLöschen.TabIndex = 4
        Me.btnLöschen.Text = "&Löschen"
        Me.btnLöschen.UseVisualStyleBackColor = True
        '
        'btnBearbeiten
        '
        Me.btnBearbeiten.Location = New System.Drawing.Point(84, 6)
        Me.btnBearbeiten.Name = "btnBearbeiten"
        Me.btnBearbeiten.Size = New System.Drawing.Size(75, 23)
        Me.btnBearbeiten.TabIndex = 1
        Me.btnBearbeiten.Text = "&Bearbeiten"
        Me.btnBearbeiten.UseVisualStyleBackColor = True
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(3, 6)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(75, 23)
        Me.btnNeu.TabIndex = 0
        Me.btnNeu.Text = "&Neu"
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'oListGenre
        '
        Me.oListGenre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListGenre.List = Nothing
        Me.oListGenre.Location = New System.Drawing.Point(0, 0)
        Me.oListGenre.Name = "oListGenre"
        Me.oListGenre.Size = New System.Drawing.Size(380, 137)
        Me.oListGenre.TabIndex = 2
        '
        'AnsichtGenre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.oListGenre)
        Me.Controls.Add(Me.pnlButtons)
        Me.MinimumSize = New System.Drawing.Size(338, 106)
        Me.Name = "AnsichtGenre"
        Me.Size = New System.Drawing.Size(380, 171)
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnNeu As System.Windows.Forms.Button
    Friend WithEvents btnBearbeiten As System.Windows.Forms.Button
    Friend WithEvents oListGenre As Softwarekueche.Dvd4Sarah.Controls.ListGenre
    Friend WithEvents btnAnzeigen As System.Windows.Forms.Button
    Friend WithEvents btnLöschen As System.Windows.Forms.Button

End Class
