
Public Class frmKnowledgeBase
    Private Bus_UserMessage1 As New Bus_UserMessage

    Private Sub frmKnowledgeBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''œ” —”Ì »Â À»  œ— Å«Ìê«Â œ«‰‘
        If CheckUserAccess(AppID, 27, 752) = True Then
            UiGroupBox2.Enabled = True
            UiGroupBox4.Enabled = True
        Else
            UiGroupBox2.Enabled = False
            UiGroupBox2.Visible = False
            UiGroupBox4.Enabled = False
            UiGroupBox4.Visible = False
        End If

        FillCmb()
        Fillgrd()
        FillGrdtrainningKnowledg()

    End Sub

    Public Function CheckUserAccess(ByVal LoginID As Integer, ByVal AppID As Integer, ByVal ActivityCode As Integer) As Boolean
        SqlStr = _
 "SELECT     GeneralObjects.dbo.tbGen_AppActLogin.ActAppLogCode " & _
 "FROM         GeneralObjects.dbo.tbGen_Logins INNER JOIN " & _
 "   GeneralObjects.dbo.tbGen_AppActLogin ON GeneralObjects.dbo.tbGen_Logins.LoginID = GeneralObjects.dbo.tbGen_AppActLogin.LoginID INNER JOIN " & _
 "   GeneralObjects.dbo.tbGen_ActivityApplication ON  " & _
 "   GeneralObjects.dbo.tbGen_AppActLogin.AppActCode = GeneralObjects.dbo.tbGen_ActivityApplication.AppActCode INNER JOIN " & _
 "   GeneralObjects.dbo.tbGen_Applications ON  " & _
 "   GeneralObjects.dbo.tbGen_ActivityApplication.AppCode = GeneralObjects.dbo.tbGen_Applications.AppCode " & _
 "  WHERE     (GeneralObjects.dbo.tbGen_Logins.LoginID =" & LoginID & ") AND (GeneralObjects.dbo.tbGen_ActivityApplication.ActivityCode =" & ActivityCode & ") AND  " & _
 "   (GeneralObjects.dbo.tbGen_Applications.AppID =" & AppID & ")"
        Dim dt As New DataTable
        dt = persist1.GetDataTable(CnnString, SqlStr)
        If dt.DefaultView.Count <> 0 Then
            CheckUserAccess = True
        Else
            CheckUserAccess = False
        End If
    End Function

    Private Sub FillGrdtrainningKnowledg()
        Dim str1 As String
        Dim dt As New DataTable
        str1 = "SELECT     TrainningKnowledgbaseID, PersonCode, CareerTitle, CareerPlace, CareerTime, CareerDay, CareerDateEzam, CareerBegDate, CareerEndDate, StateMent, prName FROM         Vw_TrainningKnowledgeBase"
        dt = persist1.GetDataTable(CnnString, str1)
        Janus1.GetBindJGrid_DT(dt, grdTrainnigKnowledg, CnnString)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "PersonCode", "ﬂœÅ—”‰·", 75, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "prName", "‰«„", 150, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "CareerTitle", "‰«„ œÊ—Â", 150, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "CareerPlace", "„Õ· œÊ—Â", 75, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "CareerTime", "„œ  “„«‰", 35, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "CareerDay", "„œ  »Â —Ê“", 35, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "CareerDateEzam", " «—ÌŒ «⁄“«„", 75, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "CareerBegDate", " «—ÌŒ ‘—Ê⁄", 75, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "CareerEndDate", " «—ÌŒ Å«Ì«‰", 75, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "StateMent", " Ê÷ÌÕ« ", 125, , , True)
        Janus1.setMyJGrid(grdTrainnigKnowledg, "TrainningKnowledgbaseID", "", 0, , , False)
    End Sub

    Private Sub grdTrainnigKnowledg_CurrentLayoutChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTrainnigKnowledg.CurrentLayoutChanged
        Try
            cmbprs.SelectedValue = grdTrainnigKnowledg.GetValue("PersonCode")
            txtCareerTitle.Text = grdTrainnigKnowledg.GetValue("CareerTitle")
            txtCareerPlace.Text = grdTrainnigKnowledg.GetValue("CareerPlace")
            mskCareerTime.Text = grdTrainnigKnowledg.GetValue("CareerTime")
            mskCareerDay.Text = grdTrainnigKnowledg.GetValue("CareerDay")
            mskEzamDate.Text = grdTrainnigKnowledg.GetValue("CareerDateEzam")
            mskBegindate.Text = grdTrainnigKnowledg.GetValue("CareerBegDate")
            mskEnddate.Text = grdTrainnigKnowledg.GetValue("CareerEndDate")
            txtTozih.Text = grdTrainnigKnowledg.GetValue("StateMent")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Fillgrd()
        Dim str As String
        Dim dt As New DataTable
        str = "SELECT     KnowledgeBaseID, PersonCode, PaperTitle, PaperTypeID, EraeehPlace, SourceBook, PaperSaveDate, MDepCode, PaperAddress, PaperType, prName ,MDepartName,maghaleId,maghaleName,asarCode   FROM         vw_KnowledgeBase"
        dt = persist1.GetDataTable(CnnString, str)
        Janus1.GetBindJGrid_DT(dt, grdKnowledgeBase, CnnString)
        Janus1.setMyJGrid(grdKnowledgeBase, "PersonCode", "ﬂœÅ—”‰·", 75, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "asarCode", "òœ «À—", 75, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "prName", "‰«„", 150, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "MDepartName", "‰«„ Ê«Õœ", 75, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "PaperTitle", "⁄‰Ê«‰ «À—", 200, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "PaperType", "‰Ê⁄ «À—", 50, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "maghaleName", "‰Ê⁄ „ﬁ«·Â", 75, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "EraeehPlace", "„Õ· «—«∆Â", 150, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "SourceBook", "„—Ã⁄", 150, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "PaperSaveDate", " «—ÌŒ À»  «À—", 75, , , True)
        Janus1.setMyJGrid(grdKnowledgeBase, "maghaleId", "", 0, , , False)
        Janus1.setMyJGrid(grdKnowledgeBase, "MDepCode", "", 0, , , False)
        Janus1.setMyJGrid(grdKnowledgeBase, "PaperAddress", "", 0, , , False)
        Janus1.setMyJGrid(grdKnowledgeBase, "PaperTypeID", "", 0, , , False)
        Janus1.setMyJGrid(grdKnowledgeBase, "KnowledgeBaseID", "", 0, , , False)
    End Sub

    Private Sub grdKnowledgeBase_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdKnowledgeBase.CurrentCellChanged
        Try
            cmbperson.SelectedValue = grdKnowledgeBase.GetValue("PersonCode")
            cmbDepart.SelectedValue = grdKnowledgeBase.GetValue("MDepCode")
            cmbAsarType.SelectedValue = grdKnowledgeBase.GetValue("PaperTypeID")
            txtAsarTitle.Text = grdKnowledgeBase.GetValue("PaperTitle")
            txtEraeh.Text = grdKnowledgeBase.GetValue("EraeehPlace")
            txtMarjae.Text = grdKnowledgeBase.GetValue("SourceBook")
            txtDate.Text = grdKnowledgeBase.GetValue("PaperSaveDate")
            txtAddress.Text = grdKnowledgeBase.GetValue("PaperAddress")
            cmbMaghale.Text = grdKnowledgeBase.GetValue("maghaleName")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FillCmb()
        Dim dtPerson, dtPrs, dtAsarType, dtDepart, dt_Maghale As New DataTable
        Dim sqlstr As String
        dtPerson = persist1.GetDataTable(CnnString, "Select PersonCode , LastName + '  ' + FirstName as prName from Personely.dbo.tbhr_person  order by LastName")
        persist1.FillCmb(dtPerson, cmbperson, "PersonCode", "prName")

        dtAsarType = persist1.GetDataTable(CnnString, "SELECT     PaperTypeID, PaperType  FROM         tbPaperType")
        persist1.FillCmb(dtAsarType, cmbAsarType, "PaperTypeID", "PaperType")


        sqlstr = _
            "SELECT     DepartCode, MDepartName " & _
            "FROM        personely.dbo.VwHR_MDepart " & _
            "WHERE     (DepartCode <> N'0' AND DepartCode <> N'XX000' AND DepartCode <> N'YY000' AND DepartCode <> N'ZY000' AND DepartCode <> N'ZZ000' AND  " & _
            "    DepartCode <> N'VV000') " & _
            "ORDER BY MDepartName"
        dtDepart = persist1.GetDataTable(CnnString, sqlstr)
        persist1.FillCmb(dtDepart, cmbDepart, "DepartCode", "MDepartName")

        dtPrs = persist1.GetDataTable(CnnString, "Select PersonCode , LastName + '  ' + FirstName as prName from Personely.dbo.tbhr_person  order by LastName")
        persist1.FillCmb(dtPrs, cmbprs, "PersonCode", "prName")

        sqlstr = "SELECT      maghaleId, maghaleName FROM         tb_Maghale"
        dt_Maghale = persist1.GetDataTable(CnnString, sqlstr)
        persist1.FillCmb(dt_Maghale, cmbMaghale, "maghaleId", "maghaleName")

    End Sub
    Private Sub RefreshNewDoc(ByVal MDepCode As Integer)
        If MsgBox("¬Ì« „«Ì· »Â  Ê“Ì⁄ «ÿ·«⁄«  »Ì‰ ﬂ«—»—«‰ Â” Ìœø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Bus_UserMessage1.Insert(MDepCode)
            MsgBox("«ÿ·«⁄«  ÊÌ—«Ì‘ ‘œÂ œ— ‘»ﬂÂ  Ê“Ì⁄ ‘œ", MsgBoxStyle.Information)
            Exit Sub
        Else
            Exit Sub
        End If
        Exit Sub
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Len(txtDate.Text.Trim) <> 10 Then
            MsgBox(" «—ÌŒ —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MsgBox("„ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            persist1.Sp_AddParam("@PersonCode_1", SqlDbType.Int, cmbperson.SelectedValue, ParameterDirection.Input)
            persist1.Sp_AddParam("@PaperTitle_2 ", SqlDbType.NVarChar, txtAsarTitle.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@PaperTypeID_3", SqlDbType.Int, cmbAsarType.SelectedValue, ParameterDirection.Input)
            persist1.Sp_AddParam("@EraeehPlace_4", SqlDbType.NVarChar, txtEraeh.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@SourceBook_5", SqlDbType.NVarChar, txtMarjae.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@PaperSaveDate_6", SqlDbType.Char, txtDate.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@MDepCode_7", SqlDbType.NVarChar, cmbDepart.SelectedValue, ParameterDirection.Input)
            persist1.Sp_AddParam("@PaperAddress_8", SqlDbType.NVarChar, txtAddress.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@maghaleId_9", SqlDbType.Int, cmbMaghale.SelectedValue, ParameterDirection.Input)
            persist1.Sp_Exe("insert_tbKnowledgeBase", CnnString, True)
            MsgBox("—ﬂÊ—œ À»  ‘œ", MsgBoxStyle.Information, "")
            Fillgrd()
        End If
    End Sub
    Private Sub btnAddress_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddress.Click
        OpenFileDialog1.Filter = "All Files|*.*"
        'OpenFileDialog1.InitialDirectory = "\\Nt_dbms\mis\iso\Quality"
        OpenFileDialog1.InitialDirectory = "\\nt_dbms\Knowledge Managment\Training"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtAddress.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Len(txtDate.Text.Trim) <> 10 Then
            MsgBox(" «—ÌŒ —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If grdKnowledgeBase.RowCount <> 0 And MsgBox("„ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            persist1.Sp_AddParam("@KnowledgeBaseID_1", SqlDbType.Int, grdKnowledgeBase.GetValue("KnowledgeBaseID"), ParameterDirection.Input)
            persist1.Sp_AddParam("@PersonCode_2", SqlDbType.Int, cmbperson.SelectedValue, ParameterDirection.Input)
            persist1.Sp_AddParam("@PaperTitle_3 ", SqlDbType.NVarChar, txtAsarTitle.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@PaperTypeID_4", SqlDbType.Int, cmbAsarType.SelectedValue, ParameterDirection.Input)
            persist1.Sp_AddParam("@EraeehPlace_5", SqlDbType.NVarChar, txtEraeh.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@SourceBook_6", SqlDbType.NVarChar, txtMarjae.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@PaperSaveDate_7", SqlDbType.Char, txtDate.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@MDepCode_8", SqlDbType.NVarChar, cmbDepart.SelectedValue, ParameterDirection.Input)
            persist1.Sp_AddParam("@PaperAddress_9", SqlDbType.NVarChar, txtAddress.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@maghaleId_10", SqlDbType.Int, cmbMaghale.SelectedValue, ParameterDirection.Input)
            persist1.Sp_Exe("update_tbKnowledgeBase", CnnString, True)
            MsgBox("—ﬂÊ—œ ÊÌ—«Ì‘ ‘œ", MsgBoxStyle.Information, "")
            Fillgrd()
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If grdKnowledgeBase.RowCount <> 0 And MsgBox("„ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            persist1.Sp_AddParam("@KnowledgeBaseID_1 ", SqlDbType.Int, grdKnowledgeBase.GetValue("KnowledgeBaseID"), ParameterDirection.Input)
            persist1.Sp_Exe("delete_tbKnowledgeBase", CnnString, True)
            MsgBox("—ﬂÊ—œ Õ–› ‘œ", MsgBoxStyle.Information, "")
            Fillgrd()
        End If
    End Sub

    Private Sub grdKnowledgeBase_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdKnowledgeBase.DoubleClick
        Try
            Process.Start(grdKnowledgeBase.GetValue("PaperAddress"))
        Catch ex As Exception
            MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnDarj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDarj.Click
        If Len(mskEzamDate.Text.Trim) <> 10 Or Len(mskBegindate.Text.Trim) <> 10 Or Len(mskEnddate.Text.Trim) <> 10 Then
            MsgBox(" «—ÌŒ —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MsgBox("„ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            persist1.Sp_AddParam("@PersonCode_1", SqlDbType.Int, cmbprs.SelectedValue, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerTitle_2 ", SqlDbType.NVarChar, txtCareerTitle.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerPlace_3", SqlDbType.NVarChar, txtCareerPlace.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerTime_4", SqlDbType.Int, mskCareerTime.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerDay_5", SqlDbType.Int, mskCareerDay.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerDateEzam_6", SqlDbType.Char, mskEzamDate.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerBegDate_7", SqlDbType.Char, mskBegindate.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerEndDate_8", SqlDbType.Char, mskEnddate.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@StateMent_9", SqlDbType.NVarChar, txtTozih.Text.Trim, ParameterDirection.Input)
            persist1.Sp_Exe("insert_tbTrainningKnowledgeBase", CnnString, True)
            MsgBox("—ﬂÊ—œ À»  ‘œ", MsgBoxStyle.Information, "")
            FillGrdtrainningKnowledg()
        End If
    End Sub

    Private Sub btnViraiesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViraiesh.Click
        If Len(mskEzamDate.Text.Trim) <> 10 Or Len(mskBegindate.Text.Trim) <> 10 Or Len(mskEnddate.Text.Trim) <> 10 Then
            MsgBox(" «—ÌŒ —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MsgBox("„ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            persist1.Sp_AddParam("@TrainningKnowledgbaseID_1", SqlDbType.Int, grdTrainnigKnowledg.GetValue("TrainningKnowledgbaseID"), ParameterDirection.Input)
            persist1.Sp_AddParam("@PersonCode_2", SqlDbType.Int, cmbprs.SelectedValue, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerTitle_3", SqlDbType.NVarChar, txtCareerTitle.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerPlace_4", SqlDbType.NVarChar, txtCareerPlace.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerTime_5", SqlDbType.Int, mskCareerTime.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerDay_6", SqlDbType.Int, mskCareerDay.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerDateEzam_7", SqlDbType.Char, mskEzamDate.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerBegDate_8", SqlDbType.Char, mskBegindate.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@CareerEndDate_9", SqlDbType.Char, mskEnddate.Text.Trim, ParameterDirection.Input)
            persist1.Sp_AddParam("@StateMent_10", SqlDbType.NVarChar, txtTozih.Text.Trim, ParameterDirection.Input)
            persist1.Sp_Exe("update_tbTrainningKnowledgeBase", CnnString, True)
            MsgBox("—ﬂÊ—œ ÊÌ—«Ì‘ ‘œ", MsgBoxStyle.Information, "")
            FillGrdtrainningKnowledg()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("„ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            persist1.Sp_AddParam("@TrainningKnowledgbaseID_1", SqlDbType.Int, grdTrainnigKnowledg.GetValue("TrainningKnowledgbaseID"), ParameterDirection.Input)
            persist1.Sp_Exe("delete_tbTrainningKnowledgeBase", CnnString, True)
            MsgBox("—ﬂÊ—œ Õ–› ‘œ", MsgBoxStyle.Information, "")
            FillGrdtrainningKnowledg()
        End If
    End Sub

    Private Sub chkViraiesh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViraiesh.CheckedChanged
        If chkViraiesh.Checked = True Then
            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub chkDel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDel.CheckedChanged
        If chkDel.Checked = True Then
            btnDel.Enabled = True
        Else
            btnDel.Enabled = False
        End If
    End Sub

    Private Sub UiCheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiCheckBox2.CheckedChanged
        If UiCheckBox2.Checked = True Then
            btnViraiesh.Enabled = True
        Else
            btnViraiesh.Enabled = False
        End If
    End Sub

    Private Sub chkDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelete.CheckedChanged
        If chkDelete.Checked = True Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New FrmNewmaghale
        frm.ShowDialog()
        FillCmb()
    End Sub
End Class