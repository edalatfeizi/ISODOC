Public Class FrmTransfer
    Dim dt_FromMdepart, dt_TOMdepart, dt As DataTable
    Private Dac_Document1 As New Dac_Document
    Private Mdepart1 As New Personely.FacadJobClassification.FacMDepart
    Private Cls_JanusGrid1 As New Cls_JanusGrid
    Private Bus_TransferDoc1 As New Bus_TransferDoc
    Private Sub UiButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton2.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCmb()
    End Sub
    Private Sub FillGrid()
        dt = Dac_Document1.GetDocumentInfo
        dt.DefaultView.RowFilter = "MdepartID='" & CmbFrom.SelectedValue & "'"
        dt.DefaultView.Sort = "MdepartID"
        Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)

        Cls_JanusGrid1.setMyJGrid(dt, dg, "MainId", "MainId", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "MDepName", "‰«„ Ê«Õœ", 100)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentCode", "ﬂœ ”‰œ", 100)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentName", "‰«„ ”‰œ", 250)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 50)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 100)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "HistorySave", "„œ  “„«‰ ‰êÂœ«—Ì", 100)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocPath", "DocPath", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocSettingPath", "DocSettingPath", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "MdepartID", "MdepartID", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocName", "‰Ê⁄ ”‰œ", 0, , , False)
        Cls_JanusGrid1.SetGroup(dg, "DocName")

        'Dim b As New Janus.Windows.GridEX.GridEXTable
        'Dim d As New GridEXColumn

        'd.DataMember = "MDepName"
        'b.DataMember = "MDepName"
        'dg.RootTable.ChildTables.Add(b)
        'b.Columns.Add(d)
        'b.ChildTables.Item(0).Columns.Add(d)


    End Sub
    Private Sub FillCmb()
        Dim str As String
        'dt_FromMdepart = Mdepart1.GetMDepartList
        str = "SELECT  DepartCode as MDepID, MDepart as MDepName FROM  personely.dbo.VwHR_MDepart WHERE  (DepartCode <> N'0')"
        dt_FromMdepart = persist1.GetDataTable(CnnString, str)
        persist1.FillCmb(dt_FromMdepart, CmbFrom, "MDepID", "MDepName")

        'dt_TOMdepart = Mdepart1.GetMDepartList
        str = "SELECT  DepartCode as MDepID, MDepart as MDepName FROM  personely.dbo.VwHR_MDepart WHERE  (DepartCode <> N'0')"

        dt_TOMdepart = persist1.GetDataTable(CnnString, str)
        persist1.FillCmb(dt_TOMdepart, CmbTo, "MDepID", "MDepName")

    End Sub

    Private Sub CmbFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFrom.SelectedIndexChanged

    End Sub

    Private Sub CmbFrom_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbFrom.SelectedValueChanged
        Try
            FillGrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Try
            If MsgBox("¬Ì« „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Bus_TransferDoc1.Update(dg.GetValue("MainId"), CmbTo.SelectedValue, 0)
                FillGrid()
                MsgBox("«ÿ·«⁄«  ÊÌ—«Ì‘ ‘œ", MsgBoxStyle.Information)
            Else
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox("Œÿ« œ— À»  «ÿ·«⁄« ", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            If MsgBox("¬Ì« „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Bus_TransferDoc1.Update(dg.GetValue("MainId"), CmbTo.SelectedValue, 1)
                FillGrid()
                MsgBox("«ÿ·«⁄«  ÊÌ—«Ì‘ ‘œ", MsgBoxStyle.Information)
            Else
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox("Œÿ« œ— À»  «ÿ·«⁄« ", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub UiGroupBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiGroupBox3.Click

    End Sub
End Class