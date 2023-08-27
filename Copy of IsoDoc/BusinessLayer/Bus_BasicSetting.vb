Public Class Bus_BasicSetting
    Private Dac_BasicSetting1 As New Dac_BasicSetting
    Friend Function GetAllUserInfo() As DataTable
        GetAllUserInfo = Dac_BasicSetting1.GetAllUserInfo()
    End Function
    Friend Function GetUserInalarm() As DataTable
        GetUserInalarm = Dac_BasicSetting1.GetAllUserInAlarm
    End Function
    Friend Sub Insert(ByVal UserCode As Integer)
        Dac_BasicSetting1.Insert(UserCode)
    End Sub
    Friend Sub Delete(ByVal UserAppCode As Integer)
        Dac_BasicSetting1.Delete(UserAppCode)
    End Sub
End Class
