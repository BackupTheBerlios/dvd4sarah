Imports DotNetUC.Validation

Public Class ValidatedControlValidator
    Implements Common.IValidator

#Region " Eigenschaft ValidatedControl As IValidatedControl "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft ValidatedControl.
    ''' </summary>
    Private _ValidatedControl As IValidatableControl

    ''' <summary>
    ''' Eigenschaft ValidatedControl
    ''' </summary>
    Public Property ValidatedControl() As IValidatableControl
        Get
            Return (Me._ValidatedControl)
        End Get
        Set(ByVal Value As IValidatableControl)
            Me._ValidatedControl = Value
        End Set
    End Property

#End Region

#Region " Schnittstelle IValidator "

    Public Function Validate(ByVal context As ValidationContext, ByVal value As Object) As ValidationInfo Implements IValidator.Validate
        Return ValidatedControl.State
    End Function

#End Region

End Class
