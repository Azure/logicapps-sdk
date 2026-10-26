//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Receptful
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReceptfulActions([ConnectionName] string connectionId)
    {
    }

    public class ReceptfulTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<VisitEventsResponse, ApiConnectionTriggerConfiguration> VisitEvents(Expression<Func<bodyEventInput>> bodyEvent, Expression<Func<string>> bodyregionId = null, Expression<Func<string>> bodylocationId = null, Expression<Func<string>> bodybuttonId = null, Expression<Func<string>> bodyconfigId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyEvent = WorkflowExpression.Compile(bodyEvent, nameof(bodyEvent), required: true);
            var __workflow_bodyregionId = WorkflowExpression.Compile(bodyregionId, nameof(bodyregionId), required: false);
            var __workflow_bodylocationId = WorkflowExpression.Compile(bodylocationId, nameof(bodylocationId), required: false);
            var __workflow_bodybuttonId = WorkflowExpression.Compile(bodybuttonId, nameof(bodybuttonId), required: false);
            var __workflow_bodyconfigId = WorkflowExpression.Compile(bodyconfigId, nameof(bodyconfigId), required: false);
            return new DeferredBodyTrigger<VisitEventsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(__workflow_bodyEvent);
                body["source"] = "microsoft";
                bodypropCount++;
                if (__workflow_bodyregionId != null)
                {
                    body["region_id"] = ExpressionConverter.ConvertO(__workflow_bodyregionId);
                    bodypropCount++;
                }

                if (__workflow_bodylocationId != null)
                {
                    body["location_id"] = ExpressionConverter.ConvertO(__workflow_bodylocationId);
                    bodypropCount++;
                }

                if (__workflow_bodybuttonId != null)
                {
                    body["button_id"] = ExpressionConverter.ConvertO(__workflow_bodybuttonId);
                    bodypropCount++;
                }

                if (__workflow_bodyconfigId != null)
                {
                    body["config_id"] = ExpressionConverter.ConvertO(__workflow_bodyconfigId);
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