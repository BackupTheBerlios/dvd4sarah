Imports DotNetUC.Validation.Common
Imports DotNetUC.Validation.ControlAdapter
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Steuerelement zum Bearbeiten einer <see cref="BusinessObjects.Genre">Genre</see>
''' </summary>
Public Class EditGenre
    Implements IValidatableControl

#Region " Konstruktor "

    ''' <summary>
    ''' Erstellt eine neue Instanz des Genre-Editors
    ''' </summary>
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

#Region " Eigenschaft Genre "

    ''' <summary>
    ''' Speichert den Wert f�r die Genre, die im Moment bearbeitet wird.
    ''' </summary>
    Private _Genre As BusinessObjects.Genre

    ''' <summary>
    ''' Genre, die im Moment bearbeitet wird.
    ''' </summary>
    Public Property Genre() As BusinessObjects.Genre
        Get
            Return _Genre
        End Get
        Set(ByVal value As BusinessObjects.Genre)
            If Me.DesignMode Then Exit Property
            _Genre = value
            Reload()
        End Set
    End Property

#End Region

#Region " Eigenschaft ReadOnly "

    ''' <summary>
    ''' Speichert den Wert f�r die ReadOnly Eigenschaft
    ''' </summary>
    Private _readOnly As Boolean

    ''' <summary>
    ''' Gibt an, ob die Felder bearbeitet oder nur gelesen werden d�rfen
    ''' </summary>
    ''' <returns>Ob die Daten nur gelesen werden d�rfen</returns>
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
    ''' Ereignis, wenn sich der Status des Validator �ndert. Setzen des State und werfen des
    ''' <see cref="StateChanged">StateChanged Events</see>
    ''' </summary>
    Private Sub oControlValidator_ValidationChanged(ByVal control As System.Windows.Forms.Control, ByVal info As ValidationInfo) Handles oControlValidator.ValidationChanged
        _State = info
        RaiseEvent StateChanged(Me, New ValidationEventArgs(info))
    End Sub

    ''' <summary>
    ''' Speichert den Wert f�r die Eigenschaft State.
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
    ''' Erstmaliges ausf�hren des Validation nach dem Binden der BindingSource.
    ''' </summary>
    Private Sub bndGenre_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles bndGenre.BindingComplete
        _State = ValidationHelper.GetMaximumInfo(oControlValidator.DoValidation())
        RaiseEvent StateChanged(Me, New ValidationEventArgs(_State))
    End Sub

    ''' <summary>
    ''' Validieren, falls noch nicht erfolgt
    ''' </summary>
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DesignMode Then Exit Sub
        If _State Is Nothing Then bndGenre_BindingComplete(sender, Nothing)
    End Sub

#End Region

#Region " Methoden "

    ''' <summary>
    ''' L�d die angezeige Daten neu
    ''' </summary>
    Public Sub Reload()
        bndGenre.DataSource = _Genre
        bndGenre.ResetBindings(False)
    End Sub

#End Region

#Region " Eventhandler "

    ''' <summary>
    ''' Hinzuf�gen des Bildes
    ''' </summary>
    Private Sub pcbLogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles pcbLogo.DoubleClick, toolHinzuf�gen.Click
        If Not stripLogo.Enabled Then Exit Sub
        If ofdOpenImage.ShowDialog = DialogResult.OK Then
            _Genre.Logo = System.Drawing.Image.FromFile(ofdOpenImage.FileName)
            bndGenre.ResetBindings(False)
        End If
    End Sub

    ''' <summary>
    ''' Entfernen des Bildes
    ''' </summary>
    Private Sub toolEntfernen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles toolEntfernen.Click
        If Not stripLogo.Enabled Then Exit Sub
        If MessageBox.Show("Bild entfernen", "Entfernen", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        _Genre.Logo = Nothing
        bndGenre.ResetBindings(False)
    End Sub

    ''' <summary>
    ''' Toggelt die automatische Gr��enanpassung
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
