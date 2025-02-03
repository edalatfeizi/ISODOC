Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports DevExpress.Xpo.DB

Public Class FrmNewDocRequest
    Private Bus_NewDocRequest As New Bus_NewDocRequest
    Private Mdepart As New Personely.FacadJobClassification.FacMDepart
    Private dt_MDepart As DataTable
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
        lblReqId.Text = maxReqId + 1
    End Sub
    Private Sub FillDepsCombo()
        dt_MDepart = Mdepart.GetMDepartList()
        cmbDeps.DataSource = dt_MDepart
        cmbDeps.DisplayMember = "MDepName" ' Column to display
        cmbDeps.ValueMember = "MDepID"

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
        docRequest.Attachment = Nothing

        'get systems office boss info
        'Dim dtSysOfficeBossInfo = Bus_NewDocRequest.GetPostUserInfo(270) '270 is the id of systems office boss post
        'Dim sysOfficeBossFName = dtUserInfo.DefaultView.Item(0).Item("FirstName")
        'Dim sysOfficeBossLName = dtUserInfo.DefaultView.Item(0).Item("LastName")
        'docRequest.SystemsOfficeBossName = sysOfficeBossFName + " " + sysOfficeBossLName

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
End Class