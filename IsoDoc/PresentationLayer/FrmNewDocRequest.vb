Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.[Shared].Json
Imports DevExpress.XtraEditors
Imports mshtml


Public Class FrmNewDocRequest
    Private Bus_NewDocRequest As New Bus_NewDocRequest
    Private Mdepart As New Personely.FacadJobClassification.FacMDepart
    Private dtDeps As DataTable
    Private dtAllDocsInfo As DataTable
    Private dtDocRequests As DataTable
    Dim docRequest As New DocRequest()
    Dim userType As New UserTypes
    Dim selectedDocReqId = ""
    Dim btnDownload As New Repository.RepositoryItemButtonEdit()
    Dim btnNoAttachment As New Repository.RepositoryItemButtonEdit()

    Private Sub FrmNewDocRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDepsCombo()
        FillData()
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
        cmbDocOwnerDep.Text = ""

        cmbReqTypes.SelectedIndex = 0

        dtAllDocsInfo = Bus_NewDocRequest.GetAllDocsInfo()
        cmbDocTitle.Properties.DataSource = dtAllDocsInfo
        cmbDocTitle.Properties.DisplayMember = "عنوان سند"
        cmbDocTitle.Properties.ValueMember = "کد سند"
        cmbDocTitle.Text = ""



        'if user is sys office boss get all doc requests

        'if user is admin then get user's own doc requests and also all doc requests belongs to his/her dep

        'if user is not an admin or sys office boss then get user's own doc requests

#Region "adjust gridview columns width based on their content"



#End Region
#Region "config EditOrReview column fixed values"
        'set EditOrReview column values to fixed ones
        Dim EditOrReviewEdit As New Repository.RepositoryItemComboBox()
        'prevent free text entry
        EditOrReviewEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

        EditOrReviewEdit.Items.Add("با بازنگری انجام شود")
        EditOrReviewEdit.Items.Add("با ویرایش انجام شود")
        grdDocRequests.RepositoryItems.Add(EditOrReviewEdit)
        ' Assign the repository item to the column.
        GridView1.Columns("EditOrReview").ColumnEdit = EditOrReviewEdit

#End Region
#Region "config OkSysOfficeBoss column fixed values"
        'set OkSysOfficeBoss column values to fixed ones
        Dim OkSysOfficeBossEdit As New Repository.RepositoryItemComboBox()
        'prevent free text entry
        OkSysOfficeBossEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

        OkSysOfficeBossEdit.Items.Add("تایید")
        OkSysOfficeBossEdit.Items.Add("عدم تایید")
        grdDocRequests.RepositoryItems.Add(OkSysOfficeBossEdit)
        ' Assign the repository item to the column.
        GridView1.Columns("OkSysOfficeBoss").ColumnEdit = OkSysOfficeBossEdit
#End Region
#Region "config OkDocOwnerDepAdmin column fixed values"
        'set OkDocOwnerDepAdmin column values to fixed ones
        Dim OkDocOwnerDepAdminEdit As New Repository.RepositoryItemComboBox()
        'prevent free text entry
        OkDocOwnerDepAdminEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

        OkDocOwnerDepAdminEdit.Items.Add("تایید")
        OkDocOwnerDepAdminEdit.Items.Add("عدم تایید")
        grdDocRequests.RepositoryItems.Add(OkDocOwnerDepAdminEdit)
        ' Assign the repository item to the column.
        GridView1.Columns("OkDocOwnerDepAdmin").ColumnEdit = OkDocOwnerDepAdminEdit
#End Region
#Region "config OkSysAdmin column fixed values"
        'set OkSysAdmin column values to fixed ones
        Dim OkSysAdminEdit As New Repository.RepositoryItemComboBox()
        'prevent free text entry
        OkSysAdminEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

        OkSysAdminEdit.Items.Add("تایید")
        OkSysAdminEdit.Items.Add("عدم تایید")
        grdDocRequests.RepositoryItems.Add(OkSysAdminEdit)
        ' Assign the repository item to the column.
        GridView1.Columns("OkSysAdmin").ColumnEdit = OkSysAdminEdit
#End Region
#Region "config Active column fixed values"
        'set OkSysAdmin column values to fixed ones
        Dim ActiveEdit As New Repository.RepositoryItemComboBox()
        'prevent free text entry
        ActiveEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

        ActiveEdit.Items.Add("فعال")
        ActiveEdit.Items.Add("غیر فعال")
        grdDocRequests.RepositoryItems.Add(ActiveEdit)
        ' Assign the repository item to the column.
        GridView1.Columns("Active").ColumnEdit = ActiveEdit
