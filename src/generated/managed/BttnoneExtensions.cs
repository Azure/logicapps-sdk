//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bttnone
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BttnoneActions([ConnectionName] string connectionId)
    {
    }

    public class BttnoneTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<BttnWebhookResponse> BttnWebhook(Expression<Func<string>> bodyactionConfigId, string triggerName = null)
        {
            var apiCallPath = "/api/action/1/powerAutomate/addWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["actionConfigId"] = ExpressionConverter.ConvertO(bodyactionConfigId);
            body["hookUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<BttnWebhookResponse>(callPayload);
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