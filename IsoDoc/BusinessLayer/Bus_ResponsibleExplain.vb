Public Class Bus_ResponsibleExplain
    Private Dac_ResponsibleExplain1 As New Dac_ResponsibleExplain
    Friend Function GetAllInfo() As DataTable
        GetAllInfo = Dac_ResponsibleExplain1.GetAllInfo
    End Function
End Class
