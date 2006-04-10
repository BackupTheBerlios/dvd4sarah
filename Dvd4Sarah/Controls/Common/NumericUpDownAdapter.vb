Imports DotNetUC.Validation.ControlAdapter

''' <summary>
''' Adapter zum Verbinden eines <see cref="System.Windows.Forms.NumericUpDown">NumericUpDown</see>
''' an einen Validator.
''' </summary>
Public Class NumericUpDownAdapter
    Implements IControlAdapter

    ''' <summary>
    ''' Gibt den Wert des NumericUpDown zurück.
    ''' </summary>
    ''' <param name="control">NumericUpDown Steuerelement mit dem zu validierenden Wert</param>
    Public Function GetValue(ByVal control As System.Windows.Forms.Control) As Object Implements IControlAdapter.GetValue
        If TypeOf control Is NumericUpDown Then
            Return CType(control, System.Windows.Forms.NumericUpDown).Value
        Else
            Return Nothing
        End If
    End Function

End Class
