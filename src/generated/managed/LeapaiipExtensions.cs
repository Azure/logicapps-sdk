//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leapaiip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeapaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ImagesGetResponseItem[], ApiConnectionActionConfiguration> ImagesGet(Expression<Func<modelIdInput>> modelId, Expression<Func<bool>> onlyFinished = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_modelId = WorkflowExpression.Compile(modelId, nameof(modelId), required: true);
            var __workflow_onlyFinished = WorkflowExpression.Compile(onlyFinished, nameof(onlyFinished), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<ImagesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/images/models/{0}/inferences", __workflow_modelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_onlyFinished != null)
                    callPayload.Queries["onlyFinished"] = ExpressionConverter.Convert(__workflow_onlyFinished);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<ImagesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ImagePostResponse, ApiConnectionActionConfiguration> Image(Expression<Func<modelIdInput>> modelId, Expression<Func<string>> bodyprompt, Expression<Func<string>> bodynegativePrompt = null, Expression<Func<int>> bodysteps = null, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodynumberOfImages = null, Expression<Func<int>> bodypromptStrength = null, Expression<Func<int>> bodyseed = null, Expression<Func<string>> bodywebhookUrl = null)
        {
            var __workflow_modelId = WorkflowExpression.Compile(modelId, nameof(modelId), required: true);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: true);
            var __workflow_bodynegativePrompt = WorkflowExpression.Compile(bodynegativePrompt, nameof(bodynegativePrompt), required: false);
            var __workflow_bodysteps = WorkflowExpression.Compile(bodysteps, nameof(bodysteps), required: false);
            var __workflow_bodywidth = WorkflowExpression.Compile(bodywidth, nameof(bodywidth), required: false);
            var __workflow_bodyheight = WorkflowExpression.Compile(bodyheight, nameof(bodyheight), required: false);
            var __workflow_bodynumberOfImages = WorkflowExpression.Compile(bodynumberOfImages, nameof(bodynumberOfImages), required: false);
            var __workflow_bodypromptStrength = WorkflowExpression.Compile(bodypromptStrength, nameof(bodypromptStrength), required: false);
            var __workflow_bodyseed = WorkflowExpression.Compile(bodyseed, nameof(bodyseed), required: false);
            var __workflow_bodywebhookUrl = WorkflowExpression.Compile(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            return new DeferredBodyAction<ImagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/images/models/{0}/inferences", __workflow_modelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                if (__workflow_bodynegativePrompt != null)
                {
                    body["negativePrompt"] = ExpressionConverter.ConvertO(__workflow_bodynegativePrompt);
                    bodypropCount++;
                }

                if (__workflow_bodysteps != null)
                {
                    body["steps"] = ExpressionConverter.ConvertO(__workflow_bodysteps);
                    bodypropCount++;
                }

                if (__workflow_bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                    bodypropCount++;
                }

                if (__workflow_bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfImages != null)
                {
                    body["numberOfImages"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfImages);
                    bodypropCount++;
                }

                if (__workflow_bodypromptStrength != null)
                {
                    body["promptStrength"] = ExpressionConverter.ConvertO(__workflow_bodypromptStrength);
                    bodypropCount++;
                }

                if (__workflow_bodyseed != null)
                {
                    body["seed"] = ExpressionConverter.ConvertO(__workflow_bodyseed);
                    bodypropCount++;
                }

                if (__workflow_bodywebhookUrl != null)
                {
                    body["webhookUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ImageGetResponse, ApiConnectionActionConfiguration> ImageGet(Expression<Func<modelIdInput>> modelId, Expression<Func<string>> inferenceId)
        {
            var __workflow_modelId = WorkflowExpression.Compile(modelId, nameof(modelId), required: true);
            var __workflow_inferenceId = WorkflowExpression.Compile(inferenceId, nameof(inferenceId), required: true);
            return new DeferredBodyAction<ImageGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/images/models/{0}/inferences/{1}", __workflow_modelId.WithUrlEncoding(1), __workflow_inferenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ImageDelete(Expression<Func<modelIdInput>> modelId, Expression<Func<string>> inferenceId)
        {
            var __workflow_modelId = WorkflowExpression.Compile(modelId, nameof(modelId), required: true);
            var __workflow_inferenceId = WorkflowExpression.Compile(inferenceId, nameof(inferenceId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/images/models/{0}/inferences/{1}", __workflow_modelId.WithUrlEncoding(1), __workflow_inferenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ModelPostResponse, ApiConnectionActionConfiguration> Model(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysubjectKeyword = null, Expression<Func<string>> bodysubjectType = null, Expression<Func<string>> bodywebhookUrl = null, Expression<Func<string[]>> bodyimageSampleUrls = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodysubjectKeyword = WorkflowExpression.Compile(bodysubjectKeyword, nameof(bodysubjectKeyword), required: false);
            var __workflow_bodysubjectType = WorkflowExpression.Compile(bodysubjectType, nameof(bodysubjectType), required: false);
            var __workflow_bodywebhookUrl = WorkflowExpression.Compile(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            var __workflow_bodyimageSampleUrls = WorkflowExpression.Compile(bodyimageSampleUrls, nameof(bodyimageSampleUrls), required: false);
            return new DeferredBodyAction<ModelPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/images/models/new";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodysubjectKeyword != null)
                {
                    body["subjectKeyword"] = ExpressionConverter.ConvertO(__workflow_bodysubjectKeyword);
                    bodypropCount++;
                }

                if (__workflow_bodysubjectType != null)
                {
                    body["subjectType"] = ExpressionConverter.ConvertO(__workflow_bodysubjectType);
                    bodypropCount++;
                }

                if (__workflow_bodywebhookUrl != null)
                {
                    body["webhookUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebhookUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyimageSampleUrls != null)
                {
                    body["imageSampleUrls"] = ExpressionConverter.ConvertO(__workflow_bodyimageSampleUrls);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModelPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ModelsGetResponse, ApiConnectionActionConfiguration> ModelsGet()
        {
            var apiCallPath = "/v2/images/models";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ModelsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ModelGetResponse, ApiConnectionActionConfiguration> ModelGet(Expression<Func<modelIdInput>> modelId)
        {
            var __workflow_modelId = WorkflowExpression.Compile(modelId, nameof(modelId), required: true);
            return new DeferredBodyAction<ModelGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/images/models/{0}", __workflow_modelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ModelDeleteResponse, ApiConnectionActionConfiguration> ModelDelete(Expression<Func<modelIdInput>> modelId)
        {
            var __workflow_modelId = WorkflowExpression.Compile(modelId, nameof(modelId), required: true);
            return new DeferredBodyAction<ModelDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/images/models/{0}", __workflow_modelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<MusicsGetResponseItem[], ApiConnectionActionConfiguration> MusicsGet()
        {
            var apiCallPath = "/v1/music";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MusicsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<MusicPostResponse, ApiConnectionActionConfiguration> Music(Expression<Func<string>> bodyprompt, Expression<Func<bodymodeInput>> bodymode, Expression<Func<int>> bodyduration)
        {
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: true);
            var __workflow_bodymode = WorkflowExpression.Compile(bodymode, nameof(bodymode), required: true);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: true);
            return new DeferredBodyAction<MusicPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/music";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                bodypropCount++;
                body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                bodypropCount++;
                body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MusicPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<MusicGetResponse, ApiConnectionActionConfiguration> MusicGet(Expression<Func<string>> inferenceId)
        {
            var __workflow_inferenceId = WorkflowExpression.Compile(inferenceId, nameof(inferenceId), required: true);
            return new DeferredBodyAction<MusicGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/music/{0}", __workflow_inferenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MusicGetResponse>(callPayload);
            });
        }
    }

    public class LeapaiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ImagesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("negativePrompt")]
        public string NegativePrompt { get; set; }

        [JsonProperty("promptStrength")]
        public int PromptStrength { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("numberOfImages")]
        public int NumberOfImages { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }

        [JsonProperty("upscalingOption")]
        public string UpscalingOption { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("images")]
        public ImagesGetResponseItemImagesTypeItem[] Images { get; set; }
    }

    public class ImagesGetResponseItemImagesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum modelIdInput
    {
        [EnumMember(Value = "26a1a203-3a46-42cb-8cfa-f4de075907d8")]
        SDXL,
        [EnumMember(Value = "ee88d150-4259-4b77-9d0f-090abe29f650")]
        StableDiffusion21,
        [EnumMember(Value = "8b1b897c-d66d-45a6-b8d7-8e32421d02cf")]
        StableDiffusion15,
        [EnumMember(Value = "37d42ae9-5f5f-4399-b60b-014d35e762a5")]
        RealisticVisionV40,
        [EnumMember(Value = "eab32df0-de26-4b83-a908-a83f3015e971")]
        RealisticVisionV20,
        [EnumMember(Value = "1e7737d7-545e-469f-857f-e4b46eaa151d")]
        OpenJourneyV4,
        [EnumMember(Value = "d66b1686-5e5d-43b2-a2e7-d295d679917c")]
        OpenJourneyV2,
        [EnumMember(Value = "7575ea52-3d4f-400f-9ded-09f7b1b1a5b8")]
        OpenJourneyV1,
        [EnumMember(Value = "8ead1e66-5722-4ff6-a13f-b5212f575321")]
        ModernDisney,
        [EnumMember(Value = "1285ded4-b11b-4993-a491-d87cdfe6310c")]
        FutureDiffusion
    }

    public class ImagePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("negativePrompt")]
        public string NegativePrompt { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("promptStrength")]
        public int PromptStrength { get; set; }

        [JsonProperty("numberOfImages")]
        public int NumberOfImages { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }

        [JsonProperty("images")]
        public ImagePostResponseImagesTypeItem[] Images { get; set; }

        [JsonProperty("modelId")]
        public string[] ModelId { get; set; }

        [JsonProperty("upscalingOption")]
        public string UpscalingOption { get; set; }
    }

    public class ImagePostResponseImagesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ImageGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("negativePrompt")]
        public string NegativePrompt { get; set; }

        [JsonProperty("promptStrength")]
        public int PromptStrength { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("numberOfImages")]
        public int NumberOfImages { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }

        [JsonProperty("upscalingOption")]
        public string UpscalingOption { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("images")]
        public ImageGetResponseImagesTypeItem[] Images { get; set; }
    }

    public class ImageGetResponseImagesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class ModelPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subjectKeyword")]
        public string SubjectKeyword { get; set; }

        [JsonProperty("subjectType")]
        public string SubjectType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("imageSamples")]
        public string[] ImageSamples { get; set; }
    }

    public class ModelsGetResponse
    {
        [JsonProperty("models")]
        public ModelsGetResponseModelsTypeItem[] Models { get; set; }
    }

    public class ModelsGetResponseModelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subjectKeyword")]
        public string SubjectKeyword { get; set; }

        [JsonProperty("subjectType")]
        public string SubjectType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("imageSamples")]
        public string[] ImageSamples { get; set; }
    }

    public class ModelGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subjectKeyword")]
        public string SubjectKeyword { get; set; }

        [JsonProperty("subjectType")]
        public string SubjectType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("imageSamples")]
        public string[] ImageSamples { get; set; }
    }

    public class ModelDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subjectKeyword")]
        public string SubjectKeyword { get; set; }

        [JsonProperty("subjectType")]
        public string SubjectType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("imageSamples")]
        public string[] ImageSamples { get; set; }
    }

    public class MusicsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("media_uri")]
        public string MediaUri { get; set; }
    }

    public class MusicPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("media_uri")]
        public string MediaUri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymodeInput
    {
        [EnumMember(Value = "melody")]
        Melody,
        [EnumMember(Value = "music")]
        Music
    }

    public class MusicGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("media_uri")]
        public string MediaUri { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Leapaiip;

    public partial class WorkflowManagedActions
    {
        public LeapaiipActions Leapaiip(string connectionId) => new LeapaiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LeapaiipTriggers Leapaiip(string connectionId) => new LeapaiipTriggers(connectionId);
    }
}
