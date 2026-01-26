//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wdatp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WdatpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<AdvancedHuntingResponse> AdvancedHunting(Expression<Func<string>> bodyQuery)
        {
            var apiCallPath = "/api/advancedqueries/run";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Query"] = ExpressionConverter.ConvertO(bodyQuery);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AdvancedHuntingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert> CreateAlertByReference(Expression<Func<string>> bodymachineId, Expression<Func<string>> bodyreportId, Expression<Func<string>> bodyeventTime, Expression<Func<bodyseverityInput>> bodyseverity, Expression<Func<bodycategoryInput>> bodycategory, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodyrecommendedAction)
        {
            var apiCallPath = "/api/alerts/createAlertByReference";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["machineId"] = ExpressionConverter.ConvertO(bodymachineId);
            bodypropCount++;
            body["reportId"] = ExpressionConverter.ConvertO(bodyreportId);
            bodypropCount++;
            body["eventTime"] = ExpressionConverter.ConvertO(bodyeventTime);
            bodypropCount++;
            body["severity"] = ExpressionConverter.ConvertO(bodyseverity);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["recommendedAction"] = ExpressionConverter.ConvertO(bodyrecommendedAction);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Alert>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetAlertsResponse> GetAlerts(Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var apiCallPath = "/api/alerts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<GetAlertsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert> GetSingleAlert(Expression<Func<string>> alertID)
        {
            var apiCallPath = String.Format("/api/alerts/{0}", ExpressionConverter.ConvertWithUrlEncoding(alertID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Alert>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert> PatchAlert(Expression<Func<string>> alertID, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<bodyclassificationInput>> bodyclassification = null, Expression<Func<bodydeterminationInput>> bodydetermination = null)
        {
            var apiCallPath = String.Format("/api/alerts/{0}", ExpressionConverter.ConvertWithUrlEncoding(alertID, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedTo != null)
            {
                body["assignedTo"] = ExpressionConverter.ConvertO(bodyassignedTo);
                bodypropCount++;
            }

            if (bodyclassification != null)
            {
                body["classification"] = ExpressionConverter.ConvertO(bodyclassification);
                bodypropCount++;
            }

            if (bodydetermination != null)
            {
                body["determination"] = ExpressionConverter.ConvertO(bodydetermination);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Alert>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<InitiateInvestigationResponse> InitiateInvestigation(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment)
        {
            var apiCallPath = String.Format("/api/machines/{0}/initiateInvestigation", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InitiateInvestigationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Investigation> StartInvestigation(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment)
        {
            var apiCallPath = String.Format("/api/machines/{0}/startInvestigation", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Investigation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> GetSingleMachineAction(Expression<Func<string>> machineActionID)
        {
            var apiCallPath = String.Format("/api/machineactions/{0}", ExpressionConverter.ConvertWithUrlEncoding(machineActionID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> CancelSingleMachineAction(Expression<Func<string>> machineActionID, Expression<Func<string>> bodyComment)
        {
            var apiCallPath = String.Format("/api/machineactions/{0}/cancel", ExpressionConverter.ConvertWithUrlEncoding(machineActionID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetLiveResponseDownloadLinkResponse> GetLiveResponseDownloadLink(Expression<Func<string>> machineActionID, Expression<Func<int>> commandIndex)
        {
            var apiCallPath = String.Format("/api/machineactions/{0}/GetLiveResponseResultDownloadLink(index={1})", ExpressionConverter.ConvertWithUrlEncoding(machineActionID, 1), ExpressionConverter.ConvertWithUrlEncoding(commandIndex, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetLiveResponseDownloadLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetMachineActionsResponse> GetMachineActions(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var apiCallPath = "/api/machineactions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<GetMachineActionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<FileStats> GetFileStats(Expression<Func<string>> fileID, Expression<Func<int>> lookBackHours = null)
        {
            var apiCallPath = String.Format("/api/files/{0}/stats", ExpressionConverter.ConvertWithUrlEncoding(fileID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lookBackHours"] = Convert.ToString(24);
            if (lookBackHours != null)
                callPayload.Queries["lookBackHours"] = ExpressionConverter.Convert(lookBackHours);
            return new ApiConnectionAction<FileStats>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<DomainStats> GetDomainStats(Expression<Func<string>> domainName, Expression<Func<int>> lookBackHours = null)
        {
            var apiCallPath = String.Format("/api/domains/{0}/stats", ExpressionConverter.ConvertWithUrlEncoding(domainName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lookBackHours"] = Convert.ToString(24);
            if (lookBackHours != null)
                callPayload.Queries["lookBackHours"] = ExpressionConverter.Convert(lookBackHours);
            return new ApiConnectionAction<DomainStats>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<IpStats> GetIpStats(Expression<Func<string>> ipAddress, Expression<Func<int>> lookBackHours = null)
        {
            var apiCallPath = String.Format("/api/ips/{0}/stats", ExpressionConverter.ConvertWithUrlEncoding(ipAddress, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lookBackHours"] = Convert.ToString(24);
            if (lookBackHours != null)
                callPayload.Queries["lookBackHours"] = ExpressionConverter.Convert(lookBackHours);
            return new ApiConnectionAction<IpStats>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Investigation> GetSingleInvestigation(Expression<Func<string>> investigationID)
        {
            var apiCallPath = String.Format("/api/investigations/{0}", ExpressionConverter.ConvertWithUrlEncoding(investigationID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Investigation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetInvestigationsResponse> GetInvestigations(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var apiCallPath = "/api/investigations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<GetInvestigationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> CollectInvestigationPackage(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment)
        {
            var apiCallPath = String.Format("/api/machines/{0}/collectInvestigationPackage", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetInvestigationPackageUriResponse> GetInvestigationPackageUri(Expression<Func<string>> machineActionID)
        {
            var apiCallPath = String.Format("/api/machineactions/{0}/getPackageUri", ExpressionConverter.ConvertWithUrlEncoding(machineActionID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetInvestigationPackageUriResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> IsolateMachine(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment, Expression<Func<bodyIsolationTypeInput>> bodyIsolationType)
        {
            var apiCallPath = String.Format("/api/machines/{0}/isolate", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            bodypropCount++;
            body["IsolationType"] = ExpressionConverter.ConvertO(bodyIsolationType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> UnisolateMachine(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment)
        {
            var apiCallPath = String.Format("/api/machines/{0}/unisolate", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> RestrictAppExecution(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment)
        {
            var apiCallPath = String.Format("/api/machines/{0}/restrictCodeExecution", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> UnrestrictAppExecution(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment)
        {
            var apiCallPath = String.Format("/api/machines/{0}/unrestrictCodeExecution", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> RunAntivirusScan(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment, Expression<Func<bodyScanTypeInput>> bodyScanType)
        {
            var apiCallPath = String.Format("/api/machines/{0}/runAntiVirusScan", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            bodypropCount++;
            body["ScanType"] = ExpressionConverter.ConvertO(bodyScanType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> RunLiveResponse(Expression<Func<string>> machineID, Expression<Func<string>> bodyComment, Expression<Func<LiveResponseCommand[]>> bodyCommands)
        {
            var apiCallPath = String.Format("/api/machines/{0}/runliveresponse", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
            bodypropCount++;
            body["Commands"] = ExpressionConverter.ConvertO(bodyCommands);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MachineAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetRemediationActivitiesResponse> GetRemediationActivities(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var apiCallPath = "/api/remediationtasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<GetRemediationActivitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<RemediationActivity> GetSingleRemediationActivity(Expression<Func<string>> remediationID)
        {
            var apiCallPath = String.Format("/api/remediationtasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(remediationID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RemediationActivity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetRemediationActivityMachineListResponse> GetRemediationActivityMachineList(Expression<Func<string>> remediationID)
        {
            var apiCallPath = String.Format("/api/remediationtasks/{0}/machinereferences", ExpressionConverter.ConvertWithUrlEncoding(remediationID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRemediationActivityMachineListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetMachinesResponse> GetMachines(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var apiCallPath = "/api/machines";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<GetMachinesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Machine> GetSingleMachine(Expression<Func<string>> machineID)
        {
            var apiCallPath = String.Format("/api/machines/{0}", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Machine>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Machine> MachineTag(Expression<Func<string>> machineID, Expression<Func<string>> bodyValue, Expression<Func<bodyActionInput>> bodyAction)
        {
            var apiCallPath = String.Format("/api/machines/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(machineID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Value"] = ExpressionConverter.ConvertO(bodyValue);
            bodypropCount++;
            body["Action"] = ExpressionConverter.ConvertO(bodyAction);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Machine>(callPayload);
        }
    }

    public class WdatpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookSubscriptionTableEntity> WebHooksCreateWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["clientState"] = "flow";
            requestpropCount++;
            request["changeType"] = "created";
            requestpropCount++;
            request["resource"] = "alerts";
            requestpropCount++;
            request["expirationDateTime"] = "2038-09-20T12:00:00Z";
            requestpropCount++;
            request["notificationUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionTableEntity>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnNewRemediationActivityResponse> OnNewRemediationActivity(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/remediationtasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$orderby"] = Convert.ToString("createdOn desc");
            return new ApiConnectionTrigger<OnNewRemediationActivityResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class AdvancedHuntingResponse
    {
        public AdvancedHuntingResponseStatsType Stats { get; set; }
        public JToken[] Results { get; set; }
    }

    public class AdvancedHuntingResponseStatsType
    {
        [JsonProperty("dataset_statistics")]
        public AdvancedHuntingResponseStatsTypeDatasetStatisticsTypeItem[] DatasetStatistics { get; set; }
    }

    public class AdvancedHuntingResponseStatsTypeDatasetStatisticsTypeItem
    {
        [JsonProperty("table_row_count")]
        public int TableRowCount { get; set; }
    }

    public class Alert
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("incidentId")]
        public int IncidentId { get; set; }

        [JsonProperty("investigationId")]
        public int InvestigationId { get; set; }

        [JsonProperty("severity")]
        public AlertSeverityType Severity { get; set; }

        [JsonProperty("status")]
        public AlertStatusType Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alertCreationTime")]
        public string AlertCreationTime { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("threatFamilyName")]
        public string ThreatFamilyName { get; set; }

        [JsonProperty("detectionSource")]
        public string DetectionSource { get; set; }

        [JsonProperty("classification")]
        public AlertClassificationType Classification { get; set; }

        [JsonProperty("determination")]
        public AlertDeterminationType Determination { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("resolvedTime")]
        public string ResolvedTime { get; set; }

        [JsonProperty("lastEventTime")]
        public string LastEventTime { get; set; }

        [JsonProperty("firstEventTime")]
        public string FirstEventTime { get; set; }

        [JsonProperty("machineId")]
        public string MachineId { get; set; }
    }

    public enum AlertSeverityType
    {
        Informational,
        Low,
        Medium,
        High
    }

    public enum AlertStatusType
    {
        Unspecified,
        New,
        InProgress,
        Resolved,
        Hidden
    }

    public enum AlertClassificationType
    {
        Unknown,
        FalsePositive,
        TruePositive
    }

    public enum AlertDeterminationType
    {
        NotAvailable,
        Apt,
        Malware,
        SecurityPersonnel,
        SecurityTesting,
        UnwantedSoftware,
        Other
    }

    public enum bodyseverityInput
    {
        Low,
        Medium,
        High
    }

    public enum bodycategoryInput
    {
        General,
        CommandAndControl,
        Collection,
        CredentialAccess,
        DefenseEvasion,
        Discovery,
        Exfiltration,
        Exploit,
        Execution,
        InitialAccess,
        LateralMovement,
        Malware,
        Persistence,
        PrivilegeEscalation,
        Ransomware,
        SuspiciousActivity
    }

    public class GetAlertsResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public Alert[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public enum bodystatusInput
    {
        New,
        InProgress,
        Resolved
    }

    public enum bodyclassificationInput
    {
        Unknown,
        FalsePositive,
        TruePositive
    }

    public enum bodydeterminationInput
    {
        NotAvailable,
        Apt,
        Malware,
        SecurityPersonnel,
        SecurityTesting,
        UnwantedSoftware,
        Other
    }

    public class InitiateInvestigationResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Investigation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public InvestigationStateType State { get; set; }

        [JsonProperty("statusDetails")]
        public string StatusDetails { get; set; }

        [JsonProperty("computerDnsName")]
        public string ComputerDnsName { get; set; }

        [JsonProperty("machineId")]
        public string MachineId { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }
    }

    public enum InvestigationStateType
    {
        Unknown,
        Terminated,
        TerminatedByUser,
        TerminatedBySystem,
        SuccessfullyRemediated,
        Benign,
        Failed,
        PartiallyRemediated,
        Running,
        PendingApproval,
        PendingResource,
        PartiallyInvestigated,
        Disabled,
        Queued,
        InnerFailure,
        PreexistingAlert,
        UnsupportedOs,
        UnsupportedAlertType,
        SuppressedAlert
    }

    public class MachineAction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public MachineActionTypeType Type { get; set; }

        [JsonProperty("requestor")]
        public string Requestor { get; set; }

        [JsonProperty("requestorComment")]
        public string RequestorComment { get; set; }

        [JsonProperty("status")]
        public MachineActionStatusType Status { get; set; }

        [JsonProperty("machineId")]
        public string MachineId { get; set; }

        [JsonProperty("creationDateTimeUtc")]
        public string CreationDateTimeUtc { get; set; }

        [JsonProperty("lastUpdateDateTimeUtc")]
        public string LastUpdateDateTimeUtc { get; set; }

        [JsonProperty("relatedFileInfo")]
        public MachineActionRelatedFileInfoType RelatedFileInfo { get; set; }

        [JsonProperty("commands")]
        public LiveResponseCommandStatus[] Commands { get; set; }
    }

    public enum MachineActionTypeType
    {
        Unknown,
        RequestSample,
        RunAntiVirusScan,
        Offboard,
        CollectInvestigationPackage,
        Isolate,
        Unisolate,
        StopAndQuarantineFile,
        RestrictCodeExecution,
        UnrestrictCodeExecution,
        LiveResponse
    }

    public enum MachineActionStatusType
    {
        Pending,
        Cancelled,
        TimeOut,
        Failed,
        InProgress,
        Succeeded
    }

    public class MachineActionRelatedFileInfoType
    {
        [JsonProperty("fileIdentifier")]
        public string FileIdentifier { get; set; }

        [JsonProperty("fileIdentifierType")]
        public MachineActionRelatedFileInfoTypeFileIdentifierTypeType FileIdentifierType { get; set; }
    }

    public enum MachineActionRelatedFileInfoTypeFileIdentifierTypeType
    {
        Sha1,
        Sha256,
        Md5
    }

    public class LiveResponseCommandStatus
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("commandStatus")]
        public LiveResponseCommandStatusCommandStatusType CommandStatus { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }

        [JsonProperty("command")]
        public JToken Command { get; set; }
    }

    public enum LiveResponseCommandStatusCommandStatusType
    {
        Executing,
        Completed,
        Failed,
        PendingResource,
        Submitted,
        Created
    }

    public class GetLiveResponseDownloadLinkResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetMachineActionsResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public MachineAction[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class FileStats
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("globallyPrevalence")]
        public int GloballyPrevalence { get; set; }

        [JsonProperty("globalFirstObserved")]
        public string GlobalFirstObserved { get; set; }

        [JsonProperty("globalLastObserved")]
        public string GlobalLastObserved { get; set; }

        [JsonProperty("organizationPrevalence")]
        public int OrganizationPrevalence { get; set; }

        [JsonProperty("orgFirstSeen")]
        public string OrgFirstSeen { get; set; }

        [JsonProperty("orgLastSeen")]
        public string OrgLastSeen { get; set; }

        [JsonProperty("topFileNames")]
        public string[] TopFileNames { get; set; }
    }

    public class DomainStats
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("organizationPrevalence")]
        public int OrganizationPrevalence { get; set; }

        [JsonProperty("orgFirstSeen")]
        public string OrgFirstSeen { get; set; }

        [JsonProperty("orgLastSeen")]
        public string OrgLastSeen { get; set; }
    }

    public class IpStats
    {
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("organizationPrevalence")]
        public int OrganizationPrevalence { get; set; }

        [JsonProperty("orgFirstSeen")]
        public string OrgFirstSeen { get; set; }

        [JsonProperty("orgLastSeen")]
        public string OrgLastSeen { get; set; }
    }

    public class GetInvestigationsResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public Investigation[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class GetInvestigationPackageUriResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodyIsolationTypeInput
    {
        Full,
        Selective
    }

    public enum bodyScanTypeInput
    {
        Quick,
        Full
    }

    public class LiveResponseCommand
    {
        [JsonProperty("type")]
        public LiveResponseCommandTypeType Type { get; set; }

        [JsonProperty("params")]
        public LiveResponseCommandParamsTypeItem[] Params { get; set; }
    }

    public enum LiveResponseCommandTypeType
    {
        GetFile,
        RunScript,
        PutFile
    }

    public class LiveResponseCommandParamsTypeItem
    {
        [JsonProperty("key")]
        public LiveResponseCommandParamsTypeItemKeyType Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum LiveResponseCommandParamsTypeItemKeyType
    {
        FileName,
        ScriptName,
        Args,
        Path
    }

    public class GetRemediationActivitiesResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public RemediationActivity[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class RemediationActivity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("statusLastModifiedOn")]
        public string StatusLastModifiedOn { get; set; }

        [JsonProperty("requesterId")]
        public string RequesterId { get; set; }

        [JsonProperty("requesterEmail")]
        public string RequesterEmail { get; set; }

        [JsonProperty("status")]
        public RemediationActivityStatusType Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("relatedComponent")]
        public string RelatedComponent { get; set; }

        [JsonProperty("targetDevices")]
        public int TargetDevices { get; set; }

        [JsonProperty("rbacGroupNames")]
        public string[] RbacGroupNames { get; set; }

        [JsonProperty("fixedDevices")]
        public int FixedDevices { get; set; }

        [JsonProperty("requesterNotes")]
        public string RequesterNotes { get; set; }

        [JsonProperty("dueOn")]
        public string DueOn { get; set; }

        [JsonProperty("category")]
        public RemediationActivityCategoryType Category { get; set; }

        [JsonProperty("productivityImpactRemediationType")]
        public RemediationActivityProductivityImpactRemediationTypeType ProductivityImpactRemediationType { get; set; }

        [JsonProperty("priority")]
        public RemediationActivityPriorityType Priority { get; set; }

        [JsonProperty("completionMethod")]
        public RemediationActivityCompletionMethodType CompletionMethod { get; set; }

        [JsonProperty("completerId")]
        public string CompleterId { get; set; }

        [JsonProperty("completerEmail")]
        public string CompleterEmail { get; set; }

        [JsonProperty("scid")]
        public string Scid { get; set; }

        [JsonProperty("type")]
        public RemediationActivityTypeType Type { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("vendorId")]
        public string VendorId { get; set; }

        [JsonProperty("nameId")]
        public string NameId { get; set; }

        [JsonProperty("recommendedVersion")]
        public string RecommendedVersion { get; set; }

        [JsonProperty("recommendedVendor")]
        public string RecommendedVendor { get; set; }

        [JsonProperty("recommendedProgram")]
        public string RecommendedProgram { get; set; }
        public string RecommendationReference { get; set; }
    }

    public enum RemediationActivityStatusType
    {
        Active,
        Completed
    }

    public enum RemediationActivityCategoryType
    {
        Software,
        SecurityConfiguration
    }

    public enum RemediationActivityProductivityImpactRemediationTypeType
    {
        AllExposedAssets,
        NonImpactedAssets
    }

    public enum RemediationActivityPriorityType
    {
        Low,
        Medium,
        High
    }

    public enum RemediationActivityCompletionMethodType
    {
        Manual,
        Automatic
    }

    public enum RemediationActivityTypeType
    {
        Update,
        Uninstall,
        ConfigurationChange,
        AttentionRequired,
        Upgrade
    }

    public class GetRemediationActivityMachineListResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public Machine[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class Machine
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("computerDnsName")]
        public string ComputerDnsName { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("osPlatform")]
        public string OsPlatform { get; set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("systemProductName")]
        public string SystemProductName { get; set; }

        [JsonProperty("lastIpAddress")]
        public string LastIpAddress { get; set; }

        [JsonProperty("lastExternalIpAddress")]
        public string LastExternalIpAddress { get; set; }

        [JsonProperty("agentVersion")]
        public string AgentVersion { get; set; }

        [JsonProperty("osBuild")]
        public int OsBuild { get; set; }

        [JsonProperty("healthStatus")]
        public MachineHealthStatusType HealthStatus { get; set; }

        [JsonProperty("isAadJoined")]
        public bool IsAadJoined { get; set; }

        [JsonProperty("machineTags")]
        public string[] MachineTags { get; set; }

        [JsonProperty("rbacGroupId")]
        public int RbacGroupId { get; set; }

        [JsonProperty("rbacGroupName")]
        public string RbacGroupName { get; set; }

        [JsonProperty("riskScore")]
        public MachineRiskScoreType RiskScore { get; set; }

        [JsonProperty("aadDeviceId")]
        public string AadDeviceId { get; set; }
    }

    public enum MachineHealthStatusType
    {
        Active,
        Inactive,
        ImpairedCommunication,
        NoSensorData,
        NoSensorDataImpairedCommunication,
        Unknown
    }

    public enum MachineRiskScoreType
    {
        None,
        Low,
        Medium,
        High
    }

    public class GetMachinesResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public Machine[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public enum bodyActionInput
    {
        Add,
        Remove
    }

    public class WebHookSubscriptionTableEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }

        [JsonProperty("clientState")]
        public string ClientState { get; set; }
    }

    public class OnNewRemediationActivityResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public RemediationActivity[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wdatp;

    public partial class WorkflowManagedActions
    {
        public WdatpActions Wdatp(string connectionId) => new WdatpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WdatpTriggers Wdatp(string connectionId) => new WdatpTriggers(connectionId);
    }
}