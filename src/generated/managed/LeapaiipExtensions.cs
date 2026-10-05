//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leapaiip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeapaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        [WorkflowExpressionFactory(nameof(__BuildImagesGet))]
        public IBodyWorkflowAction<ImagesGetResponseItem[]> ImagesGet([WorkflowExpression] Func<modelIdInput> modelId, [WorkflowExpression] Func<bool> onlyFinished = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImagesGetResponseItem[]> __BuildImagesGet(WorkflowValue<modelIdInput> modelId, WorkflowValue<bool> onlyFinished = null, WorkflowValue<int> page = null, WorkflowValue<int> pageSize = null)
        {
            WorkflowValue.Validate(modelId, nameof(modelId), required: true);
            WorkflowValue.Validate(onlyFinished, nameof(onlyFinished), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<ImagesGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/images/models/{0}/inferences", ExpressionConverter.ConvertWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (onlyFinished != null)
                    callPayload.Queries["onlyFinished"] = ExpressionConverter.Convert(onlyFinished);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<ImagesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        [WorkflowExpressionFactory(nameof(__BuildImage))]
        public IBodyWorkflowAction<ImagePostResponse> Image([WorkflowExpression] Func<modelIdInput> modelId, [WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<string> bodynegativePrompt = null, [WorkflowExpression] Func<int> bodysteps = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodynumberOfImages = null, [WorkflowExpression] Func<int> bodypromptStrength = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<string> bodywebhookUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImagePostResponse> __BuildImage(WorkflowValue<modelIdInput> modelId, WorkflowValue<string> bodyprompt, WorkflowValue<string> bodynegativePrompt = null, WorkflowValue<int> bodysteps = null, WorkflowValue<int> bodywidth = null, WorkflowValue<int> bodyheight = null, WorkflowValue<int> bodynumberOfImages = null, WorkflowValue<int> bodypromptStrength = null, WorkflowValue<int> bodyseed = null, WorkflowValue<string> bodywebhookUrl = null)
        {
            WorkflowValue.Validate(modelId, nameof(modelId), required: true);
            WorkflowValue.Validate(bodyprompt, nameof(bodyprompt), required: true);
            WorkflowValue.Validate(bodynegativePrompt, nameof(bodynegativePrompt), required: false);
            WorkflowValue.Validate(bodysteps, nameof(bodysteps), required: false);
            WorkflowValue.Validate(bodywidth, nameof(bodywidth), required: false);
            WorkflowValue.Validate(bodyheight, nameof(bodyheight), required: false);
            WorkflowValue.Validate(bodynumberOfImages, nameof(bodynumberOfImages), required: false);
            WorkflowValue.Validate(bodypromptStrength, nameof(bodypromptStrength), required: false);
            WorkflowValue.Validate(bodyseed, nameof(bodyseed), required: false);
            WorkflowValue.Validate(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            return new DeferredBodyAction<ImagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/images/models/{0}/inferences", ExpressionConverter.ConvertWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                if (bodynegativePrompt != null)
                {
                    body["negativePrompt"] = ExpressionConverter.ConvertO(bodynegativePrompt);
                    bodypropCount++;
                }

                if (bodysteps != null)
                {
                    body["steps"] = ExpressionConverter.ConvertO(bodysteps);
                    bodypropCount++;
                }

                if (bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(bodyheight);
                    bodypropCount++;
                }

                if (bodynumberOfImages != null)
                {
                    body["numberOfImages"] = ExpressionConverter.ConvertO(bodynumberOfImages);
                    bodypropCount++;
                }

                if (bodypromptStrength != null)
                {
                    body["promptStrength"] = ExpressionConverter.ConvertO(bodypromptStrength);
                    bodypropCount++;
                }

                if (bodyseed != null)
                {
                    body["seed"] = ExpressionConverter.ConvertO(bodyseed);
                    bodypropCount++;
                }

                if (bodywebhookUrl != null)
                {
                    body["webhookUrl"] = ExpressionConverter.ConvertO(bodywebhookUrl);
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
        [WorkflowExpressionFactory(nameof(__BuildImageGet))]
        public IBodyWorkflowAction<ImageGetResponse> ImageGet([WorkflowExpression] Func<modelIdInput> modelId, [WorkflowExpression] Func<string> inferenceId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageGetResponse> __BuildImageGet(WorkflowValue<modelIdInput> modelId, WorkflowValue<string> inferenceId)
        {
            WorkflowValue.Validate(modelId, nameof(modelId), required: true);
            WorkflowValue.Validate(inferenceId, nameof(inferenceId), required: true);
            return new DeferredBodyAction<ImageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/images/models/{0}/inferences/{1}", ExpressionConverter.ConvertWithUrlEncoding(modelId, 1), ExpressionConverter.ConvertWithUrlEncoding(inferenceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        [WorkflowExpressionFactory(nameof(__BuildImageDelete))]
        public IBodyWorkflowAction<string> ImageDelete([WorkflowExpression] Func<modelIdInput> modelId, [WorkflowExpression] Func<string> inferenceId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildImageDelete(WorkflowValue<modelIdInput> modelId, WorkflowValue<string> inferenceId)
        {
            WorkflowValue.Validate(modelId, nameof(modelId), required: true);
            WorkflowValue.Validate(inferenceId, nameof(inferenceId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/images/models/{0}/inferences/{1}", ExpressionConverter.ConvertWithUrlEncoding(modelId, 1), ExpressionConverter.ConvertWithUrlEncoding(inferenceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        [WorkflowExpressionFactory(nameof(__BuildModel))]
        public IBodyWorkflowAction<ModelPostResponse> Model([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodysubjectKeyword = null, [WorkflowExpression] Func<string> bodysubjectType = null, [WorkflowExpression] Func<string> bodywebhookUrl = null, [WorkflowExpression] Func<string[]> bodyimageSampleUrls = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelPostResponse> __BuildModel(WorkflowValue<string> bodyname = null, WorkflowValue<string> bodysubjectKeyword = null, WorkflowValue<string> bodysubjectType = null, WorkflowValue<string> bodywebhookUrl = null, WorkflowValue<string[]> bodyimageSampleUrls = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodysubjectKeyword, nameof(bodysubjectKeyword), required: false);
            WorkflowValue.Validate(bodysubjectType, nameof(bodysubjectType), required: false);
            WorkflowValue.Validate(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            WorkflowValue.Validate(bodyimageSampleUrls, nameof(bodyimageSampleUrls), required: false);
            return new DeferredBodyAction<ModelPostResponse>(() =>
            {
                var apiCallPath = "/v2/images/models/new";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodysubjectKeyword != null)
                {
                    body["subjectKeyword"] = ExpressionConverter.ConvertO(bodysubjectKeyword);
                    bodypropCount++;
                }

                if (bodysubjectType != null)
                {
                    body["subjectType"] = ExpressionConverter.ConvertO(bodysubjectType);
                    bodypropCount++;
                }

                if (bodywebhookUrl != null)
                {
                    body["webhookUrl"] = ExpressionConverter.ConvertO(bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodyimageSampleUrls != null)
                {
                    body["imageSampleUrls"] = ExpressionConverter.ConvertO(bodyimageSampleUrls);
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
        public IBodyWorkflowAction<ModelsGetResponse> ModelsGet()
        {
            var apiCallPath = "/v2/images/models";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ModelsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        [WorkflowExpressionFactory(nameof(__BuildModelGet))]
        public IBodyWorkflowAction<ModelGetResponse> ModelGet([WorkflowExpression] Func<modelIdInput> modelId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelGetResponse> __BuildModelGet(WorkflowValue<modelIdInput> modelId)
        {
            WorkflowValue.Validate(modelId, nameof(modelId), required: true);
            return new DeferredBodyAction<ModelGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/images/models/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        [WorkflowExpressionFactory(nameof(__BuildModelDelete))]
        public IBodyWorkflowAction<ModelDeleteResponse> ModelDelete([WorkflowExpression] Func<modelIdInput> modelId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelDeleteResponse> __BuildModelDelete(WorkflowValue<modelIdInput> modelId)
        {
            WorkflowValue.Validate(modelId, nameof(modelId), required: true);
            return new DeferredBodyAction<ModelDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/images/models/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<MusicsGetResponseItem[]> MusicsGet()
        {
            var apiCallPath = "/v1/music";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MusicsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        [WorkflowExpressionFactory(nameof(__BuildMusic))]
        public IBodyWorkflowAction<MusicPostResponse> Music([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<bodymodeInput> bodymode, [WorkflowExpression] Func<int> bodyduration)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MusicPostResponse> __BuildMusic(WorkflowValue<string> bodyprompt, WorkflowValue<bodymodeInput> bodymode, WorkflowValue<int> bodyduration)
        {
            WorkflowValue.Validate(bodyprompt, nameof(bodyprompt), required: true);
            WorkflowValue.Validate(bodymode, nameof(bodymode), required: true);
            WorkflowValue.Validate(bodyduration, nameof(bodyduration), required: true);
            return new DeferredBodyAction<MusicPostResponse>(() =>
            {
                var apiCallPath = "/v1/music";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                bodypropCount++;
                body["mode"] = ExpressionConverter.ConvertO(bodymode);
                bodypropCount++;
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MusicPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        [WorkflowExpressionFactory(nameof(__BuildMusicGet))]
        public IBodyWorkflowAction<MusicGetResponse> MusicGet([WorkflowExpression] Func<string> inferenceId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MusicGetResponse> __BuildMusicGet(WorkflowValue<string> inferenceId)
        {
            WorkflowValue.Validate(inferenceId, nameof(inferenceId), required: true);
            return new DeferredBodyAction<MusicGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/music/{0}", ExpressionConverter.ConvertWithUrlEncoding(inferenceId, 1));
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
