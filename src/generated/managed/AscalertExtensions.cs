//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ascalert
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AscalertActions([ConnectionName] string connectionId)
    {
    }

    public class AscalertTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASCAlertTriggerSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Microsoft.Security/Alert/subscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback_url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ascalert;

    public partial class WorkflowManagedActions
    {
        public AscalertActions Ascalert(string connectionId) => new AscalertActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AscalertTriggers Ascalert(string connectionId) => new AscalertTriggers(connectionId);
    }
}