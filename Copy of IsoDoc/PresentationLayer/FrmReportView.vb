Public Class FrmReportView
    Friend SumKoliDoc As Integer
    Private Sub FrmReportView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        CrystalReportViewer1.DisplayGroupTree = False
        Dim mylogOnInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Try
            rptReports.Database.Tables.Item(0).ApplyLogOnInfo(mylogOnInfo)
            rptReports.SetDataSource(dsReports.Tables(ReportName))

            CrystalReportViewer1.ReportSource = rptReports

            Select Case ReportName

                Case "RptChartKoli"
                    rptReports.setparametervalue("CurDate", Mdate1.GetIraniFullDateTime_CurDate)
                Case "RptStatisticOfDoc"
                    rptReports.setparametervalue("CurDate", Mdate1.GetIraniFullDateTime_CurDate)
                Case "RptChartPerMdep"
                    rptReports.setparametervalue("CurDate", Mdate1.GetIraniFullDateTime_CurDate)
                Case Else
                    rptReports.setparametervalue("CurDate", Mdate1.GetIraniFullDateTime_CurDate)
                    rptReports.setparametervalue("CurDate_Date", Mdate1.GetIraniFullDateTime_CurDate)

            End Select


            CrystalReportViewer1.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class