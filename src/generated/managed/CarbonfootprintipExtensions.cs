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
        public IBodyWorkflowAction<AirQualityHealthIndexResponse> AirQualityHealthIndex(Expression<Func<string>> o3, Expression<Func<string>> nO2, Expression<Func<string>> pM)
        {
            var apiCallPath = "/AirQualityHealthIndex";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["O3"] = CSharpExpressionConverter.ConvertO(o3);
            callPayload.Queries["NO2"] = CSharpExpressionConverter.ConvertO(nO2);
            callPayload.Queries["PM"] = CSharpExpressionConverter.ConvertO(pM);
            return new ApiConnectionAction<AirQualityHealthIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<TreeEquivalentResponse> TreeEquivalent(Expression<Func<string>> weight, Expression<Func<unitInput>> unit)
        {
            var apiCallPath = "/TreeEquivalent";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["weight"] = CSharpExpressionConverter.ConvertO(weight);
            callPayload.Queries["unit"] = CSharpExpressionConverter.Convert(unit);
            return new ApiConnectionAction<TreeEquivalentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<TraditionalHydroToCarbonFootprintResponse> TraditionalHydroToCarbonFootprint(Expression<Func<string>> consumption, Expression<Func<locationInput>> location)
        {
            var apiCallPath = "/TraditionalHydroToCarbonFootprint";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["consumption"] = CSharpExpressionConverter.ConvertO(consumption);
            callPayload.Queries["location"] = CSharpExpressionConverter.Convert(location);
            return new ApiConnectionAction<TraditionalHydroToCarbonFootprintResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CleanHydroToCarbonFootprintResponse> CleanHydroToCarbonFootprint(Expression<Func<energyInput>> energy, Expression<Func<string>> consumption)
        {
            var apiCallPath = "/CleanHydroToCarbonFootprint";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["energy"] = CSharpExpressionConverter.Convert(energy);
            callPayload.Queries["consumption"] = CSharpExpressionConverter.ConvertO(consumption);
            return new ApiConnectionAction<CleanHydroToCarbonFootprintResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<FuelToCO2eResponse> FuelToCO2e(Expression<Func<typeInput>> type, Expression<Func<string>> litres)
        {
            var apiCallPath = "/FuelToCO2e";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
            callPayload.Queries["litres"] = CSharpExpressionConverter.ConvertO(litres);
            return new ApiConnectionAction<FuelToCO2eResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromCarTravelResponse> CarbonFootprintFromCarTravel(Expression<Func<string>> distance, Expression<Func<vehicleInput>> vehicle)
        {
            var apiCallPath = "/CarbonFootprintFromCarTravel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["distance"] = CSharpExpressionConverter.ConvertO(distance);
            callPayload.Queries["vehicle"] = CSharpExpressionConverter.Convert(vehicle);
            return new ApiConnectionAction<CarbonFootprintFromCarTravelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromFlightResponse> CarbonFootprintFromFlight(Expression<Func<string>> distance, Expression<Func<typeInput>> type)
        {
            var apiCallPath = "/CarbonFootprintFromFlight";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["distance"] = CSharpExpressionConverter.ConvertO(distance);
            callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
            return new ApiConnectionAction<CarbonFootprintFromFlightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromMotorBikeResponse> CarbonFootprintFromMotorBike(Expression<Func<typeInput>> type, Expression<Func<string>> distance)
        {
            var apiCallPath = "/CarbonFootprintFromMotorBike";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
            callPayload.Queries["distance"] = CSharpExpressionConverter.ConvertO(distance);
            return new ApiConnectionAction<CarbonFootprintFromMotorBikeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromPublicTransitResponse> CarbonFootprintFromPublicTransit(Expression<Func<string>> distance, Expression<Func<typeInput>> type)
        {
            var apiCallPath = "/CarbonFootprintFromPublicTransit";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["distance"] = CSharpExpressionConverter.ConvertO(distance);
            callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
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