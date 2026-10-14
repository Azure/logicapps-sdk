//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boldsign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BoldsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IBodyWorkflowAction<SendDocumentFromTemplateResponse> SendDocumentFromTemplate(Expression<Func<string>> templateId, Expression<Func<bool>> isSandbox, Expression<Func<string>> title, Expression<Func<string>> message = null, Expression<Func<string>> cc = null, Expression<Func<string>> brandId = null, Expression<Func<string>> onBehalfOf = null, Expression<Func<int>> expiryDays = null, Expression<Func<string>> labels = null, Expression<Func<bool>> hideDocumentId = null, Expression<Func<bool>> enablePrintAndSign = null, Expression<Func<bool>> enableReassign = null, Expression<Func<bool>> enableAutoReminder = null, Expression<Func<object>> signers = null)
        {
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            var __workflow_isSandbox = isSandbox == null ? null : WorkflowExpression.Compile(isSandbox);
            WorkflowExpression.Validate(__workflow_isSandbox, nameof(isSandbox), required: true);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: true);
            var __workflow_message = message == null ? null : WorkflowExpression.Compile(message);
            WorkflowExpression.Validate(__workflow_message, nameof(message), required: false);
            var __workflow_cc = cc == null ? null : WorkflowExpression.Compile(cc);
            WorkflowExpression.Validate(__workflow_cc, nameof(cc), required: false);
            var __workflow_brandId = brandId == null ? null : WorkflowExpression.Compile(brandId);
            WorkflowExpression.Validate(__workflow_brandId, nameof(brandId), required: false);
            var __workflow_onBehalfOf = onBehalfOf == null ? null : WorkflowExpression.Compile(onBehalfOf);
            WorkflowExpression.Validate(__workflow_onBehalfOf, nameof(onBehalfOf), required: false);
            var __workflow_expiryDays = expiryDays == null ? null : WorkflowExpression.Compile(expiryDays);
            WorkflowExpression.Validate(__workflow_expiryDays, nameof(expiryDays), required: false);
            var __workflow_labels = labels == null ? null : WorkflowExpression.Compile(labels);
            WorkflowExpression.Validate(__workflow_labels, nameof(labels), required: false);
            var __workflow_hideDocumentId = hideDocumentId == null ? null : WorkflowExpression.Compile(hideDocumentId);
            WorkflowExpression.Validate(__workflow_hideDocumentId, nameof(hideDocumentId), required: false);
            var __workflow_enablePrintAndSign = enablePrintAndSign == null ? null : WorkflowExpression.Compile(enablePrintAndSign);
            WorkflowExpression.Validate(__workflow_enablePrintAndSign, nameof(enablePrintAndSign), required: false);
            var __workflow_enableReassign = enableReassign == null ? null : WorkflowExpression.Compile(enableReassign);
            WorkflowExpression.Validate(__workflow_enableReassign, nameof(enableReassign), required: false);
            var __workflow_enableAutoReminder = enableAutoReminder == null ? null : WorkflowExpression.Compile(enableAutoReminder);
            WorkflowExpression.Validate(__workflow_enableAutoReminder, nameof(enableAutoReminder), required: false);
            var __workflow_signers = signers == null ? null : WorkflowExpression.Compile(signers);
            WorkflowExpression.Validate(__workflow_signers, nameof(signers), required: false);
            return new DeferredBodyAction<SendDocumentFromTemplateResponse>(() =>
            {
                var apiCallPath = "/v1/template/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Queries["isSandbox"] = ExpressionConverter.Convert(__workflow_isSandbox);
                callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
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
        public IWorkflowAction DownloadDocument(Expression<Func<string>> documentId, Expression<Func<string>> onBehalfOf = null)
        {
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_onBehalfOf = onBehalfOf == null ? null : WorkflowExpression.Compile(onBehalfOf);
            WorkflowExpression.Validate(__workflow_onBehalfOf, nameof(onBehalfOf), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DownloadAuditTrail(Expression<Func<string>> documentId, Expression<Func<string>> onBehalfOf = null)
        {
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_onBehalfOf = onBehalfOf == null ? null : WorkflowExpression.Compile(onBehalfOf);
            WorkflowExpression.Validate(__workflow_onBehalfOf, nameof(onBehalfOf), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<DocumentPropertiesResponse> GetDocumentStatus(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<DocumentPropertiesResponse>(() =>
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
        public IBodyWorkflowTrigger<AddWebHooksResponse> WebHooks(Expression<Func<eventsInput>> events, Expression<Func<bool>> bodyadminMode, FlowRecurrence recurrence = null)
        {
            var __workflow_events = events == null ? null : WorkflowExpression.Compile(events);
            WorkflowExpression.Validate(__workflow_events, nameof(events), required: true);
            var __workflow_bodyadminMode = bodyadminMode == null ? null : WorkflowExpression.Compile(bodyadminMode);
            WorkflowExpression.Validate(__workflow_bodyadminMode, nameof(bodyadminMode), required: true);
            return new DeferredBodyTrigger<AddWebHooksResponse>(() =>
            {
                var apiCallPath = "/WebHooks/AddWebHooksAPIForPowerAutomate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["events"] = ExpressionConverter.Convert(__workflow_events);
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
                body["adminMode"] = ExpressionConverter.ConvertO(__workflow_bodyadminMode);
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
