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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/apps";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AppsInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<AppInfo> GetAppsById([WorkflowExpression] Func<int> appId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/apps/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(appId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AppInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<DatasourcesInfo> GetAllDataSources()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/data-sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DatasourcesInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<DatasourceInfo> GetDataSourceById([WorkflowExpression] Func<int> dataSourceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/data-sources/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DatasourceInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<JToken> GetDataSourceEntry([WorkflowExpression] Func<int> dataSourceId, [WorkflowExpression] Func<int> dataSourceEntryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/data-sources/{0}/data/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceEntryId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction DeleteDataSourceEntry([WorkflowExpression] Func<int> dataSourceId, [WorkflowExpression] Func<int> dataSourceEntryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/data-sources/{0}/data/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceEntryId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction UpdateDataSourceEntry([WorkflowExpression] Func<int> dataSourceId, [WorkflowExpression] Func<int> dataSourceEntryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/data-sources/{0}/data/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceEntryId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IBodyWorkflowAction<FetchedData> GetDataSourceEntries([WorkflowExpression] Func<int> dataSourceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/data-sources/{0}/data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FetchedData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fliplet")]
        public IWorkflowAction CreateDataSourceRows([WorkflowExpression] Func<int> dataSourceId, [WorkflowExpression] Func<bool> bodyappend, [WorkflowExpression] Func<JToken[]> bodyentries)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/data-sources/{0}/data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dataSourceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["append"] = SourceExpressionConverter.ConvertToken(bodyappend);
                bodypropCount++;
                body["entries"] = SourceExpressionConverter.ConvertToken(bodyentries);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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