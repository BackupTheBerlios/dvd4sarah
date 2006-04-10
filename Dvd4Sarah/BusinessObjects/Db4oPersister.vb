Imports com.db4o

Public Class Db4oPersister
    Implements IDisposable

#Region " Logger (log4net) "

    ''' <summary>
    ''' Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
    ''' wird durch den Namespace die Logger-Hierarchie aufgebaut.
    ''' </summary>
    ''' <remarks>Mehr siehe <a href="http://logging.apache.org/log4net/">http://logging.apache.org/log4net/</a> </remarks>
    Private Shared ReadOnly log As Global.log4net.ILog = Global.log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

#End Region

#Region " Private Member "

    Private _db As ObjectContainer

#End Region

#Region " Konstruktor "

    Public Sub New(ByVal fileName As String)
        MyBase.New()
        _fileName = fileName
        _db = Db4o.OpenFile(_fileName)
    End Sub

#End Region

#Region " Eigenschaft FileName "

    Private _fileName As String

    Public ReadOnly Property FileName() As String
        Get
            Return _fileName
        End Get
    End Property

#End Region

#Region " C R (U) D L "

    Public Sub Save(ByVal obj As Object)
        Try
            _db.Set(obj)
            _db.Commit()
        Catch ex As Exception
            If log.IsDebugEnabled Then log.Debug("Es ist ein Fehler aufgetreten.", ex)
        End Try
    End Sub

    Public Function Read(ByVal prototype As Object) As Object
        Try
            Dim os As ObjectSet = _db.Get(prototype)
            If os.Size = 0 Then Return Nothing
            Return os.Next
        Catch ex As Exception
            If log.IsDebugEnabled Then log.Debug("Es ist ein Fehler aufgetreten.", ex)
            Return Nothing
        End Try
    End Function

    Public Sub Delete(ByVal obj As Object)
        Try
            _db.Delete(obj)
            _db.Commit()
        Catch ex As Exception
            If log.IsDebugEnabled Then log.Debug("Es ist ein Fehler aufgetreten.", ex)
        End Try
    End Sub

    Public Function List(ByVal prototyp As Object) As IList
        Try
            ' TODO Testen, dass nicht n-personen da sind!
            Return _db.Get(prototyp)
        Catch ex As Exception
            If log.IsDebugEnabled Then log.Debug("Es ist ein Fehler aufgetreten.", ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region " IDisposable Support "

    Private disposedValue As Boolean = False

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' Instanz Member Deinitialisieren
                _db.Close()
            End If
            ' Shared Member Deinitialisieren

        End If
        Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class
