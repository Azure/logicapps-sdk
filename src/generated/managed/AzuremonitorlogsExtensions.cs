//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremonitorlogs
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremonitorlogsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        [WorkflowExpressionFactory(nameof(__BuildQueryData))]
        public IBodyWorkflowAction<Table> QueryData([WorkflowExpression] Func<string> subscriptions, [WorkflowExpression] Func<string> resourcegroups, [WorkflowExpression] Func<resourcetypeInput> resourcetype, [WorkflowExpression] Func<string> resourcename, [WorkflowExpression] Func<string> timerange, [WorkflowExpression] Func<string> query = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Table> __BuildQueryData(WorkflowExpression<string> subscriptions, WorkflowExpression<string> resourcegroups, WorkflowExpression<resourcetypeInput> resourcetype, WorkflowExpression<string> resourcename, WorkflowExpression<string> timerange, WorkflowExpression<string> query = null)
        {
            WorkflowExpression.Validate(subscriptions, nameof(subscriptions), required: true);
            WorkflowExpression.Validate(resourcegroups, nameof(resourcegroups), required: true);
            WorkflowExpression.Validate(resourcetype, nameof(resourcetype), required: true);
            WorkflowExpression.Validate(resourcename, nameof(resourcename), required: true);
            WorkflowExpression.Validate(timerange, nameof(timerange), required: true);
            WorkflowExpression.Validate(query, nameof(query), required: false);
            return new DeferredBodyAction<Table>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        [WorkflowExpressionFactory(nameof(__BuildVisualizeQuery))]
        public IBodyWorkflowAction<VisualizeResults> VisualizeQuery([WorkflowExpression] Func<string> subscriptions, [WorkflowExpression] Func<string> resourcegroups, [WorkflowExpression] Func<resourcetypeInput> resourcetype, [WorkflowExpression] Func<string> resourcename, [WorkflowExpression] Func<string> timerange, [WorkflowExpression] Func<visTypeInput> visType, [WorkflowExpression] Func<string> query = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VisualizeResults> __BuildVisualizeQuery(WorkflowExpression<string> subscriptions, WorkflowExpression<string> resourcegroups, WorkflowExpression<resourcetypeInput> resourcetype, WorkflowExpression<string> resourcename, WorkflowExpression<string> timerange, WorkflowExpression<visTypeInput> visType, WorkflowExpression<string> query = null)
        {
            WorkflowExpression.Validate(subscriptions, nameof(subscriptions), required: true);
            WorkflowExpression.Validate(resourcegroups, nameof(resourcegroups), required: true);
            WorkflowExpression.Validate(resourcetype, nameof(resourcetype), required: true);
            WorkflowExpression.Validate(resourcename, nameof(resourcename), required: true);
            WorkflowExpression.Validate(timerange, nameof(timerange), required: true);
            WorkflowExpression.Validate(visType, nameof(visType), required: true);
            WorkflowExpression.Validate(query, nameof(query), required: false);
            return new DeferredBodyAction<VisualizeResults>(() =>
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