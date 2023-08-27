Public Class Bus_StartegicPlan
    Private Dac_StrategicPlan1 As New Dac_StrategicPlan
    Friend Function getStrategicPlanInfo() As DataTable
        getStrategicPlanInfo = Dac_StrategicPlan1.getStrategicPlanInfo
    End Function
End Class
