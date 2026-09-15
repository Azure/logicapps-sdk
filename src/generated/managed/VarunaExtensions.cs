//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Varuna
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VarunaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<JToken> GetADocument(Expression<Func<string>> documentType, Expression<Func<string>> documentId)
        {
            var apiCallPath = "/getdocument";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = CSharpExpressionConverter.ConvertO(documentType);
            callPayload.Headers["document_id"] = CSharpExpressionConverter.ConvertO(documentId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<CreateADocumentResponse> CreateADocument(Expression<Func<string>> documentType, Expression<Func<object>> createSchema = null)
        {
            var apiCallPath = "/createdocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = CSharpExpressionConverter.ConvertO(documentType);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(createSchema);
            return new ApiConnectionAction<CreateADocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<DeleteADocumentResponse> DeleteADocument(Expression<Func<string>> documentType, Expression<Func<string>> documentId)
        {
            var apiCallPath = "/deletedocument";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = CSharpExpressionConverter.ConvertO(documentType);
            callPayload.Headers["document_id"] = CSharpExpressionConverter.ConvertO(documentId);
            return new ApiConnectionAction<DeleteADocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<UpdateADocumentResponse> UpdateADocument(Expression<Func<string>> documentType, Expression<Func<string>> documentId, Expression<Func<object>> updateSchema = null)
        {
            var apiCallPath = "/updatedocument";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = CSharpExpressionConverter.ConvertO(documentType);
            callPayload.Headers["document_id"] = CSharpExpressionConverter.ConvertO(documentId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(updateSchema);
            return new ApiConnectionAction<UpdateADocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<JToken[]> GetAllDocumentsByType(Expression<Func<string>> documentType)
        {
            var apiCallPath = "/getalldocumentsbytype";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["document_type"] = CSharpExpressionConverter.ConvertO(documentType);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }
    }

    public class VarunaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> SubscribeTrigger(Expression<Func<string>> bodytriggerName, Expression<Func<int>> bodywhen = null, string triggerName = null, FlowRecurrence recurrence = null)
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
            body["Name"] = CSharpExpressionConverter.ConvertToken(bodytriggerName);
            if (bodywhen != null)
            {
                body["When"] = CSharpExpressionConverter.ConvertToken(bodywhen);
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