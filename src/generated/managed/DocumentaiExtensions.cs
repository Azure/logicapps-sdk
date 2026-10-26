//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentai
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentPolicyResult, ApiConnectionActionConfiguration> ApplyRules(Expression<Func<ApplyRulesInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DocumentPolicyResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document-ai/document/analyze/enforce-policy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocumentPolicyResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentQuestionAnswersResult, ApiConnectionActionConfiguration> AnswerQuestions(Expression<Func<AnswerQuestionsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DocumentQuestionAnswersResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document-ai/document/analyze/answer-questions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocumentQuestionAnswersResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractFieldsAdvancedResponse, ApiConnectionActionConfiguration> ExtractFieldsAdvanced(Expression<Func<string>> recognitionMode = null, Expression<Func<ExtractFieldsAdvancedInput>> body = null)
        {
            var __workflow_recognitionMode = WorkflowExpression.Compile(recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractFieldsAdvancedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/fields/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractFieldsAdvancedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentAdvancedClassificationResult, ApiConnectionActionConfiguration> ExtractClassificationAdvanced(Expression<Func<string>> recognitionMode = null, Expression<Func<ExtractClassificationAdvancedInput>> body = null)
        {
            var __workflow_recognitionMode = WorkflowExpression.Compile(recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DocumentAdvancedClassificationResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/classify/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocumentAdvancedClassificationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult, ApiConnectionActionConfiguration> ExtractFieldsFromDocumentAdvancedBatchJob(Expression<Func<string>> recognitionMode = null, Expression<Func<ExtractFieldsFromDocumentAdvancedBatchJobInput>> body = null)
        {
            var __workflow_recognitionMode = WorkflowExpression.Compile(recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/fields/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentJobStatusResult, ApiConnectionActionConfiguration> GetAsyncJobStatus(Expression<Func<string>> asyncJobId = null)
        {
            var __workflow_asyncJobId = WorkflowExpression.Compile(asyncJobId, nameof(asyncJobId), required: false);
            return new DeferredBodyAction<ExtractDocumentJobStatusResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/batch-job/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_asyncJobId != null)
                    callPayload.Queries["AsyncJobID"] = ExpressionConverter.Convert(__workflow_asyncJobId);
                return new ApiConnectionAction<ExtractDocumentJobStatusResult>(callPayload);
            });
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

    public class ApplyRulesInput
    {
        public string InputFile { get; set; }
        public PolicyRule[] Rules { get; set; }
        public string RecognitionMode { get; set; }
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

    public class AnswerQuestionsInput
    {
        public string InputFile { get; set; }
        public DocumentQuestionBoolean[] QuestionsYesNo { get; set; }
        public DocumentQuestionMultipleChoice[] QuestionsMultipleChoice { get; set; }
        public DocumentQuestionFreeResponse[] QuestionsFreeResponse { get; set; }
        public string RecognitionMode { get; set; }
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

    public class ExtractFieldsAdvancedInput
    {
        public string InputFile { get; set; }
        public FieldToExtract[] FieldsToExtract { get; set; }
        public int? MaximumPagesProcessed { get; set; }
        public string Preprocessing { get; set; }
        public string ResultCrossCheck { get; set; }
        public double? RotateImageDegrees { get; set; }
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

    public class ExtractClassificationAdvancedInput
    {
        public string InputFile { get; set; }
        public DocumentCategories[] Categories { get; set; }
        public string Preprocessing { get; set; }
        public string ResultCrossCheck { get; set; }
        public int? MaximumPagesProcessed { get; set; }
        public double? RotateImageDegrees { get; set; }
    }

    public class DocumentCategories
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }

    public class ExtractDocumentBatchJobResult
    {
        public bool Successful { get; set; }

        [JsonProperty("AsyncJobID")]
        public string AsyncJobId { get; set; }
    }

    public class ExtractFieldsFromDocumentAdvancedBatchJobInput
    {
        public string InputFile { get; set; }
        public FieldToExtract[] FieldsToExtract { get; set; }
        public int? MaximumPagesProcessed { get; set; }
        public string Preprocessing { get; set; }
        public string ResultCrossCheck { get; set; }
        public double? RotateImageDegrees { get; set; }
    }

    public class ExtractDocumentJobStatusResult
    {
        public bool Successful { get; set; }
        public string AsyncJobStatus { get; set; }

        [JsonProperty("AsyncJobID")]
        public string AsyncJobId { get; set; }
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