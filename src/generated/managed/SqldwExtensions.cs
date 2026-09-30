//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sqldw
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SqldwActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> queryquery = null, [WorkflowExpression] Func<object> queryactualParameters = null)
        {
            SourceExpression.Validate(server, nameof(server), required: true);
            SourceExpression.Validate(database, nameof(database), required: true);
            SourceExpression.Validate(queryquery, nameof(queryquery), required: false);
            SourceExpression.Validate(queryactualParameters, nameof(queryactualParameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/query/sql", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var query = new JObject();
                var querypropCount = 0;
                if (queryquery != null)
                {
                    query["query"] = SourceExpressionConverter.ConvertToken(queryquery);
                    querypropCount++;
                }

                var formalParametersObject = new JObject();
                var formalParametersObjectpropCount = 0;
                if (formalParametersObjectpropCount > 0)
                {
                    query["formalParameters"] = formalParametersObject;
                    querypropCount++;
                }

                if (queryactualParameters != null)
                {
                    query["actualParameters"] = SourceExpressionConverter.ConvertToken(queryactualParameters);
                    querypropCount++;
                }

                if (querypropCount > 0)
                {
                    callPayload.Body = query;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            SourceExpression.Validate(server, nameof(server), required: true);
            SourceExpression.Validate(database, nameof(database), required: true);
            SourceExpression.Validate(procedure, nameof(procedure), required: true);
            SourceExpression.Validate(parameters, nameof(parameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/procedures/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(parameters);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<ItemsListV2> GetItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(server, nameof(server), required: true);
            SourceExpression.Validate(database, nameof(database), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsListV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database)
        {
            SourceExpression.Validate(server, nameof(server), required: true);
            SourceExpression.Validate(database, nameof(database), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TablesList>(BuildSourceInput);
        }
    }

    public class SqldwTriggers([ConnectionName] string connectionId)
    {
    }

    public class ItemsListV2
    {
        [JsonProperty("value")]
        public ItemV2[] Value { get; set; }
    }

    public class ItemV2
    {
        public string ItemInternalId { get; set; }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sqldw;

    public partial class WorkflowManagedActions
    {
        public SqldwActions Sqldw(string connectionId) => new SqldwActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SqldwTriggers Sqldw(string connectionId) => new SqldwTriggers(connectionId);
    }
}