#End Region

#Region "config RequestType column fixed values"
        'set OkSysAdmin column values to fixed ones
        Dim RequestTypeEdit As New Repository.RepositoryItemComboBox()
        'prevent free text entry
        RequestTypeEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

        RequestTypeEdit.Items.Add("ایجاد")
        RequestTypeEdit.Items.Add("ویرایش")
        RequestTypeEdit.Items.Add("حذف")
        grdDocRequests.RepositoryItems.Add(RequestTypeEdit)
        ' Assign the repository item to the column.
        GridView1.Columns("RequestType").ColumnEdit = RequestTypeEdit
#End Region
#Region "config download attachment"

        ' Configure the button:
        ' - Use a glyph (icon) button.
        ' - Assign an image to represent “download”. You can use an embedded resource or an image from your project.
        btnDownload.Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
        btnDownload.Buttons(0).Image = My.Resources.im_download_32  ' Replace with your download icon.
        btnDownload.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor

        ' Optionally, adjust appearance settings if needed (e.g., button size).
        ' Add the repository item to your grid control's RepositoryItems collection.
        grdDocRequests.RepositoryItems.Add(btnDownload)
#End Region
#Region "config no attachment button"

        ' Configure the button:
        ' - Use a glyph (icon) button.
        ' - Assign an image to represent “download”. You can use an embedded resource or an image from your project.
        btnNoAttachment.Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
        btnNoAttachment.Buttons(0).Image = My.Resources.DeleteLarge  ' Replace with your download icon.
        btnNoAttachment.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor

        ' Optionally, adjust appearance settings if needed (e.g., button size).
        ' Add the repository item to your grid control's RepositoryItems collection.
        grdDocRequests.RepositoryItems.Add(btnNoAttachment)
#End Region


    End Sub

    Private Sub FillData()
        Dim userName = SystemInformation.UserName.ToString()
        Dim dtUserInfo = Bus_NewDocRequest.GetUserInfo(userName)
        Dim userPersonCode = dtUserInfo.DefaultView.Item(0).Item("PersonCode")
        Dim userDepartCode = dtUserInfo.DefaultView.Item(0).Item("DepartCode")

        Dim userFirstName = dtUserInfo.DefaultView.Item(0).Item("FirstName")
        Dim userLastName = dtUserInfo.DefaultView.Item(0).Item("LastName")

        Dim depName = dtUserInfo.DefaultView.Item(0).Item("NameVahed")
        Dim userDepCode = dtUserInfo.DefaultView.Item(0).Item("DepartCode").ToString().Trim()
        cmbDeps.SelectedValue = userDepCode

        docRequest.RequesterDepCode = userDepCode
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
#Region "Systems office boss"
        'get systems office boss info

        Dim dtSysOfficeBossInfo = Bus_NewDocRequest.GetPostUserInfo(270) '270 is the id of systems office boss depart id
        Dim sysBossPCode = dtSysOfficeBossInfo.DefaultView.Item(0).Item("PersonCode")
        sysBossPCode = "14023910"
        If sysBossPCode = userPersonCode Then
            userType = UserTypes.SysOfficeBoss
            'this user is sys office boss
            Dim dtSysBossRequests = GetRequests()
            ToggleColumnEditing(GridView1, "EditOrReview", True)
            ToggleColumnEditing(GridView1, "EditNo", True)
            ToggleColumnEditing(GridView1, "RegDateTime", True)
            ToggleColumnEditing(GridView1, "OkSysOfficeBoss", True)
            ToggleColumnEditing(GridView1, "SysOfficeBossComment", True)

            HighlightColumns("EditOrReview", "EditNo", "RegDateTime", "OkSysOfficeBoss", "SysOfficeBossComment")

            FillGrid(dtSysBossRequests)
            Return

        End If
