Public Class Bus_DocType
    Private Dac_Document1 As New Dac_Document
    Private mDocTypeID As Integer
    Private mDocTypeName As String
    Friend Property DocTypeID() As String
        Get
            Return mDocTypeID
        End Get
        Set(ByVal value As String)
            mDocTypeID = value
        End Set
    End Property
   
    Friend Function GetDocFormName() As DataTable
        GetDocFormName = Dac_Document1.GetDocFormName
    End Function
    Friend Function GetDocNameInfo() As DataTable
        GetDocNameInfo = Dac_Document1.GetDocNameInfo()
    End Function
    Friend Function GetDocNameMdepartInfo() As DataTable
        GetDocNameMdepartInfo = Dac_Document1.GetDocNameMdepartInfo
    End Function
End Class
