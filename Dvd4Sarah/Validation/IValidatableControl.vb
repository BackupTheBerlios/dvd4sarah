Imports DotNetUC.Validation.Common

''' <summary>
''' Schnittstelle f�r Controls, die sich selber Validieren
''' </summary>
Public Interface IValidatableControl

    ReadOnly Property State() As ValidationInfo

    Event StateChanged As EventHandler(Of ValidationEventArgs)

End Interface
