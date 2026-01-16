//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremonitorlogs
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremonitorlogsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<Table> QueryData(Expression<Func<string>> subscriptions, Expression<Func<string>> resourcegroups, Expression<Func<resourcetypeInput>> resourcetype, Expression<Func<string>> resourcename, Expression<Func<string>> timerange, Expression<Func<string>> query = null)
        {
            var apiCallPath = "/queryData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptions"] = ExpressionConverter.Convert(subscriptions);
            callPayload.Queries["resourcegroups"] = ExpressionConverter.Convert(resourcegroups);
            callPayload.Queries["resourcetype"] = ExpressionConverter.Convert(resourcetype);
            callPayload.Queries["resourcename"] = ExpressionConverter.Convert(resourcename);
            callPayload.Queries["timerange"] = ExpressionConverter.Convert(timerange);
            callPayload.Body = ExpressionConverter.ConvertO(query);
            return new ApiConnectionAction<Table>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<TableV2> QueryDataV2(Expression<Func<string>> subscriptions, Expression<Func<string>> resourcegroups, Expression<Func<resourcetypeInput>> resourcetype, Expression<Func<string>> resourcename, Expression<Func<string>> bodyquery, Expression<Func<string>> bodytimeRangeType, Expression<Func<object>> bodytimerange)
        {
            var apiCallPath = "/queryDataV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptions"] = ExpressionConverter.Convert(subscriptions);
            callPayload.Queries["resourcegroups"] = ExpressionConverter.Convert(resourcegroups);
            callPayload.Queries["resourcetype"] = ExpressionConverter.Convert(resourcetype);
            callPayload.Queries["resourcename"] = ExpressionConverter.Convert(resourcename);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = ExpressionConverter.ConvertO(bodyquery);
            bodypropCount++;
            body["timerangetype"] = ExpressionConverter.ConvertO(bodytimeRangeType);
            bodypropCount++;
            body["timerange"] = ExpressionConverter.ConvertO(bodytimerange);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TableV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<VisualizeResults> VisualizeQuery(Expression<Func<string>> subscriptions, Expression<Func<string>> resourcegroups, Expression<Func<resourcetypeInput>> resourcetype, Expression<Func<string>> resourcename, Expression<Func<string>> timerange, Expression<Func<visTypeInput>> visType, Expression<Func<string>> query = null)
        {
            var apiCallPath = "/visualizeQuery";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptions"] = ExpressionConverter.Convert(subscriptions);
            callPayload.Queries["resourcegroups"] = ExpressionConverter.Convert(resourcegroups);
            callPayload.Queries["resourcetype"] = ExpressionConverter.Convert(resourcetype);
            callPayload.Queries["resourcename"] = ExpressionConverter.Convert(resourcename);
            callPayload.Queries["timerange"] = ExpressionConverter.Convert(timerange);
            callPayload.Queries["visType"] = ExpressionConverter.Convert(visType);
            callPayload.Body = ExpressionConverter.ConvertO(query);
            return new ApiConnectionAction<VisualizeResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<VisualizeResults> VisualizeQueryV2(Expression<Func<string>> subscriptions, Expression<Func<string>> resourcegroups, Expression<Func<resourcetypeInput>> resourcetype, Expression<Func<string>> resourcename, Expression<Func<string>> bodyquery, Expression<Func<string>> bodytimeRangeType, Expression<Func<object>> bodytimerange, Expression<Func<visTypeInput>> visType)
        {
            var apiCallPath = "/visualizeQueryV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptions"] = ExpressionConverter.Convert(subscriptions);
            callPayload.Queries["resourcegroups"] = ExpressionConverter.Convert(resourcegroups);
            callPayload.Queries["resourcetype"] = ExpressionConverter.Convert(resourcetype);
            callPayload.Queries["resourcename"] = ExpressionConverter.Convert(resourcename);
            callPayload.Queries["visType"] = ExpressionConverter.Convert(visType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = ExpressionConverter.ConvertO(bodyquery);
            bodypropCount++;
            body["timerangetype"] = ExpressionConverter.ConvertO(bodytimeRangeType);
            bodypropCount++;
            body["timerange"] = ExpressionConverter.ConvertO(bodytimerange);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<VisualizeResults>(callPayload);
        }
    }

    public class AzuremonitorlogsTriggers([ConnectionName] string connectionId)
    {
    }

    public class Table
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public enum resourcetypeInput
    {
        [EnumMember(Value = "Log Analytics Workspace")]
        LogAnalyticsWorkspace,
        [EnumMember(Value = "Application Insights")]
        ApplicationInsights
    }

    public class TableV2
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public class VisualizeResults
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("attachmentContent")]
        public string AttachmentContent { get; set; }

        [JsonProperty("attachmentName")]
        public string AttachmentName { get; set; }
    }

    public enum visTypeInput
    {
        [EnumMember(Value = "Html Table")]
        HtmlTable,
        [EnumMember(Value = "Pie Chart")]
        PieChart,
        [EnumMember(Value = "Time Chart")]
        TimeChart,
        [EnumMember(Value = "Bar Chart")]
        BarChart
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuremonitorlogs;

    public partial class WorkflowManagedActions
    {
        public AzuremonitorlogsActions Azuremonitorlogs(string connectionId) => new AzuremonitorlogsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuremonitorlogsTriggers Azuremonitorlogs(string connectionId) => new AzuremonitorlogsTriggers(connectionId);
    }
}