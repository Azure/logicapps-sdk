//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class StabilityaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<EnginesListGetResponseItem[]> EnginesListGet(Expression<Func<string>> organization = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: false);
            return new DeferredBodyAction<EnginesListGetResponseItem[]>(() =>
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
        public IBodyWorkflowAction<GenerationTextImagePostResponse> GenerationTextImage(Expression<Func<string>> engineId, Expression<Func<string>> organization = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodywidth = null, Expression<Func<bodytextPromptsInputItem[]>> bodytextPrompts = null, Expression<Func<int>> bodycfgScale = null, Expression<Func<string>> bodyclipGuidancePreset = null, Expression<Func<string>> bodysampler = null, Expression<Func<int>> bodysamples = null, Expression<Func<int>> bodyseed = null, Expression<Func<int>> bodysteps = null)
        {
            var __workflow_engineId = engineId == null ? null : WorkflowExpression.Compile(engineId);
            WorkflowExpression.Validate(__workflow_engineId, nameof(engineId), required: true);
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: false);
            var __workflow_bodyheight = bodyheight == null ? null : WorkflowExpression.Compile(bodyheight);
            WorkflowExpression.Validate(__workflow_bodyheight, nameof(bodyheight), required: false);
            var __workflow_bodywidth = bodywidth == null ? null : WorkflowExpression.Compile(bodywidth);
            WorkflowExpression.Validate(__workflow_bodywidth, nameof(bodywidth), required: false);
            var __workflow_bodytextPrompts = bodytextPrompts == null ? null : WorkflowExpression.Compile(bodytextPrompts);
            WorkflowExpression.Validate(__workflow_bodytextPrompts, nameof(bodytextPrompts), required: false);
            var __workflow_bodycfgScale = bodycfgScale == null ? null : WorkflowExpression.Compile(bodycfgScale);
            WorkflowExpression.Validate(__workflow_bodycfgScale, nameof(bodycfgScale), required: false);
            var __workflow_bodyclipGuidancePreset = bodyclipGuidancePreset == null ? null : WorkflowExpression.Compile(bodyclipGuidancePreset);
            WorkflowExpression.Validate(__workflow_bodyclipGuidancePreset, nameof(bodyclipGuidancePreset), required: false);
            var __workflow_bodysampler = bodysampler == null ? null : WorkflowExpression.Compile(bodysampler);
            WorkflowExpression.Validate(__workflow_bodysampler, nameof(bodysampler), required: false);
            var __workflow_bodysamples = bodysamples == null ? null : WorkflowExpression.Compile(bodysamples);
            WorkflowExpression.Validate(__workflow_bodysamples, nameof(bodysamples), required: false);
            var __workflow_bodyseed = bodyseed == null ? null : WorkflowExpression.Compile(bodyseed);
            WorkflowExpression.Validate(__workflow_bodyseed, nameof(bodyseed), required: false);
            var __workflow_bodysteps = bodysteps == null ? null : WorkflowExpression.Compile(bodysteps);
            WorkflowExpression.Validate(__workflow_bodysteps, nameof(bodysteps), required: false);
            return new DeferredBodyAction<GenerationTextImagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/text-to-image", ExpressionConverter.ConvertWithUrlEncoding(__workflow_engineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
                    bodypropCount++;
                }

                if (__workflow_bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                    bodypropCount++;
                }

                if (__workflow_bodytextPrompts != null)
                {
                    body["text_prompts"] = ExpressionConverter.ConvertO(__workflow_bodytextPrompts);
                    bodypropCount++;
                }

                if (__workflow_bodycfgScale != null)
                {
                    body["cfg_scale"] = ExpressionConverter.ConvertO(__workflow_bodycfgScale);
                    bodypropCount++;
                }

                if (__workflow_bodyclipGuidancePreset != null)
                {
                    body["clip_guidance_preset"] = ExpressionConverter.ConvertO(__workflow_bodyclipGuidancePreset);
                    bodypropCount++;
                }

                if (__workflow_bodysampler != null)
                {
                    body["sampler"] = ExpressionConverter.ConvertO(__workflow_bodysampler);
                    bodypropCount++;
                }

                if (__workflow_bodysamples != null)
                {
                    body["samples"] = ExpressionConverter.ConvertO(__workflow_bodysamples);
                    bodypropCount++;
                }

                if (__workflow_bodyseed != null)
                {
                    body["seed"] = ExpressionConverter.ConvertO(__workflow_bodyseed);
                    bodypropCount++;
                }

                if (__workflow_bodysteps != null)
                {
                    body["steps"] = ExpressionConverter.ConvertO(__workflow_bodysteps);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerationTextImagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationImageImagePostResponse> GenerationImageImage(Expression<Func<string>> engineId, Expression<Func<string>> bodyinitImage, Expression<Func<string>> organization = null, Expression<Func<bodytextPromptsInputItem[]>> bodytextPrompts = null, Expression<Func<bodyinitImageModeInput>> bodyinitImageMode = null, Expression<Func<double>> bodyimageStrength = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodycfgScale = null, Expression<Func<string>> bodyclipGuidancePreset = null, Expression<Func<string>> bodysampler = null, Expression<Func<int>> bodysamples = null, Expression<Func<int>> bodyseed = null, Expression<Func<int>> bodysteps = null)
        {
            var __workflow_engineId = engineId == null ? null : WorkflowExpression.Compile(engineId);
            WorkflowExpression.Validate(__workflow_engineId, nameof(engineId), required: true);
            var __workflow_bodyinitImage = bodyinitImage == null ? null : WorkflowExpression.Compile(bodyinitImage);
            WorkflowExpression.Validate(__workflow_bodyinitImage, nameof(bodyinitImage), required: true);
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: false);
            var __workflow_bodytextPrompts = bodytextPrompts == null ? null : WorkflowExpression.Compile(bodytextPrompts);
            WorkflowExpression.Validate(__workflow_bodytextPrompts, nameof(bodytextPrompts), required: false);
            var __workflow_bodyinitImageMode = bodyinitImageMode == null ? null : WorkflowExpression.Compile(bodyinitImageMode);
            WorkflowExpression.Validate(__workflow_bodyinitImageMode, nameof(bodyinitImageMode), required: false);
            var __workflow_bodyimageStrength = bodyimageStrength == null ? null : WorkflowExpression.Compile(bodyimageStrength);
            WorkflowExpression.Validate(__workflow_bodyimageStrength, nameof(bodyimageStrength), required: false);
            var __workflow_bodyheight = bodyheight == null ? null : WorkflowExpression.Compile(bodyheight);
            WorkflowExpression.Validate(__workflow_bodyheight, nameof(bodyheight), required: false);
            var __workflow_bodywidth = bodywidth == null ? null : WorkflowExpression.Compile(bodywidth);
            WorkflowExpression.Validate(__workflow_bodywidth, nameof(bodywidth), required: false);
            var __workflow_bodycfgScale = bodycfgScale == null ? null : WorkflowExpression.Compile(bodycfgScale);
            WorkflowExpression.Validate(__workflow_bodycfgScale, nameof(bodycfgScale), required: false);
            var __workflow_bodyclipGuidancePreset = bodyclipGuidancePreset == null ? null : WorkflowExpression.Compile(bodyclipGuidancePreset);
            WorkflowExpression.Validate(__workflow_bodyclipGuidancePreset, nameof(bodyclipGuidancePreset), required: false);
            var __workflow_bodysampler = bodysampler == null ? null : WorkflowExpression.Compile(bodysampler);
            WorkflowExpression.Validate(__workflow_bodysampler, nameof(bodysampler), required: false);
            var __workflow_bodysamples = bodysamples == null ? null : WorkflowExpression.Compile(bodysamples);
            WorkflowExpression.Validate(__workflow_bodysamples, nameof(bodysamples), required: false);
            var __workflow_bodyseed = bodyseed == null ? null : WorkflowExpression.Compile(bodyseed);
            WorkflowExpression.Validate(__workflow_bodyseed, nameof(bodyseed), required: false);
            var __workflow_bodysteps = bodysteps == null ? null : WorkflowExpression.Compile(bodysteps);
            WorkflowExpression.Validate(__workflow_bodysteps, nameof(bodysteps), required: false);
            return new DeferredBodyAction<GenerationImageImagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image", ExpressionConverter.ConvertWithUrlEncoding(__workflow_engineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytextPrompts != null)
                {
                    body["text_prompts"] = ExpressionConverter.ConvertO(__workflow_bodytextPrompts);
                    bodypropCount++;
                }

                bodypropCount++;
                body["init_image"] = ExpressionConverter.ConvertO(__workflow_bodyinitImage);
                if (__workflow_bodyinitImageMode != null)
                {
                    body["init_image_mode"] = ExpressionConverter.ConvertO(__workflow_bodyinitImageMode);
                    bodypropCount++;
                }

                if (__workflow_bodyimageStrength != null)
                {
                    body["image_strength"] = ExpressionConverter.ConvertO(__workflow_bodyimageStrength);
                    bodypropCount++;
                }

                if (__workflow_bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
                    bodypropCount++;
                }

                if (__workflow_bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                    bodypropCount++;
                }

                if (__workflow_bodycfgScale != null)
                {
                    body["cfg_scale"] = ExpressionConverter.ConvertO(__workflow_bodycfgScale);
                    bodypropCount++;
                }

                if (__workflow_bodyclipGuidancePreset != null)
                {
                    body["clip_guidance_preset"] = ExpressionConverter.ConvertO(__workflow_bodyclipGuidancePreset);
                    bodypropCount++;
                }

                if (__workflow_bodysampler != null)
                {
                    body["sampler"] = ExpressionConverter.ConvertO(__workflow_bodysampler);
                    bodypropCount++;
                }

                if (__workflow_bodysamples != null)
                {
                    body["samples"] = ExpressionConverter.ConvertO(__workflow_bodysamples);
                    bodypropCount++;
                }

                if (__workflow_bodyseed != null)
                {
                    body["seed"] = ExpressionConverter.ConvertO(__workflow_bodyseed);
                    bodypropCount++;
                }

                if (__workflow_bodysteps != null)
                {
                    body["steps"] = ExpressionConverter.ConvertO(__workflow_bodysteps);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerationImageImagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationUpscalePostResponse> GenerationUpscale(Expression<Func<string>> engineId, Expression<Func<string>> bodyimage, Expression<Func<string>> organization = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodywidth = null)
        {
            var __workflow_engineId = engineId == null ? null : WorkflowExpression.Compile(engineId);
            WorkflowExpression.Validate(__workflow_engineId, nameof(engineId), required: true);
            var __workflow_bodyimage = bodyimage == null ? null : WorkflowExpression.Compile(bodyimage);
            WorkflowExpression.Validate(__workflow_bodyimage, nameof(bodyimage), required: true);
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: false);
            var __workflow_bodyheight = bodyheight == null ? null : WorkflowExpression.Compile(bodyheight);
            WorkflowExpression.Validate(__workflow_bodyheight, nameof(bodyheight), required: false);
            var __workflow_bodywidth = bodywidth == null ? null : WorkflowExpression.Compile(bodywidth);
            WorkflowExpression.Validate(__workflow_bodywidth, nameof(bodywidth), required: false);
            return new DeferredBodyAction<GenerationUpscalePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image/upscale", ExpressionConverter.ConvertWithUrlEncoding(__workflow_engineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                if (__workflow_bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
                    bodypropCount++;
                }

                if (__workflow_bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerationUpscalePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<GenerationMaskPostResponse> GenerationMask(Expression<Func<string>> engineId, Expression<Func<string>> bodyinitImage, Expression<Func<bodymaskSourceInput>> bodymaskSource, Expression<Func<string>> bodymaskImage, Expression<Func<string>> organization = null, Expression<Func<bodytextPromptsInputItem[]>> bodytextPrompts = null, Expression<Func<int>> bodyheight = null, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodycfgScale = null, Expression<Func<string>> bodyclipGuidancePreset = null, Expression<Func<string>> bodysampler = null, Expression<Func<int>> bodysamples = null, Expression<Func<int>> bodyseed = null, Expression<Func<int>> bodysteps = null)
        {
            var __workflow_engineId = engineId == null ? null : WorkflowExpression.Compile(engineId);
            WorkflowExpression.Validate(__workflow_engineId, nameof(engineId), required: true);
            var __workflow_bodyinitImage = bodyinitImage == null ? null : WorkflowExpression.Compile(bodyinitImage);
            WorkflowExpression.Validate(__workflow_bodyinitImage, nameof(bodyinitImage), required: true);
            var __workflow_bodymaskSource = bodymaskSource == null ? null : WorkflowExpression.Compile(bodymaskSource);
            WorkflowExpression.Validate(__workflow_bodymaskSource, nameof(bodymaskSource), required: true);
            var __workflow_bodymaskImage = bodymaskImage == null ? null : WorkflowExpression.Compile(bodymaskImage);
            WorkflowExpression.Validate(__workflow_bodymaskImage, nameof(bodymaskImage), required: true);
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: false);
            var __workflow_bodytextPrompts = bodytextPrompts == null ? null : WorkflowExpression.Compile(bodytextPrompts);
            WorkflowExpression.Validate(__workflow_bodytextPrompts, nameof(bodytextPrompts), required: false);
            var __workflow_bodyheight = bodyheight == null ? null : WorkflowExpression.Compile(bodyheight);
            WorkflowExpression.Validate(__workflow_bodyheight, nameof(bodyheight), required: false);
            var __workflow_bodywidth = bodywidth == null ? null : WorkflowExpression.Compile(bodywidth);
            WorkflowExpression.Validate(__workflow_bodywidth, nameof(bodywidth), required: false);
            var __workflow_bodycfgScale = bodycfgScale == null ? null : WorkflowExpression.Compile(bodycfgScale);
            WorkflowExpression.Validate(__workflow_bodycfgScale, nameof(bodycfgScale), required: false);
            var __workflow_bodyclipGuidancePreset = bodyclipGuidancePreset == null ? null : WorkflowExpression.Compile(bodyclipGuidancePreset);
            WorkflowExpression.Validate(__workflow_bodyclipGuidancePreset, nameof(bodyclipGuidancePreset), required: false);
            var __workflow_bodysampler = bodysampler == null ? null : WorkflowExpression.Compile(bodysampler);
            WorkflowExpression.Validate(__workflow_bodysampler, nameof(bodysampler), required: false);
            var __workflow_bodysamples = bodysamples == null ? null : WorkflowExpression.Compile(bodysamples);
            WorkflowExpression.Validate(__workflow_bodysamples, nameof(bodysamples), required: false);
            var __workflow_bodyseed = bodyseed == null ? null : WorkflowExpression.Compile(bodyseed);
            WorkflowExpression.Validate(__workflow_bodyseed, nameof(bodyseed), required: false);
            var __workflow_bodysteps = bodysteps == null ? null : WorkflowExpression.Compile(bodysteps);
            WorkflowExpression.Validate(__workflow_bodysteps, nameof(bodysteps), required: false);
            return new DeferredBodyAction<GenerationMaskPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image/masking", ExpressionConverter.ConvertWithUrlEncoding(__workflow_engineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytextPrompts != null)
                {
                    body["text_prompts"] = ExpressionConverter.ConvertO(__workflow_bodytextPrompts);
                    bodypropCount++;
                }

                bodypropCount++;
                body["init_image"] = ExpressionConverter.ConvertO(__workflow_bodyinitImage);
                bodypropCount++;
                body["mask_source"] = ExpressionConverter.ConvertO(__workflow_bodymaskSource);
                bodypropCount++;
                body["mask_image"] = ExpressionConverter.ConvertO(__workflow_bodymaskImage);
                if (__workflow_bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
                    bodypropCount++;
                }

                if (__workflow_bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                    bodypropCount++;
                }

                if (__workflow_bodycfgScale != null)
                {
                    body["cfg_scale"] = ExpressionConverter.ConvertO(__workflow_bodycfgScale);
                    bodypropCount++;
                }

                if (__workflow_bodyclipGuidancePreset != null)
                {
                    body["clip_guidance_preset"] = ExpressionConverter.ConvertO(__workflow_bodyclipGuidancePreset);
                    bodypropCount++;
                }

                if (__workflow_bodysampler != null)
                {
                    body["sampler"] = ExpressionConverter.ConvertO(__workflow_bodysampler);
                    bodypropCount++;
                }

                if (__workflow_bodysamples != null)
                {
                    body["samples"] = ExpressionConverter.ConvertO(__workflow_bodysamples);
                    bodypropCount++;
                }

                if (__workflow_bodyseed != null)
                {
                    body["seed"] = ExpressionConverter.ConvertO(__workflow_bodyseed);
                    bodypropCount++;
                }

                if (__workflow_bodysteps != null)
                {
                    body["steps"] = ExpressionConverter.ConvertO(__workflow_bodysteps);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerationMaskPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableImageCorePostResponse> StableImageCore(Expression<Func<string>> bodyprompt, Expression<Func<bodyaspectRatioInput>> bodyaspectRatio = null, Expression<Func<string>> bodynegativePrompt = null, Expression<Func<int>> bodyseed = null, Expression<Func<bodystylePresetInput>> bodystylePreset = null)
        {
            var __workflow_bodyprompt = bodyprompt == null ? null : WorkflowExpression.Compile(bodyprompt);
            WorkflowExpression.Validate(__workflow_bodyprompt, nameof(bodyprompt), required: true);
            var __workflow_bodyaspectRatio = bodyaspectRatio == null ? null : WorkflowExpression.Compile(bodyaspectRatio);
            WorkflowExpression.Validate(__workflow_bodyaspectRatio, nameof(bodyaspectRatio), required: false);
            var __workflow_bodynegativePrompt = bodynegativePrompt == null ? null : WorkflowExpression.Compile(bodynegativePrompt);
            WorkflowExpression.Validate(__workflow_bodynegativePrompt, nameof(bodynegativePrompt), required: false);
            var __workflow_bodyseed = bodyseed == null ? null : WorkflowExpression.Compile(bodyseed);
            WorkflowExpression.Validate(__workflow_bodyseed, nameof(bodyseed), required: false);
            var __workflow_bodystylePreset = bodystylePreset == null ? null : WorkflowExpression.Compile(bodystylePreset);
            WorkflowExpression.Validate(__workflow_bodystylePreset, nameof(bodystylePreset), required: false);
            return new DeferredBodyAction<StableImageCorePostResponse>(() =>
            {
                var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/core";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                if (__workflow_bodyaspectRatio != null)
                {
                    if (__workflow_bodyaspectRatio != null)
                    {
                        body["aspect_ratio"] = ExpressionConverter.ConvertO(__workflow_bodyaspectRatio);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["aspect_ratio"] = "1:1";
                    bodypropCount++;
                }

                if (__workflow_bodynegativePrompt != null)
                {
                    body["negative_prompt"] = ExpressionConverter.ConvertO(__workflow_bodynegativePrompt);
                    bodypropCount++;
                }

                if (__workflow_bodyseed != null)
                {
                    body["seed"] = ExpressionConverter.ConvertO(__workflow_bodyseed);
                    bodypropCount++;
                }

                if (__workflow_bodystylePreset != null)
                {
                    body["style_preset"] = ExpressionConverter.ConvertO(__workflow_bodystylePreset);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StableImageCorePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        public IBodyWorkflowAction<StableDiffusionPostResponse> StableDiffusion(Expression<Func<string>> bodyprompt, Expression<Func<bodyaspectRatioInput>> bodyaspectRatio = null, Expression<Func<string>> bodynegativePrompt = null, Expression<Func<bodymodelInput>> bodymodel = null, Expression<Func<int>> bodyseed = null, Expression<Func<bodystylePresetInput>> bodystylePreset = null)
        {
            var __workflow_bodyprompt = bodyprompt == null ? null : WorkflowExpression.Compile(bodyprompt);
            WorkflowExpression.Validate(__workflow_bodyprompt, nameof(bodyprompt), required: true);
            var __workflow_bodyaspectRatio = bodyaspectRatio == null ? null : WorkflowExpression.Compile(bodyaspectRatio);
            WorkflowExpression.Validate(__workflow_bodyaspectRatio, nameof(bodyaspectRatio), required: false);
            var __workflow_bodynegativePrompt = bodynegativePrompt == null ? null : WorkflowExpression.Compile(bodynegativePrompt);
            WorkflowExpression.Validate(__workflow_bodynegativePrompt, nameof(bodynegativePrompt), required: false);
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: false);
            var __workflow_bodyseed = bodyseed == null ? null : WorkflowExpression.Compile(bodyseed);
            WorkflowExpression.Validate(__workflow_bodyseed, nameof(bodyseed), required: false);
            var __workflow_bodystylePreset = bodystylePreset == null ? null : WorkflowExpression.Compile(bodystylePreset);
            WorkflowExpression.Validate(__workflow_bodystylePreset, nameof(bodystylePreset), required: false);
            return new DeferredBodyAction<StableDiffusionPostResponse>(() =>
            {
                var apiCallPath = "/api.stability.ai/v2beta/stable-image/generate/sd3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                if (__workflow_bodyaspectRatio != null)
                {
                    if (__workflow_bodyaspectRatio != null)
                    {
                        body["aspect_ratio"] = ExpressionConverter.ConvertO(__workflow_bodyaspectRatio);
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
                if (__workflow_bodynegativePrompt != null)
                {
                    body["negative_prompt"] = ExpressionConverter.ConvertO(__workflow_bodynegativePrompt);
                    bodypropCount++;
                }

                if (__workflow_bodymodel != null)
                {
                    if (__workflow_bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "sd3";
                    bodypropCount++;
                }

                if (__workflow_bodyseed != null)
                {
                    body["seed"] = ExpressionConverter.ConvertO(__workflow_bodyseed);
                    bodypropCount++;
                }

                if (__workflow_bodystylePreset != null)
                {
                    body["style_preset"] = ExpressionConverter.ConvertO(__workflow_bodystylePreset);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
