//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oncehub
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OncehubActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oncehub")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeSlots))]
        public IBodyWorkflowAction<GetTimeSlotsResponseItem[]> GetTimeSlots([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTimeSlotsResponseItem[]> __BuildGetTimeSlots(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTimeSlotsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/booking-calendars/{0}/time-slots", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTimeSlotsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oncehub")]
        [WorkflowExpressionFactory(nameof(__BuildBookATimeSlot))]
        public IWorkflowAction BookATimeSlot([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyguestTimeZone, [WorkflowExpression] Func<string> bodybookingFormname = null, [WorkflowExpression] Func<string> bodybookingFormemail = null, [WorkflowExpression] Func<bodylocationTypeInput> bodylocationType = null, [WorkflowExpression] Func<string> bodylocationValue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBookATimeSlot(WorkflowExpression<string> id, WorkflowExpression<string> bodystartTime, WorkflowExpression<string> bodyguestTimeZone, WorkflowExpression<string> bodybookingFormname = null, WorkflowExpression<string> bodybookingFormemail = null, WorkflowExpression<bodylocationTypeInput> bodylocationType = null, WorkflowExpression<string> bodylocationValue = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            WorkflowExpression.Validate(bodyguestTimeZone, nameof(bodyguestTimeZone), required: true);
            WorkflowExpression.Validate(bodybookingFormname, nameof(bodybookingFormname), required: false);
            WorkflowExpression.Validate(bodybookingFormemail, nameof(bodybookingFormemail), required: false);
            WorkflowExpression.Validate(bodylocationType, nameof(bodylocationType), required: false);
            WorkflowExpression.Validate(bodylocationValue, nameof(bodylocationValue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/booking-calendars/{0}/schedule", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
                body["guest_time_zone"] = ExpressionConverter.ConvertO(bodyguestTimeZone);
                var bookingFormObject = new JObject();
                var bookingFormObjectpropCount = 0;
                if (bodybookingFormname != null)
                {
                    bookingFormObject["name"] = ExpressionConverter.ConvertO(bodybookingFormname);
                    bookingFormObjectpropCount++;
                }

                if (bodybookingFormemail != null)
                {
                    bookingFormObject["email"] = ExpressionConverter.ConvertO(bodybookingFormemail);
                    bookingFormObjectpropCount++;
                }

                if (bookingFormObjectpropCount > 0)
                {
                    body["booking_form"] = bookingFormObject;
                    bodypropCount++;
                }

                if (bodylocationType != null)
                {
                    body["location_type"] = ExpressionConverter.ConvertO(bodylocationType);
                    bodypropCount++;
                }

                if (bodylocationValue != null)
                {
                    body["location_value"] = ExpressionConverter.ConvertO(bodylocationValue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class OncehubTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetTimeSlotsResponseItem
    {
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("locations")]
        public GetTimeSlotsResponseItemLocationsTypeItem[] Locations { get; set; }
    }

    public class GetTimeSlotsResponseItemLocationsTypeItem
    {
        [JsonProperty("type")]
        public GetTimeSlotsResponseItemLocationsTypeItemTypeType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetTimeSlotsResponseItemLocationsTypeItemTypeType
    {
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "virtual")]
        Virtual,
        [EnumMember(Value = "phone")]
        Phone
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylocationTypeInput
    {
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "virtual")]
        Virtual,
        [EnumMember(Value = "phone")]
        Phone
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Oncehub;

    public partial class WorkflowManagedActions
    {
        public OncehubActions Oncehub(string connectionId) => new OncehubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OncehubTriggers Oncehub(string connectionId) => new OncehubTriggers(connectionId);
    }
}