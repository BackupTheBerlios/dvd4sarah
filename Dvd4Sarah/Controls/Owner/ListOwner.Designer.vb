<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOwner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListOwner))
        Me.Liste = New System.Windows.Forms.DataGridView
        Me.dctName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dciFoto = New System.Windows.Forms.DataGridViewImageColumn
        Me.dccEigentümer = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.bndOwner = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndOwner, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Liste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dctName, Me.dciFoto, Me.dccEigentümer})
        Me.Liste.DataSource = Me.bndOwner
        resources.ApplyResources(Me.Liste, "Liste")
        Me.Liste.Name = "Liste"
        Me.Liste.ReadOnly = True
        Me.Liste.RowHeadersVisible = False
        Me.Liste.RowTemplate.Height = 40
        '
        'dctName
        '
        Me.dctName.DataPropertyName = "Name"
        resources.ApplyResources(Me.dctName, "dctName")
        Me.dctName.Name = "dctName"
        Me.dctName.ReadOnly = True
        '
        'dciFoto
        '
        Me.dciFoto.DataPropertyName = "Foto40"
        resources.ApplyResources(Me.dciFoto, "dciFoto")
        Me.dciFoto.Name = "dciFoto"
        Me.dciFoto.ReadOnly = True
        '
        'dccEigentümer
        '
        Me.dccEigentümer.DataPropertyName = "isEigentümer"
        resources.ApplyResources(Me.dccEigentümer, "dccEigentümer")
        Me.dccEigentümer.Name = "dccEigentümer"
        Me.dccEigentümer.ReadOnly = True
        '
        'bndOwner
        '
        Me.bndOwner.AllowNew = False
        Me.bndOwner.Sort = ""
        '
        'ListOwner
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Liste)
        Me.Name = "ListOwner"
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndOwner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndOwner As System.Windows.Forms.BindingSource
    Friend WithEvents dctName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dciFoto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dccEigentümer As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Liste As System.Windows.Forms.DataGridView

End Class
