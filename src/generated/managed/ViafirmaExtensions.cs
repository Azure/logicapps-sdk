//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Viafirma
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ViafirmaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viafirma")]
        public IBodyWorkflowAction<SendSignRequestResponse, ApiConnectionActionConfiguration> SendSignRequest(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<SendSignRequestInput>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSignRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/documents/api/v3/messages/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSignRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viafirma")]
        public IBodyWorkflowAction<CreateSignRequestResponse, ApiConnectionActionConfiguration> CreateSignRequest(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<CreateSignRequestInput>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateSignRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/documents/api/v3/messages/dispatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSignRequestResponse>(callPayload);
            });
        }
    }

    public class ViafirmaTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSignRequestResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class SendSignRequestInput
    {
        [JsonProperty("groupCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupCode { get; set; }

        [JsonProperty("workflow", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendSignRequestInputWorkflowType Workflow { get; set; }

        [JsonProperty("notification", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendSignRequestInputNotificationType Notification { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendSignRequestInputDocumentType Document { get; set; }

        [JsonProperty("callbackMails")]
        public string CallbackMails { get; set; }
    }

    public class SendSignRequestInputWorkflowType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "WEB";
    }

    public class SendSignRequestInputNotificationType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("sharedLink", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendSignRequestInputNotificationTypeSharedLinkType SharedLink { get; set; }
    }

    public class SendSignRequestInputNotificationTypeSharedLinkType
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class SendSignRequestInputDocumentType
    {
        [JsonProperty("templateCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateCode { get; set; }
    }

    public class CreateSignRequestResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class CreateSignRequestInput
    {
        [JsonProperty("groupCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupCode { get; set; }

        [JsonProperty("workflow", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSignRequestInputWorkflowType Workflow { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSignRequestInputDocumentType Document { get; set; }
    }

    public class CreateSignRequestInputWorkflowType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "PRESENTIAL";
    }

    public class CreateSignRequestInputDocumentType
    {
        [JsonProperty("templateCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Viafirma;

    public partial class WorkflowManagedActions
    {
        public ViafirmaActions Viafirma(string connectionId) => new ViafirmaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ViafirmaTriggers Viafirma(string connectionId) => new ViafirmaTriggers(connectionId);
    }
}