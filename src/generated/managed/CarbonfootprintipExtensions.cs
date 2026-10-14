//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Carbonfootprintip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CarbonfootprintipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        public IBodyWorkflowAction<AirQualityHealthIndexResponse> AirQualityHealthIndex(Expression<Func<string>> o3, Expression<Func<string>> nO2, Expression<Func<string>> pM)
        {
            var __workflow_o3 = o3 == null ? null : WorkflowExpression.Compile(o3);
            WorkflowExpression.Validate(__workflow_o3, nameof(o3), required: true);
            var __workflow_nO2 = nO2 == null ? null : WorkflowExpression.Compile(nO2);
            WorkflowExpression.Validate(__workflow_nO2, nameof(nO2), required: true);
            var __workflow_pM = pM == null ? null : WorkflowExpression.Compile(pM);
            WorkflowExpression.Validate(__workflow_pM, nameof(pM), required: true);
            return new DeferredBodyAction<AirQualityHealthIndexResponse>(() =>
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
        public IBodyWorkflowAction<TreeEquivalentResponse> TreeEquivalent(Expression<Func<string>> weight, Expression<Func<unitInput>> unit)
        {
            var __workflow_weight = weight == null ? null : WorkflowExpression.Compile(weight);
            WorkflowExpression.Validate(__workflow_weight, nameof(weight), required: true);
            var __workflow_unit = unit == null ? null : WorkflowExpression.Compile(unit);
            WorkflowExpression.Validate(__workflow_unit, nameof(unit), required: true);
            return new DeferredBodyAction<TreeEquivalentResponse>(() =>
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
        public IBodyWorkflowAction<TraditionalHydroToCarbonFootprintResponse> TraditionalHydroToCarbonFootprint(Expression<Func<string>> consumption, Expression<Func<locationInput>> location)
        {
            var __workflow_consumption = consumption == null ? null : WorkflowExpression.Compile(consumption);
            WorkflowExpression.Validate(__workflow_consumption, nameof(consumption), required: true);
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: true);
            return new DeferredBodyAction<TraditionalHydroToCarbonFootprintResponse>(() =>
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
        public IBodyWorkflowAction<CleanHydroToCarbonFootprintResponse> CleanHydroToCarbonFootprint(Expression<Func<energyInput>> energy, Expression<Func<string>> consumption)
        {
            var __workflow_energy = energy == null ? null : WorkflowExpression.Compile(energy);
            WorkflowExpression.Validate(__workflow_energy, nameof(energy), required: true);
            var __workflow_consumption = consumption == null ? null : WorkflowExpression.Compile(consumption);
            WorkflowExpression.Validate(__workflow_consumption, nameof(consumption), required: true);
            return new DeferredBodyAction<CleanHydroToCarbonFootprintResponse>(() =>
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
        public IBodyWorkflowAction<FuelToCO2eResponse> FuelToCO2e(Expression<Func<typeInput>> type, Expression<Func<string>> litres)
        {
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            var __workflow_litres = litres == null ? null : WorkflowExpression.Compile(litres);
            WorkflowExpression.Validate(__workflow_litres, nameof(litres), required: true);
            return new DeferredBodyAction<FuelToCO2eResponse>(() =>
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
        public IBodyWorkflowAction<CarbonFootprintFromCarTravelResponse> CarbonFootprintFromCarTravel(Expression<Func<string>> distance, Expression<Func<vehicleInput>> vehicle)
        {
            var __workflow_distance = distance == null ? null : WorkflowExpression.Compile(distance);
            WorkflowExpression.Validate(__workflow_distance, nameof(distance), required: true);
            var __workflow_vehicle = vehicle == null ? null : WorkflowExpression.Compile(vehicle);
            WorkflowExpression.Validate(__workflow_vehicle, nameof(vehicle), required: true);
            return new DeferredBodyAction<CarbonFootprintFromCarTravelResponse>(() =>
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
        public IBodyWorkflowAction<CarbonFootprintFromFlightResponse> CarbonFootprintFromFlight(Expression<Func<string>> distance, Expression<Func<typeInput>> type)
        {
            var __workflow_distance = distance == null ? null : WorkflowExpression.Compile(distance);
            WorkflowExpression.Validate(__workflow_distance, nameof(distance), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            return new DeferredBodyAction<CarbonFootprintFromFlightResponse>(() =>
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
        public IBodyWorkflowAction<CarbonFootprintFromMotorBikeResponse> CarbonFootprintFromMotorBike(Expression<Func<typeInput>> type, Expression<Func<string>> distance)
        {
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            var __workflow_distance = distance == null ? null : WorkflowExpression.Compile(distance);
            WorkflowExpression.Validate(__workflow_distance, nameof(distance), required: true);
            return new DeferredBodyAction<CarbonFootprintFromMotorBikeResponse>(() =>
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
        public IBodyWorkflowAction<CarbonFootprintFromPublicTransitResponse> CarbonFootprintFromPublicTransit(Expression<Func<string>> distance, Expression<Func<typeInput>> type)
        {
            var __workflow_distance = distance == null ? null : WorkflowExpression.Compile(distance);
            WorkflowExpression.Validate(__workflow_distance, nameof(distance), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            return new DeferredBodyAction<CarbonFootprintFromPublicTransitResponse>(() =>
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
