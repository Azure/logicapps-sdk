//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Contentunderstanding
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ContentunderstandingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentunderstanding")]
        public IBodyWorkflowAction<AnalyzeOperationResult> AnalyzeContent([WorkflowExpression] Func<string> analyzerId, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<string> bodyinputFileURL = null, [WorkflowExpression] Func<string> bodyrange = null, [WorkflowExpression] Func<string> bodyfileMIMEType = null, [WorkflowExpression] Func<AnalysisInput[]> bodyinputs = null, [WorkflowExpression] Func<processingLocationInput> processingLocation = null, [WorkflowExpression] Func<string> stringEncoding = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contentunderstanding/analyzers/{0}:analyze", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(analyzerId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-01");
                if (processingLocation != null)
                    callPayload.Queries["processingLocation"] = SourceExpressionConverter.Convert(processingLocation);
                if (stringEncoding != null)
                    callPayload.Queries["stringEncoding"] = SourceExpressionConverter.ConvertO(stringEncoding);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileContent != null)
                {
                    body["inputFileContent"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                    bodypropCount++;
                }

                if (bodyinputFileURL != null)
                {
                    body["inputFileUrl"] = SourceExpressionConverter.ConvertToken(bodyinputFileURL);
                    bodypropCount++;
                }

                if (bodyrange != null)
                {
                    body["range"] = SourceExpressionConverter.ConvertToken(bodyrange);
                    bodypropCount++;
                }

                if (bodyfileMIMEType != null)
                {
                    body["inputFileMimeType"] = SourceExpressionConverter.ConvertToken(bodyfileMIMEType);
                    bodypropCount++;
                }

                if (bodyinputs != null)
                {
                    body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AnalyzeOperationResult>(BuildSourceInput);
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