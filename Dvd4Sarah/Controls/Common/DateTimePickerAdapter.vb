Imports DotNetUC.Validation.ControlAdapter

''' <summary>
''' Adapter zum Verbinden eines <see cref="System.Windows.Forms.DateTimePicker">DateTimePicker</see>
''' an einen Validator.
''' </summary>
Public Class DateTimePickerAdapter
    Implements IControlAdapter

    ''' <summary>
    ''' Gibt den Wert des DateTimePicker zurück.
    ''' </summary>
    ''' <param name="control">DateTimePicker Steuerelement mit dem zu validierenden Wert</param>
    Public Function GetValue(ByVal control As System.Windows.Forms.Control) As Object Implements IControlAdapter.GetValue
        If TypeOf control Is DateTimePicker Then
            Return CType(control, System.Windows.Forms.DateTimePicker).Value
        Else
            Return Nothing
        End If
    End Function

End Class
