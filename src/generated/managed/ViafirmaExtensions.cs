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
        public IBodyWorkflowAction<SendSignRequestResponse, ApiConnectionActionConfiguration> SendSignRequest(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<SendSignRequestBodyInput>> body)
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
        public IBodyWorkflowAction<CreateSignRequestResponse, ApiConnectionActionConfiguration> CreateSignRequest(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<CreateSignRequestBodyInput>> body)
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

    public class SendSignRequestBodyInput
    {
        public SendSignRequestBodyInput(string groupCode, BodyInputNotificationType notification, BodyInputDocumentType document)
        {
            this.GroupCode = groupCode;
            this.Notification = notification;
            this.Document = document;
        }

        [JsonProperty("groupCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupCode { get; set; }

        [JsonProperty("workflow", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendSignRequestBodyInputWorkflowType Workflow { get; set; } = new SendSignRequestBodyInputWorkflowType();

        [JsonProperty("notification", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputNotificationType Notification { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("callbackMails")]
        public string CallbackMails { get; set; }
    }

    public class SendSignRequestBodyInputWorkflowType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "WEB";
    }

    public class BodyInputNotificationType
    {
        public BodyInputNotificationType(BodyInputNotificationTypeSharedLinkType sharedLink)
        {
            this.SharedLink = sharedLink;
        }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("sharedLink", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputNotificationTypeSharedLinkType SharedLink { get; set; }
    }

    public class BodyInputNotificationTypeSharedLinkType
    {
        public BodyInputNotificationTypeSharedLinkType(string email)
        {
            this.Email = email;
        }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class BodyInputDocumentType
    {
        public BodyInputDocumentType(string templateCode)
        {
            this.TemplateCode = templateCode;
        }

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

    public class CreateSignRequestBodyInput
    {
        public CreateSignRequestBodyInput(string groupCode, BodyInputDocumentType document)
        {
            this.GroupCode = groupCode;
            this.Document = document;
        }

        [JsonProperty("groupCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupCode { get; set; }

        [JsonProperty("workflow", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSignRequestBodyInputWorkflowType Workflow { get; set; } = new CreateSignRequestBodyInputWorkflowType();

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }
    }

    public class CreateSignRequestBodyInputWorkflowType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "PRESENTIAL";
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