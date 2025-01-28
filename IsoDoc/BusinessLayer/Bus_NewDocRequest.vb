Public Class Bus_NewDocRequest
    Private Dac_NewDocRequest As New Dac_NewDocRequest

    Friend Function GetHistoryInfo() As DataTable
        SqlStr = "select * from VwIso_DocHistory "
        GetHistoryInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function

    Friend Sub Insert(docReq As DocRequest)
        Dac_NewDocRequest.Insert(docReq)
    End Sub
End Class
