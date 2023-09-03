Public Class Dac_History
    Private mDocCode As String
    Private mDocName As String
    Private mFilePath As String
    Private mFileSettingPath As String
    Private mReviewDate As String
    Private mMdepCode As String
    Private mHistorySave As String
    Private mMainID As Integer 'PK'
    Private mDocID As Integer
    Private mDocTypeID As New Bus_DocType
    Private mReviewNum As Integer
    Private mDateHist As String
    Friend Property DateHist() As String
        Get
            Return mDateHist
        End Get
        Set(ByVal value As String)
            mDateHist = value
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
    Friend Function GetHistoryInfo() As DataTable
        SqlStr = "select * from VwIso_DocHistory "
        GetHistoryInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Sub Insert() 'À»  œ— »«Ìê«‰Ì'
        persist1.Sp_AddParam("@DocID_1", SqlDbType.Int, DocID, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocName_2", SqlDbType.VarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocCode_3", SqlDbType.VarChar, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocReviewNum_4", SqlDbType.VarChar, ReviewNum, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocReviewDate_5", SqlDbType.VarChar, ReviewDate, ParameterDirection.Input)
        persist1.Sp_AddParam("@FilePath_6", SqlDbType.VarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_7 ", SqlDbType.VarChar, DocType.DocTypeID, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocDateHistory_8", SqlDbType.VarChar, DateHist, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbIsoDocHistory_Ins", CnnString, False)
        persist1.ClearParameter()
    End Sub
End Class
