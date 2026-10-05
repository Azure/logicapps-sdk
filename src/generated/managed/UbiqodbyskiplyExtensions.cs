//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiply
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UbiqodbyskiplyActions([ConnectionName] string connectionId)
    {
    }

    public class UbiqodbyskiplyTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildDataIn))]
        public IWorkflowTrigger DataIn([WorkflowExpression] Func<int> bodygroupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildDataIn(WorkflowValue<int> bodygroupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/key/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("pa");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group_id"] = ExpressionConverter.ConvertO(bodygroupId);
                body["hookUrl"] = "#{listCallbackUrl()}";
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiply;

    public partial class WorkflowManagedActions
    {
        public UbiqodbyskiplyActions Ubiqodbyskiply(string connectionId) => new UbiqodbyskiplyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UbiqodbyskiplyTriggers Ubiqodbyskiply(string connectionId) => new UbiqodbyskiplyTriggers(connectionId);
    }
}
