
Public Class Dvd
    Inherits BoBase
    Implements IComparable

#Region " Eigenschaften "

    Private _title As String

    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property

    Private _subtitle As String

    Public Property Subtitle() As String
        Get
            Return _subtitle
        End Get
        Set(ByVal value As String)
            _subtitle = value
        End Set
    End Property

    Private _owner As Owner

    Public Property Owner() As Owner
        Get
            Return _owner
        End Get
        Set(ByVal value As Owner)
            _owner = value
        End Set
    End Property

    Private _genre As Genre

    Public Property Genre() As Genre
        Get
            Return _genre
        End Get
        Set(ByVal value As Genre)
            _genre = value
        End Set
    End Property

    Private _fsk As FSK

    Public Property FSK() As FSK
        Get
            Return _fsk
        End Get
        Set(ByVal value As FSK)
            _fsk = value
        End Set
    End Property

    Private _description As String

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

#End Region

#Region " Eigenschaft Cover "

    ''' <summary>
    ''' Speichern des Bildes als Byte-Array
    ''' </summary>
    Private _cover As Byte()

    ''' <summary>
    ''' Cover wird gewrappt Byte-Array, damti es von db4o gespeichert
    ''' werden kann.
    ''' </summary>
    Public Property Cover() As System.Drawing.Image
        Get
            If _cover Is Nothing Then Return My.Resources.Blank

            If _cover.Length > 0 Then
                Dim ms As New System.IO.MemoryStream
                ms.Write(_cover, 0, _cover.Length)
                Return System.Drawing.Image.FromStream(ms)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As System.Drawing.Image)
            If value Is Nothing Then
                Array.Resize(_cover, 0)
                _cover = Nothing
                Exit Property
            End If

            Dim ms As New System.IO.MemoryStream
            value.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

            Array.Resize(_cover, CInt(ms.Length))
            _cover = ms.ToArray
        End Set
    End Property

    Public ReadOnly Property Cover24() As System.Drawing.Image
        Get
            If _cover Is Nothing Then Return My.Resources.Blank
            Dim iWidth As Integer = CInt(Cover.Width * 24 \ Cover.Height)
            Dim ms As New System.IO.MemoryStream
            ms.Write(_cover, 0, _cover.Length)
            Return System.Drawing.Image.FromStream(ms).GetThumbnailImage(iWidth, 24, Nothing, Nothing)
        End Get
    End Property

#End Region

#Region " Eigenschaften der Objekthierarchie "

    Public ReadOnly Property FskImage() As System.Drawing.Image
        Get
            If FSK Is Nothing Then Return My.Resources.Blank
            Return FSK.Logo24
        End Get
    End Property

#End Region

#Region " C R U D L "

    Public Shared Function List() As Basisklassen.BindableIList(Of Dvd)
        Dim o As New Dvd
        Return New Basisklassen.BindableIList(Of Dvd)(_persister.List(o))
    End Function

#End Region

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
        Dim myString As String = Me._title
        If myString Is Nothing Then myString = ""

        If TypeOf obj Is String Then
            Return myString.CompareTo(CType(obj, String))
        ElseIf TypeOf obj Is Dvd Then
            Return myString.CompareTo(CType(obj, Dvd).Title)
        Else
            Return myString.CompareTo(obj)
        End If
    End Function

End Class
