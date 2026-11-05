//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nhtsavpicip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NhtsavpicipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<DecodeResponse, ApiConnectionActionConfiguration> Decode(Expression<Func<string>> vIN, Expression<Func<int>> modelyear = null)
        {
            var __workflow_vIN = WorkflowExpression.Compile(vIN, nameof(vIN), required: true);
            var __workflow_modelyear = WorkflowExpression.Compile(modelyear, nameof(modelyear), required: false);
            return new DeferredBodyAction<DecodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/DecodeVinValuesExtended/{0}", __workflow_vIN.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_modelyear != null)
                    callPayload.Queries["modelyear"] = ExpressionConverter.Convert(__workflow_modelyear);
                return new ApiConnectionAction<DecodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<DecodeWMIResponse, ApiConnectionActionConfiguration> DecodeWMI(Expression<Func<string>> wMI)
        {
            var __workflow_wMI = WorkflowExpression.Compile(wMI, nameof(wMI), required: true);
            return new DeferredBodyAction<DecodeWMIResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/DecodeWMI/{0}", __workflow_wMI.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DecodeWMIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<WMIGetResponse, ApiConnectionActionConfiguration> WMIGet(Expression<Func<string>> query, Expression<Func<string>> vehicleType = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_vehicleType = WorkflowExpression.Compile(vehicleType, nameof(vehicleType), required: false);
            return new DeferredBodyAction<WMIGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetWMIsForManufacturer/{0}", __workflow_query.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_vehicleType != null)
                    callPayload.Queries["vehicleType"] = ExpressionConverter.Convert(__workflow_vehicleType);
                return new ApiConnectionAction<WMIGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<MakeResponse, ApiConnectionActionConfiguration> Make()
        {
            return new DeferredBodyAction<MakeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/vehicles/GetAllMakes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MakeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<ManufacturerResponse, ApiConnectionActionConfiguration> Manufacturer(Expression<Func<string>> manufacturerType = null, Expression<Func<int>> page = null)
        {
            var __workflow_manufacturerType = WorkflowExpression.Compile(manufacturerType, nameof(manufacturerType), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<ManufacturerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/vehicles/GetAllManufacturers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_manufacturerType != null)
                    callPayload.Queries["ManufacturerType"] = ExpressionConverter.Convert(__workflow_manufacturerType);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<ManufacturerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<ManufacturerDetailResponse, ApiConnectionActionConfiguration> ManufacturerDetail(Expression<Func<string>> query)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<ManufacturerDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetManufacturerDetails/{0}", __workflow_query.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ManufacturerDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<ManufacturerNameResponse, ApiConnectionActionConfiguration> ManufacturerName(Expression<Func<string>> query)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<ManufacturerNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetMakeForManufacturer/{0}", __workflow_query.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ManufacturerNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<ManufacturerNameYearResponse, ApiConnectionActionConfiguration> ManufacturerNameYear(Expression<Func<string>> query, Expression<Func<int>> year)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            return new DeferredBodyAction<ManufacturerNameYearResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetMakesForManufacturerAndYear/{0}", __workflow_query.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                return new ApiConnectionAction<ManufacturerNameYearResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<MakeTypeResponse, ApiConnectionActionConfiguration> MakeType(Expression<Func<string>> vehicleType)
        {
            var __workflow_vehicleType = WorkflowExpression.Compile(vehicleType, nameof(vehicleType), required: true);
            return new DeferredBodyAction<MakeTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetMakesForVehicleType/{0}", __workflow_vehicleType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MakeTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<MakeVehicleTypeResponse, ApiConnectionActionConfiguration> MakeVehicleType(Expression<Func<string>> make)
        {
            var __workflow_make = WorkflowExpression.Compile(make, nameof(make), required: true);
            return new DeferredBodyAction<MakeVehicleTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetVehicleTypesForMake/{0}", __workflow_make.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MakeVehicleTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<EquipmentPlantResponse, ApiConnectionActionConfiguration> EquipmentPlant(Expression<Func<FilterInput>> filter)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            return new DeferredBodyAction<EquipmentPlantResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetEquipmentPlantCodes/{0}", __workflow_filter.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EquipmentPlantResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<MakeModelResponse, ApiConnectionActionConfiguration> MakeModel(Expression<Func<string>> make)
        {
            var __workflow_make = WorkflowExpression.Compile(make, nameof(make), required: true);
            return new DeferredBodyAction<MakeModelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetModelsForMake/{0}", __workflow_make.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MakeModelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<MakeModelYearTypeResponse, ApiConnectionActionConfiguration> MakeModelYearType(Expression<Func<string>> make, Expression<Func<string>> yearOrVehicleType, Expression<Func<string>> query)
        {
            var __workflow_make = WorkflowExpression.Compile(make, nameof(make), required: true);
            var __workflow_yearOrVehicleType = WorkflowExpression.Compile(yearOrVehicleType, nameof(yearOrVehicleType), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<MakeModelYearTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetModelsForMakeYear/make/{0}/{1}/{2}", __workflow_make.WithUrlEncoding(1), __workflow_yearOrVehicleType.WithUrlEncoding(1), __workflow_query.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MakeModelYearTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<VehicleVariableResponse, ApiConnectionActionConfiguration> VehicleVariable()
        {
            return new DeferredBodyAction<VehicleVariableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/vehicles/GetVehicleVariableList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VehicleVariableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nhtsavpicip")]
        public IBodyWorkflowAction<VehicleVariableValueResponse, ApiConnectionActionConfiguration> VehicleVariableValue(Expression<Func<string>> variable)
        {
            var __workflow_variable = WorkflowExpression.Compile(variable, nameof(variable), required: true);
            return new DeferredBodyAction<VehicleVariableValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/GetVehicleVariableValuesList/{0}", __workflow_variable.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VehicleVariableValueResponse>(callPayload);
            });
        }
    }

    public class NhtsavpicipTriggers([ConnectionName] string connectionId)
    {
    }

    public class DecodeResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public DecodeResponseResultsTypeItem[] Results { get; set; }
    }

    public class DecodeResponseResultsTypeItem
    {
        public string ABS { get; set; }
        public string ActiveSafetySysNote { get; set; }
        public string AdaptiveCruiseControl { get; set; }
        public string AdaptiveDrivingBeam { get; set; }
        public string AdaptiveHeadlights { get; set; }
        public string AdditionalErrorText { get; set; }
        public string AirBagLocCurtain { get; set; }
        public string AirBagLocFront { get; set; }
        public string AirBagLocKnee { get; set; }
        public string AirBagLocSeatCushion { get; set; }
        public string AirBagLocSide { get; set; }
        public string AutoReverseSystem { get; set; }
        public string AutomaticPedestrianAlertingSound { get; set; }
        public string AxleConfiguration { get; set; }
        public string Axles { get; set; }
        public string BasePrice { get; set; }
        public string BatteryA { get; set; }

        [JsonProperty("BatteryA_to")]
        public string BatteryATo { get; set; }
        public string BatteryCells { get; set; }
        public string BatteryInfo { get; set; }
        public string BatteryKWh { get; set; }

        [JsonProperty("BatteryKWh_to")]
        public string BatteryKWhTo { get; set; }
        public string BatteryModules { get; set; }
        public string BatteryPacks { get; set; }
        public string BatteryType { get; set; }
        public string BatteryV { get; set; }

        [JsonProperty("BatteryV_to")]
        public string BatteryVTo { get; set; }
        public string BedLengthIN { get; set; }
        public string BedType { get; set; }
        public string BlindSpotIntervention { get; set; }
        public string BlindSpotMon { get; set; }
        public string BodyCabType { get; set; }
        public string BodyClass { get; set; }
        public string BrakeSystemDesc { get; set; }
        public string BrakeSystemType { get; set; }
        public string BusFloorConfigType { get; set; }
        public string BusLength { get; set; }
        public string BusType { get; set; }

        [JsonProperty("CAN_AACN")]
        public string CANAACN { get; set; }
        public string CIB { get; set; }
        public string CashForClunkers { get; set; }
        public string ChargerLevel { get; set; }
        public string ChargerPowerKW { get; set; }
        public string CoolingType { get; set; }
        public string CurbWeightLB { get; set; }
        public string CustomMotorcycleType { get; set; }
        public string DaytimeRunningLight { get; set; }
        public string DestinationMarket { get; set; }
        public string DisplacementCC { get; set; }
        public string DisplacementCI { get; set; }
        public string DisplacementL { get; set; }
        public string Doors { get; set; }
        public string DriveType { get; set; }
        public string DriverAssist { get; set; }
        public string DynamicBrakeSupport { get; set; }
        public string EDR { get; set; }
        public string ESC { get; set; }
        public string EVDriveUnit { get; set; }
        public string ElectrificationLevel { get; set; }
        public string EngineConfiguration { get; set; }
        public string EngineCycles { get; set; }
        public string EngineCylinders { get; set; }
        public string EngineHP { get; set; }

        [JsonProperty("EngineHP_to")]
        public string EngineHPTo { get; set; }
        public string EngineKW { get; set; }
        public string EngineManufacturer { get; set; }
        public string EngineModel { get; set; }
        public string EntertainmentSystem { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public string ForwardCollisionWarning { get; set; }
        public string FuelInjectionType { get; set; }
        public string FuelTypePrimary { get; set; }
        public string FuelTypeSecondary { get; set; }
        public string GCWR { get; set; }

        [JsonProperty("GCWR_to")]
        public string GCWRTo { get; set; }
        public string GVWR { get; set; }

        [JsonProperty("GVWR_to")]
        public string GVWRTo { get; set; }
        public string KeylessIgnition { get; set; }
        public string LaneCenteringAssistance { get; set; }
        public string LaneDepartureWarning { get; set; }
        public string LaneKeepSystem { get; set; }
        public string LowerBeamHeadlampLightSource { get; set; }
        public string Make { get; set; }

        [JsonProperty("MakeID")]
        public string MakeId { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerId { get; set; }
        public string Model { get; set; }

        [JsonProperty("ModelID")]
        public string ModelId { get; set; }
        public string ModelYear { get; set; }
        public string MotorcycleChassisType { get; set; }
        public string MotorcycleSuspensionType { get; set; }
        public string NCSABodyType { get; set; }
        public string NCSAMake { get; set; }
        public string NCSAMapExcApprovedBy { get; set; }
        public string NCSAMapExcApprovedOn { get; set; }
        public string NCSAMappingException { get; set; }
        public string NCSAModel { get; set; }
        public string NCSANote { get; set; }
        public string NonLandUse { get; set; }
        public string Note { get; set; }
        public string OtherBusInfo { get; set; }
        public string OtherEngineInfo { get; set; }
        public string OtherMotorcycleInfo { get; set; }
        public string OtherRestraintSystemInfo { get; set; }
        public string OtherTrailerInfo { get; set; }
        public string ParkAssist { get; set; }
        public string PedestrianAutomaticEmergencyBraking { get; set; }
        public string PlantCity { get; set; }
        public string PlantCompanyName { get; set; }
        public string PlantCountry { get; set; }
        public string PlantState { get; set; }
        public string PossibleValues { get; set; }
        public string Pretensioner { get; set; }
        public string RearAutomaticEmergencyBraking { get; set; }
        public string RearCrossTrafficAlert { get; set; }
        public string RearVisibilitySystem { get; set; }
        public string SAEAutomationLevel { get; set; }

        [JsonProperty("SAEAutomationLevel_to")]
        public string SAEAutomationLevelTo { get; set; }
        public string SeatBeltsAll { get; set; }
        public string SeatRows { get; set; }
        public string Seats { get; set; }
        public string SemiautomaticHeadlampBeamSwitching { get; set; }
        public string Series { get; set; }
        public string Series2 { get; set; }
        public string SteeringLocation { get; set; }
        public string SuggestedVIN { get; set; }
        public string TPMS { get; set; }
        public string TopSpeedMPH { get; set; }
        public string TrackWidth { get; set; }
        public string TractionControl { get; set; }
        public string TrailerBodyType { get; set; }
        public string TrailerLength { get; set; }
        public string TrailerType { get; set; }
        public string TransmissionSpeeds { get; set; }
        public string TransmissionStyle { get; set; }
        public string Trim { get; set; }
        public string Trim2 { get; set; }
        public string Turbo { get; set; }
        public string VIN { get; set; }
        public string ValveTrainDesign { get; set; }
        public string VehicleType { get; set; }
        public string WheelBaseLong { get; set; }
        public string WheelBaseShort { get; set; }
        public string WheelBaseType { get; set; }
        public string WheelSizeFront { get; set; }
        public string WheelSizeRear { get; set; }
        public string Wheels { get; set; }
        public string Windows { get; set; }
    }

    public class DecodeWMIResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public DecodeWMIResponseResultsTypeItem[] Results { get; set; }
    }

    public class DecodeWMIResponseResultsTypeItem
    {
        public string CommonName { get; set; }
        public string CreatedOn { get; set; }
        public string DateAvailableToPublic { get; set; }
        public string Make { get; set; }
        public string ManufacturerName { get; set; }
        public string ParentCompanyName { get; set; }
        public string URL { get; set; }
        public string UpdatedOn { get; set; }
        public string VehicleType { get; set; }
    }

    public class WMIGetResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public WMIGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class WMIGetResponseResultsTypeItem
    {
        public string Country { get; set; }
        public string CreatedOn { get; set; }
        public string DateAvailableToPublic { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string UpdatedOn { get; set; }
        public string VehicleType { get; set; }
        public string WMI { get; set; }
    }

    public class MakeResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public MakeResponseResultsTypeItem[] Results { get; set; }
    }

    public class MakeResponseResultsTypeItem
    {
        [JsonProperty("Make_ID")]
        public int MakeId { get; set; }

        [JsonProperty("Make_Name")]
        public string MakeName { get; set; }
    }

    public class ManufacturerResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public ManufacturerResponseResultsTypeItem[] Results { get; set; }
    }

    public class ManufacturerResponseResultsTypeItem
    {
        public string Country { get; set; }

        [JsonProperty("Mfr_CommonName")]
        public string MfrCommonName { get; set; }

        [JsonProperty("Mfr_ID")]
        public int MfrId { get; set; }

        [JsonProperty("Mfr_Name")]
        public string MfrName { get; set; }
        public ManufacturerResponseResultsTypeItemVehicleTypesTypeItem[] VehicleTypes { get; set; }
    }

    public class ManufacturerResponseResultsTypeItemVehicleTypesTypeItem
    {
        public bool IsPrimary { get; set; }
        public string Name { get; set; }
    }

    public class ManufacturerDetailResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public ManufacturerDetailResponseResultsTypeItem[] Results { get; set; }
    }

    public class ManufacturerDetailResponseResultsTypeItem
    {
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ContactEmail { get; set; }
        public string ContactFax { get; set; }
        public string ContactPhone { get; set; }
        public string Country { get; set; }
        public string DBAs { get; set; }
        public JToken[] EquipmentItems { get; set; }
        public string LastUpdated { get; set; }
        public ManufacturerDetailResponseResultsTypeItemManufacturerTypesTypeItem[] ManufacturerTypes { get; set; }

        [JsonProperty("Mfr_CommonName")]
        public string MfrCommonName { get; set; }

        [JsonProperty("Mfr_ID")]
        public int MfrId { get; set; }

        [JsonProperty("Mfr_Name")]
        public string MfrName { get; set; }
        public string OtherManufacturerDetails { get; set; }
        public string PostalCode { get; set; }
        public string PrimaryProduct { get; set; }
        public string PrincipalFirstName { get; set; }
        public string PrincipalLastName { get; set; }
        public string PrincipalPosition { get; set; }
        public string StateProvince { get; set; }
        public string SubmittedName { get; set; }
        public string SubmittedOn { get; set; }
        public string SubmittedPosition { get; set; }
        public ManufacturerDetailResponseResultsTypeItemVehicleTypesTypeItem[] VehicleTypes { get; set; }
    }

    public class ManufacturerDetailResponseResultsTypeItemManufacturerTypesTypeItem
    {
        public string Name { get; set; }
    }

    public class ManufacturerDetailResponseResultsTypeItemVehicleTypesTypeItem
    {
        public string GVWRFrom { get; set; }
        public string GVWRTo { get; set; }
        public bool IsPrimary { get; set; }
        public string Name { get; set; }
    }

    public class ManufacturerNameResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public ManufacturerNameResponseResultsTypeItem[] Results { get; set; }
    }

    public class ManufacturerNameResponseResultsTypeItem
    {
        [JsonProperty("Make_ID")]
        public int MakeId { get; set; }

        [JsonProperty("Make_Name")]
        public string MakeName { get; set; }

        [JsonProperty("Mfr_Name")]
        public string MfrName { get; set; }
    }

    public class ManufacturerNameYearResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public ManufacturerNameYearResponseResultsTypeItem[] Results { get; set; }
    }

    public class ManufacturerNameYearResponseResultsTypeItem
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public int MfrId { get; set; }
        public string MfrName { get; set; }
    }

    public class MakeTypeResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public MakeTypeResponseResultsTypeItem[] Results { get; set; }
    }

    public class MakeTypeResponseResultsTypeItem
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
    }

    public class MakeVehicleTypeResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public MakeVehicleTypeResponseResultsTypeItem[] Results { get; set; }
    }

    public class MakeVehicleTypeResponseResultsTypeItem
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
    }

    public class EquipmentPlantResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public EquipmentPlantResponseResultsTypeItem[] Results { get; set; }
    }

    public class EquipmentPlantResponseResultsTypeItem
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string DOTCode { get; set; }
        public string Name { get; set; }
        public string OldDotCode { get; set; }
        public string PostalCode { get; set; }
        public string StateProvince { get; set; }
        public string Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FilterInput
    {
        [EnumMember(Value = "2016")]
        _2016,
        [EnumMember(Value = "2017")]
        _2017,
        [EnumMember(Value = "2018")]
        _2018,
        [EnumMember(Value = "2019")]
        _2019,
        [EnumMember(Value = "2020")]
        _2020,
        [EnumMember(Value = "2021")]
        _2021,
        [EnumMember(Value = "2022")]
        _2022,
        [EnumMember(Value = "2023")]
        _2023,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "16")]
        _16,
        New,
        Updated,
        Closed,
        All
    }

    public class MakeModelResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public MakeModelResponseResultsTypeItem[] Results { get; set; }
    }

    public class MakeModelResponseResultsTypeItem
    {
        [JsonProperty("Make_ID")]
        public int MakeId { get; set; }

        [JsonProperty("Make_Name")]
        public string MakeName { get; set; }

        [JsonProperty("Model_ID")]
        public int ModelId { get; set; }

        [JsonProperty("Model_Name")]
        public string ModelName { get; set; }
    }

    public class MakeModelYearTypeResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public MakeModelYearTypeResponseResultsTypeItem[] Results { get; set; }
    }

    public class MakeModelYearTypeResponseResultsTypeItem
    {
        [JsonProperty("Make_ID")]
        public int MakeId { get; set; }

        [JsonProperty("Make_Name")]
        public string MakeName { get; set; }

        [JsonProperty("Model_ID")]
        public int ModelId { get; set; }

        [JsonProperty("Model_Name")]
        public string ModelName { get; set; }
    }

    public class VehicleVariableResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public VehicleVariableResponseResultsTypeItem[] Results { get; set; }
    }

    public class VehicleVariableResponseResultsTypeItem
    {
        public string DataType { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class VehicleVariableValueResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public VehicleVariableValueResponseResultsTypeItem[] Results { get; set; }
    }

    public class VehicleVariableValueResponseResultsTypeItem
    {
        public string ElementName { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nhtsavpicip;

    public partial class WorkflowManagedActions
    {
        public NhtsavpicipActions Nhtsavpicip(string connectionId) => new NhtsavpicipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NhtsavpicipTriggers Nhtsavpicip(string connectionId) => new NhtsavpicipTriggers(connectionId);
    }
}