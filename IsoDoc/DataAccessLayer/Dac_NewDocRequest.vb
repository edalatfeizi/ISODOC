Public Class Dac_NewDocRequest



    Friend Sub Insert(docReq As DocRequest)

        ' Add parameters for the stored procedure
        persist1.Sp_AddParam("@RequesterDepId", SqlDbType.Int, docReq.RequesterDepId, ParameterDirection.Input)
        persist1.Sp_AddParam("@RequesterDepName", SqlDbType.NVarChar, docReq.RequesterDepName, ParameterDirection.Input)
        persist1.Sp_AddParam("@Title", SqlDbType.NVarChar, docReq.Title, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentCode", SqlDbType.NVarChar, docReq.DocumentCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@RequestType", SqlDbType.NVarChar, docReq.RequestType, ParameterDirection.Input)
        persist1.Sp_AddParam("@StoreDuration", SqlDbType.NVarChar, docReq.StoreDuration, ParameterDirection.Input)
        persist1.Sp_AddParam("@Changes", SqlDbType.NVarChar, docReq.Changes, ParameterDirection.Input)
        persist1.Sp_AddParam("@UpdateOrNewDocReason", SqlDbType.NVarChar, docReq.UpdateOrNewDocReason, ParameterDirection.Input)
        persist1.Sp_AddParam("@OffererName", SqlDbType.NVarChar, docReq.OffererName, ParameterDirection.Input)
        persist1.Sp_AddParam("@SystemsOfficeBossName", SqlDbType.NVarChar, docReq.SystemsOfficeBossName, ParameterDirection.Input)
        persist1.Sp_AddParam("@DoWithReview", SqlDbType.Bit, docReq.DoWithReview, ParameterDirection.Input)
        persist1.Sp_AddParam("@SystemsAdminName", SqlDbType.NVarChar, docReq.SystemsAdminName, ParameterDirection.Input)
        persist1.Sp_AddParam("@EditNo", SqlDbType.NVarChar, docReq.EditNo, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkSystemsOfficeBoss", SqlDbType.Bit, docReq.OkSystemsOfficeBoss, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkSystemsOfficeBossDateTime", SqlDbType.DateTime, docReq.OkSystemsOfficeBossDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkSystemsAdmin", SqlDbType.Bit, docReq.OkSystemsAdmin, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkSystemsAdminDateTime", SqlDbType.DateTime, docReq.OkSystemsAdminDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkDocOwnerDepAdmin", SqlDbType.Bit, docReq.OkDocOwnerDepAdmin, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkDocOwnerDepAdminDateTime", SqlDbType.DateTime, docReq.OkDocOwnerDepAdminDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@RegDateTime", SqlDbType.DateTime, docReq.RegDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@ReqDateTime", SqlDbType.DateTime, docReq.ReqDateTime, ParameterDirection.Input)

        ' Execute the stored procedure
        persist1.Sp_Exe("InsertDocRequest", CnnString, False)

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
                    FROM Vw_AllPersonWithDepartName where CardNumber = '" + userCardNo + "'"
        GetUserInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
