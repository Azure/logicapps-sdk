//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aikidocs
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AikidocsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ValidateConnectionResponse, ApiConnectionActionConfiguration> ValidateConnectGoodService(Expression<Func<ValidateConnectGoodServiceInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ValidateConnectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/good";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidateConnectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ValidateConnectionResponse, ApiConnectionActionConfiguration> ValidateConnectBadService(Expression<Func<ValidateConnectBadServiceInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ValidateConnectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bad";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidateConnectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<AppendDocumentResponse, ApiConnectionActionConfiguration> WordAppendDocuments(Expression<Func<WordAppendDocumentsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AppendDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/WordAppendDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AppendDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractContentByHeadingResponse, ApiConnectionActionConfiguration> WordExtractContentByHeading(Expression<Func<WordExtractContentByHeadingInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractContentByHeadingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByHeading";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractContentByHeadingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractSectionByTitleResponse, ApiConnectionActionConfiguration> WordExtractContentByTitle(Expression<Func<WordExtractContentByTitleInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractSectionByTitleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByTitle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractSectionByTitleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractContentByBookMarksResponse, ApiConnectionActionConfiguration> WordExtractContentByBookmarks(Expression<Func<WordExtractContentByBookmarksInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractContentByBookMarksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByBookMarks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractContentByBookMarksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<InsertDocumentResponse, ApiConnectionActionConfiguration> WordInsertDocuments(Expression<Func<WordInsertDocumentsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<InsertDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/WordInsertDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InsertDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ApplyStylesResponse, ApiConnectionActionConfiguration> WordApplyStyleToDocument(Expression<Func<WordApplyStyleToDocumentInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ApplyStylesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/WordStyles/ApplyStyleToDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApplyStylesResponse>(callPayload);
            });
        }
    }

    public class AikidocsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidateConnectionResponse
    {
        [JsonProperty("resultMessage")]
        public string ResultMessage { get; set; }
    }

    public class ValidateConnectGoodServiceInput
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ValidateConnectBadServiceInput
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class AppendDocumentResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class WordDocumentParameter
    {
        [JsonProperty("documentContent")]
        public string DocumentContent { get; set; }

        [JsonProperty("documentName")]
        public string DocumentName { get; set; }
    }

    public class WordAppendDocumentsInput
    {
        [JsonProperty("appendDocumentList")]
        public string[] AppendDocumentList { get; set; }
    }

    public class ExtractContentByHeadingResponse
    {
        [JsonProperty("resultDocuments")]
        public WordDocumentParameter[] ResultDocuments { get; set; }
    }

    public class WordExtractContentByHeadingInput
    {
        [JsonProperty("sourceDocument")]
        public WordDocumentParameter SourceDocument { get; set; }

        [JsonProperty("headingStyleName")]
        public string HeadingStyleName { get; set; }
    }

    public class ExtractSectionByTitleResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }
    }

    public class WordExtractContentByTitleInput
    {
        [JsonProperty("sourceDocument")]
        public WordDocumentParameter SourceDocument { get; set; }

        [JsonProperty("headingText")]
        public string HeadingText { get; set; }

        [JsonProperty("headingStyleName")]
        public string HeadingStyleName { get; set; }

        [JsonProperty("headingEscapeStyleNames")]
        public string[] HeadingEscapeStyleNames { get; set; }
    }

    public class ExtractContentByBookMarksResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }
    }

    public class WordExtractContentByBookmarksInput
    {
        [JsonProperty("startBookMark")]
        public string StartBookMark { get; set; }

        [JsonProperty("endBookMark")]
        public string EndBookMark { get; set; }

        [JsonProperty("sourceDocument")]
        public WordDocumentParameter SourceDocument { get; set; }
    }

    public class InsertDocumentResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class WordInsertDocumentsInput
    {
        [JsonProperty("sourceDocument")]
        public WordDocumentParameter SourceDocument { get; set; }

        [JsonProperty("insertDocumentList")]
        public string[] InsertDocumentList { get; set; }

        [JsonProperty("bookmarkName")]
        public string BookmarkName { get; set; }

        [JsonProperty("deleteBookmark")]
        public bool? DeleteBookmark { get; set; }
    }

    public class ApplyStylesResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class WordApplyStyleToDocumentInput
    {
        [JsonProperty("sourceDocument")]
        public WordDocumentParameter SourceDocument { get; set; }

        [JsonProperty("destinationDocument")]
        public WordDocumentParameter DestinationDocument { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aikidocs;

    public partial class WorkflowManagedActions
    {
        public AikidocsActions Aikidocs(string connectionId) => new AikidocsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AikidocsTriggers Aikidocs(string connectionId) => new AikidocsTriggers(connectionId);
    }
}