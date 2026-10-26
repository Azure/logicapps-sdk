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
        public IBodyWorkflowAction<DataValue, ApiConnectionActionConfiguration> DatasourcesDatasourceCreateValue(Expression<Func<int>> id, Expression<Func<double>> bodyvalue, Expression<Func<string>> bodyvalueDate, Expression<Func<int>> bodyareaId = null, Expression<Func<int>> bodyassetId = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydimension = null, Expression<Func<string>> bodydimension2 = null, Expression<Func<string>> bodydimension3 = null, Expression<Func<string>> bodydimension4 = null, Expression<Func<string>> bodyexternalId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodyvalueDate = WorkflowExpression.Compile(bodyvalueDate, nameof(bodyvalueDate), required: true);
            var __workflow_bodyareaId = WorkflowExpression.Compile(bodyareaId, nameof(bodyareaId), required: false);
            var __workflow_bodyassetId = WorkflowExpression.Compile(bodyassetId, nameof(bodyassetId), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydimension = WorkflowExpression.Compile(bodydimension, nameof(bodydimension), required: false);
            var __workflow_bodydimension2 = WorkflowExpression.Compile(bodydimension2, nameof(bodydimension2), required: false);
            var __workflow_bodydimension3 = WorkflowExpression.Compile(bodydimension3, nameof(bodydimension3), required: false);
            var __workflow_bodydimension4 = WorkflowExpression.Compile(bodydimension4, nameof(bodydimension4), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            return new DeferredBodyAction<DataValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Datasources/{0}/values", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyareaId != null)
                {
                    body["areaId"] = ExpressionConverter.ConvertO(__workflow_bodyareaId);
                    bodypropCount++;
                }

                if (__workflow_bodyassetId != null)
                {
                    body["assetId"] = ExpressionConverter.ConvertO(__workflow_bodyassetId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodydimension != null)
                {
                    body["dimension"] = ExpressionConverter.ConvertO(__workflow_bodydimension);
                    bodypropCount++;
                }

                if (__workflow_bodydimension2 != null)
                {
                    body["dimension2"] = ExpressionConverter.ConvertO(__workflow_bodydimension2);
                    bodypropCount++;
                }

                if (__workflow_bodydimension3 != null)
                {
                    body["dimension3"] = ExpressionConverter.ConvertO(__workflow_bodydimension3);
                    bodypropCount++;
                }

                if (__workflow_bodydimension4 != null)
                {
                    body["dimension4"] = ExpressionConverter.ConvertO(__workflow_bodydimension4);
                    bodypropCount++;
                }

                bodypropCount++;
                body["valueDate"] = ExpressionConverter.ConvertO(__workflow_bodyvalueDate);
                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<TaskInfo, ApiConnectionActionConfiguration> TasksUpdate(Expression<Func<int>> id, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyexternalId = null, Expression<Func<int>> bodyboardId = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyresponsibleUserId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyrowCategoryId = null, Expression<Func<int>> bodycolumnCategoryId = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyresponsibleUserId = WorkflowExpression.Compile(bodyresponsibleUserId, nameof(bodyresponsibleUserId), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyrowCategoryId = WorkflowExpression.Compile(bodyrowCategoryId, nameof(bodyrowCategoryId), required: false);
            var __workflow_bodycolumnCategoryId = WorkflowExpression.Compile(bodycolumnCategoryId, nameof(bodycolumnCategoryId), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<TaskInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsibleUserId != null)
                {
                    body["responsibleUserId"] = ExpressionConverter.ConvertO(__workflow_bodyresponsibleUserId);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrowCategoryId != null)
                {
                    body["rowCategoryId"] = ExpressionConverter.ConvertO(__workflow_bodyrowCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodycolumnCategoryId != null)
                {
                    body["columnCategoryId"] = ExpressionConverter.ConvertO(__workflow_bodycolumnCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TaskInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo, ApiConnectionActionConfiguration> TasksCreate(Expression<Func<string>> bodytitle, Expression<Func<string>> bodyexternalId = null, Expression<Func<int>> bodyboardId = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyresponsibleUserId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyrowCategoryId = null, Expression<Func<int>> bodycolumnCategoryId = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyresponsibleUserId = WorkflowExpression.Compile(bodyresponsibleUserId, nameof(bodyresponsibleUserId), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyrowCategoryId = WorkflowExpression.Compile(bodyrowCategoryId, nameof(bodyrowCategoryId), required: false);
            var __workflow_bodycolumnCategoryId = WorkflowExpression.Compile(bodycolumnCategoryId, nameof(bodycolumnCategoryId), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<TaskInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsibleUserId != null)
                {
                    body["responsibleUserId"] = ExpressionConverter.ConvertO(__workflow_bodyresponsibleUserId);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrowCategoryId != null)
                {
                    body["rowCategoryId"] = ExpressionConverter.ConvertO(__workflow_bodyrowCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodycolumnCategoryId != null)
                {
                    body["columnCategoryId"] = ExpressionConverter.ConvertO(__workflow_bodycolumnCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TaskInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo, ApiConnectionActionConfiguration> TasksCreateSubTask(Expression<Func<int>> id, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyexternalId = null, Expression<Func<int>> bodyboardId = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyresponsibleUserId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyrowCategoryId = null, Expression<Func<int>> bodycolumnCategoryId = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyresponsibleUserId = WorkflowExpression.Compile(bodyresponsibleUserId, nameof(bodyresponsibleUserId), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyrowCategoryId = WorkflowExpression.Compile(bodyrowCategoryId, nameof(bodyrowCategoryId), required: false);
            var __workflow_bodycolumnCategoryId = WorkflowExpression.Compile(bodycolumnCategoryId, nameof(bodycolumnCategoryId), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<TaskInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Tasks/{0}/SubTasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsibleUserId != null)
                {
                    body["responsibleUserId"] = ExpressionConverter.ConvertO(__workflow_bodyresponsibleUserId);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrowCategoryId != null)
                {
                    body["rowCategoryId"] = ExpressionConverter.ConvertO(__workflow_bodyrowCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodycolumnCategoryId != null)
                {
                    body["columnCategoryId"] = ExpressionConverter.ConvertO(__workflow_bodycolumnCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        NotStarted,
        Completed,
        Blocked
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