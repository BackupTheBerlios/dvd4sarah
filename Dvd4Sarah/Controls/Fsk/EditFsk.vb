Imports DotNetUC.Validation.Common
Imports DotNetUC.Validation.ControlAdapter
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Steuerelement zum Bearbeiten einer <see cref="BusinessObjects.FSK">FSK Einstufung</see>
''' </summary>
Public Class EditFsk
    Implements IValidatableControl

#Region " Konstruktor "

    ''' <summary>
    ''' Erstellt eine neue Instanz des FSK Editors
    ''' </summary>
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

#Region " Eigenschaft Fsk "

    ''' <summary>
    ''' Speichert den Wert für die Fsk, die im Moment bearbeitet wird.
    ''' </summary>
    Private _Fsk As BusinessObjects.FSK

    ''' <summary>
    ''' Fsk, die im Moment bearbeitet wird.
    ''' </summary>
    Public Property Fsk() As BusinessObjects.FSK
        Get
            Return _Fsk
        End Get
        Set(ByVal value As BusinessObjects.FSK)
            If Me.DesignMode Then Exit Property
            _Fsk = value
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
            txtName.ReadOnly = value
            nupMinAlter.ReadOnly = _readOnly
            toolHinzufügen.Enabled = Not _readOnly
            toolEntfernen.Enabled = Not _readOnly
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
        RaiseEvent StateChanged(Me, New ValidationEventArgs(_State))
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
    Private Sub bndFsk_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles bndFsk.BindingComplete
        _State = ValidationHelper.GetMaximumInfo(oControlValidator.DoValidation())
        RaiseEvent StateChanged(Me, New ValidationEventArgs(_State))
    End Sub

    ''' <summary>
    ''' Validieren, falls noch nicht erfolgt
    ''' </summary>
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DesignMode Then Exit Sub
        If _State Is Nothing Then bndFsk_BindingComplete(sender, Nothing)
    End Sub

#End Region

#Region " Methoden "

    ''' <summary>
    ''' Läd die angezeige Daten neu
    ''' </summary>
    Public Sub Reload()
        bndFsk.DataSource = _Fsk
        bndFsk.ResetBindings(False)
    End Sub

#End Region

#Region " Eventhandler Context.Logo "

    ''' <summary>
    ''' Hinzufügen eines Bildes
    ''' </summary>
    Private Sub pcbLogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles pcbLogo.DoubleClick, toolHinzufügen.Click
        If Not stripLogo.Enabled Then Exit Sub
        If ofdOpenImage.ShowDialog = DialogResult.OK Then
            _Fsk.Logo = System.Drawing.Image.FromFile(ofdOpenImage.FileName)
            bndFsk.ResetBindings(False)
        End If
    End Sub

    ''' <summary>
    ''' Entfernen eines Bildes
    ''' </summary>
    Private Sub toolEntfernen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles toolEntfernen.Click
        If Not stripLogo.Enabled Then Exit Sub
        If MessageBox.Show("Bild entfernen", "Entfernen", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        _Fsk.Logo = Nothing
        bndFsk.ResetBindings(False)
    End Sub

    ''' <summary>
    ''' Toggeln ob das Bild angepasst wird
    ''' </summary>
    Private Sub toolLogoSizeImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolLogoSizeImage.Click
        If toolLogoSizeImage.Checked Then
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pcbLogo.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

#End Region

End Class
