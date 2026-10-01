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
        public IBodyWorkflowAction<DocumentPolicyResult> ApplyRules([WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<PolicyRule[]> bodyrules = null, [WorkflowExpression] Func<string> bodyrecognitionMode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document-ai/document/analyze/enforce-policy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputFile != null)
                {
                    body["InputFile"] = SourceExpressionConverter.ConvertToken(bodyinputFile);
                    bodypropCount++;
                }

                if (bodyrules != null)
                {
                    body["Rules"] = SourceExpressionConverter.ConvertToken(bodyrules);
                    bodypropCount++;
                }

                if (bodyrecognitionMode != null)
                {
                    body["RecognitionMode"] = SourceExpressionConverter.ConvertToken(bodyrecognitionMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentPolicyResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentQuestionAnswersResult> AnswerQuestions([WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<DocumentQuestionBoolean[]> bodyquestionsYesNo = null, [WorkflowExpression] Func<DocumentQuestionMultipleChoice[]> bodyquestionsMultipleChoice = null, [WorkflowExpression] Func<DocumentQuestionFreeResponse[]> bodyquestionsFreeResponse = null, [WorkflowExpression] Func<string> bodyrecognitionMode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document-ai/document/analyze/answer-questions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputFile != null)
                {
                    body["InputFile"] = SourceExpressionConverter.ConvertToken(bodyinputFile);
                    bodypropCount++;
                }

                if (bodyquestionsYesNo != null)
                {
                    body["QuestionsYesNo"] = SourceExpressionConverter.ConvertToken(bodyquestionsYesNo);
                    bodypropCount++;
                }

                if (bodyquestionsMultipleChoice != null)
                {
                    body["QuestionsMultipleChoice"] = SourceExpressionConverter.ConvertToken(bodyquestionsMultipleChoice);
                    bodypropCount++;
                }

                if (bodyquestionsFreeResponse != null)
                {
                    body["QuestionsFreeResponse"] = SourceExpressionConverter.ConvertToken(bodyquestionsFreeResponse);
                    bodypropCount++;
                }

                if (bodyrecognitionMode != null)
                {
                    body["RecognitionMode"] = SourceExpressionConverter.ConvertToken(bodyrecognitionMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentQuestionAnswersResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractFieldsAdvancedResponse> ExtractFieldsAdvanced([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<FieldToExtract[]> bodyfieldsToExtract = null, [WorkflowExpression] Func<int> bodymaximumPagesProcessed = null, [WorkflowExpression] Func<string> bodypreprocessing = null, [WorkflowExpression] Func<string> bodyresultCrossCheck = null, [WorkflowExpression] Func<double> bodyrotateImageDegrees = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document-ai/document/extract/fields/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = SourceExpressionConverter.ConvertO(recognitionMode);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputFile != null)
                {
                    body["InputFile"] = SourceExpressionConverter.ConvertToken(bodyinputFile);
                    bodypropCount++;
                }

                if (bodyfieldsToExtract != null)
                {
                    body["FieldsToExtract"] = SourceExpressionConverter.ConvertToken(bodyfieldsToExtract);
                    bodypropCount++;
                }

                if (bodymaximumPagesProcessed != null)
                {
                    body["MaximumPagesProcessed"] = SourceExpressionConverter.ConvertToken(bodymaximumPagesProcessed);
                    bodypropCount++;
                }

                if (bodypreprocessing != null)
                {
                    body["Preprocessing"] = SourceExpressionConverter.ConvertToken(bodypreprocessing);
                    bodypropCount++;
                }

                if (bodyresultCrossCheck != null)
                {
                    body["ResultCrossCheck"] = SourceExpressionConverter.ConvertToken(bodyresultCrossCheck);
                    bodypropCount++;
                }

                if (bodyrotateImageDegrees != null)
                {
                    body["RotateImageDegrees"] = SourceExpressionConverter.ConvertToken(bodyrotateImageDegrees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExtractFieldsAdvancedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentAdvancedClassificationResult> ExtractClassificationAdvanced([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<DocumentCategories[]> bodycategories = null, [WorkflowExpression] Func<string> bodypreprocessing = null, [WorkflowExpression] Func<string> bodyresultCrossCheck = null, [WorkflowExpression] Func<int> bodymaximumPagesProcessed = null, [WorkflowExpression] Func<double> bodyrotateImageDegrees = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document-ai/document/extract/classify/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = SourceExpressionConverter.ConvertO(recognitionMode);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputFile != null)
                {
                    body["InputFile"] = SourceExpressionConverter.ConvertToken(bodyinputFile);
                    bodypropCount++;
                }

                if (bodycategories != null)
                {
                    body["Categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                    bodypropCount++;
                }

                if (bodypreprocessing != null)
                {
                    body["Preprocessing"] = SourceExpressionConverter.ConvertToken(bodypreprocessing);
                    bodypropCount++;
                }

                if (bodyresultCrossCheck != null)
                {
                    body["ResultCrossCheck"] = SourceExpressionConverter.ConvertToken(bodyresultCrossCheck);
                    bodypropCount++;
                }

                if (bodymaximumPagesProcessed != null)
                {
                    body["MaximumPagesProcessed"] = SourceExpressionConverter.ConvertToken(bodymaximumPagesProcessed);
                    bodypropCount++;
                }

                if (bodyrotateImageDegrees != null)
                {
                    body["RotateImageDegrees"] = SourceExpressionConverter.ConvertToken(bodyrotateImageDegrees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentAdvancedClassificationResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractFieldsFromDocumentAdvancedBatchJob([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<FieldToExtract[]> bodyfieldsToExtract = null, [WorkflowExpression] Func<int> bodymaximumPagesProcessed = null, [WorkflowExpression] Func<string> bodypreprocessing = null, [WorkflowExpression] Func<string> bodyresultCrossCheck = null, [WorkflowExpression] Func<double> bodyrotateImageDegrees = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/fields/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = SourceExpressionConverter.ConvertO(recognitionMode);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputFile != null)
                {
                    body["InputFile"] = SourceExpressionConverter.ConvertToken(bodyinputFile);
                    bodypropCount++;
                }

                if (bodyfieldsToExtract != null)
                {
                    body["FieldsToExtract"] = SourceExpressionConverter.ConvertToken(bodyfieldsToExtract);
                    bodypropCount++;
                }

                if (bodymaximumPagesProcessed != null)
                {
                    body["MaximumPagesProcessed"] = SourceExpressionConverter.ConvertToken(bodymaximumPagesProcessed);
                    bodypropCount++;
                }

                if (bodypreprocessing != null)
                {
                    body["Preprocessing"] = SourceExpressionConverter.ConvertToken(bodypreprocessing);
                    bodypropCount++;
                }

                if (bodyresultCrossCheck != null)
                {
                    body["ResultCrossCheck"] = SourceExpressionConverter.ConvertToken(bodyresultCrossCheck);
                    bodypropCount++;
                }

                if (bodyrotateImageDegrees != null)
                {
                    body["RotateImageDegrees"] = SourceExpressionConverter.ConvertToken(bodyrotateImageDegrees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExtractDocumentBatchJobResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentJobStatusResult> GetAsyncJobStatus([WorkflowExpression] Func<string> asyncJobId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document-ai/document/batch-job/batch-job/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (asyncJobId != null)
                    callPayload.Queries["AsyncJobID"] = SourceExpressionConverter.ConvertO(asyncJobId);
                return callPayload;
            }

            return new ApiConnectionAction<ExtractDocumentJobStatusResult>(BuildSourceInput);
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

    public class ExtractFieldsAndTablesResponse
    {
        public bool Successful { get; set; }
        public FieldValue[] FieldResults { get; set; }
        public TableResult[] TableResults { get; set; }
    }

    public class FieldValue
    {
        public string FieldName { get; set; }
        public string FieldStringValue { get; set; }
        public string[] AdditionalFieldStringValues { get; set; }
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

    public class ExtractFieldsResponse
    {
        public bool Successful { get; set; }
        public FieldValue[] Results { get; set; }
    }

    public class DocumentClassificationResult
    {
        public bool Successful { get; set; }
        public string DocumentCategoryResult { get; set; }
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