
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' <!-- ProgramName --> - <!-- ProgramWeb -->
' Copyright (C) <!-- ProgramYear -->  <!-- ProgramAuthor -->
'
' This program is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 2 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program; if not, write to the Free Software
' Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports DotNetUC.Validation.ControlAdapter

Public Class Start

#Region " Logger (log4net) "

    ''' <summary>
    ''' Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
    ''' wird durch den Namespace die Logger-Hierarchie aufgebaut.
    ''' </summary>
    ''' <remarks>Mehr siehe <a href="http://logging.apache.org/log4net/">http://logging.apache.org/log4net/</a> </remarks>
    Private Shared ReadOnly log As Global.log4net.ILog = Global.log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

#End Region

#Region " (Shared) Function Main "

    ''' <summary>
    ''' Einstiegspunkt des Programms
    ''' </summary>
    ''' <param name="args">‹bergabeparameter</param>
    Public Shared Function Main(ByVal args() As String) As Integer
        ' Print GPL
        GplOut()

        ' Control Adapter initialisieren
        ControlAdapterRegistry.RegisterAdapter(GetType(Controls.EditFsk), New Controls.EditFskAdapter)
        ControlAdapterRegistry.RegisterAdapter(GetType(Controls.EditGenre), New Controls.EditGenreAdapter)
        ControlAdapterRegistry.RegisterAdapter(GetType(Controls.EditOwner), New Controls.EditOwnerAdapter)
        ControlAdapterRegistry.RegisterAdapter(GetType(Controls.EditDvd), New Controls.EditDvdAdapter)
        ControlAdapterRegistry.RegisterAdapter(GetType(Controls.EditDistribute), New Controls.EditDistributeAdapter)
        ControlAdapterRegistry.RegisterAdapter(GetType(System.Windows.Forms.NumericUpDown), New Controls.NumericUpDownAdapter)
        ControlAdapterRegistry.RegisterAdapter(GetType(System.Windows.Forms.DateTimePicker), New Controls.DateTimePickerAdapter)

        Dim f As New Hauptformular
        Basisklassen.MessageDialog.Parent = f

        For i As Integer = 0 To args.Length - 1
            If args(i) = "--file" And args.Length > i + 1 Then
                f.Datei÷ffnen(args(i + 1))
            End If
        Next

        If Basisklassen.Konfiguration.VisualStyles Then Application.EnableVisualStyles()

        Try
            Application.Run(f)
            Return 0
        Catch ex As Exception
            If log.IsFatalEnabled Then log.Fatal("Es ist ein Fehler aufgetreten.", ex)
            BusinessObjects.BoBase.UnInit()
            Return 1
        End Try

    End Function

#End Region

#Region " GPL Info Output "

    ''' <summary>
    ''' Gibt eine GPL-Info auf der Konsole aus
    ''' </summary>
    Private Shared Sub GplOut()
        System.Console.WriteLine("<!-- ProgramName -->, Version <!-- ProgramVersion -->, ")
        System.Console.WriteLine("Copyright (C) <!-- ProgramYear -->  <!-- ProgramAuthor -->")
        System.Console.WriteLine("<!-- ProgramName --> comes with ABSOLUTELY NO WARRANTY")
        System.Console.WriteLine("This is free software, and you are welcome to redistribute it under certain conditions;")
        System.Console.WriteLine("<!-- ProgramWeb -->")
    End Sub

#End Region

End Class
