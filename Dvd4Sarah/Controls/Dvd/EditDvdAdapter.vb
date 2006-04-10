Imports DotNetUC.Validation.ControlAdapter

''' <summary>
''' Adapter für den Validator zum Validieren des <see cref="EditDvd">Edit Dvd Steuerelementes</see>
''' </summary>
Public Class EditDvdAdapter
    Implements IControlAdapter

    ''' <summary>
    ''' Liest die Dvd auf dem Steuerelement aus
    ''' </summary>
    ''' <param name="control">Steuerelement vom Typ EditDvd</param>
    Public Function GetValue(ByVal control As System.Windows.Forms.Control) As Object Implements IControlAdapter.GetValue
        If TypeOf control Is EditDvd Then
            Return CType(control, EditDvd).Dvd
        Else
            Return Nothing
        End If
    End Function

End Class
