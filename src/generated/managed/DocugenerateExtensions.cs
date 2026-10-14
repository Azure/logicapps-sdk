//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docugenerate
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DocugenerateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<ListTemplatesResponseItem[]> ListTemplates()
        {
            var apiCallPath = "/template";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTemplatesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<GetTemplateResponse> GetTemplate(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<GetTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/template/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IWorkflowAction DeleteTemplate(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/template/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<ListDocumentsResponseItem[]> ListDocuments(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<ListDocumentsResponseItem[]>(() =>
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                return new ApiConnectionAction<ListDocumentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<GenerateDocumentResponse> GenerateDocument(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodydata, Expression<Func<string>> bodyname = null, Expression<Func<bodyoutputFormatInput>> bodyoutputFormat = null)
        {
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodydata = bodydata == null ? null : WorkflowExpression.Compile(bodydata);
            WorkflowExpression.Validate(__workflow_bodydata, nameof(bodydata), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyoutputFormat = bodyoutputFormat == null ? null : WorkflowExpression.Compile(bodyoutputFormat);
            WorkflowExpression.Validate(__workflow_bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            return new DeferredBodyAction<GenerateDocumentResponse>(() =>
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyoutputFormat != null)
                {
                    if (__workflow_bodyoutputFormat != null)
                    {
                        body["output_format"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["output_format"] = ".pdf";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<UpdateDocumentResponse> UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> bodyname = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<UpdateDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateDocumentResponse>(callPayload);
            });
        }
    }

    public class DocugenerateTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListTemplatesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("page_count")]
        public int PageCount { get; set; }

        [JsonProperty("delimiters")]
        public ListTemplatesResponseItemDelimitersType Delimiters { get; set; }

        [JsonProperty("tags")]
        public ListTemplatesResponseItemTagsType Tags { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("template_uri")]
        public string TemplateUri { get; set; }

        [JsonProperty("preview_uri")]
        public string PreviewUri { get; set; }

        [JsonProperty("image_uri")]
        public string ImageUri { get; set; }

        [JsonProperty("enhanced_syntax")]
        public bool EnhancedSyntax { get; set; }

        [JsonProperty("versioning_enabled")]
        public bool VersioningEnabled { get; set; }
    }

    public class ListTemplatesResponseItemDelimitersType
    {
        [JsonProperty("left")]
        public string Left { get; set; }

        [JsonProperty("right")]
        public string Right { get; set; }
    }

    public class ListTemplatesResponseItemTagsType
    {
        [JsonProperty("valid")]
        public JToken[] Valid { get; set; }

        [JsonProperty("invalid")]
        public JToken[] Invalid { get; set; }
    }

    public class GetTemplateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("page_count")]
        public int PageCount { get; set; }

        [JsonProperty("delimiters")]
        public GetTemplateResponseDelimitersType Delimiters { get; set; }

        [JsonProperty("tags")]
        public GetTemplateResponseTagsType Tags { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("template_uri")]
        public string TemplateUri { get; set; }

        [JsonProperty("preview_uri")]
        public string PreviewUri { get; set; }

        [JsonProperty("image_uri")]
        public string ImageUri { get; set; }

        [JsonProperty("enhanced_syntax")]
        public bool EnhancedSyntax { get; set; }

        [JsonProperty("versioning_enabled")]
        public bool VersioningEnabled { get; set; }
    }

    public class GetTemplateResponseDelimitersType
    {
        [JsonProperty("left")]
        public string Left { get; set; }

        [JsonProperty("right")]
        public string Right { get; set; }
    }

    public class GetTemplateResponseTagsType
    {
        [JsonProperty("valid")]
        public JToken[] Valid { get; set; }

        [JsonProperty("invalid")]
        public JToken[] Invalid { get; set; }
    }

    public class ListDocumentsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data_length")]
        public int DataLength { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("document_uri")]
        public string DocumentUri { get; set; }
    }

    public class GenerateDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data_length")]
        public int DataLength { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("document_uri")]
        public string DocumentUri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputFormatInput
    {
        [EnumMember(Value = ".docx")]
        Docx,
        [EnumMember(Value = ".doc")]
        Doc,
        [EnumMember(Value = ".odt")]
        Odt,
        [EnumMember(Value = ".txt")]
        Txt,
        [EnumMember(Value = ".html")]
        Html,
        [EnumMember(Value = ".png")]
        Png,
        [EnumMember(Value = ".pdf")]
        Pdf
    }

    public class GetDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data_length")]
        public int DataLength { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("document_uri")]
        public string DocumentUri { get; set; }
    }

    public class UpdateDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data_length")]
        public int DataLength { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("document_uri")]
        public string DocumentUri { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docugenerate;

    public partial class WorkflowManagedActions
    {
        public DocugenerateActions Docugenerate(string connectionId) => new DocugenerateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocugenerateTriggers Docugenerate(string connectionId) => new DocugenerateTriggers(connectionId);
    }
}
