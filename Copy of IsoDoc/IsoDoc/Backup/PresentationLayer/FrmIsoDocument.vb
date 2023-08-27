Public Class FrmIsoDocument
    Private Bus_Certificate1 As New Bus_Certificate
    Private dt_Certificate As New DataTable
    Private Sub FrmIsoDocument_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub
    Private Sub FillGrid()

        dt_Certificate = Bus_Certificate1.GetCertificateInfo
        persist1.SetMyGridStyle = True
        persist1.GetBindGrid_Dt(dgdCertificate, CnnString, dt_Certificate)
        Dim ts1 As New System.Windows.Forms.DataGridTableStyle
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Certificate, dgdCertificate, "certificateId", "ﬂœ", 0, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Certificate, dgdCertificate, "CertificateName", "‰«„ ”‰œ", 600, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Certificate, dgdCertificate, "certificatepath", "„”Ì— ›«Ì·", 0, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Certificate, dgdCertificate, "FileType", "FileType", 0, False, True)
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            FilePath = dgdCertificate.Item(dgdCertificate.CurrentCell.RowNumber, 2)
            System.Diagnostics.Process.Start(LTrim(RTrim(FilePath)))
        Catch ex As Exception
            MsgBox("œ” —”Ì »Â ”‰œ „Ê—œ ‰Ÿ— «„ﬂ«‰ Å–Ì— ‰„Ì »«‘œ", MsgBoxStyle.Information = MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub RadioControl()
select case 
    End Sub
End Class