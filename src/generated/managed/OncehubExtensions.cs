//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oncehub
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OncehubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oncehub")]
        public IBodyWorkflowAction<GetTimeSlotsResponseItem[]> GetTimeSlots(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/booking-calendars/{0}/time-slots", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTimeSlotsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oncehub")]
        public IWorkflowAction BookATimeSlot(Expression<Func<string>> id, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyguestTimeZone, Expression<Func<string>> bodybookingFormname = null, Expression<Func<string>> bodybookingFormemail = null, Expression<Func<bodylocationTypeInput>> bodylocationType = null, Expression<Func<string>> bodylocationValue = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/booking-calendars/{0}/schedule", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["start_time"] = CSharpExpressionConverter.ConvertToken(bodystartTime);
            bodypropCount++;
            body["guest_time_zone"] = CSharpExpressionConverter.ConvertToken(bodyguestTimeZone);
            var bookingFormObject = new JObject();
            var bookingFormObjectpropCount = 0;
            if (bodybookingFormname != null)
            {
                bookingFormObject["name"] = CSharpExpressionConverter.ConvertToken(bodybookingFormname);
                bookingFormObjectpropCount++;
            }

            if (bodybookingFormemail != null)
            {
                bookingFormObject["email"] = CSharpExpressionConverter.ConvertToken(bodybookingFormemail);
                bookingFormObjectpropCount++;
            }

            if (bookingFormObjectpropCount > 0)
            {
                body["booking_form"] = bookingFormObject;
                bodypropCount++;
            }

            if (bodylocationType != null)
            {
                body["location_type"] = CSharpExpressionConverter.Convert(bodylocationType);
                bodypropCount++;
            }

            if (bodylocationValue != null)
            {
                body["location_value"] = CSharpExpressionConverter.ConvertToken(bodylocationValue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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

    public enum GetTimeSlotsResponseItemLocationsTypeItemTypeType
    {
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "virtual")]
        Virtual,
        [EnumMember(Value = "phone")]
        Phone
    }

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