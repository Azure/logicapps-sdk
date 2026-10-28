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
        public IBodyWorkflowAction<CreateDocumentDeprecatedResponse> CreateDocumentDeprecated(Expression<Func<string>> name, Expression<Func<string>> fileContent = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: false);
            return new DeferredBodyAction<CreateDocumentDeprecatedResponse>(() =>
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
        public IBodyWorkflowAction<GetDocumentMetadataResponse> GetDocumentMetadata(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetDocumentMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/metadata/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<string> GetDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<ParseDocumentDeprecatedResponse> ParseDocumentDeprecated(Expression<Func<string>> requestmodel, Expression<Func<string>> requestdocumentID, Expression<Func<requestpostprocessingtheOutputFormatInput>> requestpostprocessingtheOutputFormat = null, Expression<Func<requestpostprocessingtheStrategyUsedForAggregatingPredictionsInput>> requestpostprocessingtheStrategyUsedForAggregatingPredictions = null, Expression<Func<bool>> requestpreprocessingautoRotate = null, Expression<Func<int>> requestpreprocessingmaxPages = null, Expression<Func<string>> requestpreprocessingimageQuality = null)
        {
            var __workflow_requestmodel = WorkflowExpression.Compile(requestmodel, nameof(requestmodel), required: true);
            var __workflow_requestdocumentID = WorkflowExpression.Compile(requestdocumentID, nameof(requestdocumentID), required: true);
            var __workflow_requestpostprocessingtheOutputFormat = WorkflowExpression.Compile(requestpostprocessingtheOutputFormat, nameof(requestpostprocessingtheOutputFormat), required: false);
            var __workflow_requestpostprocessingtheStrategyUsedForAggregatingPredictions = WorkflowExpression.Compile(requestpostprocessingtheStrategyUsedForAggregatingPredictions, nameof(requestpostprocessingtheStrategyUsedForAggregatingPredictions), required: false);
            var __workflow_requestpreprocessingautoRotate = WorkflowExpression.Compile(requestpreprocessingautoRotate, nameof(requestpreprocessingautoRotate), required: false);
            var __workflow_requestpreprocessingmaxPages = WorkflowExpression.Compile(requestpreprocessingmaxPages, nameof(requestpreprocessingmaxPages), required: false);
            var __workflow_requestpreprocessingimageQuality = WorkflowExpression.Compile(requestpreprocessingimageQuality, nameof(requestpreprocessingimageQuality), required: false);
            return new DeferredBodyAction<ParseDocumentDeprecatedResponse>(() =>
            {
                var apiCallPath = "/predictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["modelId"] = ExpressionConverter.ConvertO(__workflow_requestmodel);
                requestpropCount++;
                request["documentId"] = ExpressionConverter.ConvertO(__workflow_requestdocumentID);
                var postprocessConfigObject = new JObject();
                var postprocessConfigObjectpropCount = 0;
                if (__workflow_requestpostprocessingtheOutputFormat != null)
                {
                    if (__workflow_requestpostprocessingtheOutputFormat != null)
                    {
                        postprocessConfigObject["outputFormat"] = ExpressionConverter.ConvertO(__workflow_requestpostprocessingtheOutputFormat);
                        postprocessConfigObjectpropCount++;
                    }

                    postprocessConfigObjectpropCount++;
                }
                else
                {
                    postprocessConfigObject["outputFormat"] = "v2";
                    postprocessConfigObjectpropCount++;
                }

                if (__workflow_requestpostprocessingtheStrategyUsedForAggregatingPredictions != null)
                {
                    if (__workflow_requestpostprocessingtheStrategyUsedForAggregatingPredictions != null)
                    {
                        postprocessConfigObject["strategy"] = ExpressionConverter.ConvertO(__workflow_requestpostprocessingtheStrategyUsedForAggregatingPredictions);
                        postprocessConfigObjectpropCount++;
                    }

                    postprocessConfigObjectpropCount++;
                }
                else
                {
                    postprocessConfigObject["strategy"] = "BEST_FIRST";
                    postprocessConfigObjectpropCount++;
                }

                if (postprocessConfigObjectpropCount > 0)
                {
                    request["postprocessConfig"] = postprocessConfigObject;
                    requestpropCount++;
                }

                var preprocessConfigObject = new JObject();
                var preprocessConfigObjectpropCount = 0;
                if (__workflow_requestpreprocessingautoRotate != null)
                {
                    preprocessConfigObject["autoRotate"] = ExpressionConverter.ConvertO(__workflow_requestpreprocessingautoRotate);
                    preprocessConfigObjectpropCount++;
                }

                if (__workflow_requestpreprocessingmaxPages != null)
                {
                    preprocessConfigObject["maxPages"] = ExpressionConverter.ConvertO(__workflow_requestpreprocessingmaxPages);
                    preprocessConfigObjectpropCount++;
                }

                if (__workflow_requestpreprocessingimageQuality != null)
                {
                    preprocessConfigObject["imageQuality"] = ExpressionConverter.ConvertO(__workflow_requestpreprocessingimageQuality);
                    preprocessConfigObjectpropCount++;
                }

                if (preprocessConfigObjectpropCount > 0)
                {
                    request["preprocessConfig"] = preprocessConfigObject;
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ParseDocumentDeprecatedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<CreateRunResponse> CreateRun(Expression<Func<string>> agentId, Expression<Func<string>> variables = null, Expression<Func<string>> title = null, Expression<Func<string>> document = null)
        {
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            var __workflow_variables = WorkflowExpression.Compile(variables, nameof(variables), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: false);
            return new DeferredBodyAction<CreateRunResponse>(() =>
            {
                var apiCallPath = "/agents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["AgentId"] = ExpressionConverter.Convert(__workflow_agentId);
                if (__workflow_variables != null)
                    callPayload.Headers["variables"] = ExpressionConverter.Convert(__workflow_variables);
                if (__workflow_title != null)
                    callPayload.Headers["title"] = ExpressionConverter.Convert(__workflow_title);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_document);
                return new ApiConnectionAction<CreateRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IWorkflowAction Validate(Expression<Func<string>> actionId, Expression<Func<string>> xCradlSharedSecret)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            var __workflow_xCradlSharedSecret = WorkflowExpression.Compile(xCradlSharedSecret, nameof(xCradlSharedSecret), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/validate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ActionId"] = ExpressionConverter.Convert(__workflow_actionId);
                callPayload.Headers["X-Cradl-Shared-Secret"] = ExpressionConverter.Convert(__workflow_xCradlSharedSecret);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<CreateExecutionDeprecatedResponse> CreateExecutionDeprecated(Expression<Func<string>> workflowId, Expression<Func<string>> requestinputdocumentID, Expression<Func<string>> requestinputtitle = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_requestinputdocumentID = WorkflowExpression.Compile(requestinputdocumentID, nameof(requestinputdocumentID), required: true);
            var __workflow_requestinputtitle = WorkflowExpression.Compile(requestinputtitle, nameof(requestinputtitle), required: false);
            return new DeferredBodyAction<CreateExecutionDeprecatedResponse>(() =>
            {
                var apiCallPath = "/workflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkflowId"] = ExpressionConverter.Convert(__workflow_workflowId);
                var request = new JObject();
                var requestpropCount = 0;
                var inputObject = new JObject();
                var inputObjectpropCount = 0;
                inputObjectpropCount++;
                inputObject["documentId"] = ExpressionConverter.ConvertO(__workflow_requestinputdocumentID);
                if (__workflow_requestinputtitle != null)
                {
                    inputObject["title"] = ExpressionConverter.ConvertO(__workflow_requestinputtitle);
                    inputObjectpropCount++;
                }

                var predictionsObject = new JObject();
                var predictionsObjectpropCount = 0;
                if (predictionsObjectpropCount > 0)
                {
                    inputObject["predictions"] = predictionsObject;
                    inputObjectpropCount++;
                }

                if (inputObjectpropCount > 0)
                {
                    request["input"] = inputObject;
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<CreateExecutionDeprecatedResponse>(callPayload);
            });
        }
    }

    public class CradlaiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RunCompletedResponse> RunCompleted(Expression<Func<string>> actionId, FlowRecurrence recurrence = null)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            return new DeferredBodyTrigger<RunCompletedResponse>(() =>
            {
                var apiCallPath = "/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ActionId"] = ExpressionConverter.Convert(__workflow_actionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["enabled"] = true;
                bodypropCount++;
                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                configObject["httpMethod"] = "POST";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestpostprocessingtheOutputFormatInput
    {
        [EnumMember(Value = "v1")]
        V1,
        [EnumMember(Value = "v2")]
        V2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestpostprocessingtheStrategyUsedForAggregatingPredictionsInput
    {
        [EnumMember(Value = "BEST_N_PAGES")]
        BESTNPAGES,
        [EnumMember(Value = "BEST_FIRST")]
        BESTFIRST
    }

    public class CreateRunResponse
    {
        [JsonProperty("runId")]
        public string AgentRunId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateExecutionDeprecatedResponse
    {
        [JsonProperty("executionId")]
        public string ExecutionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RunCompletedResponse
    {
        [JsonProperty("output")]
        public JToken Output { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }
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
