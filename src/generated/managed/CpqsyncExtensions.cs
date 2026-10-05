//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cpqsync
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CpqsyncActions([ConnectionName] string connectionId)
    {
    }

    public class CpqsyncTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildProductUpdated))]
        public IWorkflowTrigger ProductUpdated([WorkflowExpression] Func<string> tenantId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildProductUpdated(WorkflowValue<string> tenantId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(tenantId, nameof(tenantId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/master-data/tenants/{0}/web-hooks/PricedItemUpdated", ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildProductCreated))]
        public IWorkflowTrigger ProductCreated([WorkflowExpression] Func<string> tenantId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildProductCreated(WorkflowValue<string> tenantId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(tenantId, nameof(tenantId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/master-data/tenants/{0}/web-hooks/PricedItemCreated", ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
