//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gravityformsbyreenhanced
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GravityformsbyreenhancedActions([ConnectionName] string connectionId)
    {
    }

    public class GravityformsbyreenhancedTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildCreateWebhook))]
        public IWorkflowTrigger CreateWebhook([WorkflowExpression] Func<string> webhookform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateWebhook(WorkflowExpression<string> webhookform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(webhookform, nameof(webhookform), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhook = new JObject();
                var webhookpropCount = 0;
                webhook["callback_url"] = "#{listCallbackUrl()}";
                webhookpropCount++;
                webhookpropCount++;
                webhook["form_id"] = ExpressionConverter.ConvertO(webhookform);
                if (webhookpropCount > 0)
                {
                    callPayload.Body = webhook;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gravityformsbyreenhanced;

    public partial class WorkflowManagedActions
    {
        public GravityformsbyreenhancedActions Gravityformsbyreenhanced(string connectionId) => new GravityformsbyreenhancedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GravityformsbyreenhancedTriggers Gravityformsbyreenhanced(string connectionId) => new GravityformsbyreenhancedTriggers(connectionId);
    }
}