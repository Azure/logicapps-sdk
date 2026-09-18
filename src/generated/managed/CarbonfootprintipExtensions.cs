//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Carbonfootprintip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CarbonfootprintipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<AirQualityHealthIndexResponse> AirQualityHealthIndex([WorkflowExpression] Func<string> o3, [WorkflowExpression] Func<string> nO2, [WorkflowExpression] Func<string> pM)
        {
            var apiCallPath = "/AirQualityHealthIndex";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["O3"] = ExpressionConverter.Convert(o3);
            callPayload.Queries["NO2"] = ExpressionConverter.Convert(nO2);
            callPayload.Queries["PM"] = ExpressionConverter.Convert(pM);
            return new ApiConnectionAction<AirQualityHealthIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<TreeEquivalentResponse> TreeEquivalent([WorkflowExpression] Func<string> weight, [WorkflowExpression] Func<unitInput> unit)
        {
            var apiCallPath = "/TreeEquivalent";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["weight"] = ExpressionConverter.Convert(weight);
            callPayload.Queries["unit"] = ExpressionConverter.Convert(unit);
            return new ApiConnectionAction<TreeEquivalentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<TraditionalHydroToCarbonFootprintResponse> TraditionalHydroToCarbonFootprint([WorkflowExpression] Func<string> consumption, [WorkflowExpression] Func<locationInput> location)
        {
            var apiCallPath = "/TraditionalHydroToCarbonFootprint";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["consumption"] = ExpressionConverter.Convert(consumption);
            callPayload.Queries["location"] = ExpressionConverter.Convert(location);
            return new ApiConnectionAction<TraditionalHydroToCarbonFootprintResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CleanHydroToCarbonFootprintResponse> CleanHydroToCarbonFootprint([WorkflowExpression] Func<energyInput> energy, [WorkflowExpression] Func<string> consumption)
        {
            var apiCallPath = "/CleanHydroToCarbonFootprint";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["energy"] = ExpressionConverter.Convert(energy);
            callPayload.Queries["consumption"] = ExpressionConverter.Convert(consumption);
            return new ApiConnectionAction<CleanHydroToCarbonFootprintResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<FuelToCO2eResponse> FuelToCO2e([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> litres)
        {
            var apiCallPath = "/FuelToCO2e";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            callPayload.Queries["litres"] = ExpressionConverter.Convert(litres);
            return new ApiConnectionAction<FuelToCO2eResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromCarTravelResponse> CarbonFootprintFromCarTravel([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<vehicleInput> vehicle)
        {
            var apiCallPath = "/CarbonFootprintFromCarTravel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
            callPayload.Queries["vehicle"] = ExpressionConverter.Convert(vehicle);
            return new ApiConnectionAction<CarbonFootprintFromCarTravelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromFlightResponse> CarbonFootprintFromFlight([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<typeInput> type)
        {
            var apiCallPath = "/CarbonFootprintFromFlight";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<CarbonFootprintFromFlightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromMotorBikeResponse> CarbonFootprintFromMotorBike([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> distance)
        {
            var apiCallPath = "/CarbonFootprintFromMotorBike";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
            return new ApiConnectionAction<CarbonFootprintFromMotorBikeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromPublicTransitResponse> CarbonFootprintFromPublicTransit([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<typeInput> type)
        {
            var apiCallPath = "/CarbonFootprintFromPublicTransit";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<CarbonFootprintFromPublicTransitResponse>(callPayload);
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