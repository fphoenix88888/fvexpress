Public Class fvexpress
    Public Shared UpdateStatus As Boolean
    Public Shared CurrentVersion, LatestVersion As String
    Shared Function CheckUpdate(ByVal CurrentVersion, ByVal LatestVersion)
            If CurrentVersion = LatestVersion Then
                UpdateStatus = False
            Else
                UpdateStatus = True
            End If
            Return UpdateStatus
    End Function
End Class
