Public Class fvexpress
    Public Shared RegName, RegOrg, RegEmail As String
    Public Shared RegGUID As String
    Public Shared RegSerial, RegKey, ActKey As String
    Public Shared Randnum As Random = New Random()
    Public Shared NumLegend As Int64 = Nothing
    Public Shared CaseMode As Integer
    Public Shared tempbufer As String
    Public Shared RegStatus As Boolean

    Shared Function GetRegData(ByVal RegName, ByVal RegOrg, ByVal RegEmail)
        Return RegGUID = System.Guid.NewGuid().ToString("D")
        Console.Write(RegGUID)
    End Function

    Shared Function GenerateRegSerial(ByVal RegUUID As String)
        NumLegend = 64
        For NumLegend = 1 To NumLegend
            CaseMode = Randnum.Next(1, 4)
            Select Case CaseMode
                Case 1
                    tempbufer = ChrW(Randnum.Next(65, 91))
                Case 2
                    tempbufer = ChrW(Randnum.Next(97, 123))
                Case 3
                    tempbufer = ChrW(Randnum.Next(48, 58))
            End Select
            RegSerial &= tempbufer
        Next
        Return RegSerial
    End Function

    Shared Function GenerateRegKey(ByVal RegUUID As String)
        NumLegend = 35
        For i As Integer = 1 To 4
            For j As Integer = 1 To 8
                CaseMode = Randnum.Next(1, 3)
                Select Case CaseMode
                    Case 1
                        tempbufer = ChrW(Randnum.Next(65, 91))
                    Case 2
                        tempbufer = ChrW(Randnum.Next(48, 58))
                End Select
                RegKey &= tempbufer
            Next
            If i <> 4 Then
                RegKey &= "-"
            Else
                Exit For
            End If
        Next
        Return RegKey
    End Function

    Shared Function GenerateActKey(ByVal RegUUID As String)
        NumLegend = 35
        For i As Integer = 1 To 6
            For j As Integer = 1 To 5
                CaseMode = Randnum.Next(1, 3)
                Select Case CaseMode
                    Case 1
                        tempbufer = ChrW(Randnum.Next(65, 91))
                    Case 2
                        tempbufer = ChrW(Randnum.Next(48, 58))
                End Select
                ActKey &= tempbufer
            Next
            If i <> 6 Then
                ActKey &= "-"
            Else
                Exit For
            End If
        Next
        Return ActKey
    End Function

    Shared Function CheckRegisterStatus(ByVal RegKeyPath As String)
        If My.Computer.FileSystem.FileExists(RegKeyPath) = True Then
            RegStatus = True
        Else
            RegStatus = False
        End If
        Return RegStatus
    End Function

    Shared Sub GenerateRegKeyFile()
        tempbufer = "RegName=" + RegName + vbNewLine + "RegOrg=" + RegOrg + vbNewLine + "RegEmail=" + RegEmail + vbNewLine + "RegSerial=" + RegSerial + vbNewLine + "RegKey=" + RegKey + vbNewLine + "ActKey=" + ActKey + vbNewLine + "GUID=" + RegGUID + vbNewLine + "RegFate=" + Date.Now.ToString("yyyy-MM-dd-HH-mm-ss")
        My.Computer.FileSystem.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\Config\Reg.key", tempbufer, False)
    End Sub
End Class