//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jedoxodatahub
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JedoxodatahubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<DatabasesResponse> Databases([WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Databases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<DatabasesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Database> DatabaseById([WorkflowExpression] Func<int> databaseId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Database>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<CubesResponse> Cubes([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Cubes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<CubesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Cube> CubeById([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<int> cubeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Cubes({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(cubeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Cube>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<CubeCellsResponse> CubeCells([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<int> cubeId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<bool> baseonly = null, [WorkflowExpression] Func<bool> userules = null, [WorkflowExpression] Func<bool> zerosupression = null, [WorkflowExpression] Func<bool> disablepaging = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Cubes({1})/Cells", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(cubeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["baseonly"] = Convert.ToString(true);
                if (baseonly != null)
                    callPayload.Queries["baseonly"] = SourceExpressionConverter.ConvertO(baseonly);
                callPayload.Queries["userules"] = Convert.ToString(false);
                if (userules != null)
                    callPayload.Queries["userules"] = SourceExpressionConverter.ConvertO(userules);
                callPayload.Queries["zerosupression"] = Convert.ToString(true);
                if (zerosupression != null)
                    callPayload.Queries["zerosupression"] = SourceExpressionConverter.ConvertO(zerosupression);
                callPayload.Queries["disablepaging"] = Convert.ToString(false);
                if (disablepaging != null)
                    callPayload.Queries["disablepaging"] = SourceExpressionConverter.ConvertO(disablepaging);
                return callPayload;
            }

            return new ApiConnectionAction<CubeCellsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<DimensionsResponse> Dimensions([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Dimensions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<DimensionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Dimension> DimensionById([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<int> dimensionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Dimensions({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dimensionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Dimension>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ElementsResponse> Elements([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<int> dimensionId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Dimensions({1})/Elements", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dimensionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<ElementsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Element> ElementById([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<int> dimensionId, [WorkflowExpression] Func<int> elementId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Dimensions({1})/Elements({2})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dimensionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(elementId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Element>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ViewsResponse> Views([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Views", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<ViewsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<View> ViewById([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<string> viewId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Views({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(viewId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<View>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ViewCellsResponse> ViewCells([WorkflowExpression] Func<int> databaseId, [WorkflowExpression] Func<string> viewId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<bool> baseonly = null, [WorkflowExpression] Func<bool> userules = null, [WorkflowExpression] Func<bool> zerosupression = null, [WorkflowExpression] Func<bool> disablepaging = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Databases({0})/Views({1})/Cells", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(viewId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["baseonly"] = Convert.ToString(false);
                if (baseonly != null)
                    callPayload.Queries["baseonly"] = SourceExpressionConverter.ConvertO(baseonly);
                callPayload.Queries["userules"] = Convert.ToString(false);
                if (userules != null)
                    callPayload.Queries["userules"] = SourceExpressionConverter.ConvertO(userules);
                callPayload.Queries["zerosupression"] = Convert.ToString(true);
                if (zerosupression != null)
                    callPayload.Queries["zerosupression"] = SourceExpressionConverter.ConvertO(zerosupression);
                callPayload.Queries["disablepaging"] = Convert.ToString(false);
                if (disablepaging != null)
                    callPayload.Queries["disablepaging"] = SourceExpressionConverter.ConvertO(disablepaging);
                return callPayload;
            }

            return new ApiConnectionAction<ViewCellsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectGroupsResponse> IntegratorProjectGroups([WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Integrator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorProjectGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectGroup> IntegratorProjectsById([WorkflowExpression] Func<string> groupIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorProjectGroup>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectsResponse> IntegratorProjects([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProject> IntegratorProjectsByName([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorProject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ExtractsResponse> Extracts([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Extracts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<ExtractsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent> ExtractByName([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> extractName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Extracts('{2}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(extractName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorComponent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ExtractRowsResponse> ExtractRows([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> extractName, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Extracts('{2}')/Rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(extractName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<ExtractRowsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<JobsResponse> Jobs([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Jobs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<JobsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent> JobByName([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> jobName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorComponent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult> RunJob([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> jobName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')/Run", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorRunResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult> RunJobWithVariables([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<string> variables)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')/Run(Variables='{3}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(variables, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorRunResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<LoadsResponse> Loads([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Loads", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<LoadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent> LoadByName([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> loadName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Loads('{2}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(loadName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorComponent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult> RunLoad([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> loadName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Loads('{2}')/Run()", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(loadName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorRunResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult> RunLoadWithVariables([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> loadName, [WorkflowExpression] Func<string> variables)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Loads('{2}')/Run(Variables='{3}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(loadName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(variables, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorRunResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<TransformsResponse> Transforms([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Transforms", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<TransformsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent> TransformByName([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> transformName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Transforms('{2}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transformName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntegratorComponent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<TransformRowsResponse> TransformRows([WorkflowExpression] Func<string> groupIdentifier, [WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> transformName, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Integrator('{0}')/Projects('{1}')/Transforms('{2}')/Rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdentifier, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transformName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<TransformRowsResponse>(BuildSourceInput);
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