//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Replicateip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReplicateipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionListResponse> PredictionList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/predictions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PredictionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionPostResponse> Prediction([WorkflowExpression] Func<string> bodyversion, [WorkflowExpression] Func<string> bodyinputtext = null, [WorkflowExpression] Func<string> bodyinputprompt = null, [WorkflowExpression] Func<string> bodyinputpromptStrength = null, [WorkflowExpression] Func<int> bodyinputwidth = null, [WorkflowExpression] Func<int> bodyinputheight = null, [WorkflowExpression] Func<string> bodyinputscale = null, [WorkflowExpression] Func<int> bodyinputnumOutputs = null, [WorkflowExpression] Func<int> bodyinputnumInferenceSteps = null, [WorkflowExpression] Func<string> bodyinputguidanceScale = null, [WorkflowExpression] Func<int> bodyinputseed = null, [WorkflowExpression] Func<string> bodywebhookCompleted = null)
        {
            SourceExpression.Validate(bodyversion, nameof(bodyversion), required: true);
            SourceExpression.Validate(bodyinputtext, nameof(bodyinputtext), required: false);
            SourceExpression.Validate(bodyinputprompt, nameof(bodyinputprompt), required: false);
            SourceExpression.Validate(bodyinputpromptStrength, nameof(bodyinputpromptStrength), required: false);
            SourceExpression.Validate(bodyinputwidth, nameof(bodyinputwidth), required: false);
            SourceExpression.Validate(bodyinputheight, nameof(bodyinputheight), required: false);
            SourceExpression.Validate(bodyinputscale, nameof(bodyinputscale), required: false);
            SourceExpression.Validate(bodyinputnumOutputs, nameof(bodyinputnumOutputs), required: false);
            SourceExpression.Validate(bodyinputnumInferenceSteps, nameof(bodyinputnumInferenceSteps), required: false);
            SourceExpression.Validate(bodyinputguidanceScale, nameof(bodyinputguidanceScale), required: false);
            SourceExpression.Validate(bodyinputseed, nameof(bodyinputseed), required: false);
            SourceExpression.Validate(bodywebhookCompleted, nameof(bodywebhookCompleted), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/predictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["version"] = SourceExpressionConverter.ConvertToken(bodyversion);
                var inputObject = new JObject();
                var inputObjectpropCount = 0;
                if (bodyinputtext != null)
                {
                    inputObject["text"] = SourceExpressionConverter.ConvertToken(bodyinputtext);
                    inputObjectpropCount++;
                }

                if (bodyinputprompt != null)
                {
                    inputObject["prompt"] = SourceExpressionConverter.ConvertToken(bodyinputprompt);
                    inputObjectpropCount++;
                }

                if (bodyinputpromptStrength != null)
                {
                    inputObject["prompt_strength"] = SourceExpressionConverter.ConvertToken(bodyinputpromptStrength);
                    inputObjectpropCount++;
                }

                if (bodyinputwidth != null)
                {
                    inputObject["width"] = SourceExpressionConverter.ConvertToken(bodyinputwidth);
                    inputObjectpropCount++;
                }

                if (bodyinputheight != null)
                {
                    inputObject["height"] = SourceExpressionConverter.ConvertToken(bodyinputheight);
                    inputObjectpropCount++;
                }

                if (bodyinputscale != null)
                {
                    inputObject["scale"] = SourceExpressionConverter.ConvertToken(bodyinputscale);
                    inputObjectpropCount++;
                }

                if (bodyinputnumOutputs != null)
                {
                    inputObject["num_outputs"] = SourceExpressionConverter.ConvertToken(bodyinputnumOutputs);
                    inputObjectpropCount++;
                }

                if (bodyinputnumInferenceSteps != null)
                {
                    inputObject["num_inference_steps"] = SourceExpressionConverter.ConvertToken(bodyinputnumInferenceSteps);
                    inputObjectpropCount++;
                }

                if (bodyinputguidanceScale != null)
                {
                    inputObject["guidance_scale"] = SourceExpressionConverter.ConvertToken(bodyinputguidanceScale);
                    inputObjectpropCount++;
                }

                if (bodyinputseed != null)
                {
                    inputObject["seed"] = SourceExpressionConverter.ConvertToken(bodyinputseed);
                    inputObjectpropCount++;
                }

                if (inputObjectpropCount > 0)
                {
                    body["input"] = inputObject;
                    bodypropCount++;
                }

                if (bodywebhookCompleted != null)
                {
                    body["webhook_completed"] = SourceExpressionConverter.ConvertToken(bodywebhookCompleted);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PredictionPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionGetResponse> PredictionGet([WorkflowExpression] Func<string> predictionId)
        {
            SourceExpression.Validate(predictionId, nameof(predictionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/predictions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(predictionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PredictionGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<PredictionCancelResponse> PredictionCancel([WorkflowExpression] Func<string> predictionId)
        {
            SourceExpression.Validate(predictionId, nameof(predictionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/predictions/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(predictionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PredictionCancelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<ModelGetResponse> ModelGet([WorkflowExpression] Func<string> modelOwner, [WorkflowExpression] Func<string> modelName)
        {
            SourceExpression.Validate(modelOwner, nameof(modelOwner), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelOwner, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicateip")]
        public IBodyWorkflowAction<ModelListResponse> ModelList([WorkflowExpression] Func<string> collectionSlug)
        {
            SourceExpression.Validate(collectionSlug, nameof(collectionSlug), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/collections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionSlug, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelListResponse>(BuildSourceInput);
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