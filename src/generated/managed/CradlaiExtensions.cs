//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cradlai
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CradlaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<CreateDocumentDeprecatedResponse> CreateDocumentDeprecated([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> fileContent = null)
        {
            var apiCallPath = "/documents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Name"] = ExpressionConverter.Convert(name);
            callPayload.Body = ExpressionConverter.ConvertO(fileContent);
            return new ApiConnectionAction<CreateDocumentDeprecatedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<GetDocumentMetadataResponse> GetDocumentMetadata([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> documentId)
        {
            var apiCallPath = String.Format("/metadata/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<string> GetDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> documentId)
        {
            var apiCallPath = String.Format("/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<ParseDocumentDeprecatedResponse> ParseDocumentDeprecated([WorkflowExpression] Func<string> requestmodel, [WorkflowExpression] Func<string> requestdocumentID, [WorkflowExpression] Func<requestpostprocessingtheOutputFormatInput> requestpostprocessingtheOutputFormat = null, [WorkflowExpression] Func<requestpostprocessingtheStrategyUsedForAggregatingPredictionsInput> requestpostprocessingtheStrategyUsedForAggregatingPredictions = null, [WorkflowExpression] Func<bool> requestpreprocessingautoRotate = null, [WorkflowExpression] Func<int> requestpreprocessingmaxPages = null, [WorkflowExpression] Func<string> requestpreprocessingimageQuality = null)
        {
            var apiCallPath = "/predictions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["modelId"] = ExpressionConverter.ConvertO(requestmodel);
            requestpropCount++;
            request["documentId"] = ExpressionConverter.ConvertO(requestdocumentID);
            var postprocessConfigObject = new JObject();
            var postprocessConfigObjectpropCount = 0;
            if (requestpostprocessingtheOutputFormat != null)
            {
                if (requestpostprocessingtheOutputFormat != null)
                {
                    postprocessConfigObject["outputFormat"] = ExpressionConverter.ConvertO(requestpostprocessingtheOutputFormat);
                    postprocessConfigObjectpropCount++;
                }

                postprocessConfigObjectpropCount++;
            }
            else
            {
                postprocessConfigObject["outputFormat"] = "v2";
                postprocessConfigObjectpropCount++;
            }

            if (requestpostprocessingtheStrategyUsedForAggregatingPredictions != null)
            {
                if (requestpostprocessingtheStrategyUsedForAggregatingPredictions != null)
                {
                    postprocessConfigObject["strategy"] = ExpressionConverter.ConvertO(requestpostprocessingtheStrategyUsedForAggregatingPredictions);
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
            if (requestpreprocessingautoRotate != null)
            {
                preprocessConfigObject["autoRotate"] = ExpressionConverter.ConvertO(requestpreprocessingautoRotate);
                preprocessConfigObjectpropCount++;
            }

            if (requestpreprocessingmaxPages != null)
            {
                preprocessConfigObject["maxPages"] = ExpressionConverter.ConvertO(requestpreprocessingmaxPages);
                preprocessConfigObjectpropCount++;
            }

            if (requestpreprocessingimageQuality != null)
            {
                preprocessConfigObject["imageQuality"] = ExpressionConverter.ConvertO(requestpreprocessingimageQuality);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<CreateRunResponse> CreateRun([WorkflowExpression] Func<string> agentId, [WorkflowExpression] Func<string> variables = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> document = null)
        {
            var apiCallPath = "/agents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["AgentId"] = ExpressionConverter.Convert(agentId);
            if (variables != null)
                callPayload.Headers["variables"] = ExpressionConverter.Convert(variables);
            if (title != null)
                callPayload.Headers["title"] = ExpressionConverter.Convert(title);
            callPayload.Body = ExpressionConverter.ConvertO(document);
            return new ApiConnectionAction<CreateRunResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IWorkflowAction Validate([WorkflowExpression] Func<string> actionId, [WorkflowExpression] Func<string> xCradlSharedSecret)
        {
            var apiCallPath = "/validate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["ActionId"] = ExpressionConverter.Convert(actionId);
            callPayload.Headers["X-Cradl-Shared-Secret"] = ExpressionConverter.Convert(xCradlSharedSecret);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cradlai")]
        public IBodyWorkflowAction<CreateExecutionDeprecatedResponse> CreateExecutionDeprecated([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> requestinputdocumentID, [WorkflowExpression] Func<string> requestinputtitle = null)
        {
            var apiCallPath = "/workflows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["WorkflowId"] = ExpressionConverter.Convert(workflowId);
            var request = new JObject();
            var requestpropCount = 0;
            var inputObject = new JObject();
            var inputObjectpropCount = 0;
            inputObjectpropCount++;
            inputObject["documentId"] = ExpressionConverter.ConvertO(requestinputdocumentID);
            if (requestinputtitle != null)
            {
                inputObject["title"] = ExpressionConverter.ConvertO(requestinputtitle);
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
        }
    }

    public class CradlaiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RunCompletedResponse> RunCompleted([WorkflowExpression] Func<string> actionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/actions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["ActionId"] = ExpressionConverter.Convert(actionId);
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

            return new ApiConnectionTrigger<RunCompletedResponse>(callPayload, triggerName, recurrence);
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

    public enum PostprocessConfigTheOutputFormatType
    {
        [EnumMember(Value = "v1")]
        V1,
        [EnumMember(Value = "v2")]
        V2
    }

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

    public enum requestpostprocessingtheOutputFormatInput
    {
        [EnumMember(Value = "v1")]
        V1,
        [EnumMember(Value = "v2")]
        V2
    }

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