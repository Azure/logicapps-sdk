//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dvelop
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DvelopActions([ConnectionName] string connectionId)
    {
    }

    public class DvelopTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DynamicWebhookTrigger(Expression<Func<string>> triggerId, Expression<Func<bodyconditionInputItem[]>> bodycondition = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/triggers/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(triggerId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback_url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodycondition != null)
            {
                body["conditions"] = ExpressionConverter.ConvertO(bodycondition);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class bodyconditionInputItem
    {
        [JsonProperty("conditionType")]
        public string Type { get; set; }

        [JsonProperty("conditionValue")]
        public string[] ConditionValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dvelop;

    public partial class WorkflowManagedActions
    {
        public DvelopActions Dvelop(string connectionId) => new DvelopActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DvelopTriggers Dvelop(string connectionId) => new DvelopTriggers(connectionId);
    }
}