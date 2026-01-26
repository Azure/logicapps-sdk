//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meisterplan
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeisterplanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseTaskResponse> GetAllTasks(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> key = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/taskManagementLink/tasks", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            if (key != null)
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            return new ApiConnectionAction<PaginatedResponseTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseMilestoneResponse> GetAllMilestones(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/milestones", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseMilestoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<MilestoneResponse> CreateMilestone(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> payloadname, Expression<Func<string>> payloaddate, Expression<Func<string>> payloadprojectPhasename = null, Expression<Func<payloadstatusvalueInput>> payloadstatusvalue = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/milestones", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["name"] = ExpressionConverter.ConvertO(payloadname);
            payloadpropCount++;
            payload["date"] = ExpressionConverter.ConvertO(payloaddate);
            var projectPhaseObject = new JObject();
            var projectPhaseObjectpropCount = 0;
            if (payloadprojectPhasename != null)
            {
                projectPhaseObject["name"] = ExpressionConverter.ConvertO(payloadprojectPhasename);
                projectPhaseObjectpropCount++;
            }

            if (projectPhaseObjectpropCount > 0)
            {
                payload["projectPhase"] = projectPhaseObject;
                payloadpropCount++;
            }

            var statusObject = new JObject();
            var statusObjectpropCount = 0;
            if (payloadstatusvalue != null)
            {
                statusObject["value"] = ExpressionConverter.ConvertO(payloadstatusvalue);
                statusObjectpropCount++;
            }

            if (statusObjectpropCount > 0)
            {
                payload["status"] = statusObject;
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<MilestoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction ReplaceMilestones(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<Milestone[]>> payloadmilestones)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/milestones", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["items"] = ExpressionConverter.ConvertO(payloadmilestones);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseFinancialsResponse> GetAllFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financials", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseFinancialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialsResponse> CreateFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<payloadtypeInput>> payloadtype, Expression<Func<double>> payloadamount, Expression<Func<payloadtimingonInput>> payloadtimingon, Expression<Func<string>> payloadtimingmilestoneID = null, Expression<Func<string>> payloadtimingdueDate = null, Expression<Func<string>> payloaddescription = null, Expression<Func<string>> payloadcategoryname = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financials", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["type"] = ExpressionConverter.ConvertO(payloadtype);
            payloadpropCount++;
            payload["amount"] = ExpressionConverter.ConvertO(payloadamount);
            var timingObject = new JObject();
            var timingObjectpropCount = 0;
            timingObjectpropCount++;
            timingObject["on"] = ExpressionConverter.ConvertO(payloadtimingon);
            if (payloadtimingmilestoneID != null)
            {
                timingObject["milestoneId"] = ExpressionConverter.ConvertO(payloadtimingmilestoneID);
                timingObjectpropCount++;
            }

            if (payloadtimingdueDate != null)
            {
                timingObject["dueDate"] = ExpressionConverter.ConvertO(payloadtimingdueDate);
                timingObjectpropCount++;
            }

            if (timingObjectpropCount > 0)
            {
                payload["timing"] = timingObject;
                payloadpropCount++;
            }

            if (payloaddescription != null)
            {
                payload["description"] = ExpressionConverter.ConvertO(payloaddescription);
                payloadpropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            if (payloadcategoryname != null)
            {
                categoryObject["name"] = ExpressionConverter.ConvertO(payloadcategoryname);
                categoryObjectpropCount++;
            }

            if (categoryObjectpropCount > 0)
            {
                payload["category"] = categoryObject;
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<FinancialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction ReplaceFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<FinancialEvent[]>> payloadfinancials)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financials", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["items"] = ExpressionConverter.ConvertO(payloadfinancials);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseFinancialActualsResponse> GetAllActualFinancialEvents(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financialActuals", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseFinancialActualsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialActualsResponse> CreateFinancialActuals(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<payloadtypeInput>> payloadtype, Expression<Func<double>> payloadamount, Expression<Func<string>> payloadbookingDate, Expression<Func<string>> payloaddescription = null, Expression<Func<string>> payloadcategoryname = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financialActuals", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["type"] = ExpressionConverter.ConvertO(payloadtype);
            payloadpropCount++;
            payload["amount"] = ExpressionConverter.ConvertO(payloadamount);
            payloadpropCount++;
            payload["bookingDate"] = ExpressionConverter.ConvertO(payloadbookingDate);
            if (payloaddescription != null)
            {
                payload["description"] = ExpressionConverter.ConvertO(payloaddescription);
                payloadpropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            if (payloadcategoryname != null)
            {
                categoryObject["name"] = ExpressionConverter.ConvertO(payloadcategoryname);
                categoryObjectpropCount++;
            }

            if (categoryObjectpropCount > 0)
            {
                payload["category"] = categoryObject;
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<FinancialActualsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction ReplaceFinancialActuals(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<FinancialActualsCreateOrReplaceRequest[]>> payloadfinancialActuals)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financialActuals", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["items"] = ExpressionConverter.ConvertO(payloadfinancialActuals);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseAllocationResponse> GetAllAllocations(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/allocations", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseAllocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AllocationResponse> CreateOrUpdateAllocation(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationCreateOrUpdateRequestallocatedEntityiD, Expression<Func<allocationCreateOrUpdateRequestallocatedEntitytypeInput>> allocationCreateOrUpdateRequestallocatedEntitytype = null, Expression<Func<string>> allocationCreateOrUpdateRequestallocatedEntityprojectRole = null, Expression<Func<AllocationSegment[]>> allocationCreateOrUpdateRequestsegments = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/allocations", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var allocationCreateOrUpdateRequest = new JObject();
            var allocationCreateOrUpdateRequestpropCount = 0;
            var allocatedEntityObject = new JObject();
            var allocatedEntityObjectpropCount = 0;
            allocatedEntityObjectpropCount++;
            allocatedEntityObject["id"] = ExpressionConverter.ConvertO(allocationCreateOrUpdateRequestallocatedEntityiD);
            if (allocationCreateOrUpdateRequestallocatedEntitytype != null)
            {
                allocatedEntityObject["type"] = ExpressionConverter.ConvertO(allocationCreateOrUpdateRequestallocatedEntitytype);
                allocatedEntityObjectpropCount++;
            }

            if (allocationCreateOrUpdateRequestallocatedEntityprojectRole != null)
            {
                allocatedEntityObject["projectRole"] = ExpressionConverter.ConvertO(allocationCreateOrUpdateRequestallocatedEntityprojectRole);
                allocatedEntityObjectpropCount++;
            }

            if (allocatedEntityObjectpropCount > 0)
            {
                allocationCreateOrUpdateRequest["allocatedEntity"] = allocatedEntityObject;
                allocationCreateOrUpdateRequestpropCount++;
            }

            if (allocationCreateOrUpdateRequestsegments != null)
            {
                allocationCreateOrUpdateRequest["segments"] = ExpressionConverter.ConvertO(allocationCreateOrUpdateRequestsegments);
                allocationCreateOrUpdateRequestpropCount++;
            }

            if (allocationCreateOrUpdateRequestpropCount > 0)
            {
                callPayload.Body = allocationCreateOrUpdateRequest;
            }

            return new ApiConnectionAction<AllocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction ReplaceAllocation(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<Allocation[]>> allocationReplaceRequestitems)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/allocations", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var allocationReplaceRequest = new JObject();
            var allocationReplaceRequestpropCount = 0;
            allocationReplaceRequestpropCount++;
            allocationReplaceRequest["items"] = ExpressionConverter.ConvertO(allocationReplaceRequestitems);
            if (allocationReplaceRequestpropCount > 0)
            {
                callPayload.Body = allocationReplaceRequest;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseAbsenceResponse> GetAllAbsences(Expression<Func<string>> resourceId, Expression<Func<string>> startDate = null, Expression<Func<string>> finishDate = null)
        {
            var apiCallPath = String.Format("/v1/resources/{0}/absences", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            if (finishDate != null)
                callPayload.Queries["finishDate"] = ExpressionConverter.Convert(finishDate);
            return new ApiConnectionAction<ListResponseAbsenceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AbsenceResponse> CreateAbsences(Expression<Func<string>> resourceId, Expression<Func<string>> payloadstart, Expression<Func<string>> payloadfinish, Expression<Func<payloadstartDayTypeInput>> payloadstartDayType = null, Expression<Func<payloadfinishDayTypeInput>> payloadfinishDayType = null)
        {
            var apiCallPath = String.Format("/v1/resources/{0}/absences", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["start"] = ExpressionConverter.ConvertO(payloadstart);
            payloadpropCount++;
            payload["finish"] = ExpressionConverter.ConvertO(payloadfinish);
            if (payloadstartDayType != null)
            {
                payload["startDayType"] = ExpressionConverter.ConvertO(payloadstartDayType);
                payloadpropCount++;
            }

            if (payloadfinishDayType != null)
            {
                payload["finishDayType"] = ExpressionConverter.ConvertO(payloadfinishDayType);
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<AbsenceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction ReplaceAbsences(Expression<Func<string>> resourceId, Expression<Func<CreateAbsenceRequest[]>> absencesabsences, Expression<Func<string>> start = null, Expression<Func<string>> end = null)
        {
            var apiCallPath = String.Format("/v1/resources/{0}/absences", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            var absences = new JObject();
            var absencespropCount = 0;
            absencespropCount++;
            absences["items"] = ExpressionConverter.ConvertO(absencesabsences);
            if (absencespropCount > 0)
            {
                callPayload.Body = absences;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseTeamResponse> GetAllTeams(Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/teams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<PaginatedResponseTeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseRoleCapacityResponse> GetRoleCapacities(Expression<Func<string>> scenarioId, Expression<Func<string>> roleId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/roleCapacities/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(roleId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseRoleCapacityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseRoleCapacityResponse> UpdateRoleCapacities(Expression<Func<string>> scenarioId, Expression<Func<string>> roleId, Expression<Func<CapacitySegment[]>> payloadsegments)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/roleCapacities/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(roleId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["segments"] = ExpressionConverter.ConvertO(payloadsegments);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<ListResponseRoleCapacityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseAllProjectsResponse> GetAllProjects(Expression<Func<string>> scenarioId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<PaginatedResponseAllProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TaskManagementLinkResponse> GetTaskManagementLink(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/taskManagementLink", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskManagementLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteTaskManagementLink(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/taskManagementLink", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseActualTimeWorkedResponse> GetAllActualTimeWorked(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/actuals", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<PaginatedResponseActualTimeWorkedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteAllActualTimeWorked(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/actuals", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ActualTimeWorkedResponse> CreateOrUpdateActualTimeWorked(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> payloadbookedEntityiD, Expression<Func<Bookings[]>> payloadbookings, Expression<Func<payloadbookedEntitytypeInput>> payloadbookedEntitytype = null, Expression<Func<string>> payloadbookedEntityTeamID = null, Expression<Func<payloadmodeInput>> payloadmode = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/actuals", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            var bookedEntityObject = new JObject();
            var bookedEntityObjectpropCount = 0;
            bookedEntityObjectpropCount++;
            bookedEntityObject["id"] = ExpressionConverter.ConvertO(payloadbookedEntityiD);
            if (payloadbookedEntitytype != null)
            {
                bookedEntityObject["type"] = ExpressionConverter.ConvertO(payloadbookedEntitytype);
                bookedEntityObjectpropCount++;
            }

            if (payloadbookedEntityTeamID != null)
            {
                bookedEntityObject["teamId"] = ExpressionConverter.ConvertO(payloadbookedEntityTeamID);
                bookedEntityObjectpropCount++;
            }

            if (bookedEntityObjectpropCount > 0)
            {
                payload["bookedEntity"] = bookedEntityObject;
                payloadpropCount++;
            }

            payloadpropCount++;
            payload["bookings"] = ExpressionConverter.ConvertO(payloadbookings);
            if (payloadmode != null)
            {
                payload["mode"] = ExpressionConverter.ConvertO(payloadmode);
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<ActualTimeWorkedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseProgramGetAllResponse> GetAllPrograms(Expression<Func<string>> scenarioId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/programs", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pageSize"] = Convert.ToString(250);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<PaginatedResponseProgramGetAllResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction UpdatePriorities(Expression<Func<string>> scenarioId, Expression<Func<PriorityEntry[]>> prioritiesUpdateRequestbelowCutOffitems, Expression<Func<PriorityEntry[]>> prioritiesUpdateRequestbelowCutOffitems, Expression<Func<PriorityEntry[]>> prioritiesUpdateRequestbelowCutOffitems, Expression<Func<prioritiesUpdateRequestbelowCutOffpositionInput>> prioritiesUpdateRequestbelowCutOffposition = null, Expression<Func<prioritiesUpdateRequestbelowCutOffpositionInput>> prioritiesUpdateRequestbelowCutOffposition = null, Expression<Func<prioritiesUpdateRequestbelowCutOffpositionInput>> prioritiesUpdateRequestbelowCutOffposition = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/priorities", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var prioritiesUpdateRequest = new JObject();
            var prioritiesUpdateRequestpropCount = 0;
            var aboveMustHaveObject = new JObject();
            var aboveMustHaveObjectpropCount = 0;
            aboveMustHaveObjectpropCount++;
            aboveMustHaveObject["items"] = ExpressionConverter.ConvertO(prioritiesUpdateRequestbelowCutOffitems);
            if (prioritiesUpdateRequestbelowCutOffposition != null)
            {
                aboveMustHaveObject["position"] = ExpressionConverter.ConvertO(prioritiesUpdateRequestbelowCutOffposition);
                aboveMustHaveObjectpropCount++;
            }

            if (aboveMustHaveObjectpropCount > 0)
            {
                prioritiesUpdateRequest["aboveMustHave"] = aboveMustHaveObject;
                prioritiesUpdateRequestpropCount++;
            }

            var regularObject = new JObject();
            var regularObjectpropCount = 0;
            regularObjectpropCount++;
            regularObject["items"] = ExpressionConverter.ConvertO(prioritiesUpdateRequestbelowCutOffitems);
            if (prioritiesUpdateRequestbelowCutOffposition != null)
            {
                regularObject["position"] = ExpressionConverter.ConvertO(prioritiesUpdateRequestbelowCutOffposition);
                regularObjectpropCount++;
            }

            if (regularObjectpropCount > 0)
            {
                prioritiesUpdateRequest["regular"] = regularObject;
                prioritiesUpdateRequestpropCount++;
            }

            var belowCutOffObject = new JObject();
            var belowCutOffObjectpropCount = 0;
            belowCutOffObjectpropCount++;
            belowCutOffObject["items"] = ExpressionConverter.ConvertO(prioritiesUpdateRequestbelowCutOffitems);
            if (prioritiesUpdateRequestbelowCutOffposition != null)
            {
                belowCutOffObject["position"] = ExpressionConverter.ConvertO(prioritiesUpdateRequestbelowCutOffposition);
                belowCutOffObjectpropCount++;
            }

            if (belowCutOffObjectpropCount > 0)
            {
                prioritiesUpdateRequest["belowCutOff"] = belowCutOffObject;
                prioritiesUpdateRequestpropCount++;
            }

            if (prioritiesUpdateRequestpropCount > 0)
            {
                callPayload.Body = prioritiesUpdateRequest;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseMilestoneDependencyResponse> GetAllMilestoneDependencies(Expression<Func<string>> scenarioId, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/milestoneDependencies", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            return new ApiConnectionAction<PaginatedResponseMilestoneDependencyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<MilestoneDependencyCreateResponse> CreateMilestoneDependency(Expression<Func<string>> scenarioId, Expression<Func<string>> payloadfromMilestoneID, Expression<Func<string>> payloadtoMilestoneID)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/milestoneDependencies", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["fromMilestoneId"] = ExpressionConverter.ConvertO(payloadfromMilestoneID);
            payloadpropCount++;
            payload["toMilestoneId"] = ExpressionConverter.ConvertO(payloadtoMilestoneID);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<MilestoneDependencyCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseRoleResponse> GetAllRoles(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/roles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<ListResponseRoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<RoleResponse> CreateRole(Expression<Func<string>> payloadname, Expression<Func<string>> payloadexternalID = null, Expression<Func<payloadcostTypeInput>> payloadcostType = null, Expression<Func<object>> payloadobsUnits = null, Expression<Func<string>> payloadresourceManageriD = null, Expression<Func<string>> payloadresourceManagerresourceKey = null, Expression<Func<double>> payloadcostPerHour = null, Expression<Func<string>> payloadcostPerHourValidFrom = null, Expression<Func<CostRate[]>> payloadcostRates = null)
        {
            var apiCallPath = "/v1/roles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["name"] = ExpressionConverter.ConvertO(payloadname);
            if (payloadexternalID != null)
            {
                payload["externalId"] = ExpressionConverter.ConvertO(payloadexternalID);
                payloadpropCount++;
            }

            if (payloadcostType != null)
            {
                payload["costType"] = ExpressionConverter.ConvertO(payloadcostType);
                payloadpropCount++;
            }

            if (payloadobsUnits != null)
            {
                payload["obsUnits"] = ExpressionConverter.ConvertO(payloadobsUnits);
                payloadpropCount++;
            }

            var resourceManagerObject = new JObject();
            var resourceManagerObjectpropCount = 0;
            if (payloadresourceManageriD != null)
            {
                resourceManagerObject["id"] = ExpressionConverter.ConvertO(payloadresourceManageriD);
                resourceManagerObjectpropCount++;
            }

            if (payloadresourceManagerresourceKey != null)
            {
                resourceManagerObject["resourceKey"] = ExpressionConverter.ConvertO(payloadresourceManagerresourceKey);
                resourceManagerObjectpropCount++;
            }

            if (resourceManagerObjectpropCount > 0)
            {
                payload["resourceManager"] = resourceManagerObject;
                payloadpropCount++;
            }

            if (payloadcostPerHour != null)
            {
                payload["costPerHour"] = ExpressionConverter.ConvertO(payloadcostPerHour);
                payloadpropCount++;
            }

            if (payloadcostPerHourValidFrom != null)
            {
                payload["costPerHourValidFrom"] = ExpressionConverter.ConvertO(payloadcostPerHourValidFrom);
                payloadpropCount++;
            }

            if (payloadcostRates != null)
            {
                payload["costRates"] = ExpressionConverter.ConvertO(payloadcostRates);
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<RoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseResourceResponse> GetAllResources(Expression<Func<int>> pageSize = null, Expression<Func<string>> pageAfter = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/resources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<PaginatedResponseResourceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ResourceResponse> CreateResource(Expression<Func<string>> payloadlastName, Expression<Func<string>> payloadresourceKey = null, Expression<Func<string>> payloadfirstName = null, Expression<Func<string>> payloadexternalID = null, Expression<Func<string>> payloademailAddress = null, Expression<Func<string>> payloadpostalAddresscity = null, Expression<Func<string>> payloadpostalAddresscountry = null, Expression<Func<string>> payloadpostalAddresspostalCode = null, Expression<Func<string>> payloademploymentPeriodstartDate = null, Expression<Func<string>> payloademploymentPeriodterminationDate = null, Expression<Func<bool>> payloadexternalResource = null, Expression<Func<string>> payloadprimaryRoleiD = null, Expression<Func<string>> payloadcalendarpath = null, Expression<Func<string>> payloadcalendariD = null, Expression<Func<object>> payloadobsUnits = null, Expression<Func<string[]>> payloadskills = null, Expression<Func<string>> payloadresourceManageriD = null, Expression<Func<string>> payloadresourceManagerresourceKey = null, Expression<Func<double>> payloadcostPerHour = null, Expression<Func<string>> payloadcostPerHourValidFrom = null, Expression<Func<CostRate[]>> payloadcostRates = null)
        {
            var apiCallPath = "/v1/resources";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadresourceKey != null)
            {
                payload["resourceKey"] = ExpressionConverter.ConvertO(payloadresourceKey);
                payloadpropCount++;
            }

            if (payloadfirstName != null)
            {
                payload["firstName"] = ExpressionConverter.ConvertO(payloadfirstName);
                payloadpropCount++;
            }

            payloadpropCount++;
            payload["lastName"] = ExpressionConverter.ConvertO(payloadlastName);
            if (payloadexternalID != null)
            {
                payload["externalId"] = ExpressionConverter.ConvertO(payloadexternalID);
                payloadpropCount++;
            }

            if (payloademailAddress != null)
            {
                payload["emailAddress"] = ExpressionConverter.ConvertO(payloademailAddress);
                payloadpropCount++;
            }

            var postalAddressObject = new JObject();
            var postalAddressObjectpropCount = 0;
            if (payloadpostalAddresscity != null)
            {
                postalAddressObject["city"] = ExpressionConverter.ConvertO(payloadpostalAddresscity);
                postalAddressObjectpropCount++;
            }

            if (payloadpostalAddresscountry != null)
            {
                postalAddressObject["country"] = ExpressionConverter.ConvertO(payloadpostalAddresscountry);
                postalAddressObjectpropCount++;
            }

            if (payloadpostalAddresspostalCode != null)
            {
                postalAddressObject["postalCode"] = ExpressionConverter.ConvertO(payloadpostalAddresspostalCode);
                postalAddressObjectpropCount++;
            }

            if (postalAddressObjectpropCount > 0)
            {
                payload["postalAddress"] = postalAddressObject;
                payloadpropCount++;
            }

            var employmentPeriodObject = new JObject();
            var employmentPeriodObjectpropCount = 0;
            if (payloademploymentPeriodstartDate != null)
            {
                employmentPeriodObject["startDate"] = ExpressionConverter.ConvertO(payloademploymentPeriodstartDate);
                employmentPeriodObjectpropCount++;
            }

            if (payloademploymentPeriodterminationDate != null)
            {
                employmentPeriodObject["terminationDate"] = ExpressionConverter.ConvertO(payloademploymentPeriodterminationDate);
                employmentPeriodObjectpropCount++;
            }

            if (employmentPeriodObjectpropCount > 0)
            {
                payload["employmentPeriod"] = employmentPeriodObject;
                payloadpropCount++;
            }

            if (payloadexternalResource != null)
            {
                payload["externalResource"] = ExpressionConverter.ConvertO(payloadexternalResource);
                payloadpropCount++;
            }

            var primaryRoleObject = new JObject();
            var primaryRoleObjectpropCount = 0;
            if (payloadprimaryRoleiD != null)
            {
                primaryRoleObject["id"] = ExpressionConverter.ConvertO(payloadprimaryRoleiD);
                primaryRoleObjectpropCount++;
            }

            if (primaryRoleObjectpropCount > 0)
            {
                payload["primaryRole"] = primaryRoleObject;
                payloadpropCount++;
            }

            var calendarObject = new JObject();
            var calendarObjectpropCount = 0;
            if (payloadcalendarpath != null)
            {
                calendarObject["path"] = ExpressionConverter.ConvertO(payloadcalendarpath);
                calendarObjectpropCount++;
            }

            if (payloadcalendariD != null)
            {
                calendarObject["id"] = ExpressionConverter.ConvertO(payloadcalendariD);
                calendarObjectpropCount++;
            }

            if (calendarObjectpropCount > 0)
            {
                payload["calendar"] = calendarObject;
                payloadpropCount++;
            }

            if (payloadobsUnits != null)
            {
                payload["obsUnits"] = ExpressionConverter.ConvertO(payloadobsUnits);
                payloadpropCount++;
            }

            if (payloadskills != null)
            {
                payload["skills"] = ExpressionConverter.ConvertO(payloadskills);
                payloadpropCount++;
            }

            var resourceManagerObject = new JObject();
            var resourceManagerObjectpropCount = 0;
            if (payloadresourceManageriD != null)
            {
                resourceManagerObject["id"] = ExpressionConverter.ConvertO(payloadresourceManageriD);
                resourceManagerObjectpropCount++;
            }

            if (payloadresourceManagerresourceKey != null)
            {
                resourceManagerObject["resourceKey"] = ExpressionConverter.ConvertO(payloadresourceManagerresourceKey);
                resourceManagerObjectpropCount++;
            }

            if (resourceManagerObjectpropCount > 0)
            {
                payload["resourceManager"] = resourceManagerObject;
                payloadpropCount++;
            }

            if (payloadcostPerHour != null)
            {
                payload["costPerHour"] = ExpressionConverter.ConvertO(payloadcostPerHour);
                payloadpropCount++;
            }

            if (payloadcostPerHourValidFrom != null)
            {
                payload["costPerHourValidFrom"] = ExpressionConverter.ConvertO(payloadcostPerHourValidFrom);
                payloadpropCount++;
            }

            if (payloadcostRates != null)
            {
                payload["costRates"] = ExpressionConverter.ConvertO(payloadcostRates);
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<ResourceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseCalendarDeviationResponse> GetCalendarDeviations(Expression<Func<string>> resourceId, Expression<Func<string>> start = null, Expression<Func<string>> finish = null)
        {
            var apiCallPath = String.Format("/v1/resources/{0}/calendarDeviations", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (finish != null)
                callPayload.Queries["finish"] = ExpressionConverter.Convert(finish);
            return new ApiConnectionAction<ListResponseCalendarDeviationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseCalendarDeviationResponse> UpdateCalendarDeviations(Expression<Func<string>> resourceId, Expression<Func<CalendarDeviation[]>> payloaddeviations, Expression<Func<string>> payloadstart = null, Expression<Func<string>> payloadfinish = null)
        {
            var apiCallPath = String.Format("/v1/resources/{0}/calendarDeviations", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadstart != null)
            {
                payload["start"] = ExpressionConverter.ConvertO(payloadstart);
                payloadpropCount++;
            }

            if (payloadfinish != null)
            {
                payload["finish"] = ExpressionConverter.ConvertO(payloadfinish);
                payloadpropCount++;
            }

            payloadpropCount++;
            payload["deviations"] = ExpressionConverter.ConvertO(payloaddeviations);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<ListResponseCalendarDeviationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseObsTypeResponse> GetAllObsTypes()
        {
            var apiCallPath = "/v1/obsTypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseObsTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsTypeResponse> CreateObsType(Expression<Func<string>> payloadname)
        {
            var apiCallPath = "/v1/obsTypes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["name"] = ExpressionConverter.ConvertO(payloadname);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<ObsTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseObsUnitResponse> GetAllObsUnits(Expression<Func<string>> obsTypeId)
        {
            var apiCallPath = String.Format("/v1/obsTypes/{0}/obsUnits", ExpressionConverter.ConvertWithUrlEncoding(obsTypeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseObsUnitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsUnitResponse> CreateObsUnit(Expression<Func<string>> obsTypeId, Expression<Func<string>> obsUnitCreateRequestname, Expression<Func<string>> obsUnitCreateRequestparentID = null)
        {
            var apiCallPath = String.Format("/v1/obsTypes/{0}/obsUnits", ExpressionConverter.ConvertWithUrlEncoding(obsTypeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var obsUnitCreateRequest = new JObject();
            var obsUnitCreateRequestpropCount = 0;
            obsUnitCreateRequestpropCount++;
            obsUnitCreateRequest["name"] = ExpressionConverter.ConvertO(obsUnitCreateRequestname);
            if (obsUnitCreateRequestparentID != null)
            {
                obsUnitCreateRequest["parentId"] = ExpressionConverter.ConvertO(obsUnitCreateRequestparentID);
                obsUnitCreateRequestpropCount++;
            }

            if (obsUnitCreateRequestpropCount > 0)
            {
                callPayload.Body = obsUnitCreateRequest;
            }

            return new ApiConnectionAction<ObsUnitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseCalendarResponse> GetAllCalendars()
        {
            var apiCallPath = "/v1/calendars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseCalendarResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<CalendarResponse> CreateCalendar(Expression<Func<string>> payloadname, Expression<Func<double>> payloadworkingHoursmonday, Expression<Func<double>> payloadworkingHourstuesday, Expression<Func<double>> payloadworkingHourswednesday, Expression<Func<double>> payloadworkingHoursthursday, Expression<Func<double>> payloadworkingHoursfriday, Expression<Func<double>> payloadworkingHourssaturday, Expression<Func<double>> payloadworkingHourssunday, Expression<Func<string>> payloadparentID = null)
        {
            var apiCallPath = "/v1/calendars";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["name"] = ExpressionConverter.ConvertO(payloadname);
            if (payloadparentID != null)
            {
                payload["parentId"] = ExpressionConverter.ConvertO(payloadparentID);
                payloadpropCount++;
            }

            var workingHoursObject = new JObject();
            var workingHoursObjectpropCount = 0;
            workingHoursObjectpropCount++;
            workingHoursObject["monday"] = ExpressionConverter.ConvertO(payloadworkingHoursmonday);
            workingHoursObjectpropCount++;
            workingHoursObject["tuesday"] = ExpressionConverter.ConvertO(payloadworkingHourstuesday);
            workingHoursObjectpropCount++;
            workingHoursObject["wednesday"] = ExpressionConverter.ConvertO(payloadworkingHourswednesday);
            workingHoursObjectpropCount++;
            workingHoursObject["thursday"] = ExpressionConverter.ConvertO(payloadworkingHoursthursday);
            workingHoursObjectpropCount++;
            workingHoursObject["friday"] = ExpressionConverter.ConvertO(payloadworkingHoursfriday);
            workingHoursObjectpropCount++;
            workingHoursObject["saturday"] = ExpressionConverter.ConvertO(payloadworkingHourssaturday);
            workingHoursObjectpropCount++;
            workingHoursObject["sunday"] = ExpressionConverter.ConvertO(payloadworkingHourssunday);
            if (workingHoursObjectpropCount > 0)
            {
                payload["workingHours"] = workingHoursObject;
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<CalendarResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseCalendarExceptionResponse> GetAllCalendarExceptions(Expression<Func<string>> calendarId, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var apiCallPath = String.Format("/v1/calendars/{0}/exceptions", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            return new ApiConnectionAction<ListResponseCalendarExceptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction CreateCalendarExceptions(Expression<Func<string>> calendarId, Expression<Func<CalendarException[]>> payloadexceptions, Expression<Func<string>> payloadstart = null, Expression<Func<string>> payloadfinish = null)
        {
            var apiCallPath = String.Format("/v1/calendars/{0}/exceptions", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadstart != null)
            {
                payload["start"] = ExpressionConverter.ConvertO(payloadstart);
                payloadpropCount++;
            }

            if (payloadfinish != null)
            {
                payload["finish"] = ExpressionConverter.ConvertO(payloadfinish);
                payloadpropCount++;
            }

            payloadpropCount++;
            payload["exceptions"] = ExpressionConverter.ConvertO(payloadexceptions);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction SetDefaultCalendar(Expression<Func<string>> payloadiD)
        {
            var apiCallPath = "/v1/calendars/defaultCalendar";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["id"] = ExpressionConverter.ConvertO(payloadiD);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TeamResponse> GetTeamById(Expression<Func<string>> teamId)
        {
            var apiCallPath = String.Format("/v1/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteTeam(Expression<Func<string>> teamId)
        {
            var apiCallPath = String.Format("/v1/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TeamResponse> UpdateTeam(Expression<Func<string>> teamId, Expression<Func<payloadInput>> payload = null)
        {
            var apiCallPath = String.Format("/v1/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(payload);
            return new ApiConnectionAction<TeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProjectResponse> GetProjectById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteProject(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProjectResponse> UpdateProject(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<payloadInput2>> payload = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(payload);
            return new ApiConnectionAction<ProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<MilestoneResponse> GetMilestoneById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> milestoneId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/milestones/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(milestoneId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MilestoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteMilestone(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> milestoneId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/milestones/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(milestoneId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<MilestoneResponse> UpdateMilestone(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> milestoneId, Expression<Func<string>> payloadname = null, Expression<Func<string>> payloaddate = null, Expression<Func<string>> payloadprojectPhasename = null, Expression<Func<payloadstatusvalueInput>> payloadstatusvalue = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/milestones/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(milestoneId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadname != null)
            {
                payload["name"] = ExpressionConverter.ConvertO(payloadname);
                payloadpropCount++;
            }

            if (payloaddate != null)
            {
                payload["date"] = ExpressionConverter.ConvertO(payloaddate);
                payloadpropCount++;
            }

            var projectPhaseObject = new JObject();
            var projectPhaseObjectpropCount = 0;
            if (payloadprojectPhasename != null)
            {
                projectPhaseObject["name"] = ExpressionConverter.ConvertO(payloadprojectPhasename);
                projectPhaseObjectpropCount++;
            }

            if (projectPhaseObjectpropCount > 0)
            {
                payload["projectPhase"] = projectPhaseObject;
                payloadpropCount++;
            }

            var statusObject = new JObject();
            var statusObjectpropCount = 0;
            if (payloadstatusvalue != null)
            {
                statusObject["value"] = ExpressionConverter.ConvertO(payloadstatusvalue);
                statusObjectpropCount++;
            }

            if (statusObjectpropCount > 0)
            {
                payload["status"] = statusObject;
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<MilestoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialsResponse> GetFinancialsById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> financialsId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financials/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(financialsId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FinancialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> financialsId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financials/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(financialsId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialsResponse> UpdateFinancials(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> financialsId, Expression<Func<payloadtimingonInput>> payloadtimingon, Expression<Func<payloadtypeInput>> payloadtype = null, Expression<Func<double>> payloadamount = null, Expression<Func<string>> payloadtimingmilestoneID = null, Expression<Func<string>> payloadtimingdueDate = null, Expression<Func<string>> payloaddescription = null, Expression<Func<string>> payloadcategoryname = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financials/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(financialsId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadtype != null)
            {
                payload["type"] = ExpressionConverter.ConvertO(payloadtype);
                payloadpropCount++;
            }

            if (payloadamount != null)
            {
                payload["amount"] = ExpressionConverter.ConvertO(payloadamount);
                payloadpropCount++;
            }

            var timingObject = new JObject();
            var timingObjectpropCount = 0;
            timingObjectpropCount++;
            timingObject["on"] = ExpressionConverter.ConvertO(payloadtimingon);
            if (payloadtimingmilestoneID != null)
            {
                timingObject["milestoneId"] = ExpressionConverter.ConvertO(payloadtimingmilestoneID);
                timingObjectpropCount++;
            }

            if (payloadtimingdueDate != null)
            {
                timingObject["dueDate"] = ExpressionConverter.ConvertO(payloadtimingdueDate);
                timingObjectpropCount++;
            }

            if (timingObjectpropCount > 0)
            {
                payload["timing"] = timingObject;
                payloadpropCount++;
            }

            if (payloaddescription != null)
            {
                payload["description"] = ExpressionConverter.ConvertO(payloaddescription);
                payloadpropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            if (payloadcategoryname != null)
            {
                categoryObject["name"] = ExpressionConverter.ConvertO(payloadcategoryname);
                categoryObjectpropCount++;
            }

            if (categoryObjectpropCount > 0)
            {
                payload["category"] = categoryObject;
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<FinancialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialActualsResponse> GetActualFinancialEventById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualFinancialEventId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financialActuals/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(actualFinancialEventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FinancialActualsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteFinancialActuals(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualFinancialEventId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financialActuals/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(actualFinancialEventId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<FinancialActualsResponse> UpdateFinancialActuals(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualFinancialEventId, Expression<Func<payloadtypeInput>> payloadtype = null, Expression<Func<double>> payloadamount = null, Expression<Func<string>> payloadbookingDate = null, Expression<Func<string>> payloaddescription = null, Expression<Func<string>> payloadcategoryname = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/financialActuals/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(actualFinancialEventId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadtype != null)
            {
                payload["type"] = ExpressionConverter.ConvertO(payloadtype);
                payloadpropCount++;
            }

            if (payloadamount != null)
            {
                payload["amount"] = ExpressionConverter.ConvertO(payloadamount);
                payloadpropCount++;
            }

            if (payloadbookingDate != null)
            {
                payload["bookingDate"] = ExpressionConverter.ConvertO(payloadbookingDate);
                payloadpropCount++;
            }

            if (payloaddescription != null)
            {
                payload["description"] = ExpressionConverter.ConvertO(payloaddescription);
                payloadpropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            if (payloadcategoryname != null)
            {
                categoryObject["name"] = ExpressionConverter.ConvertO(payloadcategoryname);
                categoryObjectpropCount++;
            }

            if (categoryObjectpropCount > 0)
            {
                payload["category"] = categoryObject;
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<FinancialActualsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AllocationResponse> GetAllocationId(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/allocations/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(allocationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AllocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteAllocation(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/allocations/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(allocationId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AllocationResponse> UpdateAllocation(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationId, Expression<Func<AllocationSegment[]>> allocationUpdateRequestsegments)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/allocations/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(allocationId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var allocationUpdateRequest = new JObject();
            var allocationUpdateRequestpropCount = 0;
            allocationUpdateRequestpropCount++;
            allocationUpdateRequest["segments"] = ExpressionConverter.ConvertO(allocationUpdateRequestsegments);
            if (allocationUpdateRequestpropCount > 0)
            {
                callPayload.Body = allocationUpdateRequest;
            }

            return new ApiConnectionAction<AllocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProgramResponse> GetProgramById(Expression<Func<string>> scenarioId, Expression<Func<string>> programId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/programs/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProgramResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteProgram(Expression<Func<string>> scenarioId, Expression<Func<string>> programId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/programs/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProgramResponse> UpdateProgram(Expression<Func<string>> scenarioId, Expression<Func<string>> programId, Expression<Func<payloadInput22>> payload = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/programs/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(payload);
            return new ApiConnectionAction<ProgramResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<RoleResponse> GetRoleById(Expression<Func<string>> roleId)
        {
            var apiCallPath = String.Format("/v1/roles/{0}", ExpressionConverter.ConvertWithUrlEncoding(roleId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteRole(Expression<Func<string>> roleId)
        {
            var apiCallPath = String.Format("/v1/roles/{0}", ExpressionConverter.ConvertWithUrlEncoding(roleId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<RoleResponse> UpdateRole(Expression<Func<string>> roleId, Expression<Func<string>> payloadname = null, Expression<Func<string>> payloadexternalID = null, Expression<Func<payloadcostTypeInput>> payloadcostType = null, Expression<Func<object>> payloadobsUnits = null, Expression<Func<string>> payloadresourceManageriD = null, Expression<Func<string>> payloadresourceManagerresourceKey = null, Expression<Func<double>> payloadcostPerHour = null, Expression<Func<string>> payloadcostPerHourValidFrom = null, Expression<Func<CostRate[]>> payloadcostRates = null)
        {
            var apiCallPath = String.Format("/v1/roles/{0}", ExpressionConverter.ConvertWithUrlEncoding(roleId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadname != null)
            {
                payload["name"] = ExpressionConverter.ConvertO(payloadname);
                payloadpropCount++;
            }

            if (payloadexternalID != null)
            {
                payload["externalId"] = ExpressionConverter.ConvertO(payloadexternalID);
                payloadpropCount++;
            }

            if (payloadcostType != null)
            {
                payload["costType"] = ExpressionConverter.ConvertO(payloadcostType);
                payloadpropCount++;
            }

            if (payloadobsUnits != null)
            {
                payload["obsUnits"] = ExpressionConverter.ConvertO(payloadobsUnits);
                payloadpropCount++;
            }

            var resourceManagerObject = new JObject();
            var resourceManagerObjectpropCount = 0;
            if (payloadresourceManageriD != null)
            {
                resourceManagerObject["id"] = ExpressionConverter.ConvertO(payloadresourceManageriD);
                resourceManagerObjectpropCount++;
            }

            if (payloadresourceManagerresourceKey != null)
            {
                resourceManagerObject["resourceKey"] = ExpressionConverter.ConvertO(payloadresourceManagerresourceKey);
                resourceManagerObjectpropCount++;
            }

            if (resourceManagerObjectpropCount > 0)
            {
                payload["resourceManager"] = resourceManagerObject;
                payloadpropCount++;
            }

            if (payloadcostPerHour != null)
            {
                payload["costPerHour"] = ExpressionConverter.ConvertO(payloadcostPerHour);
                payloadpropCount++;
            }

            if (payloadcostPerHourValidFrom != null)
            {
                payload["costPerHourValidFrom"] = ExpressionConverter.ConvertO(payloadcostPerHourValidFrom);
                payloadpropCount++;
            }

            if (payloadcostRates != null)
            {
                payload["costRates"] = ExpressionConverter.ConvertO(payloadcostRates);
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<RoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ResourceResponse> GetResourceById(Expression<Func<string>> resourceId)
        {
            var apiCallPath = String.Format("/v1/resources/{0}", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResourceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteResource(Expression<Func<string>> resourceId)
        {
            var apiCallPath = String.Format("/v1/resources/{0}", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ResourceResponse> UpdateResource(Expression<Func<string>> resourceId, Expression<Func<string>> payloadresourceKey = null, Expression<Func<string>> payloadfirstName = null, Expression<Func<string>> payloadlastName = null, Expression<Func<string>> payloadexternalID = null, Expression<Func<string>> payloademailAddress = null, Expression<Func<string>> payloadpostalAddresscity = null, Expression<Func<string>> payloadpostalAddresscountry = null, Expression<Func<string>> payloadpostalAddresspostalCode = null, Expression<Func<string>> payloademploymentPeriodstartDate = null, Expression<Func<string>> payloademploymentPeriodterminationDate = null, Expression<Func<bool>> payloadexternalResource = null, Expression<Func<string>> payloadprimaryRoleiD = null, Expression<Func<string>> payloadcalendarpath = null, Expression<Func<string>> payloadcalendariD = null, Expression<Func<object>> payloadobsUnits = null, Expression<Func<string[]>> payloadskills = null, Expression<Func<string>> payloadresourceManageriD = null, Expression<Func<string>> payloadresourceManagerresourceKey = null, Expression<Func<double>> payloadcostPerHour = null, Expression<Func<string>> payloadcostPerHourValidFrom = null, Expression<Func<CostRate[]>> payloadcostRates = null)
        {
            var apiCallPath = String.Format("/v1/resources/{0}", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadresourceKey != null)
            {
                payload["resourceKey"] = ExpressionConverter.ConvertO(payloadresourceKey);
                payloadpropCount++;
            }

            if (payloadfirstName != null)
            {
                payload["firstName"] = ExpressionConverter.ConvertO(payloadfirstName);
                payloadpropCount++;
            }

            if (payloadlastName != null)
            {
                payload["lastName"] = ExpressionConverter.ConvertO(payloadlastName);
                payloadpropCount++;
            }

            if (payloadexternalID != null)
            {
                payload["externalId"] = ExpressionConverter.ConvertO(payloadexternalID);
                payloadpropCount++;
            }

            if (payloademailAddress != null)
            {
                payload["emailAddress"] = ExpressionConverter.ConvertO(payloademailAddress);
                payloadpropCount++;
            }

            var postalAddressObject = new JObject();
            var postalAddressObjectpropCount = 0;
            if (payloadpostalAddresscity != null)
            {
                postalAddressObject["city"] = ExpressionConverter.ConvertO(payloadpostalAddresscity);
                postalAddressObjectpropCount++;
            }

            if (payloadpostalAddresscountry != null)
            {
                postalAddressObject["country"] = ExpressionConverter.ConvertO(payloadpostalAddresscountry);
                postalAddressObjectpropCount++;
            }

            if (payloadpostalAddresspostalCode != null)
            {
                postalAddressObject["postalCode"] = ExpressionConverter.ConvertO(payloadpostalAddresspostalCode);
                postalAddressObjectpropCount++;
            }

            if (postalAddressObjectpropCount > 0)
            {
                payload["postalAddress"] = postalAddressObject;
                payloadpropCount++;
            }

            var employmentPeriodObject = new JObject();
            var employmentPeriodObjectpropCount = 0;
            if (payloademploymentPeriodstartDate != null)
            {
                employmentPeriodObject["startDate"] = ExpressionConverter.ConvertO(payloademploymentPeriodstartDate);
                employmentPeriodObjectpropCount++;
            }

            if (payloademploymentPeriodterminationDate != null)
            {
                employmentPeriodObject["terminationDate"] = ExpressionConverter.ConvertO(payloademploymentPeriodterminationDate);
                employmentPeriodObjectpropCount++;
            }

            if (employmentPeriodObjectpropCount > 0)
            {
                payload["employmentPeriod"] = employmentPeriodObject;
                payloadpropCount++;
            }

            if (payloadexternalResource != null)
            {
                payload["externalResource"] = ExpressionConverter.ConvertO(payloadexternalResource);
                payloadpropCount++;
            }

            var primaryRoleObject = new JObject();
            var primaryRoleObjectpropCount = 0;
            if (payloadprimaryRoleiD != null)
            {
                primaryRoleObject["id"] = ExpressionConverter.ConvertO(payloadprimaryRoleiD);
                primaryRoleObjectpropCount++;
            }

            if (primaryRoleObjectpropCount > 0)
            {
                payload["primaryRole"] = primaryRoleObject;
                payloadpropCount++;
            }

            var calendarObject = new JObject();
            var calendarObjectpropCount = 0;
            if (payloadcalendarpath != null)
            {
                calendarObject["path"] = ExpressionConverter.ConvertO(payloadcalendarpath);
                calendarObjectpropCount++;
            }

            if (payloadcalendariD != null)
            {
                calendarObject["id"] = ExpressionConverter.ConvertO(payloadcalendariD);
                calendarObjectpropCount++;
            }

            if (calendarObjectpropCount > 0)
            {
                payload["calendar"] = calendarObject;
                payloadpropCount++;
            }

            if (payloadobsUnits != null)
            {
                payload["obsUnits"] = ExpressionConverter.ConvertO(payloadobsUnits);
                payloadpropCount++;
            }

            if (payloadskills != null)
            {
                payload["skills"] = ExpressionConverter.ConvertO(payloadskills);
                payloadpropCount++;
            }

            var resourceManagerObject = new JObject();
            var resourceManagerObjectpropCount = 0;
            if (payloadresourceManageriD != null)
            {
                resourceManagerObject["id"] = ExpressionConverter.ConvertO(payloadresourceManageriD);
                resourceManagerObjectpropCount++;
            }

            if (payloadresourceManagerresourceKey != null)
            {
                resourceManagerObject["resourceKey"] = ExpressionConverter.ConvertO(payloadresourceManagerresourceKey);
                resourceManagerObjectpropCount++;
            }

            if (resourceManagerObjectpropCount > 0)
            {
                payload["resourceManager"] = resourceManagerObject;
                payloadpropCount++;
            }

            if (payloadcostPerHour != null)
            {
                payload["costPerHour"] = ExpressionConverter.ConvertO(payloadcostPerHour);
                payloadpropCount++;
            }

            if (payloadcostPerHourValidFrom != null)
            {
                payload["costPerHourValidFrom"] = ExpressionConverter.ConvertO(payloadcostPerHourValidFrom);
                payloadpropCount++;
            }

            if (payloadcostRates != null)
            {
                payload["costRates"] = ExpressionConverter.ConvertO(payloadcostRates);
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<ResourceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AbsenceResponse> GetAbsenceById(Expression<Func<string>> resourceId, Expression<Func<string>> absenceId)
        {
            var apiCallPath = String.Format("/v1/resources/{0}/absences/{1}", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(absenceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AbsenceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteAbsence(Expression<Func<string>> resourceId, Expression<Func<string>> absenceId)
        {
            var apiCallPath = String.Format("/v1/resources/{0}/absences/{1}", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(absenceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AbsenceResponse> UpdateAbsences(Expression<Func<string>> resourceId, Expression<Func<string>> absenceId, Expression<Func<string>> payloadstart = null, Expression<Func<string>> payloadfinish = null, Expression<Func<payloadstartDayTypeInput>> payloadstartDayType = null, Expression<Func<payloadfinishDayTypeInput>> payloadfinishDayType = null)
        {
            var apiCallPath = String.Format("/v1/resources/{0}/absences/{1}", ExpressionConverter.ConvertWithUrlEncoding(resourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(absenceId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadstart != null)
            {
                payload["start"] = ExpressionConverter.ConvertO(payloadstart);
                payloadpropCount++;
            }

            if (payloadfinish != null)
            {
                payload["finish"] = ExpressionConverter.ConvertO(payloadfinish);
                payloadpropCount++;
            }

            if (payloadstartDayType != null)
            {
                payload["startDayType"] = ExpressionConverter.ConvertO(payloadstartDayType);
                payloadpropCount++;
            }

            if (payloadfinishDayType != null)
            {
                payload["finishDayType"] = ExpressionConverter.ConvertO(payloadfinishDayType);
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<AbsenceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsTypeResponse> GetObsTypeById(Expression<Func<string>> obsTypeId)
        {
            var apiCallPath = String.Format("/v1/obsTypes/{0}", ExpressionConverter.ConvertWithUrlEncoding(obsTypeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ObsTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteObsType(Expression<Func<string>> obsTypeId)
        {
            var apiCallPath = String.Format("/v1/obsTypes/{0}", ExpressionConverter.ConvertWithUrlEncoding(obsTypeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsTypeResponse> UpdateObsType(Expression<Func<string>> obsTypeId, Expression<Func<string>> payloadname)
        {
            var apiCallPath = String.Format("/v1/obsTypes/{0}", ExpressionConverter.ConvertWithUrlEncoding(obsTypeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payloadpropCount++;
            payload["name"] = ExpressionConverter.ConvertO(payloadname);
            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<ObsTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsUnitResponse> GetObsUnit(Expression<Func<string>> obsTypeId, Expression<Func<string>> obsUnitId)
        {
            var apiCallPath = String.Format("/v1/obsTypes/{0}/obsUnits/{1}", ExpressionConverter.ConvertWithUrlEncoding(obsTypeId, 1), ExpressionConverter.ConvertWithUrlEncoding(obsUnitId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ObsUnitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteObsUnit(Expression<Func<string>> obsTypeId, Expression<Func<string>> obsUnitId)
        {
            var apiCallPath = String.Format("/v1/obsTypes/{0}/obsUnits/{1}", ExpressionConverter.ConvertWithUrlEncoding(obsTypeId, 1), ExpressionConverter.ConvertWithUrlEncoding(obsUnitId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ObsUnitResponse> UpdateObsUnit(Expression<Func<string>> obsTypeId, Expression<Func<string>> obsUnitId, Expression<Func<string>> obsUnitUpdateRequestname = null, Expression<Func<string>> obsUnitUpdateRequestparentID = null)
        {
            var apiCallPath = String.Format("/v1/obsTypes/{0}/obsUnits/{1}", ExpressionConverter.ConvertWithUrlEncoding(obsTypeId, 1), ExpressionConverter.ConvertWithUrlEncoding(obsUnitId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var obsUnitUpdateRequest = new JObject();
            var obsUnitUpdateRequestpropCount = 0;
            if (obsUnitUpdateRequestname != null)
            {
                obsUnitUpdateRequest["name"] = ExpressionConverter.ConvertO(obsUnitUpdateRequestname);
                obsUnitUpdateRequestpropCount++;
            }

            if (obsUnitUpdateRequestparentID != null)
            {
                obsUnitUpdateRequest["parentId"] = ExpressionConverter.ConvertO(obsUnitUpdateRequestparentID);
                obsUnitUpdateRequestpropCount++;
            }

            if (obsUnitUpdateRequestpropCount > 0)
            {
                callPayload.Body = obsUnitUpdateRequest;
            }

            return new ApiConnectionAction<ObsUnitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<CalendarResponse> GetCalendarById(Expression<Func<string>> calendarId)
        {
            var apiCallPath = String.Format("/v1/calendars/{0}", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CalendarResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteCalendarById(Expression<Func<string>> calendarId)
        {
            var apiCallPath = String.Format("/v1/calendars/{0}", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<CalendarResponse> UpdateCalendar(Expression<Func<string>> calendarId, Expression<Func<double>> payloadworkingHoursmonday, Expression<Func<double>> payloadworkingHourstuesday, Expression<Func<double>> payloadworkingHourswednesday, Expression<Func<double>> payloadworkingHoursthursday, Expression<Func<double>> payloadworkingHoursfriday, Expression<Func<double>> payloadworkingHourssaturday, Expression<Func<double>> payloadworkingHourssunday, Expression<Func<string>> payloadname = null)
        {
            var apiCallPath = String.Format("/v1/calendars/{0}", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadname != null)
            {
                payload["name"] = ExpressionConverter.ConvertO(payloadname);
                payloadpropCount++;
            }

            var workingHoursObject = new JObject();
            var workingHoursObjectpropCount = 0;
            workingHoursObjectpropCount++;
            workingHoursObject["monday"] = ExpressionConverter.ConvertO(payloadworkingHoursmonday);
            workingHoursObjectpropCount++;
            workingHoursObject["tuesday"] = ExpressionConverter.ConvertO(payloadworkingHourstuesday);
            workingHoursObjectpropCount++;
            workingHoursObject["wednesday"] = ExpressionConverter.ConvertO(payloadworkingHourswednesday);
            workingHoursObjectpropCount++;
            workingHoursObject["thursday"] = ExpressionConverter.ConvertO(payloadworkingHoursthursday);
            workingHoursObjectpropCount++;
            workingHoursObject["friday"] = ExpressionConverter.ConvertO(payloadworkingHoursfriday);
            workingHoursObjectpropCount++;
            workingHoursObject["saturday"] = ExpressionConverter.ConvertO(payloadworkingHourssaturday);
            workingHoursObjectpropCount++;
            workingHoursObject["sunday"] = ExpressionConverter.ConvertO(payloadworkingHourssunday);
            if (workingHoursObjectpropCount > 0)
            {
                payload["workingHours"] = workingHoursObject;
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionAction<CalendarResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseUserResponse> GetAllUsers1(Expression<Func<string>> pageAfter = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<PaginatedResponseUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<UserResponse> GetUser1(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<SprintResponse> GetSprintById(Expression<Func<string>> sprintId)
        {
            var apiCallPath = String.Format("/v1/sprints/{0}", ExpressionConverter.ConvertWithUrlEncoding(sprintId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SprintResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseScenarioResponse> GetAllScenarios()
        {
            var apiCallPath = "/v1/scenarios";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseScenarioResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ScenarioResponse> GetScenarioById(Expression<Func<string>> scenarioId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ScenarioResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseRoleWithRoleCapacityResponse> GetAllRoleCapacities(Expression<Func<string>> scenarioId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/roleCapacities", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseRoleWithRoleCapacityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<TaskResponse> GetTaskById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/taskManagementLink/tasks/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteTask(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/taskManagementLink/tasks/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseProjectCommentResponse> GetAllProjectComments(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> pageAfter = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/comments", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<PaginatedResponseProjectCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ProjectCommentResponse> GetProjectComment(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> commentId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/comments/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<PaginatedResponseAllocationCommentResponse> GetAllAllocationComments(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> pageAfter = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/allocationComments", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pageAfter != null)
                callPayload.Queries["pageAfter"] = ExpressionConverter.Convert(pageAfter);
            callPayload.Queries["pageSize"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<PaginatedResponseAllocationCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<AllocationCommentResponse> GetAllocationComment(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> allocationCommentId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/allocationComments/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(allocationCommentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AllocationCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ActualTimeWorkedByIdResponse> GetActualTimeWorkedById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualsId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/actuals/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(actualsId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ActualTimeWorkedByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteActualTimeWorkedById(Expression<Func<string>> scenarioId, Expression<Func<string>> projectId, Expression<Func<string>> actualsId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/projects/{1}/actuals/{2}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(actualsId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponsePortfolioResponse> GetAllPortfolios()
        {
            var apiCallPath = "/v1/portfolios";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponsePortfolioResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IBodyWorkflowAction<ListResponseBusinessGoalDefinitionResponse> GetAllBusinessGoals()
        {
            var apiCallPath = "/v1/businessGoals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListResponseBusinessGoalDefinitionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meisterplan")]
        public IWorkflowAction DeleteMilestoneDependency(Expression<Func<string>> scenarioId, Expression<Func<string>> milestoneDependencyId)
        {
            var apiCallPath = String.Format("/v1/scenarios/{0}/milestoneDependencies/{1}", ExpressionConverter.ConvertWithUrlEncoding(scenarioId, 1), ExpressionConverter.ConvertWithUrlEncoding(milestoneDependencyId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class MeisterplanTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse> CreateWebhook(Expression<Func<payloadeventTypesInputItem[]>> payloadeventTypes, Expression<Func<string>> payloadscenarioID, Expression<Func<string>> payloadprojectID = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            payload["callbackUrl"] = "@listCallbackUrl()";
            payloadpropCount++;
            payloadpropCount++;
            payload["eventTypes"] = ExpressionConverter.ConvertO(payloadeventTypes);
            payloadpropCount++;
            payload["scenarioId"] = ExpressionConverter.ConvertO(payloadscenarioID);
            if (payloadprojectID != null)
            {
                payload["projectId"] = ExpressionConverter.ConvertO(payloadprojectID);
                payloadpropCount++;
            }

            if (payloadpropCount > 0)
            {
                callPayload.Body = payload;
            }

            return new ApiConnectionTrigger<WebhookResponse>(callPayload, triggerName, recurrence);
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

    public class ListResponseMilestoneResponse
    {
        [JsonProperty("items")]
        public MilestoneResponse[] Items { get; set; }
    }

    public class MilestoneResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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

    public enum payloadstatusvalueInput
    {
        [EnumMember(Value = "ON_TRACK")]
        ONTRACK,
        [EnumMember(Value = "NEEDS_ATTENTION")]
        NEEDSATTENTION,
        [EnumMember(Value = "OFF_TRACK")]
        OFFTRACK,
        DONE
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

    public class ListResponseFinancialsResponse
    {
        [JsonProperty("items")]
        public FinancialsResponse[] Items { get; set; }
    }

    public class FinancialsResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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
        public string MilestoneID { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }
    }

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

    public enum payloadtypeInput
    {
        CAPEX,
        OPEX,
        BENEFIT
    }

    public enum payloadtimingonInput
    {
        ProjectStart,
        ProjectFinish,
        Milestone,
        Date
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

    public enum FinancialEventTypeType
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
        public string MilestoneID { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }
    }

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

    public class ListResponseFinancialActualsResponse
    {
        [JsonProperty("items")]
        public FinancialActualsResponse[] Items { get; set; }
    }

    public class FinancialActualsResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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

    public enum FinancialActualsResponseTypeType
    {
        CAPEX,
        OPEX,
        BENEFIT
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
        public string ID { get; set; }

        [JsonProperty("allocatedEntity")]
        public AllocatedEntityResponse AllocatedEntity { get; set; }

        [JsonProperty("segments")]
        public AllocationSegmentResponse[] Segments { get; set; }
    }

    public class AllocatedEntityResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public AllocatedEntityResponseTypeType Type { get; set; }

        [JsonProperty("projectRole")]
        public string ProjectRole { get; set; }
    }

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

    public enum allocationCreateOrUpdateRequestallocatedEntitytypeInput
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

    public class Allocation
    {
        [JsonProperty("allocatedEntity")]
        public AllocatedEntity AllocatedEntity { get; set; }

        [JsonProperty("segments")]
        public AllocationSegment[] Segments { get; set; }
    }

    public class AllocatedEntity
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public AllocatedEntityTypeType Type { get; set; }

        [JsonProperty("projectRole")]
        public string ProjectRole { get; set; }
    }

    public enum AllocatedEntityTypeType
    {
        ROLE,
        RESOURCE,
        TEAM,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public class ListResponseAbsenceResponse
    {
        [JsonProperty("items")]
        public AbsenceResponse[] Items { get; set; }
    }

    public class AbsenceResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("finish")]
        public string FinishDate { get; set; }

        [JsonProperty("startDayType")]
        public AbsenceResponseStartAbsenceDayTypeType StartAbsenceDayType { get; set; }

        [JsonProperty("finishDayType")]
        public AbsenceResponseFinishAbsenceDayTypeType FinishAbsenceDayType { get; set; }
    }

    public enum AbsenceResponseStartAbsenceDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    public enum AbsenceResponseFinishAbsenceDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    public enum payloadstartDayTypeInput
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

    public enum payloadfinishDayTypeInput
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
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

    public enum CreateAbsenceRequestStartDayTypeType
    {
        [EnumMember(Value = "FULL_DAY")]
        FULLDAY,
        [EnumMember(Value = "HALF_DAY")]
        HALFDAY
    }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class MinimalPrimaryRoleResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

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
        public string ID { get; set; }

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

    public enum AllProjectsPriorityResponseRankCategoryType
    {
        [EnumMember(Value = "ABOVE_MUST_HAVE")]
        ABOVEMUSTHAVE,
        [EnumMember(Value = "BELOW_CUT_OFF")]
        BELOWCUTOFF,
        REGULAR
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
        public string ID { get; set; }

        [JsonProperty("type")]
        public ActualsEntityLinkResponseTypeType Type { get; set; }

        [JsonProperty("teamId")]
        public string TeamID { get; set; }
    }

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

    public enum ActualsBookingResponseCostTypeType
    {
        CAPEX,
        OPEX
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

    public enum BookingsCostTypeType
    {
        CAPEX,
        OPEX
    }

    public enum payloadbookedEntitytypeInput
    {
        ROLE,
        RESOURCE,
        [EnumMember(Value = "RESOLVE_BY_KEY_OR_NAME")]
        RESOLVEBYKEYORNAME
    }

    public enum payloadmodeInput
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
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("programKey")]
        public string ProgramKey { get; set; }
    }

    public class PriorityEntry
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum prioritiesUpdateRequestbelowCutOffpositionInput
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
        public string ID { get; set; }

        [JsonProperty("from")]
        public MilestoneReferenceResponse From { get; set; }

        [JsonProperty("to")]
        public MilestoneReferenceResponse To { get; set; }
    }

    public class MilestoneReferenceResponse
    {
        [JsonProperty("projectId")]
        public string ProjectID { get; set; }

        [JsonProperty("milestoneId")]
        public string MilestoneID { get; set; }
    }

    public class MilestoneDependencyCreateResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ListResponseRoleResponse
    {
        [JsonProperty("items")]
        public RoleResponse[] Items { get; set; }
    }

    public class RoleResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalID { get; set; }

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

    public enum RoleResponseCostTypeType
    {
        CAPEX,
        OPEX
    }

    public enum payloadcostTypeInput
    {
        CAPEX,
        OPEX
    }

    public class CostRate
    {
        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("costPerHourValidFrom")]
        public string CostPerHourValidFrom { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalID { get; set; }

        [JsonProperty("costType")]
        public PrimaryRoleResponseCostTypeType CostType { get; set; }

        [JsonProperty("costPerHour")]
        public double CostPerHour { get; set; }

        [JsonProperty("obsUnits")]
        public JToken OBSUnits { get; set; }
    }

    public enum PrimaryRoleResponseCostTypeType
    {
        CAPEX,
        OPEX
    }

    public class ResourceCalendarResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("name")]
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
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }
    }

    public class ListResponseCalendarResponse
    {
        [JsonProperty("items")]
        public CalendarResponse[] Items { get; set; }
    }

    public class CalendarResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }

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
        public string SourceCalendarID { get; set; }
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

    public class payloadInput
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
        public string ID { get; set; }
    }

    public class ResourceManager
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class Velocity
    {
        [JsonProperty("storyPointsPerPersonDay")]
        public double StoryPointsPerPersonDay { get; set; }
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

    public enum PriorityResponseRankCategoryType
    {
        [EnumMember(Value = "ABOVE_MUST_HAVE")]
        ABOVEMUSTHAVE,
        [EnumMember(Value = "BELOW_CUT_OFF")]
        BELOWCUTOFF,
        REGULAR
    }

    public class payloadInput2
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

    public class ProjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Manager
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public enum payloadInputCostTypeType
    {
        CAPEX,
        OPEX
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
        public string ID { get; set; }

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

    public enum RankCategoryCategoryType
    {
        [EnumMember(Value = "ABOVE_MUST_HAVE")]
        ABOVEMUSTHAVE,
        REGULAR,
        [EnumMember(Value = "BELOW_CUT_OFF")]
        BELOWCUTOFF
    }

    public enum RankCategoryPositionType
    {
        LAST,
        FIRST
    }

    public class ProgramResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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

    public class payloadInput22
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
        public string ID { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class SingleValueFieldRequest
    {
        [JsonProperty("value")]
        public string Value { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("userName")]
        public string Username { get; set; }

        [JsonProperty("externalId")]
        public string ExternalID { get; set; }

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
        public string GroupID { get; set; }

        [JsonProperty("name")]
        public string GroupName { get; set; }
    }

    public class LinkedResourceResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("resourceKey")]
        public string ResourceKey { get; set; }
    }

    public class SprintResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string UserID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("type")]
        public AllocationCommentEntityResponseTypeType Type { get; set; }
    }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("callbackUrl")]
        public string CallbackURL { get; set; }

        [JsonProperty("eventTypes")]
        public WebhookResponseEventTypesTypeItem[] EventTypes { get; set; }

        [JsonProperty("scenarioId")]
        public string ScenarioID { get; set; }

        [JsonProperty("projectId")]
        public string ProjectID { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public WebhookResponseStatusType Status { get; set; }

        [JsonProperty("createdBy")]
        public UserRefResponse CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }
    }

    public enum WebhookResponseEventTypesTypeItem
    {
        [EnumMember(Value = "PROJECT_CREATE")]
        PROJECTCREATE,
        [EnumMember(Value = "PROJECT_UPDATE")]
        PROJECTUPDATE,
        [EnumMember(Value = "PROJECT_DELETE")]
        PROJECTDELETE
    }

    public enum WebhookResponseStatusType
    {
        SUSPENDED,
        ACTIVE
    }

    public enum payloadeventTypesInputItem
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