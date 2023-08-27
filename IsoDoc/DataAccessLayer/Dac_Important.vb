Public Class Dac_Important
    Friend Function GetCertificateInfo() As DataTable
        SqlStr = "SELECT       DocCode, DocName, FilePath, DocPathNew, DocTypeID, StrategicID AS MainId  FROM         tbISOImportandDoc"
        GetCertificateInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
