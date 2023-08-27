Public Class Bus_OutsideDoc
    Private Bus_OutsideDoc1 As New Dac_OutsideDoc
    Friend Function GetOutSideDoc() As DataTable
        GetOutSideDoc = Bus_OutsideDoc1.GetOutSideDoc
    End Function
    Friend Sub Insert(ByVal DocName As String, ByVal DocCode As String, ByVal DocPath As String, ByVal ReviewNum As String, ByVal ReviewDate As String, ByVal sherkatname As String)
        Bus_OutsideDoc1.Insert(DocName, DocCode, DocPath, ReviewNum, ReviewDate, sherkatname)
    End Sub
    Friend Sub Update(ByVal Id As Integer, ByVal DocName As String, ByVal DocCode As String, ByVal DocPath As String, ByVal ReviewNum As String, ByVal ReviewDate As String, ByVal sherkatname As String)
        Bus_OutsideDoc1.Update(Id, DocName, DocCode, DocPath, ReviewNum, ReviewDate, sherkatname)
    End Sub
    Friend Sub Delete(ByVal Id As Integer)
        Bus_OutsideDoc1.Delete(Id)
    End Sub
End Class
