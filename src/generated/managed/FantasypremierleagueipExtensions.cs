//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fantasypremierleagueip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FantasypremierleagueipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [WorkflowExpressionFactory(nameof(__BuildManagerUsersHistory))]
        public IBodyWorkflowAction<ManagerUsersHistoryResponse> ManagerUsersHistory([WorkflowExpression] Func<string> managerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ManagerUsersHistoryResponse> __BuildManagerUsersHistory(WorkflowExpression<string> managerId)
        {
            WorkflowExpression.Validate(managerId, nameof(managerId), required: true);
            return new DeferredBodyAction<ManagerUsersHistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/entry/{0}/history/", ExpressionConverter.ConvertWithUrlEncoding(managerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ManagerUsersHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [WorkflowExpressionFactory(nameof(__BuildManagerUsersBasicInformation))]
        public IBodyWorkflowAction<ManagerUsersBasicInformationResponse> ManagerUsersBasicInformation([WorkflowExpression] Func<string> managerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ManagerUsersBasicInformationResponse> __BuildManagerUsersBasicInformation(WorkflowExpression<string> managerId)
        {
            WorkflowExpression.Validate(managerId, nameof(managerId), required: true);
            return new DeferredBodyAction<ManagerUsersBasicInformationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/entry/{0}/", ExpressionConverter.ConvertWithUrlEncoding(managerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ManagerUsersBasicInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [WorkflowExpressionFactory(nameof(__BuildGameWeekLiveData))]
        public IBodyWorkflowAction<GameWeekLiveDataResponse> GameWeekLiveData([WorkflowExpression] Func<string> eventId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GameWeekLiveDataResponse> __BuildGameWeekLiveData(WorkflowExpression<string> eventId)
        {
            WorkflowExpression.Validate(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<GameWeekLiveDataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/event/{0}/live/", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GameWeekLiveDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [WorkflowExpressionFactory(nameof(__BuildPlayersDetailedData))]
        public IBodyWorkflowAction<PlayersDetailedDataResponse> PlayersDetailedData([WorkflowExpression] Func<string> elementId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PlayersDetailedDataResponse> __BuildPlayersDetailedData(WorkflowExpression<string> elementId)
        {
            WorkflowExpression.Validate(elementId, nameof(elementId), required: true);
            return new DeferredBodyAction<PlayersDetailedDataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/element-summary/{0}/", ExpressionConverter.ConvertWithUrlEncoding(elementId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PlayersDetailedDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        public IBodyWorkflowAction<CurrentYearFixturesResponseItem[]> CurrentYearFixtures()
        {
            var apiCallPath = "/api/fixtures/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CurrentYearFixturesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        public IBodyWorkflowAction<GeneralInformationResponse> GeneralInformation()
        {
            var apiCallPath = "/api/bootstrap-static/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GeneralInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [WorkflowExpressionFactory(nameof(__BuildClassicLeagueStandings))]
        public IBodyWorkflowAction<ClassicLeagueStandingsResponse> ClassicLeagueStandings([WorkflowExpression] Func<string> leagueId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fantasypremierleagueip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClassicLeagueStandingsResponse> __BuildClassicLeagueStandings(WorkflowExpression<string> leagueId)
        {
            WorkflowExpression.Validate(leagueId, nameof(leagueId), required: true);
            return new DeferredBodyAction<ClassicLeagueStandingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/leagues-classic/{0}/standings/", ExpressionConverter.ConvertWithUrlEncoding(leagueId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClassicLeagueStandingsResponse>(callPayload);
            });
        }
    }

    public class FantasypremierleagueipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ManagerUsersHistoryResponse
    {
        [JsonProperty("current")]
        public ManagerUsersHistoryResponseCurrentTypeItem[] Current { get; set; }

        [JsonProperty("past")]
        public ManagerUsersHistoryResponsePastTypeItem[] Past { get; set; }

        [JsonProperty("chips")]
        public JToken[] Chips { get; set; }
    }

    public class ManagerUsersHistoryResponseCurrentTypeItem
    {
        [JsonProperty("event")]
        public int Event { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("rank_sort")]
        public int RankSort { get; set; }

        [JsonProperty("overall_rank")]
        public int OverallRank { get; set; }

        [JsonProperty("bank")]
        public int Bank { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("event_transfers")]
        public int EventTransfers { get; set; }

        [JsonProperty("event_transfers_cost")]
        public int EventTransfersCost { get; set; }

        [JsonProperty("points_on_bench")]
        public int PointsOnBench { get; set; }
    }

    public class ManagerUsersHistoryResponsePastTypeItem
    {
        [JsonProperty("season_name")]
        public string SeasonName { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class ManagerUsersBasicInformationResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("joined_time")]
        public string JoinedTime { get; set; }

        [JsonProperty("started_event")]
        public int StartedEvent { get; set; }

        [JsonProperty("favourite_team")]
        public int FavouriteTeam { get; set; }

        [JsonProperty("player_first_name")]
        public string PlayerFirstName { get; set; }

        [JsonProperty("player_last_name")]
        public string PlayerLastName { get; set; }

        [JsonProperty("player_region_id")]
        public int PlayerRegionId { get; set; }

        [JsonProperty("player_region_name")]
        public string PlayerRegionName { get; set; }

        [JsonProperty("player_region_iso_code_short")]
        public string PlayerRegionIsoCodeShort { get; set; }

        [JsonProperty("player_region_iso_code_long")]
        public string PlayerRegionIsoCodeLong { get; set; }

        [JsonProperty("summary_overall_points")]
        public int SummaryOverallPoints { get; set; }

        [JsonProperty("summary_overall_rank")]
        public int SummaryOverallRank { get; set; }

        [JsonProperty("summary_event_points")]
        public int SummaryEventPoints { get; set; }

        [JsonProperty("summary_event_rank")]
        public string SummaryEventRank { get; set; }

        [JsonProperty("current_event")]
        public int CurrentEvent { get; set; }

        [JsonProperty("leagues")]
        public ManagerUsersBasicInformationResponseLeaguesType Leagues { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_change_blocked")]
        public bool NameChangeBlocked { get; set; }

        [JsonProperty("kit")]
        public string Kit { get; set; }

        [JsonProperty("last_deadline_bank")]
        public int LastDeadlineBank { get; set; }

        [JsonProperty("last_deadline_value")]
        public int LastDeadlineValue { get; set; }

        [JsonProperty("last_deadline_total_transfers")]
        public int LastDeadlineTotalTransfers { get; set; }
    }

    public class ManagerUsersBasicInformationResponseLeaguesType
    {
        [JsonProperty("classic")]
        public ManagerUsersBasicInformationResponseLeaguesTypeClassicTypeItem[] Classic { get; set; }

        [JsonProperty("h2h")]
        public ManagerUsersBasicInformationResponseLeaguesTypeH2hTypeItem[] H2h { get; set; }

        [JsonProperty("cup")]
        public ManagerUsersBasicInformationResponseLeaguesTypeCupType Cup { get; set; }

        [JsonProperty("cup_matches")]
        public JToken[] CupMatches { get; set; }
    }

    public class ManagerUsersBasicInformationResponseLeaguesTypeClassicTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("max_entries")]
        public string MaxEntries { get; set; }

        [JsonProperty("league_type")]
        public string LeagueType { get; set; }

        [JsonProperty("scoring")]
        public string Scoring { get; set; }

        [JsonProperty("admin_entry")]
        public JToken AdminEntry { get; set; }

        [JsonProperty("start_event")]
        public int StartEvent { get; set; }

        [JsonProperty("entry_can_leave")]
        public bool EntryCanLeave { get; set; }

        [JsonProperty("entry_can_admin")]
        public bool EntryCanAdmin { get; set; }

        [JsonProperty("entry_can_invite")]
        public bool EntryCanInvite { get; set; }

        [JsonProperty("has_cup")]
        public bool HasCup { get; set; }

        [JsonProperty("cup_league")]
        public string CupLeague { get; set; }

        [JsonProperty("cup_qualified")]
        public string CupQualified { get; set; }

        [JsonProperty("entry_rank")]
        public int EntryRank { get; set; }

        [JsonProperty("entry_last_rank")]
        public int EntryLastRank { get; set; }
    }

    public class ManagerUsersBasicInformationResponseLeaguesTypeH2hTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("max_entries")]
        public string MaxEntries { get; set; }

        [JsonProperty("league_type")]
        public string LeagueType { get; set; }

        [JsonProperty("scoring")]
        public string Scoring { get; set; }

        [JsonProperty("admin_entry")]
        public JToken AdminEntry { get; set; }

        [JsonProperty("start_event")]
        public int StartEvent { get; set; }

        [JsonProperty("entry_can_leave")]
        public bool EntryCanLeave { get; set; }

        [JsonProperty("entry_can_admin")]
        public bool EntryCanAdmin { get; set; }

        [JsonProperty("entry_can_invite")]
        public bool EntryCanInvite { get; set; }

        [JsonProperty("has_cup")]
        public bool HasCup { get; set; }

        [JsonProperty("cup_league")]
        public string CupLeague { get; set; }

        [JsonProperty("cup_qualified")]
        public string CupQualified { get; set; }

        [JsonProperty("entry_rank")]
        public int EntryRank { get; set; }

        [JsonProperty("entry_last_rank")]
        public int EntryLastRank { get; set; }
    }

    public class ManagerUsersBasicInformationResponseLeaguesTypeCupType
    {
        [JsonProperty("matches")]
        public JToken[] Matches { get; set; }

        [JsonProperty("status")]
        public ManagerUsersBasicInformationResponseLeaguesTypeCupTypeStatusType Status { get; set; }

        [JsonProperty("cup_league")]
        public string CupLeague { get; set; }
    }

    public class ManagerUsersBasicInformationResponseLeaguesTypeCupTypeStatusType
    {
        [JsonProperty("qualification_event")]
        public string QualificationEvent { get; set; }

        [JsonProperty("qualification_numbers")]
        public string QualificationNumbers { get; set; }

        [JsonProperty("qualification_rank")]
        public string QualificationRank { get; set; }

        [JsonProperty("qualification_state")]
        public string QualificationState { get; set; }
    }

    public class GameWeekLiveDataResponse
    {
        [JsonProperty("elements")]
        public GameWeekLiveDataResponseElementsTypeItem[] Elements { get; set; }
    }

    public class GameWeekLiveDataResponseElementsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stats")]
        public GameWeekLiveDataResponseElementsTypeItemStatsType Stats { get; set; }

        [JsonProperty("explain")]
        public GameWeekLiveDataResponseElementsTypeItemExplainTypeItem[] Explain { get; set; }
    }

    public class GameWeekLiveDataResponseElementsTypeItemStatsType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("clean_sheets")]
        public int CleanSheets { get; set; }

        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }

        [JsonProperty("own_goals")]
        public int OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public int PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public int PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public int YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public int RedCards { get; set; }

        [JsonProperty("saves")]
        public int Saves { get; set; }

        [JsonProperty("bonus")]
        public int Bonus { get; set; }

        [JsonProperty("bps")]
        public int Bps { get; set; }

        [JsonProperty("influence")]
        public string Influence { get; set; }

        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        [JsonProperty("threat")]
        public string Threat { get; set; }

        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("in_dreamteam")]
        public bool InDreamteam { get; set; }
    }

    public class GameWeekLiveDataResponseElementsTypeItemExplainTypeItem
    {
        [JsonProperty("fixture")]
        public int Fixture { get; set; }

        [JsonProperty("stats")]
        public GameWeekLiveDataResponseElementsTypeItemExplainTypeItemStatsTypeItem[] Stats { get; set; }
    }

    public class GameWeekLiveDataResponseElementsTypeItemExplainTypeItemStatsTypeItem
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PlayersDetailedDataResponse
    {
        [JsonProperty("fixtures")]
        public PlayersDetailedDataResponseFixturesTypeItem[] Fixtures { get; set; }

        [JsonProperty("history")]
        public PlayersDetailedDataResponseHistoryTypeItem[] History { get; set; }

        [JsonProperty("history_past")]
        public PlayersDetailedDataResponseHistoryPastTypeItem[] HistoryPast { get; set; }
    }

    public class PlayersDetailedDataResponseFixturesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("team_h")]
        public int TeamH { get; set; }

        [JsonProperty("team_h_score")]
        public JToken TeamHScore { get; set; }

        [JsonProperty("team_a")]
        public int TeamA { get; set; }

        [JsonProperty("team_a_score")]
        public JToken TeamAScore { get; set; }

        [JsonProperty("event")]
        public int Event { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("provisional_start_time")]
        public bool ProvisionalStartTime { get; set; }

        [JsonProperty("kickoff_time")]
        public string KickoffTime { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("is_home")]
        public bool IsHome { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }
    }

    public class PlayersDetailedDataResponseHistoryTypeItem
    {
        [JsonProperty("element")]
        public int Element { get; set; }

        [JsonProperty("fixture")]
        public int Fixture { get; set; }

        [JsonProperty("opponent_team")]
        public int OpponentTeam { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("was_home")]
        public bool WasHome { get; set; }

        [JsonProperty("kickoff_time")]
        public string KickoffTime { get; set; }

        [JsonProperty("team_h_score")]
        public JToken TeamHScore { get; set; }

        [JsonProperty("team_a_score")]
        public JToken TeamAScore { get; set; }

        [JsonProperty("round")]
        public int Round { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("clean_sheets")]
        public int CleanSheets { get; set; }

        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }

        [JsonProperty("own_goals")]
        public int OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public int PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public int PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public int YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public int RedCards { get; set; }

        [JsonProperty("saves")]
        public int Saves { get; set; }

        [JsonProperty("bonus")]
        public int Bonus { get; set; }

        [JsonProperty("bps")]
        public int Bps { get; set; }

        [JsonProperty("influence")]
        public string Influence { get; set; }

        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        [JsonProperty("threat")]
        public string Threat { get; set; }

        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("transfers_balance")]
        public int TransfersBalance { get; set; }

        [JsonProperty("selected")]
        public int Selected { get; set; }

        [JsonProperty("transfers_in")]
        public int TransfersIn { get; set; }

        [JsonProperty("transfers_out")]
        public int TransfersOut { get; set; }
    }

    public class PlayersDetailedDataResponseHistoryPastTypeItem
    {
        [JsonProperty("season_name")]
        public string SeasonName { get; set; }

        [JsonProperty("element_code")]
        public int ElementCode { get; set; }

        [JsonProperty("start_cost")]
        public int StartCost { get; set; }

        [JsonProperty("end_cost")]
        public int EndCost { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("clean_sheets")]
        public int CleanSheets { get; set; }

        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }

        [JsonProperty("own_goals")]
        public int OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public int PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public int PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public int YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public int RedCards { get; set; }

        [JsonProperty("saves")]
        public int Saves { get; set; }

        [JsonProperty("bonus")]
        public int Bonus { get; set; }

        [JsonProperty("bps")]
        public int Bps { get; set; }

        [JsonProperty("influence")]
        public string Influence { get; set; }

        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        [JsonProperty("threat")]
        public string Threat { get; set; }

        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }
    }

    public class CurrentYearFixturesResponseItem
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("event")]
        public int Event { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("finished_provisional")]
        public bool FinishedProvisional { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("kickoff_time")]
        public string KickoffTime { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("provisional_start_time")]
        public bool ProvisionalStartTime { get; set; }

        [JsonProperty("started")]
        public bool Started { get; set; }

        [JsonProperty("team_a")]
        public int TeamA { get; set; }

        [JsonProperty("team_a_score")]
        public JToken TeamAScore { get; set; }

        [JsonProperty("team_h")]
        public int TeamH { get; set; }

        [JsonProperty("team_h_score")]
        public JToken TeamHScore { get; set; }

        [JsonProperty("stats")]
        public CurrentYearFixturesResponseItemStatsTypeItem[] Stats { get; set; }

        [JsonProperty("team_h_difficulty")]
        public int TeamHDifficulty { get; set; }

        [JsonProperty("team_a_difficulty")]
        public int TeamADifficulty { get; set; }

        [JsonProperty("pulse_id")]
        public int PulseId { get; set; }
    }

    public class CurrentYearFixturesResponseItemStatsTypeItem
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("a")]
        public CurrentYearFixturesResponseItemStatsTypeItemATypeItem[] A { get; set; }

        [JsonProperty("h")]
        public CurrentYearFixturesResponseItemStatsTypeItemHTypeItem[] H { get; set; }
    }

    public class CurrentYearFixturesResponseItemStatsTypeItemATypeItem
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("element")]
        public int Element { get; set; }
    }

    public class CurrentYearFixturesResponseItemStatsTypeItemHTypeItem
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("element")]
        public int Element { get; set; }
    }

    public class GeneralInformationResponse
    {
        [JsonProperty("events")]
        public GeneralInformationResponseEventsTypeItem[] Events { get; set; }

        [JsonProperty("game_settings")]
        public GeneralInformationResponseGameSettingsType GameSettings { get; set; }

        [JsonProperty("phases")]
        public GeneralInformationResponsePhasesTypeItem[] Phases { get; set; }

        [JsonProperty("teams")]
        public GeneralInformationResponseTeamsTypeItem[] Teams { get; set; }

        [JsonProperty("total_players")]
        public int TotalPlayers { get; set; }

        [JsonProperty("elements")]
        public GeneralInformationResponseElementsTypeItem[] Elements { get; set; }

        [JsonProperty("element_stats")]
        public GeneralInformationResponseElementStatsTypeItem[] ElementStats { get; set; }

        [JsonProperty("element_types")]
        public GeneralInformationResponseElementTypesTypeItem[] ElementTypes { get; set; }
    }

    public class GeneralInformationResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deadline_time")]
        public string DeadlineTime { get; set; }

        [JsonProperty("average_entry_score")]
        public int AverageEntryScore { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("data_checked")]
        public bool DataChecked { get; set; }

        [JsonProperty("highest_scoring_entry")]
        public JToken HighestScoringEntry { get; set; }

        [JsonProperty("deadline_time_epoch")]
        public int DeadlineTimeEpoch { get; set; }

        [JsonProperty("deadline_time_game_offset")]
        public int DeadlineTimeGameOffset { get; set; }

        [JsonProperty("highest_score")]
        public JToken HighestScore { get; set; }

        [JsonProperty("is_previous")]
        public bool IsPrevious { get; set; }

        [JsonProperty("is_current")]
        public bool IsCurrent { get; set; }

        [JsonProperty("is_next")]
        public bool IsNext { get; set; }

        [JsonProperty("cup_leagues_created")]
        public bool CupLeaguesCreated { get; set; }

        [JsonProperty("h2h_ko_matches_created")]
        public bool H2hKoMatchesCreated { get; set; }

        [JsonProperty("chip_plays")]
        public GeneralInformationResponseEventsTypeItemChipPlaysTypeItem[] ChipPlays { get; set; }

        [JsonProperty("most_selected")]
        public string MostSelected { get; set; }

        [JsonProperty("most_transferred_in")]
        public string MostTransferredIn { get; set; }

        [JsonProperty("top_element")]
        public string TopElement { get; set; }

        [JsonProperty("top_element_info")]
        public string TopElementInfo { get; set; }

        [JsonProperty("transfers_made")]
        public int TransfersMade { get; set; }

        [JsonProperty("most_captained")]
        public string MostCaptained { get; set; }

        [JsonProperty("most_vice_captained")]
        public string MostViceCaptained { get; set; }
    }

    public class GeneralInformationResponseEventsTypeItemChipPlaysTypeItem
    {
        [JsonProperty("chip_name")]
        public string ChipName { get; set; }

        [JsonProperty("num_played")]
        public int NumPlayed { get; set; }
    }

    public class GeneralInformationResponseGameSettingsType
    {
        [JsonProperty("league_join_private_max")]
        public int LeagueJoinPrivateMax { get; set; }

        [JsonProperty("league_join_public_max")]
        public int LeagueJoinPublicMax { get; set; }

        [JsonProperty("league_max_size_public_classic")]
        public int LeagueMaxSizePublicClassic { get; set; }

        [JsonProperty("league_max_size_public_h2h")]
        public int LeagueMaxSizePublicH2h { get; set; }

        [JsonProperty("league_max_size_private_h2h")]
        public int LeagueMaxSizePrivateH2h { get; set; }

        [JsonProperty("league_max_ko_rounds_private_h2h")]
        public int LeagueMaxKoRoundsPrivateH2h { get; set; }

        [JsonProperty("league_prefix_public")]
        public string LeaguePrefixPublic { get; set; }

        [JsonProperty("league_points_h2h_win")]
        public int LeaguePointsH2hWin { get; set; }

        [JsonProperty("league_points_h2h_lose")]
        public int LeaguePointsH2hLose { get; set; }

        [JsonProperty("league_points_h2h_draw")]
        public int LeaguePointsH2hDraw { get; set; }

        [JsonProperty("league_ko_first_instead_of_random")]
        public bool LeagueKoFirstInsteadOfRandom { get; set; }

        [JsonProperty("cup_start_event_id")]
        public string CupStartEventId { get; set; }

        [JsonProperty("cup_stop_event_id")]
        public string CupStopEventId { get; set; }

        [JsonProperty("cup_qualifying_method")]
        public string CupQualifyingMethod { get; set; }

        [JsonProperty("cup_type")]
        public string CupType { get; set; }

        [JsonProperty("squad_squadplay")]
        public int SquadSquadplay { get; set; }

        [JsonProperty("squad_squadsize")]
        public int SquadSquadsize { get; set; }

        [JsonProperty("squad_team_limit")]
        public int SquadTeamLimit { get; set; }

        [JsonProperty("squad_total_spend")]
        public int SquadTotalSpend { get; set; }

        [JsonProperty("ui_currency_multiplier")]
        public int UiCurrencyMultiplier { get; set; }

        [JsonProperty("ui_use_special_shirts")]
        public bool UiUseSpecialShirts { get; set; }

        [JsonProperty("ui_special_shirt_exclusions")]
        public JToken[] UiSpecialShirtExclusions { get; set; }

        [JsonProperty("stats_form_days")]
        public int StatsFormDays { get; set; }

        [JsonProperty("sys_vice_captain_enabled")]
        public bool SysViceCaptainEnabled { get; set; }

        [JsonProperty("transfers_cap")]
        public int TransfersCap { get; set; }

        [JsonProperty("transfers_sell_on_fee")]
        public double TransfersSellOnFee { get; set; }

        [JsonProperty("league_h2h_tiebreak_stats")]
        public string[] LeagueH2hTiebreakStats { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class GeneralInformationResponsePhasesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_event")]
        public int StartEvent { get; set; }

        [JsonProperty("stop_event")]
        public int StopEvent { get; set; }
    }

    public class GeneralInformationResponseTeamsTypeItem
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("draw")]
        public int Draw { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("loss")]
        public int Loss { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("played")]
        public int Played { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("team_division")]
        public string TeamDivision { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        [JsonProperty("win")]
        public int Win { get; set; }

        [JsonProperty("strength_overall_home")]
        public int StrengthOverallHome { get; set; }

        [JsonProperty("strength_overall_away")]
        public int StrengthOverallAway { get; set; }

        [JsonProperty("strength_attack_home")]
        public int StrengthAttackHome { get; set; }

        [JsonProperty("strength_attack_away")]
        public int StrengthAttackAway { get; set; }

        [JsonProperty("strength_defence_home")]
        public int StrengthDefenceHome { get; set; }

        [JsonProperty("strength_defence_away")]
        public int StrengthDefenceAway { get; set; }

        [JsonProperty("pulse_id")]
        public int PulseId { get; set; }
    }

    public class GeneralInformationResponseElementsTypeItem
    {
        [JsonProperty("chance_of_playing_next_round")]
        public string ChanceOfPlayingNextRound { get; set; }

        [JsonProperty("chance_of_playing_this_round")]
        public string ChanceOfPlayingThisRound { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("cost_change_event")]
        public int CostChangeEvent { get; set; }

        [JsonProperty("cost_change_event_fall")]
        public int CostChangeEventFall { get; set; }

        [JsonProperty("cost_change_start")]
        public int CostChangeStart { get; set; }

        [JsonProperty("cost_change_start_fall")]
        public int CostChangeStartFall { get; set; }

        [JsonProperty("dreamteam_count")]
        public int DreamteamCount { get; set; }

        [JsonProperty("element_type")]
        public int ElementType { get; set; }

        [JsonProperty("ep_next")]
        public string EpNext { get; set; }

        [JsonProperty("ep_this")]
        public string EpThis { get; set; }

        [JsonProperty("event_points")]
        public int EventPoints { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("in_dreamteam")]
        public bool InDreamteam { get; set; }

        [JsonProperty("news")]
        public string News { get; set; }

        [JsonProperty("news_added")]
        public string NewsAdded { get; set; }

        [JsonProperty("now_cost")]
        public int NowCost { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("points_per_game")]
        public string PointsPerGame { get; set; }

        [JsonProperty("second_name")]
        public string SecondName { get; set; }

        [JsonProperty("selected_by_percent")]
        public string SelectedByPercent { get; set; }

        [JsonProperty("special")]
        public bool Special { get; set; }

        [JsonProperty("squad_number")]
        public string SquadNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("team")]
        public int Team { get; set; }

        [JsonProperty("team_code")]
        public int TeamCode { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("transfers_in")]
        public int TransfersIn { get; set; }

        [JsonProperty("transfers_in_event")]
        public int TransfersInEvent { get; set; }

        [JsonProperty("transfers_out")]
        public int TransfersOut { get; set; }

        [JsonProperty("transfers_out_event")]
        public int TransfersOutEvent { get; set; }

        [JsonProperty("value_form")]
        public string ValueForm { get; set; }

        [JsonProperty("value_season")]
        public string ValueSeason { get; set; }

        [JsonProperty("web_name")]
        public string WebName { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("clean_sheets")]
        public int CleanSheets { get; set; }

        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }

        [JsonProperty("own_goals")]
        public int OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public int PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public int PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public int YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public int RedCards { get; set; }

        [JsonProperty("saves")]
        public int Saves { get; set; }

        [JsonProperty("bonus")]
        public int Bonus { get; set; }

        [JsonProperty("bps")]
        public int Bps { get; set; }

        [JsonProperty("influence")]
        public string Influence { get; set; }

        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        [JsonProperty("threat")]
        public string Threat { get; set; }

        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        [JsonProperty("influence_rank")]
        public int InfluenceRank { get; set; }

        [JsonProperty("influence_rank_type")]
        public int InfluenceRankType { get; set; }

        [JsonProperty("creativity_rank")]
        public int CreativityRank { get; set; }

        [JsonProperty("creativity_rank_type")]
        public int CreativityRankType { get; set; }

        [JsonProperty("threat_rank")]
        public int ThreatRank { get; set; }

        [JsonProperty("threat_rank_type")]
        public int ThreatRankType { get; set; }

        [JsonProperty("ict_index_rank")]
        public int IctIndexRank { get; set; }

        [JsonProperty("ict_index_rank_type")]
        public int IctIndexRankType { get; set; }

        [JsonProperty("corners_and_indirect_freekicks_order")]
        public int CornersAndIndirectFreekicksOrder { get; set; }

        [JsonProperty("corners_and_indirect_freekicks_text")]
        public string CornersAndIndirectFreekicksText { get; set; }

        [JsonProperty("direct_freekicks_order")]
        public string DirectFreekicksOrder { get; set; }

        [JsonProperty("direct_freekicks_text")]
        public string DirectFreekicksText { get; set; }

        [JsonProperty("penalties_order")]
        public string PenaltiesOrder { get; set; }

        [JsonProperty("penalties_text")]
        public string PenaltiesText { get; set; }
    }

    public class GeneralInformationResponseElementStatsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GeneralInformationResponseElementTypesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("plural_name")]
        public string PluralName { get; set; }

        [JsonProperty("plural_name_short")]
        public string PluralNameShort { get; set; }

        [JsonProperty("singular_name")]
        public string SingularName { get; set; }

        [JsonProperty("singular_name_short")]
        public string SingularNameShort { get; set; }

        [JsonProperty("squad_select")]
        public int SquadSelect { get; set; }

        [JsonProperty("squad_min_play")]
        public int SquadMinPlay { get; set; }

        [JsonProperty("squad_max_play")]
        public int SquadMaxPlay { get; set; }

        [JsonProperty("ui_shirt_specific")]
        public bool UiShirtSpecific { get; set; }

        [JsonProperty("sub_positions_locked")]
        public int[] SubPositionsLocked { get; set; }

        [JsonProperty("element_count")]
        public int ElementCount { get; set; }
    }

    public class ClassicLeagueStandingsResponse
    {
        [JsonProperty("new_entries")]
        public ClassicLeagueStandingsResponseNewEntriesType NewEntries { get; set; }

        [JsonProperty("last_updated_data")]
        public string LastUpdatedData { get; set; }

        [JsonProperty("league")]
        public ClassicLeagueStandingsResponseLeagueType League { get; set; }

        [JsonProperty("standings")]
        public ClassicLeagueStandingsResponseStandingsType Standings { get; set; }
    }

    public class ClassicLeagueStandingsResponseNewEntriesType
    {
        [JsonProperty("has_next")]
        public bool HasNext { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("results")]
        public JToken[] Results { get; set; }
    }

    public class ClassicLeagueStandingsResponseLeagueType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("max_entries")]
        public string MaxEntries { get; set; }

        [JsonProperty("league_type")]
        public string LeagueType { get; set; }

        [JsonProperty("scoring")]
        public string Scoring { get; set; }

        [JsonProperty("admin_entry")]
        public JToken AdminEntry { get; set; }

        [JsonProperty("start_event")]
        public int StartEvent { get; set; }

        [JsonProperty("code_privacy")]
        public string CodePrivacy { get; set; }

        [JsonProperty("has_cup")]
        public bool HasCup { get; set; }

        [JsonProperty("cup_league")]
        public string CupLeague { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }
    }

    public class ClassicLeagueStandingsResponseStandingsType
    {
        [JsonProperty("has_next")]
        public bool HasNext { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("results")]
        public ClassicLeagueStandingsResponseStandingsTypeResultsTypeItem[] Results { get; set; }
    }

    public class ClassicLeagueStandingsResponseStandingsTypeResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("event_total")]
        public int EventTotal { get; set; }

        [JsonProperty("player_name")]
        public string PlayerName { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("last_rank")]
        public int LastRank { get; set; }

        [JsonProperty("rank_sort")]
        public int RankSort { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("entry")]
        public int Entry { get; set; }

        [JsonProperty("entry_name")]
        public string EntryName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fantasypremierleagueip;

    public partial class WorkflowManagedActions
    {
        public FantasypremierleagueipActions Fantasypremierleagueip(string connectionId) => new FantasypremierleagueipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FantasypremierleagueipTriggers Fantasypremierleagueip(string connectionId) => new FantasypremierleagueipTriggers(connectionId);
    }
}