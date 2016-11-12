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

    Public Class CheckForUpdate
        Public Shared LatestVerAddress As String = "http://downloads.dpw-tw.lionfree.net/fvexpress/update/latest.verdesp"
        Public Shared CurrentVer As String
        Public Shared ChangelogAddress As String = "http://downloads.dpw-tw.lionfree.net/fvexpress/changelog.txt"

        Function GatherLatestUpdateInfo(ByVal LatestVerAddress, ByVal CurrentVer)


            CheckUpdate(CurrentVersion, LatestVersion)
            Return UpdateStatus
        End Function
    End Class

    Public Class DownloadUpdate

    End Class
End Class
