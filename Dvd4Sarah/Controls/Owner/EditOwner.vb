Imports DotNetUC.Validation.Common
Imports DotNetUC.Validation.ControlAdapter
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Steuerelement zum Bearbeiten einer <see cref="BusinessObjects.Owner">Owner</see>
''' </summary>
Public Class EditOwner
    Implements IValidatableControl

#Region " Konstruktor "

    ''' <summary>
    ''' Erstellt eine neue Instanz des Owner-Editors
    ''' </summary>
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

#Region " Eigenschaft Owner "

    ''' <summary>
    ''' Speichert den Wert für die Owner, die im Moment bearbeitet wird.
    ''' </summary>
    Private _Owner As BusinessObjects.Owner

    ''' <summary>
    ''' Owner, die im Moment bearbeitet wird.
    ''' </summary>
    Public Property Owner() As BusinessObjects.Owner
        Get
            Return _Owner
        End Get
        Set(ByVal value As BusinessObjects.Owner)
            If Me.DesignMode Then Exit Property
            _Owner = value
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
    Private Sub bndOwner_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles bndOwner.BindingComplete
        _State = ValidationHelper.GetMaximumInfo(oControlValidator.DoValidation())
        RaiseEvent StateChanged(Me, New ValidationEventArgs(_State))
    End Sub

    ''' <summary>
    ''' Validieren, falls noch nicht erfolgt
    ''' </summary>
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DesignMode Then Exit Sub
        If _State Is Nothing Then bndOwner_BindingComplete(sender, Nothing)
    End Sub

#End Region

#Region " Methoden "

    ''' <summary>
    ''' Läd die angezeige Daten neu
    ''' </summary>
    Public Sub Reload()
        bndOwner.DataSource = _Owner
        bndOwner.ResetBindings(True)
    End Sub

#End Region

#Region " Eventhandler "

    ''' <summary>
    ''' Hinzufügen des Bildes
    ''' </summary>
    Private Sub pcbFoto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles pcbLogo.DoubleClick, toolHinzufügen.Click
        If Not stripLogo.Enabled Then Exit Sub
        If ofdOpenImage.ShowDialog = DialogResult.OK Then
            _Owner.Foto = System.Drawing.Image.FromFile(ofdOpenImage.FileName)
            bndOwner.ResetBindings(False)
        End If
    End Sub

    ''' <summary>
    ''' Entfernen des Bildes
    ''' </summary>
    Private Sub toolEntfernen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles toolEntfernen.Click
        If Not stripLogo.Enabled Then Exit Sub
        If MessageBox.Show("Bild entfernen", "Entfernen", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        _Owner.Foto = Nothing
        bndOwner.ResetBindings(False)
    End Sub

    ''' <summary>
    ''' Toggelt die automatische Größenanpassung
    ''' </summary>
    Private Sub toolFotoSizeImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolLogoSizeImage.Click
        If toolLogoSizeImage.Checked Then
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pcbLogo.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

#End Region

End Class
