//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Replicateip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReplicateipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionListResponse, ApiConnectionActionConfiguration> PredictionList()
        {
            return new DeferredBodyAction<PredictionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/predictions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PredictionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionPostResponse, ApiConnectionActionConfiguration> Prediction(Expression<Func<PredictionPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PredictionPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/predictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PredictionPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionGetResponse, ApiConnectionActionConfiguration> PredictionGet(Expression<Func<string>> predictionId)
        {
            var __workflow_predictionId = WorkflowExpression.Compile(predictionId, nameof(predictionId), required: true);
            return new DeferredBodyAction<PredictionGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/predictions/{0}", __workflow_predictionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PredictionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionCancelResponse, ApiConnectionActionConfiguration> PredictionCancel(Expression<Func<string>> predictionId)
        {
            var __workflow_predictionId = WorkflowExpression.Compile(predictionId, nameof(predictionId), required: true);
            return new DeferredBodyAction<PredictionCancelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/predictions/{0}/cancel", __workflow_predictionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PredictionCancelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<ModelGetResponse, ApiConnectionActionConfiguration> ModelGet(Expression<Func<string>> modelOwner, Expression<Func<string>> modelName)
        {
            var __workflow_modelOwner = WorkflowExpression.Compile(modelOwner, nameof(modelOwner), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            return new DeferredBodyAction<ModelGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/models/{0}/{1}", __workflow_modelOwner.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<ModelListResponse, ApiConnectionActionConfiguration> ModelList(Expression<Func<string>> collectionSlug)
        {
            var __workflow_collectionSlug = WorkflowExpression.Compile(collectionSlug, nameof(collectionSlug), required: true);
            return new DeferredBodyAction<ModelListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/collections/{0}", __workflow_collectionSlug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelListResponse>(callPayload);
            });
        }
    }

    public class ReplicateipTriggers([ConnectionName] string connectionId)
    {
    }

    public class PredictionListResponse
    {
        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("results")]
        public PredictionListResponseResultsTypeItem[] Results { get; set; }
    }

    public class PredictionListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("urls")]
        public PredictionListResponseResultsTypeItemUrlsType Urls { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PredictionListResponseResultsTypeItemUrlsType
    {
        [JsonProperty("get")]
        public string Get { get; set; }

        [JsonProperty("cancel")]
        public string Cancel { get; set; }
    }

    public class PredictionPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("urls")]
        public PredictionPostResponseUrlsType Urls { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("input")]
        public PredictionPostResponseInputType Input { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("logs")]
        public string Logs { get; set; }
    }

    public class PredictionPostResponseUrlsType
    {
        [JsonProperty("get")]
        public string Get { get; set; }

        [JsonProperty("cancel")]
        public string Cancel { get; set; }
    }

    public class PredictionPostResponseInputType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("prompt_strength")]
        public string PromptStrength { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("scale")]
        public string Scale { get; set; }

        [JsonProperty("num_outputs")]
        public int NumOutputs { get; set; }

        [JsonProperty("num_inference_steps")]
        public int NumInferenceSteps { get; set; }

        [JsonProperty("guidance_scale")]
        public string GuidanceScale { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }
    }

    public class PredictionPostInput
    {
        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Version { get; set; }

        [JsonProperty("input")]
        public PredictionPostInputInputType Input { get; set; }

        [JsonProperty("webhook_completed")]
        public string WebhookCompleted { get; set; }
    }

    public class PredictionPostInputInputType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("prompt_strength")]
        public string PromptStrength { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("scale")]
        public string Scale { get; set; }

        [JsonProperty("num_outputs")]
        public int? NumOutputs { get; set; }

        [JsonProperty("num_inference_steps")]
        public int? NumInferenceSteps { get; set; }

        [JsonProperty("guidance_scale")]
        public string GuidanceScale { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }
    }

    public class PredictionGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("urls")]
        public PredictionGetResponseUrlsType Urls { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("input")]
        public PredictionGetResponseInputType Input { get; set; }

        [JsonProperty("output")]
        public string[] Output { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("logs")]
        public string Logs { get; set; }

        [JsonProperty("metrics")]
        public PredictionGetResponseMetricsType Metrics { get; set; }
    }

    public class PredictionGetResponseUrlsType
    {
        [JsonProperty("get")]
        public string Get { get; set; }

        [JsonProperty("cancel")]
        public string Cancel { get; set; }
    }

    public class PredictionGetResponseInputType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("prompt_strength")]
        public string PromptStrength { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("scale")]
        public string Scale { get; set; }

        [JsonProperty("num_outputs")]
        public int NumOutputs { get; set; }

        [JsonProperty("num_inference_steps")]
        public int NumInferenceSteps { get; set; }

        [JsonProperty("guidance_scale")]
        public string GuidanceScale { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }
    }

    public class PredictionGetResponseMetricsType
    {
        [JsonProperty("predict_time")]
        public double PredictTime { get; set; }
    }

    public class PredictionCancelResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("urls")]
        public PredictionCancelResponseUrlsType Urls { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("input")]
        public PredictionCancelResponseInputType Input { get; set; }

        [JsonProperty("output")]
        public string[] Output { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("logs")]
        public string Logs { get; set; }

        [JsonProperty("metrics")]
        public PredictionCancelResponseMetricsType Metrics { get; set; }
    }

    public class PredictionCancelResponseUrlsType
    {
        [JsonProperty("get")]
        public string Get { get; set; }

        [JsonProperty("cancel")]
        public string Cancel { get; set; }
    }

    public class PredictionCancelResponseInputType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("prompt_strength")]
        public string PromptStrength { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("scale")]
        public string Scale { get; set; }

        [JsonProperty("num_outputs")]
        public int NumOutputs { get; set; }

        [JsonProperty("num_inference_steps")]
        public int NumInferenceSteps { get; set; }

        [JsonProperty("guidance_scale")]
        public string GuidanceScale { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }
    }

    public class PredictionCancelResponseMetricsType
    {
        [JsonProperty("predict_time")]
        public double PredictTime { get; set; }
    }

    public class ModelGetResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("github_url")]
        public string GithubUrl { get; set; }

        [JsonProperty("paper_url")]
        public string PaperUrl { get; set; }

        [JsonProperty("license_url")]
        public string LicenseUrl { get; set; }

        [JsonProperty("latest_version")]
        public ModelGetResponseLatestVersionType LatestVersion { get; set; }
    }

    public class ModelGetResponseLatestVersionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("cog_version")]
        public string CogVersion { get; set; }

        [JsonProperty("openapi_schema")]
        public ModelGetResponseLatestVersionTypeOpenapiSchemaType OpenapiSchema { get; set; }
    }

    public class ModelGetResponseLatestVersionTypeOpenapiSchemaType
    {
        [JsonProperty("info")]
        public ModelGetResponseLatestVersionTypeOpenapiSchemaTypeInfoType Info { get; set; }

        [JsonProperty("openapi")]
        public string Openapi { get; set; }
    }

    public class ModelGetResponseLatestVersionTypeOpenapiSchemaTypeInfoType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class ModelListResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("models")]
        public ModelListResponseModelsTypeItem[] Models { get; set; }
    }

    public class ModelListResponseModelsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("github_url")]
        public string GithubUrl { get; set; }

        [JsonProperty("paper_url")]
        public string PaperUrl { get; set; }

        [JsonProperty("license_url")]
        public string LicenseUrl { get; set; }

        [JsonProperty("latest_version")]
        public ModelListResponseModelsTypeItemLatestVersionType LatestVersion { get; set; }
    }

    public class ModelListResponseModelsTypeItemLatestVersionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("cog_version")]
        public string CogVersion { get; set; }

        [JsonProperty("openapi_schema")]
        public ModelListResponseModelsTypeItemLatestVersionTypeOpenapiSchemaType OpenapiSchema { get; set; }
    }

    public class ModelListResponseModelsTypeItemLatestVersionTypeOpenapiSchemaType
    {
        [JsonProperty("info")]
        public ModelListResponseModelsTypeItemLatestVersionTypeOpenapiSchemaTypeInfoType Info { get; set; }

        [JsonProperty("openapi")]
        public string Openapi { get; set; }
    }

    public class ModelListResponseModelsTypeItemLatestVersionTypeOpenapiSchemaTypeInfoType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Replicateip;

    public partial class WorkflowManagedActions
    {
        public ReplicateipActions Replicateip(string connectionId) => new ReplicateipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReplicateipTriggers Replicateip(string connectionId) => new ReplicateipTriggers(connectionId);
    }
}