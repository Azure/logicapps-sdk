//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstracttimezones
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AbstracttimezonesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstracttimezones")]
        public IBodyWorkflowAction<GetCurrentTimeResponse> GetCurrentTime(Expression<Func<string>> location)
        {
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: true);
            return new DeferredBodyAction<GetCurrentTimeResponse>(() =>
            {
                var apiCallPath = "/v1/current_time";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                return new ApiConnectionAction<GetCurrentTimeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstracttimezones")]
        public IBodyWorkflowAction<ConvertTimeResponse> ConvertTime(Expression<Func<string>> baseLocation, Expression<Func<string>> targetLocation, Expression<Func<string>> baseDatetime = null)
        {
            var __workflow_baseLocation = baseLocation == null ? null : WorkflowExpression.Compile(baseLocation);
            WorkflowExpression.Validate(__workflow_baseLocation, nameof(baseLocation), required: true);
            var __workflow_targetLocation = targetLocation == null ? null : WorkflowExpression.Compile(targetLocation);
            WorkflowExpression.Validate(__workflow_targetLocation, nameof(targetLocation), required: true);
            var __workflow_baseDatetime = baseDatetime == null ? null : WorkflowExpression.Compile(baseDatetime);
            WorkflowExpression.Validate(__workflow_baseDatetime, nameof(baseDatetime), required: false);
            return new DeferredBodyAction<ConvertTimeResponse>(() =>
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
