Public Class Dac_PostIdentification
    Friend Function GetPostIdnInfo() As DataTable '‘‰«”‰«„Â Å” '
        SqlStr = "select * from VwIso_Documents where DocType=11"
        GetPostIdnInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
