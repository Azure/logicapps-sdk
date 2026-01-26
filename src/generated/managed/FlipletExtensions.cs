//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fliplet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlipletActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<AppsInfo> GetAllApps()
        {
            var apiCallPath = "/v1/apps";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AppsInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<AppInfo> GetAppsById(Expression<Func<int>> appId)
        {
            var apiCallPath = String.Format("/v1/apps/{0}", ExpressionConverter.ConvertWithUrlEncoding(appId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AppInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<DatasourcesInfo> GetAllDataSources()
        {
            var apiCallPath = "/v1/data-sources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DatasourcesInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<DatasourceInfo> GetDataSourceById(Expression<Func<int>> dataSourceId)
        {
            var apiCallPath = String.Format("/v1/data-sources/{0}", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DatasourceInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<JToken> GetDataSourceEntry(Expression<Func<int>> dataSourceId, Expression<Func<int>> dataSourceEntryId)
        {
            var apiCallPath = String.Format("/v1/data-sources/{0}/data/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataSourceEntryId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction DeleteDataSourceEntry(Expression<Func<int>> dataSourceId, Expression<Func<int>> dataSourceEntryId)
        {
            var apiCallPath = String.Format("/v1/data-sources/{0}/data/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataSourceEntryId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction UpdateDataSourceEntry(Expression<Func<int>> dataSourceId, Expression<Func<int>> dataSourceEntryId)
        {
            var apiCallPath = String.Format("/v1/data-sources/{0}/data/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataSourceEntryId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<FetchedData> GetDataSourceEntries(Expression<Func<int>> dataSourceId)
        {
            var apiCallPath = String.Format("/v1/data-sources/{0}/data", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FetchedData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction CreateDataSourceRows(Expression<Func<int>> dataSourceId, Expression<Func<bool>> bodyappend, Expression<Func<JToken[]>> bodyentries)
        {
            var apiCallPath = String.Format("/v1/data-sources/{0}/data", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["append"] = ExpressionConverter.ConvertO(bodyappend);
            bodypropCount++;
            body["entries"] = ExpressionConverter.ConvertO(bodyentries);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class FlipletTriggers([ConnectionName] string connectionId)
    {
    }

    public class AppsInfo
    {
        [JsonProperty("apps")]
        public JToken[] Apps { get; set; }
    }

    public class AppInfo
    {
        [JsonProperty("app")]
        public JToken[] App { get; set; }
    }

    public class DatasourcesInfo
    {
        [JsonProperty("datasources")]
        public JToken[] Datasources { get; set; }
    }

    public class DatasourceInfo
    {
        [JsonProperty("datasource")]
        public JToken[] Datasource { get; set; }
    }

    public class FetchedData
    {
        [JsonProperty("entries")]
        public JToken[] Entries { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fliplet;

    public partial class WorkflowManagedActions
    {
        public FlipletActions Fliplet(string connectionId) => new FlipletActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlipletTriggers Fliplet(string connectionId) => new FlipletTriggers(connectionId);
    }
}