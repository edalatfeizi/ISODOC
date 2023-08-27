Public Class Dac_ResponsibleExplain
    Friend Function GetAllInfo() As DataTable
        SqlStr = "select * from VwIso_Documents where DocType=2"
        GetAllInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
