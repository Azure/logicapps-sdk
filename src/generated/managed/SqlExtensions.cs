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
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<object> queryactualParameters = null, [WorkflowExpression] Func<string> queryquery = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/query/sql", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var query = new JObject();
                var querypropCount = 0;
                if (queryactualParameters != null)
                {
                    query["actualParameters"] = SourceExpressionConverter.ConvertToken(queryactualParameters);
                    querypropCount++;
                }

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

                if (querypropCount > 0)
                {
                    callPayload.Body = query;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetItemsV2Response> GetItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> apply = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<bool> count = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apply != null)
                    callPayload.Queries["$apply"] = SourceExpressionConverter.ConvertO(apply);
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
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                return callPayload;
            }

            return new ApiConnectionAction<GetItemsV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetTablesV2Response> GetTables([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                return callPayload;
            }

            return new ApiConnectionAction<GetTablesV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SqlItemsList> OnNewItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/onnewitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionTrigger<SqlItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SqlItemsList> OnUpdatedItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/onupdateditems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionTrigger<SqlItemsList>(BuildSourceInput, triggerName, recurrence);
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