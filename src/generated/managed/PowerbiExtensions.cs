//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerbi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerbiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<ListedScorecards> GetScorecards([WorkflowExpression] Func<string> groupid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return callPayload;
            }

            return new ApiConnectionAction<ListedScorecards>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreatedScorecard> CreateScorecard([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardname, [WorkflowExpression] Func<string> scorecarddescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var scorecard = new JObject();
                var scorecardpropCount = 0;
                scorecardpropCount++;
                scorecard["name"] = SourceExpressionConverter.ConvertToken(scorecardname);
                if (scorecarddescription != null)
                {
                    scorecard["description"] = SourceExpressionConverter.ConvertToken(scorecarddescription);
                    scorecardpropCount++;
                }

                if (scorecardpropCount > 0)
                {
                    callPayload.Body = scorecard;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreatedScorecard>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoals> GetMultipleGoals([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("aggregations");
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return callPayload;
            }

            return new ApiConnectionAction<FetchedGoals>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreateGoalResponse> CreateGoal([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalname, [WorkflowExpression] Func<string> goalowner = null, [WorkflowExpression] Func<string> goalcurrentValue = null, [WorkflowExpression] Func<string> goaltargetValue = null, [WorkflowExpression] Func<goalstatusInput> goalstatus = null, [WorkflowExpression] Func<string> goalstartDate = null, [WorkflowExpression] Func<string> goalcompletionDate = null, [WorkflowExpression] Func<string> goalnote = null, [WorkflowExpression] Func<string> goalparentGoalId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var goal = new JObject();
                var goalpropCount = 0;
                goalpropCount++;
                goal["name"] = SourceExpressionConverter.ConvertToken(goalname);
                if (goalowner != null)
                {
                    goal["owner"] = SourceExpressionConverter.ConvertToken(goalowner);
                    goalpropCount++;
                }

                if (goalcurrentValue != null)
                {
                    goal["value"] = SourceExpressionConverter.ConvertToken(goalcurrentValue);
                    goalpropCount++;
                }

                if (goaltargetValue != null)
                {
                    goal["target"] = SourceExpressionConverter.ConvertToken(goaltargetValue);
                    goalpropCount++;
                }

                if (goalstatus != null)
                {
                    if (goalstatus != null)
                    {
                        goal["status"] = SourceExpressionConverter.Convert(goalstatus);
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
                    goal["startDate"] = SourceExpressionConverter.ConvertToken(goalstartDate);
                    goalpropCount++;
                }

                if (goalcompletionDate != null)
                {
                    goal["completionDate"] = SourceExpressionConverter.ConvertToken(goalcompletionDate);
                    goalpropCount++;
                }

                if (goalnote != null)
                {
                    goal["note"] = SourceExpressionConverter.ConvertToken(goalnote);
                    goalpropCount++;
                }

                if (goalparentGoalId != null)
                {
                    goal["parentId"] = SourceExpressionConverter.ConvertToken(goalparentGoalId);
                    goalpropCount++;
                }

                if (goalpropCount > 0)
                {
                    callPayload.Body = goal;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateGoalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoal> GetGoal([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("aggregations");
                return callPayload;
            }

            return new ApiConnectionAction<FetchedGoal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction UpdateGoal([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalname = null, [WorkflowExpression] Func<string> goalowner = null, [WorkflowExpression] Func<double> goalcurrentValue = null, [WorkflowExpression] Func<double> goaltargetValue = null, [WorkflowExpression] Func<goalstatusInput> goalstatus = null, [WorkflowExpression] Func<string> goalstartDate = null, [WorkflowExpression] Func<string> goalcompletionDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var goal = new JObject();
                var goalpropCount = 0;
                if (goalname != null)
                {
                    goal["name"] = SourceExpressionConverter.ConvertToken(goalname);
                    goalpropCount++;
                }

                if (goalowner != null)
                {
                    goal["owner"] = SourceExpressionConverter.ConvertToken(goalowner);
                    goalpropCount++;
                }

                if (goalcurrentValue != null)
                {
                    goal["value"] = SourceExpressionConverter.ConvertToken(goalcurrentValue);
                    goalpropCount++;
                }

                if (goaltargetValue != null)
                {
                    goal["target"] = SourceExpressionConverter.ConvertToken(goaltargetValue);
                    goalpropCount++;
                }

                if (goalstatus != null)
                {
                    if (goalstatus != null)
                    {
                        goal["status"] = SourceExpressionConverter.Convert(goalstatus);
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
                    goal["startDate"] = SourceExpressionConverter.ConvertToken(goalstartDate);
                    goalpropCount++;
                }

                if (goalcompletionDate != null)
                {
                    goal["completionDate"] = SourceExpressionConverter.ConvertToken(goalcompletionDate);
                    goalpropCount++;
                }

                if (goalpropCount > 0)
                {
                    callPayload.Body = goal;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<QueryExecutionResults> ExecuteDatasetQuery([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> datasetid, [WorkflowExpression] Func<string> specificationqueryText, [WorkflowExpression] Func<bool> specificationserializerSettingsnullsIncluded = null, [WorkflowExpression] Func<string> specificationimpersonateUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var specification = new JObject();
                var specificationpropCount = 0;
                specificationpropCount++;
                specification["query"] = SourceExpressionConverter.ConvertToken(specificationqueryText);
                var serializerSettingsObject = new JObject();
                var serializerSettingsObjectpropCount = 0;
                if (specificationserializerSettingsnullsIncluded != null)
                {
                    if (specificationserializerSettingsnullsIncluded != null)
                    {
                        serializerSettingsObject["includeNulls"] = SourceExpressionConverter.ConvertToken(specificationserializerSettingsnullsIncluded);
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
                    specification["impersonatedUserName"] = SourceExpressionConverter.ConvertToken(specificationimpersonateUser);
                    specificationpropCount++;
                }

                if (specificationpropCount > 0)
                {
                    callPayload.Body = specification;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryExecutionResults>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<JToken> ExecuteDatasetQueriesJson([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> datasetid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/internalFlowActionOverloadAsJson/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var specification = new JObject();
                var specificationpropCount = 0;
                if (specificationpropCount > 0)
                {
                    callPayload.Body = specification;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction AddRows([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> datasetid, [WorkflowExpression] Func<string> tablename, [WorkflowExpression] Func<object> payload = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/tables/{2}/rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tablename, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = SourceExpressionConverter.ConvertToken(payload);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction GoalValueCheckinNote([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin, [WorkflowExpression] Func<string> note = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})/notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalCheckin, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Body = SourceExpressionConverter.ConvertToken(note);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction GoalValueCheckin([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> checkindate, [WorkflowExpression] Func<double> checkinvalue = null, [WorkflowExpression] Func<checkinstatusInput> checkinstatus = null, [WorkflowExpression] Func<string> checkinnote = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var checkin = new JObject();
                var checkinpropCount = 0;
                checkinpropCount++;
                checkin["timestamp"] = SourceExpressionConverter.ConvertToken(checkindate);
                if (checkinvalue != null)
                {
                    checkin["value"] = SourceExpressionConverter.ConvertToken(checkinvalue);
                    checkinpropCount++;
                }

                if (checkinstatus != null)
                {
                    if (checkinstatus != null)
                    {
                        checkin["status"] = SourceExpressionConverter.Convert(checkinstatus);
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
                    checkin["note"] = SourceExpressionConverter.ConvertToken(checkinnote);
                    checkinpropCount++;
                }

                if (checkinpropCount > 0)
                {
                    callPayload.Body = checkin;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinsResponse> GetGoalCheckins([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("notes");
                return callPayload;
            }

            return new ApiConnectionAction<GetGoalCheckinsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction UpdateGoalCheckin([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin, [WorkflowExpression] Func<double> checkinvalue = null, [WorkflowExpression] Func<checkinstatusInput> checkinstatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalCheckin, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                var checkin = new JObject();
                var checkinpropCount = 0;
                if (checkinvalue != null)
                {
                    checkin["value"] = SourceExpressionConverter.ConvertToken(checkinvalue);
                    checkinpropCount++;
                }

                if (checkinstatus != null)
                {
                    if (checkinstatus != null)
                    {
                        checkin["status"] = SourceExpressionConverter.Convert(checkinstatus);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinResponse> GetGoalCheckin([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalCheckin, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                callPayload.Queries["$expand"] = Convert.ToString("notes");
                return callPayload;
            }

            return new ApiConnectionAction<GetGoalCheckinResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction RefreshDataset([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> datasetid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/refreshes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string> InitiateExportToFileForPbiReports([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> reportid, [WorkflowExpression] Func<exportPayloadPowerBIReportformatInput> exportPayloadPowerBIReportformat, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale = null, [WorkflowExpression] Func<bool> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages = null, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname = null, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate = null, [WorkflowExpression] Func<ExportFilter[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters = null, [WorkflowExpression] Func<ExportReportPage[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationpages = null, [WorkflowExpression] Func<EffectiveIdentity[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportTo", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exportPayloadPowerBIReport = new JObject();
                var exportPayloadPowerBIReportpropCount = 0;
                exportPayloadPowerBIReportpropCount++;
                exportPayloadPowerBIReport["format"] = SourceExpressionConverter.Convert(exportPayloadPowerBIReportformat);
                var powerBIReportExportConfigurationObject = new JObject();
                var powerBIReportExportConfigurationObjectpropCount = 0;
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale != null)
                {
                    settingsObject["locale"] = SourceExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale);
                    settingsObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages != null)
                {
                    settingsObject["includeHiddenPages"] = SourceExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages);
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
                    defaultBookmarkObject["name"] = SourceExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname);
                    defaultBookmarkObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate != null)
                {
                    defaultBookmarkObject["state"] = SourceExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate);
                    defaultBookmarkObjectpropCount++;
                }

                if (defaultBookmarkObjectpropCount > 0)
                {
                    powerBIReportExportConfigurationObject["defaultBookmark"] = defaultBookmarkObject;
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters != null)
                {
                    powerBIReportExportConfigurationObject["reportLevelFilters"] = SourceExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters);
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationpages != null)
                {
                    powerBIReportExportConfigurationObject["pages"] = SourceExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationpages);
                    powerBIReportExportConfigurationObjectpropCount++;
                }

                if (exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities != null)
                {
                    powerBIReportExportConfigurationObject["identities"] = SourceExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string> InitiateExportToFileForPaginatedReports([WorkflowExpression] Func<string> groupid, [WorkflowExpression] Func<string> reportid, [WorkflowExpression] Func<exportPayloadPaginatedReportformatInput> exportPayloadPaginatedReportformat, [WorkflowExpression] Func<EffectiveIdentity[]> exportPayloadPaginatedReportpaginatedReportConfigurationidentities = null, [WorkflowExpression] Func<exportPayloadPaginatedReportpaginatedReportConfigurationparameterValuesInputItem[]> exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportToPaginatedReports", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exportPayloadPaginatedReport = new JObject();
                var exportPayloadPaginatedReportpropCount = 0;
                exportPayloadPaginatedReportpropCount++;
                exportPayloadPaginatedReport["format"] = SourceExpressionConverter.Convert(exportPayloadPaginatedReportformat);
                var paginatedReportConfigurationObject = new JObject();
                var paginatedReportConfigurationObjectpropCount = 0;
                if (exportPayloadPaginatedReportpaginatedReportConfigurationidentities != null)
                {
                    paginatedReportConfigurationObject["identities"] = SourceExpressionConverter.ConvertToken(exportPayloadPaginatedReportpaginatedReportConfigurationidentities);
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
                    paginatedReportConfigurationObject["parameterValues"] = SourceExpressionConverter.ConvertToken(exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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