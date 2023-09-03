Public Class Bus_PostIdentification
    Private Dac_PostIdentification1 As New Dac_PostIdentification
    Friend Function GetPostIdnInfo() As DataTable
        GetPostIdnInfo = Dac_PostIdentification1.GetPostIdnInfo
    End Function
End Class
