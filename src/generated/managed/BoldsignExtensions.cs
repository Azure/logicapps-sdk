//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boldsign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BoldsignActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        [WorkflowExpressionFactory(nameof(__BuildSendDocumentFromTemplate))]
        public IBodyWorkflowAction<SendDocumentFromTemplateResponse> SendDocumentFromTemplate([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<bool> isSandbox, [WorkflowExpression] Func<string> title, [WorkflowExpression] Func<string> message = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> brandId = null, [WorkflowExpression] Func<string> onBehalfOf = null, [WorkflowExpression] Func<int> expiryDays = null, [WorkflowExpression] Func<string> labels = null, [WorkflowExpression] Func<bool> hideDocumentId = null, [WorkflowExpression] Func<bool> enablePrintAndSign = null, [WorkflowExpression] Func<bool> enableReassign = null, [WorkflowExpression] Func<bool> enableAutoReminder = null, [WorkflowExpression] Func<object> signers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendDocumentFromTemplateResponse> __BuildSendDocumentFromTemplate(WorkflowExpression<string> templateId, WorkflowExpression<bool> isSandbox, WorkflowExpression<string> title, WorkflowExpression<string> message = null, WorkflowExpression<string> cc = null, WorkflowExpression<string> brandId = null, WorkflowExpression<string> onBehalfOf = null, WorkflowExpression<int> expiryDays = null, WorkflowExpression<string> labels = null, WorkflowExpression<bool> hideDocumentId = null, WorkflowExpression<bool> enablePrintAndSign = null, WorkflowExpression<bool> enableReassign = null, WorkflowExpression<bool> enableAutoReminder = null, WorkflowExpression<object> signers = null)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(isSandbox, nameof(isSandbox), required: true);
            WorkflowExpression.Validate(title, nameof(title), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: false);
            WorkflowExpression.Validate(cc, nameof(cc), required: false);
            WorkflowExpression.Validate(brandId, nameof(brandId), required: false);
            WorkflowExpression.Validate(onBehalfOf, nameof(onBehalfOf), required: false);
            WorkflowExpression.Validate(expiryDays, nameof(expiryDays), required: false);
            WorkflowExpression.Validate(labels, nameof(labels), required: false);
            WorkflowExpression.Validate(hideDocumentId, nameof(hideDocumentId), required: false);
            WorkflowExpression.Validate(enablePrintAndSign, nameof(enablePrintAndSign), required: false);
            WorkflowExpression.Validate(enableReassign, nameof(enableReassign), required: false);
            WorkflowExpression.Validate(enableAutoReminder, nameof(enableAutoReminder), required: false);
            WorkflowExpression.Validate(signers, nameof(signers), required: false);
            return new DeferredBodyAction<SendDocumentFromTemplateResponse>(() =>
            {
                var apiCallPath = "/v1/template/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = ExpressionConverter.Convert(templateId);
                callPayload.Queries["isSandbox"] = ExpressionConverter.Convert(isSandbox);
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
                if (message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(message);
                if (cc != null)
                    callPayload.Queries["cc"] = ExpressionConverter.Convert(cc);
                if (brandId != null)
                    callPayload.Queries["brandId"] = ExpressionConverter.Convert(brandId);
                if (onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = ExpressionConverter.Convert(onBehalfOf);
                callPayload.Queries["expiryDays"] = Convert.ToString(60);
                if (expiryDays != null)
                    callPayload.Queries["expiryDays"] = ExpressionConverter.Convert(expiryDays);
                if (labels != null)
                    callPayload.Queries["labels"] = ExpressionConverter.Convert(labels);
                if (hideDocumentId != null)
                    callPayload.Queries["hideDocumentId"] = ExpressionConverter.Convert(hideDocumentId);
                callPayload.Queries["enablePrintAndSign"] = Convert.ToString(false);
                if (enablePrintAndSign != null)
                    callPayload.Queries["enablePrintAndSign"] = ExpressionConverter.Convert(enablePrintAndSign);
                callPayload.Queries["enableReassign"] = Convert.ToString(true);
                if (enableReassign != null)
                    callPayload.Queries["enableReassign"] = ExpressionConverter.Convert(enableReassign);
                callPayload.Queries["enableAutoReminder"] = Convert.ToString(false);
                if (enableAutoReminder != null)
                    callPayload.Queries["enableAutoReminder"] = ExpressionConverter.Convert(enableAutoReminder);
                callPayload.Body = ExpressionConverter.ConvertO(signers);
                return new ApiConnectionAction<SendDocumentFromTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadDocument))]
        public IWorkflowAction DownloadDocument([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> onBehalfOf = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDownloadDocument(WorkflowExpression<string> documentId, WorkflowExpression<string> onBehalfOf = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(onBehalfOf, nameof(onBehalfOf), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/document/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = ExpressionConverter.Convert(documentId);
                if (onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = ExpressionConverter.Convert(onBehalfOf);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadAuditTrail))]
        public IWorkflowAction DownloadAuditTrail([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> onBehalfOf = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDownloadAuditTrail(WorkflowExpression<string> documentId, WorkflowExpression<string> onBehalfOf = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(onBehalfOf, nameof(onBehalfOf), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/document/downloadAuditLog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = ExpressionConverter.Convert(documentId);
                if (onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = ExpressionConverter.Convert(onBehalfOf);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentStatus))]
        public IBodyWorkflowAction<DocumentPropertiesResponse> GetDocumentStatus([WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentPropertiesResponse> __BuildGetDocumentStatus(WorkflowExpression<string> documentId)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<DocumentPropertiesResponse>(() =>
            {
                var apiCallPath = "/v1/document/properties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = ExpressionConverter.Convert(documentId);
                return new ApiConnectionAction<DocumentPropertiesResponse>(callPayload);
            });
        }
    }

    public class BoldsignTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebHooks))]
        public IBodyWorkflowTrigger<AddWebHooksResponse> WebHooks([WorkflowExpression] Func<eventsInput> events,[WorkflowExpression] Func<bool> bodyadminMode,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<AddWebHooksResponse> __BuildWebHooks(WorkflowExpression<eventsInput> events,WorkflowExpression<bool> bodyadminMode,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(events, nameof(events), required: true);
            WorkflowExpression.Validate(bodyadminMode, nameof(bodyadminMode), required: true);
            return new DeferredBodyTrigger<AddWebHooksResponse>(() =>
            {
                var apiCallPath = "/WebHooks/AddWebHooksAPIForPowerAutomate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["events"] = ExpressionConverter.Convert(events);
                var body = new JObject();
                var bodypropCount = 0;
                body["name"] = "Power Automate Webhook";
                bodypropCount++;
                body["events"] = "Sent";
                bodypropCount++;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["environment"] = "Live";
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                body["webhookType"] = "AccountCallback";
                bodypropCount++;
                bodypropCount++;
                body["adminMode"] = ExpressionConverter.ConvertO(bodyadminMode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<AddWebHooksResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendDocumentFromTemplateResponse
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    public class DocumentPropertiesResponse
    {
        [JsonProperty("status")]
        public string DocumentStatus { get; set; }
    }

    public class AddWebHooksResponse
    {
        [JsonProperty("webhookId")]
        public string WebHookId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum eventsInput
    {
        Sent,
        Signed,
        Completed,
        Declined,
        Revoked,
        Reassigned,
        Expired,
        Viewed,
        AuthenticationFailed,
        DeliveryFailed,
        SendFailed,
        TemplateSendFailed,
        DraftCreated
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Boldsign;

    public partial class WorkflowManagedActions
    {
        public BoldsignActions Boldsign(string connectionId) => new BoldsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BoldsignTriggers Boldsign(string connectionId) => new BoldsignTriggers(connectionId);
    }
}