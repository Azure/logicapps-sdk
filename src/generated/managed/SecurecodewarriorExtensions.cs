//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Securecodewarrior
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecurecodewarriorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<DeveloperGetLeaderboardResponse, ApiConnectionActionConfiguration> DeveloperGetLeaderboard(Expression<Func<ReportPeriodInput>> reportPeriod = null, Expression<Func<int>> page = null, Expression<Func<string>> startdate = null, Expression<Func<string>> enddate = null)
        {
            var __workflow_reportPeriod = WorkflowExpression.Compile(reportPeriod, nameof(reportPeriod), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_startdate = WorkflowExpression.Compile(startdate, nameof(startdate), required: false);
            var __workflow_enddate = WorkflowExpression.Compile(enddate, nameof(enddate), required: false);
            return new DeferredBodyAction<DeveloperGetLeaderboardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/training/developer-leaderboard";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportPeriod != null)
                    callPayload.Queries["report_period"] = ExpressionConverter.Convert(__workflow_reportPeriod);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(__workflow_startdate);
                if (__workflow_enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(__workflow_enddate);
                return new ApiConnectionAction<DeveloperGetLeaderboardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<DevelopersProgress, ApiConnectionActionConfiguration> DeveloperGetProgress(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<DevelopersProgress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/training/developers-progress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<DevelopersProgress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<DevelopersActivity, ApiConnectionActionConfiguration> DeveloperGetActivity(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<DevelopersActivity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/training/developers-activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<DevelopersActivity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<DeveloperSearchLeaderboardResponse, ApiConnectionActionConfiguration> DeveloperSearchLeaderboard(Expression<Func<DeveloperLeaderboardSearchInput>> developerLeaderboardSearch)
        {
            var __workflow_developerLeaderboardSearch = WorkflowExpression.Compile(developerLeaderboardSearch, nameof(developerLeaderboardSearch), required: true);
            return new DeferredBodyAction<DeveloperSearchLeaderboardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/training/developer-leaderboard/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_developerLeaderboardSearch);
                return new ApiConnectionAction<DeveloperSearchLeaderboardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<DevelopersProgress, ApiConnectionActionConfiguration> DevelopersSearchProgress(Expression<Func<DeveloperProgressSearchInput>> developerProgressSearch)
        {
            var __workflow_developerProgressSearch = WorkflowExpression.Compile(developerProgressSearch, nameof(developerProgressSearch), required: true);
            return new DeferredBodyAction<DevelopersProgress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/training/developers-progress/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_developerProgressSearch);
                return new ApiConnectionAction<DevelopersProgress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<StrengthsAndWeaknesses, ApiConnectionActionConfiguration> ActivityGetStrengthsAndWeaknesses(Expression<Func<TargetTypeInput>> targetType = null, Expression<Func<string>> targetIdentifier = null, Expression<Func<string>> languageId = null, Expression<Func<string>> languageFramework = null, Expression<Func<int>> page = null)
        {
            var __workflow_targetType = WorkflowExpression.Compile(targetType, nameof(targetType), required: false);
            var __workflow_targetIdentifier = WorkflowExpression.Compile(targetIdentifier, nameof(targetIdentifier), required: false);
            var __workflow_languageId = WorkflowExpression.Compile(languageId, nameof(languageId), required: false);
            var __workflow_languageFramework = WorkflowExpression.Compile(languageFramework, nameof(languageFramework), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<StrengthsAndWeaknesses, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/metrics/activity/strengths-and-weaknesses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_targetType != null)
                    callPayload.Queries["targetType"] = ExpressionConverter.Convert(__workflow_targetType);
                if (__workflow_targetIdentifier != null)
                    callPayload.Queries["targetIdentifier"] = ExpressionConverter.Convert(__workflow_targetIdentifier);
                if (__workflow_languageId != null)
                    callPayload.Queries["languageId"] = ExpressionConverter.Convert(__workflow_languageId);
                if (__workflow_languageFramework != null)
                    callPayload.Queries["languageFramework"] = ExpressionConverter.Convert(__workflow_languageFramework);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<StrengthsAndWeaknesses>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<DevelopersActivity, ApiConnectionActionConfiguration> DeveloperSearchActivity(Expression<Func<DeveloperActivitySearchInput>> developerActivitySearch)
        {
            var __workflow_developerActivitySearch = WorkflowExpression.Compile(developerActivitySearch, nameof(developerActivitySearch), required: true);
            return new DeferredBodyAction<DevelopersActivity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/training/developers-activity/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_developerActivitySearch);
                return new ApiConnectionAction<DevelopersActivity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<MostEngagedTeams, ApiConnectionActionConfiguration> TeamGetMostEngaged(Expression<Func<ReportPeriodInput>> reportPeriod = null, Expression<Func<string>> startdate = null, Expression<Func<string>> enddate = null, Expression<Func<int>> numberOfTeams = null, Expression<Func<string>> tags = null, Expression<Func<int>> page = null)
        {
            var __workflow_reportPeriod = WorkflowExpression.Compile(reportPeriod, nameof(reportPeriod), required: false);
            var __workflow_startdate = WorkflowExpression.Compile(startdate, nameof(startdate), required: false);
            var __workflow_enddate = WorkflowExpression.Compile(enddate, nameof(enddate), required: false);
            var __workflow_numberOfTeams = WorkflowExpression.Compile(numberOfTeams, nameof(numberOfTeams), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<MostEngagedTeams, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/metrics/activity/teams/most-engaged";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportPeriod != null)
                    callPayload.Queries["report_period"] = ExpressionConverter.Convert(__workflow_reportPeriod);
                if (__workflow_startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(__workflow_startdate);
                if (__workflow_enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(__workflow_enddate);
                if (__workflow_numberOfTeams != null)
                    callPayload.Queries["number_of_teams"] = ExpressionConverter.Convert(__workflow_numberOfTeams);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<MostEngagedTeams>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<MostEngagedUsers, ApiConnectionActionConfiguration> UserGetMostEngaged(Expression<Func<ReportPeriodInput>> reportPeriod = null, Expression<Func<string>> startdate = null, Expression<Func<string>> enddate = null, Expression<Func<int>> numberOfUsers = null, Expression<Func<string>> teamName = null, Expression<Func<string>> tags = null, Expression<Func<int>> page = null)
        {
            var __workflow_reportPeriod = WorkflowExpression.Compile(reportPeriod, nameof(reportPeriod), required: false);
            var __workflow_startdate = WorkflowExpression.Compile(startdate, nameof(startdate), required: false);
            var __workflow_enddate = WorkflowExpression.Compile(enddate, nameof(enddate), required: false);
            var __workflow_numberOfUsers = WorkflowExpression.Compile(numberOfUsers, nameof(numberOfUsers), required: false);
            var __workflow_teamName = WorkflowExpression.Compile(teamName, nameof(teamName), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<MostEngagedUsers, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/metrics/activity/users/most-engaged";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportPeriod != null)
                    callPayload.Queries["report_period"] = ExpressionConverter.Convert(__workflow_reportPeriod);
                if (__workflow_startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(__workflow_startdate);
                if (__workflow_enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(__workflow_enddate);
                if (__workflow_numberOfUsers != null)
                    callPayload.Queries["number_of_users"] = ExpressionConverter.Convert(__workflow_numberOfUsers);
                if (__workflow_teamName != null)
                    callPayload.Queries["team_name"] = ExpressionConverter.Convert(__workflow_teamName);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<MostEngagedUsers>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<AssessmentsGetResponse, ApiConnectionActionConfiguration> AssessmentsGet(Expression<Func<int>> page = null, Expression<Func<string>> startdate = null, Expression<Func<string>> enddate = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_startdate = WorkflowExpression.Compile(startdate, nameof(startdate), required: false);
            var __workflow_enddate = WorkflowExpression.Compile(enddate, nameof(enddate), required: false);
            return new DeferredBodyAction<AssessmentsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assessments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(__workflow_startdate);
                if (__workflow_enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(__workflow_enddate);
                return new ApiConnectionAction<AssessmentsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<AssessmentGetAttemptsResponse, ApiConnectionActionConfiguration> AssessmentGetAttempts(Expression<Func<string>> assessmentId, Expression<Func<int>> page = null, Expression<Func<string>> developer = null, Expression<Func<string>> startdate = null, Expression<Func<string>> enddate = null)
        {
            var __workflow_assessmentId = WorkflowExpression.Compile(assessmentId, nameof(assessmentId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_developer = WorkflowExpression.Compile(developer, nameof(developer), required: false);
            var __workflow_startdate = WorkflowExpression.Compile(startdate, nameof(startdate), required: false);
            var __workflow_enddate = WorkflowExpression.Compile(enddate, nameof(enddate), required: false);
            return new DeferredBodyAction<AssessmentGetAttemptsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/assessments/{0}/attempts", __workflow_assessmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_developer != null)
                    callPayload.Queries["developer"] = ExpressionConverter.Convert(__workflow_developer);
                if (__workflow_startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(__workflow_startdate);
                if (__workflow_enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(__workflow_enddate);
                return new ApiConnectionAction<AssessmentGetAttemptsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<AssessmentSearchResponse, ApiConnectionActionConfiguration> AssessmentSearch(Expression<Func<AssessmentsSearchInput>> assessmentsSearch)
        {
            var __workflow_assessmentsSearch = WorkflowExpression.Compile(assessmentsSearch, nameof(assessmentsSearch), required: true);
            return new DeferredBodyAction<AssessmentSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assessments/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_assessmentsSearch);
                return new ApiConnectionAction<AssessmentSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<AssessmentSearchAttemptsResponse, ApiConnectionActionConfiguration> AssessmentSearchAttempts(Expression<Func<AssessmentAttemptsSearchInput>> assessmentAttemptsSearch)
        {
            var __workflow_assessmentAttemptsSearch = WorkflowExpression.Compile(assessmentAttemptsSearch, nameof(assessmentAttemptsSearch), required: true);
            return new DeferredBodyAction<AssessmentSearchAttemptsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assessments/attempts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_assessmentAttemptsSearch);
                return new ApiConnectionAction<AssessmentSearchAttemptsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<AssessmentAssignAssessmentAssignResponse2, ApiConnectionActionConfiguration> AssessmentAssign(Expression<Func<string>> assessmentId, Expression<Func<AssessmentAssignInput>> assessmentAssign)
        {
            var __workflow_assessmentId = WorkflowExpression.Compile(assessmentId, nameof(assessmentId), required: true);
            var __workflow_assessmentAssign = WorkflowExpression.Compile(assessmentAssign, nameof(assessmentAssign), required: true);
            return new DeferredBodyAction<AssessmentAssignAssessmentAssignResponse2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/assessments/{0}/assign", __workflow_assessmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_assessmentAssign);
                return new ApiConnectionAction<AssessmentAssignAssessmentAssignResponse2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TournamentsGetResponse, ApiConnectionActionConfiguration> TournamentsGet(Expression<Func<int>> page = null, Expression<Func<string>> name = null, Expression<Func<string>> startdate = null, Expression<Func<string>> enddate = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_startdate = WorkflowExpression.Compile(startdate, nameof(startdate), required: false);
            var __workflow_enddate = WorkflowExpression.Compile(enddate, nameof(enddate), required: false);
            return new DeferredBodyAction<TournamentsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tournaments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(__workflow_startdate);
                if (__workflow_enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(__workflow_enddate);
                return new ApiConnectionAction<TournamentsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TournamentGetLeaderboardResponse, ApiConnectionActionConfiguration> TournamentGetLeaderboard(Expression<Func<string>> tournamentId, Expression<Func<int>> page = null)
        {
            var __workflow_tournamentId = WorkflowExpression.Compile(tournamentId, nameof(tournamentId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<TournamentGetLeaderboardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tournaments/{0}/leaderboard", __workflow_tournamentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<TournamentGetLeaderboardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TournamentSearchLeaderboardResponse, ApiConnectionActionConfiguration> TournamentSearchLeaderboard(Expression<Func<string>> tournamentId, Expression<Func<TournamentLeaderboardSearchInput>> tournamentLeaderboardSearch)
        {
            var __workflow_tournamentId = WorkflowExpression.Compile(tournamentId, nameof(tournamentId), required: true);
            var __workflow_tournamentLeaderboardSearch = WorkflowExpression.Compile(tournamentLeaderboardSearch, nameof(tournamentLeaderboardSearch), required: true);
            return new DeferredBodyAction<TournamentSearchLeaderboardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tournaments/{0}/leaderboard/search", __workflow_tournamentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tournamentLeaderboardSearch);
                return new ApiConnectionAction<TournamentSearchLeaderboardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<LearningGetProgressResponse, ApiConnectionActionConfiguration> LearningGetProgress(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<LearningGetProgressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/learning/progress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<LearningGetProgressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<LearningGetResourcesResponse, ApiConnectionActionConfiguration> LearningGetResources()
        {
            return new DeferredBodyAction<LearningGetResourcesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/learning/resources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LearningGetResourcesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<LearningSearchProgressResponse, ApiConnectionActionConfiguration> LearningSearchProgress(Expression<Func<LearningProgressSearchInput>> learningProgressSearch)
        {
            var __workflow_learningProgressSearch = WorkflowExpression.Compile(learningProgressSearch, nameof(learningProgressSearch), required: true);
            return new DeferredBodyAction<LearningSearchProgressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/learning/progress/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_learningProgressSearch);
                return new ApiConnectionAction<LearningSearchProgressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TimeGetSpentResponse, ApiConnectionActionConfiguration> TimeGetSpent(Expression<Func<int>> page = null, Expression<Func<string>> id = null, Expression<Func<string>> email = null, Expression<Func<string>> tags = null, Expression<Func<string>> team = null, Expression<Func<string>> startdate = null, Expression<Func<string>> enddate = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: false);
            var __workflow_startdate = WorkflowExpression.Compile(startdate, nameof(startdate), required: false);
            var __workflow_enddate = WorkflowExpression.Compile(enddate, nameof(enddate), required: false);
            return new DeferredBodyAction<TimeGetSpentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/metrics/time-spent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                if (__workflow_startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(__workflow_startdate);
                if (__workflow_enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(__workflow_enddate);
                return new ApiConnectionAction<TimeGetSpentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<ActivityGetTopPerformResponse, ApiConnectionActionConfiguration> ActivityGetTopPerform(Expression<Func<ReportPeriodInput>> reportPeriod = null, Expression<Func<int>> numUsers = null, Expression<Func<int>> page = null, Expression<Func<string>> tags = null, Expression<Func<string>> team = null, Expression<Func<string>> starttime = null, Expression<Func<string>> endtime = null)
        {
            var __workflow_reportPeriod = WorkflowExpression.Compile(reportPeriod, nameof(reportPeriod), required: false);
            var __workflow_numUsers = WorkflowExpression.Compile(numUsers, nameof(numUsers), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: false);
            var __workflow_starttime = WorkflowExpression.Compile(starttime, nameof(starttime), required: false);
            var __workflow_endtime = WorkflowExpression.Compile(endtime, nameof(endtime), required: false);
            return new DeferredBodyAction<ActivityGetTopPerformResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/metrics/activity-top-performers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportPeriod != null)
                    callPayload.Queries["report_period"] = ExpressionConverter.Convert(__workflow_reportPeriod);
                callPayload.Queries["num_users"] = Convert.ToString(10);
                if (__workflow_numUsers != null)
                    callPayload.Queries["num_users"] = ExpressionConverter.Convert(__workflow_numUsers);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                if (__workflow_starttime != null)
                    callPayload.Queries["starttime"] = ExpressionConverter.Convert(__workflow_starttime);
                if (__workflow_endtime != null)
                    callPayload.Queries["endtime"] = ExpressionConverter.Convert(__workflow_endtime);
                return new ApiConnectionAction<ActivityGetTopPerformResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TeamsGetResponse, ApiConnectionActionConfiguration> TeamsGet(Expression<Func<int>> page = null, Expression<Func<string>> name = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            return new DeferredBodyAction<TeamsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<TeamsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TeamDetails, ApiConnectionActionConfiguration> TeamCreate(Expression<Func<TeamCreateInput>> teamCreate)
        {
            var __workflow_teamCreate = WorkflowExpression.Compile(teamCreate, nameof(teamCreate), required: true);
            return new DeferredBodyAction<TeamDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_teamCreate);
                return new ApiConnectionAction<TeamDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TeamDetails, ApiConnectionActionConfiguration> TeamGetDetails(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<TeamDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team/{0}", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TeamDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TeamDeleteResponse, ApiConnectionActionConfiguration> TeamDelete(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<TeamDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team/{0}", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TeamDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<TeamDetails, ApiConnectionActionConfiguration> TeamUpdate(Expression<Func<string>> teamId, Expression<Func<TeamUpdateInput>> teamUpdate)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_teamUpdate = WorkflowExpression.Compile(teamUpdate, nameof(teamUpdate), required: true);
            return new DeferredBodyAction<TeamDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team/{0}", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_teamUpdate);
                return new ApiConnectionAction<TeamDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<CoursesGetResponse, ApiConnectionActionConfiguration> CoursesGet(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<CoursesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<CoursesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<CourseGetDevelopersProgressResponse, ApiConnectionActionConfiguration> CourseGetDevelopersProgress(Expression<Func<string>> courseId, Expression<Func<int>> page = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<CourseGetDevelopersProgressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/courses/{0}/developers-progress", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<CourseGetDevelopersProgressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securecodewarrior")]
        public IBodyWorkflowAction<DeveloperSearchProgressResponse, ApiConnectionActionConfiguration> DeveloperSearchProgress(Expression<Func<CourseDeveloperProgressSearchInput>> courseDeveloperProgressSearch, Expression<Func<int>> page = null)
        {
            var __workflow_courseDeveloperProgressSearch = WorkflowExpression.Compile(courseDeveloperProgressSearch, nameof(courseDeveloperProgressSearch), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<DeveloperSearchProgressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/courses/developers-progress/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_courseDeveloperProgressSearch);
                return new ApiConnectionAction<DeveloperSearchProgressResponse>(callPayload);
            });
        }
    }

    public class SecurecodewarriorTriggers([ConnectionName] string connectionId)
    {
    }

    public class DeveloperGetLeaderboardResponse
    {
        [JsonProperty("leaderboard")]
        public DeveloperGetLeaderboardResponseLeaderboardTypeItem[] Leaderboard { get; set; }

        [JsonProperty("links")]
        public DeveloperGetLeaderboardResponseLinksType Links { get; set; }
    }

    public class DeveloperGetLeaderboardResponseLeaderboardTypeItem
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("developer")]
        public DeveloperGetLeaderboardResponseLeaderboardTypeItemDeveloperType Developer { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("hints_used")]
        public int HintsUsed { get; set; }

        [JsonProperty("lives_lost")]
        public int LivesLost { get; set; }

        [JsonProperty("levels")]
        public DeveloperGetLeaderboardResponseLeaderboardTypeItemLevelsTypeItem[] Levels { get; set; }
    }

    public class DeveloperGetLeaderboardResponseLeaderboardTypeItemDeveloperType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("member_since")]
        public string MemberSince { get; set; }

        [JsonProperty("last_logged_in")]
        public string LastLoggedIn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }

    public class DeveloperGetLeaderboardResponseLeaderboardTypeItemLevelsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("challenges")]
        public DeveloperGetLeaderboardResponseLeaderboardTypeItemLevelsTypeItemChallengesTypeItem[] Challenges { get; set; }
    }

    public class DeveloperGetLeaderboardResponseLeaderboardTypeItemLevelsTypeItemChallengesTypeItem
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("codebase_size")]
        public string CodebaseSize { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("stages")]
        public DeveloperGetLeaderboardResponseLeaderboardTypeItemLevelsTypeItemChallengesTypeItemStagesTypeItem[] Stages { get; set; }
    }

    public class DeveloperGetLeaderboardResponseLeaderboardTypeItemLevelsTypeItemChallengesTypeItemStagesTypeItem
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("lives_lost")]
        public int LivesLost { get; set; }

        [JsonProperty("hints_used")]
        public int HintsUsed { get; set; }
    }

    public class DeveloperGetLeaderboardResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public enum ReportPeriodInput
    {
        _1 = 1,
        _7 = 7,
        _30 = 30
    }

    public class DevelopersProgress
    {
        [JsonProperty("developers")]
        public DeveloperProgressEntry[] Developers { get; set; }

        [JsonProperty("links")]
        public DevelopersProgressLinksType Links { get; set; }
    }

    public class DeveloperProgressEntry
    {
        [JsonProperty("developer")]
        public Developer Developer { get; set; }

        [JsonProperty("languages")]
        public TrainingProgressEntry[] Languages { get; set; }
    }

    public class Developer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("member_since")]
        public string MemberSince { get; set; }

        [JsonProperty("last_logged_in")]
        public string LastLoggedIn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("roles")]
        public DeveloperRolesType Roles { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeveloperRolesType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "developer")]
        Developer,
        [EnumMember(Value = "team manager")]
        TeamManager,
        [EnumMember(Value = "company admin")]
        CompanyAdmin
    }

    public class TrainingProgressEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language_progress")]
        public int LanguageProgress { get; set; }

        [JsonProperty("realms")]
        public TrainingProgressEntryRealmsTypeItem[] Realms { get; set; }
    }

    public class TrainingProgressEntryRealmsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("realm_progress")]
        public int RealmProgress { get; set; }

        [JsonProperty("levels")]
        public TrainingProgressEntryRealmsTypeItemLevelsTypeItem[] Levels { get; set; }
    }

    public class TrainingProgressEntryRealmsTypeItemLevelsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level_progress")]
        public int LevelProgress { get; set; }

        [JsonProperty("quests")]
        public TrainingProgressEntryRealmsTypeItemLevelsTypeItemQuestsTypeItem[] Quests { get; set; }
    }

    public class TrainingProgressEntryRealmsTypeItemLevelsTypeItemQuestsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quest_progress")]
        public int QuestProgress { get; set; }
    }

    public class DevelopersProgressLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class DevelopersActivity
    {
        [JsonProperty("activities")]
        public ActivityEntry[] Activities { get; set; }

        [JsonProperty("links")]
        public DevelopersActivityLinksType Links { get; set; }
    }

    public class ActivityEntry
    {
        [JsonProperty("developer")]
        public Developer Developer { get; set; }

        [JsonProperty("challenge")]
        public ChallengeAttempt Challenge { get; set; }
    }

    public class ChallengeAttempt
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("realm")]
        public string Realm { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("quest")]
        public string Quest { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("difficulty")]
        public ChallengeAttemptDifficultyType Difficulty { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("status")]
        public ChallengeAttemptStatusType Status { get; set; }

        [JsonProperty("hints_used")]
        public int HintsUsed { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("max_score")]
        public string MaxScore { get; set; }

        [JsonProperty("select_vulnerability")]
        public SelectVulnerability SelectVulnerability { get; set; }

        [JsonProperty("locate_vulnerability")]
        public LocateVulnerability LocateVulnerability { get; set; }

        [JsonProperty("identify_solution")]
        public IdentifySolution IdentifySolution { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChallengeAttemptDifficultyType
    {
        Easy,
        Medium,
        Hard
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChallengeAttemptStatusType
    {
        [EnumMember(Value = "correct")]
        Correct,
        [EnumMember(Value = "incorrect")]
        Incorrect
    }

    public class SelectVulnerability
    {
        [JsonProperty("attempt_index")]
        public int AttemptIndex { get; set; }

        [JsonProperty("status")]
        public SelectVulnerabilityStatusType Status { get; set; }

        [JsonProperty("max_score")]
        public int MaxScore { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("skipped")]
        public bool Skipped { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectVulnerabilityStatusType
    {
        [EnumMember(Value = "correct")]
        Correct,
        [EnumMember(Value = "incorrect")]
        Incorrect,
        [EnumMember(Value = "out_of_reach")]
        OutOfReach
    }

    public class LocateVulnerability
    {
        [JsonProperty("attempt_index")]
        public int AttemptIndex { get; set; }

        [JsonProperty("status")]
        public LocateVulnerabilityStatusType Status { get; set; }

        [JsonProperty("max_score")]
        public int MaxScore { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LocateVulnerabilityStatusType
    {
        [EnumMember(Value = "correct")]
        Correct,
        [EnumMember(Value = "incorrect")]
        Incorrect,
        [EnumMember(Value = "out_of_reach")]
        OutOfReach
    }

    public class IdentifySolution
    {
        [JsonProperty("attempt_index")]
        public int AttemptIndex { get; set; }

        [JsonProperty("status")]
        public IdentifySolutionStatusType Status { get; set; }

        [JsonProperty("max_score")]
        public int MaxScore { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IdentifySolutionStatusType
    {
        [EnumMember(Value = "correct")]
        Correct,
        [EnumMember(Value = "incorrect")]
        Incorrect,
        [EnumMember(Value = "out_of_reach")]
        OutOfReach
    }

    public class DevelopersActivityLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class DeveloperSearchLeaderboardResponse
    {
        [JsonProperty("leaderboard")]
        public DeveloperSearchLeaderboardResponseLeaderboardTypeItem[] Leaderboard { get; set; }

        [JsonProperty("links")]
        public DeveloperSearchLeaderboardResponseLinksType Links { get; set; }
    }

    public class DeveloperSearchLeaderboardResponseLeaderboardTypeItem
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("developer")]
        public DeveloperSearchLeaderboardResponseLeaderboardTypeItemDeveloperType Developer { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("hints_used")]
        public int HintsUsed { get; set; }

        [JsonProperty("lives_lost")]
        public int LivesLost { get; set; }

        [JsonProperty("levels")]
        public DeveloperSearchLeaderboardResponseLeaderboardTypeItemLevelsTypeItem[] Levels { get; set; }
    }

    public class DeveloperSearchLeaderboardResponseLeaderboardTypeItemDeveloperType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("member_since")]
        public string MemberSince { get; set; }

        [JsonProperty("last_logged_in")]
        public string LastLoggedIn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }

    public class DeveloperSearchLeaderboardResponseLeaderboardTypeItemLevelsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("challenges")]
        public DeveloperSearchLeaderboardResponseLeaderboardTypeItemLevelsTypeItemChallengesTypeItem[] Challenges { get; set; }
    }

    public class DeveloperSearchLeaderboardResponseLeaderboardTypeItemLevelsTypeItemChallengesTypeItem
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("codebase_size")]
        public string CodebaseSize { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("stages")]
        public DeveloperSearchLeaderboardResponseLeaderboardTypeItemLevelsTypeItemChallengesTypeItemStagesTypeItem[] Stages { get; set; }
    }

    public class DeveloperSearchLeaderboardResponseLeaderboardTypeItemLevelsTypeItemChallengesTypeItemStagesTypeItem
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("lives_lost")]
        public int LivesLost { get; set; }

        [JsonProperty("hints_used")]
        public int HintsUsed { get; set; }
    }

    public class DeveloperSearchLeaderboardResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class DeveloperLeaderboardSearchInput
    {
        [JsonProperty("report_period_in_days")]
        public int? ReportPeriodInDays { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("users")]
        public string Users { get; set; }

        [JsonProperty("team_names")]
        public string TeamNames { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }
    }

    public class DeveloperProgressSearchInput
    {
        [JsonProperty("report_period_in_days")]
        public int? ReportPeriodInDays { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("users")]
        public string Users { get; set; }

        [JsonProperty("team_names")]
        public string TeamNames { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }
    }

    public class StrengthsAndWeaknesses
    {
        [JsonProperty("auth")]
        public AverageStrengthsAndWeaknessesEntry Auth { get; set; }

        [JsonProperty("data_handling")]
        public AverageStrengthsAndWeaknessesEntry DataHandling { get; set; }

        [JsonProperty("misconfig")]
        public AverageStrengthsAndWeaknessesEntry Misconfig { get; set; }

        [JsonProperty("practices")]
        public AverageStrengthsAndWeaknessesEntry Practices { get; set; }

        [JsonProperty("sensitive_data")]
        public AverageStrengthsAndWeaknessesEntry SensitiveData { get; set; }

        [JsonProperty("other")]
        public AverageStrengthsAndWeaknessesEntry Other { get; set; }
    }

    public class AverageStrengthsAndWeaknessesEntry
    {
        [JsonProperty("challenges")]
        public ChallengesEntry Challenges { get; set; }

        [JsonProperty("hints")]
        public HintsEntry Hints { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("timeSpent")]
        public int TimeSpent { get; set; }
    }

    public class ChallengesEntry
    {
        [JsonProperty("attempted")]
        public int Attempted { get; set; }

        [JsonProperty("correct")]
        public int Correct { get; set; }

        [JsonProperty("incorrect")]
        public int Incorrect { get; set; }

        [JsonProperty("percentageCorrect")]
        public int PercentageCorrect { get; set; }

        [JsonProperty("ratioCorrect")]
        public double RatioCorrect { get; set; }
    }

    public class HintsEntry
    {
        [JsonProperty("confidenceLevel")]
        public int ConfidenceLevel { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("used")]
        public int Used { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TargetTypeInput
    {
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "developer")]
        Developer
    }

    public class DeveloperActivitySearchInput
    {
        [JsonProperty("report_period_in_days")]
        public int? ReportPeriodInDays { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("users")]
        public string Users { get; set; }

        [JsonProperty("team_names")]
        public string TeamNames { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }
    }

    public class MostEngagedTeams
    {
        [JsonProperty("teams")]
        public TeamEntry[] Teams { get; set; }

        [JsonProperty("links")]
        public MostEngagedTeamsLinksType Links { get; set; }
    }

    public class TeamEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timeSpent")]
        public int TimeSpent { get; set; }
    }

    public class MostEngagedTeamsLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class MostEngagedUsers
    {
        [JsonProperty("users")]
        public UserEntry[] Users { get; set; }

        [JsonProperty("links")]
        public MostEngagedUsersLinksType Links { get; set; }
    }

    public class UserEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timeSpent")]
        public int TimeSpent { get; set; }
    }

    public class MostEngagedUsersLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class AssessmentsGetResponse
    {
        [JsonProperty("assessments")]
        public Assessment[] Assessments { get; set; }

        [JsonProperty("links")]
        public AssessmentsGetResponseLinksType Links { get; set; }
    }

    public class Assessment
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public AssessmentStatusType Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("supported_languages")]
        public string[] SupportedLanguages { get; set; }

        [JsonProperty("difficulty")]
        public AssessmentDifficultyType Difficulty { get; set; }

        [JsonProperty("success_ratio")]
        public int SuccessRatio { get; set; }

        [JsonProperty("emits_certificate")]
        public bool EmitsCertificate { get; set; }

        [JsonProperty("time_limit")]
        public int TimeLimit { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("number_of_challenges")]
        public int NumberOfChallenges { get; set; }

        [JsonProperty("self_assess")]
        public bool SelfAssess { get; set; }

        [JsonProperty("retries_allowed")]
        public bool RetriesAllowed { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssessmentStatusType
    {
        [EnumMember(Value = "correct")]
        Correct,
        [EnumMember(Value = "incorrect")]
        Incorrect,
        [EnumMember(Value = "done")]
        Done
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssessmentDifficultyType
    {
        [EnumMember(Value = "easy")]
        Easy,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "hard")]
        Hard
    }

    public class AssessmentsGetResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class AssessmentGetAttemptsResponse
    {
        [JsonProperty("attempts")]
        public AssessmentGetAttemptsResponseAttemptsTypeItem[] Attempts { get; set; }

        [JsonProperty("links")]
        public AssessmentGetAttemptsResponseLinksType Links { get; set; }
    }

    public class AssessmentGetAttemptsResponseAttemptsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_assessment")]
        public string Assessment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("developer")]
        public AssessmentGetAttemptsResponseAttemptsTypeItemDeveloperType Developer { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("completed_in")]
        public string CompletedIn { get; set; }

        [JsonProperty("passing_grade")]
        public int PassingGrade { get; set; }

        [JsonProperty("pass_status")]
        public string PassStatus { get; set; }

        [JsonProperty("progress")]
        public AssessmentGetAttemptsResponseAttemptsTypeItemProgressType Progress { get; set; }

        [JsonProperty("accuracy")]
        public AssessmentGetAttemptsResponseAttemptsTypeItemAccuracyType Accuracy { get; set; }

        [JsonProperty("challenges")]
        public AssessmentGetAttemptsResponseAttemptsTypeItemChallengesTypeItem[] Challenges { get; set; }
    }

    public class AssessmentGetAttemptsResponseAttemptsTypeItemDeveloperType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("member_since")]
        public string MemberSince { get; set; }

        [JsonProperty("last_logged_in")]
        public string LastLoggedIn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }

    public class AssessmentGetAttemptsResponseAttemptsTypeItemProgressType
    {
        [JsonProperty("correct")]
        public int Correct { get; set; }

        [JsonProperty("incorrect")]
        public int Incorrect { get; set; }

        [JsonProperty("number_of_challenges")]
        public int NumberOfChallenges { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }
    }

    public class AssessmentGetAttemptsResponseAttemptsTypeItemAccuracyType
    {
        [JsonProperty("located")]
        public int Located { get; set; }

        [JsonProperty("identified")]
        public int Identified { get; set; }

        [JsonProperty("fixed")]
        public int Fixed { get; set; }
    }

    public class AssessmentGetAttemptsResponseAttemptsTypeItemChallengesTypeItem
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("max_score")]
        public int MaxScore { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("locate")]
        public AssessmentGetAttemptsResponseAttemptsTypeItemChallengesTypeItemLocateType Locate { get; set; }

        [JsonProperty("identify")]
        public AssessmentGetAttemptsResponseAttemptsTypeItemChallengesTypeItemIdentifyType Identify { get; set; }

        [JsonProperty("fix")]
        public AssessmentGetAttemptsResponseAttemptsTypeItemChallengesTypeItemFixType Fix { get; set; }
    }

    public class AssessmentGetAttemptsResponseAttemptsTypeItemChallengesTypeItemLocateType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AssessmentGetAttemptsResponseAttemptsTypeItemChallengesTypeItemIdentifyType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AssessmentGetAttemptsResponseAttemptsTypeItemChallengesTypeItemFixType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AssessmentGetAttemptsResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class AssessmentSearchResponse
    {
        [JsonProperty("assessments")]
        public Assessment[] Assessments { get; set; }

        [JsonProperty("links")]
        public AssessmentSearchResponseLinksType Links { get; set; }
    }

    public class AssessmentSearchResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class AssessmentsSearchInput
    {
        [JsonProperty("status")]
        public AssessmentsSearchInputStatusType? Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("supported_languages")]
        public SupportedLanguage[] SupportedLanguages { get; set; }

        [JsonProperty("difficulty")]
        public AssessmentsSearchInputDifficultyType? Difficulty { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssessmentsSearchInputStatusType
    {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "closed")]
        Closed
    }

    public class SupportedLanguage
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_framework")]
        public string Framework { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssessmentsSearchInputDifficultyType
    {
        [EnumMember(Value = "easy")]
        Easy,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "hard")]
        Hard
    }

    public class AssessmentSearchAttemptsResponse
    {
        [JsonProperty("attempts")]
        public AssessmentSearchAttemptsResponseAttemptsTypeItem[] Attempts { get; set; }

        [JsonProperty("links")]
        public AssessmentSearchAttemptsResponseLinksType Links { get; set; }
    }

    public class AssessmentSearchAttemptsResponseAttemptsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_assessment")]
        public string Assessment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("developer")]
        public AssessmentSearchAttemptsResponseAttemptsTypeItemDeveloperType Developer { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("completed_in")]
        public string CompletedIn { get; set; }

        [JsonProperty("passing_grade")]
        public int PassingGrade { get; set; }

        [JsonProperty("pass_status")]
        public string PassStatus { get; set; }

        [JsonProperty("progress")]
        public AssessmentSearchAttemptsResponseAttemptsTypeItemProgressType Progress { get; set; }

        [JsonProperty("accuracy")]
        public AssessmentSearchAttemptsResponseAttemptsTypeItemAccuracyType Accuracy { get; set; }

        [JsonProperty("challenges")]
        public AssessmentSearchAttemptsResponseAttemptsTypeItemChallengesTypeItem[] Challenges { get; set; }
    }

    public class AssessmentSearchAttemptsResponseAttemptsTypeItemDeveloperType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("member_since")]
        public string MemberSince { get; set; }

        [JsonProperty("last_logged_in")]
        public string LastLoggedIn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }

    public class AssessmentSearchAttemptsResponseAttemptsTypeItemProgressType
    {
        [JsonProperty("correct")]
        public int Correct { get; set; }

        [JsonProperty("incorrect")]
        public int Incorrect { get; set; }

        [JsonProperty("number_of_challenges")]
        public int NumberOfChallenges { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }
    }

    public class AssessmentSearchAttemptsResponseAttemptsTypeItemAccuracyType
    {
        [JsonProperty("located")]
        public int Located { get; set; }

        [JsonProperty("identified")]
        public int Identified { get; set; }

        [JsonProperty("fixed")]
        public int Fixed { get; set; }
    }

    public class AssessmentSearchAttemptsResponseAttemptsTypeItemChallengesTypeItem
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("max_score")]
        public int MaxScore { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("locate")]
        public AssessmentSearchAttemptsResponseAttemptsTypeItemChallengesTypeItemLocateType Locate { get; set; }

        [JsonProperty("identify")]
        public AssessmentSearchAttemptsResponseAttemptsTypeItemChallengesTypeItemIdentifyType Identify { get; set; }

        [JsonProperty("fix")]
        public AssessmentSearchAttemptsResponseAttemptsTypeItemChallengesTypeItemFixType Fix { get; set; }
    }

    public class AssessmentSearchAttemptsResponseAttemptsTypeItemChallengesTypeItemLocateType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AssessmentSearchAttemptsResponseAttemptsTypeItemChallengesTypeItemIdentifyType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AssessmentSearchAttemptsResponseAttemptsTypeItemChallengesTypeItemFixType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AssessmentSearchAttemptsResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class AssessmentAttemptsSearchInput
    {
        [JsonProperty("assessment_id")]
        public string AssessmentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("users")]
        public string Users { get; set; }

        [JsonProperty("status")]
        public AssessmentAttemptsSearchInputStatusType? Status { get; set; }

        [JsonProperty("team_names")]
        public string TeamNames { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("pass_status")]
        public AssessmentAttemptsSearchInputPassStatusType? PassStatus { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssessmentAttemptsSearchInputStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "in_progress")]
        InProgress,
        [EnumMember(Value = "done")]
        Done
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssessmentAttemptsSearchInputPassStatusType
    {
        [EnumMember(Value = "pass")]
        Pass,
        [EnumMember(Value = "fail")]
        Fail,
        [EnumMember(Value = "in_progress")]
        InProgress
    }

    public class AssessmentAssignAssessmentAssignResponse2
    {
        [JsonProperty("assessmentInvitations")]
        public AssessmentAssignAssessmentAssignResponse[] AssessmentInvitations { get; set; }
    }

    public class AssessmentAssignAssessmentAssignResponse
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("inviteEmailSent")]
        public bool InviteEmailSent { get; set; }

        [JsonProperty("inviteUrl")]
        public string InviteUrl { get; set; }
    }

    public class AssessmentAssignInput
    {
        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("teams")]
        public string[] Teams { get; set; }

        [JsonProperty("sendEmail")]
        public bool? SendEmail { get; set; }
    }

    public class TournamentsGetResponse
    {
        [JsonProperty("tournaments")]
        public Tournament[] Tournaments { get; set; }

        [JsonProperty("links")]
        public TournamentsGetResponseLinksType Links { get; set; }
    }

    public class Tournament
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class TournamentsGetResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class TournamentGetLeaderboardResponse
    {
        [JsonProperty("leaderboard")]
        public TournamentParticipant[] Leaderboard { get; set; }

        [JsonProperty("links")]
        public TournamentGetLeaderboardResponseLinksType Links { get; set; }
    }

    public class TournamentParticipant
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("developer")]
        public Developer Developer { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("hints_used")]
        public int HintsUsed { get; set; }

        [JsonProperty("lives_lost")]
        public int LivesLost { get; set; }

        [JsonProperty("levels")]
        public Level[] Levels { get; set; }
    }

    public class Level
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("challenges")]
        public LevelChallengesTypeItem[] Challenges { get; set; }
    }

    public class LevelChallengesTypeItem
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("difficulty")]
        public LevelChallengesTypeItemDifficultyType Difficulty { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("codebase_size")]
        public LevelChallengesTypeItemCodebaseSizeType CodebaseSize { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("stages")]
        public Stage[] Stages { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LevelChallengesTypeItemDifficultyType
    {
        [EnumMember(Value = "easy")]
        Easy,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "hard")]
        Hard
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "in_progress")]
        InProgress,
        [EnumMember(Value = "done")]
        Done,
        [EnumMember(Value = "out_of_reach")]
        OutOfReach,
        [EnumMember(Value = "skipped")]
        Skipped,
        [EnumMember(Value = "correct")]
        Correct,
        [EnumMember(Value = "incorrect")]
        Incorrect
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LevelChallengesTypeItemCodebaseSizeType
    {
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "large")]
        Large
    }

    public class Stage
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public StageStatusType Status { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("max_points")]
        public int MaxPoints { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("lives_lost")]
        public int LivesLost { get; set; }

        [JsonProperty("hints_used")]
        public int HintsUsed { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StageStatusType
    {
        [EnumMember(Value = "correct")]
        Correct,
        [EnumMember(Value = "incorrect")]
        Incorrect,
        [EnumMember(Value = "pending")]
        Pending
    }

    public class TournamentGetLeaderboardResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class TournamentSearchLeaderboardResponse
    {
        [JsonProperty("leaderboard")]
        public TournamentParticipant[] Leaderboard { get; set; }

        [JsonProperty("links")]
        public TournamentSearchLeaderboardResponseLinksType Links { get; set; }
    }

    public class TournamentSearchLeaderboardResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class TournamentLeaderboardSearchInput
    {
        [JsonProperty("report_period_in_days")]
        public int? ReportPeriodInDays { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("users")]
        public string Users { get; set; }

        [JsonProperty("team_names")]
        public string TeamNames { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }
    }

    public class LearningGetProgressResponse
    {
        [JsonProperty("developers")]
        public ResourceRecord[] Developers { get; set; }

        [JsonProperty("links")]
        public LearningGetProgressResponseLinksType Links { get; set; }
    }

    public class ResourceRecord
    {
        [JsonProperty("profile")]
        public Developer Profile { get; set; }

        [JsonProperty("completed")]
        public CompletedResource[] Completed { get; set; }
    }

    public class CompletedResource
    {
        [JsonProperty("resource")]
        public string[] Resource { get; set; }

        [JsonProperty("time_completed")]
        public string TimeCompleted { get; set; }
    }

    public class LearningGetProgressResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class LearningGetResourcesResponse
    {
        [JsonProperty("resources")]
        public Resource[] Resources { get; set; }
    }

    public class Resource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("items")]
        public ResourceItem[] Items { get; set; }
    }

    public class ResourceItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LearningSearchProgressResponse
    {
        [JsonProperty("developers")]
        public ResourceRecord[] Developers { get; set; }

        [JsonProperty("links")]
        public LearningSearchProgressResponseLinksType Links { get; set; }
    }

    public class LearningSearchProgressResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class LearningProgressSearchInput
    {
        [JsonProperty("users")]
        public string Users { get; set; }

        [JsonProperty("team_names")]
        public string TeamNames { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }
    }

    public class TimeGetSpentResponse
    {
        [JsonProperty("users")]
        public UsersTimeSpent[] Users { get; set; }

        [JsonProperty("links")]
        public TimeGetSpentResponseLinksType Links { get; set; }
    }

    public class UsersTimeSpent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public UsersTimeSpentNameType Name { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("status")]
        public UsersTimeSpentStatusType Status { get; set; }

        [JsonProperty("team")]
        public TeamData Team { get; set; }

        [JsonProperty("time-spent")]
        public UsersTimeSpentTimeSpentTypeItem[] TimeSpent { get; set; }
    }

    public class UsersTimeSpentNameType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("middle")]
        public string Middle { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UsersTimeSpentStatusType
    {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "invited")]
        Invited,
        [EnumMember(Value = "registered")]
        Registered
    }

    public class TeamData
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UsersTimeSpentTimeSpentTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("activity")]
        public UsersTimeSpentTimeSpentTypeItemActivityType Activity { get; set; }
    }

    public class UsersTimeSpentTimeSpentTypeItemActivityType
    {
        public int Assessments { get; set; }
        public int Learning { get; set; }
        public int Tournaments { get; set; }
        public int Training { get; set; }
    }

    public class TimeGetSpentResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class ActivityGetTopPerformResponse
    {
        [JsonProperty("schema")]
        public TopPerformersInfo Schema { get; set; }
    }

    public class TopPerformersInfo
    {
        [JsonProperty("report_period_in_days")]
        public int ReportPeriodInDays { get; set; }

        [JsonProperty("top_performers")]
        public TopPerformer[] TopPerformers { get; set; }

        [JsonProperty("links")]
        public TopPerformersInfoLinksType Links { get; set; }
    }

    public class TopPerformer
    {
        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public TopPerformerNameType Name { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("status")]
        public TopPerformerStatusType Status { get; set; }

        [JsonProperty("team")]
        public TeamData Team { get; set; }
    }

    public class TopPerformerNameType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("middle")]
        public string Middle { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TopPerformerStatusType
    {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "invited")]
        Invited,
        [EnumMember(Value = "registered")]
        Registered
    }

    public class TopPerformersInfoLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class TeamsGetResponse
    {
        [JsonProperty("teams")]
        public TeamDetails[] Teams { get; set; }

        [JsonProperty("links")]
        public TeamsGetResponseLinksType Links { get; set; }
    }

    public class TeamDetails
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("onboardingMessage")]
        public string OnboardingMessage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("memberJoinToken")]
        public string MemberJoinToken { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }
    }

    public class TeamsGetResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class TeamCreateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("activeFrom")]
        public string ActiveFrom { get; set; }

        [JsonProperty("activeUntil")]
        public string ActiveUntil { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("onboardingmessage")]
        public string Onboardingmessage { get; set; }

        [JsonProperty("licensing")]
        public TeamLicensing Licensing { get; set; }
    }

    public class TeamLicensing
    {
        [JsonProperty("training")]
        public LicensingEntry Training { get; set; }

        [JsonProperty("assessments")]
        public LicensingEntry Assessments { get; set; }

        [JsonProperty("tournaments")]
        public LicensingEntry Tournaments { get; set; }
    }

    public class LicensingEntry
    {
        [JsonProperty("type")]
        public LicensingEntryTypeType? Type { get; set; }

        [JsonProperty("granted")]
        public int? Granted { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LicensingEntryTypeType
    {
        [EnumMember(Value = "usage")]
        Usage,
        [EnumMember(Value = "unlimited")]
        Unlimited,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    public class TeamDeleteResponse
    {
        [JsonProperty("deleteStatus")]
        public string DeleteStatus { get; set; }
    }

    public class TeamUpdateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("onboardingmessage")]
        public string Onboardingmessage { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }
    }

    public class CoursesGetResponse
    {
        [JsonProperty("courses")]
        public Course[] Courses { get; set; }

        [JsonProperty("links")]
        public CoursesGetResponseLinksType Links { get; set; }
    }

    public class Course
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public CourseStatusType Status { get; set; }

        [JsonProperty("supported_languages")]
        public string[] SupportedLanguages { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CourseStatusType
    {
        [EnumMember(Value = "archived")]
        Archived,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "unpublished")]
        Unpublished,
        [EnumMember(Value = "expired")]
        Expired
    }

    public class CoursesGetResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class CourseGetDevelopersProgressResponse
    {
        [JsonProperty("data")]
        public CourseDeveloperProgressEntry[] Data { get; set; }

        [JsonProperty("links")]
        public CourseGetDevelopersProgressResponseLinksType Links { get; set; }
    }

    public class CourseDeveloperProgressEntry
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("status")]
        public CourseDeveloperProgressEntryStatusType Status { get; set; }

        [JsonProperty("accuracy")]
        public int Accuracy { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("first_completed_date")]
        public string FirstCompletedDate { get; set; }

        [JsonProperty("first_enrolled_date")]
        public string FirstEnrolledDate { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("languages")]
        public CourseDeveloperProgressLanguageEntry[] Languages { get; set; }

        [JsonProperty("invites")]
        public JToken[] Invites { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CourseDeveloperProgressEntryStatusType
    {
        Invited,
        [EnumMember(Value = "In Progress")]
        InProgress,
        Completed
    }

    public class CourseDeveloperProgressLanguageEntry
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("accuracy")]
        public int Accuracy { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("videos_watched")]
        public int VideosWatched { get; set; }
    }

    public class CourseGetDevelopersProgressResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class DeveloperSearchProgressResponse
    {
        [JsonProperty("data")]
        public DeveloperSearchProgressResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public DeveloperSearchProgressResponseLinksType Links { get; set; }
    }

    public class DeveloperSearchProgressResponseDataTypeItem
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("status")]
        public DeveloperSearchProgressResponseDataTypeItemStatusType Status { get; set; }

        [JsonProperty("accuracy")]
        public int Accuracy { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("minutes_spent")]
        public int MinutesSpent { get; set; }

        [JsonProperty("first_completed_date")]
        public string FirstCompletedDate { get; set; }

        [JsonProperty("first_enrolled_date")]
        public string FirstEnrolledDate { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("languages")]
        public CourseDeveloperProgressLanguageEntry[] Languages { get; set; }

        [JsonProperty("invites")]
        public JToken[] Invites { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeveloperSearchProgressResponseDataTypeItemStatusType
    {
        Invited,
        [EnumMember(Value = "In Progress")]
        InProgress,
        Completed
    }

    public class DeveloperSearchProgressResponseLinksType
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class CourseDeveloperProgressSearchInput
    {
        [JsonProperty("course_id")]
        public string[] CourseId { get; set; }

        [JsonProperty("user_id")]
        public string[] UserId { get; set; }

        [JsonProperty("status")]
        public CourseDeveloperProgressSearchInputStatusType? Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CourseDeveloperProgressSearchInputStatusType
    {
        Invited,
        [EnumMember(Value = "In Progress")]
        InProgress,
        Completed
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Securecodewarrior;

    public partial class WorkflowManagedActions
    {
        public SecurecodewarriorActions Securecodewarrior(string connectionId) => new SecurecodewarriorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SecurecodewarriorTriggers Securecodewarrior(string connectionId) => new SecurecodewarriorTriggers(connectionId);
    }
}