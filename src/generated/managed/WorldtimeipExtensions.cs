//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Worldtimeip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorldtimeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetCurrentTimeBasedOnIp(Expression<Func<string>> ipv4)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/ip/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ipv4, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        public IBodyWorkflowAction<string[]> GetTimezones()
        {
            var apiCallPath = "/timezone";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        public IBodyWorkflowAction<string[]> GetAreaTimezones(Expression<Func<string>> area)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/timezone/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(area, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetLocationTimezone(Expression<Func<string>> area, Expression<Func<string>> location)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/timezone/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(area, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetRegionTimezone(Expression<Func<string>> area, Expression<Func<string>> location, Expression<Func<string>> region)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/timezone/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(area, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
        }
    }

    public class WorldtimeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class DateTimeJsonResponse
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("day_of_week")]
        public int DayOfWeek { get; set; }

        [JsonProperty("day_of_year")]
        public int DayOfYear { get; set; }

        [JsonProperty("dst")]
        public bool Dst { get; set; }

        [JsonProperty("dst_from")]
        public string DstFrom { get; set; }

        [JsonProperty("dst_offset")]
        public int DstOffset { get; set; }

        [JsonProperty("dst_until")]
        public string DstUntil { get; set; }

        [JsonProperty("raw_offset")]
        public int RawOffset { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("unixtime")]
        public int Unixtime { get; set; }

        [JsonProperty("utc_datetime")]
        public string UtcDatetime { get; set; }

        [JsonProperty("utc_offset")]
        public string UtcOffset { get; set; }

        [JsonProperty("week_number")]
        public int WeekNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Worldtimeip;

    public partial class WorkflowManagedActions
    {
        public WorldtimeipActions Worldtimeip(string connectionId) => new WorldtimeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorldtimeipTriggers Worldtimeip(string connectionId) => new WorldtimeipTriggers(connectionId);
    }
}