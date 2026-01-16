//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Absentify
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbsentifyActions([ConnectionName] string connectionId)
    {
    }

    public class AbsentifyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerRequestCreated()
        {
            var apiCallPath = "/webhooks/manage_ms_webhook/request_created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TriggerRequestStatusChanged()
        {
            var apiCallPath = "/webhooks/manage_ms_webhook/request_status_changed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Absentify;

    public partial class WorkflowManagedActions
    {
        public AbsentifyActions Absentify(string connectionId) => new AbsentifyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbsentifyTriggers Absentify(string connectionId) => new AbsentifyTriggers(connectionId);
    }
}