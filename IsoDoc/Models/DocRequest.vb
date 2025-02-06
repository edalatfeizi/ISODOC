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
    Public Property EditOrReview As Boolean
    Public Property SysAdminName As String
    Public Property EditNo As String
    Public Property OkSysOfficeBoss As Boolean
    Public Property OkSysOfficeBossDateTime As String
    Public Property OkSysAdmin As Boolean
    Public Property OkSysAdminDateTime As String
    Public Property OkDocOwnerDepAdmin As Boolean
    Public Property OkDocOwnerDepAdminDateTime As String
    Public Property RegDateTime As String
    Public Property ReqDateTime As String
    Public Property Attachment As Byte()
    Public Property OffererPersonCode As String
    Public Property SysOfficeBossComment As String
    Public Property SysAdminComment As String
    Public Property RequesterDepBossOrAdminComment As String
    Public Property DocOwnerDepBossOrAdminComment As String
    Public Property DocOwnerDepCode As String
    Public Property DocOwnerDepName As String

    Public Sub New()
    End Sub

    Public Sub New(
                  requesterDepCode As String,
                  requesterDepName As String,
                  title As String,
                  documentCode As String,
                  requestType As String,
                  storeDuration As String,
                  changes As String,
                  updateOrNewDocReason As String,
                  offererName As String,
                  sysOfficeBossName As String,
                  editOrReview As Boolean,
                  sysAdminName As String,
                  editNo As String,
                  okSysOfficeBoss As Boolean,
                  okSysOfficeBossDateTime As String,
                  okSysAdmin As Boolean,
                  okSysAdminDateTime As String,
                  okDocOwnerDepAdmin As Boolean,
                  okDocOwnerDepAdminDateTime As String,
                  regDateTime As String,
                  reqDateTime As String,
                  attachment As Byte(),
                  offererPersonCode As String,
                  sysOfficeBossComment As String,
                  sysAdminComment As String,
                  requesterDepBossOrAdminComment As String,
                  docOwnerDepBossOrAdminComment As String,
                  docOwnerDepCode As String,
                  docOwnerDepName As String
              )
        Me.RequesterDepCode = requesterDepCode
        Me.RequesterDepName = requesterDepName
        Me.Title = title
        Me.DocumentCode = documentCode
        Me.RequestType = requestType
        Me.StoreDuration = storeDuration
        Me.Changes = changes
        Me.UpdateOrNewDocReason = updateOrNewDocReason
        Me.OffererName = offererName
        Me.SysOfficeBossName = sysOfficeBossName
        Me.EditOrReview = editOrReview
        Me.SysAdminName = sysAdminName
        Me.EditNo = editNo
        Me.OkSysOfficeBoss = okSysOfficeBoss
        Me.OkSysOfficeBossDateTime = okSysOfficeBossDateTime
        Me.OkSysAdmin = okSysAdmin
        Me.OkSysAdminDateTime = okSysAdminDateTime
        Me.OkDocOwnerDepAdmin = okDocOwnerDepAdmin
        Me.OkDocOwnerDepAdminDateTime = okDocOwnerDepAdminDateTime
        Me.RegDateTime = regDateTime
        Me.ReqDateTime = reqDateTime
        Me.Attachment = attachment
        Me.OffererPersonCode = offererPersonCode
        Me.SysOfficeBossComment = sysOfficeBossComment
        Me.SysAdminComment = sysAdminComment
        Me.RequesterDepBossOrAdminComment = requesterDepBossOrAdminComment
        Me.DocOwnerDepBossOrAdminComment = docOwnerDepBossOrAdminComment
        Me.DocOwnerDepCode = docOwnerDepCode
        Me.DocOwnerDepName = docOwnerDepName
    End Sub
End Class
