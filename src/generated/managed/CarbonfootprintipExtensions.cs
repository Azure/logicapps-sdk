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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirQualityHealthIndexResponse> __BuildAirQualityHealthIndex(WorkflowValue<string> o3, WorkflowValue<string> nO2, WorkflowValue<string> pM)
        {
            WorkflowValue.Validate(o3, nameof(o3), required: true);
            WorkflowValue.Validate(nO2, nameof(nO2), required: true);
            WorkflowValue.Validate(pM, nameof(pM), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TreeEquivalentResponse> __BuildTreeEquivalent(WorkflowValue<string> weight, WorkflowValue<unitInput> unit)
        {
            WorkflowValue.Validate(weight, nameof(weight), required: true);
            WorkflowValue.Validate(unit, nameof(unit), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TraditionalHydroToCarbonFootprintResponse> __BuildTraditionalHydroToCarbonFootprint(WorkflowValue<string> consumption, WorkflowValue<locationInput> location)
        {
            WorkflowValue.Validate(consumption, nameof(consumption), required: true);
            WorkflowValue.Validate(location, nameof(location), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CleanHydroToCarbonFootprintResponse> __BuildCleanHydroToCarbonFootprint(WorkflowValue<energyInput> energy, WorkflowValue<string> consumption)
        {
            WorkflowValue.Validate(energy, nameof(energy), required: true);
            WorkflowValue.Validate(consumption, nameof(consumption), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FuelToCO2eResponse> __BuildFuelToCO2e(WorkflowValue<typeInput> type, WorkflowValue<string> litres)
        {
            WorkflowValue.Validate(type, nameof(type), required: true);
            WorkflowValue.Validate(litres, nameof(litres), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarbonFootprintFromCarTravelResponse> __BuildCarbonFootprintFromCarTravel(WorkflowValue<string> distance, WorkflowValue<vehicleInput> vehicle)
        {
            WorkflowValue.Validate(distance, nameof(distance), required: true);
            WorkflowValue.Validate(vehicle, nameof(vehicle), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarbonFootprintFromFlightResponse> __BuildCarbonFootprintFromFlight(WorkflowValue<string> distance, WorkflowValue<typeInput> type)
        {
            WorkflowValue.Validate(distance, nameof(distance), required: true);
            WorkflowValue.Validate(type, nameof(type), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarbonFootprintFromMotorBikeResponse> __BuildCarbonFootprintFromMotorBike(WorkflowValue<typeInput> type, WorkflowValue<string> distance)
        {
            WorkflowValue.Validate(type, nameof(type), required: true);
            WorkflowValue.Validate(distance, nameof(distance), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarbonFootprintFromPublicTransitResponse> __BuildCarbonFootprintFromPublicTransit(WorkflowValue<string> distance, WorkflowValue<typeInput> type)
        {
            WorkflowValue.Validate(distance, nameof(distance), required: true);
            WorkflowValue.Validate(type, nameof(type), required: true);
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
