//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fliplet
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlipletActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<AppsInfo, ApiConnectionActionConfiguration> GetAllApps()
        {
            return new DeferredBodyAction<AppsInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/apps";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AppsInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<AppInfo, ApiConnectionActionConfiguration> GetAppsById(Expression<Func<int>> appId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            return new DeferredBodyAction<AppInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/apps/{0}", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AppInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<DatasourcesInfo, ApiConnectionActionConfiguration> GetAllDataSources()
        {
            return new DeferredBodyAction<DatasourcesInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/data-sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DatasourcesInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<DatasourceInfo, ApiConnectionActionConfiguration> GetDataSourceById(Expression<Func<int>> dataSourceId)
        {
            var __workflow_dataSourceId = WorkflowExpression.Compile(dataSourceId, nameof(dataSourceId), required: true);
            return new DeferredBodyAction<DatasourceInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/data-sources/{0}", __workflow_dataSourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DatasourceInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetDataSourceEntry(Expression<Func<int>> dataSourceId, Expression<Func<int>> dataSourceEntryId)
        {
            var __workflow_dataSourceId = WorkflowExpression.Compile(dataSourceId, nameof(dataSourceId), required: true);
            var __workflow_dataSourceEntryId = WorkflowExpression.Compile(dataSourceEntryId, nameof(dataSourceEntryId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/data-sources/{0}/data/{1}", __workflow_dataSourceId.WithUrlEncoding(1), __workflow_dataSourceEntryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDataSourceEntry(Expression<Func<int>> dataSourceId, Expression<Func<int>> dataSourceEntryId)
        {
            var __workflow_dataSourceId = WorkflowExpression.Compile(dataSourceId, nameof(dataSourceId), required: true);
            var __workflow_dataSourceEntryId = WorkflowExpression.Compile(dataSourceEntryId, nameof(dataSourceEntryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/data-sources/{0}/data/{1}", __workflow_dataSourceId.WithUrlEncoding(1), __workflow_dataSourceEntryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDataSourceEntry(Expression<Func<int>> dataSourceId, Expression<Func<int>> dataSourceEntryId)
        {
            var __workflow_dataSourceId = WorkflowExpression.Compile(dataSourceId, nameof(dataSourceId), required: true);
            var __workflow_dataSourceEntryId = WorkflowExpression.Compile(dataSourceEntryId, nameof(dataSourceEntryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/data-sources/{0}/data/{1}", __workflow_dataSourceId.WithUrlEncoding(1), __workflow_dataSourceEntryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<FetchedData, ApiConnectionActionConfiguration> GetDataSourceEntries(Expression<Func<int>> dataSourceId)
        {
            var __workflow_dataSourceId = WorkflowExpression.Compile(dataSourceId, nameof(dataSourceId), required: true);
            return new DeferredBodyAction<FetchedData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/data-sources/{0}/data", __workflow_dataSourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FetchedData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateDataSourceRows(Expression<Func<int>> dataSourceId, Expression<Func<bool>> bodyappend, Expression<Func<JToken[]>> bodyentries)
        {
            var __workflow_dataSourceId = WorkflowExpression.Compile(dataSourceId, nameof(dataSourceId), required: true);
            var __workflow_bodyappend = WorkflowExpression.Compile(bodyappend, nameof(bodyappend), required: true);
            var __workflow_bodyentries = WorkflowExpression.Compile(bodyentries, nameof(bodyentries), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/data-sources/{0}/data", __workflow_dataSourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["append"] = ExpressionConverter.ConvertO(__workflow_bodyappend);
                bodypropCount++;
                body["entries"] = ExpressionConverter.ConvertO(__workflow_bodyentries);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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