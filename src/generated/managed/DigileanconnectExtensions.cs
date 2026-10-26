//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Digileanconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DigileanconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataSourceInfo[], ApiConnectionActionConfiguration> DatasourcesList(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<DataSourceInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Datasources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<DataSourceInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataSource, ApiConnectionActionConfiguration> DatasourcesDetails(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DataSource, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Datasources/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DataSource>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataValuesPaged, ApiConnectionActionConfiguration> DatasourcesValues(Expression<Func<int>> id, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<DataValuesPaged, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Datasources/{0}/values", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                return new ApiConnectionAction<DataValuesPaged>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataValue, ApiConnectionActionConfiguration> DatasourcesDatasourceCreateValue(Expression<Func<int>> id, Expression<Func<DatasourcesDatasourceCreateValueInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DataValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Datasources/{0}/values", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DataValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DatasourcesDatasourceDeleteValue(Expression<Func<int>> id, Expression<Func<int>> valueId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_valueId = WorkflowExpression.Compile(valueId, nameof(valueId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Datasources/{0}/values/{1}", __workflow_id.WithUrlEncoding(1), __workflow_valueId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo, ApiConnectionActionConfiguration> TasksDetails(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo, ApiConnectionActionConfiguration> TasksDelete(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo, ApiConnectionActionConfiguration> TasksUpdate(Expression<Func<int>> id, Expression<Func<TasksUpdateInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo, ApiConnectionActionConfiguration> TasksCreate(Expression<Func<TasksCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo, ApiConnectionActionConfiguration> TasksCreateSubTask(Expression<Func<int>> id, Expression<Func<TasksCreateSubTaskInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Tasks/{0}/SubTasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskInfo>(callPayload);
            });
        }
    }

    public class DigileanconnectTriggers([ConnectionName] string connectionId)
    {
    }

    public class DataSourceInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class DataSource
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("objectSource")]
        public string ObjectSource { get; set; }

        [JsonProperty("unitOfTime")]
        public string UnitOfTime { get; set; }

        [JsonProperty("primaryInputSource")]
        public string PrimaryInputSource { get; set; }

        [JsonProperty("elements")]
        public DataSourceElement[] Elements { get; set; }
    }

    public class DataSourceElement
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isMandatory")]
        public bool IsMandatory { get; set; }

        [JsonProperty("sourceColumn")]
        public string SourceColumn { get; set; }

        [JsonProperty("dataSourceId")]
        public int DataSourceId { get; set; }

        [JsonProperty("dataListId")]
        public int DataListId { get; set; }
    }

    public class DataValuesPaged
    {
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("pageNo")]
        public int PageNo { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("values")]
        public DataValue[] Values { get; set; }
    }

    public class DataValue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dataSourceId")]
        public int DataSourceId { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("areaId")]
        public int AreaId { get; set; }

        [JsonProperty("assetId")]
        public int AssetId { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dimension")]
        public string Dimension { get; set; }

        [JsonProperty("dimension2")]
        public string Dimension2 { get; set; }

        [JsonProperty("dimension3")]
        public string Dimension3 { get; set; }

        [JsonProperty("dimension4")]
        public string Dimension4 { get; set; }

        [JsonProperty("valueDate")]
        public string ValueDate { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class DatasourcesDatasourceCreateValueInput
    {
        [JsonProperty("areaId")]
        public int? AreaId { get; set; }

        [JsonProperty("assetId")]
        public int? AssetId { get; set; }

        [JsonProperty("projectId")]
        public int? ProjectId { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dimension")]
        public string Dimension { get; set; }

        [JsonProperty("dimension2")]
        public string Dimension2 { get; set; }

        [JsonProperty("dimension3")]
        public string Dimension3 { get; set; }

        [JsonProperty("dimension4")]
        public string Dimension4 { get; set; }

        [JsonProperty("valueDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ValueDate { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class TaskInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("responsibleUser")]
        public string ResponsibleUser { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("boardId")]
        public int BoardId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public TaskStatus Status { get; set; }

        [JsonProperty("responsibleUserId")]
        public string ResponsibleUserId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("rowCategoryId")]
        public int RowCategoryId { get; set; }

        [JsonProperty("columnCategoryId")]
        public int ColumnCategoryId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskStatus
    {
        NotStarted,
        Completed,
        Blocked
    }

    public class TasksUpdateInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("boardId")]
        public int? BoardId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public TaskStatus? Status { get; set; }

        [JsonProperty("responsibleUserId")]
        public string ResponsibleUserId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("rowCategoryId")]
        public int? RowCategoryId { get; set; }

        [JsonProperty("columnCategoryId")]
        public int? ColumnCategoryId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class TasksCreateInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("boardId")]
        public int? BoardId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public TaskStatus? Status { get; set; }

        [JsonProperty("responsibleUserId")]
        public string ResponsibleUserId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("rowCategoryId")]
        public int? RowCategoryId { get; set; }

        [JsonProperty("columnCategoryId")]
        public int? ColumnCategoryId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class TasksCreateSubTaskInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("boardId")]
        public int? BoardId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public TaskStatus? Status { get; set; }

        [JsonProperty("responsibleUserId")]
        public string ResponsibleUserId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("rowCategoryId")]
        public int? RowCategoryId { get; set; }

        [JsonProperty("columnCategoryId")]
        public int? ColumnCategoryId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Digileanconnect;

    public partial class WorkflowManagedActions
    {
        public DigileanconnectActions Digileanconnect(string connectionId) => new DigileanconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DigileanconnectTriggers Digileanconnect(string connectionId) => new DigileanconnectTriggers(connectionId);
    }
}