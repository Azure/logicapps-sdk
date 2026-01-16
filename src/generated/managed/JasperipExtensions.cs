//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jasperip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JasperipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplatesGetResponse> TemplatesGet()
        {
            var apiCallPath = "/v1/templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplatesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet(Expression<Func<string>> templateId)
        {
            var apiCallPath = String.Format("/v1/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplateGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplatePostResponse> TemplatePost(Expression<Func<string>> templateId, Expression<Func<int>> bodyoptionsoutputCount = null, Expression<Func<bodyoptionsinputLanguageInput>> bodyoptionsinputLanguage = null, Expression<Func<bodyoptionsoutputLanguageInput>> bodyoptionsoutputLanguage = null, Expression<Func<bodyoptionslanguageFormalityInput>> bodyoptionslanguageFormality = null)
        {
            var apiCallPath = String.Format("/v1/templates/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var inputsObject = new JObject();
            var inputsObjectpropCount = 0;
            if (inputsObjectpropCount > 0)
            {
                body["inputs"] = inputsObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoutputCount != null)
            {
                optionsObject["outputCount"] = ExpressionConverter.ConvertO(bodyoptionsoutputCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsinputLanguage != null)
            {
                optionsObject["inputLanguage"] = ExpressionConverter.ConvertO(bodyoptionsinputLanguage);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoutputLanguage != null)
            {
                optionsObject["outputLanguage"] = ExpressionConverter.ConvertO(bodyoptionsoutputLanguage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslanguageFormality != null)
            {
                optionsObject["languageFormality"] = ExpressionConverter.ConvertO(bodyoptionslanguageFormality);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TemplatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgesGetResponse> KnowledgesGet(Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v1/knowledge";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<KnowledgesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgePostResponse> KnowledgePost(Expression<Func<string>> bodyname, Expression<Func<string>> bodyfile, Expression<Func<bodysettingsappVisibilityInput>> bodysettingsappVisibility = null)
        {
            var apiCallPath = "/v1/knowledge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsappVisibility != null)
            {
                settingsObject["appVisibility"] = ExpressionConverter.ConvertO(bodysettingsappVisibility);
                settingsObjectpropCount++;
            }

            if (settingsObjectpropCount > 0)
            {
                body["settings"] = settingsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["file"] = ExpressionConverter.ConvertO(bodyfile);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<KnowledgePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgeGetResponse> KnowledgeGet(Expression<Func<string>> knowledgeId)
        {
            var apiCallPath = String.Format("/v1/knowledge/{0}", ExpressionConverter.ConvertWithUrlEncoding(knowledgeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<KnowledgeGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgeDeleteResponse> KnowledgeDelete(Expression<Func<string>> knowledgeId)
        {
            var apiCallPath = String.Format("/v1/knowledge/{0}", ExpressionConverter.ConvertWithUrlEncoding(knowledgeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<KnowledgeDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgePatchResponse> KnowledgePatch(Expression<Func<string>> knowledgeId, Expression<Func<string>> bodysettingsappVisibility = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyfile = null)
        {
            var apiCallPath = String.Format("/v1/knowledge/{0}", ExpressionConverter.ConvertWithUrlEncoding(knowledgeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsappVisibility != null)
            {
                settingsObject["appVisibility"] = ExpressionConverter.ConvertO(bodysettingsappVisibility);
                settingsObjectpropCount++;
            }

            if (settingsObjectpropCount > 0)
            {
                body["settings"] = settingsObject;
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyfile != null)
            {
                body["file"] = ExpressionConverter.ConvertO(bodyfile);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<KnowledgePatchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonesGetResponseItem[]> TonesGet()
        {
            var apiCallPath = "/v1/tones";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TonesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonePostResponse> TonePost(Expression<Func<string>> bodyname, Expression<Func<string>> bodyvalue, Expression<Func<bodysettingsappVisibilityInput>> bodysettingsappVisibility = null)
        {
            var apiCallPath = "/v1/tones";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsappVisibility != null)
            {
                settingsObject["appVisibility"] = ExpressionConverter.ConvertO(bodysettingsappVisibility);
                settingsObjectpropCount++;
            }

            if (settingsObjectpropCount > 0)
            {
                body["settings"] = settingsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TonePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<ToneGetResponse> ToneGet(Expression<Func<string>> toneId)
        {
            var apiCallPath = String.Format("/v1/tones/{0}", ExpressionConverter.ConvertWithUrlEncoding(toneId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ToneGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonePatchResponse> TonePatch(Expression<Func<string>> toneId, Expression<Func<string>> bodysettingsappVisibility = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/v1/tones/{0}", ExpressionConverter.ConvertWithUrlEncoding(toneId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsappVisibility != null)
            {
                settingsObject["appVisibility"] = ExpressionConverter.ConvertO(bodysettingsappVisibility);
                settingsObjectpropCount++;
            }

            if (settingsObjectpropCount > 0)
            {
                body["settings"] = settingsObject;
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TonePatchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<ToneDeleteResponse> ToneDelete(Expression<Func<string>> toneId)
        {
            var apiCallPath = String.Format("/v1/tones/{0}", ExpressionConverter.ConvertWithUrlEncoding(toneId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ToneDeleteResponse>(callPayload);
        }
    }

    public class JasperipTriggers([ConnectionName] string connectionId)
    {
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

    public enum bodyoptionsinputLanguageInput
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    public enum bodyoptionsoutputLanguageInput
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    public enum bodyoptionslanguageFormalityInput
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

    public enum bodysettingsappVisibilityInput
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