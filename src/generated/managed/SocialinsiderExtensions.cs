//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Socialinsider
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SocialinsiderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProfileTimeBasedMetrics(Expression<Func<ProfileTimeBasedMetricsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/profile_time_based_metrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProfileAggregatedMetrics(Expression<Func<ProfileAggregatedMetricsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/profiles_aggregated_metrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Posts(Expression<Func<PostsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Stories(Expression<Func<StoriesInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SocialinsiderTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProfileTimeBasedMetricsInput
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("projectname")]
        public string Projectname { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("profile")]
        public string[] Profile { get; set; }
    }

    public class ProfileAggregatedMetricsInput
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("projectname")]
        public string Projectname { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("profiles")]
        public string[] Profiles { get; set; }
    }

    public class PostsInput
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("projectname")]
        public string Projectname { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("profiles")]
        public string[] Profiles { get; set; }
    }

    public class StoriesInput
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("projectname")]
        public string Projectname { get; set; }

        [JsonProperty("profiles")]
        public string[] Profiles { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Socialinsider;

    public partial class WorkflowManagedActions
    {
        public SocialinsiderActions Socialinsider(string connectionId) => new SocialinsiderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SocialinsiderTriggers Socialinsider(string connectionId) => new SocialinsiderTriggers(connectionId);
    }
}