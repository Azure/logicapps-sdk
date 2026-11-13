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
        public IBodyWorkflowAction<GenerationTextImageResponse, ApiConnectionActionConfiguration> GenerationTextImage(Expression<Func<string>> engineId, Expression<Func<string>> organization = null, Expression<Func<GenerationTextImageBodyInput>> body = null)
        {
            var __workflow_engineId = WorkflowExpression.Compile(engineId, nameof(engineId), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GenerationTextImageResponse, ApiConnectionActionConfiguration>(() =>
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
                return new ApiConnectionAction<GenerationTextImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationImageImageResponse, ApiConnectionActionConfiguration> GenerationImageImage(Expression<Func<string>> engineId, Expression<Func<GenerationImageImageBodyInput>> body, Expression<Func<string>> organization = null)
        {
            var __workflow_engineId = WorkflowExpression.Compile(engineId, nameof(engineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            return new DeferredBodyAction<GenerationImageImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/generation/{0}/image-to-image", __workflow_engineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerationImageImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationUpscaleResponse, ApiConnectionActionConfiguration> GenerationUpscale(Expression<Func<string>> engineId, Expression<Func<GenerationUpscaleBodyInput>> body, Expression<Func<string>> organization = null)
        {
            var __workflow_engineId = WorkflowExpression.Compile(engineId, nameof(engineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            return new DeferredBodyAction<GenerationUpscaleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/generation/{0}/image-to-image/upscale", __workflow_engineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerationUpscaleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationMaskResponse, ApiConnectionActionConfiguration> GenerationMask(Expression<Func<string>> engineId, Expression<Func<GenerationMaskBodyInput>> body, Expression<Func<string>> organization = null)
        {
            var __workflow_engineId = WorkflowExpression.Compile(engineId, nameof(engineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            return new DeferredBodyAction<GenerationMaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/generation/{0}/image-to-image/masking", __workflow_engineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerationMaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableImageCoreResponse, ApiConnectionActionConfiguration> StableImageCore(Expression<Func<StableImageCoreBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StableImageCoreResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/core";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StableImageCoreResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableDiffusionResponse, ApiConnectionActionConfiguration> StableDiffusion(Expression<Func<StableDiffusionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StableDiffusionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/sd3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StableDiffusionResponse>(callPayload);
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

    public class GenerationTextImageResponse
    {
        [JsonProperty("artifacts")]
        public GenerationTextImageResponseArtifactsTypeItem[] Artifacts { get; set; }
    }

    public class GenerationTextImageResponseArtifactsTypeItem
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }
    }

    public class GenerationTextImageBodyInput
    {
        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("text_prompts")]
        public BodyInputTextPromptsTypeItem[] TextPrompts { get; set; }

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

    public class BodyInputTextPromptsTypeItem
    {
        public BodyInputTextPromptsTypeItem(string text)
        {
            this.Text = text;
        }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }
    }

    public class GenerationImageImageResponse
    {
        [JsonProperty("artifacts")]
        public GenerationImageImageResponseArtifactsTypeItem[] Artifacts { get; set; }
    }

    public class GenerationImageImageResponseArtifactsTypeItem
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }
    }

    public class GenerationImageImageBodyInput
    {
        public GenerationImageImageBodyInput(string initImage)
        {
            this.InitImage = initImage;
        }

        [JsonProperty("text_prompts")]
        public BodyInputTextPromptsTypeItem[] TextPrompts { get; set; }

        [JsonProperty("init_image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InitImage { get; set; }

        [JsonProperty("init_image_mode")]
        public BodyInputInitImageModeType? InitImageMode { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputInitImageModeType
    {
        [EnumMember(Value = "image_strength")]
        ImageStrength,
        [EnumMember(Value = "step_schedule")]
        StepSchedule
    }

    public class GenerationUpscaleResponse
    {
        [JsonProperty("artifacts")]
        public GenerationUpscaleResponseArtifactsTypeItem[] Artifacts { get; set; }
    }

    public class GenerationUpscaleResponseArtifactsTypeItem
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }
    }

    public class GenerationUpscaleBodyInput
    {
        public GenerationUpscaleBodyInput(string image)
        {
            this.Image = image;
        }

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Image { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }

    public class GenerationMaskResponse
    {
        [JsonProperty("artifacts")]
        public GenerationMaskResponseArtifactsTypeItem[] Artifacts { get; set; }
    }

    public class GenerationMaskResponseArtifactsTypeItem
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }
    }

    public class GenerationMaskBodyInput
    {
        public GenerationMaskBodyInput(string initImage, string maskImage)
        {
            this.InitImage = initImage;
            this.MaskImage = maskImage;
        }

        [JsonProperty("text_prompts")]
        public BodyInputTextPromptsTypeItem[] TextPrompts { get; set; }

        [JsonProperty("init_image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InitImage { get; set; }

        [JsonProperty("mask_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputMaskSourceType MaskSource { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip.BodyInputMaskSourceType.MaskImageWhite;

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputMaskSourceType
    {
        [EnumMember(Value = "MASK_IMAGE_WHITE")]
        MaskImageWhite,
        [EnumMember(Value = "MASK_IMAGE_BLACK")]
        MaskImageBlack,
        [EnumMember(Value = "INIT_IMAGE_ALPHA")]
        InitImageAlpha
    }

    public class StableImageCoreResponse
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }
    }

    public class StableImageCoreBodyInput
    {
        public StableImageCoreBodyInput(string prompt)
        {
            this.Prompt = prompt;
        }

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("aspect_ratio", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAspectRatioType? AspectRatio { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip.BodyInputAspectRatioType._11;

        [JsonProperty("negative_prompt")]
        public string NegativePrompt { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }

        [JsonProperty("style_preset")]
        public BodyInputStylePresetType? StylePreset { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAspectRatioType
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
    public enum BodyInputStylePresetType
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

    public class StableDiffusionResponse
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }
    }

    public class StableDiffusionBodyInput
    {
        public StableDiffusionBodyInput(string prompt)
        {
            this.Prompt = prompt;
        }

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("aspect_ratio", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAspectRatioType? AspectRatio { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip.BodyInputAspectRatioType._11;

        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "text-to-image";

        [JsonProperty("negative_prompt")]
        public string NegativePrompt { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputModelType? Model { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip.BodyInputModelType.Sd3;

        [JsonProperty("seed")]
        public int? Seed { get; set; }

        [JsonProperty("style_preset")]
        public BodyInputStylePresetType? StylePreset { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputModelType
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