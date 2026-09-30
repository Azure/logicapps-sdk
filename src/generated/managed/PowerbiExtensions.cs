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
        public IBodyWorkflowAction<ListedScorecards> GetScorecards([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid)
        {
            var apiCallPath = String.Format("/v1.0/myOrg/groups/{0}/internalScorecards", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            return new ApiConnectionAction<ListedScorecards>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreatedScorecard> CreateScorecard([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression] Func<string> scorecardname, [WorkflowExpression] Func<string> scorecarddescription = null)
        {
            var apiCallPath = String.Format("/v1.0/myOrg/groups/{0}/internalScorecards", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoals> GetMultipleGoals([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId)
        {
            var apiCallPath = String.Format("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$expand"] = Convert.ToString("aggregations");
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            return new ApiConnectionAction<FetchedGoals>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreateGoalResponse> CreateGoal([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression] Func<string> scorecardId, [WorkflowExpression] Func<string> goalname, [WorkflowExpression] Func<string> goalowner = null, [WorkflowExpression] Func<string> goalcurrentValue = null, [WorkflowExpression] Func<string> goaltargetValue = null, [WorkflowExpression] Func<goalstatusInput> goalstatus = null, [WorkflowExpression] Func<string> goalstartDate = null, [WorkflowExpression] Func<string> goalcompletionDate = null, [WorkflowExpression] Func<string> goalnote = null, [WorkflowExpression] Func<string> goalparentGoalId = null)
        {
            var apiCallPath = String.Format("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoal> GetGoal([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId)
        {
            var apiCallPath = String.Format("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Queries["$expand"] = Convert.ToString("aggregations");
            return new ApiConnectionAction<FetchedGoal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction UpdateGoal([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> goalname = null, [WorkflowExpression] Func<string> goalowner = null, [WorkflowExpression] Func<double> goalcurrentValue = null, [WorkflowExpression] Func<double> goaltargetValue = null, [WorkflowExpression] Func<goalstatusInput> goalstatus = null, [WorkflowExpression] Func<string> goalstartDate = null, [WorkflowExpression] Func<string> goalcompletionDate = null)
        {
            var apiCallPath = String.Format("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<QueryExecutionResults> ExecuteDatasetQuery([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> datasetid, [WorkflowExpression] Func<string> specificationqueryText, [WorkflowExpression] Func<bool> specificationserializerSettingsnullsIncluded = null, [WorkflowExpression] Func<string> specificationimpersonateUser = null)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetid, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<JToken> ExecuteDatasetQueriesJson([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> datasetid)
        {
            var apiCallPath = String.Format("/internalFlowActionOverloadAsJson/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetid, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction AddRows([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> datasetid, [WorkflowExpression] Func<string> tablename, [WorkflowExpression] Func<object> payload = null)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/datasets/{1}/tables/{2}/rows", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetid, 1), ExpressionConverter.ConvertWithUrlEncoding(tablename, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Body = ExpressionConverter.ConvertO(payload);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction GoalValueCheckinNote([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scorecardId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin, [WorkflowExpression] Func<string> note = null)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})/notes", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalCheckin, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Body = ExpressionConverter.ConvertO(note);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction GoalValueCheckin([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId, [WorkflowExpression] Func<string> checkindate, [WorkflowExpression] Func<double> checkinvalue = null, [WorkflowExpression] Func<checkinstatusInput> checkinstatus = null, [WorkflowExpression] Func<string> checkinnote = null)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinsResponse> GetGoalCheckins([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scorecardId, [WorkflowExpression] Func<string> goalId)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Queries["$expand"] = Convert.ToString("notes");
            return new ApiConnectionAction<GetGoalCheckinsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction UpdateGoalCheckin([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scorecardId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin, [WorkflowExpression] Func<double> checkinvalue = null, [WorkflowExpression] Func<checkinstatusInput> checkinstatus = null)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalCheckin, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinResponse> GetGoalCheckin([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scorecardId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> goalId, [WorkflowExpression] Func<string> goalCheckin)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(scorecardId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalId, 1), ExpressionConverter.ConvertWithUrlEncoding(goalCheckin, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Queries["$expand"] = Convert.ToString("notes");
            return new ApiConnectionAction<GetGoalCheckinResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction RefreshDataset([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> datasetid)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/datasets/{1}/refreshes", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string> InitiateExportToFileForPbiReports([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> reportid, [WorkflowExpression] Func<exportPayloadPowerBIReportformatInput> exportPayloadPowerBIReportformat, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale = null, [WorkflowExpression] Func<bool> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages = null, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname = null, [WorkflowExpression] Func<string> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate = null, [WorkflowExpression] Func<ExportFilter[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters = null, [WorkflowExpression] Func<ExportReportPage[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationpages = null, [WorkflowExpression] Func<EffectiveIdentity[]> exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities = null)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/reports/{1}/ExportTo", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(reportid, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string> InitiateExportToFileForPaginatedReports([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupid, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> reportid, [WorkflowExpression] Func<exportPayloadPaginatedReportformatInput> exportPayloadPaginatedReportformat, [WorkflowExpression] Func<EffectiveIdentity[]> exportPayloadPaginatedReportpaginatedReportConfigurationidentities = null, [WorkflowExpression] Func<exportPayloadPaginatedReportpaginatedReportConfigurationparameterValuesInputItem[]> exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues = null)
        {
            var apiCallPath = String.Format("/v1.0/myorg/groups/{0}/reports/{1}/ExportToPaginatedReports", ExpressionConverter.ConvertWithUrlEncoding(groupid, 1), ExpressionConverter.ConvertWithUrlEncoding(reportid, 1));
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