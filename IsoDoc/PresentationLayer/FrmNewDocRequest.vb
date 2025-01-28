Public Class FrmNewDocRequest
    Private Bus_NewDocRequest As New Bus_NewDocRequest

    Private Sub FrmNewDocRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userName = SystemInformation.UserName.ToString()
        Dim dtUserDep As New DataTable


    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim docRequest As New DocRequest() With {
   .RequesterDepId = 1,
   .RequesterDepName = "Sales Department",
   .Title = "New Policy Document",
   .DocumentCode = "DOC002",
   .RequestType = "Update",
   .StoreDuration = "Temporary",
   .Changes = "Updated section 3.4",
   .UpdateOrNewDocReason = "Project updates",
   .OffererName = "John Doe",
   .SystemsOfficeBossName = "Jane Smith",
   .DoWithReview = True,
   .SystemsAdminName = "Admin User",
   .EditNo = "2",
   .OkSystemsOfficeBoss = True,
   .OkSystemsOfficeBossDateTime = DateTime.Now,
   .OkSystemsAdmin = True,
   .OkSystemsAdminDateTime = DateTime.Now,
   .OkDocOwnerDepAdmin = True,
   .OkDocOwnerDepAdminDateTime = DateTime.Now,
   .RegDateTime = DateTime.Now,
   .ReqDateTime = DateTime.Now.AddDays(-1)
}

        Bus_NewDocRequest.Insert(docRequest)
    End Sub
End Class