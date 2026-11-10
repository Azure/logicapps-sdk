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
        public IBodyWorkflowTrigger<BttnWebhookResponse, ApiConnectionPollingTriggerConfiguration> BttnWebhook(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<BttnWebhookResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/action/1/powerAutomate/addWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<BttnWebhookResponse>(callPayload);
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

    public class BodyInput
    {
        public BodyInput(string actionConfigId)
        {
            this.ActionConfigId = actionConfigId;
        }

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