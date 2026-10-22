//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremonitorlogs
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremonitorlogsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<Table, ApiConnectionActionConfiguration> QueryData(Expression<Func<string>> subscriptions, Expression<Func<string>> resourcegroups, Expression<Func<resourcetypeInput>> resourcetype, Expression<Func<string>> resourcename, Expression<Func<string>> timerange, Expression<Func<string>> query = null)
        {
            var __workflow_subscriptions = WorkflowExpression.Compile(subscriptions, nameof(subscriptions), required: true);
            var __workflow_resourcegroups = WorkflowExpression.Compile(resourcegroups, nameof(resourcegroups), required: true);
            var __workflow_resourcetype = WorkflowExpression.Compile(resourcetype, nameof(resourcetype), required: true);
            var __workflow_resourcename = WorkflowExpression.Compile(resourcename, nameof(resourcename), required: true);
            var __workflow_timerange = WorkflowExpression.Compile(timerange, nameof(timerange), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredBodyAction<Table, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/queryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptions"] = ExpressionConverter.Convert(__workflow_subscriptions);
                callPayload.Queries["resourcegroups"] = ExpressionConverter.Convert(__workflow_resourcegroups);
                callPayload.Queries["resourcetype"] = ExpressionConverter.Convert(__workflow_resourcetype);
                callPayload.Queries["resourcename"] = ExpressionConverter.Convert(__workflow_resourcename);
                callPayload.Queries["timerange"] = ExpressionConverter.Convert(__workflow_timerange);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<Table>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<VisualizeResults, ApiConnectionActionConfiguration> VisualizeQuery(Expression<Func<string>> subscriptions, Expression<Func<string>> resourcegroups, Expression<Func<resourcetypeInput>> resourcetype, Expression<Func<string>> resourcename, Expression<Func<string>> timerange, Expression<Func<visTypeInput>> visType, Expression<Func<string>> query = null)
        {
            var __workflow_subscriptions = WorkflowExpression.Compile(subscriptions, nameof(subscriptions), required: true);
            var __workflow_resourcegroups = WorkflowExpression.Compile(resourcegroups, nameof(resourcegroups), required: true);
            var __workflow_resourcetype = WorkflowExpression.Compile(resourcetype, nameof(resourcetype), required: true);
            var __workflow_resourcename = WorkflowExpression.Compile(resourcename, nameof(resourcename), required: true);
            var __workflow_timerange = WorkflowExpression.Compile(timerange, nameof(timerange), required: true);
            var __workflow_visType = WorkflowExpression.Compile(visType, nameof(visType), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredBodyAction<VisualizeResults, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/visualizeQuery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptions"] = ExpressionConverter.Convert(__workflow_subscriptions);
                callPayload.Queries["resourcegroups"] = ExpressionConverter.Convert(__workflow_resourcegroups);
                callPayload.Queries["resourcetype"] = ExpressionConverter.Convert(__workflow_resourcetype);
                callPayload.Queries["resourcename"] = ExpressionConverter.Convert(__workflow_resourcename);
                callPayload.Queries["timerange"] = ExpressionConverter.Convert(__workflow_timerange);
                callPayload.Queries["visType"] = ExpressionConverter.Convert(__workflow_visType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<VisualizeResults>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
