//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Synthesiaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SynthesiaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoListResponse, ApiConnectionActionConfiguration> VideoList(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<VideoListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/videos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<VideoListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoCreateResponse, ApiConnectionActionConfiguration> VideoCreate(Expression<Func<VideoCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<VideoCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/videos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VideoCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoStatusResponse, ApiConnectionActionConfiguration> VideoStatus(Expression<Func<string>> videoId)
        {
            var __workflow_videoId = WorkflowExpression.Compile(videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<VideoStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/videos/{0}", __workflow_videoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VideoStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> VideoDelete(Expression<Func<string>> videoId)
        {
            var __workflow_videoId = WorkflowExpression.Compile(videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/videos/{0}", __workflow_videoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoPatchResponse, ApiConnectionActionConfiguration> VideoPatch(Expression<Func<string>> videoId, Expression<Func<VideoPatchInput>> body)
        {
            var __workflow_videoId = WorkflowExpression.Compile(videoId, nameof(videoId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<VideoPatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/videos/{0}", __workflow_videoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VideoPatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<TemplateListResponse, ApiConnectionActionConfiguration> TemplateList(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TemplateListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<TemplateListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<TemplateGetResponse, ApiConnectionActionConfiguration> TemplateGet(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoCreateTemplateResponse, ApiConnectionActionConfiguration> VideoCreateTemplate(Expression<Func<VideoCreateTemplateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<VideoCreateTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/videos/fromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VideoCreateTemplateResponse>(callPayload);
            });
        }
    }

    public class SynthesiaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class VideoListResponse
    {
        [JsonProperty("videos")]
        public VideoListResponseVideosTypeItem[] Videos { get; set; }
    }

    public class VideoListResponseVideosTypeItem
    {
        [JsonProperty("callbackId")]
        public string CallbackId { get; set; }

        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("ctaSettings")]
        public VideoListResponseVideosTypeItemCtaSettingsType CtaSettings { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public int LastUpdatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class VideoListResponseVideosTypeItemCtaSettingsType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VideoCreateResponse
    {
        [JsonProperty("callbackId")]
        public string CallbackId { get; set; }

        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("ctaSettings")]
        public VideoCreateResponseCtaSettingsType CtaSettings { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public int LastUpdatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class VideoCreateResponseCtaSettingsType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VideoCreateInput
    {
        [JsonProperty("test")]
        public bool? Test { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("ctaSettings")]
        public VideoCreateInputCtaSettingsType CtaSettings { get; set; }

        [JsonProperty("callbackId")]
        public string CallbackId { get; set; }

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public VideoCreateInputInputTypeItem[] Input { get; set; }

        [JsonProperty("soundtrack")]
        public string Soundtrack { get; set; }
    }

    public class VideoCreateInputCtaSettingsType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VideoCreateInputInputTypeItem
    {
        [JsonProperty("scriptText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScriptText { get; set; }

        [JsonProperty("scriptAudio")]
        public string ScriptAudio { get; set; }

        [JsonProperty("scriptLanguage")]
        public string ScriptLanguage { get; set; }

        [JsonProperty("avatar", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Avatar { get; set; }

        [JsonProperty("avatarSettings")]
        public VideoCreateInputInputTypeItemAvatarSettingsType AvatarSettings { get; set; }

        [JsonProperty("background", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Background { get; set; }

        [JsonProperty("backgroundSettings")]
        public VideoCreateInputInputTypeItemBackgroundSettingsType BackgroundSettings { get; set; }
    }

    public class VideoCreateInputInputTypeItemAvatarSettingsType
    {
        [JsonProperty("voice")]
        public string Voice { get; set; }

        [JsonProperty("horizontalAlign")]
        public string HorizontalAlign { get; set; }

        [JsonProperty("scale")]
        public int? Scale { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("seamless")]
        public bool? Seamless { get; set; }
    }

    public class VideoCreateInputInputTypeItemBackgroundSettingsType
    {
        [JsonProperty("videoSettings")]
        public VideoCreateInputInputTypeItemBackgroundSettingsTypeVideoSettingsType VideoSettings { get; set; }
    }

    public class VideoCreateInputInputTypeItemBackgroundSettingsTypeVideoSettingsType
    {
        [JsonProperty("shortBackgroundContentMatchMode")]
        public string ShortBackgroundContentMatchMode { get; set; }

        [JsonProperty("longBackgroundContentMatchMode")]
        public string LongBackgroundContentMatchMode { get; set; }
    }

    public class VideoStatusResponse
    {
        [JsonProperty("callbackId")]
        public string CallbackId { get; set; }

        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("ctaSettings")]
        public VideoStatusResponseCtaSettingsType CtaSettings { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public int LastUpdatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class VideoStatusResponseCtaSettingsType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VideoPatchResponse
    {
        [JsonProperty("callbackId")]
        public string CallbackId { get; set; }

        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("ctaSettings")]
        public VideoPatchResponseCtaSettingsType CtaSettings { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public int LastUpdatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class VideoPatchResponseCtaSettingsType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VideoPatchInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ctaSettings")]
        public VideoPatchInputCtaSettingsType CtaSettings { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class VideoPatchInputCtaSettingsType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class TemplateListResponse
    {
        [JsonProperty("nextOffset")]
        public int NextOffset { get; set; }

        [JsonProperty("templates")]
        public TemplateListResponseTemplatesTypeItem[] Templates { get; set; }
    }

    public class TemplateListResponseTemplatesTypeItem
    {
        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public int LastUpdatedAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("variables")]
        public TemplateListResponseTemplatesTypeItemVariablesTypeItem[] Variables { get; set; }
    }

    public class TemplateListResponseTemplatesTypeItemVariablesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TemplateGetResponse
    {
        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public int LastUpdatedAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("variables")]
        public JToken[] Variables { get; set; }
    }

    public class VideoCreateTemplateResponse
    {
        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public int LastUpdatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class VideoCreateTemplateInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("templateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty("templateData")]
        public VideoCreateTemplateInputTemplateDataType TemplateData { get; set; }

        [JsonProperty("test")]
        public bool? Test { get; set; }

        [JsonProperty("callbackId")]
        public string CallbackId { get; set; }
    }

    public class VideoCreateTemplateInputTemplateDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Synthesiaip;

    public partial class WorkflowManagedActions
    {
        public SynthesiaipActions Synthesiaip(string connectionId) => new SynthesiaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SynthesiaipTriggers Synthesiaip(string connectionId) => new SynthesiaipTriggers(connectionId);
    }
}