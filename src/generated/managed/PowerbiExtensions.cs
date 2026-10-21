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
        public IBodyWorkflowAction<ListedScorecards> GetScorecards(Expression<Func<string>> groupid)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            return new DeferredBodyAction<ListedScorecards>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", __workflow_groupid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction<ListedScorecards>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreatedScorecard> CreateScorecard(Expression<Func<string>> groupid, Expression<Func<string>> scorecardname, Expression<Func<string>> scorecarddescription = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardname = WorkflowExpression.Compile(scorecardname, nameof(scorecardname), required: true);
            var __workflow_scorecarddescription = WorkflowExpression.Compile(scorecarddescription, nameof(scorecarddescription), required: false);
            return new DeferredBodyAction<CreatedScorecard>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", __workflow_groupid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var scorecard = new JObject();
                var scorecardpropCount = 0;
                scorecardpropCount++;
                scorecard["name"] = ExpressionConverter.ConvertO(__workflow_scorecardname);
                if (__workflow_scorecarddescription != null)
                {
                    scorecard["description"] = ExpressionConverter.ConvertO(__workflow_scorecarddescription);
                    scorecardpropCount++;
                }

                if (scorecardpropCount > 0)
                {
                    callPayload.Body = scorecard;
                }

                return new ApiConnectionAction<CreatedScorecard>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoals> GetMultipleGoals(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            return new DeferredBodyAction<FetchedGoals>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("aggregations");
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction<FetchedGoals>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreateGoalResponse> CreateGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalname, Expression<Func<string>> goalowner = null, Expression<Func<string>> goalcurrentValue = null, Expression<Func<string>> goaltargetValue = null, Expression<Func<goalstatusInput>> goalstatus = null, Expression<Func<string>> goalstartDate = null, Expression<Func<string>> goalcompletionDate = null, Expression<Func<string>> goalnote = null, Expression<Func<string>> goalparentGoalId = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalname = WorkflowExpression.Compile(goalname, nameof(goalname), required: true);
            var __workflow_goalowner = WorkflowExpression.Compile(goalowner, nameof(goalowner), required: false);
            var __workflow_goalcurrentValue = WorkflowExpression.Compile(goalcurrentValue, nameof(goalcurrentValue), required: false);
            var __workflow_goaltargetValue = WorkflowExpression.Compile(goaltargetValue, nameof(goaltargetValue), required: false);
            var __workflow_goalstatus = WorkflowExpression.Compile(goalstatus, nameof(goalstatus), required: false);
            var __workflow_goalstartDate = WorkflowExpression.Compile(goalstartDate, nameof(goalstartDate), required: false);
            var __workflow_goalcompletionDate = WorkflowExpression.Compile(goalcompletionDate, nameof(goalcompletionDate), required: false);
            var __workflow_goalnote = WorkflowExpression.Compile(goalnote, nameof(goalnote), required: false);
            var __workflow_goalparentGoalId = WorkflowExpression.Compile(goalparentGoalId, nameof(goalparentGoalId), required: false);
            return new DeferredBodyAction<CreateGoalResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var goal = new JObject();
                var goalpropCount = 0;
                goalpropCount++;
                goal["name"] = ExpressionConverter.ConvertO(__workflow_goalname);
                if (__workflow_goalowner != null)
                {
                    goal["owner"] = ExpressionConverter.ConvertO(__workflow_goalowner);
                    goalpropCount++;
                }

                if (__workflow_goalcurrentValue != null)
                {
                    goal["value"] = ExpressionConverter.ConvertO(__workflow_goalcurrentValue);
                    goalpropCount++;
                }

                if (__workflow_goaltargetValue != null)
                {
                    goal["target"] = ExpressionConverter.ConvertO(__workflow_goaltargetValue);
                    goalpropCount++;
                }

                if (__workflow_goalstatus != null)
                {
                    if (__workflow_goalstatus != null)
                    {
                        goal["status"] = ExpressionConverter.ConvertO(__workflow_goalstatus);
                        goalpropCount++;
                    }

                    goalpropCount++;
                }
                else
                {
                    goal["status"] = "Not started";
                    goalpropCount++;
                }

                if (__workflow_goalstartDate != null)
                {
                    goal["startDate"] = ExpressionConverter.ConvertO(__workflow_goalstartDate);
                    goalpropCount++;
                }

                if (__workflow_goalcompletionDate != null)
                {
                    goal["completionDate"] = ExpressionConverter.ConvertO(__workflow_goalcompletionDate);
                    goalpropCount++;
                }

                if (__workflow_goalnote != null)
                {
                    goal["note"] = ExpressionConverter.ConvertO(__workflow_goalnote);
                    goalpropCount++;
                }

                if (__workflow_goalparentGoalId != null)
                {
                    goal["parentId"] = ExpressionConverter.ConvertO(__workflow_goalparentGoalId);
                    goalpropCount++;
                }

                if (goalpropCount > 0)
                {
                    callPayload.Body = goal;
                }

                return new ApiConnectionAction<CreateGoalResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoal> GetGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<FetchedGoal>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("aggregations");
                return new ApiConnectionAction<FetchedGoal>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction UpdateGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalname = null, Expression<Func<string>> goalowner = null, Expression<Func<double>> goalcurrentValue = null, Expression<Func<double>> goaltargetValue = null, Expression<Func<goalstatusInput>> goalstatus = null, Expression<Func<string>> goalstartDate = null, Expression<Func<string>> goalcompletionDate = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_goalname = WorkflowExpression.Compile(goalname, nameof(goalname), required: false);
            var __workflow_goalowner = WorkflowExpression.Compile(goalowner, nameof(goalowner), required: false);
            var __workflow_goalcurrentValue = WorkflowExpression.Compile(goalcurrentValue, nameof(goalcurrentValue), required: false);
            var __workflow_goaltargetValue = WorkflowExpression.Compile(goaltargetValue, nameof(goaltargetValue), required: false);
            var __workflow_goalstatus = WorkflowExpression.Compile(goalstatus, nameof(goalstatus), required: false);
            var __workflow_goalstartDate = WorkflowExpression.Compile(goalstartDate, nameof(goalstartDate), required: false);
            var __workflow_goalcompletionDate = WorkflowExpression.Compile(goalcompletionDate, nameof(goalcompletionDate), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var goal = new JObject();
                var goalpropCount = 0;
                if (__workflow_goalname != null)
                {
                    goal["name"] = ExpressionConverter.ConvertO(__workflow_goalname);
                    goalpropCount++;
                }

                if (__workflow_goalowner != null)
                {
                    goal["owner"] = ExpressionConverter.ConvertO(__workflow_goalowner);
                    goalpropCount++;
                }

                if (__workflow_goalcurrentValue != null)
                {
                    goal["value"] = ExpressionConverter.ConvertO(__workflow_goalcurrentValue);
                    goalpropCount++;
                }

                if (__workflow_goaltargetValue != null)
                {
                    goal["target"] = ExpressionConverter.ConvertO(__workflow_goaltargetValue);
                    goalpropCount++;
                }

                if (__workflow_goalstatus != null)
                {
                    if (__workflow_goalstatus != null)
                    {
                        goal["status"] = ExpressionConverter.ConvertO(__workflow_goalstatus);
                        goalpropCount++;
                    }

                    goalpropCount++;
                }
                else
                {
                    goal["status"] = "Leave unchanged";
                    goalpropCount++;
                }

                if (__workflow_goalstartDate != null)
                {
                    goal["startDate"] = ExpressionConverter.ConvertO(__workflow_goalstartDate);
                    goalpropCount++;
                }

                if (__workflow_goalcompletionDate != null)
                {
                    goal["completionDate"] = ExpressionConverter.ConvertO(__workflow_goalcompletionDate);
                    goalpropCount++;
                }

                if (goalpropCount > 0)
                {
                    callPayload.Body = goal;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<QueryExecutionResults> ExecuteDatasetQuery(Expression<Func<string>> groupid, Expression<Func<string>> datasetid, Expression<Func<string>> specificationqueryText, Expression<Func<bool>> specificationserializerSettingsnullsIncluded = null, Expression<Func<string>> specificationimpersonateUser = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_datasetid = WorkflowExpression.Compile(datasetid, nameof(datasetid), required: true);
            var __workflow_specificationqueryText = WorkflowExpression.Compile(specificationqueryText, nameof(specificationqueryText), required: true);
            var __workflow_specificationserializerSettingsnullsIncluded = WorkflowExpression.Compile(specificationserializerSettingsnullsIncluded, nameof(specificationserializerSettingsnullsIncluded), required: false);
            var __workflow_specificationimpersonateUser = WorkflowExpression.Compile(specificationimpersonateUser, nameof(specificationimpersonateUser), required: false);
            return new DeferredBodyAction<QueryExecutionResults>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", __workflow_groupid.WithUrlEncoding(1), __workflow_datasetid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var specification = new JObject();
                var specificationpropCount = 0;
                specificationpropCount++;
                specification["query"] = ExpressionConverter.ConvertO(__workflow_specificationqueryText);
                var serializerSettingsObject = new JObject();
                var serializerSettingsObjectpropCount = 0;
                if (__workflow_specificationserializerSettingsnullsIncluded != null)
                {
                    if (__workflow_specificationserializerSettingsnullsIncluded != null)
                    {
                        serializerSettingsObject["includeNulls"] = ExpressionConverter.ConvertO(__workflow_specificationserializerSettingsnullsIncluded);
                        serializerSettingsObjectpropCount++;
                    }

                    serializerSettingsObjectpropCount++;
                }
                else
                {
                    serializerSettingsObject["includeNulls"] = false;
                    serializerSettingsObjectpropCount++;
                }

                if (serializerSettingsObjectpropCount > 0)
                {
                    specification["serializerSettings"] = serializerSettingsObject;
                    specificationpropCount++;
                }

                if (__workflow_specificationimpersonateUser != null)
                {
                    specification["impersonatedUserName"] = ExpressionConverter.ConvertO(__workflow_specificationimpersonateUser);
                    specificationpropCount++;
                }

                if (specificationpropCount > 0)
                {
                    callPayload.Body = specification;
                }

                return new ApiConnectionAction<QueryExecutionResults>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<JToken> ExecuteDatasetQueriesJson(Expression<Func<string>> groupid, Expression<Func<string>> datasetid)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_datasetid = WorkflowExpression.Compile(datasetid, nameof(datasetid), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/internalFlowActionOverloadAsJson/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", __workflow_groupid.WithUrlEncoding(1), __workflow_datasetid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var specification = new JObject();
                var specificationpropCount = 0;
                if (specificationpropCount > 0)
                {
                    callPayload.Body = specification;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction AddRows(Expression<Func<string>> groupid, Expression<Func<string>> datasetid, Expression<Func<string>> tablename, Expression<Func<object>> payload = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_datasetid = WorkflowExpression.Compile(datasetid, nameof(datasetid), required: true);
            var __workflow_tablename = WorkflowExpression.Compile(tablename, nameof(tablename), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/tables/{2}/rows", __workflow_groupid.WithUrlEncoding(1), __workflow_datasetid.WithUrlEncoding(1), __workflow_tablename.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction GoalValueCheckinNote(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin, Expression<Func<string>> note = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_goalCheckin = WorkflowExpression.Compile(goalCheckin, nameof(goalCheckin), required: true);
            var __workflow_note = WorkflowExpression.Compile(note, nameof(note), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})/notes", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1), __workflow_goalCheckin.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_note);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction GoalValueCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> checkindate, Expression<Func<double>> checkinvalue = null, Expression<Func<checkinstatusInput>> checkinstatus = null, Expression<Func<string>> checkinnote = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_checkindate = WorkflowExpression.Compile(checkindate, nameof(checkindate), required: true);
            var __workflow_checkinvalue = WorkflowExpression.Compile(checkinvalue, nameof(checkinvalue), required: false);
            var __workflow_checkinstatus = WorkflowExpression.Compile(checkinstatus, nameof(checkinstatus), required: false);
            var __workflow_checkinnote = WorkflowExpression.Compile(checkinnote, nameof(checkinnote), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var checkin = new JObject();
                var checkinpropCount = 0;
                checkinpropCount++;
                checkin["timestamp"] = ExpressionConverter.ConvertO(__workflow_checkindate);
                if (__workflow_checkinvalue != null)
                {
                    checkin["value"] = ExpressionConverter.ConvertO(__workflow_checkinvalue);
                    checkinpropCount++;
                }

                if (__workflow_checkinstatus != null)
                {
                    if (__workflow_checkinstatus != null)
                    {
                        checkin["status"] = ExpressionConverter.ConvertO(__workflow_checkinstatus);
                        checkinpropCount++;
                    }

                    checkinpropCount++;
                }
                else
                {
                    checkin["status"] = "Leave unchanged";
                    checkinpropCount++;
                }

                if (__workflow_checkinnote != null)
                {
                    checkin["note"] = ExpressionConverter.ConvertO(__workflow_checkinnote);
                    checkinpropCount++;
                }

                if (checkinpropCount > 0)
                {
                    callPayload.Body = checkin;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinsResponse> GetGoalCheckins(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<GetGoalCheckinsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("notes");
                return new ApiConnectionAction<GetGoalCheckinsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction UpdateGoalCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin, Expression<Func<double>> checkinvalue = null, Expression<Func<checkinstatusInput>> checkinstatus = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_goalCheckin = WorkflowExpression.Compile(goalCheckin, nameof(goalCheckin), required: true);
            var __workflow_checkinvalue = WorkflowExpression.Compile(checkinvalue, nameof(checkinvalue), required: false);
            var __workflow_checkinstatus = WorkflowExpression.Compile(checkinstatus, nameof(checkinstatus), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1), __workflow_goalCheckin.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var checkin = new JObject();
                var checkinpropCount = 0;
                if (__workflow_checkinvalue != null)
                {
                    checkin["value"] = ExpressionConverter.ConvertO(__workflow_checkinvalue);
                    checkinpropCount++;
                }

                if (__workflow_checkinstatus != null)
                {
                    if (__workflow_checkinstatus != null)
                    {
                        checkin["status"] = ExpressionConverter.ConvertO(__workflow_checkinstatus);
                        checkinpropCount++;
                    }

                    checkinpropCount++;
                }
                else
                {
                    checkin["status"] = "Leave unchanged";
                    checkinpropCount++;
                }

                if (checkinpropCount > 0)
                {
                    callPayload.Body = checkin;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinResponse> GetGoalCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_scorecardId = WorkflowExpression.Compile(scorecardId, nameof(scorecardId), required: true);
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            var __workflow_goalCheckin = WorkflowExpression.Compile(goalCheckin, nameof(goalCheckin), required: true);
            return new DeferredBodyAction<GetGoalCheckinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", __workflow_groupid.WithUrlEncoding(1), __workflow_scorecardId.WithUrlEncoding(1), __workflow_goalId.WithUrlEncoding(1), __workflow_goalCheckin.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("notes");
                return new ApiConnectionAction<GetGoalCheckinResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction RefreshDataset(Expression<Func<string>> groupid, Expression<Func<string>> datasetid)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_datasetid = WorkflowExpression.Compile(datasetid, nameof(datasetid), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/refreshes", __workflow_groupid.WithUrlEncoding(1), __workflow_datasetid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string> InitiateExportToFileForPbiReports(Expression<Func<string>> groupid, Expression<Func<string>> reportid, Expression<Func<exportPayloadPowerBIReportformatInput>> exportPayloadPowerBIReportformat, Expression<Func<string>> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale = null, Expression<Func<bool>> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages = null, Expression<Func<string>> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname = null, Expression<Func<string>> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate = null, Expression<Func<ExportFilter[]>> exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters = null, Expression<Func<ExportReportPage[]>> exportPayloadPowerBIReportpowerBIReportExportConfigurationpages = null, Expression<Func<EffectiveIdentity[]>> exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_reportid = WorkflowExpression.Compile(reportid, nameof(reportid), required: true);
            var __workflow_exportPayloadPowerBIReportformat = WorkflowExpression.Compile(exportPayloadPowerBIReportformat, nameof(exportPayloadPowerBIReportformat), required: true);
            var __workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale = WorkflowExpression.Compile(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale), required: false);
            var __workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages = WorkflowExpression.Compile(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages), required: false);
            var __workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname = WorkflowExpression.Compile(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname), required: false);
            var __workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate = WorkflowExpression.Compile(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate), required: false);
            var __workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters = WorkflowExpression.Compile(exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters), required: false);
            var __workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationpages = WorkflowExpression.Compile(exportPayloadPowerBIReportpowerBIReportExportConfigurationpages, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationpages), required: false);
            var __workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities = WorkflowExpression.Compile(exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportTo", __workflow_groupid.WithUrlEncoding(1), __workflow_reportid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exportPayloadPowerBIReport = new JObject();
                var exportPayloadPowerBIReportpropCount = 0;
                exportPayloadPowerBIReportpropCount++;
                exportPayloadPowerBIReport["format"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReportformat);
                var powerBIReportExportConfigurationObject = new JObject();
                var powerBIReportExportConfigurationObjectpropCount = 0;
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale != null)
                {
                    settingsObject["locale"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale);
                    settingsObjectpropCount++;
                }

                if (__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages != null)
                {
                    settingsObject["includeHiddenPages"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    powerBIReportExportConfigurationObject["settings"] = settingsObject;
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                var defaultBookmarkObject = new JObject();
                var defaultBookmarkObjectpropCount = 0;
                if (__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname != null)
                {
                    defaultBookmarkObject["name"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname);
                    defaultBookmarkObjectpropCount++;
                }

                if (__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate != null)
                {
                    defaultBookmarkObject["state"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate);
                    defaultBookmarkObjectpropCount++;
                }

                if (defaultBookmarkObjectpropCount > 0)
                {
                    powerBIReportExportConfigurationObject["defaultBookmark"] = defaultBookmarkObject;
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters != null)
                {
                    powerBIReportExportConfigurationObject["reportLevelFilters"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters);
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationpages != null)
                {
                    powerBIReportExportConfigurationObject["pages"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationpages);
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities != null)
                {
                    powerBIReportExportConfigurationObject["identities"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities);
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (powerBIReportExportConfigurationObjectpropCount > 0)
                {
                    exportPayloadPowerBIReport["PowerBIReportExportConfiguration"] = powerBIReportExportConfigurationObject;
                    exportPayloadPowerBIReportpropCount++;
                }

                if (exportPayloadPowerBIReportpropCount > 0)
                {
                    callPayload.Body = exportPayloadPowerBIReport;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string> InitiateExportToFileForPaginatedReports(Expression<Func<string>> groupid, Expression<Func<string>> reportid, Expression<Func<exportPayloadPaginatedReportformatInput>> exportPayloadPaginatedReportformat, Expression<Func<EffectiveIdentity[]>> exportPayloadPaginatedReportpaginatedReportConfigurationidentities = null, Expression<Func<exportPayloadPaginatedReportpaginatedReportConfigurationparameterValuesInputItem[]>> exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues = null)
        {
            var __workflow_groupid = WorkflowExpression.Compile(groupid, nameof(groupid), required: true);
            var __workflow_reportid = WorkflowExpression.Compile(reportid, nameof(reportid), required: true);
            var __workflow_exportPayloadPaginatedReportformat = WorkflowExpression.Compile(exportPayloadPaginatedReportformat, nameof(exportPayloadPaginatedReportformat), required: true);
            var __workflow_exportPayloadPaginatedReportpaginatedReportConfigurationidentities = WorkflowExpression.Compile(exportPayloadPaginatedReportpaginatedReportConfigurationidentities, nameof(exportPayloadPaginatedReportpaginatedReportConfigurationidentities), required: false);
            var __workflow_exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues = WorkflowExpression.Compile(exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues, nameof(exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportToPaginatedReports", __workflow_groupid.WithUrlEncoding(1), __workflow_reportid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exportPayloadPaginatedReport = new JObject();
                var exportPayloadPaginatedReportpropCount = 0;
                exportPayloadPaginatedReportpropCount++;
                exportPayloadPaginatedReport["format"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPaginatedReportformat);
                var paginatedReportConfigurationObject = new JObject();
                var paginatedReportConfigurationObjectpropCount = 0;
                if (__workflow_exportPayloadPaginatedReportpaginatedReportConfigurationidentities != null)
                {
                    paginatedReportConfigurationObject["identities"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPaginatedReportpaginatedReportConfigurationidentities);
                    paginatedReportConfigurationObjectpropCount++;
                }

                var formatSettingsObject = new JObject();
                var formatSettingsObjectpropCount = 0;
                if (formatSettingsObjectpropCount > 0)
                {
                    paginatedReportConfigurationObject["formatSettings"] = formatSettingsObject;
                    paginatedReportConfigurationObjectpropCount++;
                }

                if (__workflow_exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues != null)
                {
                    paginatedReportConfigurationObject["parameterValues"] = ExpressionConverter.ConvertO(__workflow_exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues);
                    paginatedReportConfigurationObjectpropCount++;
                }

                if (paginatedReportConfigurationObjectpropCount > 0)
                {
                    exportPayloadPaginatedReport["paginatedReportConfiguration"] = paginatedReportConfigurationObject;
                    exportPayloadPaginatedReportpropCount++;
                }

                if (exportPayloadPaginatedReportpropCount > 0)
                {
                    callPayload.Body = exportPayloadPaginatedReport;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum goalstatusInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum checkinstatusInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exportPayloadPowerBIReportformatInput
    {
        PDF,
        PPTX,
        PNG
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

    public class PageBookmark
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exportPayloadPaginatedReportformatInput
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

    public class exportPayloadPaginatedReportpaginatedReportConfigurationparameterValuesInputItem
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
