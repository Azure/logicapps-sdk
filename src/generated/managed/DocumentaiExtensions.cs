//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentPolicyResult> ApplyRules(Expression<Func<string>> bodyinputFile = null, Expression<Func<PolicyRule[]>> bodyrules = null, Expression<Func<string>> bodyrecognitionMode = null)
        {
            var apiCallPath = "/document-ai/document/analyze/enforce-policy";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputFile != null)
            {
                body["InputFile"] = ExpressionConverter.ConvertO(bodyinputFile);
                bodypropCount++;
            }

            if (bodyrules != null)
            {
                body["Rules"] = ExpressionConverter.ConvertO(bodyrules);
                bodypropCount++;
            }

            if (bodyrecognitionMode != null)
            {
                body["RecognitionMode"] = ExpressionConverter.ConvertO(bodyrecognitionMode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DocumentPolicyResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentQuestionAnswersResult> AnswerQuestions(Expression<Func<string>> bodyinputFile = null, Expression<Func<DocumentQuestionBoolean[]>> bodyquestionsYesNo = null, Expression<Func<DocumentQuestionMultipleChoice[]>> bodyquestionsMultipleChoice = null, Expression<Func<DocumentQuestionFreeResponse[]>> bodyquestionsFreeResponse = null, Expression<Func<string>> bodyrecognitionMode = null)
        {
            var apiCallPath = "/document-ai/document/analyze/answer-questions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputFile != null)
            {
                body["InputFile"] = ExpressionConverter.ConvertO(bodyinputFile);
                bodypropCount++;
            }

            if (bodyquestionsYesNo != null)
            {
                body["QuestionsYesNo"] = ExpressionConverter.ConvertO(bodyquestionsYesNo);
                bodypropCount++;
            }

            if (bodyquestionsMultipleChoice != null)
            {
                body["QuestionsMultipleChoice"] = ExpressionConverter.ConvertO(bodyquestionsMultipleChoice);
                bodypropCount++;
            }

            if (bodyquestionsFreeResponse != null)
            {
                body["QuestionsFreeResponse"] = ExpressionConverter.ConvertO(bodyquestionsFreeResponse);
                bodypropCount++;
            }

            if (bodyrecognitionMode != null)
            {
                body["RecognitionMode"] = ExpressionConverter.ConvertO(bodyrecognitionMode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DocumentQuestionAnswersResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractTextResponse> ExtractText(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/extract/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<ExtractTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractFieldsResponse> ExtractFields(Expression<Func<string>> fieldNames = null, Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/extract/fields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fieldNames != null)
                callPayload.Headers["FieldNames"] = ExpressionConverter.Convert(fieldNames);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<ExtractFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractFieldsAdvancedResponse> ExtractFieldsAdvanced(Expression<Func<string>> recognitionMode = null, Expression<Func<string>> bodyinputFile = null, Expression<Func<FieldToExtract[]>> bodyfieldsToExtract = null, Expression<Func<int>> bodymaximumPagesProcessed = null, Expression<Func<string>> bodypreprocessing = null, Expression<Func<string>> bodyresultCrossCheck = null, Expression<Func<double>> bodyrotateImageDegrees = null)
        {
            var apiCallPath = "/document-ai/document/extract/fields/advanced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputFile != null)
            {
                body["InputFile"] = ExpressionConverter.ConvertO(bodyinputFile);
                bodypropCount++;
            }

            if (bodyfieldsToExtract != null)
            {
                body["FieldsToExtract"] = ExpressionConverter.ConvertO(bodyfieldsToExtract);
                bodypropCount++;
            }

            if (bodymaximumPagesProcessed != null)
            {
                body["MaximumPagesProcessed"] = ExpressionConverter.ConvertO(bodymaximumPagesProcessed);
                bodypropCount++;
            }

            if (bodypreprocessing != null)
            {
                body["Preprocessing"] = ExpressionConverter.ConvertO(bodypreprocessing);
                bodypropCount++;
            }

            if (bodyresultCrossCheck != null)
            {
                body["ResultCrossCheck"] = ExpressionConverter.ConvertO(bodyresultCrossCheck);
                bodypropCount++;
            }

            if (bodyrotateImageDegrees != null)
            {
                body["RotateImageDegrees"] = ExpressionConverter.ConvertO(bodyrotateImageDegrees);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractFieldsAdvancedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractTablesResponse> ExtractTables(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/extract/tables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<ExtractTablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractBarcodesAiResponse> ExtractBarcodes(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/extract/barcodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<ExtractBarcodesAiResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractFieldsAndTablesResponse> ExtractAllFieldsAndTables(Expression<Func<string>> recognitionMode = null, Expression<Func<string>> preprocessing = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/extract/all";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            if (preprocessing != null)
                callPayload.Headers["preprocessing"] = ExpressionConverter.Convert(preprocessing);
            return new ApiConnectionAction<ExtractFieldsAndTablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentClassificationResult> ExtractClassification(Expression<Func<string>> categories = null, Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/extract/classify";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (categories != null)
                callPayload.Headers["Categories"] = ExpressionConverter.Convert(categories);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<DocumentClassificationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentAdvancedClassificationResult> ExtractClassificationAdvanced(Expression<Func<string>> recognitionMode = null, Expression<Func<string>> bodyinputFile = null, Expression<Func<DocumentCategories[]>> bodycategories = null, Expression<Func<string>> bodypreprocessing = null, Expression<Func<string>> bodyresultCrossCheck = null, Expression<Func<int>> bodymaximumPagesProcessed = null, Expression<Func<double>> bodyrotateImageDegrees = null)
        {
            var apiCallPath = "/document-ai/document/extract/classify/advanced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputFile != null)
            {
                body["InputFile"] = ExpressionConverter.ConvertO(bodyinputFile);
                bodypropCount++;
            }

            if (bodycategories != null)
            {
                body["Categories"] = ExpressionConverter.ConvertO(bodycategories);
                bodypropCount++;
            }

            if (bodypreprocessing != null)
            {
                body["Preprocessing"] = ExpressionConverter.ConvertO(bodypreprocessing);
                bodypropCount++;
            }

            if (bodyresultCrossCheck != null)
            {
                body["ResultCrossCheck"] = ExpressionConverter.ConvertO(bodyresultCrossCheck);
                bodypropCount++;
            }

            if (bodymaximumPagesProcessed != null)
            {
                body["MaximumPagesProcessed"] = ExpressionConverter.ConvertO(bodymaximumPagesProcessed);
                bodypropCount++;
            }

            if (bodyrotateImageDegrees != null)
            {
                body["RotateImageDegrees"] = ExpressionConverter.ConvertO(bodyrotateImageDegrees);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DocumentAdvancedClassificationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<SummarizeDocumentResponse> ExtractSummary(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/extract/summary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<SummarizeDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractTextFromDocumentBatchJob(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/batch-job/extract/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractFieldsFromDocumentAdvancedBatchJob(Expression<Func<string>> recognitionMode = null, Expression<Func<string>> bodyinputFile = null, Expression<Func<FieldToExtract[]>> bodyfieldsToExtract = null, Expression<Func<int>> bodymaximumPagesProcessed = null, Expression<Func<string>> bodypreprocessing = null, Expression<Func<string>> bodyresultCrossCheck = null, Expression<Func<double>> bodyrotateImageDegrees = null)
        {
            var apiCallPath = "/document-ai/document/batch-job/extract/fields/advanced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputFile != null)
            {
                body["InputFile"] = ExpressionConverter.ConvertO(bodyinputFile);
                bodypropCount++;
            }

            if (bodyfieldsToExtract != null)
            {
                body["FieldsToExtract"] = ExpressionConverter.ConvertO(bodyfieldsToExtract);
                bodypropCount++;
            }

            if (bodymaximumPagesProcessed != null)
            {
                body["MaximumPagesProcessed"] = ExpressionConverter.ConvertO(bodymaximumPagesProcessed);
                bodypropCount++;
            }

            if (bodypreprocessing != null)
            {
                body["Preprocessing"] = ExpressionConverter.ConvertO(bodypreprocessing);
                bodypropCount++;
            }

            if (bodyresultCrossCheck != null)
            {
                body["ResultCrossCheck"] = ExpressionConverter.ConvertO(bodyresultCrossCheck);
                bodypropCount++;
            }

            if (bodyrotateImageDegrees != null)
            {
                body["RotateImageDegrees"] = ExpressionConverter.ConvertO(bodyrotateImageDegrees);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractAllFieldsAndTablesFromDocumentBatchJob(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/batch-job/extract/all";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractClassificationFromDocumentBatchJob(Expression<Func<string>> categories = null, Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var apiCallPath = "/document-ai/document/batch-job/extract/classify";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (categories != null)
                callPayload.Headers["Categories"] = ExpressionConverter.Convert(categories);
            if (recognitionMode != null)
                callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
            return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentJobStatusResult> GetAsyncJobStatus(Expression<Func<string>> asyncJobID = null)
        {
            var apiCallPath = "/document-ai/document/batch-job/batch-job/status";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (asyncJobID != null)
                callPayload.Queries["AsyncJobID"] = ExpressionConverter.Convert(asyncJobID);
            return new ApiConnectionAction<ExtractDocumentJobStatusResult>(callPayload);
        }
    }

    public class DocumentaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class DocumentPolicyResult
    {
        public bool CleanResult { get; set; }
        public double RiskScore { get; set; }
        public PolicyRuleViolation[] RuleViolations { get; set; }
    }

    public class PolicyRuleViolation
    {
        public string RuleId { get; set; }
        public double RuleViolationRiskScore { get; set; }
        public string RuleViolationRationale { get; set; }
    }

    public class PolicyRule
    {
        public string RuleId { get; set; }
        public string RuleType { get; set; }
        public string RuleDescription { get; set; }
    }

    public class DocumentQuestionAnswersResult
    {
        public bool Successful { get; set; }
        public double ConfidenceScore { get; set; }
        public DocumentQuestionAnswerItem[] AnswerResults { get; set; }
    }

    public class DocumentQuestionAnswerItem
    {
        public string QuestionId { get; set; }
        public string AnswerValue { get; set; }
        public string AnswerRationale { get; set; }
        public double ConfidenceScore { get; set; }
    }

    public class DocumentQuestionBoolean
    {
        public string QuestionId { get; set; }
        public string QuestionText { get; set; }
    }

    public class DocumentQuestionMultipleChoice
    {
        public string QuestionId { get; set; }
        public string QuestionText { get; set; }
        public DocumentQuestionChoiceItem[] ResponseChoices { get; set; }
    }

    public class DocumentQuestionChoiceItem
    {
        public string ChoiceId { get; set; }
        public string ChoiceText { get; set; }
    }

    public class DocumentQuestionFreeResponse
    {
        public string QuestionId { get; set; }
        public string QuestionText { get; set; }
    }

    public class ExtractTextResponse
    {
        public bool Successful { get; set; }
        public ExtractedTextPage[] PageResults { get; set; }
    }

    public class ExtractedTextPage
    {
        public int PageNumber { get; set; }
        public string TextResult { get; set; }
    }

    public class ExtractFieldsResponse
    {
        public bool Successful { get; set; }
        public FieldValue[] Results { get; set; }
    }

    public class FieldValue
    {
        public string FieldName { get; set; }
        public string FieldStringValue { get; set; }
        public string[] AdditionalFieldStringValues { get; set; }
    }

    public class ExtractFieldsAdvancedResponse
    {
        public bool Successful { get; set; }
        public FieldAdvancedValue[] Results { get; set; }
        public double ConfidenceScore { get; set; }
    }

    public class FieldAdvancedValue
    {
        public string FieldName { get; set; }
        public string FieldStringValue { get; set; }
    }

    public class FieldToExtract
    {
        public string FieldName { get; set; }
        public bool FieldOptional { get; set; }
        public string FieldDescription { get; set; }
        public string FieldExample { get; set; }
    }

    public class ExtractTablesResponse
    {
        public bool Successful { get; set; }
        public TableResult[] TableResults { get; set; }
    }

    public class TableResult
    {
        public string Title { get; set; }
        public TableResultRow[] Rows { get; set; }
    }

    public class TableResultRow
    {
        public TableResultCell[] Cells { get; set; }
    }

    public class TableResultCell
    {
        public string CellHeader { get; set; }
        public string CellValue { get; set; }
    }

    public class ExtractBarcodesAiResponse
    {
        public bool Successful { get; set; }
        public ExtractedBarcodeItem[] BarcodeResults { get; set; }
    }

    public class ExtractedBarcodeItem
    {
        public string BarcodeType { get; set; }
        public string BarcodeValue { get; set; }
    }

    public class ExtractFieldsAndTablesResponse
    {
        public bool Successful { get; set; }
        public FieldValue[] FieldResults { get; set; }
        public TableResult[] TableResults { get; set; }
    }

    public class DocumentClassificationResult
    {
        public bool Successful { get; set; }
        public string DocumentCategoryResult { get; set; }
    }

    public class DocumentAdvancedClassificationResult
    {
        public bool Successful { get; set; }
        public string DocumentCategoryResult { get; set; }
        public double ConfidenceScore { get; set; }
    }

    public class DocumentCategories
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }

    public class SummarizeDocumentResponse
    {
        public bool Successful { get; set; }
        public string DocumentSummaryText { get; set; }
    }

    public class ExtractDocumentBatchJobResult
    {
        public bool Successful { get; set; }
        public string AsyncJobID { get; set; }
    }

    public class ExtractDocumentJobStatusResult
    {
        public bool Successful { get; set; }
        public string AsyncJobStatus { get; set; }
        public string AsyncJobID { get; set; }
        public ExtractTextResponse ExtractTextResult { get; set; }
        public ExtractFieldsAndTablesResponse ExtractFieldsAndTablesResult { get; set; }
        public ExtractFieldsResponse ExtractFieldsResult { get; set; }
        public DocumentClassificationResult ExtractClassificationResult { get; set; }
        public string ErrorMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentai;

    public partial class WorkflowManagedActions
    {
        public DocumentaiActions Documentai(string connectionId) => new DocumentaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentaiTriggers Documentai(string connectionId) => new DocumentaiTriggers(connectionId);
    }
}