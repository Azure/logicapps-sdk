//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smarp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmarpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smarp")]
        public IBodyWorkflowAction<SmarpRetrieveChannelListResponseItem[], ApiConnectionActionConfiguration> SmarpRetrieveChannelList()
        {
            return new DeferredBodyAction<SmarpRetrieveChannelListResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/channel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SmarpRetrieveChannelListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smarp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SmarpCreate(Expression<Func<SmarpCreatePostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/post";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SmarpTriggers([ConnectionName] string connectionId)
    {
    }

    public class SmarpRetrieveChannelListResponseItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SmarpCreatePostInput
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("channelList", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ChannelList { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("proposed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Proposed { get; set; } = true;

        [JsonProperty("shareable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Shareable { get; set; } = true;

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smarp;

    public partial class WorkflowManagedActions
    {
        public SmarpActions Smarp(string connectionId) => new SmarpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmarpTriggers Smarp(string connectionId) => new SmarpTriggers(connectionId);
    }
}