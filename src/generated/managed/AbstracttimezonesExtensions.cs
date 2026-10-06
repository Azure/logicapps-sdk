//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstracttimezones
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstracttimezonesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstracttimezones")]
        public IBodyWorkflowAction<GetCurrentTimeResponse> GetCurrentTime([WorkflowExpression] Func<string> location)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/current_time";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                return callPayload;
            }

            return new ApiConnectionAction<GetCurrentTimeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstracttimezones")]
        public IBodyWorkflowAction<ConvertTimeResponse> ConvertTime([WorkflowExpression] Func<string> baseLocation, [WorkflowExpression] Func<string> targetLocation, [WorkflowExpression] Func<string> baseDatetime = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/convert_time";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base_location"] = SourceExpressionConverter.ConvertO(baseLocation);
                callPayload.Queries["target_location"] = SourceExpressionConverter.ConvertO(targetLocation);
                if (baseDatetime != null)
                    callPayload.Queries["base_datetime"] = SourceExpressionConverter.ConvertO(baseDatetime);
                return callPayload;
            }

            return new ApiConnectionAction<ConvertTimeResponse>(BuildSourceInput);
        }
    }

    public class AbstracttimezonesTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCurrentTimeResponse
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("timezone_name")]
        public string TimezoneName { get; set; }

        [JsonProperty("timezone_location")]
        public string TimezoneLocation { get; set; }

        [JsonProperty("timezone_abbreviation")]
        public string TimezoneAbbreviation { get; set; }

        [JsonProperty("gmt_offset")]
        public int GmtOffset { get; set; }

        [JsonProperty("is_dst")]
        public bool IsDst { get; set; }

        [JsonProperty("requested_location")]
        public string RequestedLocation { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class ConvertTimeResponse
    {
        [JsonProperty("base_location")]
        public ConvertTimeResponseBaseLocationType BaseLocation { get; set; }

        [JsonProperty("target_location")]
        public ConvertTimeResponseTargetLocationType TargetLocation { get; set; }
    }

    public class ConvertTimeResponseBaseLocationType
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("timezone_name")]
        public string TimezoneName { get; set; }

        [JsonProperty("timezone_location")]
        public string TimezoneLocation { get; set; }

        [JsonProperty("timezone_abbreviation")]
        public string TimezoneAbbreviation { get; set; }

        [JsonProperty("gmt_offset")]
        public double GmtOffset { get; set; }

        [JsonProperty("is_dst")]
        public bool IsDst { get; set; }

        [JsonProperty("requested_location")]
        public string RequestedLocation { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class ConvertTimeResponseTargetLocationType
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("timezone_name")]
        public string TimezoneName { get; set; }

        [JsonProperty("timezone_location")]
        public string TimezoneLocation { get; set; }

        [JsonProperty("timezone_abbreviation")]
        public string TimezoneAbbreviation { get; set; }

        [JsonProperty("gmt_offset")]
        public double GmtOffset { get; set; }

        [JsonProperty("is_dst")]
        public bool IsDst { get; set; }

        [JsonProperty("requested_location")]
        public string RequestedLocation { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstracttimezones;

    public partial class WorkflowManagedActions
    {
        public AbstracttimezonesActions Abstracttimezones(string connectionId) => new AbstracttimezonesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstracttimezonesTriggers Abstracttimezones(string connectionId) => new AbstracttimezonesTriggers(connectionId);
    }
}