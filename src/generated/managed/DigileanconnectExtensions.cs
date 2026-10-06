//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Digileanconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DigileanconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataSourceInfo[]> DatasourcesList([WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Datasources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<DataSourceInfo[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataSource> DatasourcesDetails([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Datasources/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DataSource>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataValuesPaged> DatasourcesValues([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Datasources/{0}/values", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                return callPayload;
            }

            return new ApiConnectionAction<DataValuesPaged>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataValue> DatasourcesDatasourceCreateValue([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<double> bodyvalue, [WorkflowExpression] Func<string> bodyvalueDate, [WorkflowExpression] Func<int> bodyareaId = null, [WorkflowExpression] Func<int> bodyassetId = null, [WorkflowExpression] Func<int> bodyprojectId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydimension = null, [WorkflowExpression] Func<string> bodydimension2 = null, [WorkflowExpression] Func<string> bodydimension3 = null, [WorkflowExpression] Func<string> bodydimension4 = null, [WorkflowExpression] Func<string> bodyexternalId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Datasources/{0}/values", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyareaId != null)
                {
                    body["areaId"] = SourceExpressionConverter.ConvertToken(bodyareaId);
                    bodypropCount++;
                }

                if (bodyassetId != null)
                {
                    body["assetId"] = SourceExpressionConverter.ConvertToken(bodyassetId);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydimension != null)
                {
                    body["dimension"] = SourceExpressionConverter.ConvertToken(bodydimension);
                    bodypropCount++;
                }

                if (bodydimension2 != null)
                {
                    body["dimension2"] = SourceExpressionConverter.ConvertToken(bodydimension2);
                    bodypropCount++;
                }

                if (bodydimension3 != null)
                {
                    body["dimension3"] = SourceExpressionConverter.ConvertToken(bodydimension3);
                    bodypropCount++;
                }

                if (bodydimension4 != null)
                {
                    body["dimension4"] = SourceExpressionConverter.ConvertToken(bodydimension4);
                    bodypropCount++;
                }

                bodypropCount++;
                body["valueDate"] = SourceExpressionConverter.ConvertToken(bodyvalueDate);
                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DataValue>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IWorkflowAction DatasourcesDatasourceDeleteValue([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> valueId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Datasources/{0}/values/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(valueId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksDetails([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksDelete([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksUpdate([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<int> bodyboardId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyresponsibleUserId = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<int> bodyrowCategoryId = null, [WorkflowExpression] Func<int> bodycolumnCategoryId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyresponsibleUserId != null)
                {
                    body["responsibleUserId"] = SourceExpressionConverter.ConvertToken(bodyresponsibleUserId);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyrowCategoryId != null)
                {
                    body["rowCategoryId"] = SourceExpressionConverter.ConvertToken(bodyrowCategoryId);
                    bodypropCount++;
                }

                if (bodycolumnCategoryId != null)
                {
                    body["columnCategoryId"] = SourceExpressionConverter.ConvertToken(bodycolumnCategoryId);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksCreate([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<int> bodyboardId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyresponsibleUserId = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<int> bodyrowCategoryId = null, [WorkflowExpression] Func<int> bodycolumnCategoryId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyresponsibleUserId != null)
                {
                    body["responsibleUserId"] = SourceExpressionConverter.ConvertToken(bodyresponsibleUserId);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyrowCategoryId != null)
                {
                    body["rowCategoryId"] = SourceExpressionConverter.ConvertToken(bodyrowCategoryId);
                    bodypropCount++;
                }

                if (bodycolumnCategoryId != null)
                {
                    body["columnCategoryId"] = SourceExpressionConverter.ConvertToken(bodycolumnCategoryId);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksCreateSubTask([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<int> bodyboardId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyresponsibleUserId = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<int> bodyrowCategoryId = null, [WorkflowExpression] Func<int> bodycolumnCategoryId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Tasks/{0}/SubTasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyresponsibleUserId != null)
                {
                    body["responsibleUserId"] = SourceExpressionConverter.ConvertToken(bodyresponsibleUserId);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyrowCategoryId != null)
                {
                    body["rowCategoryId"] = SourceExpressionConverter.ConvertToken(bodyrowCategoryId);
                    bodypropCount++;
                }

                if (bodycolumnCategoryId != null)
                {
                    body["columnCategoryId"] = SourceExpressionConverter.ConvertToken(bodycolumnCategoryId);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskInfo>(BuildSourceInput);
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

    public enum TaskStatus
    {
        NotStarted,
        Completed,
        Blocked
    }

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