//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Receptful
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReceptfulActions([ConnectionName] string connectionId)
    {
    }

    public class ReceptfulTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<VisitEventsResponse> VisitEvents([WorkflowExpression] Func<bodyEventInput> bodyEvent, [WorkflowExpression] Func<string> bodyregionId = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodybuttonId = null, [WorkflowExpression] Func<string> bodyconfigId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["event"] = ExpressionConverter.ConvertO(bodyEvent);
            body["source"] = "microsoft";
            bodypropCount++;
            if (bodyregionId != null)
            {
                body["region_id"] = ExpressionConverter.ConvertO(bodyregionId);
                bodypropCount++;
            }

            if (bodylocationId != null)
            {
                body["location_id"] = ExpressionConverter.ConvertO(bodylocationId);
                bodypropCount++;
            }

            if (bodybuttonId != null)
            {
                body["button_id"] = ExpressionConverter.ConvertO(bodybuttonId);
                bodypropCount++;
            }

            if (bodyconfigId != null)
            {
                body["config_id"] = ExpressionConverter.ConvertO(bodyconfigId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<VisitEventsResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class VisitEventsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public enum bodyEventInput
    {
        [EnumMember(Value = "checked_in")]
        CheckedIn,
        [EnumMember(Value = "checked_out")]
        CheckedOut,
        [EnumMember(Value = "delivered")]
        Delivered,
        [EnumMember(Value = "discarded")]
        Discarded,
        [EnumMember(Value = "incinerated")]
        Incinerated
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Receptful;

    public partial class WorkflowManagedActions
    {
        public ReceptfulActions Receptful(string connectionId) => new ReceptfulActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReceptfulTriggers Receptful(string connectionId) => new ReceptfulTriggers(connectionId);
    }
}