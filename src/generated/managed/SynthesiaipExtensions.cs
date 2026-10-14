//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Synthesiaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SynthesiaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoListResponse> VideoList(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredBodyAction<VideoListResponse>(() =>
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
        public IBodyWorkflowAction<VideoCreateResponse> VideoCreate(Expression<Func<bodyinputInputItem[]>> bodyinput, Expression<Func<bool>> bodytest = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyvisibility = null, Expression<Func<string>> bodyctaSettingslabel = null, Expression<Func<string>> bodyctaSettingsurl = null, Expression<Func<string>> bodycallbackId = null, Expression<Func<string>> bodysoundtrack = null)
        {
            var __workflow_bodyinput = bodyinput == null ? null : WorkflowExpression.Compile(bodyinput);
            WorkflowExpression.Validate(__workflow_bodyinput, nameof(bodyinput), required: true);
            var __workflow_bodytest = bodytest == null ? null : WorkflowExpression.Compile(bodytest);
            WorkflowExpression.Validate(__workflow_bodytest, nameof(bodytest), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyvisibility = bodyvisibility == null ? null : WorkflowExpression.Compile(bodyvisibility);
            WorkflowExpression.Validate(__workflow_bodyvisibility, nameof(bodyvisibility), required: false);
            var __workflow_bodyctaSettingslabel = bodyctaSettingslabel == null ? null : WorkflowExpression.Compile(bodyctaSettingslabel);
            WorkflowExpression.Validate(__workflow_bodyctaSettingslabel, nameof(bodyctaSettingslabel), required: false);
            var __workflow_bodyctaSettingsurl = bodyctaSettingsurl == null ? null : WorkflowExpression.Compile(bodyctaSettingsurl);
            WorkflowExpression.Validate(__workflow_bodyctaSettingsurl, nameof(bodyctaSettingsurl), required: false);
            var __workflow_bodycallbackId = bodycallbackId == null ? null : WorkflowExpression.Compile(bodycallbackId);
            WorkflowExpression.Validate(__workflow_bodycallbackId, nameof(bodycallbackId), required: false);
            var __workflow_bodysoundtrack = bodysoundtrack == null ? null : WorkflowExpression.Compile(bodysoundtrack);
            WorkflowExpression.Validate(__workflow_bodysoundtrack, nameof(bodysoundtrack), required: false);
            return new DeferredBodyAction<VideoCreateResponse>(() =>
            {
                var apiCallPath = "/videos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(__workflow_bodytest);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyvisibility != null)
                {
                    body["visibility"] = ExpressionConverter.ConvertO(__workflow_bodyvisibility);
                    bodypropCount++;
                }

                var ctaSettingsObject = new JObject();
                var ctaSettingsObjectpropCount = 0;
                if (__workflow_bodyctaSettingslabel != null)
                {
                    ctaSettingsObject["label"] = ExpressionConverter.ConvertO(__workflow_bodyctaSettingslabel);
                    ctaSettingsObjectpropCount++;
                }

                if (__workflow_bodyctaSettingsurl != null)
                {
                    ctaSettingsObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyctaSettingsurl);
                    ctaSettingsObjectpropCount++;
                }

                if (ctaSettingsObjectpropCount > 0)
                {
                    body["ctaSettings"] = ctaSettingsObject;
                    bodypropCount++;
                }

                if (__workflow_bodycallbackId != null)
                {
                    body["callbackId"] = ExpressionConverter.ConvertO(__workflow_bodycallbackId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["input"] = ExpressionConverter.ConvertO(__workflow_bodyinput);
                if (__workflow_bodysoundtrack != null)
                {
                    body["soundtrack"] = ExpressionConverter.ConvertO(__workflow_bodysoundtrack);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<VideoCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoStatusResponse> VideoStatus(Expression<Func<string>> videoId)
        {
            var __workflow_videoId = videoId == null ? null : WorkflowExpression.Compile(videoId);
            WorkflowExpression.Validate(__workflow_videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<VideoStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/videos/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_videoId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VideoStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<string> VideoDelete(Expression<Func<string>> videoId)
        {
            var __workflow_videoId = videoId == null ? null : WorkflowExpression.Compile(videoId);
            WorkflowExpression.Validate(__workflow_videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/videos/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_videoId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoPatchResponse> VideoPatch(Expression<Func<string>> videoId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyctaSettingslabel = null, Expression<Func<string>> bodyctaSettingsurl = null, Expression<Func<string>> bodyvisibility = null)
        {
            var __workflow_videoId = videoId == null ? null : WorkflowExpression.Compile(videoId);
            WorkflowExpression.Validate(__workflow_videoId, nameof(videoId), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyctaSettingslabel = bodyctaSettingslabel == null ? null : WorkflowExpression.Compile(bodyctaSettingslabel);
            WorkflowExpression.Validate(__workflow_bodyctaSettingslabel, nameof(bodyctaSettingslabel), required: false);
            var __workflow_bodyctaSettingsurl = bodyctaSettingsurl == null ? null : WorkflowExpression.Compile(bodyctaSettingsurl);
            WorkflowExpression.Validate(__workflow_bodyctaSettingsurl, nameof(bodyctaSettingsurl), required: false);
            var __workflow_bodyvisibility = bodyvisibility == null ? null : WorkflowExpression.Compile(bodyvisibility);
            WorkflowExpression.Validate(__workflow_bodyvisibility, nameof(bodyvisibility), required: false);
            return new DeferredBodyAction<VideoPatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/videos/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_videoId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                var ctaSettingsObject = new JObject();
                var ctaSettingsObjectpropCount = 0;
                if (__workflow_bodyctaSettingslabel != null)
                {
                    ctaSettingsObject["label"] = ExpressionConverter.ConvertO(__workflow_bodyctaSettingslabel);
                    ctaSettingsObjectpropCount++;
                }

                if (__workflow_bodyctaSettingsurl != null)
                {
                    ctaSettingsObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyctaSettingsurl);
                    ctaSettingsObjectpropCount++;
                }

                if (ctaSettingsObjectpropCount > 0)
                {
                    body["ctaSettings"] = ctaSettingsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyvisibility != null)
                {
                    body["visibility"] = ExpressionConverter.ConvertO(__workflow_bodyvisibility);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<VideoPatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<TemplateListResponse> TemplateList(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredBodyAction<TemplateListResponse>(() =>
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
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoCreateTemplateResponse> VideoCreateTemplate(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyvisibility = null, Expression<Func<string>> bodytemplateDataname = null, Expression<Func<bool>> bodytest = null, Expression<Func<string>> bodycallbackId = null)
        {
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyvisibility = bodyvisibility == null ? null : WorkflowExpression.Compile(bodyvisibility);
            WorkflowExpression.Validate(__workflow_bodyvisibility, nameof(bodyvisibility), required: false);
            var __workflow_bodytemplateDataname = bodytemplateDataname == null ? null : WorkflowExpression.Compile(bodytemplateDataname);
            WorkflowExpression.Validate(__workflow_bodytemplateDataname, nameof(bodytemplateDataname), required: false);
            var __workflow_bodytest = bodytest == null ? null : WorkflowExpression.Compile(bodytest);
            WorkflowExpression.Validate(__workflow_bodytest, nameof(bodytest), required: false);
            var __workflow_bodycallbackId = bodycallbackId == null ? null : WorkflowExpression.Compile(bodycallbackId);
            WorkflowExpression.Validate(__workflow_bodycallbackId, nameof(bodycallbackId), required: false);
            return new DeferredBodyAction<VideoCreateTemplateResponse>(() =>
            {
                var apiCallPath = "/videos/fromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyvisibility != null)
                {
                    body["visibility"] = ExpressionConverter.ConvertO(__workflow_bodyvisibility);
                    bodypropCount++;
                }

                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                var templateDataObject = new JObject();
                var templateDataObjectpropCount = 0;
                if (__workflow_bodytemplateDataname != null)
                {
                    templateDataObject["name"] = ExpressionConverter.ConvertO(__workflow_bodytemplateDataname);
                    templateDataObjectpropCount++;
                }

                if (templateDataObjectpropCount > 0)
                {
                    body["templateData"] = templateDataObject;
                    bodypropCount++;
                }

                if (__workflow_bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(__workflow_bodytest);
                    bodypropCount++;
                }

                if (__workflow_bodycallbackId != null)
                {
                    body["callbackId"] = ExpressionConverter.ConvertO(__workflow_bodycallbackId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class bodyinputInputItem
    {
        [JsonProperty("scriptText")]
        public string ScriptText { get; set; }

        [JsonProperty("scriptAudio")]
        public string ScriptAudio { get; set; }

        [JsonProperty("scriptLanguage")]
        public string ScriptLanguage { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("avatarSettings")]
        public bodyinputInputItemAvatarSettingsType AvatarSettings { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("backgroundSettings")]
        public bodyinputInputItemBackgroundSettingsType BackgroundSettings { get; set; }
    }

    public class bodyinputInputItemAvatarSettingsType
    {
        [JsonProperty("voice")]
        public string Voice { get; set; }

        [JsonProperty("horizontalAlign")]
        public string HorizontalAlign { get; set; }

        [JsonProperty("scale")]
        public int Scale { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("seamless")]
        public bool Seamless { get; set; }
    }

    public class bodyinputInputItemBackgroundSettingsType
    {
        [JsonProperty("videoSettings")]
        public bodyinputInputItemBackgroundSettingsTypeVideoSettingsType VideoSettings { get; set; }
    }

    public class bodyinputInputItemBackgroundSettingsTypeVideoSettingsType
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
