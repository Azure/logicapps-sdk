//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jasperip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JasperipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<CommandPostResponse, ApiConnectionActionConfiguration> Command(Expression<Func<CommandPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CommandPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/command";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CommandPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KeepWritingPostResponse, ApiConnectionActionConfiguration> KeepWriting(Expression<Func<KeepWritingPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<KeepWritingPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/keep-writing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<KeepWritingPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplatesGetResponse, ApiConnectionActionConfiguration> TemplatesGet()
        {
            return new DeferredBodyAction<TemplatesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplatesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplateGetResponse, ApiConnectionActionConfiguration> TemplateGet(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/templates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplatePostResponse, ApiConnectionActionConfiguration> Template(Expression<Func<string>> templateId, Expression<Func<TemplatePostInput>> body = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TemplatePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/templates/{0}/run", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TemplatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgesGetResponse, ApiConnectionActionConfiguration> KnowledgesGet(Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<KnowledgesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/knowledge";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<KnowledgesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgePostResponse, ApiConnectionActionConfiguration> Knowledge(Expression<Func<KnowledgePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<KnowledgePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/knowledge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<KnowledgePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgeGetResponse, ApiConnectionActionConfiguration> KnowledgeGet(Expression<Func<string>> knowledgeId)
        {
            var __workflow_knowledgeId = WorkflowExpression.Compile(knowledgeId, nameof(knowledgeId), required: true);
            return new DeferredBodyAction<KnowledgeGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/knowledge/{0}", __workflow_knowledgeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KnowledgeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgeDeleteResponse, ApiConnectionActionConfiguration> KnowledgeDelete(Expression<Func<string>> knowledgeId)
        {
            var __workflow_knowledgeId = WorkflowExpression.Compile(knowledgeId, nameof(knowledgeId), required: true);
            return new DeferredBodyAction<KnowledgeDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/knowledge/{0}", __workflow_knowledgeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KnowledgeDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgePatchResponse, ApiConnectionActionConfiguration> KnowledgePatch(Expression<Func<string>> knowledgeId, Expression<Func<KnowledgePatchInput>> body = null)
        {
            var __workflow_knowledgeId = WorkflowExpression.Compile(knowledgeId, nameof(knowledgeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<KnowledgePatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/knowledge/{0}", __workflow_knowledgeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<KnowledgePatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonesGetResponseItem[], ApiConnectionActionConfiguration> TonesGet()
        {
            return new DeferredBodyAction<TonesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tones";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TonesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonePostResponse, ApiConnectionActionConfiguration> Tone(Expression<Func<TonePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TonePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TonePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<ToneGetResponse, ApiConnectionActionConfiguration> ToneGet(Expression<Func<string>> toneId)
        {
            var __workflow_toneId = WorkflowExpression.Compile(toneId, nameof(toneId), required: true);
            return new DeferredBodyAction<ToneGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/tones/{0}", __workflow_toneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToneGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonePatchResponse, ApiConnectionActionConfiguration> TonePatch(Expression<Func<string>> toneId, Expression<Func<TonePatchInput>> body = null)
        {
            var __workflow_toneId = WorkflowExpression.Compile(toneId, nameof(toneId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TonePatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/tones/{0}", __workflow_toneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TonePatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<ToneDeleteResponse, ApiConnectionActionConfiguration> ToneDelete(Expression<Func<string>> toneId)
        {
            var __workflow_toneId = WorkflowExpression.Compile(toneId, nameof(toneId), required: true);
            return new DeferredBodyAction<ToneDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/tones/{0}", __workflow_toneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToneDeleteResponse>(callPayload);
            });
        }
    }

    public class JasperipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommandPostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public CommandPostResponseDataTypeItem[] Data { get; set; }
    }

    public class CommandPostResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CommandPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommandPostInputInputsType Inputs { get; set; }

        [JsonProperty("options")]
        public CommandPostInputOptionsType Options { get; set; }
    }

    public class CommandPostInputInputsType
    {
        [JsonProperty("command", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Command { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    public class CommandPostInputOptionsType
    {
        [JsonProperty("outputCount", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? OutputCount { get; set; } = 3;

        [JsonProperty("inputLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommandPostInputOptionsTypeInputLanguageType? InputLanguage { get; set; } = CommandPostInputOptionsTypeInputLanguageType.English;

        [JsonProperty("outputLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommandPostInputOptionsTypeOutputLanguageType? OutputLanguage { get; set; } = CommandPostInputOptionsTypeOutputLanguageType.English;

        [JsonProperty("languageFormality", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommandPostInputOptionsTypeLanguageFormalityType? LanguageFormality { get; set; } = CommandPostInputOptionsTypeLanguageFormalityType.Default;

        [JsonProperty("completionType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommandPostInputOptionsTypeCompletionTypeType? CompletionType { get; set; } = CommandPostInputOptionsTypeCompletionTypeType.Performance;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommandPostInputOptionsTypeInputLanguageType
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommandPostInputOptionsTypeOutputLanguageType
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommandPostInputOptionsTypeLanguageFormalityType
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "more")]
        More,
        [EnumMember(Value = "less")]
        Less
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommandPostInputOptionsTypeCompletionTypeType
    {
        [EnumMember(Value = "performance")]
        Performance,
        [EnumMember(Value = "quality")]
        Quality
    }

    public class KeepWritingPostResponse
    {
        [JsonProperty("data")]
        public KeepWritingPostResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class KeepWritingPostResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class KeepWritingPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public KeepWritingPostInputInputsType Inputs { get; set; }

        [JsonProperty("options")]
        public KeepWritingPostInputOptionsType Options { get; set; }
    }

    public class KeepWritingPostInputInputsType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public KeepWritingPostInputInputsTypeTypeType Type { get; set; } = KeepWritingPostInputInputsTypeTypeType.Text;

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KeepWritingPostInputInputsTypeTypeType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "id")]
        Id
    }

    public class KeepWritingPostInputOptionsType
    {
        [JsonProperty("inputLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public KeepWritingPostInputOptionsTypeInputLanguageType? InputLanguage { get; set; } = KeepWritingPostInputOptionsTypeInputLanguageType.English;

        [JsonProperty("outputLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public KeepWritingPostInputOptionsTypeOutputLanguageType? OutputLanguage { get; set; } = KeepWritingPostInputOptionsTypeOutputLanguageType.English;

        [JsonProperty("languageFormality", DefaultValueHandling = DefaultValueHandling.Include)]
        public KeepWritingPostInputOptionsTypeLanguageFormalityType? LanguageFormality { get; set; } = KeepWritingPostInputOptionsTypeLanguageFormalityType.Default;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KeepWritingPostInputOptionsTypeInputLanguageType
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KeepWritingPostInputOptionsTypeOutputLanguageType
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KeepWritingPostInputOptionsTypeLanguageFormalityType
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "more")]
        More,
        [EnumMember(Value = "less")]
        Less
    }

    public class TemplatesGetResponse
    {
        [JsonProperty("data")]
        public TemplatesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class TemplatesGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("inputSchema")]
        public TemplatesGetResponseDataTypeItemInputSchemaTypeItem[] InputSchema { get; set; }
    }

    public class TemplatesGetResponseDataTypeItemInputSchemaTypeItem
    {
        [JsonProperty("inputKey")]
        public string InputKey { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }
    }

    public class TemplateGetResponse
    {
        [JsonProperty("data")]
        public TemplateGetResponseDataType Data { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class TemplateGetResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("inputSchema")]
        public TemplateGetResponseDataTypeInputSchemaTypeItem[] InputSchema { get; set; }
    }

    public class TemplateGetResponseDataTypeInputSchemaTypeItem
    {
        [JsonProperty("inputKey")]
        public string InputKey { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }
    }

    public class TemplatePostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public TemplatePostResponseDataTypeItem[] Data { get; set; }
    }

    public class TemplatePostResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TemplatePostInput
    {
        [JsonProperty("inputs")]
        public JToken Inputs { get; set; }

        [JsonProperty("options")]
        public TemplatePostInputOptionsType Options { get; set; }
    }

    public class TemplatePostInputOptionsType
    {
        [JsonProperty("outputCount")]
        public int? OutputCount { get; set; }

        [JsonProperty("inputLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public TemplatePostInputOptionsTypeInputLanguageType? InputLanguage { get; set; } = TemplatePostInputOptionsTypeInputLanguageType.English;

        [JsonProperty("outputLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public TemplatePostInputOptionsTypeOutputLanguageType? OutputLanguage { get; set; } = TemplatePostInputOptionsTypeOutputLanguageType.English;

        [JsonProperty("languageFormality", DefaultValueHandling = DefaultValueHandling.Include)]
        public TemplatePostInputOptionsTypeLanguageFormalityType? LanguageFormality { get; set; } = TemplatePostInputOptionsTypeLanguageFormalityType.Default;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TemplatePostInputOptionsTypeInputLanguageType
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TemplatePostInputOptionsTypeOutputLanguageType
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TemplatePostInputOptionsTypeLanguageFormalityType
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "more")]
        More,
        [EnumMember(Value = "less")]
        Less
    }

    public class KnowledgesGetResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public KnowledgesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("pagination")]
        public KnowledgesGetResponsePaginationType Pagination { get; set; }
    }

    public class KnowledgesGetResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgesGetResponseDataTypeItemSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processingState")]
        public string ProcessingState { get; set; }
    }

    public class KnowledgesGetResponseDataTypeItemSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class KnowledgesGetResponsePaginationType
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }
    }

    public class KnowledgePostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public KnowledgePostResponseDataTypeItem[] Data { get; set; }
    }

    public class KnowledgePostResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgePostResponseDataTypeItemSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processingState")]
        public string ProcessingState { get; set; }
    }

    public class KnowledgePostResponseDataTypeItemSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class KnowledgePostInput
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgePostInputSettingsType Settings { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }
    }

    public class KnowledgePostInputSettingsType
    {
        [JsonProperty("appVisibility", DefaultValueHandling = DefaultValueHandling.Include)]
        public KnowledgePostInputSettingsTypeAppVisibilityType? AppVisibility { get; set; } = KnowledgePostInputSettingsTypeAppVisibilityType.Visible;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KnowledgePostInputSettingsTypeAppVisibilityType
    {
        [EnumMember(Value = "visible")]
        Visible,
        [EnumMember(Value = "hidden")]
        Hidden
    }

    public class KnowledgeGetResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public KnowledgeGetResponseDataTypeItem[] Data { get; set; }
    }

    public class KnowledgeGetResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public KnowledgeGetResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgeGetResponseDataTypeItemSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processingState")]
        public string ProcessingState { get; set; }
    }

    public class KnowledgeGetResponseDataTypeItemMetadataType
    {
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }
    }

    public class KnowledgeGetResponseDataTypeItemSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class KnowledgeDeleteResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class KnowledgePatchResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public KnowledgePatchResponseDataTypeItem[] Data { get; set; }
    }

    public class KnowledgePatchResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgePatchResponseDataTypeItemSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processingState")]
        public string ProcessingState { get; set; }
    }

    public class KnowledgePatchResponseDataTypeItemSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class KnowledgePatchInput
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgePatchInputSettingsType Settings { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class KnowledgePatchInputSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class TonesGetResponseItem
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public TonesGetResponseItemDataType Data { get; set; }

        [JsonProperty("pagination")]
        public TonesGetResponseItemPaginationType Pagination { get; set; }
    }

    public class TonesGetResponseItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public TonesGetResponseItemDataTypeSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class TonesGetResponseItemDataTypeSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class TonesGetResponseItemPaginationType
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }
    }

    public class TonePostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public TonePostResponseDataType Data { get; set; }
    }

    public class TonePostResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public TonePostResponseDataTypeSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class TonePostResponseDataTypeSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class TonePostInput
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public TonePostInputSettingsType Settings { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class TonePostInputSettingsType
    {
        [JsonProperty("appVisibility", DefaultValueHandling = DefaultValueHandling.Include)]
        public TonePostInputSettingsTypeAppVisibilityType? AppVisibility { get; set; } = TonePostInputSettingsTypeAppVisibilityType.Visible;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TonePostInputSettingsTypeAppVisibilityType
    {
        [EnumMember(Value = "visible")]
        Visible,
        [EnumMember(Value = "hidden")]
        Hidden
    }

    public class ToneGetResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public ToneGetResponseDataType Data { get; set; }
    }

    public class ToneGetResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public ToneGetResponseDataTypeSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class ToneGetResponseDataTypeSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class TonePatchResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public TonePatchResponseDataType Data { get; set; }
    }

    public class TonePatchResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public TonePatchResponseDataTypeSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class TonePatchResponseDataTypeSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class TonePatchInput
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public TonePatchInputSettingsType Settings { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class TonePatchInputSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class ToneDeleteResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jasperip;

    public partial class WorkflowManagedActions
    {
        public JasperipActions Jasperip(string connectionId) => new JasperipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JasperipTriggers Jasperip(string connectionId) => new JasperipTriggers(connectionId);
    }
}