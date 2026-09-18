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
        public IBodyWorkflowAction<SubmitFileResponse> SubmitFile([WorkflowExpression] Func<string> file = null)
        {
            var apiCallPath = "/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(file);
            return new ApiConnectionAction<SubmitFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<string> DeleteFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fileId)
        {
            var apiCallPath = String.Format("/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateOcrRequestResponse> CreateOcrRequest([WorkflowExpression] Func<string> fileIdBodyfileID = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetOcrRequestStatusResponse> GetOcrRequestStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestId)
        {
            var apiCallPath = String.Format("/ocr/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetOcrRequestStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetOcrRequestTextResponse> GetOcrRequestText([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestId)
        {
            var apiCallPath = String.Format("/ocr/{0}/text", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetOcrRequestTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<string> GetOcrRequestImages([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestId)
        {
            var apiCallPath = String.Format("/ocr/{0}/images", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
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
        public IBodyWorkflowAction<CreateFieldExtractionRequestResponse> CreateFieldExtractionRequest([WorkflowExpression] Func<string> bodyfileID = null, [WorkflowExpression] Func<string[]> bodyfieldIDs = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetFieldExtractionRequestStatusResponse> GetFieldExtractionRequestStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestId)
        {
            var apiCallPath = String.Format("/extraction/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFieldExtractionRequestStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetFieldExtractionRequestResultsResponse> GetFieldExtractionRequestResults([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestId)
        {
            var apiCallPath = String.Format("/extraction/{0}/results/text", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFieldExtractionRequestResultsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateDocumentClassificationRequestResponse> CreateDocumentClassificationRequest([WorkflowExpression] Func<string> fileIdBodyfileID = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetDocumentClassificationRequestStatusResponse> GetDocumentClassificationRequestStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestId)
        {
            var apiCallPath = String.Format("/classification/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentClassificationRequestStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateLanguageClassificationRequestResponse> CreateLanguageClassificationRequest([WorkflowExpression] Func<string> fileIdBodyfileID = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetLanguageClassificationRequestStatusResponse> GetLanguageClassificationRequestStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestId)
        {
            var apiCallPath = String.Format("/language/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetLanguageClassificationRequestStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateMlcRequestResponse> CreateMlcRequest([WorkflowExpression] Func<string> fileIdBodyfileID = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetMlcRequestStatusResponse> GetMlcRequestStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestId)
        {
            var apiCallPath = String.Format("/mlc/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMlcRequestStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<NormalizeDatesResponse> NormalizeDates([WorkflowExpression] Func<string> textBodytext = null)
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