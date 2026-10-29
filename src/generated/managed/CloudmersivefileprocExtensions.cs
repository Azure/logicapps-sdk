//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivefileproc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivefileprocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<GetDocxCommentsResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetComments(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxCommentsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Base64DetectResponse, ApiConnectionActionConfiguration> EditTextBase64Detect(Expression<Func<string>> requestbase64ContentToDetect = null)
        {
            var __workflow_requestbase64ContentToDetect = WorkflowExpression.Compile(requestbase64ContentToDetect, nameof(requestbase64ContentToDetect), required: false);
            return new DeferredBodyAction<Base64DetectResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Base64EncodeResponse, ApiConnectionActionConfiguration> EditTextBase64Encode(Expression<Func<string>> requestcontentToEncode = null)
        {
            var __workflow_requestcontentToEncode = WorkflowExpression.Compile(requestcontentToEncode, nameof(requestcontentToEncode), required: false);
            return new DeferredBodyAction<Base64EncodeResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Base64DecodeResponse, ApiConnectionActionConfiguration> EditTextBase64Decode(Expression<Func<string>> requestbase64ContentToDecode = null)
        {
            var __workflow_requestbase64ContentToDecode = WorkflowExpression.Compile(requestbase64ContentToDecode, nameof(requestbase64ContentToDecode), required: false);
            return new DeferredBodyAction<Base64DecodeResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<FindStringSimpleResponse, ApiConnectionActionConfiguration> EditTextFindSimple(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetString = null)
        {
            var __workflow_requesttextContent = WorkflowExpression.Compile(requesttextContent, nameof(requesttextContent), required: false);
            var __workflow_requesttargetString = WorkflowExpression.Compile(requesttargetString, nameof(requesttargetString), required: false);
            return new DeferredBodyAction<FindStringSimpleResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<FindStringRegexResponse, ApiConnectionActionConfiguration> EditTextFindRegex(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetRegex = null, Expression<Func<bool>> requestmatchCase = null)
        {
            var __workflow_requesttextContent = WorkflowExpression.Compile(requesttextContent, nameof(requesttextContent), required: false);
            var __workflow_requesttargetRegex = WorkflowExpression.Compile(requesttargetRegex, nameof(requesttargetRegex), required: false);
            var __workflow_requestmatchCase = WorkflowExpression.Compile(requestmatchCase, nameof(requestmatchCase), required: false);
            return new DeferredBodyAction<FindStringRegexResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ReplaceStringSimpleResponse, ApiConnectionActionConfiguration> EditTextReplaceSimple(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requesttargetString = null, Expression<Func<string>> requestreplaceWithString = null)
        {
            var __workflow_requesttextContent = WorkflowExpression.Compile(requesttextContent, nameof(requesttextContent), required: false);
            var __workflow_requesttargetString = WorkflowExpression.Compile(requesttargetString, nameof(requesttargetString), required: false);
            var __workflow_requestreplaceWithString = WorkflowExpression.Compile(requestreplaceWithString, nameof(requestreplaceWithString), required: false);
            return new DeferredBodyAction<ReplaceStringSimpleResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ReplaceStringRegexResponse, ApiConnectionActionConfiguration> EditTextReplaceRegex(Expression<Func<string>> requesttextContent = null, Expression<Func<string>> requestregularExpressionString = null, Expression<Func<string>> requestreplaceWithString = null)
        {
            var __workflow_requesttextContent = WorkflowExpression.Compile(requesttextContent, nameof(requesttextContent), required: false);
            var __workflow_requestregularExpressionString = WorkflowExpression.Compile(requestregularExpressionString, nameof(requestregularExpressionString), required: false);
            var __workflow_requestreplaceWithString = WorkflowExpression.Compile(requestreplaceWithString, nameof(requestreplaceWithString), required: false);
            return new DeferredBodyAction<ReplaceStringRegexResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<RemoveHtmlFromTextResponse, ApiConnectionActionConfiguration> EditTextRemoveHtml(Expression<Func<string>> requesttextContainingHtml = null)
        {
            var __workflow_requesttextContainingHtml = WorkflowExpression.Compile(requesttextContainingHtml, nameof(requesttextContainingHtml), required: false);
            return new DeferredBodyAction<RemoveHtmlFromTextResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse, ApiConnectionActionConfiguration> EditTextRemoveAllWhitespace(Expression<Func<string>> requesttextContainingWhitespace = null)
        {
            var __workflow_requesttextContainingWhitespace = WorkflowExpression.Compile(requesttextContainingWhitespace, nameof(requesttextContainingWhitespace), required: false);
            return new DeferredBodyAction<RemoveWhitespaceFromTextResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<RemoveWhitespaceFromTextResponse, ApiConnectionActionConfiguration> EditTextTrimWhitespace(Expression<Func<string>> requesttextContainingWhitespace = null)
        {
            var __workflow_requesttextContainingWhitespace = WorkflowExpression.Compile(requesttextContainingWhitespace, nameof(requesttextContainingWhitespace), required: false);
            return new DeferredBodyAction<RemoveWhitespaceFromTextResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ZipArchiveZipCreateAdvanced(Expression<Func<ZipFile[]>> requestfilesInZip = null, Expression<Func<ZipDirectory[]>> requestdirectoriesInZip = null)
        {
            var __workflow_requestfilesInZip = WorkflowExpression.Compile(requestfilesInZip, nameof(requestfilesInZip), required: false);
            var __workflow_requestdirectoriesInZip = WorkflowExpression.Compile(requestdirectoriesInZip, nameof(requestdirectoriesInZip), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ZipArchiveZipEncryptAdvanced(Expression<Func<string>> encryptionRequestinputFileContents = null, Expression<Func<string>> encryptionRequestpassword = null, Expression<Func<string>> encryptionRequestencryptionAlgorithm = null)
        {
            var __workflow_encryptionRequestinputFileContents = WorkflowExpression.Compile(encryptionRequestinputFileContents, nameof(encryptionRequestinputFileContents), required: false);
            var __workflow_encryptionRequestpassword = WorkflowExpression.Compile(encryptionRequestpassword, nameof(encryptionRequestpassword), required: false);
            var __workflow_encryptionRequestencryptionAlgorithm = WorkflowExpression.Compile(encryptionRequestencryptionAlgorithm, nameof(encryptionRequestencryptionAlgorithm), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
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