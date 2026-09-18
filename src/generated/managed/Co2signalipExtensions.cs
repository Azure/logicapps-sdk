//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Co2signalip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Co2signalipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "co2signalip")]
        public IBodyWorkflowAction<GetLatestbyCodeResponse> GetLatestbyCode([WorkflowExpression] Func<string> countryCode)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["countryCode"] = SourceExpressionConverter.ConvertO(countryCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetLatestbyCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "co2signalip")]
        public IBodyWorkflowAction<GetLatestbyLatLonResponse> GetLatestbyLatLon([WorkflowExpression] Func<double> lon = null, [WorkflowExpression] Func<double> lat = null)
        {
            SourceExpression.Validate(lon, nameof(lon), required: false);
            SourceExpression.Validate(lat, nameof(lat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/latestbyloc";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                return callPayload;
            }

            return new ApiConnectionAction<GetLatestbyLatLonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "co2signalip")]
        public IBodyWorkflowAction<GetZonesResponse> GetZones()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/zones";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetZonesResponse>(BuildSourceInput);
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