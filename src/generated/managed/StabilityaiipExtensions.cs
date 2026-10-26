//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StabilityaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<EnginesListGetResponseItem[], ApiConnectionActionConfiguration> EnginesListGet(Expression<Func<string>> organization = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            return new DeferredBodyAction<EnginesListGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/engines/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction<EnginesListGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<UserAccountGetResponse, ApiConnectionActionConfiguration> UserAccountGet()
        {
            return new DeferredBodyAction<UserAccountGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserAccountGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<UserBalanceGetResponse, ApiConnectionActionConfiguration> UserBalanceGet()
        {
            return new DeferredBodyAction<UserBalanceGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserBalanceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationTextImagePostResponse, ApiConnectionActionConfiguration> GenerationTextImage(Expression<Func<string>> engineId, Expression<Func<string>> organization = null, Expression<Func<GenerationTextImagePostInput>> body = null)
        {
            var __workflow_engineId = WorkflowExpression.Compile(engineId, nameof(engineId), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GenerationTextImagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/generation/{0}/text-to-image", __workflow_engineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerationTextImagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationImageImagePostResponse, ApiConnectionActionConfiguration> GenerationImageImage(Expression<Func<string>> engineId, Expression<Func<string>> organization = null, Expression<Func<GenerationImageImagePostInput>> body = null)
        {
            var __workflow_engineId = WorkflowExpression.Compile(engineId, nameof(engineId), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GenerationImageImagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/generation/{0}/image-to-image", __workflow_engineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerationImageImagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationUpscalePostResponse, ApiConnectionActionConfiguration> GenerationUpscale(Expression<Func<string>> engineId, Expression<Func<string>> organization = null, Expression<Func<GenerationUpscalePostInput>> body = null)
        {
            var __workflow_engineId = WorkflowExpression.Compile(engineId, nameof(engineId), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GenerationUpscalePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/generation/{0}/image-to-image/upscale", __workflow_engineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerationUpscalePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationMaskPostResponse, ApiConnectionActionConfiguration> GenerationMask(Expression<Func<string>> engineId, Expression<Func<string>> organization = null, Expression<Func<GenerationMaskPostInput>> body = null)
        {
            var __workflow_engineId = WorkflowExpression.Compile(engineId, nameof(engineId), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GenerationMaskPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/generation/{0}/image-to-image/masking", __workflow_engineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerationMaskPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableImageCorePostResponse, ApiConnectionActionConfiguration> StableImageCore(Expression<Func<StableImageCorePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StableImageCorePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/core";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StableImageCorePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableDiffusionPostResponse, ApiConnectionActionConfiguration> StableDiffusion(Expression<Func<StableDiffusionPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StableDiffusionPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/sd3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StableDiffusionPostResponse>(callPayload);
            });
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

    public class GenerationTextImagePostInput
    {
        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("text_prompts")]
        public GenerationTextImagePostInputTextPromptsTypeItem[] TextPrompts { get; set; }

        [JsonProperty("cfg_scale")]
        public int? CfgScale { get; set; }

        [JsonProperty("clip_guidance_preset")]
        public string ClipGuidancePreset { get; set; }

        [JsonProperty("sampler")]
        public string Sampler { get; set; }

        [JsonProperty("samples")]
        public int? Samples { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }

        [JsonProperty("steps")]
        public int? Steps { get; set; }
    }

    public class GenerationTextImagePostInputTextPromptsTypeItem
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }
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

    public class GenerationImageImagePostInput
    {
        [JsonProperty("text_prompts")]
        public GenerationImageImagePostInputTextPromptsTypeItem[] TextPrompts { get; set; }

        [JsonProperty("init_image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InitImage { get; set; }

        [JsonProperty("init_image_mode")]
        public GenerationImageImagePostInputInitImageModeType? InitImageMode { get; set; }

        [JsonProperty("image_strength")]
        public double? ImageStrength { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("cfg_scale")]
        public int? CfgScale { get; set; }

        [JsonProperty("clip_guidance_preset")]
        public string ClipGuidancePreset { get; set; }

        [JsonProperty("sampler")]
        public string Sampler { get; set; }

        [JsonProperty("samples")]
        public int? Samples { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }

        [JsonProperty("steps")]
        public int? Steps { get; set; }
    }

    public class GenerationImageImagePostInputTextPromptsTypeItem
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerationImageImagePostInputInitImageModeType
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

    public class GenerationUpscalePostInput
    {
        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Image { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
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

    public class GenerationMaskPostInput
    {
        [JsonProperty("text_prompts")]
        public GenerationMaskPostInputTextPromptsTypeItem[] TextPrompts { get; set; }

        [JsonProperty("init_image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InitImage { get; set; }

        [JsonProperty("mask_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerationMaskPostInputMaskSourceType MaskSource { get; set; } = GenerationMaskPostInputMaskSourceType.MASKIMAGEWHITE;

        [JsonProperty("mask_image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MaskImage { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("cfg_scale")]
        public int? CfgScale { get; set; }

        [JsonProperty("clip_guidance_preset")]
        public string ClipGuidancePreset { get; set; }

        [JsonProperty("sampler")]
        public string Sampler { get; set; }

        [JsonProperty("samples")]
        public int? Samples { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }

        [JsonProperty("steps")]
        public int? Steps { get; set; }
    }

    public class GenerationMaskPostInputTextPromptsTypeItem
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerationMaskPostInputMaskSourceType
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

    public class StableImageCorePostInput
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("aspect_ratio", DefaultValueHandling = DefaultValueHandling.Include)]
        public StableImageCorePostInputAspectRatioType? AspectRatio { get; set; } = StableImageCorePostInputAspectRatioType._11;

        [JsonProperty("negative_prompt")]
        public string NegativePrompt { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }

        [JsonProperty("style_preset")]
        public StableImageCorePostInputStylePresetType? StylePreset { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StableImageCorePostInputAspectRatioType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StableImageCorePostInputStylePresetType
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

    public class StableDiffusionPostInput
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("aspect_ratio", DefaultValueHandling = DefaultValueHandling.Include)]
        public StableDiffusionPostInputAspectRatioType? AspectRatio { get; set; } = StableDiffusionPostInputAspectRatioType._11;

        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "text-to-image";

        [JsonProperty("negative_prompt")]
        public string NegativePrompt { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public StableDiffusionPostInputModelType? Model { get; set; } = StableDiffusionPostInputModelType.Sd3;

        [JsonProperty("seed")]
        public int? Seed { get; set; }

        [JsonProperty("style_preset")]
        public StableDiffusionPostInputStylePresetType? StylePreset { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StableDiffusionPostInputAspectRatioType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StableDiffusionPostInputModelType
    {
        [EnumMember(Value = "sd3")]
        Sd3,
        [EnumMember(Value = "sd3-turbo")]
        Sd3Turbo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StableDiffusionPostInputStylePresetType
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