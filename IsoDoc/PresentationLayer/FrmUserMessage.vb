
Imports System.Windows.Forms.MenuStrip
Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Clipboard
Imports System.Windows.Forms.Form
Imports System.Collections
Imports IKIDCSHelper.Models
Imports System.Linq
Imports System.Threading.Tasks
Imports IsoDocApp
Imports Microsoft.Extensions.DependencyInjection
Imports IsoDoc.Domain.Interfaces.Repositories
Imports IsoDoc.Domain.Interfaces.Services
Imports IsoDoc.Domain.Services
Imports IsoDoc.Infrastructure.Repositories

Public Class FrmUserMessage
    Private Bus_UserMessage1 As New Bus_UserMessage
    Private Cls_JanusGrid1 As New Cls_JanusGrid
    Dim LogID As String
    Dim counter As Integer
    Dim dt As New DataTable
    Dim isoDocCnnStr As String = ""
    Private Sub FillGrid()
        LogID = SystemInformation.UserName

        dt = Bus_UserMessage1.GetInformation(LogID.Trim)
        If dt.DefaultView.Count <> 0 Then
            lblCount.Text = dt.DefaultView.Count
            Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentCode", "ﬂœ ”‰œ", 80)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentName", "‰«„ ”‰œ", 600)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocPath", "DocPath", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "ID", "ID", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocTypeID", "DocTypeID", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "MainId", "MainId", 0, , , False)

        Else
            Dim FrmIsoMain1 As New FrmIsoMain

            FrmIsoMain1.ShowDialog()
            Me.Close()

        End If

    End Sub



    Public Shared ReadOnly Property DebugMode As Boolean
        Get
#If DEBUG Then
            Return True
#Else
        Return False
