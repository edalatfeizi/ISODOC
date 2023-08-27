Public Class FrmIsoOtherDoc
    Public Flg As String
    Dim counter As Integer
    Dim dt As DataTable
    Private Bus_OthersDoc1 As New Bus_OthersDoc
    Private Bus_OutsideDoc1 As New Bus_OutsideDoc
    Private Cls_JanusGrid1 As New Cls_JanusGrid
    
    Private Sub FilldgdOtherDoc()
        dt = Bus_OthersDoc1.GetOthersDocInfo
        Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "PublicDocCode", "ﬂœ ”‰œ", 100)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "PublicDocName", "‰«„ ”‰œ", 250)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 100)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 200)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "PublicDocPath", "PublicDocPath", 0, , , False)

        'persist1.SetMyGridStyle = True
        'persist1.GetBindGrid_Dt(dgdother, CnnString, dt_Other)
        'Dim tbs1 As New DataGridTableStyle
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_Other, dgdother, "PublicDocId", "ﬂœ", 0, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_Other, dgdother, "PublicDocCode", "‘„«—Â ”‰œ", 75, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_Other, dgdother, "PublicDocName", "‰«„ ”‰œ", 600, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_Other, dgdother, "PublicDocPath", "„”Ì— ›«Ì·", 0, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_Other, dgdother, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 75, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_Other, dgdother, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 75, False, True)
    End Sub
    Private Sub FilldgdOutSide()
        dt = Bus_OutsideDoc1.GetOutSideDoc
        Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "PublicDocCode", "ﬂœ ”‰œ", 85)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "PublicDocName", "‰«„ ”‰œ", 600)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "sherkatname", "‰«„ ‘—ò ", 200)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 100)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionDate", " «—ÌŒ À» ", 100)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "PublicDocPath", "PublicDocPath", 0, , , False)
        'persist1.SetMyGridStyle = True
        'persist1.GetBindGrid_Dt(dgdOutSise, CnnString, dt_OutSide)
        'Dim tbs1 As New DataGridTableStyle
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_OutSide, dgdOutSise, "PublicDocId", "ﬂœ", 0, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_OutSide, dgdOutSise, "PublicDocCode", "‘„«—Â ”‰œ", 75, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_OutSide, dgdOutSise, "PublicDocName", "‰«„ ”‰œ", 600, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_OutSide, dgdOutSise, "PublicDocPath", "„”Ì— ›«Ì·", 0, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_OutSide, dgdOutSise, "RevisionNo", "‘„«—Â »«“‰ê—Ì", 75, False, False)
        'persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dt_OutSide, dgdOutSise, "RevisionDate", " «—ÌŒ »«“‰ê—Ì", 75, False, True)

    End Sub
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PicShow.Visible = True
        counter = counter + 1
        If counter = 4 Then
            Try
                Dim e1 As New EventArgs
                Timer1.Enabled = True
                Me.Timer1_Tick(Me, e1)
                lblFilePath.Text = dg.GetValue("PublicDocPath")
                System.Diagnostics.Process.Start(LTrim(RTrim(lblFilePath.Text)))
            Catch ex As Exception
                MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
            End Try
            PicShow.Visible = False
            Timer1.Enabled = False
            counter = 0
            Exit Sub
        End If
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmIsoOtherDoc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Flg = "OtherDoc" Then
            FilldgdOtherDoc()
        Else
            FilldgdOutSide()
        End If
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click

    End Sub

End Class