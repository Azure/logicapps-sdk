//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datablend
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatablendActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<GroupSearch> GroupsSearch([WorkflowExpression] Func<int> bodyoffset = null, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<bodyordersInputItem[]> bodyorders = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/groups/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyoffset != null)
                {
                    if (bodyoffset != null)
                    {
                        body["offset"] = SourceExpressionConverter.ConvertToken(bodyoffset);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["offset"] = 0;
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    if (bodylimit != null)
                    {
                        body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 1;
                    bodypropCount++;
                }

                if (bodyorders != null)
                {
                    body["orders"] = SourceExpressionConverter.ConvertToken(bodyorders);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GroupSearch>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<QueryExecutionResults> GetQueryExecutionById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/query-executions/{0}/results", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QueryExecutionResults>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<WorkflowExecutionsSearch> WorkflowExecutionsSearch([WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<int> bodyoffset = null, [WorkflowExpression] Func<bodyordersInputItem[]> bodyorders = null, [WorkflowExpression] Func<string> bodypredicatepath = null, [WorkflowExpression] Func<string> bodypredicatevalue = null, [WorkflowExpression] Func<string> bodypredicatecomparator = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflow-executions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylimit != null)
                {
                    if (bodylimit != null)
                    {
                        body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 1;
                    bodypropCount++;
                }

                if (bodyoffset != null)
                {
                    if (bodyoffset != null)
                    {
                        body["offset"] = SourceExpressionConverter.ConvertToken(bodyoffset);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["offset"] = 0;
                    bodypropCount++;
                }

                if (bodyorders != null)
                {
                    body["orders"] = SourceExpressionConverter.ConvertToken(bodyorders);
                    bodypropCount++;
                }

                var predicateObject = new JObject();
                var predicateObjectpropCount = 0;
                if (bodypredicatepath != null)
                {
                    if (bodypredicatepath != null)
                    {
                        predicateObject["path"] = SourceExpressionConverter.ConvertToken(bodypredicatepath);
                        predicateObjectpropCount++;
                    }

                    predicateObjectpropCount++;
                }
                else
                {
                    predicateObject["path"] = "parent.id";
                    predicateObjectpropCount++;
                }

                if (bodypredicatevalue != null)
                {
                    predicateObject["value"] = SourceExpressionConverter.ConvertToken(bodypredicatevalue);
                    predicateObjectpropCount++;
                }

                if (bodypredicatecomparator != null)
                {
                    if (bodypredicatecomparator != null)
                    {
                        predicateObject["comparator"] = SourceExpressionConverter.ConvertToken(bodypredicatecomparator);
                        predicateObjectpropCount++;
                    }

                    predicateObjectpropCount++;
                }
                else
                {
                    predicateObject["comparator"] = "EqualTo";
                    predicateObjectpropCount++;
                }

                if (predicateObjectpropCount > 0)
                {
                    body["predicate"] = predicateObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowExecutionsSearch>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<WorkflowExecutions> WorkflowExecutions([WorkflowExpression] Func<string> bodyparentid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflow-executions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var parentObject = new JObject();
                var parentObjectpropCount = 0;
                if (bodyparentid != null)
                {
                    parentObject["id"] = SourceExpressionConverter.ConvertToken(bodyparentid);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    body["parent"] = parentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowExecutions>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<WorkflowsSearch> WorkflowsSearch([WorkflowExpression] Func<int> bodyoffset = null, [WorkflowExpression] Func<bodyordersInputItem[]> bodyorders = null, [WorkflowExpression] Func<string> bodypredicatepath = null, [WorkflowExpression] Func<string> bodypredicatevalue = null, [WorkflowExpression] Func<string> bodypredicatecomparator = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflows/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyoffset != null)
                {
                    if (bodyoffset != null)
                    {
                        body["offset"] = SourceExpressionConverter.ConvertToken(bodyoffset);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["offset"] = 0;
                    bodypropCount++;
                }

                if (bodyorders != null)
                {
                    body["orders"] = SourceExpressionConverter.ConvertToken(bodyorders);
                    bodypropCount++;
                }

                var predicateObject = new JObject();
                var predicateObjectpropCount = 0;
                if (bodypredicatepath != null)
                {
                    if (bodypredicatepath != null)
                    {
                        predicateObject["path"] = SourceExpressionConverter.ConvertToken(bodypredicatepath);
                        predicateObjectpropCount++;
                    }

                    predicateObjectpropCount++;
                }
                else
                {
                    predicateObject["path"] = "group.id";
                    predicateObjectpropCount++;
                }

                if (bodypredicatevalue != null)
                {
                    predicateObject["value"] = SourceExpressionConverter.ConvertToken(bodypredicatevalue);
                    predicateObjectpropCount++;
                }

                if (bodypredicatecomparator != null)
                {
                    if (bodypredicatecomparator != null)
                    {
                        predicateObject["comparator"] = SourceExpressionConverter.ConvertToken(bodypredicatecomparator);
                        predicateObjectpropCount++;
                    }

                    predicateObjectpropCount++;
                }
                else
                {
                    predicateObject["comparator"] = "EqualTo";
                    predicateObjectpropCount++;
                }

                if (predicateObjectpropCount > 0)
                {
                    body["predicate"] = predicateObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowsSearch>(BuildSourceInput);
        }
    }

    public class DatablendTriggers([ConnectionName] string connectionId)
    {
    }

    public class GroupSearch
    {
        [JsonProperty("predicate")]
        public Predicate Predicate { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("orders")]
        public Orders[] Orders { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public GroupSearchResults[] Results { get; set; }
    }

    public class Predicate
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Orders
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }
    }

    public class GroupSearchResults
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("currentRole")]
        public string CurrentRole { get; set; }

        [JsonProperty("historyRetentionDays")]
        public int HistoryRetentionDays { get; set; }

        [JsonProperty("fiscalYearStartMonth")]
        public int FiscalYearStartMonth { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyordersInputItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }
    }

    public class QueryExecutionResults
    {
        [JsonProperty("queryExecutionId")]
        public string QueryExecutionId { get; set; }

        [JsonProperty("nextToken")]
        public string NextToken { get; set; }

        [JsonProperty("columns")]
        public QueryExecutionResultsColumns[] Columns { get; set; }

        [JsonProperty("rows")]
        public JToken Rows { get; set; }
    }

    public class QueryExecutionResultsColumns
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkflowExecutionsSearch
    {
        [JsonProperty("predicate")]
        public Predicate Predicate { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("orders")]
        public Orders[] Orders { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public WorkflowExecutionsSearchResults[] Results { get; set; }
    }

    public class WorkflowExecutionsSearchResults
    {
        [JsonProperty("steps")]
        public Steps[] Steps { get; set; }

        [JsonProperty("parameters")]
        public Parameters[] Parameters { get; set; }

        [JsonProperty("parent")]
        public Parent Parent { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("createdBy")]
        public CreateUpdateBy CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public CreateUpdateBy UpdatedBy { get; set; }

        [JsonProperty("cancelBy")]
        public CreateUpdateBy CancelBy { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("scheduled")]
        public bool Scheduled { get; set; }

        [JsonProperty("hasWarnings")]
        public bool HasWarnings { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Steps
    {
        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("outputs")]
        public Outputs Outputs { get; set; }

        [JsonProperty("hasWarnings")]
        public bool HasWarnings { get; set; }

        [JsonProperty("continueOnError")]
        public bool ContinueOnError { get; set; }
    }

    public class Outputs
    {
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public class Parameters
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("valueType")]
        public string ValueType { get; set; }

        [JsonProperty("enumType")]
        public string EnumType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("path")]
        public JToken Path { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("calculatedValue")]
        public string CalculatedValue { get; set; }
    }

    public class Parent
    {
        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("isPaused")]
        public bool IsPaused { get; set; }

        [JsonProperty("parameters")]
        public Parameters[] Parameters { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownableType")]
        public string OwnableType { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("createdBy")]
        public CreateUpdateBy CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public CreateUpdateBy UpdatedBy { get; set; }

        [JsonProperty("group")]
        public Groups Group { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateUpdateBy
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("profile")]
        public CreateUpdateByProfileType Profile { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateUpdateByProfileType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Groups
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("currentRole")]
        public string CurrentRole { get; set; }

        [JsonProperty("historyRetentionDays")]
        public int HistoryRetentionDays { get; set; }

        [JsonProperty("fiscalYearStartMonth")]
        public int FiscalYearStartMonth { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class WorkflowExecutions
    {
        [JsonProperty("steps")]
        public Steps[] Steps { get; set; }

        [JsonProperty("parameters")]
        public Parameters[] Parameters { get; set; }

        [JsonProperty("parent")]
        public Parent Parent { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("createdBy")]
        public CreateUpdateBy CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public CreateUpdateBy UpdatedBy { get; set; }

        [JsonProperty("cancelBy")]
        public CreateUpdateBy CancelBy { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("scheduled")]
        public bool Scheduled { get; set; }

        [JsonProperty("hasWarnings")]
        public bool HasWarnings { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class WorkflowsSearch
    {
        [JsonProperty("predicate")]
        public Predicate Predicate { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("orders")]
        public Orders[] Orders { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public WorkflowSearchResults[] Results { get; set; }
    }

    public class WorkflowSearchResults
    {
        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("isPaused")]
        public bool IsPaused { get; set; }

        [JsonProperty("parameters")]
        public Parameters[] Parameters { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownableType")]
        public string OwnableType { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("createdBy")]
        public CreateUpdateBy CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public CreateUpdateBy UpdatedBy { get; set; }

        [JsonProperty("group")]
        public Groups Group { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Datablend;

    public partial class WorkflowManagedActions
    {
        public DatablendActions Datablend(string connectionId) => new DatablendActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DatablendTriggers Datablend(string connectionId) => new DatablendTriggers(connectionId);
    }
}