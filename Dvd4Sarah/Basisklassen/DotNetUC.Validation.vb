Imports DotNetUC

Public Class DotNetUCValidationWrapper
End Class

Public Class ControlValidator
    Inherits Validation.ControlValidator

    Public Sub New(ByVal container As ComponentModel.IContainer)
        MyBase.New(container)
    End Sub
End Class

Public Class FormValidator
    Inherits Validation.FormValidator

    Public Sub New(ByVal container As ComponentModel.IContainer)
        MyBase.New(container)
    End Sub
End Class

Public Class CellFormatter
    Inherits Validation.Formatting.CellFormatter

    Public Sub New(ByVal container As ComponentModel.IContainer)
        MyBase.New(container)
    End Sub
End Class

Public Class DataFormatter
    Inherits Validation.Formatting.DataFormatter

    Public Sub New(ByVal container As ComponentModel.IContainer)
        MyBase.New(container)
    End Sub
End Class
