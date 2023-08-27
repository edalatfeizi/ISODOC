Public Class Dac_Certificate
    Friend Function GetCertificateInfo() As DataTable
        SqlStr = "select * From Vw_ISO_Certificate"
        GetCertificateInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
