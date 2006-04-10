<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListGenre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListGenre))
        Me.Liste = New System.Windows.Forms.DataGridView
        Me.dctName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dctDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bndGenre = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndGenre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Liste
        '
        Me.Liste.AllowUserToAddRows = False
        Me.Liste.AllowUserToDeleteRows = False
        Me.Liste.AllowUserToOrderColumns = True
        Me.Liste.AllowUserToResizeRows = False
        Me.Liste.AutoGenerateColumns = False
        Me.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Liste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dctName, Me.dctDescription})
        Me.Liste.DataSource = Me.bndGenre
        resources.ApplyResources(Me.Liste, "Liste")
        Me.Liste.Name = "Liste"
        Me.Liste.ReadOnly = True
        Me.Liste.RowHeadersVisible = False
        Me.Liste.RowTemplate.Height = 20
        '
        'dctName
        '
        Me.dctName.DataPropertyName = "Name"
        resources.ApplyResources(Me.dctName, "dctName")
        Me.dctName.Name = "dctName"
        Me.dctName.ReadOnly = True
        '
        'dctDescription
        '
        Me.dctDescription.DataPropertyName = "DescriptionShort"
        resources.ApplyResources(Me.dctDescription, "dctDescription")
        Me.dctDescription.Name = "dctDescription"
        Me.dctDescription.ReadOnly = True
        '
        'bndGenre
        '
        Me.bndGenre.AllowNew = False
        Me.bndGenre.Sort = ""
        '
        'ListGenre
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Liste)
        Me.Name = "ListGenre"
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndGenre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndGenre As System.Windows.Forms.BindingSource
    Friend WithEvents Liste As System.Windows.Forms.DataGridView
    Friend WithEvents dctName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dctDescription As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
