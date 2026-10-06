//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerbi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerbiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildGetScorecards))]
        public IBodyWorkflowAction<ListedScorecards> GetScorecards([WorkflowExpression] Func<string> groupid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListedScorecards> __BuildGetScorecards(WorkflowExpression<string> groupid)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            return new DeferredBodyAction<ListedScorecards>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction<ListedScorecards>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildCreateScorecard))]
        public IBodyWorkflowAction<CreatedScorecard> CreateScorecard([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardname, [WorkflowExpression] Func<string> scorecarddescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatedScorecard> __BuildCreateScorecard(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardname, WorkflowExpression<string> scorecarddescription = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardname, nameof(scorecardname), required: true);
            WorkflowExpression.Validate(scorecarddescription, nameof(scorecarddescription), required: false);
            return new DeferredBodyAction<CreatedScorecard>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var scorecard = new JObject();
                var scorecardpropCount = 0;
                scorecardpropCount++;
                scorecard["name"] = ExpressionConverter.ConvertO(scorecardname);
                if (scorecarddescription != null)
                {
                    scorecard["description"] = ExpressionConverter.ConvertO(scorecarddescription);
                    scorecardpropCount++;
                }

                if (scorecardpropCount > 0)
                {
                    callPayload.Body = scorecard;
                }

                return new ApiConnectionAction<CreatedScorecard>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildGetMultipleGoals))]
        public IBodyWorkflowAction<FetchedGoals> GetMultipleGoals([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchedGoals> __BuildGetMultipleGoals(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            return new DeferredBodyAction<FetchedGoals>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("aggregations");
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction<FetchedGoals>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildCreateGoal))]
        public IBodyWorkflowAction<CreateGoalResponse> CreateGoal([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalname, [WorkflowExpression] Func<string> goalowner = null, [WorkflowExpression] Func<string> goalcurrentValue = null, [WorkflowExpression] Func<string> goaltargetValue = null, [WorkflowExpression] Func<goalstatusInput> goalstatus = null, [WorkflowExpression] Func<string> goalstartDate = null, [WorkflowExpression] Func<string> goalcompletionDate = null, [WorkflowExpression] Func<string> goalnote = null, [WorkflowExpression] Func<string> goalparentGoalId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateGoalResponse> __BuildCreateGoal(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId, WorkflowExpression<string> goalname, WorkflowExpression<string> goalowner = null, WorkflowExpression<string> goalcurrentValue = null, WorkflowExpression<string> goaltargetValue = null, WorkflowExpression<goalstatusInput> goalstatus = null, WorkflowExpression<string> goalstartDate = null, WorkflowExpression<string> goalcompletionDate = null, WorkflowExpression<string> goalnote = null, WorkflowExpression<string> goalparentGoalId = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            WorkflowExpression.Validate(goalname, nameof(goalname), required: true);
            WorkflowExpression.Validate(goalowner, nameof(goalowner), required: false);
            WorkflowExpression.Validate(goalcurrentValue, nameof(goalcurrentValue), required: false);
            WorkflowExpression.Validate(goaltargetValue, nameof(goaltargetValue), required: false);
            WorkflowExpression.Validate(goalstatus, nameof(goalstatus), required: false);
            WorkflowExpression.Validate(goalstartDate, nameof(goalstartDate), required: false);
            WorkflowExpression.Validate(goalcompletionDate, nameof(goalcompletionDate), required: false);
            WorkflowExpression.Validate(goalnote, nameof(goalnote), required: false);
            WorkflowExpression.Validate(goalparentGoalId, nameof(goalparentGoalId), required: false);
            return new DeferredBodyAction<CreateGoalResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var goal = new JObject();
                var goalpropCount = 0;
                goalpropCount++;
                goal["name"] = ExpressionConverter.ConvertO(goalname);
                if (goalowner != null)
                {
                    goal["owner"] = ExpressionConverter.ConvertO(goalowner);
                    goalpropCount++;
                }

                if (goalcurrentValue != null)
                {
                    goal["value"] = ExpressionConverter.ConvertO(goalcurrentValue);
                    goalpropCount++;
                }

                if (goaltargetValue != null)
                {
                    goal["target"] = ExpressionConverter.ConvertO(goaltargetValue);
                    goalpropCount++;
                }

                if (goalstatus != null)
                {
                    if (goalstatus != null)
                    {
                        goal["status"] = ExpressionConverter.ConvertO(goalstatus);
                        goalpropCount++;
                    }

                    goalpropCount++;
                }
                else
                {
                    goal["status"] = "Not started";
                    goalpropCount++;
                }

                if (goalstartDate != null)
                {
                    goal["startDate"] = ExpressionConverter.ConvertO(goalstartDate);
                    goalpropCount++;
                }

                if (goalcompletionDate != null)
                {
                    goal["completionDate"] = ExpressionConverter.ConvertO(goalcompletionDate);
                    goalpropCount++;
                }

                if (goalnote != null)
                {
                    goal["note"] = ExpressionConverter.ConvertO(goalnote);
                    goalpropCount++;
                }

                if (goalparentGoalId != null)
                {
                    goal["parentId"] = ExpressionConverter.ConvertO(goalparentGoalId);
                    goalpropCount++;
                }

                if (goalpropCount > 0)
                {
                    callPayload.Body = goal;
                }

                return new ApiConnectionAction<CreateGoalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildGetGoal))]
        public IBodyWorkflowAction<FetchedGoal> GetGoal([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchedGoal> __BuildGetGoal(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId, WorkflowExpression<string> goalId)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            WorkflowExpression.Validate(goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<FetchedGoal>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("aggregations");
                return new ApiConnectionAction<FetchedGoal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateGoal))]
        public IWorkflowAction UpdateGoal([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalname = null, [WorkflowExpression] Func<string> goalowner = null, [WorkflowExpression] Func<double> goalcurrentValue = null, [WorkflowExpression] Func<double> goaltargetValue = null, [WorkflowExpression] Func<goalstatusInput> goalstatus = null, [WorkflowExpression] Func<string> goalstartDate = null, [WorkflowExpression] Func<string> goalcompletionDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateGoal(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId, WorkflowExpression<string> goalId, WorkflowExpression<string> goalname = null, WorkflowExpression<string> goalowner = null, WorkflowExpression<double> goalcurrentValue = null, WorkflowExpression<double> goaltargetValue = null, WorkflowExpression<goalstatusInput> goalstatus = null, WorkflowExpression<string> goalstartDate = null, WorkflowExpression<string> goalcompletionDate = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            WorkflowExpression.Validate(goalId, nameof(goalId), required: true);
            WorkflowExpression.Validate(goalname, nameof(goalname), required: false);
            WorkflowExpression.Validate(goalowner, nameof(goalowner), required: false);
            WorkflowExpression.Validate(goalcurrentValue, nameof(goalcurrentValue), required: false);
            WorkflowExpression.Validate(goaltargetValue, nameof(goaltargetValue), required: false);
            WorkflowExpression.Validate(goalstatus, nameof(goalstatus), required: false);
            WorkflowExpression.Validate(goalstartDate, nameof(goalstartDate), required: false);
            WorkflowExpression.Validate(goalcompletionDate, nameof(goalcompletionDate), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var goal = new JObject();
                var goalpropCount = 0;
                if (goalname != null)
                {
                    goal["name"] = ExpressionConverter.ConvertO(goalname);
                    goalpropCount++;
                }

                if (goalowner != null)
                {
                    goal["owner"] = ExpressionConverter.ConvertO(goalowner);
                    goalpropCount++;
                }

                if (goalcurrentValue != null)
                {
                    goal["value"] = ExpressionConverter.ConvertO(goalcurrentValue);
                    goalpropCount++;
                }

                if (goaltargetValue != null)
                {
                    goal["target"] = ExpressionConverter.ConvertO(goaltargetValue);
                    goalpropCount++;
                }

                if (goalstatus != null)
                {
                    if (goalstatus != null)
                    {
                        goal["status"] = ExpressionConverter.ConvertO(goalstatus);
                        goalpropCount++;
                    }

                    goalpropCount++;
                }
                else
                {
                    goal["status"] = "Leave unchanged";
                    goalpropCount++;
                }

                if (goalstartDate != null)
                {
                    goal["startDate"] = ExpressionConverter.ConvertO(goalstartDate);
                    goalpropCount++;
                }

                if (goalcompletionDate != null)
                {
                    goal["completionDate"] = ExpressionConverter.ConvertO(goalcompletionDate);
                    goalpropCount++;
                }

                if (goalpropCount > 0)
                {
                    callPayload.Body = goal;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteDatasetQuery))]
        public IBodyWorkflowAction<QueryExecutionResults> ExecuteDatasetQuery([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> datasetid, [WorkflowExpression] Func<string> specificationqueryText, [WorkflowExpression] Func<bool> specificationserializerSettingsnullsIncluded = null, [WorkflowExpression] Func<string> specificationimpersonateUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryExecutionResults> __BuildExecuteDatasetQuery(WorkflowExpression<string> groupid, WorkflowExpression<string> datasetid, WorkflowExpression<string> specificationqueryText, WorkflowExpression<bool> specificationserializerSettingsnullsIncluded = null, WorkflowExpression<string> specificationimpersonateUser = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(datasetid, nameof(datasetid), required: true);
            WorkflowExpression.Validate(specificationqueryText, nameof(specificationqueryText), required: true);
            WorkflowExpression.Validate(specificationserializerSettingsnullsIncluded, nameof(specificationserializerSettingsnullsIncluded), required: false);
            WorkflowExpression.Validate(specificationimpersonateUser, nameof(specificationimpersonateUser), required: false);
            return new DeferredBodyAction<QueryExecutionResults>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var specification = new JObject();
                var specificationpropCount = 0;
                specificationpropCount++;
                specification["query"] = ExpressionConverter.ConvertO(specificationqueryText);
                var serializerSettingsObject = new JObject();
                var serializerSettingsObjectpropCount = 0;
                if (specificationserializerSettingsnullsIncluded != null)
                {
                    if (specificationserializerSettingsnullsIncluded != null)
                    {
                        serializerSettingsObject["includeNulls"] = ExpressionConverter.ConvertO(specificationserializerSettingsnullsIncluded);
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

                if (specificationimpersonateUser != null)
                {
                    specification["impersonatedUserName"] = ExpressionConverter.ConvertO(specificationimpersonateUser);
                    specificationpropCount++;
                }

                if (specificationpropCount > 0)
                {
                    callPayload.Body = specification;
                }

                return new ApiConnectionAction<QueryExecutionResults>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteDatasetQueriesJson))]
        public IBodyWorkflowAction<JToken> ExecuteDatasetQueriesJson([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> datasetid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecuteDatasetQueriesJson(WorkflowExpression<string> groupid, WorkflowExpression<string> datasetid)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(datasetid, nameof(datasetid), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/internalFlowActionOverloadAsJson/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetid, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildAddRows))]
        public IWorkflowAction AddRows([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> datasetid, [WorkflowExpression] Func<string> tablename, [WorkflowExpression] Func<object> payload = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddRows(WorkflowExpression<string> groupid, WorkflowExpression<string> datasetid, WorkflowExpression<string> tablename, WorkflowExpression<object> payload = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(datasetid, nameof(datasetid), required: true);
            WorkflowExpression.Validate(tablename, nameof(tablename), required: true);
            WorkflowExpression.Validate(payload, nameof(payload), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/tables/{2}/rows", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetid, 1), ExpressionConverter.ConvertWithUrlEncoding(tablename, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(payload);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildGoalValueCheckinNote))]
        public IWorkflowAction GoalValueCheckinNote([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin, [WorkflowExpression] Func<string> note = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGoalValueCheckinNote(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId, WorkflowExpression<string> goalId, WorkflowExpression<string> goalCheckin, WorkflowExpression<string> note = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            WorkflowExpression.Validate(goalId, nameof(goalId), required: true);
            WorkflowExpression.Validate(goalCheckin, nameof(goalCheckin), required: true);
            WorkflowExpression.Validate(note, nameof(note), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})/notes", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalCheckin, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(note);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildGoalValueCheckin))]
        public IWorkflowAction GoalValueCheckin([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> checkindate, [WorkflowExpression] Func<double> checkinvalue = null, [WorkflowExpression] Func<checkinstatusInput> checkinstatus = null, [WorkflowExpression] Func<string> checkinnote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGoalValueCheckin(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId, WorkflowExpression<string> goalId, WorkflowExpression<string> checkindate, WorkflowExpression<double> checkinvalue = null, WorkflowExpression<checkinstatusInput> checkinstatus = null, WorkflowExpression<string> checkinnote = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            WorkflowExpression.Validate(goalId, nameof(goalId), required: true);
            WorkflowExpression.Validate(checkindate, nameof(checkindate), required: true);
            WorkflowExpression.Validate(checkinvalue, nameof(checkinvalue), required: false);
            WorkflowExpression.Validate(checkinstatus, nameof(checkinstatus), required: false);
            WorkflowExpression.Validate(checkinnote, nameof(checkinnote), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var checkin = new JObject();
                var checkinpropCount = 0;
                checkinpropCount++;
                checkin["timestamp"] = ExpressionConverter.ConvertO(checkindate);
                if (checkinvalue != null)
                {
                    checkin["value"] = ExpressionConverter.ConvertO(checkinvalue);
                    checkinpropCount++;
                }

                if (checkinstatus != null)
                {
                    if (checkinstatus != null)
                    {
                        checkin["status"] = ExpressionConverter.ConvertO(checkinstatus);
                        checkinpropCount++;
                    }

                    checkinpropCount++;
                }
                else
                {
                    checkin["status"] = "Leave unchanged";
                    checkinpropCount++;
                }

                if (checkinnote != null)
                {
                    checkin["note"] = ExpressionConverter.ConvertO(checkinnote);
                    checkinpropCount++;
                }

                if (checkinpropCount > 0)
                {
                    callPayload.Body = checkin;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildGetGoalCheckins))]
        public IBodyWorkflowAction<GetGoalCheckinsResponse> GetGoalCheckins([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGoalCheckinsResponse> __BuildGetGoalCheckins(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId, WorkflowExpression<string> goalId)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            WorkflowExpression.Validate(goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<GetGoalCheckinsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("notes");
                return new ApiConnectionAction<GetGoalCheckinsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateGoalCheckin))]
        public IWorkflowAction UpdateGoalCheckin([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin, [WorkflowExpression] Func<double> checkinvalue = null, [WorkflowExpression] Func<checkinstatusInput> checkinstatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateGoalCheckin(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId, WorkflowExpression<string> goalId, WorkflowExpression<string> goalCheckin, WorkflowExpression<double> checkinvalue = null, WorkflowExpression<checkinstatusInput> checkinstatus = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            WorkflowExpression.Validate(goalId, nameof(goalId), required: true);
            WorkflowExpression.Validate(goalCheckin, nameof(goalCheckin), required: true);
            WorkflowExpression.Validate(checkinvalue, nameof(checkinvalue), required: false);
            WorkflowExpression.Validate(checkinstatus, nameof(checkinstatus), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalCheckin, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var checkin = new JObject();
                var checkinpropCount = 0;
                if (checkinvalue != null)
                {
                    checkin["value"] = ExpressionConverter.ConvertO(checkinvalue);
                    checkinpropCount++;
                }

                if (checkinstatus != null)
                {
                    if (checkinstatus != null)
                    {
                        checkin["status"] = ExpressionConverter.ConvertO(checkinstatus);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildGetGoalCheckin))]
        public IBodyWorkflowAction<GetGoalCheckinResponse> GetGoalCheckin([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGoalCheckinResponse> __BuildGetGoalCheckin(WorkflowExpression<string> groupid, WorkflowExpression<string> scorecardId, WorkflowExpression<string> goalId, WorkflowExpression<string> goalCheckin)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(scorecardId, nameof(scorecardId), required: true);
            WorkflowExpression.Validate(goalId, nameof(goalId), required: true);
            WorkflowExpression.Validate(goalCheckin, nameof(goalCheckin), required: true);
            return new DeferredBodyAction<GetGoalCheckinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalCheckin, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("notes");
                return new ApiConnectionAction<GetGoalCheckinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildRefreshDataset))]
        public IWorkflowAction RefreshDataset([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> datasetid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRefreshDataset(WorkflowExpression<string> groupid, WorkflowExpression<string> datasetid)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(datasetid, nameof(datasetid), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/refreshes", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildInitiateExportToFileForPbiReports))]
        public IBodyWorkflowAction<string> InitiateExportToFileForPbiReports([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> reportid, [WorkflowExpression] Func<exportPayloadPowerBIReportformatInput> exportPayloadPowerBIReportformat, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale = null, [WorkflowExpression] Func<bool> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages = null, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname = null, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate = null, [WorkflowExpression] Func<ExportFilter[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters = null, [WorkflowExpression] Func<ExportReportPage[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationpages = null, [WorkflowExpression] Func<EffectiveIdentity[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildInitiateExportToFileForPbiReports(WorkflowExpression<string> groupid, WorkflowExpression<string> reportid, WorkflowExpression<exportPayloadPowerBIReportformatInput> exportPayloadPowerBIReportformat, WorkflowExpression<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale = null, WorkflowExpression<bool> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages = null, WorkflowExpression<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname = null, WorkflowExpression<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate = null, WorkflowExpression<ExportFilter[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters = null, WorkflowExpression<ExportReportPage[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationpages = null, WorkflowExpression<EffectiveIdentity[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(reportid, nameof(reportid), required: true);
            WorkflowExpression.Validate(exportPayloadPowerBIReportformat, nameof(exportPayloadPowerBIReportformat), required: true);
            WorkflowExpression.Validate(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale), required: false);
            WorkflowExpression.Validate(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages), required: false);
            WorkflowExpression.Validate(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname), required: false);
            WorkflowExpression.Validate(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate), required: false);
            WorkflowExpression.Validate(exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters), required: false);
            WorkflowExpression.Validate(exportPayloadPowerBIReportpowerBIReportExportConfigurationpages, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationpages), required: false);
            WorkflowExpression.Validate(exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities, nameof(exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportTo", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(reportid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exportPayloadPowerBIReport = new JObject();
                var exportPayloadPowerBIReportpropCount = 0;
                exportPayloadPowerBIReportpropCount++;
                exportPayloadPowerBIReport["format"] = ExpressionConverter.ConvertO(exportPayloadPowerBIReportformat);
                var powerBIReportExportConfigurationObject = new JObject();
                var powerBIReportExportConfigurationObjectpropCount = 0;
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale != null)
                {
                    settingsObject["locale"] = ExpressionConverter.ConvertO(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale);
                    settingsObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages != null)
                {
                    settingsObject["includeHiddenPages"] = ExpressionConverter.ConvertO(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    powerBIReportExportConfigurationObject["settings"] = settingsObject;
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                var defaultBookmarkObject = new JObject();
                var defaultBookmarkObjectpropCount = 0;
                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname != null)
                {
                    defaultBookmarkObject["name"] = ExpressionConverter.ConvertO(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname);
                    defaultBookmarkObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate != null)
                {
                    defaultBookmarkObject["state"] = ExpressionConverter.ConvertO(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate);
                    defaultBookmarkObjectpropCount++;
                }

                if (defaultBookmarkObjectpropCount > 0)
                {
                    powerBIReportExportConfigurationObject["defaultBookmark"] = defaultBookmarkObject;
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters != null)
                {
                    powerBIReportExportConfigurationObject["reportLevelFilters"] = ExpressionConverter.ConvertO(exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters);
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationpages != null)
                {
                    powerBIReportExportConfigurationObject["pages"] = ExpressionConverter.ConvertO(exportPayloadPowerBIReportpowerBIReportExportConfigurationpages);
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities != null)
                {
                    powerBIReportExportConfigurationObject["identities"] = ExpressionConverter.ConvertO(exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [WorkflowExpressionFactory(nameof(__BuildInitiateExportToFileForPaginatedReports))]
        public IBodyWorkflowAction<string> InitiateExportToFileForPaginatedReports([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> reportid, [WorkflowExpression] Func<exportPayloadPaginatedReportformatInput> exportPayloadPaginatedReportformat, [WorkflowExpression] Func<EffectiveIdentity[]> exportPayloadPaginatedReportpaginatedReportConfigurationidentities = null, [WorkflowExpression] Func<exportPayloadPaginatedReportpaginatedReportConfigurationparameterValuesInputItem[]> exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildInitiateExportToFileForPaginatedReports(WorkflowExpression<string> groupid, WorkflowExpression<string> reportid, WorkflowExpression<exportPayloadPaginatedReportformatInput> exportPayloadPaginatedReportformat, WorkflowExpression<EffectiveIdentity[]> exportPayloadPaginatedReportpaginatedReportConfigurationidentities = null, WorkflowExpression<exportPayloadPaginatedReportpaginatedReportConfigurationparameterValuesInputItem[]> exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues = null)
        {
            WorkflowExpression.Validate(groupid, nameof(groupid), required: true);
            WorkflowExpression.Validate(reportid, nameof(reportid), required: true);
            WorkflowExpression.Validate(exportPayloadPaginatedReportformat, nameof(exportPayloadPaginatedReportformat), required: true);
            WorkflowExpression.Validate(exportPayloadPaginatedReportpaginatedReportConfigurationidentities, nameof(exportPayloadPaginatedReportpaginatedReportConfigurationidentities), required: false);
            WorkflowExpression.Validate(exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues, nameof(exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportToPaginatedReports", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(reportid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exportPayloadPaginatedReport = new JObject();
                var exportPayloadPaginatedReportpropCount = 0;
                exportPayloadPaginatedReportpropCount++;
                exportPayloadPaginatedReport["format"] = ExpressionConverter.ConvertO(exportPayloadPaginatedReportformat);
                var paginatedReportConfigurationObject = new JObject();
                var paginatedReportConfigurationObjectpropCount = 0;
                if (exportPayloadPaginatedReportpaginatedReportConfigurationidentities != null)
                {
                    paginatedReportConfigurationObject["identities"] = ExpressionConverter.ConvertO(exportPayloadPaginatedReportpaginatedReportConfigurationidentities);
                    paginatedReportConfigurationObjectpropCount++;
                }

                var formatSettingsObject = new JObject();
                var formatSettingsObjectpropCount = 0;
                if (formatSettingsObjectpropCount > 0)
                {
                    paginatedReportConfigurationObject["formatSettings"] = formatSettingsObject;
                    paginatedReportConfigurationObjectpropCount++;
                }

                if (exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues != null)
                {
                    paginatedReportConfigurationObject["parameterValues"] = ExpressionConverter.ConvertO(exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues);
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