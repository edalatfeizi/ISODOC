Public Class DocRequest
    Public Property Id As Integer 'PK'
    Public Property RequesterDepId As Integer
    Public Property RequesterDepName As String
    Public Property Title As String
    Public Property DocumentCode As String
    Public Property RequestType As String
    Public Property StoreDuration As String
    Public Property Changes As String
    Public Property UpdateOrNewDocReason As String
    Public Property OffererName As String
    Public Property SystemsOfficeBossName As String
    Public Property DoWithReview As Boolean
    Public Property SystemsAdminName As String
    Public Property EditNo As String
    Public Property OkSystemsOfficeBoss As Boolean
    Public Property OkSystemsOfficeBossDateTime As String
    Public Property OkSystemsAdmin As Boolean
    Public Property OkSystemsAdminDateTime As String
    Public Property OkDocOwnerDepAdmin As Boolean
    Public Property OkDocOwnerDepAdminDateTime As String
    Public Property RegDateTime As String
    Public Property ReqDateTime As String

    Public Sub New()
    End Sub

    Public Sub New(
                  id As Integer,
                  requesterDepId As Integer,
                  requesterDepName As String,
                  title As String,
                  documentCode As String,
                  requestType As String,
                  storeDuration As String,
                  changes As String,
                  updateOrNewDocReason As String,
                  offererName As String,
                  systemsOfficeBossName As String,
                  doWithReview As Boolean,
                  systemsAdminName As String,
                  editNo As String,
                  okSystemsOfficeBoss As Boolean,
                  okSystemsOfficeBossDateTime As String,
                  okSystemsAdmin As Boolean,
                  okSystemsAdminDateTime As String,
                  okDocOwnerDepAdmin As Boolean,
                  okDocOwnerDepAdminDateTime As String,
                  regDateTime As String,
                  reqDateTime As String
              )
        Me.Id = id
        Me.RequesterDepId = requesterDepId
        Me.RequesterDepName = requesterDepName
        Me.Title = title
        Me.DocumentCode = documentCode
        Me.RequestType = requestType
        Me.StoreDuration = storeDuration
        Me.Changes = changes
        Me.UpdateOrNewDocReason = updateOrNewDocReason
        Me.OffererName = offererName
        Me.SystemsOfficeBossName = systemsOfficeBossName
        Me.DoWithReview = doWithReview
        Me.SystemsAdminName = systemsAdminName
        Me.EditNo = editNo
        Me.OkSystemsOfficeBoss = okSystemsOfficeBoss
        Me.OkSystemsOfficeBossDateTime = okSystemsOfficeBossDateTime
        Me.OkSystemsAdmin = okSystemsAdmin
        Me.OkSystemsAdminDateTime = okSystemsAdminDateTime
        Me.OkDocOwnerDepAdmin = okDocOwnerDepAdmin
        Me.OkDocOwnerDepAdminDateTime = okDocOwnerDepAdminDateTime
        Me.RegDateTime = regDateTime
        Me.ReqDateTime = reqDateTime
    End Sub
End Class
