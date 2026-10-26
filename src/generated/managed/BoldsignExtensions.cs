//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boldsign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BoldsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IBodyWorkflowAction<SendDocumentFromTemplateResponse, ApiConnectionActionConfiguration> SendDocumentFromTemplate(Expression<Func<string>> templateId, Expression<Func<bool>> isSandbox, Expression<Func<object>> signers, Expression<Func<string>> message = null, Expression<Func<string>> cc = null, Expression<Func<string>> brandId = null, Expression<Func<string>> onBehalfOf = null, Expression<Func<int>> expiryDays = null, Expression<Func<string>> labels = null, Expression<Func<bool>> hideDocumentId = null, Expression<Func<bool>> enablePrintAndSign = null, Expression<Func<bool>> enableReassign = null, Expression<Func<bool>> enableAutoReminder = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_isSandbox = WorkflowExpression.Compile(isSandbox, nameof(isSandbox), required: true);
            var __workflow_signers = WorkflowExpression.Compile(signers, nameof(signers), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: false);
            var __workflow_cc = WorkflowExpression.Compile(cc, nameof(cc), required: false);
            var __workflow_brandId = WorkflowExpression.Compile(brandId, nameof(brandId), required: false);
            var __workflow_onBehalfOf = WorkflowExpression.Compile(onBehalfOf, nameof(onBehalfOf), required: false);
            var __workflow_expiryDays = WorkflowExpression.Compile(expiryDays, nameof(expiryDays), required: false);
            var __workflow_labels = WorkflowExpression.Compile(labels, nameof(labels), required: false);
            var __workflow_hideDocumentId = WorkflowExpression.Compile(hideDocumentId, nameof(hideDocumentId), required: false);
            var __workflow_enablePrintAndSign = WorkflowExpression.Compile(enablePrintAndSign, nameof(enablePrintAndSign), required: false);
            var __workflow_enableReassign = WorkflowExpression.Compile(enableReassign, nameof(enableReassign), required: false);
            var __workflow_enableAutoReminder = WorkflowExpression.Compile(enableAutoReminder, nameof(enableAutoReminder), required: false);
            return new DeferredBodyAction<SendDocumentFromTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/template/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Queries["isSandbox"] = ExpressionConverter.Convert(__workflow_isSandbox);
                if (__workflow_message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(__workflow_message);
                if (__workflow_cc != null)
                    callPayload.Queries["cc"] = ExpressionConverter.Convert(__workflow_cc);
                if (__workflow_brandId != null)
                    callPayload.Queries["brandId"] = ExpressionConverter.Convert(__workflow_brandId);
                if (__workflow_onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = ExpressionConverter.Convert(__workflow_onBehalfOf);
                callPayload.Queries["expiryDays"] = Convert.ToString(60);
                if (__workflow_expiryDays != null)
                    callPayload.Queries["expiryDays"] = ExpressionConverter.Convert(__workflow_expiryDays);
                if (__workflow_labels != null)
                    callPayload.Queries["labels"] = ExpressionConverter.Convert(__workflow_labels);
                if (__workflow_hideDocumentId != null)
                    callPayload.Queries["hideDocumentId"] = ExpressionConverter.Convert(__workflow_hideDocumentId);
                callPayload.Queries["enablePrintAndSign"] = Convert.ToString(false);
                if (__workflow_enablePrintAndSign != null)
                    callPayload.Queries["enablePrintAndSign"] = ExpressionConverter.Convert(__workflow_enablePrintAndSign);
                callPayload.Queries["enableReassign"] = Convert.ToString(true);
                if (__workflow_enableReassign != null)
                    callPayload.Queries["enableReassign"] = ExpressionConverter.Convert(__workflow_enableReassign);
                callPayload.Queries["enableAutoReminder"] = Convert.ToString(false);
                if (__workflow_enableAutoReminder != null)
                    callPayload.Queries["enableAutoReminder"] = ExpressionConverter.Convert(__workflow_enableAutoReminder);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_signers);
                return new ApiConnectionAction<SendDocumentFromTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<string>> documentId, Expression<Func<string>> onBehalfOf = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_onBehalfOf = WorkflowExpression.Compile(onBehalfOf, nameof(onBehalfOf), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/document/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = ExpressionConverter.Convert(__workflow_documentId);
                if (__workflow_onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = ExpressionConverter.Convert(__workflow_onBehalfOf);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadAuditTrail(Expression<Func<string>> documentId, Expression<Func<string>> onBehalfOf = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_onBehalfOf = WorkflowExpression.Compile(onBehalfOf, nameof(onBehalfOf), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/document/downloadAuditLog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = ExpressionConverter.Convert(__workflow_documentId);
                if (__workflow_onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = ExpressionConverter.Convert(__workflow_onBehalfOf);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IBodyWorkflowAction<DocumentPropertiesResponse, ApiConnectionActionConfiguration> GetDocumentStatus(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<DocumentPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/document/properties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = ExpressionConverter.Convert(__workflow_documentId);
                return new ApiConnectionAction<DocumentPropertiesResponse>(callPayload);
            });
        }
    }

    public class BoldsignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AddWebHooksResponse, ApiConnectionTriggerConfiguration> WebHooks(Expression<Func<eventsInput>> events, Expression<Func<WebHooksInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_events = WorkflowExpression.Compile(events, nameof(events), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<AddWebHooksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WebHooks/AddWebHooksAPIForPowerAutomate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["events"] = ExpressionConverter.Convert(__workflow_events);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class WebHooksInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "Sent";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("environment", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Environment { get; set; } = "Live";

        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsActive { get; set; } = true;

        [JsonProperty("webhookType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookType { get; set; } = "AccountCallback";

        [JsonProperty("adminMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AdminMode { get; set; } = false;
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