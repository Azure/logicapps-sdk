//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivefileproc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivefileprocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<GetDocxCommentsResponse> EditDocumentDocxGetComments([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            SourceExpression.Validate(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            SourceExpression.Validate(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-comments/flat-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxCommentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64DetectResponse> EditTextBase64Detect([WorkflowExpression] Func<string> requestbase64ContentToDetect = null)
        {
            SourceExpression.Validate(requestbase64ContentToDetect, nameof(requestbase64ContentToDetect), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestbase64ContentToDetect != null)
                {
                    request["Base64ContentToDetect"] = SourceExpressionConverter.ConvertToken(requestbase64ContentToDetect);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Base64DetectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64EncodeResponse> EditTextBase64Encode([WorkflowExpression] Func<string> requestcontentToEncode = null)
        {
            SourceExpression.Validate(requestcontentToEncode, nameof(requestcontentToEncode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/encode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestcontentToEncode != null)
                {
                    request["ContentToEncode"] = SourceExpressionConverter.ConvertToken(requestcontentToEncode);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Base64EncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64DecodeResponse> EditTextBase64Decode([WorkflowExpression] Func<string> requestbase64ContentToDecode = null)
        {
            SourceExpression.Validate(requestbase64ContentToDecode, nameof(requestbase64ContentToDecode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestbase64ContentToDecode != null)
                {
                    request["Base64ContentToDecode"] = SourceExpressionConverter.ConvertToken(requestbase64ContentToDecode);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Base64DecodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<TextEncodingDetectResponse> EditTextTextEncodingDetect([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/encoding/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TextEncodingDetectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<FindStringSimpleResponse> EditTextFindSimple([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requesttargetString = null)
        {
            SourceExpression.Validate(requesttextContent, nameof(requesttextContent), required: false);
            SourceExpression.Validate(requesttargetString, nameof(requesttargetString), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/find/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContent != null)
                {
                    request["TextContent"] = SourceExpressionConverter.ConvertToken(requesttextContent);
                    requestpropCount++;
                }

                if (requesttargetString != null)
                {
                    request["TargetString"] = SourceExpressionConverter.ConvertToken(requesttargetString);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FindStringSimpleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<FindStringRegexResponse> EditTextFindRegex([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requesttargetRegex = null, [WorkflowExpression] Func<bool> requestmatchCase = null)
        {
            SourceExpression.Validate(requesttextContent, nameof(requesttextContent), required: false);
            SourceExpression.Validate(requesttargetRegex, nameof(requesttargetRegex), required: false);
            SourceExpression.Validate(requestmatchCase, nameof(requestmatchCase), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/find/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContent != null)
                {
                    request["TextContent"] = SourceExpressionConverter.ConvertToken(requesttextContent);
                    requestpropCount++;
                }

                if (requesttargetRegex != null)
                {
                    request["TargetRegex"] = SourceExpressionConverter.ConvertToken(requesttargetRegex);
                    requestpropCount++;
                }

                if (requestmatchCase != null)
                {
                    request["MatchCase"] = SourceExpressionConverter.ConvertToken(requestmatchCase);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FindStringRegexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ReplaceStringSimpleResponse> EditTextReplaceSimple([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requesttargetString = null, [WorkflowExpression] Func<string> requestreplaceWithString = null)
        {
            SourceExpression.Validate(requesttextContent, nameof(requesttextContent), required: false);
            SourceExpression.Validate(requesttargetString, nameof(requesttargetString), required: false);
            SourceExpression.Validate(requestreplaceWithString, nameof(requestreplaceWithString), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/replace/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContent != null)
                {
                    request["TextContent"] = SourceExpressionConverter.ConvertToken(requesttextContent);
                    requestpropCount++;
                }

                if (requesttargetString != null)
                {
                    request["TargetString"] = SourceExpressionConverter.ConvertToken(requesttargetString);
                    requestpropCount++;
                }

                if (requestreplaceWithString != null)
                {
                    request["ReplaceWithString"] = SourceExpressionConverter.ConvertToken(requestreplaceWithString);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReplaceStringSimpleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ReplaceStringRegexResponse> EditTextReplaceRegex([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requestregularExpressionString = null, [WorkflowExpression] Func<string> requestreplaceWithString = null)
        {
            SourceExpression.Validate(requesttextContent, nameof(requesttextContent), required: false);
            SourceExpression.Validate(requestregularExpressionString, nameof(requestregularExpressionString), required: false);
            SourceExpression.Validate(requestreplaceWithString, nameof(requestreplaceWithString), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/replace/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContent != null)
                {
                    request["TextContent"] = SourceExpressionConverter.ConvertToken(requesttextContent);
                    requestpropCount++;
                }

                if (requestregularExpressionString != null)
                {
                    request["RegularExpressionString"] = SourceExpressionConverter.ConvertToken(requestregularExpressionString);
                    requestpropCount++;
                }

                if (requestreplaceWithString != null)
                {
                    request["ReplaceWithString"] = SourceExpressionConverter.ConvertToken(requestreplaceWithString);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReplaceStringRegexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<DetectLineEndingsResponse> EditTextDetectLineEndings([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/line-endings/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DetectLineEndingsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ChangeLineEndingResponse> EditTextChangeLineEndings([WorkflowExpression] Func<string> lineEndingType, [WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(lineEndingType, nameof(lineEndingType), required: true);
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/line-endings/change";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["lineEndingType"] = SourceExpressionConverter.ConvertO(lineEndingType);
                return callPayload;
            }

            return new ApiConnectionAction<ChangeLineEndingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveHtmlFromTextResponse> EditTextRemoveHtml([WorkflowExpression] Func<string> requesttextContainingHtml = null)
        {
            SourceExpression.Validate(requesttextContainingHtml, nameof(requesttextContainingHtml), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/remove/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContainingHtml != null)
                {
                    request["TextContainingHtml"] = SourceExpressionConverter.ConvertToken(requesttextContainingHtml);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RemoveHtmlFromTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> EditTextRemoveAllWhitespace([WorkflowExpression] Func<string> requesttextContainingWhitespace = null)
        {
            SourceExpression.Validate(requesttextContainingWhitespace, nameof(requesttextContainingWhitespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/remove/whitespace/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContainingWhitespace != null)
                {
                    request["TextContainingWhitespace"] = SourceExpressionConverter.ConvertToken(requesttextContainingWhitespace);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RemoveWhitespaceFromTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> EditTextTrimWhitespace([WorkflowExpression] Func<string> requesttextContainingWhitespace = null)
        {
            SourceExpression.Validate(requesttextContainingWhitespace, nameof(requesttextContainingWhitespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/text/remove/whitespace/trim";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttextContainingWhitespace != null)
                {
                    request["TextContainingWhitespace"] = SourceExpressionConverter.ConvertToken(requesttextContainingWhitespace);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RemoveWhitespaceFromTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentExecutableValidation([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/validate/executable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentValidationResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ViewerResponse> ViewerToolsCreateSimple([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/viewer/create/web/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<string> ZipArchiveZipCreate([WorkflowExpression] Func<object> inputFile1, [WorkflowExpression] Func<object> inputFile2 = null, [WorkflowExpression] Func<object> inputFile3 = null, [WorkflowExpression] Func<object> inputFile4 = null, [WorkflowExpression] Func<object> inputFile5 = null, [WorkflowExpression] Func<object> inputFile6 = null, [WorkflowExpression] Func<object> inputFile7 = null, [WorkflowExpression] Func<object> inputFile8 = null, [WorkflowExpression] Func<object> inputFile9 = null, [WorkflowExpression] Func<object> inputFile10 = null)
        {
            SourceExpression.Validate(inputFile1, nameof(inputFile1), required: true);
            SourceExpression.Validate(inputFile2, nameof(inputFile2), required: false);
            SourceExpression.Validate(inputFile3, nameof(inputFile3), required: false);
            SourceExpression.Validate(inputFile4, nameof(inputFile4), required: false);
            SourceExpression.Validate(inputFile5, nameof(inputFile5), required: false);
            SourceExpression.Validate(inputFile6, nameof(inputFile6), required: false);
            SourceExpression.Validate(inputFile7, nameof(inputFile7), required: false);
            SourceExpression.Validate(inputFile8, nameof(inputFile8), required: false);
            SourceExpression.Validate(inputFile9, nameof(inputFile9), required: false);
            SourceExpression.Validate(inputFile10, nameof(inputFile10), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/archive/zip/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken> ZipArchiveZipCreateAdvanced([WorkflowExpression] Func<ZipFile[]> requestfilesInZip = null, [WorkflowExpression] Func<ZipDirectory[]> requestdirectoriesInZip = null)
        {
            SourceExpression.Validate(requestfilesInZip, nameof(requestfilesInZip), required: false);
            SourceExpression.Validate(requestdirectoriesInZip, nameof(requestdirectoriesInZip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/archive/zip/create/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestfilesInZip != null)
                {
                    request["FilesInZip"] = SourceExpressionConverter.ConvertToken(requestfilesInZip);
                    requestpropCount++;
                }

                if (requestdirectoriesInZip != null)
                {
                    request["DirectoriesInZip"] = SourceExpressionConverter.ConvertToken(requestdirectoriesInZip);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ZipExtractResponse> ZipArchiveZipExtract([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/archive/zip/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ZipExtractResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken> ZipArchiveZipEncryptAdvanced([WorkflowExpression] Func<string> encryptionRequestinputFileContents = null, [WorkflowExpression] Func<string> encryptionRequestpassword = null, [WorkflowExpression] Func<string> encryptionRequestencryptionAlgorithm = null)
        {
            SourceExpression.Validate(encryptionRequestinputFileContents, nameof(encryptionRequestinputFileContents), required: false);
            SourceExpression.Validate(encryptionRequestpassword, nameof(encryptionRequestpassword), required: false);
            SourceExpression.Validate(encryptionRequestencryptionAlgorithm, nameof(encryptionRequestencryptionAlgorithm), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/archive/zip/encrypt/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var encryptionRequest = new JObject();
                var encryptionRequestpropCount = 0;
                if (encryptionRequestinputFileContents != null)
                {
                    encryptionRequest["InputFileContents"] = SourceExpressionConverter.ConvertToken(encryptionRequestinputFileContents);
                    encryptionRequestpropCount++;
                }

                if (encryptionRequestpassword != null)
                {
                    encryptionRequest["Password"] = SourceExpressionConverter.ConvertToken(encryptionRequestpassword);
                    encryptionRequestpropCount++;
                }

                if (encryptionRequestencryptionAlgorithm != null)
                {
                    encryptionRequest["EncryptionAlgorithm"] = SourceExpressionConverter.ConvertToken(encryptionRequestencryptionAlgorithm);
                    encryptionRequestpropCount++;
                }

                if (encryptionRequestpropCount > 0)
                {
                    callPayload.Body = encryptionRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken> ZipArchiveZipDecrypt([WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<string> zipPassword)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            SourceExpression.Validate(zipPassword, nameof(zipPassword), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/archive/zip/decrypt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["zipPassword"] = SourceExpressionConverter.ConvertO(zipPassword);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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