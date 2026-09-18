//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlesheet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglesheetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression] Func<string> dataset)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TablesList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> PostItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<itemInput> item = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> GetItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> PatchItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<itemInput> item = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }
    }

    public class GooglesheetTriggers([ConnectionName] string connectionId)
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

    public class itemInput
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlesheet;

    public partial class WorkflowManagedActions
    {
        public GooglesheetActions Googlesheet(string connectionId) => new GooglesheetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglesheetTriggers Googlesheet(string connectionId) => new GooglesheetTriggers(connectionId);
    }
}