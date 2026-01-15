//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Nearearthobjectwebip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NearearthobjectwebipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nearearthobjectwebip")]
        public IBodyWorkflowAction<FeedResponse> Feed(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<bool>> detailed = null)
        {
            var apiCallPath = "/feed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
            if (detailed != null)
                callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
            return new ApiConnectionAction<FeedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nearearthobjectwebip")]
        public IBodyWorkflowAction<FeedTodayResponse> FeedToday(Expression<Func<bool>> detailed = null)
        {
            var apiCallPath = "/feed/today";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (detailed != null)
                callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
            return new ApiConnectionAction<FeedTodayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nearearthobjectwebip")]
        public IBodyWorkflowAction<NeoResponse> Neo(Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/neo/browse";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<NeoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nearearthobjectwebip")]
        public IBodyWorkflowAction<NeoIDResponse> NeoID(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/neo/{0}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NeoIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nearearthobjectwebip")]
        public IBodyWorkflowAction<SentryResponse> Sentry(Expression<Func<bool>> isActive = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/neo/sentry";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (isActive != null)
                callPayload.Queries["is_active"] = ExpressionConverter.Convert(isActive);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<SentryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nearearthobjectwebip")]
        public IBodyWorkflowAction<SentryIDResponse> SentryID(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/neo/sentry/{0}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SentryIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nearearthobjectwebip")]
        public IBodyWorkflowAction<StatsResponse> Stats()
        {
            var apiCallPath = "/stats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatsResponse>(callPayload);
        }
    }

    public class NearearthobjectwebipTriggers([ConnectionName] string connectionId)
    {
    }

    public class FeedResponse
    {
        [JsonProperty("links")]
        public FeedResponseLinksType Links { get; set; }

        [JsonProperty("element_count")]
        public int ElementCount { get; set; }

        [JsonProperty("near_earth_objects")]
        public FeedResponseNearEarthObjectsType NearEarthObjects { get; set; }
    }

    public class FeedResponseLinksType
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class FeedResponseNearEarthObjectsType
    {
        [JsonProperty("date")]
        public FeedResponseNearEarthObjectsTypeDateTypeItem[] Date { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItem
    {
        [JsonProperty("links")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("neo_reference_id")]
        public string NeoReferenceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public int AbsoluteMagnitudeH { get; set; }

        [JsonProperty("estimated_diameter")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterType EstimatedDiameter { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }

        [JsonProperty("close_approach_data")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItem[] CloseApproachData { get; set; }

        [JsonProperty("orbital_data")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemOrbitalDataType OrbitalData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterType
    {
        [JsonProperty("kilometers")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeKilometersType Kilometers { get; set; }

        [JsonProperty("meters")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeMetersType Meters { get; set; }

        [JsonProperty("miles")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeMilesType Miles { get; set; }

        [JsonProperty("feet")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeFeetType Feet { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeKilometersType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeMetersType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeMilesType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeFeetType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItem
    {
        [JsonProperty("close_approach_date")]
        public string CloseApproachDate { get; set; }

        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public int EpochDateCloseApproach { get; set; }

        [JsonProperty("relative_velocity")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItemRelativeVelocityType RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItemMissDistanceType MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItemRelativeVelocityType
    {
        [JsonProperty("kilometers_per_second")]
        public string KilometersPerSecond { get; set; }

        [JsonProperty("kilometers_per_hour")]
        public string KilometersPerHour { get; set; }

        [JsonProperty("miles_per_hour")]
        public string MilesPerHour { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItemMissDistanceType
    {
        [JsonProperty("astronomical")]
        public string Astronomical { get; set; }

        [JsonProperty("lunar")]
        public string Lunar { get; set; }

        [JsonProperty("kilometers")]
        public string Kilometers { get; set; }

        [JsonProperty("miles")]
        public string Miles { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemOrbitalDataType
    {
        [JsonProperty("orbit_id")]
        public string OrbitId { get; set; }

        [JsonProperty("orbit_determination_date")]
        public string OrbitDeterminationDate { get; set; }

        [JsonProperty("first_observation_date")]
        public string FirstObservationDate { get; set; }

        [JsonProperty("last_observation_date")]
        public string LastObservationDate { get; set; }

        [JsonProperty("data_arc_in_days")]
        public int DataArcInDays { get; set; }

        [JsonProperty("observations_used")]
        public int ObservationsUsed { get; set; }

        [JsonProperty("orbit_uncertainty")]
        public string OrbitUncertainty { get; set; }

        [JsonProperty("minimum_orbit_intersection")]
        public string MinimumOrbitIntersection { get; set; }

        [JsonProperty("jupiter_tisserand_invariant")]
        public string JupiterTisserandInvariant { get; set; }

        [JsonProperty("epoch_osculation")]
        public string EpochOsculation { get; set; }

        [JsonProperty("eccentricity")]
        public string Eccentricity { get; set; }

        [JsonProperty("semi_major_axis")]
        public string SemiMajorAxis { get; set; }

        [JsonProperty("inclination")]
        public string Inclination { get; set; }

        [JsonProperty("ascending_node_longitude")]
        public string AscendingNodeLongitude { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("perihelion_distance")]
        public string PerihelionDistance { get; set; }

        [JsonProperty("perihelion_argument")]
        public string PerihelionArgument { get; set; }

        [JsonProperty("aphelion_distance")]
        public string AphelionDistance { get; set; }

        [JsonProperty("perihelion_time")]
        public string PerihelionTime { get; set; }

        [JsonProperty("mean_anomaly")]
        public string MeanAnomaly { get; set; }

        [JsonProperty("mean_motion")]
        public string MeanMotion { get; set; }

        [JsonProperty("equinox")]
        public string Equinox { get; set; }

        [JsonProperty("orbit_class")]
        public FeedResponseNearEarthObjectsTypeDateTypeItemOrbitalDataTypeOrbitClassType OrbitClass { get; set; }
    }

    public class FeedResponseNearEarthObjectsTypeDateTypeItemOrbitalDataTypeOrbitClassType
    {
        [JsonProperty("orbit_class_type")]
        public string OrbitClassType { get; set; }

        [JsonProperty("orbit_class_description")]
        public string OrbitClassDescription { get; set; }

        [JsonProperty("orbit_class_range")]
        public string OrbitClassRange { get; set; }
    }

    public class FeedTodayResponse
    {
        [JsonProperty("links")]
        public FeedTodayResponseLinksType Links { get; set; }

        [JsonProperty("element_count")]
        public int ElementCount { get; set; }

        [JsonProperty("near_earth_objects")]
        public FeedTodayResponseNearEarthObjectsType NearEarthObjects { get; set; }
    }

    public class FeedTodayResponseLinksType
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsType
    {
        [JsonProperty("date")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItem[] Date { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItem
    {
        [JsonProperty("links")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("neo_reference_id")]
        public string NeoReferenceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double AbsoluteMagnitudeH { get; set; }

        [JsonProperty("estimated_diameter")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterType EstimatedDiameter { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }

        [JsonProperty("close_approach_data")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItem[] CloseApproachData { get; set; }

        [JsonProperty("orbital_data")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemOrbitalDataType OrbitalData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterType
    {
        [JsonProperty("kilometers")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeKilometersType Kilometers { get; set; }

        [JsonProperty("meters")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeMetersType Meters { get; set; }

        [JsonProperty("miles")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeMilesType Miles { get; set; }

        [JsonProperty("feet")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeFeetType Feet { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeKilometersType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeMetersType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeMilesType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemEstimatedDiameterTypeFeetType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItem
    {
        [JsonProperty("close_approach_date")]
        public string CloseApproachDate { get; set; }

        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public int EpochDateCloseApproach { get; set; }

        [JsonProperty("relative_velocity")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItemRelativeVelocityType RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItemMissDistanceType MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItemRelativeVelocityType
    {
        [JsonProperty("kilometers_per_second")]
        public string KilometersPerSecond { get; set; }

        [JsonProperty("kilometers_per_hour")]
        public string KilometersPerHour { get; set; }

        [JsonProperty("miles_per_hour")]
        public string MilesPerHour { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemCloseApproachDataTypeItemMissDistanceType
    {
        [JsonProperty("astronomical")]
        public string Astronomical { get; set; }

        [JsonProperty("lunar")]
        public string Lunar { get; set; }

        [JsonProperty("kilometers")]
        public string Kilometers { get; set; }

        [JsonProperty("miles")]
        public string Miles { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemOrbitalDataType
    {
        [JsonProperty("orbit_id")]
        public string OrbitId { get; set; }

        [JsonProperty("orbit_determination_date")]
        public string OrbitDeterminationDate { get; set; }

        [JsonProperty("first_observation_date")]
        public string FirstObservationDate { get; set; }

        [JsonProperty("last_observation_date")]
        public string LastObservationDate { get; set; }

        [JsonProperty("data_arc_in_days")]
        public int DataArcInDays { get; set; }

        [JsonProperty("observations_used")]
        public int ObservationsUsed { get; set; }

        [JsonProperty("orbit_uncertainty")]
        public string OrbitUncertainty { get; set; }

        [JsonProperty("minimum_orbit_intersection")]
        public string MinimumOrbitIntersection { get; set; }

        [JsonProperty("jupiter_tisserand_invariant")]
        public string JupiterTisserandInvariant { get; set; }

        [JsonProperty("epoch_osculation")]
        public string EpochOsculation { get; set; }

        [JsonProperty("eccentricity")]
        public string Eccentricity { get; set; }

        [JsonProperty("semi_major_axis")]
        public string SemiMajorAxis { get; set; }

        [JsonProperty("inclination")]
        public string Inclination { get; set; }

        [JsonProperty("ascending_node_longitude")]
        public string AscendingNodeLongitude { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("perihelion_distance")]
        public string PerihelionDistance { get; set; }

        [JsonProperty("perihelion_argument")]
        public string PerihelionArgument { get; set; }

        [JsonProperty("aphelion_distance")]
        public string AphelionDistance { get; set; }

        [JsonProperty("perihelion_time")]
        public string PerihelionTime { get; set; }

        [JsonProperty("mean_anomaly")]
        public string MeanAnomaly { get; set; }

        [JsonProperty("mean_motion")]
        public string MeanMotion { get; set; }

        [JsonProperty("equinox")]
        public string Equinox { get; set; }

        [JsonProperty("orbit_class")]
        public FeedTodayResponseNearEarthObjectsTypeDateTypeItemOrbitalDataTypeOrbitClassType OrbitClass { get; set; }
    }

    public class FeedTodayResponseNearEarthObjectsTypeDateTypeItemOrbitalDataTypeOrbitClassType
    {
        [JsonProperty("orbit_class_type")]
        public string OrbitClassType { get; set; }

        [JsonProperty("orbit_class_description")]
        public string OrbitClassDescription { get; set; }

        [JsonProperty("orbit_class_range")]
        public string OrbitClassRange { get; set; }
    }

    public class NeoResponse
    {
        [JsonProperty("links")]
        public NeoResponseLinksType Links { get; set; }

        [JsonProperty("page")]
        public NeoResponsePageType Page { get; set; }

        [JsonProperty("near_earth_objects")]
        public NeoResponseNearEarthObjectsTypeItem[] NearEarthObjects { get; set; }
    }

    public class NeoResponseLinksType
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class NeoResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItem
    {
        [JsonProperty("links")]
        public NeoResponseNearEarthObjectsTypeItemLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("neo_reference_id")]
        public string NeoReferenceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_limited")]
        public string NameLimited { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double AbsoluteMagnitudeH { get; set; }

        [JsonProperty("estimated_diameter")]
        public NeoResponseNearEarthObjectsTypeItemEstimatedDiameterType EstimatedDiameter { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }

        [JsonProperty("close_approach_data")]
        public NeoResponseNearEarthObjectsTypeItemCloseApproachDataTypeItem[] CloseApproachData { get; set; }

        [JsonProperty("orbital_data")]
        public NeoResponseNearEarthObjectsTypeItemOrbitalDataType OrbitalData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemEstimatedDiameterType
    {
        [JsonProperty("kilometers")]
        public NeoResponseNearEarthObjectsTypeItemEstimatedDiameterTypeKilometersType Kilometers { get; set; }

        [JsonProperty("meters")]
        public NeoResponseNearEarthObjectsTypeItemEstimatedDiameterTypeMetersType Meters { get; set; }

        [JsonProperty("miles")]
        public NeoResponseNearEarthObjectsTypeItemEstimatedDiameterTypeMilesType Miles { get; set; }

        [JsonProperty("feet")]
        public NeoResponseNearEarthObjectsTypeItemEstimatedDiameterTypeFeetType Feet { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemEstimatedDiameterTypeKilometersType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemEstimatedDiameterTypeMetersType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemEstimatedDiameterTypeMilesType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemEstimatedDiameterTypeFeetType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemCloseApproachDataTypeItem
    {
        [JsonProperty("close_approach_date")]
        public string CloseApproachDate { get; set; }

        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public int EpochDateCloseApproach { get; set; }

        [JsonProperty("relative_velocity")]
        public NeoResponseNearEarthObjectsTypeItemCloseApproachDataTypeItemRelativeVelocityType RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public NeoResponseNearEarthObjectsTypeItemCloseApproachDataTypeItemMissDistanceType MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemCloseApproachDataTypeItemRelativeVelocityType
    {
        [JsonProperty("kilometers_per_second")]
        public string KilometersPerSecond { get; set; }

        [JsonProperty("kilometers_per_hour")]
        public string KilometersPerHour { get; set; }

        [JsonProperty("miles_per_hour")]
        public string MilesPerHour { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemCloseApproachDataTypeItemMissDistanceType
    {
        [JsonProperty("astronomical")]
        public string Astronomical { get; set; }

        [JsonProperty("lunar")]
        public string Lunar { get; set; }

        [JsonProperty("kilometers")]
        public string Kilometers { get; set; }

        [JsonProperty("miles")]
        public string Miles { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemOrbitalDataType
    {
        [JsonProperty("orbit_id")]
        public string OrbitId { get; set; }

        [JsonProperty("orbit_determination_date")]
        public string OrbitDeterminationDate { get; set; }

        [JsonProperty("first_observation_date")]
        public string FirstObservationDate { get; set; }

        [JsonProperty("last_observation_date")]
        public string LastObservationDate { get; set; }

        [JsonProperty("data_arc_in_days")]
        public int DataArcInDays { get; set; }

        [JsonProperty("observations_used")]
        public int ObservationsUsed { get; set; }

        [JsonProperty("orbit_uncertainty")]
        public string OrbitUncertainty { get; set; }

        [JsonProperty("minimum_orbit_intersection")]
        public string MinimumOrbitIntersection { get; set; }

        [JsonProperty("jupiter_tisserand_invariant")]
        public string JupiterTisserandInvariant { get; set; }

        [JsonProperty("epoch_osculation")]
        public string EpochOsculation { get; set; }

        [JsonProperty("eccentricity")]
        public string Eccentricity { get; set; }

        [JsonProperty("semi_major_axis")]
        public string SemiMajorAxis { get; set; }

        [JsonProperty("inclination")]
        public string Inclination { get; set; }

        [JsonProperty("ascending_node_longitude")]
        public string AscendingNodeLongitude { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("perihelion_distance")]
        public string PerihelionDistance { get; set; }

        [JsonProperty("perihelion_argument")]
        public string PerihelionArgument { get; set; }

        [JsonProperty("aphelion_distance")]
        public string AphelionDistance { get; set; }

        [JsonProperty("perihelion_time")]
        public string PerihelionTime { get; set; }

        [JsonProperty("mean_anomaly")]
        public string MeanAnomaly { get; set; }

        [JsonProperty("mean_motion")]
        public string MeanMotion { get; set; }

        [JsonProperty("equinox")]
        public string Equinox { get; set; }

        [JsonProperty("orbit_class")]
        public NeoResponseNearEarthObjectsTypeItemOrbitalDataTypeOrbitClassType OrbitClass { get; set; }
    }

    public class NeoResponseNearEarthObjectsTypeItemOrbitalDataTypeOrbitClassType
    {
        [JsonProperty("orbit_class_type")]
        public string OrbitClassType { get; set; }

        [JsonProperty("orbit_class_description")]
        public string OrbitClassDescription { get; set; }

        [JsonProperty("orbit_class_range")]
        public string OrbitClassRange { get; set; }
    }

    public class NeoIDResponse
    {
        [JsonProperty("links")]
        public NeoIDResponseLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("neo_reference_id")]
        public string NeoReferenceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_limited")]
        public string NameLimited { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double AbsoluteMagnitudeH { get; set; }

        [JsonProperty("estimated_diameter")]
        public NeoIDResponseEstimatedDiameterType EstimatedDiameter { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }

        [JsonProperty("close_approach_data")]
        public NeoIDResponseCloseApproachDataTypeItem[] CloseApproachData { get; set; }

        [JsonProperty("orbital_data")]
        public NeoIDResponseOrbitalDataType OrbitalData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }
    }

    public class NeoIDResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class NeoIDResponseEstimatedDiameterType
    {
        [JsonProperty("kilometers")]
        public NeoIDResponseEstimatedDiameterTypeKilometersType Kilometers { get; set; }

        [JsonProperty("meters")]
        public NeoIDResponseEstimatedDiameterTypeMetersType Meters { get; set; }

        [JsonProperty("miles")]
        public NeoIDResponseEstimatedDiameterTypeMilesType Miles { get; set; }

        [JsonProperty("feet")]
        public NeoIDResponseEstimatedDiameterTypeFeetType Feet { get; set; }
    }

    public class NeoIDResponseEstimatedDiameterTypeKilometersType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class NeoIDResponseEstimatedDiameterTypeMetersType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class NeoIDResponseEstimatedDiameterTypeMilesType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class NeoIDResponseEstimatedDiameterTypeFeetType
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public class NeoIDResponseCloseApproachDataTypeItem
    {
        [JsonProperty("close_approach_date")]
        public string CloseApproachDate { get; set; }

        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public int EpochDateCloseApproach { get; set; }

        [JsonProperty("relative_velocity")]
        public NeoIDResponseCloseApproachDataTypeItemRelativeVelocityType RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public NeoIDResponseCloseApproachDataTypeItemMissDistanceType MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }

    public class NeoIDResponseCloseApproachDataTypeItemRelativeVelocityType
    {
        [JsonProperty("kilometers_per_second")]
        public string KilometersPerSecond { get; set; }

        [JsonProperty("kilometers_per_hour")]
        public string KilometersPerHour { get; set; }

        [JsonProperty("miles_per_hour")]
        public string MilesPerHour { get; set; }
    }

    public class NeoIDResponseCloseApproachDataTypeItemMissDistanceType
    {
        [JsonProperty("astronomical")]
        public string Astronomical { get; set; }

        [JsonProperty("lunar")]
        public string Lunar { get; set; }

        [JsonProperty("kilometers")]
        public string Kilometers { get; set; }

        [JsonProperty("miles")]
        public string Miles { get; set; }
    }

    public class NeoIDResponseOrbitalDataType
    {
        [JsonProperty("orbit_id")]
        public string OrbitId { get; set; }

        [JsonProperty("orbit_determination_date")]
        public string OrbitDeterminationDate { get; set; }

        [JsonProperty("first_observation_date")]
        public string FirstObservationDate { get; set; }

        [JsonProperty("last_observation_date")]
        public string LastObservationDate { get; set; }

        [JsonProperty("data_arc_in_days")]
        public int DataArcInDays { get; set; }

        [JsonProperty("observations_used")]
        public int ObservationsUsed { get; set; }

        [JsonProperty("orbit_uncertainty")]
        public string OrbitUncertainty { get; set; }

        [JsonProperty("minimum_orbit_intersection")]
        public string MinimumOrbitIntersection { get; set; }

        [JsonProperty("jupiter_tisserand_invariant")]
        public string JupiterTisserandInvariant { get; set; }

        [JsonProperty("epoch_osculation")]
        public string EpochOsculation { get; set; }

        [JsonProperty("eccentricity")]
        public string Eccentricity { get; set; }

        [JsonProperty("semi_major_axis")]
        public string SemiMajorAxis { get; set; }

        [JsonProperty("inclination")]
        public string Inclination { get; set; }

        [JsonProperty("ascending_node_longitude")]
        public string AscendingNodeLongitude { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("perihelion_distance")]
        public string PerihelionDistance { get; set; }

        [JsonProperty("perihelion_argument")]
        public string PerihelionArgument { get; set; }

        [JsonProperty("aphelion_distance")]
        public string AphelionDistance { get; set; }

        [JsonProperty("perihelion_time")]
        public string PerihelionTime { get; set; }

        [JsonProperty("mean_anomaly")]
        public string MeanAnomaly { get; set; }

        [JsonProperty("mean_motion")]
        public string MeanMotion { get; set; }

        [JsonProperty("equinox")]
        public string Equinox { get; set; }

        [JsonProperty("orbit_class")]
        public NeoIDResponseOrbitalDataTypeOrbitClassType OrbitClass { get; set; }
    }

    public class NeoIDResponseOrbitalDataTypeOrbitClassType
    {
        [JsonProperty("orbit_class_type")]
        public string OrbitClassType { get; set; }

        [JsonProperty("orbit_class_description")]
        public string OrbitClassDescription { get; set; }

        [JsonProperty("orbit_class_range")]
        public string OrbitClassRange { get; set; }
    }

    public class SentryResponse
    {
        [JsonProperty("links")]
        public SentryResponseLinksType Links { get; set; }

        [JsonProperty("page")]
        public SentryResponsePageType Page { get; set; }

        [JsonProperty("sentry_objects")]
        public SentryResponseSentryObjectsTypeItem[] SentryObjects { get; set; }
    }

    public class SentryResponseLinksType
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class SentryResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class SentryResponseSentryObjectsTypeItem
    {
        [JsonProperty("links")]
        public SentryResponseSentryObjectsTypeItemLinksType Links { get; set; }

        [JsonProperty("spkId")]
        public string SpkId { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("sentryId")]
        public string SentryId { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("year_range_min")]
        public string YearRangeMin { get; set; }

        [JsonProperty("year_range_max")]
        public string YearRangeMax { get; set; }

        [JsonProperty("potential_impacts")]
        public string PotentialImpacts { get; set; }

        [JsonProperty("impact_probability")]
        public string ImpactProbability { get; set; }

        [JsonProperty("v_infinity")]
        public string VInfinity { get; set; }

        [JsonProperty("absolute_magnitude")]
        public string AbsoluteMagnitude { get; set; }

        [JsonProperty("estimated_diameter")]
        public string EstimatedDiameter { get; set; }

        [JsonProperty("palermo_scale_ave")]
        public string PalermoScaleAve { get; set; }

        [JsonProperty("Palermo_scale_max")]
        public string PalermoScaleMax { get; set; }

        [JsonProperty("torino_scale")]
        public string TorinoScale { get; set; }

        [JsonProperty("last_obs")]
        public string LastObs { get; set; }

        [JsonProperty("last_obs_jd")]
        public string LastObsJd { get; set; }

        [JsonProperty("url_nasa_details")]
        public string UrlNasaDetails { get; set; }

        [JsonProperty("url_orbital_elements")]
        public string UrlOrbitalElements { get; set; }

        [JsonProperty("is_active_sentry_object")]
        public bool IsActiveSentryObject { get; set; }

        [JsonProperty("average_lunar_distance")]
        public double AverageLunarDistance { get; set; }
    }

    public class SentryResponseSentryObjectsTypeItemLinksType
    {
        [JsonProperty("near_earth_object_parent")]
        public string NearEarthObjectParent { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class SentryIDResponse
    {
        [JsonProperty("links")]
        public SentryIDResponseLinksType Links { get; set; }

        [JsonProperty("spkId")]
        public string SpkId { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("sentryId")]
        public string SentryId { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("year_range_min")]
        public string YearRangeMin { get; set; }

        [JsonProperty("year_range_max")]
        public string YearRangeMax { get; set; }

        [JsonProperty("potential_impacts")]
        public string PotentialImpacts { get; set; }

        [JsonProperty("impact_probability")]
        public string ImpactProbability { get; set; }

        [JsonProperty("v_infinity")]
        public string VInfinity { get; set; }

        [JsonProperty("absolute_magnitude")]
        public string AbsoluteMagnitude { get; set; }

        [JsonProperty("estimated_diameter")]
        public string EstimatedDiameter { get; set; }

        [JsonProperty("palermo_scale_ave")]
        public string PalermoScaleAve { get; set; }

        [JsonProperty("Palermo_scale_max")]
        public string PalermoScaleMax { get; set; }

        [JsonProperty("torino_scale")]
        public string TorinoScale { get; set; }

        [JsonProperty("last_obs")]
        public string LastObs { get; set; }

        [JsonProperty("last_obs_jd")]
        public string LastObsJd { get; set; }

        [JsonProperty("url_nasa_details")]
        public string UrlNasaDetails { get; set; }

        [JsonProperty("url_orbital_elements")]
        public string UrlOrbitalElements { get; set; }

        [JsonProperty("is_active_sentry_object")]
        public bool IsActiveSentryObject { get; set; }

        [JsonProperty("average_lunar_distance")]
        public double AverageLunarDistance { get; set; }
    }

    public class SentryIDResponseLinksType
    {
        [JsonProperty("near_earth_object_parent")]
        public string NearEarthObjectParent { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class StatsResponse
    {
        [JsonProperty("near_earth_object_count")]
        public int NearEarthObjectCount { get; set; }

        [JsonProperty("close_approach_count")]
        public int CloseApproachCount { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Nearearthobjectwebip;

    public partial class WorkflowManagedActions
    {
        public NearearthobjectwebipActions Nearearthobjectwebip(string connectionId) => new NearearthobjectwebipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NearearthobjectwebipTriggers Nearearthobjectwebip(string connectionId) => new NearearthobjectwebipTriggers(connectionId);
    }
}