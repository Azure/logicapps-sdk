//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstracttimezones
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstracttimezonesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstracttimezones")]
        public IBodyWorkflowAction<GetCurrentTimeResponse, ApiConnectionActionConfiguration> GetCurrentTime(Expression<Func<string>> location)
        {
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            return new DeferredBodyAction<GetCurrentTimeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/current_time";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                return new ApiConnectionAction<GetCurrentTimeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstracttimezones")]
        public IBodyWorkflowAction<ConvertTimeResponse, ApiConnectionActionConfiguration> ConvertTime(Expression<Func<string>> baseLocation, Expression<Func<string>> targetLocation, Expression<Func<string>> baseDatetime = null)
        {
            var __workflow_baseLocation = WorkflowExpression.Compile(baseLocation, nameof(baseLocation), required: true);
            var __workflow_targetLocation = WorkflowExpression.Compile(targetLocation, nameof(targetLocation), required: true);
            var __workflow_baseDatetime = WorkflowExpression.Compile(baseDatetime, nameof(baseDatetime), required: false);
            return new DeferredBodyAction<ConvertTimeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/convert_time";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base_location"] = ExpressionConverter.Convert(__workflow_baseLocation);
                callPayload.Queries["target_location"] = ExpressionConverter.Convert(__workflow_targetLocation);
                if (__workflow_baseDatetime != null)
                    callPayload.Queries["base_datetime"] = ExpressionConverter.Convert(__workflow_baseDatetime);
                return new ApiConnectionAction<ConvertTimeResponse>(callPayload);
            });
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
