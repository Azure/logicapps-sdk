//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gravityformsbyreenhanced
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GravityformsbyreenhancedActions([ConnectionName] string connectionId)
    {
    }

    public class GravityformsbyreenhancedTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateWebhook(Expression<Func<string>> webhookform, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookform = webhookform == null ? null : WorkflowExpression.Compile(webhookform);
            WorkflowExpression.Validate(__workflow_webhookform, nameof(webhookform), required: true);
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
                webhook["form_id"] = ExpressionConverter.ConvertO(__workflow_webhookform);
                if (webhookpropCount > 0)
                {
                    callPayload.Body = webhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
