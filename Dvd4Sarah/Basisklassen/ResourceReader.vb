Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection

''' <summary>
''' Abstrakte Klasse zum Lesen von Resourcen aus der Assembly der Klasse. Um den Code und die
''' Aufrufe zu vereinfachen wird die Property <see cref="ResourceReader.Assembly">Assembly</see>
''' auf das Assembly, in dem sich diese Klasse befindet, gesetzt.
''' </summary>
Public NotInheritable Class ResourceReader

    ''' <summary>
    ''' Konstruktor verbergen
    ''' </summary>
    Private Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Assembly, aus der die Resourcen gelesen werden.
    ''' </summary>
    Private Shared _Assembly As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(GetType(ResourceReader))

    ''' <summary>
    ''' Property zum Lesen und setzen der Assembly.
    ''' </summary>
    ''' <remarks>Dieser Property muss mit bedacht benutzt werden. Das Ändern der Assembly
    ''' kann zu Seiteneffekten wie "Resource nicht gefunden" führen, wenn die Assembly
    ''' in der Zwischenzeit geändert wurde.</remarks>
    Public Shared Property Assembly() As System.Reflection.Assembly
        Get
            Return _Assembly
        End Get
        Set(ByVal value As System.Reflection.Assembly)
            _Assembly = value
        End Set
    End Property

    ' <summary>
    ' Liest einen Stream bis ans Ende aus und gibt die enthaltenen Daten zurück.
    ' </summary>
    ' <param name="stream">Der Stream, der bis zum Ende gelesen werden soll</param>
    ' <returns>Inhalt des Streams</returns>
    Private Shared Function ReadStreamToEnd(ByVal stream As System.IO.Stream) As String
        Try
            Dim data(CInt(stream.Length)) As Byte
            Dim size As Integer = stream.Read(data, 0, data.Length)

            Return System.Text.Encoding.Default.GetString(data, 0, size)
        Catch
            Throw
        End Try
    End Function

    ' <summary>
    ' Lädt aus einer bst. Assembly bst. Ressourcen anhand des namen
    ' </summary>
    ' <param name="name">Der Name der Resource (Normal ist das der Namespace + Dateinamen)</param>
    ' <returns>Die Werte die In der Resource enthalten sind</returns>
    Public Shared Function GetResourceOfAssembly(ByVal name As String) As String
        Try
            Dim stream As System.IO.Stream = _Assembly.GetManifestResourceStream(name)

            Return ReadStreamToEnd(stream)
        Catch
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Gibt eine Liste aller Reosurcen mit der Endung von 'Pattern' aus der Assembly zurück.
    ''' </summary>
    ''' <param name="Pattern">Muster der Endung der Resourcen</param>
    Public Shared Function GetResourceList(ByVal Pattern As String) As List(Of String)
        Dim res As New List(Of String)
        Dim ResList() As String = _Assembly.GetManifestResourceNames()

        For Each ResListItem As String In ResList
            If ResListItem.EndsWith(Pattern) Then
                res.Add(ResListItem)
            End If
        Next
        Return res
    End Function

End Class
