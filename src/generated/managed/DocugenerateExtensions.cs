//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docugenerate
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildGetTemplate))]
        public IBodyWorkflowAction<GetTemplateResponse> GetTemplate([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTemplateResponse> __BuildGetTemplate(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/template/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTemplate))]
        public IWorkflowAction DeleteTemplate([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTemplate(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/template/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [WorkflowExpressionFactory(nameof(__BuildListDocuments))]
        public IBodyWorkflowAction<ListDocumentsResponseItem[]> ListDocuments([WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListDocumentsResponseItem[]> __BuildListDocuments(WorkflowExpression<string> templateId)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<ListDocumentsResponseItem[]>(() =>
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                return new ApiConnectionAction<ListDocumentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateDocument))]
        public IBodyWorkflowAction<GenerateDocumentResponse> GenerateDocument([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateDocumentResponse> __BuildGenerateDocument(WorkflowExpression<string> bodytemplateId, WorkflowExpression<string> bodydata, WorkflowExpression<string> bodyname = null, WorkflowExpression<bodyoutputFormatInput> bodyoutputFormat = null)
        {
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            return new DeferredBodyAction<GenerateDocumentResponse>(() =>
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyoutputFormat != null)
                {
                    if (bodyoutputFormat != null)
                    {
                        body["output_format"] = ExpressionConverter.ConvertO(bodyoutputFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDocument))]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentResponse> __BuildGetDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocument))]
        public IBodyWorkflowAction<UpdateDocumentResponse> UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateDocumentResponse> __BuildUpdateDocument(WorkflowExpression<string> id, WorkflowExpression<string> bodyname = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<UpdateDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
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