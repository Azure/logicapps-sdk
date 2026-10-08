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
        [WorkflowExpressionFactory(nameof(__BuildAirQualityHealthIndex))]
        public IBodyWorkflowAction<AirQualityHealthIndexResponse> AirQualityHealthIndex([WorkflowExpression] Func<string> o3, [WorkflowExpression] Func<string> nO2, [WorkflowExpression] Func<string> pM)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirQualityHealthIndexResponse> __BuildAirQualityHealthIndex(WorkflowExpression<string> o3, WorkflowExpression<string> nO2, WorkflowExpression<string> pM)
        {
            WorkflowExpression.Validate(o3, nameof(o3), required: true);
            WorkflowExpression.Validate(nO2, nameof(nO2), required: true);
            WorkflowExpression.Validate(pM, nameof(pM), required: true);
            return new DeferredBodyAction<AirQualityHealthIndexResponse>(() =>
            {
                var apiCallPath = "/AirQualityHealthIndex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["O3"] = ExpressionConverter.Convert(o3);
                callPayload.Queries["NO2"] = ExpressionConverter.Convert(nO2);
                callPayload.Queries["PM"] = ExpressionConverter.Convert(pM);
                return new ApiConnectionAction<AirQualityHealthIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        [WorkflowExpressionFactory(nameof(__BuildTreeEquivalent))]
        public IBodyWorkflowAction<TreeEquivalentResponse> TreeEquivalent([WorkflowExpression] Func<string> weight, [WorkflowExpression] Func<unitInput> unit)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TreeEquivalentResponse> __BuildTreeEquivalent(WorkflowExpression<string> weight, WorkflowExpression<unitInput> unit)
        {
            WorkflowExpression.Validate(weight, nameof(weight), required: true);
            WorkflowExpression.Validate(unit, nameof(unit), required: true);
            return new DeferredBodyAction<TreeEquivalentResponse>(() =>
            {
                var apiCallPath = "/TreeEquivalent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["weight"] = ExpressionConverter.Convert(weight);
                callPayload.Queries["unit"] = ExpressionConverter.Convert(unit);
                return new ApiConnectionAction<TreeEquivalentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        [WorkflowExpressionFactory(nameof(__BuildTraditionalHydroToCarbonFootprint))]
        public IBodyWorkflowAction<TraditionalHydroToCarbonFootprintResponse> TraditionalHydroToCarbonFootprint([WorkflowExpression] Func<string> consumption, [WorkflowExpression] Func<locationInput> location)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TraditionalHydroToCarbonFootprintResponse> __BuildTraditionalHydroToCarbonFootprint(WorkflowExpression<string> consumption, WorkflowExpression<locationInput> location)
        {
            WorkflowExpression.Validate(consumption, nameof(consumption), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            return new DeferredBodyAction<TraditionalHydroToCarbonFootprintResponse>(() =>
            {
                var apiCallPath = "/TraditionalHydroToCarbonFootprint";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["consumption"] = ExpressionConverter.Convert(consumption);
                callPayload.Queries["location"] = ExpressionConverter.Convert(location);
                return new ApiConnectionAction<TraditionalHydroToCarbonFootprintResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        [WorkflowExpressionFactory(nameof(__BuildCleanHydroToCarbonFootprint))]
        public IBodyWorkflowAction<CleanHydroToCarbonFootprintResponse> CleanHydroToCarbonFootprint([WorkflowExpression] Func<energyInput> energy, [WorkflowExpression] Func<string> consumption)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CleanHydroToCarbonFootprintResponse> __BuildCleanHydroToCarbonFootprint(WorkflowExpression<energyInput> energy, WorkflowExpression<string> consumption)
        {
            WorkflowExpression.Validate(energy, nameof(energy), required: true);
            WorkflowExpression.Validate(consumption, nameof(consumption), required: true);
            return new DeferredBodyAction<CleanHydroToCarbonFootprintResponse>(() =>
            {
                var apiCallPath = "/CleanHydroToCarbonFootprint";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["energy"] = ExpressionConverter.Convert(energy);
                callPayload.Queries["consumption"] = ExpressionConverter.Convert(consumption);
                return new ApiConnectionAction<CleanHydroToCarbonFootprintResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        [WorkflowExpressionFactory(nameof(__BuildFuelToCO2e))]
        public IBodyWorkflowAction<FuelToCO2eResponse> FuelToCO2e([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> litres)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FuelToCO2eResponse> __BuildFuelToCO2e(WorkflowExpression<typeInput> type, WorkflowExpression<string> litres)
        {
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(litres, nameof(litres), required: true);
            return new DeferredBodyAction<FuelToCO2eResponse>(() =>
            {
                var apiCallPath = "/FuelToCO2e";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                callPayload.Queries["litres"] = ExpressionConverter.Convert(litres);
                return new ApiConnectionAction<FuelToCO2eResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        [WorkflowExpressionFactory(nameof(__BuildCarbonFootprintFromCarTravel))]
        public IBodyWorkflowAction<CarbonFootprintFromCarTravelResponse> CarbonFootprintFromCarTravel([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<vehicleInput> vehicle)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarbonFootprintFromCarTravelResponse> __BuildCarbonFootprintFromCarTravel(WorkflowExpression<string> distance, WorkflowExpression<vehicleInput> vehicle)
        {
            WorkflowExpression.Validate(distance, nameof(distance), required: true);
            WorkflowExpression.Validate(vehicle, nameof(vehicle), required: true);
            return new DeferredBodyAction<CarbonFootprintFromCarTravelResponse>(() =>
            {
                var apiCallPath = "/CarbonFootprintFromCarTravel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
                callPayload.Queries["vehicle"] = ExpressionConverter.Convert(vehicle);
                return new ApiConnectionAction<CarbonFootprintFromCarTravelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        [WorkflowExpressionFactory(nameof(__BuildCarbonFootprintFromFlight))]
        public IBodyWorkflowAction<CarbonFootprintFromFlightResponse> CarbonFootprintFromFlight([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarbonFootprintFromFlightResponse> __BuildCarbonFootprintFromFlight(WorkflowExpression<string> distance, WorkflowExpression<typeInput> type)
        {
            WorkflowExpression.Validate(distance, nameof(distance), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<CarbonFootprintFromFlightResponse>(() =>
            {
                var apiCallPath = "/CarbonFootprintFromFlight";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<CarbonFootprintFromFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        [WorkflowExpressionFactory(nameof(__BuildCarbonFootprintFromMotorBike))]
        public IBodyWorkflowAction<CarbonFootprintFromMotorBikeResponse> CarbonFootprintFromMotorBike([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> distance)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarbonFootprintFromMotorBikeResponse> __BuildCarbonFootprintFromMotorBike(WorkflowExpression<typeInput> type, WorkflowExpression<string> distance)
        {
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(distance, nameof(distance), required: true);
            return new DeferredBodyAction<CarbonFootprintFromMotorBikeResponse>(() =>
            {
                var apiCallPath = "/CarbonFootprintFromMotorBike";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
                return new ApiConnectionAction<CarbonFootprintFromMotorBikeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonfootprintip")]
        [WorkflowExpressionFactory(nameof(__BuildCarbonFootprintFromPublicTransit))]
        public IBodyWorkflowAction<CarbonFootprintFromPublicTransitResponse> CarbonFootprintFromPublicTransit([WorkflowExpression] Func<string> distance, [WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarbonFootprintFromPublicTransitResponse> __BuildCarbonFootprintFromPublicTransit(WorkflowExpression<string> distance, WorkflowExpression<typeInput> type)
        {
            WorkflowExpression.Validate(distance, nameof(distance), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<CarbonFootprintFromPublicTransitResponse>(() =>
            {
                var apiCallPath = "/CarbonFootprintFromPublicTransit";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
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