//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boldsign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BoldsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IBodyWorkflowAction<SendDocumentFromTemplateResponse> SendDocumentFromTemplate(Expression<Func<string>> templateId, Expression<Func<bool>> isSandbox, Expression<Func<string>> title, Expression<Func<string>> message = null, Expression<Func<string>> cc = null, Expression<Func<string>> brandId = null, Expression<Func<string>> onBehalfOf = null, Expression<Func<int>> expiryDays = null, Expression<Func<string>> labels = null, Expression<Func<bool>> hideDocumentId = null, Expression<Func<bool>> enablePrintAndSign = null, Expression<Func<bool>> enableReassign = null, Expression<Func<bool>> enableAutoReminder = null, Expression<Func<object>> signers = null)
        {
            var apiCallPath = "/v1/template/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["templateId"] = CSharpExpressionConverter.ConvertO(templateId);
            callPayload.Queries["isSandbox"] = CSharpExpressionConverter.ConvertO(isSandbox);
            callPayload.Queries["title"] = CSharpExpressionConverter.ConvertO(title);
            if (message != null)
                callPayload.Queries["message"] = CSharpExpressionConverter.ConvertO(message);
            if (cc != null)
                callPayload.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (brandId != null)
                callPayload.Queries["brandId"] = CSharpExpressionConverter.ConvertO(brandId);
            if (onBehalfOf != null)
                callPayload.Queries["onBehalfOf"] = CSharpExpressionConverter.ConvertO(onBehalfOf);
            callPayload.Queries["expiryDays"] = Convert.ToString(60);
            if (expiryDays != null)
                callPayload.Queries["expiryDays"] = CSharpExpressionConverter.ConvertO(expiryDays);
            if (labels != null)
                callPayload.Queries["labels"] = CSharpExpressionConverter.ConvertO(labels);
            if (hideDocumentId != null)
                callPayload.Queries["hideDocumentId"] = CSharpExpressionConverter.ConvertO(hideDocumentId);
            callPayload.Queries["enablePrintAndSign"] = Convert.ToString(false);
            if (enablePrintAndSign != null)
                callPayload.Queries["enablePrintAndSign"] = CSharpExpressionConverter.ConvertO(enablePrintAndSign);
            callPayload.Queries["enableReassign"] = Convert.ToString(true);
            if (enableReassign != null)
                callPayload.Queries["enableReassign"] = CSharpExpressionConverter.ConvertO(enableReassign);
            callPayload.Queries["enableAutoReminder"] = Convert.ToString(false);
            if (enableAutoReminder != null)
                callPayload.Queries["enableAutoReminder"] = CSharpExpressionConverter.ConvertO(enableAutoReminder);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(signers);
            return new ApiConnectionAction<SendDocumentFromTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IWorkflowAction DownloadDocument(Expression<Func<string>> documentId, Expression<Func<string>> onBehalfOf = null)
        {
            var apiCallPath = "/v1/document/download";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentId"] = CSharpExpressionConverter.ConvertO(documentId);
            if (onBehalfOf != null)
                callPayload.Queries["onBehalfOf"] = CSharpExpressionConverter.ConvertO(onBehalfOf);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IWorkflowAction DownloadAuditTrail(Expression<Func<string>> documentId, Expression<Func<string>> onBehalfOf = null)
        {
            var apiCallPath = "/v1/document/downloadAuditLog";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentId"] = CSharpExpressionConverter.ConvertO(documentId);
            if (onBehalfOf != null)
                callPayload.Queries["onBehalfOf"] = CSharpExpressionConverter.ConvertO(onBehalfOf);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IBodyWorkflowAction<DocumentPropertiesResponse> GetDocumentStatus(Expression<Func<string>> documentId)
        {
            var apiCallPath = "/v1/document/properties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentId"] = CSharpExpressionConverter.ConvertO(documentId);
            return new ApiConnectionAction<DocumentPropertiesResponse>(callPayload);
        }
    }

    public class BoldsignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AddWebHooksResponse> WebHooks(Expression<Func<eventsInput>> events, Expression<Func<bool>> bodyadminMode, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WebHooks/AddWebHooksAPIForPowerAutomate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["events"] = CSharpExpressionConverter.Convert(events);
            var body = new JObject();
            var bodypropCount = 0;
            body["name"] = "Power Automate Webhook";
            bodypropCount++;
            body["events"] = "Sent";
            bodypropCount++;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            body["environment"] = "Live";
            bodypropCount++;
            body["isActive"] = true;
            bodypropCount++;
            body["webhookType"] = "AccountCallback";
            bodypropCount++;
            bodypropCount++;
            body["adminMode"] = CSharpExpressionConverter.ConvertToken(bodyadminMode);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<AddWebHooksResponse>(callPayload, triggerName, recurrence);
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