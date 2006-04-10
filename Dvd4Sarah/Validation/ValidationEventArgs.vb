Imports DotNetUC.Validation.Common

Public Class ValidationEventArgs
    Inherits EventArgs

#Region " Eigenschaft Info As ValidationInfo "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft Info.
    ''' </summary>
    Private _Info As ValidationInfo
    ''' <summary>
    ''' Eigenschaft Info
    ''' </summary>
    Public Property Info() As ValidationInfo
        Get
            Return (Me._Info)
        End Get
        Set(ByVal Value As ValidationInfo)
            Me._Info = Value
        End Set
    End Property

#End Region

#Region " Konstruktor "

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal info As ValidationInfo)
        _Info = info
    End Sub

#End Region

End Class
