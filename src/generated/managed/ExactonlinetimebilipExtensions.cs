//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Exactonlinetimebilip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExactonlinetimebilipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetDivisions))]
        public IBodyWorkflowAction<DivisionsResponse> GetDivisions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DivisionsResponse> __BuildGetDivisions(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<DivisionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/hrm/Divisions", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<DivisionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmploymentInternalRates))]
        public IBodyWorkflowAction<EmploymentInternalRatesResponse> GetEmploymentInternalRates([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmploymentInternalRatesResponse> __BuildGetEmploymentInternalRates(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<EmploymentInternalRatesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/EmploymentInternalRates", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<EmploymentInternalRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourCostTypes))]
        public IBodyWorkflowAction<HourCostTypesResponse> GetHourCostTypes([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourCostTypesResponse> __BuildGetHourCostTypes(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourCostTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourCostTypes", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<HourCostTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourEntryActivitiesByProject))]
        public IBodyWorkflowAction<HourEntryActivitiesByProjectResponse> GetHourEntryActivitiesByProject([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourEntryActivitiesByProjectResponse> __BuildGetHourEntryActivitiesByProject(WorkflowExpression<string> division, WorkflowExpression<string> projectId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryActivitiesByProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryActivitiesByProject", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionAction<HourEntryActivitiesByProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourEntryRecentAccounts))]
        public IBodyWorkflowAction<HourEntryRecentAccountsResponse> GetHourEntryRecentAccounts([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourEntryRecentAccountsResponse> __BuildGetHourEntryRecentAccounts(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentAccountsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentAccounts", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<HourEntryRecentAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourEntryRecentAccountsByProject))]
        public IBodyWorkflowAction<HourEntryRecentAccountsByProjectResponse> GetHourEntryRecentAccountsByProject([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourEntryRecentAccountsByProjectResponse> __BuildGetHourEntryRecentAccountsByProject(WorkflowExpression<string> division, WorkflowExpression<string> projectId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentAccountsByProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentAccountsByProject", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionAction<HourEntryRecentAccountsByProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourEntryRecentHourTypes))]
        public IBodyWorkflowAction<HourEntryRecentHourTypesResponse> GetHourEntryRecentHourTypes([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourEntryRecentHourTypesResponse> __BuildGetHourEntryRecentHourTypes(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentHourTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentHourTypes", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<HourEntryRecentHourTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourEntryRecentHourTypesByProject))]
        public IBodyWorkflowAction<HourEntryRecentHourTypesByProjectResponse> GetHourEntryRecentHourTypesByProject([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourEntryRecentHourTypesByProjectResponse> __BuildGetHourEntryRecentHourTypesByProject(WorkflowExpression<string> division, WorkflowExpression<string> projectId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentHourTypesByProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentHourTypesByProject", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionAction<HourEntryRecentHourTypesByProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourEntryRecentProjects))]
        public IBodyWorkflowAction<HourEntryRecentProjectsResponse> GetHourEntryRecentProjects([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourEntryRecentProjectsResponse> __BuildGetHourEntryRecentProjects(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentProjectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentProjects", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<HourEntryRecentProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHoursByDate))]
        public IBodyWorkflowAction<HoursByDateResponse> GetHoursByDate([WorkflowExpression] Func<string> checkDate, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HoursByDateResponse> __BuildGetHoursByDate(WorkflowExpression<string> checkDate, WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(checkDate, nameof(checkDate), required: true);
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HoursByDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HoursByDate", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["checkDate"] = ExpressionConverter.Convert(checkDate);
                return new ApiConnectionAction<HoursByDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHoursById))]
        public IBodyWorkflowAction<HoursByIdResponse> GetHoursById([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> entryId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HoursByIdResponse> __BuildGetHoursById(WorkflowExpression<string> division, WorkflowExpression<string> entryId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(entryId, nameof(entryId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HoursByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HoursById", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["entryId"] = ExpressionConverter.Convert(entryId);
                return new ApiConnectionAction<HoursByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourTypes))]
        public IBodyWorkflowAction<HourTypesResponse> GetHourTypes([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourTypesResponse> __BuildGetHourTypes(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypes", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<HourTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourTypesByDate))]
        public IBodyWorkflowAction<HourTypesByDateResponse> GetHourTypesByDate([WorkflowExpression] Func<string> checkDate, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourTypesByDateResponse> __BuildGetHourTypesByDate(WorkflowExpression<string> checkDate, WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(checkDate, nameof(checkDate), required: true);
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourTypesByDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypesByDate", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["checkDate"] = ExpressionConverter.Convert(checkDate);
                return new ApiConnectionAction<HourTypesByDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHourTypesByProjectAndDate))]
        public IBodyWorkflowAction<HourTypesByProjectAndDateResponse> GetHourTypesByProjectAndDate([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HourTypesByProjectAndDateResponse> __BuildGetHourTypesByProjectAndDate(WorkflowExpression<string> division, WorkflowExpression<string> projectId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<HourTypesByProjectAndDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypesByProjectAndDate", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionAction<HourTypesByProjectAndDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjectRestrictionRebillings))]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> GetProjectRestrictionRebillings([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> __BuildGetProjectRestrictionRebillings(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ProjectRestrictionRebillingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildPutProjectRestrictionRebillings))]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> PutProjectRestrictionRebillings([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebill, [WorkflowExpression] Func<string> projectRestrictionRebillingsproject, [WorkflowExpression] Func<string> projectRestrictionRebillingsiD = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebillCode = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebillDescription = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreated = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreator = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreatorFullName = null, [WorkflowExpression] Func<int> projectRestrictionRebillingsdivision = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodified = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodifier = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodifierFullName = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsprojectCode = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsprojectDescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> __BuildPutProjectRestrictionRebillings(WorkflowExpression<string> division, WorkflowExpression<string> iD, WorkflowExpression<string> projectRestrictionRebillingscostTypeRebill, WorkflowExpression<string> projectRestrictionRebillingsproject, WorkflowExpression<string> projectRestrictionRebillingsiD = null, WorkflowExpression<string> projectRestrictionRebillingscostTypeRebillCode = null, WorkflowExpression<string> projectRestrictionRebillingscostTypeRebillDescription = null, WorkflowExpression<string> projectRestrictionRebillingscreated = null, WorkflowExpression<string> projectRestrictionRebillingscreator = null, WorkflowExpression<string> projectRestrictionRebillingscreatorFullName = null, WorkflowExpression<int> projectRestrictionRebillingsdivision = null, WorkflowExpression<string> projectRestrictionRebillingsmodified = null, WorkflowExpression<string> projectRestrictionRebillingsmodifier = null, WorkflowExpression<string> projectRestrictionRebillingsmodifierFullName = null, WorkflowExpression<string> projectRestrictionRebillingsprojectCode = null, WorkflowExpression<string> projectRestrictionRebillingsprojectDescription = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(iD, nameof(iD), required: true);
            WorkflowExpression.Validate(projectRestrictionRebillingscostTypeRebill, nameof(projectRestrictionRebillingscostTypeRebill), required: true);
            WorkflowExpression.Validate(projectRestrictionRebillingsproject, nameof(projectRestrictionRebillingsproject), required: true);
            WorkflowExpression.Validate(projectRestrictionRebillingsiD, nameof(projectRestrictionRebillingsiD), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscostTypeRebillCode, nameof(projectRestrictionRebillingscostTypeRebillCode), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscostTypeRebillDescription, nameof(projectRestrictionRebillingscostTypeRebillDescription), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscreated, nameof(projectRestrictionRebillingscreated), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscreator, nameof(projectRestrictionRebillingscreator), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscreatorFullName, nameof(projectRestrictionRebillingscreatorFullName), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsdivision, nameof(projectRestrictionRebillingsdivision), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsmodified, nameof(projectRestrictionRebillingsmodified), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsmodifier, nameof(projectRestrictionRebillingsmodifier), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsmodifierFullName, nameof(projectRestrictionRebillingsmodifierFullName), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsprojectCode, nameof(projectRestrictionRebillingsprojectCode), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsprojectDescription, nameof(projectRestrictionRebillingsprojectDescription), required: false);
            return new DeferredBodyAction<ProjectRestrictionRebillingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(iD);
                var projectRestrictionRebillings = new JObject();
                var projectRestrictionRebillingspropCount = 0;
                if (projectRestrictionRebillingsiD != null)
                {
                    projectRestrictionRebillings["ID"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsiD);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["CostTypeRebill"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscostTypeRebill);
                if (projectRestrictionRebillingscostTypeRebillCode != null)
                {
                    projectRestrictionRebillings["CostTypeRebillCode"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscostTypeRebillCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscostTypeRebillDescription != null)
                {
                    projectRestrictionRebillings["CostTypeRebillDescription"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscostTypeRebillDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreated != null)
                {
                    projectRestrictionRebillings["Created"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscreated);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreator != null)
                {
                    projectRestrictionRebillings["Creator"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscreator);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreatorFullName != null)
                {
                    projectRestrictionRebillings["CreatorFullName"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscreatorFullName);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsdivision != null)
                {
                    projectRestrictionRebillings["Division"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsdivision);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodified != null)
                {
                    projectRestrictionRebillings["Modified"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsmodified);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodifier != null)
                {
                    projectRestrictionRebillings["Modifier"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsmodifier);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodifierFullName != null)
                {
                    projectRestrictionRebillings["ModifierFullName"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsmodifierFullName);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["Project"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsproject);
                if (projectRestrictionRebillingsprojectCode != null)
                {
                    projectRestrictionRebillings["ProjectCode"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsprojectCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsprojectDescription != null)
                {
                    projectRestrictionRebillings["ProjectDescription"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsprojectDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingspropCount > 0)
                {
                    callPayload.Body = projectRestrictionRebillings;
                }

                return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildPostProjectRestrictionRebillings))]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> PostProjectRestrictionRebillings([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebill, [WorkflowExpression] Func<string> projectRestrictionRebillingsproject, [WorkflowExpression] Func<string> projectRestrictionRebillingsiD = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebillCode = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscostTypeRebillDescription = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreated = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreator = null, [WorkflowExpression] Func<string> projectRestrictionRebillingscreatorFullName = null, [WorkflowExpression] Func<int> projectRestrictionRebillingsdivision = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodified = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodifier = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsmodifierFullName = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsprojectCode = null, [WorkflowExpression] Func<string> projectRestrictionRebillingsprojectDescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> __BuildPostProjectRestrictionRebillings(WorkflowExpression<string> division, WorkflowExpression<string> projectRestrictionRebillingscostTypeRebill, WorkflowExpression<string> projectRestrictionRebillingsproject, WorkflowExpression<string> projectRestrictionRebillingsiD = null, WorkflowExpression<string> projectRestrictionRebillingscostTypeRebillCode = null, WorkflowExpression<string> projectRestrictionRebillingscostTypeRebillDescription = null, WorkflowExpression<string> projectRestrictionRebillingscreated = null, WorkflowExpression<string> projectRestrictionRebillingscreator = null, WorkflowExpression<string> projectRestrictionRebillingscreatorFullName = null, WorkflowExpression<int> projectRestrictionRebillingsdivision = null, WorkflowExpression<string> projectRestrictionRebillingsmodified = null, WorkflowExpression<string> projectRestrictionRebillingsmodifier = null, WorkflowExpression<string> projectRestrictionRebillingsmodifierFullName = null, WorkflowExpression<string> projectRestrictionRebillingsprojectCode = null, WorkflowExpression<string> projectRestrictionRebillingsprojectDescription = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(projectRestrictionRebillingscostTypeRebill, nameof(projectRestrictionRebillingscostTypeRebill), required: true);
            WorkflowExpression.Validate(projectRestrictionRebillingsproject, nameof(projectRestrictionRebillingsproject), required: true);
            WorkflowExpression.Validate(projectRestrictionRebillingsiD, nameof(projectRestrictionRebillingsiD), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscostTypeRebillCode, nameof(projectRestrictionRebillingscostTypeRebillCode), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscostTypeRebillDescription, nameof(projectRestrictionRebillingscostTypeRebillDescription), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscreated, nameof(projectRestrictionRebillingscreated), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscreator, nameof(projectRestrictionRebillingscreator), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingscreatorFullName, nameof(projectRestrictionRebillingscreatorFullName), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsdivision, nameof(projectRestrictionRebillingsdivision), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsmodified, nameof(projectRestrictionRebillingsmodified), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsmodifier, nameof(projectRestrictionRebillingsmodifier), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsmodifierFullName, nameof(projectRestrictionRebillingsmodifierFullName), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsprojectCode, nameof(projectRestrictionRebillingsprojectCode), required: false);
            WorkflowExpression.Validate(projectRestrictionRebillingsprojectDescription, nameof(projectRestrictionRebillingsprojectDescription), required: false);
            return new DeferredBodyAction<ProjectRestrictionRebillingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var projectRestrictionRebillings = new JObject();
                var projectRestrictionRebillingspropCount = 0;
                if (projectRestrictionRebillingsiD != null)
                {
                    projectRestrictionRebillings["ID"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsiD);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["CostTypeRebill"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscostTypeRebill);
                if (projectRestrictionRebillingscostTypeRebillCode != null)
                {
                    projectRestrictionRebillings["CostTypeRebillCode"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscostTypeRebillCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscostTypeRebillDescription != null)
                {
                    projectRestrictionRebillings["CostTypeRebillDescription"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscostTypeRebillDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreated != null)
                {
                    projectRestrictionRebillings["Created"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscreated);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreator != null)
                {
                    projectRestrictionRebillings["Creator"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscreator);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingscreatorFullName != null)
                {
                    projectRestrictionRebillings["CreatorFullName"] = ExpressionConverter.ConvertO(projectRestrictionRebillingscreatorFullName);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsdivision != null)
                {
                    projectRestrictionRebillings["Division"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsdivision);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodified != null)
                {
                    projectRestrictionRebillings["Modified"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsmodified);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodifier != null)
                {
                    projectRestrictionRebillings["Modifier"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsmodifier);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsmodifierFullName != null)
                {
                    projectRestrictionRebillings["ModifierFullName"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsmodifierFullName);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["Project"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsproject);
                if (projectRestrictionRebillingsprojectCode != null)
                {
                    projectRestrictionRebillings["ProjectCode"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsprojectCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingsprojectDescription != null)
                {
                    projectRestrictionRebillings["ProjectDescription"] = ExpressionConverter.ConvertO(projectRestrictionRebillingsprojectDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (projectRestrictionRebillingspropCount > 0)
                {
                    callPayload.Body = projectRestrictionRebillings;
                }

                return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteProjectRestrictionRebillings))]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> DeleteProjectRestrictionRebillings([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> __BuildDeleteProjectRestrictionRebillings(WorkflowExpression<string> division, WorkflowExpression<string> iD)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(iD, nameof(iD), required: true);
            return new DeferredBodyAction<ProjectRestrictionRebillingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(iD);
                return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecentCostsByNumberOfWeeks))]
        public IBodyWorkflowAction<RecentCostsByNumberOfWeeksResponse> GetRecentCostsByNumberOfWeeks([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<int> numberOfWeeks, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecentCostsByNumberOfWeeksResponse> __BuildGetRecentCostsByNumberOfWeeks(WorkflowExpression<string> division, WorkflowExpression<int> numberOfWeeks, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(numberOfWeeks, nameof(numberOfWeeks), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<RecentCostsByNumberOfWeeksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentCostsByNumberOfWeeks", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["numberOfWeeks"] = ExpressionConverter.Convert(numberOfWeeks);
                return new ApiConnectionAction<RecentCostsByNumberOfWeeksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecentHours))]
        public IBodyWorkflowAction<RecentHoursResponse> GetRecentHours([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecentHoursResponse> __BuildGetRecentHours(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<RecentHoursResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentHours", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<RecentHoursResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecentHoursByNumberOfWeeks))]
        public IBodyWorkflowAction<RecentHoursByNumberOfWeeksResponse> GetRecentHoursByNumberOfWeeks([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<int> numberOfWeeks, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecentHoursByNumberOfWeeksResponse> __BuildGetRecentHoursByNumberOfWeeks(WorkflowExpression<string> division, WorkflowExpression<int> numberOfWeeks, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(numberOfWeeks, nameof(numberOfWeeks), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<RecentHoursByNumberOfWeeksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentHoursByNumberOfWeeks", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["numberOfWeeks"] = ExpressionConverter.Convert(numberOfWeeks);
                return new ApiConnectionAction<RecentHoursByNumberOfWeeksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingAccountDetails))]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsResponse> GetTimeAndBillingAccountDetails([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsResponse> __BuildGetTimeAndBillingAccountDetails(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingAccountDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingAccountDetails", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingAccountDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingAccountDetailsByID))]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsByIDResponse> GetTimeAndBillingAccountDetailsByID([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsByIDResponse> __BuildGetTimeAndBillingAccountDetailsByID(WorkflowExpression<string> accountId, WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingAccountDetailsByIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingAccountDetailsByID", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["accountId"] = ExpressionConverter.Convert(accountId);
                return new ApiConnectionAction<TimeAndBillingAccountDetailsByIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingActivitiesAndExpenses))]
        public IBodyWorkflowAction<TimeAndBillingActivitiesAndExpensesResponse> GetTimeAndBillingActivitiesAndExpenses([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingActivitiesAndExpensesResponse> __BuildGetTimeAndBillingActivitiesAndExpenses(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingActivitiesAndExpensesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingActivitiesAndExpenses", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingActivitiesAndExpensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryAccounts))]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsResponse> GetTimeAndBillingEntryAccounts([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsResponse> __BuildGetTimeAndBillingEntryAccounts(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryAccountsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccounts", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingEntryAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryAccountsByDate))]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByDateResponse> GetTimeAndBillingEntryAccountsByDate([WorkflowExpression] Func<string> checkDate, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByDateResponse> __BuildGetTimeAndBillingEntryAccountsByDate(WorkflowExpression<string> checkDate, WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(checkDate, nameof(checkDate), required: true);
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryAccountsByDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccountsByDate", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["checkDate"] = ExpressionConverter.Convert(checkDate);
                return new ApiConnectionAction<TimeAndBillingEntryAccountsByDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryAccountsByProjectAndDate))]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByProjectAndDateResponse> GetTimeAndBillingEntryAccountsByProjectAndDate([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByProjectAndDateResponse> __BuildGetTimeAndBillingEntryAccountsByProjectAndDate(WorkflowExpression<string> division, WorkflowExpression<string> projectId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryAccountsByProjectAndDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccountsByProjectAndDate", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionAction<TimeAndBillingEntryAccountsByProjectAndDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryProjects))]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsResponse> GetTimeAndBillingEntryProjects([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsResponse> __BuildGetTimeAndBillingEntryProjects(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryProjectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjects", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingEntryProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryProjectsByAccountAndDate))]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByAccountAndDateResponse> GetTimeAndBillingEntryProjectsByAccountAndDate([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByAccountAndDateResponse> __BuildGetTimeAndBillingEntryProjectsByAccountAndDate(WorkflowExpression<string> accountId, WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryProjectsByAccountAndDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjectsByAccountAndDate", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["accountId"] = ExpressionConverter.Convert(accountId);
                return new ApiConnectionAction<TimeAndBillingEntryProjectsByAccountAndDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryProjectsByDate))]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByDateResponse> GetTimeAndBillingEntryProjectsByDate([WorkflowExpression] Func<string> checkDate, [WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByDateResponse> __BuildGetTimeAndBillingEntryProjectsByDate(WorkflowExpression<string> checkDate, WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(checkDate, nameof(checkDate), required: true);
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryProjectsByDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjectsByDate", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["checkDate"] = ExpressionConverter.Convert(checkDate);
                return new ApiConnectionAction<TimeAndBillingEntryProjectsByDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryRecentAccounts))]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentAccountsResponse> GetTimeAndBillingEntryRecentAccounts([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentAccountsResponse> __BuildGetTimeAndBillingEntryRecentAccounts(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryRecentAccountsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentAccounts", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingEntryRecentAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryRecentActivitiesAndExpenses))]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse> GetTimeAndBillingEntryRecentActivitiesAndExpenses([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse> __BuildGetTimeAndBillingEntryRecentActivitiesAndExpenses(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentActivitiesAndExpenses", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryRecentHourCostTypes))]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentHourCostTypesResponse> GetTimeAndBillingEntryRecentHourCostTypes([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentHourCostTypesResponse> __BuildGetTimeAndBillingEntryRecentHourCostTypes(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryRecentHourCostTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentHourCostTypes", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingEntryRecentHourCostTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingEntryRecentProjects))]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentProjectsResponse> GetTimeAndBillingEntryRecentProjects([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentProjectsResponse> __BuildGetTimeAndBillingEntryRecentProjects(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryRecentProjectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentProjects", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingEntryRecentProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingItemDetails))]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsResponse> GetTimeAndBillingItemDetails([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsResponse> __BuildGetTimeAndBillingItemDetails(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingItemDetails", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingItemDetailsByID))]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsByIDResponse> GetTimeAndBillingItemDetailsByID([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsByIDResponse> __BuildGetTimeAndBillingItemDetailsByID(WorkflowExpression<string> division, WorkflowExpression<string> itemId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(itemId, nameof(itemId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingItemDetailsByIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingItemDetailsByID", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["itemId"] = ExpressionConverter.Convert(itemId);
                return new ApiConnectionAction<TimeAndBillingItemDetailsByIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingProjectDetails))]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsResponse> GetTimeAndBillingProjectDetails([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsResponse> __BuildGetTimeAndBillingProjectDetails(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingProjectDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingProjectDetails", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingProjectDetailsByID))]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsByIDResponse> GetTimeAndBillingProjectDetailsByID([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsByIDResponse> __BuildGetTimeAndBillingProjectDetailsByID(WorkflowExpression<string> division, WorkflowExpression<string> projectId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingProjectDetailsByIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingProjectDetailsByID", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionAction<TimeAndBillingProjectDetailsByIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeAndBillingRecentProjects))]
        public IBodyWorkflowAction<TimeAndBillingRecentProjectsResponse> GetTimeAndBillingRecentProjects([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeAndBillingRecentProjectsResponse> __BuildGetTimeAndBillingRecentProjects(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingRecentProjectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingRecentProjects", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeAndBillingRecentProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeCorrections))]
        public IBodyWorkflowAction<TimeCorrectionsResponse> GetTimeCorrections([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeCorrectionsResponse> __BuildGetTimeCorrections(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeCorrectionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildPutTimeCorrections))]
        public IBodyWorkflowAction<TimeCorrectionsResponse> PutTimeCorrections([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD, [WorkflowExpression] Func<string> timeCorrectionsiD = null, [WorkflowExpression] Func<string> timeCorrectionscreated = null, [WorkflowExpression] Func<string> timeCorrectionscreator = null, [WorkflowExpression] Func<string> timeCorrectionscreatorFullName = null, [WorkflowExpression] Func<int> timeCorrectionsdivision = null, [WorkflowExpression] Func<string> timeCorrectionsmodified = null, [WorkflowExpression] Func<string> timeCorrectionsmodifier = null, [WorkflowExpression] Func<string> timeCorrectionsmodifierFullName = null, [WorkflowExpression] Func<string> timeCorrectionsnotes = null, [WorkflowExpression] Func<string> timeCorrectionsoriginalEntryId = null, [WorkflowExpression] Func<double> timeCorrectionsquantity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeCorrectionsResponse> __BuildPutTimeCorrections(WorkflowExpression<string> division, WorkflowExpression<string> iD, WorkflowExpression<string> timeCorrectionsiD = null, WorkflowExpression<string> timeCorrectionscreated = null, WorkflowExpression<string> timeCorrectionscreator = null, WorkflowExpression<string> timeCorrectionscreatorFullName = null, WorkflowExpression<int> timeCorrectionsdivision = null, WorkflowExpression<string> timeCorrectionsmodified = null, WorkflowExpression<string> timeCorrectionsmodifier = null, WorkflowExpression<string> timeCorrectionsmodifierFullName = null, WorkflowExpression<string> timeCorrectionsnotes = null, WorkflowExpression<string> timeCorrectionsoriginalEntryId = null, WorkflowExpression<double> timeCorrectionsquantity = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(iD, nameof(iD), required: true);
            WorkflowExpression.Validate(timeCorrectionsiD, nameof(timeCorrectionsiD), required: false);
            WorkflowExpression.Validate(timeCorrectionscreated, nameof(timeCorrectionscreated), required: false);
            WorkflowExpression.Validate(timeCorrectionscreator, nameof(timeCorrectionscreator), required: false);
            WorkflowExpression.Validate(timeCorrectionscreatorFullName, nameof(timeCorrectionscreatorFullName), required: false);
            WorkflowExpression.Validate(timeCorrectionsdivision, nameof(timeCorrectionsdivision), required: false);
            WorkflowExpression.Validate(timeCorrectionsmodified, nameof(timeCorrectionsmodified), required: false);
            WorkflowExpression.Validate(timeCorrectionsmodifier, nameof(timeCorrectionsmodifier), required: false);
            WorkflowExpression.Validate(timeCorrectionsmodifierFullName, nameof(timeCorrectionsmodifierFullName), required: false);
            WorkflowExpression.Validate(timeCorrectionsnotes, nameof(timeCorrectionsnotes), required: false);
            WorkflowExpression.Validate(timeCorrectionsoriginalEntryId, nameof(timeCorrectionsoriginalEntryId), required: false);
            WorkflowExpression.Validate(timeCorrectionsquantity, nameof(timeCorrectionsquantity), required: false);
            return new DeferredBodyAction<TimeCorrectionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(iD);
                var timeCorrections = new JObject();
                var timeCorrectionspropCount = 0;
                if (timeCorrectionsiD != null)
                {
                    timeCorrections["ID"] = ExpressionConverter.ConvertO(timeCorrectionsiD);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreated != null)
                {
                    timeCorrections["Created"] = ExpressionConverter.ConvertO(timeCorrectionscreated);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreator != null)
                {
                    timeCorrections["Creator"] = ExpressionConverter.ConvertO(timeCorrectionscreator);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreatorFullName != null)
                {
                    timeCorrections["CreatorFullName"] = ExpressionConverter.ConvertO(timeCorrectionscreatorFullName);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsdivision != null)
                {
                    timeCorrections["Division"] = ExpressionConverter.ConvertO(timeCorrectionsdivision);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodified != null)
                {
                    timeCorrections["Modified"] = ExpressionConverter.ConvertO(timeCorrectionsmodified);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodifier != null)
                {
                    timeCorrections["Modifier"] = ExpressionConverter.ConvertO(timeCorrectionsmodifier);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodifierFullName != null)
                {
                    timeCorrections["ModifierFullName"] = ExpressionConverter.ConvertO(timeCorrectionsmodifierFullName);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsnotes != null)
                {
                    timeCorrections["Notes"] = ExpressionConverter.ConvertO(timeCorrectionsnotes);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsoriginalEntryId != null)
                {
                    timeCorrections["OriginalEntryId"] = ExpressionConverter.ConvertO(timeCorrectionsoriginalEntryId);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsquantity != null)
                {
                    timeCorrections["Quantity"] = ExpressionConverter.ConvertO(timeCorrectionsquantity);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionspropCount > 0)
                {
                    callPayload.Body = timeCorrections;
                }

                return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildPostTimeCorrections))]
        public IBodyWorkflowAction<TimeCorrectionsResponse> PostTimeCorrections([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> timeCorrectionsiD = null, [WorkflowExpression] Func<string> timeCorrectionscreated = null, [WorkflowExpression] Func<string> timeCorrectionscreator = null, [WorkflowExpression] Func<string> timeCorrectionscreatorFullName = null, [WorkflowExpression] Func<int> timeCorrectionsdivision = null, [WorkflowExpression] Func<string> timeCorrectionsmodified = null, [WorkflowExpression] Func<string> timeCorrectionsmodifier = null, [WorkflowExpression] Func<string> timeCorrectionsmodifierFullName = null, [WorkflowExpression] Func<string> timeCorrectionsnotes = null, [WorkflowExpression] Func<string> timeCorrectionsoriginalEntryId = null, [WorkflowExpression] Func<double> timeCorrectionsquantity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeCorrectionsResponse> __BuildPostTimeCorrections(WorkflowExpression<string> division, WorkflowExpression<string> timeCorrectionsiD = null, WorkflowExpression<string> timeCorrectionscreated = null, WorkflowExpression<string> timeCorrectionscreator = null, WorkflowExpression<string> timeCorrectionscreatorFullName = null, WorkflowExpression<int> timeCorrectionsdivision = null, WorkflowExpression<string> timeCorrectionsmodified = null, WorkflowExpression<string> timeCorrectionsmodifier = null, WorkflowExpression<string> timeCorrectionsmodifierFullName = null, WorkflowExpression<string> timeCorrectionsnotes = null, WorkflowExpression<string> timeCorrectionsoriginalEntryId = null, WorkflowExpression<double> timeCorrectionsquantity = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(timeCorrectionsiD, nameof(timeCorrectionsiD), required: false);
            WorkflowExpression.Validate(timeCorrectionscreated, nameof(timeCorrectionscreated), required: false);
            WorkflowExpression.Validate(timeCorrectionscreator, nameof(timeCorrectionscreator), required: false);
            WorkflowExpression.Validate(timeCorrectionscreatorFullName, nameof(timeCorrectionscreatorFullName), required: false);
            WorkflowExpression.Validate(timeCorrectionsdivision, nameof(timeCorrectionsdivision), required: false);
            WorkflowExpression.Validate(timeCorrectionsmodified, nameof(timeCorrectionsmodified), required: false);
            WorkflowExpression.Validate(timeCorrectionsmodifier, nameof(timeCorrectionsmodifier), required: false);
            WorkflowExpression.Validate(timeCorrectionsmodifierFullName, nameof(timeCorrectionsmodifierFullName), required: false);
            WorkflowExpression.Validate(timeCorrectionsnotes, nameof(timeCorrectionsnotes), required: false);
            WorkflowExpression.Validate(timeCorrectionsoriginalEntryId, nameof(timeCorrectionsoriginalEntryId), required: false);
            WorkflowExpression.Validate(timeCorrectionsquantity, nameof(timeCorrectionsquantity), required: false);
            return new DeferredBodyAction<TimeCorrectionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var timeCorrections = new JObject();
                var timeCorrectionspropCount = 0;
                if (timeCorrectionsiD != null)
                {
                    timeCorrections["ID"] = ExpressionConverter.ConvertO(timeCorrectionsiD);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreated != null)
                {
                    timeCorrections["Created"] = ExpressionConverter.ConvertO(timeCorrectionscreated);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreator != null)
                {
                    timeCorrections["Creator"] = ExpressionConverter.ConvertO(timeCorrectionscreator);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionscreatorFullName != null)
                {
                    timeCorrections["CreatorFullName"] = ExpressionConverter.ConvertO(timeCorrectionscreatorFullName);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsdivision != null)
                {
                    timeCorrections["Division"] = ExpressionConverter.ConvertO(timeCorrectionsdivision);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodified != null)
                {
                    timeCorrections["Modified"] = ExpressionConverter.ConvertO(timeCorrectionsmodified);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodifier != null)
                {
                    timeCorrections["Modifier"] = ExpressionConverter.ConvertO(timeCorrectionsmodifier);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsmodifierFullName != null)
                {
                    timeCorrections["ModifierFullName"] = ExpressionConverter.ConvertO(timeCorrectionsmodifierFullName);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsnotes != null)
                {
                    timeCorrections["Notes"] = ExpressionConverter.ConvertO(timeCorrectionsnotes);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsoriginalEntryId != null)
                {
                    timeCorrections["OriginalEntryId"] = ExpressionConverter.ConvertO(timeCorrectionsoriginalEntryId);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionsquantity != null)
                {
                    timeCorrections["Quantity"] = ExpressionConverter.ConvertO(timeCorrectionsquantity);
                    timeCorrectionspropCount++;
                }

                if (timeCorrectionspropCount > 0)
                {
                    callPayload.Body = timeCorrections;
                }

                return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTimeCorrections))]
        public IBodyWorkflowAction<TimeCorrectionsResponse> DeleteTimeCorrections([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeCorrectionsResponse> __BuildDeleteTimeCorrections(WorkflowExpression<string> division, WorkflowExpression<string> iD)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(iD, nameof(iD), required: true);
            return new DeferredBodyAction<TimeCorrectionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(iD);
                return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeTransactions))]
        public IBodyWorkflowAction<TimeTransactionsResponse> GetTimeTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeTransactionsResponse> __BuildGetTimeTransactions(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<TimeTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildPutTimeTransactions))]
        public IBodyWorkflowAction<TimeTransactionsResponse> PutTimeTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD, [WorkflowExpression] Func<string> timeTransactionsitem, [WorkflowExpression] Func<string> timeTransactionsproject, [WorkflowExpression] Func<double> timeTransactionsquantity, [WorkflowExpression] Func<string> timeTransactionsiD = null, [WorkflowExpression] Func<string> timeTransactionsaccount = null, [WorkflowExpression] Func<string> timeTransactionsaccountName = null, [WorkflowExpression] Func<string> timeTransactionsactivity = null, [WorkflowExpression] Func<string> timeTransactionsactivityDescription = null, [WorkflowExpression] Func<double> timeTransactionsamount = null, [WorkflowExpression] Func<double> timeTransactionsamountFC = null, [WorkflowExpression] Func<string> timeTransactionsattachment = null, [WorkflowExpression] Func<string> timeTransactionscreated = null, [WorkflowExpression] Func<string> timeTransactionscreator = null, [WorkflowExpression] Func<string> timeTransactionscreatorFullName = null, [WorkflowExpression] Func<string> timeTransactionscurrency = null, [WorkflowExpression] Func<string> timeTransactionsdate = null, [WorkflowExpression] Func<int> timeTransactionsdivision = null, [WorkflowExpression] Func<string> timeTransactionsdivisionDescription = null, [WorkflowExpression] Func<string> timeTransactionsemployee = null, [WorkflowExpression] Func<string> timeTransactionsendTime = null, [WorkflowExpression] Func<int> timeTransactionsentryNumber = null, [WorkflowExpression] Func<string> timeTransactionserrorText = null, [WorkflowExpression] Func<double> timeTransactionshourStatus = null, [WorkflowExpression] Func<string> timeTransactionsitemDescription = null, [WorkflowExpression] Func<bool> timeTransactionsitemDivisable = null, [WorkflowExpression] Func<string> timeTransactionsmodified = null, [WorkflowExpression] Func<string> timeTransactionsmodifier = null, [WorkflowExpression] Func<string> timeTransactionsmodifierFullName = null, [WorkflowExpression] Func<string> timeTransactionsnotes = null, [WorkflowExpression] Func<double> timeTransactionsprice = null, [WorkflowExpression] Func<double> timeTransactionspriceFC = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccount = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccountCode = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccountName = null, [WorkflowExpression] Func<string> timeTransactionsprojectCode = null, [WorkflowExpression] Func<string> timeTransactionsprojectDescription = null, [WorkflowExpression] Func<bool> timeTransactionsskipValidation = null, [WorkflowExpression] Func<string> timeTransactionsstartTime = null, [WorkflowExpression] Func<string> timeTransactionssubscription = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccount = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccountCode = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccountName = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionDescription = null, [WorkflowExpression] Func<int> timeTransactionssubscriptionNumber = null, [WorkflowExpression] Func<double> timeTransactionstype = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeTransactionsResponse> __BuildPutTimeTransactions(WorkflowExpression<string> division, WorkflowExpression<string> iD, WorkflowExpression<string> timeTransactionsitem, WorkflowExpression<string> timeTransactionsproject, WorkflowExpression<double> timeTransactionsquantity, WorkflowExpression<string> timeTransactionsiD = null, WorkflowExpression<string> timeTransactionsaccount = null, WorkflowExpression<string> timeTransactionsaccountName = null, WorkflowExpression<string> timeTransactionsactivity = null, WorkflowExpression<string> timeTransactionsactivityDescription = null, WorkflowExpression<double> timeTransactionsamount = null, WorkflowExpression<double> timeTransactionsamountFC = null, WorkflowExpression<string> timeTransactionsattachment = null, WorkflowExpression<string> timeTransactionscreated = null, WorkflowExpression<string> timeTransactionscreator = null, WorkflowExpression<string> timeTransactionscreatorFullName = null, WorkflowExpression<string> timeTransactionscurrency = null, WorkflowExpression<string> timeTransactionsdate = null, WorkflowExpression<int> timeTransactionsdivision = null, WorkflowExpression<string> timeTransactionsdivisionDescription = null, WorkflowExpression<string> timeTransactionsemployee = null, WorkflowExpression<string> timeTransactionsendTime = null, WorkflowExpression<int> timeTransactionsentryNumber = null, WorkflowExpression<string> timeTransactionserrorText = null, WorkflowExpression<double> timeTransactionshourStatus = null, WorkflowExpression<string> timeTransactionsitemDescription = null, WorkflowExpression<bool> timeTransactionsitemDivisable = null, WorkflowExpression<string> timeTransactionsmodified = null, WorkflowExpression<string> timeTransactionsmodifier = null, WorkflowExpression<string> timeTransactionsmodifierFullName = null, WorkflowExpression<string> timeTransactionsnotes = null, WorkflowExpression<double> timeTransactionsprice = null, WorkflowExpression<double> timeTransactionspriceFC = null, WorkflowExpression<string> timeTransactionsprojectAccount = null, WorkflowExpression<string> timeTransactionsprojectAccountCode = null, WorkflowExpression<string> timeTransactionsprojectAccountName = null, WorkflowExpression<string> timeTransactionsprojectCode = null, WorkflowExpression<string> timeTransactionsprojectDescription = null, WorkflowExpression<bool> timeTransactionsskipValidation = null, WorkflowExpression<string> timeTransactionsstartTime = null, WorkflowExpression<string> timeTransactionssubscription = null, WorkflowExpression<string> timeTransactionssubscriptionAccount = null, WorkflowExpression<string> timeTransactionssubscriptionAccountCode = null, WorkflowExpression<string> timeTransactionssubscriptionAccountName = null, WorkflowExpression<string> timeTransactionssubscriptionDescription = null, WorkflowExpression<int> timeTransactionssubscriptionNumber = null, WorkflowExpression<double> timeTransactionstype = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(iD, nameof(iD), required: true);
            WorkflowExpression.Validate(timeTransactionsitem, nameof(timeTransactionsitem), required: true);
            WorkflowExpression.Validate(timeTransactionsproject, nameof(timeTransactionsproject), required: true);
            WorkflowExpression.Validate(timeTransactionsquantity, nameof(timeTransactionsquantity), required: true);
            WorkflowExpression.Validate(timeTransactionsiD, nameof(timeTransactionsiD), required: false);
            WorkflowExpression.Validate(timeTransactionsaccount, nameof(timeTransactionsaccount), required: false);
            WorkflowExpression.Validate(timeTransactionsaccountName, nameof(timeTransactionsaccountName), required: false);
            WorkflowExpression.Validate(timeTransactionsactivity, nameof(timeTransactionsactivity), required: false);
            WorkflowExpression.Validate(timeTransactionsactivityDescription, nameof(timeTransactionsactivityDescription), required: false);
            WorkflowExpression.Validate(timeTransactionsamount, nameof(timeTransactionsamount), required: false);
            WorkflowExpression.Validate(timeTransactionsamountFC, nameof(timeTransactionsamountFC), required: false);
            WorkflowExpression.Validate(timeTransactionsattachment, nameof(timeTransactionsattachment), required: false);
            WorkflowExpression.Validate(timeTransactionscreated, nameof(timeTransactionscreated), required: false);
            WorkflowExpression.Validate(timeTransactionscreator, nameof(timeTransactionscreator), required: false);
            WorkflowExpression.Validate(timeTransactionscreatorFullName, nameof(timeTransactionscreatorFullName), required: false);
            WorkflowExpression.Validate(timeTransactionscurrency, nameof(timeTransactionscurrency), required: false);
            WorkflowExpression.Validate(timeTransactionsdate, nameof(timeTransactionsdate), required: false);
            WorkflowExpression.Validate(timeTransactionsdivision, nameof(timeTransactionsdivision), required: false);
            WorkflowExpression.Validate(timeTransactionsdivisionDescription, nameof(timeTransactionsdivisionDescription), required: false);
            WorkflowExpression.Validate(timeTransactionsemployee, nameof(timeTransactionsemployee), required: false);
            WorkflowExpression.Validate(timeTransactionsendTime, nameof(timeTransactionsendTime), required: false);
            WorkflowExpression.Validate(timeTransactionsentryNumber, nameof(timeTransactionsentryNumber), required: false);
            WorkflowExpression.Validate(timeTransactionserrorText, nameof(timeTransactionserrorText), required: false);
            WorkflowExpression.Validate(timeTransactionshourStatus, nameof(timeTransactionshourStatus), required: false);
            WorkflowExpression.Validate(timeTransactionsitemDescription, nameof(timeTransactionsitemDescription), required: false);
            WorkflowExpression.Validate(timeTransactionsitemDivisable, nameof(timeTransactionsitemDivisable), required: false);
            WorkflowExpression.Validate(timeTransactionsmodified, nameof(timeTransactionsmodified), required: false);
            WorkflowExpression.Validate(timeTransactionsmodifier, nameof(timeTransactionsmodifier), required: false);
            WorkflowExpression.Validate(timeTransactionsmodifierFullName, nameof(timeTransactionsmodifierFullName), required: false);
            WorkflowExpression.Validate(timeTransactionsnotes, nameof(timeTransactionsnotes), required: false);
            WorkflowExpression.Validate(timeTransactionsprice, nameof(timeTransactionsprice), required: false);
            WorkflowExpression.Validate(timeTransactionspriceFC, nameof(timeTransactionspriceFC), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectAccount, nameof(timeTransactionsprojectAccount), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectAccountCode, nameof(timeTransactionsprojectAccountCode), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectAccountName, nameof(timeTransactionsprojectAccountName), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectCode, nameof(timeTransactionsprojectCode), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectDescription, nameof(timeTransactionsprojectDescription), required: false);
            WorkflowExpression.Validate(timeTransactionsskipValidation, nameof(timeTransactionsskipValidation), required: false);
            WorkflowExpression.Validate(timeTransactionsstartTime, nameof(timeTransactionsstartTime), required: false);
            WorkflowExpression.Validate(timeTransactionssubscription, nameof(timeTransactionssubscription), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionAccount, nameof(timeTransactionssubscriptionAccount), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionAccountCode, nameof(timeTransactionssubscriptionAccountCode), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionAccountName, nameof(timeTransactionssubscriptionAccountName), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionDescription, nameof(timeTransactionssubscriptionDescription), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionNumber, nameof(timeTransactionssubscriptionNumber), required: false);
            WorkflowExpression.Validate(timeTransactionstype, nameof(timeTransactionstype), required: false);
            return new DeferredBodyAction<TimeTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(iD);
                var timeTransactions = new JObject();
                var timeTransactionspropCount = 0;
                if (timeTransactionsiD != null)
                {
                    timeTransactions["ID"] = ExpressionConverter.ConvertO(timeTransactionsiD);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsaccount != null)
                {
                    timeTransactions["Account"] = ExpressionConverter.ConvertO(timeTransactionsaccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsaccountName != null)
                {
                    timeTransactions["AccountName"] = ExpressionConverter.ConvertO(timeTransactionsaccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsactivity != null)
                {
                    timeTransactions["Activity"] = ExpressionConverter.ConvertO(timeTransactionsactivity);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsactivityDescription != null)
                {
                    timeTransactions["ActivityDescription"] = ExpressionConverter.ConvertO(timeTransactionsactivityDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsamount != null)
                {
                    timeTransactions["Amount"] = ExpressionConverter.ConvertO(timeTransactionsamount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsamountFC != null)
                {
                    timeTransactions["AmountFC"] = ExpressionConverter.ConvertO(timeTransactionsamountFC);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsattachment != null)
                {
                    timeTransactions["Attachment"] = ExpressionConverter.ConvertO(timeTransactionsattachment);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreated != null)
                {
                    timeTransactions["Created"] = ExpressionConverter.ConvertO(timeTransactionscreated);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreator != null)
                {
                    timeTransactions["Creator"] = ExpressionConverter.ConvertO(timeTransactionscreator);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreatorFullName != null)
                {
                    timeTransactions["CreatorFullName"] = ExpressionConverter.ConvertO(timeTransactionscreatorFullName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscurrency != null)
                {
                    timeTransactions["Currency"] = ExpressionConverter.ConvertO(timeTransactionscurrency);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdate != null)
                {
                    timeTransactions["Date"] = ExpressionConverter.ConvertO(timeTransactionsdate);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdivision != null)
                {
                    timeTransactions["Division"] = ExpressionConverter.ConvertO(timeTransactionsdivision);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdivisionDescription != null)
                {
                    timeTransactions["DivisionDescription"] = ExpressionConverter.ConvertO(timeTransactionsdivisionDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsemployee != null)
                {
                    timeTransactions["Employee"] = ExpressionConverter.ConvertO(timeTransactionsemployee);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsendTime != null)
                {
                    timeTransactions["EndTime"] = ExpressionConverter.ConvertO(timeTransactionsendTime);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsentryNumber != null)
                {
                    timeTransactions["EntryNumber"] = ExpressionConverter.ConvertO(timeTransactionsentryNumber);
                    timeTransactionspropCount++;
                }

                if (timeTransactionserrorText != null)
                {
                    timeTransactions["ErrorText"] = ExpressionConverter.ConvertO(timeTransactionserrorText);
                    timeTransactionspropCount++;
                }

                if (timeTransactionshourStatus != null)
                {
                    timeTransactions["HourStatus"] = ExpressionConverter.ConvertO(timeTransactionshourStatus);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Item"] = ExpressionConverter.ConvertO(timeTransactionsitem);
                if (timeTransactionsitemDescription != null)
                {
                    timeTransactions["ItemDescription"] = ExpressionConverter.ConvertO(timeTransactionsitemDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsitemDivisable != null)
                {
                    timeTransactions["ItemDivisable"] = ExpressionConverter.ConvertO(timeTransactionsitemDivisable);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodified != null)
                {
                    timeTransactions["Modified"] = ExpressionConverter.ConvertO(timeTransactionsmodified);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodifier != null)
                {
                    timeTransactions["Modifier"] = ExpressionConverter.ConvertO(timeTransactionsmodifier);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodifierFullName != null)
                {
                    timeTransactions["ModifierFullName"] = ExpressionConverter.ConvertO(timeTransactionsmodifierFullName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsnotes != null)
                {
                    timeTransactions["Notes"] = ExpressionConverter.ConvertO(timeTransactionsnotes);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprice != null)
                {
                    timeTransactions["Price"] = ExpressionConverter.ConvertO(timeTransactionsprice);
                    timeTransactionspropCount++;
                }

                if (timeTransactionspriceFC != null)
                {
                    timeTransactions["PriceFC"] = ExpressionConverter.ConvertO(timeTransactionspriceFC);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Project"] = ExpressionConverter.ConvertO(timeTransactionsproject);
                if (timeTransactionsprojectAccount != null)
                {
                    timeTransactions["ProjectAccount"] = ExpressionConverter.ConvertO(timeTransactionsprojectAccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectAccountCode != null)
                {
                    timeTransactions["ProjectAccountCode"] = ExpressionConverter.ConvertO(timeTransactionsprojectAccountCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectAccountName != null)
                {
                    timeTransactions["ProjectAccountName"] = ExpressionConverter.ConvertO(timeTransactionsprojectAccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectCode != null)
                {
                    timeTransactions["ProjectCode"] = ExpressionConverter.ConvertO(timeTransactionsprojectCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectDescription != null)
                {
                    timeTransactions["ProjectDescription"] = ExpressionConverter.ConvertO(timeTransactionsprojectDescription);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Quantity"] = ExpressionConverter.ConvertO(timeTransactionsquantity);
                if (timeTransactionsskipValidation != null)
                {
                    timeTransactions["SkipValidation"] = ExpressionConverter.ConvertO(timeTransactionsskipValidation);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsstartTime != null)
                {
                    timeTransactions["StartTime"] = ExpressionConverter.ConvertO(timeTransactionsstartTime);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscription != null)
                {
                    timeTransactions["Subscription"] = ExpressionConverter.ConvertO(timeTransactionssubscription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccount != null)
                {
                    timeTransactions["SubscriptionAccount"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionAccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccountCode != null)
                {
                    timeTransactions["SubscriptionAccountCode"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionAccountCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccountName != null)
                {
                    timeTransactions["SubscriptionAccountName"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionAccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionDescription != null)
                {
                    timeTransactions["SubscriptionDescription"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionNumber != null)
                {
                    timeTransactions["SubscriptionNumber"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionNumber);
                    timeTransactionspropCount++;
                }

                if (timeTransactionstype != null)
                {
                    timeTransactions["Type"] = ExpressionConverter.ConvertO(timeTransactionstype);
                    timeTransactionspropCount++;
                }

                if (timeTransactionspropCount > 0)
                {
                    callPayload.Body = timeTransactions;
                }

                return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildPostTimeTransactions))]
        public IBodyWorkflowAction<TimeTransactionsResponse> PostTimeTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> timeTransactionsitem, [WorkflowExpression] Func<string> timeTransactionsproject, [WorkflowExpression] Func<double> timeTransactionsquantity, [WorkflowExpression] Func<string> timeTransactionsiD = null, [WorkflowExpression] Func<string> timeTransactionsaccount = null, [WorkflowExpression] Func<string> timeTransactionsaccountName = null, [WorkflowExpression] Func<string> timeTransactionsactivity = null, [WorkflowExpression] Func<string> timeTransactionsactivityDescription = null, [WorkflowExpression] Func<double> timeTransactionsamount = null, [WorkflowExpression] Func<double> timeTransactionsamountFC = null, [WorkflowExpression] Func<string> timeTransactionsattachment = null, [WorkflowExpression] Func<string> timeTransactionscreated = null, [WorkflowExpression] Func<string> timeTransactionscreator = null, [WorkflowExpression] Func<string> timeTransactionscreatorFullName = null, [WorkflowExpression] Func<string> timeTransactionscurrency = null, [WorkflowExpression] Func<string> timeTransactionsdate = null, [WorkflowExpression] Func<int> timeTransactionsdivision = null, [WorkflowExpression] Func<string> timeTransactionsdivisionDescription = null, [WorkflowExpression] Func<string> timeTransactionsemployee = null, [WorkflowExpression] Func<string> timeTransactionsendTime = null, [WorkflowExpression] Func<int> timeTransactionsentryNumber = null, [WorkflowExpression] Func<string> timeTransactionserrorText = null, [WorkflowExpression] Func<double> timeTransactionshourStatus = null, [WorkflowExpression] Func<string> timeTransactionsitemDescription = null, [WorkflowExpression] Func<bool> timeTransactionsitemDivisable = null, [WorkflowExpression] Func<string> timeTransactionsmodified = null, [WorkflowExpression] Func<string> timeTransactionsmodifier = null, [WorkflowExpression] Func<string> timeTransactionsmodifierFullName = null, [WorkflowExpression] Func<string> timeTransactionsnotes = null, [WorkflowExpression] Func<double> timeTransactionsprice = null, [WorkflowExpression] Func<double> timeTransactionspriceFC = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccount = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccountCode = null, [WorkflowExpression] Func<string> timeTransactionsprojectAccountName = null, [WorkflowExpression] Func<string> timeTransactionsprojectCode = null, [WorkflowExpression] Func<string> timeTransactionsprojectDescription = null, [WorkflowExpression] Func<bool> timeTransactionsskipValidation = null, [WorkflowExpression] Func<string> timeTransactionsstartTime = null, [WorkflowExpression] Func<string> timeTransactionssubscription = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccount = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccountCode = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionAccountName = null, [WorkflowExpression] Func<string> timeTransactionssubscriptionDescription = null, [WorkflowExpression] Func<int> timeTransactionssubscriptionNumber = null, [WorkflowExpression] Func<double> timeTransactionstype = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeTransactionsResponse> __BuildPostTimeTransactions(WorkflowExpression<string> division, WorkflowExpression<string> timeTransactionsitem, WorkflowExpression<string> timeTransactionsproject, WorkflowExpression<double> timeTransactionsquantity, WorkflowExpression<string> timeTransactionsiD = null, WorkflowExpression<string> timeTransactionsaccount = null, WorkflowExpression<string> timeTransactionsaccountName = null, WorkflowExpression<string> timeTransactionsactivity = null, WorkflowExpression<string> timeTransactionsactivityDescription = null, WorkflowExpression<double> timeTransactionsamount = null, WorkflowExpression<double> timeTransactionsamountFC = null, WorkflowExpression<string> timeTransactionsattachment = null, WorkflowExpression<string> timeTransactionscreated = null, WorkflowExpression<string> timeTransactionscreator = null, WorkflowExpression<string> timeTransactionscreatorFullName = null, WorkflowExpression<string> timeTransactionscurrency = null, WorkflowExpression<string> timeTransactionsdate = null, WorkflowExpression<int> timeTransactionsdivision = null, WorkflowExpression<string> timeTransactionsdivisionDescription = null, WorkflowExpression<string> timeTransactionsemployee = null, WorkflowExpression<string> timeTransactionsendTime = null, WorkflowExpression<int> timeTransactionsentryNumber = null, WorkflowExpression<string> timeTransactionserrorText = null, WorkflowExpression<double> timeTransactionshourStatus = null, WorkflowExpression<string> timeTransactionsitemDescription = null, WorkflowExpression<bool> timeTransactionsitemDivisable = null, WorkflowExpression<string> timeTransactionsmodified = null, WorkflowExpression<string> timeTransactionsmodifier = null, WorkflowExpression<string> timeTransactionsmodifierFullName = null, WorkflowExpression<string> timeTransactionsnotes = null, WorkflowExpression<double> timeTransactionsprice = null, WorkflowExpression<double> timeTransactionspriceFC = null, WorkflowExpression<string> timeTransactionsprojectAccount = null, WorkflowExpression<string> timeTransactionsprojectAccountCode = null, WorkflowExpression<string> timeTransactionsprojectAccountName = null, WorkflowExpression<string> timeTransactionsprojectCode = null, WorkflowExpression<string> timeTransactionsprojectDescription = null, WorkflowExpression<bool> timeTransactionsskipValidation = null, WorkflowExpression<string> timeTransactionsstartTime = null, WorkflowExpression<string> timeTransactionssubscription = null, WorkflowExpression<string> timeTransactionssubscriptionAccount = null, WorkflowExpression<string> timeTransactionssubscriptionAccountCode = null, WorkflowExpression<string> timeTransactionssubscriptionAccountName = null, WorkflowExpression<string> timeTransactionssubscriptionDescription = null, WorkflowExpression<int> timeTransactionssubscriptionNumber = null, WorkflowExpression<double> timeTransactionstype = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(timeTransactionsitem, nameof(timeTransactionsitem), required: true);
            WorkflowExpression.Validate(timeTransactionsproject, nameof(timeTransactionsproject), required: true);
            WorkflowExpression.Validate(timeTransactionsquantity, nameof(timeTransactionsquantity), required: true);
            WorkflowExpression.Validate(timeTransactionsiD, nameof(timeTransactionsiD), required: false);
            WorkflowExpression.Validate(timeTransactionsaccount, nameof(timeTransactionsaccount), required: false);
            WorkflowExpression.Validate(timeTransactionsaccountName, nameof(timeTransactionsaccountName), required: false);
            WorkflowExpression.Validate(timeTransactionsactivity, nameof(timeTransactionsactivity), required: false);
            WorkflowExpression.Validate(timeTransactionsactivityDescription, nameof(timeTransactionsactivityDescription), required: false);
            WorkflowExpression.Validate(timeTransactionsamount, nameof(timeTransactionsamount), required: false);
            WorkflowExpression.Validate(timeTransactionsamountFC, nameof(timeTransactionsamountFC), required: false);
            WorkflowExpression.Validate(timeTransactionsattachment, nameof(timeTransactionsattachment), required: false);
            WorkflowExpression.Validate(timeTransactionscreated, nameof(timeTransactionscreated), required: false);
            WorkflowExpression.Validate(timeTransactionscreator, nameof(timeTransactionscreator), required: false);
            WorkflowExpression.Validate(timeTransactionscreatorFullName, nameof(timeTransactionscreatorFullName), required: false);
            WorkflowExpression.Validate(timeTransactionscurrency, nameof(timeTransactionscurrency), required: false);
            WorkflowExpression.Validate(timeTransactionsdate, nameof(timeTransactionsdate), required: false);
            WorkflowExpression.Validate(timeTransactionsdivision, nameof(timeTransactionsdivision), required: false);
            WorkflowExpression.Validate(timeTransactionsdivisionDescription, nameof(timeTransactionsdivisionDescription), required: false);
            WorkflowExpression.Validate(timeTransactionsemployee, nameof(timeTransactionsemployee), required: false);
            WorkflowExpression.Validate(timeTransactionsendTime, nameof(timeTransactionsendTime), required: false);
            WorkflowExpression.Validate(timeTransactionsentryNumber, nameof(timeTransactionsentryNumber), required: false);
            WorkflowExpression.Validate(timeTransactionserrorText, nameof(timeTransactionserrorText), required: false);
            WorkflowExpression.Validate(timeTransactionshourStatus, nameof(timeTransactionshourStatus), required: false);
            WorkflowExpression.Validate(timeTransactionsitemDescription, nameof(timeTransactionsitemDescription), required: false);
            WorkflowExpression.Validate(timeTransactionsitemDivisable, nameof(timeTransactionsitemDivisable), required: false);
            WorkflowExpression.Validate(timeTransactionsmodified, nameof(timeTransactionsmodified), required: false);
            WorkflowExpression.Validate(timeTransactionsmodifier, nameof(timeTransactionsmodifier), required: false);
            WorkflowExpression.Validate(timeTransactionsmodifierFullName, nameof(timeTransactionsmodifierFullName), required: false);
            WorkflowExpression.Validate(timeTransactionsnotes, nameof(timeTransactionsnotes), required: false);
            WorkflowExpression.Validate(timeTransactionsprice, nameof(timeTransactionsprice), required: false);
            WorkflowExpression.Validate(timeTransactionspriceFC, nameof(timeTransactionspriceFC), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectAccount, nameof(timeTransactionsprojectAccount), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectAccountCode, nameof(timeTransactionsprojectAccountCode), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectAccountName, nameof(timeTransactionsprojectAccountName), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectCode, nameof(timeTransactionsprojectCode), required: false);
            WorkflowExpression.Validate(timeTransactionsprojectDescription, nameof(timeTransactionsprojectDescription), required: false);
            WorkflowExpression.Validate(timeTransactionsskipValidation, nameof(timeTransactionsskipValidation), required: false);
            WorkflowExpression.Validate(timeTransactionsstartTime, nameof(timeTransactionsstartTime), required: false);
            WorkflowExpression.Validate(timeTransactionssubscription, nameof(timeTransactionssubscription), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionAccount, nameof(timeTransactionssubscriptionAccount), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionAccountCode, nameof(timeTransactionssubscriptionAccountCode), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionAccountName, nameof(timeTransactionssubscriptionAccountName), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionDescription, nameof(timeTransactionssubscriptionDescription), required: false);
            WorkflowExpression.Validate(timeTransactionssubscriptionNumber, nameof(timeTransactionssubscriptionNumber), required: false);
            WorkflowExpression.Validate(timeTransactionstype, nameof(timeTransactionstype), required: false);
            return new DeferredBodyAction<TimeTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var timeTransactions = new JObject();
                var timeTransactionspropCount = 0;
                if (timeTransactionsiD != null)
                {
                    timeTransactions["ID"] = ExpressionConverter.ConvertO(timeTransactionsiD);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsaccount != null)
                {
                    timeTransactions["Account"] = ExpressionConverter.ConvertO(timeTransactionsaccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsaccountName != null)
                {
                    timeTransactions["AccountName"] = ExpressionConverter.ConvertO(timeTransactionsaccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsactivity != null)
                {
                    timeTransactions["Activity"] = ExpressionConverter.ConvertO(timeTransactionsactivity);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsactivityDescription != null)
                {
                    timeTransactions["ActivityDescription"] = ExpressionConverter.ConvertO(timeTransactionsactivityDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsamount != null)
                {
                    timeTransactions["Amount"] = ExpressionConverter.ConvertO(timeTransactionsamount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsamountFC != null)
                {
                    timeTransactions["AmountFC"] = ExpressionConverter.ConvertO(timeTransactionsamountFC);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsattachment != null)
                {
                    timeTransactions["Attachment"] = ExpressionConverter.ConvertO(timeTransactionsattachment);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreated != null)
                {
                    timeTransactions["Created"] = ExpressionConverter.ConvertO(timeTransactionscreated);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreator != null)
                {
                    timeTransactions["Creator"] = ExpressionConverter.ConvertO(timeTransactionscreator);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscreatorFullName != null)
                {
                    timeTransactions["CreatorFullName"] = ExpressionConverter.ConvertO(timeTransactionscreatorFullName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionscurrency != null)
                {
                    timeTransactions["Currency"] = ExpressionConverter.ConvertO(timeTransactionscurrency);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdate != null)
                {
                    timeTransactions["Date"] = ExpressionConverter.ConvertO(timeTransactionsdate);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdivision != null)
                {
                    timeTransactions["Division"] = ExpressionConverter.ConvertO(timeTransactionsdivision);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsdivisionDescription != null)
                {
                    timeTransactions["DivisionDescription"] = ExpressionConverter.ConvertO(timeTransactionsdivisionDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsemployee != null)
                {
                    timeTransactions["Employee"] = ExpressionConverter.ConvertO(timeTransactionsemployee);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsendTime != null)
                {
                    timeTransactions["EndTime"] = ExpressionConverter.ConvertO(timeTransactionsendTime);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsentryNumber != null)
                {
                    timeTransactions["EntryNumber"] = ExpressionConverter.ConvertO(timeTransactionsentryNumber);
                    timeTransactionspropCount++;
                }

                if (timeTransactionserrorText != null)
                {
                    timeTransactions["ErrorText"] = ExpressionConverter.ConvertO(timeTransactionserrorText);
                    timeTransactionspropCount++;
                }

                if (timeTransactionshourStatus != null)
                {
                    timeTransactions["HourStatus"] = ExpressionConverter.ConvertO(timeTransactionshourStatus);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Item"] = ExpressionConverter.ConvertO(timeTransactionsitem);
                if (timeTransactionsitemDescription != null)
                {
                    timeTransactions["ItemDescription"] = ExpressionConverter.ConvertO(timeTransactionsitemDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsitemDivisable != null)
                {
                    timeTransactions["ItemDivisable"] = ExpressionConverter.ConvertO(timeTransactionsitemDivisable);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodified != null)
                {
                    timeTransactions["Modified"] = ExpressionConverter.ConvertO(timeTransactionsmodified);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodifier != null)
                {
                    timeTransactions["Modifier"] = ExpressionConverter.ConvertO(timeTransactionsmodifier);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsmodifierFullName != null)
                {
                    timeTransactions["ModifierFullName"] = ExpressionConverter.ConvertO(timeTransactionsmodifierFullName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsnotes != null)
                {
                    timeTransactions["Notes"] = ExpressionConverter.ConvertO(timeTransactionsnotes);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprice != null)
                {
                    timeTransactions["Price"] = ExpressionConverter.ConvertO(timeTransactionsprice);
                    timeTransactionspropCount++;
                }

                if (timeTransactionspriceFC != null)
                {
                    timeTransactions["PriceFC"] = ExpressionConverter.ConvertO(timeTransactionspriceFC);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Project"] = ExpressionConverter.ConvertO(timeTransactionsproject);
                if (timeTransactionsprojectAccount != null)
                {
                    timeTransactions["ProjectAccount"] = ExpressionConverter.ConvertO(timeTransactionsprojectAccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectAccountCode != null)
                {
                    timeTransactions["ProjectAccountCode"] = ExpressionConverter.ConvertO(timeTransactionsprojectAccountCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectAccountName != null)
                {
                    timeTransactions["ProjectAccountName"] = ExpressionConverter.ConvertO(timeTransactionsprojectAccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectCode != null)
                {
                    timeTransactions["ProjectCode"] = ExpressionConverter.ConvertO(timeTransactionsprojectCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsprojectDescription != null)
                {
                    timeTransactions["ProjectDescription"] = ExpressionConverter.ConvertO(timeTransactionsprojectDescription);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Quantity"] = ExpressionConverter.ConvertO(timeTransactionsquantity);
                if (timeTransactionsskipValidation != null)
                {
                    timeTransactions["SkipValidation"] = ExpressionConverter.ConvertO(timeTransactionsskipValidation);
                    timeTransactionspropCount++;
                }

                if (timeTransactionsstartTime != null)
                {
                    timeTransactions["StartTime"] = ExpressionConverter.ConvertO(timeTransactionsstartTime);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscription != null)
                {
                    timeTransactions["Subscription"] = ExpressionConverter.ConvertO(timeTransactionssubscription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccount != null)
                {
                    timeTransactions["SubscriptionAccount"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionAccount);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccountCode != null)
                {
                    timeTransactions["SubscriptionAccountCode"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionAccountCode);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionAccountName != null)
                {
                    timeTransactions["SubscriptionAccountName"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionAccountName);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionDescription != null)
                {
                    timeTransactions["SubscriptionDescription"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionDescription);
                    timeTransactionspropCount++;
                }

                if (timeTransactionssubscriptionNumber != null)
                {
                    timeTransactions["SubscriptionNumber"] = ExpressionConverter.ConvertO(timeTransactionssubscriptionNumber);
                    timeTransactionspropCount++;
                }

                if (timeTransactionstype != null)
                {
                    timeTransactions["Type"] = ExpressionConverter.ConvertO(timeTransactionstype);
                    timeTransactionspropCount++;
                }

                if (timeTransactionspropCount > 0)
                {
                    callPayload.Body = timeTransactions;
                }

                return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTimeTransactions))]
        public IBodyWorkflowAction<TimeTransactionsResponse> DeleteTimeTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> iD)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeTransactionsResponse> __BuildDeleteTimeTransactions(WorkflowExpression<string> division, WorkflowExpression<string> iD)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(iD, nameof(iD), required: true);
            return new DeferredBodyAction<TimeTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(iD);
                return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjectTimeCostTransactions))]
        public IBodyWorkflowAction<ProjectTimeCostTransactionsResponse> GetProjectTimeCostTransactions([WorkflowExpression] Func<string> division, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectTimeCostTransactionsResponse> __BuildGetProjectTimeCostTransactions(WorkflowExpression<string> division, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(division, nameof(division), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ProjectTimeCostTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sync/Project/TimeCostTransactions", ExpressionConverter.ConvertWithUrlEncoding(division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ProjectTimeCostTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [WorkflowExpressionFactory(nameof(__BuildGetMe))]
        public IBodyWorkflowAction<MeResponse> GetMe([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MeResponse> __BuildGetMe(WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<MeResponse>(() =>
            {
                var apiCallPath = "/current/Me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<MeResponse>(callPayload);
            });
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