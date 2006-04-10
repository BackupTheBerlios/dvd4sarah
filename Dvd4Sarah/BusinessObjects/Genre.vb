
<System.ComponentModel.DefaultProperty("Name")> _
Public Class Genre
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

    Private _description As String

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Public ReadOnly Property DescriptionShort() As String
        Get
            If _description.Length > 300 Then Return _description.Substring(0, 300)
            Return _description
        End Get
    End Property

#End Region

#Region " Eigenschaft Logo "

    ''' <summary>
    ''' Speichern des Bildes als Byte-Array
    ''' </summary>
    Private _logo As Byte()

    ''' <summary>
    ''' Logo wird gewrappt Byte-Array, damti es von db4o gespeichert
    ''' werden kann.
    ''' </summary>
    Public Property Logo() As System.Drawing.Image
        Get
            If _logo Is Nothing Then Return My.Resources.Blank

            If _logo.Length > 0 Then
                Dim ms As New System.IO.MemoryStream
                ms.Write(_logo, 0, _logo.Length)
                Return System.Drawing.Image.FromStream(ms)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As System.Drawing.Image)
            If value Is Nothing Then
                Array.Resize(_logo, 0)
                _logo = Nothing
                Exit Property
            End If

            Dim ms As New System.IO.MemoryStream
            value.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

            Array.Resize(_logo, CInt(ms.Length))
            _logo = ms.ToArray
        End Set
    End Property

    Public ReadOnly Property Logo24() As System.Drawing.Image
        Get
            If _logo Is Nothing Then Return My.Resources.Blank
            Dim iWidth As Integer = CInt(Logo.Width * 24 \ Logo.Height)
            Dim ms As New System.IO.MemoryStream
            ms.Write(_logo, 0, _logo.Length)
            Return System.Drawing.Image.FromStream(ms).GetThumbnailImage(iWidth, 24, Nothing, Nothing)
        End Get
    End Property

#End Region

#Region " ToString "

    Public Overrides Function ToString() As String
        Return _name
    End Function

#End Region

#Region " C R U D L "

    Public Shared Function List() As Basisklassen.BindableIList(Of Genre)
        Dim o As New Genre
        Return New Basisklassen.BindableIList(Of Genre)(_persister.List(o))
    End Function

#End Region

End Class
