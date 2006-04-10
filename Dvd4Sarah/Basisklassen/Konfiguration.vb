
''' <summary>
''' Klasse, welche die Konfiguration der Perssoll.exe benutzt.
''' </summary>
Public NotInheritable Class Konfiguration

#Region " Verborgener Konstruktur "

    ''' <summary>
    ''' Konstruktor verbergen
    ''' </summary>
    Private Sub New()
        MyBase.New()
    End Sub

#End Region

#Region " Logger (log4net)"
    ''' <summary>
    ''' Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
    ''' wird durch den Namespace die Logger-Hierarchie aufgebaut.
    ''' </summary>
    ''' <remarks>Mehr siehe <a href="http://logging.apache.org/log4net/">http://logging.apache.org/log4net/</a> </remarks>
    Private Shared ReadOnly log As Global.log4net.ILog = Global.log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
#End Region

#Region " Initialisierung "

    Private Shared mgr As System.Configuration.Configuration

    ''' <summary>
    ''' Initialisieren des Konfigurationsmanagers
    ''' </summary>
    Private Shared Sub Init()
        mgr = System.Configuration.ConfigurationManager.OpenExeConfiguration(Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal)
    End Sub

#End Region

#Region " Property-Wrapper für die Parameter "

    ''' <summary>
    ''' VisualStyles
    ''' </summary>
    Public Shared ReadOnly Property VisualStyles() As Boolean
        Get
            If mgr Is Nothing Then Init()

            If mgr.AppSettings.Settings("VisualStyles") Is Nothing Then
                Return True
            Else
                Return Not String.Compare(mgr.AppSettings.Settings("VisualStyles").Value, "False", True) = 0
            End If
        End Get
    End Property

    ''' <summary>
    ''' MessageDialogs
    ''' </summary>
    Public Shared ReadOnly Property MessageDialogs() As String
        Get
            If mgr Is Nothing Then Init()

            If mgr.AppSettings.Settings("MessageDialogs") Is Nothing Then
                Return ""
            Else
                Return CStr(mgr.AppSettings.Settings("MessageDialogs").Value)
            End If
        End Get
    End Property

    ''' <summary>
    ''' HelpFile
    ''' </summary>
    Public Shared ReadOnly Property HelpFile() As String
        Get
            If mgr Is Nothing Then Init()

            If mgr.AppSettings.Settings("HelpFile") Is Nothing Then
                Return ""
            Else
                Return CStr(mgr.AppSettings.Settings("HelpFile").Value)
            End If
        End Get
    End Property

#End Region

End Class
