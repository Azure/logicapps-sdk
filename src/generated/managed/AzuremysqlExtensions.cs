//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremysql
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremysqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        [WorkflowExpressionFactory(nameof(__BuildGetStoredProcedures))]
        public IBodyWorkflowAction<ProceduresList> GetStoredProcedures([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProceduresList> __BuildGetStoredProcedures(WorkflowValue<string> server, WorkflowValue<string> database)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            return new DeferredBodyAction<ProceduresList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/procedures", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProceduresList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteProcedure))]
        public IBodyWorkflowAction<JToken> ExecuteProcedure([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecuteProcedure(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> procedure, WorkflowValue<object> parameters = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(procedure, nameof(procedure), required: true);
            WorkflowValue.Validate(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/procedures/{2}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TablesList> __BuildGetTables(WorkflowValue<string> server, WorkflowValue<string> database)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItems(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null, WorkflowValue<string> select = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
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
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
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
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
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
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
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
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
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
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/query/mysql", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
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
    }

    public class AzuremysqlTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnNewItems))]
        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnNewItems(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<int> top = null, WorkflowValue<string> orderby = null, WorkflowValue<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedItems))]
        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnUpdatedItems(WorkflowValue<string> server, WorkflowValue<string> database, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<int> top = null, WorkflowValue<string> orderby = null, WorkflowValue<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(server, nameof(server), required: true);
            WorkflowValue.Validate(database, nameof(database), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
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
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class ProceduresList
    {
        [JsonProperty("value")]
        public Procedure[] Value { get; set; }
    }

    public class Procedure
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class TablesList
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuremysql;

    public partial class WorkflowManagedActions
    {
        public AzuremysqlActions Azuremysql(string connectionId) => new AzuremysqlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuremysqlTriggers Azuremysql(string connectionId) => new AzuremysqlTriggers(connectionId);
    }
}
