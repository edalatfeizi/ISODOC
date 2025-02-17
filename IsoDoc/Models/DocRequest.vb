Public Class DocRequest
    Public Property Id As Integer 'PK'
    Public Property RequesterDepCode As String
    Public Property RequesterDepName As String
    Public Property Title As String
    Public Property DocumentCode As String
    Public Property RequestType As String
    Public Property StoreDuration As String
    Public Property Changes As String
    Public Property UpdateOrNewDocReason As String
    Public Property OffererName As String
    Public Property SysOfficeBossName As String
    Public Property EditOrReview As String
    Public Property SysAdminName As String
    Public Property EditNo As String
    Public Property OkSysOfficeBoss As String
    Public Property OkSysOfficeBossDateTime As String
    Public Property OkSysAdmin As String
    Public Property OkSysAdminDateTime As String
    Public Property OkDocOwnerDepAdmin As String
    Public Property OkDocOwnerDepAdminDateTime As String
    Public Property RegDateTime As String
    Public Property ReqDateTime As String
    Public Property Attachment As Byte()
    Public Property FileExtension As String
    Public Property OffererPersonCode As String
    Public Property SysOfficeBossComment As String
    Public Property SysAdminComment As String
    Public Property RequesterDepBossOrAdminComment As String
    Public Property DocOwnerDepBossOrAdminComment As String
    Public Property DocOwnerDepCode As String
    Public Property DocOwnerDepName As String
    Public Property Active As Boolean

    Public Sub New()
    End Sub

    Public Sub New(
                  RequesterDepCode As String,
                  RequesterDepName As String,
                  Title As String,
                  DocumentCode As String,
                  RequestType As String,
                  StoreDuration As String,
                  Changes As String,
                  UpdateOrNewDocReason As String,
                  OffererName As String,
                  SysOfficeBossName As String,
                  EditOrReview As Boolean,
                  SysAdminName As String,
                  EditNo As String,
                  OkSysOfficeBoss As Boolean,
                  OkSysOfficeBossDateTime As String,
                  OkSysAdmin As Boolean,
                  OkSysAdminDateTime As String,
                  OkDocOwnerDepAdmin As Boolean,
                  OkDocOwnerDepAdminDateTime As String,
                  RegDateTime As String,
                  ReqDateTime As String,
                  Attachment As Byte(),
                  FileExtension As String,
                  OffererPersonCode As String,
                  SysOfficeBossComment As String,
                  SysAdminComment As String,
                  RequesterDepBossOrAdminComment As String,
                  DocOwnerDepBossOrAdminComment As String,
                  DocOwnerDepCode As String,
                  DocOwnerDepName As String,
                  Active As Boolean,
                  Optional Id As Integer = 0
              )
        Me.RequesterDepCode = RequesterDepCode
        Me.RequesterDepName = RequesterDepName
        Me.Title = Title
        Me.DocumentCode = DocumentCode
        Me.RequestType = RequestType
        Me.StoreDuration = StoreDuration
        Me.Changes = Changes
        Me.UpdateOrNewDocReason = UpdateOrNewDocReason
        Me.OffererName = OffererName
        Me.SysOfficeBossName = SysOfficeBossName
        Me.EditOrReview = EditOrReview
        Me.SysAdminName = SysAdminName
        Me.EditNo = EditNo
        Me.OkSysOfficeBoss = OkSysOfficeBoss
        Me.OkSysOfficeBossDateTime = OkSysOfficeBossDateTime
        Me.OkSysAdmin = OkSysAdmin
        Me.OkSysAdminDateTime = OkSysAdminDateTime
        Me.OkDocOwnerDepAdmin = OkDocOwnerDepAdmin
        Me.OkDocOwnerDepAdminDateTime = OkDocOwnerDepAdminDateTime
        Me.RegDateTime = RegDateTime
        Me.ReqDateTime = ReqDateTime
        Me.Attachment = Attachment
        Me.FileExtension = FileExtension
        Me.OffererPersonCode = OffererPersonCode
        Me.SysOfficeBossComment = SysOfficeBossComment
        Me.SysAdminComment = SysAdminComment
        Me.RequesterDepBossOrAdminComment = RequesterDepBossOrAdminComment
        Me.DocOwnerDepBossOrAdminComment = DocOwnerDepBossOrAdminComment
        Me.DocOwnerDepCode = DocOwnerDepCode
        Me.DocOwnerDepName = DocOwnerDepName
        Me.Active = Active
    End Sub
End Class
