//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Urldevip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class UrldevipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<LinkPostResponse> Link(Expression<Func<string>> bodyurl, Expression<Func<int>> bodyttl = null)
        {
            var __workflow_bodyurl = bodyurl == null ? null : WorkflowExpression.Compile(bodyurl);
            WorkflowExpression.Validate(__workflow_bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyttl = bodyttl == null ? null : WorkflowExpression.Compile(bodyttl);
            WorkflowExpression.Validate(__workflow_bodyttl, nameof(bodyttl), required: false);
            return new DeferredBodyAction<LinkPostResponse>(() =>
            {
                var apiCallPath = "/create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyttl != null)
                {
                    body["ttl"] = ExpressionConverter.ConvertO(__workflow_bodyttl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LinkPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<bool> LinkDelete(Expression<Func<string>> bodykey = null)
        {
            var __workflow_bodykey = bodykey == null ? null : WorkflowExpression.Compile(bodykey);
            WorkflowExpression.Validate(__workflow_bodykey, nameof(bodykey), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = "/destroy/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<MessagePostResponse> Message(Expression<Func<string>> bodymessage, Expression<Func<int>> bodyttl = null)
        {
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodyttl = bodyttl == null ? null : WorkflowExpression.Compile(bodyttl);
            WorkflowExpression.Validate(__workflow_bodyttl, nameof(bodyttl), required: false);
            return new DeferredBodyAction<MessagePostResponse>(() =>
            {
                var apiCallPath = "/messages/create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (__workflow_bodyttl != null)
                {
                    body["ttl"] = ExpressionConverter.ConvertO(__workflow_bodyttl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
