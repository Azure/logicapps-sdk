//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentai
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DocumentaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentPolicyResult> ApplyRules(Expression<Func<string>> bodyinputFile = null, Expression<Func<PolicyRule[]>> bodyrules = null, Expression<Func<string>> bodyrecognitionMode = null)
        {
            var __workflow_bodyinputFile = bodyinputFile == null ? null : WorkflowExpression.Compile(bodyinputFile);
            WorkflowExpression.Validate(__workflow_bodyinputFile, nameof(bodyinputFile), required: false);
            var __workflow_bodyrules = bodyrules == null ? null : WorkflowExpression.Compile(bodyrules);
            WorkflowExpression.Validate(__workflow_bodyrules, nameof(bodyrules), required: false);
            var __workflow_bodyrecognitionMode = bodyrecognitionMode == null ? null : WorkflowExpression.Compile(bodyrecognitionMode);
            WorkflowExpression.Validate(__workflow_bodyrecognitionMode, nameof(bodyrecognitionMode), required: false);
            return new DeferredBodyAction<DocumentPolicyResult>(() =>
            {
                var apiCallPath = "/document-ai/document/analyze/enforce-policy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputFile != null)
                {
                    body["InputFile"] = ExpressionConverter.ConvertO(__workflow_bodyinputFile);
                    bodypropCount++;
                }

                if (__workflow_bodyrules != null)
                {
                    body["Rules"] = ExpressionConverter.ConvertO(__workflow_bodyrules);
                    bodypropCount++;
                }

                if (__workflow_bodyrecognitionMode != null)
                {
                    body["RecognitionMode"] = ExpressionConverter.ConvertO(__workflow_bodyrecognitionMode);
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
        public IBodyWorkflowAction<DocumentQuestionAnswersResult> AnswerQuestions(Expression<Func<string>> bodyinputFile = null, Expression<Func<DocumentQuestionBoolean[]>> bodyquestionsYesNo = null, Expression<Func<DocumentQuestionMultipleChoice[]>> bodyquestionsMultipleChoice = null, Expression<Func<DocumentQuestionFreeResponse[]>> bodyquestionsFreeResponse = null, Expression<Func<string>> bodyrecognitionMode = null)
        {
            var __workflow_bodyinputFile = bodyinputFile == null ? null : WorkflowExpression.Compile(bodyinputFile);
            WorkflowExpression.Validate(__workflow_bodyinputFile, nameof(bodyinputFile), required: false);
            var __workflow_bodyquestionsYesNo = bodyquestionsYesNo == null ? null : WorkflowExpression.Compile(bodyquestionsYesNo);
            WorkflowExpression.Validate(__workflow_bodyquestionsYesNo, nameof(bodyquestionsYesNo), required: false);
            var __workflow_bodyquestionsMultipleChoice = bodyquestionsMultipleChoice == null ? null : WorkflowExpression.Compile(bodyquestionsMultipleChoice);
            WorkflowExpression.Validate(__workflow_bodyquestionsMultipleChoice, nameof(bodyquestionsMultipleChoice), required: false);
            var __workflow_bodyquestionsFreeResponse = bodyquestionsFreeResponse == null ? null : WorkflowExpression.Compile(bodyquestionsFreeResponse);
            WorkflowExpression.Validate(__workflow_bodyquestionsFreeResponse, nameof(bodyquestionsFreeResponse), required: false);
            var __workflow_bodyrecognitionMode = bodyrecognitionMode == null ? null : WorkflowExpression.Compile(bodyrecognitionMode);
            WorkflowExpression.Validate(__workflow_bodyrecognitionMode, nameof(bodyrecognitionMode), required: false);
            return new DeferredBodyAction<DocumentQuestionAnswersResult>(() =>
            {
                var apiCallPath = "/document-ai/document/analyze/answer-questions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputFile != null)
                {
                    body["InputFile"] = ExpressionConverter.ConvertO(__workflow_bodyinputFile);
                    bodypropCount++;
                }

                if (__workflow_bodyquestionsYesNo != null)
                {
                    body["QuestionsYesNo"] = ExpressionConverter.ConvertO(__workflow_bodyquestionsYesNo);
                    bodypropCount++;
                }

                if (__workflow_bodyquestionsMultipleChoice != null)
                {
                    body["QuestionsMultipleChoice"] = ExpressionConverter.ConvertO(__workflow_bodyquestionsMultipleChoice);
                    bodypropCount++;
                }

                if (__workflow_bodyquestionsFreeResponse != null)
                {
                    body["QuestionsFreeResponse"] = ExpressionConverter.ConvertO(__workflow_bodyquestionsFreeResponse);
                    bodypropCount++;
                }

                if (__workflow_bodyrecognitionMode != null)
                {
                    body["RecognitionMode"] = ExpressionConverter.ConvertO(__workflow_bodyrecognitionMode);
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
        public IBodyWorkflowAction<ExtractTextResponse> ExtractText(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractTextResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<ExtractTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractFieldsResponse> ExtractFields(Expression<Func<string>> fieldNames = null, Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_fieldNames = fieldNames == null ? null : WorkflowExpression.Compile(fieldNames);
            WorkflowExpression.Validate(__workflow_fieldNames, nameof(fieldNames), required: false);
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractFieldsResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fieldNames != null)
                    callPayload.Headers["FieldNames"] = ExpressionConverter.Convert(__workflow_fieldNames);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<ExtractFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractFieldsAdvancedResponse> ExtractFieldsAdvanced(Expression<Func<string>> recognitionMode = null, Expression<Func<string>> bodyinputFile = null, Expression<Func<FieldToExtract[]>> bodyfieldsToExtract = null, Expression<Func<int>> bodymaximumPagesProcessed = null, Expression<Func<string>> bodypreprocessing = null, Expression<Func<string>> bodyresultCrossCheck = null, Expression<Func<double>> bodyrotateImageDegrees = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_bodyinputFile = bodyinputFile == null ? null : WorkflowExpression.Compile(bodyinputFile);
            WorkflowExpression.Validate(__workflow_bodyinputFile, nameof(bodyinputFile), required: false);
            var __workflow_bodyfieldsToExtract = bodyfieldsToExtract == null ? null : WorkflowExpression.Compile(bodyfieldsToExtract);
            WorkflowExpression.Validate(__workflow_bodyfieldsToExtract, nameof(bodyfieldsToExtract), required: false);
            var __workflow_bodymaximumPagesProcessed = bodymaximumPagesProcessed == null ? null : WorkflowExpression.Compile(bodymaximumPagesProcessed);
            WorkflowExpression.Validate(__workflow_bodymaximumPagesProcessed, nameof(bodymaximumPagesProcessed), required: false);
            var __workflow_bodypreprocessing = bodypreprocessing == null ? null : WorkflowExpression.Compile(bodypreprocessing);
            WorkflowExpression.Validate(__workflow_bodypreprocessing, nameof(bodypreprocessing), required: false);
            var __workflow_bodyresultCrossCheck = bodyresultCrossCheck == null ? null : WorkflowExpression.Compile(bodyresultCrossCheck);
            WorkflowExpression.Validate(__workflow_bodyresultCrossCheck, nameof(bodyresultCrossCheck), required: false);
            var __workflow_bodyrotateImageDegrees = bodyrotateImageDegrees == null ? null : WorkflowExpression.Compile(bodyrotateImageDegrees);
            WorkflowExpression.Validate(__workflow_bodyrotateImageDegrees, nameof(bodyrotateImageDegrees), required: false);
            return new DeferredBodyAction<ExtractFieldsAdvancedResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/fields/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputFile != null)
                {
                    body["InputFile"] = ExpressionConverter.ConvertO(__workflow_bodyinputFile);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsToExtract != null)
                {
                    body["FieldsToExtract"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsToExtract);
                    bodypropCount++;
                }

                if (__workflow_bodymaximumPagesProcessed != null)
                {
                    body["MaximumPagesProcessed"] = ExpressionConverter.ConvertO(__workflow_bodymaximumPagesProcessed);
                    bodypropCount++;
                }

                if (__workflow_bodypreprocessing != null)
                {
                    body["Preprocessing"] = ExpressionConverter.ConvertO(__workflow_bodypreprocessing);
                    bodypropCount++;
                }

                if (__workflow_bodyresultCrossCheck != null)
                {
                    body["ResultCrossCheck"] = ExpressionConverter.ConvertO(__workflow_bodyresultCrossCheck);
                    bodypropCount++;
                }

                if (__workflow_bodyrotateImageDegrees != null)
                {
                    body["RotateImageDegrees"] = ExpressionConverter.ConvertO(__workflow_bodyrotateImageDegrees);
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
        public IBodyWorkflowAction<ExtractTablesResponse> ExtractTables(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractTablesResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<ExtractTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractBarcodesAiResponse> ExtractBarcodes(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractBarcodesAiResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/barcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<ExtractBarcodesAiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractFieldsAndTablesResponse> ExtractAllFieldsAndTables(Expression<Func<string>> recognitionMode = null, Expression<Func<string>> preprocessing = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_preprocessing = preprocessing == null ? null : WorkflowExpression.Compile(preprocessing);
            WorkflowExpression.Validate(__workflow_preprocessing, nameof(preprocessing), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractFieldsAndTablesResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                if (__workflow_preprocessing != null)
                    callPayload.Headers["preprocessing"] = ExpressionConverter.Convert(__workflow_preprocessing);
                return new ApiConnectionAction<ExtractFieldsAndTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentClassificationResult> ExtractClassification(Expression<Func<string>> categories = null, Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_categories = categories == null ? null : WorkflowExpression.Compile(categories);
            WorkflowExpression.Validate(__workflow_categories, nameof(categories), required: false);
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<DocumentClassificationResult>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/classify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_categories != null)
                    callPayload.Headers["Categories"] = ExpressionConverter.Convert(__workflow_categories);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<DocumentClassificationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<DocumentAdvancedClassificationResult> ExtractClassificationAdvanced(Expression<Func<string>> recognitionMode = null, Expression<Func<string>> bodyinputFile = null, Expression<Func<DocumentCategories[]>> bodycategories = null, Expression<Func<string>> bodypreprocessing = null, Expression<Func<string>> bodyresultCrossCheck = null, Expression<Func<int>> bodymaximumPagesProcessed = null, Expression<Func<double>> bodyrotateImageDegrees = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_bodyinputFile = bodyinputFile == null ? null : WorkflowExpression.Compile(bodyinputFile);
            WorkflowExpression.Validate(__workflow_bodyinputFile, nameof(bodyinputFile), required: false);
            var __workflow_bodycategories = bodycategories == null ? null : WorkflowExpression.Compile(bodycategories);
            WorkflowExpression.Validate(__workflow_bodycategories, nameof(bodycategories), required: false);
            var __workflow_bodypreprocessing = bodypreprocessing == null ? null : WorkflowExpression.Compile(bodypreprocessing);
            WorkflowExpression.Validate(__workflow_bodypreprocessing, nameof(bodypreprocessing), required: false);
            var __workflow_bodyresultCrossCheck = bodyresultCrossCheck == null ? null : WorkflowExpression.Compile(bodyresultCrossCheck);
            WorkflowExpression.Validate(__workflow_bodyresultCrossCheck, nameof(bodyresultCrossCheck), required: false);
            var __workflow_bodymaximumPagesProcessed = bodymaximumPagesProcessed == null ? null : WorkflowExpression.Compile(bodymaximumPagesProcessed);
            WorkflowExpression.Validate(__workflow_bodymaximumPagesProcessed, nameof(bodymaximumPagesProcessed), required: false);
            var __workflow_bodyrotateImageDegrees = bodyrotateImageDegrees == null ? null : WorkflowExpression.Compile(bodyrotateImageDegrees);
            WorkflowExpression.Validate(__workflow_bodyrotateImageDegrees, nameof(bodyrotateImageDegrees), required: false);
            return new DeferredBodyAction<DocumentAdvancedClassificationResult>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/classify/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputFile != null)
                {
                    body["InputFile"] = ExpressionConverter.ConvertO(__workflow_bodyinputFile);
                    bodypropCount++;
                }

                if (__workflow_bodycategories != null)
                {
                    body["Categories"] = ExpressionConverter.ConvertO(__workflow_bodycategories);
                    bodypropCount++;
                }

                if (__workflow_bodypreprocessing != null)
                {
                    body["Preprocessing"] = ExpressionConverter.ConvertO(__workflow_bodypreprocessing);
                    bodypropCount++;
                }

                if (__workflow_bodyresultCrossCheck != null)
                {
                    body["ResultCrossCheck"] = ExpressionConverter.ConvertO(__workflow_bodyresultCrossCheck);
                    bodypropCount++;
                }

                if (__workflow_bodymaximumPagesProcessed != null)
                {
                    body["MaximumPagesProcessed"] = ExpressionConverter.ConvertO(__workflow_bodymaximumPagesProcessed);
                    bodypropCount++;
                }

                if (__workflow_bodyrotateImageDegrees != null)
                {
                    body["RotateImageDegrees"] = ExpressionConverter.ConvertO(__workflow_bodyrotateImageDegrees);
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
        public IBodyWorkflowAction<SummarizeDocumentResponse> ExtractSummary(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<SummarizeDocumentResponse>(() =>
            {
                var apiCallPath = "/document-ai/document/extract/summary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<SummarizeDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractTextFromDocumentBatchJob(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractFieldsFromDocumentAdvancedBatchJob(Expression<Func<string>> recognitionMode = null, Expression<Func<string>> bodyinputFile = null, Expression<Func<FieldToExtract[]>> bodyfieldsToExtract = null, Expression<Func<int>> bodymaximumPagesProcessed = null, Expression<Func<string>> bodypreprocessing = null, Expression<Func<string>> bodyresultCrossCheck = null, Expression<Func<double>> bodyrotateImageDegrees = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_bodyinputFile = bodyinputFile == null ? null : WorkflowExpression.Compile(bodyinputFile);
            WorkflowExpression.Validate(__workflow_bodyinputFile, nameof(bodyinputFile), required: false);
            var __workflow_bodyfieldsToExtract = bodyfieldsToExtract == null ? null : WorkflowExpression.Compile(bodyfieldsToExtract);
            WorkflowExpression.Validate(__workflow_bodyfieldsToExtract, nameof(bodyfieldsToExtract), required: false);
            var __workflow_bodymaximumPagesProcessed = bodymaximumPagesProcessed == null ? null : WorkflowExpression.Compile(bodymaximumPagesProcessed);
            WorkflowExpression.Validate(__workflow_bodymaximumPagesProcessed, nameof(bodymaximumPagesProcessed), required: false);
            var __workflow_bodypreprocessing = bodypreprocessing == null ? null : WorkflowExpression.Compile(bodypreprocessing);
            WorkflowExpression.Validate(__workflow_bodypreprocessing, nameof(bodypreprocessing), required: false);
            var __workflow_bodyresultCrossCheck = bodyresultCrossCheck == null ? null : WorkflowExpression.Compile(bodyresultCrossCheck);
            WorkflowExpression.Validate(__workflow_bodyresultCrossCheck, nameof(bodyresultCrossCheck), required: false);
            var __workflow_bodyrotateImageDegrees = bodyrotateImageDegrees == null ? null : WorkflowExpression.Compile(bodyrotateImageDegrees);
            WorkflowExpression.Validate(__workflow_bodyrotateImageDegrees, nameof(bodyrotateImageDegrees), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/fields/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputFile != null)
                {
                    body["InputFile"] = ExpressionConverter.ConvertO(__workflow_bodyinputFile);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsToExtract != null)
                {
                    body["FieldsToExtract"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsToExtract);
                    bodypropCount++;
                }

                if (__workflow_bodymaximumPagesProcessed != null)
                {
                    body["MaximumPagesProcessed"] = ExpressionConverter.ConvertO(__workflow_bodymaximumPagesProcessed);
                    bodypropCount++;
                }

                if (__workflow_bodypreprocessing != null)
                {
                    body["Preprocessing"] = ExpressionConverter.ConvertO(__workflow_bodypreprocessing);
                    bodypropCount++;
                }

                if (__workflow_bodyresultCrossCheck != null)
                {
                    body["ResultCrossCheck"] = ExpressionConverter.ConvertO(__workflow_bodyresultCrossCheck);
                    bodypropCount++;
                }

                if (__workflow_bodyrotateImageDegrees != null)
                {
                    body["RotateImageDegrees"] = ExpressionConverter.ConvertO(__workflow_bodyrotateImageDegrees);
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
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractAllFieldsAndTablesFromDocumentBatchJob(Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentBatchJobResult> ExtractClassificationFromDocumentBatchJob(Expression<Func<string>> categories = null, Expression<Func<string>> recognitionMode = null, Expression<Func<object>> inputFile = null)
        {
            var __workflow_categories = categories == null ? null : WorkflowExpression.Compile(categories);
            WorkflowExpression.Validate(__workflow_categories, nameof(categories), required: false);
            var __workflow_recognitionMode = recognitionMode == null ? null : WorkflowExpression.Compile(recognitionMode);
            WorkflowExpression.Validate(__workflow_recognitionMode, nameof(recognitionMode), required: false);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: false);
            return new DeferredBodyAction<ExtractDocumentBatchJobResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/extract/classify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_categories != null)
                    callPayload.Headers["Categories"] = ExpressionConverter.Convert(__workflow_categories);
                if (__workflow_recognitionMode != null)
                    callPayload.Headers["recognitionMode"] = ExpressionConverter.Convert(__workflow_recognitionMode);
                return new ApiConnectionAction<ExtractDocumentBatchJobResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentai")]
        public IBodyWorkflowAction<ExtractDocumentJobStatusResult> GetAsyncJobStatus(Expression<Func<string>> asyncJobID = null)
        {
            var __workflow_asyncJobID = asyncJobID == null ? null : WorkflowExpression.Compile(asyncJobID);
            WorkflowExpression.Validate(__workflow_asyncJobID, nameof(asyncJobID), required: false);
            return new DeferredBodyAction<ExtractDocumentJobStatusResult>(() =>
            {
                var apiCallPath = "/document-ai/document/batch-job/batch-job/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_asyncJobID != null)
                    callPayload.Queries["AsyncJobID"] = ExpressionConverter.Convert(__workflow_asyncJobID);
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
