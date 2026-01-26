//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cpqsync
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CpqsyncActions([ConnectionName] string connectionId)
    {
    }

    public class CpqsyncTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProductUpdated(Expression<Func<string>> tenantId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/master-data/tenants/{0}/web-hooks/PricedItemUpdated", ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            callPayload.Headers["accept"] = Convert.ToString("*/*");
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ProductCreated(Expression<Func<string>> tenantId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/master-data/tenants/{0}/web-hooks/PricedItemCreated", ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            callPayload.Headers["accept"] = Convert.ToString("*/*");
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cpqsync;

    public partial class WorkflowManagedActions
    {
        public CpqsyncActions Cpqsync(string connectionId) => new CpqsyncActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CpqsyncTriggers Cpqsync(string connectionId) => new CpqsyncTriggers(connectionId);
    }
}