//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Exactonlinetimebilip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExactonlinetimebilipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<DivisionsResponse> GetDivisions(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/hrm/Divisions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<DivisionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<EmploymentInternalRatesResponse> GetEmploymentInternalRates(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/EmploymentInternalRates", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<EmploymentInternalRatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourCostTypesResponse> GetHourCostTypes(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourCostTypes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<HourCostTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryActivitiesByProjectResponse> GetHourEntryActivitiesByProject(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryActivitiesByProject", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            return new ApiConnectionAction<HourEntryActivitiesByProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentAccountsResponse> GetHourEntryRecentAccounts(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentAccounts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<HourEntryRecentAccountsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentAccountsByProjectResponse> GetHourEntryRecentAccountsByProject(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentAccountsByProject", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            return new ApiConnectionAction<HourEntryRecentAccountsByProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentHourTypesResponse> GetHourEntryRecentHourTypes(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentHourTypes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<HourEntryRecentHourTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentHourTypesByProjectResponse> GetHourEntryRecentHourTypesByProject(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentHourTypesByProject", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            return new ApiConnectionAction<HourEntryRecentHourTypesByProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentProjectsResponse> GetHourEntryRecentProjects(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentProjects", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<HourEntryRecentProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HoursByDateResponse> GetHoursByDate(Expression<Func<string>> checkDate, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HoursByDate", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["checkDate"] = CSharpExpressionConverter.ConvertO(checkDate);
            return new ApiConnectionAction<HoursByDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HoursByIdResponse> GetHoursById(Expression<Func<string>> division, Expression<Func<string>> entryId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HoursById", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["entryId"] = CSharpExpressionConverter.ConvertO(entryId);
            return new ApiConnectionAction<HoursByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesResponse> GetHourTypes(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<HourTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesByDateResponse> GetHourTypesByDate(Expression<Func<string>> checkDate, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypesByDate", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["checkDate"] = CSharpExpressionConverter.ConvertO(checkDate);
            return new ApiConnectionAction<HourTypesByDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesByProjectAndDateResponse> GetHourTypesByProjectAndDate(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypesByProjectAndDate", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            return new ApiConnectionAction<HourTypesByProjectAndDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> GetProjectRestrictionRebillings(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> PutProjectRestrictionRebillings(Expression<Func<string>> division, Expression<Func<string>> iD, Expression<Func<string>> projectRestrictionRebillingscostTypeRebill, Expression<Func<string>> projectRestrictionRebillingsproject, Expression<Func<string>> projectRestrictionRebillingsiD = null, Expression<Func<string>> projectRestrictionRebillingscostTypeRebillCode = null, Expression<Func<string>> projectRestrictionRebillingscostTypeRebillDescription = null, Expression<Func<string>> projectRestrictionRebillingscreated = null, Expression<Func<string>> projectRestrictionRebillingscreator = null, Expression<Func<string>> projectRestrictionRebillingscreatorFullName = null, Expression<Func<int>> projectRestrictionRebillingsdivision = null, Expression<Func<string>> projectRestrictionRebillingsmodified = null, Expression<Func<string>> projectRestrictionRebillingsmodifier = null, Expression<Func<string>> projectRestrictionRebillingsmodifierFullName = null, Expression<Func<string>> projectRestrictionRebillingsprojectCode = null, Expression<Func<string>> projectRestrictionRebillingsprojectDescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ID"] = CSharpExpressionConverter.ConvertO(iD);
            var projectRestrictionRebillings = new JObject();
            var projectRestrictionRebillingspropCount = 0;
            if (projectRestrictionRebillingsiD != null)
            {
                projectRestrictionRebillings["ID"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsiD);
                projectRestrictionRebillingspropCount++;
            }

            projectRestrictionRebillingspropCount++;
            projectRestrictionRebillings["CostTypeRebill"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebill);
            if (projectRestrictionRebillingscostTypeRebillCode != null)
            {
                projectRestrictionRebillings["CostTypeRebillCode"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebillCode);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingscostTypeRebillDescription != null)
            {
                projectRestrictionRebillings["CostTypeRebillDescription"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebillDescription);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingscreated != null)
            {
                projectRestrictionRebillings["Created"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscreated);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingscreator != null)
            {
                projectRestrictionRebillings["Creator"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscreator);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingscreatorFullName != null)
            {
                projectRestrictionRebillings["CreatorFullName"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscreatorFullName);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsdivision != null)
            {
                projectRestrictionRebillings["Division"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsdivision);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsmodified != null)
            {
                projectRestrictionRebillings["Modified"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsmodified);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsmodifier != null)
            {
                projectRestrictionRebillings["Modifier"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsmodifier);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsmodifierFullName != null)
            {
                projectRestrictionRebillings["ModifierFullName"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsmodifierFullName);
                projectRestrictionRebillingspropCount++;
            }

            projectRestrictionRebillingspropCount++;
            projectRestrictionRebillings["Project"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsproject);
            if (projectRestrictionRebillingsprojectCode != null)
            {
                projectRestrictionRebillings["ProjectCode"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsprojectCode);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsprojectDescription != null)
            {
                projectRestrictionRebillings["ProjectDescription"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsprojectDescription);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingspropCount > 0)
            {
                callPayload.Body = projectRestrictionRebillings;
            }

            return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> PostProjectRestrictionRebillings(Expression<Func<string>> division, Expression<Func<string>> projectRestrictionRebillingscostTypeRebill, Expression<Func<string>> projectRestrictionRebillingsproject, Expression<Func<string>> projectRestrictionRebillingsiD = null, Expression<Func<string>> projectRestrictionRebillingscostTypeRebillCode = null, Expression<Func<string>> projectRestrictionRebillingscostTypeRebillDescription = null, Expression<Func<string>> projectRestrictionRebillingscreated = null, Expression<Func<string>> projectRestrictionRebillingscreator = null, Expression<Func<string>> projectRestrictionRebillingscreatorFullName = null, Expression<Func<int>> projectRestrictionRebillingsdivision = null, Expression<Func<string>> projectRestrictionRebillingsmodified = null, Expression<Func<string>> projectRestrictionRebillingsmodifier = null, Expression<Func<string>> projectRestrictionRebillingsmodifierFullName = null, Expression<Func<string>> projectRestrictionRebillingsprojectCode = null, Expression<Func<string>> projectRestrictionRebillingsprojectDescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var projectRestrictionRebillings = new JObject();
            var projectRestrictionRebillingspropCount = 0;
            if (projectRestrictionRebillingsiD != null)
            {
                projectRestrictionRebillings["ID"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsiD);
                projectRestrictionRebillingspropCount++;
            }

            projectRestrictionRebillingspropCount++;
            projectRestrictionRebillings["CostTypeRebill"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebill);
            if (projectRestrictionRebillingscostTypeRebillCode != null)
            {
                projectRestrictionRebillings["CostTypeRebillCode"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebillCode);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingscostTypeRebillDescription != null)
            {
                projectRestrictionRebillings["CostTypeRebillDescription"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebillDescription);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingscreated != null)
            {
                projectRestrictionRebillings["Created"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscreated);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingscreator != null)
            {
                projectRestrictionRebillings["Creator"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscreator);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingscreatorFullName != null)
            {
                projectRestrictionRebillings["CreatorFullName"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingscreatorFullName);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsdivision != null)
            {
                projectRestrictionRebillings["Division"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsdivision);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsmodified != null)
            {
                projectRestrictionRebillings["Modified"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsmodified);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsmodifier != null)
            {
                projectRestrictionRebillings["Modifier"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsmodifier);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsmodifierFullName != null)
            {
                projectRestrictionRebillings["ModifierFullName"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsmodifierFullName);
                projectRestrictionRebillingspropCount++;
            }

            projectRestrictionRebillingspropCount++;
            projectRestrictionRebillings["Project"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsproject);
            if (projectRestrictionRebillingsprojectCode != null)
            {
                projectRestrictionRebillings["ProjectCode"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsprojectCode);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingsprojectDescription != null)
            {
                projectRestrictionRebillings["ProjectDescription"] = CSharpExpressionConverter.ConvertToken(projectRestrictionRebillingsprojectDescription);
                projectRestrictionRebillingspropCount++;
            }

            if (projectRestrictionRebillingspropCount > 0)
            {
                callPayload.Body = projectRestrictionRebillings;
            }

            return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> DeleteProjectRestrictionRebillings(Expression<Func<string>> division, Expression<Func<string>> iD)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ID"] = CSharpExpressionConverter.ConvertO(iD);
            return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentCostsByNumberOfWeeksResponse> GetRecentCostsByNumberOfWeeks(Expression<Func<string>> division, Expression<Func<int>> numberOfWeeks, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentCostsByNumberOfWeeks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["numberOfWeeks"] = CSharpExpressionConverter.ConvertO(numberOfWeeks);
            return new ApiConnectionAction<RecentCostsByNumberOfWeeksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentHoursResponse> GetRecentHours(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentHours", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<RecentHoursResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentHoursByNumberOfWeeksResponse> GetRecentHoursByNumberOfWeeks(Expression<Func<string>> division, Expression<Func<int>> numberOfWeeks, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentHoursByNumberOfWeeks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["numberOfWeeks"] = CSharpExpressionConverter.ConvertO(numberOfWeeks);
            return new ApiConnectionAction<RecentHoursByNumberOfWeeksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsResponse> GetTimeAndBillingAccountDetails(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingAccountDetails", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingAccountDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsByIDResponse> GetTimeAndBillingAccountDetailsByID(Expression<Func<string>> accountId, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingAccountDetailsByID", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["accountId"] = CSharpExpressionConverter.ConvertO(accountId);
            return new ApiConnectionAction<TimeAndBillingAccountDetailsByIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingActivitiesAndExpensesResponse> GetTimeAndBillingActivitiesAndExpenses(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingActivitiesAndExpenses", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingActivitiesAndExpensesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsResponse> GetTimeAndBillingEntryAccounts(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccounts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingEntryAccountsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByDateResponse> GetTimeAndBillingEntryAccountsByDate(Expression<Func<string>> checkDate, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccountsByDate", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["checkDate"] = CSharpExpressionConverter.ConvertO(checkDate);
            return new ApiConnectionAction<TimeAndBillingEntryAccountsByDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByProjectAndDateResponse> GetTimeAndBillingEntryAccountsByProjectAndDate(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccountsByProjectAndDate", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            return new ApiConnectionAction<TimeAndBillingEntryAccountsByProjectAndDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsResponse> GetTimeAndBillingEntryProjects(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjects", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingEntryProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByAccountAndDateResponse> GetTimeAndBillingEntryProjectsByAccountAndDate(Expression<Func<string>> accountId, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjectsByAccountAndDate", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["accountId"] = CSharpExpressionConverter.ConvertO(accountId);
            return new ApiConnectionAction<TimeAndBillingEntryProjectsByAccountAndDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByDateResponse> GetTimeAndBillingEntryProjectsByDate(Expression<Func<string>> checkDate, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjectsByDate", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["checkDate"] = CSharpExpressionConverter.ConvertO(checkDate);
            return new ApiConnectionAction<TimeAndBillingEntryProjectsByDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentAccountsResponse> GetTimeAndBillingEntryRecentAccounts(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentAccounts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingEntryRecentAccountsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse> GetTimeAndBillingEntryRecentActivitiesAndExpenses(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentActivitiesAndExpenses", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentHourCostTypesResponse> GetTimeAndBillingEntryRecentHourCostTypes(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentHourCostTypes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingEntryRecentHourCostTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentProjectsResponse> GetTimeAndBillingEntryRecentProjects(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentProjects", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingEntryRecentProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsResponse> GetTimeAndBillingItemDetails(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingItemDetails", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingItemDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsByIDResponse> GetTimeAndBillingItemDetailsByID(Expression<Func<string>> division, Expression<Func<string>> itemId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingItemDetailsByID", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["itemId"] = CSharpExpressionConverter.ConvertO(itemId);
            return new ApiConnectionAction<TimeAndBillingItemDetailsByIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsResponse> GetTimeAndBillingProjectDetails(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingProjectDetails", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingProjectDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsByIDResponse> GetTimeAndBillingProjectDetailsByID(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingProjectDetailsByID", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            return new ApiConnectionAction<TimeAndBillingProjectDetailsByIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingRecentProjectsResponse> GetTimeAndBillingRecentProjects(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingRecentProjects", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeAndBillingRecentProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> GetTimeCorrections(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> PutTimeCorrections(Expression<Func<string>> division, Expression<Func<string>> iD, Expression<Func<string>> timeCorrectionsiD = null, Expression<Func<string>> timeCorrectionscreated = null, Expression<Func<string>> timeCorrectionscreator = null, Expression<Func<string>> timeCorrectionscreatorFullName = null, Expression<Func<int>> timeCorrectionsdivision = null, Expression<Func<string>> timeCorrectionsmodified = null, Expression<Func<string>> timeCorrectionsmodifier = null, Expression<Func<string>> timeCorrectionsmodifierFullName = null, Expression<Func<string>> timeCorrectionsnotes = null, Expression<Func<string>> timeCorrectionsoriginalEntryId = null, Expression<Func<double>> timeCorrectionsquantity = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ID"] = CSharpExpressionConverter.ConvertO(iD);
            var timeCorrections = new JObject();
            var timeCorrectionspropCount = 0;
            if (timeCorrectionsiD != null)
            {
                timeCorrections["ID"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsiD);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionscreated != null)
            {
                timeCorrections["Created"] = CSharpExpressionConverter.ConvertToken(timeCorrectionscreated);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionscreator != null)
            {
                timeCorrections["Creator"] = CSharpExpressionConverter.ConvertToken(timeCorrectionscreator);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionscreatorFullName != null)
            {
                timeCorrections["CreatorFullName"] = CSharpExpressionConverter.ConvertToken(timeCorrectionscreatorFullName);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsdivision != null)
            {
                timeCorrections["Division"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsdivision);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsmodified != null)
            {
                timeCorrections["Modified"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsmodified);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsmodifier != null)
            {
                timeCorrections["Modifier"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsmodifier);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsmodifierFullName != null)
            {
                timeCorrections["ModifierFullName"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsmodifierFullName);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsnotes != null)
            {
                timeCorrections["Notes"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsnotes);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsoriginalEntryId != null)
            {
                timeCorrections["OriginalEntryId"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsoriginalEntryId);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsquantity != null)
            {
                timeCorrections["Quantity"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsquantity);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionspropCount > 0)
            {
                callPayload.Body = timeCorrections;
            }

            return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> PostTimeCorrections(Expression<Func<string>> division, Expression<Func<string>> timeCorrectionsiD = null, Expression<Func<string>> timeCorrectionscreated = null, Expression<Func<string>> timeCorrectionscreator = null, Expression<Func<string>> timeCorrectionscreatorFullName = null, Expression<Func<int>> timeCorrectionsdivision = null, Expression<Func<string>> timeCorrectionsmodified = null, Expression<Func<string>> timeCorrectionsmodifier = null, Expression<Func<string>> timeCorrectionsmodifierFullName = null, Expression<Func<string>> timeCorrectionsnotes = null, Expression<Func<string>> timeCorrectionsoriginalEntryId = null, Expression<Func<double>> timeCorrectionsquantity = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var timeCorrections = new JObject();
            var timeCorrectionspropCount = 0;
            if (timeCorrectionsiD != null)
            {
                timeCorrections["ID"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsiD);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionscreated != null)
            {
                timeCorrections["Created"] = CSharpExpressionConverter.ConvertToken(timeCorrectionscreated);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionscreator != null)
            {
                timeCorrections["Creator"] = CSharpExpressionConverter.ConvertToken(timeCorrectionscreator);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionscreatorFullName != null)
            {
                timeCorrections["CreatorFullName"] = CSharpExpressionConverter.ConvertToken(timeCorrectionscreatorFullName);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsdivision != null)
            {
                timeCorrections["Division"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsdivision);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsmodified != null)
            {
                timeCorrections["Modified"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsmodified);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsmodifier != null)
            {
                timeCorrections["Modifier"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsmodifier);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsmodifierFullName != null)
            {
                timeCorrections["ModifierFullName"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsmodifierFullName);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsnotes != null)
            {
                timeCorrections["Notes"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsnotes);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsoriginalEntryId != null)
            {
                timeCorrections["OriginalEntryId"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsoriginalEntryId);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionsquantity != null)
            {
                timeCorrections["Quantity"] = CSharpExpressionConverter.ConvertToken(timeCorrectionsquantity);
                timeCorrectionspropCount++;
            }

            if (timeCorrectionspropCount > 0)
            {
                callPayload.Body = timeCorrections;
            }

            return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> DeleteTimeCorrections(Expression<Func<string>> division, Expression<Func<string>> iD)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ID"] = CSharpExpressionConverter.ConvertO(iD);
            return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> GetTimeTransactions(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> PutTimeTransactions(Expression<Func<string>> division, Expression<Func<string>> iD, Expression<Func<string>> timeTransactionsitem, Expression<Func<string>> timeTransactionsproject, Expression<Func<double>> timeTransactionsquantity, Expression<Func<string>> timeTransactionsiD = null, Expression<Func<string>> timeTransactionsaccount = null, Expression<Func<string>> timeTransactionsaccountName = null, Expression<Func<string>> timeTransactionsactivity = null, Expression<Func<string>> timeTransactionsactivityDescription = null, Expression<Func<double>> timeTransactionsamount = null, Expression<Func<double>> timeTransactionsamountFC = null, Expression<Func<string>> timeTransactionsattachment = null, Expression<Func<string>> timeTransactionscreated = null, Expression<Func<string>> timeTransactionscreator = null, Expression<Func<string>> timeTransactionscreatorFullName = null, Expression<Func<string>> timeTransactionscurrency = null, Expression<Func<string>> timeTransactionsdate = null, Expression<Func<int>> timeTransactionsdivision = null, Expression<Func<string>> timeTransactionsdivisionDescription = null, Expression<Func<string>> timeTransactionsemployee = null, Expression<Func<string>> timeTransactionsendTime = null, Expression<Func<int>> timeTransactionsentryNumber = null, Expression<Func<string>> timeTransactionserrorText = null, Expression<Func<double>> timeTransactionshourStatus = null, Expression<Func<string>> timeTransactionsitemDescription = null, Expression<Func<bool>> timeTransactionsitemDivisable = null, Expression<Func<string>> timeTransactionsmodified = null, Expression<Func<string>> timeTransactionsmodifier = null, Expression<Func<string>> timeTransactionsmodifierFullName = null, Expression<Func<string>> timeTransactionsnotes = null, Expression<Func<double>> timeTransactionsprice = null, Expression<Func<double>> timeTransactionspriceFC = null, Expression<Func<string>> timeTransactionsprojectAccount = null, Expression<Func<string>> timeTransactionsprojectAccountCode = null, Expression<Func<string>> timeTransactionsprojectAccountName = null, Expression<Func<string>> timeTransactionsprojectCode = null, Expression<Func<string>> timeTransactionsprojectDescription = null, Expression<Func<bool>> timeTransactionsskipValidation = null, Expression<Func<string>> timeTransactionsstartTime = null, Expression<Func<string>> timeTransactionssubscription = null, Expression<Func<string>> timeTransactionssubscriptionAccount = null, Expression<Func<string>> timeTransactionssubscriptionAccountCode = null, Expression<Func<string>> timeTransactionssubscriptionAccountName = null, Expression<Func<string>> timeTransactionssubscriptionDescription = null, Expression<Func<int>> timeTransactionssubscriptionNumber = null, Expression<Func<double>> timeTransactionstype = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ID"] = CSharpExpressionConverter.ConvertO(iD);
            var timeTransactions = new JObject();
            var timeTransactionspropCount = 0;
            if (timeTransactionsiD != null)
            {
                timeTransactions["ID"] = CSharpExpressionConverter.ConvertToken(timeTransactionsiD);
                timeTransactionspropCount++;
            }

            if (timeTransactionsaccount != null)
            {
                timeTransactions["Account"] = CSharpExpressionConverter.ConvertToken(timeTransactionsaccount);
                timeTransactionspropCount++;
            }

            if (timeTransactionsaccountName != null)
            {
                timeTransactions["AccountName"] = CSharpExpressionConverter.ConvertToken(timeTransactionsaccountName);
                timeTransactionspropCount++;
            }

            if (timeTransactionsactivity != null)
            {
                timeTransactions["Activity"] = CSharpExpressionConverter.ConvertToken(timeTransactionsactivity);
                timeTransactionspropCount++;
            }

            if (timeTransactionsactivityDescription != null)
            {
                timeTransactions["ActivityDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionsactivityDescription);
                timeTransactionspropCount++;
            }

            if (timeTransactionsamount != null)
            {
                timeTransactions["Amount"] = CSharpExpressionConverter.ConvertToken(timeTransactionsamount);
                timeTransactionspropCount++;
            }

            if (timeTransactionsamountFC != null)
            {
                timeTransactions["AmountFC"] = CSharpExpressionConverter.ConvertToken(timeTransactionsamountFC);
                timeTransactionspropCount++;
            }

            if (timeTransactionsattachment != null)
            {
                timeTransactions["Attachment"] = CSharpExpressionConverter.ConvertToken(timeTransactionsattachment);
                timeTransactionspropCount++;
            }

            if (timeTransactionscreated != null)
            {
                timeTransactions["Created"] = CSharpExpressionConverter.ConvertToken(timeTransactionscreated);
                timeTransactionspropCount++;
            }

            if (timeTransactionscreator != null)
            {
                timeTransactions["Creator"] = CSharpExpressionConverter.ConvertToken(timeTransactionscreator);
                timeTransactionspropCount++;
            }

            if (timeTransactionscreatorFullName != null)
            {
                timeTransactions["CreatorFullName"] = CSharpExpressionConverter.ConvertToken(timeTransactionscreatorFullName);
                timeTransactionspropCount++;
            }

            if (timeTransactionscurrency != null)
            {
                timeTransactions["Currency"] = CSharpExpressionConverter.ConvertToken(timeTransactionscurrency);
                timeTransactionspropCount++;
            }

            if (timeTransactionsdate != null)
            {
                timeTransactions["Date"] = CSharpExpressionConverter.ConvertToken(timeTransactionsdate);
                timeTransactionspropCount++;
            }

            if (timeTransactionsdivision != null)
            {
                timeTransactions["Division"] = CSharpExpressionConverter.ConvertToken(timeTransactionsdivision);
                timeTransactionspropCount++;
            }

            if (timeTransactionsdivisionDescription != null)
            {
                timeTransactions["DivisionDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionsdivisionDescription);
                timeTransactionspropCount++;
            }

            if (timeTransactionsemployee != null)
            {
                timeTransactions["Employee"] = CSharpExpressionConverter.ConvertToken(timeTransactionsemployee);
                timeTransactionspropCount++;
            }

            if (timeTransactionsendTime != null)
            {
                timeTransactions["EndTime"] = CSharpExpressionConverter.ConvertToken(timeTransactionsendTime);
                timeTransactionspropCount++;
            }

            if (timeTransactionsentryNumber != null)
            {
                timeTransactions["EntryNumber"] = CSharpExpressionConverter.ConvertToken(timeTransactionsentryNumber);
                timeTransactionspropCount++;
            }

            if (timeTransactionserrorText != null)
            {
                timeTransactions["ErrorText"] = CSharpExpressionConverter.ConvertToken(timeTransactionserrorText);
                timeTransactionspropCount++;
            }

            if (timeTransactionshourStatus != null)
            {
                timeTransactions["HourStatus"] = CSharpExpressionConverter.ConvertToken(timeTransactionshourStatus);
                timeTransactionspropCount++;
            }

            timeTransactionspropCount++;
            timeTransactions["Item"] = CSharpExpressionConverter.ConvertToken(timeTransactionsitem);
            if (timeTransactionsitemDescription != null)
            {
                timeTransactions["ItemDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionsitemDescription);
                timeTransactionspropCount++;
            }

            if (timeTransactionsitemDivisable != null)
            {
                timeTransactions["ItemDivisable"] = CSharpExpressionConverter.ConvertToken(timeTransactionsitemDivisable);
                timeTransactionspropCount++;
            }

            if (timeTransactionsmodified != null)
            {
                timeTransactions["Modified"] = CSharpExpressionConverter.ConvertToken(timeTransactionsmodified);
                timeTransactionspropCount++;
            }

            if (timeTransactionsmodifier != null)
            {
                timeTransactions["Modifier"] = CSharpExpressionConverter.ConvertToken(timeTransactionsmodifier);
                timeTransactionspropCount++;
            }

            if (timeTransactionsmodifierFullName != null)
            {
                timeTransactions["ModifierFullName"] = CSharpExpressionConverter.ConvertToken(timeTransactionsmodifierFullName);
                timeTransactionspropCount++;
            }

            if (timeTransactionsnotes != null)
            {
                timeTransactions["Notes"] = CSharpExpressionConverter.ConvertToken(timeTransactionsnotes);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprice != null)
            {
                timeTransactions["Price"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprice);
                timeTransactionspropCount++;
            }

            if (timeTransactionspriceFC != null)
            {
                timeTransactions["PriceFC"] = CSharpExpressionConverter.ConvertToken(timeTransactionspriceFC);
                timeTransactionspropCount++;
            }

            timeTransactionspropCount++;
            timeTransactions["Project"] = CSharpExpressionConverter.ConvertToken(timeTransactionsproject);
            if (timeTransactionsprojectAccount != null)
            {
                timeTransactions["ProjectAccount"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectAccount);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprojectAccountCode != null)
            {
                timeTransactions["ProjectAccountCode"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectAccountCode);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprojectAccountName != null)
            {
                timeTransactions["ProjectAccountName"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectAccountName);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprojectCode != null)
            {
                timeTransactions["ProjectCode"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectCode);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprojectDescription != null)
            {
                timeTransactions["ProjectDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectDescription);
                timeTransactionspropCount++;
            }

            timeTransactionspropCount++;
            timeTransactions["Quantity"] = CSharpExpressionConverter.ConvertToken(timeTransactionsquantity);
            if (timeTransactionsskipValidation != null)
            {
                timeTransactions["SkipValidation"] = CSharpExpressionConverter.ConvertToken(timeTransactionsskipValidation);
                timeTransactionspropCount++;
            }

            if (timeTransactionsstartTime != null)
            {
                timeTransactions["StartTime"] = CSharpExpressionConverter.ConvertToken(timeTransactionsstartTime);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscription != null)
            {
                timeTransactions["Subscription"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscription);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionAccount != null)
            {
                timeTransactions["SubscriptionAccount"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionAccount);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionAccountCode != null)
            {
                timeTransactions["SubscriptionAccountCode"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionAccountCode);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionAccountName != null)
            {
                timeTransactions["SubscriptionAccountName"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionAccountName);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionDescription != null)
            {
                timeTransactions["SubscriptionDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionDescription);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionNumber != null)
            {
                timeTransactions["SubscriptionNumber"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionNumber);
                timeTransactionspropCount++;
            }

            if (timeTransactionstype != null)
            {
                timeTransactions["Type"] = CSharpExpressionConverter.ConvertToken(timeTransactionstype);
                timeTransactionspropCount++;
            }

            if (timeTransactionspropCount > 0)
            {
                callPayload.Body = timeTransactions;
            }

            return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> PostTimeTransactions(Expression<Func<string>> division, Expression<Func<string>> timeTransactionsitem, Expression<Func<string>> timeTransactionsproject, Expression<Func<double>> timeTransactionsquantity, Expression<Func<string>> timeTransactionsiD = null, Expression<Func<string>> timeTransactionsaccount = null, Expression<Func<string>> timeTransactionsaccountName = null, Expression<Func<string>> timeTransactionsactivity = null, Expression<Func<string>> timeTransactionsactivityDescription = null, Expression<Func<double>> timeTransactionsamount = null, Expression<Func<double>> timeTransactionsamountFC = null, Expression<Func<string>> timeTransactionsattachment = null, Expression<Func<string>> timeTransactionscreated = null, Expression<Func<string>> timeTransactionscreator = null, Expression<Func<string>> timeTransactionscreatorFullName = null, Expression<Func<string>> timeTransactionscurrency = null, Expression<Func<string>> timeTransactionsdate = null, Expression<Func<int>> timeTransactionsdivision = null, Expression<Func<string>> timeTransactionsdivisionDescription = null, Expression<Func<string>> timeTransactionsemployee = null, Expression<Func<string>> timeTransactionsendTime = null, Expression<Func<int>> timeTransactionsentryNumber = null, Expression<Func<string>> timeTransactionserrorText = null, Expression<Func<double>> timeTransactionshourStatus = null, Expression<Func<string>> timeTransactionsitemDescription = null, Expression<Func<bool>> timeTransactionsitemDivisable = null, Expression<Func<string>> timeTransactionsmodified = null, Expression<Func<string>> timeTransactionsmodifier = null, Expression<Func<string>> timeTransactionsmodifierFullName = null, Expression<Func<string>> timeTransactionsnotes = null, Expression<Func<double>> timeTransactionsprice = null, Expression<Func<double>> timeTransactionspriceFC = null, Expression<Func<string>> timeTransactionsprojectAccount = null, Expression<Func<string>> timeTransactionsprojectAccountCode = null, Expression<Func<string>> timeTransactionsprojectAccountName = null, Expression<Func<string>> timeTransactionsprojectCode = null, Expression<Func<string>> timeTransactionsprojectDescription = null, Expression<Func<bool>> timeTransactionsskipValidation = null, Expression<Func<string>> timeTransactionsstartTime = null, Expression<Func<string>> timeTransactionssubscription = null, Expression<Func<string>> timeTransactionssubscriptionAccount = null, Expression<Func<string>> timeTransactionssubscriptionAccountCode = null, Expression<Func<string>> timeTransactionssubscriptionAccountName = null, Expression<Func<string>> timeTransactionssubscriptionDescription = null, Expression<Func<int>> timeTransactionssubscriptionNumber = null, Expression<Func<double>> timeTransactionstype = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var timeTransactions = new JObject();
            var timeTransactionspropCount = 0;
            if (timeTransactionsiD != null)
            {
                timeTransactions["ID"] = CSharpExpressionConverter.ConvertToken(timeTransactionsiD);
                timeTransactionspropCount++;
            }

            if (timeTransactionsaccount != null)
            {
                timeTransactions["Account"] = CSharpExpressionConverter.ConvertToken(timeTransactionsaccount);
                timeTransactionspropCount++;
            }

            if (timeTransactionsaccountName != null)
            {
                timeTransactions["AccountName"] = CSharpExpressionConverter.ConvertToken(timeTransactionsaccountName);
                timeTransactionspropCount++;
            }

            if (timeTransactionsactivity != null)
            {
                timeTransactions["Activity"] = CSharpExpressionConverter.ConvertToken(timeTransactionsactivity);
                timeTransactionspropCount++;
            }

            if (timeTransactionsactivityDescription != null)
            {
                timeTransactions["ActivityDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionsactivityDescription);
                timeTransactionspropCount++;
            }

            if (timeTransactionsamount != null)
            {
                timeTransactions["Amount"] = CSharpExpressionConverter.ConvertToken(timeTransactionsamount);
                timeTransactionspropCount++;
            }

            if (timeTransactionsamountFC != null)
            {
                timeTransactions["AmountFC"] = CSharpExpressionConverter.ConvertToken(timeTransactionsamountFC);
                timeTransactionspropCount++;
            }

            if (timeTransactionsattachment != null)
            {
                timeTransactions["Attachment"] = CSharpExpressionConverter.ConvertToken(timeTransactionsattachment);
                timeTransactionspropCount++;
            }

            if (timeTransactionscreated != null)
            {
                timeTransactions["Created"] = CSharpExpressionConverter.ConvertToken(timeTransactionscreated);
                timeTransactionspropCount++;
            }

            if (timeTransactionscreator != null)
            {
                timeTransactions["Creator"] = CSharpExpressionConverter.ConvertToken(timeTransactionscreator);
                timeTransactionspropCount++;
            }

            if (timeTransactionscreatorFullName != null)
            {
                timeTransactions["CreatorFullName"] = CSharpExpressionConverter.ConvertToken(timeTransactionscreatorFullName);
                timeTransactionspropCount++;
            }

            if (timeTransactionscurrency != null)
            {
                timeTransactions["Currency"] = CSharpExpressionConverter.ConvertToken(timeTransactionscurrency);
                timeTransactionspropCount++;
            }

            if (timeTransactionsdate != null)
            {
                timeTransactions["Date"] = CSharpExpressionConverter.ConvertToken(timeTransactionsdate);
                timeTransactionspropCount++;
            }

            if (timeTransactionsdivision != null)
            {
                timeTransactions["Division"] = CSharpExpressionConverter.ConvertToken(timeTransactionsdivision);
                timeTransactionspropCount++;
            }

            if (timeTransactionsdivisionDescription != null)
            {
                timeTransactions["DivisionDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionsdivisionDescription);
                timeTransactionspropCount++;
            }

            if (timeTransactionsemployee != null)
            {
                timeTransactions["Employee"] = CSharpExpressionConverter.ConvertToken(timeTransactionsemployee);
                timeTransactionspropCount++;
            }

            if (timeTransactionsendTime != null)
            {
                timeTransactions["EndTime"] = CSharpExpressionConverter.ConvertToken(timeTransactionsendTime);
                timeTransactionspropCount++;
            }

            if (timeTransactionsentryNumber != null)
            {
                timeTransactions["EntryNumber"] = CSharpExpressionConverter.ConvertToken(timeTransactionsentryNumber);
                timeTransactionspropCount++;
            }

            if (timeTransactionserrorText != null)
            {
                timeTransactions["ErrorText"] = CSharpExpressionConverter.ConvertToken(timeTransactionserrorText);
                timeTransactionspropCount++;
            }

            if (timeTransactionshourStatus != null)
            {
                timeTransactions["HourStatus"] = CSharpExpressionConverter.ConvertToken(timeTransactionshourStatus);
                timeTransactionspropCount++;
            }

            timeTransactionspropCount++;
            timeTransactions["Item"] = CSharpExpressionConverter.ConvertToken(timeTransactionsitem);
            if (timeTransactionsitemDescription != null)
            {
                timeTransactions["ItemDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionsitemDescription);
                timeTransactionspropCount++;
            }

            if (timeTransactionsitemDivisable != null)
            {
                timeTransactions["ItemDivisable"] = CSharpExpressionConverter.ConvertToken(timeTransactionsitemDivisable);
                timeTransactionspropCount++;
            }

            if (timeTransactionsmodified != null)
            {
                timeTransactions["Modified"] = CSharpExpressionConverter.ConvertToken(timeTransactionsmodified);
                timeTransactionspropCount++;
            }

            if (timeTransactionsmodifier != null)
            {
                timeTransactions["Modifier"] = CSharpExpressionConverter.ConvertToken(timeTransactionsmodifier);
                timeTransactionspropCount++;
            }

            if (timeTransactionsmodifierFullName != null)
            {
                timeTransactions["ModifierFullName"] = CSharpExpressionConverter.ConvertToken(timeTransactionsmodifierFullName);
                timeTransactionspropCount++;
            }

            if (timeTransactionsnotes != null)
            {
                timeTransactions["Notes"] = CSharpExpressionConverter.ConvertToken(timeTransactionsnotes);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprice != null)
            {
                timeTransactions["Price"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprice);
                timeTransactionspropCount++;
            }

            if (timeTransactionspriceFC != null)
            {
                timeTransactions["PriceFC"] = CSharpExpressionConverter.ConvertToken(timeTransactionspriceFC);
                timeTransactionspropCount++;
            }

            timeTransactionspropCount++;
            timeTransactions["Project"] = CSharpExpressionConverter.ConvertToken(timeTransactionsproject);
            if (timeTransactionsprojectAccount != null)
            {
                timeTransactions["ProjectAccount"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectAccount);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprojectAccountCode != null)
            {
                timeTransactions["ProjectAccountCode"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectAccountCode);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprojectAccountName != null)
            {
                timeTransactions["ProjectAccountName"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectAccountName);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprojectCode != null)
            {
                timeTransactions["ProjectCode"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectCode);
                timeTransactionspropCount++;
            }

            if (timeTransactionsprojectDescription != null)
            {
                timeTransactions["ProjectDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionsprojectDescription);
                timeTransactionspropCount++;
            }

            timeTransactionspropCount++;
            timeTransactions["Quantity"] = CSharpExpressionConverter.ConvertToken(timeTransactionsquantity);
            if (timeTransactionsskipValidation != null)
            {
                timeTransactions["SkipValidation"] = CSharpExpressionConverter.ConvertToken(timeTransactionsskipValidation);
                timeTransactionspropCount++;
            }

            if (timeTransactionsstartTime != null)
            {
                timeTransactions["StartTime"] = CSharpExpressionConverter.ConvertToken(timeTransactionsstartTime);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscription != null)
            {
                timeTransactions["Subscription"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscription);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionAccount != null)
            {
                timeTransactions["SubscriptionAccount"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionAccount);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionAccountCode != null)
            {
                timeTransactions["SubscriptionAccountCode"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionAccountCode);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionAccountName != null)
            {
                timeTransactions["SubscriptionAccountName"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionAccountName);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionDescription != null)
            {
                timeTransactions["SubscriptionDescription"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionDescription);
                timeTransactionspropCount++;
            }

            if (timeTransactionssubscriptionNumber != null)
            {
                timeTransactions["SubscriptionNumber"] = CSharpExpressionConverter.ConvertToken(timeTransactionssubscriptionNumber);
                timeTransactionspropCount++;
            }

            if (timeTransactionstype != null)
            {
                timeTransactions["Type"] = CSharpExpressionConverter.ConvertToken(timeTransactionstype);
                timeTransactionspropCount++;
            }

            if (timeTransactionspropCount > 0)
            {
                callPayload.Body = timeTransactions;
            }

            return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> DeleteTimeTransactions(Expression<Func<string>> division, Expression<Func<string>> iD)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ID"] = CSharpExpressionConverter.ConvertO(iD);
            return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectTimeCostTransactionsResponse> GetProjectTimeCostTransactions(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/sync/Project/TimeCostTransactions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<ProjectTimeCostTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<MeResponse> GetMe(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/current/Me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<MeResponse>(callPayload);
        }
    }

    public class ExactonlinetimebilipTriggers([ConnectionName] string connectionId)
    {
    }

    public class DivisionsResponse
    {
        [JsonProperty("d")]
        public DivisionsArray D { get; set; }
    }

    public class DivisionsArray
    {
        [JsonProperty("results")]
        public Divisions[] Results { get; set; }
    }

    public class Divisions
    {
        public int Code { get; set; }
        public string ArchiveDate { get; set; }
        public int BlockingStatus { get; set; }
        public string Country { get; set; }
        public string CountryDescription { get; set; }
        public string Created { get; set; }
        public string Creator { get; set; }
        public string CreatorFullName { get; set; }
        public string Currency { get; set; }
        public string CurrencyDescription { get; set; }
        public string Customer { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
        public string HID { get; set; }
        public bool Main { get; set; }
        public string Modified { get; set; }
        public string Modifier { get; set; }
        public string ModifierFullName { get; set; }
        public string OBNumber { get; set; }
        public string SiretNumber { get; set; }
        public string StartDate { get; set; }
        public double Status { get; set; }
        public string TaxOfficeNumber { get; set; }
        public string TaxReferenceNumber { get; set; }
        public string TemplateCode { get; set; }
        public string VATNumber { get; set; }
        public string Website { get; set; }
    }

    public class EmploymentInternalRatesResponse
    {
        [JsonProperty("d")]
        public EmploymentInternalRatesArray D { get; set; }
    }

    public class EmploymentInternalRatesArray
    {
        [JsonProperty("results")]
        public EmploymentInternalRates[] Results { get; set; }
    }

    public class EmploymentInternalRates
    {
        public string ID { get; set; }
        public string Created { get; set; }
        public string Creator { get; set; }
        public string CreatorFullName { get; set; }
        public int Division { get; set; }
        public string Employee { get; set; }
        public string EmployeeFullName { get; set; }
        public int EmployeeHID { get; set; }
        public string Employment { get; set; }
        public int EmploymentHID { get; set; }
        public string EndDate { get; set; }
        public double IntercompanyRate { get; set; }
        public double InternalRate { get; set; }
        public string Modified { get; set; }
        public string Modifier { get; set; }
        public string ModifierFullName { get; set; }
        public string StartDate { get; set; }
    }

    public class HourCostTypesResponse
    {
        [JsonProperty("d")]
        public HourCostTypesArray D { get; set; }
    }

    public class HourCostTypesArray
    {
        [JsonProperty("results")]
        public HourCostTypes[] Results { get; set; }
    }

    public class HourCostTypes
    {
        public string ItemId { get; set; }
        public string ItemDescription { get; set; }
    }

    public class HourEntryActivitiesByProjectResponse
    {
        [JsonProperty("d")]
        public HourEntryActivitiesByProjectArray D { get; set; }
    }

    public class HourEntryActivitiesByProjectArray
    {
        [JsonProperty("results")]
        public HourEntryActivitiesByProject[] Results { get; set; }
    }

    public class HourEntryActivitiesByProject
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string ParentDescription { get; set; }
    }

    public class HourEntryRecentAccountsResponse
    {
        [JsonProperty("d")]
        public HourEntryRecentAccountsArray D { get; set; }
    }

    public class HourEntryRecentAccountsArray
    {
        [JsonProperty("results")]
        public HourEntryRecentAccounts[] Results { get; set; }
    }

    public class HourEntryRecentAccounts
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string DateLastUsed { get; set; }
    }

    public class HourEntryRecentAccountsByProjectResponse
    {
        [JsonProperty("d")]
        public HourEntryRecentAccountsByProjectArray D { get; set; }
    }

    public class HourEntryRecentAccountsByProjectArray
    {
        [JsonProperty("results")]
        public HourEntryRecentAccountsByProject[] Results { get; set; }
    }

    public class HourEntryRecentAccountsByProject
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string DateLastUsed { get; set; }
    }

    public class HourEntryRecentHourTypesResponse
    {
        [JsonProperty("d")]
        public HourEntryRecentHourTypesArray D { get; set; }
    }

    public class HourEntryRecentHourTypesArray
    {
        [JsonProperty("results")]
        public HourEntryRecentHourTypes[] Results { get; set; }
    }

    public class HourEntryRecentHourTypes
    {
        public string ItemId { get; set; }
        public string DateLastUsed { get; set; }
        public string ItemDescription { get; set; }
    }

    public class HourEntryRecentHourTypesByProjectResponse
    {
        [JsonProperty("d")]
        public HourEntryRecentHourTypesByProjectArray D { get; set; }
    }

    public class HourEntryRecentHourTypesByProjectArray
    {
        [JsonProperty("results")]
        public HourEntryRecentHourTypesByProject[] Results { get; set; }
    }

    public class HourEntryRecentHourTypesByProject
    {
        public string ItemId { get; set; }
        public string DateLastUsed { get; set; }
        public string ItemDescription { get; set; }
    }

    public class HourEntryRecentProjectsResponse
    {
        [JsonProperty("d")]
        public HourEntryRecentProjectsArray D { get; set; }
    }

    public class HourEntryRecentProjectsArray
    {
        [JsonProperty("results")]
        public HourEntryRecentProjects[] Results { get; set; }
    }

    public class HourEntryRecentProjects
    {
        public string ProjectId { get; set; }
        public string DateLastUsed { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
    }

    public class HoursByDateResponse
    {
        [JsonProperty("d")]
        public HoursByDateArray D { get; set; }
    }

    public class HoursByDateArray
    {
        [JsonProperty("results")]
        public HoursByDate[] Results { get; set; }
    }

    public class HoursByDate
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string Activity { get; set; }
        public string ActivityDescription { get; set; }
        public string Date { get; set; }
        public string EntryId { get; set; }
        public double HoursApproved { get; set; }
        public double HoursApprovedBillable { get; set; }
        public double HoursDraft { get; set; }
        public double HoursDraftBillable { get; set; }
        public double HoursRejected { get; set; }
        public double HoursRejectedBillable { get; set; }
        public double HoursSubmitted { get; set; }
        public double HoursSubmittedBillable { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemId { get; set; }
        public string Notes { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectId { get; set; }
        public int WeekNumber { get; set; }
    }

    public class HoursByIdResponse
    {
        [JsonProperty("d")]
        public HoursByIdArray D { get; set; }
    }

    public class HoursByIdArray
    {
        [JsonProperty("results")]
        public HoursById[] Results { get; set; }
    }

    public class HoursById
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string Activity { get; set; }
        public string ActivityDescription { get; set; }
        public string Date { get; set; }
        public string EntryId { get; set; }
        public double HoursApproved { get; set; }
        public double HoursApprovedBillable { get; set; }
        public double HoursDraft { get; set; }
        public double HoursDraftBillable { get; set; }
        public double HoursRejected { get; set; }
        public double HoursRejectedBillable { get; set; }
        public double HoursSubmitted { get; set; }
        public double HoursSubmittedBillable { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemId { get; set; }
        public string Notes { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectId { get; set; }
        public int WeekNumber { get; set; }
    }

    public class HourTypesResponse
    {
        [JsonProperty("d")]
        public HourTypesArray D { get; set; }
    }

    public class HourTypesArray
    {
        [JsonProperty("results")]
        public HourTypes[] Results { get; set; }
    }

    public class HourTypes
    {
        public string ItemId { get; set; }
        public string ItemDescription { get; set; }
    }

    public class HourTypesByDateResponse
    {
        [JsonProperty("d")]
        public HourTypesByDateArray D { get; set; }
    }

    public class HourTypesByDateArray
    {
        [JsonProperty("results")]
        public HourTypesByDate[] Results { get; set; }
    }

    public class HourTypesByDate
    {
        public string ItemId { get; set; }
        public string ItemDescription { get; set; }
    }

    public class HourTypesByProjectAndDateResponse
    {
        [JsonProperty("d")]
        public HourTypesByProjectAndDateArray D { get; set; }
    }

    public class HourTypesByProjectAndDateArray
    {
        [JsonProperty("results")]
        public HourTypesByProjectAndDate[] Results { get; set; }
    }

    public class HourTypesByProjectAndDate
    {
        public string ItemId { get; set; }
        public string ItemDescription { get; set; }
    }

    public class ProjectRestrictionRebillingsResponse
    {
        [JsonProperty("d")]
        public ProjectRestrictionRebillingsArray D { get; set; }
    }

    public class ProjectRestrictionRebillingsArray
    {
        [JsonProperty("results")]
        public ProjectRestrictionRebillings[] Results { get; set; }
    }

    public class ProjectRestrictionRebillings
    {
        public string ID { get; set; }
        public string CostTypeRebill { get; set; }
        public string CostTypeRebillCode { get; set; }
        public string CostTypeRebillDescription { get; set; }
        public string Created { get; set; }
        public string Creator { get; set; }
        public string CreatorFullName { get; set; }
        public int Division { get; set; }
        public string Modified { get; set; }
        public string Modifier { get; set; }
        public string ModifierFullName { get; set; }
        public string Project { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
    }

    public class RecentCostsByNumberOfWeeksResponse
    {
        [JsonProperty("d")]
        public RecentCostsByNumberOfWeeksArray D { get; set; }
    }

    public class RecentCostsByNumberOfWeeksArray
    {
        [JsonProperty("results")]
        public RecentCostsByNumberOfWeeks[] Results { get; set; }
    }

    public class RecentCostsByNumberOfWeeks
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public double AmountApproved { get; set; }
        public double AmountDraft { get; set; }
        public double AmountRejected { get; set; }
        public double AmountSubmitted { get; set; }
        public string CurrencyCode { get; set; }
        public string Date { get; set; }
        public string EntryId { get; set; }
        public string Expense { get; set; }
        public string ExpenseDescription { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemId { get; set; }
        public string Notes { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectId { get; set; }
        public double QuantityApproved { get; set; }
        public double QuantityDraft { get; set; }
        public double QuantityRejected { get; set; }
        public double QuantitySubmitted { get; set; }
        public int WeekNumber { get; set; }
    }

    public class RecentHoursResponse
    {
        [JsonProperty("d")]
        public RecentHoursArray D { get; set; }
    }

    public class RecentHoursArray
    {
        [JsonProperty("results")]
        public RecentHours[] Results { get; set; }
    }

    public class RecentHours
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string Activity { get; set; }
        public string ActivityDescription { get; set; }
        public string Date { get; set; }
        public string EntryId { get; set; }
        public double HoursApproved { get; set; }
        public double HoursApprovedBillable { get; set; }
        public double HoursDraft { get; set; }
        public double HoursDraftBillable { get; set; }
        public double HoursRejected { get; set; }
        public double HoursRejectedBillable { get; set; }
        public double HoursSubmitted { get; set; }
        public double HoursSubmittedBillable { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemId { get; set; }
        public string Notes { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectId { get; set; }
        public int WeekNumber { get; set; }
    }

    public class RecentHoursByNumberOfWeeksResponse
    {
        [JsonProperty("d")]
        public RecentHoursByNumberOfWeeksArray D { get; set; }
    }

    public class RecentHoursByNumberOfWeeksArray
    {
        [JsonProperty("results")]
        public RecentHoursByNumberOfWeeks[] Results { get; set; }
    }

    public class RecentHoursByNumberOfWeeks
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string Activity { get; set; }
        public string ActivityDescription { get; set; }
        public string Date { get; set; }
        public string EntryId { get; set; }
        public double HoursApproved { get; set; }
        public double HoursApprovedBillable { get; set; }
        public double HoursDraft { get; set; }
        public double HoursDraftBillable { get; set; }
        public double HoursRejected { get; set; }
        public double HoursRejectedBillable { get; set; }
        public double HoursSubmitted { get; set; }
        public double HoursSubmittedBillable { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemId { get; set; }
        public string Notes { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectId { get; set; }
        public int WeekNumber { get; set; }
    }

    public class TimeAndBillingAccountDetailsResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingAccountDetailsArray D { get; set; }
    }

    public class TimeAndBillingAccountDetailsArray
    {
        [JsonProperty("results")]
        public TimeAndBillingAccountDetails[] Results { get; set; }
    }

    public class TimeAndBillingAccountDetails
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class TimeAndBillingAccountDetailsByIDResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingAccountDetailsByIDArray D { get; set; }
    }

    public class TimeAndBillingAccountDetailsByIDArray
    {
        [JsonProperty("results")]
        public TimeAndBillingAccountDetailsByID[] Results { get; set; }
    }

    public class TimeAndBillingAccountDetailsByID
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class TimeAndBillingActivitiesAndExpensesResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingActivitiesAndExpensesArray D { get; set; }
    }

    public class TimeAndBillingActivitiesAndExpensesArray
    {
        [JsonProperty("results")]
        public TimeAndBillingActivitiesAndExpenses[] Results { get; set; }
    }

    public class TimeAndBillingActivitiesAndExpenses
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string ParentDescription { get; set; }
    }

    public class TimeAndBillingEntryAccountsResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryAccountsArray D { get; set; }
    }

    public class TimeAndBillingEntryAccountsArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryAccounts[] Results { get; set; }
    }

    public class TimeAndBillingEntryAccounts
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
    }

    public class TimeAndBillingEntryAccountsByDateResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryAccountsByDateArray D { get; set; }
    }

    public class TimeAndBillingEntryAccountsByDateArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryAccountsByDate[] Results { get; set; }
    }

    public class TimeAndBillingEntryAccountsByDate
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
    }

    public class TimeAndBillingEntryAccountsByProjectAndDateResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryAccountsByProjectAndDateArray D { get; set; }
    }

    public class TimeAndBillingEntryAccountsByProjectAndDateArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryAccountsByProjectAndDate[] Results { get; set; }
    }

    public class TimeAndBillingEntryAccountsByProjectAndDate
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
    }

    public class TimeAndBillingEntryProjectsResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryProjectsArray D { get; set; }
    }

    public class TimeAndBillingEntryProjectsArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryProjects[] Results { get; set; }
    }

    public class TimeAndBillingEntryProjects
    {
        public string ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
    }

    public class TimeAndBillingEntryProjectsByAccountAndDateResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryProjectsByAccountAndDateArray D { get; set; }
    }

    public class TimeAndBillingEntryProjectsByAccountAndDateArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryProjectsByAccountAndDate[] Results { get; set; }
    }

    public class TimeAndBillingEntryProjectsByAccountAndDate
    {
        public string ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
    }

    public class TimeAndBillingEntryProjectsByDateResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryProjectsByDateArray D { get; set; }
    }

    public class TimeAndBillingEntryProjectsByDateArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryProjectsByDate[] Results { get; set; }
    }

    public class TimeAndBillingEntryProjectsByDate
    {
        public string ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
    }

    public class TimeAndBillingEntryRecentAccountsResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryRecentAccountsArray D { get; set; }
    }

    public class TimeAndBillingEntryRecentAccountsArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryRecentAccounts[] Results { get; set; }
    }

    public class TimeAndBillingEntryRecentAccounts
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string DateLastUsed { get; set; }
    }

    public class TimeAndBillingEntryRecentActivitiesAndExpensesResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryRecentActivitiesAndExpensesArray D { get; set; }
    }

    public class TimeAndBillingEntryRecentActivitiesAndExpensesArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryRecentActivitiesAndExpenses[] Results { get; set; }
    }

    public class TimeAndBillingEntryRecentActivitiesAndExpenses
    {
        public string ID { get; set; }
        public string DateLastUsed { get; set; }
        public string Description { get; set; }
        public string ParentDescription { get; set; }
    }

    public class TimeAndBillingEntryRecentHourCostTypesResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryRecentHourCostTypesArray D { get; set; }
    }

    public class TimeAndBillingEntryRecentHourCostTypesArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryRecentHourCostTypes[] Results { get; set; }
    }

    public class TimeAndBillingEntryRecentHourCostTypes
    {
        public string ItemId { get; set; }
        public string DateLastUsed { get; set; }
        public string ItemDescription { get; set; }
    }

    public class TimeAndBillingEntryRecentProjectsResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingEntryRecentProjectsArray D { get; set; }
    }

    public class TimeAndBillingEntryRecentProjectsArray
    {
        [JsonProperty("results")]
        public TimeAndBillingEntryRecentProjects[] Results { get; set; }
    }

    public class TimeAndBillingEntryRecentProjects
    {
        public string ProjectId { get; set; }
        public string DateLastUsed { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
    }

    public class TimeAndBillingItemDetailsResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingItemDetailsArray D { get; set; }
    }

    public class TimeAndBillingItemDetailsArray
    {
        [JsonProperty("results")]
        public TimeAndBillingItemDetails[] Results { get; set; }
    }

    public class TimeAndBillingItemDetails
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsFractionAllowedItem { get; set; }
        public bool IsSalesItem { get; set; }
        public string SalesCurrency { get; set; }
        public double SalesPrice { get; set; }
    }

    public class TimeAndBillingItemDetailsByIDResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingItemDetailsByIDArray D { get; set; }
    }

    public class TimeAndBillingItemDetailsByIDArray
    {
        [JsonProperty("results")]
        public TimeAndBillingItemDetailsByID[] Results { get; set; }
    }

    public class TimeAndBillingItemDetailsByID
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsFractionAllowedItem { get; set; }
        public bool IsSalesItem { get; set; }
        public string SalesCurrency { get; set; }
        public double SalesPrice { get; set; }
    }

    public class TimeAndBillingProjectDetailsResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingProjectDetailsArray D { get; set; }
    }

    public class TimeAndBillingProjectDetailsArray
    {
        [JsonProperty("results")]
        public TimeAndBillingProjectDetails[] Results { get; set; }
    }

    public class TimeAndBillingProjectDetails
    {
        public string ID { get; set; }
        public string Account { get; set; }
        public string AccountName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
    }

    public class TimeAndBillingProjectDetailsByIDResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingProjectDetailsByIDArray D { get; set; }
    }

    public class TimeAndBillingProjectDetailsByIDArray
    {
        [JsonProperty("results")]
        public TimeAndBillingProjectDetailsByID[] Results { get; set; }
    }

    public class TimeAndBillingProjectDetailsByID
    {
        public string ID { get; set; }
        public string Account { get; set; }
        public string AccountName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
    }

    public class TimeAndBillingRecentProjectsResponse
    {
        [JsonProperty("d")]
        public TimeAndBillingRecentProjectsArray D { get; set; }
    }

    public class TimeAndBillingRecentProjectsArray
    {
        [JsonProperty("results")]
        public TimeAndBillingRecentProjects[] Results { get; set; }
    }

    public class TimeAndBillingRecentProjects
    {
        public string ProjectId { get; set; }
        public string DateLastUsed { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
    }

    public class TimeCorrectionsResponse
    {
        [JsonProperty("d")]
        public TimeCorrectionsArray D { get; set; }
    }

    public class TimeCorrectionsArray
    {
        [JsonProperty("results")]
        public TimeCorrections[] Results { get; set; }
    }

    public class TimeCorrections
    {
        public string ID { get; set; }
        public string Created { get; set; }
        public string Creator { get; set; }
        public string CreatorFullName { get; set; }
        public int Division { get; set; }
        public string Modified { get; set; }
        public string Modifier { get; set; }
        public string ModifierFullName { get; set; }
        public string Notes { get; set; }
        public string OriginalEntryId { get; set; }
        public double Quantity { get; set; }
    }

    public class TimeTransactionsResponse
    {
        [JsonProperty("d")]
        public TimeTransactionsArray D { get; set; }
    }

    public class TimeTransactionsArray
    {
        [JsonProperty("results")]
        public TimeTransactions[] Results { get; set; }
    }

    public class TimeTransactions
    {
        public string ID { get; set; }
        public string Account { get; set; }
        public string AccountName { get; set; }
        public string Activity { get; set; }
        public string ActivityDescription { get; set; }
        public double Amount { get; set; }
        public double AmountFC { get; set; }
        public string Attachment { get; set; }
        public string Created { get; set; }
        public string Creator { get; set; }
        public string CreatorFullName { get; set; }
        public string Currency { get; set; }
        public string Date { get; set; }
        public int Division { get; set; }
        public string DivisionDescription { get; set; }
        public string Employee { get; set; }
        public string EndTime { get; set; }
        public int EntryNumber { get; set; }
        public string ErrorText { get; set; }
        public double HourStatus { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public bool ItemDivisable { get; set; }
        public string Modified { get; set; }
        public string Modifier { get; set; }
        public string ModifierFullName { get; set; }
        public string Notes { get; set; }
        public double Price { get; set; }
        public double PriceFC { get; set; }
        public string Project { get; set; }
        public string ProjectAccount { get; set; }
        public string ProjectAccountCode { get; set; }
        public string ProjectAccountName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        public double Quantity { get; set; }
        public bool SkipValidation { get; set; }
        public string StartTime { get; set; }
        public string Subscription { get; set; }
        public string SubscriptionAccount { get; set; }
        public string SubscriptionAccountCode { get; set; }
        public string SubscriptionAccountName { get; set; }
        public string SubscriptionDescription { get; set; }
        public int SubscriptionNumber { get; set; }
        public double Type { get; set; }
    }

    public class ProjectTimeCostTransactionsResponse
    {
        [JsonProperty("d")]
        public ProjectTimeCostTransactionsArray D { get; set; }
    }

    public class ProjectTimeCostTransactionsArray
    {
        [JsonProperty("results")]
        public ProjectTimeCostTransactions[] Results { get; set; }
    }

    public class ProjectTimeCostTransactions
    {
        public int Timestamp { get; set; }
        public string Account { get; set; }
        public string AccountName { get; set; }
        public double AmountFC { get; set; }
        public string Attachment { get; set; }
        public string Created { get; set; }
        public string Creator { get; set; }
        public string CreatorFullName { get; set; }
        public string Currency { get; set; }
        public string Date { get; set; }
        public int Division { get; set; }
        public string DivisionDescription { get; set; }
        public string Employee { get; set; }
        public string EndTime { get; set; }
        public int EntryNumber { get; set; }
        public string ErrorText { get; set; }
        public double HourStatus { get; set; }
        public string ID { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public bool ItemDivisable { get; set; }
        public string Modified { get; set; }
        public string Modifier { get; set; }
        public string ModifierFullName { get; set; }
        public string Notes { get; set; }
        public double PriceFC { get; set; }
        public string Project { get; set; }
        public string ProjectAccount { get; set; }
        public string ProjectAccountCode { get; set; }
        public string ProjectAccountName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        public double Quantity { get; set; }
        public string StartTime { get; set; }
        public string Subscription { get; set; }
        public string SubscriptionAccount { get; set; }
        public string SubscriptionAccountCode { get; set; }
        public string SubscriptionAccountName { get; set; }
        public string SubscriptionDescription { get; set; }
        public int SubscriptionNumber { get; set; }
        public double Type { get; set; }
        public string WBS { get; set; }
        public string WBSDescription { get; set; }
    }

    public class MeResponse
    {
        [JsonProperty("d")]
        public MeArray D { get; set; }
    }

    public class MeArray
    {
        [JsonProperty("results")]
        public Me[] Results { get; set; }
    }

    public class Me
    {
        public string UserID { get; set; }
        public int AccountingDivision { get; set; }
        public int CurrentDivision { get; set; }
        public string CustomerCode { get; set; }
        public string DivisionCustomer { get; set; }
        public string DivisionCustomerCode { get; set; }
        public string DivisionCustomerName { get; set; }
        public string DivisionCustomerSiretNumber { get; set; }
        public string DivisionCustomerVatNumber { get; set; }
        public int DossierDivision { get; set; }
        public string Email { get; set; }
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Initials { get; set; }
        public bool IsClientUser { get; set; }
        public bool IsMyFirmPortalUser { get; set; }
        public string Language { get; set; }
        public string LanguageCode { get; set; }
        public string LastName { get; set; }
        public string Legislation { get; set; }
        public string MiddleName { get; set; }
        public string Mobile { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string PhoneExtension { get; set; }
        public string PictureUrl { get; set; }
        public string ServerTime { get; set; }
        public double ServerUtcOffset { get; set; }
        public string ThumbnailPicture { get; set; }
        public string ThumbnailPictureFormat { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Exactonlinetimebilip;

    public partial class WorkflowManagedActions
    {
        public ExactonlinetimebilipActions Exactonlinetimebilip(string connectionId) => new ExactonlinetimebilipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExactonlinetimebilipTriggers Exactonlinetimebilip(string connectionId) => new ExactonlinetimebilipTriggers(connectionId);
    }
}