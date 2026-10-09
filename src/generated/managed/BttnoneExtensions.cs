//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bttnone
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BttnoneActions([ConnectionName] string connectionId)
    {
    }

    public class BttnoneTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildBttnWebhook))]
        public IBodyWorkflowTrigger<BttnWebhookResponse> BttnWebhook([WorkflowExpression] Func<string> bodyactionConfigId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BttnWebhookResponse> __BuildBttnWebhook(WorkflowExpression<string> bodyactionConfigId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyactionConfigId, nameof(bodyactionConfigId), required: true);
            return new DeferredBodyTrigger<BttnWebhookResponse>(() =>
            {
                var apiCallPath = "/api/action/1/powerAutomate/addWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["actionConfigId"] = ExpressionConverter.ConvertO(bodyactionConfigId);
                body["hookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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