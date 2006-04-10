Imports log4net
Imports log4net.Core
Imports log4net.Appender
Imports log4net.Layout
Imports log4net.Util

Imports System.IO
Imports System.Windows.Forms

''' <summary>
''' MessageBox für log4net zum Anzeigen von "Error" und "Fatal" Fehlermeldungen.
''' </summary>
<System.Runtime.InteropServices.ComVisible(False)> _
Public Class MessageBoxAppender
    Inherits Appender.AppenderSkeleton

    Private _TitleLayout As PatternLayout
    Private _LevelMapping As New LevelMapping()

    ''' <summary>
    ''' Kontruktor
    ''' </summary>
    Public Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Überschreibt die Methode zum Anzeigen und durchreichen der Fehlermeldung
    ''' </summary>
    Protected Overrides Sub Append(ByVal loggingEvent As Core.LoggingEvent)
        Dim messageBoxIcon As MessageBoxIcon = messageBoxIcon.Information

        Dim levelIcon As LevelIcon = CType(_LevelMapping.Lookup(loggingEvent.Level), LevelIcon)

        If Not (levelIcon Is Nothing) Then
            messageBoxIcon = levelIcon.Icon
        End If

        Dim message As String = RenderLoggingEvent(loggingEvent)
        If message.Length > 300 Then
            message = message.Substring(0, 300) & " ..."
        End If

        Dim title As String = Nothing
        If _TitleLayout Is Nothing Then
            title = "LoggingEvent: " + loggingEvent.Level.Name
        Else
            Dim titleWriter As New StringWriter(System.Globalization.CultureInfo.InvariantCulture)
            _TitleLayout.Format(titleWriter, loggingEvent)
            title = titleWriter.ToString()
        End If

        MessageBox.Show(message, title, MessageBoxButtons.OK, messageBoxIcon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
    End Sub

    Public Sub AddMapping(ByVal mapping As LevelIcon)
        _LevelMapping.Add(mapping)
    End Sub

    Public Property TitleLayout() As PatternLayout
        Get
            Return (Me._TitleLayout)
        End Get
        Set(ByVal Value As PatternLayout)
            Me._TitleLayout = Value
        End Set
    End Property

    Public Overrides Sub ActivateOptions()
        MyBase.ActivateOptions()
        _LevelMapping.ActivateOptions()
    End Sub

End Class

''' <summary>
''' Icon, das angezeigt wird.
''' </summary>
<System.Runtime.InteropServices.ComVisible(False)> _
Public Class LevelIcon
    Inherits LevelMappingEntry

    Public Sub New()
        MyBase.New()
        _Icon = MessageBoxIcon.None
    End Sub

    Private _Icon As MessageBoxIcon

    Public Property Icon() As MessageBoxIcon
        Get
            Return (Me._Icon)
        End Get
        Set(ByVal Value As MessageBoxIcon)
            Me._Icon = Value
        End Set

    End Property

End Class
