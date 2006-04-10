Imports DotNetUC.Validation.ControlAdapter

''' <summary>
''' Adapter für den Validator zum Validieren des <see cref="EditFsk">Edit FSK Steuerelementes</see>
''' </summary>
Public Class EditFskAdapter
    Implements IControlAdapter

    ''' <summary>
    ''' Liest die FSK auf dem Steuerelement aus
    ''' </summary>
    ''' <param name="control">Steuerelement vom Typ EditFsk</param>
    Public Function GetValue(ByVal control As System.Windows.Forms.Control) As Object Implements IControlAdapter.GetValue
        If TypeOf control Is EditFsk Then
            Return CType(control, EditFsk).Fsk
        Else
            Return Nothing
        End If
    End Function

End Class
