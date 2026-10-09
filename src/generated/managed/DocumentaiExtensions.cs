//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentai
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentaiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildApplyRules))]
        public IBodyWorkflowAction<DocumentPolicyResult> ApplyRules([WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<PolicyRule[]> bodyrules = null, [WorkflowExpression] Func<string> bodyrecognitionMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentPolicyResult> __BuildApplyRules(WorkflowExpression<string> bodyinputFile = null, WorkflowExpression<PolicyRule[]> bodyrules = null, WorkflowExpression<string> bodyrecognitionMode = null)
        {
            WorkflowExpression.Validate(bodyinputFile, nameof(bodyinputFile), required: false);
            WorkflowExpression.Validate(bodyrules, nameof(bodyrules), required: false);
            WorkflowExpression.Validate(bodyrecognitionMode, nameof(bodyrecognitionMode), required: false);
            return new DeferredBodyAction<DocumentPolicyResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildAnswerQuestions))]
        public IBodyWorkflowAction<DocumentQuestionAnswersResult> AnswerQuestions([WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<DocumentQuestionBoolean[]> bodyquestionsYesNo = null, [WorkflowExpression] Func<DocumentQuestionMultipleChoice[]> bodyquestionsMultipleChoice = null, [WorkflowExpression] Func<DocumentQuestionFreeResponse[]> bodyquestionsFreeResponse = null, [WorkflowExpression] Func<string> bodyrecognitionMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentQuestionAnswersResult> __BuildAnswerQuestions(WorkflowExpression<string> bodyinputFile = null, WorkflowExpression<DocumentQuestionBoolean[]> bodyquestionsYesNo = null, WorkflowExpression<DocumentQuestionMultipleChoice[]> bodyquestionsMultipleChoice = null, WorkflowExpression<DocumentQuestionFreeResponse[]> bodyquestionsFreeResponse = null, WorkflowExpression<string> bodyrecognitionMode = null)
        {
            WorkflowExpression.Validate(bodyinputFile, nameof(bodyinputFile), required: false);
            WorkflowExpression.Validate(bodyquestionsYesNo, nameof(bodyquestionsYesNo), required: false);
            WorkflowExpression.Validate(bodyquestionsMultipleChoice, nameof(bodyquestionsMultipleChoice), required: false);
            WorkflowExpression.Validate(bodyquestionsFreeResponse, nameof(bodyquestionsFreeResponse), required: false);
            WorkflowExpression.Validate(bodyrecognitionMode, nameof(bodyrecognitionMode), required: false);
            return new DeferredBodyAction<DocumentQuestionAnswersResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractText))]
        public IBodyWorkflowAction<ExtractTextResponse> ExtractText([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractTextResponse> __BuildExtractText(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractTextResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<ExtractTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFields))]
        public IBodyWorkflowAction<ExtractFieldsResponse> ExtractFields([WorkflowExpression] Func<string> fieldNames = null, [WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractFieldsResponse> __BuildExtractFields(WorkflowExpression<string> fieldNames = null, WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(fieldNames, nameof(fieldNames), required: false);
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractFieldsResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fieldNames != null)
                    callPayload.Headers["FieldNames"] = ExpressionConverter.Convert(fieldNames);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<ExtractFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFieldsAdvanced))]
        public IBodyWorkflowAction<ExtractFieldsAdvancedResponse> ExtractFieldsAdvanced([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<FieldToExtract[]> bodyfieldsToExtract = null, [WorkflowExpression] Func<int> bodymaximumPagesProcessed = null, [WorkflowExpression] Func<string> bodypreprocessing = null, [WorkflowExpression] Func<string> bodyresultCrossCheck = null, [WorkflowExpression] Func<double> bodyrotateImageDegrees = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractFieldsAdvancedResponse> __BuildExtractFieldsAdvanced(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<string> bodyinputFile = null, WorkflowExpression<FieldToExtract[]> bodyfieldsToExtract = null, WorkflowExpression<int> bodymaximumPagesProcessed = null, WorkflowExpression<string> bodypreprocessing = null, WorkflowExpression<string> bodyresultCrossCheck = null, WorkflowExpression<double> bodyrotateImageDegrees = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(bodyinputFile, nameof(bodyinputFile), required: false);
            WorkflowExpression.Validate(bodyfieldsToExtract, nameof(bodyfieldsToExtract), required: false);
            WorkflowExpression.Validate(bodymaximumPagesProcessed, nameof(bodymaximumPagesProcessed), required: false);
            WorkflowExpression.Validate(bodypreprocessing, nameof(bodypreprocessing), required: false);
            WorkflowExpression.Validate(bodyresultCrossCheck, nameof(bodyresultCrossCheck), required: false);
            WorkflowExpression.Validate(bodyrotateImageDegrees, nameof(bodyrotateImageDegrees), required: false);
            return new DeferredBodyAction<ExtractFieldsAdvancedResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractTables))]
        public IBodyWorkflowAction<ExtractTablesResponse> ExtractTables([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractTablesResponse> __BuildExtractTables(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractTablesResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<ExtractTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractBarcodes))]
        public IBodyWorkflowAction<ExtractBarcodesAiResponse> ExtractBarcodes([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractBarcodesAiResponse> __BuildExtractBarcodes(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractBarcodesAiResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/barcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<ExtractBarcodesAiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractAllFieldsAndTables))]
        public IBodyWorkflowAction<ExtractFieldsAndTablesResponse> ExtractAllFieldsAndTables([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<string> preprocessing = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractFieldsAndTablesResponse> __BuildExtractAllFieldsAndTables(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<string> preprocessing = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(preprocessing, nameof(preprocessing), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractFieldsAndTablesResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                if (preprocessing != null)
                    callPayload.Headers["preprocessing"] = ExpressionConverter.Convert(preprocessing);
                return new ApiConnectionAction<ExtractFieldsAndTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractClassification))]
        public IBodyWorkflowAction<DocumentClassificationResult> ExtractClassification([WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentClassificationResult> __BuildExtractClassification(WorkflowExpression<string> categories = null, WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(categories, nameof(categories), required: false);
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<DocumentClassificationResult>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/classify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (categories != null)
                    callPayload.Headers["Categories"] = ExpressionConverter.Convert(categories);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<DocumentClassificationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractClassificationAdvanced))]
        public IBodyWorkflowAction<DocumentAdvancedClassificationResult> ExtractClassificationAdvanced([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<DocumentCategories[]> bodycategories = null, [WorkflowExpression] Func<string> bodypreprocessing = null, [WorkflowExpression] Func<string> bodyresultCrossCheck = null, [WorkflowExpression] Func<int> bodymaximumPagesProcessed = null, [WorkflowExpression] Func<double> bodyrotateImageDegrees = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentAdvancedClassificationResult> __BuildExtractClassificationAdvanced(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<string> bodyinputFile = null, WorkflowExpression<DocumentCategories[]> bodycategories = null, WorkflowExpression<string> bodypreprocessing = null, WorkflowExpression<string> bodyresultCrossCheck = null, WorkflowExpression<int> bodymaximumPagesProcessed = null, WorkflowExpression<double> bodyrotateImageDegrees = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(bodyinputFile, nameof(bodyinputFile), required: false);
            WorkflowExpression.Validate(bodycategories, nameof(bodycategories), required: false);
            WorkflowExpression.Validate(bodypreprocessing, nameof(bodypreprocessing), required: false);
            WorkflowExpression.Validate(bodyresultCrossCheck, nameof(bodyresultCrossCheck), required: false);
            WorkflowExpression.Validate(bodymaximumPagesProcessed, nameof(bodymaximumPagesProcessed), required: false);
            WorkflowExpression.Validate(bodyrotateImageDegrees, nameof(bodyrotateImageDegrees), required: false);
            return new DeferredBodyAction<DocumentAdvancedClassificationResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractSummary))]
        public IBodyWorkflowAction<SummarizeDocumentResponse> ExtractSummary([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SummarizeDocumentResponse> __BuildExtractSummary(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<SummarizeDocumentResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/summary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<SummarizeDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractTextFromDocumentBatchJob))]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractTextFromDocumentBatchJob([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> __BuildExtractTextFromDocumentBatchJob(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFieldsFromDocumentAdvancedBatchJob))]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractFieldsFromDocumentAdvancedBatchJob([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<string> bodyinputFile = null, [WorkflowExpression] Func<FieldToExtract[]> bodyfieldsToExtract = null, [WorkflowExpression] Func<int> bodymaximumPagesProcessed = null, [WorkflowExpression] Func<string> bodypreprocessing = null, [WorkflowExpression] Func<string> bodyresultCrossCheck = null, [WorkflowExpression] Func<double> bodyrotateImageDegrees = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> __BuildExtractFieldsFromDocumentAdvancedBatchJob(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<string> bodyinputFile = null, WorkflowExpression<FieldToExtract[]> bodyfieldsToExtract = null, WorkflowExpression<int> bodymaximumPagesProcessed = null, WorkflowExpression<string> bodypreprocessing = null, WorkflowExpression<string> bodyresultCrossCheck = null, WorkflowExpression<double> bodyrotateImageDegrees = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(bodyinputFile, nameof(bodyinputFile), required: false);
            WorkflowExpression.Validate(bodyfieldsToExtract, nameof(bodyfieldsToExtract), required: false);
            WorkflowExpression.Validate(bodymaximumPagesProcessed, nameof(bodymaximumPagesProcessed), required: false);
            WorkflowExpression.Validate(bodypreprocessing, nameof(bodypreprocessing), required: false);
            WorkflowExpression.Validate(bodyresultCrossCheck, nameof(bodyresultCrossCheck), required: false);
            WorkflowExpression.Validate(bodyrotateImageDegrees, nameof(bodyrotateImageDegrees), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractAllFieldsAndTablesFromDocumentBatchJob))]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractAllFieldsAndTablesFromDocumentBatchJob([WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> __BuildExtractAllFieldsAndTablesFromDocumentBatchJob(WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildExtractClassificationFromDocumentBatchJob))]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractClassificationFromDocumentBatchJob([WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<string> recognitionMode = null, [WorkflowExpression] Func<object> inputFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> __BuildExtractClassificationFromDocumentBatchJob(WorkflowExpression<string> categories = null, WorkflowExpression<string> recognitionMode = null, WorkflowExpression<object> inputFile = null)
        {
            WorkflowExpression.Validate(categories, nameof(categories), required: false);
            WorkflowExpression.Validate(recognitionMode, nameof(recognitionMode), required: false);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/classify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (categories != null)
                    callPayload.Headers["Categories"] = ExpressionConverter.Convert(categories);
                if (recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(recognitionMode);
                return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        [WorkflowExpressionFactory(nameof(__BuildGetAsyncJobStatus))]
        public IBodyWorkflowAction<ExtractDocumentJobStatusResult> GetAsyncJobStatus([WorkflowExpression] Func<string> asyncJobID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractDocumentJobStatusResult> __BuildGetAsyncJobStatus(WorkflowExpression<string> asyncJobID = null)
        {
            WorkflowExpression.Validate(asyncJobID, nameof(asyncJobID), required: false);
            return new DeferredBodyAction<ExtractDocumentJobStatusResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/batch-job/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (asyncJobID != null)
                    callPayload.Queries["AsyncJobID"] = ExpressionConverter.Convert(asyncJobID);
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