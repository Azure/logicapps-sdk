//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivefileproc
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CloudmersivefileprocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<GetDocxCommentsResponse> EditDocumentDocxGetComments(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = reqConfiginputFileBytes == null ? null : WorkflowExpression.Compile(reqConfiginputFileBytes);
            WorkflowExpression.Validate(__workflow_reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = reqConfiginputFileUrl == null ? null : WorkflowExpression.Compile(reqConfiginputFileUrl);
            WorkflowExpression.Validate(__workflow_reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxCommentsResponse>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-comments/flat-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
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
        public IBodyWorkflowAction<Base64DetectResponse> EditTextBase64Detect(Expression<Func<string>> requestbase64ContentToDetect = null)
        {
            var __workflow_requestbase64ContentToDetect = requestbase64ContentToDetect == null ? null : WorkflowExpression.Compile(requestbase64ContentToDetect);
            WorkflowExpression.Validate(__workflow_requestbase64ContentToDetect, nameof(requestbase64ContentToDetect), required: false);
            return new DeferredBodyAction<Base64DetectResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestbase64ContentToDetect != null)
                {
                    request["Base64ContentToDetect"] = ExpressionConverter.ConvertO(__workflow_requestbase64ContentToDetect);
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
        public IBodyWorkflowAction<Base64EncodeResponse> EditTextBase64Encode(Expression<Func<string>> requestcontentToEncode = null)
        {
            var __workflow_requestcontentToEncode = requestcontentToEncode == null ? null : WorkflowExpression.Compile(requestcontentToEncode);
            WorkflowExpression.Validate(__workflow_requestcontentToEncode, nameof(requestcontentToEncode), required: false);
            return new DeferredBodyAction<Base64EncodeResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/encode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestcontentToEncode != null)
                {
                    request["ContentToEncode"] = ExpressionConverter.ConvertO(__workflow_requestcontentToEncode);
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
        public IBodyWorkflowAction<Base64DecodeResponse> EditTextBase64Decode(Expression<Func<string>> requestbase64ContentToDecode = null)
        {
            var __workflow_requestbase64ContentToDecode = requestbase64ContentToDecode == null ? null : WorkflowExpression.Compile(requestbase64ContentToDecode);
            WorkflowExpression.Validate(__workflow_requestbase64ContentToDecode, nameof(requestbase64ContentToDecode), required: false);
            return new DeferredBodyAction<Base64DecodeResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestbase64ContentToDecode != null)
                {
                    request["Base64ContentToDecode"] = ExpressionConverter.ConvertO(__workflow_requestbase64ContentToDecode);
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
        public IBodyWorkflowAction<TextEncodingDetectResponse> EditTextTextEncodingDetect(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<TextEncodingDetectResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TextEncodingDetectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<FindStringSimpleResponse> EditTextFindSimple(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetString = null)
        {
            var __workflow_requesttextContent = requesttextContent == null ? null : WorkflowExpression.Compile(requesttextContent);
            WorkflowExpression.Validate(__workflow_requesttextContent, nameof(requesttextContent), required: false);
            var __workflow_requesttargetString = requesttargetString == null ? null : WorkflowExpression.Compile(requesttargetString);
            WorkflowExpression.Validate(__workflow_requesttargetString, nameof(requesttargetString), required: false);
            return new DeferredBodyAction<FindStringSimpleResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/find/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requesttextContent != null)
                {
                    request["TextContent"] = ExpressionConverter.ConvertO(__workflow_requesttextContent);
                    requestpropCount++;
                }

                if (__workflow_requesttargetString != null)
                {
                    request["TargetString"] = ExpressionConverter.ConvertO(__workflow_requesttargetString);
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
        public IBodyWorkflowAction<FindStringRegexResponse> EditTextFindRegex(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetRegex = null, Expression<Func<bool>> requestmatchCase = null)
        {
            var __workflow_requesttextContent = requesttextContent == null ? null : WorkflowExpression.Compile(requesttextContent);
            WorkflowExpression.Validate(__workflow_requesttextContent, nameof(requesttextContent), required: false);
            var __workflow_requesttargetRegex = requesttargetRegex == null ? null : WorkflowExpression.Compile(requesttargetRegex);
            WorkflowExpression.Validate(__workflow_requesttargetRegex, nameof(requesttargetRegex), required: false);
            var __workflow_requestmatchCase = requestmatchCase == null ? null : WorkflowExpression.Compile(requestmatchCase);
            WorkflowExpression.Validate(__workflow_requestmatchCase, nameof(requestmatchCase), required: false);
            return new DeferredBodyAction<FindStringRegexResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/find/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requesttextContent != null)
                {
                    request["TextContent"] = ExpressionConverter.ConvertO(__workflow_requesttextContent);
                    requestpropCount++;
                }

                if (__workflow_requesttargetRegex != null)
                {
                    request["TargetRegex"] = ExpressionConverter.ConvertO(__workflow_requesttargetRegex);
                    requestpropCount++;
                }

                if (__workflow_requestmatchCase != null)
                {
                    request["MatchCase"] = ExpressionConverter.ConvertO(__workflow_requestmatchCase);
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
        public IBodyWorkflowAction<ReplaceStringSimpleResponse> EditTextReplaceSimple(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetString = null, Expression<Func<string>> requestreplaceWithString = null)
        {
            var __workflow_requesttextContent = requesttextContent == null ? null : WorkflowExpression.Compile(requesttextContent);
            WorkflowExpression.Validate(__workflow_requesttextContent, nameof(requesttextContent), required: false);
            var __workflow_requesttargetString = requesttargetString == null ? null : WorkflowExpression.Compile(requesttargetString);
            WorkflowExpression.Validate(__workflow_requesttargetString, nameof(requesttargetString), required: false);
            var __workflow_requestreplaceWithString = requestreplaceWithString == null ? null : WorkflowExpression.Compile(requestreplaceWithString);
            WorkflowExpression.Validate(__workflow_requestreplaceWithString, nameof(requestreplaceWithString), required: false);
            return new DeferredBodyAction<ReplaceStringSimpleResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/replace/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requesttextContent != null)
                {
                    request["TextContent"] = ExpressionConverter.ConvertO(__workflow_requesttextContent);
                    requestpropCount++;
                }

                if (__workflow_requesttargetString != null)
                {
                    request["TargetString"] = ExpressionConverter.ConvertO(__workflow_requesttargetString);
                    requestpropCount++;
                }

                if (__workflow_requestreplaceWithString != null)
                {
                    request["ReplaceWithString"] = ExpressionConverter.ConvertO(__workflow_requestreplaceWithString);
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
        public IBodyWorkflowAction<ReplaceStringRegexResponse> EditTextReplaceRegex(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requestregularExpressionString = null, Expression<Func<string>> requestreplaceWithString = null)
        {
            var __workflow_requesttextContent = requesttextContent == null ? null : WorkflowExpression.Compile(requesttextContent);
            WorkflowExpression.Validate(__workflow_requesttextContent, nameof(requesttextContent), required: false);
            var __workflow_requestregularExpressionString = requestregularExpressionString == null ? null : WorkflowExpression.Compile(requestregularExpressionString);
            WorkflowExpression.Validate(__workflow_requestregularExpressionString, nameof(requestregularExpressionString), required: false);
            var __workflow_requestreplaceWithString = requestreplaceWithString == null ? null : WorkflowExpression.Compile(requestreplaceWithString);
            WorkflowExpression.Validate(__workflow_requestreplaceWithString, nameof(requestreplaceWithString), required: false);
            return new DeferredBodyAction<ReplaceStringRegexResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/replace/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requesttextContent != null)
                {
                    request["TextContent"] = ExpressionConverter.ConvertO(__workflow_requesttextContent);
                    requestpropCount++;
                }

                if (__workflow_requestregularExpressionString != null)
                {
                    request["RegularExpressionString"] = ExpressionConverter.ConvertO(__workflow_requestregularExpressionString);
                    requestpropCount++;
                }

                if (__workflow_requestreplaceWithString != null)
                {
                    request["ReplaceWithString"] = ExpressionConverter.ConvertO(__workflow_requestreplaceWithString);
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
        public IBodyWorkflowAction<DetectLineEndingsResponse> EditTextDetectLineEndings(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<DetectLineEndingsResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/line-endings/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DetectLineEndingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ChangeLineEndingResponse> EditTextChangeLineEndings(Expression<Func<string>> lineEndingType, Expression<Func<object>> inputFile)
        {
            var __workflow_lineEndingType = lineEndingType == null ? null : WorkflowExpression.Compile(lineEndingType);
            WorkflowExpression.Validate(__workflow_lineEndingType, nameof(lineEndingType), required: true);
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<ChangeLineEndingResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/line-endings/change";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["lineEndingType"] = ExpressionConverter.Convert(__workflow_lineEndingType);
                return new ApiConnectionAction<ChangeLineEndingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveHtmlFromTextResponse> EditTextRemoveHtml(Expression<Func<string>> requesttextContainingHtml = null)
        {
            var __workflow_requesttextContainingHtml = requesttextContainingHtml == null ? null : WorkflowExpression.Compile(requesttextContainingHtml);
            WorkflowExpression.Validate(__workflow_requesttextContainingHtml, nameof(requesttextContainingHtml), required: false);
            return new DeferredBodyAction<RemoveHtmlFromTextResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requesttextContainingHtml != null)
                {
                    request["TextContainingHtml"] = ExpressionConverter.ConvertO(__workflow_requesttextContainingHtml);
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
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> EditTextRemoveAllWhitespace(Expression<Func<string>> requesttextContainingWhitespace = null)
        {
            var __workflow_requesttextContainingWhitespace = requesttextContainingWhitespace == null ? null : WorkflowExpression.Compile(requesttextContainingWhitespace);
            WorkflowExpression.Validate(__workflow_requesttextContainingWhitespace, nameof(requesttextContainingWhitespace), required: false);
            return new DeferredBodyAction<RemoveWhitespaceFromTextResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/whitespace/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requesttextContainingWhitespace != null)
                {
                    request["TextContainingWhitespace"] = ExpressionConverter.ConvertO(__workflow_requesttextContainingWhitespace);
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
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> EditTextTrimWhitespace(Expression<Func<string>> requesttextContainingWhitespace = null)
        {
            var __workflow_requesttextContainingWhitespace = requesttextContainingWhitespace == null ? null : WorkflowExpression.Compile(requesttextContainingWhitespace);
            WorkflowExpression.Validate(__workflow_requesttextContainingWhitespace, nameof(requesttextContainingWhitespace), required: false);
            return new DeferredBodyAction<RemoveWhitespaceFromTextResponse>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/whitespace/trim";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requesttextContainingWhitespace != null)
                {
                    request["TextContainingWhitespace"] = ExpressionConverter.ConvertO(__workflow_requesttextContainingWhitespace);
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
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentExecutableValidation(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<DocumentValidationResult>(() =>
            {
                var apiCallPath = "/convert/validate/executable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentValidationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ViewerResponse> ViewerToolsCreateSimple(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<ViewerResponse>(() =>
            {
                var apiCallPath = "/convert/viewer/create/web/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<string> ZipArchiveZipCreate(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2 = null, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var __workflow_inputFile1 = inputFile1 == null ? null : WorkflowExpression.Compile(inputFile1);
            WorkflowExpression.Validate(__workflow_inputFile1, nameof(inputFile1), required: true);
            var __workflow_inputFile2 = inputFile2 == null ? null : WorkflowExpression.Compile(inputFile2);
            WorkflowExpression.Validate(__workflow_inputFile2, nameof(inputFile2), required: false);
            var __workflow_inputFile3 = inputFile3 == null ? null : WorkflowExpression.Compile(inputFile3);
            WorkflowExpression.Validate(__workflow_inputFile3, nameof(inputFile3), required: false);
            var __workflow_inputFile4 = inputFile4 == null ? null : WorkflowExpression.Compile(inputFile4);
            WorkflowExpression.Validate(__workflow_inputFile4, nameof(inputFile4), required: false);
            var __workflow_inputFile5 = inputFile5 == null ? null : WorkflowExpression.Compile(inputFile5);
            WorkflowExpression.Validate(__workflow_inputFile5, nameof(inputFile5), required: false);
            var __workflow_inputFile6 = inputFile6 == null ? null : WorkflowExpression.Compile(inputFile6);
            WorkflowExpression.Validate(__workflow_inputFile6, nameof(inputFile6), required: false);
            var __workflow_inputFile7 = inputFile7 == null ? null : WorkflowExpression.Compile(inputFile7);
            WorkflowExpression.Validate(__workflow_inputFile7, nameof(inputFile7), required: false);
            var __workflow_inputFile8 = inputFile8 == null ? null : WorkflowExpression.Compile(inputFile8);
            WorkflowExpression.Validate(__workflow_inputFile8, nameof(inputFile8), required: false);
            var __workflow_inputFile9 = inputFile9 == null ? null : WorkflowExpression.Compile(inputFile9);
            WorkflowExpression.Validate(__workflow_inputFile9, nameof(inputFile9), required: false);
            var __workflow_inputFile10 = inputFile10 == null ? null : WorkflowExpression.Compile(inputFile10);
            WorkflowExpression.Validate(__workflow_inputFile10, nameof(inputFile10), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/archive/zip/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken> ZipArchiveZipCreateAdvanced(Expression<Func<ZipFile[]>> requestfilesInZip = null, Expression<Func<ZipDirectory[]>> requestdirectoriesInZip = null)
        {
            var __workflow_requestfilesInZip = requestfilesInZip == null ? null : WorkflowExpression.Compile(requestfilesInZip);
            WorkflowExpression.Validate(__workflow_requestfilesInZip, nameof(requestfilesInZip), required: false);
            var __workflow_requestdirectoriesInZip = requestdirectoriesInZip == null ? null : WorkflowExpression.Compile(requestdirectoriesInZip);
            WorkflowExpression.Validate(__workflow_requestdirectoriesInZip, nameof(requestdirectoriesInZip), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/convert/archive/zip/create/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestfilesInZip != null)
                {
                    request["FilesInZip"] = ExpressionConverter.ConvertO(__workflow_requestfilesInZip);
                    requestpropCount++;
                }

                if (__workflow_requestdirectoriesInZip != null)
                {
                    request["DirectoriesInZip"] = ExpressionConverter.ConvertO(__workflow_requestdirectoriesInZip);
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
        public IBodyWorkflowAction<ZipExtractResponse> ZipArchiveZipExtract(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<ZipExtractResponse>(() =>
            {
                var apiCallPath = "/convert/archive/zip/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ZipExtractResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken> ZipArchiveZipEncryptAdvanced(Expression<Func<string>> encryptionRequestinputFileContents = null, Expression<Func<string>> encryptionRequestpassword = null, Expression<Func<string>> encryptionRequestencryptionAlgorithm = null)
        {
            var __workflow_encryptionRequestinputFileContents = encryptionRequestinputFileContents == null ? null : WorkflowExpression.Compile(encryptionRequestinputFileContents);
            WorkflowExpression.Validate(__workflow_encryptionRequestinputFileContents, nameof(encryptionRequestinputFileContents), required: false);
            var __workflow_encryptionRequestpassword = encryptionRequestpassword == null ? null : WorkflowExpression.Compile(encryptionRequestpassword);
            WorkflowExpression.Validate(__workflow_encryptionRequestpassword, nameof(encryptionRequestpassword), required: false);
            var __workflow_encryptionRequestencryptionAlgorithm = encryptionRequestencryptionAlgorithm == null ? null : WorkflowExpression.Compile(encryptionRequestencryptionAlgorithm);
            WorkflowExpression.Validate(__workflow_encryptionRequestencryptionAlgorithm, nameof(encryptionRequestencryptionAlgorithm), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/convert/archive/zip/encrypt/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var encryptionRequest = new JObject();
                var encryptionRequestpropCount = 0;
                if (__workflow_encryptionRequestinputFileContents != null)
                {
                    encryptionRequest["InputFileContents"] = ExpressionConverter.ConvertO(__workflow_encryptionRequestinputFileContents);
                    encryptionRequestpropCount++;
                }

                if (__workflow_encryptionRequestpassword != null)
                {
                    encryptionRequest["Password"] = ExpressionConverter.ConvertO(__workflow_encryptionRequestpassword);
                    encryptionRequestpropCount++;
                }

                if (__workflow_encryptionRequestencryptionAlgorithm != null)
                {
                    encryptionRequest["EncryptionAlgorithm"] = ExpressionConverter.ConvertO(__workflow_encryptionRequestencryptionAlgorithm);
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
        public IBodyWorkflowAction<JToken> ZipArchiveZipDecrypt(Expression<Func<object>> inputFile, Expression<Func<string>> zipPassword)
        {
            var __workflow_inputFile = inputFile == null ? null : WorkflowExpression.Compile(inputFile);
            WorkflowExpression.Validate(__workflow_inputFile, nameof(inputFile), required: true);
            var __workflow_zipPassword = zipPassword == null ? null : WorkflowExpression.Compile(zipPassword);
            WorkflowExpression.Validate(__workflow_zipPassword, nameof(zipPassword), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/convert/archive/zip/decrypt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["zipPassword"] = ExpressionConverter.Convert(__workflow_zipPassword);
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
