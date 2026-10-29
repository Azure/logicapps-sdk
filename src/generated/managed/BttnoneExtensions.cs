//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bttnone
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BttnoneActions([ConnectionName] string connectionId)
    {
    }

    public class BttnoneTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BttnWebhookResponse, ApiConnectionTriggerConfiguration> BttnWebhook(Expression<Func<BttnWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<BttnWebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/action/1/powerAutomate/addWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<BttnWebhookResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class BttnWebhookResponse
    {
        [JsonProperty("actionConfigurationId")]
        public string ActionConfigurationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BttnWebhookInput
    {
        [JsonProperty("actionConfigId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ActionConfigId { get; set; }

        [JsonProperty("hookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string HookUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bttnone;

    public partial class WorkflowManagedActions
    {
        public BttnoneActions Bttnone(string connectionId) => new BttnoneActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BttnoneTriggers Bttnone(string connectionId) => new BttnoneTriggers(connectionId);
    }
}