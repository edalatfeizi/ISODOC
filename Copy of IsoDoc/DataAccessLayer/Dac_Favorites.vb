Public Class Dac_Favorites
    Friend Function GetInfo(ByVal UserID As String) As DataTable
        SqlStr = "select * from VwUserFavorites where NetLoginName='" & UserID & "'"
        GetInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Sub Insert(ByVal DocID As Integer, ByVal UserCode As String)
        persist1.Sp_AddParam("@UserID_1", SqlDbType.NChar, UserCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocCode_2", SqlDbType.Int, DocID, ParameterDirection.Input)
        persist1.Sp_Exe("insert_tbIsoUserFavorites", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub Delete(ByVal ID As Integer)
        persist1.Sp_AddParam("@ID_1", SqlDbType.Int, ID, ParameterDirection.Input)
        persist1.Sp_Exe("delete_tbIsoUserFavorites", CnnString, False)
        persist1.ClearParameter()
    End Sub




End Class
