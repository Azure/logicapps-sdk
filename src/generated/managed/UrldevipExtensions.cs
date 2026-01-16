//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Urldevip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UrldevipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<LinkPostResponse> LinkPost(Expression<Func<string>> bodyurl, Expression<Func<int>> bodyttl = null)
        {
            var apiCallPath = "/create/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyttl != null)
            {
                body["ttl"] = ExpressionConverter.ConvertO(bodyttl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LinkPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<bool> LinkDelete(Expression<Func<string>> bodykey = null)
        {
            var apiCallPath = "/destroy/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<MessagePostResponse> MessagePost(Expression<Func<string>> bodymessage, Expression<Func<int>> bodyttl = null)
        {
            var apiCallPath = "/messages/create/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            if (bodyttl != null)
            {
                body["ttl"] = ExpressionConverter.ConvertO(bodyttl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MessagePostResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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