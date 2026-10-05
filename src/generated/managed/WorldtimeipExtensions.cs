//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Worldtimeip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorldtimeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        [WorkflowExpressionFactory(nameof(__BuildGetCurrentTimeBasedOnIp))]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetCurrentTimeBasedOnIp([WorkflowExpression] Func<string> ipv4)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DateTimeJsonResponse> __BuildGetCurrentTimeBasedOnIp(WorkflowValue<string> ipv4)
        {
            WorkflowValue.Validate(ipv4, nameof(ipv4), required: true);
            return new DeferredBodyAction<DateTimeJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ip/{0}", ExpressionConverter.ConvertWithUrlEncoding(ipv4, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildGetAreaTimezones))]
        public IBodyWorkflowAction<string[]> GetAreaTimezones([WorkflowExpression] Func<string> area)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildGetAreaTimezones(WorkflowValue<string> area)
        {
            WorkflowValue.Validate(area, nameof(area), required: true);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/timezone/{0}", ExpressionConverter.ConvertWithUrlEncoding(area, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocationTimezone))]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetLocationTimezone([WorkflowExpression] Func<string> area, [WorkflowExpression] Func<string> location)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DateTimeJsonResponse> __BuildGetLocationTimezone(WorkflowValue<string> area, WorkflowValue<string> location)
        {
            WorkflowValue.Validate(area, nameof(area), required: true);
            WorkflowValue.Validate(location, nameof(location), required: true);
            return new DeferredBodyAction<DateTimeJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/timezone/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(area, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldtimeip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRegionTimezone))]
        public IBodyWorkflowAction<DateTimeJsonResponse> GetRegionTimezone([WorkflowExpression] Func<string> area, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<string> region)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DateTimeJsonResponse> __BuildGetRegionTimezone(WorkflowValue<string> area, WorkflowValue<string> location, WorkflowValue<string> region)
        {
            WorkflowValue.Validate(area, nameof(area), required: true);
            WorkflowValue.Validate(location, nameof(location), required: true);
            WorkflowValue.Validate(region, nameof(region), required: true);
            return new DeferredBodyAction<DateTimeJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/timezone/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(area, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(region, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DateTimeJsonResponse>(callPayload);
            });
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
