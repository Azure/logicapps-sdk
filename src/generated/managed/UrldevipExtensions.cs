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
        public IBodyWorkflowAction<LinkPostResponse, ApiConnectionActionConfiguration> Link(Expression<Func<LinkPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LinkPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LinkPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> LinkDelete(Expression<Func<LinkDeleteInput>> body = null)
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
        public IBodyWorkflowAction<MessagePostResponse, ApiConnectionActionConfiguration> Message(Expression<Func<MessagePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MessagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessagePostResponse>(callPayload);
            });
        }
    }

    public class UrldevipTriggers([ConnectionName] string connectionId)
    {
    }

    public class LinkPostResponse
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

    public class LinkPostInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("ttl")]
        public int? Ttl { get; set; }
    }

    public class LinkDeleteInput
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class MessagePostResponse
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

    public class MessagePostInput
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