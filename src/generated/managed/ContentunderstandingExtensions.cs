//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Contentunderstanding
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ContentunderstandingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentunderstanding")]
        public IBodyWorkflowAction<AnalyzeOperationResult, ApiConnectionActionConfiguration> AnalyzeContent(Expression<Func<string>> analyzerId, Expression<Func<string>> bodyfileContent = null, Expression<Func<string>> bodyinputFileURL = null, Expression<Func<string>> bodyrange = null, Expression<Func<string>> bodyfileMIMEType = null, Expression<Func<AnalysisInput[]>> bodyinputs = null, Expression<Func<processingLocationInput>> processingLocation = null, Expression<Func<string>> stringEncoding = null)
        {
            var __workflow_analyzerId = WorkflowExpression.Compile(analyzerId, nameof(analyzerId), required: true);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: false);
            var __workflow_bodyinputFileURL = WorkflowExpression.Compile(bodyinputFileURL, nameof(bodyinputFileURL), required: false);
            var __workflow_bodyrange = WorkflowExpression.Compile(bodyrange, nameof(bodyrange), required: false);
            var __workflow_bodyfileMIMEType = WorkflowExpression.Compile(bodyfileMIMEType, nameof(bodyfileMIMEType), required: false);
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: false);
            var __workflow_processingLocation = WorkflowExpression.Compile(processingLocation, nameof(processingLocation), required: false);
            var __workflow_stringEncoding = WorkflowExpression.Compile(stringEncoding, nameof(stringEncoding), required: false);
            return new DeferredBodyAction<AnalyzeOperationResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contentunderstanding/analyzers/{0}:analyze", __workflow_analyzerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-01");
                if (__workflow_processingLocation != null)
                    callPayload.Queries["processingLocation"] = ExpressionConverter.Convert(__workflow_processingLocation);
                if (__workflow_stringEncoding != null)
                    callPayload.Queries["stringEncoding"] = ExpressionConverter.Convert(__workflow_stringEncoding);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileContent != null)
                {
                    body["inputFileContent"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                    bodypropCount++;
                }

                if (__workflow_bodyinputFileURL != null)
                {
                    body["inputFileUrl"] = ExpressionConverter.ConvertO(__workflow_bodyinputFileURL);
                    bodypropCount++;
                }

                if (__workflow_bodyrange != null)
                {
                    body["range"] = ExpressionConverter.ConvertO(__workflow_bodyrange);
                    bodypropCount++;
                }

                if (__workflow_bodyfileMIMEType != null)
                {
                    body["inputFileMimeType"] = ExpressionConverter.ConvertO(__workflow_bodyfileMIMEType);
                    bodypropCount++;
                }

                if (__workflow_bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AnalyzeOperationResult>(callPayload);
            });
        }
    }

    public class ContentunderstandingTriggers([ConnectionName] string connectionId)
    {
    }

    public class AnalyzeOperationResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public OperationState Status { get; set; }

        [JsonProperty("error")]
        public AnalyzeOperationResultErrorType Error { get; set; }

        [JsonProperty("result")]
        public AnalysisResult Result { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationState
    {
        NotStarted,
        Running,
        Succeeded,
        Failed,
        Canceled
    }

    public class AnalyzeOperationResultErrorType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class AnalysisResult
    {
        [JsonProperty("analyzerId")]
        public string AnalyzerId { get; set; }

        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("warnings")]
        public AnalysisResultWarningsTypeItem[] Warnings { get; set; }

        [JsonProperty("_markdown")]
        public string MarkdownContent { get; set; }

        [JsonProperty("contents")]
        public AnalysisContent[] Contents { get; set; }
    }

    public class AnalysisResultWarningsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class AnalysisContent
    {
        [JsonProperty("kind")]
        public AnalysisContentKindType Kind { get; set; }

        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("analyzerId")]
        public string AnalyzerId { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AnalysisContentKindType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "audioVisual")]
        AudioVisual
    }

    public class AnalysisInput
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum processingLocationInput
    {
        [EnumMember(Value = "geography")]
        Geography,
        [EnumMember(Value = "dataZone")]
        DataZone,
        [EnumMember(Value = "global")]
        Global
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Contentunderstanding;

    public partial class WorkflowManagedActions
    {
        public ContentunderstandingActions Contentunderstanding(string connectionId) => new ContentunderstandingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ContentunderstandingTriggers Contentunderstanding(string connectionId) => new ContentunderstandingTriggers(connectionId);
    }
}