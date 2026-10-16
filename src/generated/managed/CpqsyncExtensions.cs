//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cpqsync
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CpqsyncActions([ConnectionName] string connectionId)
    {
    }

    public class CpqsyncTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProductUpdated(Expression<Func<string>> tenantId, FlowRecurrence recurrence = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/master-data/tenants/{0}/web-hooks/PricedItemUpdated", ExpressionConverter.ConvertWithUrlEncoding(__workflow_tenantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                callPayload.Headers["accept"] = Convert.ToString("*/*");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger ProductCreated(Expression<Func<string>> tenantId, FlowRecurrence recurrence = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/master-data/tenants/{0}/web-hooks/PricedItemCreated", ExpressionConverter.ConvertWithUrlEncoding(__workflow_tenantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                callPayload.Headers["accept"] = Convert.ToString("*/*");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
