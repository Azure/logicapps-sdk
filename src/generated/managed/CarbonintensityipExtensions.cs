//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Carbonintensityip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CarbonintensityipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonintensityip")]
        public IBodyWorkflowAction<GetIntensityResponse> GetIntensity()
        {
            var apiCallPath = "/intensity";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetIntensityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonintensityip")]
        public IBodyWorkflowAction<GetIntensityFactorsResponse> GetIntensityFactors()
        {
            var apiCallPath = "/intensity/factors";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetIntensityFactorsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonintensityip")]
        public IBodyWorkflowAction<GetGenerationResponse> GetGeneration()
        {
            var apiCallPath = "/generation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetGenerationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonintensityip")]
        public IBodyWorkflowAction<GetIntensityEnglandResponse> GetIntensityEngland()
        {
            var apiCallPath = "/regional/england";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetIntensityEnglandResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonintensityip")]
        public IBodyWorkflowAction<GetIntensityScotlandResponse> GetIntensityScotland()
        {
            var apiCallPath = "/regional/scotland";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetIntensityScotlandResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonintensityip")]
        public IBodyWorkflowAction<GetIntensityWalesResponse> GetIntensityWales()
        {
            var apiCallPath = "/regional/wales";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetIntensityWalesResponse>(callPayload);
        }
    }

    public class CarbonintensityipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetIntensityResponse
    {
        [JsonProperty("data")]
        public GetIntensityResponseDataTypeItem[] Data { get; set; }
    }

    public class GetIntensityResponseDataTypeItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("intensity")]
        public GetIntensityResponseDataTypeItemIntensityType Intensity { get; set; }
    }

    public class GetIntensityResponseDataTypeItemIntensityType
    {
        [JsonProperty("forecast")]
        public int Forecast { get; set; }

        [JsonProperty("actual")]
        public int Actual { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }
    }

    public class GetIntensityFactorsResponse
    {
        [JsonProperty("data")]
        public GetIntensityFactorsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetIntensityFactorsResponseDataTypeItem
    {
        public int Biomass { get; set; }
        public int Coal { get; set; }

        [JsonProperty("Dutch Imports")]
        public int DutchImports { get; set; }

        [JsonProperty("French Imports")]
        public int FrenchImports { get; set; }

        [JsonProperty("Gas (Combined Cycle)")]
        public int GasCombinedCycle { get; set; }

        [JsonProperty("Gas (Open Cycle)")]
        public int GasOpenCycle { get; set; }
        public int Hydro { get; set; }

        [JsonProperty("Irish Imports")]
        public int IrishImports { get; set; }
        public int Nuclear { get; set; }
        public int Oil { get; set; }
        public int Other { get; set; }

        [JsonProperty("Pumped Storage")]
        public int PumpedStorage { get; set; }
        public int Solar { get; set; }
        public int Wind { get; set; }
    }

    public class GetGenerationResponse
    {
        [JsonProperty("data")]
        public GetGenerationResponseDataType Data { get; set; }
    }

    public class GetGenerationResponseDataType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("generationmix")]
        public GetGenerationResponseDataTypeGenerationmixTypeItem[] Generationmix { get; set; }
    }

    public class GetGenerationResponseDataTypeGenerationmixTypeItem
    {
        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        [JsonProperty("perc")]
        public double Perc { get; set; }
    }

    public class GetIntensityEnglandResponse
    {
        [JsonProperty("data")]
        public GetIntensityEnglandResponseDataTypeItem[] Data { get; set; }
    }

    public class GetIntensityEnglandResponseDataTypeItem
    {
        [JsonProperty("regionid")]
        public int Regionid { get; set; }

        [JsonProperty("dnoregion")]
        public string Dnoregion { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("data")]
        public GetIntensityEnglandResponseDataTypeItemDataTypeItem[] Data { get; set; }
    }

    public class GetIntensityEnglandResponseDataTypeItemDataTypeItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("intensity")]
        public GetIntensityEnglandResponseDataTypeItemDataTypeItemIntensityType Intensity { get; set; }

        [JsonProperty("generationmix")]
        public GetIntensityEnglandResponseDataTypeItemDataTypeItemGenerationmixTypeItem[] Generationmix { get; set; }
    }

    public class GetIntensityEnglandResponseDataTypeItemDataTypeItemIntensityType
    {
        [JsonProperty("forecast")]
        public int Forecast { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }
    }

    public class GetIntensityEnglandResponseDataTypeItemDataTypeItemGenerationmixTypeItem
    {
        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        [JsonProperty("perc")]
        public double Perc { get; set; }
    }

    public class GetIntensityScotlandResponse
    {
        [JsonProperty("data")]
        public GetIntensityScotlandResponseDataTypeItem[] Data { get; set; }
    }

    public class GetIntensityScotlandResponseDataTypeItem
    {
        [JsonProperty("regionid")]
        public int Regionid { get; set; }

        [JsonProperty("dnoregion")]
        public string Dnoregion { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("data")]
        public GetIntensityScotlandResponseDataTypeItemDataTypeItem[] Data { get; set; }
    }

    public class GetIntensityScotlandResponseDataTypeItemDataTypeItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("intensity")]
        public GetIntensityScotlandResponseDataTypeItemDataTypeItemIntensityType Intensity { get; set; }

        [JsonProperty("generationmix")]
        public GetIntensityScotlandResponseDataTypeItemDataTypeItemGenerationmixTypeItem[] Generationmix { get; set; }
    }

    public class GetIntensityScotlandResponseDataTypeItemDataTypeItemIntensityType
    {
        [JsonProperty("forecast")]
        public int Forecast { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }
    }

    public class GetIntensityScotlandResponseDataTypeItemDataTypeItemGenerationmixTypeItem
    {
        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        [JsonProperty("perc")]
        public double Perc { get; set; }
    }

    public class GetIntensityWalesResponse
    {
        [JsonProperty("data")]
        public GetIntensityWalesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetIntensityWalesResponseDataTypeItem
    {
        [JsonProperty("regionid")]
        public int Regionid { get; set; }

        [JsonProperty("dnoregion")]
        public string Dnoregion { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("data")]
        public GetIntensityWalesResponseDataTypeItemDataTypeItem[] Data { get; set; }
    }

    public class GetIntensityWalesResponseDataTypeItemDataTypeItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("intensity")]
        public GetIntensityWalesResponseDataTypeItemDataTypeItemIntensityType Intensity { get; set; }

        [JsonProperty("generationmix")]
        public GetIntensityWalesResponseDataTypeItemDataTypeItemGenerationmixTypeItem[] Generationmix { get; set; }
    }

    public class GetIntensityWalesResponseDataTypeItemDataTypeItemIntensityType
    {
        [JsonProperty("forecast")]
        public int Forecast { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }
    }

    public class GetIntensityWalesResponseDataTypeItemDataTypeItemGenerationmixTypeItem
    {
        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        [JsonProperty("perc")]
        public double Perc { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Carbonintensityip;

    public partial class WorkflowManagedActions
    {
        public CarbonintensityipActions Carbonintensityip(string connectionId) => new CarbonintensityipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CarbonintensityipTriggers Carbonintensityip(string connectionId) => new CarbonintensityipTriggers(connectionId);
    }
}