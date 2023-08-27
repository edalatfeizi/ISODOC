Public Class Dac_TransferDoc
    Friend Sub Update(ByVal MainID As Integer, ByVal MdepCode As String, ByVal Type As Integer)
        If Type = 0 Then
            persist1.Sp_AddParam("@MainId_1", SqlDbType.Int, MainID, ParameterDirection.Input)
            persist1.Sp_AddParam("@MdepartID_2", SqlDbType.NChar, MdepCode, ParameterDirection.Input)
            persist1.Sp_Exe("Sp_TransferDoc_Upd", CnnString, False)

        ElseIf Type = 1 Then ' Insert 
            persist1.Sp_AddParam("@MainId_1", SqlDbType.Int, MainID, ParameterDirection.Input)
            persist1.Sp_AddParam("@MdepartID_2", SqlDbType.NChar, MdepCode, ParameterDirection.Input)
            persist1.Sp_Exe("Sp_TransferDoc_Copy", CnnString, False)

        End If
        persist1.ClearParameter()
    End Sub
End Class
