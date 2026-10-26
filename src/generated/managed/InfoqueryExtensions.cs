//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infoquery
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfoqueryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddNewPartnerEmployeeToPartnerCompanyResponse, ApiConnectionActionConfiguration> AddNewPartnerEmployeeToPartnerCompany(Expression<Func<string>> partnerCompanyId, Expression<Func<AddNewPartnerEmployeeToPartnerCompanyInput>> body)
        {
            var __workflow_partnerCompanyId = WorkflowExpression.Compile(partnerCompanyId, nameof(partnerCompanyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddNewPartnerEmployeeToPartnerCompanyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddNewPartnerEmployeeToPartnerCompany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(__workflow_partnerCompanyId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddNewPartnerEmployeeToPartnerCompanyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<CreateNewFileResponse, ApiConnectionActionConfiguration> CreateNewFile(Expression<Func<CreateNewFileInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateNewFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateNewFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateNewFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[], ApiConnectionActionConfiguration> GetTransactionAndProductTypesForEstimationAndOrderPlacement(Expression<Func<string>> state = null, Expression<Func<string>> county = null)
        {
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_county = WorkflowExpression.Compile(county, nameof(county), required: false);
            return new DeferredBodyAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTransactionAndProductTypesForEstimationAndOrderPlacement";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_state != null)
                    callPayload.Queries["State"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_county != null)
                    callPayload.Queries["County"] = ExpressionConverter.Convert(__workflow_county);
                return new ApiConnectionAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdateActionForFileResponse, ApiConnectionActionConfiguration> UpdateActionForFile(Expression<Func<string>> fileId, Expression<Func<string>> fileActionId, Expression<Func<UpdateActionForFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_fileActionId = WorkflowExpression.Compile(fileActionId, nameof(fileActionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateActionForFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UpdateActionForFile";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["FileActionID"] = ExpressionConverter.Convert(__workflow_fileActionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateActionForFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetsFilesFromGivenSearchCriteria(Expression<Func<GetsFilesFromGivenSearchCriteriaInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetsFilesFromGivenSearchCriteria";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeletePartnerOnSpecificFile(Expression<Func<string>> fileId, Expression<Func<DeletePartnerOnSpecificFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeletePartnerOnSpecificFile";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartnerInformationResponse, ApiConnectionActionConfiguration> GetPartnerInformation(Expression<Func<string>> partnerCompanyId)
        {
            var __workflow_partnerCompanyId = WorkflowExpression.Compile(partnerCompanyId, nameof(partnerCompanyId), required: true);
            return new DeferredBodyAction<GetPartnerInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetPartnerInformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(__workflow_partnerCompanyId);
                return new ApiConnectionAction<GetPartnerInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CancelsPreviouslyPlacedOrder(Expression<Func<string>> fileId, Expression<Func<CancelsPreviouslyPlacedOrderInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CancelsPreviouslyPlacedOrder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<CreateNewDocumentOnSpecificFileResponse, ApiConnectionActionConfiguration> CreateNewDocumentOnSpecificFile(Expression<Func<string>> fileId, Expression<Func<CreateNewDocumentOnSpecificFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateNewDocumentOnSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateNewDocumentOnSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateNewDocumentOnSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeletePreviouslyPlacedOrder(Expression<Func<string>> fileId, Expression<Func<DeletePreviouslyPlacedOrderInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeletePreviouslyPlacedOrder";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddOrUpdateCustomFieldOnSpecificFile(Expression<Func<string>> fileId, Expression<Func<AddOrUpdateCustomFieldOnSpecificFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddOrUpdateCustomFieldOnSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddPartnerToSpecificFile(Expression<Func<string>> fileId, Expression<Func<AddPartnerToSpecificFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddPartnerToSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdatePartnerInformationForSpecificFileResponse, ApiConnectionActionConfiguration> UpdatePartnerInformationForSpecificFile(Expression<Func<string>> fileId, Expression<Func<string>> partnerId, Expression<Func<UpdatePartnerInformationForSpecificFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdatePartnerInformationForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UpdatePartnerInformationForSpecificFile";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["PartnerID"] = ExpressionConverter.Convert(__workflow_partnerId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdatePartnerInformationForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddNoteToFileResponse, ApiConnectionActionConfiguration> AddNoteToFile(Expression<Func<string>> fileId, Expression<Func<AddNoteToFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddNoteToFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddNoteToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddNoteToFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartnersForSpecificFileResponse, ApiConnectionActionConfiguration> GetPartnersForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetPartnersForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetPartnersForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetPartnersForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UploadWebURLDocumentToSpecificFileResponse, ApiConnectionActionConfiguration> UploadWebURLDocumentToSpecificFile(Expression<Func<string>> fileId, Expression<Func<UploadWebURLDocumentToSpecificFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UploadWebURLDocumentToSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UploadWebUrlDocumentToSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadWebURLDocumentToSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddOrUpdateCustomFieldOnSpecificDocument(Expression<Func<string>> fileId, Expression<Func<string>> documentId, Expression<Func<AddOrUpdateCustomFieldOnSpecificDocumentInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddOrUpdateCustomFieldOnSpecificDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(__workflow_documentId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdatePartnerEmployeeResponse, ApiConnectionActionConfiguration> UpdatePartnerEmployee(Expression<Func<string>> userId, Expression<Func<string>> partnerCompanyId, Expression<Func<UpdatePartnerEmployeeInput>> body = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_partnerCompanyId = WorkflowExpression.Compile(partnerCompanyId, nameof(partnerCompanyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdatePartnerEmployeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UpdatePartnerEmployee";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["UserID"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(__workflow_partnerCompanyId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdatePartnerEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartiesForSpecificFileResponse, ApiConnectionActionConfiguration> GetPartiesForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetPartiesForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetPartiesForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetPartiesForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetNotesForSpecificFileResponse, ApiConnectionActionConfiguration> GetNotesForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetNotesForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetNotesForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetNotesForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetNoteResponse, ApiConnectionActionConfiguration> GetNote(Expression<Func<string>> noteId)
        {
            var __workflow_noteId = WorkflowExpression.Compile(noteId, nameof(noteId), required: true);
            return new DeferredBodyAction<GetNoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetNote";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["NoteID"] = ExpressionConverter.Convert(__workflow_noteId);
                return new ApiConnectionAction<GetNoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddActionToFileResponse, ApiConnectionActionConfiguration> AddActionToFile(Expression<Func<string>> fileId, Expression<Func<AddActionToFileInput>> body = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddActionToFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddActionToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddActionToFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCustomFieldsOnSpecificDocumentResponse, ApiConnectionActionConfiguration> GetCustomFieldsOnSpecificDocument(Expression<Func<string>> fileId, Expression<Func<string>> documentId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetCustomFieldsOnSpecificDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetCustomFieldsOnSpecificDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(__workflow_documentId);
                return new ApiConnectionAction<GetCustomFieldsOnSpecificDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetDocumentsForSpecificFileResponse, ApiConnectionActionConfiguration> GetDocumentsForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetDocumentsForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetDocumentsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetDocumentsForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetDocumentResponse, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(__workflow_documentId);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCustomFieldsForSpecificFileResponse, ApiConnectionActionConfiguration> GetCustomFieldsForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetCustomFieldsForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetCustomFieldsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetCustomFieldsForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetClosingFeeEstimateReceiptResponse, ApiConnectionActionConfiguration> GetClosingFeeEstimateReceipt(Expression<Func<string>> closingFeeId)
        {
            var __workflow_closingFeeId = WorkflowExpression.Compile(closingFeeId, nameof(closingFeeId), required: true);
            return new DeferredBodyAction<GetClosingFeeEstimateReceiptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetClosingFeeEstimateReceipt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ClosingFeeID"] = ExpressionConverter.Convert(__workflow_closingFeeId);
                return new ApiConnectionAction<GetClosingFeeEstimateReceiptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetClosingFeeEstimateReceiptPDF(Expression<Func<string>> closingFeeId)
        {
            var __workflow_closingFeeId = WorkflowExpression.Compile(closingFeeId, nameof(closingFeeId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetClosingFeeEstimateReceiptPDF";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ClosingFeeID"] = ExpressionConverter.Convert(__workflow_closingFeeId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetActionsForSpecificFileResponse, ApiConnectionActionConfiguration> GetActionsForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetActionsForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetActionsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetActionsForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse, ApiConnectionActionConfiguration> GetCurrentUserInfo()
        {
            return new DeferredBodyAction<GetCurrentUserInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetCurrentUserInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCurrentUserInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<EstimateClosingFeeResponse, ApiConnectionActionConfiguration> EstimateClosingFee(Expression<Func<EstimateClosingFeeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EstimateClosingFeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EstimateClosingFee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EstimateClosingFeeResponse>(callPayload);
            });
        }
    }

    public class InfoqueryTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddNewPartnerEmployeeToPartnerCompanyResponse
    {
        public AddNewPartnerEmployeeToPartnerCompanyResponseEmployeeType Employee { get; set; }
    }

    public class AddNewPartnerEmployeeToPartnerCompanyResponseEmployeeType
    {
        [JsonProperty("PartnerCompanyID")]
        public int PartnerCompanyId { get; set; }
        public bool Enabled { get; set; }
        public bool WebsiteAccess { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddNewPartnerEmployeeToPartnerCompanyResponseEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class AddNewPartnerEmployeeToPartnerCompanyResponseEmployeeTypeContactInformationType
    {
        public string EmailAddress { get; set; }
    }

    public class AddNewPartnerEmployeeToPartnerCompanyInput
    {
        public string Password { get; set; }
        public string PasswordExpirationDate { get; set; }
        public bool? Enabled { get; set; }
        public bool? WebsiteAccess { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddNewPartnerEmployeeToPartnerCompanyInputContactInformationType ContactInformation { get; set; }
    }

    public class AddNewPartnerEmployeeToPartnerCompanyInputContactInformationType
    {
        public string EmailAddress { get; set; }
    }

    public class CreateNewFileResponse
    {
        [JsonProperty("FileID")]
        public int FileId { get; set; }
        public string FileNumber { get; set; }
        public string[] Warnings { get; set; }
    }

    public class CreateNewFileInput
    {
        public CreateNewFileInputBuyersTypeItem[] Buyers { get; set; }
        public CreateNewFileInputSellersTypeItem[] Sellers { get; set; }
        public string EstimatedSettlementDate { get; set; }
        public CreateNewFileInputTransactionProductTypeType TransactionProductType { get; set; }
        public int? SalesPrice { get; set; }
        public string ClientFileNumber { get; set; }
        public string PiggybackFileNumber { get; set; }
        public string MainFileNumber { get; set; }

        [JsonProperty("SourceOfBusinessID")]
        public int? SourceOfBusinessId { get; set; }
        public string Note { get; set; }
        public CreateNewFileInputCustomFieldsTypeItem[] CustomFields { get; set; }
        public CreateNewFileInputLoansTypeItem[] Loans { get; set; }
        public CreateNewFileInputPropertiesTypeItem[] Properties { get; set; }
    }

    public class CreateNewFileInputBuyersTypeItem
    {
        public string EntityType { get; set; }
        public bool? IsPrimaryTransactee { get; set; }
        public CreateNewFileInputBuyersTypeItemPrimaryType Primary { get; set; }
        public bool? UsePropertyAddress { get; set; }
        public CreateNewFileInputBuyersTypeItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
    }

    public class CreateNewFileInputBuyersTypeItemPrimaryType
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class CreateNewFileInputBuyersTypeItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class CreateNewFileInputSellersTypeItem
    {
        public string EntityType { get; set; }
        public bool? IsPrimaryTransactee { get; set; }
        public CreateNewFileInputSellersTypeItemPrimaryType Primary { get; set; }
        public bool? UsePropertyAddress { get; set; }
        public CreateNewFileInputSellersTypeItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
    }

    public class CreateNewFileInputSellersTypeItemPrimaryType
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class CreateNewFileInputSellersTypeItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class CreateNewFileInputTransactionProductTypeType
    {
        [JsonProperty("TransactionTypeID")]
        public int? TransactionTypeId { get; set; }

        [JsonProperty("ProductTypeID")]
        public int? ProductTypeId { get; set; }
    }

    public class CreateNewFileInputCustomFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CreateNewFileInputLoansTypeItem
    {
        public int? LienPosition { get; set; }
        public string LoanNumber { get; set; }
        public int? LoanAmount { get; set; }
        public string LoanType { get; set; }
    }

    public class CreateNewFileInputPropertiesTypeItem
    {
        public bool? IsPrimary { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem
    {
        public string TransactionType { get; set; }

        [JsonProperty("TransactionTypeID")]
        public int TransactionTypeId { get; set; }
        public string ProductType { get; set; }

        [JsonProperty("ProductTypeID")]
        public int ProductTypeId { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItem[] AncillaryProducts { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAddOnProductsTypeItem[] AddOnProducts { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItemOptionsTypeItem
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAddOnProductsTypeItem
    {
        public string TransactionType { get; set; }

        [JsonProperty("TransactionTypeID")]
        public int TransactionTypeId { get; set; }
        public string ProductType { get; set; }

        [JsonProperty("ProductTypeID")]
        public int ProductTypeId { get; set; }
    }

    public class UpdateActionForFileResponse
    {
        [JsonProperty("FileActionID")]
        public int FileActionId { get; set; }
    }

    public class UpdateActionForFileInput
    {
        public UpdateActionForFileInputStartTaskType StartTask { get; set; }
        public UpdateActionForFileInputCompleteTaskType CompleteTask { get; set; }
    }

    public class UpdateActionForFileInputStartTaskType
    {
        [JsonProperty("CoordinatorTypeID")]
        public int? CoordinatorTypeId { get; set; }
        public string DueDate { get; set; }
        public bool? DoneDateLocked { get; set; }
    }

    public class UpdateActionForFileInputCompleteTaskType
    {
        [JsonProperty("CoordinatorTypeID")]
        public int? CoordinatorTypeId { get; set; }
        public string DueDate { get; set; }
        public bool? DoneDateLocked { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInput
    {
        public string FileNumber { get; set; }

        [JsonProperty("FileID")]
        public int? FileId { get; set; }

        [JsonProperty("OfficeID")]
        public int? OfficeId { get; set; }
        public string ClientsFileNumber { get; set; }
        public GetsFilesFromGivenSearchCriteriaInputTransactionProductTypeType TransactionProductType { get; set; }
        public GetsFilesFromGivenSearchCriteriaInputStatusesTypeItem[] Statuses { get; set; }
        public string PolicyNumber { get; set; }
        public string SearchNumber { get; set; }
        public string LoanNumber { get; set; }
        public GetsFilesFromGivenSearchCriteriaInputPropertyType Property { get; set; }
        public GetsFilesFromGivenSearchCriteriaInputBuyerType Buyer { get; set; }
        public GetsFilesFromGivenSearchCriteriaInputFilePartnerType FilePartner { get; set; }
        public string OpenedFromDate { get; set; }
        public string OpenedToDate { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInputTransactionProductTypeType
    {
        [JsonProperty("TransactionTypeID")]
        public int? TransactionTypeId { get; set; }

        [JsonProperty("ProductTypeID")]
        public int? ProductTypeId { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInputStatusesTypeItem
    {
        [JsonProperty("StatusID")]
        public int? StatusId { get; set; }
        public string Name { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInputPropertyType
    {
        public bool? IsPrimary { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Subdivision { get; set; }

        [JsonProperty("ParcelID")]
        public string ParcelId { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInputBuyerType
    {
        public string EntityType { get; set; }
        public GetsFilesFromGivenSearchCriteriaInputBuyerTypePrimaryType Primary { get; set; }
        public bool? UsePropertyAddress { get; set; }
        public string MaritalStatus { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInputBuyerTypePrimaryType
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInputFilePartnerType
    {
        public GetsFilesFromGivenSearchCriteriaInputFilePartnerTypePrimaryEmployeeType PrimaryEmployee { get; set; }

        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int? PartnerId { get; set; }
        public GetsFilesFromGivenSearchCriteriaInputFilePartnerTypePartnerTypeType PartnerType { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInputFilePartnerTypePrimaryEmployeeType
    {
        [JsonProperty("UserID")]
        public int? UserId { get; set; }
    }

    public class GetsFilesFromGivenSearchCriteriaInputFilePartnerTypePartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }
    }

    public class DeletePartnerOnSpecificFileInput
    {
        public DeletePartnerOnSpecificFileInputPartnersTypeItem[] Partners { get; set; }
    }

    public class DeletePartnerOnSpecificFileInputPartnersTypeItem
    {
        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int? PartnerId { get; set; }
        public DeletePartnerOnSpecificFileInputPartnersTypeItemPartnerTypeType PartnerType { get; set; }
    }

    public class DeletePartnerOnSpecificFileInputPartnersTypeItemPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }
    }

    public class GetPartnerInformationResponse
    {
        [JsonProperty("PartnerCompanyID")]
        public int PartnerCompanyId { get; set; }
        public GetPartnerInformationResponsePartnerTypesTypeItem[] PartnerTypes { get; set; }

        [JsonProperty("OfficeID")]
        public int OfficeId { get; set; }
        public string PartnerName { get; set; }
        public string CompanyAbbreviation { get; set; }
        public string ProperCompanyName { get; set; }
        public GetPartnerInformationResponseMailingAddressType MailingAddress { get; set; }
        public GetPartnerInformationResponseContactInformationType ContactInformation { get; set; }
        public GetPartnerInformationResponseCompanyInformationType CompanyInformation { get; set; }
        public bool SendDocumentsAsWebLinks { get; set; }

        [JsonProperty("WireConfirmationEmailTemplateID")]
        public int WireConfirmationEmailTemplateId { get; set; }
        public GetPartnerInformationResponseCourierAddressType CourierAddress { get; set; }
    }

    public class GetPartnerInformationResponsePartnerTypesTypeItem
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class GetPartnerInformationResponseMailingAddressType
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class GetPartnerInformationResponseContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class GetPartnerInformationResponseCompanyInformationType
    {
        public GetPartnerInformationResponseCompanyInformationTypeParentCompanyType ParentCompany { get; set; }
        public GetPartnerInformationResponseCompanyInformationTypePartnerEntityType PartnerEntity { get; set; }
        public bool IsBillable { get; set; }
        public bool IsInvoiceable { get; set; }

        [JsonProperty("TaxID")]
        public string TaxId { get; set; }
        public string AccountingCode { get; set; }
        public string CommentsSpecialInstructions { get; set; }
        public bool DontAllowSelectionInSettlement { get; set; }
        public bool Needs1099 { get; set; }
        public bool MWBE { get; set; }
    }

    public class GetPartnerInformationResponseCompanyInformationTypeParentCompanyType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GetPartnerInformationResponseCompanyInformationTypePartnerEntityType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetPartnerInformationResponseCourierAddressType
    {
        public bool UseOnDisbursements { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class CancelsPreviouslyPlacedOrderInput
    {
        [JsonProperty("FileID")]
        public int? FileId { get; set; }
    }

    public class CreateNewDocumentOnSpecificFileResponse
    {
        public CreateNewDocumentOnSpecificFileResponseDocumentType Document { get; set; }
    }

    public class CreateNewDocumentOnSpecificFileResponseDocumentType
    {
        [JsonProperty("DocumentID")]
        public int DocumentId { get; set; }
    }

    public class CreateNewDocumentOnSpecificFileInput
    {
        public string DocumentName { get; set; }
        public CreateNewDocumentOnSpecificFileInputDocumentTypeType DocumentType { get; set; }
        public string Description { get; set; }
        public string InternalOnly { get; set; }
        public string DocumentBody { get; set; }
    }

    public class CreateNewDocumentOnSpecificFileInputDocumentTypeType
    {
        [JsonProperty("DocumentTypeID")]
        public int? DocumentTypeId { get; set; }
    }

    public class DeletePreviouslyPlacedOrderInput
    {
        [JsonProperty("FileID")]
        public int? FileId { get; set; }
    }

    public class AddOrUpdateCustomFieldOnSpecificFileInput
    {
        public AddOrUpdateCustomFieldOnSpecificFileInputCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class AddOrUpdateCustomFieldOnSpecificFileInputCustomFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class AddPartnerToSpecificFileInput
    {
        public AddPartnerToSpecificFileInputPartnersTypeItem[] Partners { get; set; }
    }

    public class AddPartnerToSpecificFileInputPartnersTypeItem
    {
        public AddPartnerToSpecificFileInputPartnersTypeItemPrimaryEmployeeType PrimaryEmployee { get; set; }
        public AddPartnerToSpecificFileInputPartnersTypeItemSecondaryEmployeesTypeItem[] SecondaryEmployees { get; set; }

        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int? PartnerId { get; set; }
        public AddPartnerToSpecificFileInputPartnersTypeItemPartnerTypeType PartnerType { get; set; }
    }

    public class AddPartnerToSpecificFileInputPartnersTypeItemPrimaryEmployeeType
    {
        [JsonProperty("UserID")]
        public int? UserId { get; set; }
    }

    public class AddPartnerToSpecificFileInputPartnersTypeItemSecondaryEmployeesTypeItem
    {
        [JsonProperty("UserID")]
        public int? UserId { get; set; }
    }

    public class AddPartnerToSpecificFileInputPartnersTypeItemPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponse
    {
        [JsonProperty("FileID")]
        public int FileId { get; set; }
        public string FileNumber { get; set; }
        public UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeType PrimaryEmployee { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItem[] SecondaryEmployees { get; set; }
        public string ReferenceNumber { get; set; }
        public string RemoteFileNumber { get; set; }

        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public UpdatePartnerInformationForSpecificFileResponsePartnerTypeType PartnerType { get; set; }

        [JsonProperty("OfficeID")]
        public int OfficeId { get; set; }
        public string PartnerName { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseMailingAddressType MailingAddress { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeTypeContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItem
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItemContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItemContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponsePartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponseMailingAddressType
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponseContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileInput
    {
        [JsonProperty("FileID")]
        public int? FileId { get; set; }
        public UpdatePartnerInformationForSpecificFileInputPrimaryEmployeeType PrimaryEmployee { get; set; }
        public UpdatePartnerInformationForSpecificFileInputSecondaryEmployeesTypeItem[] SecondaryEmployees { get; set; }
        public string ReferenceNumber { get; set; }
        public string RemoteFileNumber { get; set; }

        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int? PartnerId { get; set; }
        public UpdatePartnerInformationForSpecificFileInputPartnerTypeType PartnerType { get; set; }

        [JsonProperty("OfficeID")]
        public int? OfficeId { get; set; }
        public string PartnerName { get; set; }
        public UpdatePartnerInformationForSpecificFileInputMailingAddressType MailingAddress { get; set; }
        public UpdatePartnerInformationForSpecificFileInputContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileInputPrimaryEmployeeType
    {
        [JsonProperty("UserID")]
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerInformationForSpecificFileInputPrimaryEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileInputPrimaryEmployeeTypeContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileInputSecondaryEmployeesTypeItem
    {
        [JsonProperty("UserID")]
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerInformationForSpecificFileInputSecondaryEmployeesTypeItemContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileInputSecondaryEmployeesTypeItemContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileInputPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileInputMailingAddressType
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileInputContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class AddNoteToFileResponse
    {
        [JsonProperty("note")]
        public AddNoteToFileResponseNoteType Note { get; set; }
    }

    public class AddNoteToFileResponseNoteType
    {
        [JsonProperty("NoteID")]
        public int NoteId { get; set; }
    }

    public class AddNoteToFileInput
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class GetPartnersForSpecificFileResponse
    {
        public GetPartnersForSpecificFileResponsePartnersTypeItem[] Partners { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItem
    {
        public GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeType PrimaryEmployee { get; set; }

        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public GetPartnersForSpecificFileResponsePartnersTypeItemPartnerTypeType PartnerType { get; set; }
        public string PartnerName { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeTypeContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItemPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class UploadWebURLDocumentToSpecificFileResponse
    {
        public UploadWebURLDocumentToSpecificFileResponseDocumentType Document { get; set; }
    }

    public class UploadWebURLDocumentToSpecificFileResponseDocumentType
    {
        [JsonProperty("DocumentID")]
        public int DocumentId { get; set; }
    }

    public class UploadWebURLDocumentToSpecificFileInput
    {
        public string DocumentName { get; set; }
        public UploadWebURLDocumentToSpecificFileInputDocumentTypeType DocumentType { get; set; }
        public string Description { get; set; }
        public bool? InternalOnly { get; set; }
        public string WebURL { get; set; }
    }

    public class UploadWebURLDocumentToSpecificFileInputDocumentTypeType
    {
        [JsonProperty("DocumentTypeID")]
        public int? DocumentTypeId { get; set; }
    }

    public class AddOrUpdateCustomFieldOnSpecificDocumentInput
    {
        public AddOrUpdateCustomFieldOnSpecificDocumentInputCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class AddOrUpdateCustomFieldOnSpecificDocumentInputCustomFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class UpdatePartnerEmployeeResponse
    {
        public UpdatePartnerEmployeeResponseEmployeeType Employee { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeType
    {
        [JsonProperty("PartnerCompanyID")]
        public int PartnerCompanyId { get; set; }
        public UpdatePartnerEmployeeResponseEmployeeTypeRolesTypeItem[] Roles { get; set; }
        public bool Enabled { get; set; }
        public bool WebsiteAccess { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerEmployeeResponseEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeTypeRolesTypeItem
    {
        [JsonProperty("RoleID")]
        public int RoleId { get; set; }
        public string Name { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeTypeContactInformationType
    {
        public string EmailAddress { get; set; }
    }

    public class UpdatePartnerEmployeeInput
    {
        public string Password { get; set; }
        public string PasswordExpirationDate { get; set; }
        public UpdatePartnerEmployeeInputRolesTypeItem[] Roles { get; set; }
        public bool? Enabled { get; set; }
        public bool? WebsiteAccess { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerEmployeeInputContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerEmployeeInputRolesTypeItem
    {
        [JsonProperty("RoleID")]
        public int? RoleId { get; set; }
        public string Name { get; set; }
    }

    public class UpdatePartnerEmployeeInputContactInformationType
    {
        public string EmailAddress { get; set; }
    }

    public class GetPartiesForSpecificFileResponse
    {
        public GetPartiesForSpecificFileResponseBuyersTypeItem[] Buyers { get; set; }
        public GetPartiesForSpecificFileResponseSellersTypeItem[] Sellers { get; set; }
        public string[] Customers { get; set; }
    }

    public class GetPartiesForSpecificFileResponseBuyersTypeItem
    {
        [JsonProperty("LegalEntityID")]
        public int LegalEntityId { get; set; }
        public string EntityType { get; set; }
        public GetPartiesForSpecificFileResponseBuyersTypeItemPrimaryType Primary { get; set; }
        public GetPartiesForSpecificFileResponseBuyersTypeItemSecondaryType Secondary { get; set; }
        public bool UsePropertyAddress { get; set; }
        public GetPartiesForSpecificFileResponseBuyersTypeItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string EmailSecondary { get; set; }
    }

    public class GetPartiesForSpecificFileResponseBuyersTypeItemPrimaryType
    {
        public string Prefix { get; set; }
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Suffix { get; set; }
    }

    public class GetPartiesForSpecificFileResponseBuyersTypeItemSecondaryType
    {
        public string Prefix { get; set; }
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
    }

    public class GetPartiesForSpecificFileResponseBuyersTypeItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class GetPartiesForSpecificFileResponseSellersTypeItem
    {
        [JsonProperty("LegalEntityID")]
        public int LegalEntityId { get; set; }
        public string EntityType { get; set; }
        public GetPartiesForSpecificFileResponseSellersTypeItemPrimaryType Primary { get; set; }
        public bool UsePropertyAddress { get; set; }
        public GetPartiesForSpecificFileResponseSellersTypeItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
    }

    public class GetPartiesForSpecificFileResponseSellersTypeItemPrimaryType
    {
        public string BusinessName { get; set; }
    }

    public class GetPartiesForSpecificFileResponseSellersTypeItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class GetNotesForSpecificFileResponse
    {
        public GetNotesForSpecificFileResponseNotesTypeItem[] Notes { get; set; }
    }

    public class GetNotesForSpecificFileResponseNotesTypeItem
    {
        [JsonProperty("NoteID")]
        public int NoteId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public GetNotesForSpecificFileResponseNotesTypeItemCreatedByType CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        [JsonProperty("FileID")]
        public int FileId { get; set; }
        public bool Expedite { get; set; }
    }

    public class GetNotesForSpecificFileResponseNotesTypeItemCreatedByType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GetNotesForSpecificFileResponseNotesTypeItemCreatedByTypeContactInformationType ContactInformation { get; set; }
    }

    public class GetNotesForSpecificFileResponseNotesTypeItemCreatedByTypeContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }

    public class GetNoteResponse
    {
        [JsonProperty("NoteID")]
        public int NoteId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public GetNoteResponseCreatedByType CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        [JsonProperty("FileID")]
        public int FileId { get; set; }
    }

    public class GetNoteResponseCreatedByType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
    }

    public class AddActionToFileResponse
    {
        [JsonProperty("FileActionID")]
        public int FileActionId { get; set; }
    }

    public class AddActionToFileInput
    {
        public AddActionToFileInputActionTypeType ActionType { get; set; }
        public AddActionToFileInputGroupType Group { get; set; }
        public AddActionToFileInputStartTaskType StartTask { get; set; }
        public AddActionToFileInputCompleteTaskType CompleteTask { get; set; }
    }

    public class AddActionToFileInputActionTypeType
    {
        [JsonProperty("ActionTypeID")]
        public int? ActionTypeId { get; set; }
    }

    public class AddActionToFileInputGroupType
    {
        [JsonProperty("ActionGroupID")]
        public int? ActionGroupId { get; set; }
    }

    public class AddActionToFileInputStartTaskType
    {
        [JsonProperty("CoordinatorTypeID")]
        public int? CoordinatorTypeId { get; set; }
        public string DueDate { get; set; }
    }

    public class AddActionToFileInputCompleteTaskType
    {
        public AddActionToFileInputCompleteTaskTypePartnerType Partner { get; set; }
        public string DueDate { get; set; }
    }

    public class AddActionToFileInputCompleteTaskTypePartnerType
    {
        public AddActionToFileInputCompleteTaskTypePartnerTypePartnerTypeType PartnerType { get; set; }
    }

    public class AddActionToFileInputCompleteTaskTypePartnerTypePartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }
    }

    public class GetCustomFieldsOnSpecificDocumentResponse
    {
        public GetCustomFieldsOnSpecificDocumentResponseCustomFieldsTypeItem[] CustomFields { get; set; }
        public int CustomFieldListCount { get; set; }
    }

    public class GetCustomFieldsOnSpecificDocumentResponseCustomFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GetDocumentsForSpecificFileResponse
    {
        public GetDocumentsForSpecificFileResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItem
    {
        [JsonProperty("DocumentID")]
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public GetDocumentsForSpecificFileResponseDocumentsTypeItemDocumentTypeType DocumentType { get; set; }
        public string Description { get; set; }
        public bool InternalOnly { get; set; }
        public bool Approved { get; set; }
        public GetDocumentsForSpecificFileResponseDocumentsTypeItemAssociatedNotesTypeItem[] AssociatedNotes { get; set; }
        public GetDocumentsForSpecificFileResponseDocumentsTypeItemCreateUserType CreateUser { get; set; }
        public string CreateDate { get; set; }
        public GetDocumentsForSpecificFileResponseDocumentsTypeItemModifyUserType ModifyUser { get; set; }
        public string ModifyDate { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemDocumentTypeType
    {
        [JsonProperty("DocumentTypeID")]
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemAssociatedNotesTypeItem
    {
        [JsonProperty("NoteID")]
        public int NoteId { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemCreateUserType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemModifyUserType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentResponse
    {
        [JsonProperty("DocumentID")]
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public GetDocumentResponseDocumentTypeType DocumentType { get; set; }
        public string Description { get; set; }
        public bool InternalOnly { get; set; }
        public bool Approved { get; set; }
        public GetDocumentResponseCreateUserType CreateUser { get; set; }
        public string CreateDate { get; set; }
    }

    public class GetDocumentResponseDocumentTypeType
    {
        [JsonProperty("DocumentTypeID")]
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentResponseCreateUserType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
    }

    public class GetCustomFieldsForSpecificFileResponse
    {
        public GetCustomFieldsForSpecificFileResponseCustomFieldsTypeItem[] CustomFields { get; set; }
        public int CustomFieldListCount { get; set; }
    }

    public class GetCustomFieldsForSpecificFileResponseCustomFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponse
    {
        public string EstimateDate { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestType Request { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseType Response { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestType
    {
        public GetClosingFeeEstimateReceiptResponseRequestTypeTransactionProductTypeType TransactionProductType { get; set; }
        public string SettlementStatementVersion { get; set; }
        public int SalesPrice { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeLoansTypeItem[] Loans { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypePropertiesTypeItem[] Properties { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItem[] FilePartners { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeEndorsementsTypeItem[] Endorsements { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeTransactionProductTypeType
    {
        [JsonProperty("TransactionTypeID")]
        public int TransactionTypeId { get; set; }

        [JsonProperty("ProductTypeID")]
        public int ProductTypeId { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeLoansTypeItem
    {
        public int LienPosition { get; set; }
        public int LoanAmount { get; set; }
        public string LoanType { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypePropertiesTypeItem
    {
        public bool IsPrimary { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItem
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItemPartnerTypeType PartnerType { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItemPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeEndorsementsTypeItem
    {
        public string Name { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseType
    {
        [JsonProperty("ClosingFeeEstimateID")]
        public int ClosingFeeEstimateId { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseTypeHUDFeesTypeItem[] HUDFees { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseTypeGFETypeItem[] GFE { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseTypePremiumsType Premiums { get; set; }
        public string Timestamp { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseTypeHUDFeesTypeItem
    {
        public int Amount { get; set; }
        public string Description { get; set; }
        public string LineNumber { get; set; }
        public int BuyerAmount { get; set; }
        public int BuyerPOCAmount { get; set; }
        public int SellerAmount { get; set; }
        public int SellerPOCAmount { get; set; }
        public int OtherPOCAmount { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseTypeHUDFeesTypeItemOtherPOCPartnerTypeType OtherPOCPartnerType { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseTypeHUDFeesTypeItemOtherPOCPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseTypeGFETypeItem
    {
        public string Description { get; set; }
        public int Amount { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseTypePremiumsType
    {
        public int LendersPremium { get; set; }
        public int FullLendersPremium { get; set; }
    }

    public class GetActionsForSpecificFileResponse
    {
        public GetActionsForSpecificFileResponseActionsTypeItem[] Actions { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItem
    {
        [JsonProperty("FileActionID")]
        public int FileActionId { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemActionTypeType ActionType { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemGroupType Group { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemStartTaskType StartTask { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskType CompleteTask { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemActionTypeType
    {
        [JsonProperty("ActionTypeID")]
        public int ActionTypeId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemGroupType
    {
        [JsonProperty("ActionGroupID")]
        public int ActionGroupId { get; set; }
        public string Name { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemStartTaskType
    {
        [JsonProperty("CoordinatorTypeID")]
        public int CoordinatorTypeId { get; set; }
        public string DueDate { get; set; }
        public bool DueDateLocked { get; set; }
        public string DoneDate { get; set; }
        public bool DoneDateLocked { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemStartTaskTypeDoneByType DoneBy { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemStartTaskTypeDoneByType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskType
    {
        [JsonProperty("CoordinatorTypeID")]
        public int CoordinatorTypeId { get; set; }
        public string DueDate { get; set; }
        public bool DueDateLocked { get; set; }
        public bool DoneDateLocked { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskTypeDoneByType DoneBy { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskTypeDoneByType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class GetCurrentUserInfoResponse
    {
        public string Title { get; set; }
        public string PasswordExpirationDate { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GetCurrentUserInfoResponseContactInformationType ContactInformation { get; set; }
    }

    public class GetCurrentUserInfoResponseContactInformationType
    {
        public string CellPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Website { get; set; }
    }

    public class EstimateClosingFeeResponse
    {
        public EstimateClosingFeeResponseClosingFeeEstimateType ClosingFeeEstimate { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateType
    {
        [JsonProperty("ClosingFeeEstimateID")]
        public int ClosingFeeEstimateId { get; set; }
        public EstimateClosingFeeResponseClosingFeeEstimateTypeHUDFeesTypeItem[] HUDFees { get; set; }
        public EstimateClosingFeeResponseClosingFeeEstimateTypeGFETypeItem[] GFE { get; set; }
        public EstimateClosingFeeResponseClosingFeeEstimateTypePremiumsType Premiums { get; set; }
        public string Timestamp { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateTypeHUDFeesTypeItem
    {
        public int Amount { get; set; }
        public string Description { get; set; }
        public string LineNumber { get; set; }
        public int BuyerAmount { get; set; }
        public int BuyerPOCAmount { get; set; }
        public int SellerAmount { get; set; }
        public int SellerPOCAmount { get; set; }
        public int OtherPOCAmount { get; set; }
        public EstimateClosingFeeResponseClosingFeeEstimateTypeHUDFeesTypeItemOtherPOCPartnerTypeType OtherPOCPartnerType { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateTypeHUDFeesTypeItemOtherPOCPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateTypeGFETypeItem
    {
        public string Description { get; set; }
        public int Amount { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateTypePremiumsType
    {
        public int LendersPremium { get; set; }
        public int FullLendersPremium { get; set; }
    }

    public class EstimateClosingFeeInput
    {
        public EstimateClosingFeeInputTransactionProductTypeType TransactionProductType { get; set; }
        public string SettlementStatementVersion { get; set; }
        public int? SalesPrice { get; set; }
        public EstimateClosingFeeInputLoansTypeItem[] Loans { get; set; }
        public EstimateClosingFeeInputPropertiesTypeItem[] Properties { get; set; }
        public EstimateClosingFeeInputFilePartnersTypeItem[] FilePartners { get; set; }
        public EstimateClosingFeeInputEndorsementsTypeItem[] Endorsements { get; set; }
    }

    public class EstimateClosingFeeInputTransactionProductTypeType
    {
        [JsonProperty("TransactionTypeID")]
        public int? TransactionTypeId { get; set; }

        [JsonProperty("ProductTypeID")]
        public int? ProductTypeId { get; set; }
    }

    public class EstimateClosingFeeInputLoansTypeItem
    {
        public int? LienPosition { get; set; }
        public int? LoanAmount { get; set; }
        public string LoanType { get; set; }
    }

    public class EstimateClosingFeeInputPropertiesTypeItem
    {
        public bool? IsPrimary { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
    }

    public class EstimateClosingFeeInputFilePartnersTypeItem
    {
        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int? PartnerId { get; set; }
        public EstimateClosingFeeInputFilePartnersTypeItemPartnerTypeType PartnerType { get; set; }
    }

    public class EstimateClosingFeeInputFilePartnersTypeItemPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int? PartnerTypeId { get; set; }
    }

    public class EstimateClosingFeeInputEndorsementsTypeItem
    {
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Infoquery;

    public partial class WorkflowManagedActions
    {
        public InfoqueryActions Infoquery(string connectionId) => new InfoqueryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfoqueryTriggers Infoquery(string connectionId) => new InfoqueryTriggers(connectionId);
    }
}