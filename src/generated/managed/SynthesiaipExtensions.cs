//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Synthesiaip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SynthesiaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        [WorkflowExpressionFactory(nameof(__BuildVideoList))]
        public IBodyWorkflowAction<VideoListResponse> VideoList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VideoListResponse> __BuildVideoList(WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<VideoListResponse>(() =>
            {
                var apiCallPath = "/videos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<VideoListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        [WorkflowExpressionFactory(nameof(__BuildVideoCreate))]
        public IBodyWorkflowAction<VideoCreateResponse> VideoCreate([WorkflowExpression] Func<bodyinputInputItem[]> bodyinput, [WorkflowExpression] Func<bool> bodytest = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyvisibility = null, [WorkflowExpression] Func<string> bodyctaSettingslabel = null, [WorkflowExpression] Func<string> bodyctaSettingsurl = null, [WorkflowExpression] Func<string> bodycallbackId = null, [WorkflowExpression] Func<string> bodysoundtrack = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VideoCreateResponse> __BuildVideoCreate(WorkflowValue<bodyinputInputItem[]> bodyinput, WorkflowValue<bool> bodytest = null, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodyvisibility = null, WorkflowValue<string> bodyctaSettingslabel = null, WorkflowValue<string> bodyctaSettingsurl = null, WorkflowValue<string> bodycallbackId = null, WorkflowValue<string> bodysoundtrack = null)
        {
            WorkflowValue.Validate(bodyinput, nameof(bodyinput), required: true);
            WorkflowValue.Validate(bodytest, nameof(bodytest), required: false);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyvisibility, nameof(bodyvisibility), required: false);
            WorkflowValue.Validate(bodyctaSettingslabel, nameof(bodyctaSettingslabel), required: false);
            WorkflowValue.Validate(bodyctaSettingsurl, nameof(bodyctaSettingsurl), required: false);
            WorkflowValue.Validate(bodycallbackId, nameof(bodycallbackId), required: false);
            WorkflowValue.Validate(bodysoundtrack, nameof(bodysoundtrack), required: false);
            return new DeferredBodyAction<VideoCreateResponse>(() =>
            {
                var apiCallPath = "/videos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(bodytest);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyvisibility != null)
                {
                    body["visibility"] = ExpressionConverter.ConvertO(bodyvisibility);
                    bodypropCount++;
                }

                var ctaSettingsObject = new JObject();
                var ctaSettingsObjectpropCount = 0;
                if (bodyctaSettingslabel != null)
                {
                    ctaSettingsObject["label"] = ExpressionConverter.ConvertO(bodyctaSettingslabel);
                    ctaSettingsObjectpropCount++;
                }

                if (bodyctaSettingsurl != null)
                {
                    ctaSettingsObject["url"] = ExpressionConverter.ConvertO(bodyctaSettingsurl);
                    ctaSettingsObjectpropCount++;
                }

                if (ctaSettingsObjectpropCount > 0)
                {
                    body["ctaSettings"] = ctaSettingsObject;
                    bodypropCount++;
                }

                if (bodycallbackId != null)
                {
                    body["callbackId"] = ExpressionConverter.ConvertO(bodycallbackId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["input"] = ExpressionConverter.ConvertO(bodyinput);
                if (bodysoundtrack != null)
                {
                    body["soundtrack"] = ExpressionConverter.ConvertO(bodysoundtrack);
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
        [WorkflowExpressionFactory(nameof(__BuildVideoStatus))]
        public IBodyWorkflowAction<VideoStatusResponse> VideoStatus([WorkflowExpression] Func<string> videoId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VideoStatusResponse> __BuildVideoStatus(WorkflowValue<string> videoId)
        {
            WorkflowValue.Validate(videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<VideoStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/videos/{0}", ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VideoStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        [WorkflowExpressionFactory(nameof(__BuildVideoDelete))]
        public IBodyWorkflowAction<string> VideoDelete([WorkflowExpression] Func<string> videoId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideoDelete(WorkflowValue<string> videoId)
        {
            WorkflowValue.Validate(videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/videos/{0}", ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        [WorkflowExpressionFactory(nameof(__BuildVideoPatch))]
        public IBodyWorkflowAction<VideoPatchResponse> VideoPatch([WorkflowExpression] Func<string> videoId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyctaSettingslabel = null, [WorkflowExpression] Func<string> bodyctaSettingsurl = null, [WorkflowExpression] Func<string> bodyvisibility = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VideoPatchResponse> __BuildVideoPatch(WorkflowValue<string> videoId, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodyctaSettingslabel = null, WorkflowValue<string> bodyctaSettingsurl = null, WorkflowValue<string> bodyvisibility = null)
        {
            WorkflowValue.Validate(videoId, nameof(videoId), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyctaSettingslabel, nameof(bodyctaSettingslabel), required: false);
            WorkflowValue.Validate(bodyctaSettingsurl, nameof(bodyctaSettingsurl), required: false);
            WorkflowValue.Validate(bodyvisibility, nameof(bodyvisibility), required: false);
            return new DeferredBodyAction<VideoPatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/videos/{0}", ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                var ctaSettingsObject = new JObject();
                var ctaSettingsObjectpropCount = 0;
                if (bodyctaSettingslabel != null)
                {
                    ctaSettingsObject["label"] = ExpressionConverter.ConvertO(bodyctaSettingslabel);
                    ctaSettingsObjectpropCount++;
                }

                if (bodyctaSettingsurl != null)
                {
                    ctaSettingsObject["url"] = ExpressionConverter.ConvertO(bodyctaSettingsurl);
                    ctaSettingsObjectpropCount++;
                }

                if (ctaSettingsObjectpropCount > 0)
                {
                    body["ctaSettings"] = ctaSettingsObject;
                    bodypropCount++;
                }

                if (bodyvisibility != null)
                {
                    body["visibility"] = ExpressionConverter.ConvertO(bodyvisibility);
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
        [WorkflowExpressionFactory(nameof(__BuildTemplateList))]
        public IBodyWorkflowAction<TemplateListResponse> TemplateList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplateListResponse> __BuildTemplateList(WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TemplateListResponse>(() =>
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<TemplateListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplateGet))]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplateGetResponse> __BuildTemplateGet(WorkflowValue<string> templateId)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        [WorkflowExpressionFactory(nameof(__BuildVideoCreateTemplate))]
        public IBodyWorkflowAction<VideoCreateTemplateResponse> VideoCreateTemplate([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyvisibility = null, [WorkflowExpression] Func<string> bodytemplateDataname = null, [WorkflowExpression] Func<bool> bodytest = null, [WorkflowExpression] Func<string> bodycallbackId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VideoCreateTemplateResponse> __BuildVideoCreateTemplate(WorkflowValue<string> bodytemplateId, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodyvisibility = null, WorkflowValue<string> bodytemplateDataname = null, WorkflowValue<bool> bodytest = null, WorkflowValue<string> bodycallbackId = null)
        {
            WorkflowValue.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyvisibility, nameof(bodyvisibility), required: false);
            WorkflowValue.Validate(bodytemplateDataname, nameof(bodytemplateDataname), required: false);
            WorkflowValue.Validate(bodytest, nameof(bodytest), required: false);
            WorkflowValue.Validate(bodycallbackId, nameof(bodycallbackId), required: false);
            return new DeferredBodyAction<VideoCreateTemplateResponse>(() =>
            {
                var apiCallPath = "/videos/fromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyvisibility != null)
                {
                    body["visibility"] = ExpressionConverter.ConvertO(bodyvisibility);
                    bodypropCount++;
                }

                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                var templateDataObject = new JObject();
                var templateDataObjectpropCount = 0;
                if (bodytemplateDataname != null)
                {
                    templateDataObject["name"] = ExpressionConverter.ConvertO(bodytemplateDataname);
                    templateDataObjectpropCount++;
                }

                if (templateDataObjectpropCount > 0)
                {
                    body["templateData"] = templateDataObject;
                    bodypropCount++;
                }

                if (bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(bodytest);
                    bodypropCount++;
                }

                if (bodycallbackId != null)
                {
                    body["callbackId"] = ExpressionConverter.ConvertO(bodycallbackId);
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
