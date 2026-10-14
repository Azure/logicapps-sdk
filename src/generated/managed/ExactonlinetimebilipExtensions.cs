//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Exactonlinetimebilip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ExactonlinetimebilipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<DivisionsResponse> GetDivisions(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<DivisionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/hrm/Divisions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<DivisionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<EmploymentInternalRatesResponse> GetEmploymentInternalRates(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<EmploymentInternalRatesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/EmploymentInternalRates", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<EmploymentInternalRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourCostTypesResponse> GetHourCostTypes(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourCostTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourCostTypes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<HourCostTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryActivitiesByProjectResponse> GetHourEntryActivitiesByProject(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryActivitiesByProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryActivitiesByProject", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<HourEntryActivitiesByProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentAccountsResponse> GetHourEntryRecentAccounts(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentAccountsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentAccounts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<HourEntryRecentAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentAccountsByProjectResponse> GetHourEntryRecentAccountsByProject(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentAccountsByProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentAccountsByProject", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<HourEntryRecentAccountsByProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentHourTypesResponse> GetHourEntryRecentHourTypes(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentHourTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentHourTypes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<HourEntryRecentHourTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentHourTypesByProjectResponse> GetHourEntryRecentHourTypesByProject(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentHourTypesByProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentHourTypesByProject", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<HourEntryRecentHourTypesByProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourEntryRecentProjectsResponse> GetHourEntryRecentProjects(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourEntryRecentProjectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourEntryRecentProjects", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<HourEntryRecentProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HoursByDateResponse> GetHoursByDate(Expression<Func<string>> checkDate, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_checkDate = checkDate == null ? null : WorkflowExpression.Compile(checkDate);
            WorkflowExpression.Validate(__workflow_checkDate, nameof(checkDate), required: true);
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HoursByDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HoursByDate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["checkDate"] = ExpressionConverter.Convert(__workflow_checkDate);
                return new ApiConnectionAction<HoursByDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HoursByIdResponse> GetHoursById(Expression<Func<string>> division, Expression<Func<string>> entryId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_entryId = entryId == null ? null : WorkflowExpression.Compile(entryId);
            WorkflowExpression.Validate(__workflow_entryId, nameof(entryId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HoursByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HoursById", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["entryId"] = ExpressionConverter.Convert(__workflow_entryId);
                return new ApiConnectionAction<HoursByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesResponse> GetHourTypes(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<HourTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesByDateResponse> GetHourTypesByDate(Expression<Func<string>> checkDate, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_checkDate = checkDate == null ? null : WorkflowExpression.Compile(checkDate);
            WorkflowExpression.Validate(__workflow_checkDate, nameof(checkDate), required: true);
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourTypesByDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypesByDate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["checkDate"] = ExpressionConverter.Convert(__workflow_checkDate);
                return new ApiConnectionAction<HourTypesByDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<HourTypesByProjectAndDateResponse> GetHourTypesByProjectAndDate(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<HourTypesByProjectAndDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/HourTypesByProjectAndDate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<HourTypesByProjectAndDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> GetProjectRestrictionRebillings(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ProjectRestrictionRebillingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> PutProjectRestrictionRebillings(Expression<Func<string>> division, Expression<Func<string>> iD, Expression<Func<string>> projectRestrictionRebillingscostTypeRebill, Expression<Func<string>> projectRestrictionRebillingsproject, Expression<Func<string>> projectRestrictionRebillingsiD = null, Expression<Func<string>> projectRestrictionRebillingscostTypeRebillCode = null, Expression<Func<string>> projectRestrictionRebillingscostTypeRebillDescription = null, Expression<Func<string>> projectRestrictionRebillingscreated = null, Expression<Func<string>> projectRestrictionRebillingscreator = null, Expression<Func<string>> projectRestrictionRebillingscreatorFullName = null, Expression<Func<int>> projectRestrictionRebillingsdivision = null, Expression<Func<string>> projectRestrictionRebillingsmodified = null, Expression<Func<string>> projectRestrictionRebillingsmodifier = null, Expression<Func<string>> projectRestrictionRebillingsmodifierFullName = null, Expression<Func<string>> projectRestrictionRebillingsprojectCode = null, Expression<Func<string>> projectRestrictionRebillingsprojectDescription = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_iD = iD == null ? null : WorkflowExpression.Compile(iD);
            WorkflowExpression.Validate(__workflow_iD, nameof(iD), required: true);
            var __workflow_projectRestrictionRebillingscostTypeRebill = projectRestrictionRebillingscostTypeRebill == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscostTypeRebill);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscostTypeRebill, nameof(projectRestrictionRebillingscostTypeRebill), required: true);
            var __workflow_projectRestrictionRebillingsproject = projectRestrictionRebillingsproject == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsproject);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsproject, nameof(projectRestrictionRebillingsproject), required: true);
            var __workflow_projectRestrictionRebillingsiD = projectRestrictionRebillingsiD == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsiD);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsiD, nameof(projectRestrictionRebillingsiD), required: false);
            var __workflow_projectRestrictionRebillingscostTypeRebillCode = projectRestrictionRebillingscostTypeRebillCode == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscostTypeRebillCode);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscostTypeRebillCode, nameof(projectRestrictionRebillingscostTypeRebillCode), required: false);
            var __workflow_projectRestrictionRebillingscostTypeRebillDescription = projectRestrictionRebillingscostTypeRebillDescription == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscostTypeRebillDescription);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscostTypeRebillDescription, nameof(projectRestrictionRebillingscostTypeRebillDescription), required: false);
            var __workflow_projectRestrictionRebillingscreated = projectRestrictionRebillingscreated == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscreated);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscreated, nameof(projectRestrictionRebillingscreated), required: false);
            var __workflow_projectRestrictionRebillingscreator = projectRestrictionRebillingscreator == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscreator);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscreator, nameof(projectRestrictionRebillingscreator), required: false);
            var __workflow_projectRestrictionRebillingscreatorFullName = projectRestrictionRebillingscreatorFullName == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscreatorFullName);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscreatorFullName, nameof(projectRestrictionRebillingscreatorFullName), required: false);
            var __workflow_projectRestrictionRebillingsdivision = projectRestrictionRebillingsdivision == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsdivision);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsdivision, nameof(projectRestrictionRebillingsdivision), required: false);
            var __workflow_projectRestrictionRebillingsmodified = projectRestrictionRebillingsmodified == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsmodified);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsmodified, nameof(projectRestrictionRebillingsmodified), required: false);
            var __workflow_projectRestrictionRebillingsmodifier = projectRestrictionRebillingsmodifier == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsmodifier);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsmodifier, nameof(projectRestrictionRebillingsmodifier), required: false);
            var __workflow_projectRestrictionRebillingsmodifierFullName = projectRestrictionRebillingsmodifierFullName == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsmodifierFullName);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsmodifierFullName, nameof(projectRestrictionRebillingsmodifierFullName), required: false);
            var __workflow_projectRestrictionRebillingsprojectCode = projectRestrictionRebillingsprojectCode == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsprojectCode);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsprojectCode, nameof(projectRestrictionRebillingsprojectCode), required: false);
            var __workflow_projectRestrictionRebillingsprojectDescription = projectRestrictionRebillingsprojectDescription == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsprojectDescription);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsprojectDescription, nameof(projectRestrictionRebillingsprojectDescription), required: false);
            return new DeferredBodyAction<ProjectRestrictionRebillingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(__workflow_iD);
                var projectRestrictionRebillings = new JObject();
                var projectRestrictionRebillingspropCount = 0;
                if (__workflow_projectRestrictionRebillingsiD != null)
                {
                    projectRestrictionRebillings["ID"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsiD);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["CostTypeRebill"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscostTypeRebill);
                if (__workflow_projectRestrictionRebillingscostTypeRebillCode != null)
                {
                    projectRestrictionRebillings["CostTypeRebillCode"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscostTypeRebillCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingscostTypeRebillDescription != null)
                {
                    projectRestrictionRebillings["CostTypeRebillDescription"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscostTypeRebillDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingscreated != null)
                {
                    projectRestrictionRebillings["Created"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscreated);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingscreator != null)
                {
                    projectRestrictionRebillings["Creator"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscreator);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingscreatorFullName != null)
                {
                    projectRestrictionRebillings["CreatorFullName"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscreatorFullName);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsdivision != null)
                {
                    projectRestrictionRebillings["Division"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsdivision);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsmodified != null)
                {
                    projectRestrictionRebillings["Modified"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsmodified);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsmodifier != null)
                {
                    projectRestrictionRebillings["Modifier"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsmodifier);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsmodifierFullName != null)
                {
                    projectRestrictionRebillings["ModifierFullName"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsmodifierFullName);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["Project"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsproject);
                if (__workflow_projectRestrictionRebillingsprojectCode != null)
                {
                    projectRestrictionRebillings["ProjectCode"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsprojectCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsprojectDescription != null)
                {
                    projectRestrictionRebillings["ProjectDescription"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsprojectDescription);
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
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> PostProjectRestrictionRebillings(Expression<Func<string>> division, Expression<Func<string>> projectRestrictionRebillingscostTypeRebill, Expression<Func<string>> projectRestrictionRebillingsproject, Expression<Func<string>> projectRestrictionRebillingsiD = null, Expression<Func<string>> projectRestrictionRebillingscostTypeRebillCode = null, Expression<Func<string>> projectRestrictionRebillingscostTypeRebillDescription = null, Expression<Func<string>> projectRestrictionRebillingscreated = null, Expression<Func<string>> projectRestrictionRebillingscreator = null, Expression<Func<string>> projectRestrictionRebillingscreatorFullName = null, Expression<Func<int>> projectRestrictionRebillingsdivision = null, Expression<Func<string>> projectRestrictionRebillingsmodified = null, Expression<Func<string>> projectRestrictionRebillingsmodifier = null, Expression<Func<string>> projectRestrictionRebillingsmodifierFullName = null, Expression<Func<string>> projectRestrictionRebillingsprojectCode = null, Expression<Func<string>> projectRestrictionRebillingsprojectDescription = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_projectRestrictionRebillingscostTypeRebill = projectRestrictionRebillingscostTypeRebill == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscostTypeRebill);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscostTypeRebill, nameof(projectRestrictionRebillingscostTypeRebill), required: true);
            var __workflow_projectRestrictionRebillingsproject = projectRestrictionRebillingsproject == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsproject);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsproject, nameof(projectRestrictionRebillingsproject), required: true);
            var __workflow_projectRestrictionRebillingsiD = projectRestrictionRebillingsiD == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsiD);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsiD, nameof(projectRestrictionRebillingsiD), required: false);
            var __workflow_projectRestrictionRebillingscostTypeRebillCode = projectRestrictionRebillingscostTypeRebillCode == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscostTypeRebillCode);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscostTypeRebillCode, nameof(projectRestrictionRebillingscostTypeRebillCode), required: false);
            var __workflow_projectRestrictionRebillingscostTypeRebillDescription = projectRestrictionRebillingscostTypeRebillDescription == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscostTypeRebillDescription);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscostTypeRebillDescription, nameof(projectRestrictionRebillingscostTypeRebillDescription), required: false);
            var __workflow_projectRestrictionRebillingscreated = projectRestrictionRebillingscreated == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscreated);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscreated, nameof(projectRestrictionRebillingscreated), required: false);
            var __workflow_projectRestrictionRebillingscreator = projectRestrictionRebillingscreator == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscreator);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscreator, nameof(projectRestrictionRebillingscreator), required: false);
            var __workflow_projectRestrictionRebillingscreatorFullName = projectRestrictionRebillingscreatorFullName == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingscreatorFullName);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingscreatorFullName, nameof(projectRestrictionRebillingscreatorFullName), required: false);
            var __workflow_projectRestrictionRebillingsdivision = projectRestrictionRebillingsdivision == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsdivision);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsdivision, nameof(projectRestrictionRebillingsdivision), required: false);
            var __workflow_projectRestrictionRebillingsmodified = projectRestrictionRebillingsmodified == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsmodified);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsmodified, nameof(projectRestrictionRebillingsmodified), required: false);
            var __workflow_projectRestrictionRebillingsmodifier = projectRestrictionRebillingsmodifier == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsmodifier);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsmodifier, nameof(projectRestrictionRebillingsmodifier), required: false);
            var __workflow_projectRestrictionRebillingsmodifierFullName = projectRestrictionRebillingsmodifierFullName == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsmodifierFullName);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsmodifierFullName, nameof(projectRestrictionRebillingsmodifierFullName), required: false);
            var __workflow_projectRestrictionRebillingsprojectCode = projectRestrictionRebillingsprojectCode == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsprojectCode);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsprojectCode, nameof(projectRestrictionRebillingsprojectCode), required: false);
            var __workflow_projectRestrictionRebillingsprojectDescription = projectRestrictionRebillingsprojectDescription == null ? null : WorkflowExpression.Compile(projectRestrictionRebillingsprojectDescription);
            WorkflowExpression.Validate(__workflow_projectRestrictionRebillingsprojectDescription, nameof(projectRestrictionRebillingsprojectDescription), required: false);
            return new DeferredBodyAction<ProjectRestrictionRebillingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var projectRestrictionRebillings = new JObject();
                var projectRestrictionRebillingspropCount = 0;
                if (__workflow_projectRestrictionRebillingsiD != null)
                {
                    projectRestrictionRebillings["ID"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsiD);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["CostTypeRebill"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscostTypeRebill);
                if (__workflow_projectRestrictionRebillingscostTypeRebillCode != null)
                {
                    projectRestrictionRebillings["CostTypeRebillCode"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscostTypeRebillCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingscostTypeRebillDescription != null)
                {
                    projectRestrictionRebillings["CostTypeRebillDescription"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscostTypeRebillDescription);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingscreated != null)
                {
                    projectRestrictionRebillings["Created"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscreated);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingscreator != null)
                {
                    projectRestrictionRebillings["Creator"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscreator);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingscreatorFullName != null)
                {
                    projectRestrictionRebillings["CreatorFullName"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingscreatorFullName);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsdivision != null)
                {
                    projectRestrictionRebillings["Division"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsdivision);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsmodified != null)
                {
                    projectRestrictionRebillings["Modified"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsmodified);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsmodifier != null)
                {
                    projectRestrictionRebillings["Modifier"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsmodifier);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsmodifierFullName != null)
                {
                    projectRestrictionRebillings["ModifierFullName"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsmodifierFullName);
                    projectRestrictionRebillingspropCount++;
                }

                projectRestrictionRebillingspropCount++;
                projectRestrictionRebillings["Project"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsproject);
                if (__workflow_projectRestrictionRebillingsprojectCode != null)
                {
                    projectRestrictionRebillings["ProjectCode"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsprojectCode);
                    projectRestrictionRebillingspropCount++;
                }

                if (__workflow_projectRestrictionRebillingsprojectDescription != null)
                {
                    projectRestrictionRebillings["ProjectDescription"] = ExpressionConverter.ConvertO(__workflow_projectRestrictionRebillingsprojectDescription);
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
        public IBodyWorkflowAction<ProjectRestrictionRebillingsResponse> DeleteProjectRestrictionRebillings(Expression<Func<string>> division, Expression<Func<string>> iD)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_iD = iD == null ? null : WorkflowExpression.Compile(iD);
            WorkflowExpression.Validate(__workflow_iD, nameof(iD), required: true);
            return new DeferredBodyAction<ProjectRestrictionRebillingsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/ProjectRestrictionRebillings", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(__workflow_iD);
                return new ApiConnectionAction<ProjectRestrictionRebillingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentCostsByNumberOfWeeksResponse> GetRecentCostsByNumberOfWeeks(Expression<Func<string>> division, Expression<Func<int>> numberOfWeeks, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_numberOfWeeks = numberOfWeeks == null ? null : WorkflowExpression.Compile(numberOfWeeks);
            WorkflowExpression.Validate(__workflow_numberOfWeeks, nameof(numberOfWeeks), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<RecentCostsByNumberOfWeeksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentCostsByNumberOfWeeks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["numberOfWeeks"] = ExpressionConverter.Convert(__workflow_numberOfWeeks);
                return new ApiConnectionAction<RecentCostsByNumberOfWeeksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentHoursResponse> GetRecentHours(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<RecentHoursResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentHours", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<RecentHoursResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<RecentHoursByNumberOfWeeksResponse> GetRecentHoursByNumberOfWeeks(Expression<Func<string>> division, Expression<Func<int>> numberOfWeeks, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_numberOfWeeks = numberOfWeeks == null ? null : WorkflowExpression.Compile(numberOfWeeks);
            WorkflowExpression.Validate(__workflow_numberOfWeeks, nameof(numberOfWeeks), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<RecentHoursByNumberOfWeeksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/RecentHoursByNumberOfWeeks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["numberOfWeeks"] = ExpressionConverter.Convert(__workflow_numberOfWeeks);
                return new ApiConnectionAction<RecentHoursByNumberOfWeeksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsResponse> GetTimeAndBillingAccountDetails(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingAccountDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingAccountDetails", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingAccountDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingAccountDetailsByIDResponse> GetTimeAndBillingAccountDetailsByID(Expression<Func<string>> accountId, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingAccountDetailsByIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingAccountDetailsByID", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["accountId"] = ExpressionConverter.Convert(__workflow_accountId);
                return new ApiConnectionAction<TimeAndBillingAccountDetailsByIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingActivitiesAndExpensesResponse> GetTimeAndBillingActivitiesAndExpenses(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingActivitiesAndExpensesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingActivitiesAndExpenses", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingActivitiesAndExpensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsResponse> GetTimeAndBillingEntryAccounts(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryAccountsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccounts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingEntryAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByDateResponse> GetTimeAndBillingEntryAccountsByDate(Expression<Func<string>> checkDate, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_checkDate = checkDate == null ? null : WorkflowExpression.Compile(checkDate);
            WorkflowExpression.Validate(__workflow_checkDate, nameof(checkDate), required: true);
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryAccountsByDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccountsByDate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["checkDate"] = ExpressionConverter.Convert(__workflow_checkDate);
                return new ApiConnectionAction<TimeAndBillingEntryAccountsByDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryAccountsByProjectAndDateResponse> GetTimeAndBillingEntryAccountsByProjectAndDate(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryAccountsByProjectAndDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryAccountsByProjectAndDate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<TimeAndBillingEntryAccountsByProjectAndDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsResponse> GetTimeAndBillingEntryProjects(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryProjectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjects", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingEntryProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByAccountAndDateResponse> GetTimeAndBillingEntryProjectsByAccountAndDate(Expression<Func<string>> accountId, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryProjectsByAccountAndDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjectsByAccountAndDate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["accountId"] = ExpressionConverter.Convert(__workflow_accountId);
                return new ApiConnectionAction<TimeAndBillingEntryProjectsByAccountAndDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryProjectsByDateResponse> GetTimeAndBillingEntryProjectsByDate(Expression<Func<string>> checkDate, Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_checkDate = checkDate == null ? null : WorkflowExpression.Compile(checkDate);
            WorkflowExpression.Validate(__workflow_checkDate, nameof(checkDate), required: true);
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryProjectsByDateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryProjectsByDate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["checkDate"] = ExpressionConverter.Convert(__workflow_checkDate);
                return new ApiConnectionAction<TimeAndBillingEntryProjectsByDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentAccountsResponse> GetTimeAndBillingEntryRecentAccounts(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryRecentAccountsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentAccounts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingEntryRecentAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse> GetTimeAndBillingEntryRecentActivitiesAndExpenses(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentActivitiesAndExpenses", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingEntryRecentActivitiesAndExpensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentHourCostTypesResponse> GetTimeAndBillingEntryRecentHourCostTypes(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryRecentHourCostTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentHourCostTypes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingEntryRecentHourCostTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingEntryRecentProjectsResponse> GetTimeAndBillingEntryRecentProjects(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingEntryRecentProjectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingEntryRecentProjects", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingEntryRecentProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsResponse> GetTimeAndBillingItemDetails(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingItemDetails", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingItemDetailsByIDResponse> GetTimeAndBillingItemDetailsByID(Expression<Func<string>> division, Expression<Func<string>> itemId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_itemId = itemId == null ? null : WorkflowExpression.Compile(itemId);
            WorkflowExpression.Validate(__workflow_itemId, nameof(itemId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingItemDetailsByIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingItemDetailsByID", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["itemId"] = ExpressionConverter.Convert(__workflow_itemId);
                return new ApiConnectionAction<TimeAndBillingItemDetailsByIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsResponse> GetTimeAndBillingProjectDetails(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingProjectDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingProjectDetails", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingProjectDetailsByIDResponse> GetTimeAndBillingProjectDetailsByID(Expression<Func<string>> division, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingProjectDetailsByIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingProjectDetailsByID", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<TimeAndBillingProjectDetailsByIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeAndBillingRecentProjectsResponse> GetTimeAndBillingRecentProjects(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeAndBillingRecentProjectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/read/project/TimeAndBillingRecentProjects", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeAndBillingRecentProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> GetTimeCorrections(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeCorrectionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeCorrectionsResponse> PutTimeCorrections(Expression<Func<string>> division, Expression<Func<string>> iD, Expression<Func<string>> timeCorrectionsiD = null, Expression<Func<string>> timeCorrectionscreated = null, Expression<Func<string>> timeCorrectionscreator = null, Expression<Func<string>> timeCorrectionscreatorFullName = null, Expression<Func<int>> timeCorrectionsdivision = null, Expression<Func<string>> timeCorrectionsmodified = null, Expression<Func<string>> timeCorrectionsmodifier = null, Expression<Func<string>> timeCorrectionsmodifierFullName = null, Expression<Func<string>> timeCorrectionsnotes = null, Expression<Func<string>> timeCorrectionsoriginalEntryId = null, Expression<Func<double>> timeCorrectionsquantity = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_iD = iD == null ? null : WorkflowExpression.Compile(iD);
            WorkflowExpression.Validate(__workflow_iD, nameof(iD), required: true);
            var __workflow_timeCorrectionsiD = timeCorrectionsiD == null ? null : WorkflowExpression.Compile(timeCorrectionsiD);
            WorkflowExpression.Validate(__workflow_timeCorrectionsiD, nameof(timeCorrectionsiD), required: false);
            var __workflow_timeCorrectionscreated = timeCorrectionscreated == null ? null : WorkflowExpression.Compile(timeCorrectionscreated);
            WorkflowExpression.Validate(__workflow_timeCorrectionscreated, nameof(timeCorrectionscreated), required: false);
            var __workflow_timeCorrectionscreator = timeCorrectionscreator == null ? null : WorkflowExpression.Compile(timeCorrectionscreator);
            WorkflowExpression.Validate(__workflow_timeCorrectionscreator, nameof(timeCorrectionscreator), required: false);
            var __workflow_timeCorrectionscreatorFullName = timeCorrectionscreatorFullName == null ? null : WorkflowExpression.Compile(timeCorrectionscreatorFullName);
            WorkflowExpression.Validate(__workflow_timeCorrectionscreatorFullName, nameof(timeCorrectionscreatorFullName), required: false);
            var __workflow_timeCorrectionsdivision = timeCorrectionsdivision == null ? null : WorkflowExpression.Compile(timeCorrectionsdivision);
            WorkflowExpression.Validate(__workflow_timeCorrectionsdivision, nameof(timeCorrectionsdivision), required: false);
            var __workflow_timeCorrectionsmodified = timeCorrectionsmodified == null ? null : WorkflowExpression.Compile(timeCorrectionsmodified);
            WorkflowExpression.Validate(__workflow_timeCorrectionsmodified, nameof(timeCorrectionsmodified), required: false);
            var __workflow_timeCorrectionsmodifier = timeCorrectionsmodifier == null ? null : WorkflowExpression.Compile(timeCorrectionsmodifier);
            WorkflowExpression.Validate(__workflow_timeCorrectionsmodifier, nameof(timeCorrectionsmodifier), required: false);
            var __workflow_timeCorrectionsmodifierFullName = timeCorrectionsmodifierFullName == null ? null : WorkflowExpression.Compile(timeCorrectionsmodifierFullName);
            WorkflowExpression.Validate(__workflow_timeCorrectionsmodifierFullName, nameof(timeCorrectionsmodifierFullName), required: false);
            var __workflow_timeCorrectionsnotes = timeCorrectionsnotes == null ? null : WorkflowExpression.Compile(timeCorrectionsnotes);
            WorkflowExpression.Validate(__workflow_timeCorrectionsnotes, nameof(timeCorrectionsnotes), required: false);
            var __workflow_timeCorrectionsoriginalEntryId = timeCorrectionsoriginalEntryId == null ? null : WorkflowExpression.Compile(timeCorrectionsoriginalEntryId);
            WorkflowExpression.Validate(__workflow_timeCorrectionsoriginalEntryId, nameof(timeCorrectionsoriginalEntryId), required: false);
            var __workflow_timeCorrectionsquantity = timeCorrectionsquantity == null ? null : WorkflowExpression.Compile(timeCorrectionsquantity);
            WorkflowExpression.Validate(__workflow_timeCorrectionsquantity, nameof(timeCorrectionsquantity), required: false);
            return new DeferredBodyAction<TimeCorrectionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(__workflow_iD);
                var timeCorrections = new JObject();
                var timeCorrectionspropCount = 0;
                if (__workflow_timeCorrectionsiD != null)
                {
                    timeCorrections["ID"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsiD);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionscreated != null)
                {
                    timeCorrections["Created"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionscreated);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionscreator != null)
                {
                    timeCorrections["Creator"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionscreator);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionscreatorFullName != null)
                {
                    timeCorrections["CreatorFullName"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionscreatorFullName);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsdivision != null)
                {
                    timeCorrections["Division"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsdivision);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsmodified != null)
                {
                    timeCorrections["Modified"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsmodified);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsmodifier != null)
                {
                    timeCorrections["Modifier"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsmodifier);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsmodifierFullName != null)
                {
                    timeCorrections["ModifierFullName"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsmodifierFullName);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsnotes != null)
                {
                    timeCorrections["Notes"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsnotes);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsoriginalEntryId != null)
                {
                    timeCorrections["OriginalEntryId"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsoriginalEntryId);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsquantity != null)
                {
                    timeCorrections["Quantity"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsquantity);
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
        public IBodyWorkflowAction<TimeCorrectionsResponse> PostTimeCorrections(Expression<Func<string>> division, Expression<Func<string>> timeCorrectionsiD = null, Expression<Func<string>> timeCorrectionscreated = null, Expression<Func<string>> timeCorrectionscreator = null, Expression<Func<string>> timeCorrectionscreatorFullName = null, Expression<Func<int>> timeCorrectionsdivision = null, Expression<Func<string>> timeCorrectionsmodified = null, Expression<Func<string>> timeCorrectionsmodifier = null, Expression<Func<string>> timeCorrectionsmodifierFullName = null, Expression<Func<string>> timeCorrectionsnotes = null, Expression<Func<string>> timeCorrectionsoriginalEntryId = null, Expression<Func<double>> timeCorrectionsquantity = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_timeCorrectionsiD = timeCorrectionsiD == null ? null : WorkflowExpression.Compile(timeCorrectionsiD);
            WorkflowExpression.Validate(__workflow_timeCorrectionsiD, nameof(timeCorrectionsiD), required: false);
            var __workflow_timeCorrectionscreated = timeCorrectionscreated == null ? null : WorkflowExpression.Compile(timeCorrectionscreated);
            WorkflowExpression.Validate(__workflow_timeCorrectionscreated, nameof(timeCorrectionscreated), required: false);
            var __workflow_timeCorrectionscreator = timeCorrectionscreator == null ? null : WorkflowExpression.Compile(timeCorrectionscreator);
            WorkflowExpression.Validate(__workflow_timeCorrectionscreator, nameof(timeCorrectionscreator), required: false);
            var __workflow_timeCorrectionscreatorFullName = timeCorrectionscreatorFullName == null ? null : WorkflowExpression.Compile(timeCorrectionscreatorFullName);
            WorkflowExpression.Validate(__workflow_timeCorrectionscreatorFullName, nameof(timeCorrectionscreatorFullName), required: false);
            var __workflow_timeCorrectionsdivision = timeCorrectionsdivision == null ? null : WorkflowExpression.Compile(timeCorrectionsdivision);
            WorkflowExpression.Validate(__workflow_timeCorrectionsdivision, nameof(timeCorrectionsdivision), required: false);
            var __workflow_timeCorrectionsmodified = timeCorrectionsmodified == null ? null : WorkflowExpression.Compile(timeCorrectionsmodified);
            WorkflowExpression.Validate(__workflow_timeCorrectionsmodified, nameof(timeCorrectionsmodified), required: false);
            var __workflow_timeCorrectionsmodifier = timeCorrectionsmodifier == null ? null : WorkflowExpression.Compile(timeCorrectionsmodifier);
            WorkflowExpression.Validate(__workflow_timeCorrectionsmodifier, nameof(timeCorrectionsmodifier), required: false);
            var __workflow_timeCorrectionsmodifierFullName = timeCorrectionsmodifierFullName == null ? null : WorkflowExpression.Compile(timeCorrectionsmodifierFullName);
            WorkflowExpression.Validate(__workflow_timeCorrectionsmodifierFullName, nameof(timeCorrectionsmodifierFullName), required: false);
            var __workflow_timeCorrectionsnotes = timeCorrectionsnotes == null ? null : WorkflowExpression.Compile(timeCorrectionsnotes);
            WorkflowExpression.Validate(__workflow_timeCorrectionsnotes, nameof(timeCorrectionsnotes), required: false);
            var __workflow_timeCorrectionsoriginalEntryId = timeCorrectionsoriginalEntryId == null ? null : WorkflowExpression.Compile(timeCorrectionsoriginalEntryId);
            WorkflowExpression.Validate(__workflow_timeCorrectionsoriginalEntryId, nameof(timeCorrectionsoriginalEntryId), required: false);
            var __workflow_timeCorrectionsquantity = timeCorrectionsquantity == null ? null : WorkflowExpression.Compile(timeCorrectionsquantity);
            WorkflowExpression.Validate(__workflow_timeCorrectionsquantity, nameof(timeCorrectionsquantity), required: false);
            return new DeferredBodyAction<TimeCorrectionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var timeCorrections = new JObject();
                var timeCorrectionspropCount = 0;
                if (__workflow_timeCorrectionsiD != null)
                {
                    timeCorrections["ID"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsiD);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionscreated != null)
                {
                    timeCorrections["Created"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionscreated);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionscreator != null)
                {
                    timeCorrections["Creator"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionscreator);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionscreatorFullName != null)
                {
                    timeCorrections["CreatorFullName"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionscreatorFullName);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsdivision != null)
                {
                    timeCorrections["Division"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsdivision);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsmodified != null)
                {
                    timeCorrections["Modified"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsmodified);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsmodifier != null)
                {
                    timeCorrections["Modifier"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsmodifier);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsmodifierFullName != null)
                {
                    timeCorrections["ModifierFullName"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsmodifierFullName);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsnotes != null)
                {
                    timeCorrections["Notes"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsnotes);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsoriginalEntryId != null)
                {
                    timeCorrections["OriginalEntryId"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsoriginalEntryId);
                    timeCorrectionspropCount++;
                }

                if (__workflow_timeCorrectionsquantity != null)
                {
                    timeCorrections["Quantity"] = ExpressionConverter.ConvertO(__workflow_timeCorrectionsquantity);
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
        public IBodyWorkflowAction<TimeCorrectionsResponse> DeleteTimeCorrections(Expression<Func<string>> division, Expression<Func<string>> iD)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_iD = iD == null ? null : WorkflowExpression.Compile(iD);
            WorkflowExpression.Validate(__workflow_iD, nameof(iD), required: true);
            return new DeferredBodyAction<TimeCorrectionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeCorrections", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(__workflow_iD);
                return new ApiConnectionAction<TimeCorrectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> GetTimeTransactions(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<TimeTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<TimeTransactionsResponse> PutTimeTransactions(Expression<Func<string>> division, Expression<Func<string>> iD, Expression<Func<string>> timeTransactionsitem, Expression<Func<string>> timeTransactionsproject, Expression<Func<double>> timeTransactionsquantity, Expression<Func<string>> timeTransactionsiD = null, Expression<Func<string>> timeTransactionsaccount = null, Expression<Func<string>> timeTransactionsaccountName = null, Expression<Func<string>> timeTransactionsactivity = null, Expression<Func<string>> timeTransactionsactivityDescription = null, Expression<Func<double>> timeTransactionsamount = null, Expression<Func<double>> timeTransactionsamountFC = null, Expression<Func<string>> timeTransactionsattachment = null, Expression<Func<string>> timeTransactionscreated = null, Expression<Func<string>> timeTransactionscreator = null, Expression<Func<string>> timeTransactionscreatorFullName = null, Expression<Func<string>> timeTransactionscurrency = null, Expression<Func<string>> timeTransactionsdate = null, Expression<Func<int>> timeTransactionsdivision = null, Expression<Func<string>> timeTransactionsdivisionDescription = null, Expression<Func<string>> timeTransactionsemployee = null, Expression<Func<string>> timeTransactionsendTime = null, Expression<Func<int>> timeTransactionsentryNumber = null, Expression<Func<string>> timeTransactionserrorText = null, Expression<Func<double>> timeTransactionshourStatus = null, Expression<Func<string>> timeTransactionsitemDescription = null, Expression<Func<bool>> timeTransactionsitemDivisable = null, Expression<Func<string>> timeTransactionsmodified = null, Expression<Func<string>> timeTransactionsmodifier = null, Expression<Func<string>> timeTransactionsmodifierFullName = null, Expression<Func<string>> timeTransactionsnotes = null, Expression<Func<double>> timeTransactionsprice = null, Expression<Func<double>> timeTransactionspriceFC = null, Expression<Func<string>> timeTransactionsprojectAccount = null, Expression<Func<string>> timeTransactionsprojectAccountCode = null, Expression<Func<string>> timeTransactionsprojectAccountName = null, Expression<Func<string>> timeTransactionsprojectCode = null, Expression<Func<string>> timeTransactionsprojectDescription = null, Expression<Func<bool>> timeTransactionsskipValidation = null, Expression<Func<string>> timeTransactionsstartTime = null, Expression<Func<string>> timeTransactionssubscription = null, Expression<Func<string>> timeTransactionssubscriptionAccount = null, Expression<Func<string>> timeTransactionssubscriptionAccountCode = null, Expression<Func<string>> timeTransactionssubscriptionAccountName = null, Expression<Func<string>> timeTransactionssubscriptionDescription = null, Expression<Func<int>> timeTransactionssubscriptionNumber = null, Expression<Func<double>> timeTransactionstype = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_iD = iD == null ? null : WorkflowExpression.Compile(iD);
            WorkflowExpression.Validate(__workflow_iD, nameof(iD), required: true);
            var __workflow_timeTransactionsitem = timeTransactionsitem == null ? null : WorkflowExpression.Compile(timeTransactionsitem);
            WorkflowExpression.Validate(__workflow_timeTransactionsitem, nameof(timeTransactionsitem), required: true);
            var __workflow_timeTransactionsproject = timeTransactionsproject == null ? null : WorkflowExpression.Compile(timeTransactionsproject);
            WorkflowExpression.Validate(__workflow_timeTransactionsproject, nameof(timeTransactionsproject), required: true);
            var __workflow_timeTransactionsquantity = timeTransactionsquantity == null ? null : WorkflowExpression.Compile(timeTransactionsquantity);
            WorkflowExpression.Validate(__workflow_timeTransactionsquantity, nameof(timeTransactionsquantity), required: true);
            var __workflow_timeTransactionsiD = timeTransactionsiD == null ? null : WorkflowExpression.Compile(timeTransactionsiD);
            WorkflowExpression.Validate(__workflow_timeTransactionsiD, nameof(timeTransactionsiD), required: false);
            var __workflow_timeTransactionsaccount = timeTransactionsaccount == null ? null : WorkflowExpression.Compile(timeTransactionsaccount);
            WorkflowExpression.Validate(__workflow_timeTransactionsaccount, nameof(timeTransactionsaccount), required: false);
            var __workflow_timeTransactionsaccountName = timeTransactionsaccountName == null ? null : WorkflowExpression.Compile(timeTransactionsaccountName);
            WorkflowExpression.Validate(__workflow_timeTransactionsaccountName, nameof(timeTransactionsaccountName), required: false);
            var __workflow_timeTransactionsactivity = timeTransactionsactivity == null ? null : WorkflowExpression.Compile(timeTransactionsactivity);
            WorkflowExpression.Validate(__workflow_timeTransactionsactivity, nameof(timeTransactionsactivity), required: false);
            var __workflow_timeTransactionsactivityDescription = timeTransactionsactivityDescription == null ? null : WorkflowExpression.Compile(timeTransactionsactivityDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionsactivityDescription, nameof(timeTransactionsactivityDescription), required: false);
            var __workflow_timeTransactionsamount = timeTransactionsamount == null ? null : WorkflowExpression.Compile(timeTransactionsamount);
            WorkflowExpression.Validate(__workflow_timeTransactionsamount, nameof(timeTransactionsamount), required: false);
            var __workflow_timeTransactionsamountFC = timeTransactionsamountFC == null ? null : WorkflowExpression.Compile(timeTransactionsamountFC);
            WorkflowExpression.Validate(__workflow_timeTransactionsamountFC, nameof(timeTransactionsamountFC), required: false);
            var __workflow_timeTransactionsattachment = timeTransactionsattachment == null ? null : WorkflowExpression.Compile(timeTransactionsattachment);
            WorkflowExpression.Validate(__workflow_timeTransactionsattachment, nameof(timeTransactionsattachment), required: false);
            var __workflow_timeTransactionscreated = timeTransactionscreated == null ? null : WorkflowExpression.Compile(timeTransactionscreated);
            WorkflowExpression.Validate(__workflow_timeTransactionscreated, nameof(timeTransactionscreated), required: false);
            var __workflow_timeTransactionscreator = timeTransactionscreator == null ? null : WorkflowExpression.Compile(timeTransactionscreator);
            WorkflowExpression.Validate(__workflow_timeTransactionscreator, nameof(timeTransactionscreator), required: false);
            var __workflow_timeTransactionscreatorFullName = timeTransactionscreatorFullName == null ? null : WorkflowExpression.Compile(timeTransactionscreatorFullName);
            WorkflowExpression.Validate(__workflow_timeTransactionscreatorFullName, nameof(timeTransactionscreatorFullName), required: false);
            var __workflow_timeTransactionscurrency = timeTransactionscurrency == null ? null : WorkflowExpression.Compile(timeTransactionscurrency);
            WorkflowExpression.Validate(__workflow_timeTransactionscurrency, nameof(timeTransactionscurrency), required: false);
            var __workflow_timeTransactionsdate = timeTransactionsdate == null ? null : WorkflowExpression.Compile(timeTransactionsdate);
            WorkflowExpression.Validate(__workflow_timeTransactionsdate, nameof(timeTransactionsdate), required: false);
            var __workflow_timeTransactionsdivision = timeTransactionsdivision == null ? null : WorkflowExpression.Compile(timeTransactionsdivision);
            WorkflowExpression.Validate(__workflow_timeTransactionsdivision, nameof(timeTransactionsdivision), required: false);
            var __workflow_timeTransactionsdivisionDescription = timeTransactionsdivisionDescription == null ? null : WorkflowExpression.Compile(timeTransactionsdivisionDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionsdivisionDescription, nameof(timeTransactionsdivisionDescription), required: false);
            var __workflow_timeTransactionsemployee = timeTransactionsemployee == null ? null : WorkflowExpression.Compile(timeTransactionsemployee);
            WorkflowExpression.Validate(__workflow_timeTransactionsemployee, nameof(timeTransactionsemployee), required: false);
            var __workflow_timeTransactionsendTime = timeTransactionsendTime == null ? null : WorkflowExpression.Compile(timeTransactionsendTime);
            WorkflowExpression.Validate(__workflow_timeTransactionsendTime, nameof(timeTransactionsendTime), required: false);
            var __workflow_timeTransactionsentryNumber = timeTransactionsentryNumber == null ? null : WorkflowExpression.Compile(timeTransactionsentryNumber);
            WorkflowExpression.Validate(__workflow_timeTransactionsentryNumber, nameof(timeTransactionsentryNumber), required: false);
            var __workflow_timeTransactionserrorText = timeTransactionserrorText == null ? null : WorkflowExpression.Compile(timeTransactionserrorText);
            WorkflowExpression.Validate(__workflow_timeTransactionserrorText, nameof(timeTransactionserrorText), required: false);
            var __workflow_timeTransactionshourStatus = timeTransactionshourStatus == null ? null : WorkflowExpression.Compile(timeTransactionshourStatus);
            WorkflowExpression.Validate(__workflow_timeTransactionshourStatus, nameof(timeTransactionshourStatus), required: false);
            var __workflow_timeTransactionsitemDescription = timeTransactionsitemDescription == null ? null : WorkflowExpression.Compile(timeTransactionsitemDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionsitemDescription, nameof(timeTransactionsitemDescription), required: false);
            var __workflow_timeTransactionsitemDivisable = timeTransactionsitemDivisable == null ? null : WorkflowExpression.Compile(timeTransactionsitemDivisable);
            WorkflowExpression.Validate(__workflow_timeTransactionsitemDivisable, nameof(timeTransactionsitemDivisable), required: false);
            var __workflow_timeTransactionsmodified = timeTransactionsmodified == null ? null : WorkflowExpression.Compile(timeTransactionsmodified);
            WorkflowExpression.Validate(__workflow_timeTransactionsmodified, nameof(timeTransactionsmodified), required: false);
            var __workflow_timeTransactionsmodifier = timeTransactionsmodifier == null ? null : WorkflowExpression.Compile(timeTransactionsmodifier);
            WorkflowExpression.Validate(__workflow_timeTransactionsmodifier, nameof(timeTransactionsmodifier), required: false);
            var __workflow_timeTransactionsmodifierFullName = timeTransactionsmodifierFullName == null ? null : WorkflowExpression.Compile(timeTransactionsmodifierFullName);
            WorkflowExpression.Validate(__workflow_timeTransactionsmodifierFullName, nameof(timeTransactionsmodifierFullName), required: false);
            var __workflow_timeTransactionsnotes = timeTransactionsnotes == null ? null : WorkflowExpression.Compile(timeTransactionsnotes);
            WorkflowExpression.Validate(__workflow_timeTransactionsnotes, nameof(timeTransactionsnotes), required: false);
            var __workflow_timeTransactionsprice = timeTransactionsprice == null ? null : WorkflowExpression.Compile(timeTransactionsprice);
            WorkflowExpression.Validate(__workflow_timeTransactionsprice, nameof(timeTransactionsprice), required: false);
            var __workflow_timeTransactionspriceFC = timeTransactionspriceFC == null ? null : WorkflowExpression.Compile(timeTransactionspriceFC);
            WorkflowExpression.Validate(__workflow_timeTransactionspriceFC, nameof(timeTransactionspriceFC), required: false);
            var __workflow_timeTransactionsprojectAccount = timeTransactionsprojectAccount == null ? null : WorkflowExpression.Compile(timeTransactionsprojectAccount);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectAccount, nameof(timeTransactionsprojectAccount), required: false);
            var __workflow_timeTransactionsprojectAccountCode = timeTransactionsprojectAccountCode == null ? null : WorkflowExpression.Compile(timeTransactionsprojectAccountCode);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectAccountCode, nameof(timeTransactionsprojectAccountCode), required: false);
            var __workflow_timeTransactionsprojectAccountName = timeTransactionsprojectAccountName == null ? null : WorkflowExpression.Compile(timeTransactionsprojectAccountName);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectAccountName, nameof(timeTransactionsprojectAccountName), required: false);
            var __workflow_timeTransactionsprojectCode = timeTransactionsprojectCode == null ? null : WorkflowExpression.Compile(timeTransactionsprojectCode);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectCode, nameof(timeTransactionsprojectCode), required: false);
            var __workflow_timeTransactionsprojectDescription = timeTransactionsprojectDescription == null ? null : WorkflowExpression.Compile(timeTransactionsprojectDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectDescription, nameof(timeTransactionsprojectDescription), required: false);
            var __workflow_timeTransactionsskipValidation = timeTransactionsskipValidation == null ? null : WorkflowExpression.Compile(timeTransactionsskipValidation);
            WorkflowExpression.Validate(__workflow_timeTransactionsskipValidation, nameof(timeTransactionsskipValidation), required: false);
            var __workflow_timeTransactionsstartTime = timeTransactionsstartTime == null ? null : WorkflowExpression.Compile(timeTransactionsstartTime);
            WorkflowExpression.Validate(__workflow_timeTransactionsstartTime, nameof(timeTransactionsstartTime), required: false);
            var __workflow_timeTransactionssubscription = timeTransactionssubscription == null ? null : WorkflowExpression.Compile(timeTransactionssubscription);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscription, nameof(timeTransactionssubscription), required: false);
            var __workflow_timeTransactionssubscriptionAccount = timeTransactionssubscriptionAccount == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionAccount);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionAccount, nameof(timeTransactionssubscriptionAccount), required: false);
            var __workflow_timeTransactionssubscriptionAccountCode = timeTransactionssubscriptionAccountCode == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionAccountCode);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionAccountCode, nameof(timeTransactionssubscriptionAccountCode), required: false);
            var __workflow_timeTransactionssubscriptionAccountName = timeTransactionssubscriptionAccountName == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionAccountName);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionAccountName, nameof(timeTransactionssubscriptionAccountName), required: false);
            var __workflow_timeTransactionssubscriptionDescription = timeTransactionssubscriptionDescription == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionDescription, nameof(timeTransactionssubscriptionDescription), required: false);
            var __workflow_timeTransactionssubscriptionNumber = timeTransactionssubscriptionNumber == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionNumber);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionNumber, nameof(timeTransactionssubscriptionNumber), required: false);
            var __workflow_timeTransactionstype = timeTransactionstype == null ? null : WorkflowExpression.Compile(timeTransactionstype);
            WorkflowExpression.Validate(__workflow_timeTransactionstype, nameof(timeTransactionstype), required: false);
            return new DeferredBodyAction<TimeTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(__workflow_iD);
                var timeTransactions = new JObject();
                var timeTransactionspropCount = 0;
                if (__workflow_timeTransactionsiD != null)
                {
                    timeTransactions["ID"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsiD);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsaccount != null)
                {
                    timeTransactions["Account"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsaccount);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsaccountName != null)
                {
                    timeTransactions["AccountName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsaccountName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsactivity != null)
                {
                    timeTransactions["Activity"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsactivity);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsactivityDescription != null)
                {
                    timeTransactions["ActivityDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsactivityDescription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsamount != null)
                {
                    timeTransactions["Amount"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsamount);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsamountFC != null)
                {
                    timeTransactions["AmountFC"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsamountFC);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsattachment != null)
                {
                    timeTransactions["Attachment"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsattachment);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionscreated != null)
                {
                    timeTransactions["Created"] = ExpressionConverter.ConvertO(__workflow_timeTransactionscreated);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionscreator != null)
                {
                    timeTransactions["Creator"] = ExpressionConverter.ConvertO(__workflow_timeTransactionscreator);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionscreatorFullName != null)
                {
                    timeTransactions["CreatorFullName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionscreatorFullName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionscurrency != null)
                {
                    timeTransactions["Currency"] = ExpressionConverter.ConvertO(__workflow_timeTransactionscurrency);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsdate != null)
                {
                    timeTransactions["Date"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsdate);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsdivision != null)
                {
                    timeTransactions["Division"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsdivision);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsdivisionDescription != null)
                {
                    timeTransactions["DivisionDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsdivisionDescription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsemployee != null)
                {
                    timeTransactions["Employee"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsemployee);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsendTime != null)
                {
                    timeTransactions["EndTime"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsendTime);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsentryNumber != null)
                {
                    timeTransactions["EntryNumber"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsentryNumber);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionserrorText != null)
                {
                    timeTransactions["ErrorText"] = ExpressionConverter.ConvertO(__workflow_timeTransactionserrorText);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionshourStatus != null)
                {
                    timeTransactions["HourStatus"] = ExpressionConverter.ConvertO(__workflow_timeTransactionshourStatus);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Item"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsitem);
                if (__workflow_timeTransactionsitemDescription != null)
                {
                    timeTransactions["ItemDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsitemDescription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsitemDivisable != null)
                {
                    timeTransactions["ItemDivisable"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsitemDivisable);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsmodified != null)
                {
                    timeTransactions["Modified"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsmodified);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsmodifier != null)
                {
                    timeTransactions["Modifier"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsmodifier);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsmodifierFullName != null)
                {
                    timeTransactions["ModifierFullName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsmodifierFullName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsnotes != null)
                {
                    timeTransactions["Notes"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsnotes);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprice != null)
                {
                    timeTransactions["Price"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprice);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionspriceFC != null)
                {
                    timeTransactions["PriceFC"] = ExpressionConverter.ConvertO(__workflow_timeTransactionspriceFC);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Project"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsproject);
                if (__workflow_timeTransactionsprojectAccount != null)
                {
                    timeTransactions["ProjectAccount"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectAccount);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprojectAccountCode != null)
                {
                    timeTransactions["ProjectAccountCode"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectAccountCode);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprojectAccountName != null)
                {
                    timeTransactions["ProjectAccountName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectAccountName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprojectCode != null)
                {
                    timeTransactions["ProjectCode"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectCode);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprojectDescription != null)
                {
                    timeTransactions["ProjectDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectDescription);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Quantity"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsquantity);
                if (__workflow_timeTransactionsskipValidation != null)
                {
                    timeTransactions["SkipValidation"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsskipValidation);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsstartTime != null)
                {
                    timeTransactions["StartTime"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsstartTime);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscription != null)
                {
                    timeTransactions["Subscription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionAccount != null)
                {
                    timeTransactions["SubscriptionAccount"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionAccount);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionAccountCode != null)
                {
                    timeTransactions["SubscriptionAccountCode"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionAccountCode);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionAccountName != null)
                {
                    timeTransactions["SubscriptionAccountName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionAccountName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionDescription != null)
                {
                    timeTransactions["SubscriptionDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionDescription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionNumber != null)
                {
                    timeTransactions["SubscriptionNumber"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionNumber);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionstype != null)
                {
                    timeTransactions["Type"] = ExpressionConverter.ConvertO(__workflow_timeTransactionstype);
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
        public IBodyWorkflowAction<TimeTransactionsResponse> PostTimeTransactions(Expression<Func<string>> division, Expression<Func<string>> timeTransactionsitem, Expression<Func<string>> timeTransactionsproject, Expression<Func<double>> timeTransactionsquantity, Expression<Func<string>> timeTransactionsiD = null, Expression<Func<string>> timeTransactionsaccount = null, Expression<Func<string>> timeTransactionsaccountName = null, Expression<Func<string>> timeTransactionsactivity = null, Expression<Func<string>> timeTransactionsactivityDescription = null, Expression<Func<double>> timeTransactionsamount = null, Expression<Func<double>> timeTransactionsamountFC = null, Expression<Func<string>> timeTransactionsattachment = null, Expression<Func<string>> timeTransactionscreated = null, Expression<Func<string>> timeTransactionscreator = null, Expression<Func<string>> timeTransactionscreatorFullName = null, Expression<Func<string>> timeTransactionscurrency = null, Expression<Func<string>> timeTransactionsdate = null, Expression<Func<int>> timeTransactionsdivision = null, Expression<Func<string>> timeTransactionsdivisionDescription = null, Expression<Func<string>> timeTransactionsemployee = null, Expression<Func<string>> timeTransactionsendTime = null, Expression<Func<int>> timeTransactionsentryNumber = null, Expression<Func<string>> timeTransactionserrorText = null, Expression<Func<double>> timeTransactionshourStatus = null, Expression<Func<string>> timeTransactionsitemDescription = null, Expression<Func<bool>> timeTransactionsitemDivisable = null, Expression<Func<string>> timeTransactionsmodified = null, Expression<Func<string>> timeTransactionsmodifier = null, Expression<Func<string>> timeTransactionsmodifierFullName = null, Expression<Func<string>> timeTransactionsnotes = null, Expression<Func<double>> timeTransactionsprice = null, Expression<Func<double>> timeTransactionspriceFC = null, Expression<Func<string>> timeTransactionsprojectAccount = null, Expression<Func<string>> timeTransactionsprojectAccountCode = null, Expression<Func<string>> timeTransactionsprojectAccountName = null, Expression<Func<string>> timeTransactionsprojectCode = null, Expression<Func<string>> timeTransactionsprojectDescription = null, Expression<Func<bool>> timeTransactionsskipValidation = null, Expression<Func<string>> timeTransactionsstartTime = null, Expression<Func<string>> timeTransactionssubscription = null, Expression<Func<string>> timeTransactionssubscriptionAccount = null, Expression<Func<string>> timeTransactionssubscriptionAccountCode = null, Expression<Func<string>> timeTransactionssubscriptionAccountName = null, Expression<Func<string>> timeTransactionssubscriptionDescription = null, Expression<Func<int>> timeTransactionssubscriptionNumber = null, Expression<Func<double>> timeTransactionstype = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_timeTransactionsitem = timeTransactionsitem == null ? null : WorkflowExpression.Compile(timeTransactionsitem);
            WorkflowExpression.Validate(__workflow_timeTransactionsitem, nameof(timeTransactionsitem), required: true);
            var __workflow_timeTransactionsproject = timeTransactionsproject == null ? null : WorkflowExpression.Compile(timeTransactionsproject);
            WorkflowExpression.Validate(__workflow_timeTransactionsproject, nameof(timeTransactionsproject), required: true);
            var __workflow_timeTransactionsquantity = timeTransactionsquantity == null ? null : WorkflowExpression.Compile(timeTransactionsquantity);
            WorkflowExpression.Validate(__workflow_timeTransactionsquantity, nameof(timeTransactionsquantity), required: true);
            var __workflow_timeTransactionsiD = timeTransactionsiD == null ? null : WorkflowExpression.Compile(timeTransactionsiD);
            WorkflowExpression.Validate(__workflow_timeTransactionsiD, nameof(timeTransactionsiD), required: false);
            var __workflow_timeTransactionsaccount = timeTransactionsaccount == null ? null : WorkflowExpression.Compile(timeTransactionsaccount);
            WorkflowExpression.Validate(__workflow_timeTransactionsaccount, nameof(timeTransactionsaccount), required: false);
            var __workflow_timeTransactionsaccountName = timeTransactionsaccountName == null ? null : WorkflowExpression.Compile(timeTransactionsaccountName);
            WorkflowExpression.Validate(__workflow_timeTransactionsaccountName, nameof(timeTransactionsaccountName), required: false);
            var __workflow_timeTransactionsactivity = timeTransactionsactivity == null ? null : WorkflowExpression.Compile(timeTransactionsactivity);
            WorkflowExpression.Validate(__workflow_timeTransactionsactivity, nameof(timeTransactionsactivity), required: false);
            var __workflow_timeTransactionsactivityDescription = timeTransactionsactivityDescription == null ? null : WorkflowExpression.Compile(timeTransactionsactivityDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionsactivityDescription, nameof(timeTransactionsactivityDescription), required: false);
            var __workflow_timeTransactionsamount = timeTransactionsamount == null ? null : WorkflowExpression.Compile(timeTransactionsamount);
            WorkflowExpression.Validate(__workflow_timeTransactionsamount, nameof(timeTransactionsamount), required: false);
            var __workflow_timeTransactionsamountFC = timeTransactionsamountFC == null ? null : WorkflowExpression.Compile(timeTransactionsamountFC);
            WorkflowExpression.Validate(__workflow_timeTransactionsamountFC, nameof(timeTransactionsamountFC), required: false);
            var __workflow_timeTransactionsattachment = timeTransactionsattachment == null ? null : WorkflowExpression.Compile(timeTransactionsattachment);
            WorkflowExpression.Validate(__workflow_timeTransactionsattachment, nameof(timeTransactionsattachment), required: false);
            var __workflow_timeTransactionscreated = timeTransactionscreated == null ? null : WorkflowExpression.Compile(timeTransactionscreated);
            WorkflowExpression.Validate(__workflow_timeTransactionscreated, nameof(timeTransactionscreated), required: false);
            var __workflow_timeTransactionscreator = timeTransactionscreator == null ? null : WorkflowExpression.Compile(timeTransactionscreator);
            WorkflowExpression.Validate(__workflow_timeTransactionscreator, nameof(timeTransactionscreator), required: false);
            var __workflow_timeTransactionscreatorFullName = timeTransactionscreatorFullName == null ? null : WorkflowExpression.Compile(timeTransactionscreatorFullName);
            WorkflowExpression.Validate(__workflow_timeTransactionscreatorFullName, nameof(timeTransactionscreatorFullName), required: false);
            var __workflow_timeTransactionscurrency = timeTransactionscurrency == null ? null : WorkflowExpression.Compile(timeTransactionscurrency);
            WorkflowExpression.Validate(__workflow_timeTransactionscurrency, nameof(timeTransactionscurrency), required: false);
            var __workflow_timeTransactionsdate = timeTransactionsdate == null ? null : WorkflowExpression.Compile(timeTransactionsdate);
            WorkflowExpression.Validate(__workflow_timeTransactionsdate, nameof(timeTransactionsdate), required: false);
            var __workflow_timeTransactionsdivision = timeTransactionsdivision == null ? null : WorkflowExpression.Compile(timeTransactionsdivision);
            WorkflowExpression.Validate(__workflow_timeTransactionsdivision, nameof(timeTransactionsdivision), required: false);
            var __workflow_timeTransactionsdivisionDescription = timeTransactionsdivisionDescription == null ? null : WorkflowExpression.Compile(timeTransactionsdivisionDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionsdivisionDescription, nameof(timeTransactionsdivisionDescription), required: false);
            var __workflow_timeTransactionsemployee = timeTransactionsemployee == null ? null : WorkflowExpression.Compile(timeTransactionsemployee);
            WorkflowExpression.Validate(__workflow_timeTransactionsemployee, nameof(timeTransactionsemployee), required: false);
            var __workflow_timeTransactionsendTime = timeTransactionsendTime == null ? null : WorkflowExpression.Compile(timeTransactionsendTime);
            WorkflowExpression.Validate(__workflow_timeTransactionsendTime, nameof(timeTransactionsendTime), required: false);
            var __workflow_timeTransactionsentryNumber = timeTransactionsentryNumber == null ? null : WorkflowExpression.Compile(timeTransactionsentryNumber);
            WorkflowExpression.Validate(__workflow_timeTransactionsentryNumber, nameof(timeTransactionsentryNumber), required: false);
            var __workflow_timeTransactionserrorText = timeTransactionserrorText == null ? null : WorkflowExpression.Compile(timeTransactionserrorText);
            WorkflowExpression.Validate(__workflow_timeTransactionserrorText, nameof(timeTransactionserrorText), required: false);
            var __workflow_timeTransactionshourStatus = timeTransactionshourStatus == null ? null : WorkflowExpression.Compile(timeTransactionshourStatus);
            WorkflowExpression.Validate(__workflow_timeTransactionshourStatus, nameof(timeTransactionshourStatus), required: false);
            var __workflow_timeTransactionsitemDescription = timeTransactionsitemDescription == null ? null : WorkflowExpression.Compile(timeTransactionsitemDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionsitemDescription, nameof(timeTransactionsitemDescription), required: false);
            var __workflow_timeTransactionsitemDivisable = timeTransactionsitemDivisable == null ? null : WorkflowExpression.Compile(timeTransactionsitemDivisable);
            WorkflowExpression.Validate(__workflow_timeTransactionsitemDivisable, nameof(timeTransactionsitemDivisable), required: false);
            var __workflow_timeTransactionsmodified = timeTransactionsmodified == null ? null : WorkflowExpression.Compile(timeTransactionsmodified);
            WorkflowExpression.Validate(__workflow_timeTransactionsmodified, nameof(timeTransactionsmodified), required: false);
            var __workflow_timeTransactionsmodifier = timeTransactionsmodifier == null ? null : WorkflowExpression.Compile(timeTransactionsmodifier);
            WorkflowExpression.Validate(__workflow_timeTransactionsmodifier, nameof(timeTransactionsmodifier), required: false);
            var __workflow_timeTransactionsmodifierFullName = timeTransactionsmodifierFullName == null ? null : WorkflowExpression.Compile(timeTransactionsmodifierFullName);
            WorkflowExpression.Validate(__workflow_timeTransactionsmodifierFullName, nameof(timeTransactionsmodifierFullName), required: false);
            var __workflow_timeTransactionsnotes = timeTransactionsnotes == null ? null : WorkflowExpression.Compile(timeTransactionsnotes);
            WorkflowExpression.Validate(__workflow_timeTransactionsnotes, nameof(timeTransactionsnotes), required: false);
            var __workflow_timeTransactionsprice = timeTransactionsprice == null ? null : WorkflowExpression.Compile(timeTransactionsprice);
            WorkflowExpression.Validate(__workflow_timeTransactionsprice, nameof(timeTransactionsprice), required: false);
            var __workflow_timeTransactionspriceFC = timeTransactionspriceFC == null ? null : WorkflowExpression.Compile(timeTransactionspriceFC);
            WorkflowExpression.Validate(__workflow_timeTransactionspriceFC, nameof(timeTransactionspriceFC), required: false);
            var __workflow_timeTransactionsprojectAccount = timeTransactionsprojectAccount == null ? null : WorkflowExpression.Compile(timeTransactionsprojectAccount);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectAccount, nameof(timeTransactionsprojectAccount), required: false);
            var __workflow_timeTransactionsprojectAccountCode = timeTransactionsprojectAccountCode == null ? null : WorkflowExpression.Compile(timeTransactionsprojectAccountCode);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectAccountCode, nameof(timeTransactionsprojectAccountCode), required: false);
            var __workflow_timeTransactionsprojectAccountName = timeTransactionsprojectAccountName == null ? null : WorkflowExpression.Compile(timeTransactionsprojectAccountName);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectAccountName, nameof(timeTransactionsprojectAccountName), required: false);
            var __workflow_timeTransactionsprojectCode = timeTransactionsprojectCode == null ? null : WorkflowExpression.Compile(timeTransactionsprojectCode);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectCode, nameof(timeTransactionsprojectCode), required: false);
            var __workflow_timeTransactionsprojectDescription = timeTransactionsprojectDescription == null ? null : WorkflowExpression.Compile(timeTransactionsprojectDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionsprojectDescription, nameof(timeTransactionsprojectDescription), required: false);
            var __workflow_timeTransactionsskipValidation = timeTransactionsskipValidation == null ? null : WorkflowExpression.Compile(timeTransactionsskipValidation);
            WorkflowExpression.Validate(__workflow_timeTransactionsskipValidation, nameof(timeTransactionsskipValidation), required: false);
            var __workflow_timeTransactionsstartTime = timeTransactionsstartTime == null ? null : WorkflowExpression.Compile(timeTransactionsstartTime);
            WorkflowExpression.Validate(__workflow_timeTransactionsstartTime, nameof(timeTransactionsstartTime), required: false);
            var __workflow_timeTransactionssubscription = timeTransactionssubscription == null ? null : WorkflowExpression.Compile(timeTransactionssubscription);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscription, nameof(timeTransactionssubscription), required: false);
            var __workflow_timeTransactionssubscriptionAccount = timeTransactionssubscriptionAccount == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionAccount);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionAccount, nameof(timeTransactionssubscriptionAccount), required: false);
            var __workflow_timeTransactionssubscriptionAccountCode = timeTransactionssubscriptionAccountCode == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionAccountCode);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionAccountCode, nameof(timeTransactionssubscriptionAccountCode), required: false);
            var __workflow_timeTransactionssubscriptionAccountName = timeTransactionssubscriptionAccountName == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionAccountName);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionAccountName, nameof(timeTransactionssubscriptionAccountName), required: false);
            var __workflow_timeTransactionssubscriptionDescription = timeTransactionssubscriptionDescription == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionDescription);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionDescription, nameof(timeTransactionssubscriptionDescription), required: false);
            var __workflow_timeTransactionssubscriptionNumber = timeTransactionssubscriptionNumber == null ? null : WorkflowExpression.Compile(timeTransactionssubscriptionNumber);
            WorkflowExpression.Validate(__workflow_timeTransactionssubscriptionNumber, nameof(timeTransactionssubscriptionNumber), required: false);
            var __workflow_timeTransactionstype = timeTransactionstype == null ? null : WorkflowExpression.Compile(timeTransactionstype);
            WorkflowExpression.Validate(__workflow_timeTransactionstype, nameof(timeTransactionstype), required: false);
            return new DeferredBodyAction<TimeTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var timeTransactions = new JObject();
                var timeTransactionspropCount = 0;
                if (__workflow_timeTransactionsiD != null)
                {
                    timeTransactions["ID"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsiD);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsaccount != null)
                {
                    timeTransactions["Account"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsaccount);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsaccountName != null)
                {
                    timeTransactions["AccountName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsaccountName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsactivity != null)
                {
                    timeTransactions["Activity"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsactivity);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsactivityDescription != null)
                {
                    timeTransactions["ActivityDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsactivityDescription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsamount != null)
                {
                    timeTransactions["Amount"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsamount);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsamountFC != null)
                {
                    timeTransactions["AmountFC"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsamountFC);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsattachment != null)
                {
                    timeTransactions["Attachment"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsattachment);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionscreated != null)
                {
                    timeTransactions["Created"] = ExpressionConverter.ConvertO(__workflow_timeTransactionscreated);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionscreator != null)
                {
                    timeTransactions["Creator"] = ExpressionConverter.ConvertO(__workflow_timeTransactionscreator);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionscreatorFullName != null)
                {
                    timeTransactions["CreatorFullName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionscreatorFullName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionscurrency != null)
                {
                    timeTransactions["Currency"] = ExpressionConverter.ConvertO(__workflow_timeTransactionscurrency);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsdate != null)
                {
                    timeTransactions["Date"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsdate);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsdivision != null)
                {
                    timeTransactions["Division"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsdivision);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsdivisionDescription != null)
                {
                    timeTransactions["DivisionDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsdivisionDescription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsemployee != null)
                {
                    timeTransactions["Employee"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsemployee);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsendTime != null)
                {
                    timeTransactions["EndTime"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsendTime);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsentryNumber != null)
                {
                    timeTransactions["EntryNumber"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsentryNumber);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionserrorText != null)
                {
                    timeTransactions["ErrorText"] = ExpressionConverter.ConvertO(__workflow_timeTransactionserrorText);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionshourStatus != null)
                {
                    timeTransactions["HourStatus"] = ExpressionConverter.ConvertO(__workflow_timeTransactionshourStatus);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Item"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsitem);
                if (__workflow_timeTransactionsitemDescription != null)
                {
                    timeTransactions["ItemDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsitemDescription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsitemDivisable != null)
                {
                    timeTransactions["ItemDivisable"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsitemDivisable);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsmodified != null)
                {
                    timeTransactions["Modified"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsmodified);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsmodifier != null)
                {
                    timeTransactions["Modifier"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsmodifier);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsmodifierFullName != null)
                {
                    timeTransactions["ModifierFullName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsmodifierFullName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsnotes != null)
                {
                    timeTransactions["Notes"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsnotes);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprice != null)
                {
                    timeTransactions["Price"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprice);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionspriceFC != null)
                {
                    timeTransactions["PriceFC"] = ExpressionConverter.ConvertO(__workflow_timeTransactionspriceFC);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Project"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsproject);
                if (__workflow_timeTransactionsprojectAccount != null)
                {
                    timeTransactions["ProjectAccount"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectAccount);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprojectAccountCode != null)
                {
                    timeTransactions["ProjectAccountCode"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectAccountCode);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprojectAccountName != null)
                {
                    timeTransactions["ProjectAccountName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectAccountName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprojectCode != null)
                {
                    timeTransactions["ProjectCode"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectCode);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsprojectDescription != null)
                {
                    timeTransactions["ProjectDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsprojectDescription);
                    timeTransactionspropCount++;
                }

                timeTransactionspropCount++;
                timeTransactions["Quantity"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsquantity);
                if (__workflow_timeTransactionsskipValidation != null)
                {
                    timeTransactions["SkipValidation"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsskipValidation);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionsstartTime != null)
                {
                    timeTransactions["StartTime"] = ExpressionConverter.ConvertO(__workflow_timeTransactionsstartTime);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscription != null)
                {
                    timeTransactions["Subscription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionAccount != null)
                {
                    timeTransactions["SubscriptionAccount"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionAccount);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionAccountCode != null)
                {
                    timeTransactions["SubscriptionAccountCode"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionAccountCode);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionAccountName != null)
                {
                    timeTransactions["SubscriptionAccountName"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionAccountName);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionDescription != null)
                {
                    timeTransactions["SubscriptionDescription"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionDescription);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionssubscriptionNumber != null)
                {
                    timeTransactions["SubscriptionNumber"] = ExpressionConverter.ConvertO(__workflow_timeTransactionssubscriptionNumber);
                    timeTransactionspropCount++;
                }

                if (__workflow_timeTransactionstype != null)
                {
                    timeTransactions["Type"] = ExpressionConverter.ConvertO(__workflow_timeTransactionstype);
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
        public IBodyWorkflowAction<TimeTransactionsResponse> DeleteTimeTransactions(Expression<Func<string>> division, Expression<Func<string>> iD)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_iD = iD == null ? null : WorkflowExpression.Compile(iD);
            WorkflowExpression.Validate(__workflow_iD, nameof(iD), required: true);
            return new DeferredBodyAction<TimeTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/project/TimeTransactions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(__workflow_iD);
                return new ApiConnectionAction<TimeTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<ProjectTimeCostTransactionsResponse> GetProjectTimeCostTransactions(Expression<Func<string>> division, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_division = division == null ? null : WorkflowExpression.Compile(division);
            WorkflowExpression.Validate(__workflow_division, nameof(division), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ProjectTimeCostTransactionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sync/Project/TimeCostTransactions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_division, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ProjectTimeCostTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exactonlinetimebilip")]
        public IBodyWorkflowAction<MeResponse> GetMe(Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> skiptoken = null, Expression<Func<int>> top = null)
        {
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<MeResponse>(() =>
            {
                var apiCallPath = "/current/Me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
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
