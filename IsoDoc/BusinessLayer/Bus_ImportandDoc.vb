Public Class Bus_ImportandDoc
    Private Dac_ImportandDoc1 As New Dac_ImportandDoc

    Friend Sub Insert(ByVal DocCode As String, ByVal DocName As String, ByVal FilePath As String, ByVal Flg As String, ByVal DocTypeID As Integer)
        Dac_ImportandDoc1.DocCode = DocCode
        Dac_ImportandDoc1.DocName = DocName
        Dac_ImportandDoc1.FilePath = FilePath
        Dac_ImportandDoc1.DocTypeID = DocTypeID
        If Flg = "Certificate" Then
            Dac_ImportandDoc1.InsertCertificate()
        ElseIf Flg = "Strategic" Then
            Dac_ImportandDoc1.InsertStrategicPlan()
        ElseIf Flg = "ImportandDoc" Then
            Dac_ImportandDoc1.InsertImportandDoc()
        End If

    End Sub
    Friend Sub Update(ByVal MainID As Integer, ByVal DocCode As String, ByVal DocName As String, ByVal FilePath As String, ByVal Flg As String, ByVal DocTypeID As Integer)
        Dac_ImportandDoc1.DocCode = DocCode
        Dac_ImportandDoc1.DocName = DocName
        Dac_ImportandDoc1.FilePath = FilePath
        Dac_ImportandDoc1.MainID = MainID
        Dac_ImportandDoc1.DocTypeID = DocTypeID
        If Flg = "Certificate" Then
            Dac_ImportandDoc1.UpdateCertificate()
        ElseIf Flg = "Strategic" Then
            Dac_ImportandDoc1.UpdateStrategicPlan()
        ElseIf Flg = "ImportandDoc" Then
            Dac_ImportandDoc1.UpdateImportandDoc()
        End If
    End Sub
    Friend Sub Delete(ByVal MainID As Integer, ByVal Flg As String)
        Dac_ImportandDoc1.MainID = MainID
        If Flg = "Certificate" Then
            Dac_ImportandDoc1.DeleteCertificate()
        ElseIf Flg = "Strategic" Then
            Dac_ImportandDoc1.DeleteStrategicPlan()
        ElseIf Flg = "ImportandDoc" Then
            Dac_ImportandDoc1.DeleteImportndDoc()
        End If
    End Sub

    Friend Function GetImportandDocInfo(ByVal Indx As Integer) As DataTable
        GetImportandDocInfo = Dac_ImportandDoc1.GetImportandDocInfo(Indx)
    End Function
    Friend Function GetImportandDocInfo() As DataTable
        GetImportandDocInfo = Dac_ImportandDoc1.GetImportandDocInfo()
    End Function
End Class
