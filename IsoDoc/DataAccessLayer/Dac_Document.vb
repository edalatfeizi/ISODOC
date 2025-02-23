Public Class Dac_Document

    Private mDocument As Object
    Public Property Document() As Bus_Document
        Get
            Return mDocument
        End Get
        Set(ByVal value As Bus_Document)
            mDocument = value
        End Set
    End Property

    Friend Sub Insert()

        persist1.Sp_AddParam("@DocumentName_1", SqlDbType.VarChar, Document.DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentCode_2", SqlDbType.VarChar, Document.DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocPath_3", SqlDbType.VarChar, Document.FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionNo_4", SqlDbType.VarChar, Document.ReviewNum, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionDate_5", SqlDbType.VarChar, Document.ReviewDate, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocSettingPath_6", SqlDbType.VarChar, Document.FileSettingPath, ParameterDirection.Input)
        persist1.Sp_AddParam("@HistorySave_7 ", SqlDbType.VarChar, Document.HistorySave, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocType_8", SqlDbType.SmallInt, Document.DocType.DocTypeID, ParameterDirection.Input)
        persist1.Sp_AddParam("@MdepartID_9", SqlDbType.NVarChar, Document.MdepCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@AppCode_10", SqlDbType.Int, 0, ParameterDirection.Input)
        persist1.Sp_AddParam("@MethodID_11", SqlDbType.SmallInt, 0, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_13", SqlDbType.Int, Document.DocID, ParameterDirection.Input)
        If Document.DocID = 9 Then
            persist1.Sp_AddParam("@IsPrint_14", SqlDbType.Bit, Document.IsPrint, ParameterDirection.Input)
        Else
            persist1.Sp_AddParam("@IsPrint_14", SqlDbType.Bit, Document.IsPrint, ParameterDirection.Input)
        End If

        persist1.Sp_Exe("SP_tbISODocuments_Ins", CnnString, False)
        persist1.ClearParameter()
    End Sub

    Friend Sub Update()

        persist1.Sp_AddParam("@MainId_1", SqlDbType.Int, Document.MainID, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentName_2", SqlDbType.VarChar, Document.DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentCode_3", SqlDbType.VarChar, Document.DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocPath_4", SqlDbType.VarChar, Document.FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionNo_5", SqlDbType.VarChar, Document.ReviewNum, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionDate_6", SqlDbType.VarChar, Document.ReviewDate, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocSettingPath_7", SqlDbType.VarChar, Document.FileSettingPath, ParameterDirection.Input)
        persist1.Sp_AddParam("@HistorySave_8 ", SqlDbType.VarChar, Document.HistorySave, ParameterDirection.Input)
        persist1.Sp_AddParam("@MethodID_9", SqlDbType.SmallInt, 0, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_10", SqlDbType.SmallInt, Document.DocID, ParameterDirection.Input)

        If Document.DocID = 9 Then
            persist1.Sp_AddParam("@IsPrint_11", SqlDbType.Bit, Document.IsPrint, ParameterDirection.Input)
        Else
            persist1.Sp_AddParam("@IsPrint_11", SqlDbType.Bit, Document.IsPrint, ParameterDirection.Input)
        End If
        persist1.Sp_AddParam("@IsShowPublic_12", SqlDbType.Bit, Document.IsShowPublic, ParameterDirection.Input)


        persist1.Sp_Exe("Sp_tbISODocuments_Upd", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub Delete()
        persist1.Sp_AddParam("@MainId_1", SqlDbType.Int, Document.MainID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISODocuments_Del", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Function GetDocumentInfo() As DataTable
        ' MessageBox.Show(UserInfo.LoginPersonID)
        'SqlStr = "select DISTINCT  * from VwAllDocument "
        If (act1.CheckUserAccess(27, 629, LoginID) Or act1.CheckUserAccess(27, 1098, LoginID)) Then
            SqlStr = "select DISTINCT  * from VwIso_Documents "
        Else


            SqlStr = "select DISTINCT  * from VwIso_Documents where MdepartID ='" & UserInfo.LoginMDepartID & "' or personcode='" & UserInfo.LoginPersonID & "' or IsShowPublic=1"
            '     MessageBox.Show(SqlStr)
        End If
        'If act1.CheckUserAccess(27, 1258, LoginID) Then
        '    SqlStr = "select DISTINCT  * from VwIso_Documents where MdepartID IN('RE0964','TT400','RR0015','QC000','HC0855','TT500','AM1247') or personcode='" & UserInfo.LoginPersonID & "' or IsShowPublic=1"
        'End If

        GetDocumentInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Function GetALLDocumentInfo(ByVal Filter As String) As DataTable 'Technical+Systems'
        If (act1.CheckUserAccess(27, 629, LoginID) Or act1.CheckUserAccess(27, 1098, LoginID)) Then
            SqlStr = "select DISTINCT  * from VwAllDocument where    " & Filter
        Else

            SqlStr = "select DISTINCT  * from VwAllDocument where (MdepartID ='" & UserInfo.LoginMDepartID & "' or mdepartid='PublicTechnicalDocuments') and   " & Filter & " and (MdepartID ='" & UserInfo.LoginMDepartID & "' or mdepartid='PublicTechnicalDocuments') or IsShowPublic=1 or   personcode='" & UserInfo.UserCode & "'"

        End If


        'SqlStr = "select DISTINCT  * from VwIso_Documents"
        GetALLDocumentInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
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
End Class
