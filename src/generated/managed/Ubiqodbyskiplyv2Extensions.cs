//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiplyv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ubiqodbyskiplyv2Actions([ConnectionName] string connectionId)
    {
    }

    public class Ubiqodbyskiplyv2Triggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildReceiveDataFromTrackers))]
        public IBodyWorkflowTrigger<ReceiveDataFromTrackersResponseItem[]> ReceiveDataFromTrackers([WorkflowExpression] Func<string> bodyhookName = null, [WorkflowExpression] Func<string> bodydispatchId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ReceiveDataFromTrackersResponseItem[]> __BuildReceiveDataFromTrackers(WorkflowExpression<string> bodyhookName = null, WorkflowExpression<string> bodydispatchId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyhookName, nameof(bodyhookName), required: false);
            WorkflowExpression.Validate(bodydispatchId, nameof(bodydispatchId), required: false);
            return new DeferredBodyTrigger<ReceiveDataFromTrackersResponseItem[]>(() =>
            {
                var apiCallPath = "/hooks/zapier/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["hookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["dispatchType"] = "POWERAUTOMATE";
                bodypropCount++;
                if (bodyhookName != null)
                {
                    body["hookName"] = ExpressionConverter.ConvertO(bodyhookName);
                    bodypropCount++;
                }

                if (bodydispatchId != null)
                {
                    body["dispatchId"] = ExpressionConverter.ConvertO(bodydispatchId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<ReceiveDataFromTrackersResponseItem[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class ReceiveDataFromTrackersResponseItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiplyv2;

    public partial class WorkflowManagedActions
    {
        public Ubiqodbyskiplyv2Actions Ubiqodbyskiplyv2(string connectionId) => new Ubiqodbyskiplyv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Ubiqodbyskiplyv2Triggers Ubiqodbyskiplyv2(string connectionId) => new Ubiqodbyskiplyv2Triggers(connectionId);
    }
}