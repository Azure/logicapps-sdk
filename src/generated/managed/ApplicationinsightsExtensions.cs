//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Applicationinsights
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApplicationinsightsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "applicationinsights")]
        public IBodyWorkflowAction<Table, ApiConnectionActionConfiguration> RunQuery(Expression<Func<string>> query = null, Expression<Func<timerangeInput>> timerange = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_timerange = WorkflowExpression.Compile(timerange, nameof(timerange), required: false);
            return new DeferredBodyAction<Table, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/QueryDraft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timerange"] = Convert.ToString("Last hour");
                if (__workflow_timerange != null)
                    callPayload.Queries["timerange"] = ExpressionConverter.Convert(__workflow_timerange);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<Table>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "applicationinsights")]
        public IBodyWorkflowAction<VisualizeResults, ApiConnectionActionConfiguration> VisualizeQuery(Expression<Func<chartTypeInput>> chartType, Expression<Func<string>> query = null, Expression<Func<timerangeInput>> timerange = null)
        {
            var __workflow_chartType = WorkflowExpression.Compile(chartType, nameof(chartType), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_timerange = WorkflowExpression.Compile(timerange, nameof(timerange), required: false);
            return new DeferredBodyAction<VisualizeResults, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/VisualizeQueryDraft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timerange"] = Convert.ToString("Last hour");
                if (__workflow_timerange != null)
                    callPayload.Queries["timerange"] = ExpressionConverter.Convert(__workflow_timerange);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["chartType"] = ExpressionConverter.Convert(__workflow_chartType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<VisualizeResults>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
