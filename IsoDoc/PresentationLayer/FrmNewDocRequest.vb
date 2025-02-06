Imports System.IO
Imports DevExpress.XtraEditors


Public Class FrmNewDocRequest
    Private Bus_NewDocRequest As New Bus_NewDocRequest
    Private Mdepart As New Personely.FacadJobClassification.FacMDepart
    Private dtDeps As DataTable
    Private dtDocRequests As DataTable
    Dim docRequest As New DocRequest()
    Private Sub FrmNewDocRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDepsCombo()
        ' txtReqDate.Text = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString()
        SetNewRequestId()

    End Sub
    Private Sub SetNewRequestId()
        'set new request id
        Dim dtMaxReqId = Bus_NewDocRequest.GetMaxRequestId()
        Dim maxReqId = dtMaxReqId.DefaultView.Item(0).Item("MaxReqId")
        txtReqCode.Text = maxReqId + 1
    End Sub
    Private Sub FillDepsCombo()
        dtDeps = Bus_NewDocRequest.GetDepsList()
        cmbDeps.DataSource = dtDeps
        cmbDeps.DisplayMember = "نام واحد" ' Column to display
        cmbDeps.ValueMember = "کد واحد"

        ' Now, bind the list to the LookUpEdit control
        cmbDocOwnerDep.Properties.DataSource = dtDeps
        cmbDocOwnerDep.Properties.DisplayMember = "نام واحد"
        cmbDocOwnerDep.Properties.ValueMember = "کد واحد"

        Dim userName = SystemInformation.UserName.ToString()
        Dim dtUserInfo = Bus_NewDocRequest.GetUserInfo(userName)
        Dim userFirstName = dtUserInfo.DefaultView.Item(0).Item("FirstName")
        Dim userLastName = dtUserInfo.DefaultView.Item(0).Item("LastName")

        Dim depName = dtUserInfo.DefaultView.Item(0).Item("NameVahed")
        Dim depCode = dtUserInfo.DefaultView.Item(0).Item("DepartCode")
        cmbDeps.SelectedValue = depCode

        docRequest.RequesterDepCode = depCode
        docRequest.RequesterDepName = depName
        docRequest.OffererName = userFirstName + " " + userLastName
        docRequest.EditOrReview = False
        docRequest.EditNo = ""
        docRequest.OkSysOfficeBoss = False
        docRequest.OkSysOfficeBossDateTime = ""
        docRequest.OkSysAdmin = False
        docRequest.OkSysAdminDateTime = ""
        docRequest.OkDocOwnerDepAdmin = False
        docRequest.OkDocOwnerDepAdminDateTime = ""
        docRequest.RegDateTime = ""
        docRequest.OffererPersonCode = dtUserInfo.DefaultView.Item(0).Item("PersonCode")
        docRequest.SysOfficeBossComment = ""
        docRequest.SysAdminComment = ""
        docRequest.SysAdminComment = ""
        docRequest.RequesterDepBossOrAdminComment = ""
        docRequest.DocOwnerDepBossOrAdminComment = ""

        docRequest.Attachment = Nothing

        'if user is sys office boss get all doc requests

        'if user is admin then get user's own doc requests and also all doc requests belongs to his/her dep

        'if user is not an admin or sys office boss then get user's own doc requests

        dtDocRequests = Bus_NewDocRequest.GetDocRequests()
        grdDocRequests.DataSource = dtDocRequests
        'get systems office boss info
        'Dim dtSysOfficeBossInfo = Bus_NewDocRequest.GetPostUserInfo(270) '270 is the id of systems office boss post
        'Dim sysOfficeBossFName = dtUserInfo.DefaultView.Item(0).Item("FirstName")
        'Dim sysOfficeBossLName = dtUserInfo.DefaultView.Item(0).Item("LastName")
        'docRequest.SystemsOfficeBossName = sysOfficeBossFName + " " + sysOfficeBossLName


        'Get dep admins
        'Dim depAdminsDt = Bus_NewDocRequest.GetDepAdmins("SI000") 'get systems dep admins
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If String.IsNullOrEmpty(txtTitle.Text) Or String.IsNullOrEmpty(cmbReqTypes.SelectedItem.ToString()) Or
           String.IsNullOrEmpty(txtChanges.Text) Or String.IsNullOrEmpty(txtReason.Text) Then
            MessageBox.Show("لطفا همه مقادیر ستاره دار را وارد کنید", "تکمیل اطلاعات")
        Else

            If cmbReqTypes.SelectedItem.ToString() = "تغییر" Or cmbReqTypes.SelectedItem.ToString() = "حذف" Then
                If String.IsNullOrEmpty(txtDocNo.Text) Then
                    MessageBox.Show("لطفا شماره سند را وارد کنید", "تکمیل اطلاعات")

                Else
                    SaveDocRequest()
                End If
            Else

                SaveDocRequest()

            End If


        End If





    End Sub
    Private Sub SaveDocRequest()
        docRequest.Title = txtTitle.Text
        docRequest.DocumentCode = txtDocNo.Text
        docRequest.RequestType = cmbReqTypes.SelectedItem.ToString()
        docRequest.StoreDuration = txtStoreDuration.Text
        docRequest.Changes = txtChanges.Text
        docRequest.UpdateOrNewDocReason = txtReason.Text
        docRequest.ReqDateTime = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString()
        'docRequest.DocOwnerDepCode =
        Bus_NewDocRequest.Insert(docRequest)
        MessageBox.Show("عملیات مورد نظر با موفقیت انجام شد", "عملیات موفقیت آمیز")
        ClearData()
    End Sub
    Private Sub ClearData()
        txtTitle.Text = ""
        txtDocNo.Text = ""
        cmbReqTypes.SelectedItem = ""
        txtStoreDuration.Text = ""
        txtChanges.Text = ""
        txtReason.Text = ""

        docRequest.Title = ""
        docRequest.DocumentCode = ""
        docRequest.RequestType = ""
        docRequest.StoreDuration = ""
        docRequest.Changes = ""
        docRequest.UpdateOrNewDocReason = ""
        docRequest.ReqDateTime = ""
        docRequest.Attachment = Nothing
    End Sub
    Private Sub txtRegDate_TextChanged(sender As Object, e As EventArgs) Handles txtRegDate.TextChanged

    End Sub

    Private Sub txtRegDate_MouseClick(sender As Object, e As MouseEventArgs) Handles txtRegDate.MouseClick
        SelectDate(txtRegDate)

    End Sub
    Private Function SelectDate(txt As TextBox) As String
        Dim f2 As New FrmPersianDatePicker()
        Dim returnedValue As String = ""

        ' Open Form2 as a modal dialog
        If f2.ShowDialog() = DialogResult.OK Then
            ' Retrieve the value from Form2
            returnedValue = f2.SelectedDate
            txt.Text = returnedValue
        Else

        End If
        Return returnedValue
    End Function

    Private Sub btnAttachFiles_Click(sender As Object, e As EventArgs) Handles btnAttachFiles.Click

        AttachFile()

    End Sub

    Private Sub pbAttachFiles_Click(sender As Object, e As EventArgs) Handles pbAttachFiles.Click
        AttachFile()
    End Sub

    Private Sub AttachFile()
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Word Files|*.docx;*.doc|Excel Files|*.xlsx;*.xls"
        openFileDialog.Title = "فایل پیوست مورد نظر را انتخاب کنید"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            docRequest.Attachment = File.ReadAllBytes(filePath)
            btnFileName.Visible = True
            btnFileName.Text = openFileDialog.SafeFileName
        End If
    End Sub

    Private Sub btnFileName_Click(sender As Object, e As EventArgs) Handles btnFileName.Click
        If docRequest.Attachment IsNot Nothing Then
            docRequest.Attachment = Nothing
            btnFileName.Visible = False
            Return
        End If
    End Sub

    Private Sub txtDocNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocNo.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbDocOwnerDep_EditValueChanged(sender As Object, e As EventArgs) Handles cmbDocOwnerDep.EditValueChanged
        docRequest.DocOwnerDepName = cmbDocOwnerDep.SelectedText
        docRequest.DocOwnerDepCode = cmbDocOwnerDep.EditValue.ToString()
    End Sub

    Private Sub cmbReqTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReqTypes.SelectedIndexChanged
        If cmbReqTypes.SelectedIndex = 1 Or cmbReqTypes.SelectedIndex = 2 Then
            lblDocNoStar.Visible = True

        Else
            lblDocNoStar.Visible = False

        End If
    End Sub
End Class