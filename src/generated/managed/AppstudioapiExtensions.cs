//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appstudioapi
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppstudioapiActions([ConnectionName] string connectionId)
    {
    }

    public class AppstudioapiTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildApiHooksSubscribePost))]
        public IWorkflowTrigger ApiHooksSubscribePost([WorkflowExpression] Func<string> solutionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildApiHooksSubscribePost(WorkflowValue<string> solutionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(solutionId, nameof(solutionId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Hooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionId"] = ExpressionConverter.Convert(solutionId);
                var data = new JObject();
                var datapropCount = 0;
                data["url"] = "#{listCallbackUrl()}";
                datapropCount++;
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Appstudioapi;

    public partial class WorkflowManagedActions
    {
        public AppstudioapiActions Appstudioapi(string connectionId) => new AppstudioapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AppstudioapiTriggers Appstudioapi(string connectionId) => new AppstudioapiTriggers(connectionId);
    }
}
