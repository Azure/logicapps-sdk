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
        public IBodyWorkflowAction<DatabasesResponse> Databases(Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/Databases";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<DatabasesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Database> DatabaseById(Expression<Func<int>> databaseId)
        {
            var apiCallPath = String.Format("/Databases({0})", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Database>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<CubesResponse> Cubes(Expression<Func<int>> databaseId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Databases({0})/Cubes", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<CubesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Cube> CubeById(Expression<Func<int>> databaseId, Expression<Func<int>> cubeId)
        {
            var apiCallPath = String.Format("/Databases({0})/Cubes({1})", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(cubeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Cube>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<CubeCellsResponse> CubeCells(Expression<Func<int>> databaseId, Expression<Func<int>> cubeId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null, Expression<Func<bool>> baseonly = null, Expression<Func<bool>> userules = null, Expression<Func<bool>> zerosupression = null, Expression<Func<bool>> disablepaging = null)
        {
            var apiCallPath = String.Format("/Databases({0})/Cubes({1})/Cells", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(cubeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["baseonly"] = Convert.ToString(true);
            if (baseonly != null)
                callPayload.Queries["baseonly"] = ExpressionConverter.Convert(baseonly);
            callPayload.Queries["userules"] = Convert.ToString(false);
            if (userules != null)
                callPayload.Queries["userules"] = ExpressionConverter.Convert(userules);
            callPayload.Queries["zerosupression"] = Convert.ToString(true);
            if (zerosupression != null)
                callPayload.Queries["zerosupression"] = ExpressionConverter.Convert(zerosupression);
            callPayload.Queries["disablepaging"] = Convert.ToString(false);
            if (disablepaging != null)
                callPayload.Queries["disablepaging"] = ExpressionConverter.Convert(disablepaging);
            return new ApiConnectionAction<CubeCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<DimensionsResponse> Dimensions(Expression<Func<int>> databaseId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Databases({0})/Dimensions", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<DimensionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Dimension> DimensionById(Expression<Func<int>> databaseId, Expression<Func<int>> dimensionId)
        {
            var apiCallPath = String.Format("/Databases({0})/Dimensions({1})", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(dimensionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Dimension>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ElementsResponse> Elements(Expression<Func<int>> databaseId, Expression<Func<int>> dimensionId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Databases({0})/Dimensions({1})/Elements", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(dimensionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<ElementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<Element> ElementById(Expression<Func<int>> databaseId, Expression<Func<int>> dimensionId, Expression<Func<int>> elementId)
        {
            var apiCallPath = String.Format("/Databases({0})/Dimensions({1})/Elements({2})", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(dimensionId, 1), ExpressionConverter.ConvertWithUrlEncoding(elementId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Element>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ViewsResponse> Views(Expression<Func<int>> databaseId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Databases({0})/Views", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<ViewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<View> ViewById(Expression<Func<int>> databaseId, Expression<Func<string>> viewId)
        {
            var apiCallPath = String.Format("/Databases({0})/Views({1})", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(viewId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<View>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ViewCellsResponse> ViewCells(Expression<Func<int>> databaseId, Expression<Func<string>> viewId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null, Expression<Func<bool>> baseonly = null, Expression<Func<bool>> userules = null, Expression<Func<bool>> zerosupression = null, Expression<Func<bool>> disablepaging = null)
        {
            var apiCallPath = String.Format("/Databases({0})/Views({1})/Cells", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(viewId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["baseonly"] = Convert.ToString(false);
            if (baseonly != null)
                callPayload.Queries["baseonly"] = ExpressionConverter.Convert(baseonly);
            callPayload.Queries["userules"] = Convert.ToString(false);
            if (userules != null)
                callPayload.Queries["userules"] = ExpressionConverter.Convert(userules);
            callPayload.Queries["zerosupression"] = Convert.ToString(true);
            if (zerosupression != null)
                callPayload.Queries["zerosupression"] = ExpressionConverter.Convert(zerosupression);
            callPayload.Queries["disablepaging"] = Convert.ToString(false);
            if (disablepaging != null)
                callPayload.Queries["disablepaging"] = ExpressionConverter.Convert(disablepaging);
            return new ApiConnectionAction<ViewCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectGroupsResponse> IntegratorProjectGroups(Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/Integrator";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<IntegratorProjectGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectGroup> IntegratorProjectsById(Expression<Func<string>> groupIdentifier)
        {
            var apiCallPath = String.Format("/Integrator('{0}')", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorProjectGroup>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProjectsResponse> IntegratorProjects(Expression<Func<string>> groupIdentifier, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<IntegratorProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorProject> IntegratorProjectsByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorProject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ExtractsResponse> Extracts(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Extracts", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<ExtractsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent> ExtractByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> extractName)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Extracts('{2}')", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(extractName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorComponent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<ExtractRowsResponse> ExtractRows(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> extractName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Extracts('{2}')/Rows", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(extractName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<ExtractRowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<JobsResponse> Jobs(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Jobs", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<JobsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent> JobByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> jobName)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(jobName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorComponent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult> RunJob(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> jobName)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')/Run", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(jobName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorRunResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult> RunJobWithVariables(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> jobName, Expression<Func<string>> variables)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Jobs('{2}')/Run(Variables='{3}')", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(jobName, 1), ExpressionConverter.ConvertWithUrlEncoding(variables, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorRunResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<LoadsResponse> Loads(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Loads", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<LoadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent> LoadByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> loadName)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Loads('{2}')", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(loadName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorComponent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult> RunLoad(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> loadName)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Loads('{2}')/Run()", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(loadName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorRunResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorRunResult> RunLoadWithVariables(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> loadName, Expression<Func<string>> variables)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Loads('{2}')/Run(Variables='{3}')", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(loadName, 1), ExpressionConverter.ConvertWithUrlEncoding(variables, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorRunResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<TransformsResponse> Transforms(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Transforms", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<TransformsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<IntegratorComponent> TransformByName(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> transformName)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Transforms('{2}')", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(transformName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IntegratorComponent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jedoxodatahub")]
        public IBodyWorkflowAction<TransformRowsResponse> TransformRows(Expression<Func<string>> groupIdentifier, Expression<Func<string>> projectName, Expression<Func<string>> transformName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/Integrator('{0}')/Projects('{1}')/Transforms('{2}')/Rows", ExpressionConverter.ConvertWithUrlEncoding(groupIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(projectName, 1), ExpressionConverter.ConvertWithUrlEncoding(transformName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<TransformRowsResponse>(callPayload);
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