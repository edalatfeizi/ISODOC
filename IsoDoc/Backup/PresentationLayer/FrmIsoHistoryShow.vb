Public Class FrmIsoHistoryShow
    Dim dt As DataTable
    Dim FilePath As String
    Private Bus_History1 As New Bus_History
    Private Bus_DocType1 As New Bus_DocType

    Private Sub FillCmb()
        Dim dt_DocTypeName As DataTable
        dt_DocTypeName = Bus_DocType1.GetDocNameInfo
        persist1.FillCmb(dt_DocTypeName, cmbDocName, "DocId", "DocName")
    End Sub
    Private Sub FillGrid()

        dt = Bus_History1.GetHistoryInfo
        dt.DefaultView.RowFilter = "DocTypeID=" & cmbDocName.SelectedValue
        persist1.SetMyGridStyle = True
        persist1.GetBindGrid_Dt(dgdHistory, CnnString, dt)
        Dim ts1 As New System.Windows.Forms.DataGridTableStyle
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdHistory, "MainID", "ﬂœ", 0, False, False) 'PK'
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdHistory, "DocID", "DocID", 0, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdHistory, "DocCode", "ﬂœ ”‰œ", 75, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdHistory, "DocName", "‰«„ ”‰œ", 300, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdHistory, "DocReviewNum", "‘„«—Â »«“‰ê—Ì", 75, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdHistory, "DocReviewDate", " «—ÌŒ »«“‰ê—Ì", 75, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdHistory, "DocDateHistory", " «—ÌŒ »«Ìê«‰Ì", 75, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt, dgdHistory, "FilePath", "FilePath", 0, False, True)
        utility1.SetWlglobalForm(Me.BindingContext, CnnString, dt, dgdHistory)
    End Sub
 
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmbDocName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDocName.SelectedValueChanged
        Try
            FillGrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FrmIsoHistoryShow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCmb()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        ShowDocs()
    End Sub

    Private Sub ChkAllDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAllDoc.CheckedChanged
        If ChkAllDoc.Checked = True Then
            dt.DefaultView.RowFilter = ""
        Else
            dt.DefaultView.RowFilter = "DocTypeID=" & cmbDocName.SelectedValue
        End If
    End Sub

    Private Sub dgdHistory_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdHistory.DoubleClick
        ShowDocs()
    End Sub

    Private Sub ShowDocs()
        FilePath = dgdHistory.Item(dgdHistory.CurrentCell.RowNumber, 7)
        Try
            If FilePath <> "" Then
                System.Diagnostics.Process.Start(FilePath)
            End If
        Catch ex As Exception
            Dim Bus_MessageHandler1 As New Bus_MessageHandler
            Dim fileType As String
            fileType = Bus_MessageHandler1.GetFileExtension(FilePath)
            If fileType = "" Then
                'MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Critical)
                MessageBox.Show("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", "Œÿ«", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Else
                MsgBox("œ«—Ìœ " + fileType + " »—«Ì „‘«ÂœÂ «Ì‰ ”‰œ ‰Ì«“ »Â ‰—„ «›“«—", MsgBoxStyle.Information)

            End If
        End Try


    End Sub

End Class