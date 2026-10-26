//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerbi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerbiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<ListedScorecards, ApiConnectionActionConfiguration> GetScorecards(Expression<Func<string>> groupid)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            return new DeferredBodyAction<ListedScorecards, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", __workflow_groupid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction<ListedScorecards>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreatedScorecard, ApiConnectionActionConfiguration> CreateScorecard(Expression<Func<string>> groupid, Expression<Func<CreateScorecardInput>> scorecard)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecard = WorkflowExpression.Compile(scorecard, nameof(scorecard), required: true);
            return new DeferredBodyAction<CreatedScorecard, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", __workflow_groupid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_scorecard);
                return new ApiConnectionAction<CreatedScorecard>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoals, ApiConnectionActionConfiguration> GetMultipleGoals(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            return new DeferredBodyAction<FetchedGoals, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("aggregations");
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction<FetchedGoals>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreateGoalResponse, ApiConnectionActionConfiguration> CreateGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<CreateGoalInput>> goal)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goal = WorkflowExpression.Compile(goal, nameof(goal), required: true);
            return new DeferredBodyAction<CreateGoalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_goal);
                return new ApiConnectionAction<CreateGoalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoal, ApiConnectionActionConfiguration> GetGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<FetchedGoal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("aggregations");
                return new ApiConnectionAction<FetchedGoal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<UpdateGoalInput>> goal)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_goal = WorkflowExpression.Compile(goal, nameof(goal), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_goal);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<QueryExecutionResults, ApiConnectionActionConfiguration> ExecuteDatasetQuery(Expression<Func<string>> groupid, Expression<Func<string>> datasetid, Expression<Func<ExecuteDatasetQueryInput>> specification)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_datasetid = WorkflowExpression.Compile(datasetid, nameof(datasetid), required: true);
            var __workflow_specification = WorkflowExpression.Compile(specification, nameof(specification), required: true);
            return new DeferredBodyAction<QueryExecutionResults, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", __workflow_groupid.WithUrlEncoding(1), __workflow_datasetid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_specification);
                return new ApiConnectionAction<QueryExecutionResults>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExecuteDatasetQueriesJson(Expression<Func<string>> groupid, Expression<Func<string>> datasetid, Expression<Func<object>> specification)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_datasetid = WorkflowExpression.Compile(datasetid, nameof(datasetid), required: true);
            var __workflow_specification = WorkflowExpression.Compile(specification, nameof(specification), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/internalFlowActionOverloadAsJson/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", __workflow_groupid.WithUrlEncoding(1), __workflow_datasetid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_specification);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddRows(Expression<Func<string>> groupid, Expression<Func<string>> datasetid, Expression<Func<string>> tablename, Expression<Func<object>> payload = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_datasetid = WorkflowExpression.Compile(datasetid, nameof(datasetid), required: true);
            var __workflow_tablename = WorkflowExpression.Compile(tablename, nameof(tablename), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/tables/{2}/rows", __workflow_groupid.WithUrlEncoding(1), __workflow_datasetid.WithUrlEncoding(1), __workflow_tablename.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                if (__workflow_payload != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GoalValueCheckinNote(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin, Expression<Func<string>> note)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_goalCheckin = WorkflowExpression.Compile(goalCheckin, nameof(goalCheckin), required: true);
            var __workflow_note = WorkflowExpression.Compile(note, nameof(note), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})/notes", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1), __workflow_goalCheckin.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_note);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GoalValueCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<GoalValueCheckinInput>> checkin)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_checkin = WorkflowExpression.Compile(checkin, nameof(checkin), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_checkin);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinsResponse, ApiConnectionActionConfiguration> GetGoalCheckins(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<GetGoalCheckinsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("notes");
                return new ApiConnectionAction<GetGoalCheckinsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateGoalCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin, Expression<Func<UpdateGoalCheckinInput>> checkin)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_goalCheckin = WorkflowExpression.Compile(goalCheckin, nameof(goalCheckin), required: true);
            var __workflow_checkin = WorkflowExpression.Compile(checkin, nameof(checkin), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1), __workflow_goalCheckin.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_checkin);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinResponse, ApiConnectionActionConfiguration> GetGoalCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_goalCheckin = WorkflowExpression.Compile(goalCheckin, nameof(goalCheckin), required: true);
            return new DeferredBodyAction<GetGoalCheckinResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1), __workflow_goalCheckin.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("notes");
                return new ApiConnectionAction<GetGoalCheckinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RefreshDataset(Expression<Func<string>> groupid, Expression<Func<string>> datasetid)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_datasetid = WorkflowExpression.Compile(datasetid, nameof(datasetid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/refreshes", __workflow_groupid.WithUrlEncoding(1), __workflow_datasetid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> InitiateExportToFileForPbiReports(Expression<Func<string>> groupid, Expression<Func<string>> reportid, Expression<Func<InitiateExportToFileForPbiReportsInput>> exportPayloadPowerBIReport = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_reportid = WorkflowExpression.Compile(reportid, nameof(reportid), required: true);
            var __workflow_exportPayloadPowerBIReport = WorkflowExpression.Compile(exportPayloadPowerBIReport, nameof(exportPayloadPowerBIReport), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportTo", __workflow_groupid.WithUrlEncoding(1), __workflow_reportid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_exportPayloadPowerBIReport != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReport);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> InitiateExportToFileForPaginatedReports(Expression<Func<string>> groupid, Expression<Func<string>> reportid, Expression<Func<InitiateExportToFileForPaginatedReportsInput>> exportPayloadPaginatedReport = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_reportid = WorkflowExpression.Compile(reportid, nameof(reportid), required: true);
            var __workflow_exportPayloadPaginatedReport = WorkflowExpression.Compile(exportPayloadPaginatedReport, nameof(exportPayloadPaginatedReport), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportToPaginatedReports", __workflow_groupid.WithUrlEncoding(1), __workflow_reportid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_exportPayloadPaginatedReport != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_exportPayloadPaginatedReport);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class PowerbiTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListedScorecards
    {
        [JsonProperty("value")]
        public ListedScorecard[] Scorecards { get; set; }
    }

    public class ListedScorecard
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }
    }

    public class CreatedScorecard
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateScorecardInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class FetchedGoals
    {
        [JsonProperty("value")]
        public FetchedGoal[] Goals { get; set; }
    }

    public class FetchedGoal
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("completionDate")]
        public string CompletionDate { get; set; }

        [JsonProperty("parentId")]
        public string ParentGoalId { get; set; }

        [JsonProperty("currentValue")]
        public double CurrentValue { get; set; }

        [JsonProperty("currentValueTimestamp")]
        public string CurrentValueTimestamp { get; set; }

        [JsonProperty("targetValue")]
        public double TargetValue { get; set; }

        [JsonProperty("targetValueTimestamp")]
        public string TargetValueTimestamp { get; set; }

        [JsonProperty("status")]
        public FetchedGoalStatusType Status { get; set; }

        [JsonProperty("statusTimestamp")]
        public string StatusTimestamp { get; set; }

        [JsonProperty("cycle")]
        public FetchedGoalFrequencyType Frequency { get; set; }

        [JsonProperty("cyclePeriod")]
        public string TrackingCycleDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FetchedGoalStatusType
    {
        [EnumMember(Value = "Not started")]
        NotStarted,
        [EnumMember(Value = "On track")]
        OnTrack,
        [EnumMember(Value = "At risk")]
        AtRisk,
        Behind,
        Overdue,
        Completed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FetchedGoalFrequencyType
    {
        [EnumMember(Value = "No cycle")]
        NoCycle,
        Daily,
        Weekly,
        Monthly,
        Quarterly,
        Yearly
    }

    public class CreateGoalResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateGoalInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("value")]
        public string CurrentValue { get; set; }

        [JsonProperty("target")]
        public string TargetValue { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGoalInputStatusType? Status { get; set; } = CreateGoalInputStatusType.NotStarted;

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("completionDate")]
        public string CompletionDate { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("parentId")]
        public string ParentGoalId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGoalInputStatusType
    {
        [EnumMember(Value = "Not started")]
        NotStarted,
        [EnumMember(Value = "On track")]
        OnTrack,
        [EnumMember(Value = "At risk")]
        AtRisk,
        Behind,
        Overdue,
        Completed
    }

    public class UpdateGoalInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("value")]
        public double? CurrentValue { get; set; }

        [JsonProperty("target")]
        public double? TargetValue { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateGoalInputStatusType? Status { get; set; } = UpdateGoalInputStatusType.LeaveUnchanged;

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("completionDate")]
        public string CompletionDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateGoalInputStatusType
    {
        [EnumMember(Value = "Leave unchanged")]
        LeaveUnchanged,
        [EnumMember(Value = "Not started")]
        NotStarted,
        [EnumMember(Value = "On track")]
        OnTrack,
        [EnumMember(Value = "At risk")]
        AtRisk,
        Behind,
        Overdue,
        Completed
    }

    public class QueryExecutionResults
    {
        [JsonProperty("firstTableRows")]
        public JToken[] FirstTableRows { get; set; }
    }

    public class ExecuteDatasetQueryInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string QueryText { get; set; }

        [JsonProperty("serializerSettings")]
        public ExecuteDatasetQueryInputSerializerSettingsType SerializerSettings { get; set; }

        [JsonProperty("impersonatedUserName")]
        public string ImpersonateUser { get; set; }
    }

    public class ExecuteDatasetQueryInputSerializerSettingsType
    {
        [JsonProperty("includeNulls", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NullsIncluded { get; set; } = false;
    }

    public class GoalValueCheckinInput
    {
        [JsonProperty("timestamp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public GoalValueCheckinInputStatusType? Status { get; set; } = GoalValueCheckinInputStatusType.LeaveUnchanged;

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GoalValueCheckinInputStatusType
    {
        [EnumMember(Value = "Leave unchanged")]
        LeaveUnchanged,
        [EnumMember(Value = "Not started")]
        NotStarted,
        [EnumMember(Value = "On track")]
        OnTrack,
        [EnumMember(Value = "At risk")]
        AtRisk,
        Behind,
        Overdue,
        Completed
    }

    public class GetGoalCheckinsResponse
    {
        [JsonProperty("value")]
        public GetGoalCheckinsResponseCheckInsTypeItem[] CheckIns { get; set; }
    }

    public class GetGoalCheckinsResponseCheckInsTypeItem
    {
        [JsonProperty("timestamp")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notes")]
        public GoalNotesItem[] Notes { get; set; }
    }

    public class GoalNotesItem
    {
        [JsonProperty("body")]
        public string Text { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }

    public class UpdateGoalCheckinInput
    {
        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateGoalCheckinInputStatusType? Status { get; set; } = UpdateGoalCheckinInputStatusType.LeaveUnchanged;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateGoalCheckinInputStatusType
    {
        [EnumMember(Value = "Leave unchanged")]
        LeaveUnchanged,
        [EnumMember(Value = "Not started")]
        NotStarted,
        [EnumMember(Value = "On track")]
        OnTrack,
        [EnumMember(Value = "At risk")]
        AtRisk,
        Behind,
        Overdue,
        Completed
    }

    public class GetGoalCheckinResponse
    {
        [JsonProperty("timestamp")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notes")]
        public GoalNotesItem[] Notes { get; set; }
    }

    public class InitiateExportToFileForPbiReportsInput
    {
        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InitiateExportToFileForPbiReportsInputFormatType Format { get; set; } = InitiateExportToFileForPbiReportsInputFormatType.PDF;
        public InitiateExportToFileForPbiReportsInputPowerBIReportExportConfigurationType PowerBIReportExportConfiguration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InitiateExportToFileForPbiReportsInputFormatType
    {
        PDF,
        PPTX,
        PNG
    }

    public class InitiateExportToFileForPbiReportsInputPowerBIReportExportConfigurationType
    {
        [JsonProperty("settings")]
        public ExportReportSettings Settings { get; set; }

        [JsonProperty("defaultBookmark")]
        public PageBookmark DefaultBookmark { get; set; }

        [JsonProperty("reportLevelFilters")]
        public ExportFilter[] ReportLevelFilters { get; set; }

        [JsonProperty("pages")]
        public ExportReportPage[] Pages { get; set; }

        [JsonProperty("identities")]
        public EffectiveIdentity[] Identities { get; set; }
    }

    public class ExportReportSettings
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("includeHiddenPages")]
        public bool IncludeHiddenPages { get; set; }
    }

    public class PageBookmark
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class ExportFilter
    {
        [JsonProperty("filter")]
        public string Filter { get; set; }
    }

    public class ExportReportPage
    {
        [JsonProperty("pageName")]
        public string PageName { get; set; }

        [JsonProperty("visualName")]
        public string VisualName { get; set; }

        [JsonProperty("bookmark")]
        public PageBookmark Bookmark { get; set; }
    }

    public class EffectiveIdentity
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("datasets")]
        public string[] Datasets { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("customData")]
        public string CustomData { get; set; }

        [JsonProperty("identityBlob")]
        public IdentityBlob IdentityBlob { get; set; }

        [JsonProperty("reports")]
        public string[] Reports { get; set; }
    }

    public class IdentityBlob
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class InitiateExportToFileForPaginatedReportsInput
    {
        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InitiateExportToFileForPaginatedReportsInputFormatType Format { get; set; } = InitiateExportToFileForPaginatedReportsInputFormatType.PDF;

        [JsonProperty("paginatedReportConfiguration")]
        public InitiateExportToFileForPaginatedReportsInputPaginatedReportConfigurationType PaginatedReportConfiguration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InitiateExportToFileForPaginatedReportsInputFormatType
    {
        PDF,
        CSV,
        DOCX,
        IMAGE,
        MHTML,
        PPTX,
        XLSX,
        XML,
        ACCESSIBLEPDF
    }

    public class InitiateExportToFileForPaginatedReportsInputPaginatedReportConfigurationType
    {
        [JsonProperty("identities")]
        public EffectiveIdentity[] Identities { get; set; }

        [JsonProperty("formatSettings")]
        public JToken FormatSettings { get; set; }

        [JsonProperty("parameterValues")]
        public InitiateExportToFileForPaginatedReportsInputPaginatedReportConfigurationTypeParameterValuesTypeItem[] ParameterValues { get; set; }
    }

    public class InitiateExportToFileForPaginatedReportsInputPaginatedReportConfigurationTypeParameterValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powerbi;

    public partial class WorkflowManagedActions
    {
        public PowerbiActions Powerbi(string connectionId) => new PowerbiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PowerbiTriggers Powerbi(string connectionId) => new PowerbiTriggers(connectionId);
    }
}