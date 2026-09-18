//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leapaiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeapaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ImagesGetResponseItem[]> ImagesGet([WorkflowExpression] Func<modelIdInput> modelId, [WorkflowExpression] Func<bool> onlyFinished = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(modelId, nameof(modelId), required: true);
            SourceExpression.Validate(onlyFinished, nameof(onlyFinished), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/images/models/{0}/inferences", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (onlyFinished != null)
                    callPayload.Queries["onlyFinished"] = SourceExpressionConverter.ConvertO(onlyFinished);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<ImagesGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ImagePostResponse> Image([WorkflowExpression] Func<modelIdInput> modelId, [WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<string> bodynegativePrompt = null, [WorkflowExpression] Func<int> bodysteps = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodynumberOfImages = null, [WorkflowExpression] Func<int> bodypromptStrength = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<string> bodywebhookUrl = null)
        {
            SourceExpression.Validate(modelId, nameof(modelId), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: true);
            SourceExpression.Validate(bodynegativePrompt, nameof(bodynegativePrompt), required: false);
            SourceExpression.Validate(bodysteps, nameof(bodysteps), required: false);
            SourceExpression.Validate(bodywidth, nameof(bodywidth), required: false);
            SourceExpression.Validate(bodyheight, nameof(bodyheight), required: false);
            SourceExpression.Validate(bodynumberOfImages, nameof(bodynumberOfImages), required: false);
            SourceExpression.Validate(bodypromptStrength, nameof(bodypromptStrength), required: false);
            SourceExpression.Validate(bodyseed, nameof(bodyseed), required: false);
            SourceExpression.Validate(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/images/models/{0}/inferences", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                if (bodynegativePrompt != null)
                {
                    body["negativePrompt"] = SourceExpressionConverter.ConvertToken(bodynegativePrompt);
                    bodypropCount++;
                }

                if (bodysteps != null)
                {
                    body["steps"] = SourceExpressionConverter.ConvertToken(bodysteps);
                    bodypropCount++;
                }

                if (bodywidth != null)
                {
                    body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                    bodypropCount++;
                }

                if (bodynumberOfImages != null)
                {
                    body["numberOfImages"] = SourceExpressionConverter.ConvertToken(bodynumberOfImages);
                    bodypropCount++;
                }

                if (bodypromptStrength != null)
                {
                    body["promptStrength"] = SourceExpressionConverter.ConvertToken(bodypromptStrength);
                    bodypropCount++;
                }

                if (bodyseed != null)
                {
                    body["seed"] = SourceExpressionConverter.ConvertToken(bodyseed);
                    bodypropCount++;
                }

                if (bodywebhookUrl != null)
                {
                    body["webhookUrl"] = SourceExpressionConverter.ConvertToken(bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImagePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ImageGetResponse> ImageGet([WorkflowExpression] Func<modelIdInput> modelId, [WorkflowExpression] Func<string> inferenceId)
        {
            SourceExpression.Validate(modelId, nameof(modelId), required: true);
            SourceExpression.Validate(inferenceId, nameof(inferenceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/images/models/{0}/inferences/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inferenceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ImageGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<string> ImageDelete([WorkflowExpression] Func<modelIdInput> modelId, [WorkflowExpression] Func<string> inferenceId)
        {
            SourceExpression.Validate(modelId, nameof(modelId), required: true);
            SourceExpression.Validate(inferenceId, nameof(inferenceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/images/models/{0}/inferences/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inferenceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ModelPostResponse> Model([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodysubjectKeyword = null, [WorkflowExpression] Func<string> bodysubjectType = null, [WorkflowExpression] Func<string> bodywebhookUrl = null, [WorkflowExpression] Func<string[]> bodyimageSampleUrls = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodysubjectKeyword, nameof(bodysubjectKeyword), required: false);
            SourceExpression.Validate(bodysubjectType, nameof(bodysubjectType), required: false);
            SourceExpression.Validate(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            SourceExpression.Validate(bodyimageSampleUrls, nameof(bodyimageSampleUrls), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/images/models/new";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodysubjectKeyword != null)
                {
                    body["subjectKeyword"] = SourceExpressionConverter.ConvertToken(bodysubjectKeyword);
                    bodypropCount++;
                }

                if (bodysubjectType != null)
                {
                    body["subjectType"] = SourceExpressionConverter.ConvertToken(bodysubjectType);
                    bodypropCount++;
                }

                if (bodywebhookUrl != null)
                {
                    body["webhookUrl"] = SourceExpressionConverter.ConvertToken(bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodyimageSampleUrls != null)
                {
                    body["imageSampleUrls"] = SourceExpressionConverter.ConvertToken(bodyimageSampleUrls);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModelPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ModelsGetResponse> ModelsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/images/models";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ModelGetResponse> ModelGet([WorkflowExpression] Func<modelIdInput> modelId)
        {
            SourceExpression.Validate(modelId, nameof(modelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/images/models/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<ModelDeleteResponse> ModelDelete([WorkflowExpression] Func<modelIdInput> modelId)
        {
            SourceExpression.Validate(modelId, nameof(modelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/images/models/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<MusicsGetResponseItem[]> MusicsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/music";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MusicsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<MusicPostResponse> Music([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<bodymodeInput> bodymode, [WorkflowExpression] Func<int> bodyduration)
        {
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: true);
            SourceExpression.Validate(bodymode, nameof(bodymode), required: true);
            SourceExpression.Validate(bodyduration, nameof(bodyduration), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/music";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                bodypropCount++;
                body["mode"] = SourceExpressionConverter.Convert(bodymode);
                bodypropCount++;
                body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MusicPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leapaiip")]
        public IBodyWorkflowAction<MusicGetResponse> MusicGet([WorkflowExpression] Func<string> inferenceId)
        {
            SourceExpression.Validate(inferenceId, nameof(inferenceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/music/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inferenceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MusicGetResponse>(BuildSourceInput);
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