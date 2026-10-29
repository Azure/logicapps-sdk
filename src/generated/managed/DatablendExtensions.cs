//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datablend
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatablendActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<GroupSearch, ApiConnectionActionConfiguration> GroupsSearch(Expression<Func<GroupsSearchInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GroupSearch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/groups/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupSearch>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<QueryExecutionResults, ApiConnectionActionConfiguration> GetQueryExecutionById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<QueryExecutionResults, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/query-executions/{0}/results", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QueryExecutionResults>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<WorkflowExecutionsSearch, ApiConnectionActionConfiguration> WorkflowExecutionsSearch(Expression<Func<WorkflowExecutionsSearchInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkflowExecutionsSearch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflow-executions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkflowExecutionsSearch>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<WorkflowExecutions, ApiConnectionActionConfiguration> WorkflowExecutions(Expression<Func<WorkflowExecutionsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkflowExecutions, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflow-executions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkflowExecutions>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datablend")]
        public IBodyWorkflowAction<WorkflowsSearch, ApiConnectionActionConfiguration> WorkflowsSearch(Expression<Func<WorkflowsSearchInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkflowsSearch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflows/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkflowsSearch>(callPayload);
            });
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

    public class GroupsSearchInput
    {
        [JsonProperty("offset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Offset { get; set; } = 0;

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 1;

        [JsonProperty("orders")]
        public GroupsSearchInputOrdersTypeItem[] Orders { get; set; }
    }

    public class GroupsSearchInputOrdersTypeItem
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; } = "name";

        [JsonProperty("direction", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Direction { get; set; } = "Ascending";
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

    public class WorkflowExecutionsSearchInput
    {
        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 1;

        [JsonProperty("offset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Offset { get; set; } = 0;

        [JsonProperty("orders")]
        public WorkflowExecutionsSearchInputOrdersTypeItem[] Orders { get; set; }

        [JsonProperty("predicate")]
        public WorkflowExecutionsSearchInputPredicateType Predicate { get; set; }
    }

    public class WorkflowExecutionsSearchInputOrdersTypeItem
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; } = "created";

        [JsonProperty("direction", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Direction { get; set; } = "Descending";
    }

    public class WorkflowExecutionsSearchInputPredicateType
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; } = "parent.id";

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("comparator", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comparator { get; set; } = "EqualTo";
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

    public class WorkflowExecutionsInput
    {
        [JsonProperty("parent")]
        public WorkflowExecutionsInputParentType Parent { get; set; }
    }

    public class WorkflowExecutionsInputParentType
    {
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

    public class WorkflowsSearchInput
    {
        [JsonProperty("offset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Offset { get; set; } = 0;

        [JsonProperty("orders")]
        public WorkflowsSearchInputOrdersTypeItem[] Orders { get; set; }

        [JsonProperty("predicate")]
        public WorkflowsSearchInputPredicateType Predicate { get; set; }
    }

    public class WorkflowsSearchInputOrdersTypeItem
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; } = "name";

        [JsonProperty("direction", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Direction { get; set; } = "Ascending";
    }

    public class WorkflowsSearchInputPredicateType
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; } = "group.id";

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("comparator", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comparator { get; set; } = "EqualTo";
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