#End Region
#Region "Systems Admins"

        'Get dep admins
        Dim sysAdminsDt = Bus_NewDocRequest.GetDepAdmins("SI000") 'get systems dep admins
        Dim adminPersonCodes As New List(Of String)

        ' Loop through each DataRow in the DataTable.
        For Each dr As DataRow In sysAdminsDt.Rows
            ' Replace "YourColumnName" with the actual name of the column you want.
            adminPersonCodes.Add(dr("PersonCode").ToString())
        Next
        'userPersonCode = "14013815"
        If adminPersonCodes.Contains(userPersonCode) Then
            userType = UserTypes.SysAdmin

            Dim dtSysAdminRequests = GetRequests()

            ToggleColumnEditing(GridView1, "SysAdminComment", True)
            ToggleColumnEditing(GridView1, "OkSysAdmin", True)
            HighlightColumns("SysAdminComment", "OkSysAdmin")

            FillGrid(dtSysAdminRequests)
            Return
        End If
#End Region
#Region "Other Deps Admins"


        'Get dep admins

        Dim dtUserRequests As DataTable = GetRequests("where OffererPersonCode = '" + userPersonCode.ToString() + " '")
        If dtUserRequests.Rows.Count > 0 Then

            ToggleColumnEditing(GridView1, "Title", True)
            ToggleColumnEditing(GridView1, "DocumentCode", True)
            ToggleColumnEditing(GridView1, "StoreDuration", True)
            ToggleColumnEditing(GridView1, "Changes", True)
            ToggleColumnEditing(GridView1, "UpdateOrNewDocReason", True)
            ToggleColumnEditing(GridView1, "RequestType", True)
            HighlightColumns("Title", "DocumentCode", "StoreDuration", "Changes", "UpdateOrNewDocReason", "RequestType")

        End If
        Dim depAdminsDt = Bus_NewDocRequest.GetDepAdmins(userDepCode) 'get systems dep admins
        Dim depAdminPersonCodes As New List(Of String)

        ' Loop through each DataRow in the DataTable.
        For Each dr As DataRow In sysAdminsDt.Rows
            ' Replace "YourColumnName" with the actual name of the column you want.
            adminPersonCodes.Add(dr("PersonCode").ToString())
        Next
        'userPersonCode = "14033956"
        If adminPersonCodes.Contains(userPersonCode) Then
            userType = UserTypes.DepAdmin

            'get doc requests related to dep 
            Dim depRequests = GetRequests("where DocOwnerDepCode = '" + userDepartCode + " '")
            dtUserRequests.Merge(depRequests)

            ToggleColumnEditing(GridView1, "DocOwnerDepBossOrAdminComment", True)
            ToggleColumnEditing(GridView1, "OkDocOwnerDepAdmin", True)
            HighlightColumns("DocOwnerDepBossOrAdminComment", "OkDocOwnerDepAdmin")

        End If
        userType = UserTypes.SysOfficeBoss

        FillGrid(dtUserRequests)

