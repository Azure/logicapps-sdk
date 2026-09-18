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
        public IBodyWorkflowAction<LinkPostResponse> Link([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodyttl = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyttl, nameof(bodyttl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyttl != null)
                {
                    body["ttl"] = SourceExpressionConverter.ConvertToken(bodyttl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LinkPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<bool> LinkDelete([WorkflowExpression] Func<string> bodykey = null)
        {
            SourceExpression.Validate(bodykey, nameof(bodykey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/destroy/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodykey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<bool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urldevip")]
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<int> bodyttl = null)
        {
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodyttl, nameof(bodyttl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages/create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodyttl != null)
                {
                    body["ttl"] = SourceExpressionConverter.ConvertToken(bodyttl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MessagePostResponse>(BuildSourceInput);
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