Imports DotNetUC.Validation.Common


''' <summary>
''' Hilfsfunktionen für Validation
''' </summary>
Public NotInheritable Class ValidationHelper

#Region " Verborgener Konstruktur "

    ''' <summary>
    ''' Konstruktor für die "NotInhertiable" Klasse verbergen. Dadurch ist
    ''' die Klasse nie instanziiert.
    ''' </summary>
    Private Sub New()
        MyBase.New()
    End Sub

#End Region

    Public Shared Function GetMaximumInfo(ByVal infos() As ValidationInfo) As ValidationInfo
        Dim summary As New ValidationInfo(ValidationSeverity.None, "")

        For Each info As ValidationInfo In infos
            If info.Severity > summary.Severity Then
                summary.Severity = info.Severity
                summary.Message = info.Message
            End If
        Next

        Return summary
    End Function

End Class
