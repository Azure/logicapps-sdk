//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiply
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UbiqodbyskiplyActions([ConnectionName] string connectionId)
    {
    }

    public class UbiqodbyskiplyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DataIn(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/key/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("pa");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class BodyInput
    {
        public BodyInput(int groupId)
        {
            this.GroupId = groupId;
        }

        [JsonProperty("group_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int GroupId { get; set; }

        [JsonProperty("hookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string HookUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiply;

    public partial class WorkflowManagedActions
    {
        public UbiqodbyskiplyActions Ubiqodbyskiply(string connectionId) => new UbiqodbyskiplyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UbiqodbyskiplyTriggers Ubiqodbyskiply(string connectionId) => new UbiqodbyskiplyTriggers(connectionId);
    }
}