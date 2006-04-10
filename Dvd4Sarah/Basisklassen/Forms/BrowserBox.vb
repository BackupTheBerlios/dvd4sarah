
''' <summary>
''' Mini-WWebbrowser für die Online-Hilfe
''' </summary>
Public Class BrowserBox

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        WebBrowser1.Navigate(Konfiguration.HelpFile)
    End Sub

    Private Sub BrowserBox_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

End Class