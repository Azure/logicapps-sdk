//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Appstudioapi
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
        public IWorkflowTrigger ApiHooksSubscribePost(Expression<Func<string>> solutionId)
        {
            var apiCallPath = "/api/Hooks/subscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["solutionId"] = ExpressionConverter.Convert(solutionId);
            var data = new JObject();
            var datapropCount = 0;
            data["url"] = "@listcallbackurl()";
            datapropCount++;
            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Appstudioapi;

    public partial class WorkflowManagedActions
    {
        public AppstudioapiActions Appstudioapi(string connectionId) => new AppstudioapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AppstudioapiTriggers Appstudioapi(string connectionId) => new AppstudioapiTriggers(connectionId);
    }
}