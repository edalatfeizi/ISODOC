Public Class Bus_Important

    Private Dac_ImportandDoc1 As New Dac_ImportandDoc
    Friend Function GetCertificateInfo() As DataTable
        GetCertificateInfo = Dac_ImportandDoc1.GetImportandDocInfo
    End Function

End Class
