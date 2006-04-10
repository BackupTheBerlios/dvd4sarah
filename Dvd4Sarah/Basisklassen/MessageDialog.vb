Imports System
Imports System.Collections

''' <summary>
''' Diese Funktion kapselt statisch alle Funktionen, die für den MessageDialog
''' benötigt werden. Dadurch wird der Dialog und die Verbindung nur einmal
''' initialisiert.
''' </summary>
''' <remarks>GOF: Singleton-Pattern</remarks>
Public NotInheritable Class MessageDialog

#Region " Logger (log4net) "

    ''' <summary>
    ''' Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
    ''' wird durch den Namespace die Logger-Hierarchie aufgebaut.
    ''' </summary>
    ''' <remarks>Mehr siehe <a href="http://logging.apache.org/log4net/">http://logging.apache.org/log4net/</a> </remarks>
    Private Shared ReadOnly log As Global.log4net.ILog = Global.log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

#End Region

#Region " Konstruktor "

    ''' <summary>
    ''' Verborgener Konstruktor
    ''' </summary>
    Private Sub New()
        MyBase.New()
    End Sub

#End Region

#Region " Eigenschaft Parent "

    Private Shared _Parent As System.Windows.Forms.Form
    ''' <summary>
    ''' Falls ein Parent angegeben wurde, ist es möglichen, diesen nach einem
    ''' ShowDialog in den Vordergrund zu bringen.
    ''' </summary>
    Public Shared WriteOnly Property Parent() As System.Windows.Forms.Form
        Set(ByVal Value As System.Windows.Forms.Form)
            _Parent = Value
        End Set
    End Property

#End Region

#Region " Initialisieren "

    ''' <summary>
    ''' Der Singleton MessageDialog
    ''' </summary>
    Private Shared oMsgDlg As DotNetUC.Forms.MessageDialog

    ''' <summary>
    ''' Initialisieren der Verbindung, des MessageProviders, der Datenbank und 
    ''' besonders das initialisieren des MessageDialoges
    ''' </summary>
    Public Shared Sub Init()
        ' MessageDialog initialisieren
        oMsgDlg = New DotNetUC.Forms.MessageDialog

        ' MessageProvider erstellen und Me-zuweisen
        Dim oMsgProvider As New DotNetUC.Forms.FileMessageProvider
        oMsgProvider.FileName = Konfiguration.MessageDialogs
        oMsgDlg.MessageProvider = oMsgProvider
    End Sub

#End Region

#Region " MessageDialog.Show "

    ''' <summary>
    ''' Wrapper für MessageDialog.Show
    ''' </summary>
    Public Shared Function Show(ByVal Index As Int32) As Windows.Forms.DialogResult
        If oMsgDlg Is Nothing Then Init()
        Dim res As System.Windows.Forms.DialogResult
        res = oMsgDlg.Show(Index)

        If Not _Parent Is Nothing Then
            _Parent.BringToFront()
        Else
            If log.IsInfoEnabled Then log.Info("Parent ist 'Nothing'")
        End If

        Return res
    End Function

    ''' <summary>
    ''' Wrapper für MessageDialog.Show()
    ''' </summary>
    Public Shared Function Show(ByVal Index As Int32, ByVal ParamArray Parameter() As String) As Windows.Forms.DialogResult
        If oMsgDlg Is Nothing Then Init()
        Dim res As System.Windows.Forms.DialogResult
        res = oMsgDlg.Show(Index, Parameter)

        If Not _Parent Is Nothing Then
            _Parent.BringToFront()
        Else
            If log.IsInfoEnabled Then log.Info("Parent ist 'Nothing'")
        End If

        Return res
    End Function

#End Region

End Class
