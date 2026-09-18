//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Receptful
{
    using System.Linq.Expressions;
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
            SourceExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            SourceExpression.Validate(bodyregionId, nameof(bodyregionId), required: false);
            SourceExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            SourceExpression.Validate(bodybuttonId, nameof(bodybuttonId), required: false);
            SourceExpression.Validate(bodyconfigId, nameof(bodyconfigId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["event"] = SourceExpressionConverter.Convert(bodyEvent);
                body["source"] = "microsoft";
                bodypropCount++;
                if (bodyregionId != null)
                {
                    body["region_id"] = SourceExpressionConverter.ConvertToken(bodyregionId);
                    bodypropCount++;
                }

                if (bodylocationId != null)
                {
                    body["location_id"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodybuttonId != null)
                {
                    body["button_id"] = SourceExpressionConverter.ConvertToken(bodybuttonId);
                    bodypropCount++;
                }

                if (bodyconfigId != null)
                {
                    body["config_id"] = SourceExpressionConverter.ConvertToken(bodyconfigId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<VisitEventsResponse>(BuildSourceInput, triggerName, recurrence);
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