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
        public IBodyWorkflowAction<GetTimeSlotsResponseItem[]> GetTimeSlots([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/booking-calendars/{0}/time-slots", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTimeSlotsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oncehub")]
        public IWorkflowAction BookATimeSlot([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyguestTimeZone, [WorkflowExpression] Func<string> bodybookingFormname = null, [WorkflowExpression] Func<string> bodybookingFormemail = null, [WorkflowExpression] Func<bodylocationTypeInput> bodylocationType = null, [WorkflowExpression] Func<string> bodylocationValue = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            SourceExpression.Validate(bodyguestTimeZone, nameof(bodyguestTimeZone), required: true);
            SourceExpression.Validate(bodybookingFormname, nameof(bodybookingFormname), required: false);
            SourceExpression.Validate(bodybookingFormemail, nameof(bodybookingFormemail), required: false);
            SourceExpression.Validate(bodylocationType, nameof(bodylocationType), required: false);
            SourceExpression.Validate(bodylocationValue, nameof(bodylocationValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/booking-calendars/{0}/schedule", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
                body["guest_time_zone"] = SourceExpressionConverter.ConvertToken(bodyguestTimeZone);
                var bookingFormObject = new JObject();
                var bookingFormObjectpropCount = 0;
                if (bodybookingFormname != null)
                {
                    bookingFormObject["name"] = SourceExpressionConverter.ConvertToken(bodybookingFormname);
                    bookingFormObjectpropCount++;
                }

                if (bodybookingFormemail != null)
                {
                    bookingFormObject["email"] = SourceExpressionConverter.ConvertToken(bodybookingFormemail);
                    bookingFormObjectpropCount++;
                }

                if (bookingFormObjectpropCount > 0)
                {
                    body["booking_form"] = bookingFormObject;
                    bodypropCount++;
                }

                if (bodylocationType != null)
                {
                    body["location_type"] = SourceExpressionConverter.Convert(bodylocationType);
                    bodypropCount++;
                }

                if (bodylocationValue != null)
                {
                    body["location_value"] = SourceExpressionConverter.ConvertToken(bodylocationValue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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