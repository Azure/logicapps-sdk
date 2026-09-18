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
        public IBodyWorkflowAction<DivisionsResponse> GetDivisions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/hrm/Divisions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<DivisionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<EmploymentInternalRatesResponse> GetEmploymentInternalRates([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/EmploymentInternalRates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<EmploymentInternalRatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourCostTypesResponse> GetHourCostTypes([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourCostTypes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<HourCostTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryActivitiesByProjectResponse> GetHourEntryActivitiesByProject([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryActivitiesByProject", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<HourEntryActivitiesByProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentAccountsResponse> GetHourEntryRecentAccounts([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentAccounts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<HourEntryRecentAccountsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentAccountsByProjectResponse> GetHourEntryRecentAccountsByProject([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentAccountsByProject", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<HourEntryRecentAccountsByProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentHourTypesResponse> GetHourEntryRecentHourTypes([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentHourTypes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<HourEntryRecentHourTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentHourTypesByProjectResponse> GetHourEntryRecentHourTypesByProject([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentHourTypesByProject", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<HourEntryRecentHourTypesByProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentProjectsResponse> GetHourEntryRecentProjects([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentProjects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<HourEntryRecentProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HoursByDateResponse> GetHoursByDate([WorkflowExpression] Func<string> checkDate, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(checkDate, nameof(checkDate), required: true);
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HoursByDate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["checkDate"] = SourceExpressionConverter.ConvertO(checkDate);
                return callPayload;
            }

            return new ApiConnectionAction<HoursByDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HoursByIdResponse> GetHoursById([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> entryId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(entryId, nameof(entryId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HoursById", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["entryId"] = SourceExpressionConverter.ConvertO(entryId);
                return callPayload;
            }

            return new ApiConnectionAction<HoursByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesResponse> GetHourTypes([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<HourTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesByDateResponse> GetHourTypesByDate([WorkflowExpression] Func<string> checkDate, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(checkDate, nameof(checkDate), required: true);
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypesByDate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["checkDate"] = SourceExpressionConverter.ConvertO(checkDate);
                return callPayload;
            }

            return new ApiConnectionAction<HourTypesByDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesByProjectAndDateResponse> GetHourTypesByProjectAndDate([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypesByProjectAndDate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<HourTypesByProjectAndDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> GetProjectRestrictionRebillings([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> PutProjectRestrictionRebillings([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebill, [WorkflowExpression] Func<string> projectRestrictionRebillingsproject, [WorkflowExpression] Func<string> projectRestrictionRebillingsiD = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebillCode = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebillDescription = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreated = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreator = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreatorFullName = null, [WorkflowExpression] Func<int> projectRestrictionRebillingsdivision = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodified = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodifier = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodifierFullName = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsprojectCode = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsprojectDescription = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(iD, nameof(iD), required: true);
            SourceExpression.Validate(projectRestrictionRebillingscostTypeRebill, nameof(projectRestrictionRebillingscostTypeRebill), required: true);
            SourceExpression.Validate(projectRestrictionRebillingsproject, nameof(projectRestrictionRebillingsproject), required: true);
            SourceExpression.Validate(projectRestrictionRebillingsiD, nameof(projectRestrictionRebillingsiD), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscostTypeRebillCode, nameof(projectRestrictionRebillingscostTypeRebillCode), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscostTypeRebillDescription, nameof(projectRestrictionRebillingscostTypeRebillDescription), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscreated, nameof(projectRestrictionRebillingscreated), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscreator, nameof(projectRestrictionRebillingscreator), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscreatorFullName, nameof(projectRestrictionRebillingscreatorFullName), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsdivision, nameof(projectRestrictionRebillingsdivision), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsmodified, nameof(projectRestrictionRebillingsmodified), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsmodifier, nameof(projectRestrictionRebillingsmodifier), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsmodifierFullName, nameof(projectRestrictionRebillingsmodifierFullName), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsprojectCode, nameof(projectRestrictionRebillingsprojectCode), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsprojectDescription, nameof(projectRestrictionRebillingsprojectDescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = SourceExpressionConverter.ConvertO(iD);
                var projectRestrictionRebillings = new JObject();
                var projectRestrictionRebillingspropCount = 0;
                if (projectRestrictionRebillingsiD != null)
                {
                    projectRestrictionRebillings["ID"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsiD);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["CostTypeRebill"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebill);
                if (projectRestrictionRebillingscostTypeRebillCode != null)
                {
                    projectRestrictionRebillings["CostTypeRebillCode"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebillCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscostTypeRebillDescription != null)
                {
                    projectRestrictionRebillings["CostTypeRebillDescription"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebillDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreated != null)
                {
                    projectRestrictionRebillings["Created"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscreated);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreator != null)
                {
                    projectRestrictionRebillings["Creator"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscreator);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreatorFullName != null)
                {
                    projectRestrictionRebillings["CreatorFullName"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscreatorFullName);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsdivision != null)
                {
                    projectRestrictionRebillings["Division"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsdivision);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodified != null)
                {
                    projectRestrictionRebillings["Modified"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsmodified);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodifier != null)
                {
                    projectRestrictionRebillings["Modifier"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsmodifier);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodifierFullName != null)
                {
                    projectRestrictionRebillings["ModifierFullName"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsmodifierFullName);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["Project"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsproject);
                if (projectRestrictionRebillingsprojectCode != null)
                {
                    projectRestrictionRebillings["ProjectCode"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsprojectCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsprojectDescription != null)
                {
                    projectRestrictionRebillings["ProjectDescription"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsprojectDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingspropCount > 0)
                {
                    callPayload.Body = projectRestrictionRebillings;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> PostProjectRestrictionRebillings([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebill, [WorkflowExpression] Func<string> projectRestrictionRebillingsproject, [WorkflowExpression] Func<string> projectRestrictionRebillingsiD = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebillCode = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebillDescription = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreated = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreator = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreatorFullName = null, [WorkflowExpression] Func<int> projectRestrictionRebillingsdivision = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodified = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodifier = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodifierFullName = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsprojectCode = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsprojectDescription = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(projectRestrictionRebillingscostTypeRebill, nameof(projectRestrictionRebillingscostTypeRebill), required: true);
            SourceExpression.Validate(projectRestrictionRebillingsproject, nameof(projectRestrictionRebillingsproject), required: true);
            SourceExpression.Validate(projectRestrictionRebillingsiD, nameof(projectRestrictionRebillingsiD), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscostTypeRebillCode, nameof(projectRestrictionRebillingscostTypeRebillCode), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscostTypeRebillDescription, nameof(projectRestrictionRebillingscostTypeRebillDescription), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscreated, nameof(projectRestrictionRebillingscreated), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscreator, nameof(projectRestrictionRebillingscreator), required: false);
            SourceExpression.Validate(projectRestrictionRebillingscreatorFullName, nameof(projectRestrictionRebillingscreatorFullName), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsdivision, nameof(projectRestrictionRebillingsdivision), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsmodified, nameof(projectRestrictionRebillingsmodified), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsmodifier, nameof(projectRestrictionRebillingsmodifier), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsmodifierFullName, nameof(projectRestrictionRebillingsmodifierFullName), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsprojectCode, nameof(projectRestrictionRebillingsprojectCode), required: false);
            SourceExpression.Validate(projectRestrictionRebillingsprojectDescription, nameof(projectRestrictionRebillingsprojectDescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var projectRestrictionRebillings = new JObject();
                var projectRestrictionRebillingspropCount = 0;
                if (projectRestrictionRebillingsiD != null)
                {
                    projectRestrictionRebillings["ID"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsiD);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["CostTypeRebill"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebill);
                if (projectRestrictionRebillingscostTypeRebillCode != null)
                {
                    projectRestrictionRebillings["CostTypeRebillCode"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebillCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscostTypeRebillDescription != null)
                {
                    projectRestrictionRebillings["CostTypeRebillDescription"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscostTypeRebillDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreated != null)
                {
                    projectRestrictionRebillings["Created"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscreated);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreator != null)
                {
                    projectRestrictionRebillings["Creator"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscreator);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreatorFullName != null)
                {
                    projectRestrictionRebillings["CreatorFullName"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingscreatorFullName);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsdivision != null)
                {
                    projectRestrictionRebillings["Division"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsdivision);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodified != null)
                {
                    projectRestrictionRebillings["Modified"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsmodified);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodifier != null)
                {
                    projectRestrictionRebillings["Modifier"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsmodifier);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodifierFullName != null)
                {
                    projectRestrictionRebillings["ModifierFullName"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsmodifierFullName);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["Project"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsproject);
                if (projectRestrictionRebillingsprojectCode != null)
                {
                    projectRestrictionRebillings["ProjectCode"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsprojectCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsprojectDescription != null)
                {
                    projectRestrictionRebillings["ProjectDescription"] = SourceExpressionConverter.ConvertToken(projectRestrictionRebillingsprojectDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingspropCount > 0)
                {
                    callPayload.Body = projectRestrictionRebillings;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> DeleteProjectRestrictionRebillings([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(iD, nameof(iD), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = SourceExpressionConverter.ConvertO(iD);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentCostsByNumberOfWeeksResponse> GetRecentCostsByNumberOfWeeks([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<int> numberOfWeeks, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(numberOfWeeks, nameof(numberOfWeeks), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentCostsByNumberOfWeeks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["numberOfWeeks"] = SourceExpressionConverter.ConvertO(numberOfWeeks);
                return callPayload;
            }

            return new ApiConnectionAction<RecentCostsByNumberOfWeeksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentHoursResponse> GetRecentHours([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentHours", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<RecentHoursResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentHoursByNumberOfWeeksResponse> GetRecentHoursByNumberOfWeeks([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<int> numberOfWeeks, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(numberOfWeeks, nameof(numberOfWeeks), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentHoursByNumberOfWeeks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["numberOfWeeks"] = SourceExpressionConverter.ConvertO(numberOfWeeks);
                return callPayload;
            }

            return new ApiConnectionAction<RecentHoursByNumberOfWeeksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsResponse> GetTimeAndBillingAccountDetails([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingAccountDetails", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingAccountDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsByIDResponse> GetTimeAndBillingAccountDetailsByID([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingAccountDetailsByID", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["accountId"] = SourceExpressionConverter.ConvertO(accountId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingAccountDetailsByIDResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingActivitiesAndExpensesResponse> GetTimeAndBillingActivitiesAndExpenses([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingActivitiesAndExpenses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingActivitiesAndExpensesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsResponse> GetTimeAndBillingEntryAccounts([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccounts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryAccountsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByDateResponse> GetTimeAndBillingEntryAccountsByDate([WorkflowExpression] Func<string> checkDate, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(checkDate, nameof(checkDate), required: true);
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccountsByDate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["checkDate"] = SourceExpressionConverter.ConvertO(checkDate);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryAccountsByDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByProjectAndDateResponse> GetTimeAndBillingEntryAccountsByProjectAndDate([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccountsByProjectAndDate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryAccountsByProjectAndDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsResponse> GetTimeAndBillingEntryProjects([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByAccountAndDateResponse> GetTimeAndBillingEntryProjectsByAccountAndDate([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjectsByAccountAndDate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["accountId"] = SourceExpressionConverter.ConvertO(accountId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryProjectsByAccountAndDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByDateResponse> GetTimeAndBillingEntryProjectsByDate([WorkflowExpression] Func<string> checkDate, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(checkDate, nameof(checkDate), required: true);
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjectsByDate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["checkDate"] = SourceExpressionConverter.ConvertO(checkDate);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryProjectsByDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentAccountsResponse> GetTimeAndBillingEntryRecentAccounts([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentAccounts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryRecentAccountsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse> GetTimeAndBillingEntryRecentActivitiesAndExpenses([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentActivitiesAndExpenses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentHourCostTypesResponse> GetTimeAndBillingEntryRecentHourCostTypes([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentHourCostTypes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryRecentHourCostTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentProjectsResponse> GetTimeAndBillingEntryRecentProjects([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentProjects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingEntryRecentProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsResponse> GetTimeAndBillingItemDetails([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingItemDetails", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingItemDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsByIDResponse> GetTimeAndBillingItemDetailsByID([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingItemDetailsByID", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["itemId"] = SourceExpressionConverter.ConvertO(itemId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingItemDetailsByIDResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsResponse> GetTimeAndBillingProjectDetails([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingProjectDetails", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingProjectDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsByIDResponse> GetTimeAndBillingProjectDetailsByID([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingProjectDetailsByID", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingProjectDetailsByIDResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingRecentProjectsResponse> GetTimeAndBillingRecentProjects([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingRecentProjects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeAndBillingRecentProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> GetTimeCorrections([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeCorrectionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> PutTimeCorrections([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD, [WorkflowExpression] Func<string> timeCorrectionsiD = null, [WorkflowExpression] Func<string> timeCorrectionscreated = null, [WorkflowExpression] Func<string> timeCorrectionscreator = null, [WorkflowExpression] Func<string> timeCorrectionscreatorFullName = null, [WorkflowExpression] Func<int> timeCorrectionsdivision = null, [WorkflowExpression] Func<string> timeCorrectionsmodified = null, [WorkflowExpression] Func<string> timeCorrectionsmodifier = null, [WorkflowExpression] Func<string> timeCorrectionsmodifierFullName = null, [WorkflowExpression] Func<string> timeCorrectionsnotes = null, [WorkflowExpression] Func<string> timeCorrectionsoriginalEntryId = null, [WorkflowExpression] Func<double> timeCorrectionsquantity = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(iD, nameof(iD), required: true);
            SourceExpression.Validate(timeCorrectionsiD, nameof(timeCorrectionsiD), required: false);
            SourceExpression.Validate(timeCorrectionscreated, nameof(timeCorrectionscreated), required: false);
            SourceExpression.Validate(timeCorrectionscreator, nameof(timeCorrectionscreator), required: false);
            SourceExpression.Validate(timeCorrectionscreatorFullName, nameof(timeCorrectionscreatorFullName), required: false);
            SourceExpression.Validate(timeCorrectionsdivision, nameof(timeCorrectionsdivision), required: false);
            SourceExpression.Validate(timeCorrectionsmodified, nameof(timeCorrectionsmodified), required: false);
            SourceExpression.Validate(timeCorrectionsmodifier, nameof(timeCorrectionsmodifier), required: false);
            SourceExpression.Validate(timeCorrectionsmodifierFullName, nameof(timeCorrectionsmodifierFullName), required: false);
            SourceExpression.Validate(timeCorrectionsnotes, nameof(timeCorrectionsnotes), required: false);
            SourceExpression.Validate(timeCorrectionsoriginalEntryId, nameof(timeCorrectionsoriginalEntryId), required: false);
            SourceExpression.Validate(timeCorrectionsquantity, nameof(timeCorrectionsquantity), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = SourceExpressionConverter.ConvertO(iD);
                var timeCorrections = new JObject();
                var timeCorrectionspropCount = 0;
                if (timeCorrectionsiD != null)
                {
                    timeCorrections["ID"] = SourceExpressionConverter.ConvertToken(timeCorrectionsiD);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreated != null)
                {
                    timeCorrections["Created"] = SourceExpressionConverter.ConvertToken(timeCorrectionscreated);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreator != null)
                {
                    timeCorrections["Creator"] = SourceExpressionConverter.ConvertToken(timeCorrectionscreator);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreatorFullName != null)
                {
                    timeCorrections["CreatorFullName"] = SourceExpressionConverter.ConvertToken(timeCorrectionscreatorFullName);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsdivision != null)
                {
                    timeCorrections["Division"] = SourceExpressionConverter.ConvertToken(timeCorrectionsdivision);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodified != null)
                {
                    timeCorrections["Modified"] = SourceExpressionConverter.ConvertToken(timeCorrectionsmodified);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodifier != null)
                {
                    timeCorrections["Modifier"] = SourceExpressionConverter.ConvertToken(timeCorrectionsmodifier);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodifierFullName != null)
                {
                    timeCorrections["ModifierFullName"] = SourceExpressionConverter.ConvertToken(timeCorrectionsmodifierFullName);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsnotes != null)
                {
                    timeCorrections["Notes"] = SourceExpressionConverter.ConvertToken(timeCorrectionsnotes);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsoriginalEntryId != null)
                {
                    timeCorrections["OriginalEntryId"] = SourceExpressionConverter.ConvertToken(timeCorrectionsoriginalEntryId);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsquantity != null)
                {
                    timeCorrections["Quantity"] = SourceExpressionConverter.ConvertToken(timeCorrectionsquantity);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionspropCount > 0)
                {
                    callPayload.Body = timeCorrections;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeCorrectionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> PostTimeCorrections([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> timeCorrectionsiD = null, [WorkflowExpression] Func<string> timeCorrectionscreated = null, [WorkflowExpression] Func<string> timeCorrectionscreator = null, [WorkflowExpression] Func<string> timeCorrectionscreatorFullName = null, [WorkflowExpression] Func<int> timeCorrectionsdivision = null, [WorkflowExpression] Func<string> timeCorrectionsmodified = null, [WorkflowExpression] Func<string> timeCorrectionsmodifier = null, [WorkflowExpression] Func<string> timeCorrectionsmodifierFullName = null, [WorkflowExpression] Func<string> timeCorrectionsnotes = null, [WorkflowExpression] Func<string> timeCorrectionsoriginalEntryId = null, [WorkflowExpression] Func<double> timeCorrectionsquantity = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(timeCorrectionsiD, nameof(timeCorrectionsiD), required: false);
            SourceExpression.Validate(timeCorrectionscreated, nameof(timeCorrectionscreated), required: false);
            SourceExpression.Validate(timeCorrectionscreator, nameof(timeCorrectionscreator), required: false);
            SourceExpression.Validate(timeCorrectionscreatorFullName, nameof(timeCorrectionscreatorFullName), required: false);
            SourceExpression.Validate(timeCorrectionsdivision, nameof(timeCorrectionsdivision), required: false);
            SourceExpression.Validate(timeCorrectionsmodified, nameof(timeCorrectionsmodified), required: false);
            SourceExpression.Validate(timeCorrectionsmodifier, nameof(timeCorrectionsmodifier), required: false);
            SourceExpression.Validate(timeCorrectionsmodifierFullName, nameof(timeCorrectionsmodifierFullName), required: false);
            SourceExpression.Validate(timeCorrectionsnotes, nameof(timeCorrectionsnotes), required: false);
            SourceExpression.Validate(timeCorrectionsoriginalEntryId, nameof(timeCorrectionsoriginalEntryId), required: false);
            SourceExpression.Validate(timeCorrectionsquantity, nameof(timeCorrectionsquantity), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var timeCorrections = new JObject();
                var timeCorrectionspropCount = 0;
                if (timeCorrectionsiD != null)
                {
                    timeCorrections["ID"] = SourceExpressionConverter.ConvertToken(timeCorrectionsiD);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreated != null)
                {
                    timeCorrections["Created"] = SourceExpressionConverter.ConvertToken(timeCorrectionscreated);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreator != null)
                {
                    timeCorrections["Creator"] = SourceExpressionConverter.ConvertToken(timeCorrectionscreator);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreatorFullName != null)
                {
                    timeCorrections["CreatorFullName"] = SourceExpressionConverter.ConvertToken(timeCorrectionscreatorFullName);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsdivision != null)
                {
                    timeCorrections["Division"] = SourceExpressionConverter.ConvertToken(timeCorrectionsdivision);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodified != null)
                {
                    timeCorrections["Modified"] = SourceExpressionConverter.ConvertToken(timeCorrectionsmodified);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodifier != null)
                {
                    timeCorrections["Modifier"] = SourceExpressionConverter.ConvertToken(timeCorrectionsmodifier);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodifierFullName != null)
                {
                    timeCorrections["ModifierFullName"] = SourceExpressionConverter.ConvertToken(timeCorrectionsmodifierFullName);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsnotes != null)
                {
                    timeCorrections["Notes"] = SourceExpressionConverter.ConvertToken(timeCorrectionsnotes);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsoriginalEntryId != null)
                {
                    timeCorrections["OriginalEntryId"] = SourceExpressionConverter.ConvertToken(timeCorrectionsoriginalEntryId);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsquantity != null)
                {
                    timeCorrections["Quantity"] = SourceExpressionConverter.ConvertToken(timeCorrectionsquantity);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionspropCount > 0)
                {
                    callPayload.Body = timeCorrections;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeCorrectionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> DeleteTimeCorrections([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(iD, nameof(iD), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = SourceExpressionConverter.ConvertO(iD);
                return callPayload;
            }

            return new ApiConnectionAction<TimeCorrectionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> GetTimeTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<TimeTransactionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> PutTimeTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD, [WorkflowExpression] Func<string> timeTransactionsitem, [WorkflowExpression] Func<string> timeTransactionsproject, [WorkflowExpression] Func<double> timeTransactionsquantity, [WorkflowExpression] Func<string> timeTransactionsiD = null, [WorkflowExpression] Func<string> timeTransactionsaccount = null, [WorkflowExpression] Func<string> timeTransactionsaccountName = null, [WorkflowExpression] Func<string> timeTransactionsactivity = null, [WorkflowExpression] Func<string> timeTransactionsactivityDescription = null, [WorkflowExpression] Func<double> timeTransactionsamount = null, [WorkflowExpression] Func<double> timeTransactionsamountFC = null, [WorkflowExpression] Func<string> timeTransactionsattachment = null, [WorkflowExpression] Func<string> timeTransactionscreated = null, [WorkflowExpression] Func<string> timeTransactionscreator = null, [WorkflowExpression] Func<string> timeTransactionscreatorFullName = null, [WorkflowExpression] Func<string> timeTransactionscurrency = null, [WorkflowExpression] Func<string> timeTransactionsdate = null, [WorkflowExpression] Func<int> timeTransactionsdivision = null, [WorkflowExpression] Func<string> timeTransactionsdivisionDescription = null, [WorkflowExpression] Func<string> timeTransactionsemployee = null, [WorkflowExpression] Func<string> timeTransactionsendTime = null, [WorkflowExpression] Func<int> timeTransactionsentryNumber = null, [WorkflowExpression] Func<string> timeTransactionserrorText = null, [WorkflowExpression] Func<double> timeTransactionshourStatus = null, [WorkflowExpression] Func<string> timeTransactionsitemDescription = null, [WorkflowExpression] Func<bool> timeTransactionsitemDivisable = null, [WorkflowExpression] Func<string> timeTransactionsmodified = null, [WorkflowExpression] Func<string> timeTransactionsmodifier = null, [WorkflowExpression] Func<string> timeTransactionsmodifierFullName = null, [WorkflowExpression] Func<string> timeTransactionsnotes = null, [WorkflowExpression] Func<double> timeTransactionsprice = null, [WorkflowExpression] Func<double> timeTransactionspriceFC = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccount = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccountCode = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccountName = null, [WorkflowExpression] Func<string> timeTransactionsprojectCode = null, [WorkflowExpression] Func<string> timeTransactionsprojectDescription = null, [WorkflowExpression] Func<bool> timeTransactionsskipValidation = null, [WorkflowExpression] Func<string> timeTransactionsstartTime = null, [WorkflowExpression] Func<string> timeTransactionssubscription = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccount = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccountCode = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccountName = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionDescription = null, [WorkflowExpression] Func<int> timeTransactionssubscriptionNumber = null, [WorkflowExpression] Func<double> timeTransactionstype = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(iD, nameof(iD), required: true);
            SourceExpression.Validate(timeTransactionsitem, nameof(timeTransactionsitem), required: true);
            SourceExpression.Validate(timeTransactionsproject, nameof(timeTransactionsproject), required: true);
            SourceExpression.Validate(timeTransactionsquantity, nameof(timeTransactionsquantity), required: true);
            SourceExpression.Validate(timeTransactionsiD, nameof(timeTransactionsiD), required: false);
            SourceExpression.Validate(timeTransactionsaccount, nameof(timeTransactionsaccount), required: false);
            SourceExpression.Validate(timeTransactionsaccountName, nameof(timeTransactionsaccountName), required: false);
            SourceExpression.Validate(timeTransactionsactivity, nameof(timeTransactionsactivity), required: false);
            SourceExpression.Validate(timeTransactionsactivityDescription, nameof(timeTransactionsactivityDescription), required: false);
            SourceExpression.Validate(timeTransactionsamount, nameof(timeTransactionsamount), required: false);
            SourceExpression.Validate(timeTransactionsamountFC, nameof(timeTransactionsamountFC), required: false);
            SourceExpression.Validate(timeTransactionsattachment, nameof(timeTransactionsattachment), required: false);
            SourceExpression.Validate(timeTransactionscreated, nameof(timeTransactionscreated), required: false);
            SourceExpression.Validate(timeTransactionscreator, nameof(timeTransactionscreator), required: false);
            SourceExpression.Validate(timeTransactionscreatorFullName, nameof(timeTransactionscreatorFullName), required: false);
            SourceExpression.Validate(timeTransactionscurrency, nameof(timeTransactionscurrency), required: false);
            SourceExpression.Validate(timeTransactionsdate, nameof(timeTransactionsdate), required: false);
            SourceExpression.Validate(timeTransactionsdivision, nameof(timeTransactionsdivision), required: false);
            SourceExpression.Validate(timeTransactionsdivisionDescription, nameof(timeTransactionsdivisionDescription), required: false);
            SourceExpression.Validate(timeTransactionsemployee, nameof(timeTransactionsemployee), required: false);
            SourceExpression.Validate(timeTransactionsendTime, nameof(timeTransactionsendTime), required: false);
            SourceExpression.Validate(timeTransactionsentryNumber, nameof(timeTransactionsentryNumber), required: false);
            SourceExpression.Validate(timeTransactionserrorText, nameof(timeTransactionserrorText), required: false);
            SourceExpression.Validate(timeTransactionshourStatus, nameof(timeTransactionshourStatus), required: false);
            SourceExpression.Validate(timeTransactionsitemDescription, nameof(timeTransactionsitemDescription), required: false);
            SourceExpression.Validate(timeTransactionsitemDivisable, nameof(timeTransactionsitemDivisable), required: false);
            SourceExpression.Validate(timeTransactionsmodified, nameof(timeTransactionsmodified), required: false);
            SourceExpression.Validate(timeTransactionsmodifier, nameof(timeTransactionsmodifier), required: false);
            SourceExpression.Validate(timeTransactionsmodifierFullName, nameof(timeTransactionsmodifierFullName), required: false);
            SourceExpression.Validate(timeTransactionsnotes, nameof(timeTransactionsnotes), required: false);
            SourceExpression.Validate(timeTransactionsprice, nameof(timeTransactionsprice), required: false);
            SourceExpression.Validate(timeTransactionspriceFC, nameof(timeTransactionspriceFC), required: false);
            SourceExpression.Validate(timeTransactionsprojectAccount, nameof(timeTransactionsprojectAccount), required: false);
            SourceExpression.Validate(timeTransactionsprojectAccountCode, nameof(timeTransactionsprojectAccountCode), required: false);
            SourceExpression.Validate(timeTransactionsprojectAccountName, nameof(timeTransactionsprojectAccountName), required: false);
            SourceExpression.Validate(timeTransactionsprojectCode, nameof(timeTransactionsprojectCode), required: false);
            SourceExpression.Validate(timeTransactionsprojectDescription, nameof(timeTransactionsprojectDescription), required: false);
            SourceExpression.Validate(timeTransactionsskipValidation, nameof(timeTransactionsskipValidation), required: false);
            SourceExpression.Validate(timeTransactionsstartTime, nameof(timeTransactionsstartTime), required: false);
            SourceExpression.Validate(timeTransactionssubscription, nameof(timeTransactionssubscription), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionAccount, nameof(timeTransactionssubscriptionAccount), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionAccountCode, nameof(timeTransactionssubscriptionAccountCode), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionAccountName, nameof(timeTransactionssubscriptionAccountName), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionDescription, nameof(timeTransactionssubscriptionDescription), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionNumber, nameof(timeTransactionssubscriptionNumber), required: false);
            SourceExpression.Validate(timeTransactionstype, nameof(timeTransactionstype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = SourceExpressionConverter.ConvertO(iD);
                var timeTransactions = new JObject();
                var timeTransactionspropCount = 0;
                if (timeTransactionsiD != null)
                {
                    timeTransactions["ID"] = SourceExpressionConverter.ConvertToken(timeTransactionsiD);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsaccount != null)
                {
                    timeTransactions["Account"] = SourceExpressionConverter.ConvertToken(timeTransactionsaccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsaccountName != null)
                {
                    timeTransactions["AccountName"] = SourceExpressionConverter.ConvertToken(timeTransactionsaccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsactivity != null)
                {
                    timeTransactions["Activity"] = SourceExpressionConverter.ConvertToken(timeTransactionsactivity);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsactivityDescription != null)
                {
                    timeTransactions["ActivityDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionsactivityDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsamount != null)
                {
                    timeTransactions["Amount"] = SourceExpressionConverter.ConvertToken(timeTransactionsamount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsamountFC != null)
                {
                    timeTransactions["AmountFC"] = SourceExpressionConverter.ConvertToken(timeTransactionsamountFC);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsattachment != null)
                {
                    timeTransactions["Attachment"] = SourceExpressionConverter.ConvertToken(timeTransactionsattachment);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreated != null)
                {
                    timeTransactions["Created"] = SourceExpressionConverter.ConvertToken(timeTransactionscreated);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreator != null)
                {
                    timeTransactions["Creator"] = SourceExpressionConverter.ConvertToken(timeTransactionscreator);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreatorFullName != null)
                {
                    timeTransactions["CreatorFullName"] = SourceExpressionConverter.ConvertToken(timeTransactionscreatorFullName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscurrency != null)
                {
                    timeTransactions["Currency"] = SourceExpressionConverter.ConvertToken(timeTransactionscurrency);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdate != null)
                {
                    timeTransactions["Date"] = SourceExpressionConverter.ConvertToken(timeTransactionsdate);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdivision != null)
                {
                    timeTransactions["Division"] = SourceExpressionConverter.ConvertToken(timeTransactionsdivision);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdivisionDescription != null)
                {
                    timeTransactions["DivisionDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionsdivisionDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsemployee != null)
                {
                    timeTransactions["Employee"] = SourceExpressionConverter.ConvertToken(timeTransactionsemployee);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsendTime != null)
                {
                    timeTransactions["EndTime"] = SourceExpressionConverter.ConvertToken(timeTransactionsendTime);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsentryNumber != null)
                {
                    timeTransactions["EntryNumber"] = SourceExpressionConverter.ConvertToken(timeTransactionsentryNumber);
                    timeTransactionspropCount++;
                }

                if (timeTransactionserrorText != null)
                {
                    timeTransactions["ErrorText"] = SourceExpressionConverter.ConvertToken(timeTransactionserrorText);
                    timeTransactionspropCount++;
                }

                if (timeTransactionshourStatus != null)
                {
                    timeTransactions["HourStatus"] = SourceExpressionConverter.ConvertToken(timeTransactionshourStatus);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Item"] = SourceExpressionConverter.ConvertToken(timeTransactionsitem);
                if (timeTransactionsitemDescription != null)
                {
                    timeTransactions["ItemDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionsitemDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsitemDivisable != null)
                {
                    timeTransactions["ItemDivisable"] = SourceExpressionConverter.ConvertToken(timeTransactionsitemDivisable);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodified != null)
                {
                    timeTransactions["Modified"] = SourceExpressionConverter.ConvertToken(timeTransactionsmodified);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodifier != null)
                {
                    timeTransactions["Modifier"] = SourceExpressionConverter.ConvertToken(timeTransactionsmodifier);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodifierFullName != null)
                {
                    timeTransactions["ModifierFullName"] = SourceExpressionConverter.ConvertToken(timeTransactionsmodifierFullName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsnotes != null)
                {
                    timeTransactions["Notes"] = SourceExpressionConverter.ConvertToken(timeTransactionsnotes);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprice != null)
                {
                    timeTransactions["Price"] = SourceExpressionConverter.ConvertToken(timeTransactionsprice);
                    timeTransactionspropCount++;
                }

                if (timeTransactionspriceFC != null)
                {
                    timeTransactions["PriceFC"] = SourceExpressionConverter.ConvertToken(timeTransactionspriceFC);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Project"] = SourceExpressionConverter.ConvertToken(timeTransactionsproject);
                if (timeTransactionsprojectAccount != null)
                {
                    timeTransactions["ProjectAccount"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectAccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectAccountCode != null)
                {
                    timeTransactions["ProjectAccountCode"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectAccountCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectAccountName != null)
                {
                    timeTransactions["ProjectAccountName"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectAccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectCode != null)
                {
                    timeTransactions["ProjectCode"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectDescription != null)
                {
                    timeTransactions["ProjectDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectDescription);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Quantity"] = SourceExpressionConverter.ConvertToken(timeTransactionsquantity);
                if (timeTransactionsskipValidation != null)
                {
                    timeTransactions["SkipValidation"] = SourceExpressionConverter.ConvertToken(timeTransactionsskipValidation);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsstartTime != null)
                {
                    timeTransactions["StartTime"] = SourceExpressionConverter.ConvertToken(timeTransactionsstartTime);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscription != null)
                {
                    timeTransactions["Subscription"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccount != null)
                {
                    timeTransactions["SubscriptionAccount"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionAccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccountCode != null)
                {
                    timeTransactions["SubscriptionAccountCode"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionAccountCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccountName != null)
                {
                    timeTransactions["SubscriptionAccountName"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionAccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionDescription != null)
                {
                    timeTransactions["SubscriptionDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionNumber != null)
                {
                    timeTransactions["SubscriptionNumber"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionNumber);
                    timeTransactionspropCount++;
                }

                if (timeTransactionstype != null)
                {
                    timeTransactions["Type"] = SourceExpressionConverter.ConvertToken(timeTransactionstype);
                    timeTransactionspropCount++;
                }

                if (timeTransactionspropCount > 0)
                {
                    callPayload.Body = timeTransactions;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeTransactionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> PostTimeTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> timeTransactionsitem, [WorkflowExpression] Func<string> timeTransactionsproject, [WorkflowExpression] Func<double> timeTransactionsquantity, [WorkflowExpression] Func<string> timeTransactionsiD = null, [WorkflowExpression] Func<string> timeTransactionsaccount = null, [WorkflowExpression] Func<string> timeTransactionsaccountName = null, [WorkflowExpression] Func<string> timeTransactionsactivity = null, [WorkflowExpression] Func<string> timeTransactionsactivityDescription = null, [WorkflowExpression] Func<double> timeTransactionsamount = null, [WorkflowExpression] Func<double> timeTransactionsamountFC = null, [WorkflowExpression] Func<string> timeTransactionsattachment = null, [WorkflowExpression] Func<string> timeTransactionscreated = null, [WorkflowExpression] Func<string> timeTransactionscreator = null, [WorkflowExpression] Func<string> timeTransactionscreatorFullName = null, [WorkflowExpression] Func<string> timeTransactionscurrency = null, [WorkflowExpression] Func<string> timeTransactionsdate = null, [WorkflowExpression] Func<int> timeTransactionsdivision = null, [WorkflowExpression] Func<string> timeTransactionsdivisionDescription = null, [WorkflowExpression] Func<string> timeTransactionsemployee = null, [WorkflowExpression] Func<string> timeTransactionsendTime = null, [WorkflowExpression] Func<int> timeTransactionsentryNumber = null, [WorkflowExpression] Func<string> timeTransactionserrorText = null, [WorkflowExpression] Func<double> timeTransactionshourStatus = null, [WorkflowExpression] Func<string> timeTransactionsitemDescription = null, [WorkflowExpression] Func<bool> timeTransactionsitemDivisable = null, [WorkflowExpression] Func<string> timeTransactionsmodified = null, [WorkflowExpression] Func<string> timeTransactionsmodifier = null, [WorkflowExpression] Func<string> timeTransactionsmodifierFullName = null, [WorkflowExpression] Func<string> timeTransactionsnotes = null, [WorkflowExpression] Func<double> timeTransactionsprice = null, [WorkflowExpression] Func<double> timeTransactionspriceFC = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccount = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccountCode = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccountName = null, [WorkflowExpression] Func<string> timeTransactionsprojectCode = null, [WorkflowExpression] Func<string> timeTransactionsprojectDescription = null, [WorkflowExpression] Func<bool> timeTransactionsskipValidation = null, [WorkflowExpression] Func<string> timeTransactionsstartTime = null, [WorkflowExpression] Func<string> timeTransactionssubscription = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccount = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccountCode = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccountName = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionDescription = null, [WorkflowExpression] Func<int> timeTransactionssubscriptionNumber = null, [WorkflowExpression] Func<double> timeTransactionstype = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(timeTransactionsitem, nameof(timeTransactionsitem), required: true);
            SourceExpression.Validate(timeTransactionsproject, nameof(timeTransactionsproject), required: true);
            SourceExpression.Validate(timeTransactionsquantity, nameof(timeTransactionsquantity), required: true);
            SourceExpression.Validate(timeTransactionsiD, nameof(timeTransactionsiD), required: false);
            SourceExpression.Validate(timeTransactionsaccount, nameof(timeTransactionsaccount), required: false);
            SourceExpression.Validate(timeTransactionsaccountName, nameof(timeTransactionsaccountName), required: false);
            SourceExpression.Validate(timeTransactionsactivity, nameof(timeTransactionsactivity), required: false);
            SourceExpression.Validate(timeTransactionsactivityDescription, nameof(timeTransactionsactivityDescription), required: false);
            SourceExpression.Validate(timeTransactionsamount, nameof(timeTransactionsamount), required: false);
            SourceExpression.Validate(timeTransactionsamountFC, nameof(timeTransactionsamountFC), required: false);
            SourceExpression.Validate(timeTransactionsattachment, nameof(timeTransactionsattachment), required: false);
            SourceExpression.Validate(timeTransactionscreated, nameof(timeTransactionscreated), required: false);
            SourceExpression.Validate(timeTransactionscreator, nameof(timeTransactionscreator), required: false);
            SourceExpression.Validate(timeTransactionscreatorFullName, nameof(timeTransactionscreatorFullName), required: false);
            SourceExpression.Validate(timeTransactionscurrency, nameof(timeTransactionscurrency), required: false);
            SourceExpression.Validate(timeTransactionsdate, nameof(timeTransactionsdate), required: false);
            SourceExpression.Validate(timeTransactionsdivision, nameof(timeTransactionsdivision), required: false);
            SourceExpression.Validate(timeTransactionsdivisionDescription, nameof(timeTransactionsdivisionDescription), required: false);
            SourceExpression.Validate(timeTransactionsemployee, nameof(timeTransactionsemployee), required: false);
            SourceExpression.Validate(timeTransactionsendTime, nameof(timeTransactionsendTime), required: false);
            SourceExpression.Validate(timeTransactionsentryNumber, nameof(timeTransactionsentryNumber), required: false);
            SourceExpression.Validate(timeTransactionserrorText, nameof(timeTransactionserrorText), required: false);
            SourceExpression.Validate(timeTransactionshourStatus, nameof(timeTransactionshourStatus), required: false);
            SourceExpression.Validate(timeTransactionsitemDescription, nameof(timeTransactionsitemDescription), required: false);
            SourceExpression.Validate(timeTransactionsitemDivisable, nameof(timeTransactionsitemDivisable), required: false);
            SourceExpression.Validate(timeTransactionsmodified, nameof(timeTransactionsmodified), required: false);
            SourceExpression.Validate(timeTransactionsmodifier, nameof(timeTransactionsmodifier), required: false);
            SourceExpression.Validate(timeTransactionsmodifierFullName, nameof(timeTransactionsmodifierFullName), required: false);
            SourceExpression.Validate(timeTransactionsnotes, nameof(timeTransactionsnotes), required: false);
            SourceExpression.Validate(timeTransactionsprice, nameof(timeTransactionsprice), required: false);
            SourceExpression.Validate(timeTransactionspriceFC, nameof(timeTransactionspriceFC), required: false);
            SourceExpression.Validate(timeTransactionsprojectAccount, nameof(timeTransactionsprojectAccount), required: false);
            SourceExpression.Validate(timeTransactionsprojectAccountCode, nameof(timeTransactionsprojectAccountCode), required: false);
            SourceExpression.Validate(timeTransactionsprojectAccountName, nameof(timeTransactionsprojectAccountName), required: false);
            SourceExpression.Validate(timeTransactionsprojectCode, nameof(timeTransactionsprojectCode), required: false);
            SourceExpression.Validate(timeTransactionsprojectDescription, nameof(timeTransactionsprojectDescription), required: false);
            SourceExpression.Validate(timeTransactionsskipValidation, nameof(timeTransactionsskipValidation), required: false);
            SourceExpression.Validate(timeTransactionsstartTime, nameof(timeTransactionsstartTime), required: false);
            SourceExpression.Validate(timeTransactionssubscription, nameof(timeTransactionssubscription), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionAccount, nameof(timeTransactionssubscriptionAccount), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionAccountCode, nameof(timeTransactionssubscriptionAccountCode), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionAccountName, nameof(timeTransactionssubscriptionAccountName), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionDescription, nameof(timeTransactionssubscriptionDescription), required: false);
            SourceExpression.Validate(timeTransactionssubscriptionNumber, nameof(timeTransactionssubscriptionNumber), required: false);
            SourceExpression.Validate(timeTransactionstype, nameof(timeTransactionstype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var timeTransactions = new JObject();
                var timeTransactionspropCount = 0;
                if (timeTransactionsiD != null)
                {
                    timeTransactions["ID"] = SourceExpressionConverter.ConvertToken(timeTransactionsiD);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsaccount != null)
                {
                    timeTransactions["Account"] = SourceExpressionConverter.ConvertToken(timeTransactionsaccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsaccountName != null)
                {
                    timeTransactions["AccountName"] = SourceExpressionConverter.ConvertToken(timeTransactionsaccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsactivity != null)
                {
                    timeTransactions["Activity"] = SourceExpressionConverter.ConvertToken(timeTransactionsactivity);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsactivityDescription != null)
                {
                    timeTransactions["ActivityDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionsactivityDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsamount != null)
                {
                    timeTransactions["Amount"] = SourceExpressionConverter.ConvertToken(timeTransactionsamount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsamountFC != null)
                {
                    timeTransactions["AmountFC"] = SourceExpressionConverter.ConvertToken(timeTransactionsamountFC);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsattachment != null)
                {
                    timeTransactions["Attachment"] = SourceExpressionConverter.ConvertToken(timeTransactionsattachment);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreated != null)
                {
                    timeTransactions["Created"] = SourceExpressionConverter.ConvertToken(timeTransactionscreated);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreator != null)
                {
                    timeTransactions["Creator"] = SourceExpressionConverter.ConvertToken(timeTransactionscreator);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreatorFullName != null)
                {
                    timeTransactions["CreatorFullName"] = SourceExpressionConverter.ConvertToken(timeTransactionscreatorFullName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscurrency != null)
                {
                    timeTransactions["Currency"] = SourceExpressionConverter.ConvertToken(timeTransactionscurrency);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdate != null)
                {
                    timeTransactions["Date"] = SourceExpressionConverter.ConvertToken(timeTransactionsdate);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdivision != null)
                {
                    timeTransactions["Division"] = SourceExpressionConverter.ConvertToken(timeTransactionsdivision);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdivisionDescription != null)
                {
                    timeTransactions["DivisionDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionsdivisionDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsemployee != null)
                {
                    timeTransactions["Employee"] = SourceExpressionConverter.ConvertToken(timeTransactionsemployee);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsendTime != null)
                {
                    timeTransactions["EndTime"] = SourceExpressionConverter.ConvertToken(timeTransactionsendTime);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsentryNumber != null)
                {
                    timeTransactions["EntryNumber"] = SourceExpressionConverter.ConvertToken(timeTransactionsentryNumber);
                    timeTransactionspropCount++;
                }

                if (timeTransactionserrorText != null)
                {
                    timeTransactions["ErrorText"] = SourceExpressionConverter.ConvertToken(timeTransactionserrorText);
                    timeTransactionspropCount++;
                }

                if (timeTransactionshourStatus != null)
                {
                    timeTransactions["HourStatus"] = SourceExpressionConverter.ConvertToken(timeTransactionshourStatus);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Item"] = SourceExpressionConverter.ConvertToken(timeTransactionsitem);
                if (timeTransactionsitemDescription != null)
                {
                    timeTransactions["ItemDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionsitemDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsitemDivisable != null)
                {
                    timeTransactions["ItemDivisable"] = SourceExpressionConverter.ConvertToken(timeTransactionsitemDivisable);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodified != null)
                {
                    timeTransactions["Modified"] = SourceExpressionConverter.ConvertToken(timeTransactionsmodified);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodifier != null)
                {
                    timeTransactions["Modifier"] = SourceExpressionConverter.ConvertToken(timeTransactionsmodifier);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodifierFullName != null)
                {
                    timeTransactions["ModifierFullName"] = SourceExpressionConverter.ConvertToken(timeTransactionsmodifierFullName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsnotes != null)
                {
                    timeTransactions["Notes"] = SourceExpressionConverter.ConvertToken(timeTransactionsnotes);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprice != null)
                {
                    timeTransactions["Price"] = SourceExpressionConverter.ConvertToken(timeTransactionsprice);
                    timeTransactionspropCount++;
                }

                if (timeTransactionspriceFC != null)
                {
                    timeTransactions["PriceFC"] = SourceExpressionConverter.ConvertToken(timeTransactionspriceFC);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Project"] = SourceExpressionConverter.ConvertToken(timeTransactionsproject);
                if (timeTransactionsprojectAccount != null)
                {
                    timeTransactions["ProjectAccount"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectAccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectAccountCode != null)
                {
                    timeTransactions["ProjectAccountCode"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectAccountCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectAccountName != null)
                {
                    timeTransactions["ProjectAccountName"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectAccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectCode != null)
                {
                    timeTransactions["ProjectCode"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectDescription != null)
                {
                    timeTransactions["ProjectDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionsprojectDescription);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Quantity"] = SourceExpressionConverter.ConvertToken(timeTransactionsquantity);
                if (timeTransactionsskipValidation != null)
                {
                    timeTransactions["SkipValidation"] = SourceExpressionConverter.ConvertToken(timeTransactionsskipValidation);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsstartTime != null)
                {
                    timeTransactions["StartTime"] = SourceExpressionConverter.ConvertToken(timeTransactionsstartTime);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscription != null)
                {
                    timeTransactions["Subscription"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccount != null)
                {
                    timeTransactions["SubscriptionAccount"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionAccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccountCode != null)
                {
                    timeTransactions["SubscriptionAccountCode"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionAccountCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccountName != null)
                {
                    timeTransactions["SubscriptionAccountName"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionAccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionDescription != null)
                {
                    timeTransactions["SubscriptionDescription"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionNumber != null)
                {
                    timeTransactions["SubscriptionNumber"] = SourceExpressionConverter.ConvertToken(timeTransactionssubscriptionNumber);
                    timeTransactionspropCount++;
                }

                if (timeTransactionstype != null)
                {
                    timeTransactions["Type"] = SourceExpressionConverter.ConvertToken(timeTransactionstype);
                    timeTransactionspropCount++;
                }

                if (timeTransactionspropCount > 0)
                {
                    callPayload.Body = timeTransactions;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeTransactionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> DeleteTimeTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(iD, nameof(iD), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = SourceExpressionConverter.ConvertO(iD);
                return callPayload;
            }

            return new ApiConnectionAction<TimeTransactionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectTimeCostTransactionsResponse> GetProjectTimeCostTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(division, nameof(division), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/sync/Project/TimeCostTransactions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectTimeCostTransactionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<MeResponse> GetMe([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/current/Me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<MeResponse>(BuildSourceInput);
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