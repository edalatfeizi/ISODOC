Public Class FrmInsOutsideDoc
    Private Bus_OutsideDoc1 As New Bus_OutsideDoc
    Private Sub FrmInsOutsideDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillOutsideDocGrid()
    End Sub
    Private Sub FillOutsideDocGrid()
        Dim dt As DataTable
        dt = Bus_OutsideDoc1.GetOutSideDoc

        Janus1.GetBindJGrid_DT(dt, dg, CnnString)
        Janus1.setMyJGrid(dg, "PublicDocId", "", 0, , , False)
        Janus1.setMyJGrid(dg, "PublicDocCode", "ﬂœ ”‰œ", 85)
        Janus1.setMyJGrid(dg, "PublicDocName", "‰«„ ”‰œ", 300)
        Janus1.setMyJGrid(dg, "PublicDocPath", "PublicDocPath", 0, , , False)
        Janus1.setMyJGrid(dg, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 100)
        Janus1.setMyJGrid(dg, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 90)
        Janus1.setMyJGrid(dg, "sherkatname", "‰«„ ‘—ò ", 90)
        Janus1.BindJanusNavigator(dg, dt)

    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        OpenFileDialog1.Filter = "All Files|*.*"
        OpenFileDialog1.InitialDirectory = "\\srv05si\iso"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtFilePath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub UiButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton2.Click
        Try
            If txtFilePath.Text <> "" Then
                System.Diagnostics.Process.Start(txtFilePath.Text)
            End If
        Catch ex As Exception
            MsgBox("„”Ì— ›«Ì· „Ê—œ ‰Ÿ— ’ÕÌÕ ‰„Ì »«‘œ", MsgBoxStyle.Critical, "Œÿ«")

        End Try
    End Sub

    Private Sub dg_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.CurrentCellChanged
        Try
            txtDocName.Text = utility1.NZ(dg.GetValue("PublicDocName"), "")
            txtDocCode.Text = utility1.NZ(dg.GetValue("PublicDocCode"), "")
            txtFilePath.Text = utility1.NZ(dg.GetValue("PublicDocPath"), "")
            txtRevisionNum.Text = utility1.NZ(dg.GetValue("RevisionNo"), "")
            MskReviewDate.Text = utility1.NZ(dg.GetValue("RevisionDate"), "")
            txtsherkat.Text = utility1.NZ(dg.GetValue("sherkatname"), "")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UiButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton3.Click
        Bus_OutsideDoc1.Insert(txtDocName.Text.Trim, txtDocCode.Text, txtFilePath.Text.Trim, txtRevisionNum.Text, MskReviewDate.Text.Trim, txtsherkat.Text)
        MsgBox("—ﬂÊ—œ À»  ‘œ", MsgBoxStyle.Information, "")
        FillOutsideDocGrid()
    End Sub

    Private Sub UiButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton5.Click

        If MsgBox("¬Ì« „ÿ„∆‰ Â” Ìœ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_OutsideDoc1.Delete(dg.GetValue("PublicDocId"))
            MsgBox("—ﬂÊ—œ Õ–› ‘œ", MsgBoxStyle.Information, "")
            FillOutsideDocGrid()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub UiButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton4.Click
        If MsgBox("¬Ì« „ÿ„∆‰ Â” Ìœ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_OutsideDoc1.Update(dg.GetValue("PublicDocId"), txtDocName.Text.Trim, txtDocCode.Text, txtFilePath.Text.Trim, txtRevisionNum.Text, MskReviewDate.Text.Trim, txtsherkat.Text)
            MsgBox("—ﬂÊ—œ ÊÌ—«Ì‘ ‘œ", MsgBoxStyle.Information, "")
            FillOutsideDocGrid()
        Else
            Exit Sub
        End If
    End Sub
End Class