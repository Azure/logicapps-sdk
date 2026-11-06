//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appstudioapi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppstudioapiActions([ConnectionName] string connectionId)
    {
    }

    public class AppstudioapiTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ApiHooksSubscribePost(Expression<Func<string>> solutionId)
        {
            var __workflow_solutionId = WorkflowExpression.Compile(solutionId, nameof(solutionId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/Hooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionId"] = ExpressionConverter.Convert(__workflow_solutionId);
                callPayload.Body = new DataInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class DataInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Appstudioapi;

    public partial class WorkflowManagedActions
    {
        public AppstudioapiActions Appstudioapi(string connectionId) => new AppstudioapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AppstudioapiTriggers Appstudioapi(string connectionId) => new AppstudioapiTriggers(connectionId);
    }
}