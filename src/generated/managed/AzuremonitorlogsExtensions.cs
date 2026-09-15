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
            callPayload.Queries["subscriptions"] = CSharpExpressionConverter.ConvertO(subscriptions);
            callPayload.Queries["resourcegroups"] = CSharpExpressionConverter.ConvertO(resourcegroups);
            callPayload.Queries["resourcetype"] = CSharpExpressionConverter.Convert(resourcetype);
            callPayload.Queries["resourcename"] = CSharpExpressionConverter.ConvertO(resourcename);
            callPayload.Queries["timerange"] = CSharpExpressionConverter.ConvertO(timerange);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(query);
            return new ApiConnectionAction<Table>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<VisualizeResults> VisualizeQuery(Expression<Func<string>> subscriptions, Expression<Func<string>> resourcegroups, Expression<Func<resourcetypeInput>> resourcetype, Expression<Func<string>> resourcename, Expression<Func<string>> timerange, Expression<Func<visTypeInput>> visType, Expression<Func<string>> query = null)
        {
            var apiCallPath = "/visualizeQuery";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptions"] = CSharpExpressionConverter.ConvertO(subscriptions);
            callPayload.Queries["resourcegroups"] = CSharpExpressionConverter.ConvertO(resourcegroups);
            callPayload.Queries["resourcetype"] = CSharpExpressionConverter.Convert(resourcetype);
            callPayload.Queries["resourcename"] = CSharpExpressionConverter.ConvertO(resourcename);
            callPayload.Queries["timerange"] = CSharpExpressionConverter.ConvertO(timerange);
            callPayload.Queries["visType"] = CSharpExpressionConverter.Convert(visType);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(query);
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

namespace Microsoft.Azure.Workflows.Sdk
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