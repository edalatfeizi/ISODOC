Public Class Bus_OthersDoc
    Private Dac_Document1 As New Dac_Document
    Private Dac_OthersDoc1 As New Dac_OthersDoc

    Friend Sub insert(ByVal DocCode As String, ByVal DocName As String, ByVal FilePath As String, ByVal FileSettingPath As String, ByVal HistorySave As String, ByVal ReviewDate As String, ByVal ReviewNum As Integer, ByVal docTypeID As Integer, ByVal MdepCode As String, ByVal DocID As Integer)
        Dac_OthersDoc1.DocCode = DocCode
        Dac_OthersDoc1.DocName = DocName
        Dac_OthersDoc1.FilePath = FilePath
        Dac_OthersDoc1.FileSettingPath = FileSettingPath
        Dac_OthersDoc1.HistorySave = HistorySave
        Dac_OthersDoc1.ReviewDate = ReviewDate
        Dac_OthersDoc1.ReviewNum = ReviewNum
        Dac_OthersDoc1.MdepCode = MdepCode
        Dac_OthersDoc1.DocType.DocTypeID = docTypeID
        Dac_OthersDoc1.DocID = DocID
        Dac_OthersDoc1.Insert()
    End Sub
    Friend Sub update(ByVal MainID As Integer, ByVal DocCode As String, ByVal DocName As String, ByVal FilePath As String, ByVal FileSettingPath As String, ByVal HistorySave As String, ByVal ReviewDate As String, ByVal ReviewNum As Integer, ByVal MdepCode As String)
        Dac_OthersDoc1.MainID = MainID
        Dac_OthersDoc1.DocCode = DocCode
        Dac_OthersDoc1.DocName = DocName
        Dac_OthersDoc1.FilePath = FilePath
        Dac_OthersDoc1.FileSettingPath = FileSettingPath
        Dac_OthersDoc1.HistorySave = HistorySave
        Dac_OthersDoc1.ReviewDate = ReviewDate
        Dac_OthersDoc1.MdepCode = MdepCode
        Dac_OthersDoc1.ReviewNum = ReviewNum

        Dac_OthersDoc1.Update()
    End Sub
    Friend Sub Delete(ByVal MainID As Integer)
        Dac_OthersDoc1.MainID = MainID
        Dac_OthersDoc1.Delete()
    End Sub
    Friend Function GetOthersDocInfo() As DataTable
        GetOthersDocInfo = Dac_OthersDoc1.GetOthersDocInfo
    End Function
    Friend Function GetDocumentInfo() As DataTable
        GetDocumentInfo = Dac_Document1.GetDocumentInfo
    End Function

End Class
