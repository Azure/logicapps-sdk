//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meisterplan
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeisterplanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseTaskResponse, ApiConnectionActionConfiguration> GetAllTasks(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> key = null)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: false);
            return new DeferredBodyAction<PaginatedResponseTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/taskManagementLink/tasks", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                if (__workflow_key != null)
                    callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<PaginatedResponseTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateOrUpdateTask(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<payloadInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/taskManagementLink/tasks", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplaceTask(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<tasksReplaceRequestInput>> tasksReplaceRequest)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_tasksReplaceRequest = WorkflowExpression.Compile(tasksReplaceRequest, nameof(tasksReplaceRequest), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/taskManagementLink/tasks", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksReplaceRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseMilestoneResponse, ApiConnectionActionConfiguration> GetAllMilestones(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ListResponseMilestoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/milestones", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseMilestoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<MilestoneResponse, ApiConnectionActionConfiguration> CreateMilestone(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<CreateMilestoneInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<MilestoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/milestones", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<MilestoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplaceMilestones(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<ReplaceMilestonesInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/milestones", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseFinancialsResponse, ApiConnectionActionConfiguration> GetAllFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ListResponseFinancialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financials", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseFinancialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialsResponse, ApiConnectionActionConfiguration> CreateFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<CreateFinancialsInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<FinancialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financials", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<FinancialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplaceFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<ReplaceFinancialsInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financials", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseFinancialActualsResponse, ApiConnectionActionConfiguration> GetAllActualFinancialEvents(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ListResponseFinancialActualsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financialActuals", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseFinancialActualsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialActualsResponse, ApiConnectionActionConfiguration> CreateFinancialActuals(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<CreateFinancialActualsInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<FinancialActualsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financialActuals", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<FinancialActualsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplaceFinancialActuals(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<ReplaceFinancialActualsInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financialActuals", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseAllocationResponse, ApiConnectionActionConfiguration> GetAllAllocations(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ListResponseAllocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/allocations", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseAllocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AllocationResponse, ApiConnectionActionConfiguration> CreateOrUpdateAllocation(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<CreateOrUpdateAllocationInput>> allocationCreateOrUpdateRequest)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_allocationCreateOrUpdateRequest = WorkflowExpression.Compile(allocationCreateOrUpdateRequest, nameof(allocationCreateOrUpdateRequest), required: true);
            return new DeferredBodyAction<AllocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/allocations", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_allocationCreateOrUpdateRequest);
                return new ApiConnectionAction<AllocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplaceAllocation(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<ReplaceAllocationInput>> allocationReplaceRequest)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_allocationReplaceRequest = WorkflowExpression.Compile(allocationReplaceRequest, nameof(allocationReplaceRequest), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/allocations", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_allocationReplaceRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseAbsenceResponse, ApiConnectionActionConfiguration> GetAllAbsences(Expression<Func<string>> resourceId, Expression<Func<string>> startDate = null, Expression<Func<string>> finishDate = null)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_finishDate = WorkflowExpression.Compile(finishDate, nameof(finishDate), required: false);
            return new DeferredBodyAction<ListResponseAbsenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}/absences", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_finishDate != null)
                    callPayload.Queries["finishDate"] = ExpressionConverter.Convert(__workflow_finishDate);
                return new ApiConnectionAction<ListResponseAbsenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AbsenceResponse, ApiConnectionActionConfiguration> CreateAbsences(Expression<Func<string>> resourceId, Expression<Func<CreateAbsencesInput>> payload)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<AbsenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}/absences", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<AbsenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplaceAbsences(Expression<Func<string>> resourceId, Expression<Func<ReplaceAbsencesInput>> absences, Expression<Func<string>> start = null, Expression<Func<string>> end = null)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_absences = WorkflowExpression.Compile(absences, nameof(absences), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}/absences", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_absences);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseTeamResponse, ApiConnectionActionConfiguration> GetAllTeams(Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PaginatedResponseTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PaginatedResponseTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TeamResponse, ApiConnectionActionConfiguration> CreateTeam(Expression<Func<payloadInput2>> payload)
        {
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<TeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/teams";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<TeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseRoleCapacityResponse, ApiConnectionActionConfiguration> GetRoleCapacities(Expression<Func<string>> scenarioId, Expression<Func<string>> roleId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            return new DeferredBodyAction<ListResponseRoleCapacityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/roleCapacities/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseRoleCapacityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseRoleCapacityResponse, ApiConnectionActionConfiguration> UpdateRoleCapacities(Expression<Func<string>> scenarioId, Expression<Func<string>> roleId, Expression<Func<UpdateRoleCapacitiesInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ListResponseRoleCapacityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/roleCapacities/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ListResponseRoleCapacityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseAllProjectsResponse, ApiConnectionActionConfiguration> GetAllProjects(Expression<Func<string>> scenarioId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PaginatedResponseAllProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PaginatedResponseAllProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<string>> scenarioId, Expression<Func<payloadInput22>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TaskManagementLinkResponse, ApiConnectionActionConfiguration> GetTaskManagementLink(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<TaskManagementLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/taskManagementLink", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskManagementLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTaskManagementLink(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/taskManagementLink", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TaskManagementLinkResponse, ApiConnectionActionConfiguration> CreateOrUpdateTaskManagementLink(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<payloadInput222>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<TaskManagementLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/taskManagementLink", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<TaskManagementLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseActualTimeWorkedResponse, ApiConnectionActionConfiguration> GetAllActualTimeWorked(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PaginatedResponseActualTimeWorkedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/actuals", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PaginatedResponseActualTimeWorkedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAllActualTimeWorked(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/actuals", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ActualTimeWorkedResponse, ApiConnectionActionConfiguration> CreateOrUpdateActualTimeWorked(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<CreateOrUpdateActualTimeWorkedInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ActualTimeWorkedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/actuals", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ActualTimeWorkedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseProgramGetAllResponse, ApiConnectionActionConfiguration> GetAllPrograms(Expression<Func<string>> scenarioId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PaginatedResponseProgramGetAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/programs", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageSize"] = Convert.ToString(250);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PaginatedResponseProgramGetAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProgramResponse, ApiConnectionActionConfiguration> CreateProgram(Expression<Func<string>> scenarioId, Expression<Func<payloadInput2222>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ProgramResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/programs", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ProgramResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdatePriorities(Expression<Func<string>> scenarioId, Expression<Func<UpdatePrioritiesInput>> prioritiesUpdateRequest)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_prioritiesUpdateRequest = WorkflowExpression.Compile(prioritiesUpdateRequest, nameof(prioritiesUpdateRequest), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/priorities", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_prioritiesUpdateRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseMilestoneDependencyResponse, ApiConnectionActionConfiguration> GetAllMilestoneDependencies(Expression<Func<string>> scenarioId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            return new DeferredBodyAction<PaginatedResponseMilestoneDependencyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/milestoneDependencies", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                return new ApiConnectionAction<PaginatedResponseMilestoneDependencyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<MilestoneDependencyCreateResponse, ApiConnectionActionConfiguration> CreateMilestoneDependency(Expression<Func<string>> scenarioId, Expression<Func<CreateMilestoneDependencyInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<MilestoneDependencyCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/milestoneDependencies", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<MilestoneDependencyCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseRoleResponse, ApiConnectionActionConfiguration> GetAllRoles(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ListResponseRoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/roles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<ListResponseRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<RoleResponse, ApiConnectionActionConfiguration> CreateRole(Expression<Func<CreateRoleInput>> payload)
        {
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<RoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/roles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<RoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseResourceResponse, ApiConnectionActionConfiguration> GetAllResources(Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PaginatedResponseResourceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/resources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PaginatedResponseResourceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ResourceResponse, ApiConnectionActionConfiguration> CreateResource(Expression<Func<CreateResourceInput>> payload)
        {
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ResourceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/resources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ResourceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseCalendarDeviationResponse, ApiConnectionActionConfiguration> GetCalendarDeviations(Expression<Func<string>> resourceId, Expression<Func<string>> start = null, Expression<Func<string>> finish = null)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_finish = WorkflowExpression.Compile(finish, nameof(finish), required: false);
            return new DeferredBodyAction<ListResponseCalendarDeviationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}/calendarDeviations", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_finish != null)
                    callPayload.Queries["finish"] = ExpressionConverter.Convert(__workflow_finish);
                return new ApiConnectionAction<ListResponseCalendarDeviationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseCalendarDeviationResponse, ApiConnectionActionConfiguration> UpdateCalendarDeviations(Expression<Func<string>> resourceId, Expression<Func<UpdateCalendarDeviationsInput>> payload)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ListResponseCalendarDeviationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}/calendarDeviations", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ListResponseCalendarDeviationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseObsTypeResponse, ApiConnectionActionConfiguration> GetAllObsTypes()
        {
            return new DeferredBodyAction<ListResponseObsTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/obsTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseObsTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsTypeResponse, ApiConnectionActionConfiguration> CreateObsType(Expression<Func<CreateObsTypeInput>> payload)
        {
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ObsTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/obsTypes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ObsTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseObsUnitResponse, ApiConnectionActionConfiguration> GetAllObsUnits(Expression<Func<string>> obsTypeId)
        {
            var __workflow_obsTypeId = WorkflowExpression.Compile(obsTypeId, nameof(obsTypeId), required: true);
            return new DeferredBodyAction<ListResponseObsUnitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/obsTypes/{0}/obsUnits", __workflow_obsTypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseObsUnitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsUnitResponse, ApiConnectionActionConfiguration> CreateObsUnit(Expression<Func<string>> obsTypeId, Expression<Func<CreateObsUnitInput>> obsUnitCreateRequest)
        {
            var __workflow_obsTypeId = WorkflowExpression.Compile(obsTypeId, nameof(obsTypeId), required: true);
            var __workflow_obsUnitCreateRequest = WorkflowExpression.Compile(obsUnitCreateRequest, nameof(obsUnitCreateRequest), required: true);
            return new DeferredBodyAction<ObsUnitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/obsTypes/{0}/obsUnits", __workflow_obsTypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_obsUnitCreateRequest);
                return new ApiConnectionAction<ObsUnitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseCalendarResponse, ApiConnectionActionConfiguration> GetAllCalendars()
        {
            return new DeferredBodyAction<ListResponseCalendarResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/calendars";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseCalendarResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<CalendarResponse, ApiConnectionActionConfiguration> CreateCalendar(Expression<Func<CreateCalendarInput>> payload)
        {
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<CalendarResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/calendars";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<CalendarResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseCalendarExceptionResponse, ApiConnectionActionConfiguration> GetAllCalendarExceptions(Expression<Func<string>> calendarId, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<ListResponseCalendarExceptionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/calendars/{0}/exceptions", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<ListResponseCalendarExceptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateCalendarExceptions(Expression<Func<string>> calendarId, Expression<Func<CreateCalendarExceptionsInput>> payload)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/calendars/{0}/exceptions", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetDefaultCalendar(Expression<Func<SetDefaultCalendarInput>> payload)
        {
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/calendars/defaultCalendar";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TeamResponse, ApiConnectionActionConfiguration> GetTeamById(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<TeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/teams/{0}", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTeam(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/teams/{0}", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TeamResponse, ApiConnectionActionConfiguration> UpdateTeam(Expression<Func<string>> teamId, Expression<Func<payloadInput2>> payload)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<TeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/teams/{0}", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<TeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProjectResponse, ApiConnectionActionConfiguration> GetProjectById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteProject(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProjectResponse, ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<payloadInput22222>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<MilestoneResponse, ApiConnectionActionConfiguration> GetMilestoneById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> milestoneId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            return new DeferredBodyAction<MilestoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/milestones/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_milestoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MilestoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteMilestone(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> milestoneId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/milestones/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_milestoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<MilestoneResponse, ApiConnectionActionConfiguration> UpdateMilestone(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> milestoneId, Expression<Func<UpdateMilestoneInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<MilestoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/milestones/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_milestoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<MilestoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialsResponse, ApiConnectionActionConfiguration> GetFinancialsById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> financialsId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_financialsId = WorkflowExpression.Compile(financialsId, nameof(financialsId), required: true);
            return new DeferredBodyAction<FinancialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financials/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_financialsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FinancialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> financialsId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_financialsId = WorkflowExpression.Compile(financialsId, nameof(financialsId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financials/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_financialsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialsResponse, ApiConnectionActionConfiguration> UpdateFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> financialsId, Expression<Func<UpdateFinancialsInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_financialsId = WorkflowExpression.Compile(financialsId, nameof(financialsId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<FinancialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financials/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_financialsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<FinancialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialActualsResponse, ApiConnectionActionConfiguration> GetActualFinancialEventById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualFinancialEventId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_actualFinancialEventId = WorkflowExpression.Compile(actualFinancialEventId, nameof(actualFinancialEventId), required: true);
            return new DeferredBodyAction<FinancialActualsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financialActuals/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_actualFinancialEventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FinancialActualsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFinancialActuals(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualFinancialEventId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_actualFinancialEventId = WorkflowExpression.Compile(actualFinancialEventId, nameof(actualFinancialEventId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financialActuals/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_actualFinancialEventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialActualsResponse, ApiConnectionActionConfiguration> UpdateFinancialActuals(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualFinancialEventId, Expression<Func<UpdateFinancialActualsInput>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_actualFinancialEventId = WorkflowExpression.Compile(actualFinancialEventId, nameof(actualFinancialEventId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<FinancialActualsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/financialActuals/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_actualFinancialEventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<FinancialActualsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AllocationResponse, ApiConnectionActionConfiguration> GetAllocationId(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_allocationId = WorkflowExpression.Compile(allocationId, nameof(allocationId), required: true);
            return new DeferredBodyAction<AllocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/allocations/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_allocationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AllocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAllocation(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_allocationId = WorkflowExpression.Compile(allocationId, nameof(allocationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/allocations/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_allocationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AllocationResponse, ApiConnectionActionConfiguration> UpdateAllocation(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationId, Expression<Func<UpdateAllocationInput>> allocationUpdateRequest)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_allocationId = WorkflowExpression.Compile(allocationId, nameof(allocationId), required: true);
            var __workflow_allocationUpdateRequest = WorkflowExpression.Compile(allocationUpdateRequest, nameof(allocationUpdateRequest), required: true);
            return new DeferredBodyAction<AllocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/allocations/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_allocationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_allocationUpdateRequest);
                return new ApiConnectionAction<AllocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProgramResponse, ApiConnectionActionConfiguration> GetProgramById(Expression<Func<string>> scenarioId, Expression<Func<string>> programId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_programId = WorkflowExpression.Compile(programId, nameof(programId), required: true);
            return new DeferredBodyAction<ProgramResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/programs/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_programId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProgramResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteProgram(Expression<Func<string>> scenarioId, Expression<Func<string>> programId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_programId = WorkflowExpression.Compile(programId, nameof(programId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/programs/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_programId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProgramResponse, ApiConnectionActionConfiguration> UpdateProgram(Expression<Func<string>> scenarioId, Expression<Func<string>> programId, Expression<Func<payloadInput2222>> payload)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_programId = WorkflowExpression.Compile(programId, nameof(programId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ProgramResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/programs/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_programId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ProgramResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<RoleResponse, ApiConnectionActionConfiguration> GetRoleById(Expression<Func<string>> roleId)
        {
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            return new DeferredBodyAction<RoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/roles/{0}", __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRole(Expression<Func<string>> roleId)
        {
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/roles/{0}", __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<RoleResponse, ApiConnectionActionConfiguration> UpdateRole(Expression<Func<string>> roleId, Expression<Func<UpdateRoleInput>> payload)
        {
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<RoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/roles/{0}", __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<RoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ResourceResponse, ApiConnectionActionConfiguration> GetResourceById(Expression<Func<string>> resourceId)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            return new DeferredBodyAction<ResourceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResourceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteResource(Expression<Func<string>> resourceId)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ResourceResponse, ApiConnectionActionConfiguration> UpdateResource(Expression<Func<string>> resourceId, Expression<Func<UpdateResourceInput>> payload)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ResourceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ResourceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AbsenceResponse, ApiConnectionActionConfiguration> GetAbsenceById(Expression<Func<string>> resourceId, Expression<Func<string>> absenceId)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_absenceId = WorkflowExpression.Compile(absenceId, nameof(absenceId), required: true);
            return new DeferredBodyAction<AbsenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}/absences/{1}", __workflow_resourceId.WithUrlEncoding(1), __workflow_absenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AbsenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAbsence(Expression<Func<string>> resourceId, Expression<Func<string>> absenceId)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_absenceId = WorkflowExpression.Compile(absenceId, nameof(absenceId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}/absences/{1}", __workflow_resourceId.WithUrlEncoding(1), __workflow_absenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AbsenceResponse, ApiConnectionActionConfiguration> UpdateAbsences(Expression<Func<string>> resourceId, Expression<Func<string>> absenceId, Expression<Func<UpdateAbsencesInput>> payload)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_absenceId = WorkflowExpression.Compile(absenceId, nameof(absenceId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<AbsenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/resources/{0}/absences/{1}", __workflow_resourceId.WithUrlEncoding(1), __workflow_absenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<AbsenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsTypeResponse, ApiConnectionActionConfiguration> GetObsTypeById(Expression<Func<string>> obsTypeId)
        {
            var __workflow_obsTypeId = WorkflowExpression.Compile(obsTypeId, nameof(obsTypeId), required: true);
            return new DeferredBodyAction<ObsTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/obsTypes/{0}", __workflow_obsTypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ObsTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteObsType(Expression<Func<string>> obsTypeId)
        {
            var __workflow_obsTypeId = WorkflowExpression.Compile(obsTypeId, nameof(obsTypeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/obsTypes/{0}", __workflow_obsTypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsTypeResponse, ApiConnectionActionConfiguration> UpdateObsType(Expression<Func<string>> obsTypeId, Expression<Func<UpdateObsTypeInput>> payload)
        {
            var __workflow_obsTypeId = WorkflowExpression.Compile(obsTypeId, nameof(obsTypeId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<ObsTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/obsTypes/{0}", __workflow_obsTypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<ObsTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsUnitResponse, ApiConnectionActionConfiguration> GetObsUnit(Expression<Func<string>> obsTypeId, Expression<Func<string>> obsUnitId)
        {
            var __workflow_obsTypeId = WorkflowExpression.Compile(obsTypeId, nameof(obsTypeId), required: true);
            var __workflow_obsUnitId = WorkflowExpression.Compile(obsUnitId, nameof(obsUnitId), required: true);
            return new DeferredBodyAction<ObsUnitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/obsTypes/{0}/obsUnits/{1}", __workflow_obsTypeId.WithUrlEncoding(1), __workflow_obsUnitId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ObsUnitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteObsUnit(Expression<Func<string>> obsTypeId, Expression<Func<string>> obsUnitId)
        {
            var __workflow_obsTypeId = WorkflowExpression.Compile(obsTypeId, nameof(obsTypeId), required: true);
            var __workflow_obsUnitId = WorkflowExpression.Compile(obsUnitId, nameof(obsUnitId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/obsTypes/{0}/obsUnits/{1}", __workflow_obsTypeId.WithUrlEncoding(1), __workflow_obsUnitId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsUnitResponse, ApiConnectionActionConfiguration> UpdateObsUnit(Expression<Func<string>> obsTypeId, Expression<Func<string>> obsUnitId, Expression<Func<UpdateObsUnitInput>> obsUnitUpdateRequest)
        {
            var __workflow_obsTypeId = WorkflowExpression.Compile(obsTypeId, nameof(obsTypeId), required: true);
            var __workflow_obsUnitId = WorkflowExpression.Compile(obsUnitId, nameof(obsUnitId), required: true);
            var __workflow_obsUnitUpdateRequest = WorkflowExpression.Compile(obsUnitUpdateRequest, nameof(obsUnitUpdateRequest), required: true);
            return new DeferredBodyAction<ObsUnitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/obsTypes/{0}/obsUnits/{1}", __workflow_obsTypeId.WithUrlEncoding(1), __workflow_obsUnitId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_obsUnitUpdateRequest);
                return new ApiConnectionAction<ObsUnitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<CalendarResponse, ApiConnectionActionConfiguration> GetCalendarById(Expression<Func<string>> calendarId)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyAction<CalendarResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/calendars/{0}", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CalendarResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteCalendarById(Expression<Func<string>> calendarId)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/calendars/{0}", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<CalendarResponse, ApiConnectionActionConfiguration> UpdateCalendar(Expression<Func<string>> calendarId, Expression<Func<UpdateCalendarInput>> payload)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyAction<CalendarResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/calendars/{0}", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction<CalendarResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseUserResponse, ApiConnectionActionConfiguration> GetAllUsers1(Expression<Func<string>> pageAfter = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> filter = null)
        {
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PaginatedResponseUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PaginatedResponseUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> GetUser1(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<SprintResponse, ApiConnectionActionConfiguration> GetSprintById(Expression<Func<string>> sprintId)
        {
            var __workflow_sprintId = WorkflowExpression.Compile(sprintId, nameof(sprintId), required: true);
            return new DeferredBodyAction<SprintResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/sprints/{0}", __workflow_sprintId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SprintResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseScenarioResponse, ApiConnectionActionConfiguration> GetAllScenarios()
        {
            return new DeferredBodyAction<ListResponseScenarioResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/scenarios";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseScenarioResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ScenarioResponse, ApiConnectionActionConfiguration> GetScenarioById(Expression<Func<string>> scenarioId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            return new DeferredBodyAction<ScenarioResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ScenarioResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseRoleWithRoleCapacityResponse, ApiConnectionActionConfiguration> GetAllRoleCapacities(Expression<Func<string>> scenarioId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            return new DeferredBodyAction<ListResponseRoleWithRoleCapacityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/roleCapacities", __workflow_scenarioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseRoleWithRoleCapacityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TaskResponse, ApiConnectionActionConfiguration> GetTaskById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> taskId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/taskManagementLink/tasks/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTask(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> taskId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/taskManagementLink/tasks/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseProjectCommentResponse, ApiConnectionActionConfiguration> GetAllProjectComments(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> pageAfter = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<PaginatedResponseProjectCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/comments", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<PaginatedResponseProjectCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProjectCommentResponse, ApiConnectionActionConfiguration> GetProjectComment(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> commentId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            return new DeferredBodyAction<ProjectCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/comments/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseAllocationCommentResponse, ApiConnectionActionConfiguration> GetAllAllocationComments(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> pageAfter = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_pageAfter = WorkflowExpression.Compile(pageAfter, nameof(pageAfter), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<PaginatedResponseAllocationCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/allocationComments", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageAfter != null)
                    callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(__workflow_pageAfter);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<PaginatedResponseAllocationCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AllocationCommentResponse, ApiConnectionActionConfiguration> GetAllocationComment(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationCommentId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_allocationCommentId = WorkflowExpression.Compile(allocationCommentId, nameof(allocationCommentId), required: true);
            return new DeferredBodyAction<AllocationCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/allocationComments/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_allocationCommentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AllocationCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ActualTimeWorkedByIdResponse, ApiConnectionActionConfiguration> GetActualTimeWorkedById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualsId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_actualsId = WorkflowExpression.Compile(actualsId, nameof(actualsId), required: true);
            return new DeferredBodyAction<ActualTimeWorkedByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/actuals/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_actualsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ActualTimeWorkedByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteActualTimeWorkedById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualsId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_actualsId = WorkflowExpression.Compile(actualsId, nameof(actualsId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/projects/{1}/actuals/{2}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1), __workflow_actualsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponsePortfolioResponse, ApiConnectionActionConfiguration> GetAllPortfolios()
        {
            return new DeferredBodyAction<ListResponsePortfolioResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/portfolios";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponsePortfolioResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseBusinessGoalDefinitionResponse, ApiConnectionActionConfiguration> GetAllBusinessGoals()
        {
            return new DeferredBodyAction<ListResponseBusinessGoalDefinitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/businessGoals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListResponseBusinessGoalDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteMilestoneDependency(Expression<Func<string>> scenarioId, Expression<Func<string>> milestoneDependencyId)
        {
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: true);
            var __workflow_milestoneDependencyId = WorkflowExpression.Compile(milestoneDependencyId, nameof(milestoneDependencyId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenarios/{0}/milestoneDependencies/{1}", __workflow_scenarioId.WithUrlEncoding(1), __workflow_milestoneDependencyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class MeisterplanTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> CreateWebhook(Expression<Func<CreateWebhookInput>> payload, FlowRecurrence recurrence = null)
        {
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class PaginatedResponseTaskResponse
    {
        [JsonProperty("items")]
        public TaskResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class TaskResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public TaskResponseStatusType Status { get; set; }

        [JsonProperty("externalViewUrl")]
        public string ExternalViewUrl { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("effort")]
        public TaskEffortResponse Effort { get; set; }

        [JsonProperty("sprint")]
        public SprintReferenceResponse Sprint { get; set; }

        [JsonProperty("dependencies")]
        public TaskDependenciesResponse Dependencies { get; set; }

        [JsonProperty("type")]
        public TaskResponseTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskResponseStatusType
    {
        OPEN,
        CLOSED,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS
    }

    public class TaskEffortResponse
    {
        [JsonProperty("assignments")]
        public TaskAssignmentResponse[] Assignments { get; set; }

        [JsonProperty("totalRemainingEffort")]
        public EffortValueResponse TotalRemainingEffort { get; set; }

        [JsonProperty("totalCompletedEffort")]
        public EffortValueResponse TotalCompletedEffort { get; set; }
    }

    public class TaskAssignmentResponse
    {
        [JsonProperty("entity")]
        public TaskAssigmentEntityResponse Entity { get; set; }

        [JsonProperty("remainingEffort")]
        public EffortValueResponse RemainingEffort { get; set; }

        [JsonProperty("completedEffort")]
        public EffortValueResponse CompletedEffort { get; set; }
    }

    public class TaskAssigmentEntityResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public TaskAssigmentEntityResponseTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskAssigmentEntityResponseTypeType
    {
        ROLE,
        RESOURCE,
        TEAM,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public class EffortValueResponse
    {
        [JsonProperty("computedHours")]
        public double ComputedHours { get; set; }

        [JsonProperty("unit")]
        public EffortValueResponseUnitType Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EffortValueResponseUnitType
    {
        HOURS,
        [EnumMember(Value = "STORY_POINTS")]
        STORYPOINTS
    }

    public class SprintReferenceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class TaskDependenciesResponse
    {
        [JsonProperty("blocks")]
        public TaskDependencyResponse[] Blocks { get; set; }

        [JsonProperty("blockedBy")]
        public TaskDependencyResponse[] BlockedBy { get; set; }
    }

    public class TaskDependencyResponse
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskResponseTypeType
    {
        [EnumMember(Value = "TASK")]
        TaskObject,
        MILESTONE
    }

    public class Pagination
    {
        [JsonProperty("after")]
        public CursorInfo After { get; set; }
    }

    public class CursorInfo
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class payloadInput
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public payloadInputStatusType Status { get; set; }

        [JsonProperty("externalViewUrl")]
        public string ExternalViewUrl { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("effort")]
        public Effort Effort { get; set; }

        [JsonProperty("sprint")]
        public Sprint Sprint { get; set; }

        [JsonProperty("dependencies")]
        public TaskDependencies Dependencies { get; set; }

        [JsonProperty("type")]
        public payloadInputTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum payloadInputStatusType
    {
        OPEN,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        CLOSED
    }

    public class Effort
    {
        [JsonProperty("assignments")]
        public Assignment[] Assignments { get; set; }

        [JsonProperty("remainingEffort")]
        public EffortValue RemainingEffort { get; set; }

        [JsonProperty("completedEffort")]
        public EffortValue CompletedEffort { get; set; }
    }

    public class Assignment
    {
        [JsonProperty("entity")]
        public AssignmentEntity Entity { get; set; }

        [JsonProperty("remainingEffort")]
        public EffortValue RemainingEffort { get; set; }

        [JsonProperty("completedEffort")]
        public EffortValue CompletedEffort { get; set; }
    }

    public class AssignmentEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public AssignmentEntityTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssignmentEntityTypeType
    {
        ROLE,
        RESOURCE,
        TEAM,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public class EffortValue
    {
        [JsonProperty("hours")]
        public double Hours { get; set; }

        [JsonProperty("storyPoints")]
        public double StoryPoints { get; set; }
    }

    public class Sprint
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDate { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDate { get; set; }
    }

    public class TaskDependencies
    {
        [JsonProperty("blocks")]
        public TaskDependency[] Blocks { get; set; }

        [JsonProperty("blockedBy")]
        public TaskDependency[] BlockedBy { get; set; }
    }

    public class TaskDependency
    {
        [JsonProperty("taskKey")]
        public string TaskKey { get; set; }

        [JsonProperty("projectKey")]
        public string ProjectKey { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum payloadInputTypeType
    {
        [EnumMember(Value = "TASK")]
        TaskObject,
        MILESTONE
    }

    public class tasksReplaceRequestInput
    {
        [JsonProperty("items")]
        public TaskReplaceRequestItem[] Items { get; set; }
    }

    public class TaskReplaceRequestItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public TaskReplaceRequestItemStatusType Status { get; set; }

        [JsonProperty("externalViewUrl")]
        public string ExternalViewUrl { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("effort")]
        public Effort Effort { get; set; }

        [JsonProperty("sprint")]
        public Sprint Sprint { get; set; }

        [JsonProperty("dependencies")]
        public TaskDependencies Dependencies { get; set; }

        [JsonProperty("type")]
        public TaskReplaceRequestItemTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskReplaceRequestItemStatusType
    {
        OPEN,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        CLOSED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskReplaceRequestItemTypeType
    {
        [EnumMember(Value = "TASK")]
        TaskObject,
        MILESTONE
    }

    public class ListResponseMilestoneResponse
    {
        [JsonProperty("items")]
        public MilestoneResponse[] Items { get; set; }
    }

    public class MilestoneResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("projectPhase")]
        public ProjectPhaseResponse ProjectPhase { get; set; }

        [JsonProperty("status")]
        public StatusResponse Status { get; set; }
    }

    public class ProjectPhaseResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class StatusResponse
    {
        [JsonProperty("value")]
        public StatusResponseValueType Value { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatusResponseValueType
    {
        [EnumMember(Value = "ON_TRACK")]
        ONTRACK,
        [EnumMember(Value = "NEEDS_ATTENTION")]
        NEEDSATTENTION,
        [EnumMember(Value = "OFF_TRACK")]
        OFFTRACK,
        DONE
    }

    public class CreateMilestoneInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("projectPhase")]
        public ProjectPhase ProjectPhase { get; set; }

        [JsonProperty("status")]
        public MilestoneStatus Status { get; set; }
    }

    public class ProjectPhase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class MilestoneStatus
    {
        [JsonProperty("value")]
        public MilestoneStatusValueType Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MilestoneStatusValueType
    {
        [EnumMember(Value = "ON_TRACK")]
        ONTRACK,
        [EnumMember(Value = "NEEDS_ATTENTION")]
        NEEDSATTENTION,
        [EnumMember(Value = "OFF_TRACK")]
        OFFTRACK,
        DONE
    }

    public class ReplaceMilestonesInput
    {
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Include)]
        public Milestone[] Milestones { get; set; }
    }

    public class Milestone
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("projectPhase")]
        public ProjectPhase ProjectPhase { get; set; }

        [JsonProperty("status")]
        public MilestoneStatus Status { get; set; }
    }

    public class ListResponseFinancialsResponse
    {
        [JsonProperty("items")]
        public FinancialsResponse[] Items { get; set; }
    }

    public class FinancialsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public FinancialsResponseTypeType Type { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("timing")]
        public FinancialsTimingResponse Timing { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public FinanceCategoryResponse Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FinancialsResponseTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public class FinancialsTimingResponse
    {
        [JsonProperty("on")]
        public FinancialsTimingResponseOnType On { get; set; }

        [JsonProperty("milestoneId")]
        public string MilestoneId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FinancialsTimingResponseOnType
    {
        ProjectStart,
        ProjectFinish,
        Milestone,
        Date
    }

    public class FinanceCategoryResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateFinancialsInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateFinancialsInputTypeType Type { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("timing", DefaultValueHandling = DefaultValueHandling.Include)]
        public Timing Timing { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateFinancialsInputTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public class Timing
    {
        [JsonProperty("on")]
        public TimingOnType On { get; set; }

        [JsonProperty("milestoneId")]
        public string MilestoneId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimingOnType
    {
        ProjectStart,
        ProjectFinish,
        Milestone,
        Date
    }

    public class Category
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReplaceFinancialsInput
    {
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Include)]
        public FinancialEvent[] Financials { get; set; }
    }

    public class FinancialEvent
    {
        [JsonProperty("type")]
        public FinancialEventTypeType Type { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("timing")]
        public Timing Timing { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FinancialEventTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public class ListResponseFinancialActualsResponse
    {
        [JsonProperty("items")]
        public FinancialActualsResponse[] Items { get; set; }
    }

    public class FinancialActualsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public FinancialActualsResponseTypeType Type { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public FinanceCategoryResponse Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FinancialActualsResponseTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public class CreateFinancialActualsInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateFinancialActualsInputTypeType Type { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("bookingDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BookingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateFinancialActualsInputTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public class ReplaceFinancialActualsInput
    {
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Include)]
        public FinancialActualsCreateOrReplaceRequest[] FinancialActuals { get; set; }
    }

    public class FinancialActualsCreateOrReplaceRequest
    {
        [JsonProperty("type")]
        public FinancialActualsCreateOrReplaceRequestTypeType Type { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FinancialActualsCreateOrReplaceRequestTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public class ListResponseAllocationResponse
    {
        [JsonProperty("items")]
        public AllocationResponse[] Items { get; set; }
    }

    public class AllocationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("allocatedEntity")]
        public AllocatedEntityResponse AllocatedEntity { get; set; }

        [JsonProperty("segments")]
        public AllocationSegmentResponse[] Segments { get; set; }
    }

    public class AllocatedEntityResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public AllocatedEntityResponseTypeType Type { get; set; }

        [JsonProperty("projectRole")]
        public string ProjectRole { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AllocatedEntityResponseTypeType
    {
        ROLE,
        RESOURCE,
        TEAM,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public class AllocationSegmentResponse
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }
    }

    public class CreateOrUpdateAllocationInput
    {
        [JsonProperty("allocatedEntity", DefaultValueHandling = DefaultValueHandling.Include)]
        public AllocatedEntity AllocatedEntity { get; set; }

        [JsonProperty("segments")]
        public AllocationSegment[] Segments { get; set; }
    }

    public class AllocatedEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public AllocatedEntityTypeType Type { get; set; }

        [JsonProperty("projectRole")]
        public string ProjectRole { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AllocatedEntityTypeType
    {
        ROLE,
        RESOURCE,
        TEAM,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public class AllocationSegment
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("fte")]
        public double Fte { get; set; }

        [JsonProperty("days")]
        public double Days { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }
    }

    public class ReplaceAllocationInput
    {
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Include)]
        public Allocation[] Items { get; set; }
    }

    public class Allocation
    {
        [JsonProperty("allocatedEntity")]
        public AllocatedEntity AllocatedEntity { get; set; }

        [JsonProperty("segments")]
        public AllocationSegment[] Segments { get; set; }
    }

    public class ListResponseAbsenceResponse
    {
        [JsonProperty("items")]
        public AbsenceResponse[] Items { get; set; }
    }

    public class AbsenceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("finish")]
        public string FinishDate { get; set; }

        [JsonProperty("startDayType")]
        public AbsenceResponseStartAbsenceDayTypeType StartAbsenceDayType { get; set; }

        [JsonProperty("finishDayType")]
        public AbsenceResponseFinishAbsenceDayTypeType FinishAbsenceDayType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AbsenceResponseStartAbsenceDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AbsenceResponseFinishAbsenceDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    public class CreateAbsencesInput
    {
        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Start { get; set; }

        [JsonProperty("finish", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Finish { get; set; }

        [JsonProperty("startDayType")]
        public CreateAbsencesInputStartDayTypeType? StartDayType { get; set; }

        [JsonProperty("finishDayType")]
        public CreateAbsencesInputFinishDayTypeType? FinishDayType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAbsencesInputStartDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAbsencesInputFinishDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    public class ReplaceAbsencesInput
    {
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAbsenceRequest[] Absences { get; set; }
    }

    public class CreateAbsenceRequest
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("startDayType")]
        public CreateAbsenceRequestStartDayTypeType StartDayType { get; set; }

        [JsonProperty("finishDayType")]
        public CreateAbsenceRequestFinishDayTypeType FinishDayType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAbsenceRequestStartDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAbsenceRequestFinishDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    public class PaginatedResponseTeamResponse
    {
        [JsonProperty("items")]
        public TeamResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class TeamResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resourceManager")]
        public ResourceManagerResponse ResourceManager { get; set; }

        [JsonProperty("primaryRole")]
        public MinimalPrimaryRoleResponse PrimaryRole { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("costRates")]
        public CostRateResponse[] CostRates { get; set; }

        [JsonProperty("standardBillingRatePerHour")]
        public double StandardBillingRatePerHour { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("status")]
        public TeamResponseStatusType Status { get; set; }

        [JsonProperty("velocity")]
        public VelocityResponse Velocity { get; set; }

        [JsonProperty("period")]
        public TeamPeriodResponse Period { get; set; }
    }

    public class ResourceManagerResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class MinimalPrimaryRoleResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CostRateResponse
    {
        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("costPerHourValidFrom")]
        public string CostPerHourValidFrom { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TeamResponseStatusType
    {
        ACTIVE,
        INACTIVE,
        FUTURE
    }

    public class VelocityResponse
    {
        [JsonProperty("storyPointsPerPersonDay")]
        public double StoryPointsPerPersonDay { get; set; }
    }

    public class TeamPeriodResponse
    {
        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("finish")]
        public string FinishDate { get; set; }
    }

    public class payloadInput2
    {
        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primaryRole")]
        public PrimaryRole PrimaryRole { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("resourceManager")]
        public ResourceManager ResourceManager { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("costPerHourValidFrom")]
        public string CostPerHourValidFrom { get; set; }

        [JsonProperty("costRates")]
        public CostRate[] CostRates { get; set; }

        [JsonProperty("standardBillingRatePerHour")]
        public double StandardBillingRatePerHour { get; set; }

        [JsonProperty("velocity")]
        public Velocity Velocity { get; set; }
    }

    public class PrimaryRole
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ResourceManager
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class CostRate
    {
        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("costPerHourValidFrom")]
        public string CostPerHourValidFrom { get; set; }
    }

    public class Velocity
    {
        [JsonProperty("storyPointsPerPersonDay")]
        public double StoryPointsPerPersonDay { get; set; }
    }

    public class ListResponseRoleCapacityResponse
    {
        [JsonProperty("items")]
        public RoleCapacityResponse[] Items { get; set; }
    }

    public class RoleCapacityResponse
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("fte")]
        public double Fte { get; set; }
    }

    public class UpdateRoleCapacitiesInput
    {
        [JsonProperty("segments", DefaultValueHandling = DefaultValueHandling.Include)]
        public CapacitySegment[] Segments { get; set; }
    }

    public class CapacitySegment
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("fte")]
        public double Fte { get; set; }

        [JsonProperty("days")]
        public double Days { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }
    }

    public class PaginatedResponseAllProjectsResponse
    {
        [JsonProperty("items")]
        public AllProjectsResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class AllProjectsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("projectKey")]
        public string ProjectKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectType")]
        public ProjectTypeFieldResponse ProjectType { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("manager")]
        public ResourceReferenceResponse Manager { get; set; }

        [JsonProperty("costType")]
        public AllProjectsResponseCostTypeType CostType { get; set; }

        [JsonProperty("status")]
        public StatusFieldResponse Status { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("businessGoal")]
        public BusinessGoalResponse BusinessGoal { get; set; }

        [JsonProperty("approvedTotalEffort")]
        public ApprovedTotalEffortResponse ApprovedTotalEffort { get; set; }

        [JsonProperty("approvedBudget")]
        public double ApprovedBudget { get; set; }

        [JsonProperty("approvedOpexBudget")]
        public double ApprovedOpExBudget { get; set; }

        [JsonProperty("approvedCapexBudget")]
        public double ApprovedCapExBudget { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("program")]
        public ProgramLinkResponse Program { get; set; }

        [JsonProperty("viewUrl")]
        public string ViewUrl { get; set; }

        [JsonProperty("lastChanged")]
        public string LastChanged { get; set; }

        [JsonProperty("priority")]
        public AllProjectsPriorityResponse Priority { get; set; }
    }

    public class ProjectTypeFieldResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ResourceReferenceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AllProjectsResponseCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class StatusFieldResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BusinessGoalResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ApprovedTotalEffortResponse
    {
        [JsonProperty("hours")]
        public double Hours { get; set; }
    }

    public class ProgramLinkResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("programKey")]
        public string Key { get; set; }
    }

    public class AllProjectsPriorityResponse
    {
        [JsonProperty("rankCategory")]
        public AllProjectsPriorityResponseRankCategoryType RankCategory { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AllProjectsPriorityResponseRankCategoryType
    {
        [EnumMember(Value = "ABOVE_MUST_HAVE")]
        ABOVEMUSTHAVE,
        [EnumMember(Value = "BELOW_CUT_OFF")]
        BELOWCUTOFF,
        REGULAR
    }

    public class ProjectResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("projectKey")]
        public string ProjectKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectType")]
        public ProjectTypeFieldResponse ProjectType { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("manager")]
        public ResourceReferenceResponse Manager { get; set; }

        [JsonProperty("costType")]
        public ProjectResponseCostTypeType CostType { get; set; }

        [JsonProperty("status")]
        public StatusFieldResponse Status { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("businessGoal")]
        public BusinessGoalResponse BusinessGoal { get; set; }

        [JsonProperty("approvedTotalEffort")]
        public ApprovedTotalEffortResponse ApprovedTotalEffort { get; set; }

        [JsonProperty("approvedBudget")]
        public double ApprovedBudget { get; set; }

        [JsonProperty("approvedCapexBudget")]
        public double ApprovedCapExBudget { get; set; }

        [JsonProperty("approvedOpexBudget")]
        public double ApprovedOpExBudget { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("program")]
        public ProgramLinkResponse Program { get; set; }

        [JsonProperty("viewUrl")]
        public string ViewUrl { get; set; }

        [JsonProperty("lastChanged")]
        public string LastChanged { get; set; }

        [JsonProperty("priority")]
        public PriorityResponse Priority { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProjectResponseCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class PriorityResponse
    {
        [JsonProperty("rankCategory")]
        public PriorityResponseRankCategoryType RankCategory { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PriorityResponseRankCategoryType
    {
        [EnumMember(Value = "ABOVE_MUST_HAVE")]
        ABOVEMUSTHAVE,
        [EnumMember(Value = "BELOW_CUT_OFF")]
        BELOWCUTOFF,
        REGULAR
    }

    public class payloadInput22
    {
        [JsonProperty("projectKey")]
        public string ProjectKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectType")]
        public ProjectType ProjectType { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("costType")]
        public payloadInputCostTypeType CostType { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("manager")]
        public Manager Manager { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("businessGoal")]
        public BusinessGoal BusinessGoal { get; set; }

        [JsonProperty("approvedTotalEffort")]
        public ApprovedTotalEffort ApprovedTotalEffort { get; set; }

        [JsonProperty("approvedBudget")]
        public double ApprovedBudget { get; set; }

        [JsonProperty("approvedCapexBudget")]
        public double ApprovedCapExBudget { get; set; }

        [JsonProperty("approvedOpexBudget")]
        public double ApprovedOpExBudget { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("obsUnits")]
        public JToken OBSUnits { get; set; }

        [JsonProperty("program")]
        public Program Program { get; set; }

        [JsonProperty("priority")]
        public Priority Priority { get; set; }
    }

    public class ProjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum payloadInputCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class Manager
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class Status
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BusinessGoal
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ApprovedTotalEffort
    {
        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("days")]
        public string Days { get; set; }
    }

    public class Program
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("programKey")]
        public string Key { get; set; }
    }

    public class Priority
    {
        [JsonProperty("rankCategory")]
        public RankCategory RankCategory { get; set; }
    }

    public class RankCategory
    {
        [JsonProperty("category")]
        public RankCategoryCategoryType Category { get; set; }

        [JsonProperty("position")]
        public RankCategoryPositionType Position { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RankCategoryCategoryType
    {
        [EnumMember(Value = "ABOVE_MUST_HAVE")]
        ABOVEMUSTHAVE,
        REGULAR,
        [EnumMember(Value = "BELOW_CUT_OFF")]
        BELOWCUTOFF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RankCategoryPositionType
    {
        LAST,
        FIRST
    }

    public class TaskManagementLinkResponse
    {
        [JsonProperty("toolKey")]
        public string ToolKey { get; set; }

        [JsonProperty("externalViewUrl")]
        public string ExternalViewURL { get; set; }

        [JsonProperty("projectIdOrKeyInTool")]
        public string ProjectIdOrKeyInTool { get; set; }

        [JsonProperty("linkType")]
        public string LinkType { get; set; }
    }

    public class payloadInput222
    {
        [JsonProperty("toolKey")]
        public string ToolKey { get; set; }

        [JsonProperty("externalViewUrl")]
        public string ExternalViewURL { get; set; }
    }

    public class PaginatedResponseActualTimeWorkedResponse
    {
        [JsonProperty("items")]
        public ActualTimeWorkedResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class ActualTimeWorkedResponse
    {
        [JsonProperty("bookedEntity")]
        public ActualsEntityLinkResponse BookedEntity { get; set; }

        [JsonProperty("bookings")]
        public ActualsBookingResponse[] Bookings { get; set; }
    }

    public class ActualsEntityLinkResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public ActualsEntityLinkResponseTypeType Type { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActualsEntityLinkResponseTypeType
    {
        ROLE,
        RESOURCE,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public class ActualsBookingResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }

        [JsonProperty("costType")]
        public ActualsBookingResponseCostTypeType CostType { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActualsBookingResponseCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class CreateOrUpdateActualTimeWorkedInput
    {
        [JsonProperty("bookedEntity", DefaultValueHandling = DefaultValueHandling.Include)]
        public BookedEntity BookedEntity { get; set; }

        [JsonProperty("bookings", DefaultValueHandling = DefaultValueHandling.Include)]
        public Bookings[] Bookings { get; set; }

        [JsonProperty("mode")]
        public CreateOrUpdateActualTimeWorkedInputModeType? Mode { get; set; }
    }

    public class BookedEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public BookedEntityTypeType Type { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BookedEntityTypeType
    {
        ROLE,
        RESOURCE,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public class Bookings
    {
        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }

        [JsonProperty("costType")]
        public BookingsCostTypeType CostType { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BookingsCostTypeType
    {
        CAPEX,
        OPEX
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrUpdateActualTimeWorkedInputModeType
    {
        ADD,
        REPLACE
    }

    public class PaginatedResponseProgramGetAllResponse
    {
        [JsonProperty("items")]
        public ProgramGetAllResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class ProgramGetAllResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("programKey")]
        public string ProgramKey { get; set; }
    }

    public class ProgramResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("goal")]
        public BusinessGoalResponse Goal { get; set; }

        [JsonProperty("lastChanged")]
        public string LastChanged { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("programKey")]
        public string ProgramKey { get; set; }

        [JsonProperty("manager")]
        public ResourceReferenceResponse Manager { get; set; }

        [JsonProperty("rankCategory")]
        public SingleValueStringResponse RankCategory { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public SingleValueStringResponse Status { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("viewUrl")]
        public string ViewURL { get; set; }
    }

    public class SingleValueStringResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class payloadInput2222
    {
        [JsonProperty("goal")]
        public BusinessGoal Goal { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("programKey")]
        public string ProgramKey { get; set; }

        [JsonProperty("manager")]
        public GenericResourceReferenceRequest Manager { get; set; }

        [JsonProperty("status")]
        public SingleValueFieldRequest Status { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }
    }

    public class GenericResourceReferenceRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class SingleValueFieldRequest
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdatePrioritiesInput
    {
        [JsonProperty("aboveMustHave")]
        public Priorities AboveMustHave { get; set; }

        [JsonProperty("regular")]
        public Priorities Regular { get; set; }

        [JsonProperty("belowCutOff")]
        public Priorities BelowCutOff { get; set; }
    }

    public class Priorities
    {
        [JsonProperty("items")]
        public PriorityEntry[] Items { get; set; }

        [JsonProperty("position")]
        public PrioritiesPositionType Position { get; set; }
    }

    public class PriorityEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PrioritiesPositionType
    {
        FIRST,
        LAST
    }

    public class PaginatedResponseMilestoneDependencyResponse
    {
        [JsonProperty("items")]
        public MilestoneDependencyResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class MilestoneDependencyResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("from")]
        public MilestoneReferenceResponse From { get; set; }

        [JsonProperty("to")]
        public MilestoneReferenceResponse To { get; set; }
    }

    public class MilestoneReferenceResponse
    {
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("milestoneId")]
        public string MilestoneId { get; set; }
    }

    public class MilestoneDependencyCreateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateMilestoneDependencyInput
    {
        [JsonProperty("fromMilestoneId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromMilestoneId { get; set; }

        [JsonProperty("toMilestoneId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToMilestoneId { get; set; }
    }

    public class ListResponseRoleResponse
    {
        [JsonProperty("items")]
        public RoleResponse[] Items { get; set; }
    }

    public class RoleResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("costType")]
        public RoleResponseCostTypeType CostType { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("resourceManager")]
        public ResourceManagerResponse ResourceManager { get; set; }

        [JsonProperty("costRates")]
        public CostRateResponse[] CostRates { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RoleResponseCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class CreateRoleInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("costType")]
        public CreateRoleInputCostTypeType? CostType { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("resourceManager")]
        public ResourceManager ResourceManager { get; set; }

        [JsonProperty("costPerHour")]
        public double? CostPerHour { get; set; }

        [JsonProperty("costPerHourValidFrom")]
        public string CostPerHourValidFrom { get; set; }

        [JsonProperty("costRates")]
        public CostRate[] CostRates { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateRoleInputCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class PaginatedResponseResourceResponse
    {
        [JsonProperty("items")]
        public ResourceResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class ResourceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("postalAddress")]
        public PostalAddressResponse PostalAddress { get; set; }

        [JsonProperty("employmentPeriod")]
        public EmploymentPeriodResponse EmploymentPeriod { get; set; }

        [JsonProperty("externalResource")]
        public bool ExternalResource { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("primaryRole")]
        public PrimaryRoleResponse PrimaryRole { get; set; }

        [JsonProperty("calendar")]
        public ResourceCalendarResponse Calendar { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("resourceManager")]
        public ResourceManagerResponse ResourceManager { get; set; }

        [JsonProperty("costRates")]
        public CostRateResponse[] CostRates { get; set; }
    }

    public class PostalAddressResponse
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class EmploymentPeriodResponse
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("terminationDate")]
        public string TerminationDate { get; set; }
    }

    public class PrimaryRoleResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("costType")]
        public PrimaryRoleResponseCostTypeType CostType { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("obsUnits")]
        public JToken OBSUnits { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PrimaryRoleResponseCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class ResourceCalendarResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class CreateResourceInput
    {
        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("postalAddress")]
        public PostalAddress PostalAddress { get; set; }

        [JsonProperty("employmentPeriod")]
        public EmploymentPeriod EmploymentPeriod { get; set; }

        [JsonProperty("externalResource")]
        public bool? ExternalResource { get; set; }

        [JsonProperty("primaryRole")]
        public PrimaryRole PrimaryRole { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("resourceManager")]
        public ResourceManager ResourceManager { get; set; }

        [JsonProperty("costPerHour")]
        public double? CostPerHour { get; set; }

        [JsonProperty("costPerHourValidFrom")]
        public string CostPerHourValidFrom { get; set; }

        [JsonProperty("costRates")]
        public CostRate[] CostRates { get; set; }
    }

    public class PostalAddress
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class EmploymentPeriod
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("terminationDate")]
        public string TerminationDate { get; set; }
    }

    public class Calendar
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListResponseCalendarDeviationResponse
    {
        [JsonProperty("items")]
        public CalendarDeviationResponse[] Items { get; set; }
    }

    public class CalendarDeviationResponse
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("relativeCapacity")]
        public double RelativeCapacity { get; set; }
    }

    public class UpdateCalendarDeviationsInput
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("deviations", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalendarDeviation[] Deviations { get; set; }
    }

    public class CalendarDeviation
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("relativeCapacity")]
        public double RelativeCapacity { get; set; }
    }

    public class ListResponseObsTypeResponse
    {
        [JsonProperty("items")]
        public ObsTypeResponse[] Items { get; set; }
    }

    public class ObsTypeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateObsTypeInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ListResponseObsUnitResponse
    {
        [JsonProperty("items")]
        public ObsUnitResponse[] Items { get; set; }
    }

    public class ObsUnitResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class CreateObsUnitInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class ListResponseCalendarResponse
    {
        [JsonProperty("items")]
        public CalendarResponse[] Items { get; set; }
    }

    public class CalendarResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("workingHours")]
        public WorkingHoursResponse WorkingHours { get; set; }
    }

    public class WorkingHoursResponse
    {
        [JsonProperty("monday")]
        public double Monday { get; set; }

        [JsonProperty("tuesday")]
        public double Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public double Wednesday { get; set; }

        [JsonProperty("thursday")]
        public double Thursday { get; set; }

        [JsonProperty("friday")]
        public double Friday { get; set; }

        [JsonProperty("saturday")]
        public double Saturday { get; set; }

        [JsonProperty("sunday")]
        public double Sunday { get; set; }
    }

    public class CreateCalendarInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("workingHours", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkingHours WorkingHours { get; set; }
    }

    public class WorkingHours
    {
        [JsonProperty("monday")]
        public double Monday { get; set; }

        [JsonProperty("tuesday")]
        public double Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public double Wednesday { get; set; }

        [JsonProperty("thursday")]
        public double Thursday { get; set; }

        [JsonProperty("friday")]
        public double Friday { get; set; }

        [JsonProperty("saturday")]
        public double Saturday { get; set; }

        [JsonProperty("sunday")]
        public double Sunday { get; set; }
    }

    public class ListResponseCalendarExceptionResponse
    {
        [JsonProperty("items")]
        public CalendarExceptionResponse[] Items { get; set; }
    }

    public class CalendarExceptionResponse
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("workingHours")]
        public double WorkingHours { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sourceCalendarId")]
        public string SourceCalendarId { get; set; }
    }

    public class CreateCalendarExceptionsInput
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("exceptions", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalendarException[] Exceptions { get; set; }
    }

    public class CalendarException
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("workingHours")]
        public double WorkingHours { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SetDefaultCalendarInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class payloadInput22222
    {
        [JsonProperty("projectKey")]
        public string ProjectKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectType")]
        public ProjectType ProjectType { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("manager")]
        public Manager Manager { get; set; }

        [JsonProperty("costType")]
        public payloadInputCostTypeType CostType { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("businessGoal")]
        public BusinessGoal BusinessGoal { get; set; }

        [JsonProperty("approvedTotalEffort")]
        public ApprovedTotalEffort ApprovedTotalEffort { get; set; }

        [JsonProperty("approvedBudget")]
        public double ApprovedBudget { get; set; }

        [JsonProperty("approvedCapexBudget")]
        public double ApprovedCapExBudget { get; set; }

        [JsonProperty("approvedOpexBudget")]
        public double ApprovedOpExBudget { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("obsUnits")]
        public JToken OBSUnits { get; set; }

        [JsonProperty("program")]
        public Program Program { get; set; }

        [JsonProperty("priority")]
        public Priority Priority { get; set; }
    }

    public class UpdateMilestoneInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("projectPhase")]
        public ProjectPhase ProjectPhase { get; set; }

        [JsonProperty("status")]
        public MilestoneStatus Status { get; set; }
    }

    public class UpdateFinancialsInput
    {
        [JsonProperty("type")]
        public UpdateFinancialsInputTypeType? Type { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("timing")]
        public Timing Timing { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateFinancialsInputTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public class UpdateFinancialActualsInput
    {
        [JsonProperty("type")]
        public UpdateFinancialActualsInputTypeType? Type { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateFinancialActualsInputTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public class UpdateAllocationInput
    {
        [JsonProperty("segments", DefaultValueHandling = DefaultValueHandling.Include)]
        public AllocationSegment[] Segments { get; set; }
    }

    public class UpdateRoleInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("costType")]
        public UpdateRoleInputCostTypeType? CostType { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("resourceManager")]
        public ResourceManager ResourceManager { get; set; }

        [JsonProperty("costPerHour")]
        public double? CostPerHour { get; set; }

        [JsonProperty("costPerHourValidFrom")]
        public string CostPerHourValidFrom { get; set; }

        [JsonProperty("costRates")]
        public CostRate[] CostRates { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateRoleInputCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class UpdateResourceInput
    {
        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("postalAddress")]
        public PostalAddress PostalAddress { get; set; }

        [JsonProperty("employmentPeriod")]
        public EmploymentPeriod EmploymentPeriod { get; set; }

        [JsonProperty("externalResource")]
        public bool? ExternalResource { get; set; }

        [JsonProperty("primaryRole")]
        public PrimaryRole PrimaryRole { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("obsUnits")]
        public JToken ObsUnits { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("resourceManager")]
        public ResourceManager ResourceManager { get; set; }

        [JsonProperty("costPerHour")]
        public double? CostPerHour { get; set; }

        [JsonProperty("costPerHourValidFrom")]
        public string CostPerHourValidFrom { get; set; }

        [JsonProperty("costRates")]
        public CostRate[] CostRates { get; set; }
    }

    public class UpdateAbsencesInput
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("finish")]
        public string Finish { get; set; }

        [JsonProperty("startDayType")]
        public UpdateAbsencesInputStartDayTypeType? StartDayType { get; set; }

        [JsonProperty("finishDayType")]
        public UpdateAbsencesInputFinishDayTypeType? FinishDayType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateAbsencesInputStartDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateAbsencesInputFinishDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    public class UpdateObsTypeInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class UpdateObsUnitInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class UpdateCalendarInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("workingHours")]
        public WorkingHours WorkingHours { get; set; }
    }

    public class PaginatedResponseUserResponse
    {
        [JsonProperty("items")]
        public UserResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class UserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userName")]
        public string Username { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("groups")]
        public BasicUserGroupResponse[] Groups { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("linkedResource")]
        public LinkedResourceResponse LinkedResource { get; set; }

        [JsonProperty("passwordNeverExpires")]
        public bool PasswordNeverExpires { get; set; }
    }

    public class BasicUserGroupResponse
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("name")]
        public string GroupName { get; set; }
    }

    public class LinkedResourceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class SprintResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string SprintKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class ListResponseScenarioResponse
    {
        [JsonProperty("items")]
        public ScenarioResponse[] Items { get; set; }
    }

    public class ScenarioResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListResponseRoleWithRoleCapacityResponse
    {
        [JsonProperty("items")]
        public RoleWithRoleCapacityResponse[] Items { get; set; }
    }

    public class RoleWithRoleCapacityResponse
    {
        [JsonProperty("roleId")]
        public string RoleId { get; set; }

        [JsonProperty("segments")]
        public RoleCapacityResponse[] Segments { get; set; }
    }

    public class PaginatedResponseProjectCommentResponse
    {
        [JsonProperty("items")]
        public ProjectCommentResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class ProjectCommentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("author")]
        public UserRefResponse Author { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("mentions")]
        public UserRefResponse[] Mentions { get; set; }
    }

    public class UserRefResponse
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string UserDisplayName { get; set; }
    }

    public class PaginatedResponseAllocationCommentResponse
    {
        [JsonProperty("items")]
        public AllocationCommentResponse[] Items { get; set; }

        [JsonProperty("_pagination")]
        public Pagination Pagination { get; set; }
    }

    public class AllocationCommentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("author")]
        public UserRefResponse Author { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("mentions")]
        public UserRefResponse[] Mentions { get; set; }

        [JsonProperty("allocatedEntity")]
        public AllocationCommentEntityResponse AllocatedEntity { get; set; }
    }

    public class AllocationCommentEntityResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public AllocationCommentEntityResponseTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AllocationCommentEntityResponseTypeType
    {
        ROLE,
        RESOURCE,
        TEAM,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public class ActualTimeWorkedByIdResponse
    {
        [JsonProperty("bookedEntity")]
        public ActualsEntityLinkResponse BookedEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }

        [JsonProperty("costType")]
        public ActualTimeWorkedByIdResponseCostTypeType CostType { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActualTimeWorkedByIdResponseCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class ListResponsePortfolioResponse
    {
        [JsonProperty("items")]
        public PortfolioResponse[] Items { get; set; }
    }

    public class PortfolioResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListResponseBusinessGoalDefinitionResponse
    {
        [JsonProperty("items")]
        public BusinessGoalDefinitionResponse[] Items { get; set; }
    }

    public class BusinessGoalDefinitionResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subGoals")]
        public SubGoalDefinitionResponse[] SubGoals { get; set; }
    }

    public class SubGoalDefinitionResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class WebhookResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("callbackUrl")]
        public string CallbackURL { get; set; }

        [JsonProperty("eventTypes")]
        public WebhookResponseEventTypesTypeItem[] EventTypes { get; set; }

        [JsonProperty("scenarioId")]
        public string ScenarioId { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public WebhookResponseStatusType Status { get; set; }

        [JsonProperty("createdBy")]
        public UserRefResponse CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookResponseEventTypesTypeItem
    {
        [EnumMember(Value = "PROJECT_CREATE")]
        PROJECTCREATE,
        [EnumMember(Value = "PROJECT_UPDATE")]
        PROJECTUPDATE,
        [EnumMember(Value = "PROJECT_DELETE")]
        PROJECTDELETE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookResponseStatusType
    {
        SUSPENDED,
        ACTIVE
    }

    public class CreateWebhookInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("eventTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookInputEventTypesTypeItem[] EventTypes { get; set; }

        [JsonProperty("scenarioId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScenarioId { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookInputEventTypesTypeItem
    {
        [EnumMember(Value = "PROJECT_CREATE")]
        PROJECTCREATE,
        [EnumMember(Value = "PROJECT_UPDATE")]
        PROJECTUPDATE,
        [EnumMember(Value = "PROJECT_DELETE")]
        PROJECTDELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Meisterplan;

    public partial class WorkflowManagedActions
    {
        public MeisterplanActions Meisterplan(string connectionId) => new MeisterplanActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MeisterplanTriggers Meisterplan(string connectionId) => new MeisterplanTriggers(connectionId);
    }
}