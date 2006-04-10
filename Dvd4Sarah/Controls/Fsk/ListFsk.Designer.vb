<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListFsk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListFsk))
        Me.Liste = New System.Windows.Forms.DataGridView
        Me.dctName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dctMinAlter = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dciLogo24 = New System.Windows.Forms.DataGridViewImageColumn
        Me.bndFsk = New System.Windows.Forms.BindingSource(Me.components)
        Me.oDataFormatter = New Softwarekueche.Dvd4Sarah.Basisklassen.DataFormatter(Me.components)
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndFsk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oDataFormatter, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Liste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dctName, Me.dctMinAlter, Me.dciLogo24})
        Me.Liste.DataSource = Me.bndFsk
        resources.ApplyResources(Me.Liste, "Liste")
        Me.Liste.Name = "Liste"
        Me.Liste.ReadOnly = True
        Me.Liste.RowHeadersVisible = False
        Me.Liste.RowTemplate.Height = 26
        '
        'dctName
        '
        Me.dctName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dctName.DataPropertyName = "Name"
        resources.ApplyResources(Me.dctName, "dctName")
        Me.dctName.Name = "dctName"
        Me.dctName.ReadOnly = True
        '
        'dctMinAlter
        '
        Me.dctMinAlter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.oDataFormatter.SetColumnFormatter(Me.dctMinAlter, New Softwarekueche.Dvd4Sarah.Validation.AgeFormatter)
        Me.oDataFormatter.SetColumnParser(Me.dctMinAlter, New Softwarekueche.Dvd4Sarah.Validation.AgeFormatter)
        Me.dctMinAlter.DataPropertyName = "MinAlter"
        resources.ApplyResources(Me.dctMinAlter, "dctMinAlter")
        Me.dctMinAlter.Name = "dctMinAlter"
        Me.dctMinAlter.ReadOnly = True
        '
        'dciLogo24
        '
        Me.dciLogo24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dciLogo24.DataPropertyName = "Logo24"
        resources.ApplyResources(Me.dciLogo24, "dciLogo24")
        Me.dciLogo24.Name = "dciLogo24"
        Me.dciLogo24.ReadOnly = True
        '
        'bndFsk
        '
        Me.bndFsk.AllowNew = False
        Me.bndFsk.Sort = ""
        '
        'ListFsk
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Liste)
        Me.Name = "ListFsk"
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndFsk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oDataFormatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndFsk As System.Windows.Forms.BindingSource
    Friend WithEvents Liste As System.Windows.Forms.DataGridView
    Friend WithEvents oDataFormatter As Softwarekueche.Dvd4Sarah.Basisklassen.DataFormatter
    Friend WithEvents dctName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dctMinAlter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dciLogo24 As System.Windows.Forms.DataGridViewImageColumn

End Class
