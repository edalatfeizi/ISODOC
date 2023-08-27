Public Class Dac_StrategicPlan
    Friend Function getStrategicPlanInfo() As DataTable
        SqlStr = "select * from VwIso_StartegicPlan "
        getStrategicPlanInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
