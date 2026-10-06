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
        public IBodyWorkflowAction<TableV2> QueryData([WorkflowExpression] Func<string> subscriptions, [WorkflowExpression] Func<string> resourcegroups, [WorkflowExpression] Func<resourcetypeInput> resourcetype, [WorkflowExpression] Func<string> resourcename, [WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodytimeRangeType, [WorkflowExpression] Func<object> bodytimerange)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/queryDataV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptions"] = SourceExpressionConverter.ConvertO(subscriptions);
                callPayload.Queries["resourcegroups"] = SourceExpressionConverter.ConvertO(resourcegroups);
                callPayload.Queries["resourcetype"] = SourceExpressionConverter.Convert(resourcetype);
                callPayload.Queries["resourcename"] = SourceExpressionConverter.ConvertO(resourcename);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
                body["timerangetype"] = SourceExpressionConverter.ConvertToken(bodytimeRangeType);
                bodypropCount++;
                body["timerange"] = SourceExpressionConverter.ConvertToken(bodytimerange);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TableV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogs")]
        public IBodyWorkflowAction<VisualizeResults> VisualizeQuery([WorkflowExpression] Func<string> subscriptions, [WorkflowExpression] Func<string> resourcegroups, [WorkflowExpression] Func<resourcetypeInput> resourcetype, [WorkflowExpression] Func<string> resourcename, [WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodytimeRangeType, [WorkflowExpression] Func<object> bodytimerange, [WorkflowExpression] Func<visTypeInput> visType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/visualizeQueryV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptions"] = SourceExpressionConverter.ConvertO(subscriptions);
                callPayload.Queries["resourcegroups"] = SourceExpressionConverter.ConvertO(resourcegroups);
                callPayload.Queries["resourcetype"] = SourceExpressionConverter.Convert(resourcetype);
                callPayload.Queries["resourcename"] = SourceExpressionConverter.ConvertO(resourcename);
                callPayload.Queries["visType"] = SourceExpressionConverter.Convert(visType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
                body["timerangetype"] = SourceExpressionConverter.ConvertToken(bodytimeRangeType);
                bodypropCount++;
                body["timerange"] = SourceExpressionConverter.ConvertToken(bodytimerange);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VisualizeResults>(BuildSourceInput);
        }
    }

    public class AzuremonitorlogsTriggers([ConnectionName] string connectionId)
    {
    }

    public class TableV2
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }

        [JsonProperty("error")]
        public PartialQueryError Error { get; set; }
    }

    public class PartialQueryError
    {
        [JsonProperty("code")]
        public string ErrorCode { get; set; }
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

        [JsonProperty("error")]
        public PartialQueryError Error { get; set; }
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