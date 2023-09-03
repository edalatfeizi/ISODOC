Public Class Bus_TechnicalDoc
    Private Dac_TechnicalDoc1 As New Dac_TechnicalDoc
    Friend Function GetTechnicalDocInfo() As DataTable
        GetTechnicalDocInfo = Dac_TechnicalDoc1.GetTechnicalDocInfo
    End Function
End Class
