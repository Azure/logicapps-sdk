//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stabilityaiip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StabilityaiipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [WorkflowExpressionFactory(nameof(__BuildEnginesListGet))]
        public IBodyWorkflowAction<EnginesListGetResponseItem[]> EnginesListGet([WorkflowExpression] Func<string> organization = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnginesListGetResponseItem[]> __BuildEnginesListGet(WorkflowExpression<string> organization = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: false);
            return new DeferredBodyAction<EnginesListGetResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/engines/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (organization != null)
                    callPayload.Headers["Organization"] = ExpressionConverter.Convert(organization);
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
        [WorkflowExpressionFactory(nameof(__BuildGenerationTextImage))]
        public IBodyWorkflowAction<GenerationTextImagePostResponse> GenerationTextImage([WorkflowExpression] Func<string> engineId, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<bodytextPromptsInputItem[]> bodytextPrompts = null, [WorkflowExpression] Func<int> bodycfgScale = null, [WorkflowExpression] Func<string> bodyclipGuidancePreset = null, [WorkflowExpression] Func<string> bodysampler = null, [WorkflowExpression] Func<int> bodysamples = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<int> bodysteps = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerationTextImagePostResponse> __BuildGenerationTextImage(WorkflowExpression<string> engineId, WorkflowExpression<string> organization = null, WorkflowExpression<int> bodyheight = null, WorkflowExpression<int> bodywidth = null, WorkflowExpression<bodytextPromptsInputItem[]> bodytextPrompts = null, WorkflowExpression<int> bodycfgScale = null, WorkflowExpression<string> bodyclipGuidancePreset = null, WorkflowExpression<string> bodysampler = null, WorkflowExpression<int> bodysamples = null, WorkflowExpression<int> bodyseed = null, WorkflowExpression<int> bodysteps = null)
        {
            WorkflowExpression.Validate(engineId, nameof(engineId), required: true);
            WorkflowExpression.Validate(organization, nameof(organization), required: false);
            WorkflowExpression.Validate(bodyheight, nameof(bodyheight), required: false);
            WorkflowExpression.Validate(bodywidth, nameof(bodywidth), required: false);
            WorkflowExpression.Validate(bodytextPrompts, nameof(bodytextPrompts), required: false);
            WorkflowExpression.Validate(bodycfgScale, nameof(bodycfgScale), required: false);
            WorkflowExpression.Validate(bodyclipGuidancePreset, nameof(bodyclipGuidancePreset), required: false);
            WorkflowExpression.Validate(bodysampler, nameof(bodysampler), required: false);
            WorkflowExpression.Validate(bodysamples, nameof(bodysamples), required: false);
            WorkflowExpression.Validate(bodyseed, nameof(bodyseed), required: false);
            WorkflowExpression.Validate(bodysteps, nameof(bodysteps), required: false);
            return new DeferredBodyAction<GenerationTextImagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/text-to-image", ExpressionConverter.ConvertWithUrlEncoding(engineId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [WorkflowExpressionFactory(nameof(__BuildGenerationImageImage))]
        public IBodyWorkflowAction<GenerationImageImagePostResponse> GenerationImageImage([WorkflowExpression] Func<string> engineId, [WorkflowExpression] Func<string> bodyinitImage, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<bodytextPromptsInputItem[]> bodytextPrompts = null, [WorkflowExpression] Func<bodyinitImageModeInput> bodyinitImageMode = null, [WorkflowExpression] Func<double> bodyimageStrength = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodycfgScale = null, [WorkflowExpression] Func<string> bodyclipGuidancePreset = null, [WorkflowExpression] Func<string> bodysampler = null, [WorkflowExpression] Func<int> bodysamples = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<int> bodysteps = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerationImageImagePostResponse> __BuildGenerationImageImage(WorkflowExpression<string> engineId, WorkflowExpression<string> bodyinitImage, WorkflowExpression<string> organization = null, WorkflowExpression<bodytextPromptsInputItem[]> bodytextPrompts = null, WorkflowExpression<bodyinitImageModeInput> bodyinitImageMode = null, WorkflowExpression<double> bodyimageStrength = null, WorkflowExpression<int> bodyheight = null, WorkflowExpression<int> bodywidth = null, WorkflowExpression<int> bodycfgScale = null, WorkflowExpression<string> bodyclipGuidancePreset = null, WorkflowExpression<string> bodysampler = null, WorkflowExpression<int> bodysamples = null, WorkflowExpression<int> bodyseed = null, WorkflowExpression<int> bodysteps = null)
        {
            WorkflowExpression.Validate(engineId, nameof(engineId), required: true);
            WorkflowExpression.Validate(bodyinitImage, nameof(bodyinitImage), required: true);
            WorkflowExpression.Validate(organization, nameof(organization), required: false);
            WorkflowExpression.Validate(bodytextPrompts, nameof(bodytextPrompts), required: false);
            WorkflowExpression.Validate(bodyinitImageMode, nameof(bodyinitImageMode), required: false);
            WorkflowExpression.Validate(bodyimageStrength, nameof(bodyimageStrength), required: false);
            WorkflowExpression.Validate(bodyheight, nameof(bodyheight), required: false);
            WorkflowExpression.Validate(bodywidth, nameof(bodywidth), required: false);
            WorkflowExpression.Validate(bodycfgScale, nameof(bodycfgScale), required: false);
            WorkflowExpression.Validate(bodyclipGuidancePreset, nameof(bodyclipGuidancePreset), required: false);
            WorkflowExpression.Validate(bodysampler, nameof(bodysampler), required: false);
            WorkflowExpression.Validate(bodysamples, nameof(bodysamples), required: false);
            WorkflowExpression.Validate(bodyseed, nameof(bodyseed), required: false);
            WorkflowExpression.Validate(bodysteps, nameof(bodysteps), required: false);
            return new DeferredBodyAction<GenerationImageImagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image", ExpressionConverter.ConvertWithUrlEncoding(engineId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [WorkflowExpressionFactory(nameof(__BuildGenerationUpscale))]
        public IBodyWorkflowAction<GenerationUpscalePostResponse> GenerationUpscale([WorkflowExpression] Func<string> engineId, [WorkflowExpression] Func<string> bodyimage, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodywidth = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerationUpscalePostResponse> __BuildGenerationUpscale(WorkflowExpression<string> engineId, WorkflowExpression<string> bodyimage, WorkflowExpression<string> organization = null, WorkflowExpression<int> bodyheight = null, WorkflowExpression<int> bodywidth = null)
        {
            WorkflowExpression.Validate(engineId, nameof(engineId), required: true);
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: true);
            WorkflowExpression.Validate(organization, nameof(organization), required: false);
            WorkflowExpression.Validate(bodyheight, nameof(bodyheight), required: false);
            WorkflowExpression.Validate(bodywidth, nameof(bodywidth), required: false);
            return new DeferredBodyAction<GenerationUpscalePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image/upscale", ExpressionConverter.ConvertWithUrlEncoding(engineId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [WorkflowExpressionFactory(nameof(__BuildGenerationMask))]
        public IBodyWorkflowAction<GenerationMaskPostResponse> GenerationMask([WorkflowExpression] Func<string> engineId, [WorkflowExpression] Func<string> bodyinitImage, [WorkflowExpression] Func<bodymaskSourceInput> bodymaskSource, [WorkflowExpression] Func<string> bodymaskImage, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<bodytextPromptsInputItem[]> bodytextPrompts = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodycfgScale = null, [WorkflowExpression] Func<string> bodyclipGuidancePreset = null, [WorkflowExpression] Func<string> bodysampler = null, [WorkflowExpression] Func<int> bodysamples = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<int> bodysteps = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerationMaskPostResponse> __BuildGenerationMask(WorkflowExpression<string> engineId, WorkflowExpression<string> bodyinitImage, WorkflowExpression<bodymaskSourceInput> bodymaskSource, WorkflowExpression<string> bodymaskImage, WorkflowExpression<string> organization = null, WorkflowExpression<bodytextPromptsInputItem[]> bodytextPrompts = null, WorkflowExpression<int> bodyheight = null, WorkflowExpression<int> bodywidth = null, WorkflowExpression<int> bodycfgScale = null, WorkflowExpression<string> bodyclipGuidancePreset = null, WorkflowExpression<string> bodysampler = null, WorkflowExpression<int> bodysamples = null, WorkflowExpression<int> bodyseed = null, WorkflowExpression<int> bodysteps = null)
        {
            WorkflowExpression.Validate(engineId, nameof(engineId), required: true);
            WorkflowExpression.Validate(bodyinitImage, nameof(bodyinitImage), required: true);
            WorkflowExpression.Validate(bodymaskSource, nameof(bodymaskSource), required: true);
            WorkflowExpression.Validate(bodymaskImage, nameof(bodymaskImage), required: true);
            WorkflowExpression.Validate(organization, nameof(organization), required: false);
            WorkflowExpression.Validate(bodytextPrompts, nameof(bodytextPrompts), required: false);
            WorkflowExpression.Validate(bodyheight, nameof(bodyheight), required: false);
            WorkflowExpression.Validate(bodywidth, nameof(bodywidth), required: false);
            WorkflowExpression.Validate(bodycfgScale, nameof(bodycfgScale), required: false);
            WorkflowExpression.Validate(bodyclipGuidancePreset, nameof(bodyclipGuidancePreset), required: false);
            WorkflowExpression.Validate(bodysampler, nameof(bodysampler), required: false);
            WorkflowExpression.Validate(bodysamples, nameof(bodysamples), required: false);
            WorkflowExpression.Validate(bodyseed, nameof(bodyseed), required: false);
            WorkflowExpression.Validate(bodysteps, nameof(bodysteps), required: false);
            return new DeferredBodyAction<GenerationMaskPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/generation/{0}/image-to-image/masking", ExpressionConverter.ConvertWithUrlEncoding(engineId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [WorkflowExpressionFactory(nameof(__BuildStableImageCore))]
        public IBodyWorkflowAction<StableImageCorePostResponse> StableImageCore([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<bodyaspectRatioInput> bodyaspectRatio = null, [WorkflowExpression] Func<string> bodynegativePrompt = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<bodystylePresetInput> bodystylePreset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StableImageCorePostResponse> __BuildStableImageCore(WorkflowExpression<string> bodyprompt, WorkflowExpression<bodyaspectRatioInput> bodyaspectRatio = null, WorkflowExpression<string> bodynegativePrompt = null, WorkflowExpression<int> bodyseed = null, WorkflowExpression<bodystylePresetInput> bodystylePreset = null)
        {
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: true);
            WorkflowExpression.Validate(bodyaspectRatio, nameof(bodyaspectRatio), required: false);
            WorkflowExpression.Validate(bodynegativePrompt, nameof(bodynegativePrompt), required: false);
            WorkflowExpression.Validate(bodyseed, nameof(bodyseed), required: false);
            WorkflowExpression.Validate(bodystylePreset, nameof(bodystylePreset), required: false);
            return new DeferredBodyAction<StableImageCorePostResponse>(() =>
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
                    if (bodyaspectRatio != null)
                    {
                        body["aspect_ratio"] = ExpressionConverter.ConvertO(bodyaspectRatio);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [WorkflowExpressionFactory(nameof(__BuildStableDiffusion))]
        public IBodyWorkflowAction<StableDiffusionPostResponse> StableDiffusion([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<bodyaspectRatioInput> bodyaspectRatio = null, [WorkflowExpression] Func<string> bodynegativePrompt = null, [WorkflowExpression] Func<bodymodelInput> bodymodel = null, [WorkflowExpression] Func<int> bodyseed = null, [WorkflowExpression] Func<bodystylePresetInput> bodystylePreset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stabilityaiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StableDiffusionPostResponse> __BuildStableDiffusion(WorkflowExpression<string> bodyprompt, WorkflowExpression<bodyaspectRatioInput> bodyaspectRatio = null, WorkflowExpression<string> bodynegativePrompt = null, WorkflowExpression<bodymodelInput> bodymodel = null, WorkflowExpression<int> bodyseed = null, WorkflowExpression<bodystylePresetInput> bodystylePreset = null)
        {
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: true);
            WorkflowExpression.Validate(bodyaspectRatio, nameof(bodyaspectRatio), required: false);
            WorkflowExpression.Validate(bodynegativePrompt, nameof(bodynegativePrompt), required: false);
            WorkflowExpression.Validate(bodymodel, nameof(bodymodel), required: false);
            WorkflowExpression.Validate(bodyseed, nameof(bodyseed), required: false);
            WorkflowExpression.Validate(bodystylePreset, nameof(bodystylePreset), required: false);
            return new DeferredBodyAction<StableDiffusionPostResponse>(() =>
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
                    if (bodyaspectRatio != null)
                    {
                        body["aspect_ratio"] = ExpressionConverter.ConvertO(bodyaspectRatio);
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
                    body["negative_prompt"] = ExpressionConverter.ConvertO(bodynegativePrompt);
                    bodypropCount++;
                }

                if (bodymodel != null)
                {
                    if (bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(bodymodel);
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