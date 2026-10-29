//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oncehub
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OncehubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oncehub")]
        public IBodyWorkflowAction<GetTimeSlotsResponseItem[], ApiConnectionActionConfiguration> GetTimeSlots(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTimeSlotsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/booking-calendars/{0}/time-slots", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTimeSlotsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oncehub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BookATimeSlot(Expression<Func<string>> id, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyguestTimeZone, Expression<Func<string>> bodybookingFormname = null, Expression<Func<string>> bodybookingFormemail = null, Expression<Func<bodylocationTypeInput>> bodylocationType = null, Expression<Func<string>> bodylocationValue = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: true);
            var __workflow_bodyguestTimeZone = WorkflowExpression.Compile(bodyguestTimeZone, nameof(bodyguestTimeZone), required: true);
            var __workflow_bodybookingFormname = WorkflowExpression.Compile(bodybookingFormname, nameof(bodybookingFormname), required: false);
            var __workflow_bodybookingFormemail = WorkflowExpression.Compile(bodybookingFormemail, nameof(bodybookingFormemail), required: false);
            var __workflow_bodylocationType = WorkflowExpression.Compile(bodylocationType, nameof(bodylocationType), required: false);
            var __workflow_bodylocationValue = WorkflowExpression.Compile(bodylocationValue, nameof(bodylocationValue), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/booking-calendars/{0}/schedule", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                bodypropCount++;
                body["guest_time_zone"] = ExpressionConverter.ConvertO(__workflow_bodyguestTimeZone);
                var bookingFormObject = new JObject();
                var bookingFormObjectpropCount = 0;
                if (__workflow_bodybookingFormname != null)
                {
                    bookingFormObject["name"] = ExpressionConverter.ConvertO(__workflow_bodybookingFormname);
                    bookingFormObjectpropCount++;
                }

                if (__workflow_bodybookingFormemail != null)
                {
                    bookingFormObject["email"] = ExpressionConverter.ConvertO(__workflow_bodybookingFormemail);
                    bookingFormObjectpropCount++;
                }

                if (bookingFormObjectpropCount > 0)
                {
                    body["booking_form"] = bookingFormObject;
                    bodypropCount++;
                }

                if (__workflow_bodylocationType != null)
                {
                    body["location_type"] = ExpressionConverter.ConvertO(__workflow_bodylocationType);
                    bodypropCount++;
                }

                if (__workflow_bodylocationValue != null)
                {
                    body["location_value"] = ExpressionConverter.ConvertO(__workflow_bodylocationValue);
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
