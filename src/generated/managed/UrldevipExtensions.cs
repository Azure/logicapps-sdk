//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Urldevip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UrldevipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        [WorkflowExpressionFactory(nameof(__BuildLink))]
        public IBodyWorkflowAction<LinkPostResponse> Link([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodyttl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkPostResponse> __BuildLink(WorkflowValue<string> bodyurl, WorkflowValue<int> bodyttl = null)
        {
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowValue.Validate(bodyttl, nameof(bodyttl), required: false);
            return new DeferredBodyAction<LinkPostResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        [WorkflowExpressionFactory(nameof(__BuildLinkDelete))]
        public IBodyWorkflowAction<bool> LinkDelete([WorkflowExpression] Func<string> bodykey = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildLinkDelete(WorkflowValue<string> bodykey = null)
        {
            WorkflowValue.Validate(bodykey, nameof(bodykey), required: false);
            return new DeferredBodyAction<bool>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        [WorkflowExpressionFactory(nameof(__BuildMessage))]
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<int> bodyttl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessagePostResponse> __BuildMessage(WorkflowValue<string> bodymessage, WorkflowValue<int> bodyttl = null)
        {
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowValue.Validate(bodyttl, nameof(bodyttl), required: false);
            return new DeferredBodyAction<MessagePostResponse>(() =>
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
