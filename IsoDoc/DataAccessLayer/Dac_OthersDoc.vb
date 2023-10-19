Public Class Dac_OthersDoc
    Private mDocCode As String
    Private mDocName As String
    Private mFilePath As String
    Private mFileSettingPath As String
    Private mReviewDate As String
    Private mMdepCode As String
    Private mHistorySave As String
    Private mMainID As Integer
    Private mDocTypeID As New Bus_DocType
    Private mReviewNum As Integer
    Dim mDocID As Integer

    Friend Property DocName() As String
        Get
            Return mDocName
        End Get
        Set(ByVal value As String)
            mDocName = value
        End Set
    End Property
    Friend Property DocCode() As String
        Get
            Return mDocCode
        End Get
        Set(ByVal value As String)
            mDocCode = value
        End Set
    End Property
    Friend Property FilePath() As String
        Get
            Return mFilePath
        End Get
        Set(ByVal value As String)
            mFilePath = value
        End Set
    End Property
    Friend Property FileSettingPath() As String
        Get
            Return mFileSettingPath
        End Get
        Set(ByVal value As String)
            mFileSettingPath = value
        End Set
    End Property
    Friend Property ReviewDate() As String
        Get
            Return mReviewDate
        End Get
        Set(ByVal value As String)
            mReviewDate = value
        End Set
    End Property
    Friend Property MdepCode() As String
        Get
            Return mMdepCode
        End Get
        Set(ByVal value As String)
            mMdepCode = value
        End Set
    End Property
    Friend Property HistorySave() As String
        Get
            Return mHistorySave
        End Get
        Set(ByVal value As String)
            mHistorySave = value
        End Set
    End Property
    Friend Property MainID() As Integer
        Get
            Return mMainID
        End Get
        Set(ByVal value As Integer)
            mMainID = value
        End Set
    End Property
    Friend Property DocType() As Bus_DocType
        Get
            Return mDocTypeID
        End Get
        Set(ByVal value As Bus_DocType)
            mDocTypeID = value
        End Set
    End Property
    Friend Property ReviewNum() As Integer
        Get
            Return mReviewNum
        End Get
        Set(ByVal value As Integer)
            mReviewNum = value
        End Set
    End Property

    Friend Property DocID() As Integer
        Get
            Return mDocID
        End Get
        Set(ByVal value As Integer)
            mDocID = value
        End Set
    End Property

    Friend Sub Insert()

        persist1.Sp_AddParam("@DocumentName_1", SqlDbType.VarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentCode_2", SqlDbType.VarChar, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocPath_3", SqlDbType.VarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionNo_4", SqlDbType.VarChar, ReviewNum, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionDate_5", SqlDbType.VarChar, ReviewDate, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocSettingPath_6", SqlDbType.VarChar, FileSettingPath, ParameterDirection.Input)
        persist1.Sp_AddParam("@HistorySave_7 ", SqlDbType.VarChar, HistorySave, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocType_8", SqlDbType.SmallInt, DocType.DocTypeID, ParameterDirection.Input)
        persist1.Sp_AddParam("@MdepartID_9", SqlDbType.NVarChar, MdepCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@AppCode_10", SqlDbType.Int, 0, ParameterDirection.Input)
        persist1.Sp_AddParam("@MethodID_11", SqlDbType.SmallInt, 0, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_13", SqlDbType.Int, DocID, ParameterDirection.Input)
        persist1.Sp_AddParam("@IsPrint_14", SqlDbType.Bit, 1, ParameterDirection.Input)
        persist1.Sp_Exe("SP_tbISODocuments_Ins", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub Update()

        persist1.Sp_AddParam("@MainId_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentName_2", SqlDbType.VarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocumentCode_3", SqlDbType.VarChar, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocPath_4", SqlDbType.VarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionNo_5", SqlDbType.VarChar, ReviewNum, ParameterDirection.Input)
        persist1.Sp_AddParam("@RevisionDate_6", SqlDbType.VarChar, ReviewDate, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocSettingPath_7", SqlDbType.VarChar, FileSettingPath, ParameterDirection.Input)
        persist1.Sp_AddParam("@HistorySave_8 ", SqlDbType.VarChar, HistorySave, ParameterDirection.Input)
        persist1.Sp_AddParam("@MdepartID_9 ", SqlDbType.NVarChar, MdepCode, ParameterDirection.Input)

        persist1.Sp_Exe("Sp_OtherDoc_upd", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub Delete()
        persist1.Sp_AddParam("@MainId_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISODocuments_Del", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Function GetOthersDocInfo() As DataTable
        SqlStr = "select * from VwIso_Others " '”«Ì— „” ‰œ« '
        GetOthersDocInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
