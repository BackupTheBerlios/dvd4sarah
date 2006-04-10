<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListDistribute
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListDistribute))
        Me.Liste = New System.Windows.Forms.DataGridView
        Me.bndDistribute = New System.Windows.Forms.BindingSource(Me.components)
        Me.DvdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LeihDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndDistribute, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Liste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DvdDataGridViewTextBoxColumn, Me.LenderDataGridViewTextBoxColumn, Me.LeihDatumDataGridViewTextBoxColumn})
        Me.Liste.DataSource = Me.bndDistribute
        resources.ApplyResources(Me.Liste, "Liste")
        Me.Liste.Name = "Liste"
        Me.Liste.ReadOnly = True
        Me.Liste.RowHeadersVisible = False
        Me.Liste.RowTemplate.Height = 40
        '
        'bndDistribute
        '
        Me.bndDistribute.AllowNew = False
        Me.bndDistribute.DataSource = GetType(Softwarekueche.Dvd4Sarah.BusinessObjects.Distribute)
        Me.bndDistribute.Sort = ""
        '
        'DvdDataGridViewTextBoxColumn
        '
        Me.DvdDataGridViewTextBoxColumn.DataPropertyName = "Dvd"
        resources.ApplyResources(Me.DvdDataGridViewTextBoxColumn, "DvdDataGridViewTextBoxColumn")
        Me.DvdDataGridViewTextBoxColumn.Name = "DvdDataGridViewTextBoxColumn"
        Me.DvdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LenderDataGridViewTextBoxColumn
        '
        Me.LenderDataGridViewTextBoxColumn.DataPropertyName = "Lender"
        resources.ApplyResources(Me.LenderDataGridViewTextBoxColumn, "LenderDataGridViewTextBoxColumn")
        Me.LenderDataGridViewTextBoxColumn.Name = "LenderDataGridViewTextBoxColumn"
        Me.LenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeihDatumDataGridViewTextBoxColumn
        '
        Me.LeihDatumDataGridViewTextBoxColumn.DataPropertyName = "LeihDatum"
        resources.ApplyResources(Me.LeihDatumDataGridViewTextBoxColumn, "LeihDatumDataGridViewTextBoxColumn")
        Me.LeihDatumDataGridViewTextBoxColumn.Name = "LeihDatumDataGridViewTextBoxColumn"
        Me.LeihDatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListDistribute
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Liste)
        Me.Name = "ListDistribute"
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndDistribute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndDistribute As System.Windows.Forms.BindingSource
    Friend WithEvents Liste As System.Windows.Forms.DataGridView
    Friend WithEvents DvdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeihDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
