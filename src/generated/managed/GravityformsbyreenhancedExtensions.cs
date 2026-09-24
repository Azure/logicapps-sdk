//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gravityformsbyreenhanced
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GravityformsbyreenhancedActions([ConnectionName] string connectionId)
    {
    }

    public class GravityformsbyreenhancedTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateWebhook([WorkflowExpression] Func<string> webhookform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(webhookform, nameof(webhookform), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhook = new JObject();
                var webhookpropCount = 0;
                webhook["callback_url"] = "#{listCallbackUrl()}";
                webhookpropCount++;
                webhookpropCount++;
                webhook["form_id"] = SourceExpressionConverter.ConvertToken(webhookform);
                if (webhookpropCount > 0)
                {
                    callPayload.Body = webhook;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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