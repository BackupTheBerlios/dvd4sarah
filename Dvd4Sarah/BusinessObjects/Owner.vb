
<System.ComponentModel.DefaultProperty("Name")> _
Public Class Owner
    Inherits BoBase

#Region " Eigenschaften "

    Private _name As String

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _mail As String

    Public Property Mail() As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            _mail = value
        End Set
    End Property

    Private _address As String

    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Private _isEigentümer As Boolean

    Public Property isEigentümer() As Boolean
        Get
            Return _isEigentümer
        End Get
        Set(ByVal value As Boolean)
            _isEigentümer = value
        End Set
    End Property


#End Region

#Region " Eigenschaft Foto "

    ''' <summary>
    ''' Speichern des Bildes als Byte-Array
    ''' </summary>
    Private _foto As Byte()

    ''' <summary>
    ''' Foto wird gewrappt Byte-Array, damti es von db4o gespeichert
    ''' werden kann.
    ''' </summary>
    Public Property Foto() As System.Drawing.Image
        Get
            If _foto Is Nothing Then Return My.Resources.Blank

            If _foto.Length > 0 Then
                Dim ms As New System.IO.MemoryStream
                ms.Write(_foto, 0, _foto.Length)
                Return System.Drawing.Image.FromStream(ms)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As System.Drawing.Image)
            If value Is Nothing Then
                Array.Resize(_foto, 0)
                _foto = Nothing
                Exit Property
            End If

            Dim ms As New System.IO.MemoryStream
            value.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

            Array.Resize(_foto, CInt(ms.Length))
            _foto = ms.ToArray
        End Set
    End Property

    Public ReadOnly Property Foto40() As System.Drawing.Image
        Get
            If _foto Is Nothing Then Return My.Resources.Blank
            Dim iWidth As Integer = CInt(Foto.Width * 40 \ Foto.Height)
            Dim ms As New System.IO.MemoryStream
            ms.Write(_foto, 0, _foto.Length)
            Return System.Drawing.Image.FromStream(ms).GetThumbnailImage(iWidth, 40, Nothing, Nothing)
        End Get
    End Property

#End Region

#Region " ToString "

    Public Overrides Function ToString() As String
        Return _name
    End Function

#End Region

#Region " C R U D L "

    Public Shared Function List() As Basisklassen.BindableIList(Of Owner)
        Dim o As New Owner
        Return New Basisklassen.BindableIList(Of Owner)(_persister.List(o))
    End Function

    Public Shared Function List(ByVal isOwner As Boolean) As Basisklassen.BindableIList(Of Owner)
        Dim o As New Owner
        o.isEigentümer = isOwner
        Return New Basisklassen.BindableIList(Of Owner)(_persister.List(o))
    End Function

#End Region

End Class
