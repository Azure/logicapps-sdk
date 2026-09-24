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
        public IBodyWorkflowAction<JToken> GetADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentType, nameof(documentType), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getdocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = SourceExpressionConverter.ConvertO(documentType);
                callPayload.Headers["document_id"] = SourceExpressionConverter.ConvertO(documentId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<CreateADocumentResponse> CreateADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<object> createSchema = null)
        {
            SourceExpression.Validate(documentType, nameof(documentType), required: true);
            SourceExpression.Validate(createSchema, nameof(createSchema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createdocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = SourceExpressionConverter.ConvertO(documentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(createSchema);
                return callPayload;
            }

            return new ApiConnectionAction<CreateADocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<DeleteADocumentResponse> DeleteADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentType, nameof(documentType), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deletedocument";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = SourceExpressionConverter.ConvertO(documentType);
                callPayload.Headers["document_id"] = SourceExpressionConverter.ConvertO(documentId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteADocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<UpdateADocumentResponse> UpdateADocument([WorkflowExpression] Func<string> documentType, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<object> updateSchema = null)
        {
            SourceExpression.Validate(documentType, nameof(documentType), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(updateSchema, nameof(updateSchema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updatedocument";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = SourceExpressionConverter.ConvertO(documentType);
                callPayload.Headers["document_id"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(updateSchema);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateADocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "varuna")]
        public IBodyWorkflowAction<JToken[]> GetAllDocumentsByType([WorkflowExpression] Func<string> documentType)
        {
            SourceExpression.Validate(documentType, nameof(documentType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getalldocumentsbytype";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["document_type"] = SourceExpressionConverter.ConvertO(documentType);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }
    }

    public class VarunaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> SubscribeTrigger([WorkflowExpression] Func<string> bodytriggerName, [WorkflowExpression] Func<int> bodywhen = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytriggerName, nameof(bodytriggerName), required: true);
            SourceExpression.Validate(bodywhen, nameof(bodywhen), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                body["Name"] = SourceExpressionConverter.ConvertToken(bodytriggerName);
                if (bodywhen != null)
                {
                    body["When"] = SourceExpressionConverter.ConvertToken(bodywhen);
                    bodypropCount++;
                }

                body["Endpoint"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
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