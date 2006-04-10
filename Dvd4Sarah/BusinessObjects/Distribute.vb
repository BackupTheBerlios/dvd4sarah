Public Class Distribute
    Inherits BoBase

#Region " Eigenschaft Dvd As Dvd = Nothing "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft Dvd.
    ''' Default ist Nothing
    ''' </summary>
    Private _Dvd As Dvd = Nothing

    ''' <summary>
    ''' Eigenschaft Dvd
    ''' </summary>
    Public Property Dvd() As Dvd
        Get
            Return (Me._Dvd)
        End Get
        Set(ByVal Value As Dvd)
            Me._Dvd = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft Lender As Owner = Nothing "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft Lender.
    ''' Default ist Nothing
    ''' </summary>
    Private _Lender As Owner = Nothing

    ''' <summary>
    ''' Eigenschaft Lender
    ''' </summary>
    Public Property Lender() As Owner
        Get
            Return (Me._Lender)
        End Get
        Set(ByVal Value As Owner)
            Me._Lender = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft LeihDatum As Date = Date.Now "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft LeihDatum.
    ''' Default ist Date.Now
    ''' </summary>
    Private _LeihDatum As Date = Date.Now

    ''' <summary>
    ''' Eigenschaft LeihDatum
    ''' </summary>
    Public Property LeihDatum() As Date
        Get
            Return (Me._LeihDatum)
        End Get
        Set(ByVal Value As Date)
            Me._LeihDatum = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft ZuruechDatum As Date = Date.Now.AddDays(7) "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft ZuruechDatum.
    ''' Default ist Date.Now.AddDays(7)
    ''' </summary>
    Private _ZuruechDatum As Date = Date.Now.AddDays(7)

    ''' <summary>
    ''' Eigenschaft ZuruechDatum
    ''' </summary>
    Public Property ZuruechDatum() As Date
        Get
            Return (Me._ZuruechDatum)
        End Get
        Set(ByVal Value As Date)
            Me._ZuruechDatum = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft Bemerkung As String "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft Bemerkung.
    ''' Default ist Standard
    ''' </summary>
    Private _Bemerkung As String

    ''' <summary>
    ''' Eigenschaft Bemerkung
    ''' </summary>
    Public Property Bemerkung() As String
        Get
            Return (Me._Bemerkung)
        End Get
        Set(ByVal Value As String)
            Me._Bemerkung = Value
        End Set
    End Property

#End Region

#Region " Listen abfragen "

    Public Shared Function List() As Basisklassen.BindableIList(Of Distribute)
        Dim o As New Distribute
        Return New Basisklassen.BindableIList(Of Distribute)(_persister.List(o))
    End Function

#End Region

End Class
