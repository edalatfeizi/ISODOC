Public Class Dac_UserMessage
    Private mDocMainID As Integer
    Private mUserID As Integer
    Private mID As Integer
    Friend Property MainDocID() As Integer
        Get
            Return mDocMainID
        End Get
        Set(ByVal value As Integer)
            mDocMainID = value
        End Set
    End Property
    Friend Property UserID() As Integer
        Get
            Return mUserID
        End Get
        Set(ByVal value As Integer)
            mUserID = value
        End Set
    End Property
    Friend Property ID() As Integer 'pk in tbuser AU'
        Get
            Return mID
        End Get
        Set(ByVal value As Integer)
            mID = value
        End Set
    End Property


    Friend Sub Insert() 'À»  «ÿ·«⁄«  ÃÂ  ‰„«Ì‘  €ÌÌ—«  »—«Ì ﬂ«—»—«‰'
        persist1.Sp_AddParam("@DocMainID", SqlDbType.Int, MainDocID, ParameterDirection.Input)
        persist1.Sp_AddParam("@CurDate", SqlDbType.Char, Mdate1.GetIrani8Date_CurDate, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_UserMessageIns", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Function GetInformation(ByVal LogID As String)
        SqlStr = "select * from VwIso_ShowUpdateDocForUser where NetLoginName='" & LogID & "'"
        GetInformation = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Sub Update()
        persist1.Sp_AddParam("@ID_1", SqlDbType.Int, ID, ParameterDirection.Input)
        persist1.Sp_AddParam("@ChangeTypeID_2", SqlDbType.Int, 1, ParameterDirection.Input)
        persist1.Sp_Exe("update_tbUserRefresh", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub UpdateAll() 'ÊÌ—«Ì‘ »Ì‘ «“ Ìﬂ ”‰œ'
        persist1.Sp_AddParam("@UserID_1", SqlDbType.Int, UserID, ParameterDirection.Input)
        persist1.Sp_AddParam("@ChangeTypeID_2", SqlDbType.Int, 1, ParameterDirection.Input)
        persist1.Sp_Exe("update_tbUserRefresh_all", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub Delete() 'Õ–› ›«Ì· Â«Ì „‘«ÂœÂ ‘œÂ'
        persist1.Sp_AddParam("@ChangeTypeID_1", SqlDbType.Int, 1, ParameterDirection.Input)
        persist1.Sp_Exe("delete_tbUserRefresh", CnnString, False)
        persist1.ClearParameter()
    End Sub

End Class
