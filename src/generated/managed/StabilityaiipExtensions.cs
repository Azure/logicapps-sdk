//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Stabilityaiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StabilityaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<EnginesListGetResponseItem[]> EnginesListGet(Expression<Func<string>> organization = null)
        {
            var apiCallPath = "/v1/engines/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (organization != null)
                callPayload.Headers["Organization"] = ExpressionConverter.Convert(organization);
            return new ApiConnectionAction<EnginesListGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<UserAccountGetResponse> UserAccountGet()
        {
            var apiCallPath = "/v1/user/account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserAccountGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<UserBalanceGetResponse> UserBalanceGet()
        {
            var apiCallPath = "/v1/user/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserBalanceGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationTextImagePostResponse> GenerationTextImagePost(Expression<Func<string>> engineId, Expression<Func<string>> organization = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodywidth = null, Expression<Func<bodytextPromptsInputItem[]>> bodytextPrompts = null, Expression<Func<int>> bodycfgScale = null, Expression<Func<string>> bodyclipGuidancePreset = null, Expression<Func<string>> bodysampler = null, Expression<Func<int>> bodysamples = null, Expression<Func<int>> bodyseed = null, Expression<Func<int>> bodysteps = null)
        {
            var apiCallPath = String.Format("/v1/generation/{0}/text-to-image", ExpressionConverter.ConvertWithUrlEncoding(engineId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            if (organization != null)
                callPayload.Headers["Organization"] = ExpressionConverter.Convert(organization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyheight != null)
            {
                body["height"] = ExpressionConverter.ConvertO(bodyheight);
                bodypropCount++;
            }

            if (bodywidth != null)
            {
                body["width"] = ExpressionConverter.ConvertO(bodywidth);
                bodypropCount++;
            }

            if (bodytextPrompts != null)
            {
                body["text_prompts"] = ExpressionConverter.ConvertO(bodytextPrompts);
                bodypropCount++;
            }

            if (bodycfgScale != null)
            {
                body["cfg_scale"] = ExpressionConverter.ConvertO(bodycfgScale);
                bodypropCount++;
            }

            if (bodyclipGuidancePreset != null)
            {
                body["clip_guidance_preset"] = ExpressionConverter.ConvertO(bodyclipGuidancePreset);
                bodypropCount++;
            }

            if (bodysampler != null)
            {
                body["sampler"] = ExpressionConverter.ConvertO(bodysampler);
                bodypropCount++;
            }

            if (bodysamples != null)
            {
                body["samples"] = ExpressionConverter.ConvertO(bodysamples);
                bodypropCount++;
            }

            if (bodyseed != null)
            {
                body["seed"] = ExpressionConverter.ConvertO(bodyseed);
                bodypropCount++;
            }

            if (bodysteps != null)
            {
                body["steps"] = ExpressionConverter.ConvertO(bodysteps);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GenerationTextImagePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationImageImagePostResponse> GenerationImageImagePost(Expression<Func<string>> engineId, Expression<Func<string>> bodyinitImage, Expression<Func<string>> organization = null, Expression<Func<bodytextPromptsInputItem[]>> bodytextPrompts = null, Expression<Func<bodyinitImageModeInput>> bodyinitImageMode = null, Expression<Func<double>> bodyimageStrength = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodycfgScale = null, Expression<Func<string>> bodyclipGuidancePreset = null, Expression<Func<string>> bodysampler = null, Expression<Func<int>> bodysamples = null, Expression<Func<int>> bodyseed = null, Expression<Func<int>> bodysteps = null)
        {
            var apiCallPath = String.Format("/v1/generation/{0}/image-to-image", ExpressionConverter.ConvertWithUrlEncoding(engineId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            if (organization != null)
                callPayload.Headers["Organization"] = ExpressionConverter.Convert(organization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytextPrompts != null)
            {
                body["text_prompts"] = ExpressionConverter.ConvertO(bodytextPrompts);
                bodypropCount++;
            }

            bodypropCount++;
            body["init_image"] = ExpressionConverter.ConvertO(bodyinitImage);
            if (bodyinitImageMode != null)
            {
                body["init_image_mode"] = ExpressionConverter.ConvertO(bodyinitImageMode);
                bodypropCount++;
            }

            if (bodyimageStrength != null)
            {
                body["image_strength"] = ExpressionConverter.ConvertO(bodyimageStrength);
                bodypropCount++;
            }

            if (bodyheight != null)
            {
                body["height"] = ExpressionConverter.ConvertO(bodyheight);
                bodypropCount++;
            }

            if (bodywidth != null)
            {
                body["width"] = ExpressionConverter.ConvertO(bodywidth);
                bodypropCount++;
            }

            if (bodycfgScale != null)
            {
                body["cfg_scale"] = ExpressionConverter.ConvertO(bodycfgScale);
                bodypropCount++;
            }

            if (bodyclipGuidancePreset != null)
            {
                body["clip_guidance_preset"] = ExpressionConverter.ConvertO(bodyclipGuidancePreset);
                bodypropCount++;
            }

            if (bodysampler != null)
            {
                body["sampler"] = ExpressionConverter.ConvertO(bodysampler);
                bodypropCount++;
            }

            if (bodysamples != null)
            {
                body["samples"] = ExpressionConverter.ConvertO(bodysamples);
                bodypropCount++;
            }

            if (bodyseed != null)
            {
                body["seed"] = ExpressionConverter.ConvertO(bodyseed);
                bodypropCount++;
            }

            if (bodysteps != null)
            {
                body["steps"] = ExpressionConverter.ConvertO(bodysteps);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GenerationImageImagePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationUpscalePostResponse> GenerationUpscalePost(Expression<Func<string>> engineId, Expression<Func<string>> bodyimage, Expression<Func<string>> organization = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodywidth = null)
        {
            var apiCallPath = String.Format("/v1/generation/{0}/image-to-image/upscale", ExpressionConverter.ConvertWithUrlEncoding(engineId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            if (organization != null)
                callPayload.Headers["Organization"] = ExpressionConverter.Convert(organization);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["image"] = ExpressionConverter.ConvertO(bodyimage);
            if (bodyheight != null)
            {
                body["height"] = ExpressionConverter.ConvertO(bodyheight);
                bodypropCount++;
            }

            if (bodywidth != null)
            {
                body["width"] = ExpressionConverter.ConvertO(bodywidth);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GenerationUpscalePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationMaskPostResponse> GenerationMaskPost(Expression<Func<string>> engineId, Expression<Func<string>> bodyinitImage, Expression<Func<bodymaskSourceInput>> bodymaskSource, Expression<Func<string>> bodymaskImage, Expression<Func<string>> organization = null, Expression<Func<bodytextPromptsInputItem[]>> bodytextPrompts = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodycfgScale = null, Expression<Func<string>> bodyclipGuidancePreset = null, Expression<Func<string>> bodysampler = null, Expression<Func<int>> bodysamples = null, Expression<Func<int>> bodyseed = null, Expression<Func<int>> bodysteps = null)
        {
            var apiCallPath = String.Format("/v1/generation/{0}/image-to-image/masking", ExpressionConverter.ConvertWithUrlEncoding(engineId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            if (organization != null)
                callPayload.Headers["Organization"] = ExpressionConverter.Convert(organization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytextPrompts != null)
            {
                body["text_prompts"] = ExpressionConverter.ConvertO(bodytextPrompts);
                bodypropCount++;
            }

            bodypropCount++;
            body["init_image"] = ExpressionConverter.ConvertO(bodyinitImage);
            bodypropCount++;
            body["mask_source"] = ExpressionConverter.ConvertO(bodymaskSource);
            bodypropCount++;
            body["mask_image"] = ExpressionConverter.ConvertO(bodymaskImage);
            if (bodyheight != null)
            {
                body["height"] = ExpressionConverter.ConvertO(bodyheight);
                bodypropCount++;
            }

            if (bodywidth != null)
            {
                body["width"] = ExpressionConverter.ConvertO(bodywidth);
                bodypropCount++;
            }

            if (bodycfgScale != null)
            {
                body["cfg_scale"] = ExpressionConverter.ConvertO(bodycfgScale);
                bodypropCount++;
            }

            if (bodyclipGuidancePreset != null)
            {
                body["clip_guidance_preset"] = ExpressionConverter.ConvertO(bodyclipGuidancePreset);
                bodypropCount++;
            }

            if (bodysampler != null)
            {
                body["sampler"] = ExpressionConverter.ConvertO(bodysampler);
                bodypropCount++;
            }

            if (bodysamples != null)
            {
                body["samples"] = ExpressionConverter.ConvertO(bodysamples);
                bodypropCount++;
            }

            if (bodyseed != null)
            {
                body["seed"] = ExpressionConverter.ConvertO(bodyseed);
                bodypropCount++;
            }

            if (bodysteps != null)
            {
                body["steps"] = ExpressionConverter.ConvertO(bodysteps);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GenerationMaskPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableImageCorePostResponse> StableImageCorePost(Expression<Func<string>> bodyprompt, Expression<Func<bodyaspectRatioInput>> bodyaspectRatio = null, Expression<Func<string>> bodynegativePrompt = null, Expression<Func<int>> bodyseed = null, Expression<Func<bodystylePresetInput>> bodystylePreset = null)
        {
            var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/core";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
            if (bodyaspectRatio != null)
            {
                body["aspect_ratio"] = ExpressionConverter.ConvertO(bodyaspectRatio);
                bodypropCount++;
            }

            if (bodynegativePrompt != null)
            {
                body["negative_prompt"] = ExpressionConverter.ConvertO(bodynegativePrompt);
                bodypropCount++;
            }

            if (bodyseed != null)
            {
                body["seed"] = ExpressionConverter.ConvertO(bodyseed);
                bodypropCount++;
            }

            if (bodystylePreset != null)
            {
                body["style_preset"] = ExpressionConverter.ConvertO(bodystylePreset);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StableImageCorePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableDiffusionPostResponse> StableDiffusionPost(Expression<Func<string>> bodyprompt, Expression<Func<bodyaspectRatioInput>> bodyaspectRatio = null, Expression<Func<string>> bodynegativePrompt = null, Expression<Func<bodymodelInput>> bodymodel = null, Expression<Func<int>> bodyseed = null, Expression<Func<bodystylePresetInput>> bodystylePreset = null)
        {
            var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/sd3";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
            if (bodyaspectRatio != null)
            {
                body["aspect_ratio"] = ExpressionConverter.ConvertO(bodyaspectRatio);
                bodypropCount++;
            }

            body["mode"] = "text-to-image";
            bodypropCount++;
            if (bodynegativePrompt != null)
            {
                body["negative_prompt"] = ExpressionConverter.ConvertO(bodynegativePrompt);
                bodypropCount++;
            }

            if (bodymodel != null)
            {
                body["model"] = ExpressionConverter.ConvertO(bodymodel);
                bodypropCount++;
            }

            if (bodyseed != null)
            {
                body["seed"] = ExpressionConverter.ConvertO(bodyseed);
                bodypropCount++;
            }

            if (bodystylePreset != null)
            {
                body["style_preset"] = ExpressionConverter.ConvertO(bodystylePreset);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StableDiffusionPostResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Stabilityaiip;

    public partial class WorkflowManagedActions
    {
        public StabilityaiipActions Stabilityaiip(string connectionId) => new StabilityaiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StabilityaiipTriggers Stabilityaiip(string connectionId) => new StabilityaiipTriggers(connectionId);
    }
}