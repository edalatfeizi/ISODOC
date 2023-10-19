Imports CrystalDecisions.ReportAppServer

Public Class Frm_SetAccessForViewDoc

    Private Sub Frm_SetAccessForViewDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Search()
        filldg()
    End Sub
    Private Sub Search()
        '  If (Txt_search.Text.Length > 0) Then
        SqlStr = "select * from Personely.[dbo].Vw_AllPersonWithDepartName  where LastName like '%" & Txt_search.Text & "%' AND (NOT (PersonCode IN (SELECT PersonCode FROM  dbo.Vw_ShowPersonSelectedData   WHERE        (DocumentCode = '" & DocumentCode & "'))))   or CAST( personcode as nvarchar(50) ) ='" & Txt_search.Text & "' AND (NOT (PersonCode IN (SELECT PersonCode FROM  dbo.Vw_ShowPersonSelectedData  WHERE        (DocumentCode = '" & DocumentCode & "'))))  or CAST( CardNumber as nvarchar(50) ) ='" & Txt_search.Text & "' AND (NOT (PersonCode IN (SELECT PersonCode FROM  dbo.Vw_ShowPersonSelectedData AS Vw_SelectPersonRecord_5 WHERE        (DocumentCode = '" & DocumentCode & "'))))  Or LastName Like N'%" & Txt_search.Text & "%' AND (NOT (PersonCode IN (SELECT PersonCode FROM  dbo.Vw_ShowPersonSelectedData AS Vw_SelectPersonRecord_5 WHERE        (DocumentCode = '" & DocumentCode & "'))))  "


        dt = persist1.GetDataTable(CnnString, SqlStr)

        GrdMain.DataSource = dt

        'End If

    End Sub
    Private Sub filldg()

        SqlStr = "select * from Personely.[dbo].Vw_AllPersonWithDepartName  "

        dt = persist1.GetDataTable(CnnString, SqlStr)
        GrdMain.DataSource = dt

        SqlStr = "select * from Vw_ShowPersonSelectedData  where DocumentCode ='" & DocumentCode & "'"

        dt = persist1.GetDataTable(CnnString, SqlStr)
        GrdSelectedPerson.DataSource = dt
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        SqlStr = "insert into tb_PersonAccessForViewDocument(PersonCode,DocumentCode ) values('" & GrdMain.GetValue("personcode") & "','" & DocumentCode & "')"
        persist1.ExecuteNoneQuery(SqlStr, CnnString)
        filldg()
    End Sub

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        SqlStr = "delete from tb_PersonAccessForViewDocument where PersonCode='" & GrdSelectedPerson.GetValue("personcode") & "' "
        persist1.ExecuteNoneQuery(SqlStr, CnnString)
        filldg()
    End Sub
    Private Sub Searchselectedperson()
        '  If (Txt_search.Text.Length > 0) Then
        SqlStr = "select * from tb_PersonAccessForViewDocument  where LastName like '%" & Txt_searchSelectedPerson.Text & "%'  and DocumentCode='" & DocumentCode & "' or CAST( personcode as nvarchar(50) ) ='" & Txt_searchSelectedPerson.Text & "'  and DocumentCode='" & DocumentCode & "' or CAST( CardNumber as nvarchar(50) ) ='" & Txt_searchSelectedPerson.Text & "'   and DocumentCode='" & DocumentCode & "' Or LastName Like N'%" & Txt_searchSelectedPerson.Text & "%' and DocumentCode='" & DocumentCode & "' or CAST( personcode as nvarchar(50) ) ='" & Txt_searchSelectedPerson.Text & "' and DocumentCode='" & DocumentCode & "' or CAST( CardNumber as nvarchar(50) ) ='" & Txt_searchSelectedPerson.Text & "' and DocumentCode='" & DocumentCode & "'"
        dt = persist1.GetDataTable(CnnString, SqlStr)
        GrdSelectedPerson.DataSource = dt

        'End If

    End Sub

    Private Sub Txt_searchSelectedPerson_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_searchSelectedPerson.KeyUp
        Searchselectedperson()
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Search()
    End Sub

    Private Sub Txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search.KeyPress
        If e.KeyChar = Chr(13) Then
            Btn_Search_Click(e, e)

        End If
    End Sub
End Class