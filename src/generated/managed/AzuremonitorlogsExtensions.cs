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
        public IBodyWorkflowAction<Table> QueryData([WorkflowExpression] Func<string> subscriptions, [WorkflowExpression] Func<string> resourcegroups, [WorkflowExpression] Func<resourcetypeInput> resourcetype, [WorkflowExpression] Func<string> resourcename, [WorkflowExpression] Func<string> timerange, [WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(subscriptions, nameof(subscriptions), required: true);
            SourceExpression.Validate(resourcegroups, nameof(resourcegroups), required: true);
            SourceExpression.Validate(resourcetype, nameof(resourcetype), required: true);
            SourceExpression.Validate(resourcename, nameof(resourcename), required: true);
            SourceExpression.Validate(timerange, nameof(timerange), required: true);
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/queryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptions"] = SourceExpressionConverter.ConvertO(subscriptions);
                callPayload.Queries["resourcegroups"] = SourceExpressionConverter.ConvertO(resourcegroups);
                callPayload.Queries["resourcetype"] = SourceExpressionConverter.Convert(resourcetype);
                callPayload.Queries["resourcename"] = SourceExpressionConverter.ConvertO(resourcename);
                callPayload.Queries["timerange"] = SourceExpressionConverter.ConvertO(timerange);
                callPayload.Body = SourceExpressionConverter.ConvertToken(query);
                return callPayload;
            }

            return new ApiConnectionAction<Table>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<VisualizeResults> VisualizeQuery([WorkflowExpression] Func<string> subscriptions, [WorkflowExpression] Func<string> resourcegroups, [WorkflowExpression] Func<resourcetypeInput> resourcetype, [WorkflowExpression] Func<string> resourcename, [WorkflowExpression] Func<string> timerange, [WorkflowExpression] Func<visTypeInput> visType, [WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(subscriptions, nameof(subscriptions), required: true);
            SourceExpression.Validate(resourcegroups, nameof(resourcegroups), required: true);
            SourceExpression.Validate(resourcetype, nameof(resourcetype), required: true);
            SourceExpression.Validate(resourcename, nameof(resourcename), required: true);
            SourceExpression.Validate(timerange, nameof(timerange), required: true);
            SourceExpression.Validate(visType, nameof(visType), required: true);
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/visualizeQuery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptions"] = SourceExpressionConverter.ConvertO(subscriptions);
                callPayload.Queries["resourcegroups"] = SourceExpressionConverter.ConvertO(resourcegroups);
                callPayload.Queries["resourcetype"] = SourceExpressionConverter.Convert(resourcetype);
                callPayload.Queries["resourcename"] = SourceExpressionConverter.ConvertO(resourcename);
                callPayload.Queries["timerange"] = SourceExpressionConverter.ConvertO(timerange);
                callPayload.Queries["visType"] = SourceExpressionConverter.Convert(visType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(query);
                return callPayload;
            }

            return new ApiConnectionAction<VisualizeResults>(BuildSourceInput);
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