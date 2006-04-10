Imports DotNetUC.Validation.Formatting

Public Class AgeFormatter
    Implements IFormatter
    Implements IParser

    Public Function Format(ByVal owner As Object, ByVal value As Object) As Object Implements IFormatter.Format
        Return CStr(value) & " Jahre"
    End Function

    Public Function Parse(ByVal owner As Object, ByVal value As Object) As Object Implements IParser.Parse
        Return CStr(value).Split(" "c)(0)
    End Function

End Class
