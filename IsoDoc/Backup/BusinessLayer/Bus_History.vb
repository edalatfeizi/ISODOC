Public Class Bus_History
    Dim Dac_History1 As New Dac_History
    Friend Function GetHistoryInfo() As DataTable
        GetHistoryInfo = Dac_History1.GetHistoryInfo
    End Function
    Friend Sub InsertHistory(ByVal DocID As Integer, ByVal DocName As String, ByVal DocCode As String, ByVal ReviewNum As Integer, ByVal ReviewDate As String, ByVal FilePath As String, ByVal DocTypeID As Integer, ByVal DateHist As String)
        Dac_History1.DocID = DocID
        Dac_History1.DocName = DocName
        Dac_History1.DocCode = DocCode
        Dac_History1.ReviewNum = ReviewNum
        Dac_History1.ReviewDate = ReviewDate
        Dac_History1.FilePath = FilePath
        Dac_History1.DateHist = DateHist
        Dac_History1.DocType.DocTypeID = DocTypeID
        Dac_History1.Insert()
    End Sub
End Class
