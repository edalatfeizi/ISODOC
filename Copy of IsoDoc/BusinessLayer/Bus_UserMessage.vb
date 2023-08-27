Public Class Bus_UserMessage
    Private Dac_UserMessage1 As New Dac_UserMessage
    Friend Function GetInformation(ByVal LogID As String)
        GetInformation = Dac_UserMessage1.GetInformation(LogID)
    End Function
    Friend Sub Insert(ByVal MainDocID As Integer)
        Dac_UserMessage1.MainDocID = MainDocID
        Dac_UserMessage1.Insert()
    End Sub
    Friend Sub Update(ByVal ID As Integer)
        Dac_UserMessage1.ID = ID
        Dac_UserMessage1.Update()
    End Sub
    Friend Sub UpdateAll(ByVal UserID As Integer) '1908 = 1000'
        Dac_UserMessage1.UserID = UserID
        Dac_UserMessage1.UpdateAll()
    End Sub
    Friend Sub DeleteAllsee()
        Dac_UserMessage1.Delete()
    End Sub
End Class
