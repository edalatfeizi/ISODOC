Public Class FrmIsoBasicSetting
    Private Mdepart1 As New Personely.FacadJobClassification.FacMDepart
    Private Bus_DocType1 As New Bus_DocType
    Private Bus_MdepDoc1 As New Bus_MdepDoc
    Private Bus_BasicSetting1 As New Bus_BasicSetting
    Private dt_Mdepart, dt_DocName, dt_regist, dt_NotInalarm, dt_InAlarm As New DataTable
    Private Sub FilldgdMdep()
        Dim str As String
        str = "SELECT  DepartCode as MDepID, MDepart as MDepName FROM  personely.dbo.VwHR_MDepart WHERE  (DepartCode <> N'0')"
        dt_Mdepart = Mdepart1.GetMDepartList
        persist1.SetMyGridStyle = True
        persist1.GetBindGrid_Dt(dgdMdepart, CnnString, dt_Mdepart)
        Dim ts1 As New DataGridTableStyle
        AddRowNumberToGrid(persist1, dt_Mdepart, ts1, dgdMdepart)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Mdepart, dgdMdepart, "MDepID", "ﬂœ", 0, False, False) 'PK'
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_Mdepart, dgdMdepart, "MDepName", "‰«„ Ê«Õœ", 200, False, True)
    End Sub
    Private Sub FilldgdDocName()
        dt_DocName = Bus_DocType1.GetDocNameInfo
        persist1.SetMyGridStyle = True
        persist1.GetBindGrid_Dt(DgdFileName, CnnString, dt_DocName)
        Dim ts1 As New DataGridTableStyle
        AddRowNumberToGrid(persist1, dt_DocName, ts1, DgdFileName)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_DocName, DgdFileName, "DocId", "ﬂœ", 0, False, False) 'PK'
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_DocName, DgdFileName, "DocName", "‰«„ ”‰œ", 200, False, True)
    End Sub
    Private Sub FilldgdRegist()
        dt_regist = Bus_DocType1.GetDocFormName
        dt_regist.DefaultView.RowFilter = "MdepCode='" & dgdMdepart.Item(dgdMdepart.CurrentCell.RowNumber, 1) & "'"
        dt_regist.DefaultView.Sort = "DocName"
        persist1.SetMyGridStyle = True
        persist1.GetBindGrid_Dt(dgdRegist, CnnString, dt_regist)
        Dim ts1 As New DataGridTableStyle
        AddRowNumberToGrid(persist1, dt_regist, ts1, dgdRegist)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_regist, dgdRegist, "RadifId", "ﬂœ", 0, False, False) 'PK'
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_regist, dgdRegist, "DocName", "‰«„ ”‰œ", 200, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_regist, dgdRegist, "MDepName", "‰«„ ”‰œ", 0, False, False)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_regist, dgdRegist, "MdepCode", "‰«„ ”‰œ", 0, False, True)
    End Sub
    Private Sub FilldgdNotInAlarm()
        dt_NotInalarm = Bus_BasicSetting1.GetAllUserInfo
        persist1.SetMyGridStyle = True
        persist1.GetBindGrid_Dt(dgdAllUser, CnnString, dt_NotInalarm)
        Dim ts1 As New DataGridTableStyle
        AddRowNumberToGrid(persist1, dt_NotInalarm, ts1, dgdAllUser)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_NotInalarm, dgdAllUser, "UserCode", "ﬂœ", 0, False, False) 'PK'
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_NotInalarm, dgdAllUser, "PrName", "‰«„", 200, False, True)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_NotInalarm, dgdAllUser, "NetLoginName", "‘‰«”Â ﬂ«—»—Ì", 200, False, False)

    End Sub
    Private Sub FilldgdInAlarm()
        dt_InAlarm = Bus_BasicSetting1.GetUserInalarm
        persist1.SetMyGridStyle = True
        persist1.GetBindGrid_Dt(dgdUserAlarm, CnnString, dt_InAlarm)
        Dim ts1 As New DataGridTableStyle
        AddRowNumberToGrid(persist1, dt_InAlarm, ts1, dgdUserAlarm)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_InAlarm, dgdUserAlarm, "UserAppCode", "UserAppCode", 0, False, False) 'PK'
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_InAlarm, dgdUserAlarm, "UserCode", "ﬂœ", 0, False, False) 'PK'
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_InAlarm, dgdUserAlarm, "PrName", "‰«„", 200, False, True)
        persist1.SetGridStyle_Dt(ts1, Persistent.DataAccess.TxtBol.Text, dt_InAlarm, dgdUserAlarm, "NetLoginName", "‘‰«”Â ﬂ«—»—Ì", 200, False, False)

    End Sub

    Private Sub FrmBasicSetting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        act1.CheckFormControl(27, AppID, Me)
        FilldgdMdep()
        FilldgdDocName()
        FilldgdNotInAlarm()
        FilldgdInAlarm()
    End Sub
    Private Sub dgdMdepart_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdMdepart.CurrentCellChanged
        Try
            FilldgdRegist()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Bus_MdepDoc1.InsertMdepDoc(DgdFileName.Item(DgdFileName.CurrentCell.RowNumber, 1), dgdMdepart.Item(dgdMdepart.CurrentCell.RowNumber, 1))
        FilldgdRegist()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Bus_MdepDoc1.DeleteMdepDoc(dgdRegist.Item(dgdRegist.CurrentCell.RowNumber, 1))
        FilldgdRegist()
    End Sub

   
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Bus_BasicSetting1.Insert(dgdAllUser.Item(dgdAllUser.CurrentCell.RowNumber, 1))
        FilldgdNotInAlarm()
        FilldgdInAlarm()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Bus_BasicSetting1.Delete(dgdUserAlarm.Item(dgdUserAlarm.CurrentCell.RowNumber, 1))
        FilldgdNotInAlarm()
        FilldgdInAlarm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Bus_UserMessage1 As New Bus_UserMessage
        If MsgBox("¬Ì« „«Ì· »Â Õ–› «ÿ·«⁄«  «÷«›Ì Â” Ìœø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Bus_UserMessage1.DeleteAllsee()
            MsgBox("«ÿ·«⁄«  «÷«›Ì Õ–› ‘œ", MsgBoxStyle.Information)
        Else
            Exit Sub
        End If

    End Sub
End Class