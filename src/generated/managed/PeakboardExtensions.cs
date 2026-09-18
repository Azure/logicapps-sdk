//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Peakboard
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PeakboardActions([ConnectionName] string connectionId)
    {
    }

    public class PeakboardTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenAlertIsSent(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/PowerAutomate/Subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["CallbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Peakboard;

    public partial class WorkflowManagedActions
    {
        public PeakboardActions Peakboard(string connectionId) => new PeakboardActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PeakboardTriggers Peakboard(string connectionId) => new PeakboardTriggers(connectionId);
    }
}