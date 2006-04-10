<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsichtDistribute
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
        Me.oListDistribute = New Softwarekueche.Dvd4Sarah.Controls.ListDistribute
        Me.EditDistribute1 = New Softwarekueche.Dvd4Sarah.Controls.EditDistribute
        Me.sptEdit = New System.Windows.Forms.Splitter
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'oListDistribute
        '
        Me.oListDistribute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListDistribute.List = Nothing
        Me.oListDistribute.Location = New System.Drawing.Point(0, 0)
        Me.oListDistribute.Name = "oListDistribute"
        Me.oListDistribute.Size = New System.Drawing.Size(404, 301)
        Me.oListDistribute.Sort = ""
        Me.oListDistribute.TabIndex = 2
        '
        'EditDistribute1
        '
        Me.EditDistribute1.Distribute = Nothing
        Me.EditDistribute1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EditDistribute1.Location = New System.Drawing.Point(0, 361)
        Me.EditDistribute1.Name = "EditDistribute1"
        Me.EditDistribute1.Size = New System.Drawing.Size(404, 160)
        Me.EditDistribute1.TabIndex = 1
        '
        'sptEdit
        '
        Me.sptEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sptEdit.Location = New System.Drawing.Point(0, 358)
        Me.sptEdit.Name = "sptEdit"
        Me.sptEdit.Size = New System.Drawing.Size(404, 3)
        Me.sptEdit.TabIndex = 3
        Me.sptEdit.TabStop = False
        '
        'pnlButtons
        '
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 301)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(404, 57)
        Me.pnlButtons.TabIndex = 4
        '
        'AnsichtDistribute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.oListDistribute)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.sptEdit)
        Me.Controls.Add(Me.EditDistribute1)
        Me.Name = "AnsichtDistribute"
        Me.Size = New System.Drawing.Size(404, 521)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EditDistribute1 As Softwarekueche.Dvd4Sarah.Controls.EditDistribute
    Friend WithEvents oListDistribute As Softwarekueche.Dvd4Sarah.Controls.ListDistribute
    Friend WithEvents sptEdit As System.Windows.Forms.Splitter
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel

End Class
