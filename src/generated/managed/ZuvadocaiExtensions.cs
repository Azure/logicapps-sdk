//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zuvadocai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZuvadocaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<SubmitFileResponse> SubmitFile([WorkflowExpression] Func<string> @file = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(@file);
                return callPayload;
            }

            return new ApiConnectionAction<SubmitFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<string> DeleteFile([WorkflowExpression] Func<string> fileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateOcrRequestResponse> CreateOcrRequest([WorkflowExpression] Func<string> fileIdBodyfileId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (fileIdBodyfileId != null)
                {
                    fileIdBody["file_id"] = SourceExpressionConverter.ConvertToken(fileIdBodyfileId);
                    fileIdBodypropCount++;
                }

                if (fileIdBodypropCount > 0)
                {
                    callPayload.Body = fileIdBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateOcrRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetOcrRequestStatusResponse> GetOcrRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ocr/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetOcrRequestStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetOcrRequestTextResponse> GetOcrRequestText([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ocr/{0}/text", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetOcrRequestTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<string> GetOcrRequestImages([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ocr/{0}/images", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetFieldListResponseItem[]> GetFieldList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFieldListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateFieldExtractionRequestResponse> CreateFieldExtractionRequest([WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string[]> bodyfieldIDs = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/extraction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodyfieldIDs != null)
                {
                    body["field_ids"] = SourceExpressionConverter.ConvertToken(bodyfieldIDs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateFieldExtractionRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetFieldExtractionRequestStatusResponse> GetFieldExtractionRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/extraction/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFieldExtractionRequestStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetFieldExtractionRequestResultsResponse> GetFieldExtractionRequestResults([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/extraction/{0}/results/text", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFieldExtractionRequestResultsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateDocumentClassificationRequestResponse> CreateDocumentClassificationRequest([WorkflowExpression] Func<string> fileIdBodyfileId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/classification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (fileIdBodyfileId != null)
                {
                    fileIdBody["file_id"] = SourceExpressionConverter.ConvertToken(fileIdBodyfileId);
                    fileIdBodypropCount++;
                }

                if (fileIdBodypropCount > 0)
                {
                    callPayload.Body = fileIdBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateDocumentClassificationRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetDocumentClassificationRequestStatusResponse> GetDocumentClassificationRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/classification/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentClassificationRequestStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateLanguageClassificationRequestResponse> CreateLanguageClassificationRequest([WorkflowExpression] Func<string> fileIdBodyfileId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/language";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (fileIdBodyfileId != null)
                {
                    fileIdBody["file_id"] = SourceExpressionConverter.ConvertToken(fileIdBodyfileId);
                    fileIdBodypropCount++;
                }

                if (fileIdBodypropCount > 0)
                {
                    callPayload.Body = fileIdBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateLanguageClassificationRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetLanguageClassificationRequestStatusResponse> GetLanguageClassificationRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/language/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetLanguageClassificationRequestStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateMlcRequestResponse> CreateMlcRequest([WorkflowExpression] Func<string> fileIdBodyfileId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mlc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (fileIdBodyfileId != null)
                {
                    fileIdBody["file_id"] = SourceExpressionConverter.ConvertToken(fileIdBodyfileId);
                    fileIdBodypropCount++;
                }

                if (fileIdBodypropCount > 0)
                {
                    callPayload.Body = fileIdBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateMlcRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetMlcRequestStatusResponse> GetMlcRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/mlc/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMlcRequestStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<NormalizeDatesResponse> NormalizeDates([WorkflowExpression] Func<string> textBodytext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/normalize/date";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var textBody = new JObject();
                var textBodypropCount = 0;
                if (textBodytext != null)
                {
                    textBody["text"] = SourceExpressionConverter.ConvertToken(textBodytext);
                    textBodypropCount++;
                }

                if (textBodypropCount > 0)
                {
                    callPayload.Body = textBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NormalizeDatesResponse>(BuildSourceInput);
        }
    }

    public class ZuvadocaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class SubmitFileResponse
    {
        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("attributes")]
        public SubmitFileResponseAttributesType Attributes { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }
    }

    public class SubmitFileResponseAttributesType
    {
        [JsonProperty("content-type")]
        public string ContentType { get; set; }
    }

    public class CreateOcrRequestResponse
    {
        [JsonProperty("request_id")]
        public string OCRRequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetOcrRequestStatusResponse
    {
        [JsonProperty("status")]
        public string OCRRequestStatus { get; set; }

        [JsonProperty("is_finished")]
        public bool IsFinished { get; set; }

        [JsonProperty("request_id")]
        public string RequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }
    }

    public class GetOcrRequestTextResponse
    {
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFieldListResponseItem
    {
        [JsonProperty("field_id")]
        public string FieldID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("bias")]
        public double Bias { get; set; }

        [JsonProperty("f_score")]
        public double FScore { get; set; }

        [JsonProperty("precision")]
        public double Precision { get; set; }

        [JsonProperty("recall")]
        public double Recall { get; set; }

        [JsonProperty("document_count")]
        public int DocumentCount { get; set; }

        [JsonProperty("is_custom")]
        public bool IsCustom { get; set; }

        [JsonProperty("is_trained")]
        public bool IsTrained { get; set; }
    }

    public class CreateFieldExtractionRequestResponse
    {
        [JsonProperty("request_id")]
        public string ExtractionRequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("field_ids")]
        public string[] FieldIDs { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetFieldExtractionRequestStatusResponse
    {
        [JsonProperty("status")]
        public string FieldExtractionRequestStatus { get; set; }

        [JsonProperty("is_finished")]
        public bool IsFinished { get; set; }

        [JsonProperty("request_id")]
        public string RequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }
    }

    public class GetFieldExtractionRequestResultsResponse
    {
        [JsonProperty("results")]
        public GetFieldExtractionRequestResultsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("request_id")]
        public string RequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }
    }

    public class GetFieldExtractionRequestResultsResponseResultsTypeItem
    {
        [JsonProperty("field_id")]
        public string FieldID { get; set; }

        [JsonProperty("extractions")]
        public GetFieldExtractionRequestResultsResponseResultsTypeItemExtractionsTypeItem[] Extractions { get; set; }
    }

    public class GetFieldExtractionRequestResultsResponseResultsTypeItemExtractionsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("spans")]
        public GetFieldExtractionRequestResultsResponseResultsTypeItemExtractionsTypeItemSpansTypeItem[] Spans { get; set; }
    }

    public class GetFieldExtractionRequestResultsResponseResultsTypeItemExtractionsTypeItemSpansTypeItem
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("pages")]
        public GetFieldExtractionRequestResultsResponseResultsTypeItemExtractionsTypeItemSpansTypeItemPagesType Pages { get; set; }
    }

    public class GetFieldExtractionRequestResultsResponseResultsTypeItemExtractionsTypeItemSpansTypeItemPagesType
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class CreateDocumentClassificationRequestResponse
    {
        [JsonProperty("request_id")]
        public string ClassificationRequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetDocumentClassificationRequestStatusResponse
    {
        [JsonProperty("status")]
        public string ClassificationRequestStatus { get; set; }

        [JsonProperty("is_finished")]
        public bool IsFinished { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("is_contract")]
        public bool IsContract { get; set; }

        [JsonProperty("request_id")]
        public string RequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }
    }

    public class CreateLanguageClassificationRequestResponse
    {
        [JsonProperty("request_id")]
        public string LanguageRequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetLanguageClassificationRequestStatusResponse
    {
        [JsonProperty("status")]
        public string LanguageRequestStatus { get; set; }

        [JsonProperty("is_finished")]
        public bool IsFinished { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("request_id")]
        public string RequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }
    }

    public class CreateMlcRequestResponse
    {
        [JsonProperty("request_id")]
        public string MLCRequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetMlcRequestStatusResponse
    {
        [JsonProperty("status")]
        public string MLCRequestStatus { get; set; }

        [JsonProperty("is_finished")]
        public bool IsFinished { get; set; }

        [JsonProperty("classifications")]
        public string[] Classifications { get; set; }

        [JsonProperty("request_id")]
        public string RequestID { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }
    }

    public class NormalizeDatesResponse
    {
        [JsonProperty("request_id")]
        public string RequestID { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("sha-256")]
        public string Sha256 { get; set; }

        [JsonProperty("date")]
        public NormalizeDatesResponseDateTypeItem[] Date { get; set; }
    }

    public class NormalizeDatesResponseDateTypeItem
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zuvadocai;

    public partial class WorkflowManagedActions
    {
        public ZuvadocaiActions Zuvadocai(string connectionId) => new ZuvadocaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZuvadocaiTriggers Zuvadocai(string connectionId) => new ZuvadocaiTriggers(connectionId);
    }
}