Public Class fvexpress
    Public Shared RegName, RegOrg, RegEmail As String
    Public Shared RegGUID As String
    Public Shared RegSerial, RegKey, ActKay As String
    Dim Randnum As Random
    Public Shared RegStatus As Boolean

    Shared Function GetRegData(ByVal RegName, ByVal RegOrg, ByVal RegEmail)
        Return RegGUID = Convert.ToString(Guid.NewGuid)
    End Function

    Function GenerateRegSerial(ByVal RegUUID)

    End Function

    Function GenerateRegKey(ByVal RegUUID)

    End Function

    Function GenerateActKey(ByVal RegUUID)

    End Function

    Shared Function CheckRegisterStatus(ByVal RegKeyPath As String)
        If My.Computer.FileSystem.FileExists(RegKeyPath) = True Then
            RegStatus = True
        Else
            RegStatus = False
        End If
        Return RegStatus
    End Function
End Class