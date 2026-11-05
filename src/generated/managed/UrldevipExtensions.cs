//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Urldevip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UrldevipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<LinkResponse, ApiConnectionActionConfiguration> Link(Expression<Func<LinkBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> LinkDelete(Expression<Func<LinkDeleteBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/destroy/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<MessageResponse, ApiConnectionActionConfiguration> Message(Expression<Func<MessageBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessageResponse>(callPayload);
            });
        }
    }

    public class UrldevipTriggers([ConnectionName] string connectionId)
    {
    }

    public class LinkResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }
    }

    public class LinkBodyInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("ttl")]
        public int? Ttl { get; set; }
    }

    public class LinkDeleteBodyInput
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class MessageResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("message_url")]
        public string MessageUrl { get; set; }
    }

    public class MessageBodyInput
    {
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("ttl")]
        public int? Ttl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Urldevip;

    public partial class WorkflowManagedActions
    {
        public UrldevipActions Urldevip(string connectionId) => new UrldevipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UrldevipTriggers Urldevip(string connectionId) => new UrldevipTriggers(connectionId);
    }
}