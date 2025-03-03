using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Infrastructure.Repositories
{
    public class ManageDocReqRepository : IManageDocReqsRepository
    {
        private readonly IDbConnection connection;
        private readonly string baseEntityInsertProps = "CreatedBy,ModifiedBy,CreatedAt,ModifiedAt,Active";
        private readonly string baseEntityInsertPropsValues = "@CreatedBy,@ModifiedBy,@CreatedAt,@ModifiedAt,@Active";
        public ManageDocReqRepository(IDbConnection dbConnection)
        {
            connection = dbConnection;
            //connection = new SqlConnection("Data Source=sqlsrv;Initial Catalog=Isodoc_New;User Id=samane;Password=#@Samane1367!#;Encrypt=False;");
        }

        public async Task<DocRequestStep> AddNewDocRequestStepAsync(DocRequestStep docRequestStep)
        {
            try
            {
                
                connection.Open();
                var docRequestStepQuery = $@"
                    INSERT INTO DocRequestSteps (DocRequestId, SenderUserPersonCode, SenderUserFullName, SenderUserPost, ReceiverUserPersonCode, ReceiverUserFullName, ReceiverUserPost, Description, IsApproved, {baseEntityInsertProps})
                    OUTPUT INSERTED.Id
                    VALUES (@DocRequestId, @SenderUserPersonCode, @SenderUserFullName, @SenderUserPost, @ReceiverUserPersonCode, @ReceiverUserFullName, @ReceiverUserPost, @Description, @IsApproved, {baseEntityInsertPropsValues});";


                var newDocReqStepId = await connection.QuerySingleAsync<int>(docRequestStepQuery, docRequestStep);
                connection.Close();
                docRequestStep.Id = newDocReqStepId;
                return docRequestStep;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
          
        }

        public async Task<DocRequestAttachment> AttachFileAsync(DocRequestAttachment docRequestAttachment)
        {
            try
            {
                connection.Open();
                var docRequestAttachmentQuery = $@"
                    INSERT INTO DocRequestAttachments (DocRequestId, Name, ContentType, FileContent, Size, {baseEntityInsertProps})
                    OUTPUT INSERTED.Id
                    VALUES (@DocRequestId, @Name, @ContentType, @FileContent, @Size, {baseEntityInsertPropsValues});";


                var newDocReqAttachmentId = await connection.QuerySingleAsync<int>(docRequestAttachmentQuery, docRequestAttachment);
                connection.Close();
                docRequestAttachment.Id = newDocReqAttachmentId;
                return docRequestAttachment;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
  
        }

        public async Task<DocRequest> CreateNewDocRequest(DocRequest docRequest)
        {
            try
            {
                connection.Open();
                var docRequestsQuery = $@"
                    INSERT INTO DocRequests (DocOwnerDep, DocCode, Title, KeepDuration, ChangeSummary, CreateReason, DocRequestType, DocType, CreatorDep, {baseEntityInsertProps})
                    OUTPUT INSERTED.Id
                    VALUES (@DocOwnerDep, @DocCode, @Title, @KeepDuration, @ChangeSummary, @CreateReason, @DocRequestType, @DocType, @CreatorDep, {baseEntityInsertPropsValues});";


                var newDocReqId = await connection.QuerySingleAsync<int>(docRequestsQuery, docRequest);
                connection.Close();
                docRequest.Id = newDocReqId;
                return docRequest;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }



        }



        public async Task<List<DocRequest>> GetAll()
        {
            try
            {
                connection.Open();
                var docRequestsQuery = "select * from DocRequests";

                var docRequests = await connection.QueryAsync<DocRequest>(docRequestsQuery);
                connection.Close();
                return docRequests.ToList();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
      
        }

        public async Task<List<DocType>> GetDocTypes()
        {
            try
            {
                connection.Open();
                var docTypesQuery = "select DocId,DocName,KeepDurationRequired from tbISODocName";

                var docTypes = await connection.QueryAsync<DocType>(docTypesQuery);
                connection.Close();
                return docTypes.ToList();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public async Task<List<Document>> GetDocuments(string depCode)
        {
            try
            {
                connection.Open();
                var documentsQuery = $"select DISTINCT ROW_NUMBER() OVER (ORDER BY MainId) AS RowNumber, MainId as DocId, DocumentName, DocumentCode, DocName, HistorySave from VwIso_Documents where MdepartID = '{depCode}'";
                Console.WriteLine(documentsQuery);
                var documents = await connection.QueryAsync<Document>(documentsQuery);
                connection.Close();
                return documents.ToList();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        
        }


        public async Task<int> GetLastDocReqId()
        {
            try
            {
                connection.Open();
                var maxDocReqIdQuery = "select MAX(Id) as MaxReqId from DocRequests";

                var maxDocReqId = await connection.QueryAsync<int>(maxDocReqIdQuery);
                connection.Close();
                return maxDocReqId.First();
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex);
            }
            return 0;
        }
    }
}