#End If
        End Get
    End Property

    Private Async Function SetupConnectionStrings() As Task
        Try
            Dim IsoDocCsList As List(Of AppConnStrDto) = Await CSHelper.CSRepo.GetConnectionStringsAsync(DebugMode, "IsoDoc")
            Dim ArchiveCS = IsoDocCsList.Where(Function(p) p.Key = "SQLSRV-Archive_New").FirstOrDefault()
            Dim IsodocCS = IsoDocCsList.Where(Function(p) p.Key = "SQLSRV-Isodoc_New").FirstOrDefault()
            Dim ProductionCS = IsoDocCsList.Where(Function(p) p.Key = "SQLSRV-Production").FirstOrDefault()
            Dim TrainingCS = IsoDocCsList.Where(Function(p) p.Key = "SQLSRV-Training").FirstOrDefault()
            Dim GeneralCs = IsoDocCsList.Where(Function(p) p.Key = "SQLSRV-GeneralObjects").FirstOrDefault()
            isoDocCnnStr = IsodocCS.value

            MdlMain.CnnStringArchiveNew = ArchiveCS.Value
            MdlMain.CnnString = IsodocCS.Value
            MdlMain.CnnStringProduction = ProductionCS.Value
            MdlMain.CnnStringTraining = TrainingCS.Value
            MdlMain.CnnStringGeneralObject = GeneralCs.Value
        Catch ex As Exception
            Dim InnerException As String = " "
            If ex.InnerException IsNot Nothing Then
                InnerException = ex.InnerException.Message
            End If

            Dim constr As String = "Data Source=sqlsrv;Initial Catalog=IkidGeneral;Connect Timeout=0;User Id=exlog;Password=afarinesh;"
            Dim query As String = "insert into Tb_Exception (ExceptionTitle,AppId,Message,InnerException,ExceptionTime,UserName) values ('IsoDoc Exception','22','" & ex.Message.Replace("'", "") & "','" & InnerException.Replace("'", "") & "','" & DateTime.Now.ToString() & "','" & Environment.UserName & "')"
            persist1.ExecuteNoneQuery(query, constr)


        End Try
    End Function



    Private Async Sub FrmUserMessage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Await SetupConnectionStrings()

        'Configure DI for IsoDocApp, IsoDoc.Domain, IsoDoc.Infrastructure projects
        Dim services As New ServiceCollection()
        ConfigureServices(services, isoDocCnnStr)
        Dim serviceProvider As IServiceProvider = services.BuildServiceProvider()
        MdlMain.frmManageDocReqs = serviceProvider.GetRequiredService(Of FrmManageDocReqs)()
        'End configure DI

        My.Settings.Archive_NewConnectionString = MdlMain.CnnStringArchiveNew
        My.Settings.Isodoc_NewConnectionString = MdlMain.CnnString
        Dim adapter As New Archive_NewDataSetTableAdapters.VwAch_BookTableAdapter
        adapter.Connection.ConnectionString = MdlMain.CnnStringArchiveNew
        Dim adapter1 As New Archive_NewDataSet1TableAdapters.VwAch_DieMapsTableAdapter
        adapter1.Connection.ConnectionString = MdlMain.CnnStringArchiveNew
        Dim adapter2 As New DataSet1TableAdapters.tb_TelTableAdapter
        adapter2.Connection.ConnectionString = MdlMain.CnnString


        RepairPDF()

        FillGrid()

    End Sub
    Private Sub ConfigureServices(services As IServiceCollection, connStr As String)
        ' Register your dependencies here
        services.AddScoped(Of IDbConnection)(Function(sp) New SqlConnection(connStr))
        services.AddSingleton(Of IManageDocReqsRepository, ManageDocReqRepository)()
        services.AddSingleton(Of IManageDocReqsService, ManageDocReqsService)()
        services.AddSingleton(Of FrmManageDocReqs)()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PicShow.Visible = True
        counter = counter + 1

        If counter = 4 Then
            If dg.GetValue("DocTypeID") <> 1 Then
                Try
                    FilePath = dg.GetValue("DocPath")
                    System.Diagnostics.Process.Start(LTrim(RTrim(FilePath)))
                    Bus_UserMessage1.Update(dg.GetValue("ID"))
                    FillGrid()
                Catch ex As Exception
                    Dim Bus_MessageHandler1 As New Bus_MessageHandler
                    Dim fileType As String
                    fileType = Bus_MessageHandler1.GetFileExtension(FilePath.Trim)
                    If fileType = "" Then
                        MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
                    Else
                        MsgBox("œ«— Ìœ " + fileType + " »—«Ì „‘«ÂœÂ «Ì‰ ”‰œ ‰Ì«“ »Â ‰—„ «›“«—", MsgBoxStyle.Critical)

                    End If

                End Try
                PicShow.Visible = False
                Timer1.Enabled = False
                counter = 0
                Exit Sub

            ElseIf dg.GetValue("DocTypeID") = 1 Then

                Dim frm As New frmPDF
                MainId = dg.GetValue("MainID")
                frm.ShowDialog()
                Bus_UserMessage1.Update(dg.GetValue("ID"))
                FillGrid()
                PicShow.Visible = False
                Timer1.Enabled = False
                counter = 0

                Exit Sub


            End If


        End If
    End Sub

    Private Sub RepairPDF()
        '''' œ— œ—«ÌÊ  CÃÂ  œ—”  ‰„Êœ‰ ‰«„ ›«Ì·Â«ÌÌ ﬂÂ  Ê”ÿ «Ì“Êœ«ﬂ Œ—«» ‘œÂ
        Try
            Dim arrFiles() As String = Directory.GetFiles("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings")
            Dim fileCount As Integer = Directory.GetFiles("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings").Length
            Dim i As Integer
            If fileCount > 0 Then
                For i = 0 To fileCount - 1
                    Dim currentFile As String = Mid(arrFiles(i), 54)
                    Dim fileDetails As FileInfo = New FileInfo(arrFiles(i))
                    Select Case currentFile
                        Case ".eBook"
                            My.Computer.FileSystem.RenameFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\.eBook", "eBook.joboptions")
                        Case ".Press"
                            My.Computer.FileSystem.RenameFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\.Press", "Press.joboptions")
                        Case ".Print"
                            My.Computer.FileSystem.RenameFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\.Print", "Print.joboptions")
                        Case ".Screen"
                            My.Computer.FileSystem.RenameFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\.Screen", "Screen.joboptions")
                    End Select
                Next
            End If
        Catch
        End Try
        '''' œ— œ—«ÌÊ  DÃÂ  œ—”  ‰„Êœ‰ ‰«„ ›«Ì·Â«ÌÌ ﬂÂ  Ê”ÿ «Ì“Êœ«ﬂ Œ—«» ‘œÂ
        Try
            Dim arrFiles() As String = Directory.GetFiles("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings")
            Dim fileCount As Integer = Directory.GetFiles("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings").Length
            Dim i As Integer
            If fileCount > 0 Then
                For i = 0 To fileCount - 1
                    Dim currentFile As String = Mid(arrFiles(i), 54)
                    Dim fileDetails As FileInfo = New FileInfo(arrFiles(i))
                    Select Case currentFile
                        Case ".eBook"
                            My.Computer.FileSystem.RenameFile("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\.eBook", "eBook.joboptions")
                        Case ".Press"
                            My.Computer.FileSystem.RenameFile("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\.Press", "Press.joboptions")
                        Case ".Print"
                            My.Computer.FileSystem.RenameFile("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\.Print", "Print.joboptions")
                        Case ".Screen"
                            My.Computer.FileSystem.RenameFile("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\.Screen", "Screen.joboptions")
                    End Select
                Next
            End If
        Catch
        End Try
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Bus_UserMessage1.UpdateAll(dt.DefaultView.Item(0).Item("UserID"))
        Me.Hide()
        Dim b As New FrmIsoMain
        b.ShowDialog()
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Hide()
        Dim b1 As New FrmIsoMain
        b1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim b As New FrmIsoMain
        b.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)
    End Sub
End Class