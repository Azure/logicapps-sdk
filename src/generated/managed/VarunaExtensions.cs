//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Varuna
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VarunaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        [WorkflowExpressionFactory(nameof(__BuildGetADocument))]
        public IBodyWorkflowAction<JToken> GetADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetADocument(WorkflowValue<string> documentType, WorkflowValue<string> documentId)
        {
            WorkflowValue.Validate(documentType, nameof(documentType), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getdocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
                callPayload.Headers["document_id"] = ExpressionConverter.Convert(documentId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        [WorkflowExpressionFactory(nameof(__BuildCreateADocument))]
        public IBodyWorkflowAction<CreateADocumentResponse> CreateADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<object> createSchema = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateADocumentResponse> __BuildCreateADocument(WorkflowValue<string> documentType, WorkflowValue<object> createSchema = null)
        {
            WorkflowValue.Validate(documentType, nameof(documentType), required: true);
            WorkflowValue.Validate(createSchema, nameof(createSchema), required: false);
            return new DeferredBodyAction<CreateADocumentResponse>(() =>
            {
                var apiCallPath = "/createdocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
                callPayload.Body = ExpressionConverter.ConvertO(createSchema);
                return new ApiConnectionAction<CreateADocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteADocument))]
        public IBodyWorkflowAction<DeleteADocumentResponse> DeleteADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteADocumentResponse> __BuildDeleteADocument(WorkflowValue<string> documentType, WorkflowValue<string> documentId)
        {
            WorkflowValue.Validate(documentType, nameof(documentType), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<DeleteADocumentResponse>(() =>
            {
                var apiCallPath = "/deletedocument";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
                callPayload.Headers["document_id"] = ExpressionConverter.Convert(documentId);
                return new ApiConnectionAction<DeleteADocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateADocument))]
        public IBodyWorkflowAction<UpdateADocumentResponse> UpdateADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<object> updateSchema = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateADocumentResponse> __BuildUpdateADocument(WorkflowValue<string> documentType, WorkflowValue<string> documentId, WorkflowValue<object> updateSchema = null)
        {
            WorkflowValue.Validate(documentType, nameof(documentType), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(updateSchema, nameof(updateSchema), required: false);
            return new DeferredBodyAction<UpdateADocumentResponse>(() =>
            {
                var apiCallPath = "/updatedocument";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
                callPayload.Headers["document_id"] = ExpressionConverter.Convert(documentId);
                callPayload.Body = ExpressionConverter.ConvertO(updateSchema);
                return new ApiConnectionAction<UpdateADocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllDocumentsByType))]
        public IBodyWorkflowAction<JToken[]> GetAllDocumentsByType([WorkflowExpression] Func<string> documentType)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetAllDocumentsByType(WorkflowValue<string> documentType)
        {
            WorkflowValue.Validate(documentType, nameof(documentType), required: true);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/getalldocumentsbytype";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }
    }

    public class VarunaTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildSubscribeTrigger))]
        public IBodyWorkflowTrigger<JToken> SubscribeTrigger([WorkflowExpression] Func<string> bodytriggerName, [WorkflowExpression] Func<int> bodywhen = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildSubscribeTrigger(WorkflowValue<string> bodytriggerName, WorkflowValue<int> bodywhen = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytriggerName, nameof(bodytriggerName), required: true);
            WorkflowValue.Validate(bodywhen, nameof(bodywhen), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/subscribewebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Acknowledge"] = "FireAndForget";
                bodypropCount++;
                body["SubscriptionMode"] = "WebHookHttpEndpoint";
                bodypropCount++;
                body["MessageTemplateFormat"] = "Json";
                bodypropCount++;
                bodypropCount++;
                body["Name"] = ExpressionConverter.ConvertO(bodytriggerName);
                if (bodywhen != null)
                {
                    body["When"] = ExpressionConverter.ConvertO(bodywhen);
                    bodypropCount++;
                }

                body["Endpoint"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class CreateADocumentResponse
    {
        public string DocumentId { get; set; }
    }

    public class DeleteADocumentResponse
    {
        public string DocumentId { get; set; }
    }

    public class UpdateADocumentResponse
    {
        public string DocumentId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Varuna;

    public partial class WorkflowManagedActions
    {
        public VarunaActions Varuna(string connectionId) => new VarunaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VarunaTriggers Varuna(string connectionId) => new VarunaTriggers(connectionId);
    }
}
