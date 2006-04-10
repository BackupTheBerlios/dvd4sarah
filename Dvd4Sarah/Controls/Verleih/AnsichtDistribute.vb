Public Class AnsichtDistribute

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oListDistribute.List = BusinessObjects.Distribute.List()
    End Sub
End Class
