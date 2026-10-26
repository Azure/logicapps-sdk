//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stravaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StravaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<GetAthleteStatsResponse, ApiConnectionActionConfiguration> GetAthleteStats(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetAthleteStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/athletes/{0}/stats", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAthleteStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<GetAuthenticatedAthleteResponse, ApiConnectionActionConfiguration> GetAuthenticatedAthlete()
        {
            return new DeferredBodyAction<GetAuthenticatedAthleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/athlete";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAuthenticatedAthleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<SummaryActivity[], ApiConnectionActionConfiguration> ListAthleteActivities(Expression<Func<string>> before = null, Expression<Func<string>> after = null, Expression<Func<string>> page = null, Expression<Func<string>> perPage = null)
        {
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SummaryActivity[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/athlete/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                callPayload.Queries["page"] = Convert.ToString("1");
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString("30");
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SummaryActivity[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<Club[], ApiConnectionActionConfiguration> ListAthleteClubs(Expression<Func<string>> page = null, Expression<Func<string>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<Club[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/athlete/clubs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString("30");
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<Club[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<DetailedSegment, ApiConnectionActionConfiguration> GetSegment(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DetailedSegment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/segments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DetailedSegment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<SummarySegment[], ApiConnectionActionConfiguration> ListStarredSegments(Expression<Func<string>> page = null, Expression<Func<string>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SummarySegment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/segments/starred";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString("30");
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SummarySegment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<DetailedActivity, ApiConnectionActionConfiguration> GetActivity(Expression<Func<int>> id, Expression<Func<string>> includeAllEfforts = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_includeAllEfforts = WorkflowExpression.Compile(includeAllEfforts, nameof(includeAllEfforts), required: false);
            return new DeferredBodyAction<DetailedActivity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/activities/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeAllEfforts != null)
                    callPayload.Queries["include_all_efforts"] = ExpressionConverter.Convert(__workflow_includeAllEfforts);
                return new ApiConnectionAction<DetailedActivity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<Lap[], ApiConnectionActionConfiguration> ListActivityLaps(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Lap[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/activities/{0}/laps", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Lap[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<ListActivityCommentsResponseItem[], ApiConnectionActionConfiguration> ListActivityComments(Expression<Func<int>> id, Expression<Func<string>> page = null, Expression<Func<string>> perPage = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ListActivityCommentsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/activities/{0}/comments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString("30");
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<ListActivityCommentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<SummaryAthlete[], ApiConnectionActionConfiguration> ListActivityKudoers(Expression<Func<int>> id, Expression<Func<string>> page = null, Expression<Func<string>> perPage = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SummaryAthlete[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/activities/{0}/kudos", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString("30");
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SummaryAthlete[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<Club, ApiConnectionActionConfiguration> GetClub(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Club, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clubs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Club>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<ListClubMembersResponseItem[], ApiConnectionActionConfiguration> ListClubMembers(Expression<Func<int>> id, Expression<Func<string>> page = null, Expression<Func<string>> perPage = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ListClubMembersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clubs/{0}/members", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString("30");
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<ListClubMembersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<SummaryAthlete[], ApiConnectionActionConfiguration> ListClubAdministrators(Expression<Func<int>> id, Expression<Func<string>> page = null, Expression<Func<string>> perPage = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SummaryAthlete[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clubs/{0}/admins", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString("30");
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SummaryAthlete[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stravaip")]
        public IBodyWorkflowAction<SummaryActivity[], ApiConnectionActionConfiguration> ListClubActivities(Expression<Func<int>> id, Expression<Func<string>> page = null, Expression<Func<string>> perPage = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SummaryActivity[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clubs/{0}/activities", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString("30");
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SummaryActivity[]>(callPayload);
            });
        }
    }

    public class StravaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAthleteStatsResponse
    {
        [JsonProperty("biggest_ride_distance")]
        public double BiggestRideDistance { get; set; }

        [JsonProperty("biggest_climb_elevation_gain")]
        public double BiggestClimbElevationGain { get; set; }

        [JsonProperty("recent_ride_totals")]
        public ActivityTotal RecentRideTotals { get; set; }

        [JsonProperty("all_ride_totals")]
        public ActivityTotalShort AllRideTotals { get; set; }

        [JsonProperty("recent_run_totals")]
        public ActivityTotal RecentRunTotals { get; set; }

        [JsonProperty("all_run_totals")]
        public ActivityTotalShort AllRunTotals { get; set; }

        [JsonProperty("recent_swim_totals")]
        public ActivityTotal RecentSwimTotals { get; set; }

        [JsonProperty("all_swim_totals")]
        public ActivityTotalShort AllSwimTotals { get; set; }

        [JsonProperty("ytd_ride_totals")]
        public ActivityTotalShort YtdRideTotals { get; set; }

        [JsonProperty("ytd_run_totals")]
        public ActivityTotalShort YtdRunTotals { get; set; }

        [JsonProperty("ytd_swim_totals")]
        public ActivityTotalShort YtdSwimTotals { get; set; }
    }

    public class ActivityTotal
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonProperty("elevation_gain")]
        public double ElevationGain { get; set; }

        [JsonProperty("achievement_count")]
        public int AchievementCount { get; set; }
    }

    public class ActivityTotalShort
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonProperty("elevation_gain")]
        public double ElevationGain { get; set; }
    }

    public class GetAuthenticatedAthleteResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("summit")]
        public bool Summit { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("profile_medium")]
        public string ProfileMedium { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("follower_count")]
        public int FollowerCount { get; set; }

        [JsonProperty("friend_count")]
        public int FriendCount { get; set; }

        [JsonProperty("measurement_preference")]
        public string MeasurementPreference { get; set; }

        [JsonProperty("clubs")]
        public JToken[] Clubs { get; set; }

        [JsonProperty("ftp")]
        public string Ftp { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("bikes")]
        public Bikes[] Bikes { get; set; }

        [JsonProperty("shoes")]
        public Shoes[] Shoes { get; set; }
    }

    public class Bikes
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public class Shoes
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public class SummaryActivity
    {
        [JsonProperty("athlete")]
        public SummaryActivityAthleteType Athlete { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonProperty("total_elevation_gain")]
        public double TotalElevationGain { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workout_type")]
        public int WorkoutType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("upload_id")]
        public int UploadId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_date_local")]
        public string StartDateLocal { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start_latlng")]
        public double[] StartLatlng { get; set; }

        [JsonProperty("end_latlng")]
        public double[] EndLatlng { get; set; }

        [JsonProperty("location_city")]
        public string LocationCity { get; set; }

        [JsonProperty("location_state")]
        public string LocationState { get; set; }

        [JsonProperty("location_country")]
        public string LocationCountry { get; set; }

        [JsonProperty("achievement_count")]
        public int AchievementCount { get; set; }

        [JsonProperty("kudos_count")]
        public int KudosCount { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("athlete_count")]
        public int AthleteCount { get; set; }

        [JsonProperty("photo_count")]
        public int PhotoCount { get; set; }

        [JsonProperty("map")]
        public SummaryActivityMapType Map { get; set; }

        [JsonProperty("trainer")]
        public bool Trainer { get; set; }

        [JsonProperty("commute")]
        public bool Commute { get; set; }

        [JsonProperty("manual")]
        public bool Manual { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("flagged")]
        public bool Flagged { get; set; }

        [JsonProperty("gear_id")]
        public string GearId { get; set; }

        [JsonProperty("average_speed")]
        public double AverageSpeed { get; set; }

        [JsonProperty("max_speed")]
        public double MaxSpeed { get; set; }

        [JsonProperty("average_cadence")]
        public double AverageCadence { get; set; }

        [JsonProperty("average_watts")]
        public double AverageWatts { get; set; }

        [JsonProperty("weighted_average_watts")]
        public int WeightedAverageWatts { get; set; }

        [JsonProperty("kilojoules")]
        public double Kilojoules { get; set; }

        [JsonProperty("device_watts")]
        public bool DeviceWatts { get; set; }

        [JsonProperty("has_heartrate")]
        public bool HasHeartrate { get; set; }

        [JsonProperty("average_heartrate")]
        public double AverageHeartrate { get; set; }

        [JsonProperty("max_heartrate")]
        public double MaxHeartrate { get; set; }

        [JsonProperty("max_watts")]
        public int MaxWatts { get; set; }

        [JsonProperty("total_photo_count")]
        public int TotalPhotoCount { get; set; }

        [JsonProperty("has_kudoed")]
        public bool HasKudoed { get; set; }

        [JsonProperty("suffer_score")]
        public int SufferScore { get; set; }
    }

    public class SummaryActivityAthleteType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class SummaryActivityMapType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("summary_polyline")]
        public string SummaryPolyline { get; set; }

        [JsonProperty("polyline")]
        public string Polyline { get; set; }
    }

    public class Club
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_medium")]
        public string ProfileMedium { get; set; }

        [JsonProperty("cover_photo")]
        public string CoverPhoto { get; set; }

        [JsonProperty("cover_photo_small")]
        public string CoverPhotoSmall { get; set; }

        [JsonProperty("activity_types")]
        public string ActivityTypes { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("membership")]
        public string Membership { get; set; }

        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("following_count")]
        public int FollowingCount { get; set; }
    }

    public class DetailedSegment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("average_grade")]
        public double AverageGrade { get; set; }

        [JsonProperty("maximum_grade")]
        public double MaximumGrade { get; set; }

        [JsonProperty("elevation_high")]
        public double ElevationHigh { get; set; }

        [JsonProperty("elevation_low")]
        public double ElevationLow { get; set; }

        [JsonProperty("start_latlng")]
        public double[] StartLatlng { get; set; }

        [JsonProperty("end_latlng")]
        public double[] EndLatlng { get; set; }

        [JsonProperty("climb_category")]
        public int ClimbCategory { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("hazardous")]
        public bool Hazardous { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("total_elevation_gain")]
        public double TotalElevationGain { get; set; }

        [JsonProperty("map")]
        public DetailedSegmentMapType Map { get; set; }

        [JsonProperty("effort_count")]
        public int EffortCount { get; set; }

        [JsonProperty("athlete_count")]
        public int AthleteCount { get; set; }

        [JsonProperty("star_count")]
        public int StarCount { get; set; }

        [JsonProperty("athlete_segment_stats")]
        public DetailedSegmentAthleteSegmentStatsType AthleteSegmentStats { get; set; }
    }

    public class DetailedSegmentMapType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("polyline")]
        public string Polyline { get; set; }

        [JsonProperty("summary_polyline")]
        public string SummaryPolyline { get; set; }
    }

    public class DetailedSegmentAthleteSegmentStatsType
    {
        [JsonProperty("pr_activity_id")]
        public int PrActivityId { get; set; }

        [JsonProperty("pr_elapsed_time")]
        public int PrElapsedTime { get; set; }

        [JsonProperty("pr_date")]
        public string PrDate { get; set; }

        [JsonProperty("effort_count")]
        public int EffortCount { get; set; }
    }

    public class SummarySegment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("average_grade")]
        public double AverageGrade { get; set; }

        [JsonProperty("maximum_grade")]
        public double MaximumGrade { get; set; }

        [JsonProperty("elevation_high")]
        public double ElevationHigh { get; set; }

        [JsonProperty("elevation_low")]
        public double ElevationLow { get; set; }

        [JsonProperty("start_latlng")]
        public double[] StartLatlng { get; set; }

        [JsonProperty("end_latlng")]
        public double[] EndLatlng { get; set; }

        [JsonProperty("climb_category")]
        public int ClimbCategory { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }
    }

    public class DetailedActivity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("upload_id")]
        public int UploadId { get; set; }

        [JsonProperty("athlete")]
        public DetailedActivityAthleteType Athlete { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonProperty("total_elevation_gain")]
        public double TotalElevationGain { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_date_local")]
        public string StartDateLocal { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("utc_offset")]
        public double UtcOffset { get; set; }

        [JsonProperty("start_latlng")]
        public double[] StartLatlng { get; set; }

        [JsonProperty("end_latlng")]
        public double[] EndLatlng { get; set; }

        [JsonProperty("achievement_count")]
        public int AchievementCount { get; set; }

        [JsonProperty("kudos_count")]
        public int KudosCount { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("athlete_count")]
        public int AthleteCount { get; set; }

        [JsonProperty("photo_count")]
        public int PhotoCount { get; set; }

        [JsonProperty("map")]
        public DetailedActivityMapType Map { get; set; }

        [JsonProperty("trainer")]
        public bool Trainer { get; set; }

        [JsonProperty("commute")]
        public bool Commute { get; set; }

        [JsonProperty("manual")]
        public bool Manual { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("flagged")]
        public bool Flagged { get; set; }

        [JsonProperty("gear_id")]
        public string GearId { get; set; }

        [JsonProperty("average_speed")]
        public double AverageSpeed { get; set; }

        [JsonProperty("max_speed")]
        public double MaxSpeed { get; set; }

        [JsonProperty("average_cadence")]
        public double AverageCadence { get; set; }

        [JsonProperty("average_temp")]
        public int AverageTemp { get; set; }

        [JsonProperty("average_watts")]
        public double AverageWatts { get; set; }

        [JsonProperty("weighted_average_watts")]
        public int WeightedAverageWatts { get; set; }

        [JsonProperty("kilojoules")]
        public double Kilojoules { get; set; }

        [JsonProperty("device_watts")]
        public bool DeviceWatts { get; set; }

        [JsonProperty("has_heartrate")]
        public bool HasHeartrate { get; set; }

        [JsonProperty("max_watts")]
        public int MaxWatts { get; set; }

        [JsonProperty("elev_high")]
        public double ElevHigh { get; set; }

        [JsonProperty("elev_low")]
        public double ElevLow { get; set; }

        [JsonProperty("total_photo_count")]
        public int TotalPhotoCount { get; set; }

        [JsonProperty("has_kudoed")]
        public bool HasKudoed { get; set; }

        [JsonProperty("workout_type")]
        public int WorkoutType { get; set; }

        [JsonProperty("suffer_score")]
        public string SufferScore { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("calories")]
        public double Calories { get; set; }

        [JsonProperty("segment_efforts")]
        public DetailedActivitySegmentEffortsTypeItem[] SegmentEfforts { get; set; }

        [JsonProperty("splits_metric")]
        public DetailedActivitySplitsMetricTypeItem[] SplitsMetric { get; set; }

        [JsonProperty("laps")]
        public Lap[] Laps { get; set; }

        [JsonProperty("gear")]
        public SummaryGear Gear { get; set; }

        [JsonProperty("photos")]
        public DetailedActivityPhotosType Photos { get; set; }

        [JsonProperty("highlighted_kudosers")]
        public DetailedActivityHighlightedKudosersTypeItem[] HighlightedKudosers { get; set; }

        [JsonProperty("device_name")]
        public string DeviceName { get; set; }

        [JsonProperty("embed_token")]
        public string EmbedToken { get; set; }
    }

    public class DetailedActivityAthleteType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class DetailedActivityMapType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("polyline")]
        public string Polyline { get; set; }

        [JsonProperty("summary_polyline")]
        public string SummaryPolyline { get; set; }
    }

    public class DetailedActivitySegmentEffortsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("activity")]
        public DetailedActivitySegmentEffortsTypeItemActivityType Activity { get; set; }

        [JsonProperty("athlete")]
        public DetailedActivitySegmentEffortsTypeItemAthleteType Athlete { get; set; }

        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_date_local")]
        public string StartDateLocal { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        [JsonProperty("end_index")]
        public int EndIndex { get; set; }

        [JsonProperty("average_cadence")]
        public double AverageCadence { get; set; }

        [JsonProperty("device_watts")]
        public bool DeviceWatts { get; set; }

        [JsonProperty("average_watts")]
        public double AverageWatts { get; set; }

        [JsonProperty("segment")]
        public SummarySegment Segment { get; set; }

        [JsonProperty("kom_rank")]
        public int KomRank { get; set; }

        [JsonProperty("pr_rank")]
        public int PrRank { get; set; }
    }

    public class DetailedActivitySegmentEffortsTypeItemActivityType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class DetailedActivitySegmentEffortsTypeItemAthleteType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class DetailedActivitySplitsMetricTypeItem
    {
        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonProperty("elevation_difference")]
        public double ElevationDifference { get; set; }

        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        [JsonProperty("split")]
        public int Split { get; set; }

        [JsonProperty("average_speed")]
        public double AverageSpeed { get; set; }

        [JsonProperty("pace_zone")]
        public int PaceZone { get; set; }
    }

    public class Lap
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("activity")]
        public LapActivityType Activity { get; set; }

        [JsonProperty("athlete")]
        public LapAthleteType Athlete { get; set; }

        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_date_local")]
        public string StartDateLocal { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        [JsonProperty("end_index")]
        public int EndIndex { get; set; }

        [JsonProperty("total_elevation_gain")]
        public double TotalElevationGain { get; set; }

        [JsonProperty("average_speed")]
        public double AverageSpeed { get; set; }

        [JsonProperty("max_speed")]
        public double MaxSpeed { get; set; }

        [JsonProperty("average_cadence")]
        public double AverageCadence { get; set; }

        [JsonProperty("lap_index")]
        public int LapIndex { get; set; }

        [JsonProperty("split")]
        public int Split { get; set; }
    }

    public class LapActivityType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class LapAthleteType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class SummaryGear
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public class DetailedActivityPhotosType
    {
        [JsonProperty("primary")]
        public DetailedActivityPhotosTypePrimaryType Primary { get; set; }

        [JsonProperty("use_primary_photo")]
        public bool UsePrimaryPhoto { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class DetailedActivityPhotosTypePrimaryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("urls")]
        public DetailedActivityPhotosTypePrimaryTypeUrlsType Urls { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }
    }

    public class DetailedActivityPhotosTypePrimaryTypeUrlsType
    {
        [JsonProperty("100")]
        public string _100 { get; set; }

        [JsonProperty("600")]
        public string _600 { get; set; }
    }

    public class DetailedActivityHighlightedKudosersTypeItem
    {
        [JsonProperty("destination_url")]
        public string DestinationUrl { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("show_name")]
        public bool ShowName { get; set; }
    }

    public class ListActivityCommentsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("activity_id")]
        public int ActivityId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("athlete")]
        public SummaryAthlete Athlete { get; set; }
    }

    public class SummaryAthlete
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }
    }

    public class ListClubMembersResponseItem
    {
        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("membership")]
        public string Membership { get; set; }

        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Stravaip;

    public partial class WorkflowManagedActions
    {
        public StravaipActions Stravaip(string connectionId) => new StravaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StravaipTriggers Stravaip(string connectionId) => new StravaipTriggers(connectionId);
    }
}