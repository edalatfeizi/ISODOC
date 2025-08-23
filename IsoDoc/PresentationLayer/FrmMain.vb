Imports System.IO
Imports System.Linq
Imports System.Web.Configuration
Imports DevComponents.DotNetBar
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports IsoDoc.Domain.Interfaces.Services
Imports IsoDoc.Domain.Models

Public Class FrmMain
    Dim FrmIsoMaster1 As New FrmIsoMaster
    Dim Bus_ImportandDoc1 As New Bus_ImportandDoc
    Private DA1 As New SqlClient.SqlDataAdapter
    Private wstr As String
    Private _userInfo As Person
    Private topManagers As List(Of Person) = New List(Of Person)

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub btnShowKartable_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowKartable.ItemClick
        MdlMain.frmManageDocReqs.ShowDialog()

    End Sub

    Private Sub btnSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        'MdlMain.frmSearch.ShowDialog()
        'Dim b As New FrmSearchDocs
        'b.ShowDialog()
        MdlMain.frmSearchDocs.ShowDialog()

    End Sub
    Private Sub OpenFile(ByVal FilePath As String)
        Try
            System.Diagnostics.Process.Start(LTrim(RTrim(FilePath)))
        Catch ex As Exception
            Dim Bus_MessageHandler1 As New Bus_MessageHandler
            Dim fileType As String
            fileType = Bus_MessageHandler1.GetFileExtension(FilePath)
            If fileType = "" Then
                MessageBox.Show("دسترسي به سند مورد نظر امكان پذير نمي باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Else
                MsgBox("داريد " + fileType + " براي مشاهده اين سند نياز به نرم افزار", MsgBoxStyle.Critical)

            End If
        End Try
        btnImportantDocs.PerformClick()
    End Sub

    Private Async Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeletePdfs()
        Dim dt As New DataTable
        Dim Bus_UserMessage1 As New Bus_UserMessage
        ' SplashScreen1.Hide()
        Dim c As New FrmIsoMaster
        LogID = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        'LogID = "DM_PDC2\4892"
        dt = persist1.GetDataTable(CnnString, SqlStr)
        'If dt.Rows.Count = 0 Then
        '    Me.Close()
        '    Exit Sub
        'End If
        Dim userName = SystemInformation.UserName
        Dim userPersonCode As String = Await MdlMain.personelyService.GetUserPersonCodeByLoginName(userName)
        Dim personUserInfo As Person = Await personelyService.GetUserInfoByPersonCode(userPersonCode)

        If personUserInfo.CodeEdare = Constants.CEOOfficeBossDepCode Or personUserInfo.CodeEdare = Constants.CEOOfficeSecretaryDepCode Then
            BuildRunAsPopupMenu()

        Else

            btnShowKartable.ActAsDropDown = False
            btnShowKartable.ButtonStyle = BarButtonStyle.Default
        End If




        UserInfo.GetLoginInfo_ByLogName(SystemInformation.UserDomainName + "\" + SystemInformation.UserName)
        'UserInfo.GetLoginInfo_ByLogName("DM_PDC2\3864")

        LoginID = getLogID(LogID)

        AppID = getApp(LogID)



        SqlStr =
            "SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CardNumber = '" + SystemInformation.UserName + "'"
        Dim userInfoDt = persist1.GetDataTable(CnnString, SqlStr)


        If userInfoDt.DefaultView.Item(0).Item("PersonCode").ToString().IsDeveloper() Or userInfoDt.DefaultView.Item(0).Item("CodeEdare") = "SI000" Or userInfoDt.DefaultView.Item(0).Item("CodeEdare") = "SI300" Or userInfoDt.DefaultView.Item(0).Item("UpperCode") = "SI300" Then
            tabEnterData.Visible = True
            btnManageSignatures.Enabled = True
        End If

        ''UserInfo.GetLoginInfo_ByLogName("Dm_Pdc2\3710")
        ''LoginID = 1257
        ''AppID = 1257
        'Dim act1 As New Activities.AppActivities("729461sc75halgygb")
        'act1.CheckFormControl(27, AppID, Me)
        'If CheckUserAccess(AppID, 27, 629) = True Then
        '    كمكToolStripMenuItem.Visible = True
        'Else
        '    كمكToolStripMenuItem.Visible = False
        'End If
        'كمكToolStripMenuItem.Visible = True

        ''''دسترسي به پايگاه دانش
        If CheckUserAccess(AppID, 27, 752) = True Then
            rpKnowledgeBase.Visible = True
            btnShowKnowledgeBase.Visibility = False
        Else
            rpKnowledgeBase.Visible = True
            btnAddKnowledgeBaseData.Visibility = False
        End If
        ''''' دسترسی به روزشمار ممیزی
        If CheckUserAccess(AppID, 27, 802) = True Then
            rpAuditCalendar.Visible = True
        Else
            rpAuditCalendar.Visible = False
        End If
        ''JGrade1.SetUserControl(LoginID, 27, Me.Name, True)
    End Sub
    Friend Function getLogID(ByVal Logon As String) As Integer
        Try
            Dim Sqlstr As String
            Dim DataTable1 As New DataTable
            Dim dt As New DataTable

            Sqlstr =
            "SELECT     GeneralObjects.dbo.tbGen_Logins.LoginID, GeneralObjects.dbo.tbGen_Logins.LoginName, GeneralObjects.dbo.tbGen_Logins.LoginPersonID,  " &
            "                      Personely.dbo.tbHR_Person.FirstName+'-'+ Personely.dbo.tbHR_Person.LastName as Logname" &
            " FROM         GeneralObjects.dbo.tbGen_Logins LEFT OUTER JOIN " &
            "                      Personely.dbo.tbHR_Person ON GeneralObjects.dbo.tbGen_Logins.LoginPersonID = Personely.dbo.tbHR_Person.PersonCode " &
            " where  GeneralObjects.dbo.tbGen_Logins.LoginName='" & Logon & "' "
            dt = persist1.GetDataTable(CnnString, Sqlstr)
            If dt.Rows.Count = 0 Then
                Me.Close()
                Exit Function
            End If

            '   Sqlstr = "select LoginID from GeneralObjects.dbo.tbGen_Logins where LoginName='" & Logon & "' "
            DataTable1 = persist1.GetDataTable(CnnString, Sqlstr)
            Dim x As Integer
            x = DataTable1.DefaultView.Item(0).Item("LoginID")
            '   LogName = DataTable1.DefaultView.Item(0).Item("Logname")
            getLogID = x
        Catch ex As Exception
            getLogID = 0
        End Try
    End Function


    Private Sub DeletePdfs()

        Try
            Dim arrFiles() As String = Directory.GetFiles("C:\IkidSystems")
            Dim fileCount As Integer = Directory.GetFiles("C:\IkidSystems").Length
            Dim i As Integer
            If fileCount > 0 Then
                For i = 0 To fileCount - 1
                    Dim currentFile As String = Mid(arrFiles(i), 16)
                    If IsNumeric(currentFile) = True Then
                        My.Computer.FileSystem.DeleteFile("C:\IkidSystems\" + currentFile)
                    End If
                Next
            End If
        Catch ex As Exception
            'MsgBox("Error No 12", MsgBoxStyle.OkOnly, "")
        End Try

    End Sub
    Private Sub ShowDOC(ByVal DocTypeID As Integer, ByVal DocPath As String, ByVal _MainID As Integer)
        Try

            If DocTypeID <> 1 Then

                Try
                    Dim e1 As New EventArgs
                    System.Diagnostics.Process.Start(LTrim(RTrim(DocPath)))
                Catch ex As Exception
                    MsgBox("دسترسي به سند مورد نظر امكان پذير نمي باشد", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
                End Try

                Exit Sub

            ElseIf DocTypeID = 1 Then
                Dim frm As New frmPDF
                MainId = _MainID

                frm.pdfStatus = _pdftype.IsImportant_DOC

                frm.ShowDialog()

                Exit Sub

            End If
        Catch ex As Exception
            Dim Bus_MessageHandler1 As New Bus_MessageHandler
            Dim fileType As String
            fileType = Bus_MessageHandler1.GetFileExtension(FilePath.Trim)
            If fileType = "" Then
                MsgBox("دسترسي به سند مورد نظر امكان پذير نمي باشد", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
            Else
                MsgBox("دار يد " + fileType + " براي مشاهده اين سند نياز به نرم افزار", MsgBoxStyle.Critical)

            End If

        End Try
    End Sub

    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim b As New FrmUserMessage
        b.Close()
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DeletePdfs()
    End Sub

    Private Sub btnBaseInfo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBaseInfo.ItemClick
        Dim FrmIsoBasicSetting1 As New FrmIsoBasicSetting
        FrmIsoBasicSetting1.Show()
    End Sub

    Private Sub btnMainDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMainDocs.ItemClick
        Dim b As New FrmIsoRegistDocument
        b.Show()
    End Sub

    Private Sub btnOutsideDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOutsideDocs.ItemClick
        Dim b As New FrmInsOutsideDoc
        b.ShowDialog()
    End Sub

    Private Sub mnuImportantDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuImportantDocs.ItemClick
        CloseMenus(sender)
        Dim b As New FrmIsoImportandDoc
        b.FillGrid("ImportandDoc")
        b.Show()
    End Sub

    Private Sub mnuCertificates_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCertificates.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIsoImportandDoc
        b.FillGrid("Certificate")
        b.Show()
    End Sub

    Private Sub mnuStrategicConcepts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuStrategicConcepts.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIsoImportandDoc
        b.FillGrid("Strategic")
        b.Show()
    End Sub

    Private Sub btnArchive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArchive.ItemClick
        Dim b As New FrmIsoHistoryShow
        b.ShowDialog()
    End Sub

    Private Sub btnChangeDocsDep_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangeDocsDep.ItemClick
        Dim b As New FrmTransfer
        b.ShowDialog()
    End Sub

    Private Sub btnAddLinks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddLinks.ItemClick
        Dim frm As New frmSaveLinks
        frm.ShowDialog()
    End Sub

    Private Sub btnShowDepDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowDepDocs.ItemClick
        Dim FrmIsoDepartDoc1 As New FrmIsoDepartDoc
        FrmIsoDepartDoc1.ShowDialog()
    End Sub

    Private Sub mnuFormDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuFormDocs.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(9)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuChartDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuChartDocs.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(1)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuDutyDesc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDutyDesc.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(2)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub btnExecutiveMethods_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExecutiveMethods.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(3)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuInstructions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuInstructions.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(4)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuFMEARisks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuFMEARisks.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(25)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuRegulations_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuRegulations.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(5)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuProcessMap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuProcessMap.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(6)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuPostIdentity_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPostIdentity.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(11)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuProcessIdentity_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuProcessIdentity.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(8)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuControlPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuControlPlan.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(10)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuFlowChart_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuFlowChart.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(12)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuProcessDesc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuProcessDesc.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(13)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuStandardsUnification_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuStandardsUnification.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(14)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuSoftwareIdentity_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSoftwareIdentity.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(26)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuTable_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuTable.ItemClick
        CloseMenus(sender)

        FrmIsoMaster1.GetInfo(27)
        FrmIsoMaster1.ShowDialog()
    End Sub

    Private Sub mnuProductDevDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuProductDevDocs.ItemClick
        CloseMenus(sender)

        utility1.OpenFile("\\srv01si\PRODUCTION STANDARDS\SQA & SURVEY PLAN")
    End Sub

    Private Sub btnImportantDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportantDocs.ItemClick
        Dim FrmIsoDocShow1 As New FrmIsoDocShow

        FrmIsoDocShow1.TypeShow1 = TypeShow.Important
        '   FrmIsoDocShow1.ShowDialog()
        FrmIsoDocShow1.Text = "اسناد مهم"
        FrmIsoDocShow1.ShowDialog()

        'Dim e1 As New EventArgs
        'Timer1.Enabled = True
        'Me.Timer1_Tick(Me, e1)



        'OpenFile(dt.DefaultView.Item(0).Item("FilePath"))
    End Sub

    Private Sub btnStandardCerts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStandardCerts.ItemClick
        Dim FrmIsoDocShow1 As New FrmIsoDocShow

        FrmIsoDocShow1.TypeShow1 = TypeShow.Certificate
        '  FrmIsoDocShow1.ShowDialog()
        FrmIsoDocShow1.Text = "گواهي نامه ها"
        FrmIsoDocShow1.ShowDialog()
    End Sub

    Private Sub btnStrategicPlans_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStrategicPlans.ItemClick
        Dim FrmIsoDocShow1 As New FrmIsoDocShow
        Dim TypeShow1 As New TypeShow
        FrmIsoDocShow1.TypeShow1 = TypeShow.Strategic
        ' FrmIsoDocShow1.ShowDialog()
        FrmIsoDocShow1.Text = "طرح هاي استراتژيك"
        FrmIsoDocShow1.ShowDialog()
    End Sub

    Private Sub mnuTechnicalDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuTechnicalDocs.ItemClick
        CloseMenus(sender)

        Try
            ' Shell("explorer \\srv05si\STANDARDS", AppWinStyle.MaximizedFocus)

        Catch ex As Exception
            MsgBox("خطا", MsgBoxStyle.MsgBoxSetForeground)
        End Try
    End Sub

    Private Sub mnuBooks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuBooks.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "كتاب"
        b.Filldgd(1)
        b.Show()
    End Sub

    Private Sub mnuCatalogs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCatalogs.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "كاتالوگ"
        b.Filldgd(4)
        b.Show()
    End Sub

    Private Sub mnuStandard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuStandard.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "استاندارد"
        b.Filldgd(5)
        b.Show()
    End Sub

    Private Sub mnuSoftware_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSoftware.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "نرم افزار"
        b.Filldgd(6)
        b.Show()
    End Sub

    Private Sub mnuReports_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuReports.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "گزارشات و جزوات"
        b.Filldgd(7)
        b.Show()
    End Sub

    Private Sub mnuGallery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGallery.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "آلبوم عكس"
        b.Filldgd(8)
        b.Show()
    End Sub

    Private Sub mnuPanelMap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPanelMap.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "نقشه پانل"
        b.Filldgd(9)
        b.Show()
    End Sub

    Private Sub mnuCadData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCadData.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "Cad Data"
        b.Filldgd(10)
        b.Show()
    End Sub

    Private Sub mnuOperationSheets_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuOperationSheets.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "Operation Sheet"
        b.Filldgd(11)
        b.Show()
    End Sub

    Private Sub mnuDLMap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDLMap.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "نقشه D\L"
        b.Filldgd(12)
        b.Show()
    End Sub

    Private Sub mnuTemplateMap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuTemplateMap.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "نقشه قالب"
        b.Filldgd(13)
        b.Show()
    End Sub

    Private Sub mnuCadPrograms_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCadPrograms.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "برنامه هاي Cad"
        b.Filldgd(14)
        b.Show()
    End Sub

    Private Sub mnuCamPrograms_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCamPrograms.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "برنامه هاي Cam"
        b.Filldgd(15)
        b.Show()
    End Sub

    Private Sub mnuPGMap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPGMap.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "نقشه PG"
        b.Filldgd(16)
        b.Show()
    End Sub

    Private Sub mnuCutCard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCutCard.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "كارت برش"
        b.Filldgd(17)
        b.Show()
    End Sub

    Private Sub mnuPressCard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPressCard.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "كارت پرس"
        b.Filldgd(18)
        b.Show()
    End Sub

    Private Sub mnuSparParts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSparParts.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "ليست قطعات يدكي"
        b.Filldgd(19)
        b.Show()
    End Sub

    Private Sub mnuPackagingPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPackagingPlan.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "طرح بسته بندي"
        b.Filldgd(20)
        b.Show()
    End Sub

    Private Sub mnuPaletMap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPaletMap.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "نقشه پالت"
        b.Filldgd(21)
        b.Show()
    End Sub

    Private Sub mnuSurveyPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSurveyPlan.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "Survey Plan"
        b.Filldgd(23)
        b.Show()
    End Sub

    Private Sub mnuContracts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuContracts.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "قراردادها"
        b.Filldgd(24)
        b.Show()
    End Sub

    Private Sub mnuSQADocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSQADocs.ItemClick
        CloseMenus(sender)

        Dim b As New FrmIso_TechnicalDoc
        b.Text = "مدارك SQA"
        b.Filldgd(25)
        b.Show()
    End Sub

    Private Sub btnOutDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOutDocs.ItemClick
        Dim FrmIsoOtherDoc1 As New FrmIsoOtherDoc
        FrmIsoOtherDoc1.Flg = ""
        FrmIsoOtherDoc1.ShowDialog()
    End Sub

    Private Sub btnOtherDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOtherDocs.ItemClick
        Dim FrmIsoOtherDoc1 As New FrmIsoOtherDoc
        FrmIsoOtherDoc1.Flg = "OtherDoc"
        FrmIsoOtherDoc1.ShowDialog()
    End Sub

    Private Sub btnTrack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTrack.ItemClick
        utility1.OpenFile("\\srv05si\xxzdis1035xt$\Quality\PEYGIRI.xlsx")

    End Sub

    Private Sub btnSystemDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSystemDocs.ItemClick
        Dim b As New FrmMasterReport
        b.ShowDialog()
    End Sub

    Private Sub btnCumulativeDocsReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCumulativeDocsReport.ItemClick
        Try
            wstr = "select * from Vw_ReportChart"
            rptReports = New RptStatisticOfDoc  'rptIO_EnterObject 
            LastRepName = ReportName
            ReportName = "RptStatisticOfDoc"

            'rptReports.setparametervalue("CurDate", mdate1.GetIrani8DateStr_CurDate)
            'rptReports.setparametervalue("CurDate_Date", mdate1.GetIraniFullDateTime_CurDate)

            Call rptLoad()
        Catch ex As Exception
            MsgBox("بر روي سيستم شما نصب نمي باشد Crystal Report 2005", MsgBoxStyle.Critical, "CrystalReport")
        End Try
    End Sub

    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = persist1.GetDataAccess(wstr, 1, MdlMain.CnnString, ReportName, dsReports)
            Dim f1 As New FrmReportView
            f1.Show()
        Catch ex As Exception
            Dim r3 As DialogResult = MessageBox.Show("كليك نماييد Help بر روي سيستم شما نصب نمي باشد براي نصب نرم افزار روي دكمه  Crystal Report2005",
                                                      "Help Caption", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Question,
                                                      MessageBoxDefaultButton.Button1,
                                                      0, "\\Nt_dbms\mis\iso\Help\WareSupply for 2005\CRRedist2005_x86.msi",
                                                      HelpNavigator.Index)
        End Try
    End Sub

    Public Function getApp(ByVal Logon As String) As Integer
        Dim Sqlstr As String
        Dim DataTable1 As New DataTable
        Sqlstr = "select LoginID from GeneralObjects..tbGen_Logins where LoginName='" & Logon & "' "
        DataTable1 = persist1.GetDataTable(CnnString, Sqlstr)
        Dim x As Integer
        x = DataTable1.DefaultView.Item(0).Item("LoginID")
        getApp = x
    End Function

    Private Sub btnDocsCountChart_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDocsCountChart.ItemClick
        Try
            wstr = "select * from Vw_CntOfDocument"
            rptReports = New RptChartKoli  'rptIO_EnterObject 
            LastRepName = ReportName
            ReportName = "RptChartKoli"

            'rptReports.setparametervalue("CurDate", mdate1.GetIrani8DateStr_CurDate)
            'rptReports.setparametervalue("CurDate_Date", mdate1.GetIraniFullDateTime_CurDate)

            Call rptLoad()
        Catch ex As Exception
            MsgBox("بر روي سيستم شما نصب نمي باشد Crystal Report 2005", MsgBoxStyle.Critical, "CrystalReport")
        End Try
    End Sub

    Private Sub btnDepsDocsCountChart_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDepsDocsCountChart.ItemClick
        Try
            wstr = "select * from Vw_ReportChart ORDER BY SumDoc DESC"
            rptReports = New RptChartPerMdep  'rptIO_EnterObject 
            LastRepName = ReportName
            ReportName = "RptChartPerMdep"

            'rptReports.setparametervalue("CurDate", mdate1.GetIrani8DateStr_CurDate)
            'rptReports.setparametervalue("CurDate_Date", mdate1.GetIraniFullDateTime_CurDate)

            Call rptLoad()
        Catch ex As Exception
            MsgBox("بر روي سيستم شما نصب نمي باشد Crystal Report 2005", MsgBoxStyle.Critical, "CrystalReport")
        End Try
    End Sub

    Private Sub btnQAReports_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQAReports.ItemClick
        Dim b As New FrmTazminReports
        b.ShowDialog()
    End Sub

    Private Sub btnPrintableForms_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintableForms.ItemClick
        Try
            wstr = "SELECT     DocumentName, DocumentCode, IsPrint " &
                    "FROM         dbo.tbISODocuments " &
                    "WHERE     (DocumentCode LIKE '%FO%') AND (IsPrint = 0) and (DocumentCode <> 'AD-FO-04') order by DocumentCode "
            rptReports = New RptFormChapi
            LastRepName = ReportName
            ReportName = "RptFormChapi"


            Call rptLoad()
        Catch ex As Exception
            MsgBox("بر روي سيستم شما نصب نمي باشد Crystal Report 2005", MsgBoxStyle.Critical, "CrystalReport")
        End Try
    End Sub

    Private Sub btnWishList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnWishList.ItemClick
        Dim b As New FrmIsoFarvorites
        b.ShowDialog()
    End Sub

    Private Sub btnAuditCalendar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAuditCalendar.ItemClick
        Dim frm As New FrmISORoozshomar
        frm.ShowDialog()
    End Sub

    Private Sub btnAppHelp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAppHelp.ItemClick
        utility1.OpenFile("\\srv05si\MIS\iso\Help\User_Guide.doc")

    End Sub

    Private Sub btnAbout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbout.ItemClick
        Dim b As New FrmIsoAbout
        b.Show()
    End Sub

    Private Sub btnAddKnowledgeBaseData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddKnowledgeBaseData.ItemClick
        Dim frm As New frmKnowledgeBase
        frm.ShowDialog()
    End Sub

    Private Sub btnShowKnowledgeBase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowKnowledgeBase.ItemClick
        Dim frm1 As New frmKnowledgeBaseview
        frm1.ShowDialog()
    End Sub

    Private Sub CloseMenus(sender As Object)
        Dim RibbonBarManager As RibbonBarManager = TryCast(sender, RibbonBarManager)
        RibbonBarManager.CloseMenus()
    End Sub

    Private Sub btnManageNewDocConfirms_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnManageSignatures.ItemClick
        MdlMain.frmManageSignatures.ShowDialog()

    End Sub

    Private Async Sub BuildRunAsPopupMenu()
        ' Make sure the PopupMenu uses the same manager as the Ribbon
        PopupMenu2.Manager = RibbonControl.Manager

        ' (Optional) start fresh
        PopupMenu2.ClearLinks()

        Dim ceo As Person = Await MdlMain.personelyService.GetPersonByDepCode(Constants.CEODepCode)
        Dim deputy As Person = Await MdlMain.personelyService.GetPersonByDepCode(Constants.DeputyDepCode)
        Dim boardOfDirectors As List(Of Person) = Await MdlMain.personelyService.GetColleaguesByDepCode(Constants.BoardOfDirectorsDepCode)


        topManagers.Add(ceo)
        topManagers.Add(deputy)
        topManagers.AddRange(boardOfDirectors)

        If boardOfDirectors IsNot Nothing Then
            For Each manager As Person In topManagers
                ' Add items
                AddPopupItem($"{manager.FirstName} {manager.LastName} - {manager.Posttxt}", manager.PersonCode,
                         iconPng:=My.Resources.namemanager_16x16, fontSize:=9.0F)
            Next
        End If

    End Sub

    ' Helper: creates an item, styles it, wires click, and adds it to PopupMenu1
    Private Sub AddPopupItem(caption As String,
                         tag As String,
                         Optional iconPng As Image = Nothing,
                         Optional iconSvg As SvgImage = Nothing,
                         Optional fontName As String = "Vazirmatn",
                         Optional fontSize As Single = 9.0F,
                         Optional bold As Boolean = False,
                         Optional beginGroup As Boolean = False)

        Dim item As New BarButtonItem(RibbonControl.Manager, caption) With {
        .Tag = tag
    }

        ' Icon (use either PNG or SVG)
        If iconSvg IsNot Nothing Then
            item.ImageOptions.SvgImage = iconSvg
        ElseIf iconPng IsNot Nothing Then
            item.ImageOptions.Image = iconPng
        End If

        ' Per-item font (apply to all visual states)
        Dim style As FontStyle = If(bold, FontStyle.Bold, FontStyle.Regular)
        Dim f As New Font(fontName, fontSize, style)

        item.ItemAppearance.Normal.Font = f
        item.ItemAppearance.Normal.Options.UseFont = True
        item.ItemAppearance.Hovered.Font = f
        item.ItemAppearance.Hovered.Options.UseFont = True
        item.ItemAppearance.Pressed.Font = f
        item.ItemAppearance.Pressed.Options.UseFont = True

        ' Click handler
        AddHandler item.ItemClick, AddressOf PopupMenuItem_ItemClick

        ' Add to popup (with optional separator before it)
        Dim link = PopupMenu2.AddItem(item)
        link.BeginGroup = beginGroup
    End Sub

    ' One place to handle all popup item clicks
    Private Sub PopupMenuItem_ItemClick(sender As Object, e As ItemClickEventArgs)

        Dim manager As Person = topManagers.Where(Function(x) x.PersonCode = CStr(e.Item.Tag)).FirstOrDefault()
        If manager IsNot Nothing Then
            MdlMain.frmManageDocReqs.runAsUserPersonCode = manager.CardNumber
            MdlMain.frmManageDocReqs.ShowDialog()
        End If

    End Sub
End Class

