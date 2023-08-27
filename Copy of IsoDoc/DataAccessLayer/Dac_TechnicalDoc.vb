Public Class Dac_TechnicalDoc
    Friend Function GetTechnicalDocInfo() As DataTable
        SqlStr = "select * From VwIso_TechnicalDocument "
        GetTechnicalDocInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
