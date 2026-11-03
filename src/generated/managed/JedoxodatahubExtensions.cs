//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jedoxodatahub
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JedoxodatahubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<DatabasesResponse, ApiConnectionActionConfiguration> Databases(Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<DatabasesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Databases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<DatabasesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Database, ApiConnectionActionConfiguration> DatabaseById(Expression<Func<int>> databaseId)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            return new DeferredBodyAction<Database, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})", __workflow_databaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Database>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<CubesResponse, ApiConnectionActionConfiguration> Cubes(Expression<Func<int>> databaseId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CubesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Cubes", __workflow_databaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<CubesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Cube, ApiConnectionActionConfiguration> CubeById(Expression<Func<int>> databaseId, Expression<Func<int>> cubeId)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_cubeId = WorkflowExpression.Compile(cubeId, nameof(cubeId), required: true);
            return new DeferredBodyAction<Cube, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Cubes({1})", __workflow_databaseId.WithUrlEncoding(1), __workflow_cubeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Cube>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<CubeCellsResponse, ApiConnectionActionConfiguration> CubeCells(Expression<Func<int>> databaseId, Expression<Func<int>> cubeId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null, Expression<Func<bool>> baseonly = null, Expression<Func<bool>> userules = null, Expression<Func<bool>> zerosupression = null, Expression<Func<bool>> disablepaging = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_cubeId = WorkflowExpression.Compile(cubeId, nameof(cubeId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_baseonly = WorkflowExpression.Compile(baseonly, nameof(baseonly), required: false);
            var __workflow_userules = WorkflowExpression.Compile(userules, nameof(userules), required: false);
            var __workflow_zerosupression = WorkflowExpression.Compile(zerosupression, nameof(zerosupression), required: false);
            var __workflow_disablepaging = WorkflowExpression.Compile(disablepaging, nameof(disablepaging), required: false);
            return new DeferredBodyAction<CubeCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Cubes({1})/Cells", __workflow_databaseId.WithUrlEncoding(1), __workflow_cubeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["baseonly"] = Convert.ToString(true);
                if (__workflow_baseonly != null)
                    callPayload.Queries["baseonly"] = ExpressionConverter.Convert(__workflow_baseonly);
                callPayload.Queries["userules"] = Convert.ToString(false);
                if (__workflow_userules != null)
                    callPayload.Queries["userules"] = ExpressionConverter.Convert(__workflow_userules);
                callPayload.Queries["zerosupression"] = Convert.ToString(true);
                if (__workflow_zerosupression != null)
                    callPayload.Queries["zerosupression"] = ExpressionConverter.Convert(__workflow_zerosupression);
                callPayload.Queries["disablepaging"] = Convert.ToString(false);
                if (__workflow_disablepaging != null)
                    callPayload.Queries["disablepaging"] = ExpressionConverter.Convert(__workflow_disablepaging);
                return new ApiConnectionAction<CubeCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<DimensionsResponse, ApiConnectionActionConfiguration> Dimensions(Expression<Func<int>> databaseId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<DimensionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Dimensions", __workflow_databaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<DimensionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Dimension, ApiConnectionActionConfiguration> DimensionById(Expression<Func<int>> databaseId, Expression<Func<int>> dimensionId)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_dimensionId = WorkflowExpression.Compile(dimensionId, nameof(dimensionId), required: true);
            return new DeferredBodyAction<Dimension, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Dimensions({1})", __workflow_databaseId.WithUrlEncoding(1), __workflow_dimensionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Dimension>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ElementsResponse, ApiConnectionActionConfiguration> Elements(Expression<Func<int>> databaseId, Expression<Func<int>> dimensionId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_dimensionId = WorkflowExpression.Compile(dimensionId, nameof(dimensionId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Dimensions({1})/Elements", __workflow_databaseId.WithUrlEncoding(1), __workflow_dimensionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<ElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Element, ApiConnectionActionConfiguration> ElementById(Expression<Func<int>> databaseId, Expression<Func<int>> dimensionId, Expression<Func<int>> elementId)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_dimensionId = WorkflowExpression.Compile(dimensionId, nameof(dimensionId), required: true);
            var __workflow_elementId = WorkflowExpression.Compile(elementId, nameof(elementId), required: true);
            return new DeferredBodyAction<Element, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Dimensions({1})/Elements({2})", __workflow_databaseId.WithUrlEncoding(1), __workflow_dimensionId.WithUrlEncoding(1), __workflow_elementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Element>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ViewsResponse, ApiConnectionActionConfiguration> Views(Expression<Func<int>> databaseId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ViewsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Views", __workflow_databaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<ViewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<View, ApiConnectionActionConfiguration> ViewById(Expression<Func<int>> databaseId, Expression<Func<string>> viewId)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            return new DeferredBodyAction<View, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Views({1})", __workflow_databaseId.WithUrlEncoding(1), __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<View>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ViewCellsResponse, ApiConnectionActionConfiguration> ViewCells(Expression<Func<int>> databaseId, Expression<Func<string>> viewId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null, Expression<Func<bool>> baseonly = null, Expression<Func<bool>> userules = null, Expression<Func<bool>> zerosupression = null, Expression<Func<bool>> disablepaging = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_baseonly = WorkflowExpression.Compile(baseonly, nameof(baseonly), required: false);
            var __workflow_userules = WorkflowExpression.Compile(userules, nameof(userules), required: false);
            var __workflow_zerosupression = WorkflowExpression.Compile(zerosupression, nameof(zerosupression), required: false);
            var __workflow_disablepaging = WorkflowExpression.Compile(disablepaging, nameof(disablepaging), required: false);
            return new DeferredBodyAction<ViewCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Databases({0})/Views({1})/Cells", __workflow_databaseId.WithUrlEncoding(1), __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["baseonly"] = Convert.ToString(false);
                if (__workflow_baseonly != null)
                    callPayload.Queries["baseonly"] = ExpressionConverter.Convert(__workflow_baseonly);
                callPayload.Queries["userules"] = Convert.ToString(false);
                if (__workflow_userules != null)
                    callPayload.Queries["userules"] = ExpressionConverter.Convert(__workflow_userules);
                callPayload.Queries["zerosupression"] = Convert.ToString(true);
                if (__workflow_zerosupression != null)
                    callPayload.Queries["zerosupression"] = ExpressionConverter.Convert(__workflow_zerosupression);
                callPayload.Queries["disablepaging"] = Convert.ToString(false);
                if (__workflow_disablepaging != null)
                    callPayload.Queries["disablepaging"] = ExpressionConverter.Convert(__workflow_disablepaging);
                return new ApiConnectionAction<ViewCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectGroupsResponse, ApiConnectionActionConfiguration> IntegratorProjectGroups(Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<IntegratorProjectGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Integrator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<IntegratorProjectGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectGroup, ApiConnectionActionConfiguration> IntegratorProjectsById(Expression<Func<string>> groupIdentifier)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            return new DeferredBodyAction<IntegratorProjectGroup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')", __workflow_groupIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorProjectGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectsResponse, ApiConnectionActionConfiguration> IntegratorProjects(Expression<Func<string>> groupIdentifier, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<IntegratorProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects", __workflow_groupIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<IntegratorProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProject, ApiConnectionActionConfiguration> IntegratorProjectsByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            return new DeferredBodyAction<IntegratorProject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ExtractsResponse, ApiConnectionActionConfiguration> Extracts(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ExtractsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Extracts", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<ExtractsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent, ApiConnectionActionConfiguration> ExtractByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> extractName)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_extractName = WorkflowExpression.Compile(extractName, nameof(extractName), required: true);
            return new DeferredBodyAction<IntegratorComponent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Extracts('{2}')", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_extractName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorComponent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ExtractRowsResponse, ApiConnectionActionConfiguration> ExtractRows(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> extractName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_extractName = WorkflowExpression.Compile(extractName, nameof(extractName), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ExtractRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Extracts('{2}')/Rows", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_extractName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<ExtractRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<JobsResponse, ApiConnectionActionConfiguration> Jobs(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<JobsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Jobs", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<JobsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent, ApiConnectionActionConfiguration> JobByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> jobName)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            return new DeferredBodyAction<IntegratorComponent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_jobName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorComponent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult, ApiConnectionActionConfiguration> RunJob(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> jobName)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            return new DeferredBodyAction<IntegratorRunResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')/Run", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_jobName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorRunResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult, ApiConnectionActionConfiguration> RunJobWithVariables(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> jobName, Expression<Func<string>> variables)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_variables = WorkflowExpression.Compile(variables, nameof(variables), required: true);
            return new DeferredBodyAction<IntegratorRunResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')/Run(Variables='{3}')", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_jobName.WithUrlEncoding(1), __workflow_variables.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorRunResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<LoadsResponse, ApiConnectionActionConfiguration> Loads(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<LoadsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Loads", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<LoadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent, ApiConnectionActionConfiguration> LoadByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> loadName)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_loadName = WorkflowExpression.Compile(loadName, nameof(loadName), required: true);
            return new DeferredBodyAction<IntegratorComponent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Loads('{2}')", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_loadName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorComponent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult, ApiConnectionActionConfiguration> RunLoad(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> loadName)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_loadName = WorkflowExpression.Compile(loadName, nameof(loadName), required: true);
            return new DeferredBodyAction<IntegratorRunResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Loads('{2}')/Run()", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_loadName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorRunResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult, ApiConnectionActionConfiguration> RunLoadWithVariables(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> loadName, Expression<Func<string>> variables)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_loadName = WorkflowExpression.Compile(loadName, nameof(loadName), required: true);
            var __workflow_variables = WorkflowExpression.Compile(variables, nameof(variables), required: true);
            return new DeferredBodyAction<IntegratorRunResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Loads('{2}')/Run(Variables='{3}')", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_loadName.WithUrlEncoding(1), __workflow_variables.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorRunResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<TransformsResponse, ApiConnectionActionConfiguration> Transforms(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<TransformsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Transforms", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<TransformsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent, ApiConnectionActionConfiguration> TransformByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> transformName)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_transformName = WorkflowExpression.Compile(transformName, nameof(transformName), required: true);
            return new DeferredBodyAction<IntegratorComponent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Transforms('{2}')", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_transformName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntegratorComponent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<TransformRowsResponse, ApiConnectionActionConfiguration> TransformRows(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> transformName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var __workflow_groupIdentifier = WorkflowExpression.Compile(groupIdentifier, nameof(groupIdentifier), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_transformName = WorkflowExpression.Compile(transformName, nameof(transformName), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<TransformRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Integrator('{0}')/Projects('{1}')/Transforms('{2}')/Rows", __workflow_groupIdentifier.WithUrlEncoding(1), __workflow_projectName.WithUrlEncoding(1), __workflow_transformName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<TransformRowsResponse>(callPayload);
            });
        }
    }

    public class JedoxodatahubTriggers([ConnectionName] string connectionId)
    {
    }

    public class DatabasesResponse
    {
        [JsonProperty("value")]
        public Database[] Value { get; set; }
    }

    public class Database
    {
        public int CubeCount { get; set; }
        public int DimensionCount { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class CubesResponse
    {
        [JsonProperty("value")]
        public Cube[] Value { get; set; }
    }

    public class Cube
    {
        public int FilledCellCount { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class CubeCellsResponse
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public class DimensionsResponse
    {
        [JsonProperty("value")]
        public Dimension[] Value { get; set; }
    }

    public class Dimension
    {
        public int ElementCount { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class ElementsResponse
    {
        [JsonProperty("value")]
        public Element[] Value { get; set; }
    }

    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
    }

    public class ViewsResponse
    {
        [JsonProperty("value")]
        public View[] Value { get; set; }
    }

    public class View
    {
        public string CreationDate { get; set; }
        public int CubeId { get; set; }
        public string CubeName { get; set; }
        public string Description { get; set; }
        public string FriendlyName { get; set; }
        public bool Global { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
    }

    public class ViewCellsResponse
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public class IntegratorProjectGroupsResponse
    {
        [JsonProperty("value")]
        public IntegratorProjectGroup[] Value { get; set; }
    }

    public class IntegratorProjectGroup
    {
        public string Description { get; set; }
        public string Developer { get; set; }
        public string FriendlyName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Version { get; set; }
    }

    public class IntegratorProjectsResponse
    {
        [JsonProperty("value")]
        public IntegratorProject[] Value { get; set; }
    }

    public class IntegratorProject
    {
        public string Description { get; set; }
        public string ModificationDate { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
    }

    public class ExtractsResponse
    {
        [JsonProperty("value")]
        public IntegratorComponent[] Value { get; set; }
    }

    public class IntegratorComponent
    {
        public string Description { get; set; }
        public string ModificationDate { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class ExtractRowsResponse
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public class JobsResponse
    {
        [JsonProperty("value")]
        public IntegratorComponent[] Value { get; set; }
    }

    public class IntegratorRunResult
    {
        [JsonProperty("errors")]
        public int Errors { get; set; }

        [JsonProperty("executionType")]
        public string ExecutionType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("traceAvailable")]
        public bool TraceAvailable { get; set; }

        [JsonProperty("warnings")]
        public int Warnings { get; set; }
    }

    public class LoadsResponse
    {
        [JsonProperty("value")]
        public IntegratorComponent[] Value { get; set; }
    }

    public class TransformsResponse
    {
        [JsonProperty("value")]
        public IntegratorComponent[] Value { get; set; }
    }

    public class TransformRowsResponse
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jedoxodatahub;

    public partial class WorkflowManagedActions
    {
        public JedoxodatahubActions Jedoxodatahub(string connectionId) => new JedoxodatahubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JedoxodatahubTriggers Jedoxodatahub(string connectionId) => new JedoxodatahubTriggers(connectionId);
    }
}