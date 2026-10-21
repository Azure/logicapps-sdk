//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Worldtimeip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorldtimeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetCurrentTimeBasedOnIp(Expression<Func<string>> ipv4)
        {
            var __workflow_ipv4 = WorkflowExpression.Compile(ipv4, nameof(ipv4), required: true);
            return new DeferredBodyAction<DateTimeJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ip/{0}", __workflow_ipv4.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
            var __workflow_area = WorkflowExpression.Compile(area, nameof(area), required: true);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/timezone/{0}", __workflow_area.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetLocationTimezone(Expression<Func<string>> area, Expression<Func<string>> location)
        {
            var __workflow_area = WorkflowExpression.Compile(area, nameof(area), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            return new DeferredBodyAction<DateTimeJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/timezone/{0}/{1}", __workflow_area.WithUrlEncoding(1), __workflow_location.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetRegionTimezone(Expression<Func<string>> area, Expression<Func<string>> location, Expression<Func<string>> region)
        {
            var __workflow_area = WorkflowExpression.Compile(area, nameof(area), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            return new DeferredBodyAction<DateTimeJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/timezone/{0}/{1}/{2}", __workflow_area.WithUrlEncoding(1), __workflow_location.WithUrlEncoding(1), __workflow_region.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
