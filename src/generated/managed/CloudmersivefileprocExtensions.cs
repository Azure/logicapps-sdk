//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivefileproc
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivefileprocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditDocumentDocxGetComments))]
        public IBodyWorkflowAction<GetDocxCommentsResponse> EditDocumentDocxGetComments([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocxCommentsResponse> __BuildEditDocumentDocxGetComments(WorkflowValue<string> reqConfiginputFileBytes = null, WorkflowValue<string> reqConfiginputFileUrl = null)
        {
            WorkflowValue.Validate(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            WorkflowValue.Validate(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxCommentsResponse>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-comments/flat-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxCommentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextBase64Detect))]
        public IBodyWorkflowAction<Base64DetectResponse> EditTextBase64Detect([WorkflowExpression] Func<string> requestbase64ContentToDetect = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Base64DetectResponse> __BuildEditTextBase64Detect(WorkflowValue<string> requestbase64ContentToDetect = null)
        {
            WorkflowValue.Validate(requestbase64ContentToDetect, nameof(requestbase64ContentToDetect), required: false);
            return new DeferredBodyAction<Base64DetectResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestbase64ContentToDetect != null)
                {
                    request["Base64ContentToDetect"] = ExpressionConverter.ConvertO(requestbase64ContentToDetect);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<Base64DetectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextBase64Encode))]
        public IBodyWorkflowAction<Base64EncodeResponse> EditTextBase64Encode([WorkflowExpression] Func<string> requestcontentToEncode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Base64EncodeResponse> __BuildEditTextBase64Encode(WorkflowValue<string> requestcontentToEncode = null)
        {
            WorkflowValue.Validate(requestcontentToEncode, nameof(requestcontentToEncode), required: false);
            return new DeferredBodyAction<Base64EncodeResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/encode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestcontentToEncode != null)
                {
                    request["ContentToEncode"] = ExpressionConverter.ConvertO(requestcontentToEncode);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<Base64EncodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextBase64Decode))]
        public IBodyWorkflowAction<Base64DecodeResponse> EditTextBase64Decode([WorkflowExpression] Func<string> requestbase64ContentToDecode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Base64DecodeResponse> __BuildEditTextBase64Decode(WorkflowValue<string> requestbase64ContentToDecode = null)
        {
            WorkflowValue.Validate(requestbase64ContentToDecode, nameof(requestbase64ContentToDecode), required: false);
            return new DeferredBodyAction<Base64DecodeResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestbase64ContentToDecode != null)
                {
                    request["Base64ContentToDecode"] = ExpressionConverter.ConvertO(requestbase64ContentToDecode);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<Base64DecodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextTextEncodingDetect))]
        public IBodyWorkflowAction<TextEncodingDetectResponse> EditTextTextEncodingDetect([WorkflowExpression] Func<object> inputFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextEncodingDetectResponse> __BuildEditTextTextEncodingDetect(WorkflowValue<object> inputFile)
        {
            WorkflowValue.Validate(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<TextEncodingDetectResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TextEncodingDetectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextFindSimple))]
        public IBodyWorkflowAction<FindStringSimpleResponse> EditTextFindSimple([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requesttargetString = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindStringSimpleResponse> __BuildEditTextFindSimple(WorkflowValue<string> requesttextContent = null, WorkflowValue<string> requesttargetString = null)
        {
            WorkflowValue.Validate(requesttextContent, nameof(requesttextContent), required: false);
            WorkflowValue.Validate(requesttargetString, nameof(requesttargetString), required: false);
            return new DeferredBodyAction<FindStringSimpleResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/find/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContent != null)
                {
                    request["TextContent"] = ExpressionConverter.ConvertO(requesttextContent);
                    requestpropCount++;
                }

                if (requesttargetString != null)
                {
                    request["TargetString"] = ExpressionConverter.ConvertO(requesttargetString);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<FindStringSimpleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextFindRegex))]
        public IBodyWorkflowAction<FindStringRegexResponse> EditTextFindRegex([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requesttargetRegex = null, [WorkflowExpression] Func<bool> requestmatchCase = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindStringRegexResponse> __BuildEditTextFindRegex(WorkflowValue<string> requesttextContent = null, WorkflowValue<string> requesttargetRegex = null, WorkflowValue<bool> requestmatchCase = null)
        {
            WorkflowValue.Validate(requesttextContent, nameof(requesttextContent), required: false);
            WorkflowValue.Validate(requesttargetRegex, nameof(requesttargetRegex), required: false);
            WorkflowValue.Validate(requestmatchCase, nameof(requestmatchCase), required: false);
            return new DeferredBodyAction<FindStringRegexResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/find/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContent != null)
                {
                    request["TextContent"] = ExpressionConverter.ConvertO(requesttextContent);
                    requestpropCount++;
                }

                if (requesttargetRegex != null)
                {
                    request["TargetRegex"] = ExpressionConverter.ConvertO(requesttargetRegex);
                    requestpropCount++;
                }

                if (requestmatchCase != null)
                {
                    request["MatchCase"] = ExpressionConverter.ConvertO(requestmatchCase);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<FindStringRegexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextReplaceSimple))]
        public IBodyWorkflowAction<ReplaceStringSimpleResponse> EditTextReplaceSimple([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requesttargetString = null, [WorkflowExpression] Func<string> requestreplaceWithString = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReplaceStringSimpleResponse> __BuildEditTextReplaceSimple(WorkflowValue<string> requesttextContent = null, WorkflowValue<string> requesttargetString = null, WorkflowValue<string> requestreplaceWithString = null)
        {
            WorkflowValue.Validate(requesttextContent, nameof(requesttextContent), required: false);
            WorkflowValue.Validate(requesttargetString, nameof(requesttargetString), required: false);
            WorkflowValue.Validate(requestreplaceWithString, nameof(requestreplaceWithString), required: false);
            return new DeferredBodyAction<ReplaceStringSimpleResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/replace/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContent != null)
                {
                    request["TextContent"] = ExpressionConverter.ConvertO(requesttextContent);
                    requestpropCount++;
                }

                if (requesttargetString != null)
                {
                    request["TargetString"] = ExpressionConverter.ConvertO(requesttargetString);
                    requestpropCount++;
                }

                if (requestreplaceWithString != null)
                {
                    request["ReplaceWithString"] = ExpressionConverter.ConvertO(requestreplaceWithString);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ReplaceStringSimpleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextReplaceRegex))]
        public IBodyWorkflowAction<ReplaceStringRegexResponse> EditTextReplaceRegex([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requestregularExpressionString = null, [WorkflowExpression] Func<string> requestreplaceWithString = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReplaceStringRegexResponse> __BuildEditTextReplaceRegex(WorkflowValue<string> requesttextContent = null, WorkflowValue<string> requestregularExpressionString = null, WorkflowValue<string> requestreplaceWithString = null)
        {
            WorkflowValue.Validate(requesttextContent, nameof(requesttextContent), required: false);
            WorkflowValue.Validate(requestregularExpressionString, nameof(requestregularExpressionString), required: false);
            WorkflowValue.Validate(requestreplaceWithString, nameof(requestreplaceWithString), required: false);
            return new DeferredBodyAction<ReplaceStringRegexResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/replace/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContent != null)
                {
                    request["TextContent"] = ExpressionConverter.ConvertO(requesttextContent);
                    requestpropCount++;
                }

                if (requestregularExpressionString != null)
                {
                    request["RegularExpressionString"] = ExpressionConverter.ConvertO(requestregularExpressionString);
                    requestpropCount++;
                }

                if (requestreplaceWithString != null)
                {
                    request["ReplaceWithString"] = ExpressionConverter.ConvertO(requestreplaceWithString);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ReplaceStringRegexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextDetectLineEndings))]
        public IBodyWorkflowAction<DetectLineEndingsResponse> EditTextDetectLineEndings([WorkflowExpression] Func<object> inputFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetectLineEndingsResponse> __BuildEditTextDetectLineEndings(WorkflowValue<object> inputFile)
        {
            WorkflowValue.Validate(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<DetectLineEndingsResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/line-endings/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DetectLineEndingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextChangeLineEndings))]
        public IBodyWorkflowAction<ChangeLineEndingResponse> EditTextChangeLineEndings([WorkflowExpression] Func<string> lineEndingType, [WorkflowExpression] Func<object> inputFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChangeLineEndingResponse> __BuildEditTextChangeLineEndings(WorkflowValue<string> lineEndingType, WorkflowValue<object> inputFile)
        {
            WorkflowValue.Validate(lineEndingType, nameof(lineEndingType), required: true);
            WorkflowValue.Validate(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<ChangeLineEndingResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/line-endings/change";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["lineEndingType"] = ExpressionConverter.Convert(lineEndingType);
                return new ApiConnectionAction<ChangeLineEndingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextRemoveHtml))]
        public IBodyWorkflowAction<RemoveHtmlFromTextResponse> EditTextRemoveHtml([WorkflowExpression] Func<string> requesttextContainingHtml = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveHtmlFromTextResponse> __BuildEditTextRemoveHtml(WorkflowValue<string> requesttextContainingHtml = null)
        {
            WorkflowValue.Validate(requesttextContainingHtml, nameof(requesttextContainingHtml), required: false);
            return new DeferredBodyAction<RemoveHtmlFromTextResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContainingHtml != null)
                {
                    request["TextContainingHtml"] = ExpressionConverter.ConvertO(requesttextContainingHtml);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<RemoveHtmlFromTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextRemoveAllWhitespace))]
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> EditTextRemoveAllWhitespace([WorkflowExpression] Func<string> requesttextContainingWhitespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> __BuildEditTextRemoveAllWhitespace(WorkflowValue<string> requesttextContainingWhitespace = null)
        {
            WorkflowValue.Validate(requesttextContainingWhitespace, nameof(requesttextContainingWhitespace), required: false);
            return new DeferredBodyAction<RemoveWhitespaceFromTextResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/whitespace/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContainingWhitespace != null)
                {
                    request["TextContainingWhitespace"] = ExpressionConverter.ConvertO(requesttextContainingWhitespace);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<RemoveWhitespaceFromTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildEditTextTrimWhitespace))]
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> EditTextTrimWhitespace([WorkflowExpression] Func<string> requesttextContainingWhitespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> __BuildEditTextTrimWhitespace(WorkflowValue<string> requesttextContainingWhitespace = null)
        {
            WorkflowValue.Validate(requesttextContainingWhitespace, nameof(requesttextContainingWhitespace), required: false);
            return new DeferredBodyAction<RemoveWhitespaceFromTextResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/whitespace/trim";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContainingWhitespace != null)
                {
                    request["TextContainingWhitespace"] = ExpressionConverter.ConvertO(requesttextContainingWhitespace);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<RemoveWhitespaceFromTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildValidateDocumentExecutableValidation))]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentExecutableValidation([WorkflowExpression] Func<object> inputFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentValidationResult> __BuildValidateDocumentExecutableValidation(WorkflowValue<object> inputFile)
        {
            WorkflowValue.Validate(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<DocumentValidationResult>(() =>
            {
                var apiCallPath = "/convert/validate/executable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentValidationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildViewerToolsCreateSimple))]
        public IBodyWorkflowAction<ViewerResponse> ViewerToolsCreateSimple([WorkflowExpression] Func<object> inputFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewerResponse> __BuildViewerToolsCreateSimple(WorkflowValue<object> inputFile)
        {
            WorkflowValue.Validate(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<ViewerResponse>(() =>
            {
                var apiCallPath = "/convert/viewer/create/web/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildZipArchiveZipCreate))]
        public IBodyWorkflowAction<string> ZipArchiveZipCreate([WorkflowExpression] Func<object> inputFile1, [WorkflowExpression] Func<object> inputFile2 = null, [WorkflowExpression] Func<object> inputFile3 = null, [WorkflowExpression] Func<object> inputFile4 = null, [WorkflowExpression] Func<object> inputFile5 = null, [WorkflowExpression] Func<object> inputFile6 = null, [WorkflowExpression] Func<object> inputFile7 = null, [WorkflowExpression] Func<object> inputFile8 = null, [WorkflowExpression] Func<object> inputFile9 = null, [WorkflowExpression] Func<object> inputFile10 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildZipArchiveZipCreate(WorkflowValue<object> inputFile1, WorkflowValue<object> inputFile2 = null, WorkflowValue<object> inputFile3 = null, WorkflowValue<object> inputFile4 = null, WorkflowValue<object> inputFile5 = null, WorkflowValue<object> inputFile6 = null, WorkflowValue<object> inputFile7 = null, WorkflowValue<object> inputFile8 = null, WorkflowValue<object> inputFile9 = null, WorkflowValue<object> inputFile10 = null)
        {
            WorkflowValue.Validate(inputFile1, nameof(inputFile1), required: true);
            WorkflowValue.Validate(inputFile2, nameof(inputFile2), required: false);
            WorkflowValue.Validate(inputFile3, nameof(inputFile3), required: false);
            WorkflowValue.Validate(inputFile4, nameof(inputFile4), required: false);
            WorkflowValue.Validate(inputFile5, nameof(inputFile5), required: false);
            WorkflowValue.Validate(inputFile6, nameof(inputFile6), required: false);
            WorkflowValue.Validate(inputFile7, nameof(inputFile7), required: false);
            WorkflowValue.Validate(inputFile8, nameof(inputFile8), required: false);
            WorkflowValue.Validate(inputFile9, nameof(inputFile9), required: false);
            WorkflowValue.Validate(inputFile10, nameof(inputFile10), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/archive/zip/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildZipArchiveZipCreateAdvanced))]
        public IBodyWorkflowAction<JToken> ZipArchiveZipCreateAdvanced([WorkflowExpression] Func<ZipFile[]> requestfilesInZip = null, [WorkflowExpression] Func<ZipDirectory[]> requestdirectoriesInZip = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildZipArchiveZipCreateAdvanced(WorkflowValue<ZipFile[]> requestfilesInZip = null, WorkflowValue<ZipDirectory[]> requestdirectoriesInZip = null)
        {
            WorkflowValue.Validate(requestfilesInZip, nameof(requestfilesInZip), required: false);
            WorkflowValue.Validate(requestdirectoriesInZip, nameof(requestdirectoriesInZip), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/convert/archive/zip/create/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestfilesInZip != null)
                {
                    request["FilesInZip"] = ExpressionConverter.ConvertO(requestfilesInZip);
                    requestpropCount++;
                }

                if (requestdirectoriesInZip != null)
                {
                    request["DirectoriesInZip"] = ExpressionConverter.ConvertO(requestdirectoriesInZip);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildZipArchiveZipExtract))]
        public IBodyWorkflowAction<ZipExtractResponse> ZipArchiveZipExtract([WorkflowExpression] Func<object> inputFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ZipExtractResponse> __BuildZipArchiveZipExtract(WorkflowValue<object> inputFile)
        {
            WorkflowValue.Validate(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<ZipExtractResponse>(() =>
            {
                var apiCallPath = "/convert/archive/zip/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ZipExtractResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildZipArchiveZipEncryptAdvanced))]
        public IBodyWorkflowAction<JToken> ZipArchiveZipEncryptAdvanced([WorkflowExpression] Func<string> encryptionRequestinputFileContents = null, [WorkflowExpression] Func<string> encryptionRequestpassword = null, [WorkflowExpression] Func<string> encryptionRequestencryptionAlgorithm = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildZipArchiveZipEncryptAdvanced(WorkflowValue<string> encryptionRequestinputFileContents = null, WorkflowValue<string> encryptionRequestpassword = null, WorkflowValue<string> encryptionRequestencryptionAlgorithm = null)
        {
            WorkflowValue.Validate(encryptionRequestinputFileContents, nameof(encryptionRequestinputFileContents), required: false);
            WorkflowValue.Validate(encryptionRequestpassword, nameof(encryptionRequestpassword), required: false);
            WorkflowValue.Validate(encryptionRequestencryptionAlgorithm, nameof(encryptionRequestencryptionAlgorithm), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/convert/archive/zip/encrypt/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var encryptionRequest = new JObject();
                var encryptionRequestpropCount = 0;
                if (encryptionRequestinputFileContents != null)
                {
                    encryptionRequest["InputFileContents"] = ExpressionConverter.ConvertO(encryptionRequestinputFileContents);
                    encryptionRequestpropCount++;
                }

                if (encryptionRequestpassword != null)
                {
                    encryptionRequest["Password"] = ExpressionConverter.ConvertO(encryptionRequestpassword);
                    encryptionRequestpropCount++;
                }

                if (encryptionRequestencryptionAlgorithm != null)
                {
                    encryptionRequest["EncryptionAlgorithm"] = ExpressionConverter.ConvertO(encryptionRequestencryptionAlgorithm);
                    encryptionRequestpropCount++;
                }

                if (encryptionRequestpropCount > 0)
                {
                    callPayload.Body = encryptionRequest;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        [WorkflowExpressionFactory(nameof(__BuildZipArchiveZipDecrypt))]
        public IBodyWorkflowAction<JToken> ZipArchiveZipDecrypt([WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<string> zipPassword)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildZipArchiveZipDecrypt(WorkflowValue<object> inputFile, WorkflowValue<string> zipPassword)
        {
            WorkflowValue.Validate(inputFile, nameof(inputFile), required: true);
            WorkflowValue.Validate(zipPassword, nameof(zipPassword), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/convert/archive/zip/decrypt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["zipPassword"] = ExpressionConverter.Convert(zipPassword);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class CloudmersivefileprocTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDocxCommentsResponse
    {
        public bool Successful { get; set; }
        public DocxComment[] Comments { get; set; }
        public int CommentCount { get; set; }
    }

    public class DocxComment
    {
        public string Path { get; set; }
        public string Author { get; set; }
        public string AuthorInitials { get; set; }
        public string CommentText { get; set; }
        public string CommentDate { get; set; }
        public bool IsTopLevel { get; set; }
        public bool IsReply { get; set; }
        public string ParentCommentPath { get; set; }
        public bool Done { get; set; }
    }

    public class Base64DetectResponse
    {
        public bool Successful { get; set; }
        public bool IsBase64Encoded { get; set; }
    }

    public class Base64EncodeResponse
    {
        public bool Successful { get; set; }
        public string Base64TextContentResult { get; set; }
    }

    public class Base64DecodeResponse
    {
        public bool Successful { get; set; }
        public string ContentResult { get; set; }
    }

    public class TextEncodingDetectResponse
    {
        public bool Successful { get; set; }
        public string TextEncoding { get; set; }
    }

    public class FindStringSimpleResponse
    {
        public bool Successful { get; set; }
        public FindStringMatch[] Matches { get; set; }
        public int MatchCount { get; set; }
    }

    public class FindStringMatch
    {
        public int CharacterOffsetStart { get; set; }
        public int CharacterOffsetEnd { get; set; }
        public string ContainingLine { get; set; }
    }

    public class FindStringRegexResponse
    {
        public bool Successful { get; set; }
        public FindRegexMatch[] Matches { get; set; }
        public int MatchCount { get; set; }
    }

    public class FindRegexMatch
    {
        public int CharacterOffsetStart { get; set; }
        public int CharacterOffsetEnd { get; set; }
        public string ContainingLine { get; set; }
        public string MatchValue { get; set; }
        public string[] MatchGroups { get; set; }
    }

    public class ReplaceStringSimpleResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class ReplaceStringRegexResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class DetectLineEndingsResponse
    {
        public bool Successful { get; set; }
        public string PrimaryNewlineType { get; set; }
        public string PrimaryNewlineTerminator { get; set; }
        public int InputLength { get; set; }
    }

    public class ChangeLineEndingResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class RemoveHtmlFromTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class RemoveWhitespaceFromTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class DocumentValidationResult
    {
        public bool DocumentIsValid { get; set; }
        public bool PasswordProtected { get; set; }
        public int ErrorCount { get; set; }
        public int WarningCount { get; set; }
        public DocumentValidationError[] ErrorsAndWarnings { get; set; }
    }

    public class DocumentValidationError
    {
        public string Description { get; set; }
        public string Path { get; set; }
        public string Uri { get; set; }
        public bool IsError { get; set; }
    }

    public class ViewerResponse
    {
        public string HtmlEmbed { get; set; }
        public bool Successful { get; set; }
    }

    public class ZipFile
    {
        public string FileName { get; set; }
        public string FileContents { get; set; }
    }

    public class ZipDirectory
    {
        public string DirectoryName { get; set; }
        public ZipDirectory[] DirectoriesInDirectory { get; set; }
        public ZipFile[] FilesInDirectory { get; set; }
    }

    public class ZipExtractResponse
    {
        public bool Successful { get; set; }
        public ZipFile[] FilesInZip { get; set; }
        public ZipDirectory[] DirectoriesInZip { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivefileproc;

    public partial class WorkflowManagedActions
    {
        public CloudmersivefileprocActions Cloudmersivefileproc(string connectionId) => new CloudmersivefileprocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivefileprocTriggers Cloudmersivefileproc(string connectionId) => new CloudmersivefileprocTriggers(connectionId);
    }
}
