//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dvelop
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DvelopActions([ConnectionName] string connectionId)
    {
    }

    public class DvelopTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildDynamicWebhookTrigger))]
        public IWorkflowTrigger DynamicWebhookTrigger([WorkflowExpression] Func<string> triggerId,[WorkflowExpression] Func<bodyconditionInputItem[]> bodycondition = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildDynamicWebhookTrigger(WorkflowExpression<string> triggerId,WorkflowExpression<bodyconditionInputItem[]> bodycondition = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(triggerId, nameof(triggerId), required: true);
            WorkflowExpression.Validate(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/triggers/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(triggerId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callback_url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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