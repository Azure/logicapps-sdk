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
        public IBodyWorkflowAction<ListedScorecards> GetScorecards(Expression<Func<string>> groupid)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            return new ApiConnectionAction<ListedScorecards>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreatedScorecard> CreateScorecard(Expression<Func<string>> groupid, Expression<Func<string>> scorecardname, Expression<Func<string>> scorecarddescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            var scorecard = new JObject();
            var scorecardpropCount = 0;
            scorecardpropCount++;
            scorecard["name"] = CSharpExpressionConverter.ConvertToken(scorecardname);
            if (scorecarddescription != null)
            {
                scorecard["description"] = CSharpExpressionConverter.ConvertToken(scorecarddescription);
                scorecardpropCount++;
            }

            if (scorecardpropCount > 0)
            {
                callPayload.Body = scorecard;
            }

            return new ApiConnectionAction<CreatedScorecard>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoals> GetMultipleGoals(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$expand"] = Convert.ToString("aggregations");
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            return new ApiConnectionAction<FetchedGoals>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<CreateGoalResponse> CreateGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalname, Expression<Func<string>> goalowner = null, Expression<Func<string>> goalcurrentValue = null, Expression<Func<string>> goaltargetValue = null, Expression<Func<goalstatusInput>> goalstatus = null, Expression<Func<string>> goalstartDate = null, Expression<Func<string>> goalcompletionDate = null, Expression<Func<string>> goalnote = null, Expression<Func<string>> goalparentGoalId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            var goal = new JObject();
            var goalpropCount = 0;
            goalpropCount++;
            goal["name"] = CSharpExpressionConverter.ConvertToken(goalname);
            if (goalowner != null)
            {
                goal["owner"] = CSharpExpressionConverter.ConvertToken(goalowner);
                goalpropCount++;
            }

            if (goalcurrentValue != null)
            {
                goal["value"] = CSharpExpressionConverter.ConvertToken(goalcurrentValue);
                goalpropCount++;
            }

            if (goaltargetValue != null)
            {
                goal["target"] = CSharpExpressionConverter.ConvertToken(goaltargetValue);
                goalpropCount++;
            }

            if (goalstatus != null)
            {
                if (goalstatus != null)
                {
                    goal["status"] = CSharpExpressionConverter.Convert(goalstatus);
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
                goal["startDate"] = CSharpExpressionConverter.ConvertToken(goalstartDate);
                goalpropCount++;
            }

            if (goalcompletionDate != null)
            {
                goal["completionDate"] = CSharpExpressionConverter.ConvertToken(goalcompletionDate);
                goalpropCount++;
            }

            if (goalnote != null)
            {
                goal["note"] = CSharpExpressionConverter.ConvertToken(goalnote);
                goalpropCount++;
            }

            if (goalparentGoalId != null)
            {
                goal["parentId"] = CSharpExpressionConverter.ConvertToken(goalparentGoalId);
                goalpropCount++;
            }

            if (goalpropCount > 0)
            {
                callPayload.Body = goal;
            }

            return new ApiConnectionAction<CreateGoalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<FetchedGoal> GetGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Queries["$expand"] = Convert.ToString("aggregations");
            return new ApiConnectionAction<FetchedGoal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction UpdateGoal(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalname = null, Expression<Func<string>> goalowner = null, Expression<Func<double>> goalcurrentValue = null, Expression<Func<double>> goaltargetValue = null, Expression<Func<goalstatusInput>> goalstatus = null, Expression<Func<string>> goalstartDate = null, Expression<Func<string>> goalcompletionDate = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myOrg/groups/{0}/internalScorecards({1})/goals({2})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            var goal = new JObject();
            var goalpropCount = 0;
            if (goalname != null)
            {
                goal["name"] = CSharpExpressionConverter.ConvertToken(goalname);
                goalpropCount++;
            }

            if (goalowner != null)
            {
                goal["owner"] = CSharpExpressionConverter.ConvertToken(goalowner);
                goalpropCount++;
            }

            if (goalcurrentValue != null)
            {
                goal["value"] = CSharpExpressionConverter.ConvertToken(goalcurrentValue);
                goalpropCount++;
            }

            if (goaltargetValue != null)
            {
                goal["target"] = CSharpExpressionConverter.ConvertToken(goaltargetValue);
                goalpropCount++;
            }

            if (goalstatus != null)
            {
                if (goalstatus != null)
                {
                    goal["status"] = CSharpExpressionConverter.Convert(goalstatus);
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
                goal["startDate"] = CSharpExpressionConverter.ConvertToken(goalstartDate);
                goalpropCount++;
            }

            if (goalcompletionDate != null)
            {
                goal["completionDate"] = CSharpExpressionConverter.ConvertToken(goalcompletionDate);
                goalpropCount++;
            }

            if (goalpropCount > 0)
            {
                callPayload.Body = goal;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<QueryExecutionResults> ExecuteDatasetQuery(Expression<Func<string>> groupid, Expression<Func<string>> datasetid, Expression<Func<string>> specificationqueryText, Expression<Func<bool>> specificationserializerSettingsnullsIncluded = null, Expression<Func<string>> specificationimpersonateUser = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            var specification = new JObject();
            var specificationpropCount = 0;
            specificationpropCount++;
            specification["query"] = CSharpExpressionConverter.ConvertToken(specificationqueryText);
            var serializerSettingsObject = new JObject();
            var serializerSettingsObjectpropCount = 0;
            if (specificationserializerSettingsnullsIncluded != null)
            {
                if (specificationserializerSettingsnullsIncluded != null)
                {
                    serializerSettingsObject["includeNulls"] = CSharpExpressionConverter.ConvertToken(specificationserializerSettingsnullsIncluded);
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
                specification["impersonatedUserName"] = CSharpExpressionConverter.ConvertToken(specificationimpersonateUser);
                specificationpropCount++;
            }

            if (specificationpropCount > 0)
            {
                callPayload.Body = specification;
            }

            return new ApiConnectionAction<QueryExecutionResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<JToken> ExecuteDatasetQueriesJson(Expression<Func<string>> groupid, Expression<Func<string>> datasetid)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/internalFlowActionOverloadAsJson/v1.0/myorg/groups/{0}/datasets/{1}/executeQueries", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetid, 1));
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
        public IWorkflowAction AddRows(Expression<Func<string>> groupid, Expression<Func<string>> datasetid, Expression<Func<string>> tablename, Expression<Func<object>> payload = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/tables/{2}/rows", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tablename, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Body = CSharpExpressionConverter.ConvertToken(payload);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction GoalValueCheckinNote(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin, Expression<Func<string>> note = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})/notes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalCheckin, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Body = CSharpExpressionConverter.ConvertToken(note);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction GoalValueCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> checkindate, Expression<Func<double>> checkinvalue = null, Expression<Func<checkinstatusInput>> checkinstatus = null, Expression<Func<string>> checkinnote = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            var checkin = new JObject();
            var checkinpropCount = 0;
            checkinpropCount++;
            checkin["timestamp"] = CSharpExpressionConverter.ConvertToken(checkindate);
            if (checkinvalue != null)
            {
                checkin["value"] = CSharpExpressionConverter.ConvertToken(checkinvalue);
                checkinpropCount++;
            }

            if (checkinstatus != null)
            {
                if (checkinstatus != null)
                {
                    checkin["status"] = CSharpExpressionConverter.Convert(checkinstatus);
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
                checkin["note"] = CSharpExpressionConverter.ConvertToken(checkinnote);
                checkinpropCount++;
            }

            if (checkinpropCount > 0)
            {
                callPayload.Body = checkin;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<GetGoalCheckinsResponse> GetGoalCheckins(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Queries["$expand"] = Convert.ToString("notes");
            return new ApiConnectionAction<GetGoalCheckinsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction UpdateGoalCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin, Expression<Func<double>> checkinvalue = null, Expression<Func<checkinstatusInput>> checkinstatus = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalCheckin, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            var checkin = new JObject();
            var checkinpropCount = 0;
            if (checkinvalue != null)
            {
                checkin["value"] = CSharpExpressionConverter.ConvertToken(checkinvalue);
                checkinpropCount++;
            }

            if (checkinstatus != null)
            {
                if (checkinstatus != null)
                {
                    checkin["status"] = CSharpExpressionConverter.Convert(checkinstatus);
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
        public IBodyWorkflowAction<GetGoalCheckinResponse> GetGoalCheckin(Expression<Func<string>> groupid, Expression<Func<string>> scorecardId, Expression<Func<string>> goalId, Expression<Func<string>> goalCheckin)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/internalScorecards({1})/goals({2})/goalValues({3})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scorecardId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalCheckin, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            callPayload.Queries["$expand"] = Convert.ToString("notes");
            return new ApiConnectionAction<GetGoalCheckinResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IWorkflowAction RefreshDataset(Expression<Func<string>> groupid, Expression<Func<string>> datasetid)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/datasets/{1}/refreshes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pbi_source"] = Convert.ToString("powerAutomate");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerbi")]
        public IBodyWorkflowAction<string> InitiateExportToFileForPbiReports(Expression<Func<string>> groupid, Expression<Func<string>> reportid, Expression<Func<exportPayloadPowerBIReportformatInput>> exportPayloadPowerBIReportformat, Expression<Func<string>> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale = null, Expression<Func<bool>> exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages = null, Expression<Func<string>> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname = null, Expression<Func<string>> exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate = null, Expression<Func<ExportFilter[]>> exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters = null, Expression<Func<ExportReportPage[]>> exportPayloadPowerBIReportpowerBIReportExportConfigurationpages = null, Expression<Func<EffectiveIdentity[]>> exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportTo", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exportPayloadPowerBIReport = new JObject();
            var exportPayloadPowerBIReportpropCount = 0;
            exportPayloadPowerBIReportpropCount++;
            exportPayloadPowerBIReport["format"] = CSharpExpressionConverter.Convert(exportPayloadPowerBIReportformat);
            var powerBIReportExportConfigurationObject = new JObject();
            var powerBIReportExportConfigurationObjectpropCount = 0;
            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale != null)
            {
                settingsObject["locale"] = CSharpExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingslocale);
                settingsObjectpropCount++;
            }

            if (exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages != null)
            {
                settingsObject["includeHiddenPages"] = CSharpExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationsettingsincludeHiddenPages);
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
                defaultBookmarkObject["name"] = CSharpExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkname);
                defaultBookmarkObjectpropCount++;
            }

            if (exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate != null)
            {
                defaultBookmarkObject["state"] = CSharpExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationdefaultBookmarkstate);
                defaultBookmarkObjectpropCount++;
            }

            if (defaultBookmarkObjectpropCount > 0)
            {
                powerBIReportExportConfigurationObject["defaultBookmark"] = defaultBookmarkObject;
                powerBIReportExportConfigurationObjectpropCount++;
            }

            if (exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters != null)
            {
                powerBIReportExportConfigurationObject["reportLevelFilters"] = CSharpExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationreportLevelFilters);
                powerBIReportExportConfigurationObjectpropCount++;
            }

            if (exportPayloadPowerBIReportpowerBIReportExportConfigurationpages != null)
            {
                powerBIReportExportConfigurationObject["pages"] = CSharpExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationpages);
                powerBIReportExportConfigurationObjectpropCount++;
            }

            if (exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities != null)
            {
                powerBIReportExportConfigurationObject["identities"] = CSharpExpressionConverter.ConvertToken(exportPayloadPowerBIReportpowerBIReportExportConfigurationidentities);
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
        public IBodyWorkflowAction<string> InitiateExportToFileForPaginatedReports(Expression<Func<string>> groupid, Expression<Func<string>> reportid, Expression<Func<exportPayloadPaginatedReportformatInput>> exportPayloadPaginatedReportformat, Expression<Func<EffectiveIdentity[]>> exportPayloadPaginatedReportpaginatedReportConfigurationidentities = null, Expression<Func<exportPayloadPaginatedReportpaginatedReportConfigurationparameterValuesInputItem[]>> exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/myorg/groups/{0}/reports/{1}/ExportToPaginatedReports", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupid, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exportPayloadPaginatedReport = new JObject();
            var exportPayloadPaginatedReportpropCount = 0;
            exportPayloadPaginatedReportpropCount++;
            exportPayloadPaginatedReport["format"] = CSharpExpressionConverter.Convert(exportPayloadPaginatedReportformat);
            var paginatedReportConfigurationObject = new JObject();
            var paginatedReportConfigurationObjectpropCount = 0;
            if (exportPayloadPaginatedReportpaginatedReportConfigurationidentities != null)
            {
                paginatedReportConfigurationObject["identities"] = CSharpExpressionConverter.ConvertToken(exportPayloadPaginatedReportpaginatedReportConfigurationidentities);
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
                paginatedReportConfigurationObject["parameterValues"] = CSharpExpressionConverter.ConvertToken(exportPayloadPaginatedReportpaginatedReportConfigurationparameterValues);
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