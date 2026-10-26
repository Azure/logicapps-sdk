//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cradlai
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CradlaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<CreateDocumentDeprecatedResponse, ApiConnectionActionConfiguration> CreateDocumentDeprecated(Expression<Func<string>> name, Expression<Func<string>> fileContent)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: true);
            return new DeferredBodyAction<CreateDocumentDeprecatedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileContent);
                return new ApiConnectionAction<CreateDocumentDeprecatedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<GetDocumentMetadataResponse, ApiConnectionActionConfiguration> GetDocumentMetadata(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetDocumentMetadataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/metadata/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<ParseDocumentDeprecatedResponse, ApiConnectionActionConfiguration> ParseDocumentDeprecated(Expression<Func<ParseDocumentDeprecatedInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ParseDocumentDeprecatedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/predictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ParseDocumentDeprecatedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateRun(Expression<Func<string>> agentId, Expression<Func<string>> document, Expression<Func<string>> actionId = null, Expression<Func<int>> maxWaitInterval = null, Expression<Func<string>> variables = null, Expression<Func<string>> title = null)
        {
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: false);
            var __workflow_maxWaitInterval = WorkflowExpression.Compile(maxWaitInterval, nameof(maxWaitInterval), required: false);
            var __workflow_variables = WorkflowExpression.Compile(variables, nameof(variables), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/agents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_variables != null)
                    callPayload.Queries["variables"] = ExpressionConverter.Convert(__workflow_variables);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                callPayload.Headers["AgentId"] = ExpressionConverter.Convert(__workflow_agentId);
                if (__workflow_actionId != null)
                    callPayload.Headers["ActionId"] = ExpressionConverter.Convert(__workflow_actionId);
                if (__workflow_maxWaitInterval != null)
                    callPayload.Headers["maxWaitInterval"] = ExpressionConverter.Convert(__workflow_maxWaitInterval);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_document);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Validate(Expression<Func<object>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<CreateExecutionDeprecatedResponse, ApiConnectionActionConfiguration> CreateExecutionDeprecated(Expression<Func<string>> workflowId, Expression<Func<CreateExecutionDeprecatedInput>> request)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<CreateExecutionDeprecatedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkflowId"] = ExpressionConverter.Convert(__workflow_workflowId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<CreateExecutionDeprecatedResponse>(callPayload);
            });
        }
    }

    public class CradlaiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RunCompletedResponse, ApiConnectionTriggerConfiguration> RunCompleted(Expression<Func<string>> actionId, Expression<Func<RunCompletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<RunCompletedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ActionId"] = ExpressionConverter.Convert(__workflow_actionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<RunCompletedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateDocumentDeprecatedResponse
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    public class GetDocumentMetadataResponse
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("name")]
        public string DocumentName { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }

    public class ParseDocumentDeprecatedResponse
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("inferenceTime")]
        public double InferenceTime { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("postprocessConfig")]
        public PostprocessConfig PostprocessConfig { get; set; }

        [JsonProperty("preprocessConfig")]
        public PreprocessConfig PreprocessConfig { get; set; }

        [JsonProperty("predictions")]
        public JToken Predictions { get; set; }

        [JsonProperty("trainingId")]
        public string TrainingId { get; set; }
    }

    public class PostprocessConfig
    {
        [JsonProperty("outputFormat")]
        public PostprocessConfigTheOutputFormatType TheOutputFormat { get; set; }

        [JsonProperty("strategy")]
        public PostprocessConfigTheStrategyUsedForAggregatingPredictionsType TheStrategyUsedForAggregatingPredictions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostprocessConfigTheOutputFormatType
    {
        [EnumMember(Value = "v1")]
        V1,
        [EnumMember(Value = "v2")]
        V2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostprocessConfigTheStrategyUsedForAggregatingPredictionsType
    {
        [EnumMember(Value = "BEST_N_PAGES")]
        BESTNPAGES,
        [EnumMember(Value = "BEST_FIRST")]
        BESTFIRST
    }

    public class PreprocessConfig
    {
        [JsonProperty("autoRotate")]
        public bool AutoRotate { get; set; }

        [JsonProperty("maxPages")]
        public int MaxPages { get; set; }

        [JsonProperty("imageQuality")]
        public string ImageQuality { get; set; }
    }

    public class ParseDocumentDeprecatedInput
    {
        [JsonProperty("modelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("postprocessConfig")]
        public PostprocessConfig PostprocessConfig { get; set; }

        [JsonProperty("preprocessConfig")]
        public PreprocessConfig PreprocessConfig { get; set; }
    }

    public class CreateExecutionDeprecatedResponse
    {
        [JsonProperty("executionId")]
        public string ExecutionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateExecutionDeprecatedInput
    {
        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkflowInput Input { get; set; }
    }

    public class WorkflowInput
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("predictions")]
        public JToken Predictions { get; set; }
    }

    public class RunCompletedResponse
    {
        [JsonProperty("output")]
        public JToken Output { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }
    }

    public class RunCompletedInput
    {
        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Enabled { get; set; } = true;

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public RunCompletedInputConfigType Config { get; set; }
    }

    public class RunCompletedInputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("httpMethod", DefaultValueHandling = DefaultValueHandling.Include)]
        internal RunCompletedInputConfigTypeHttpMethodType HttpMethod { get; set; } = RunCompletedInputConfigTypeHttpMethodType.POST;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunCompletedInputConfigTypeHttpMethodType
    {
        POST,
        GET,
        PUT
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cradlai;

    public partial class WorkflowManagedActions
    {
        public CradlaiActions Cradlai(string connectionId) => new CradlaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CradlaiTriggers Cradlai(string connectionId) => new CradlaiTriggers(connectionId);
    }
}