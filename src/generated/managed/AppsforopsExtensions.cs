//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appsforops
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppsforopsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appsforops")]
        public IBodyWorkflowAction<NPSCreateResponse, ApiConnectionActionConfiguration> ApiExtNPS(Expression<Func<ApiExtNPSPostInput>> model)
        {
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            return new DeferredBodyAction<NPSCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ext/NPS";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_model);
                return new ApiConnectionAction<NPSCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appsforops")]
        public IBodyWorkflowAction<TimelineCreateResponse, ApiConnectionActionConfiguration> ApiExtTimeline(Expression<Func<ApiExtTimelinePostInput>> model)
        {
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            return new DeferredBodyAction<TimelineCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ext/Timeline";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_model);
                return new ApiConnectionAction<TimelineCreateResponse>(callPayload);
            });
        }
    }

    public class AppsforopsTriggers([ConnectionName] string connectionId)
    {
    }

    public class NPSCreateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("additionalData")]
        public string AdditionalData { get; set; }
    }

    public class ApiExtNPSPostInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Score { get; set; }

        [JsonProperty("ratingDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RatingDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("additionalData")]
        public string AdditionalData { get; set; }
    }

    public class TimelineCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("channelName")]
        public string ChannelName { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("fromEmail")]
        public string FromEmail { get; set; }

        [JsonProperty("fromDisplayName")]
        public string FromDisplayName { get; set; }

        [JsonProperty("toEmail")]
        public string ToEmail { get; set; }

        [JsonProperty("toDisplayName")]
        public string ToDisplayName { get; set; }

        [JsonProperty("createdByDateTime")]
        public string CreatedByDateTime { get; set; }
    }

    public class ApiExtTimelinePostInput
    {
        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Source { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("toDisplayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToDisplayName { get; set; }

        [JsonProperty("toEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToEmail { get; set; }

        [JsonProperty("fromDisplayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromDisplayName { get; set; }

        [JsonProperty("fromEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromEmail { get; set; }

        [JsonProperty("createdByDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedByDateTime { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Appsforops;

    public partial class WorkflowManagedActions
    {
        public AppsforopsActions Appsforops(string connectionId) => new AppsforopsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AppsforopsTriggers Appsforops(string connectionId) => new AppsforopsTriggers(connectionId);
    }
}