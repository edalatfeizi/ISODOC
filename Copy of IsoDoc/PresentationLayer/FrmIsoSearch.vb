Public Class FrmIsoSearch
    Dim Dac_Document1 As New Dac_Document
    Dim Bus_TechnicalDoc1 As New Bus_TechnicalDoc
    Dim dt As New DataTable
    Dim Flg As String

    Private Sub FillDocument()
        persist1.SetMyGridStyle = True
        persist1.GetBindGrid_Dt(dgdSearch, CnnString, dt)
        Dim ts1 As New System.Windows.Forms.DataGridTableStyle
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocumentCode", "ﬂœ ”‰œ", 100, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocumentName", "‰«„ ”‰œ", 300, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocName", "‰Ê⁄ ”‰œ", 100, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 75, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 75, False, False)
        ' persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "HistorySave", "„œ  “„«‰ ‰êÂœ«—Ì", 400, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocPath", "DocPath", 0, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocSettingPath", "DocSettingPath", 0, False, True)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "MainId", "MainId", 0, False, True)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocTypeID", "DocTypeID", 0, False, True)


        utility1.SetWlglobalForm(Me.BindingContext, CnnString, dt, dgdSearch)
    End Sub

    'Private Sub FillTechnical()
    '    persist1.SetMyGridStyle = True
    '    persist1.GetBindGrid_Dt(dgdSearch, CnnString, dt)
    '    Dim ts1 As New System.Windows.Forms.DataGridTableStyle
    '    persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocumentName", "‰«„ ”‰œ", 300, False, False)
    '    persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 75, False, False)
    '    persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 75, False, False)
    '    persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "HistorySave", "„œ  “„«‰ ‰êÂœ«—Ì", 400, False, False)
    '    persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocPath", "DocPath", 0, False, False)
    '    persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdSearch, "DocSettingPath", "DocSettingPath", 0, False, False)

    '    utility1.SetWlglobalForm(Me.BindingContext, CnnString, dt, dgdSearch)
    'End Sub

    Private Sub FrmIsoSearchLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblFilePath.Visible = False
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        utility1.GetLanguageFarsi()
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress

        If e.KeyChar = Chr(13) Then
            dt = Dac_Document1.GetALLDocumentInfo("DocumentName Like '%" & txtSearch.Text.Trim & "%'  AND (IsoDocViewID = 1)   or DocumentCode like '%" & txtSearch.Text.Trim & "%'   AND (IsoDocViewID = 1) ")
            'dt.DefaultView.RowFilter = "DocumentName Like '%" & txtSearch.Text & "%'  AND (IsoDocViewID = 1)   or DocumentCode like '%" & txtSearch.Text & "%'   AND (IsoDocViewID = 1) "

            FillDocument()
            If dt.DefaultView.Count = 0 Then
                MsgBox("„Ê—œÌ ÅÌœ« ‰‘œ", MsgBoxStyle.OkOnly)
            End If
        End If

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim DocTypeID As Integer
        MainId = dgdSearch.Item(dgdSearch.CurrentCell.RowNumber, 7)
        DocTypeID = dgdSearch.Item(dgdSearch.CurrentCell.RowNumber, 8)
        If DocTypeID = 1 And MainId <> -1 Then

            Dim frm As New frmPDF
            MainId = MainId
            frm.ShowDialog()
            Exit Sub

        Else

            Try
                lblFilePath.Text = dgdSearch.Item(dgdSearch.CurrentCell.RowNumber, 5)
                System.Diagnostics.Process.Start(LTrim(RTrim(lblFilePath.Text)))
            Catch ex As Exception
                Dim Bus_MessageHandler1 As New Bus_MessageHandler
                Dim fileType As String
                fileType = Bus_MessageHandler1.GetFileExtension(lblFilePath.Text)
                If fileType = "" Then
                    ''''MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Critical)
                    MessageBox.Show("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", "Œÿ«", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Else
                    MsgBox("œ«—Ìœ " + fileType + " »—«Ì „‘«ÂœÂ «Ì‰ ”‰œ ‰Ì«“ »Â ‰—„ «›“«—", MsgBoxStyle.Critical)

                End If
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgdSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdSearch.DoubleClick
        Dim DocTypeID As Integer
        MainId = dgdSearch.Item(dgdSearch.CurrentCell.RowNumber, 7)
        DocTypeID = dgdSearch.Item(dgdSearch.CurrentCell.RowNumber, 8)
        If DocTypeID = 1 And MainId <> -1 Then

            Dim frm As New frmPDF
            MainId = MainId
            frm.ShowDialog()
            Exit Sub

        Else

            Try
                lblFilePath.Text = dgdSearch.Item(dgdSearch.CurrentCell.RowNumber, 5)
                System.Diagnostics.Process.Start(LTrim(RTrim(lblFilePath.Text)))
            Catch ex As Exception
                Dim Bus_MessageHandler1 As New Bus_MessageHandler
                Dim fileType As String
                fileType = Bus_MessageHandler1.GetFileExtension(lblFilePath.Text)
                If fileType = "" Then
                    ''''MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Critical)
                    MessageBox.Show("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", "Œÿ«", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Else
                    MsgBox("œ«—Ìœ " + fileType + " »—«Ì „‘«ÂœÂ «Ì‰ ”‰œ ‰Ì«“ »Â ‰—„ «›“«—", MsgBoxStyle.Critical)

                End If
            End Try
        End If
    End Sub

    Private Sub «›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Bus_Favorites1 As New Bus_Favorites
        Bus_Favorites1.Insert(dgdSearch.Item(dgdSearch.CurrentCell.RowNumber, 7), SystemInformation.UserName)
        MsgBox("”‰œ „Ê—œ ‰Ÿ— »Â ·Ì”  ⁄·«ﬁÂ „‰œÌ ‘„« «÷«›Â ‘œ", MsgBoxStyle.Information)
    End Sub

    Private Sub „‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim b As New FrmIsoFarvorites
        b.ShowDialog()
    End Sub

    ''Private Sub dgdSearch_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgdSearch.MouseDown
    ''    ' ''If e.Button = Windows.Forms.MouseButtons.Right Then
    ''    ' ''    Me.ContextMenuStrip1.Show(Me, New System.Drawing.Point(MousePosition.X, MousePosition.Y - 30))
    ''    ' ''End If
    ''End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Dim dt As DataTable
        If Flg = "Technical" Then
            dt = Bus_TechnicalDoc1.GetTechnicalDocInfo
        Else
            dt = Dac_Document1.GetALLDocumentInfo("LTRIM(RTRIM(DocumentName)) Like '%" & txtSearch.Text.Trim & "%'  AND (IsoDocViewID = 1)   or DocumentCode like '%" & txtSearch.Text.Trim & "%'   AND (IsoDocViewID = 1) ")
            ''dt.DefaultView.RowFilter = "DocumentName Like '%" & txtSearch.Text.Trim & "%'  AND (IsoDocViewID = 1)   or DocumentCode like '%" & txtSearch.Text.Trim & "%'   AND (IsoDocViewID = 1) "

            FillDocument()
            If dt.DefaultView.Count = 0 Then
                MsgBox("„Ê—œÌ ÅÌœ« ‰‘œ", MsgBoxStyle.OkOnly)
            End If
        End If

    End Sub

End Class