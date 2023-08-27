Imports Janus.Windows.GridEX
Imports System.io

Public Class FrmIsoMaster
    Private Bus_document1 As Bus_Document
    Private Bus_PostIdentification1 As New Bus_PostIdentification
    Private Cls_JanusGrid1 As New Cls_JanusGrid
    Dim dt_Export As New DataTable
    Private counter As Integer
    Dim FlgLoad As Boolean
    Dim b As System.IO.File

    Private Sub FrmIsoMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        act1.CheckJanusExplorBar(27, AppID, Me.ExplorerBar1)
        lblFilePath.Visible = False
        ' GetInfo(9)
    End Sub

    Private Sub FillGrid(ByVal dt As DataTable)
        dt_Export = dt
        If dt.DefaultView.Count <> 0 Then
            Me.Text = dt.DefaultView.Item(0).Item("DocName")
        Else
            MsgBox("«ÿ·«⁄«  À»  ‰‘œÂ «” ", MsgBoxStyle.OkOnly, "Œÿ«")
            Exit Sub
        End If

        dt.DefaultView.Sort = "DocumentCode"
        Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)

        If dt.DefaultView.Item(0).Item("DocType") = 26 Then
            Cls_JanusGrid1.setMyJGrid(dt, dg, "MainId", "MainId", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentName", "‰«„ ”‰œ", 250)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 90)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 100)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "HistorySave", "„œ  “„«‰ ‰êÂœ«—Ì", 100)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocPath", "DocPath", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "AppName", "‰«„ ”«„«‰Â", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "MethodTxt", "Artifact", 0, , , False)
            '-------
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocTypeID", "DocTypeID", 0, , , False)
            '-------
            Cls_JanusGrid1.SetGroup(dg, "AppName")
            Cls_JanusGrid1.SetGroup(dg, "MethodTxt")

        Else

            If (dt.DefaultView.Item(0).Item("DocType") = 6) Then
                dt.DefaultView.Sort = "DocumentCode"

            End If



            Cls_JanusGrid1.setMyJGrid(dt, dg, "MainId", "MainId", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "MDepName", "‰«„ Ê«Õœ", 100)
            If (dt.DefaultView.Item(0).Item("DocType") = 10) Or (dt.DefaultView.Item(0).Item("DocType") = 25) Then
                Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentCode", "ﬂœ Å—ÊéÂ", 100)
            Else
                Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentCode", "ﬂœ ”‰œ", 100)
            End If
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentName", "‰«„ ”‰œ", 250)
            If (dt.DefaultView.Item(0).Item("DocType") <> 10) And (dt.DefaultView.Item(0).Item("DocType") <> 25) Then
                Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 50)
                Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 100)
                Cls_JanusGrid1.setMyJGrid(dt, dg, "HistorySave", "„œ  “„«‰ ‰êÂœ«—Ì", 100)
            End If

            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocPath", "DocPath", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocSettingPath", "DocSettingPath", 0, , , False)
            Cls_JanusGrid1.setMyJGrid(dt, dg, "MdepartID", "MdepartID", 0, , , False)
            '---------
            Cls_JanusGrid1.setMyJGrid(dt, dg, "DocTypeID", "DocTypeID", 0, , , False)
            '---------
            Cls_JanusGrid1.SetGroup(dg, "MDepName")
        End If
    End Sub
    Friend Function GetInfo(ByVal DocTypeID As Integer) As DataTable
        Dim dt1 As New DataTable
        Select Case DocTypeID
            Case 1
                Dim Bus_OthersDoc1 As New Bus_OthersDoc
                dt1 = Bus_OthersDoc1.GetDocumentInfo
                dt1.DefaultView.RowFilter = "DocType=1"
            Case 2
                Dim Bus_OthersDoc1 As New Bus_OthersDoc
                dt1 = Bus_OthersDoc1.GetDocumentInfo
                dt1.DefaultView.RowFilter = "DocType=2"
            Case 3

                Bus_document1 = New Bus_RaveshEjraie
                dt1 = Bus_document1.GetAllInfo
                dt1.DefaultView.RowFilter = "DocType=3"
            Case 4
                Bus_document1 = New Bus_Dastor
                dt1 = Bus_document1.GetAllInfo
                dt1.DefaultView.RowFilter = "DocType=4"
            Case 5
                Bus_document1 = New Bus_AienName
                dt1 = Bus_document1.GetAllInfo
                dt1.DefaultView.RowFilter = "DocType=5"
            Case 6
                Bus_document1 = New Bus_NemodarGardesh
                dt1 = Bus_document1.GetAllInfo
                dt1.DefaultView.RowFilter = "DocType=6"
            Case 12
                Bus_document1 = New Bus_FlowChart
                dt1 = Bus_document1.GetAllInfo
                dt1.DefaultView.RowFilter = "DocType=12"
            Case 9
                Bus_document1 = New Bus_Forms
                dt1 = Bus_document1.GetAllInfo
                dt1.DefaultView.RowFilter = "DocType=9"
            Case 10
                Dim Bus_OthersDoc1 As New Bus_OthersDoc
                dt1 = Bus_OthersDoc1.GetDocumentInfo
                dt1.DefaultView.RowFilter = "DocType=10"
            Case 11
                Dim Bus_OthersDoc1 As New Bus_OthersDoc
                dt1 = Bus_OthersDoc1.GetDocumentInfo
                dt1.DefaultView.RowFilter = "DocType=11"
            Case 8
                Dim Bus_OthersDoc1 As New Bus_OthersDoc
                dt1 = Bus_OthersDoc1.GetDocumentInfo
                dt1.DefaultView.RowFilter = "DocType=8"
            Case 13
                Bus_document1 = New Bus_ProcessDesc
                dt1 = Bus_document1.GetAllInfo
                dt1.DefaultView.RowFilter = "DocType=13"
            Case 14
                Bus_document1 = New Bus_EqualStandard
                dt1 = Bus_document1.GetAllInfo
                dt1.DefaultView.RowFilter = "DocType=14"
            Case 25
                Dim Bus_OthersDoc1 As New Bus_OthersDoc
                dt1 = Bus_OthersDoc1.GetDocumentInfo
                dt1.DefaultView.RowFilter = "DocType=25"
            Case 26
                Dim Bus_OthersDoc1 As New Bus_OthersDoc
                dt1 = Bus_OthersDoc1.GetDocumentInfo
                dt1.DefaultView.RowFilter = "DocType=26"
            Case 27
                Dim Bus_OthersDoc1 As New Bus_OthersDoc
                dt1 = Bus_OthersDoc1.GetDocumentInfo
                dt1.DefaultView.RowFilter = "DocType=27"
        End Select
        GetInfo = dt1
        FillGrid(dt1)
    End Function

    Private Sub Ã” ÊÃÊÌToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim b As New FrmIsoSearch
        b.ShowDialog()
    End Sub

    Private Sub dgdIsoMaster_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            ' lblFilePath.Text = dgdIsoMaster.Item(dgdIsoMaster.CurrentCell.RowNumber, 5)
            System.Diagnostics.Process.Start(LTrim(RTrim(lblFilePath.Text)))
        Catch ex As Exception
            MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ  Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        PicShow.Visible = True
        lblExecute.Visible = True
        PicShow.Enabled = True
        counter = counter + 1
        If counter = 2 Then
            If dg.RowCount = 0 Then
                PicShow.Visible = False
                lblExecute.Visible = False
                PicShow.Enabled = False
                Timer1.Enabled = False
                counter = 0

                Exit Sub
            Else
                If dg.GetValue("DocTypeID") <> 1 Then
                    Try
                        Dim e1 As New EventArgs
                        Timer1.Enabled = True
                        Me.Timer1_Tick(Me, e1)
                        lblFilePath.Text = dg.GetValue("DocPath")
                        '  Dim b As New OfficeControl.initcomponent.Init
                        ' b.FilePath = lblFilePath.Text

                        System.Diagnostics.Process.Start(LTrim(RTrim(lblFilePath.Text)))
                    Catch ex As Exception
                        Dim Bus_MessageHandler1 As New Bus_MessageHandler
                        Dim fileType As String
                        fileType = Bus_MessageHandler1.GetFileExtension(lblFilePath.Text.Trim)
                        If fileType = "" Then
                            MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
                        Else
                            MsgBox("œ«— Ìœ " + fileType + " »—«Ì „‘«ÂœÂ «Ì‰ ”‰œ ‰Ì«“ »Â ‰—„ «›“«—", MsgBoxStyle.Critical)
                        End If
                    End Try
                    PicShow.Visible = False
                    lblExecute.Visible = False
                    PicShow.Enabled = False
                    Timer1.Enabled = False
                    counter = 0
                    Exit Sub

                ElseIf dg.GetValue("DocTypeID") = 1 Then
                    Dim frm As New frmPDF
                    MainId = dg.GetValue("MainID")
                    PicShow.Visible = False
                    Timer1.Enabled = False
                    lblExecute.Visible = False
                    frm.ShowDialog()
                    counter = 0
                    Exit Sub

                End If
            End If
        End If
   
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim Bus_Favorites1 As New Bus_Favorites
        Bus_Favorites1.Insert(dg.GetValue("MainId"), SystemInformation.UserName)
        MsgBox("”‰œ „Ê—œ ‰Ÿ— »Â ·Ì”  ⁄·«ﬁÂ „‰œÌ ‘„« «÷«›Â ‘œ", MsgBoxStyle.Information)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim b As New FrmIsoFarvorites
        b.ShowDialog()
    End Sub

    Private Sub ExplorerBar1_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ExplorerBar.ItemEventArgs)
        If e.Item.Key = "btnSearch" Then
            Dim b As New FrmIsoSearch
            b.ShowDialog()
        End If
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)
    End Sub

    Private Sub ExplorerBar1_ItemClick_1(ByVal sender As System.Object, ByVal e As Janus.Windows.ExplorerBar.ItemEventArgs) Handles ExplorerBar1.ItemClick
        Select Case e.Item.Key
            Case "btnViewDoc"
                Dim e1 As New EventArgs
                Timer1.Enabled = True
                Me.Timer1_Tick(Me, e1)
            Case "btnSettingPad"
                Try
                    lblSettingPath.Text = dg.GetValue("DocSettingPath")
                    System.Diagnostics.Process.Start(LTrim(RTrim(lblSettingPath.Text)))
                Catch ex As Exception
                    MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
                End Try
            Case "btnClose"
                Me.Close()
            Case "btnFavoriteList"
                Dim b As New FrmIsoFarvorites
                b.ShowDialog()
            Case "addtoFavorite"
                Try
                    If dg.GetValue("MainId") = Nothing Then
                        MsgBox("·ÿ›« ⁄„·Ì«  —« œÊ»«—Â «‰Ã«„ œÂÌœ", MsgBoxStyle.Critical, "Œÿ«")
                    Else
                        Dim Bus_Favorites1 As New Bus_Favorites
                        Bus_Favorites1.Insert(dg.GetValue("MainId"), SystemInformation.UserName)
                        MsgBox("”‰œ „Ê—œ ‰Ÿ— »Â ·Ì”  ⁄·«ﬁÂ „‰œÌ ‘„« «÷«›Â ‘œ", MsgBoxStyle.Information)
                    End If

                Catch ex As Exception
                    MsgBox("·ÿ›« ⁄„·Ì«  —« œÊ»«—Â «‰Ã«„ œÂÌœ", MsgBoxStyle.Critical, "Œÿ«")
                End Try
            Case "Print"
                PrintPreviewDialog1.SetBounds(Bounds.Left, Bounds.Top, Bounds.Width, Bounds.Height)
                PrintPreviewDialog1.ShowDialog()
            Case "btnSearch"
                Dim b As New FrmIsoSearch
                b.ShowDialog()
            Case "btnForm"
                GetInfo(9)
                'ExplorerBar1.Groups(4).Items("btnForm").Visible = False
            Case "btnChart"
                GetInfo(1)
                ' ExplorerBar1.Groups(4).Items("btnChart").Visible = False
            Case "btnVazayef"
                GetInfo(2)
                ' ExplorerBar1.Groups(4).Items("btnVazayef").Visible = False
            Case "BtnRavesh"
                GetInfo(3)
                ' ExplorerBar1.Groups(4).Items("btnRavesh").Visible = False
            Case "btnDastor"
                GetInfo(4)
                '  ExplorerBar1.Groups(4).Items("btnDastor").Visible = False
            Case "btnAien"
                GetInfo(5)
                ' ExplorerBar1.Groups(4).Items("btnAien").Visible = False
            Case "btnTarheControl"
                GetInfo(10)
                ' ExplorerBar1.Groups(4).Items("btnTarheControl").Visible = False
            Case "btnNemodar"
                GetInfo(6)
                'ExplorerBar1.Groups(4).ItemS("btnNemodar").Visible = False
            Case "btnFlow"
                GetInfo(12)
                'ExplorerBar1.Groups(4).Items("btnFlow").Visible = False
            Case "btnSharheFarayand"
                GetInfo(13)
                ' ExplorerBar1.Groups(4).Items("btnSharheFarayand").Visible = False
            Case "btnShenasnamefarayand"
                GetInfo(8)
                ' ExplorerBar1.Groups(4).Items("btnShenasnamefarayand").Visible = False
            Case "btnShenasnamePost"
                GetInfo(11)
                ' ExplorerBar1.Groups(4).Items("btnShenasnamePost").Visible = False
            Case "btnYeksanSazi"
                GetInfo(14)
            Case "btnFMEA"
                GetInfo(25)
            Case "btnJadval"
                GetInfo(27)
            Case "btnEditMaster"
                Dim b As New FrmIsoRegistDocument
                b.ShowDialog()
        End Select
    End Sub
    Private Sub dg_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dg.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.ContextMenuStrip1.Show(Me, New System.Drawing.Point(MousePosition.X, MousePosition.Y - 30))
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim FL As New Janus.Windows.GridEX.GridEXFilterCondition
        'FL = New Janus.Windows.GridEX.GridEXFilterCondition(dg.RootTable.Columns(1), Janus.Windows.GridEX.ConditionOperator.Contains, txt_Search.Text.Trim)
        'dg.RootTable.FilterCondition = FL
    End Sub

End Class