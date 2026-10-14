//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Replicateip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_bodyversion = bodyversion == null ? null : WorkflowExpression.Compile(bodyversion);
            WorkflowExpression.Validate(__workflow_bodyversion, nameof(bodyversion), required: true);
            var __workflow_bodyinputtext = bodyinputtext == null ? null : WorkflowExpression.Compile(bodyinputtext);
            WorkflowExpression.Validate(__workflow_bodyinputtext, nameof(bodyinputtext), required: false);
            var __workflow_bodyinputprompt = bodyinputprompt == null ? null : WorkflowExpression.Compile(bodyinputprompt);
            WorkflowExpression.Validate(__workflow_bodyinputprompt, nameof(bodyinputprompt), required: false);
            var __workflow_bodyinputpromptStrength = bodyinputpromptStrength == null ? null : WorkflowExpression.Compile(bodyinputpromptStrength);
            WorkflowExpression.Validate(__workflow_bodyinputpromptStrength, nameof(bodyinputpromptStrength), required: false);
            var __workflow_bodyinputwidth = bodyinputwidth == null ? null : WorkflowExpression.Compile(bodyinputwidth);
            WorkflowExpression.Validate(__workflow_bodyinputwidth, nameof(bodyinputwidth), required: false);
            var __workflow_bodyinputheight = bodyinputheight == null ? null : WorkflowExpression.Compile(bodyinputheight);
            WorkflowExpression.Validate(__workflow_bodyinputheight, nameof(bodyinputheight), required: false);
            var __workflow_bodyinputscale = bodyinputscale == null ? null : WorkflowExpression.Compile(bodyinputscale);
            WorkflowExpression.Validate(__workflow_bodyinputscale, nameof(bodyinputscale), required: false);
            var __workflow_bodyinputnumOutputs = bodyinputnumOutputs == null ? null : WorkflowExpression.Compile(bodyinputnumOutputs);
            WorkflowExpression.Validate(__workflow_bodyinputnumOutputs, nameof(bodyinputnumOutputs), required: false);
            var __workflow_bodyinputnumInferenceSteps = bodyinputnumInferenceSteps == null ? null : WorkflowExpression.Compile(bodyinputnumInferenceSteps);
            WorkflowExpression.Validate(__workflow_bodyinputnumInferenceSteps, nameof(bodyinputnumInferenceSteps), required: false);
            var __workflow_bodyinputguidanceScale = bodyinputguidanceScale == null ? null : WorkflowExpression.Compile(bodyinputguidanceScale);
            WorkflowExpression.Validate(__workflow_bodyinputguidanceScale, nameof(bodyinputguidanceScale), required: false);
            var __workflow_bodyinputseed = bodyinputseed == null ? null : WorkflowExpression.Compile(bodyinputseed);
            WorkflowExpression.Validate(__workflow_bodyinputseed, nameof(bodyinputseed), required: false);
            var __workflow_bodywebhookCompleted = bodywebhookCompleted == null ? null : WorkflowExpression.Compile(bodywebhookCompleted);
            WorkflowExpression.Validate(__workflow_bodywebhookCompleted, nameof(bodywebhookCompleted), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionGetResponse> PredictionGet(Expression<Func<string>> predictionId)
        {
            var __workflow_predictionId = predictionId == null ? null : WorkflowExpression.Compile(predictionId);
            WorkflowExpression.Validate(__workflow_predictionId, nameof(predictionId), required: true);
            return new DeferredBodyAction<PredictionGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/predictions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_predictionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PredictionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionCancelResponse> PredictionCancel(Expression<Func<string>> predictionId)
        {
            var __workflow_predictionId = predictionId == null ? null : WorkflowExpression.Compile(predictionId);
            WorkflowExpression.Validate(__workflow_predictionId, nameof(predictionId), required: true);
            return new DeferredBodyAction<PredictionCancelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/predictions/{0}/cancel", ExpressionConverter.ConvertWithUrlEncoding(__workflow_predictionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PredictionCancelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<ModelGetResponse> ModelGet(Expression<Func<string>> modelOwner, Expression<Func<string>> modelName)
        {
            var __workflow_modelOwner = modelOwner == null ? null : WorkflowExpression.Compile(modelOwner);
            WorkflowExpression.Validate(__workflow_modelOwner, nameof(modelOwner), required: true);
            var __workflow_modelName = modelName == null ? null : WorkflowExpression.Compile(modelName);
            WorkflowExpression.Validate(__workflow_modelName, nameof(modelName), required: true);
            return new DeferredBodyAction<ModelGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_modelOwner, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_modelName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<ModelListResponse> ModelList(Expression<Func<string>> collectionSlug)
        {
            var __workflow_collectionSlug = collectionSlug == null ? null : WorkflowExpression.Compile(collectionSlug);
            WorkflowExpression.Validate(__workflow_collectionSlug, nameof(collectionSlug), required: true);
            return new DeferredBodyAction<ModelListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_collectionSlug, 1));
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
