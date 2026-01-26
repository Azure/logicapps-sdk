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
        public IBodyWorkflowAction<DataSourceInfo[]> DatasourcesList(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/Datasources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<DataSourceInfo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataSource> DatasourcesDetails(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/v1/Datasources/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataSource>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataValuesPaged> DatasourcesValues(Expression<Func<int>> id, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null)
        {
            var apiCallPath = String.Format("/v1/Datasources/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (from != null)
                callPayload.Queries["from"] = ExpressionConverter.Convert(from);
            if (to != null)
                callPayload.Queries["to"] = ExpressionConverter.Convert(to);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            return new ApiConnectionAction<DataValuesPaged>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<DataValue> DatasourcesDatasourceCreateValue(Expression<Func<int>> id, Expression<Func<double>> bodyvalue, Expression<Func<string>> bodyvalueDate, Expression<Func<int>> bodyareaId = null, Expression<Func<int>> bodyassetId = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydimension = null, Expression<Func<string>> bodydimension2 = null, Expression<Func<string>> bodydimension3 = null, Expression<Func<string>> bodydimension4 = null, Expression<Func<string>> bodyexternalId = null)
        {
            var apiCallPath = String.Format("/v1/Datasources/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyareaId != null)
            {
                body["areaId"] = ExpressionConverter.ConvertO(bodyareaId);
                bodypropCount++;
            }

            if (bodyassetId != null)
            {
                body["assetId"] = ExpressionConverter.ConvertO(bodyassetId);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodydimension != null)
            {
                body["dimension"] = ExpressionConverter.ConvertO(bodydimension);
                bodypropCount++;
            }

            if (bodydimension2 != null)
            {
                body["dimension2"] = ExpressionConverter.ConvertO(bodydimension2);
                bodypropCount++;
            }

            if (bodydimension3 != null)
            {
                body["dimension3"] = ExpressionConverter.ConvertO(bodydimension3);
                bodypropCount++;
            }

            if (bodydimension4 != null)
            {
                body["dimension4"] = ExpressionConverter.ConvertO(bodydimension4);
                bodypropCount++;
            }

            bodypropCount++;
            body["valueDate"] = ExpressionConverter.ConvertO(bodyvalueDate);
            if (bodyexternalId != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DataValue>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IWorkflowAction DatasourcesDatasourceDeleteValue(Expression<Func<int>> id, Expression<Func<int>> valueId)
        {
            var apiCallPath = String.Format("/v1/Datasources/{0}/values/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(valueId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksDetails(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/v1/Tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksDelete(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/v1/Tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksUpdate(Expression<Func<int>> id, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyexternalId = null, Expression<Func<int>> bodyboardId = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyresponsibleUserId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyrowCategoryId = null, Expression<Func<int>> bodycolumnCategoryId = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = String.Format("/v1/Tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyexternalId != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                bodypropCount++;
            }

            if (bodyboardId != null)
            {
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                bodypropCount++;
            }

            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyresponsibleUserId != null)
            {
                body["responsibleUserId"] = ExpressionConverter.ConvertO(bodyresponsibleUserId);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyrowCategoryId != null)
            {
                body["rowCategoryId"] = ExpressionConverter.ConvertO(bodyrowCategoryId);
                bodypropCount++;
            }

            if (bodycolumnCategoryId != null)
            {
                body["columnCategoryId"] = ExpressionConverter.ConvertO(bodycolumnCategoryId);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksCreate(Expression<Func<string>> bodytitle, Expression<Func<string>> bodyexternalId = null, Expression<Func<int>> bodyboardId = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyresponsibleUserId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyrowCategoryId = null, Expression<Func<int>> bodycolumnCategoryId = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = "/v1/Tasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyexternalId != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                bodypropCount++;
            }

            if (bodyboardId != null)
            {
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                bodypropCount++;
            }

            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyresponsibleUserId != null)
            {
                body["responsibleUserId"] = ExpressionConverter.ConvertO(bodyresponsibleUserId);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyrowCategoryId != null)
            {
                body["rowCategoryId"] = ExpressionConverter.ConvertO(bodyrowCategoryId);
                bodypropCount++;
            }

            if (bodycolumnCategoryId != null)
            {
                body["columnCategoryId"] = ExpressionConverter.ConvertO(bodycolumnCategoryId);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digileanconnect")]
        public IBodyWorkflowAction<TaskInfo> TasksCreateSubTask(Expression<Func<int>> id, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyexternalId = null, Expression<Func<int>> bodyboardId = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyresponsibleUserId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyrowCategoryId = null, Expression<Func<int>> bodycolumnCategoryId = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = String.Format("/v1/Tasks/{0}/SubTasks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyexternalId != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                bodypropCount++;
            }

            if (bodyboardId != null)
            {
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                bodypropCount++;
            }

            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyresponsibleUserId != null)
            {
                body["responsibleUserId"] = ExpressionConverter.ConvertO(bodyresponsibleUserId);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyrowCategoryId != null)
            {
                body["rowCategoryId"] = ExpressionConverter.ConvertO(bodyrowCategoryId);
                bodypropCount++;
            }

            if (bodycolumnCategoryId != null)
            {
                body["columnCategoryId"] = ExpressionConverter.ConvertO(bodycolumnCategoryId);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskInfo>(callPayload);
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