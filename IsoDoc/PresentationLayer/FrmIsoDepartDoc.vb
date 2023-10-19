
Public Class FrmIsoDepartDoc
    Private Bus_Certificate1 As New Bus_Certificate
    Private Bus_ImportandDoc1 As New Bus_ImportandDoc
    Private Bus_StartegicPlan1 As New Bus_StartegicPlan
    Private Bus_OthersDoc1 As New Bus_OthersDoc
    Private Bus_OutsideDoc1 As New Bus_OutsideDoc
    Private Bus_Document1 As Bus_Document
    Private Mdepart1 As New Personely.FacadJobClassification.FacMDepart
    Private Bus_DocName1 As New Bus_DocType
    Private dt_Document, dt_Certificate, dt_Stategic, dt_Other, dt_OutSide, dt_Docname, dt_MDepart, dt_FormDocName As New DataTable
    Private Cls_JanusGrid1 As New Cls_JanusGrid
    Dim counter As Integer
    Private Sub FrmIsoDepartDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillObject()

    End Sub

    Private Sub FillDocumentsGrid()
        dt_Document = Bus_OthersDoc1.GetDocumentInfo()
        dt_Document.DefaultView.RowFilter = "MdepartID='" & LstMdep.SelectedValue & "' and DocType=" & LstDocName.SelectedValue
        Cls_JanusGrid1.GetBindJGrid_DT(dt_Document, dg, CnnString)

        Cls_JanusGrid1.setMyJGrid(dt_Document, dg, "MainID", "MainID", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt_Document, dg, "DocumentCode", "ﬂœ ”‰œ", 90)
        Cls_JanusGrid1.setMyJGrid(dt_Document, dg, "DocumentName", "‰«„ ”‰œ", 300)
        Cls_JanusGrid1.setMyJGrid(dt_Document, dg, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 90)
        Cls_JanusGrid1.setMyJGrid(dt_Document, dg, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 900)
        Cls_JanusGrid1.setMyJGrid(dt_Document, dg, "DocPath", "FilePath", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt_Document, dg, "DocSettingPath", "FilePath", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt_Document, dg, "DocTypeID", "DocTypeID", 50)




        'dt_Document = Bus_OthersDoc1.GetDocumentInfo()
        'dt_Document.DefaultView.RowFilter = "MdepartID='" & LstMdep.SelectedValue & "' and DocType=" & LstDocName.SelectedValue
        ''  case 
        '' End Select
        'persist1.SetMyGridStyle = True
        'persist1.GetBindGrid_Dt(dgdDocument, CnnString, dt_Document)
        'Dim ts1 As New System.Windows.Forms.DataGridTableStyle
        'persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Document, dgdDocument, "DocumentCode", "ﬂœ ”‰œ", 75, False, False)
        'persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Document, dgdDocument, "DocumentName", "‰«„ ”‰œ", 250, False, False)
        'persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Document, dgdDocument, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 75, False, False)
        'persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Document, dgdDocument, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 75, False, False)
        'persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Document, dgdDocument, "DocPath", "DocPath", 0, False, False)
        'persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Document, dgdDocument, "DocSettingPath", "DocSettingPath", 0, False, True)
    End Sub

    Private Sub FillObject()
        dt_MDepart = Mdepart1.GetMDepartList
        persist1.FillCmb(dt_MDepart, LstMdep, "MDepID", "MDepName")
    End Sub

    Private Sub LstMdep_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstMdep.SelectedValueChanged
        Try
            dt_Docname = Bus_DocName1.GetDocFormName
            dt_Docname.DefaultView.RowFilter = "MdepCode='" & LstMdep.SelectedValue & "'"

            persist1.FillCmb(dt_Docname, LstDocName, "DocCode", "DocName")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstDocName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstDocName.SelectedValueChanged
        Try
            FillDocumentsGrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblWait.Visible = True
        PicShow.Visible = True
        counter = counter + 1
        If counter = 4 Then
            If dg.GetValue("DocTypeID") <> 1 Then
                Try
                    If Flg = "Regist" Then
                        FilePath = dg.GetValue("DocSettingPath")
                    Else
                        FilePath = dg.GetValue("DocPath")
                    End If

                    System.Diagnostics.Process.Start(LTrim(RTrim(FilePath)))
                Catch ex As Exception
                    Dim Bus_MessageHandler1 As New Bus_MessageHandler
                    Dim fileType As String
                    fileType = Bus_MessageHandler1.GetFileExtension(FilePath)
                    If fileType = "" Then
                        MessageBox.Show("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", "Œÿ«", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
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
                PicShow.Visible = False
                Timer1.Enabled = False
                counter = 0
                Exit Sub
            End If

        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)


    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)
        Flg = ""
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)
        Flg = "Regist"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub LstMdep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstMdep.SelectedIndexChanged
        'Try
        '    dt_Docname = Bus_DocName1.GetDocFormName
        '    dt_Docname.DefaultView.RowFilter = "MdepCode='" & LstMdep.SelectedValue & "'"
        '    persist1.FillCmb(dt_Docname, LstDocName, "DocCode", "DocName")
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dg_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles dg.FormattingRow

    End Sub

    Private Sub dg_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dg.MouseDown
        If e.Button = MouseButtons.Right Then
            Me.ContextMenuStrip1.Show(Me, New System.Drawing.Point(MousePosition.X, MousePosition.Y - 50))
        End If
    End Sub

    Private Sub «›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles «›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem.Click
        Dim Bus_Favorites1 As New Bus_Favorites
        Bus_Favorites1.Insert(dg.GetValue("MainId"), SystemInformation.UserName)
        MsgBox("”‰œ „Ê—œ ‰Ÿ— »Â ·Ì”  ⁄·«ﬁÂ „‰œÌ ‘„« «÷«›Â ‘œ", MsgBoxStyle.Information)
    End Sub

    Private Sub „‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles „‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem.Click
        Dim b As New FrmIsoFarvorites
        b.ShowDialog()
    End Sub

End Class