//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zuvadocai
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZuvadocaiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildSubmitFile))]
        public IBodyWorkflowAction<SubmitFileResponse> SubmitFile([WorkflowExpression] Func<string> file = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubmitFileResponse> __BuildSubmitFile(WorkflowExpression<string> file = null)
        {
            WorkflowExpression.Validate(file, nameof(file), required: false);
            return new DeferredBodyAction<SubmitFileResponse>(() =>
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(file);
                return new ApiConnectionAction<SubmitFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IBodyWorkflowAction<string> DeleteFile([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteFile(WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOcrRequest))]
        public IBodyWorkflowAction<CreateOcrRequestResponse> CreateOcrRequest([WorkflowExpression] Func<string> fileIdBodyfileID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateOcrRequestResponse> __BuildCreateOcrRequest(WorkflowExpression<string> fileIdBodyfileID = null)
        {
            WorkflowExpression.Validate(fileIdBodyfileID, nameof(fileIdBodyfileID), required: false);
            return new DeferredBodyAction<CreateOcrRequestResponse>(() =>
            {
                var apiCallPath = "/ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (fileIdBodyfileID != null)
                {
                    fileIdBody["file_id"] = ExpressionConverter.ConvertO(fileIdBodyfileID);
                    fileIdBodypropCount++;
                }

                if (fileIdBodypropCount > 0)
                {
                    callPayload.Body = fileIdBody;
                }

                return new ApiConnectionAction<CreateOcrRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildGetOcrRequestStatus))]
        public IBodyWorkflowAction<GetOcrRequestStatusResponse> GetOcrRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOcrRequestStatusResponse> __BuildGetOcrRequestStatus(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetOcrRequestStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ocr/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOcrRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildGetOcrRequestText))]
        public IBodyWorkflowAction<GetOcrRequestTextResponse> GetOcrRequestText([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOcrRequestTextResponse> __BuildGetOcrRequestText(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetOcrRequestTextResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ocr/{0}/text", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOcrRequestTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildGetOcrRequestImages))]
        public IBodyWorkflowAction<string> GetOcrRequestImages([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetOcrRequestImages(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ocr/{0}/images", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetFieldListResponseItem[]> GetFieldList()
        {
            var apiCallPath = "/fields";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFieldListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFieldExtractionRequest))]
        public IBodyWorkflowAction<CreateFieldExtractionRequestResponse> CreateFieldExtractionRequest([WorkflowExpression] Func<string> bodyfileID = null, [WorkflowExpression] Func<string[]> bodyfieldIDs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFieldExtractionRequestResponse> __BuildCreateFieldExtractionRequest(WorkflowExpression<string> bodyfileID = null, WorkflowExpression<string[]> bodyfieldIDs = null)
        {
            WorkflowExpression.Validate(bodyfileID, nameof(bodyfileID), required: false);
            WorkflowExpression.Validate(bodyfieldIDs, nameof(bodyfieldIDs), required: false);
            return new DeferredBodyAction<CreateFieldExtractionRequestResponse>(() =>
            {
                var apiCallPath = "/extraction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileID != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(bodyfileID);
                    bodypropCount++;
                }

                if (bodyfieldIDs != null)
                {
                    body["field_ids"] = ExpressionConverter.ConvertO(bodyfieldIDs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFieldExtractionRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildGetFieldExtractionRequestStatus))]
        public IBodyWorkflowAction<GetFieldExtractionRequestStatusResponse> GetFieldExtractionRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFieldExtractionRequestStatusResponse> __BuildGetFieldExtractionRequestStatus(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetFieldExtractionRequestStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/extraction/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFieldExtractionRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildGetFieldExtractionRequestResults))]
        public IBodyWorkflowAction<GetFieldExtractionRequestResultsResponse> GetFieldExtractionRequestResults([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFieldExtractionRequestResultsResponse> __BuildGetFieldExtractionRequestResults(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetFieldExtractionRequestResultsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/extraction/{0}/results/text", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFieldExtractionRequestResultsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocumentClassificationRequest))]
        public IBodyWorkflowAction<CreateDocumentClassificationRequestResponse> CreateDocumentClassificationRequest([WorkflowExpression] Func<string> fileIdBodyfileID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocumentClassificationRequestResponse> __BuildCreateDocumentClassificationRequest(WorkflowExpression<string> fileIdBodyfileID = null)
        {
            WorkflowExpression.Validate(fileIdBodyfileID, nameof(fileIdBodyfileID), required: false);
            return new DeferredBodyAction<CreateDocumentClassificationRequestResponse>(() =>
            {
                var apiCallPath = "/classification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (fileIdBodyfileID != null)
                {
                    fileIdBody["file_id"] = ExpressionConverter.ConvertO(fileIdBodyfileID);
                    fileIdBodypropCount++;
                }

                if (fileIdBodypropCount > 0)
                {
                    callPayload.Body = fileIdBody;
                }

                return new ApiConnectionAction<CreateDocumentClassificationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentClassificationRequestStatus))]
        public IBodyWorkflowAction<GetDocumentClassificationRequestStatusResponse> GetDocumentClassificationRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentClassificationRequestStatusResponse> __BuildGetDocumentClassificationRequestStatus(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetDocumentClassificationRequestStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/classification/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentClassificationRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLanguageClassificationRequest))]
        public IBodyWorkflowAction<CreateLanguageClassificationRequestResponse> CreateLanguageClassificationRequest([WorkflowExpression] Func<string> fileIdBodyfileID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateLanguageClassificationRequestResponse> __BuildCreateLanguageClassificationRequest(WorkflowExpression<string> fileIdBodyfileID = null)
        {
            WorkflowExpression.Validate(fileIdBodyfileID, nameof(fileIdBodyfileID), required: false);
            return new DeferredBodyAction<CreateLanguageClassificationRequestResponse>(() =>
            {
                var apiCallPath = "/language";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (fileIdBodyfileID != null)
                {
                    fileIdBody["file_id"] = ExpressionConverter.ConvertO(fileIdBodyfileID);
                    fileIdBodypropCount++;
                }

                if (fileIdBodypropCount > 0)
                {
                    callPayload.Body = fileIdBody;
                }

                return new ApiConnectionAction<CreateLanguageClassificationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildGetLanguageClassificationRequestStatus))]
        public IBodyWorkflowAction<GetLanguageClassificationRequestStatusResponse> GetLanguageClassificationRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLanguageClassificationRequestStatusResponse> __BuildGetLanguageClassificationRequestStatus(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetLanguageClassificationRequestStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/language/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLanguageClassificationRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildCreateMlcRequest))]
        public IBodyWorkflowAction<CreateMlcRequestResponse> CreateMlcRequest([WorkflowExpression] Func<string> fileIdBodyfileID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateMlcRequestResponse> __BuildCreateMlcRequest(WorkflowExpression<string> fileIdBodyfileID = null)
        {
            WorkflowExpression.Validate(fileIdBodyfileID, nameof(fileIdBodyfileID), required: false);
            return new DeferredBodyAction<CreateMlcRequestResponse>(() =>
            {
                var apiCallPath = "/mlc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (fileIdBodyfileID != null)
                {
                    fileIdBody["file_id"] = ExpressionConverter.ConvertO(fileIdBodyfileID);
                    fileIdBodypropCount++;
                }

                if (fileIdBodypropCount > 0)
                {
                    callPayload.Body = fileIdBody;
                }

                return new ApiConnectionAction<CreateMlcRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildGetMlcRequestStatus))]
        public IBodyWorkflowAction<GetMlcRequestStatusResponse> GetMlcRequestStatus([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMlcRequestStatusResponse> __BuildGetMlcRequestStatus(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetMlcRequestStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/mlc/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMlcRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        [WorkflowExpressionFactory(nameof(__BuildNormalizeDates))]
        public IBodyWorkflowAction<NormalizeDatesResponse> NormalizeDates([WorkflowExpression] Func<string> textBodytext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NormalizeDatesResponse> __BuildNormalizeDates(WorkflowExpression<string> textBodytext = null)
        {
            WorkflowExpression.Validate(textBodytext, nameof(textBodytext), required: false);
            return new DeferredBodyAction<NormalizeDatesResponse>(() =>
            {
                var apiCallPath = "/normalize/date";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var textBody = new JObject();
                var textBodypropCount = 0;
                if (textBodytext != null)
                {
                    textBody["text"] = ExpressionConverter.ConvertO(textBodytext);
                    textBodypropCount++;
                }

                if (textBodypropCount > 0)
                {
                    callPayload.Body = textBody;
                }

                return new ApiConnectionAction<NormalizeDatesResponse>(callPayload);
            });
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