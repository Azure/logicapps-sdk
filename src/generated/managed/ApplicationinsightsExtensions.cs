//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Applicationinsights
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApplicationinsightsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "applicationinsights")]
        public IBodyWorkflowAction<Table> RunQuery([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<timerangeInput> timerange = null)
        {
            SourceExpression.Validate(query, nameof(query), required: false);
            SourceExpression.Validate(timerange, nameof(timerange), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/QueryDraft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timerange"] = Convert.ToString("Last hour");
                if (timerange != null)
                    callPayload.Queries["timerange"] = SourceExpressionConverter.Convert(timerange);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Body = SourceExpressionConverter.ConvertToken(query);
                return callPayload;
            }

            return new ApiConnectionAction<Table>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "applicationinsights")]
        public IBodyWorkflowAction<VisualizeResults> VisualizeQuery([WorkflowExpression] Func<chartTypeInput> chartType, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<timerangeInput> timerange = null)
        {
            SourceExpression.Validate(chartType, nameof(chartType), required: true);
            SourceExpression.Validate(query, nameof(query), required: false);
            SourceExpression.Validate(timerange, nameof(timerange), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/VisualizeQueryDraft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timerange"] = Convert.ToString("Last hour");
                if (timerange != null)
                    callPayload.Queries["timerange"] = SourceExpressionConverter.Convert(timerange);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["chartType"] = SourceExpressionConverter.Convert(chartType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(query);
                return callPayload;
            }

            return new ApiConnectionAction<VisualizeResults>(BuildSourceInput);
        }
    }

    public class ApplicationinsightsTriggers([ConnectionName] string connectionId)
    {
    }

    public class Table
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public enum timerangeInput
    {
        [EnumMember(Value = "Last hour")]
        LastHour,
        [EnumMember(Value = "Last 4 hours")]
        Last4Hours,
        [EnumMember(Value = "Last 12 hours")]
        Last12Hours,
        [EnumMember(Value = "Last 24 hours")]
        Last24Hours,
        [EnumMember(Value = "Last 48 hours")]
        Last48Hours,
        [EnumMember(Value = "Last 3 days")]
        Last3Days,
        [EnumMember(Value = "Last 7 days")]
        Last7Days,
        [EnumMember(Value = "Set in query")]
        SetInQuery
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

    public enum chartTypeInput
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Applicationinsights;

    public partial class WorkflowManagedActions
    {
        public ApplicationinsightsActions Applicationinsights(string connectionId) => new ApplicationinsightsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApplicationinsightsTriggers Applicationinsights(string connectionId) => new ApplicationinsightsTriggers(connectionId);
    }
}