Public Class Dac_OutsideDoc
    Friend Function GetOutSideDoc() As DataTable
        SqlStr = "select * From VwIso_OutSideDoc "
        GetOutSideDoc = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Sub Insert(ByVal DocName As String, ByVal DocCode As String, ByVal DocPath As String, ByVal ReviewNum As String, ByVal ReviewDate As String, ByVal sherkatname As String)
        persist1.Sp_AddParam("@PublicDocName_1", SqlDbType.Char, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@PublicDocCode_2", SqlDbType.VarChar, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@PublicDocPath_3", SqlDbType.VarChar, DocPath, ParameterDirection.Input)
        persist1.Sp_AddParam("@InternalDoc_4", SqlDbType.Bit, 0, ParameterDirection.Input)
        persist1.Sp_AddParam("@Other_5", SqlDbType.Bit, 1, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionNo_6", SqlDbType.Char, ReviewNum, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionDate_7 ", SqlDbType.Char, ReviewDate, ParameterDirection.Input)
        persist1.Sp_AddParam("@DepName_8", SqlDbType.NVarChar, 0, ParameterDirection.Input)
        persist1.Sp_AddParam("@sherkatname_9", SqlDbType.NVarChar, 0, ParameterDirection.Input)
        persist1.Sp_Exe("insert_tbISOPublicAndOthers", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub Update(ByVal Id As Integer, ByVal DocName As String, ByVal DocCode As String, ByVal DocPath As String, ByVal ReviewNum As String, ByVal ReviewDate As String, ByVal sherkatname As String)
        persist1.Sp_AddParam("@PublicDocId_1", SqlDbType.Int, Id, ParameterDirection.Input)
        persist1.Sp_AddParam("@PublicDocName_2", SqlDbType.Char, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@PublicDocCode_3", SqlDbType.VarChar, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@PublicDocPath_4", SqlDbType.VarChar, DocPath, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionNo_5", SqlDbType.Char, ReviewNum, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionDate_6 ", SqlDbType.Char, ReviewDate, ParameterDirection.Input)
        persist1.Sp_AddParam("@sherkatname_7 ", SqlDbType.NVarChar, sherkatname, ParameterDirection.Input)
        persist1.Sp_Exe("update_tbISOPublicAndOthers", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub Delete(ByVal Id As Integer)
        persist1.Sp_AddParam("@PublicDocId_1", SqlDbType.Int, Id, ParameterDirection.Input)
        persist1.Sp_Exe("delete_tbISOPublicAndOthers", CnnString, False)
        persist1.ClearParameter()
    End Sub
End Class
