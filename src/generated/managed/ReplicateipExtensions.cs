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
        public IBodyWorkflowAction<PredictionListResponse> PredictionList()
        {
            var apiCallPath = "/predictions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PredictionListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionPostResponse> Prediction(Expression<Func<string>> bodyversion, Expression<Func<string>> bodyinputtext = null, Expression<Func<string>> bodyinputprompt = null, Expression<Func<string>> bodyinputpromptStrength = null, Expression<Func<int>> bodyinputwidth = null, Expression<Func<int>> bodyinputheight = null, Expression<Func<string>> bodyinputscale = null, Expression<Func<int>> bodyinputnumOutputs = null, Expression<Func<int>> bodyinputnumInferenceSteps = null, Expression<Func<string>> bodyinputguidanceScale = null, Expression<Func<int>> bodyinputseed = null, Expression<Func<string>> bodywebhookCompleted = null)
        {
            var __workflow_bodyversion = WorkflowExpression.Compile(bodyversion, nameof(bodyversion), required: true);
            var __workflow_bodyinputtext = WorkflowExpression.Compile(bodyinputtext, nameof(bodyinputtext), required: false);
            var __workflow_bodyinputprompt = WorkflowExpression.Compile(bodyinputprompt, nameof(bodyinputprompt), required: false);
            var __workflow_bodyinputpromptStrength = WorkflowExpression.Compile(bodyinputpromptStrength, nameof(bodyinputpromptStrength), required: false);
            var __workflow_bodyinputwidth = WorkflowExpression.Compile(bodyinputwidth, nameof(bodyinputwidth), required: false);
            var __workflow_bodyinputheight = WorkflowExpression.Compile(bodyinputheight, nameof(bodyinputheight), required: false);
            var __workflow_bodyinputscale = WorkflowExpression.Compile(bodyinputscale, nameof(bodyinputscale), required: false);
            var __workflow_bodyinputnumOutputs = WorkflowExpression.Compile(bodyinputnumOutputs, nameof(bodyinputnumOutputs), required: false);
            var __workflow_bodyinputnumInferenceSteps = WorkflowExpression.Compile(bodyinputnumInferenceSteps, nameof(bodyinputnumInferenceSteps), required: false);
            var __workflow_bodyinputguidanceScale = WorkflowExpression.Compile(bodyinputguidanceScale, nameof(bodyinputguidanceScale), required: false);
            var __workflow_bodyinputseed = WorkflowExpression.Compile(bodyinputseed, nameof(bodyinputseed), required: false);
            var __workflow_bodywebhookCompleted = WorkflowExpression.Compile(bodywebhookCompleted, nameof(bodywebhookCompleted), required: false);
            return new DeferredBodyAction<PredictionPostResponse>(() =>
            {
                var apiCallPath = "/predictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["version"] = ExpressionConverter.ConvertO(__workflow_bodyversion);
                var inputObject = new JObject();
                var inputObjectpropCount = 0;
                if (__workflow_bodyinputtext != null)
                {
                    inputObject["text"] = ExpressionConverter.ConvertO(__workflow_bodyinputtext);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputprompt != null)
                {
                    inputObject["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyinputprompt);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputpromptStrength != null)
                {
                    inputObject["prompt_strength"] = ExpressionConverter.ConvertO(__workflow_bodyinputpromptStrength);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputwidth != null)
                {
                    inputObject["width"] = ExpressionConverter.ConvertO(__workflow_bodyinputwidth);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputheight != null)
                {
                    inputObject["height"] = ExpressionConverter.ConvertO(__workflow_bodyinputheight);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputscale != null)
                {
                    inputObject["scale"] = ExpressionConverter.ConvertO(__workflow_bodyinputscale);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputnumOutputs != null)
                {
                    inputObject["num_outputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputnumOutputs);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputnumInferenceSteps != null)
                {
                    inputObject["num_inference_steps"] = ExpressionConverter.ConvertO(__workflow_bodyinputnumInferenceSteps);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputguidanceScale != null)
                {
                    inputObject["guidance_scale"] = ExpressionConverter.ConvertO(__workflow_bodyinputguidanceScale);
                    inputObjectpropCount++;
                }

                if (__workflow_bodyinputseed != null)
                {
                    inputObject["seed"] = ExpressionConverter.ConvertO(__workflow_bodyinputseed);
                    inputObjectpropCount++;
                }

                if (inputObjectpropCount > 0)
                {
                    body["input"] = inputObject;
                    bodypropCount++;
                }

                if (__workflow_bodywebhookCompleted != null)
                {
                    body["webhook_completed"] = ExpressionConverter.ConvertO(__workflow_bodywebhookCompleted);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PredictionPostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionGetResponse> PredictionGet(Expression<Func<string>> predictionId)
        {
            var __workflow_predictionId = WorkflowExpression.Compile(predictionId, nameof(predictionId), required: true);
            return new DeferredBodyAction<PredictionGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/predictions/{0}", __workflow_predictionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PredictionGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionCancelResponse> PredictionCancel(Expression<Func<string>> predictionId)
        {
            var __workflow_predictionId = WorkflowExpression.Compile(predictionId, nameof(predictionId), required: true);
            return new DeferredBodyAction<PredictionCancelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/predictions/{0}/cancel", __workflow_predictionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PredictionCancelResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<ModelGetResponse> ModelGet(Expression<Func<string>> modelOwner, Expression<Func<string>> modelName)
        {
            var __workflow_modelOwner = WorkflowExpression.Compile(modelOwner, nameof(modelOwner), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            return new DeferredBodyAction<ModelGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/models/{0}/{1}", __workflow_modelOwner.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<ModelListResponse> ModelList(Expression<Func<string>> collectionSlug)
        {
            var __workflow_collectionSlug = WorkflowExpression.Compile(collectionSlug, nameof(collectionSlug), required: true);
            return new DeferredBodyAction<ModelListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/collections/{0}", __workflow_collectionSlug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelListResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
