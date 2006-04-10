Imports DotNetUC.Validation

''' <summary>
''' Validator zum �berpr�fen der L�nge einer Eingabe
''' </summary>
Public Class LengthValidator
    Implements Common.IValidator

#Region " Eigenschaft MinimumCheck As Boolean "

    ''' <summary>
    ''' Speichert den Wert f�r die Eigenschaft MinimumCheck.
    ''' </summary>
    Private _MinimumCheck As Boolean = True

    ''' <summary>
    ''' Eigenschaft MinimumCheck
    ''' </summary>
    <System.ComponentModel.DefaultValue(GetType(Boolean), "True")> _
    Public Property MinimumCheck() As Boolean
        Get
            Return (Me._MinimumCheck)
        End Get
        Set(ByVal Value As Boolean)
            Me._MinimumCheck = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft MinimumLength As Integer "

    ''' <summary>
    ''' Speichert den Wert f�r die Eigenschaft MinimumLength.
    ''' </summary>
    Private _MinimumLength As Integer = 1

    ''' <summary>
    ''' Eigenschaft MinimumLength
    ''' </summary>
    Public Property MinimumLength() As Integer
        Get
            Return (Me._MinimumLength)
        End Get
        Set(ByVal Value As Integer)
            Me._MinimumLength = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft MaximumCheck As Boolean "

    ''' <summary>
    ''' Speichert den Wert f�r die Eigenschaft MaximumCheck.
    ''' </summary>
    Private _MaximumCheck As Boolean = False

    ''' <summary>
    ''' Eigenschaft MaximumCheck
    ''' </summary>
    <System.ComponentModel.DefaultValue(GetType(Boolean), "False")> _
    Public Property MaximumCheck() As Boolean
        Get
            Return (Me._MaximumCheck)
        End Get
        Set(ByVal Value As Boolean)
            Me._MaximumCheck = Value
        End Set
    End Property

#End Region

#Region " Eigenschaft MaximumLength As Integer "

    ''' <summary>
    ''' Speichert den Wert f�r die Eigenschaft MaximumLength.
    ''' </summary>
    Private _MaximumLength As Integer

    ''' <summary>
    ''' Eigenschaft MaximumLength
    ''' </summary>
    Public Property MaximumLength() As Integer
        Get
            Return (Me._MaximumLength)
        End Get
        Set(ByVal Value As Integer)
            Me._MaximumLength = Value
        End Set
    End Property

#End Region

#Region " Schnittstelle IValidator "

    ''' <summary>
    ''' Validiert die L�nge des �bergebenen Strings.
    ''' </summary>
    ''' <param name="context">Context des Strings</param>
    ''' <param name="value">String</param>
    Public Function Validate(ByVal context As ValidationContext, ByVal value As Object) As ValidationInfo Implements IValidator.Validate
        If TypeOf value Is String Then
            Dim s As String = CType(value, String)
            If MinimumCheck AndAlso s.Length < MinimumLength Then Return New Common.ValidationInfo(Common.ValidationSeverity.Error, context.ErrorMessage)
            If MaximumCheck AndAlso s.Length > MaximumLength Then Return New Common.ValidationInfo(Common.ValidationSeverity.Error, context.ErrorMessage)
            Return Nothing
        End If

        Return New Common.ValidationInfo(Common.ValidationSeverity.Info, "Eingabe vom Typ '" & value.GetType().ToString() & "' kann nicht �berpr�ft werden")
    End Function

#End Region

End Class
