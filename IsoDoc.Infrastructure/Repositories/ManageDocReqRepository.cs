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
                    INSERT INTO DocRequests (DocId, DocOwnerDep, DocCode, Title, KeepDuration, ChangeSummary, CreateReason, DocRequestType,DocRequestStatus, DocType, CreatorDep, {baseEntityInsertProps})
                    OUTPUT INSERTED.Id
                    VALUES (@DocId, @DocOwnerDep, @DocCode, @Title, @KeepDuration, @ChangeSummary, @CreateReason, @DocRequestType,@DocRequestStatus, @DocType, @CreatorDep, {baseEntityInsertPropsValues});";


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

        public async Task<bool> SetDocRequestActive(int docReqId, string deleteDesc,bool isActive)
        {
            try
            {
                connection.Open();

                var updateQuery = @$"
                                    UPDATE DocRequests
                                        SET Active = @Active, deleteDesc = @DeleteDesc
                                        WHERE Id = @DocReqId ";

                var affectedRows = await connection.ExecuteAsync(updateQuery, new { DocReqId = docReqId, Active = isActive, DeleteDesc = deleteDesc });

                connection.Close();

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public async Task<List<DocRequest>> FilterDocRequests(FilterDocRequests filterDocRequests)
        {
            try
            {
                connection.Open();

                var docRequestsQuery = @"
                                        SELECT DISTINCT
                                            DR.*,
                                            CASE 
                                                WHEN DRA.DocRequestID IS NOT NULL THEN 'دارد'
                                                ELSE 'ندارد'
                                            END AS HasAttachments
                                            FROM 
                                                DocRequests DR
                                            LEFT JOIN 
                                                DocRequestAttachments DRA ON DR.Id = DRA.DocRequestId
                                           ";
                docRequestsQuery += filterDocRequests.DocRequestStatus != null ? @" where DR.Active = @Active and DR.DocRequestStatus = @DocRequestStatus " : filterDocRequests.Active != null ? " where DR.Active = @Active" : ""; // DocRequestStatus = 0 is DocRequest is InProgress

                if (!string.IsNullOrEmpty(filterDocRequests.CreatorPersonCode))
                {
                    docRequestsQuery += " and DR.CreatedBy = @CreatorPersonCode ";
                }
                if (!string.IsNullOrEmpty(filterDocRequests.ReceiverPersonCode))
                {
                    var receivedDocReqs = $"select DocRequestId from DocRequestSteps where ReceiverUserPersonCode = '{filterDocRequests.ReceiverPersonCode}' and IsApproved = 'false' and active = '1' group by DocRequestId";

                    docRequestsQuery += $" and DR.Id in ({receivedDocReqs}) ";
                }

                if (!string.IsNullOrEmpty(filterDocRequests.SenderPersonCode))
                {
                    var receivedDocReqs = $"select DocRequestId from DocRequestSteps where SenderUserPersonCode = '{filterDocRequests.SenderPersonCode}' and active = '1' group by DocRequestId";

                    docRequestsQuery += $" and DR.Id in ({receivedDocReqs}) ";
                }

                docRequestsQuery += " ORDER BY DR.Id DESC ";

                var parameters = new
                {
                    Active = filterDocRequests.Active,
                    CreatorPersonCode = filterDocRequests.CreatorPersonCode,
                    DocRequestStatus = filterDocRequests.DocRequestStatus,
                };

                var docRequests = await connection.QueryAsync<DocRequest>(docRequestsQuery, parameters);

                connection.Close();
                return docRequests.ToList();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public async Task<DocRequest> GetDocRequest(int docReqId)
        {
            try
            {
                connection.Open();
                var docReqQuery = $"select * from DocRequests where Id = '{docReqId}'";

                var docReqs = await connection.QueryAsync<DocRequest>(docReqQuery);
                connection.Close();
                return docReqs.First();
            }
            catch (Exception ex)
            {
                connection.Close();

                throw ex;
            }
        }

       

        public async Task<List<DocRequestStep>> GetDocRequestSteps(int docReqId)
        {
            try
            {
                connection.Open();
                var docRequestStepsQuery = $"select * from DocRequestSteps where DocRequestId = '{docReqId}' and Active = '1' order by Id";
               

                var docRequestSteps = await connection.QueryAsync<DocRequestStep>(docRequestStepsQuery);
                connection.Close();
                return docRequestSteps.ToList();
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

                throw ex;
            }
        }

        public async Task<bool> SetDocRequestStepApproved(int docReqId, string userPersonCode)
        {
            try
            {
                connection.Open();

                var updateQuery = @"
                                    UPDATE DocRequestSteps
                                        SET IsApproved = 'true'
                                        WHERE DocRequestId = @DocReqId and ReceiverUserPersonCode = @ReceiverUserPersonCode";

                var affectedRows = await connection.ExecuteAsync(updateQuery, new { DocReqId = docReqId, ReceiverUserPersonCode = userPersonCode });

                connection.Close();

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }

        }

        public async Task<bool> UpdateDocRequestStatus(int docReqId, DocRequestStatus docRequestStatus, string cancelDesc)
        {
            try
            {
                connection.Open();

                var updateQuery = @$"
                                    UPDATE DocRequests
                                        SET DocRequestStatus = @docRequestStatus, CancelDesc = @cancelDesc
                                        WHERE Id = @DocReqId ";

                var affectedRows = await connection.ExecuteAsync(updateQuery, new { DocReqId = docReqId, DocRequestStatus = docRequestStatus, cancelDesc = cancelDesc });

                connection.Close();

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
    }
}
