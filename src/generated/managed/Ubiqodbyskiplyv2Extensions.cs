//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiplyv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ubiqodbyskiplyv2Actions([ConnectionName] string connectionId)
    {
    }

    public class Ubiqodbyskiplyv2Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveDataFromTrackersResponseItem[]> ReceiveDataFromTrackers([WorkflowExpression] Func<string> bodyhookName = null, [WorkflowExpression] Func<string> bodydispatchId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyhookName, nameof(bodyhookName), required: false);
            SourceExpression.Validate(bodydispatchId, nameof(bodydispatchId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/zapier/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["hookUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                body["dispatchType"] = "POWERAUTOMATE";
                bodypropCount++;
                if (bodyhookName != null)
                {
                    body["hookName"] = SourceExpressionConverter.ConvertToken(bodyhookName);
                    bodypropCount++;
                }

                if (bodydispatchId != null)
                {
                    body["dispatchId"] = SourceExpressionConverter.ConvertToken(bodydispatchId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ReceiveDataFromTrackersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
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