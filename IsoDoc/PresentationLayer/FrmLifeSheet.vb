Public Class FrmLifeSheet
    Private DA1 As New SqlClient.SqlDataAdapter
    Private wstr As String
    Dim dt As DataTable
    Private Sub FrmLifeSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend Sub Filldg(ByVal MapID As Integer)
        Dim sqlstr As String = "select * from Archive_New..Vw_LifeSheet where MapID=" & MapID & " "
        dt = persist1.GetDataTable(CnnString, sqlstr)

        Janus1.GetBindJGrid_DT(dt, dgReview, CnnString)
        Janus1.setMyJGrid(dgReview, "MapID", "ﬂœ ‰ﬁ‘Â", 0, , , False)
        Janus1.setMyJGrid(dgReview, "ReviewID", "ReviewID", 0, , , False) 'pk'
        Janus1.setMyJGrid(dgReview, "DoctypeName", "‰Ê⁄ „œ«—ﬂ", 75)
        Janus1.setMyJGrid(dgReview, "ReqNum", "‘„«—Â œ—ŒÊ«” ", 90)
        Janus1.setMyJGrid(dgReview, "SheetTypeTxt", "‰Ê⁄ ‘Ì ", 0, , , False)
        Janus1.setMyJGrid(dgReview, "PanelID", "ﬂœ ﬁÿ⁄Â", 75)
        Janus1.setMyJGrid(dgReview, "PrdPosition1", "ÅÊ“Ì”ÌÊ‰", 80)
        Janus1.setMyJGrid(dgReview, "Requester", "œ—ŒÊ«”  ﬂ‰‰œÂ", 90)
        Janus1.setMyJGrid(dgReview, "OkPerson", " «ÌÌœ ﬂ‰‰œÂ", 90)
        Janus1.setMyJGrid(dgReview, "ChangeDate", " «—ÌŒ  €ÌÌ—", 75)
        Janus1.setMyJGrid(dgReview, "ReviewNum", "‘„«—Â »«“‰ê—Ì", 70)
        Janus1.setMyJGrid(dgReview, "ChangeDesc", "‘—Õ  €ÌÌ—", 150)
        Janus1.setMyJGrid(dgReview, "ChangeReson", "⁄·   €ÌÌ—", 150)
        Janus1.setMyJGrid(dgReview, "FilePath", "FilePath", 0, , , False)
        Janus1.setMyJGrid(dgReview, "DocTypeID", "DocTypeID", 0, , , False)
        Janus1.setMyJGrid(dgReview, "SheetType", "SheetType", 0, , , False)
        Janus1.setMyJGrid(dgReview, "RequesterID", "RequesterID", 0, , , False)
        Janus1.setMyJGrid(dgReview, "OkPersonID", "OkPersonID", 0, , , False)

        ' Janus1.SetGroup(dgReview, "DoctypeName", Janus.Windows.GridEX.GroupMode.Collapsed)
        ' Janus1.SetGroup(dgReview, "PrdPosition1", Janus.Windows.GridEX.GroupMode.Collapsed)
        Janus1.SetGroup(dgReview, "SheetTypeTxt", Janus.Windows.GridEX.GroupMode.Collapsed)

    End Sub
    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = persist1.GetDataAccess(wstr, 1, MdlMain.CnnString, ReportName, dsReports)
            Dim f1 As New FrmReportView
            f1.Show()
        Catch ex As Exception
            MsgBox("Œÿ« œ— ç«Å «ÿ·«⁄« ", MsgBoxStyle.Exclamation, "Crystal Error")
                                               
        End Try

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            wstr = "select * from Archive_New..Vw_LifeSheet where MapID=" & dt.DefaultView.Item(0).Item("MapID") & " "
            rptReports = New RptLifeSheet  'rptIO_EnterObject 
            LastRepName = ReportName
            ReportName = "RptLifeSheet"

            'rptReports.setparametervalue("CurDate", mdate1.GetIrani8DateStr_CurDate)
            'rptReports.setparametervalue("CurDate_Date", mdate1.GetIraniFullDateTime_CurDate)

            Call rptLoad()
        Catch ex As Exception
            MsgBox("»— —ÊÌ ”Ì” „ ‘„« ‰’» ‰„Ì »«‘œ Crystal Report 2005", MsgBoxStyle.Critical, "CrystalReport")
        End Try

    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Me.Close()
    End Sub
End Class