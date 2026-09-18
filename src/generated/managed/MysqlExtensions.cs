//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mysql
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MysqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mysql")]
        public IBodyWorkflowAction<TablesList> GetTables()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TablesList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mysql")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mysql")]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mysql")]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mysql")]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mysql")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class MysqlTriggers([ConnectionName] string connectionId)
    {
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mysql;

    public partial class WorkflowManagedActions
    {
        public MysqlActions Mysql(string connectionId) => new MysqlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MysqlTriggers Mysql(string connectionId) => new MysqlTriggers(connectionId);
    }
}