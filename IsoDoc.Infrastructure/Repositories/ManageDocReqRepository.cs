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
        }

        public async Task<DocRequestStep> AddNewDocRequestStepAsync(DocRequestStep docRequestStep)
        {
            const string docRequestStepQuery = @"
                    INSERT INTO DocRequestSteps (
                        DocRequestId, 
                        SenderUserPersonCode, 
                        SenderUserFullName, 
                        SenderUserPost, 
                        ReceiverUserPersonCode, 
                        ReceiverUserFullName, 
                        ReceiverUserPost, 
                        Description, 
                        IsApproved, 
                        CreatedBy, 
                        ModifiedBy, 
                        CreatedAt, 
                        ModifiedAt,
                        Active
                    )
                    OUTPUT INSERTED.Id
                    VALUES (
                        @DocRequestId, 
                        @SenderUserPersonCode, 
                        @SenderUserFullName, 
                        @SenderUserPost, 
                        @ReceiverUserPersonCode, 
                        @ReceiverUserFullName, 
                        @ReceiverUserPost, 
                        @Description, 
                        @IsApproved, 
                        @CreatedBy, 
                        @ModifiedBy, 
                        @CreatedAt, 
                        @ModifiedAt,
                        @Active
                    );";

            var newDocReqStepId = await connection.QuerySingleAsync<int>(docRequestStepQuery, docRequestStep);
            docRequestStep.Id = newDocReqStepId;
            return docRequestStep;
        }

        public async Task<DocRequestAttachment> AttachFileAsync(DocRequestAttachment docRequestAttachment)
        {
            var docRequestAttachmentQuery = @"
                    INSERT INTO DocRequestAttachments (
                        DocRequestId,
                        Name,
                        ContentType,
                        FileContent,
                        Size,
                        CreatedBy, 
                        ModifiedBy, 
                        CreatedAt, 
                        ModifiedAt,
                        Active
                    )
                    OUTPUT INSERTED.Id
                    VALUES (
                        @DocRequestId,
                        @Name,
                        @ContentType,
                        @FileContent,
                        @Size,
                        @CreatedBy, 
                        @ModifiedBy, 
                        @CreatedAt, 
                        @ModifiedAt,
                        @Active
                    );";


            var newDocReqAttachmentId = await connection.QuerySingleAsync<int>(docRequestAttachmentQuery, docRequestAttachment);
            docRequestAttachment.Id = newDocReqAttachmentId;
            return docRequestAttachment;



        }

        public async Task<DocRequest> CreateNewDocRequest(DocRequest docRequest)
        {
            var docRequestsQuery = @"
                    INSERT INTO DocRequests (
                        DocId,
                        DocOwnerDep,
                        DocCode,
                        Title,
                        KeepDuration,
                        ChangeSummary,
                        CreateReason,
                        DocRequestType,
                        DocRequestStatus,
                        DocType,
                        CreatorDep,
                        CreatedBy, 
                        ModifiedBy, 
                        CreatedAt, 
                        ModifiedAt,
                        Active
                    )
                    OUTPUT INSERTED.Id
                    VALUES (
                        @DocId,
                        @DocOwnerDep,
                        @DocCode,
                        @Title,
                        @KeepDuration,
                        @ChangeSummary,
                        @CreateReason,
                        @DocRequestType,
                        @DocRequestStatus,
                        @DocType,
                        @CreatorDep,
                        @CreatedBy, 
                        @ModifiedBy, 
                        @CreatedAt, 
                        @ModifiedAt,
                        @Active
                    );";


            var newDocReqId = await connection.QuerySingleAsync<int>(docRequestsQuery, docRequest);
            docRequest.Id = newDocReqId;
            return docRequest;

        }

        public async Task<bool> SetDocRequestActive(int docReqId, string deleteDesc, bool isActive)
        {
            var updateQuery = @"
                    UPDATE DocRequests SET Active = @Active, deleteDesc = @DeleteDesc
                    WHERE Id = @DocReqId ";

            var affectedRows = await connection.ExecuteAsync(updateQuery, new { DocReqId = docReqId, Active = isActive, DeleteDesc = deleteDesc });

            return affectedRows > 0;

        }

        public async Task<List<DocRequest>> FilterDocRequests(FilterDocRequests filterDocRequests)
        {

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
                var receivedDocReqs = @"select DocRequestId from DocRequestSteps where ReceiverUserPersonCode = @ReceiverUserPersonCode and IsApproved = 'false' and active = '1' group by DocRequestId";

                docRequestsQuery += $" and DR.Id in ({receivedDocReqs}) ";
            }

            if (!string.IsNullOrEmpty(filterDocRequests.SenderPersonCode))
            {
                var receivedDocReqs = $"select DocRequestId from DocRequestSteps where SenderUserPersonCode = @SenderUserPersonCode and active = '1' group by DocRequestId";

                docRequestsQuery += $" and DR.Id in ({receivedDocReqs}) ";
            }

            docRequestsQuery += " ORDER BY DR.Id DESC ";

            var parameters = new
            {
                Active = filterDocRequests.Active,
                CreatorPersonCode = filterDocRequests.CreatorPersonCode,
                DocRequestStatus = filterDocRequests.DocRequestStatus,
                ReceiverUserPersonCode = filterDocRequests.ReceiverPersonCode,
                SenderUserPersonCode = filterDocRequests.SenderPersonCode
            };

            var docRequests = await connection.QueryAsync<DocRequest>(docRequestsQuery, parameters);

            return docRequests.ToList();

        }

        public async Task<DocRequest> GetDocRequest(int docReqId)
        {
            var docReqQuery = @"select * from DocRequests where Id = @Id";

            var docReqs = await connection.QueryAsync<DocRequest>(docReqQuery, new { Id = docReqId });
            return docReqs.First();

        }



        public async Task<List<DocRequestStep>> GetDocRequestSteps(int docReqId)
        {
            var docRequestStepsQuery = @"select * from DocRequestSteps where DocRequestId = @DocRequestId and Active = '1' order by Id";

            var docRequestSteps = await connection.QueryAsync<DocRequestStep>(docRequestStepsQuery, new { DocRequestId = docReqId });
            return docRequestSteps.ToList();

        }

        public async Task<List<DocType>> GetDocTypes()
        {
            var docTypesQuery = "select DocId,DocName,KeepDurationRequired from tbISODocName";

            var docTypes = await connection.QueryAsync<DocType>(docTypesQuery);
            return docTypes.ToList();

        }

        public async Task<List<Document>> GetDocuments(string depCode)
        {
            var documentsQuery = @"select DISTINCT ROW_NUMBER() OVER (ORDER BY MainId) AS RowNumber, MainId as DocId, DocumentName, DocumentCode, DocName, HistorySave from VwIso_Documents where MdepartID = @MdepartID"; //MdepartID in VwIso_Documents has depCode values 

            var documents = await connection.QueryAsync<Document>(documentsQuery, new { MdepartID = depCode });
            return documents.ToList();


        }


        public async Task<int> GetLastDocReqId()
        {

            var maxDocReqIdQuery = "select MAX(Id) as MaxReqId from DocRequests";

            var maxDocReqId = await connection.QueryAsync<int?>(maxDocReqIdQuery);
            return maxDocReqId.First() != null ? (int)maxDocReqId.First() : 0;

        }

        public async Task<bool> SetDocRequestStepApproved(int docReqId, string userPersonCode)
        {

            var updateQuery = @"
                                    UPDATE DocRequestSteps
                                        SET IsApproved = 'true'
                                        WHERE DocRequestId = @DocReqId and ReceiverUserPersonCode = @ReceiverUserPersonCode";

            var affectedRows = await connection.ExecuteAsync(updateQuery, new { DocReqId = docReqId, ReceiverUserPersonCode = userPersonCode });


            return affectedRows > 0;


        }

        public async Task<bool> UpdateDocRequestStatus(int docReqId, DocRequestStatus docRequestStatus, string cancelDesc, string modifiedBy)
        {

            var updateQuery = @"
                                    UPDATE DocRequests
                                        SET DocRequestStatus = @DocRequestStatus, CancelDesc = @CancelDesc, ModifiedBy = @ModifiedBy
                                        WHERE Id = @DocReqId ";

            var affectedRows = await connection.ExecuteAsync(updateQuery, new { DocReqId = docReqId, DocRequestStatus = docRequestStatus, CancelDesc = cancelDesc, ModifiedBy = modifiedBy });


            return affectedRows > 0;

        }

        public async Task<bool> UpdateDocRequestEditOrReviewStatus(int docReqId, EditOrReviewStatus editOrReviewStatus, int editOrReviewNo)
        {

            var updateQuery = @"
                                    UPDATE DocRequests
                                        SET EditOrReviewStatus = @EditOrReviewStatus, EditOrReviewNo = @EditOrReviewNo
                                        WHERE Id = @DocReqId ";

            var affectedRows = await connection.ExecuteAsync(updateQuery, new { DocReqId = docReqId, EditOrReviewStatus = editOrReviewStatus, EditOrReviewNo = editOrReviewNo });


            return affectedRows > 0;

        }
    }
}
