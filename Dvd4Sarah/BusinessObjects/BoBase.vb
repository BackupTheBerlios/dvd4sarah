
''' <summary>
''' Basisklasse für alle Fachobjekte
''' </summary>
Public MustInherit Class BoBase

#Region " Logger (log4net) "

    ''' <summary>
    ''' Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
    ''' wird durch den Namespace die Logger-Hierarchie aufgebaut.
    ''' </summary>
    ''' <remarks>Mehr siehe <a href="http://logging.apache.org/log4net/">http://logging.apache.org/log4net/</a> </remarks>
    Private Shared ReadOnly log As Global.log4net.ILog = Global.log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

#End Region

#Region " Db4oPersister "

    Protected Shared _persister As Db4oPersister

    Public Shared Sub Init(ByVal persister As Db4oPersister)
        _persister = persister
        _state = PersisterState.Initialized
    End Sub

    Public Shared Sub UnInit()
        If Not _persister Is Nothing Then
            _persister.Dispose()
            _persister = Nothing
        End If

        _state = PersisterState.UnInitialized
    End Sub

#End Region

#Region " State "

    Public Enum PersisterState As Integer
        UnInitialized
        Initialized
    End Enum

    Private Shared _state As PersisterState = PersisterState.UnInitialized

    Public Shared ReadOnly Property State() As PersisterState
        Get
            Return _state
        End Get
    End Property

#End Region

#Region " Eigenschaft FileName As String "

    ''' <summary>
    ''' Eigenschaft FileName
    ''' </summary>
    Public Shared ReadOnly Property FileName() As String
        Get
            If _persister Is Nothing Then Return ""
            Return _persister.FileName
        End Get
    End Property

#End Region

#Region " Konstruktor "

    Protected Sub New()
        MyBase.New()
    End Sub

#End Region

#Region " Save / Delete "

    Public Sub Save()
        _persister.Save(Me)
    End Sub

    Public Sub Delete()
        _persister.Delete(Me)
    End Sub

#End Region

End Class