#End Region
    End Sub
    Private Sub HighlightColumns(ParamArray columnNames() As String)
        For Each column As String In columnNames
            GridView1.Columns(column).AppearanceCell.BackColor = Color.LightBlue
            GridView1.Columns(column).AppearanceCell.Options.UseBackColor = True
        Next
    End Sub
    Private Function GetRequests(Optional filter As String = "") As DataTable
        GetRequests = Bus_NewDocRequest.GetDocRequests(filter)
    End Function

    Private Sub FillGrid(requests As DataTable)
        GridView1.OptionsView.ColumnAutoWidth = False


        grdDocRequests.DataSource = requests
        'After Binding your data (e.g., after setting the DataSource),
        ' adjust each column's width based on its content.

        GridView1.BestFitColumns()
    End Sub
    Private Sub ToggleColumnEditing(gridView As DevExpress.XtraGrid.Views.Grid.GridView, columnName As String, enabled As Boolean)
        Dim column As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns(columnName)
        If column IsNot Nothing Then
            column.OptionsColumn.AllowEdit = enabled
        End If
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If cmbReqTypes.SelectedItem Is Nothing Then
            ShowEmptyMessage()
            Return

        End If
        If cmbReqTypes.SelectedIndex = 0 And String.IsNullOrEmpty(txtNewDocTitle.Text) Then
            ShowEmptyMessage()
            Return
        End If
        If cmbReqTypes.SelectedIndex <> 0 And cmbDocTitle.EditValue Is Nothing Then
            ShowEmptyMessage()
            Return

        End If

        If String.IsNullOrWhiteSpace(txtChanges.Text) Or String.IsNullOrWhiteSpace(txtReason.Text) Then
            ShowEmptyMessage()
            Return
        End If

        If cmbDocOwnerDep.EditValue Is Nothing Then
            ShowEmptyMessage()
            Return
        End If

        SaveDocRequest()





    End Sub
    Private Sub ShowEmptyMessage()
        MessageBox.Show("لطفا همه مقادیر ستاره دار را وارد کنید", "تکمیل اطلاعات")

    End Sub
    Private Sub SaveDocRequest()
        If cmbReqTypes.SelectedIndex = 0 Then
            docRequest.Title = txtNewDocTitle.Text
            docRequest.DocumentCode = 0
        End If
        docRequest.RequestType = cmbReqTypes.SelectedItem.ToString()
        docRequest.StoreDuration = txtStoreDuration.Text
        docRequest.Changes = txtChanges.Text
        docRequest.UpdateOrNewDocReason = txtReason.Text
        docRequest.ReqDateTime = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString()
        'docRequest.DocOwnerDepCode =
        Bus_NewDocRequest.Insert(docRequest)
        MessageBox.Show("عملیات مورد نظر با موفقیت انجام شد", "عملیات موفقیت آمیز")
        ClearData()
        FillData()
    End Sub
    Private Sub ClearData()
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

        AttachFile(docRequest, True)

    End Sub

    Private Sub pbAttachFiles_Click(sender As Object, e As EventArgs) Handles pbAttachFiles.Click
        AttachFile(docRequest, True)
    End Sub

    Private Sub AttachFile(docRequest As DocRequest, showFileName As Boolean)
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Word Files|*.docx;*.doc|Excel Files|*.xlsx;*.xls"
        openFileDialog.Title = "فایل پیوست مورد نظر را انتخاب کنید"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            docRequest.Attachment = File.ReadAllBytes(filePath)
            Dim fileExtension As String = Path.GetExtension(filePath)
            ' Optionally, store the extension in your docRequest object (assuming you have such a property).
            docRequest.FileExtension = fileExtension
            If showFileName Then
                btnFileName.Visible = True
                btnFileName.Text = openFileDialog.SafeFileName
            End If

        End If
    End Sub

    Private Sub btnFileName_Click(sender As Object, e As EventArgs) Handles btnFileName.Click
        If docRequest.Attachment IsNot Nothing Then
            docRequest.Attachment = Nothing
            docRequest.FileExtension = ""
            btnFileName.Visible = False
            Return
        End If
    End Sub

    Private Sub txtDocNo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbDocOwnerDep_EditValueChanged(sender As Object, e As EventArgs) Handles cmbDocOwnerDep.EditValueChanged
        docRequest.DocOwnerDepName = cmbDocOwnerDep.SelectedText
        docRequest.DocOwnerDepCode = cmbDocOwnerDep.EditValue.ToString()
    End Sub

    Private Sub cmbReqTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReqTypes.SelectedIndexChanged
        If cmbReqTypes.SelectedIndex = 0 Then
            txtNewDocTitle.Visible = True
            cmbDocTitle.Visible = False
            txtStoreDuration.Enabled = True
        Else
            txtNewDocTitle.Visible = False
            cmbDocTitle.Visible = True
            txtStoreDuration.Enabled = False
        End If
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        ' Replace "IsActive" with your actual field name if different.
        If e.Column.FieldName = "Active" Then
            If TypeOf e.Value Is Boolean Then
                If CBool(e.Value) Then
                    e.DisplayText = "فعال"
                Else
                    e.DisplayText = "غیر فعال"
                End If

            End If
        End If
        'If e.Column.FieldName = "OkDocOwnerDepAdmin" Or e.Column.FieldName = "OkSysAdmin" Or e.Column.FieldName = "OkSysOfficeBoss" Then
        '    If TypeOf e.Value Is Boolean Then
        '        If CBool(e.Value) Then
        '            e.DisplayText = "تایید"
        '        Else
        '            e.DisplayText = "عدم تایید"
        '        End If

        '    Else
        '        e.DisplayText = "عدم تایید"

        '    End If
        'End If

    End Sub

    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles GridView1.CustomRowCellEdit
        ' Check if this is the "Attachment" column.
        If e.Column.FieldName = "Attachment" Then
            ' Get the cell value for the "Attachment" column.
            Dim cellValue As Object = GridView1.GetRowCellValue(e.RowHandle, "Attachment")
            ' If the cell has data (not null or DBNull), assign the button editor.
            If cellValue IsNot Nothing AndAlso cellValue IsNot DBNull.Value Then
                e.RepositoryItem = btnDownload
            Else
                ' Optionally, assign a simple (non-editable) repository or nothing.
                e.RepositoryItem = btnNoAttachment
            End If
        End If
    End Sub

    Private Sub cmbDocTitle_EditValueChanged(sender As Object, e As EventArgs) Handles cmbDocTitle.EditValueChanged
        docRequest.Title = cmbDocTitle.SelectedText
        docRequest.DocumentCode = cmbDocTitle.EditValue.ToString()

    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        'Try
        '    Dim OkSysOfficeBoss As Boolean = CBool(GridView1.GetRowCellValue(e.RowHandle, "OkSysOfficeBoss"))
        '    Dim OkSysAdmin As Boolean = CBool(GridView1.GetRowCellValue(e.RowHandle, "OkSysAdmin"))
        '    Dim OkDocOwnerDepAdmin As Boolean = CBool(GridView1.GetRowCellValue(e.RowHandle, "OkDocOwnerDepAdmin"))
        '    If OkDocOwnerDepAdmin = False Then
        '        e.Appearance.BackColor = Color.LightGoldenrodYellow
        '    End If
        '    If OkSysOfficeBoss = False Then
        '        e.Appearance.BackColor = Color.LightPink

        '    End If
        '    If OkSysAdmin = False Then
        '        e.Appearance.BackColor = Color.HotPink
        '    End If
        '    If OkSysOfficeBoss And OkSysAdmin And OkDocOwnerDepAdmin Then
        '        e.Appearance.BackColor = Color.LightGreen

        '    End If
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim updatedRow As DataRow = view.GetDataRow(e.RowHandle)

        If updatedRow IsNot Nothing Then
            ' Call a routine to update this row in the database.
            UpdateDatabaseRow(updatedRow)
        End If
    End Sub

    Private Sub UpdateDatabaseRow(ByVal row As DataRow)
        Try
            Dim updatedDocReq As New DocRequest()
            updatedDocReq.Id = row("Id")

            Select Case userType
                Case UserTypes.EndUser
                    updatedDocReq.Title = row("Title")
                    updatedDocReq.DocumentCode = row("DocumentCode")
                    updatedDocReq.StoreDuration = row("StoreDuration")
                    updatedDocReq.Changes = row("Changes")
                    updatedDocReq.UpdateOrNewDocReason = row("UpdateOrNewDocReason")
                    updatedDocReq.RequestType = row("RequestType")

                Case UserTypes.SysOfficeBoss
                    updatedDocReq.EditOrReview = If(row("EditOrReview"), "")
                    updatedDocReq.EditNo = If(Convert.IsDBNull(row("EditNo")), "", row("EditNo").ToString())
                    updatedDocReq.RegDateTime = If(Convert.IsDBNull(row("RegDateTime")), "", row("RegDateTime").ToString())
                    updatedDocReq.OkSysOfficeBoss = If(Convert.IsDBNull(row("OkSysOfficeBoss")), "", row("OkSysOfficeBoss").ToString())
                    updatedDocReq.SysOfficeBossComment = If(Convert.IsDBNull(row("SysOfficeBossComment")), "", row("SysOfficeBossComment").ToString())
                    updatedDocReq.OkSysOfficeBossDateTime = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString()


                Case UserTypes.SysAdmin
                    updatedDocReq.SysAdminComment = row("SysAdminComment")
                    updatedDocReq.OkSysAdmin = row("OkSysAdmin")
                    updatedDocReq.OkSysAdminDateTime = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString()

                Case UserTypes.DepAdmin
                    updatedDocReq.DocOwnerDepBossOrAdminComment = row("DocOwnerDepBossOrAdminComment")
                    updatedDocReq.OkDocOwnerDepAdmin = row("OkDocOwnerDepAdmin")
                    updatedDocReq.OkDocOwnerDepAdminDateTime = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString()

            End Select
            Bus_NewDocRequest.Update(updatedDocReq)
            MessageBox.Show("بروز رسانی اطلاعات با موفقیت انجام شد", "عملیات موفقیت آمیز")
            FillData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در انجام عملیات")

        End Try


    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing


        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = GridView1.FocusedRowHandle
            Dim attachmentValue As Object = GridView1.GetRowCellValue(rowHandle, "Attachment")

            If attachmentValue Is Nothing OrElse Convert.IsDBNull(attachmentValue) Then
                mnuDeleteAttachment.Enabled = False
                mnuOpenAttachment.Enabled = False
                mnuUploadAttachment.Enabled = True

            Else
                mnuDeleteAttachment.Enabled = True
                mnuOpenAttachment.Enabled = True
                mnuUploadAttachment.Enabled = False
            End If

            Dim idValue As Object = GridView1.GetRowCellValue(rowHandle, "Id")
            If idValue IsNot Nothing AndAlso Not Convert.IsDBNull(idValue) Then
                selectedDocReqId = idValue
            End If

            Dim screenPoint As Point = grdDocRequests.PointToScreen(e.Point)
            ContextMenuStrip1.Show(screenPoint)
            ' Optionally disable the default DevExpress menu.
            e.Allow = False
        End If

    End Sub

    Private Sub mnuUploadAttachment_Click(sender As Object, e As EventArgs) Handles mnuUploadAttachment.Click
        Dim updatedDocReq As New DocRequest()
        updatedDocReq.Id = GetSelectedDocReqId()
        AttachFile(updatedDocReq, False)

        Bus_NewDocRequest.Update(updatedDocReq)
        MessageBox.Show("فایل پیوست با موفقیت ذخیره شد.", "عملیات موفقیت آمیز")
        FillData()
    End Sub

    Private Sub mnuOpenAttachment_Click(sender As Object, e As EventArgs) Handles mnuOpenAttachment.Click
        Dim rowHandle As Integer = GridView1.FocusedRowHandle
        If rowHandle < 0 Then Return

        ' Retrieve the binary attachment data.
        Dim attachmentObj As Object = GridView1.GetRowCellValue(rowHandle, "Attachment")
        If attachmentObj Is Nothing OrElse Convert.IsDBNull(attachmentObj) Then
            'MessageBox.Show("No attachment found for this row.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim attachmentData() As Byte = CType(attachmentObj, Byte())

        ' Retrieve the file name from the grid if available.
        Dim defaultFileName As String = "Attachment"
        Dim fileNameObj As Object = GridView1.GetRowCellValue(rowHandle, "FileName")
        If fileNameObj IsNot Nothing AndAlso Not Convert.IsDBNull(fileNameObj) Then
            defaultFileName = fileNameObj.ToString()
        End If

        ' Retrieve the file extension from the FileExtension column.
        Dim fileExt As String = ""
        Dim fileExtObj As Object = GridView1.GetRowCellValue(rowHandle, "FileExtension")
        If fileExtObj IsNot Nothing AndAlso Not Convert.IsDBNull(fileExtObj) Then
            fileExt = fileExtObj.ToString()
        End If

        ' If the default file name doesn't already include the extension, append it.
        If Not defaultFileName.EndsWith(fileExt, StringComparison.OrdinalIgnoreCase) Then
            defaultFileName &= fileExt
        End If

        ' Let the user choose where to save the file.
        Using sfd As New SaveFileDialog()
            sfd.FileName = defaultFileName
            sfd.Filter = "All Files (*.*)|*.*"
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    System.IO.File.WriteAllBytes(sfd.FileName, attachmentData)
                    MessageBox.Show("فایل پیوست با موفقیت ذخیره شد.", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("خطا در ذخیره فایل پیوست: " & ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using

    End Sub

    Private Sub mnuDeleteAttachment_Click(sender As Object, e As EventArgs) Handles mnuDeleteAttachment.Click

        Dim result As DialogResult = MessageBox.Show("آیا برای حذف فایل پیوست مطمئن هستید؟", "حذف فایل پیوست", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim docReqId As Integer = GetSelectedDocReqId()
            Bus_NewDocRequest.DeleteDocRequestAttachment(docReqId)
            MessageBox.Show("فایل پیوست با موفقیت حذف شد.", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FillData()
        ElseIf result = DialogResult.No Then

        End If


    End Sub
    Private Function GetSelectedDocReqId() As Integer
        Dim rowHandle As Integer = GridView1.FocusedRowHandle
        If rowHandle < 0 Then Return -1

        Dim idObj As Object = GridView1.GetRowCellValue(rowHandle, "Id")
        Dim docReqId As Integer = Convert.ToInt32(idObj)
        Return docReqId
    End Function
End Class