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
        public IWorkflowAction<ApiConnectionActionConfiguration> SendAttachmentsToUrl(Expression<Func<SendAttachmentsToUrlInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        public IBodyWorkflowAction<Response, ApiConnectionActionConfiguration> ReturnResultsToBot(Expression<Func<string>> returnResultURL, Expression<Func<ReturnResultsToBotInput>> body = null)
        {
            var __workflow_returnResultURL = WorkflowExpression.Compile(returnResultURL, nameof(returnResultURL), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/skills/results";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["returnResultURL"] = ExpressionConverter.Convert(__workflow_returnResultURL);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Response>(callPayload);
            });
        }
    }

    public class OttobotTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendAttachmentsToUrlInput
    {
        [JsonProperty("additionalParameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AdditionalParameters { get; set; } = JToken.Parse("{}");

        [JsonProperty("apiRequestHeaders", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ApiRequestHeaders { get; set; } = JToken.Parse("{}");

        [JsonProperty("apiUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string APIURL { get; set; }

        [JsonProperty("attachmentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AttachmentURL { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AttachmentFileName { get; set; }
    }

    public class Response
    {
        [JsonProperty("message")]
        public string ResultMessage { get; set; }
    }

    public class ReturnResultsToBotInput
    {
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
        [JsonProperty("$schema")]
        public string AdaptiveCardSchema { get; set; }

        [JsonProperty("actions")]
        public JToken[] AdaptiveCardActions { get; set; }

        [JsonProperty("body")]
        public JToken[] AdaptiveCardBody { get; set; }

        [JsonProperty("type")]
        public string AdaptiveCardType { get; set; }

        [JsonProperty("version")]
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