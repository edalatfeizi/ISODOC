Public Enum x
    ali = 1
    reza = 2
    mamad = 3

End Enum
Module MdlMain
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
    Friend CnnString As String = "Data Source=sqlsrv;Initial Catalog=Isodoc_New;Integrated Security=True;Connect Timeout=200"
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
End Module
