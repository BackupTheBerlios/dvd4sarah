Imports System.Reflection

Public Class BindableIList(Of keyType As Class)
    Implements System.ComponentModel.IBindingList
    Implements System.ComponentModel.IBindingListView

    Public Event ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Implements System.ComponentModel.IBindingList.ListChanged

#Region " Logger (log4net) "

    ''' <summary>
    ''' Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
    ''' wird durch den Namespace die Logger-Hierarchie aufgebaut.
    ''' </summary>
    ''' <remarks>Mehr siehe <a href="http://logging.apache.org/log4net/">http://logging.apache.org/log4net/</a> </remarks>
    Private Shared ReadOnly log As Global.log4net.ILog = Global.log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

#End Region

#Region " Konstruktur / Member "

    Private WithEvents _list As IList
    Private _array() As keyType

    Private Shared ReadOnly oLog As Global.log4net.ILog = Global.log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    Private Sub CreateArray()
        If log.IsDebugEnabled Then log.Debug("Array wird neu erstellt")
        Dim a(_list.Count - 1) As keyType
        _list.CopyTo(a, 0)
        _array = a
    End Sub

    Public Sub New()
        MyBase.New()
        If oLog.IsDebugEnabled Then oLog.Debug("BindableIList erzeugt für " & GetType(keyType).ToString)
        _list = New List(Of keyType)
        CreateArray()
    End Sub

    Public Sub New(ByVal List As IList)
        MyBase.New()
        If oLog.IsDebugEnabled Then oLog.Debug("BindableIList erzeugt für " & GetType(keyType).ToString)
        If List Is Nothing Then
            If oLog.IsDebugEnabled Then oLog.Warn("Bag ist Nothing. Leere Liste wird erzeugt.")
            List = New List(Of keyType)
        End If
        _list = List
        CreateArray()
    End Sub

#End Region

#Region " IList "
    Public Sub CopyTo(ByVal array As System.Array, ByVal index As Integer) Implements System.Collections.ICollection.CopyTo
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: CopyTo")
        _list.CopyTo(array, index)
    End Sub

    Public Sub CopyTo(ByVal array As keyType(), ByVal index As Integer)
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: CopyTo")
        _list.CopyTo(array, index)
    End Sub

    Public ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
        Get
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Count")
            Return _list.Count
        End Get
    End Property

    Public ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
        Get
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: IsSynchronized")
            Return _list.IsSynchronized
        End Get
    End Property

    Public ReadOnly Property SyncRoot() As Object Implements System.Collections.ICollection.SyncRoot
        Get
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: SyncRoot")
            Return _list.SyncRoot
        End Get
    End Property

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: GetEnumerator")
        Return _list.GetEnumerator
    End Function

    Private Function Add(ByVal value As Object) As Integer Implements System.Collections.IList.Add
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Add (Private)")
        Dim res As Integer
        res = _list.Add(value)
        CreateArray()
        Return res
    End Function

    Public Function Add(ByVal value As keyType) As Integer
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Add (Private)")
        Dim res As Integer
        res = _list.Add(value)
        CreateArray()
        RaiseEvent ListChanged(Me, New System.ComponentModel.ListChangedEventArgs(ComponentModel.ListChangedType.ItemAdded, Me.Count - 1))
        Return res
    End Function

    Public Sub Clear() Implements System.Collections.IList.Clear
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Clear")
        _list.Clear()
        CreateArray()
        RaiseEvent ListChanged(Me, New System.ComponentModel.ListChangedEventArgs(ComponentModel.ListChangedType.Reset, 0))
    End Sub

    Public Function Contains(ByVal value As Object) As Boolean Implements System.Collections.IList.Contains
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Contains")
        Return _list.Contains(value)
    End Function

    Public Function IndexOf(ByVal value As Object) As Integer Implements System.Collections.IList.IndexOf
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: IndexOf")
        Return _list.IndexOf(value)
    End Function

    Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements System.Collections.IList.Insert
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Insert (Public)")
        _list.Insert(index, value)
        CreateArray()
        RaiseEvent ListChanged(Me, New System.ComponentModel.ListChangedEventArgs(ComponentModel.ListChangedType.ItemAdded, index))
    End Sub

    Public ReadOnly Property IsFixedSize() As Boolean Implements System.Collections.IList.IsFixedSize
        Get
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: IsFixedSize")
            Return _list.IsFixedSize
        End Get
    End Property

    Public ReadOnly Property IsReadOnly() As Boolean Implements System.Collections.IList.IsReadOnly
        Get
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: IsReadOnly")
            Return _list.IsReadOnly
        End Get
    End Property

    Private Property Item_Untyped(ByVal index As Integer) As Object Implements System.Collections.IList.Item
        Get
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Private Item_Untyped (Get)")
            Return _array(index)
        End Get
        Set(ByVal value As Object)
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Private Item_Untyped (Set)")
            If Not TypeOf value Is keyType Then
                If oLog.IsDebugEnabled Then oLog.Debug("Item ist nicht vom richtigen Typ")
                Exit Property
            End If
            _list.Item(index) = value
            CreateArray()
            RaiseEvent ListChanged(Me, New System.ComponentModel.ListChangedEventArgs(ComponentModel.ListChangedType.ItemChanged, index))
        End Set
    End Property

    Default Public Property Item(ByVal index As Integer) As keyType
        Get
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Public Item (Get)")
            Return CType(_array(index), keyType)
        End Get
        Set(ByVal value As keyType)
            If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Public Item (Set)")
            _list.Item(index) = value
            CreateArray()
            RaiseEvent ListChanged(Me, New System.ComponentModel.ListChangedEventArgs(ComponentModel.ListChangedType.ItemChanged, index))
        End Set
    End Property

    Public Sub Remove(ByVal value As Object) Implements System.Collections.IList.Remove
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: Remove")
        Dim i As Integer = _list.IndexOf(value)
        _list.Remove(value)
        CreateArray()
        RaiseEvent ListChanged(Me, New System.ComponentModel.ListChangedEventArgs(ComponentModel.ListChangedType.ItemDeleted, i))
    End Sub

    Public Sub RemoveAt(ByVal index As Integer) Implements System.Collections.IList.RemoveAt
        If oLog.IsDebugEnabled Then oLog.Debug("TypedBag: RemoveAt")
        _list.RemoveAt(index)
        CreateArray()
        RaiseEvent ListChanged(Me, New System.ComponentModel.ListChangedEventArgs(ComponentModel.ListChangedType.ItemChanged, index))
    End Sub
#End Region

#Region " IBindingList "

    Private _sortDirection As System.ComponentModel.ListSortDirection

    Private _isSorted As Boolean

    Private _sortProperty As System.ComponentModel.PropertyDescriptor

    Private _indizes As List(Of System.ComponentModel.PropertyDescriptor)

    Public Sub AddIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements System.ComponentModel.IBindingList.AddIndex
        If log.IsDebugEnabled Then log.Debug("AddIndex")
        _indizes.Add([property])
    End Sub

    Public Function AddNew() As Object Implements System.ComponentModel.IBindingList.AddNew
        Dim obj As keyType = CType(Activator.CreateInstance(GetType(keyType)), keyType)
        Me._list.Add(obj)
        Return obj
    End Function

    Public ReadOnly Property AllowEdit() As Boolean Implements System.ComponentModel.IBindingList.AllowEdit
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property AllowNew() As Boolean Implements System.ComponentModel.IBindingList.AllowNew
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property AllowRemove() As Boolean Implements System.ComponentModel.IBindingList.AllowRemove
        Get
            Return True
        End Get
    End Property

    Public Sub ApplySort(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection) Implements System.ComponentModel.IBindingList.ApplySort
        If [property] Is Nothing Then
            _isSorted = False
            _sortProperty = Nothing
            Exit Sub
        End If

        'If Not _sortProperty Is Nothing AndAlso _sortProperty.Name = [property].Name AndAlso _sortDirection = direction Then Exit Sub
        _sortProperty = [property]
        _sortDirection = direction


        ' Suchen, ob die Sortierung unterstützt wird
        Dim bSupportSorting As Boolean
        For Each inf As Type In [property].PropertyType.GetInterfaces
            If inf.FullName.CompareTo(GetType(IComparable).FullName) = 0 Then
                bSupportSorting = True
                Exit For
            End If
        Next

        If Not bSupportSorting Or _array.Length = 0 Then
            _isSorted = False
            Exit Sub
        End If

        ' Aus Performace Gründen wird das If mit dem Größer/Kleiner gespart
        Select Case direction
            Case ComponentModel.ListSortDirection.Ascending
                Dim kleinstesElement As Integer
                Dim kleinsterWert As Object
                Dim vergleichWert As Object
                Dim swap As keyType
                Dim fld As PropertyInfo

                For i As Integer = 0 To Count - 1
                    kleinstesElement = i
                    fld = _array(0).GetType.GetProperty(_sortProperty.Name, BindingFlags.Public Or BindingFlags.GetProperty Or BindingFlags.Instance)
                    kleinsterWert = fld.GetValue(_array(i), BindingFlags.GetProperty, Nothing, Nothing, Globalization.CultureInfo.CurrentCulture)

                    For j As Integer = i + 1 To Count - 1
                        fld = GetType(keyType).GetProperty(_sortProperty.Name, BindingFlags.Public Or BindingFlags.SetProperty Or BindingFlags.Instance)
                        vergleichWert = fld.GetValue(_array(j), BindingFlags.GetProperty, Nothing, Nothing, Globalization.CultureInfo.CurrentCulture)
                        If CType(kleinsterWert, IComparable).CompareTo(vergleichWert) > 0 Then
                            kleinstesElement = j
                            kleinsterWert = vergleichWert
                        End If
                    Next

                    Try
                        If kleinstesElement > i Then 'Tauschen
                            swap = _array(i)
                            _array(i) = _array(kleinstesElement)
                            _array(kleinstesElement) = swap
                        End If
                    Catch ex As Exception
                        If oLog.IsErrorEnabled Then oLog.Error("Liste kann nicht sortiert werden", ex)
                        Exit Sub
                    End Try
                Next

            Case ComponentModel.ListSortDirection.Descending
                Dim kleinstesElement As Integer
                Dim kleinsterWert As Object
                Dim vergleichWert As Object
                Dim swap As keyType
                Dim fld As PropertyInfo

                For i As Integer = 0 To Count - 1
                    kleinstesElement = i
                    fld = _array(0).GetType.GetProperty(_sortProperty.Name, BindingFlags.Public Or BindingFlags.GetProperty Or BindingFlags.Instance)
                    kleinsterWert = fld.GetValue(_array(i), BindingFlags.GetProperty, Nothing, Nothing, Globalization.CultureInfo.CurrentCulture)

                    For j As Integer = i + 1 To Count - 1
                        fld = GetType(keyType).GetProperty(_sortProperty.Name, BindingFlags.Public Or BindingFlags.SetProperty Or BindingFlags.Instance)
                        vergleichWert = fld.GetValue(_array(j), BindingFlags.GetProperty, Nothing, Nothing, Globalization.CultureInfo.CurrentCulture)
                        If CType(kleinsterWert, IComparable).CompareTo(vergleichWert) < 0 Then
                            kleinstesElement = j
                            kleinsterWert = vergleichWert
                        End If
                    Next

                    Try
                        If kleinstesElement > i Then 'Tauschen
                            swap = _array(i)
                            _array(i) = _array(kleinstesElement)
                            _array(kleinstesElement) = swap
                        End If
                    Catch ex As Exception
                        If oLog.IsErrorEnabled Then oLog.Error("Liste kann nicht sortiert werden", ex)
                        Exit Sub
                    End Try
                Next
        End Select
    End Sub

    Public Function Find(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal key As Object) As Integer Implements System.ComponentModel.IBindingList.Find
        Dim fld As PropertyInfo
        Dim wert As Object

        ' Suchen, ob die Vergleichen unterstützt wird
        Dim bSupportFiltering As Boolean
        For Each inf As Type In [property].PropertyType.GetInterfaces
            If inf.FullName.CompareTo(GetType(IComparable).FullName) = 0 Then
                bSupportFiltering = True
                Exit For
            End If
        Next

        ' Erstes Feld das Stimmt zurückgeben
        For i As Integer = 0 To _array.Length - 1
            fld = _array(0).GetType.GetProperty([property].Name, BindingFlags.Public Or BindingFlags.GetProperty Or BindingFlags.Instance)
            wert = fld.GetValue(_array(i), BindingFlags.GetProperty, Nothing, Nothing, Globalization.CultureInfo.CurrentCulture)
            If CType(wert, IComparable).CompareTo(key) = 0 Then Return i
        Next

        Return -1
    End Function

    Public ReadOnly Property IsSorted() As Boolean Implements System.ComponentModel.IBindingList.IsSorted
        Get
            Return _isSorted
        End Get
    End Property

    Public Sub RemoveIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements System.ComponentModel.IBindingList.RemoveIndex
        If log.IsDebugEnabled Then log.Debug("RemoveIndex")
        _indizes.Remove([property])
    End Sub

    Public Sub RemoveSort() Implements System.ComponentModel.IBindingList.RemoveSort ' Eine Sortierung kann nie wieder zurück genommen werden
        _sortDirection = ComponentModel.ListSortDirection.Ascending
        _sortProperty = Nothing
        _isSorted = False
    End Sub

    Public ReadOnly Property SortDirection() As System.ComponentModel.ListSortDirection Implements System.ComponentModel.IBindingList.SortDirection
        Get
            Return _sortDirection
        End Get
    End Property

    Public ReadOnly Property SortProperty() As System.ComponentModel.PropertyDescriptor Implements System.ComponentModel.IBindingList.SortProperty
        Get
            Return _sortProperty
        End Get
    End Property

    Public ReadOnly Property SupportsChangeNotification() As Boolean Implements System.ComponentModel.IBindingList.SupportsChangeNotification
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property SupportsSearching() As Boolean Implements System.ComponentModel.IBindingList.SupportsSearching
        Get
            If log.IsDebugEnabled Then log.Debug("SupportsSearching")
            Return True
        End Get
    End Property

    Public ReadOnly Property SupportsSorting() As Boolean Implements System.ComponentModel.IBindingList.SupportsSorting
        Get
            Return True
        End Get
    End Property

#End Region

#Region " IBindingListView "

    Private _filter As String

    Private _sorts As System.ComponentModel.ListSortDescriptionCollection

    Public Sub ApplyMultiSort(ByVal sorts As System.ComponentModel.ListSortDescriptionCollection) Implements System.ComponentModel.IBindingListView.ApplySort
        If log.IsDebugEnabled Then log.Debug("ApplyMultiSort")
        ' TODO
        If sorts.Count = 0 Then Exit Sub
        ApplySort(sorts(0).PropertyDescriptor, sorts(0).SortDirection)
        _sorts = sorts
    End Sub

    Public Property Filter() As String Implements System.ComponentModel.IBindingListView.Filter
        Get
            Return _filter
        End Get
        Set(ByVal value As String)
            _filter = value
            CreateArray()
            ' TODO
        End Set
    End Property

    Public Sub RemoveFilter() Implements System.ComponentModel.IBindingListView.RemoveFilter
        Filter = ""
    End Sub

    Public ReadOnly Property SortDescriptions() As System.ComponentModel.ListSortDescriptionCollection Implements System.ComponentModel.IBindingListView.SortDescriptions
        Get
            Return _sorts
        End Get
    End Property

    Public ReadOnly Property SupportsAdvancedSorting() As Boolean Implements System.ComponentModel.IBindingListView.SupportsAdvancedSorting
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property SupportsFiltering() As Boolean Implements System.ComponentModel.IBindingListView.SupportsFiltering
        Get
            Return True
        End Get
    End Property

#End Region

End Class

