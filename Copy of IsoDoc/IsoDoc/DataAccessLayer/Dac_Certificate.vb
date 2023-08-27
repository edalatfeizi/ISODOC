Public Class Dac_Certificate
    Friend Function GetCertificateInfo() As DataTable
        SqlStr = "select * From tbISO_Certificate"
        GetCertificateInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function

End Class
