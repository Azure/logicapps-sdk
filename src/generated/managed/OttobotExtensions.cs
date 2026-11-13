//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ottobot
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OttobotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendAttachmentsToUrl(Expression<Func<SendAttachmentsToUrlBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        public IBodyWorkflowAction<Response, ApiConnectionActionConfiguration> ReturnResultsToBot(Expression<Func<string>> returnResultUrl, Expression<Func<ReturnResultsToBotBodyInput>> body)
        {
            var __workflow_returnResultUrl = WorkflowExpression.Compile(returnResultUrl, nameof(returnResultUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/skills/results";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["returnResultURL"] = ExpressionConverter.Convert(__workflow_returnResultUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Response>(callPayload);
            });
        }
    }

    public class OttobotTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendAttachmentsToUrlBodyInput
    {
        public SendAttachmentsToUrlBodyInput(string apiUrl, string attachmentUrl, string attachmentFileName)
        {
            this.ApiUrl = apiUrl;
            this.AttachmentUrl = attachmentUrl;
            this.AttachmentFileName = attachmentFileName;
        }

        [JsonProperty("additionalParameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AdditionalParameters { get; set; } = JToken.Parse("{}");

        [JsonProperty("apiRequestHeaders", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ApiRequestHeaders { get; set; } = JToken.Parse("{}");

        [JsonProperty("apiUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiUrl { get; set; }

        [JsonProperty("attachmentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AttachmentUrl { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AttachmentFileName { get; set; }
    }

    public class Response
    {
        [JsonProperty("message")]
        public string ResultMessage { get; set; }
    }

    public class ReturnResultsToBotBodyInput
    {
        public ReturnResultsToBotBodyInput(string text, bool endRequest)
        {
            this.Text = text;
            this.EndRequest = endRequest;
        }

        [JsonProperty("adaptiveCard")]
        public AdaptiveCard AdaptiveCard { get; set; }

        [JsonProperty("renderPreformattedText")]
        public bool? RenderPreformattedText { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("endRequest", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EndRequest { get; set; }
    }

    public class AdaptiveCard
    {
        public AdaptiveCard(string adaptiveCardSchema, string adaptiveCardType, string adaptiveCardVersion)
        {
            this.AdaptiveCardSchema = adaptiveCardSchema;
            this.AdaptiveCardType = adaptiveCardType;
            this.AdaptiveCardVersion = adaptiveCardVersion;
        }

        [JsonProperty("$schema", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AdaptiveCardSchema { get; set; }

        [JsonProperty("actions")]
        public JToken[] AdaptiveCardActions { get; set; }

        [JsonProperty("body")]
        public JToken[] AdaptiveCardBody { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AdaptiveCardType { get; set; }

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AdaptiveCardVersion { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ottobot;

    public partial class WorkflowManagedActions
    {
        public OttobotActions Ottobot(string connectionId) => new OttobotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OttobotTriggers Ottobot(string connectionId) => new OttobotTriggers(connectionId);
    }
}