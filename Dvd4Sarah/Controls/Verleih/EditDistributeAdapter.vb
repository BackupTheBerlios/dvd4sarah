Imports DotNetUC.Validation.ControlAdapter

''' <summary>
''' Adapter für den Validator zum Validieren des <see cref="EditFsk">Edit FSK Steuerelementes</see>
''' </summary>
Public Class EditDistributeAdapter
    Implements IControlAdapter

    ''' <summary>
    ''' Liest das Owner auf dem Steuerelement aus
    ''' </summary>
    ''' <param name="control">Steuerelement vom Typ EditOwner</param>
    Public Function GetValue(ByVal control As System.Windows.Forms.Control) As Object Implements IControlAdapter.GetValue
        If TypeOf control Is EditDistribute Then
            Return CType(control, EditDistribute).Distribute
        Else
            Return Nothing
        End If
    End Function

End Class
