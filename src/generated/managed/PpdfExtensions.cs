//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ppdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PpdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ppdf")]
        public IBodyWorkflowAction<DataSetsList> GetDataSets()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DataSetsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ppdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ppdf")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
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
    }

    public class PpdfTriggers([ConnectionName] string connectionId)
    {
    }

    public class DataSetsList
    {
        [JsonProperty("value")]
        public DataSet[] Value { get; set; }
    }

    public class DataSet
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
        public string ItemInternalId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ppdf;

    public partial class WorkflowManagedActions
    {
        public PpdfActions Ppdf(string connectionId) => new PpdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PpdfTriggers Ppdf(string connectionId) => new PpdfTriggers(connectionId);
    }
}