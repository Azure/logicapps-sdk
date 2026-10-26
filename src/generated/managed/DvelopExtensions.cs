//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dvelop
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DvelopActions([ConnectionName] string connectionId)
    {
    }

    public class DvelopTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> DynamicWebhookTrigger(Expression<Func<string>> triggerId, Expression<Func<DynamicWebhookTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_triggerId = WorkflowExpression.Compile(triggerId, nameof(triggerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/triggers/{0}/subscribe", __workflow_triggerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class DynamicWebhookTriggerInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrlForTheTrigger { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("conditions")]
        public DynamicWebhookTriggerInputConditionTypeItem[] Condition { get; set; }
    }

    public class DynamicWebhookTriggerInputConditionTypeItem
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