Public Class Bus_Favorites
    Dim Dac_Favorites1 As New Dac_Favorites
    Friend Function GetInfo(ByVal UserID As String) As DataTable
        GetInfo = Dac_Favorites1.GetInfo(UserID)
    End Function
    Friend Sub Insert(ByVal DocID As Integer, ByVal UserCode As String)
        Dac_Favorites1.Insert(DocID, UserCode.Trim)
    End Sub
    Friend Sub Delete(ByVal ID As Integer)
        Dac_Favorites1.Delete(ID)
    End Sub
End Class
