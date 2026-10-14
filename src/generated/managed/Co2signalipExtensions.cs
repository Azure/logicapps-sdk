//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Co2signalip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Co2signalipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "co2signalip")]
        public IBodyWorkflowAction<GetLatestbyCodeResponse> GetLatestbyCode(Expression<Func<string>> countryCode)
        {
            var __workflow_countryCode = countryCode == null ? null : WorkflowExpression.Compile(countryCode);
            WorkflowExpression.Validate(__workflow_countryCode, nameof(countryCode), required: true);
            return new DeferredBodyAction<GetLatestbyCodeResponse>(() =>
            {
                var apiCallPath = "/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["countryCode"] = ExpressionConverter.Convert(__workflow_countryCode);
                return new ApiConnectionAction<GetLatestbyCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "co2signalip")]
        public IBodyWorkflowAction<GetLatestbyLatLonResponse> GetLatestbyLatLon(Expression<Func<double>> lon = null, Expression<Func<double>> lat = null)
        {
            var __workflow_lon = lon == null ? null : WorkflowExpression.Compile(lon);
            WorkflowExpression.Validate(__workflow_lon, nameof(lon), required: false);
            var __workflow_lat = lat == null ? null : WorkflowExpression.Compile(lat);
            WorkflowExpression.Validate(__workflow_lat, nameof(lat), required: false);
            return new DeferredBodyAction<GetLatestbyLatLonResponse>(() =>
            {
                var apiCallPath = "/latestbyloc";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lon != null)
                    callPayload.Queries["lon"] = ExpressionConverter.Convert(__workflow_lon);
                if (__workflow_lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                return new ApiConnectionAction<GetLatestbyLatLonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "co2signalip")]
        public IBodyWorkflowAction<GetZonesResponse> GetZones()
        {
            var apiCallPath = "/zones";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetZonesResponse>(callPayload);
        }
    }

    public class Co2signalipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLatestbyCodeResponse
    {
        [JsonProperty("_disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("data")]
        public GetLatestbyCodeResponseDataType Data { get; set; }

        [JsonProperty("units")]
        public GetLatestbyCodeResponseUnitsType Units { get; set; }
    }

    public class GetLatestbyCodeResponseDataType
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }

        [JsonProperty("fossilFuelPercentage")]
        public JToken FossilFuelPercentage { get; set; }
    }

    public class GetLatestbyCodeResponseUnitsType
    {
        [JsonProperty("carbonIntensity")]
        public string CarbonIntensity { get; set; }
    }

    public class GetLatestbyLatLonResponse
    {
        [JsonProperty("_disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("data")]
        public GetLatestbyLatLonResponseDataType Data { get; set; }

        [JsonProperty("units")]
        public GetLatestbyLatLonResponseUnitsType Units { get; set; }
    }

    public class GetLatestbyLatLonResponseDataType
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }

        [JsonProperty("fossilFuelPercentage")]
        public JToken FossilFuelPercentage { get; set; }
    }

    public class GetLatestbyLatLonResponseUnitsType
    {
        [JsonProperty("carbonIntensity")]
        public string CarbonIntensity { get; set; }
    }

    public class GetZonesResponse
    {
        public GetZonesResponseZonesTypeItem[] Zones { get; set; }
    }

    public class GetZonesResponseZonesTypeItem
    {
        public string Name { get; set; }
        public GetZonesResponseZonesTypeItemDetailsType Details { get; set; }
    }

    public class GetZonesResponseZonesTypeItemDetailsType
    {
        [JsonProperty("zoneName")]
        public string ZoneName { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Co2signalip;

    public partial class WorkflowManagedActions
    {
        public Co2signalipActions Co2signalip(string connectionId) => new Co2signalipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Co2signalipTriggers Co2signalip(string connectionId) => new Co2signalipTriggers(connectionId);
    }
}
