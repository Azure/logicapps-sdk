//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Metatask
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MetataskActions([ConnectionName] string connectionId)
    {
    }

    public class MetataskTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CreateSubscriptionProcessCompleted(Expression<Func<CreateSubscriptionProcessCompletedInput>> webhookRequestBody, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookRequestBody = WorkflowExpression.Compile(webhookRequestBody, nameof(webhookRequestBody), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/oauth/subscription/process_completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookRequestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateSubscriptionProcessCompletedInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "PROCESS_COMPLETED";

        [JsonProperty("target_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("conditions", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSubscriptionProcessCompletedInputConditionsType Conditions { get; set; }
    }

    public class CreateSubscriptionProcessCompletedInputConditionsType
    {
        [JsonProperty("templateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Template { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Metatask;

    public partial class WorkflowManagedActions
    {
        public MetataskActions Metatask(string connectionId) => new MetataskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MetataskTriggers Metatask(string connectionId) => new MetataskTriggers(connectionId);
    }
}