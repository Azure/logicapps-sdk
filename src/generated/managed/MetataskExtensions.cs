//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Metatask
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MetataskActions([ConnectionName] string connectionId)
    {
    }

    public class MetataskTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCreateSubscriptionProcessCompleted))]
        public IWorkflowTrigger CreateSubscriptionProcessCompleted([WorkflowExpression] Func<string> webhookRequestBodyconditionstemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateSubscriptionProcessCompleted(WorkflowValue<string> webhookRequestBodyconditionstemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(webhookRequestBodyconditionstemplate, nameof(webhookRequestBodyconditionstemplate), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/oauth/subscription/process_completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhookRequestBody = new JObject();
                var webhookRequestBodypropCount = 0;
                webhookRequestBody["event"] = "PROCESS_COMPLETED";
                webhookRequestBodypropCount++;
                webhookRequestBody["target_url"] = "#{listCallbackUrl()}";
                webhookRequestBodypropCount++;
                var conditionsObject = new JObject();
                var conditionsObjectpropCount = 0;
                if (webhookRequestBodyconditionstemplate != null)
                {
                    conditionsObject["templateId"] = ExpressionConverter.ConvertO(webhookRequestBodyconditionstemplate);
                    conditionsObjectpropCount++;
                }

                if (conditionsObjectpropCount > 0)
                {
                    webhookRequestBody["conditions"] = conditionsObject;
                    webhookRequestBodypropCount++;
                }

                if (webhookRequestBodypropCount > 0)
                {
                    callPayload.Body = webhookRequestBody;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Metatask;

    public partial class WorkflowManagedActions
    {
        public MetataskActions Metatask(string connectionId) => new MetataskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MetataskTriggers Metatask(string connectionId) => new MetataskTriggers(connectionId);
    }
}
