Imports DotNetUC.Validation.ControlAdapter

''' <summary>
''' Adapter für den Validator zum Validieren des <see cref="EditFsk">Edit FSK Steuerelementes</see>
''' </summary>
Public Class EditGenreAdapter
    Implements IControlAdapter

    ''' <summary>
    ''' Liest das Genre auf dem Steuerelement aus
    ''' </summary>
    ''' <param name="control">Steuerelement vom Typ EditGenre</param>
    Public Function GetValue(ByVal control As System.Windows.Forms.Control) As Object Implements IControlAdapter.GetValue
        If TypeOf control Is EditGenre Then
            Return CType(control, EditGenre).Genre
        Else
            Return Nothing
        End If
    End Function

End Class
