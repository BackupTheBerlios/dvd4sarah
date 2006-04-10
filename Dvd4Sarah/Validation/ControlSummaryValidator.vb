Imports DotNetUC.Validation.Common

Public Class ControlSummaryValidator
    Implements IFormValidator

    Public Function Validate(ByVal context As ValidationContext, ByVal infos() As ValidationInfo) As ValidationInfo Implements IFormValidator.Validate
        Dim sv As ValidationSeverity = ValidationSeverity.None

        For Each inf As ValidationInfo In infos
            If inf.Severity > sv Then sv = inf.Severity
        Next

        Select Case sv
            Case ValidationSeverity.Info
                Return New ValidationInfo(sv, context.InfoMessage)
            Case ValidationSeverity.Warning
                Return New ValidationInfo(sv, context.WarningMessage)
            Case ValidationSeverity.Error
                Return New ValidationInfo(sv, context.ErrorMessage)
            Case Else
                Return Nothing
        End Select
    End Function

End Class
