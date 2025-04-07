Public Class FrmMain
    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick

    End Sub

    Private Sub btnShowKartable_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowKartable.ItemClick
        MdlMain.frmManageDocReqs.ShowDialog()

    End Sub
End Class