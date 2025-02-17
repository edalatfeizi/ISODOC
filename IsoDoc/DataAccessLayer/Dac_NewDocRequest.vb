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
        persist1.Sp_AddParam("@FileExtension", SqlDbType.VarChar, docReq.FileExtension, ParameterDirection.Input)
        persist1.Sp_AddParam("@OffererPersonCode", SqlDbType.VarChar, docReq.OffererPersonCode, ParameterDirection.Input)

        ' Execute the stored procedure
        persist1.Sp_Exe("SP_InsertDocRequest", CnnString, False)

        ' Clear parameters after execution
        persist1.ClearParameter()
    End Sub
    Friend Sub Update(docReq As DocRequest)
        ' Add the mandatory Id parameter
        persist1.Sp_AddParam("@Id", SqlDbType.Int, docReq.Id, ParameterDirection.Input)

        ' Add parameters for the update stored procedure
        persist1.Sp_AddParam("@Title", SqlDbType.NVarChar, docReq.Title, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentCode", SqlDbType.NVarChar, docReq.DocumentCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@RequestType", SqlDbType.NVarChar, docReq.RequestType, ParameterDirection.Input)
        persist1.Sp_AddParam("@StoreDuration", SqlDbType.NVarChar, docReq.StoreDuration, ParameterDirection.Input)
        persist1.Sp_AddParam("@Changes", SqlDbType.NVarChar, docReq.Changes, ParameterDirection.Input)
        persist1.Sp_AddParam("@UpdateOrNewDocReason", SqlDbType.NVarChar, docReq.UpdateOrNewDocReason, ParameterDirection.Input)
        persist1.Sp_AddParam("@EditOrReview", SqlDbType.NVarChar, docReq.EditOrReview, ParameterDirection.Input)
        persist1.Sp_AddParam("@EditNo", SqlDbType.Int, docReq.EditNo, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkSysOfficeBoss", SqlDbType.VarChar, docReq.OkSysOfficeBoss, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkSysOfficeBossDateTime", SqlDbType.VarChar, docReq.OkSysOfficeBossDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkSysAdmin", SqlDbType.NVarChar, docReq.OkSysAdmin, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkSysAdminDateTime", SqlDbType.VarChar, docReq.OkSysAdminDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkDocOwnerDepAdmin", SqlDbType.NVarChar, docReq.OkDocOwnerDepAdmin, ParameterDirection.Input)
        persist1.Sp_AddParam("@OkDocOwnerDepAdminDateTime", SqlDbType.VarChar, docReq.OkDocOwnerDepAdminDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@RegDateTime", SqlDbType.VarChar, docReq.RegDateTime, ParameterDirection.Input)
        persist1.Sp_AddParam("@Attachment", SqlDbType.VarBinary, docReq.Attachment, ParameterDirection.Input)
        persist1.Sp_AddParam("@FileExtension", SqlDbType.VarChar, docReq.FileExtension, ParameterDirection.Input)
        persist1.Sp_AddParam("@SysOfficeBossComment", SqlDbType.NVarChar, docReq.SysOfficeBossComment, ParameterDirection.Input)
        persist1.Sp_AddParam("@SysAdminComment", SqlDbType.NVarChar, docReq.SysAdminComment, ParameterDirection.Input)
        persist1.Sp_AddParam("@RequesterDepBossOrAdminComment", SqlDbType.NVarChar, docReq.RequesterDepBossOrAdminComment, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocOwnerDepBossOrAdminComment", SqlDbType.NVarChar, docReq.DocOwnerDepBossOrAdminComment, ParameterDirection.Input)
        persist1.Sp_AddParam("@Active", SqlDbType.Bit, docReq.Active, ParameterDirection.Input)

        ' Execute the update stored procedure
        persist1.Sp_Exe("spUpdateDocRequest", CnnString, False)

        ' Clear parameters after execution
        persist1.ClearParameter()
    End Sub

    Friend Sub DeleteDocRequestAttachment(docReqId As Integer)
        ' Add the mandatory Id parameter
        persist1.Sp_AddParam("@Id", SqlDbType.Int, docReqId, ParameterDirection.Input)

        ' Execute the update stored procedure
        persist1.Sp_Exe("spDeleteDocRequestAttachment", CnnString, False)

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
    Friend Function GetPostUserInfo(departId As String) As DataTable
        SqlStr = "SELECT *
                    FROM Personely.dbo.Vw_AllPersonWithDepartName where DepartId = '" + departId + "'"
        GetPostUserInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Function GetMaxRequestId() As DataTable
        SqlStr = "select MAX(Id) as MaxReqId from [Isodoc_New].[dbo].tbDocRequests"
        GetMaxRequestId = persist1.GetDataTable(CnnString, SqlStr)
    End Function

    Friend Function GetDepAdmins(depCode As String) As DataTable
        SqlStr = "SELECT *
                    FROM Personely.dbo.Vw_AllPersonWithDepartName where DepartCode = '" + depCode + "' and (PostTypeID = '3' or PostTypeID = '27')"
        GetDepAdmins = persist1.GetDataTable(CnnString, SqlStr)
    End Function

    Friend Function GetDepsList() As DataTable
        SqlStr = "select MDepartName as 'نام واحد',MDepartCode as 'کد واحد' from Personely.dbo.VwHR_MDepart where MDepartCode <> '0'  order by DepartID"
        GetDepsList = persist1.GetDataTable(CnnString, SqlStr)
    End Function

    Friend Function GetDocRequests(filter As String) As DataTable
        SqlStr = "select * from [Isodoc_New].[dbo].[tbDocRequests] " + filter
        GetDocRequests = persist1.GetDataTable(CnnString, SqlStr)
    End Function

    Friend Function GetAllDocsInfo() As DataTable
        SqlStr = "select DISTINCT  DocumentName as 'عنوان سند', DocumentCode as 'کد سند', HistorySave as 'مدت زمان نگه داری'  from VwIso_Documents"
        GetAllDocsInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function

End Class
