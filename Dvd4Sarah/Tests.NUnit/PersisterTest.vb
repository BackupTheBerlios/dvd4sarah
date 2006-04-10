Imports NUnit.Framework
Imports Softwarekueche.Dvd4Sarah.BusinessObjects

<TestFixture()> _
Public Class PersisterTest

    <Test()> _
    Public Sub SaveOwner()
        Dim pst As New Db4oPersister("C:\NUnitTest.Dvd4Sarah")
        BoBase.Init(pst)

        Dim ow As New Owner
        ow.Name = "Thomas"
        ow.Save()

        Dim o As New Owner
        Dim lst As IList = pst.List(o)
        Assert.IsNotNull(lst)

        For Each itm As Object In lst
            Console.WriteLine(itm.ToString)
        Next

        System.IO.File.Delete("C:\NUnitTest.Dvd4Sarah")

        pst.Dispose()
        System.GC.WaitForPendingFinalizers()
    End Sub

End Class
