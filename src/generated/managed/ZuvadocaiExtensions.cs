//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zuvadocai
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZuvadocaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<SubmitFileResponse, ApiConnectionActionConfiguration> SubmitFile(Expression<Func<string>> @file = null)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: false);
            return new DeferredBodyAction<SubmitFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_file);
                return new ApiConnectionAction<SubmitFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/files/{0}", __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateOcrRequestResponse, ApiConnectionActionConfiguration> CreateOcrRequest(Expression<Func<string>> fileIdBodyfileId = null)
        {
            var __workflow_fileIdBodyfileId = WorkflowExpression.Compile(fileIdBodyfileId, nameof(fileIdBodyfileId), required: false);
            return new DeferredBodyAction<CreateOcrRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (__workflow_fileIdBodyfileId != null)
                {
                    fileIdBody["file_id"] = ExpressionConverter.ConvertO(__workflow_fileIdBodyfileId);
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
        public IBodyWorkflowAction<GetOcrRequestStatusResponse, ApiConnectionActionConfiguration> GetOcrRequestStatus(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetOcrRequestStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ocr/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOcrRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetOcrRequestTextResponse, ApiConnectionActionConfiguration> GetOcrRequestText(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetOcrRequestTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ocr/{0}/text", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOcrRequestTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetOcrRequestImages(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ocr/{0}/images", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetFieldListResponseItem[], ApiConnectionActionConfiguration> GetFieldList()
        {
            return new DeferredBodyAction<GetFieldListResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFieldListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateFieldExtractionRequestResponse, ApiConnectionActionConfiguration> CreateFieldExtractionRequest(Expression<Func<string>> bodyfileId = null, Expression<Func<string[]>> bodyfieldIDs = null)
        {
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodyfieldIDs = WorkflowExpression.Compile(bodyfieldIDs, nameof(bodyfieldIDs), required: false);
            return new DeferredBodyAction<CreateFieldExtractionRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/extraction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldIDs != null)
                {
                    body["field_ids"] = ExpressionConverter.ConvertO(__workflow_bodyfieldIDs);
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
        public IBodyWorkflowAction<GetFieldExtractionRequestStatusResponse, ApiConnectionActionConfiguration> GetFieldExtractionRequestStatus(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetFieldExtractionRequestStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/extraction/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFieldExtractionRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<GetFieldExtractionRequestResultsResponse, ApiConnectionActionConfiguration> GetFieldExtractionRequestResults(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetFieldExtractionRequestResultsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/extraction/{0}/results/text", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFieldExtractionRequestResultsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateDocumentClassificationRequestResponse, ApiConnectionActionConfiguration> CreateDocumentClassificationRequest(Expression<Func<string>> fileIdBodyfileId = null)
        {
            var __workflow_fileIdBodyfileId = WorkflowExpression.Compile(fileIdBodyfileId, nameof(fileIdBodyfileId), required: false);
            return new DeferredBodyAction<CreateDocumentClassificationRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/classification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (__workflow_fileIdBodyfileId != null)
                {
                    fileIdBody["file_id"] = ExpressionConverter.ConvertO(__workflow_fileIdBodyfileId);
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
        public IBodyWorkflowAction<GetDocumentClassificationRequestStatusResponse, ApiConnectionActionConfiguration> GetDocumentClassificationRequestStatus(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetDocumentClassificationRequestStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/classification/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentClassificationRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateLanguageClassificationRequestResponse, ApiConnectionActionConfiguration> CreateLanguageClassificationRequest(Expression<Func<string>> fileIdBodyfileId = null)
        {
            var __workflow_fileIdBodyfileId = WorkflowExpression.Compile(fileIdBodyfileId, nameof(fileIdBodyfileId), required: false);
            return new DeferredBodyAction<CreateLanguageClassificationRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/language";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (__workflow_fileIdBodyfileId != null)
                {
                    fileIdBody["file_id"] = ExpressionConverter.ConvertO(__workflow_fileIdBodyfileId);
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
        public IBodyWorkflowAction<GetLanguageClassificationRequestStatusResponse, ApiConnectionActionConfiguration> GetLanguageClassificationRequestStatus(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetLanguageClassificationRequestStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/language/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLanguageClassificationRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<CreateMlcRequestResponse, ApiConnectionActionConfiguration> CreateMlcRequest(Expression<Func<string>> fileIdBodyfileId = null)
        {
            var __workflow_fileIdBodyfileId = WorkflowExpression.Compile(fileIdBodyfileId, nameof(fileIdBodyfileId), required: false);
            return new DeferredBodyAction<CreateMlcRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mlc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileIdBody = new JObject();
                var fileIdBodypropCount = 0;
                if (__workflow_fileIdBodyfileId != null)
                {
                    fileIdBody["file_id"] = ExpressionConverter.ConvertO(__workflow_fileIdBodyfileId);
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
        public IBodyWorkflowAction<GetMlcRequestStatusResponse, ApiConnectionActionConfiguration> GetMlcRequestStatus(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetMlcRequestStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/mlc/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMlcRequestStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zuvadocai")]
        public IBodyWorkflowAction<NormalizeDatesResponse, ApiConnectionActionConfiguration> NormalizeDates(Expression<Func<string>> textBodytext = null)
        {
            var __workflow_textBodytext = WorkflowExpression.Compile(textBodytext, nameof(textBodytext), required: false);
            return new DeferredBodyAction<NormalizeDatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/normalize/date";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var textBody = new JObject();
                var textBodypropCount = 0;
                if (__workflow_textBodytext != null)
                {
                    textBody["text"] = ExpressionConverter.ConvertO(__workflow_textBodytext);
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
        public string FileId { get; set; }

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
        public string OCRRequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

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
        public string RequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }
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
        public string FieldId { get; set; }

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
        public string ExtractionRequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

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
        public string RequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }
    }

    public class GetFieldExtractionRequestResultsResponse
    {
        [JsonProperty("results")]
        public GetFieldExtractionRequestResultsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }
    }

    public class GetFieldExtractionRequestResultsResponseResultsTypeItem
    {
        [JsonProperty("field_id")]
        public string FieldId { get; set; }

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
        public string ClassificationRequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

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
        public string RequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }
    }

    public class CreateLanguageClassificationRequestResponse
    {
        [JsonProperty("request_id")]
        public string LanguageRequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

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
        public string RequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }
    }

    public class CreateMlcRequestResponse
    {
        [JsonProperty("request_id")]
        public string MLCRequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

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
        public string RequestId { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }
    }

    public class NormalizeDatesResponse
    {
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

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