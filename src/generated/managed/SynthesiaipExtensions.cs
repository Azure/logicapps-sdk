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
        public IBodyWorkflowAction<VideoListResponse> VideoList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/videos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<VideoListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoCreateResponse> VideoCreate([WorkflowExpression] Func<bodyinputInputItem[]> bodyinput, [WorkflowExpression] Func<bool> bodytest = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyvisibility = null, [WorkflowExpression] Func<string> bodyctaSettingslabel = null, [WorkflowExpression] Func<string> bodyctaSettingsurl = null, [WorkflowExpression] Func<string> bodycallbackId = null, [WorkflowExpression] Func<string> bodysoundtrack = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/videos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytest != null)
                {
                    body["test"] = SourceExpressionConverter.ConvertToken(bodytest);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyvisibility != null)
                {
                    body["visibility"] = SourceExpressionConverter.ConvertToken(bodyvisibility);
                    bodypropCount++;
                }

                var ctaSettingsObject = new JObject();
                var ctaSettingsObjectpropCount = 0;
                if (bodyctaSettingslabel != null)
                {
                    ctaSettingsObject["label"] = SourceExpressionConverter.ConvertToken(bodyctaSettingslabel);
                    ctaSettingsObjectpropCount++;
                }

                if (bodyctaSettingsurl != null)
                {
                    ctaSettingsObject["url"] = SourceExpressionConverter.ConvertToken(bodyctaSettingsurl);
                    ctaSettingsObjectpropCount++;
                }

                if (ctaSettingsObjectpropCount > 0)
                {
                    body["ctaSettings"] = ctaSettingsObject;
                    bodypropCount++;
                }

                if (bodycallbackId != null)
                {
                    body["callbackId"] = SourceExpressionConverter.ConvertToken(bodycallbackId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["input"] = SourceExpressionConverter.ConvertToken(bodyinput);
                if (bodysoundtrack != null)
                {
                    body["soundtrack"] = SourceExpressionConverter.ConvertToken(bodysoundtrack);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VideoCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoStatusResponse> VideoStatus([WorkflowExpression] Func<string> videoId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/videos/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(videoId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VideoStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<string> VideoDelete([WorkflowExpression] Func<string> videoId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/videos/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(videoId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoPatchResponse> VideoPatch([WorkflowExpression] Func<string> videoId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyctaSettingslabel = null, [WorkflowExpression] Func<string> bodyctaSettingsurl = null, [WorkflowExpression] Func<string> bodyvisibility = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/videos/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(videoId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                var ctaSettingsObject = new JObject();
                var ctaSettingsObjectpropCount = 0;
                if (bodyctaSettingslabel != null)
                {
                    ctaSettingsObject["label"] = SourceExpressionConverter.ConvertToken(bodyctaSettingslabel);
                    ctaSettingsObjectpropCount++;
                }

                if (bodyctaSettingsurl != null)
                {
                    ctaSettingsObject["url"] = SourceExpressionConverter.ConvertToken(bodyctaSettingsurl);
                    ctaSettingsObjectpropCount++;
                }

                if (ctaSettingsObjectpropCount > 0)
                {
                    body["ctaSettings"] = ctaSettingsObject;
                    bodypropCount++;
                }

                if (bodyvisibility != null)
                {
                    body["visibility"] = SourceExpressionConverter.ConvertToken(bodyvisibility);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VideoPatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<TemplateListResponse> TemplateList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<TemplateListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> templateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemplateGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "synthesiaip")]
        public IBodyWorkflowAction<VideoCreateTemplateResponse> VideoCreateTemplate([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyvisibility = null, [WorkflowExpression] Func<string> bodytemplateDataname = null, [WorkflowExpression] Func<bool> bodytest = null, [WorkflowExpression] Func<string> bodycallbackId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/videos/fromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyvisibility != null)
                {
                    body["visibility"] = SourceExpressionConverter.ConvertToken(bodyvisibility);
                    bodypropCount++;
                }

                bodypropCount++;
                body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                var templateDataObject = new JObject();
                var templateDataObjectpropCount = 0;
                if (bodytemplateDataname != null)
                {
                    templateDataObject["name"] = SourceExpressionConverter.ConvertToken(bodytemplateDataname);
                    templateDataObjectpropCount++;
                }

                if (templateDataObjectpropCount > 0)
                {
                    body["templateData"] = templateDataObject;
                    bodypropCount++;
                }

                if (bodytest != null)
                {
                    body["test"] = SourceExpressionConverter.ConvertToken(bodytest);
                    bodypropCount++;
                }

                if (bodycallbackId != null)
                {
                    body["callbackId"] = SourceExpressionConverter.ConvertToken(bodycallbackId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VideoCreateTemplateResponse>(BuildSourceInput);
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