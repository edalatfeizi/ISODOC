Public Class Bus_MdepDoc
    Private Dac_MdepDoc1 As New Dac_MdepDoc
    Friend Sub InsertMdepDoc(ByVal DocTypeID As Integer, ByVal MdepCode As String)
        Dac_MdepDoc1.InsertDocName(DocTypeID, MdepCode)
    End Sub
    Friend Sub DeleteMdepDoc(ByVal MainID As Integer)
        Dac_MdepDoc1.DeleteDocName(MainID)
    End Sub
End Class
