<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListDvd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListDvd))
        Me.Liste = New System.Windows.Forms.DataGridView
        Me.dctTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dctSubtitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dctOwner = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dctGenre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dciCover = New System.Windows.Forms.DataGridViewImageColumn
        Me.dciFskImage = New System.Windows.Forms.DataGridViewImageColumn
        Me.bndDvd = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndDvd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Liste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dctTitle, Me.dctSubtitle, Me.dctOwner, Me.dctGenre, Me.dciCover, Me.dciFskImage})
        Me.Liste.DataSource = Me.bndDvd
        resources.ApplyResources(Me.Liste, "Liste")
        Me.Liste.Name = "Liste"
        Me.Liste.ReadOnly = True
        Me.Liste.RowHeadersVisible = False
        Me.Liste.RowTemplate.Height = 35
        '
        'dctTitle
        '
        Me.dctTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dctTitle.DataPropertyName = "Title"
        resources.ApplyResources(Me.dctTitle, "dctTitle")
        Me.dctTitle.Name = "dctTitle"
        Me.dctTitle.ReadOnly = True
        '
        'dctSubtitle
        '
        Me.dctSubtitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dctSubtitle.DataPropertyName = "Subtitle"
        resources.ApplyResources(Me.dctSubtitle, "dctSubtitle")
        Me.dctSubtitle.Name = "dctSubtitle"
        Me.dctSubtitle.ReadOnly = True
        '
        'dctOwner
        '
        Me.dctOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dctOwner.DataPropertyName = "Owner"
        resources.ApplyResources(Me.dctOwner, "dctOwner")
        Me.dctOwner.Name = "dctOwner"
        Me.dctOwner.ReadOnly = True
        '
        'dctGenre
        '
        Me.dctGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dctGenre.DataPropertyName = "Genre"
        resources.ApplyResources(Me.dctGenre, "dctGenre")
        Me.dctGenre.Name = "dctGenre"
        Me.dctGenre.ReadOnly = True
        '
        'dciCover
        '
        Me.dciCover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dciCover.DataPropertyName = "Cover24"
        resources.ApplyResources(Me.dciCover, "dciCover")
        Me.dciCover.Name = "dciCover"
        Me.dciCover.ReadOnly = True
        '
        'dciFskImage
        '
        Me.dciFskImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dciFskImage.DataPropertyName = "FskImage"
        resources.ApplyResources(Me.dciFskImage, "dciFskImage")
        Me.dciFskImage.Name = "dciFskImage"
        Me.dciFskImage.ReadOnly = True
        '
        'bndDvd
        '
        Me.bndDvd.AllowNew = False
        Me.bndDvd.Sort = ""
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Owner"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Genre"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Owner"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Genre"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4")
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'ListDvd
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Liste)
        Me.Name = "ListDvd"
        CType(Me.Liste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndDvd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndDvd As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Liste As System.Windows.Forms.DataGridView
    Friend WithEvents dctTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dctSubtitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dctOwner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dctGenre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dciCover As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dciFskImage As System.Windows.Forms.DataGridViewImageColumn

End Class
