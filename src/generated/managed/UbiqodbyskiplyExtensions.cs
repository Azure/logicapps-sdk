//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiply
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class UbiqodbyskiplyActions([ConnectionName] string connectionId)
    {
    }

    public class UbiqodbyskiplyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DataIn(Expression<Func<int>> bodygroupId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodygroupId = bodygroupId == null ? null : WorkflowExpression.Compile(bodygroupId);
            WorkflowExpression.Validate(__workflow_bodygroupId, nameof(bodygroupId), required: true);
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
                body["group_id"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                body["hookUrl"] = "#{listCallbackUrl()}";
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
