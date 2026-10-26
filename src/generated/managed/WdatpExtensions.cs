//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wdatp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WdatpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<AdvancedHuntingResponse, ApiConnectionActionConfiguration> AdvancedHunting(Expression<Func<AdvancedHuntingInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AdvancedHuntingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/advancedqueries/run";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AdvancedHuntingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert, ApiConnectionActionConfiguration> CreateAlertByReference(Expression<Func<CreateAlertByReferenceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Alert, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/alerts/createAlertByReference";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Alert>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetAlertsResponse, ApiConnectionActionConfiguration> GetAlerts(Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<GetAlertsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                return new ApiConnectionAction<GetAlertsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert, ApiConnectionActionConfiguration> GetSingleAlert(Expression<Func<string>> alertId)
        {
            var __workflow_alertId = WorkflowExpression.Compile(alertId, nameof(alertId), required: true);
            return new DeferredBodyAction<Alert, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/alerts/{0}", __workflow_alertId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Alert>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert, ApiConnectionActionConfiguration> PatchAlert(Expression<Func<string>> alertId, Expression<Func<PatchAlertInput>> body)
        {
            var __workflow_alertId = WorkflowExpression.Compile(alertId, nameof(alertId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Alert, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/alerts/{0}", __workflow_alertId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Alert>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<InitiateInvestigationResponse, ApiConnectionActionConfiguration> InitiateInvestigation(Expression<Func<string>> machineId, Expression<Func<InitiateInvestigationInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InitiateInvestigationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/initiateInvestigation", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InitiateInvestigationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Investigation, ApiConnectionActionConfiguration> StartInvestigation(Expression<Func<string>> machineId, Expression<Func<StartInvestigationInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Investigation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/startInvestigation", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Investigation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> GetSingleMachineAction(Expression<Func<string>> machineActionId)
        {
            var __workflow_machineActionId = WorkflowExpression.Compile(machineActionId, nameof(machineActionId), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machineactions/{0}", __workflow_machineActionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> CancelSingleMachineAction(Expression<Func<string>> machineActionId, Expression<Func<CancelSingleMachineActionInput>> body)
        {
            var __workflow_machineActionId = WorkflowExpression.Compile(machineActionId, nameof(machineActionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machineactions/{0}/cancel", __workflow_machineActionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetLiveResponseDownloadLinkResponse, ApiConnectionActionConfiguration> GetLiveResponseDownloadLink(Expression<Func<string>> machineActionId, Expression<Func<int>> commandIndex)
        {
            var __workflow_machineActionId = WorkflowExpression.Compile(machineActionId, nameof(machineActionId), required: true);
            var __workflow_commandIndex = WorkflowExpression.Compile(commandIndex, nameof(commandIndex), required: true);
            return new DeferredBodyAction<GetLiveResponseDownloadLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machineactions/{0}/GetLiveResponseResultDownloadLink(index={1})", __workflow_machineActionId.WithUrlEncoding(1), __workflow_commandIndex.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLiveResponseDownloadLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetMachineActionsResponse, ApiConnectionActionConfiguration> GetMachineActions(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<GetMachineActionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/machineactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                return new ApiConnectionAction<GetMachineActionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<FileStats, ApiConnectionActionConfiguration> GetFileStats(Expression<Func<string>> fileId, Expression<Func<int>> lookBackHours = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_lookBackHours = WorkflowExpression.Compile(lookBackHours, nameof(lookBackHours), required: false);
            return new DeferredBodyAction<FileStats, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/files/{0}/stats", __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lookBackHours"] = Convert.ToString(24);
                if (__workflow_lookBackHours != null)
                    callPayload.Queries["lookBackHours"] = ExpressionConverter.Convert(__workflow_lookBackHours);
                return new ApiConnectionAction<FileStats>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<DomainStats, ApiConnectionActionConfiguration> GetDomainStats(Expression<Func<string>> domainName, Expression<Func<int>> lookBackHours = null)
        {
            var __workflow_domainName = WorkflowExpression.Compile(domainName, nameof(domainName), required: true);
            var __workflow_lookBackHours = WorkflowExpression.Compile(lookBackHours, nameof(lookBackHours), required: false);
            return new DeferredBodyAction<DomainStats, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/domains/{0}/stats", __workflow_domainName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lookBackHours"] = Convert.ToString(24);
                if (__workflow_lookBackHours != null)
                    callPayload.Queries["lookBackHours"] = ExpressionConverter.Convert(__workflow_lookBackHours);
                return new ApiConnectionAction<DomainStats>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<IpStats, ApiConnectionActionConfiguration> GetIpStats(Expression<Func<string>> ipAddress, Expression<Func<int>> lookBackHours = null)
        {
            var __workflow_ipAddress = WorkflowExpression.Compile(ipAddress, nameof(ipAddress), required: true);
            var __workflow_lookBackHours = WorkflowExpression.Compile(lookBackHours, nameof(lookBackHours), required: false);
            return new DeferredBodyAction<IpStats, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ips/{0}/stats", __workflow_ipAddress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lookBackHours"] = Convert.ToString(24);
                if (__workflow_lookBackHours != null)
                    callPayload.Queries["lookBackHours"] = ExpressionConverter.Convert(__workflow_lookBackHours);
                return new ApiConnectionAction<IpStats>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Investigation, ApiConnectionActionConfiguration> GetSingleInvestigation(Expression<Func<string>> investigationId)
        {
            var __workflow_investigationId = WorkflowExpression.Compile(investigationId, nameof(investigationId), required: true);
            return new DeferredBodyAction<Investigation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/investigations/{0}", __workflow_investigationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Investigation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetInvestigationsResponse, ApiConnectionActionConfiguration> GetInvestigations(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<GetInvestigationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/investigations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                return new ApiConnectionAction<GetInvestigationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> CollectInvestigationPackage(Expression<Func<string>> machineId, Expression<Func<CollectInvestigationPackageInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/collectInvestigationPackage", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetInvestigationPackageUriResponse, ApiConnectionActionConfiguration> GetInvestigationPackageUri(Expression<Func<string>> machineActionId)
        {
            var __workflow_machineActionId = WorkflowExpression.Compile(machineActionId, nameof(machineActionId), required: true);
            return new DeferredBodyAction<GetInvestigationPackageUriResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machineactions/{0}/getPackageUri", __workflow_machineActionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetInvestigationPackageUriResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> IsolateMachine(Expression<Func<string>> machineId, Expression<Func<IsolateMachineInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/isolate", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> UnisolateMachine(Expression<Func<string>> machineId, Expression<Func<UnisolateMachineInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/unisolate", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> RestrictAppExecution(Expression<Func<string>> machineId, Expression<Func<RestrictAppExecutionInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/restrictCodeExecution", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> UnrestrictAppExecution(Expression<Func<string>> machineId, Expression<Func<UnrestrictAppExecutionInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/unrestrictCodeExecution", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> RunAntivirusScan(Expression<Func<string>> machineId, Expression<Func<RunAntivirusScanInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/runAntiVirusScan", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction, ApiConnectionActionConfiguration> RunLiveResponse(Expression<Func<string>> machineId, Expression<Func<RunLiveResponseInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MachineAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/runliveresponse", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MachineAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetRemediationActivitiesResponse, ApiConnectionActionConfiguration> GetRemediationActivities(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<GetRemediationActivitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/remediationtasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                return new ApiConnectionAction<GetRemediationActivitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<RemediationActivity, ApiConnectionActionConfiguration> GetSingleRemediationActivity(Expression<Func<string>> remediationId)
        {
            var __workflow_remediationId = WorkflowExpression.Compile(remediationId, nameof(remediationId), required: true);
            return new DeferredBodyAction<RemediationActivity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/remediationtasks/{0}", __workflow_remediationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RemediationActivity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetRemediationActivityMachineListResponse, ApiConnectionActionConfiguration> GetRemediationActivityMachineList(Expression<Func<string>> remediationId)
        {
            var __workflow_remediationId = WorkflowExpression.Compile(remediationId, nameof(remediationId), required: true);
            return new DeferredBodyAction<GetRemediationActivityMachineListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/remediationtasks/{0}/machinereferences", __workflow_remediationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRemediationActivityMachineListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetMachinesResponse, ApiConnectionActionConfiguration> GetMachines(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<GetMachinesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/machines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                return new ApiConnectionAction<GetMachinesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Machine, ApiConnectionActionConfiguration> GetSingleMachine(Expression<Func<string>> machineId)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            return new DeferredBodyAction<Machine, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Machine>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Machine, ApiConnectionActionConfiguration> MachineTag(Expression<Func<string>> machineId, Expression<Func<MachineTagInput>> body)
        {
            var __workflow_machineId = WorkflowExpression.Compile(machineId, nameof(machineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Machine, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/machines/{0}/tags", __workflow_machineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Machine>(callPayload);
            });
        }
    }

    public class WdatpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookSubscriptionTableEntity, ApiConnectionTriggerConfiguration> WebHooksCreateWebHook(Expression<Func<WebHooksCreateWebHookInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyTrigger<WebHookSubscriptionTableEntity, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger<WebHookSubscriptionTableEntity>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnNewRemediationActivityResponse, ApiConnectionTriggerConfiguration> OnNewRemediationActivity(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<OnNewRemediationActivityResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/remediationtasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$orderby"] = Convert.ToString("createdOn desc");
                return new ApiConnectionTrigger<OnNewRemediationActivityResponse>(callPayload, recurrence: recurrence);
            });
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

    public class AdvancedHuntingInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlertSeverityType
    {
        Informational,
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlertStatusType
    {
        Unspecified,
        New,
        InProgress,
        Resolved,
        Hidden
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlertClassificationType
    {
        Unknown,
        FalsePositive,
        TruePositive
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class CreateAlertByReferenceInput
    {
        [JsonProperty("machineId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MachineId { get; set; }

        [JsonProperty("reportId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReportId { get; set; }

        [JsonProperty("eventTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventTime { get; set; }

        [JsonProperty("severity", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAlertByReferenceInputSeverityType Severity { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAlertByReferenceInputCategoryType Category { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("recommendedAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecommendedAction { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAlertByReferenceInputSeverityType
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAlertByReferenceInputCategoryType
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

    public class PatchAlertInput
    {
        [JsonProperty("status")]
        public PatchAlertInputStatusType? Status { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("classification")]
        public PatchAlertInputClassificationType? Classification { get; set; }

        [JsonProperty("determination")]
        public PatchAlertInputDeterminationType? Determination { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PatchAlertInputStatusType
    {
        New,
        InProgress,
        Resolved
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PatchAlertInputClassificationType
    {
        Unknown,
        FalsePositive,
        TruePositive
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PatchAlertInputDeterminationType
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

    public class InitiateInvestigationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class StartInvestigationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LiveResponseCommandStatusCommandStatusType
    {
        Executing,
        Completed,
        Failed,
        PendingResource,
        Submitted,
        Created
    }

    public class CancelSingleMachineActionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
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

    public class CollectInvestigationPackageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
    }

    public class GetInvestigationPackageUriResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class IsolateMachineInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public IsolateMachineInputIsolationTypeType IsolationType { get; set; } = IsolateMachineInputIsolationTypeType.Full;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IsolateMachineInputIsolationTypeType
    {
        Full,
        Selective
    }

    public class UnisolateMachineInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
    }

    public class RestrictAppExecutionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
    }

    public class UnrestrictAppExecutionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
    }

    public class RunAntivirusScanInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RunAntivirusScanInputScanTypeType ScanType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunAntivirusScanInputScanTypeType
    {
        Quick,
        Full
    }

    public class RunLiveResponseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public LiveResponseCommand[] Commands { get; set; }
    }

    public class LiveResponseCommand
    {
        [JsonProperty("type")]
        public LiveResponseCommandTypeType Type { get; set; }

        [JsonProperty("params")]
        public LiveResponseCommandParamsTypeItem[] Params { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RemediationActivityStatusType
    {
        Active,
        Completed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RemediationActivityCategoryType
    {
        Software,
        SecurityConfiguration
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RemediationActivityProductivityImpactRemediationTypeType
    {
        AllExposedAssets,
        NonImpactedAssets
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RemediationActivityPriorityType
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RemediationActivityCompletionMethodType
    {
        Manual,
        Automatic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MachineHealthStatusType
    {
        Active,
        Inactive,
        ImpairedCommunication,
        NoSensorData,
        NoSensorDataImpairedCommunication,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class MachineTagInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MachineTagInputActionType Action { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MachineTagInputActionType
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

    public class WebHooksCreateWebHookInput
    {
        [JsonProperty("clientState", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ClientState { get; set; } = "flow";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ChangeType { get; set; } = "created";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "alerts";

        [JsonProperty("expirationDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ExpirationDateTime { get; set; } = "2038-09-20T12:00:00Z";

        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
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