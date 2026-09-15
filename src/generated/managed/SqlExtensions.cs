//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sql
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure(Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/default/procedures/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<object>> queryactualParameters = null, Expression<Func<string>> queryquery = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/query/sql", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var query = new JObject();
            var querypropCount = 0;
            if (queryactualParameters != null)
            {
                query["actualParameters"] = CSharpExpressionConverter.ConvertToken(queryactualParameters);
                querypropCount++;
            }

            if (queryquery != null)
            {
                query["query"] = CSharpExpressionConverter.ConvertToken(queryquery);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetItemsV2Response> GetItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> apply = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<string>> select = null, Expression<Func<bool>> count = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (apply != null)
                callPayload.Queries["$apply"] = CSharpExpressionConverter.ConvertO(apply);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (count != null)
                callPayload.Queries["$count"] = CSharpExpressionConverter.ConvertO(count);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            return new ApiConnectionAction<GetItemsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetTablesV2Response> GetTables(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            return new ApiConnectionAction<GetTablesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SqlItemsList> OnNewItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/onnewitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionTrigger<SqlItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SqlItemsList> OnUpdatedItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/onupdateditems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionTrigger<SqlItemsList>(callPayload, triggerName, recurrence);
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