Imports DotNetUC.Validation.Common

''' <summary>
''' Prüft, ob eine Eingabe (Double) zwischen zwei Werten liegt.
''' </summary>
Public Class BetweenValidator
    Implements IValidator

#Region " Eigenschaft UpperBound As Decimal "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft UpperBound.
    ''' </summary>
    Private _UpperBound As Decimal
    ''' <summary>
    ''' Eigenschaft UpperBound
    ''' </summary>
    Public Property UpperBound() As Decimal
        Get
            Return (Me._UpperBound)
        End Get
        Set(ByVal Value As Decimal)
            Me._UpperBound = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft LowerBound As Decimal "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft LowerBound.
    ''' </summary>
    Private _LowerBound As Decimal
    ''' <summary>
    ''' Eigenschaft LowerBound
    ''' </summary>
    Public Property LowerBound() As Decimal
        Get
            Return (Me._LowerBound)
        End Get
        Set(ByVal Value As Decimal)
            Me._LowerBound = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft ExcludeBound As Boolean "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft ExcludeBound.
    ''' </summary>
    Private _ExcludeBound As Boolean
    ''' <summary>
    ''' Eigenschaft ExcludeBound
    ''' </summary>
    Public Property ExcludeBound() As Boolean
        Get
            Return (Me._ExcludeBound)
        End Get
        Set(ByVal Value As Boolean)
            Me._ExcludeBound = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft Severity As ValidationSeverity "

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft Severity.
    ''' </summary>
    Private _Severity As ValidationSeverity = ValidationSeverity.Warning
    ''' <summary>
    ''' Eigenschaft Severity
    ''' </summary>
    Public Property Severity() As ValidationSeverity
        Get
            Return (Me._Severity)
        End Get
        Set(ByVal Value As ValidationSeverity)
            Me._Severity = Value
        End Set
    End Property

#End Region

#Region " Schnittstelle IValidator "

    Public Function Validate(ByVal context As ValidationContext, ByVal value As Object) As ValidationInfo Implements IValidator.Validate
        If UpperBound <= LowerBound Then Return Nothing

        Dim msg As String = "Die Eingabe muss zwischen " & CStr(LowerBound) & " und " & CStr(UpperBound) & " liegen"

        If TypeOf value Is Decimal Then
            Dim v As Decimal = CType(value, Decimal)

            If _ExcludeBound Then
                If v <= LowerBound Then Return New ValidationInfo(Severity, msg)
                If v >= UpperBound Then Return New ValidationInfo(Severity, msg)
            Else
                If v < LowerBound Then Return New ValidationInfo(Severity, msg)
                If v > UpperBound Then Return New ValidationInfo(Severity, msg)
            End If

            Return Nothing
        End If

        Return New ValidationInfo(ValidationSeverity.Info, "Eingabe ist vom falschen Typ")

    End Function

#End Region

End Class
