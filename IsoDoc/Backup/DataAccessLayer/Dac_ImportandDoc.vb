Public Class Dac_ImportandDoc
    Private mFilePath As String
    Private mMainID As Integer
    Private mDocTypeID As New Bus_DocType
    Private mDocName As String
    Private mDocCode As String
    Private _DocTypeID As Integer

    Friend Property DocName() As String
        Get
            Return mDocName
        End Get
        Set(ByVal value As String)
            mDocName = value
        End Set
    End Property
    Friend Property DocCode() As String
        Get
            Return mDocCode
        End Get
        Set(ByVal value As String)
            mDocCode = value
        End Set
    End Property
    Friend Property FilePath() As String
        Get
            Return mFilePath
        End Get
        Set(ByVal value As String)
            mFilePath = value
        End Set
    End Property
   
    Friend Property MainID() As Integer
        Get
            Return mMainID
        End Get
        Set(ByVal value As Integer)
            mMainID = value
        End Set
    End Property
    Friend Property DocTypeID() As Integer
        Get
            Return _DocTypeID
        End Get
        Set(ByVal value As Integer)
            _DocTypeID = value
        End Set
    End Property
    Friend Sub InsertCertificate()
        persist1.Sp_AddParam("@CertificateName_1", SqlDbType.VarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@certificatepath_2", SqlDbType.VarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_3", SqlDbType.Int, DocTypeID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISO_Certificate_Ins", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub UpdateCertificate()
        persist1.Sp_AddParam("@certificateId_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_AddParam("@CertificateName_2", SqlDbType.NVarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@certificatepath_3", SqlDbType.NVarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_4", SqlDbType.Int, DocTypeID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISO_Certificate_Upd", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub DeleteCertificate()
        persist1.Sp_AddParam("@certificateId_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISO_Certificate_Del", CnnString, False)
        persist1.ClearParameter()
    End Sub

    Friend Sub InsertStrategicPlan()
        persist1.Sp_AddParam("@DocCode_1", SqlDbType.Char, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocName_2", SqlDbType.NVarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@FilePath_3", SqlDbType.VarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_4", SqlDbType.Int, DocTypeID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISO_StrategicPlan_Ins", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub UpdateStrategicPlan()
        persist1.Sp_AddParam("@StrategicID_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocCode_2", SqlDbType.Char, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocName_3", SqlDbType.NVarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@FilePath_4", SqlDbType.VarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_5", SqlDbType.Int, DocTypeID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISO_StrategicPlan_Upd", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub DeleteStrategicPlan()
        persist1.Sp_AddParam("@StrategicID_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISO_StrategicPlan_Del", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub InsertImportandDoc()
        persist1.Sp_AddParam("@DocCode_1", SqlDbType.NVarChar, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocName_2", SqlDbType.NVarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@FilePath_3", SqlDbType.VarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_4", SqlDbType.Int, DocTypeID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISOImportandDoc_Ins", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub UpdateImportandDoc()
        persist1.Sp_AddParam("@StrategicID_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocCode_2", SqlDbType.NVarChar, DocCode, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocName_3", SqlDbType.NVarChar, DocName, ParameterDirection.Input)
        persist1.Sp_AddParam("@FilePath_4", SqlDbType.VarChar, FilePath, ParameterDirection.Input)
        persist1.Sp_AddParam("@DocTypeID_5", SqlDbType.Int, DocTypeID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISOImportandDoc_Upd", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Sub DeleteImportndDoc()
        persist1.Sp_AddParam("@StrategicID_1", SqlDbType.Int, MainID, ParameterDirection.Input)
        persist1.Sp_Exe("Sp_tbISOImportandDoc_Del", CnnString, False)
        persist1.ClearParameter()
    End Sub
    Friend Function GetImportandDocInfo(ByVal Indx As Integer) As DataTable
        SqlStr = "select * from tbISOImportandDoc where StrategicID=" & Indx
        GetImportandDocInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
    Friend Function GetImportandDocInfo() As DataTable
        SqlStr = "select  StrategicID AS MainID,* from tbISOImportandDoc "
        GetImportandDocInfo = persist1.GetDataTable(CnnString, SqlStr)
    End Function
End Class
