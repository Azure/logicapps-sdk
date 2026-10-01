//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Metatask
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MetataskActions([ConnectionName] string connectionId)
    {
    }

    public class MetataskTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateSubscriptionProcessCompleted([WorkflowExpression] Func<string> webhookRequestBodyconditionstemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    conditionsObject["templateId"] = SourceExpressionConverter.ConvertToken(webhookRequestBodyconditionstemplate);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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