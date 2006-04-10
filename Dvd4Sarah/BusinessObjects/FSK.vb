
<System.ComponentModel.DefaultProperty("Name")> _
Public Class FSK
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

    Private _minAlter As Integer

    Public Property MinAlter() As Integer
        Get
            Return _minAlter
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then value = 0
            _minAlter = value
        End Set
    End Property

#End Region

#Region " Eigenschaft Logo "

    ''' <summary>
    ''' Speichern des Bildes als Byte-Array
    ''' </summary>
    Private _Logo As Byte()

    ''' <summary>
    ''' Logo wird gewrappt Byte-Array, damti es von db4o gespeichert
    ''' werden kann.
    ''' </summary>
    Public Property Logo() As System.Drawing.Image
        Get
            If _Logo Is Nothing Then Return My.Resources.Blank

            If _Logo.Length > 0 Then
                Dim ms As New System.IO.MemoryStream
                ms.Write(_Logo, 0, _Logo.Length)
                Return System.Drawing.Image.FromStream(ms)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As System.Drawing.Image)
            If value Is Nothing Then
                Array.Resize(_Logo, 0)
                _Logo = Nothing
                Exit Property
            End If

            Dim ms As New System.IO.MemoryStream
            value.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

            Array.Resize(_Logo, CInt(ms.Length))
            _Logo = ms.ToArray
        End Set
    End Property

    Public ReadOnly Property Logo24() As System.Drawing.Image
        Get
            If _Logo Is Nothing Then Return My.Resources.Blank
            Dim iWidth As Integer = CInt(Logo.Width * 24 \ Logo.Height)
            Dim ms As New System.IO.MemoryStream
            ms.Write(_Logo, 0, _Logo.Length)
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

    Public Shared Function List() As Basisklassen.BindableIList(Of FSK)
        Dim o As New FSK
        Return New Basisklassen.BindableIList(Of FSK)(_persister.List(o))
    End Function

#End Region

End Class
