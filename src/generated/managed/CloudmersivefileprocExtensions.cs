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
        public IBodyWorkflowAction<GetDocxCommentsResponse> EditDocumentDocxGetComments(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64DetectResponse> EditTextBase64Detect(Expression<Func<string>> requestbase64ContentToDetect = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64EncodeResponse> EditTextBase64Encode(Expression<Func<string>> requestcontentToEncode = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64DecodeResponse> EditTextBase64Decode(Expression<Func<string>> requestbase64ContentToDecode = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<TextEncodingDetectResponse> EditTextTextEncodingDetect(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/text/encoding/detect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TextEncodingDetectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<FindStringSimpleResponse> EditTextFindSimple(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetString = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<FindStringRegexResponse> EditTextFindRegex(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetRegex = null, Expression<Func<bool>> requestmatchCase = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ReplaceStringSimpleResponse> EditTextReplaceSimple(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetString = null, Expression<Func<string>> requestreplaceWithString = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ReplaceStringRegexResponse> EditTextReplaceRegex(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requestregularExpressionString = null, Expression<Func<string>> requestreplaceWithString = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<DetectLineEndingsResponse> EditTextDetectLineEndings(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/text/line-endings/detect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DetectLineEndingsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ChangeLineEndingResponse> EditTextChangeLineEndings(Expression<Func<string>> lineEndingType, Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/text/line-endings/change";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["lineEndingType"] = ExpressionConverter.Convert(lineEndingType);
            return new ApiConnectionAction<ChangeLineEndingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveHtmlFromTextResponse> EditTextRemoveHtml(Expression<Func<string>> requesttextContainingHtml = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> EditTextRemoveAllWhitespace(Expression<Func<string>> requesttextContainingWhitespace = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse> EditTextTrimWhitespace(Expression<Func<string>> requesttextContainingWhitespace = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentExecutableValidation(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/validate/executable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ViewerResponse> ViewerToolsCreateSimple(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/viewer/create/web/simple";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<string> ZipArchiveZipCreate(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2 = null, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var apiCallPath = "/convert/archive/zip/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken> ZipArchiveZipCreateAdvanced(Expression<Func<ZipFile[]>> requestfilesInZip = null, Expression<Func<ZipDirectory[]>> requestdirectoriesInZip = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ZipExtractResponse> ZipArchiveZipExtract(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/archive/zip/extract";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ZipExtractResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken> ZipArchiveZipEncryptAdvanced(Expression<Func<string>> encryptionRequestinputFileContents = null, Expression<Func<string>> encryptionRequestpassword = null, Expression<Func<string>> encryptionRequestencryptionAlgorithm = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken> ZipArchiveZipDecrypt(Expression<Func<object>> inputFile, Expression<Func<string>> zipPassword)
        {
            var apiCallPath = "/convert/archive/zip/decrypt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["zipPassword"] = ExpressionConverter.Convert(zipPassword);
            return new ApiConnectionAction<JToken>(callPayload);
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