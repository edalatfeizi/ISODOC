Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System
Imports System.Windows.Forms.Clipboard
Imports System.Windows.Forms.Form
Imports System.Collections

'Enum pdftype
'    main = 0
'    link = 1
'End Enum

Public Class frmShowPDF
    Dim conn As New SqlConnection
    Dim strfn As String
    Dim Zoom As Integer = 140
    Dim dt_Link As New DataTable
    Dim ZoomCount As Integer = 1
    Dim _MainId As Integer

    Friend Property MainId() As Integer
        Get
            Return _MainId
        End Get
        Set(ByVal value As Integer)
            _MainId = value
        End Set
    End Property

    Friend pdfStatus As _pdftype

    Private Sub frmShowPDF_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' ''KillProcess()
    End Sub


    'Private Sub frmShowPDF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
    '    Timer1.Enabled = True
    '    Timer2.Enabled = True
    'End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        Timer2.Enabled = True
        'AxPdf1.setShowScrollbars(True)

        DeletePdfs()
        ShowPdf(MainId, pdfStatus)
        FillgrdLinks(MainId)
    End Sub

    Private Sub FillgrdLinks(ByVal MainId1 As Integer)
        SqlStr = "SELECT LinksID, MainID, LinkAddress ,LinkTitle FROM  tbDocumentLinks where MainID = " & MainId1 & " "
        dt_Link = persist1.GetDataTable(CnnString, SqlStr)
        If dt_Link.Rows.Count <> 0 Then
            grdLinks.GroupByBoxInfoText = "مسيرهاي زير مربوط به لينكهاي اين سند مي باشد"
            Janus1.GetBindJGrid_DT(dt_Link, grdLinks, CnnString)
            Janus1.setMyJGrid(grdLinks, "LinksID", "MainID", 0, , , False)
            Janus1.setMyJGrid(grdLinks, "MainID", "MainID", 0, , , False)
            Janus1.setMyJGrid(grdLinks, "LinkTitle", "عنوان لينك", 150, , , True)
            Janus1.setMyJGrid(grdLinks, "LinkAddress", "مسير لينك", 0, , , False)
        End If
    End Sub

    Private Sub grdLinks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLinks.DoubleClick
        Dim a As Integer

        If grdLinks.RowCount <> 0 Then
            a = Len(grdLinks.GetValue("LinkAddress"))
            If Mid(grdLinks.GetValue("LinkAddress"), a - 2, 3) = "pdf" Then
                Dim frm As New frmShowPDF
                frm.MainId = grdLinks.GetValue("LinksID")
                frm.pdfStatus = _pdftype.link
                frm.ShowDialog()
            Else
                ShowLink()
            End If
        End If
    End Sub

    'Private Sub KillProcess()
    '    Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Acrobat")
    '    For Each p As Process In pProcess
    '        p.Kill()
    '    Next
    'End Sub

    Private Sub ShowLink()
        Process.Start(grdLinks.GetValue("LinkAddress"))
    End Sub

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
        Catch

        End Try
    End Sub

    Private Sub ShowPdf(ByVal ID As Integer, ByVal pdfstatus As Integer)

        Timer1.Enabled = True
        Timer2.Enabled = True

        Dim cmd As New SqlCommand
        Try
            conn.ConnectionString = CnnString
            If pdfstatus = 0 Then
                cmd.CommandText = "SELECT  DocPathNew  FROM tbISODocuments  WHERE  MainId = " & MainId & ""
            Else
                cmd.CommandText = "SELECT   LinkPdf FROM  tbDocumentLinks WHERE  LinksID = " & MainId & ""
            End If


            cmd.Connection = conn
            conn.Open()
            Dim BarrImg() As Byte = cmd.ExecuteScalar()
            strfn = Convert.ToString(DateTime.Now.ToFileTime())
            Dim fs = New FileStream(strfn, FileMode.CreateNew, FileAccess.ReadWrite)
            fs.Write(BarrImg, 0, BarrImg.Length)
            fs.Flush()
            fs.Close()

            AxPdf1.LoadFile(strfn)
            AxPdf1.setShowToolbar(True)
            'AxPdf1.setShowScrollbars(True)
            AxPdf1.setShowToolbar(True)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean 'LockKey
        Select Case (keyData)
            Case Keys.Control
                MessageBox.Show("Control Key pressed")
            Case Keys.O, Keys.M, Keys.I, Keys.D, Keys.U, Keys.K, Keys.J
                txt1.Focus()

            Case Keys.H, Keys.T, Keys.R, Keys.Y, Keys.Decimal, Keys.Back
                txt2.Focus()

        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ''''Clear Clipboard
        Try
            My.Computer.Clipboard.Clear()
        Catch ex As Exception
            Timer1.Enabled = False
        End Try
        ''''''''''

        ProcessDialogKey(Keys.O) 'LockKey
        ProcessDialogKey(Keys.M) 'LockKey
        ProcessDialogKey(Keys.I) 'LockKey
        ProcessDialogKey(Keys.D) 'LockKey
        ProcessDialogKey(Keys.U) 'LockKey
        ProcessDialogKey(Keys.K) 'LockKey
        ProcessDialogKey(Keys.J) 'LockKey

        'Try
        '    My.Computer.FileSystem.DeleteFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\EBook.joboptions")

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        ProcessDialogKey(Keys.H) 'LockKey
        ProcessDialogKey(Keys.R) 'LockKey
        ProcessDialogKey(Keys.T) 'LockKey
        ProcessDialogKey(Keys.Y) 'LockKey
        ProcessDialogKey(Keys.Back) 'LockKey
        ProcessDialogKey(Keys.Decimal) 'LockKey

        'Try
        '    My.Computer.FileSystem.DeleteFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\EBook.joboptions")
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '''' در درايو  Cجهت درست نمودن نام فايلهايي كه توسط ايزوداك خراب شده
        Try
            Timer1.Enabled = False
            Timer2.Enabled = False
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
            System.IO.File.Delete(strfn)
        Catch
        End Try
        '''' در درايو  Dجهت درست نمودن نام فايلهايي كه توسط ايزوداك خراب شده
        Try
            Timer1.Enabled = False
            Timer2.Enabled = False
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
            System.IO.File.Delete(strfn)
        Catch
        End Try
        ''''دليل : بعضي پي دي اف ها به دليل خراب بودن باز نميشوند و باعث مي شوند ديگر پي دي افي باز نشود
        ''KillProcess()
        ''''
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Zoom = Zoom * 4 / 5
        ZoomCount = ZoomCount + 1
        AxPdf1.setZoom(Zoom)
    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomIN.Click
        Zoom = Zoom * 5 / 4
        ZoomCount = ZoomCount + 1
        AxPdf1.setZoom(Zoom)
    End Sub

    Private Sub btnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomOut.Click

        Zoom = Zoom * 4 / 5
        ZoomCount = ZoomCount + 1
        AxPdf1.setZoom(Zoom)
    End Sub

    Private Sub پرینتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles پرینتToolStripMenuItem.Click
        PrintPDF()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintPDF()
    End Sub

    Private Sub PrintPDF()
        '''' در درايو  Cجهت درست نمودن نام فايلهايي كه توسط ايزوداك خراب شده
        Try
            Dim arrFiles() As String = Directory.GetFiles("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings")
            Dim fileCount As Integer = Directory.GetFiles("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings").Length
            Dim i As Integer
            If fileCount > 0 Then
                For i = 0 To fileCount - 1
                    Dim currentFile As String = Mid(arrFiles(i), 54)
                    Dim fileDetails As FileInfo = New FileInfo(arrFiles(i))
                    Select Case currentFile
                        Case "eBook.joboptions"
                            My.Computer.FileSystem.RenameFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\eBook.joboptions", ".eBook")
                        Case "Press.joboptions"
                            My.Computer.FileSystem.RenameFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\Press.joboptions", ".Press")
                        Case "Print.joboptions"
                            My.Computer.FileSystem.RenameFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\Print.joboptions", ".Print")
                        Case "Screen.joboptions"
                            My.Computer.FileSystem.RenameFile("C:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\Screen.joboptions", ".Screen")
                    End Select
                Next
            End If

            My.Computer.FileSystem.RenameDirectory("C:\Program Files\Microsoft Office\Office12\OneNote", "OneNot")
        Catch ex As Exception

        End Try

        '''' در درايو  Dجهت درست نمودن نام فايلهايي كه توسط ايزوداك خراب شده
        Try
            Dim arrFiles() As String = Directory.GetFiles("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings")
            Dim fileCount As Integer = Directory.GetFiles("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings").Length
            Dim i As Integer
            If fileCount > 0 Then
                For i = 0 To fileCount - 1
                    Dim currentFile As String = Mid(arrFiles(i), 54)
                    Dim fileDetails As FileInfo = New FileInfo(arrFiles(i))
                    Select Case currentFile
                        Case "eBook.joboptions"
                            My.Computer.FileSystem.RenameFile("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\eBook.joboptions", ".eBook")
                        Case "Press.joboptions"
                            My.Computer.FileSystem.RenameFile("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\Press.joboptions", ".Press")
                        Case "Print.joboptions"
                            My.Computer.FileSystem.RenameFile("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\Print.joboptions", ".Print")
                        Case "Screen.joboptions"
                            My.Computer.FileSystem.RenameFile("D:\Program Files\Adobe\Acrobat 5.0\Distillr\Settings\Screen.joboptions", ".Screen")
                    End Select
                Next
            End If

            My.Computer.FileSystem.RenameDirectory("D:\Program Files\Microsoft Office\Office12\OneNote", "OneNot")
        Catch ex As Exception

        End Try

        'Print-----------------------------
        AxPdf1.Print()
    End Sub
    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextPage.Click
        AxPdf1.gotoNextPage()
    End Sub

    Private Sub btnLastPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastPage.Click
        AxPdf1.gotoLastPage()
    End Sub

    Private Sub btnFirstPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstPage.Click
        AxPdf1.gotoFirstPage()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousPage.Click
        AxPdf1.gotoPreviousPage()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Zoom = Zoom * 5 / 4
        ZoomCount = ZoomCount + 1
        AxPdf1.setZoom(Zoom)
    End Sub

    Private Sub UiButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowLink()
    End Sub

    Private Sub Slider1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Slider1.ValueChanged
        Try
            If Slider1.Value > 50 Then
                Zoom = Slider1.Value * 4
                AxPdf1.setZoom(Zoom)
            Else

                Zoom = Slider1.Value / 0.5
                AxPdf1.setZoom(Zoom)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class