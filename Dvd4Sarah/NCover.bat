@ECHO OFF

echo Starten der Anwendung zum Erstellen der Analysedaten
"c:\programme\NCover\NCover.Console.exe" Dvd4Sarah\Bin\Dvd4Sarah.exe //x Release\NCover.Xml //l Release\NCover.Log

echo Aufbereiten und Darstellen der Analysedaten
"C:\Programme\TestDriven.NET 2.0\NCoverExplorer\NCoverExplorer.exe" Release\NCover.Xml
