//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Synthesiaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SynthesiaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoListResponse> VideoList(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/videos";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<VideoListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoCreateResponse> VideoCreate(Expression<Func<bodyinputInputItem[]>> bodyinput, Expression<Func<bool>> bodytest = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyvisibility = null, Expression<Func<string>> bodyctaSettingslabel = null, Expression<Func<string>> bodyctaSettingsurl = null, Expression<Func<string>> bodycallbackId = null, Expression<Func<string>> bodysoundtrack = null)
        {
            var apiCallPath = "/videos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytest != null)
            {
                body["test"] = CSharpExpressionConverter.ConvertToken(bodytest);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyvisibility != null)
            {
                body["visibility"] = CSharpExpressionConverter.ConvertToken(bodyvisibility);
                bodypropCount++;
            }

            var ctaSettingsObject = new JObject();
            var ctaSettingsObjectpropCount = 0;
            if (bodyctaSettingslabel != null)
            {
                ctaSettingsObject["label"] = CSharpExpressionConverter.ConvertToken(bodyctaSettingslabel);
                ctaSettingsObjectpropCount++;
            }

            if (bodyctaSettingsurl != null)
            {
                ctaSettingsObject["url"] = CSharpExpressionConverter.ConvertToken(bodyctaSettingsurl);
                ctaSettingsObjectpropCount++;
            }

            if (ctaSettingsObjectpropCount > 0)
            {
                body["ctaSettings"] = ctaSettingsObject;
                bodypropCount++;
            }

            if (bodycallbackId != null)
            {
                body["callbackId"] = CSharpExpressionConverter.ConvertToken(bodycallbackId);
                bodypropCount++;
            }

            bodypropCount++;
            body["input"] = CSharpExpressionConverter.ConvertToken(bodyinput);
            if (bodysoundtrack != null)
            {
                body["soundtrack"] = CSharpExpressionConverter.ConvertToken(bodysoundtrack);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<VideoCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoStatusResponse> VideoStatus(Expression<Func<string>> videoId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/videos/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VideoStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<string> VideoDelete(Expression<Func<string>> videoId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/videos/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoPatchResponse> VideoPatch(Expression<Func<string>> videoId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyctaSettingslabel = null, Expression<Func<string>> bodyctaSettingsurl = null, Expression<Func<string>> bodyvisibility = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/videos/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            var ctaSettingsObject = new JObject();
            var ctaSettingsObjectpropCount = 0;
            if (bodyctaSettingslabel != null)
            {
                ctaSettingsObject["label"] = CSharpExpressionConverter.ConvertToken(bodyctaSettingslabel);
                ctaSettingsObjectpropCount++;
            }

            if (bodyctaSettingsurl != null)
            {
                ctaSettingsObject["url"] = CSharpExpressionConverter.ConvertToken(bodyctaSettingsurl);
                ctaSettingsObjectpropCount++;
            }

            if (ctaSettingsObjectpropCount > 0)
            {
                body["ctaSettings"] = ctaSettingsObject;
                bodypropCount++;
            }

            if (bodyvisibility != null)
            {
                body["visibility"] = CSharpExpressionConverter.ConvertToken(bodyvisibility);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<VideoPatchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<TemplateListResponse> TemplateList(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<TemplateListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet(Expression<Func<string>> templateId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/templates/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplateGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoCreateTemplateResponse> VideoCreateTemplate(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyvisibility = null, Expression<Func<string>> bodytemplateDataname = null, Expression<Func<bool>> bodytest = null, Expression<Func<string>> bodycallbackId = null)
        {
            var apiCallPath = "/videos/fromTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyvisibility != null)
            {
                body["visibility"] = CSharpExpressionConverter.ConvertToken(bodyvisibility);
                bodypropCount++;
            }

            bodypropCount++;
            body["templateId"] = CSharpExpressionConverter.ConvertToken(bodytemplateId);
            var templateDataObject = new JObject();
            var templateDataObjectpropCount = 0;
            if (bodytemplateDataname != null)
            {
                templateDataObject["name"] = CSharpExpressionConverter.ConvertToken(bodytemplateDataname);
                templateDataObjectpropCount++;
            }

            if (templateDataObjectpropCount > 0)
            {
                body["templateData"] = templateDataObject;
                bodypropCount++;
            }

            if (bodytest != null)
            {
                body["test"] = CSharpExpressionConverter.ConvertToken(bodytest);
                bodypropCount++;
            }

            if (bodycallbackId != null)
            {
                body["callbackId"] = CSharpExpressionConverter.ConvertToken(bodycallbackId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<VideoCreateTemplateResponse>(callPayload);
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