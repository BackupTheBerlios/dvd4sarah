Imports DotNetUC.Validation.Common
Imports DotNetUC.Validation.ControlAdapter
Imports Softwarekueche.Dvd4Sarah.Validation

''' <summary>
''' Steuerelement zum Bearbeiten einer <see cref="BusinessObjects.dvd">DVD</see>
''' </summary>
Public Class EditDvd
    Implements IValidatableControl

#Region " Konstruktor "

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        rtbDescription.DataBindings.Add("Rtf", Me.bndDvd, "Description", True)
    End Sub

#End Region

#Region " Eigenschaft Dvd "

    ''' <summary>
    ''' Speichert den Wert für die DVD, die im Moment bearbeitet wird.
    ''' </summary>
    Private _dvd As BusinessObjects.Dvd

    ''' <summary>
    ''' Dvd, die im Moment bearbeitet wird.
    ''' </summary>
    Public Property Dvd() As BusinessObjects.Dvd
        Get
            Return _dvd
        End Get
        Set(ByVal value As BusinessObjects.Dvd)
            If Me.DesignMode Then Exit Property

            _dvd = value
            bndDvd.DataSource = _dvd

            If _dvd Is Nothing Then
                cmbOwner.SelectedItem = Nothing
                cmbGenre.SelectedItem = Nothing
                cmbFsk.SelectedItem = Nothing
            Else
                bndDvd.ResetBindings(False)
                If _dvd.Owner Is Nothing Then cmbOwner.Text = ""
                If _dvd.Genre Is Nothing Then cmbGenre.Text = ""
                If _dvd.FSK Is Nothing Then cmbFsk.Text = ""
            End If
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
            txtSubtitle.ReadOnly = value
            txtTitle.ReadOnly = value
            cmbOwner.Enabled = Not [ReadOnly]
            cmbGenre.Enabled = Not [ReadOnly]
            cmbFsk.Enabled = Not [ReadOnly]
            stripLogo.Enabled = Not [ReadOnly]
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
    ''' Läd die angezeige DVD und die Auswahllisten neu
    ''' </summary>
    Public Sub Reload()
        bndOwner.DataSource = BusinessObjects.Owner.List(True)
        If _dvd.Owner Is Nothing Then cmbOwner.Text = ""
        bndFsk.DataSource = BusinessObjects.FSK.List
        bndFsk.Sort = "MinAlter"
        If _dvd.FSK Is Nothing Then cmbFsk.Text = ""
        bndGenre.DataSource = BusinessObjects.Genre.List
        If _dvd.Genre Is Nothing Then cmbGenre.Text = ""
        bndDvd.ResetBindings(False)
    End Sub

#End Region

#Region " Eventhandler des Formulars und der Komponenten "

    ''' <summary>
    ''' Läd erstmalig die Auswahllisten
    ''' </summary>
    Private Sub EditDvd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.DesignMode Then Exit Sub
        Reload()
    End Sub

    Private Sub cmbOwner_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOwner.SelectedIndexChanged
        _dvd.Owner = CType(cmbOwner.SelectedItem, BusinessObjects.Owner)
    End Sub

    Private Sub cmbOwner_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOwner.TextChanged
        If cmbOwner.Text = "" Then cmbOwner.SelectedItem = Nothing
    End Sub

    Private Sub cmbFsk_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFsk.SelectedIndexChanged
        _dvd.FSK = CType(cmbFsk.SelectedItem, BusinessObjects.FSK)
    End Sub

    Private Sub cmbFsk_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFsk.TextChanged
        If cmbFsk.Text = "" Then cmbFsk.SelectedItem = Nothing
    End Sub

    Private Sub cmbGenre_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGenre.SelectedIndexChanged
        _dvd.Genre = CType(cmbGenre.SelectedItem, BusinessObjects.Genre)
    End Sub

    Private Sub cmbGenre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGenre.TextChanged
        If cmbGenre.Text = "" Then cmbGenre.SelectedItem = Nothing
    End Sub

    Private Sub pcbCover_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles pcbCover.DoubleClick
        If Not stripLogo.Enabled Then Exit Sub
        If ofdOpenImage.ShowDialog = DialogResult.OK Then
            _dvd.Cover = System.Drawing.Image.FromFile(ofdOpenImage.FileName)
            bndDvd.ResetBindings(False)
        End If
    End Sub

    Private Sub toolEntfernen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not stripLogo.Enabled Then Exit Sub
        If MessageBox.Show("Bild entfernen", "Entfernen", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        _dvd.Cover = Nothing
        bndDvd.ResetBindings(False)
    End Sub

#End Region

End Class
