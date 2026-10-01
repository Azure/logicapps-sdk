//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Carbonfootprintip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CarbonfootprintipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<AirQualityHealthIndexResponse> AirQualityHealthIndex([WorkflowExpression] Func<string> o3, [WorkflowExpression] Func<string> nO2, [WorkflowExpression] Func<string> pM)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AirQualityHealthIndex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["O3"] = SourceExpressionConverter.ConvertO(o3);
                callPayload.Queries["NO2"] = SourceExpressionConverter.ConvertO(nO2);
                callPayload.Queries["PM"] = SourceExpressionConverter.ConvertO(pM);
                return callPayload;
            }

            return new ApiConnectionAction<AirQualityHealthIndexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<TreeEquivalentResponse> TreeEquivalent([WorkflowExpression] Func<string> weight, [WorkflowExpression] Func<unitInput> unit)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TreeEquivalent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["weight"] = SourceExpressionConverter.ConvertO(weight);
                callPayload.Queries["unit"] = SourceExpressionConverter.Convert(unit);
                return callPayload;
            }

            return new ApiConnectionAction<TreeEquivalentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<TraditionalHydroToCarbonFootprintResponse> TraditionalHydroToCarbonFootprint([WorkflowExpression] Func<string> consumption, [WorkflowExpression] Func<locationInput> location)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TraditionalHydroToCarbonFootprint";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["consumption"] = SourceExpressionConverter.ConvertO(consumption);
                callPayload.Queries["location"] = SourceExpressionConverter.Convert(location);
                return callPayload;
            }

            return new ApiConnectionAction<TraditionalHydroToCarbonFootprintResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CleanHydroToCarbonFootprintResponse> CleanHydroToCarbonFootprint([WorkflowExpression] Func<energyInput> energy, [WorkflowExpression] Func<string> consumption)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CleanHydroToCarbonFootprint";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["energy"] = SourceExpressionConverter.Convert(energy);
                callPayload.Queries["consumption"] = SourceExpressionConverter.ConvertO(consumption);
                return callPayload;
            }

            return new ApiConnectionAction<CleanHydroToCarbonFootprintResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<FuelToCO2eResponse> FuelToCO2e([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> litres)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FuelToCO2e";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                callPayload.Queries["litres"] = SourceExpressionConverter.ConvertO(litres);
                return callPayload;
            }

            return new ApiConnectionAction<FuelToCO2eResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromCarTravelResponse> CarbonFootprintFromCarTravel([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<vehicleInput> vehicle)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CarbonFootprintFromCarTravel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = SourceExpressionConverter.ConvertO(distance);
                callPayload.Queries["vehicle"] = SourceExpressionConverter.Convert(vehicle);
                return callPayload;
            }

            return new ApiConnectionAction<CarbonFootprintFromCarTravelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromFlightResponse> CarbonFootprintFromFlight([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<typeInput> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CarbonFootprintFromFlight";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = SourceExpressionConverter.ConvertO(distance);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<CarbonFootprintFromFlightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromMotorBikeResponse> CarbonFootprintFromMotorBike([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> distance)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CarbonFootprintFromMotorBike";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                callPayload.Queries["distance"] = SourceExpressionConverter.ConvertO(distance);
                return callPayload;
            }

            return new ApiConnectionAction<CarbonFootprintFromMotorBikeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromPublicTransitResponse> CarbonFootprintFromPublicTransit([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<typeInput> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CarbonFootprintFromPublicTransit";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = SourceExpressionConverter.ConvertO(distance);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<CarbonFootprintFromPublicTransitResponse>(BuildSourceInput);
        }
    }

    public class CarbonfootprintipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AirQualityHealthIndexResponse
    {
        [JsonProperty("airQualityHealthIndex")]
        public int AirQualityHealthIndex { get; set; }
    }

    public class TreeEquivalentResponse
    {
        [JsonProperty("numberOfTrees")]
        public double NumberOfTrees { get; set; }
    }

    public enum unitInput
    {
        [EnumMember(Value = "kg")]
        Kg,
        [EnumMember(Value = "lb")]
        Lb
    }

    public class TraditionalHydroToCarbonFootprintResponse
    {
        [JsonProperty("carbonEquivalent")]
        public double CarbonEquivalent { get; set; }
    }

    public enum locationInput
    {
        USA,
        Canada,
        UK,
        Europe,
        Africa,
        LatinAmerica,
        MiddleEast,
        OtherCountry
    }

    public class CleanHydroToCarbonFootprintResponse
    {
        [JsonProperty("carbonEquivalent")]
        public int CarbonEquivalent { get; set; }
    }

    public enum energyInput
    {
        Solar,
        Wind,
        HydroElectric,
        Biomass,
        Geothermal,
        Tidal,
        OtherCleanEnergy
    }

    public class FuelToCO2eResponse
    {
        [JsonProperty("carbonEquivalent")]
        public double CarbonEquivalent { get; set; }
    }

    public enum typeInput
    {
        Taxi,
        ClassicBus,
        EcoBus,
        Coach,
        NationalTrain,
        LightRail,
        Subway,
        FerryOnFoot,
        FerryInCar
    }

    public class CarbonFootprintFromCarTravelResponse
    {
        [JsonProperty("carbonEquivalent")]
        public double CarbonEquivalent { get; set; }
    }

    public enum vehicleInput
    {
        SmallDieselCar,
        MediumDieselCar,
        LargeDieselCar,
        MediumHybridCar,
        LargeHybridCar,
        MediumLPGCar,
        LargeLPGCar,
        MediumCNGCar,
        LargeCNGCar,
        SmallPetrolVan,
        LargePetrolVan,
        SmallDieselVan,
        MediumDieselVan,
        LargeDieselVan,
        LPGVan,
        CNGVan,
        SmallPetrolCar,
        MediumPetrolCar,
        LargePetrolCar,
        SmallMotorBike,
        MediumMotorBike,
        LargeMotorBike
    }

    public class CarbonFootprintFromFlightResponse
    {
        [JsonProperty("carbonEquivalent")]
        public double CarbonEquivalent { get; set; }
    }

    public class CarbonFootprintFromMotorBikeResponse
    {
        [JsonProperty("carbonEquivalent")]
        public double CarbonEquivalent { get; set; }
    }

    public class CarbonFootprintFromPublicTransitResponse
    {
        [JsonProperty("carbonEquivalent")]
        public double CarbonEquivalent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Carbonfootprintip;

    public partial class WorkflowManagedActions
    {
        public CarbonfootprintipActions Carbonfootprintip(string connectionId) => new CarbonfootprintipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CarbonfootprintipTriggers Carbonfootprintip(string connectionId) => new CarbonfootprintipTriggers(connectionId);
    }
}