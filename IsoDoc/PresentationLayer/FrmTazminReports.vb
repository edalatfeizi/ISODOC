Public Class FrmTazminReports
    Friend CnnString As String = MdlMain.CnnString
    Dim dr As SqlClient.SqlDataReader
    Dim CntOdPos As Integer

    Private Sub FrmTazminReports_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub FrmTazminReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MskToDate.Text = ""
        MskFromDate.Text = ""
    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        SqlStr = _
           "SELECT     fnTazminKeyfiyatReport.* " & _
           "FROM         dbo.fnTazminKeyfiyatReport('" & MskFromDate.Text & "', '" & MskToDate.Text & "') fnTazminKeyfiyatReport"
        persist1.OpenRecordSet(dr, SqlStr, MdlMain.CnnStringProduction)
        dr.Read()
        CntOdPos = dr("PosCount")
        lblCntOfDie.Text = dr("CountOfDie")
        lblCntOfPMDie.Text = dr("pmCount")
        lblCountOfRepair.Text = dr("CountOfRepair")
        ' ''lblAverageOfPM.Text = CInt((lblCntOfPMDie.Text / lblCntOfDie.Text))
        Dim a As String
        a = Str((lblCntOfPMDie.Text / lblCntOfDie.Text))
        lblAverageOfPM.Text = Mid(a, 1, 4)

        lblSaraneSodorDarkhast.Text = CInt((lblCountOfRepair.Text / CntOdPos))
        lblDStop.Text = DStop()
        lblAvgStop.Text = CInt(lblDStop.Text / CntOdPos)
    End Sub

    Private Function DStop() As Integer
        Dim dr1 As SqlClient.SqlDataReader
        Dim SumStops As Integer
        SqlStr = _
           "SELECT     SUM(DStop) AS DStop, 'Hand' AS type " & _
           "FROM         dbo.fnPLN_ProdMontlyStops_HND_Rpt('" & MskFromDate.Text & "', '" & MskToDate.Text & "') fnPLN_ProdMontlyStops_HND_Rpt " & _
           "UNION " & _
           "SELECT     SUM(DStop) AS Expr1, 'Mechanize' AS type " & _
           "FROM         dbo.fnPLN_ProdMontlyStops_PS_Rpt('" & MskFromDate.Text & "', '" & MskToDate.Text & "') fnPLN_ProdMontlyStops_PS_Rpt"
        persist1.OpenRecordSet(dr1, SqlStr, MdlMain.CnnStringProduction)

        While dr1.Read
            SumStops += dr1("DStop")
            'dr1.NextResult()
        End While

        dr1.Close()
        Return SumStops
    End Function

    Private Sub btnCalculateTrainning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateTrainning.Click
        Dim dt As New DataTable
        Dim sqlstr As String
        Dim cn As String
        cn = MdlMain.CnnStringTraining
        ''''ÈÑÒÇÑ ÔÏå åÇ
        sqlstr = _
        "SELECT     COUNT(dbo.tbTRNCrsLocation.InstituteID) AS dd " & _
        "FROM         dbo.tbTRNCrsLocation INNER JOIN " & _
        "                      dbo.tbTRNCourse ON dbo.tbTRNCrsLocation.CourseID = dbo.tbTRNCourse.CourseID INNER JOIN " & _
        "                      dbo.tbTRNCLStatus ON dbo.tbTRNCrsLocation.CLStatusID = dbo.tbTRNCLStatus.CLStatusID " & _
        "WHERE     (dbo.tbTRNCrsLocation.BeginDate BETWEEN '" & MskFromDate.Text.Trim & "' AND '" & MskToDate.Text.Trim & "') AND (dbo.tbTRNCLStatus.CLStatusID = 4)"

        dt = persist1.GetDataTable(cn, sqlstr)
        lblBargozarShode.Text = dt.DefaultView.Item(0).Item("dd")
        sqlstr = ""
        dt.Rows.Clear()
        ''''ÏÑ ÍÇá ÇÌÑÇ
        sqlstr = _
        "SELECT     COUNT(dbo.tbTRNCrsLocation.InstituteID) AS dd " & _
        "FROM         dbo.tbTRNCrsLocation INNER JOIN " & _
        "                      dbo.tbTRNCourse ON dbo.tbTRNCrsLocation.CourseID = dbo.tbTRNCourse.CourseID INNER JOIN " & _
        "                      dbo.tbTRNCLStatus ON dbo.tbTRNCrsLocation.CLStatusID = dbo.tbTRNCLStatus.CLStatusID " & _
        "WHERE     (dbo.tbTRNCrsLocation.BeginDate BETWEEN '" & MskFromDate.Text.Trim & "' AND '" & MskToDate.Text.Trim & "') AND (dbo.tbTRNCLStatus.CLStatusID = 2)"

        dt = persist1.GetDataTable(cn, sqlstr)
        lblDarHaleEjra.Text = dt.DefaultView.Item(0).Item("dd")
        sqlstr = ""
        dt.Rows.Clear()
        ''''ÂãÇÏå ÈÑÒÇÑí
        sqlstr = _
        "SELECT     COUNT(dbo.tbTRNCrsLocation.InstituteID) AS dd " & _
        "FROM         dbo.tbTRNCrsLocation INNER JOIN " & _
        "                      dbo.tbTRNCourse ON dbo.tbTRNCrsLocation.CourseID = dbo.tbTRNCourse.CourseID INNER JOIN " & _
        "                      dbo.tbTRNCLStatus ON dbo.tbTRNCrsLocation.CLStatusID = dbo.tbTRNCLStatus.CLStatusID " & _
        "WHERE     (dbo.tbTRNCrsLocation.BeginDate BETWEEN '" & MskFromDate.Text.Trim & "' AND '" & MskToDate.Text.Trim & "') AND (dbo.tbTRNCLStatus.CLStatusID = 1)"

        dt = persist1.GetDataTable(cn, sqlstr)
        lblDarAmadeBargozari.Text = dt.DefaultView.Item(0).Item("dd")
        sqlstr = ""
        dt.Rows.Clear()
        ''''ÈÑÒÇÑ äÔÏå)áÛæ ãæÓÓå(
        sqlstr = _
        "SELECT     COUNT(dbo.tbTRNCrsLocation.InstituteID) AS dd " & _
        "FROM         dbo.tbTRNCrsLocation INNER JOIN " & _
        "                      dbo.tbTRNCourse ON dbo.tbTRNCrsLocation.CourseID = dbo.tbTRNCourse.CourseID INNER JOIN " & _
        "                      dbo.tbTRNCLStatus ON dbo.tbTRNCrsLocation.CLStatusID = dbo.tbTRNCLStatus.CLStatusID " & _
        "WHERE     (dbo.tbTRNCrsLocation.BeginDate BETWEEN '" & MskFromDate.Text.Trim & "' AND '" & MskToDate.Text.Trim & "') AND (dbo.tbTRNCLStatus.CLStatusID = 3)"

        dt = persist1.GetDataTable(cn, sqlstr)
        lblBargozarNashode.Text = dt.DefaultView.Item(0).Item("dd")
        sqlstr = ""
        dt.Rows.Clear()
        '''' ÊÚÏÇÏ äÝÑÇÊ  ÏÑ ÍÇá ÂãæÒÔ
        sqlstr = _
        "SELECT     COUNT(PersonID) AS dd " & _
        "FROM         vwTR_rptTazminKeifiiat " & _
        "WHERE     (CLStatusID = 2) " & _
        "     and      (BeginDate BETWEEN '" & MskFromDate.Text.Trim & "' AND  '" & MskToDate.Text.Trim & "')"
        dt = persist1.GetDataTable(cn, sqlstr)
        lblCountPersonDarHalAmooozesh.Text = dt.DefaultView.Item(0).Item("dd")
        sqlstr = ""
        dt.Rows.Clear()
        '''' ÊÚÏÇÏ äÝÑÇÊ ÂãæÒÔ ÏíÏå ÇíÇä ÂãæÒÔ ÔÏå
        sqlstr = _
        "SELECT     COUNT(PersonID) AS dd " & _
        "FROM         vwTR_rptTazminKeifiiat " & _
        "WHERE     (CLStatusID = 4) " & _
        "     AND (BeginDate BETWEEN '" & MskFromDate.Text.Trim & "' AND  '" & MskToDate.Text.Trim & "')"
        dt = persist1.GetDataTable(cn, sqlstr)
        lblCountPersonPaianAmooozesh.Text = dt.DefaultView.Item(0).Item("dd")
        sqlstr = ""
        dt.Rows.Clear()

    End Sub

    Private Sub btnArz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArz.Click

        If MskFromDate.Text.Trim = "" Or MskFromDate.Text.Trim = "" Then
            MsgBox("ÊÇÑíÎ ÑÇ æÇÑÏ äãÇííÏ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            Dim dt As New DataTable
            wstr = "select    SubConName, ActionName, StartDate, ExpDate, GetScore, GradeTxt from Contract.dbo.Vw_SupGrade where (StartDate>='" & MskFromDate.Text & "' and StartDate<='" & MskToDate.Text & "') "
            dt = persist1.GetDataTable(CnnString, wstr)
            utility1.ExportTo(dt, IKIDUtility.ExportType.Excel)
        End If

    End Sub

    Private Sub btnFactor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactor.Click
        If MskFromDate.Text.Trim = "" Or MskFromDate.Text.Trim = "" Then
            MsgBox("ÊÇÑíÎ ÑÇ æÇÑÏ äãÇííÏ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            Dim dt_Forosh As New DataTable

            wstr = _
            "SELECT     COUNT(CustomerID) AS Count, CustomTxt " & _
            "FROM        Sales_New.dbo.Vw_Report_CountFactor " & _
            "WHERE     (FactorDate >= '" & MskFromDate.Text & "') " & _
            "AND (FactorDate <= '" & MskToDate.Text & "') GROUP BY CustomTxt"
            dt_Forosh = persist1.GetDataTable(CnnString, wstr)
            utility1.ExportTo(dt_Forosh, IKIDUtility.ExportType.Excel)
        End If
    End Sub
End Class