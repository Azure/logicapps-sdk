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
            var apiCallPath = String.Format("/v2/booking-calendars/{0}/time-slots", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTimeSlotsResponseItem[]>(callPayload);
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