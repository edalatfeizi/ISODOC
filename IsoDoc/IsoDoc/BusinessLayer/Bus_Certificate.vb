Public Class Bus_Certificate
    Private Dac_Certificate1 As New Dac_Certificate
    Friend Function GetCertificateInfo() As DataTable
        GetCertificateInfo = Dac_Certificate1.GetCertificateInfo
    End Function
End Class
