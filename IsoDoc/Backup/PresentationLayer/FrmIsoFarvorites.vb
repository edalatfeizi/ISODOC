Public Class FrmIsoFarvorites
    Dim dt As DataTable
    Dim Bus_Favorites1 As New Bus_Favorites
    Dim Cls_JanusGrid1 As New Cls_JanusGrid
    Dim counter As Integer
    Private Sub FrmIsoFarvorites_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub
    Private Sub FillGrid()
        dt = Bus_Favorites1.GetInfo(SystemInformation.UserName)
        If dt.DefaultView.Count > 0 Then
            Me.Text = "���� ����� ���� ���" + " " + dt.DefaultView.Item(0).Item("PrName")
        End If
        Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "ID", "ID", 0, , , False)

        Cls_JanusGrid1.setMyJGrid(dt, dg, "MainId", "MainId", 0, , , False)

        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentCode", "�� ���", 85)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocumentName", "��� ���", 250)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionNo", "����� ������", 75)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "RevisionDate", "����� ������", 75)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocPath", "����� ������", 0, , , False)
        'Cls_JanusGrid1.setMyJGrid(dt, dg, "DocPathNew", "DocPathNew", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocTypeID", "DocTypeID", 0, , , False)


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
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
            If dg.GetValue("DocTypeID") <> 1 Then

                Try
                    Dim e1 As New EventArgs
                    Timer1.Enabled = True
                    Me.Timer1_Tick(Me, e1)
                    System.Diagnostics.Process.Start(LTrim(RTrim(dg.GetValue("DocPath"))))
                Catch ex As Exception
                    MsgBox("������ �� ��� ���� ��� ����� ���� ��� ����", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Bus_Favorites1.Delete(dg.GetValue("ID"))
        FillGrid()
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim e1 As New EventArgs
        Timer1.Enabled = True
        Me.Timer1_Tick(Me, e1)
    End Sub

End Class