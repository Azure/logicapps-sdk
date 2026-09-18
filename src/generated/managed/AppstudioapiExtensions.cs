//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appstudioapi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppstudioapiActions([ConnectionName] string connectionId)
    {
    }

    public class AppstudioapiTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ApiHooksSubscribePost([WorkflowExpression] Func<string> solutionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(solutionId, nameof(solutionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Hooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionId"] = SourceExpressionConverter.ConvertO(solutionId);
                var data = new JObject();
                var datapropCount = 0;
                data["url"] = "@listCallbackUrl()";
                datapropCount++;
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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