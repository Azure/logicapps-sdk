//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StabilityaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<EnginesListGetResponseItem[]> EnginesListGet([WorkflowExpression] Func<string> organization = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/engines/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (organization != null)
                    callPayload.Headers["Organization"] = SourceExpressionConverter.ConvertO(organization);
                return callPayload;
            }

            return new ApiConnectionAction<EnginesListGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<UserAccountGetResponse> UserAccountGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/user/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserAccountGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<UserBalanceGetResponse> UserBalanceGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/user/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserBalanceGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationTextImagePostResponse> GenerationTextImage([WorkflowExpression] Func<string> engineId, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<bodytextPromptsInputItem[]> bodytextPrompts = null, [WorkflowExpression] Func<int> bodycfgScale = null, [WorkflowExpression] Func<string> bodyclipGuidancePreset = null, [WorkflowExpression] Func<string> bodysampler = null, [WorkflowExpression] Func<int> bodysamples = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<int> bodysteps = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/text-to-image", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(engineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (organization != null)
                    callPayload.Headers["Organization"] = SourceExpressionConverter.ConvertO(organization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                    bodypropCount++;
                }

                if (bodywidth != null)
                {
                    body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                    bodypropCount++;
                }

                if (bodytextPrompts != null)
                {
                    body["text_prompts"] = SourceExpressionConverter.ConvertToken(bodytextPrompts);
                    bodypropCount++;
                }

                if (bodycfgScale != null)
                {
                    body["cfg_scale"] = SourceExpressionConverter.ConvertToken(bodycfgScale);
                    bodypropCount++;
                }

                if (bodyclipGuidancePreset != null)
                {
                    body["clip_guidance_preset"] = SourceExpressionConverter.ConvertToken(bodyclipGuidancePreset);
                    bodypropCount++;
                }

                if (bodysampler != null)
                {
                    body["sampler"] = SourceExpressionConverter.ConvertToken(bodysampler);
                    bodypropCount++;
                }

                if (bodysamples != null)
                {
                    body["samples"] = SourceExpressionConverter.ConvertToken(bodysamples);
                    bodypropCount++;
                }

                if (bodyseed != null)
                {
                    body["seed"] = SourceExpressionConverter.ConvertToken(bodyseed);
                    bodypropCount++;
                }

                if (bodysteps != null)
                {
                    body["steps"] = SourceExpressionConverter.ConvertToken(bodysteps);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerationTextImagePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationImageImagePostResponse> GenerationImageImage([WorkflowExpression] Func<string> engineId, [WorkflowExpression] Func<string> bodyinitImage, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<bodytextPromptsInputItem[]> bodytextPrompts = null, [WorkflowExpression] Func<bodyinitImageModeInput> bodyinitImageMode = null, [WorkflowExpression] Func<double> bodyimageStrength = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodycfgScale = null, [WorkflowExpression] Func<string> bodyclipGuidancePreset = null, [WorkflowExpression] Func<string> bodysampler = null, [WorkflowExpression] Func<int> bodysamples = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<int> bodysteps = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(engineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (organization != null)
                    callPayload.Headers["Organization"] = SourceExpressionConverter.ConvertO(organization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytextPrompts != null)
                {
                    body["text_prompts"] = SourceExpressionConverter.ConvertToken(bodytextPrompts);
                    bodypropCount++;
                }

                bodypropCount++;
                body["init_image"] = SourceExpressionConverter.ConvertToken(bodyinitImage);
                if (bodyinitImageMode != null)
                {
                    body["init_image_mode"] = SourceExpressionConverter.Convert(bodyinitImageMode);
                    bodypropCount++;
                }

                if (bodyimageStrength != null)
                {
                    body["image_strength"] = SourceExpressionConverter.ConvertToken(bodyimageStrength);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                    bodypropCount++;
                }

                if (bodywidth != null)
                {
                    body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                    bodypropCount++;
                }

                if (bodycfgScale != null)
                {
                    body["cfg_scale"] = SourceExpressionConverter.ConvertToken(bodycfgScale);
                    bodypropCount++;
                }

                if (bodyclipGuidancePreset != null)
                {
                    body["clip_guidance_preset"] = SourceExpressionConverter.ConvertToken(bodyclipGuidancePreset);
                    bodypropCount++;
                }

                if (bodysampler != null)
                {
                    body["sampler"] = SourceExpressionConverter.ConvertToken(bodysampler);
                    bodypropCount++;
                }

                if (bodysamples != null)
                {
                    body["samples"] = SourceExpressionConverter.ConvertToken(bodysamples);
                    bodypropCount++;
                }

                if (bodyseed != null)
                {
                    body["seed"] = SourceExpressionConverter.ConvertToken(bodyseed);
                    bodypropCount++;
                }

                if (bodysteps != null)
                {
                    body["steps"] = SourceExpressionConverter.ConvertToken(bodysteps);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerationImageImagePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationUpscalePostResponse> GenerationUpscale([WorkflowExpression] Func<string> engineId, [WorkflowExpression] Func<string> bodyimage, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodywidth = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image/upscale", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(engineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (organization != null)
                    callPayload.Headers["Organization"] = SourceExpressionConverter.ConvertO(organization);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["image"] = SourceExpressionConverter.ConvertToken(bodyimage);
                if (bodyheight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                    bodypropCount++;
                }

                if (bodywidth != null)
                {
                    body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerationUpscalePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationMaskPostResponse> GenerationMask([WorkflowExpression] Func<string> engineId, [WorkflowExpression] Func<string> bodyinitImage, [WorkflowExpression] Func<bodymaskSourceInput> bodymaskSource, [WorkflowExpression] Func<string> bodymaskImage, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<bodytextPromptsInputItem[]> bodytextPrompts = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodycfgScale = null, [WorkflowExpression] Func<string> bodyclipGuidancePreset = null, [WorkflowExpression] Func<string> bodysampler = null, [WorkflowExpression] Func<int> bodysamples = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<int> bodysteps = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image/masking", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(engineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (organization != null)
                    callPayload.Headers["Organization"] = SourceExpressionConverter.ConvertO(organization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytextPrompts != null)
                {
                    body["text_prompts"] = SourceExpressionConverter.ConvertToken(bodytextPrompts);
                    bodypropCount++;
                }

                bodypropCount++;
                body["init_image"] = SourceExpressionConverter.ConvertToken(bodyinitImage);
                bodypropCount++;
                body["mask_source"] = SourceExpressionConverter.Convert(bodymaskSource);
                bodypropCount++;
                body["mask_image"] = SourceExpressionConverter.ConvertToken(bodymaskImage);
                if (bodyheight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                    bodypropCount++;
                }

                if (bodywidth != null)
                {
                    body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                    bodypropCount++;
                }

                if (bodycfgScale != null)
                {
                    body["cfg_scale"] = SourceExpressionConverter.ConvertToken(bodycfgScale);
                    bodypropCount++;
                }

                if (bodyclipGuidancePreset != null)
                {
                    body["clip_guidance_preset"] = SourceExpressionConverter.ConvertToken(bodyclipGuidancePreset);
                    bodypropCount++;
                }

                if (bodysampler != null)
                {
                    body["sampler"] = SourceExpressionConverter.ConvertToken(bodysampler);
                    bodypropCount++;
                }

                if (bodysamples != null)
                {
                    body["samples"] = SourceExpressionConverter.ConvertToken(bodysamples);
                    bodypropCount++;
                }

                if (bodyseed != null)
                {
                    body["seed"] = SourceExpressionConverter.ConvertToken(bodyseed);
                    bodypropCount++;
                }

                if (bodysteps != null)
                {
                    body["steps"] = SourceExpressionConverter.ConvertToken(bodysteps);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerationMaskPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableImageCorePostResponse> StableImageCore([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<bodyaspectRatioInput> bodyaspectRatio = null, [WorkflowExpression] Func<string> bodynegativePrompt = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<bodystylePresetInput> bodystylePreset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/core";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                if (bodyaspectRatio != null)
                {
                    if (bodyaspectRatio != null)
                    {
                        body["aspect_ratio"] = SourceExpressionConverter.Convert(bodyaspectRatio);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["aspect_ratio"] = "1:1";
                    bodypropCount++;
                }

                if (bodynegativePrompt != null)
                {
                    body["negative_prompt"] = SourceExpressionConverter.ConvertToken(bodynegativePrompt);
                    bodypropCount++;
                }

                if (bodyseed != null)
                {
                    body["seed"] = SourceExpressionConverter.ConvertToken(bodyseed);
                    bodypropCount++;
                }

                if (bodystylePreset != null)
                {
                    body["style_preset"] = SourceExpressionConverter.Convert(bodystylePreset);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StableImageCorePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableDiffusionPostResponse> StableDiffusion([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<bodyaspectRatioInput> bodyaspectRatio = null, [WorkflowExpression] Func<string> bodynegativePrompt = null, [WorkflowExpression] Func<bodymodelInput> bodymodel = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<bodystylePresetInput> bodystylePreset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/sd3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                if (bodyaspectRatio != null)
                {
                    if (bodyaspectRatio != null)
                    {
                        body["aspect_ratio"] = SourceExpressionConverter.Convert(bodyaspectRatio);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["aspect_ratio"] = "1:1";
                    bodypropCount++;
                }

                body["mode"] = "text-to-image";
                bodypropCount++;
                if (bodynegativePrompt != null)
                {
                    body["negative_prompt"] = SourceExpressionConverter.ConvertToken(bodynegativePrompt);
                    bodypropCount++;
                }

                if (bodymodel != null)
                {
                    if (bodymodel != null)
                    {
                        body["model"] = SourceExpressionConverter.Convert(bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "sd3";
                    bodypropCount++;
                }

                if (bodyseed != null)
                {
                    body["seed"] = SourceExpressionConverter.ConvertToken(bodyseed);
                    bodypropCount++;
                }

                if (bodystylePreset != null)
                {
                    body["style_preset"] = SourceExpressionConverter.Convert(bodystylePreset);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StableDiffusionPostResponse>(BuildSourceInput);
        }
    }

    public class StabilityaiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EnginesListGetResponseItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserAccountGetResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizations")]
        public UserAccountGetResponseOrganizationsTypeItem[] Organizations { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }
    }

    public class UserAccountGetResponseOrganizationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
    }

    public class UserBalanceGetResponse
    {
        [JsonProperty("credits")]
        public double Credits { get; set; }
    }

    public class GenerationTextImagePostResponse
    {
        [JsonProperty("artifacts")]
        public GenerationTextImagePostResponseArtifactsTypeItem[] Artifacts { get; set; }
    }

    public class GenerationTextImagePostResponseArtifactsTypeItem
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }
    }

    public class bodytextPromptsInputItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class GenerationImageImagePostResponse
    {
        [JsonProperty("artifacts")]
        public GenerationImageImagePostResponseArtifactsTypeItem[] Artifacts { get; set; }
    }

    public class GenerationImageImagePostResponseArtifactsTypeItem
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }
    }

    public enum bodyinitImageModeInput
    {
        [EnumMember(Value = "image_strength")]
        ImageStrength,
        [EnumMember(Value = "step_schedule")]
        StepSchedule
    }

    public class GenerationUpscalePostResponse
    {
        [JsonProperty("artifacts")]
        public GenerationUpscalePostResponseArtifactsTypeItem[] Artifacts { get; set; }
    }

    public class GenerationUpscalePostResponseArtifactsTypeItem
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }
    }

    public class GenerationMaskPostResponse
    {
        [JsonProperty("artifacts")]
        public GenerationMaskPostResponseArtifactsTypeItem[] Artifacts { get; set; }
    }

    public class GenerationMaskPostResponseArtifactsTypeItem
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }
    }

    public enum bodymaskSourceInput
    {
        [EnumMember(Value = "MASK_IMAGE_WHITE")]
        MASKIMAGEWHITE,
        [EnumMember(Value = "MASK_IMAGE_BLACK")]
        MASKIMAGEBLACK,
        [EnumMember(Value = "INIT_IMAGE_ALPHA")]
        INITIMAGEALPHA
    }

    public class StableImageCorePostResponse
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }
    }

    public enum bodyaspectRatioInput
    {
        [EnumMember(Value = "1:1")]
        _11,
        [EnumMember(Value = "16:9")]
        _169,
        [EnumMember(Value = "21:9")]
        _219,
        [EnumMember(Value = "2:3")]
        _23,
        [EnumMember(Value = "3:2")]
        _32,
        [EnumMember(Value = "4:5")]
        _45,
        [EnumMember(Value = "5:4")]
        _54,
        [EnumMember(Value = "9:16")]
        _916,
        [EnumMember(Value = "9:21")]
        _921
    }

    public enum bodystylePresetInput
    {
        [EnumMember(Value = "3d-model")]
        _3dModel,
        [EnumMember(Value = "analog-film")]
        AnalogFilm,
        [EnumMember(Value = "anime")]
        Anime,
        [EnumMember(Value = "cinematic")]
        Cinematic,
        [EnumMember(Value = "comic-book")]
        ComicBook,
        [EnumMember(Value = "digital-art")]
        DigitalArt,
        [EnumMember(Value = "enhance")]
        Enhance,
        [EnumMember(Value = "fantasy-art")]
        FantasyArt,
        [EnumMember(Value = "isometric")]
        Isometric,
        [EnumMember(Value = "line-art")]
        LineArt,
        [EnumMember(Value = "low-poly")]
        LowPoly,
        [EnumMember(Value = "modeling-compound")]
        ModelingCompound,
        [EnumMember(Value = "neon-punk")]
        NeonPunk,
        [EnumMember(Value = "origami")]
        Origami,
        [EnumMember(Value = "photographic")]
        Photographic,
        [EnumMember(Value = "pixel-art")]
        PixelArt,
        [EnumMember(Value = "tile-texture")]
        TileTexture
    }

    public class StableDiffusionPostResponse
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }
    }

    public enum bodymodelInput
    {
        [EnumMember(Value = "sd3")]
        Sd3,
        [EnumMember(Value = "sd3-turbo")]
        Sd3Turbo
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip;

    public partial class WorkflowManagedActions
    {
        public StabilityaiipActions Stabilityaiip(string connectionId) => new StabilityaiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StabilityaiipTriggers Stabilityaiip(string connectionId) => new StabilityaiipTriggers(connectionId);
    }
}