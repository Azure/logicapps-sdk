//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appstudioapi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AppstudioapiActions([ConnectionName] string connectionId)
    {
    }

    public class AppstudioapiTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ApiHooksSubscribePost(Expression<Func<string>> solutionId, FlowRecurrence recurrence = null)
        {
            var __workflow_solutionId = WorkflowExpression.Compile(solutionId, nameof(solutionId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Hooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionId"] = ExpressionConverter.Convert(__workflow_solutionId);
                var data = new JObject();
                var datapropCount = 0;
                data["url"] = "#{listCallbackUrl()}";
                datapropCount++;
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
