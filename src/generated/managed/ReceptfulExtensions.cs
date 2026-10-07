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

        [WorkflowExpressionFactory(nameof(__BuildVisitEvents))]
        public IBodyWorkflowTrigger<VisitEventsResponse> VisitEvents([WorkflowExpression] Func<bodyEventInput> bodyEvent,[WorkflowExpression] Func<string> bodyregionId = null,[WorkflowExpression] Func<string> bodylocationId = null,[WorkflowExpression] Func<string> bodybuttonId = null,[WorkflowExpression] Func<string> bodyconfigId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VisitEventsResponse> __BuildVisitEvents(WorkflowExpression<bodyEventInput> bodyEvent,WorkflowExpression<string> bodyregionId = null,WorkflowExpression<string> bodylocationId = null,WorkflowExpression<string> bodybuttonId = null,WorkflowExpression<string> bodyconfigId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            WorkflowExpression.Validate(bodyregionId, nameof(bodyregionId), required: false);
            WorkflowExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            WorkflowExpression.Validate(bodybuttonId, nameof(bodybuttonId), required: false);
            WorkflowExpression.Validate(bodyconfigId, nameof(bodyconfigId), required: false);
            return new DeferredBodyTrigger<VisitEventsResponse>(() =>
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger<VisitEventsResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class VisitEventsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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