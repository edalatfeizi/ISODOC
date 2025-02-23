Imports IsoDocApp

Module MdlMain
    Public frmManageDocReqs As FrmManageDocReqs

    Public dt As New DataTable
    Public DocumentCode As String

    Friend app As New APPFrameWork.DataGridViewHelper.MakeDataGridView2
    Friend ds As New System.Windows.Forms.BindingSource
    Friend persist1 As New Persistent.DataAccess.DataAccess
    Friend pic1 As New IKIDUtility.PictureInfo.PictureInfo
    Friend CurrentDataBaseProvider As APPFrameWork.DataBaseProvider.Provider
    Friend CurrentDbWorking1 As APPFrameWork.DataBaseWorking
    Friend AppUserAccess As APPFrameWork.Security.UserAccess
    Friend MyNotifyBox1 As New APPFrameWork.NotificationHelper.NotifyBox
    Public act1 As New Activities.AppActivities("729461sc75halgygb")
    Public utility1 As New IKIDUtility.IKIDUtility.Formating
    Public Mdate1 As New IraniDate.IraniDate.IraniDate
    Public dsReports As New DataSet
    Public rptReports As Object
    Public ReportName As String
    Public LastRepName As String
    Friend FilePath As String
    Friend FileSettingPath As String
    Public LogType As String
    Public LogID As String
    Public LoginID As String
    Public AppID As Integer
    Public Pasw As String
    Friend Flg As String
    Public wstr As String
    Friend SqlStr As String
    Friend Janus1 As New JFrameWork.JanusGrid
    'Friend CnnString As String = " Persist Security Info=False;User ID=sa;PWD=afarinesh;Connect Timeout=100;Initial Catalog=Isodoc_New;Data Source=SQLSRV  "
    Friend CnnString As String = ""
    Friend CnnStringArchiveNew As String = ""
    Friend CnnStringProduction As String = ""
    Friend CnnStringTraining As String = ""
    Friend CnnStringGeneralObject As String = ""
    ' Friend Cnnstring As String = "Provider=SQLOLEDB.1;Password=afarinesh;Persist Security Info=True;User ID=sa;Initial Catalog=Isodoc_New;Data Source=SQLSRV"
    Friend IraniDate1 As New APPFrameWork.IraniDateAdaptee

    ''For Show Pdf...........................................................
    Public pdfDocument1 As O2S.Components.PDFView4NET.PDFDocument
    Friend settings As New Printing.PrinterSettings()
    Friend pdfPrintSettings As New O2S.Components.PDFView4NET.Printing.PDFPrintSettings(settings)
    Friend flgPrinte As Boolean
    Friend PrintCount, i As Integer
    Friend MainId As Integer
    Friend certificateId As Integer
    Friend flgIsLink As Boolean = False

    Public UserInfo As New IKIDSecurity.Information.LoginInfo
    Public Function CheckUserAccess(ByVal LoginID As Integer, ByVal AppID As Integer, ByVal ActivityCode As Integer) As Boolean
        SqlStr =
 "SELECT     GeneralObjects.dbo.tbGen_AppActLogin.ActAppLogCode " &
 "FROM         GeneralObjects.dbo.tbGen_Logins INNER JOIN " &
 "                      GeneralObjects.dbo.tbGen_AppActLogin ON GeneralObjects.dbo.tbGen_Logins.LoginID = GeneralObjects.dbo.tbGen_AppActLogin.LoginID INNER JOIN " &
 "                      GeneralObjects.dbo.tbGen_ActivityApplication ON  " &
 "                      GeneralObjects.dbo.tbGen_AppActLogin.AppActCode = GeneralObjects.dbo.tbGen_ActivityApplication.AppActCode INNER JOIN " &
 "                      GeneralObjects.dbo.tbGen_Applications ON  " &
 "                      GeneralObjects.dbo.tbGen_ActivityApplication.AppCode = GeneralObjects.dbo.tbGen_Applications.AppCode " &
 "WHERE     (GeneralObjects.dbo.tbGen_Logins.LoginID =" & LoginID & ") AND (GeneralObjects.dbo.tbGen_ActivityApplication.ActivityCode =" & ActivityCode & ") AND  " &
 "                      (GeneralObjects.dbo.tbGen_Applications.AppID =" & AppID & ")"
        Dim dt As New DataTable
        dt = persist1.GetDataTable(CnnString, SqlStr)
        If dt.DefaultView.Count <> 0 Then
            CheckUserAccess = True
        Else
            CheckUserAccess = False

        End If

    End Function
End Module
