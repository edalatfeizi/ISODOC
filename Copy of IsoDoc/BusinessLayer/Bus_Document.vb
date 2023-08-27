Public MustInherit Class Bus_Document

    Public MustOverride Sub Insert()
    Public MustOverride Sub Delete()
    Public MustOverride Sub Update()
    Public MustOverride Function GetAllInfo() As DataTable

    Private mDocCode As String
    Private mDocName As String
    Private mFilePath As String
    Private mFileSettingPath As String
    Private mReviewDate As String
    Private mMdepCode As String
    Private mHistorySave As String
    Private mMainID As Integer
    Private mDocTypeID As New Bus_DocType
    Private mReviewNum As String
    'Private mDocPathNew As Byte
    Private mDocID As Integer
    Private mIsPrint As Boolean

    'Friend Property DocPathNew() As Byte
    '    Get
    '        Return mDocPathNew
    '    End Get
    '    Set(ByVal value As Byte)
    '        mDocPathNew = value
    '    End Set
    'End Property
    Friend Property IsPrint() As Integer
        Get
            Return mIsPrint
        End Get
        Set(ByVal value As Integer)
            mIsPrint = value
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
    Friend Property ReviewNum() As String
        Get
            Return mReviewNum
        End Get
        Set(ByVal value As String)
            mReviewNum = value
        End Set
    End Property

End Class
