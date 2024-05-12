Public Class Dac_BasicSetting
    Friend Function GetAllUserInfo() As DataTable '«”«„Ì «›—«œÌ ﬂÂ ÅÌ€«„ »“«Ì‘«‰ «—”«· ‰„Ì ê—œœ'
        SqlStr = "select * from Vw_ManageUsersForAlarm"
        GetAllUserInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function

    Friend Function GetAllUserInAlarm() As DataTable
        SqlStr = "select * from Vw_IsoUsers" '«”«„Ì «›—«œÌ ﬂÂ ÅÌ€«„ »“«Ì‘«‰ «—”«· „Ì ê—œœ'
        GetAllUserInAlarm = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Sub Insert(ByVal UserCode As Integer)
        persist1.Sp_AddParam("@UserCode_1", SqlDbType.Int, UserCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@AppCode_2", SqlDbType.Int, 2, ParameterDirection.Input)
        persist1.Sp_Exe("insert_tbGen_UserApplication", MdlMain.CnnStringGeneralObject, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub Delete(ByVal UserAppCode As Integer)
        persist1.Sp_AddParam("@UserAppCode_1", SqlDbType.Int, UserAppCode, ParameterDirection.Input)
        persist1.Sp_Exe("delete_tbGen_UserApplication", MdlMain.CnnStringGeneralObject, False)
        persist1.ClearParameter()
    End Sub
End Class
