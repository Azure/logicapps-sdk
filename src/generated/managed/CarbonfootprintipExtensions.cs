//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Carbonfootprintip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CarbonfootprintipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<AirQualityHealthIndexResponse, ApiConnectionActionConfiguration> AirQualityHealthIndex(Expression<Func<string>> o3, Expression<Func<string>> nO2, Expression<Func<string>> pM)
        {
            var __workflow_o3 = WorkflowExpression.Compile(o3, nameof(o3), required: true);
            var __workflow_nO2 = WorkflowExpression.Compile(nO2, nameof(nO2), required: true);
            var __workflow_pM = WorkflowExpression.Compile(pM, nameof(pM), required: true);
            return new DeferredBodyAction<AirQualityHealthIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AirQualityHealthIndex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["O3"] = ExpressionConverter.Convert(__workflow_o3);
                callPayload.Queries["NO2"] = ExpressionConverter.Convert(__workflow_nO2);
                callPayload.Queries["PM"] = ExpressionConverter.Convert(__workflow_pM);
                return new ApiConnectionAction<AirQualityHealthIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<TreeEquivalentResponse, ApiConnectionActionConfiguration> TreeEquivalent(Expression<Func<string>> weight, Expression<Func<unitInput>> unit)
        {
            var __workflow_weight = WorkflowExpression.Compile(weight, nameof(weight), required: true);
            var __workflow_unit = WorkflowExpression.Compile(unit, nameof(unit), required: true);
            return new DeferredBodyAction<TreeEquivalentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/TreeEquivalent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["weight"] = ExpressionConverter.Convert(__workflow_weight);
                callPayload.Queries["unit"] = ExpressionConverter.Convert(__workflow_unit);
                return new ApiConnectionAction<TreeEquivalentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<TraditionalHydroToCarbonFootprintResponse, ApiConnectionActionConfiguration> TraditionalHydroToCarbonFootprint(Expression<Func<string>> consumption, Expression<Func<locationInput>> location)
        {
            var __workflow_consumption = WorkflowExpression.Compile(consumption, nameof(consumption), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            return new DeferredBodyAction<TraditionalHydroToCarbonFootprintResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/TraditionalHydroToCarbonFootprint";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["consumption"] = ExpressionConverter.Convert(__workflow_consumption);
                callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                return new ApiConnectionAction<TraditionalHydroToCarbonFootprintResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CleanHydroToCarbonFootprintResponse, ApiConnectionActionConfiguration> CleanHydroToCarbonFootprint(Expression<Func<energyInput>> energy, Expression<Func<string>> consumption)
        {
            var __workflow_energy = WorkflowExpression.Compile(energy, nameof(energy), required: true);
            var __workflow_consumption = WorkflowExpression.Compile(consumption, nameof(consumption), required: true);
            return new DeferredBodyAction<CleanHydroToCarbonFootprintResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CleanHydroToCarbonFootprint";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["energy"] = ExpressionConverter.Convert(__workflow_energy);
                callPayload.Queries["consumption"] = ExpressionConverter.Convert(__workflow_consumption);
                return new ApiConnectionAction<CleanHydroToCarbonFootprintResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<FuelToCO2eResponse, ApiConnectionActionConfiguration> FuelToCO2e(Expression<Func<typeInput>> type, Expression<Func<string>> litres)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_litres = WorkflowExpression.Compile(litres, nameof(litres), required: true);
            return new DeferredBodyAction<FuelToCO2eResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FuelToCO2e";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["litres"] = ExpressionConverter.Convert(__workflow_litres);
                return new ApiConnectionAction<FuelToCO2eResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromCarTravelResponse, ApiConnectionActionConfiguration> CarbonFootprintFromCarTravel(Expression<Func<string>> distance, Expression<Func<vehicleInput>> vehicle)
        {
            var __workflow_distance = WorkflowExpression.Compile(distance, nameof(distance), required: true);
            var __workflow_vehicle = WorkflowExpression.Compile(vehicle, nameof(vehicle), required: true);
            return new DeferredBodyAction<CarbonFootprintFromCarTravelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CarbonFootprintFromCarTravel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = ExpressionConverter.Convert(__workflow_distance);
                callPayload.Queries["vehicle"] = ExpressionConverter.Convert(__workflow_vehicle);
                return new ApiConnectionAction<CarbonFootprintFromCarTravelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromFlightResponse, ApiConnectionActionConfiguration> CarbonFootprintFromFlight(Expression<Func<string>> distance, Expression<Func<typeInput>> type)
        {
            var __workflow_distance = WorkflowExpression.Compile(distance, nameof(distance), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<CarbonFootprintFromFlightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CarbonFootprintFromFlight";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = ExpressionConverter.Convert(__workflow_distance);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<CarbonFootprintFromFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromMotorBikeResponse, ApiConnectionActionConfiguration> CarbonFootprintFromMotorBike(Expression<Func<typeInput>> type, Expression<Func<string>> distance)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_distance = WorkflowExpression.Compile(distance, nameof(distance), required: true);
            return new DeferredBodyAction<CarbonFootprintFromMotorBikeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CarbonFootprintFromMotorBike";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["distance"] = ExpressionConverter.Convert(__workflow_distance);
                return new ApiConnectionAction<CarbonFootprintFromMotorBikeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<CarbonFootprintFromPublicTransitResponse, ApiConnectionActionConfiguration> CarbonFootprintFromPublicTransit(Expression<Func<string>> distance, Expression<Func<typeInput>> type)
        {
            var __workflow_distance = WorkflowExpression.Compile(distance, nameof(distance), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<CarbonFootprintFromPublicTransitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CarbonFootprintFromPublicTransit";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = ExpressionConverter.Convert(__workflow_distance);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<CarbonFootprintFromPublicTransitResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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