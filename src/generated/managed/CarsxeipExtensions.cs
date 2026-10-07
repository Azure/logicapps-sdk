//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Carsxeip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CarsxeipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [WorkflowExpressionFactory(nameof(__BuildSpecGet))]
        public IBodyWorkflowAction<SpecGetResponse> SpecGet([WorkflowExpression] Func<string> vin)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SpecGetResponse> __BuildSpecGet(WorkflowExpression<string> vin)
        {
            WorkflowExpression.Validate(vin, nameof(vin), required: true);
            return new DeferredBodyAction<SpecGetResponse>(() =>
            {
                var apiCallPath = "/specs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["vin"] = ExpressionConverter.Convert(vin);
                return new ApiConnectionAction<SpecGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [WorkflowExpressionFactory(nameof(__BuildValueGet))]
        public IBodyWorkflowAction<ValueGetResponse> ValueGet([WorkflowExpression] Func<string> vin)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValueGetResponse> __BuildValueGet(WorkflowExpression<string> vin)
        {
            WorkflowExpression.Validate(vin, nameof(vin), required: true);
            return new DeferredBodyAction<ValueGetResponse>(() =>
            {
                var apiCallPath = "/marketvalue";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["vin"] = ExpressionConverter.Convert(vin);
                return new ApiConnectionAction<ValueGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [WorkflowExpressionFactory(nameof(__BuildHistoryGet))]
        public IBodyWorkflowAction<HistoryGetResponse> HistoryGet([WorkflowExpression] Func<string> vin)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HistoryGetResponse> __BuildHistoryGet(WorkflowExpression<string> vin)
        {
            WorkflowExpression.Validate(vin, nameof(vin), required: true);
            return new DeferredBodyAction<HistoryGetResponse>(() =>
            {
                var apiCallPath = "/history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["vin"] = ExpressionConverter.Convert(vin);
                return new ApiConnectionAction<HistoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [WorkflowExpressionFactory(nameof(__BuildPlateDecode))]
        public IBodyWorkflowAction<PlateDecodeResponse> PlateDecode([WorkflowExpression] Func<string> plate, [WorkflowExpression] Func<string> state, [WorkflowExpression] Func<countryInput> country = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PlateDecodeResponse> __BuildPlateDecode(WorkflowExpression<string> plate, WorkflowExpression<string> state, WorkflowExpression<countryInput> country = null)
        {
            WorkflowExpression.Validate(plate, nameof(plate), required: true);
            WorkflowExpression.Validate(state, nameof(state), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            return new DeferredBodyAction<PlateDecodeResponse>(() =>
            {
                var apiCallPath = "/platedecoder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["plate"] = ExpressionConverter.Convert(plate);
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                return new ApiConnectionAction<PlateDecodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [WorkflowExpressionFactory(nameof(__BuildImageGet))]
        public IBodyWorkflowAction<ImageGetResponse> ImageGet([WorkflowExpression] Func<string> make, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<int> year = null, [WorkflowExpression] Func<string> trim = null, [WorkflowExpression] Func<string> color = null, [WorkflowExpression] Func<bool> transparent = null, [WorkflowExpression] Func<angleInput> angle = null, [WorkflowExpression] Func<photoTypeInput> photoType = null, [WorkflowExpression] Func<sizeInput> size = null, [WorkflowExpression] Func<licenseInput> license = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageGetResponse> __BuildImageGet(WorkflowExpression<string> make, WorkflowExpression<string> model, WorkflowExpression<int> year = null, WorkflowExpression<string> trim = null, WorkflowExpression<string> color = null, WorkflowExpression<bool> transparent = null, WorkflowExpression<angleInput> angle = null, WorkflowExpression<photoTypeInput> photoType = null, WorkflowExpression<sizeInput> size = null, WorkflowExpression<licenseInput> license = null)
        {
            WorkflowExpression.Validate(make, nameof(make), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: true);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(trim, nameof(trim), required: false);
            WorkflowExpression.Validate(color, nameof(color), required: false);
            WorkflowExpression.Validate(transparent, nameof(transparent), required: false);
            WorkflowExpression.Validate(angle, nameof(angle), required: false);
            WorkflowExpression.Validate(photoType, nameof(photoType), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(license, nameof(license), required: false);
            return new DeferredBodyAction<ImageGetResponse>(() =>
            {
                var apiCallPath = "/images";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["make"] = ExpressionConverter.Convert(make);
                callPayload.Queries["model"] = ExpressionConverter.Convert(model);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (trim != null)
                    callPayload.Queries["trim"] = ExpressionConverter.Convert(trim);
                if (color != null)
                    callPayload.Queries["color"] = ExpressionConverter.Convert(color);
                callPayload.Queries["transparent"] = Convert.ToString(true);
                if (transparent != null)
                    callPayload.Queries["transparent"] = ExpressionConverter.Convert(transparent);
                if (angle != null)
                    callPayload.Queries["angle"] = ExpressionConverter.Convert(angle);
                if (photoType != null)
                    callPayload.Queries["photoType"] = ExpressionConverter.Convert(photoType);
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                if (license != null)
                    callPayload.Queries["license"] = ExpressionConverter.Convert(license);
                return new ApiConnectionAction<ImageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [WorkflowExpressionFactory(nameof(__BuildPlateRecog))]
        public IBodyWorkflowAction<PlateRecogResponse> PlateRecog([WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PlateRecogResponse> __BuildPlateRecog(WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PlateRecogResponse>(() =>
            {
                var apiCallPath = "/platerecognition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("text/plain");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PlateRecogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [WorkflowExpressionFactory(nameof(__BuildCodeGet))]
        public IBodyWorkflowAction<CodeGetResponse> CodeGet([WorkflowExpression] Func<string> code)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carsxeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CodeGetResponse> __BuildCodeGet(WorkflowExpression<string> code)
        {
            WorkflowExpression.Validate(code, nameof(code), required: true);
            return new DeferredBodyAction<CodeGetResponse>(() =>
            {
                var apiCallPath = "/obdcodesdecoder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
                return new ApiConnectionAction<CodeGetResponse>(callPayload);
            });
        }
    }

    public class CarsxeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SpecGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("input")]
        public SpecGetResponseInputType Input { get; set; }

        [JsonProperty("attributes")]
        public SpecGetResponseAttributesType Attributes { get; set; }

        [JsonProperty("colors")]
        public SpecGetResponseColorsTypeItem[] Colors { get; set; }

        [JsonProperty("equipment")]
        public SpecGetResponseEquipmentType Equipment { get; set; }

        [JsonProperty("warranties")]
        public SpecGetResponseWarrantiesTypeItem[] Warranties { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SpecGetResponseInputType
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("vin")]
        public string Vin { get; set; }
    }

    public class SpecGetResponseAttributesType
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("trim")]
        public string Trim { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("made_in")]
        public string MadeIn { get; set; }

        [JsonProperty("made_in_city")]
        public string MadeInCity { get; set; }

        [JsonProperty("doors")]
        public string Doors { get; set; }

        [JsonProperty("fuel_type")]
        public string FuelType { get; set; }

        [JsonProperty("fuel_capacity")]
        public string FuelCapacity { get; set; }

        [JsonProperty("city_mileage")]
        public string CityMileage { get; set; }

        [JsonProperty("highway_mileage")]
        public string HighwayMileage { get; set; }

        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("engine_size")]
        public string EngineSize { get; set; }

        [JsonProperty("engine_cylinders")]
        public string EngineCylinders { get; set; }

        [JsonProperty("transmission")]
        public string Transmission { get; set; }

        [JsonProperty("transmission_short")]
        public string TransmissionShort { get; set; }

        [JsonProperty("transmission_type")]
        public string TransmissionType { get; set; }

        [JsonProperty("transmission_speeds")]
        public string TransmissionSpeeds { get; set; }

        [JsonProperty("drivetrain")]
        public string Drivetrain { get; set; }

        [JsonProperty("anti_brake_system")]
        public string AntiBrakeSystem { get; set; }

        [JsonProperty("steering_type")]
        public string SteeringType { get; set; }

        [JsonProperty("curb_weight")]
        public string CurbWeight { get; set; }

        [JsonProperty("gross_vehicle_weight_rating")]
        public string GrossVehicleWeightRating { get; set; }

        [JsonProperty("overall_height")]
        public string OverallHeight { get; set; }

        [JsonProperty("overall_length")]
        public string OverallLength { get; set; }

        [JsonProperty("overall_width")]
        public string OverallWidth { get; set; }

        [JsonProperty("wheelbase_length")]
        public string WheelbaseLength { get; set; }

        [JsonProperty("standard_seating")]
        public string StandardSeating { get; set; }

        [JsonProperty("invoice_price")]
        public string InvoicePrice { get; set; }

        [JsonProperty("delivery_charges")]
        public string DeliveryCharges { get; set; }

        [JsonProperty("manufacturer_suggested_retail_price")]
        public string ManufacturerSuggestedRetailPrice { get; set; }

        [JsonProperty("production_seq_number")]
        public string ProductionSeqNumber { get; set; }

        [JsonProperty("front_brake_type")]
        public string FrontBrakeType { get; set; }

        [JsonProperty("rear_brake_type")]
        public string RearBrakeType { get; set; }

        [JsonProperty("turning_diameter")]
        public string TurningDiameter { get; set; }

        [JsonProperty("front_suspension")]
        public string FrontSuspension { get; set; }

        [JsonProperty("rear_suspension")]
        public string RearSuspension { get; set; }

        [JsonProperty("front_spring_type")]
        public string FrontSpringType { get; set; }

        [JsonProperty("rear_spring_type")]
        public string RearSpringType { get; set; }

        [JsonProperty("tires")]
        public string Tires { get; set; }

        [JsonProperty("front_headroom")]
        public string FrontHeadroom { get; set; }

        [JsonProperty("rear_headroom")]
        public string RearHeadroom { get; set; }

        [JsonProperty("front_legroom")]
        public string FrontLegroom { get; set; }

        [JsonProperty("rear_legroom")]
        public string RearLegroom { get; set; }

        [JsonProperty("front_shoulder_room")]
        public string FrontShoulderRoom { get; set; }

        [JsonProperty("rear_shoulder_room")]
        public string RearShoulderRoom { get; set; }

        [JsonProperty("front_hip_room")]
        public string FrontHipRoom { get; set; }

        [JsonProperty("rear_hip_room")]
        public string RearHipRoom { get; set; }

        [JsonProperty("interior_trim")]
        public string[] InteriorTrim { get; set; }

        [JsonProperty("exterior_color")]
        public string[] ExteriorColor { get; set; }

        [JsonProperty("curb_weight_manual")]
        public string CurbWeightManual { get; set; }

        [JsonProperty("ground_clearance")]
        public string GroundClearance { get; set; }

        [JsonProperty("track_front")]
        public string TrackFront { get; set; }

        [JsonProperty("track_rear")]
        public string TrackRear { get; set; }

        [JsonProperty("cargo_length")]
        public string CargoLength { get; set; }

        [JsonProperty("width_at_wheelwell")]
        public string WidthAtWheelwell { get; set; }

        [JsonProperty("width_at_wall")]
        public string WidthAtWall { get; set; }

        [JsonProperty("depth")]
        public string Depth { get; set; }

        [JsonProperty("optional_seating")]
        public string OptionalSeating { get; set; }

        [JsonProperty("passenger_volume")]
        public string PassengerVolume { get; set; }

        [JsonProperty("cargo_volume")]
        public string CargoVolume { get; set; }

        [JsonProperty("standard_towing")]
        public string StandardTowing { get; set; }

        [JsonProperty("maximum_towing")]
        public string MaximumTowing { get; set; }

        [JsonProperty("standard_payload")]
        public string StandardPayload { get; set; }

        [JsonProperty("maximum_payload")]
        public string MaximumPayload { get; set; }

        [JsonProperty("maximum_gvwr")]
        public string MaximumGvwr { get; set; }
    }

    public class SpecGetResponseColorsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SpecGetResponseEquipmentType
    {
        [JsonProperty("4wd_awd")]
        public string _4wdAwd { get; set; }

        [JsonProperty("abs_brakes")]
        public string AbsBrakes { get; set; }

        [JsonProperty("adjustable_foot_pedals")]
        public string AdjustableFootPedals { get; set; }

        [JsonProperty("air_conditioning")]
        public string AirConditioning { get; set; }

        [JsonProperty("alloy_wheels")]
        public string AlloyWheels { get; set; }

        [JsonProperty("am_fm_radio")]
        public string AmFmRadio { get; set; }

        [JsonProperty("automatic_headlights")]
        public string AutomaticHeadlights { get; set; }

        [JsonProperty("automatic_load_leveling")]
        public string AutomaticLoadLeveling { get; set; }

        [JsonProperty("cargo_area_cover")]
        public string CargoAreaCover { get; set; }

        [JsonProperty("cargo_area_tiedowns")]
        public string CargoAreaTiedowns { get; set; }

        [JsonProperty("cargo_net")]
        public string CargoNet { get; set; }

        [JsonProperty("cassette_player")]
        public string CassettePlayer { get; set; }

        [JsonProperty("cd_changer")]
        public string CdChanger { get; set; }

        [JsonProperty("cd_player")]
        public string CdPlayer { get; set; }

        [JsonProperty("child_safety_door_locks")]
        public string ChildSafetyDoorLocks { get; set; }

        [JsonProperty("chrome_wheels")]
        public string ChromeWheels { get; set; }

        [JsonProperty("cruise_control")]
        public string CruiseControl { get; set; }

        [JsonProperty("daytime_running_lights")]
        public string DaytimeRunningLights { get; set; }

        [JsonProperty("deep_tinted_glass")]
        public string DeepTintedGlass { get; set; }

        [JsonProperty("driver_airbag")]
        public string DriverAirbag { get; set; }

        [JsonProperty("driver_multi_adjustable_power_seat")]
        public string DriverMultiAdjustablePowerSeat { get; set; }

        [JsonProperty("dvd_player")]
        public string DvdPlayer { get; set; }

        [JsonProperty("electrochromic_exterior_rearview_mirror")]
        public string ElectrochromicExteriorRearviewMirror { get; set; }

        [JsonProperty("electrochromic_interior_rearview_mirror")]
        public string ElectrochromicInteriorRearviewMirror { get; set; }

        [JsonProperty("electronic_brake_assistance")]
        public string ElectronicBrakeAssistance { get; set; }

        [JsonProperty("electronic_parking_aid")]
        public string ElectronicParkingAid { get; set; }

        [JsonProperty("first_aid_kit")]
        public string FirstAidKit { get; set; }

        [JsonProperty("fog_lights")]
        public string FogLights { get; set; }

        [JsonProperty("front_air_dam")]
        public string FrontAirDam { get; set; }

        [JsonProperty("front_cooled_seat")]
        public string FrontCooledSeat { get; set; }

        [JsonProperty("front_heated_seat")]
        public string FrontHeatedSeat { get; set; }

        [JsonProperty("front_power_lumbar_support")]
        public string FrontPowerLumbarSupport { get; set; }

        [JsonProperty("front_power_memory_seat")]
        public string FrontPowerMemorySeat { get; set; }

        [JsonProperty("front_side_airbag")]
        public string FrontSideAirbag { get; set; }

        [JsonProperty("front_side_airbag_with_head_protection")]
        public string FrontSideAirbagWithHeadProtection { get; set; }

        [JsonProperty("front_split_bench_seat")]
        public string FrontSplitBenchSeat { get; set; }

        [JsonProperty("full_size_spare_tire")]
        public string FullSizeSpareTire { get; set; }

        [JsonProperty("genuine_wood_trim")]
        public string GenuineWoodTrim { get; set; }

        [JsonProperty("glass_rear_window_on_convertible")]
        public string GlassRearWindowOnConvertible { get; set; }

        [JsonProperty("heated_exterior_mirror")]
        public string HeatedExteriorMirror { get; set; }

        [JsonProperty("heated_steering_wheel")]
        public string HeatedSteeringWheel { get; set; }

        [JsonProperty("high_intensity_discharge_headlights")]
        public string HighIntensityDischargeHeadlights { get; set; }

        [JsonProperty("interval_wipers")]
        public string IntervalWipers { get; set; }

        [JsonProperty("keyless_entry")]
        public string KeylessEntry { get; set; }

        [JsonProperty("leather_seat")]
        public string LeatherSeat { get; set; }

        [JsonProperty("leather_steering_wheel")]
        public string LeatherSteeringWheel { get; set; }

        [JsonProperty("limited_slip_differential")]
        public string LimitedSlipDifferential { get; set; }

        [JsonProperty("load_bearing_exterior_rack")]
        public string LoadBearingExteriorRack { get; set; }

        [JsonProperty("locking_differential")]
        public string LockingDifferential { get; set; }

        [JsonProperty("locking_pickup_truck_tailgate")]
        public string LockingPickupTruckTailgate { get; set; }

        [JsonProperty("manual_sunroof")]
        public string ManualSunroof { get; set; }

        [JsonProperty("navigation_aid")]
        public string NavigationAid { get; set; }

        [JsonProperty("passenger_airbag")]
        public string PassengerAirbag { get; set; }

        [JsonProperty("passenger_multi_adjustable_power_seat")]
        public string PassengerMultiAdjustablePowerSeat { get; set; }

        [JsonProperty("pickup_truck_bed_liner")]
        public string PickupTruckBedLiner { get; set; }

        [JsonProperty("pickup_truck_cargo_box_light")]
        public string PickupTruckCargoBoxLight { get; set; }

        [JsonProperty("power_adjustable_exterior_mirror")]
        public string PowerAdjustableExteriorMirror { get; set; }

        [JsonProperty("power_door_locks")]
        public string PowerDoorLocks { get; set; }

        [JsonProperty("power_sliding_side_van_door")]
        public string PowerSlidingSideVanDoor { get; set; }

        [JsonProperty("power_sunroof")]
        public string PowerSunroof { get; set; }

        [JsonProperty("power_trunk_lid")]
        public string PowerTrunkLid { get; set; }

        [JsonProperty("power_windows")]
        public string PowerWindows { get; set; }

        [JsonProperty("rain_sensing_wipers")]
        public string RainSensingWipers { get; set; }

        [JsonProperty("rear_spoiler")]
        public string RearSpoiler { get; set; }

        [JsonProperty("rear_window_defogger")]
        public string RearWindowDefogger { get; set; }

        [JsonProperty("rear_wiper")]
        public string RearWiper { get; set; }

        [JsonProperty("remote_ignition")]
        public string RemoteIgnition { get; set; }

        [JsonProperty("removable_top")]
        public string RemovableTop { get; set; }

        [JsonProperty("run_flat_tires")]
        public string RunFlatTires { get; set; }

        [JsonProperty("running_boards")]
        public string RunningBoards { get; set; }

        [JsonProperty("second_row_folding_seat")]
        public string SecondRowFoldingSeat { get; set; }

        [JsonProperty("second_row_heated_seat")]
        public string SecondRowHeatedSeat { get; set; }

        [JsonProperty("second_row_multi_adjustable_power_seat")]
        public string SecondRowMultiAdjustablePowerSeat { get; set; }

        [JsonProperty("second_row_removable_seat")]
        public string SecondRowRemovableSeat { get; set; }

        [JsonProperty("second_row_side_airbag")]
        public string SecondRowSideAirbag { get; set; }

        [JsonProperty("second_row_side_airbag_with_head_protection")]
        public string SecondRowSideAirbagWithHeadProtection { get; set; }

        [JsonProperty("second_row_sound_controls")]
        public string SecondRowSoundControls { get; set; }

        [JsonProperty("separate_driver_front_passenger_climate_controls")]
        public string SeparateDriverFrontPassengerClimateControls { get; set; }

        [JsonProperty("side_head_curtain_airbag")]
        public string SideHeadCurtainAirbag { get; set; }

        [JsonProperty("skid_plate")]
        public string SkidPlate { get; set; }

        [JsonProperty("sliding_rear_pickup_truck_window")]
        public string SlidingRearPickupTruckWindow { get; set; }

        [JsonProperty("splash_guards")]
        public string SplashGuards { get; set; }

        [JsonProperty("steel_wheels")]
        public string SteelWheels { get; set; }

        [JsonProperty("steering_wheel_mounted_controls")]
        public string SteeringWheelMountedControls { get; set; }

        [JsonProperty("subwoofer")]
        public string Subwoofer { get; set; }

        [JsonProperty("tachometer")]
        public string Tachometer { get; set; }

        [JsonProperty("telematics_system")]
        public string TelematicsSystem { get; set; }

        [JsonProperty("telescopic_steering_column")]
        public string TelescopicSteeringColumn { get; set; }

        [JsonProperty("third_row_removable_seat")]
        public string ThirdRowRemovableSeat { get; set; }

        [JsonProperty("tilt_steering")]
        public string TiltSteering { get; set; }

        [JsonProperty("tilt_steering_column")]
        public string TiltSteeringColumn { get; set; }

        [JsonProperty("tire_pressure_monitor")]
        public string TirePressureMonitor { get; set; }

        [JsonProperty("tow_hitch_receiver")]
        public string TowHitchReceiver { get; set; }

        [JsonProperty("towing_preparation_package")]
        public string TowingPreparationPackage { get; set; }

        [JsonProperty("traction_control")]
        public string TractionControl { get; set; }

        [JsonProperty("trip_computer")]
        public string TripComputer { get; set; }

        [JsonProperty("trunk_anti_trap_device")]
        public string TrunkAntiTrapDevice { get; set; }

        [JsonProperty("vehicle_anti_theft")]
        public string VehicleAntiTheft { get; set; }

        [JsonProperty("vehicle_stability_control_system")]
        public string VehicleStabilityControlSystem { get; set; }

        [JsonProperty("voice_activated_telephone")]
        public string VoiceActivatedTelephone { get; set; }

        [JsonProperty("wind_deflector_for_convertibles")]
        public string WindDeflectorForConvertibles { get; set; }
    }

    public class SpecGetResponseWarrantiesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("miles")]
        public string Miles { get; set; }

        [JsonProperty("months")]
        public string Months { get; set; }
    }

    public class ValueGetResponse
    {
        [JsonProperty("modelYear")]
        public string ModelYear { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("retail")]
        public string Retail { get; set; }

        [JsonProperty("mileageAdjustment")]
        public string MileageAdjustment { get; set; }

        [JsonProperty("adjustedCleanTrade")]
        public string AdjustedCleanTrade { get; set; }

        [JsonProperty("tradeIn")]
        public string TradeIn { get; set; }

        [JsonProperty("averageTradeIn")]
        public string AverageTradeIn { get; set; }

        [JsonProperty("adjustedCleanRetail")]
        public string AdjustedCleanRetail { get; set; }

        [JsonProperty("vin")]
        public string Vin { get; set; }

        [JsonProperty("loanValue")]
        public string LoanValue { get; set; }

        [JsonProperty("tradeInValues")]
        public string[] TradeInValues { get; set; }

        [JsonProperty("fuelType")]
        public string FuelType { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("minAdjRoughTrade")]
        public string MinAdjRoughTrade { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("minAdjRetail")]
        public string MinAdjRetail { get; set; }

        [JsonProperty("averageMileage")]
        public string AverageMileage { get; set; }

        [JsonProperty("minAdjCleanTrade")]
        public string MinAdjCleanTrade { get; set; }

        [JsonProperty("minMileageAdj")]
        public string MinMileageAdj { get; set; }

        [JsonProperty("maxMileageAdj")]
        public string MaxMileageAdj { get; set; }

        [JsonProperty("minAdjLoan")]
        public string MinAdjLoan { get; set; }

        [JsonProperty("adjustedLoan")]
        public string AdjustedLoan { get; set; }

        [JsonProperty("msrp")]
        public string Msrp { get; set; }

        [JsonProperty("roughTradeIn")]
        public string RoughTradeIn { get; set; }

        [JsonProperty("adjustedRoughTrade")]
        public string AdjustedRoughTrade { get; set; }

        [JsonProperty("minAdjAverageTrade")]
        public string MinAdjAverageTrade { get; set; }

        [JsonProperty("adjustedAverageTrade")]
        public string AdjustedAverageTrade { get; set; }
    }

    public class HistoryGetResponse
    {
        [JsonProperty("insuranceInformation")]
        public HistoryGetResponseInsuranceInformationTypeItem[] InsuranceInformation { get; set; }

        [JsonProperty("historyInformation")]
        public HistoryGetResponseHistoryInformationTypeItem[] HistoryInformation { get; set; }

        [JsonProperty("vin")]
        public string Vin { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("currentTitleInformation")]
        public HistoryGetResponseCurrentTitleInformationTypeItem[] CurrentTitleInformation { get; set; }

        [JsonProperty("vinChanged")]
        public bool VinChanged { get; set; }

        [JsonProperty("brandsInformation")]
        public HistoryGetResponseBrandsInformationTypeItem[] BrandsInformation { get; set; }

        [JsonProperty("junkAndSalvageInformation")]
        public HistoryGetResponseJunkAndSalvageInformationTypeItem[] JunkAndSalvageInformation { get; set; }

        [JsonProperty("brandsRecordCount")]
        public int BrandsRecordCount { get; set; }
    }

    public class HistoryGetResponseInsuranceInformationTypeItem
    {
        public string VehicleObtainedDate { get; set; }
        public HistoryGetResponseInsuranceInformationTypeItemReportingEntityAbstractType ReportingEntityAbstract { get; set; }
        public string VehicleDispositionText { get; set; }
    }

    public class HistoryGetResponseInsuranceInformationTypeItemReportingEntityAbstractType
    {
        public string ContactEmailID { get; set; }
        public string LocationStateUSPostalServiceCode { get; set; }
        public string ReportingEntityCategoryCode { get; set; }
        public string ReportingEntityCategoryText { get; set; }
        public string EntityName { get; set; }
        public string LocationCityName { get; set; }
        public string IdentificationID { get; set; }
        public string TelephoneNumberFullID { get; set; }
    }

    public class HistoryGetResponseHistoryInformationTypeItem
    {
        public HistoryGetResponseHistoryInformationTypeItemVehicleIdentificationType VehicleIdentification { get; set; }
        public string VehicleOdometerReadingMeasure { get; set; }
        public string VehicleOdometerReadingUnitCode { get; set; }
        public string TitleIssuingAuthorityName { get; set; }
        public HistoryGetResponseHistoryInformationTypeItemTitleIssueDateType TitleIssueDate { get; set; }
    }

    public class HistoryGetResponseHistoryInformationTypeItemVehicleIdentificationType
    {
        public string IdentificationID { get; set; }
    }

    public class HistoryGetResponseHistoryInformationTypeItemTitleIssueDateType
    {
        public string Date { get; set; }
    }

    public class HistoryGetResponseCurrentTitleInformationTypeItem
    {
        public string VehicleOdometerReadingMeasure { get; set; }
        public string VehicleOdometerReadingUnitCode { get; set; }
        public string RecordMatchSequenceID { get; set; }
        public HistoryGetResponseCurrentTitleInformationTypeItemHistoricTitleAbstractTypeItem[] HistoricTitleAbstract { get; set; }
        public string TitleIssuingAuthorityName { get; set; }
        public HistoryGetResponseCurrentTitleInformationTypeItemTitleIssueDateType TitleIssueDate { get; set; }
        public HistoryGetResponseCurrentTitleInformationTypeItemVehicleIdentificationType VehicleIdentification { get; set; }
    }

    public class HistoryGetResponseCurrentTitleInformationTypeItemHistoricTitleAbstractTypeItem
    {
        public HistoryGetResponseCurrentTitleInformationTypeItemHistoricTitleAbstractTypeItemTitleIssueDateType TitleIssueDate { get; set; }
        public HistoryGetResponseCurrentTitleInformationTypeItemHistoricTitleAbstractTypeItemVehicleIdentificationType VehicleIdentification { get; set; }
        public string VehicleOdometerReadingMeasure { get; set; }
        public string VehicleOdometerReadingUnitCode { get; set; }
        public string TitleIssuingAuthorityName { get; set; }
    }

    public class HistoryGetResponseCurrentTitleInformationTypeItemHistoricTitleAbstractTypeItemTitleIssueDateType
    {
        public string Date { get; set; }
    }

    public class HistoryGetResponseCurrentTitleInformationTypeItemHistoricTitleAbstractTypeItemVehicleIdentificationType
    {
        public string IdentificationID { get; set; }
    }

    public class HistoryGetResponseCurrentTitleInformationTypeItemTitleIssueDateType
    {
        public string Date { get; set; }
    }

    public class HistoryGetResponseCurrentTitleInformationTypeItemVehicleIdentificationType
    {
        public string IdentificationID { get; set; }
    }

    public class HistoryGetResponseBrandsInformationTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("record")]
        public HistoryGetResponseBrandsInformationTypeItemRecordType Record { get; set; }
    }

    public class HistoryGetResponseBrandsInformationTypeItemRecordType
    {
        public HistoryGetResponseBrandsInformationTypeItemRecordTypeVehicleBrandDateType VehicleBrandDate { get; set; }
        public string VehicleBrandCode { get; set; }
        public HistoryGetResponseBrandsInformationTypeItemRecordTypeReportingEntityAbstractType ReportingEntityAbstract { get; set; }
        public string VehicleDispositionText { get; set; }
    }

    public class HistoryGetResponseBrandsInformationTypeItemRecordTypeVehicleBrandDateType
    {
        public string Date { get; set; }
    }

    public class HistoryGetResponseBrandsInformationTypeItemRecordTypeReportingEntityAbstractType
    {
        public string EntityName { get; set; }
        public string ReportingEntityCategoryText { get; set; }
        public string ReportingEntityCategoryCode { get; set; }
        public string IdentificationID { get; set; }
    }

    public class HistoryGetResponseJunkAndSalvageInformationTypeItem
    {
        public string VehicleObtainedDate { get; set; }
        public HistoryGetResponseJunkAndSalvageInformationTypeItemReportingEntityAbstractType ReportingEntityAbstract { get; set; }
        public string VehicleIntendedForExportCode { get; set; }
        public string VehicleDispositionText { get; set; }
    }

    public class HistoryGetResponseJunkAndSalvageInformationTypeItemReportingEntityAbstractType
    {
        public string EntityName { get; set; }
        public string LocationCityName { get; set; }
        public string ReportingEntityCategoryText { get; set; }
        public string ContactEmailID { get; set; }
        public string TelephoneNumberFullID { get; set; }
        public string IdentificationID { get; set; }
        public string LocationStateUSPostalServiceCode { get; set; }
        public string ReportingEntityCategoryCode { get; set; }
    }

    public class PlateDecodeResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("input")]
        public PlateDecodeResponseInputType Input { get; set; }
        public string CarModel { get; set; }
        public string EngineSize { get; set; }
        public string Description { get; set; }
        public string CarMake { get; set; }

        [JsonProperty("assembly")]
        public string Assembly { get; set; }
        public string RegistrationYear { get; set; }

        [JsonProperty("vin")]
        public string Vin { get; set; }
        public string BodyStyle { get; set; }
        public string NumberOfDoors { get; set; }
    }

    public class PlateDecodeResponseInputType
    {
        [JsonProperty("plate")]
        public string Plate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum countryInput
    {
        [EnumMember(Value = "au")]
        Au
    }

    public class ImageGetResponse
    {
        [JsonProperty("query")]
        public ImageGetResponseQueryType Query { get; set; }

        [JsonProperty("images")]
        public ImageGetResponseImagesTypeItem[] Images { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class ImageGetResponseQueryType
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("transparent")]
        public string Transparent { get; set; }
    }

    public class ImageGetResponseImagesTypeItem
    {
        [JsonProperty("mime")]
        public string Mime { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("contextLink")]
        public string ContextLink { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("byteSize")]
        public int ByteSize { get; set; }

        [JsonProperty("thumbnailLink")]
        public string ThumbnailLink { get; set; }

        [JsonProperty("thumbnailHeight")]
        public int ThumbnailHeight { get; set; }

        [JsonProperty("thumbnailWidth")]
        public int ThumbnailWidth { get; set; }

        [JsonProperty("hostPageDomainFriendlyName")]
        public string HostPageDomainFriendlyName { get; set; }

        [JsonProperty("accentColor")]
        public string AccentColor { get; set; }

        [JsonProperty("datePublished")]
        public string DatePublished { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum angleInput
    {
        [EnumMember(Value = "front")]
        Front,
        [EnumMember(Value = "side")]
        Side,
        [EnumMember(Value = "back")]
        Back
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum photoTypeInput
    {
        [EnumMember(Value = "interior")]
        Interior,
        [EnumMember(Value = "exterior")]
        Exterior,
        [EnumMember(Value = "engine")]
        Engine
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sizeInput
    {
        All,
        Small,
        Medium,
        Large,
        Wallpaper
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum licenseInput
    {
        Public,
        Share,
        ShareCommercially,
        Modify,
        ModifyCommercially
    }

    public class PlateRecogResponse
    {
        [JsonProperty("results")]
        public PlateRecogResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("camera_id")]
        public string CameraId { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("processing_time")]
        public double ProcessingTime { get; set; }
    }

    public class PlateRecogResponseResultsTypeItem
    {
        [JsonProperty("box")]
        public PlateRecogResponseResultsTypeItemBoxType Box { get; set; }

        [JsonProperty("candidates")]
        public PlateRecogResponseResultsTypeItemCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("dscore")]
        public double Dscore { get; set; }

        [JsonProperty("plate")]
        public string Plate { get; set; }

        [JsonProperty("region")]
        public PlateRecogResponseResultsTypeItemRegionType Region { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("vehicle")]
        public PlateRecogResponseResultsTypeItemVehicleType Vehicle { get; set; }
    }

    public class PlateRecogResponseResultsTypeItemBoxType
    {
        [JsonProperty("xmax")]
        public int Xmax { get; set; }

        [JsonProperty("xmin")]
        public int Xmin { get; set; }

        [JsonProperty("ymax")]
        public int Ymax { get; set; }

        [JsonProperty("ymin")]
        public int Ymin { get; set; }
    }

    public class PlateRecogResponseResultsTypeItemCandidatesTypeItem
    {
        [JsonProperty("plate")]
        public string Plate { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class PlateRecogResponseResultsTypeItemRegionType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class PlateRecogResponseResultsTypeItemVehicleType
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CodeGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("diagnosis")]
        public string Diagnosis { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Carsxeip;

    public partial class WorkflowManagedActions
    {
        public CarsxeipActions Carsxeip(string connectionId) => new CarsxeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CarsxeipTriggers Carsxeip(string connectionId) => new CarsxeipTriggers(connectionId);
    }
}