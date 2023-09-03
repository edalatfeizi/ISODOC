Public Class Dac_MdepDoc
    Friend Sub InsertDocName(ByVal DocTypeID As Integer, ByVal MdepCode As String)
        persist1.Sp_AddParam("@MdepCode_1", SqlDbType.NVarChar, MdepCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocCode_2", SqlDbType.Int, DocTypeID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISOMdepDocument_Ins", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub DeleteDocName(ByVal MainID As Integer)
        persist1.Sp_AddParam("@RadifId_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISOMdepDocument_Del", CnnString, False)
        persist1.ClearParameter()
    End Sub
End Class
