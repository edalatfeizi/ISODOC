Module MdlMain
    Friend app As New APPFrameWork.DataGridViewHelper.MakeDataGridView2
    Friend ds As New System.Windows.Forms.BindingSource
    Friend persist1 As New Persistent.DataAccess.DataAccess
    Friend CurrentDataBaseProvider As APPFrameWork.DataBaseProvider.Provider
    Friend CurrentDbWorking1 As APPFrameWork.DataBaseWorking
    Friend AppUserAccess As APPFrameWork.Security.UserAccess
    Friend MyNotifyBox1 As New APPFrameWork.NotificationHelper.NotifyBox
    Public act1 As New Activities.AppActivities("729461sc75halgygb")
    Public utility1 As New IKIDUtility.IKIDUtility.Formating
    Public dsReports As New DataSet
    Public rptReports As Object
    Public ReportName As String
    Public LastRepName As String
    Friend FilePath As String
    Public wstr As String
    Friend SqlStr As String
    Friend CnnString As String = "Persist Security Info=False;User ID=sa;PWD=afarinesh;Initial Catalog=Isodoc_New;Data Source=SQLSRV"
    Friend IraniDate1 As New APPFrameWork.IraniDateAdaptee
End Module
