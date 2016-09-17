Imports System.IO
Imports System.IO.StreamReader
Imports System.IO.StreamWriter
Public Class fvexpress
    Public Shared AutoUpdate As String
    Public Shared Status As String
    Shared Function LoadSettings(ByVal SettingFilePath As String)
        Status = True
        Dim LoadSettingHandler As StreamReader = New StreamReader(Directory.GetCurrentDirectory + "\Config\Config.cfg")
        AutoUpdate = LoadSettingHandler.ReadLine()
        LoadSettingHandler.Close()
        Return Status
    End Function

    Shared Function SaveSettings(ByVal SettingFilePath As String, AutoUpdateParameter As String)
        Status = False
        Dim SaveSettingHandler As StreamWriter = New StreamWriter(Directory.GetCurrentDirectory + "\Config\Config.cfg")
        SaveSettingHandler.WriteLine(AutoUpdateParameter)
        SaveSettingHandler.Close()
        Return Status
    End Function
End Class
