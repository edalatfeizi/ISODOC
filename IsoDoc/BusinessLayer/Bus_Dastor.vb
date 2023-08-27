Public Class Bus_Dastor
    Inherits Bus_Document
    Private Dac_Document1 As New Dac_Document
    Public Overrides Sub Delete()
        MainID = MainID
        Dac_Document1.Document = Me
        Dac_Document1.Delete()
    End Sub

    Public Overrides Function GetAllInfo() As System.Data.DataTable
        GetAllInfo = Dac_Document1.GetDocumentInfo
    End Function

    Public Overrides Sub Insert()
        DocType.DocTypeID = 4
        MainID = MainID
        FilePath = FilePath
        FileSettingPath = FileSettingPath
        DocCode = DocCode
        DocName = DocName
        HistorySave = HistorySave
        ReviewDate = ReviewDate
        ReviewNum = ReviewNum
        MdepCode = MdepCode
        DocID = DocID
        Dac_Document1.Document = Me
        Dac_Document1.Insert()
    End Sub

    Public Overrides Sub Update()

        MainID = MainID
        FilePath = FilePath
        FileSettingPath = FileSettingPath
        DocCode = DocCode
        DocName = DocName
        HistorySave = HistorySave
        ReviewDate = ReviewDate
        ReviewNum = ReviewNum
        Dac_Document1.Document = Me
        Dac_Document1.Update()
    End Sub
End Class
