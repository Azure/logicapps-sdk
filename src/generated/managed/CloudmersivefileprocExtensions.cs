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
        public IBodyWorkflowAction<GetDocxCommentsResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetComments(Expression<Func<ReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxCommentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-comments/flat-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxCommentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64DetectResponse, ApiConnectionActionConfiguration> EditTextBase64Detect(Expression<Func<EditTextBase64DetectRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<Base64DetectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<Base64DetectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64EncodeResponse, ApiConnectionActionConfiguration> EditTextBase64Encode(Expression<Func<EditTextBase64EncodeRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<Base64EncodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/encode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<Base64EncodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<Base64DecodeResponse, ApiConnectionActionConfiguration> EditTextBase64Decode(Expression<Func<EditTextBase64DecodeRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<Base64DecodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/encoding/base64/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<Base64DecodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<FindStringSimpleResponse, ApiConnectionActionConfiguration> EditTextFindSimple(Expression<Func<EditTextFindSimpleRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<FindStringSimpleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/find/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<FindStringSimpleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<FindStringRegexResponse, ApiConnectionActionConfiguration> EditTextFindRegex(Expression<Func<EditTextFindRegexRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<FindStringRegexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/find/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<FindStringRegexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ReplaceStringSimpleResponse, ApiConnectionActionConfiguration> EditTextReplaceSimple(Expression<Func<EditTextReplaceSimpleRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ReplaceStringSimpleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/replace/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ReplaceStringSimpleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<ReplaceStringRegexResponse, ApiConnectionActionConfiguration> EditTextReplaceRegex(Expression<Func<EditTextReplaceRegexRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ReplaceStringRegexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/replace/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ReplaceStringRegexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveHtmlFromTextResponse, ApiConnectionActionConfiguration> EditTextRemoveHtml(Expression<Func<EditTextRemoveHtmlRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<RemoveHtmlFromTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<RemoveHtmlFromTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveWhiteSpaceFromTextResponse, ApiConnectionActionConfiguration> EditTextRemoveAllWhiteSpace(Expression<Func<EditTextRemoveAllWhiteSpaceRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<RemoveWhiteSpaceFromTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/whitespace/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<RemoveWhiteSpaceFromTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<RemoveWhiteSpaceFromTextResponse, ApiConnectionActionConfiguration> EditTextTrimWhiteSpace(Expression<Func<EditTextRemoveAllWhiteSpaceRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<RemoveWhiteSpaceFromTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/text/remove/whitespace/trim";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<RemoveWhiteSpaceFromTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ZipArchiveZipCreateAdvanced(Expression<Func<ZipArchiveZipCreateAdvancedRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/archive/zip/create/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivefileproc")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ZipArchiveZipEncryptAdvanced(Expression<Func<EncryptionRequestInput>> encryptionRequest)
        {
            var __workflow_encryptionRequest = WorkflowExpression.Compile(encryptionRequest, nameof(encryptionRequest), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/archive/zip/encrypt/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_encryptionRequest);
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

    public class ReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
    }

    public class Base64DetectResponse
    {
        public bool Successful { get; set; }
        public bool IsBase64Encoded { get; set; }
    }

    public class EditTextBase64DetectRequestInput
    {
        public string Base64ContentToDetect { get; set; }
    }

    public class Base64EncodeResponse
    {
        public bool Successful { get; set; }
        public string Base64TextContentResult { get; set; }
    }

    public class EditTextBase64EncodeRequestInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ContentToEncode { get; set; }
    }

    public class Base64DecodeResponse
    {
        public bool Successful { get; set; }
        public string ContentResult { get; set; }
    }

    public class EditTextBase64DecodeRequestInput
    {
        public string Base64ContentToDecode { get; set; }
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

    public class EditTextFindSimpleRequestInput
    {
        public string TextContent { get; set; }
        public string TargetString { get; set; }
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

    public class EditTextFindRegexRequestInput
    {
        public string TextContent { get; set; }
        public string TargetRegex { get; set; }
        public bool? MatchCase { get; set; }
    }

    public class ReplaceStringSimpleResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class EditTextReplaceSimpleRequestInput
    {
        public string TextContent { get; set; }
        public string TargetString { get; set; }
        public string ReplaceWithString { get; set; }
    }

    public class ReplaceStringRegexResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class EditTextReplaceRegexRequestInput
    {
        public string TextContent { get; set; }
        public string RegularExpressionString { get; set; }
        public string ReplaceWithString { get; set; }
    }

    public class RemoveHtmlFromTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class EditTextRemoveHtmlRequestInput
    {
        public string TextContainingHtml { get; set; }
    }

    public class RemoveWhiteSpaceFromTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class EditTextRemoveAllWhiteSpaceRequestInput
    {
        [JsonProperty("TextContainingWhitespace")]
        public string TextContainingWhiteSpace { get; set; }
    }

    public class ZipArchiveZipCreateAdvancedRequestInput
    {
        public ZipFile[] FilesInZip { get; set; }
        public ZipDirectory[] DirectoriesInZip { get; set; }
    }

    public class ZipFile
    {
        public string FileName { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContents { get; set; }
    }

    public class ZipDirectory
    {
        public string DirectoryName { get; set; }
        public ZipFile[] FilesInDirectory { get; set; }
    }

    public class EncryptionRequestInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileContents { get; set; }
        public string Password { get; set; }
        public string EncryptionAlgorithm { get; set; }
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