//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aikidocs
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AikidocsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ValidateConnectionResponse> ValidateConnectGoodService(Expression<Func<string>> bodymessage = null)
        {
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<ValidateConnectionResponse>(() =>
            {
                var apiCallPath = "/good";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidateConnectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ValidateConnectionResponse> ValidateConnectBadService(Expression<Func<string>> bodymessage = null)
        {
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<ValidateConnectionResponse>(() =>
            {
                var apiCallPath = "/bad";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidateConnectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<AppendDocumentResponse> WordAppendDocuments(Expression<Func<string[]>> bodyappendDocumentList = null)
        {
            var __workflow_bodyappendDocumentList = bodyappendDocumentList == null ? null : WorkflowExpression.Compile(bodyappendDocumentList);
            WorkflowExpression.Validate(__workflow_bodyappendDocumentList, nameof(bodyappendDocumentList), required: false);
            return new DeferredBodyAction<AppendDocumentResponse>(() =>
            {
                var apiCallPath = "/api/WordAppendDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyappendDocumentList != null)
                {
                    body["appendDocumentList"] = ExpressionConverter.ConvertO(__workflow_bodyappendDocumentList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AppendDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractContentByHeadingResponse> WordExtractContentByHeading(Expression<Func<string>> bodysourceDocumentdocumentContent = null, Expression<Func<string>> bodysourceDocumentdocumentName = null, Expression<Func<string>> bodyheadingStyleName = null)
        {
            var __workflow_bodysourceDocumentdocumentContent = bodysourceDocumentdocumentContent == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentContent);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            var __workflow_bodysourceDocumentdocumentName = bodysourceDocumentdocumentName == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            var __workflow_bodyheadingStyleName = bodyheadingStyleName == null ? null : WorkflowExpression.Compile(bodyheadingStyleName);
            WorkflowExpression.Validate(__workflow_bodyheadingStyleName, nameof(bodyheadingStyleName), required: false);
            return new DeferredBodyAction<ExtractContentByHeadingResponse>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByHeading";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (__workflow_bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (__workflow_bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                if (__workflow_bodyheadingStyleName != null)
                {
                    body["headingStyleName"] = ExpressionConverter.ConvertO(__workflow_bodyheadingStyleName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExtractContentByHeadingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractSectionByTitleResponse> WordExtractContentByTitle(Expression<Func<string>> bodysourceDocumentdocumentContent = null, Expression<Func<string>> bodysourceDocumentdocumentName = null, Expression<Func<string>> bodyheadingText = null, Expression<Func<string>> bodyheadingStyleName = null, Expression<Func<string[]>> bodyheadingEscapeStyleNames = null)
        {
            var __workflow_bodysourceDocumentdocumentContent = bodysourceDocumentdocumentContent == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentContent);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            var __workflow_bodysourceDocumentdocumentName = bodysourceDocumentdocumentName == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            var __workflow_bodyheadingText = bodyheadingText == null ? null : WorkflowExpression.Compile(bodyheadingText);
            WorkflowExpression.Validate(__workflow_bodyheadingText, nameof(bodyheadingText), required: false);
            var __workflow_bodyheadingStyleName = bodyheadingStyleName == null ? null : WorkflowExpression.Compile(bodyheadingStyleName);
            WorkflowExpression.Validate(__workflow_bodyheadingStyleName, nameof(bodyheadingStyleName), required: false);
            var __workflow_bodyheadingEscapeStyleNames = bodyheadingEscapeStyleNames == null ? null : WorkflowExpression.Compile(bodyheadingEscapeStyleNames);
            WorkflowExpression.Validate(__workflow_bodyheadingEscapeStyleNames, nameof(bodyheadingEscapeStyleNames), required: false);
            return new DeferredBodyAction<ExtractSectionByTitleResponse>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByTitle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (__workflow_bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (__workflow_bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                if (__workflow_bodyheadingText != null)
                {
                    body["headingText"] = ExpressionConverter.ConvertO(__workflow_bodyheadingText);
                    bodypropCount++;
                }

                if (__workflow_bodyheadingStyleName != null)
                {
                    body["headingStyleName"] = ExpressionConverter.ConvertO(__workflow_bodyheadingStyleName);
                    bodypropCount++;
                }

                if (__workflow_bodyheadingEscapeStyleNames != null)
                {
                    body["headingEscapeStyleNames"] = ExpressionConverter.ConvertO(__workflow_bodyheadingEscapeStyleNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExtractSectionByTitleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractContentByBookMarksResponse> WordExtractContentByBookmarks(Expression<Func<string>> bodystartBookMark = null, Expression<Func<string>> bodyendBookMark = null, Expression<Func<string>> bodysourceDocumentdocumentContent = null, Expression<Func<string>> bodysourceDocumentdocumentName = null)
        {
            var __workflow_bodystartBookMark = bodystartBookMark == null ? null : WorkflowExpression.Compile(bodystartBookMark);
            WorkflowExpression.Validate(__workflow_bodystartBookMark, nameof(bodystartBookMark), required: false);
            var __workflow_bodyendBookMark = bodyendBookMark == null ? null : WorkflowExpression.Compile(bodyendBookMark);
            WorkflowExpression.Validate(__workflow_bodyendBookMark, nameof(bodyendBookMark), required: false);
            var __workflow_bodysourceDocumentdocumentContent = bodysourceDocumentdocumentContent == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentContent);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            var __workflow_bodysourceDocumentdocumentName = bodysourceDocumentdocumentName == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            return new DeferredBodyAction<ExtractContentByBookMarksResponse>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByBookMarks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystartBookMark != null)
                {
                    body["startBookMark"] = ExpressionConverter.ConvertO(__workflow_bodystartBookMark);
                    bodypropCount++;
                }

                if (__workflow_bodyendBookMark != null)
                {
                    body["endBookMark"] = ExpressionConverter.ConvertO(__workflow_bodyendBookMark);
                    bodypropCount++;
                }

                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (__workflow_bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (__workflow_bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExtractContentByBookMarksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<InsertDocumentResponse> WordInsertDocuments(Expression<Func<string>> bodysourceDocumentdocumentContent = null, Expression<Func<string>> bodysourceDocumentdocumentName = null, Expression<Func<string[]>> bodyinsertDocumentList = null, Expression<Func<string>> bodybookmarkName = null, Expression<Func<bool>> bodydeleteBookmark = null)
        {
            var __workflow_bodysourceDocumentdocumentContent = bodysourceDocumentdocumentContent == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentContent);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            var __workflow_bodysourceDocumentdocumentName = bodysourceDocumentdocumentName == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            var __workflow_bodyinsertDocumentList = bodyinsertDocumentList == null ? null : WorkflowExpression.Compile(bodyinsertDocumentList);
            WorkflowExpression.Validate(__workflow_bodyinsertDocumentList, nameof(bodyinsertDocumentList), required: false);
            var __workflow_bodybookmarkName = bodybookmarkName == null ? null : WorkflowExpression.Compile(bodybookmarkName);
            WorkflowExpression.Validate(__workflow_bodybookmarkName, nameof(bodybookmarkName), required: false);
            var __workflow_bodydeleteBookmark = bodydeleteBookmark == null ? null : WorkflowExpression.Compile(bodydeleteBookmark);
            WorkflowExpression.Validate(__workflow_bodydeleteBookmark, nameof(bodydeleteBookmark), required: false);
            return new DeferredBodyAction<InsertDocumentResponse>(() =>
            {
                var apiCallPath = "/api/WordInsertDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (__workflow_bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (__workflow_bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                if (__workflow_bodyinsertDocumentList != null)
                {
                    body["insertDocumentList"] = ExpressionConverter.ConvertO(__workflow_bodyinsertDocumentList);
                    bodypropCount++;
                }

                if (__workflow_bodybookmarkName != null)
                {
                    body["bookmarkName"] = ExpressionConverter.ConvertO(__workflow_bodybookmarkName);
                    bodypropCount++;
                }

                if (__workflow_bodydeleteBookmark != null)
                {
                    body["deleteBookmark"] = ExpressionConverter.ConvertO(__workflow_bodydeleteBookmark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InsertDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ApplyStylesResponse> WordApplyStyleToDocument(Expression<Func<string>> bodysourceDocumentdocumentContent = null, Expression<Func<string>> bodysourceDocumentdocumentName = null, Expression<Func<string>> bodydestinationDocumentdocumentContent = null, Expression<Func<string>> bodydestinationDocumentdocumentName = null)
        {
            var __workflow_bodysourceDocumentdocumentContent = bodysourceDocumentdocumentContent == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentContent);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            var __workflow_bodysourceDocumentdocumentName = bodysourceDocumentdocumentName == null ? null : WorkflowExpression.Compile(bodysourceDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            var __workflow_bodydestinationDocumentdocumentContent = bodydestinationDocumentdocumentContent == null ? null : WorkflowExpression.Compile(bodydestinationDocumentdocumentContent);
            WorkflowExpression.Validate(__workflow_bodydestinationDocumentdocumentContent, nameof(bodydestinationDocumentdocumentContent), required: false);
            var __workflow_bodydestinationDocumentdocumentName = bodydestinationDocumentdocumentName == null ? null : WorkflowExpression.Compile(bodydestinationDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_bodydestinationDocumentdocumentName, nameof(bodydestinationDocumentdocumentName), required: false);
            return new DeferredBodyAction<ApplyStylesResponse>(() =>
            {
                var apiCallPath = "/api/WordStyles/ApplyStyleToDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (__workflow_bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (__workflow_bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                var destinationDocumentObject = new JObject();
                var destinationDocumentObjectpropCount = 0;
                if (__workflow_bodysourceDocumentdocumentContent != null)
                {
                    destinationDocumentObject["documentContent"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentContent);
                    destinationDocumentObjectpropCount++;
                }

                if (__workflow_bodysourceDocumentdocumentName != null)
                {
                    destinationDocumentObject["documentName"] = ExpressionConverter.ConvertO(__workflow_bodysourceDocumentdocumentName);
                    destinationDocumentObjectpropCount++;
                }

                if (destinationDocumentObjectpropCount > 0)
                {
                    body["destinationDocument"] = destinationDocumentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class ExtractContentByHeadingResponse
    {
        [JsonProperty("resultDocuments")]
        public WordDocumentParameter[] ResultDocuments { get; set; }
    }

    public class ExtractSectionByTitleResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }
    }

    public class ExtractContentByBookMarksResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }
    }

    public class InsertDocumentResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class ApplyStylesResponse
    {
        [JsonProperty("resultDocument")]
        public WordDocumentParameter ResultDocument { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
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
