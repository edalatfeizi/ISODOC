Public Class Bus_TransferDoc
    Private Dac_TransferDoc1 As New Dac_TransferDoc
    Friend Sub Update(ByVal MainID As Integer, ByVal MdepCode As String, ByVal Type As Integer)
        Dac_TransferDoc1.Update(MainID, MdepCode, Type)
    End Sub


End Class
