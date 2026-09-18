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
        public IBodyWorkflowAction<JToken> GetADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId)
        {
            var apiCallPath = "/getdocument";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
            callPayload.Headers["document_id"] = ExpressionConverter.Convert(documentId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<CreateADocumentResponse> CreateADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<object> createSchema = null)
        {
            var apiCallPath = "/createdocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
            callPayload.Body = ExpressionConverter.ConvertO(createSchema);
            return new ApiConnectionAction<CreateADocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<DeleteADocumentResponse> DeleteADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId)
        {
            var apiCallPath = "/deletedocument";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
            callPayload.Headers["document_id"] = ExpressionConverter.Convert(documentId);
            return new ApiConnectionAction<DeleteADocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<UpdateADocumentResponse> UpdateADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<object> updateSchema = null)
        {
            var apiCallPath = "/updatedocument";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
            callPayload.Headers["document_id"] = ExpressionConverter.Convert(documentId);
            callPayload.Body = ExpressionConverter.ConvertO(updateSchema);
            return new ApiConnectionAction<UpdateADocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<JToken[]> GetAllDocumentsByType([WorkflowExpression] Func<string> documentType)
        {
            var apiCallPath = "/getalldocumentsbytype";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = ExpressionConverter.Convert(documentType);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }
    }

    public class VarunaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> SubscribeTrigger([WorkflowExpression] Func<string> bodytriggerName, [WorkflowExpression] Func<int> bodywhen = null, string triggerName = null, FlowRecurrence recurrence = null)
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

            body["Endpoint"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
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