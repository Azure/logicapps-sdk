//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Riskiqdigitalfootprint
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RiskiqdigitalfootprintActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<Tag[], ApiConnectionActionConfiguration> Tags()
        {
            return new DeferredBodyAction<Tag[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Tag[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<SavedSearch[], ApiConnectionActionConfiguration> SavedSearches()
        {
            return new DeferredBodyAction<SavedSearch[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/savedsearches";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SavedSearch[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<Brand[], ApiConnectionActionConfiguration> Brands()
        {
            return new DeferredBodyAction<Brand[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/brands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Brand[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<Organization[], ApiConnectionActionConfiguration> Organizations()
        {
            return new DeferredBodyAction<Organization[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Organization[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<GlobalInventoryDeltasSummaryResponseItem[], ApiConnectionActionConfiguration> DeltasSummary(Expression<Func<string>> date = null, Expression<Func<RangeInput>> range = null, Expression<Func<string>> brand = null, Expression<Func<string>> organization = null, Expression<Func<string>> tag = null)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_range = WorkflowExpression.Compile(range, nameof(range), required: false);
            var __workflow_brand = WorkflowExpression.Compile(brand, nameof(brand), required: false);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            return new DeferredBodyAction<GlobalInventoryDeltasSummaryResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/deltas/summary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["range"] = Convert.ToString(1);
                if (__workflow_range != null)
                    callPayload.Queries["range"] = ExpressionConverter.Convert(__workflow_range);
                if (__workflow_brand != null)
                    callPayload.Queries["brand"] = ExpressionConverter.Convert(__workflow_brand);
                if (__workflow_organization != null)
                    callPayload.Queries["organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                return new ApiConnectionAction<GlobalInventoryDeltasSummaryResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<ApeHit[], ApiConnectionActionConfiguration> NewlyOpenedPorts(Expression<Func<PeriodInput>> period = null, Expression<Func<string>> ports = null, Expression<Func<string>> excludedPorts = null, Expression<Func<int>> after = null, Expression<Func<bool>> stream = null, Expression<Func<int>> size = null)
        {
            var __workflow_period = WorkflowExpression.Compile(period, nameof(period), required: false);
            var __workflow_ports = WorkflowExpression.Compile(ports, nameof(ports), required: false);
            var __workflow_excludedPorts = WorkflowExpression.Compile(excludedPorts, nameof(excludedPorts), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_stream = WorkflowExpression.Compile(stream, nameof(stream), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ApeHit[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/ape/hit/nop";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_period != null)
                    callPayload.Queries["period"] = ExpressionConverter.Convert(__workflow_period);
                if (__workflow_ports != null)
                    callPayload.Queries["ports"] = ExpressionConverter.Convert(__workflow_ports);
                if (__workflow_excludedPorts != null)
                    callPayload.Queries["excludedPorts"] = ExpressionConverter.Convert(__workflow_excludedPorts);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_stream != null)
                    callPayload.Queries["stream"] = ExpressionConverter.Convert(__workflow_stream);
                callPayload.Queries["size"] = Convert.ToString(100);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ApeHit[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetRecentSearch(Expression<Func<int>> savedSearchId = null, Expression<Func<string>> savedSearchName = null, Expression<Func<bool>> @global = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_savedSearchId = WorkflowExpression.Compile(savedSearchId, nameof(savedSearchId), required: false);
            var __workflow_savedSearchName = WorkflowExpression.Compile(savedSearchName, nameof(savedSearchName), required: false);
            var __workflow_global = WorkflowExpression.Compile(@global, nameof(@global), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_savedSearchId != null)
                    callPayload.Queries["savedSearchID"] = ExpressionConverter.Convert(__workflow_savedSearchId);
                if (__workflow_savedSearchName != null)
                    callPayload.Queries["savedSearchName"] = ExpressionConverter.Convert(__workflow_savedSearchName);
                callPayload.Queries["global"] = Convert.ToString(false);
                if (__workflow_global != null)
                    callPayload.Queries["global"] = ExpressionConverter.Convert(__workflow_global);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(20);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SearchRecent(Expression<Func<object>> query, Expression<Func<bool>> @global = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_global = WorkflowExpression.Compile(@global, nameof(@global), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["global"] = Convert.ToString(false);
                if (__workflow_global != null)
                    callPayload.Queries["global"] = ExpressionConverter.Convert(__workflow_global);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(20);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ConnectedAssetsByType(Expression<Func<AssetTypeTypeInput>> type, Expression<Func<string>> name, Expression<Func<bool>> @global = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_global = WorkflowExpression.Compile(@global, nameof(@global), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/globalinventory/assets/{0}/connected", __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["global"] = Convert.ToString(false);
                if (__workflow_global != null)
                    callPayload.Queries["global"] = ExpressionConverter.Convert(__workflow_global);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<TaskResponse, ApiConnectionActionConfiguration> CancelTask(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/globalinventory/task/{0}/cancel", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AssetsAdd(Expression<Func<object>> request, Expression<Func<bool>> failOnError = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            var __workflow_failOnError = WorkflowExpression.Compile(failOnError, nameof(failOnError), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/assets/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["failOnError"] = Convert.ToString(true);
                if (__workflow_failOnError != null)
                    callPayload.Queries["failOnError"] = ExpressionConverter.Convert(__workflow_failOnError);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> BulkRetrieve(Expression<Func<object>> assets)
        {
            var __workflow_assets = WorkflowExpression.Compile(assets, nameof(assets), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/assets/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_assets);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<TaskResponse, ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/globalinventory/task/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<GlobalInventoryDeltasResponse, ApiConnectionActionConfiguration> Deltas(Expression<Func<DeltasTypeInput>> type = null, Expression<Func<string>> date = null, Expression<Func<int>> range = null, Expression<Func<MeasureInput>> measure = null, Expression<Func<string>> brand = null, Expression<Func<string>> organization = null, Expression<Func<string>> tag = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_range = WorkflowExpression.Compile(range, nameof(range), required: false);
            var __workflow_measure = WorkflowExpression.Compile(measure, nameof(measure), required: false);
            var __workflow_brand = WorkflowExpression.Compile(brand, nameof(brand), required: false);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<GlobalInventoryDeltasResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/deltas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["range"] = Convert.ToString(1);
                if (__workflow_range != null)
                    callPayload.Queries["range"] = ExpressionConverter.Convert(__workflow_range);
                callPayload.Queries["measure"] = Convert.ToString("ADDED");
                if (__workflow_measure != null)
                    callPayload.Queries["measure"] = ExpressionConverter.Convert(__workflow_measure);
                if (__workflow_brand != null)
                    callPayload.Queries["brand"] = ExpressionConverter.Convert(__workflow_brand);
                if (__workflow_organization != null)
                    callPayload.Queries["organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(20);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<GlobalInventoryDeltasResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AssetType(Expression<Func<AssetTypeTypeInput>> type, Expression<Func<string>> name, Expression<Func<bool>> @global = null, Expression<Func<int>> size = null, Expression<Func<bool>> recent = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_global = WorkflowExpression.Compile(@global, nameof(@global), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_recent = WorkflowExpression.Compile(recent, nameof(recent), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/globalinventory/assets/{0}", __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["global"] = Convert.ToString(false);
                if (__workflow_global != null)
                    callPayload.Queries["global"] = ExpressionConverter.Convert(__workflow_global);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["recent"] = Convert.ToString(false);
                if (__workflow_recent != null)
                    callPayload.Queries["recent"] = ExpressionConverter.Convert(__workflow_recent);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AssetId(Expression<Func<string>> uuid, Expression<Func<bool>> @global = null, Expression<Func<bool>> recent = null)
        {
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: true);
            var __workflow_global = WorkflowExpression.Compile(@global, nameof(@global), required: false);
            var __workflow_recent = WorkflowExpression.Compile(recent, nameof(recent), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/globalinventory/assets/id/{0}", __workflow_uuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["global"] = Convert.ToString(false);
                if (__workflow_global != null)
                    callPayload.Queries["global"] = ExpressionConverter.Convert(__workflow_global);
                callPayload.Queries["recent"] = Convert.ToString(false);
                if (__workflow_recent != null)
                    callPayload.Queries["recent"] = ExpressionConverter.Convert(__workflow_recent);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AssetsUpdate(Expression<Func<object>> request, Expression<Func<bool>> failOnError = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            var __workflow_failOnError = WorkflowExpression.Compile(failOnError, nameof(failOnError), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["failOnError"] = Convert.ToString(true);
                if (__workflow_failOnError != null)
                    callPayload.Queries["failOnError"] = ExpressionConverter.Convert(__workflow_failOnError);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SearchHistory(Expression<Func<object>> query, Expression<Func<bool>> @global = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<bool>> recent = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_global = WorkflowExpression.Compile(@global, nameof(@global), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_recent = WorkflowExpression.Compile(recent, nameof(recent), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/search/history";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["global"] = Convert.ToString(false);
                if (__workflow_global != null)
                    callPayload.Queries["global"] = ExpressionConverter.Convert(__workflow_global);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(20);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["recent"] = Convert.ToString(false);
                if (__workflow_recent != null)
                    callPayload.Queries["recent"] = ExpressionConverter.Convert(__workflow_recent);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqdigitalfootprint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateHistory(Expression<Func<object>> request, Expression<Func<bool>> failOnError = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            var __workflow_failOnError = WorkflowExpression.Compile(failOnError, nameof(failOnError), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/globalinventory/update/history";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FailOnError"] = Convert.ToString(true);
                if (__workflow_failOnError != null)
                    callPayload.Queries["FailOnError"] = ExpressionConverter.Convert(__workflow_failOnError);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class RiskiqdigitalfootprintTriggers([ConnectionName] string connectionId)
    {
    }

    public class Tag
    {
        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public int UpdatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("workspaceTagID")]
        public int WorkspaceTagId { get; set; }

        [JsonProperty("workspaceTagType")]
        public string WorkspaceTagType { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("workspaceID")]
        public int WorkspaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class SavedSearch
    {
        [JsonProperty("savedSearchID")]
        public int SavedSearchId { get; set; }

        [JsonProperty("globalSearch")]
        public bool GlobalSearch { get; set; }

        [JsonProperty("savedSearchName")]
        public string SavedSearchName { get; set; }

        [JsonProperty("workspaceSearch")]
        public bool WorkspaceSearch { get; set; }
    }

    public class Brand
    {
        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public int UpdatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("workspaceBrandID")]
        public int WorkspaceBrandId { get; set; }

        [JsonProperty("workspaceID")]
        public int WorkspaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class Organization
    {
        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public int UpdatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("workspaceOrganizationID")]
        public int WorkspaceOrganizationId { get; set; }

        [JsonProperty("workspaceID")]
        public int WorkspaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class GlobalInventoryDeltasSummaryResponseItem
    {
        [JsonProperty("runDate")]
        public string RunDate { get; set; }

        [JsonProperty("deltas")]
        public DeltaSummary[] Deltas { get; set; }
    }

    public class DeltaSummary
    {
        [JsonProperty("type")]
        public DeltaSummaryTypeType Type { get; set; }

        [JsonProperty("aggregations")]
        public Aggregation[] Aggregations { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeltaSummaryTypeType
    {
        CONTACT,
        [EnumMember(Value = "SSL_CERT")]
        SSLCERT,
        [EnumMember(Value = "MAIL_SERVER")]
        MAILSERVER,
        [EnumMember(Value = "IP_BLOCK")]
        IPBLOCK,
        PAGE,
        AS,
        DOMAIN,
        [EnumMember(Value = "IP_ADDRESS")]
        IPADDRESS,
        HOST,
        [EnumMember(Value = "NAME_SERVER")]
        NAMESERVER,
        [EnumMember(Value = "SELF_HOSTED_RESOURCE")]
        SELFHOSTEDRESOURCE,
        [EnumMember(Value = "THIRDPARTY_HOSTED_RESOURCE")]
        THIRDPARTYHOSTEDRESOURCE
    }

    public class Aggregation
    {
        [JsonProperty("removed")]
        public int Removed { get; set; }

        [JsonProperty("added")]
        public int Added { get; set; }

        [JsonProperty("changed")]
        public int Changed { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("range")]
        public AggregationRangeType Range { get; set; }

        [JsonProperty("difference")]
        public int Difference { get; set; }
    }

    public enum AggregationRangeType
    {
        _1 = 1,
        _7 = 7,
        _30 = 30
    }

    public enum RangeInput
    {
        _1 = 1,
        _7 = 7,
        _30 = 30
    }

    public class ApeHit
    {
        [JsonProperty("workspaceId")]
        public int WorkspaceId { get; set; }

        [JsonProperty("policyId")]
        public string PolicyId { get; set; }

        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("asset")]
        public JToken Asset { get; set; }

        [JsonProperty("actions")]
        public ApeHitActionsTypeItem[] Actions { get; set; }

        [JsonProperty("metadata")]
        public ApeHitMetadataTypeItem[] Metadata { get; set; }

        [JsonProperty("storedAt")]
        public int StoredAt { get; set; }
    }

    public class ApeHitActionsTypeItem
    {
        [JsonProperty("actionId")]
        public int ActionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("actionParameters")]
        public string ActionParameters { get; set; }
    }

    public class ApeHitMetadataTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum PeriodInput
    {
        _7 = 7,
        _14 = 14,
        _30 = 30
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssetTypeTypeInput
    {
        Domain,
        Host,
        [EnumMember(Value = "IP_Address")]
        IPAddress,
        [EnumMember(Value = "IP_Block")]
        IPBlock,
        AS,
        Page,
        [EnumMember(Value = "SSL_Cert")]
        SSLCert,
        [EnumMember(Value = "Name_Server")]
        NameServer,
        [EnumMember(Value = "Mail_Server")]
        MailServer,
        Contact
    }

    public class TaskResponse
    {
        [JsonProperty("taskClass")]
        public string TaskClass { get; set; }

        [JsonProperty("userID")]
        public int UserId { get; set; }

        [JsonProperty("startedAt")]
        public int StartedAt { get; set; }

        [JsonProperty("completedAt")]
        public int CompletedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("key")]
        public TaskResponseKeyType Key { get; set; }

        [JsonProperty("data")]
        public TaskResponseDataType Data { get; set; }

        [JsonProperty("supportedActions")]
        public JToken[] SupportedActions { get; set; }

        [JsonProperty("polling")]
        public bool Polling { get; set; }
    }

    public class TaskResponseKeyType
    {
        [JsonProperty("workspaceID")]
        public int WorkspaceId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class TaskResponseDataType
    {
        [JsonProperty("targetAssetTypes")]
        public JToken[] TargetAssetTypes { get; set; }

        [JsonProperty("assets")]
        public AssetIdentifier[] Assets { get; set; }

        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        [JsonProperty("estimated")]
        public int Estimated { get; set; }

        [JsonProperty("apiToken")]
        public string ApiToken { get; set; }

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("requestLag")]
        public int RequestLag { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("totalUpdates")]
        public int TotalUpdates { get; set; }

        [JsonProperty("countersByType")]
        public JToken CountersByType { get; set; }

        [JsonProperty("processedUpdates")]
        public int ProcessedUpdates { get; set; }

        [JsonProperty("properties")]
        public JToken[] Properties { get; set; }
    }

    public class AssetIdentifier
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GlobalInventoryDeltasResponse
    {
        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("content")]
        public GlobalInventoryDeltasResponseContentTypeItem[] Content { get; set; }
    }

    public class GlobalInventoryDeltasResponseContentTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("runDate")]
        public string RunDate { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }

        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("autoconfirmed")]
        public bool Autoconfirmed { get; set; }

        [JsonProperty("enterprise")]
        public bool Enterprise { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("source")]
        public bool Source { get; set; }

        [JsonProperty("keystone")]
        public bool Keystone { get; set; }

        [JsonProperty("updatedAt")]
        public int UpdatedAt { get; set; }

        [JsonProperty("wildcard")]
        public bool Wildcard { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeltasTypeInput
    {
        Domain,
        Host,
        [EnumMember(Value = "IP_Address")]
        IPAddress,
        [EnumMember(Value = "IP_Block")]
        IPBlock,
        AS,
        Page,
        [EnumMember(Value = "SSL_Cert")]
        SSLCert,
        [EnumMember(Value = "Name_Server")]
        NameServer,
        [EnumMember(Value = "Mail_Server")]
        MailServer,
        Contact,
        [EnumMember(Value = "Self_Hosted_Resource")]
        SelfHostedResource,
        [EnumMember(Value = "ThirdParty_Hosted_Resource")]
        ThirdPartyHostedResource
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MeasureInput
    {
        ADDED,
        REMOVED
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Riskiqdigitalfootprint;

    public partial class WorkflowManagedActions
    {
        public RiskiqdigitalfootprintActions Riskiqdigitalfootprint(string connectionId) => new RiskiqdigitalfootprintActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RiskiqdigitalfootprintTriggers Riskiqdigitalfootprint(string connectionId) => new RiskiqdigitalfootprintTriggers(connectionId);
    }
}