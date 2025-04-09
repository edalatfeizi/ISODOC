Imports System.Data.SqlClient
Imports CrystalDecisions.[Shared].Json
Imports IsoDoc.Domain.Interfaces.Repositories
Imports IsoDoc.Domain.Interfaces.Services
Imports IsoDoc.Domain.Models
Imports IsoDoc.Domain.Services
Imports IsoDoc.Infrastructure.Repositories
Imports IsoDocApp
Imports IsoDocApp.Helpers
Imports Microsoft.Extensions.DependencyInjection
Public Class FrmSearchDocs
    Private _docsService As IDocsService
    Private _personelyService As IPersonelyService
    Private result As New List(Of SearchResult)
    Private userInfo As Person
    Private userName = ""
    Private isAdmin = False
    Private Async Sub FrmSearchDocs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim services As New ServiceCollection()
        'ConfigureServices(services, isoDocCnnStr)

        'Dim serviceProvider As IServiceProvider = services.BuildServiceProvider()
        'docsService = serviceProvider.GetRequiredService(Of DocsService)()
        'personelyService = serviceProvider.GetRequiredService(Of PersonelyService)()
        'If docsService Is Nothing Then
        '    MessageBox.Show("not")
        'End If

        txtSearch.Height = 32
        txtSearch.MinimumSize = New Size(320, 36)
        txtSearch.MaximumSize = New Size(320, 36)

        userName = SystemInformation.UserName.ToString()
        'userName = "3015";

        userInfo = Await _personelyService.GetUserInfoByCardNumber(userName)

        If userInfo.CodeEdare = "SI300" Or userInfo.UpperCode = "SI300" Then
            isAdmin = True

        End If

    End Sub
    'Private Sub ConfigureServices(services As IServiceCollection, connStr As String)
    '    ' Register your dependencies here
    '    services.AddScoped(Of IDbConnection)(Function(sp) New SqlConnection(connStr))
    '    services.AddSingleton(Of IPersonelyRepository, PersonelyRepository)()
    '    services.AddSingleton(Of IDocsRepository, DocsRepository)()
    '    services.AddSingleton(Of IPersonelyService, PersonelyService)()
    '    services.AddSingleton(Of IDocsService, DocsService)()
    'End Sub
    Public Sub New(docsService As IDocsService, personelyService As IPersonelyService)
        InitializeComponent()

        If docsService Is Nothing Then
            Throw New ArgumentNullException(NameOf(docsService))
        End If
        If personelyService Is Nothing Then
            Throw New ArgumentNullException(NameOf(personelyService))
        End If

        _docsService = docsService
        _personelyService = personelyService



    End Sub

    Private Async Sub Search()
        Try
            If userInfo IsNot Nothing Then
                result = Await _docsService.FilterDocs(isAdmin, txtSearch.Text.Trim(), userInfo.DepartCode)

                grdSearchResult.DataSource = result
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Search()
    End Sub

    Private Sub txtSearch_EditValueChanged(sender As Object, e As EventArgs) Handles txtSearch.EditValueChanged
        Search()
    End Sub

    Private Sub btnShowDoc_Click(sender As Object, e As EventArgs) Handles btnShowDoc.Click
        ShowDoc()
    End Sub

    Private Sub ShowDoc()
        Dim docTypeID = GridViewHelper.GetGridViewCellValue(gridView1, "DocTypeID").ToString()
        Dim mainId = Convert.ToInt32(GridViewHelper.GetGridViewCellValue(gridView1, "MainId").ToString())
        Dim docPath = GridViewHelper.GetGridViewCellValue(gridView1, "DocPath").ToString()

        Try
            If docTypeID = 1 And mainId <> -1 Then

                Dim frm As New frmPDF
                MdlMain.MainId = mainId
                frm.ShowDialog()
                Exit Sub

            Else

                Try
                    Process.Start(LTrim(RTrim(docPath)))
                Catch ex As Exception
                    Dim Bus_MessageHandler1 As New Bus_MessageHandler
                    Dim fileType As String
                    fileType = Bus_MessageHandler1.GetFileExtension(docPath)
                    If fileType = "" Then
                        ''''MsgBox("دسترسي به سند مورد نظر امكان پذير نمي باشد", MsgBoxStyle.Critical)
                        MessageBox.Show("دسترسي به سند مورد نظر امكان پذير نمي باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    Else
                        MsgBox("داريد " + fileType + " براي مشاهده اين سند نياز به نرم افزار", MsgBoxStyle.Critical)

                    End If
                End Try
            End If
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub gridView1_DoubleClick(sender As Object, e As EventArgs) Handles gridView1.DoubleClick
        ShowDoc()
    End Sub
End Class