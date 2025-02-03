Public Class Dac_NewDocRequest



    Friend Sub Insert(docReq As DocRequest)

        ' Add parameters for the stored procedure
        persist1.Sp_AddParam("@RequesterDepCode", SqlDbType.VarChar, docReq.RequesterDepCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@RequesterDepName", SqlDbType.NVarChar, docReq.RequesterDepName, ParameterDirection.Input)
        persist1.Sp_AddParam("@Title", SqlDbType.NVarChar, docReq.Title, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentCode", SqlDbType.NVarChar, docReq.DocumentCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@RequestType", SqlDbType.NVarChar, docReq.RequestType, ParameterDirection.Input)
        persist1.Sp_AddParam("@StoreDuration", SqlDbType.NVarChar, docReq.StoreDuration, ParameterDirection.Input)
        persist1.Sp_AddParam("@Changes", SqlDbType.NVarChar, docReq.Changes, ParameterDirection.Input)
        persist1.Sp_AddParam("@UpdateOrNewDocReason", SqlDbType.NVarChar, docReq.UpdateOrNewDocReason, ParameterDirection.Input)
        persist1.Sp_AddParam("@OffererName", SqlDbType.NVarChar, docReq.OffererName, ParameterDirection.Input)
        persist1.Sp_AddParam("@ReqDateTime", SqlDbType.VarChar, docReq.ReqDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@Attachment", SqlDbType.VarBinary, docReq.Attachment, ParameterDirection.Input)

        ' Execute the stored procedure
        persist1.Sp_Exe("SP_InsertDocRequest", CnnString, False)

        ' Clear parameters after execution
        persist1.ClearParameter()
    End Sub



    Friend Function GetDocFormName() As DataTable
        SqlStr = "select * from VwIso_MdepDoc  "
        GetDocFormName = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Function GetDocNameInfo() As DataTable
        SqlStr = "select * from tbISODocName "
        GetDocNameInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Function GetDocNameMdepartInfo() As DataTable
        SqlStr = "select * from tbISODocName "
        GetDocNameMdepartInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Function GetUserInfo(userCardNo As String) As DataTable
        SqlStr = "SELECT *
                    FROM Personely.dbo.Vw_AllPersonWithDepartName where CardNumber = '" + userCardNo + "'"
        GetUserInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Function GetPostUserInfo(postId As String) As DataTable
        SqlStr = "SELECT *
                    FROM Personely.dbo.Vw_AllPersonWithDepartName where PostID = '" + postId + "'"
        GetPostUserInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Function GetMaxRequestId() As DataTable
        SqlStr = "select MAX(Id) as MaxReqId from [Isodoc_New].[dbo].tbDocRequests"
        GetMaxRequestId = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
