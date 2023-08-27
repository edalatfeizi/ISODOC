Public Enum TypeShow
    Certificate = 1
    Strategic = 2
    Important = 3
End Enum

Public Class FrmIsoDocShow
    Private Bus_Certificate1 As New Bus_Certificate
    Private Bus_ImportandDoc1 As New Bus_ImportandDoc
    Private Bus_StartegicPlan1 As New Bus_StartegicPlan
    Private Bus_OthersDoc1 As New Bus_OthersDoc
    Private Bus_OutsideDoc1 As New Bus_OutsideDoc
    Private Bus_Document1 As Bus_Document
    Private Mdepart1 As New Personely.FacadJobClassification.FacMDepart
    Private Bus_DocName1 As New Bus_DocType
    Private dt_Document, dt_Certificate, dt, dt_Other, dt_OutSide, dt_Docname, dt_MDepart, dt_FormDocName As New DataTable
    Private Cls_JanusGrid1 As New Cls_JanusGrid
    Dim counter As Integer
    Dim FilePath As String

    Public TypeShow1 As New TypeShow

    Private Sub FillStrategic()
        dt = Bus_StartegicPlan1.getStrategicPlanInfo

        Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "StrategicID", "ﬂœ", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "MainID", "ﬂœ", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocTypeID", "DocTypeID", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocName", "‰«„ ”‰œ", 600)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocPath", "DocPath", 0, , , False)
    End Sub
    Private Sub FillCertificate()
        dt = Bus_Certificate1.GetCertificateInfo

        Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "MainID", "ﬂœ", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocTypeID", "DocTypeID", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "CertificateName", "‰«„ ”‰œ", 600)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "certificatepath", "certificatepath", 0, , , False)
    End Sub
    Private Sub FillImportant()
        dt = Bus_ImportandDoc1.GetImportandDocInfo

        Cls_JanusGrid1.GetBindJGrid_DT(dt, dg, CnnString)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "StrategicID", "ﬂœ", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "MainID", "ﬂœ", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocTypeID", "DocTypeID", 0, , , False)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocName", "‰«„ ”‰œ", 600)
        Cls_JanusGrid1.setMyJGrid(dt, dg, "DocPathNew", "DocPathNew", 0, , , False)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PicShow.Visible = True
        counter = counter + 1
        If counter = 4 Then

            Try
                ''If Flg = "Certificate" Then
                ''    FilePath = dg.GetValue("certificatepath")
                ''Else
                ''    FilePath = dg.GetValue("FilePath")
                ''End If

                ''System.Diagnostics.Process.Start(LTrim(RTrim(FilePath)))
                If dg.GetValue("DocTypeID") <> 1 Then

                    Try
                        Dim e1 As New EventArgs
                        Timer1.Enabled = True
                        Me.Timer1_Tick(Me, e1)
                        System.Diagnostics.Process.Start(LTrim(RTrim(dg.GetValue("DocPath"))))
                    Catch ex As Exception
                        MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
                    End Try
                    PicShow.Visible = False
                    Timer1.Enabled = False
                    counter = 0
                    Exit Sub

                ElseIf dg.GetValue("DocTypeID") = 1 Then
                    Dim frm As New frmPDF
                    MainId = dg.GetValue("MainID")

                    Select Case TypeShow1
                        Case TypeShow.Certificate
                            frm.pdfStatus = _pdftype.IsCertificate_DOC
                        Case TypeShow.Important
                            frm.pdfStatus = _pdftype.IsImportant_DOC
                        Case TypeShow.Strategic
                            frm.pdfStatus = _pdftype.IsStrategic_DOC

                    End Select

                 
                    frm.ShowDialog()
                    PicShow.Visible = False
                    Timer1.Enabled = False
                    counter = 0
                    Exit Sub

                End If
            Catch ex As Exception
                Dim Bus_MessageHandler1 As New Bus_MessageHandler
                Dim fileType As String
                fileType = Bus_MessageHandler1.GetFileExtension(FilePath.Trim)
                If fileType = "" Then
                    MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
                Else
                    MsgBox("œ«— Ìœ " + fileType + " »—«Ì „‘«ÂœÂ «Ì‰ ”‰œ ‰Ì«“ »Â ‰—„ «›“«—", MsgBoxStyle.Critical)

                End If

            End Try


            PicShow.Visible = False
            Timer1.Enabled = False
            counter = 0
            Exit Sub
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
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmIsoDocShow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim act1 As New Activities.AppActivities("729461sc75halgygb")
        act1.CheckFormControl(27, AppID, Me)
        Select Case TypeShow1
            Case TypeShow.Certificate
                FillCertificate()
            Case TypeShow.Strategic
                FillStrategic()
            Case TypeShow.Important
                FillImportant()
        End Select
   

    End Sub

    Private Sub UiGroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiGroupBox1.Click

    End Sub

    Private Sub dg_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles dg.FormattingRow

    End Sub
End Class