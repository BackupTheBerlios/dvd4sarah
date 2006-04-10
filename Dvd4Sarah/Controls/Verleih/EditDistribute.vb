Imports DotNetUC.Validation.Common
Imports DotNetUC.Validation.ControlAdapter
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Steuerelement zum Bearbeiten einer <see cref="BusinessObjects.Distribute">Distribute</see>
''' </summary>
Public Class EditDistribute
    Implements IValidatableControl

#Region " Konstruktor "

    ''' <summary>
    ''' Erstellt eine neue Instanz des Distribute-Editors
    ''' </summary>
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

#Region " Eigenschaft Distribute "

    ''' <summary>
    ''' Speichert den Wert für die Distribute, die im Moment bearbeitet wird.
    ''' </summary>
    Private _Distribute As BusinessObjects.Distribute

    ''' <summary>
    ''' Distribute, die im Moment bearbeitet wird.
    ''' </summary>
    Public Property Distribute() As BusinessObjects.Distribute
        Get
            Return _Distribute
        End Get
        Set(ByVal value As BusinessObjects.Distribute)
            If Me.DesignMode Then Exit Property
            _Distribute = value
            Reload()
        End Set
    End Property

#End Region

#Region " Eigenschaft ReadOnly "

    ''' <summary>
    ''' Speichert den Wert für die ReadOnly Eigenschaft
    ''' </summary>
    Private _readOnly As Boolean

    ''' <summary>
    ''' Gibt an, ob die Felder bearbeitet oder nur gelesen werden dürfen
    ''' </summary>
    ''' <returns>Ob die Daten nur gelesen werden dürfen</returns>
    <System.ComponentModel.DefaultValue(GetType(Boolean), "False")> _
    Public Property [ReadOnly]() As Boolean
        Get
            Return _readOnly
        End Get
        Set(ByVal value As Boolean)
            _readOnly = value
            txtBemerkung.ReadOnly = value
            dtpLeihen.Enabled = Not value
            dtpZurueck.Enabled = Not value
        End Set
    End Property
#End Region

#Region " Eigenschaft State As ValidationInfo "

    ''' <summary>
    ''' Ereignis zum Durchreichen des ValidationChanged Events.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event StateChanged(ByVal sender As Object, ByVal e As ValidationEventArgs) Implements Validation.IValidatableControl.StateChanged

    ''' <summary>
    ''' Ereignis, wenn sich der Status des Validator ändert. Setzen des State und werfen des
    ''' <see cref="StateChanged">StateChanged Events</see>
    ''' </summary>
    Private Sub oControlValidator_ValidationChanged(ByVal control As System.Windows.Forms.Control, ByVal info As ValidationInfo) Handles oControlValidator.ValidationChanged
        _State = info
        RaiseEvent StateChanged(Me, New ValidationEventArgs(info))
    End Sub

    ''' <summary>
    ''' Speichert den Wert für die Eigenschaft State.
    ''' </summary>
    Private _State As ValidationInfo

    ''' <summary>
    ''' Eigenschaft State
    ''' </summary>
    Public ReadOnly Property State() As ValidationInfo Implements IValidatableControl.State
        Get
            Return (Me._State)
        End Get
    End Property

    ''' <summary>
    ''' Erstmaliges ausführen des Validation nach dem Binden der BindingSource.
    ''' </summary>
    Private Sub bndDistribute_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles bndDistribute.BindingComplete
        _State = ValidationHelper.GetMaximumInfo(oControlValidator.DoValidation())
        RaiseEvent StateChanged(Me, New ValidationEventArgs(_State))
    End Sub

    ''' <summary>
    ''' Validieren, falls noch nicht erfolgt
    ''' </summary>
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DesignMode Then Exit Sub
        If _State Is Nothing Then bndDistribute_BindingComplete(sender, Nothing)
    End Sub

#End Region

#Region " Methoden "

    ''' <summary>
    ''' Läd die angezeige Daten neu
    ''' </summary>
    Public Sub Reload()
        bndDistribute.DataSource = _Distribute
        bndDistribute.ResetBindings(True)
    End Sub

#End Region

#Region " Eventhandler "

#End Region

End Class
