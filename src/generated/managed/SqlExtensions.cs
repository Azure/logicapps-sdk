//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sql
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteProcedure))]
        public IBodyWorkflowAction<JToken> ExecuteProcedure([WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecuteProcedure(WorkflowValue<string> procedure, WorkflowValue<object> parameters = null)
        {
            WorkflowValue.Validate(procedure, nameof(procedure), required: true);
            WorkflowValue.Validate(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/procedures/{0}", ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItem))]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteItem(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        [WorkflowExpressionFactory(nameof(__BuildExecutePassThroughNativeQuery))]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<object> queryactualParameters = null, [WorkflowExpression] Func<string> queryquery = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecutePassThroughNativeQuery(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<object> queryactualParameters = null, WorkflowValue<string> queryquery = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(queryactualParameters, nameof(queryactualParameters), required: false);
            WorkflowValue.Validate(queryquery, nameof(queryquery), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/query/sql", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var query = new JObject();
                var querypropCount = 0;
                if (queryactualParameters != null)
                {
                    query["actualParameters"] = ExpressionConverter.ConvertO(queryactualParameters);
                    querypropCount++;
                }

                if (queryquery != null)
                {
                    query["query"] = ExpressionConverter.ConvertO(queryquery);
                    querypropCount++;
                }

                var formalParametersObject = new JObject();
                var formalParametersObjectpropCount = 0;
                if (formalParametersObjectpropCount > 0)
                {
                    query["formalParameters"] = formalParametersObject;
                    querypropCount++;
                }

                if (querypropCount > 0)
                {
                    callPayload.Body = query;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItem(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<GetItemsV2Response> GetItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> apply = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<bool> count = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetItemsV2Response> __BuildGetItems(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> apply = null, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> skip = null, WorkflowValue<int> top = null, WorkflowValue<string> select = null, WorkflowValue<bool> count = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(apply, nameof(apply), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(count, nameof(count), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<GetItemsV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apply != null)
                    callPayload.Queries["$apply"] = ExpressionConverter.Convert(apply);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                return new ApiConnectionAction<GetItemsV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<GetTablesV2Response> GetTables([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTablesV2Response> __BuildGetTables(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<GetTablesV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                return new ApiConnectionAction<GetTablesV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItem))]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPatchItem(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> id, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        [WorkflowExpressionFactory(nameof(__BuildPostItem))]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPostItem(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnNewItems))]
        public IBodyWorkflowTrigger<SqlItemsList> OnNewItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<SqlItemsList> __BuildOnNewItems(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<int> top = null, WorkflowValue<string> orderby = null, WorkflowValue<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyTrigger<SqlItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionTrigger<SqlItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedItems))]
        public IBodyWorkflowTrigger<SqlItemsList> OnUpdatedItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<SqlItemsList> __BuildOnUpdatedItems(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<int> top = null, WorkflowValue<string> orderby = null, WorkflowValue<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyTrigger<SqlItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionTrigger<SqlItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class GetItemsV2Response
    {
        [JsonProperty("@metadata")]
        public DataWithSensitivityLabelInfo[] Metadata { get; set; }

        [JsonProperty("value")]
        public SqlItem[] Value { get; set; }
    }

    public class DataWithSensitivityLabelInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public class SensitivityLabelMetadata
    {
        [JsonProperty("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string SensitivityLabelDisplayNameInfo { get; set; }

        [JsonProperty("tooltip")]
        public string TooltipInfo { get; set; }

        [JsonProperty("priority")]
        public int PriorityOfSensitivityLabel { get; set; }

        [JsonProperty("color")]
        public string ColorToBeDisplayedForSensitivityLabel { get; set; }

        [JsonProperty("isEncrypted")]
        public bool IsEncryptedStatusOfSensitivityLabel { get; set; }

        [JsonProperty("isEnabled")]
        public bool WhetherSensitivityLabelIsEnabled { get; set; }

        [JsonProperty("isParent")]
        public bool WhetherSensitivityLabelIsParent { get; set; }

        [JsonProperty("parentSensitivityLabelId")]
        public string ParentSensitivityLabelId { get; set; }
    }

    public class SqlItem
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class GetTablesV2Response
    {
        [JsonProperty("@metadata")]
        public DataWithSensitivityLabelInfo[] Metadata { get; set; }

        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class SqlItemsList
    {
        [JsonProperty("value")]
        public SqlItem[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sql;

    public partial class WorkflowManagedActions
    {
        public SqlActions Sql(string connectionId) => new SqlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SqlTriggers Sql(string connectionId) => new SqlTriggers(connectionId);
    }
}
