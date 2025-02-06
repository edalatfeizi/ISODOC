Public Class Bus_NewDocRequest
    Private Dac_NewDocRequest As New Dac_NewDocRequest

    Friend Function GetHistoryInfo() As DataTable
        SqlStr = "select * from VwIso_DocHistory "
        GetHistoryInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function

    Friend Function GetUserInfo(ByVal userCardNo As String) As DataTable
        GetUserInfo = Dac_NewDocRequest.GetUserInfo(userCardNo)
    End Function
    Friend Function GetPostUserInfo(ByVal postId As String) As DataTable
        GetPostUserInfo = Dac_NewDocRequest.GetPostUserInfo(postId)
    End Function
    Friend Sub Insert(docReq As DocRequest)
        Dac_NewDocRequest.Insert(docReq)
    End Sub
    Friend Function GetMaxRequestId() As DataTable
        GetMaxRequestId = Dac_NewDocRequest.GetMaxRequestId()
    End Function

    Friend Function GetDepAdmins(depCode As String) As DataTable
        GetDepAdmins = Dac_NewDocRequest.GetDepAdmins(depCode)
    End Function

    Friend Function GetDepsList() As DataTable
        GetDepsList = Dac_NewDocRequest.GetDepsList()
    End Function

    Friend Function GetDocRequests() As DataTable
        GetDocRequests = Dac_NewDocRequest.GetDocRequests()

    End Function
End Class
