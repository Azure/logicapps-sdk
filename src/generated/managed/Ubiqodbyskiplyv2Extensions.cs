//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiplyv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ubiqodbyskiplyv2Actions([ConnectionName] string connectionId)
    {
    }

    public class Ubiqodbyskiplyv2Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveDataFromTrackersResponseItem[]> ReceiveDataFromTrackers(Expression<Func<string>> bodyhookName = null, Expression<Func<string>> bodydispatchId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyhookName = WorkflowExpression.Compile(bodyhookName, nameof(bodyhookName), required: false);
            var __workflow_bodydispatchId = WorkflowExpression.Compile(bodydispatchId, nameof(bodydispatchId), required: false);
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
                if (__workflow_bodyhookName != null)
                {
                    body["hookName"] = ExpressionConverter.ConvertO(__workflow_bodyhookName);
                    bodypropCount++;
                }

                if (__workflow_bodydispatchId != null)
                {
                    body["dispatchId"] = ExpressionConverter.ConvertO(__workflow_bodydispatchId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<ReceiveDataFromTrackersResponseItem[]>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
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
