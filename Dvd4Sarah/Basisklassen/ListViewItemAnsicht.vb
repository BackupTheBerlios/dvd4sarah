
Public Enum AnsichtTyp As Integer
    DVDs = 0
    Personen = 1
    FSK = 2
    Genre = 3
    Verleih = 4
End Enum

Public Class ListViewItemAnsicht
    Inherits System.Windows.Forms.ListViewItem

#Region " Eigenschaft Ansicht As AnsichtTyp"

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft Ansicht.
    ''' </summary>
    Private _Ansicht As AnsichtTyp = AnsichtTyp.DVDs

    ''' <summary>
    ''' Eigenschaft Ansicht
    ''' </summary>
    Public Property Ansicht() As AnsichtTyp
        Get
            Return (Me._Ansicht)
        End Get
        Set(ByVal Value As AnsichtTyp)
            Me._Ansicht = Value
        End Set
    End Property

#End Region

End Class
