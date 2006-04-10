<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LizenzBox
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
        Me.stripStatus = New System.Windows.Forms.StatusStrip
        Me.rteLizenz = New System.Windows.Forms.RichTextBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.pcbGnu = New System.Windows.Forms.PictureBox
        Me.lblProgram = New System.Windows.Forms.Label
        Me.lblShort = New System.Windows.Forms.Label
        CType(Me.pcbGnu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stripStatus
        '
        Me.stripStatus.Location = New System.Drawing.Point(0, 448)
        Me.stripStatus.Name = "stripStatus"
        Me.stripStatus.Size = New System.Drawing.Size(747, 22)
        Me.stripStatus.TabIndex = 0
        Me.stripStatus.Text = "StatusStrip1"
        '
        'rteLizenz
        '
        Me.rteLizenz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rteLizenz.Location = New System.Drawing.Point(12, 150)
        Me.rteLizenz.Name = "rteLizenz"
        Me.rteLizenz.ReadOnly = True
        Me.rteLizenz.Size = New System.Drawing.Size(723, 266)
        Me.rteLizenz.TabIndex = 1
        Me.rteLizenz.Text = ""
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(660, 422)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pcbGnu
        '
        Me.pcbGnu.Location = New System.Drawing.Point(12, 12)
        Me.pcbGnu.Name = "pcbGnu"
        Me.pcbGnu.Size = New System.Drawing.Size(144, 132)
        Me.pcbGnu.TabIndex = 3
        Me.pcbGnu.TabStop = False
        '
        'lblProgram
        '
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(162, 12)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(183, 23)
        Me.lblProgram.TabIndex = 4
        Me.lblProgram.Text = "Dvd4Sarah"
        '
        'lblShort
        '
        Me.lblShort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShort.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShort.Location = New System.Drawing.Point(164, 52)
        Me.lblShort.Name = "lblShort"
        Me.lblShort.Size = New System.Drawing.Size(571, 92)
        Me.lblShort.TabIndex = 5
        Me.lblShort.Text = "Dvd4Sarah is distributed under" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GNU General Public License" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 2, Juni 1991"
        '
        'LizenzBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 470)
        Me.Controls.Add(Me.lblShort)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.pcbGnu)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.rteLizenz)
        Me.Controls.Add(Me.stripStatus)
        Me.MinimumSize = New System.Drawing.Size(424, 284)
        Me.Name = "LizenzBox"
        Me.Text = "Dvd4Sarah - Lizenz"
        CType(Me.pcbGnu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stripStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents rteLizenz As System.Windows.Forms.RichTextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents pcbGnu As System.Windows.Forms.PictureBox
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents lblShort As System.Windows.Forms.Label
End Class
