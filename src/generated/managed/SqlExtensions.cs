//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Sql
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
            var apiCallPath = String.Format("/datasets/default/procedures/{0}", ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> ExecuteProcedureV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/procedures/{2}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQueryV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<object>> queryactualParameters = null, Expression<Func<string>> queryquery = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/query/sql", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetTablesV2Response> GetTablesV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
            return new ApiConnectionAction<GetTablesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetItemsV2Response> GetItemsV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> apply = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<string>> select = null, Expression<Func<bool>> count = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> PostItemV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> GetItemV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IWorkflowAction DeleteItemV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> PatchItemV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<SqlItemsList> GetOnUpdatedItemsV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables/{2}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            return new ApiConnectionTrigger<SqlItemsList>(callPayload);
        }

        public IOutputWorkflowTrigger<SqlItemsList> GetOnNewItemsV2(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables/{2}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            return new ApiConnectionTrigger<SqlItemsList>(callPayload);
        }
    }

    public class GetTablesV2Response
    {
        [JsonProperty("@metadata")]
        public DataWithSensitivityLabelInfo[] Metadata { get; set; }

        [JsonProperty("value")]
        public Table[] Value { get; set; }
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

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class GetItemsV2Response
    {
        [JsonProperty("@metadata")]
        public DataWithSensitivityLabelInfo[] Metadata { get; set; }

        [JsonProperty("value")]
        public SqlItem[] Value { get; set; }
    }

    public class SqlItem
    {
        [JsonProperty("dynamicProperties")]
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
    using Microsoft.Azure.Workflows.Sdk.Sql;

    public partial class WorkflowManagedActions
    {
        public SqlActions Sql(string connectionId) => new SqlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SqlTriggers Sql(string connectionId) => new SqlTriggers(connectionId);
    }
}