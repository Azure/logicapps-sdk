//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docugenerate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocugenerateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<ListTemplatesResponseItem[]> ListTemplates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTemplatesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<GetTemplateResponse> GetTemplate([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/template/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IWorkflowAction DeleteTemplate([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/template/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<ListDocumentsResponseItem[]> ListDocuments([WorkflowExpression] Func<string> templateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                return callPayload;
            }

            return new ApiConnectionAction<ListDocumentsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<GenerateDocumentResponse> GenerateDocument([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyoutputFormat != null)
                {
                    if (bodyoutputFormat != null)
                    {
                        body["output_format"] = SourceExpressionConverter.Convert(bodyoutputFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<GenerateDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugenerate")]
        public IBodyWorkflowAction<UpdateDocumentResponse> UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDocumentResponse>(BuildSourceInput);
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