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
        public IBodyWorkflowAction<FindStringSimpleResponse> EditTextFindSimple([WorkflowExpression] Func<string> requesttextContent = null, [WorkflowExpression] Func<string> requesttargetString = null)
        {
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
        public IBodyWorkflowAction<RemoveHtmlFromTextResponse> EditTextRemoveHtml([WorkflowExpression] Func<string> requesttextContainingHtml = null)
        {
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
        public IBodyWorkflowAction<JToken> ZipArchiveZipCreateAdvanced([WorkflowExpression] Func<ZipFile[]> requestfilesInZip = null, [WorkflowExpression] Func<ZipDirectory[]> requestdirectoriesInZip = null)
        {
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
        public IBodyWorkflowAction<JToken> ZipArchiveZipEncryptAdvanced([WorkflowExpression] Func<string> encryptionRequestinputFileContents = null, [WorkflowExpression] Func<string> encryptionRequestpassword = null, [WorkflowExpression] Func<string> encryptionRequestencryptionAlgorithm = null)
        {
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