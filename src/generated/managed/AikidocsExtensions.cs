//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aikidocs
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AikidocsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        [WorkflowExpressionFactory(nameof(__BuildValidateConnectGoodService))]
        public IBodyWorkflowAction<ValidateConnectionResponse> ValidateConnectGoodService([WorkflowExpression] Func<string> bodymessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateConnectionResponse> __BuildValidateConnectGoodService(WorkflowValue<string> bodymessage = null)
        {
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<ValidateConnectionResponse>(() =>
            {
                var apiCallPath = "/good";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
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
        [WorkflowExpressionFactory(nameof(__BuildValidateConnectBadService))]
        public IBodyWorkflowAction<ValidateConnectionResponse> ValidateConnectBadService([WorkflowExpression] Func<string> bodymessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateConnectionResponse> __BuildValidateConnectBadService(WorkflowValue<string> bodymessage = null)
        {
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<ValidateConnectionResponse>(() =>
            {
                var apiCallPath = "/bad";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
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
        [WorkflowExpressionFactory(nameof(__BuildWordAppendDocuments))]
        public IBodyWorkflowAction<AppendDocumentResponse> WordAppendDocuments([WorkflowExpression] Func<string[]> bodyappendDocumentList = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AppendDocumentResponse> __BuildWordAppendDocuments(WorkflowValue<string[]> bodyappendDocumentList = null)
        {
            WorkflowValue.Validate(bodyappendDocumentList, nameof(bodyappendDocumentList), required: false);
            return new DeferredBodyAction<AppendDocumentResponse>(() =>
            {
                var apiCallPath = "/api/WordAppendDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyappendDocumentList != null)
                {
                    body["appendDocumentList"] = ExpressionConverter.ConvertO(bodyappendDocumentList);
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
        [WorkflowExpressionFactory(nameof(__BuildWordExtractContentByHeading))]
        public IBodyWorkflowAction<ExtractContentByHeadingResponse> WordExtractContentByHeading([WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null, [WorkflowExpression] Func<string> bodyheadingStyleName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractContentByHeadingResponse> __BuildWordExtractContentByHeading(WorkflowValue<string> bodysourceDocumentdocumentContent = null, WorkflowValue<string> bodysourceDocumentdocumentName = null, WorkflowValue<string> bodyheadingStyleName = null)
        {
            WorkflowValue.Validate(bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            WorkflowValue.Validate(bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            WorkflowValue.Validate(bodyheadingStyleName, nameof(bodyheadingStyleName), required: false);
            return new DeferredBodyAction<ExtractContentByHeadingResponse>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByHeading";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                if (bodyheadingStyleName != null)
                {
                    body["headingStyleName"] = ExpressionConverter.ConvertO(bodyheadingStyleName);
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
        [WorkflowExpressionFactory(nameof(__BuildWordExtractContentByTitle))]
        public IBodyWorkflowAction<ExtractSectionByTitleResponse> WordExtractContentByTitle([WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null, [WorkflowExpression] Func<string> bodyheadingText = null, [WorkflowExpression] Func<string> bodyheadingStyleName = null, [WorkflowExpression] Func<string[]> bodyheadingEscapeStyleNames = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractSectionByTitleResponse> __BuildWordExtractContentByTitle(WorkflowValue<string> bodysourceDocumentdocumentContent = null, WorkflowValue<string> bodysourceDocumentdocumentName = null, WorkflowValue<string> bodyheadingText = null, WorkflowValue<string> bodyheadingStyleName = null, WorkflowValue<string[]> bodyheadingEscapeStyleNames = null)
        {
            WorkflowValue.Validate(bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            WorkflowValue.Validate(bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            WorkflowValue.Validate(bodyheadingText, nameof(bodyheadingText), required: false);
            WorkflowValue.Validate(bodyheadingStyleName, nameof(bodyheadingStyleName), required: false);
            WorkflowValue.Validate(bodyheadingEscapeStyleNames, nameof(bodyheadingEscapeStyleNames), required: false);
            return new DeferredBodyAction<ExtractSectionByTitleResponse>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByTitle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                if (bodyheadingText != null)
                {
                    body["headingText"] = ExpressionConverter.ConvertO(bodyheadingText);
                    bodypropCount++;
                }

                if (bodyheadingStyleName != null)
                {
                    body["headingStyleName"] = ExpressionConverter.ConvertO(bodyheadingStyleName);
                    bodypropCount++;
                }

                if (bodyheadingEscapeStyleNames != null)
                {
                    body["headingEscapeStyleNames"] = ExpressionConverter.ConvertO(bodyheadingEscapeStyleNames);
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
        [WorkflowExpressionFactory(nameof(__BuildWordExtractContentByBookmarks))]
        public IBodyWorkflowAction<ExtractContentByBookMarksResponse> WordExtractContentByBookmarks([WorkflowExpression] Func<string> bodystartBookMark = null, [WorkflowExpression] Func<string> bodyendBookMark = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractContentByBookMarksResponse> __BuildWordExtractContentByBookmarks(WorkflowValue<string> bodystartBookMark = null, WorkflowValue<string> bodyendBookMark = null, WorkflowValue<string> bodysourceDocumentdocumentContent = null, WorkflowValue<string> bodysourceDocumentdocumentName = null)
        {
            WorkflowValue.Validate(bodystartBookMark, nameof(bodystartBookMark), required: false);
            WorkflowValue.Validate(bodyendBookMark, nameof(bodyendBookMark), required: false);
            WorkflowValue.Validate(bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            WorkflowValue.Validate(bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            return new DeferredBodyAction<ExtractContentByBookMarksResponse>(() =>
            {
                var apiCallPath = "/api/WordExtractContent/ByBookMarks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystartBookMark != null)
                {
                    body["startBookMark"] = ExpressionConverter.ConvertO(bodystartBookMark);
                    bodypropCount++;
                }

                if (bodyendBookMark != null)
                {
                    body["endBookMark"] = ExpressionConverter.ConvertO(bodyendBookMark);
                    bodypropCount++;
                }

                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentName);
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
        [WorkflowExpressionFactory(nameof(__BuildWordInsertDocuments))]
        public IBodyWorkflowAction<InsertDocumentResponse> WordInsertDocuments([WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null, [WorkflowExpression] Func<string[]> bodyinsertDocumentList = null, [WorkflowExpression] Func<string> bodybookmarkName = null, [WorkflowExpression] Func<bool> bodydeleteBookmark = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertDocumentResponse> __BuildWordInsertDocuments(WorkflowValue<string> bodysourceDocumentdocumentContent = null, WorkflowValue<string> bodysourceDocumentdocumentName = null, WorkflowValue<string[]> bodyinsertDocumentList = null, WorkflowValue<string> bodybookmarkName = null, WorkflowValue<bool> bodydeleteBookmark = null)
        {
            WorkflowValue.Validate(bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            WorkflowValue.Validate(bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            WorkflowValue.Validate(bodyinsertDocumentList, nameof(bodyinsertDocumentList), required: false);
            WorkflowValue.Validate(bodybookmarkName, nameof(bodybookmarkName), required: false);
            WorkflowValue.Validate(bodydeleteBookmark, nameof(bodydeleteBookmark), required: false);
            return new DeferredBodyAction<InsertDocumentResponse>(() =>
            {
                var apiCallPath = "/api/WordInsertDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                if (bodyinsertDocumentList != null)
                {
                    body["insertDocumentList"] = ExpressionConverter.ConvertO(bodyinsertDocumentList);
                    bodypropCount++;
                }

                if (bodybookmarkName != null)
                {
                    body["bookmarkName"] = ExpressionConverter.ConvertO(bodybookmarkName);
                    bodypropCount++;
                }

                if (bodydeleteBookmark != null)
                {
                    body["deleteBookmark"] = ExpressionConverter.ConvertO(bodydeleteBookmark);
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
        [WorkflowExpressionFactory(nameof(__BuildWordApplyStyleToDocument))]
        public IBodyWorkflowAction<ApplyStylesResponse> WordApplyStyleToDocument([WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null, [WorkflowExpression] Func<string> bodydestinationDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodydestinationDocumentdocumentName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApplyStylesResponse> __BuildWordApplyStyleToDocument(WorkflowValue<string> bodysourceDocumentdocumentContent = null, WorkflowValue<string> bodysourceDocumentdocumentName = null, WorkflowValue<string> bodydestinationDocumentdocumentContent = null, WorkflowValue<string> bodydestinationDocumentdocumentName = null)
        {
            WorkflowValue.Validate(bodysourceDocumentdocumentContent, nameof(bodysourceDocumentdocumentContent), required: false);
            WorkflowValue.Validate(bodysourceDocumentdocumentName, nameof(bodysourceDocumentdocumentName), required: false);
            WorkflowValue.Validate(bodydestinationDocumentdocumentContent, nameof(bodydestinationDocumentdocumentContent), required: false);
            WorkflowValue.Validate(bodydestinationDocumentdocumentName, nameof(bodydestinationDocumentdocumentName), required: false);
            return new DeferredBodyAction<ApplyStylesResponse>(() =>
            {
                var apiCallPath = "/api/WordStyles/ApplyStyleToDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (bodysourceDocumentdocumentContent != null)
                {
                    sourceDocumentObject["documentContent"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentContent);
                    sourceDocumentObjectpropCount++;
                }

                if (bodysourceDocumentdocumentName != null)
                {
                    sourceDocumentObject["documentName"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentName);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    body["sourceDocument"] = sourceDocumentObject;
                    bodypropCount++;
                }

                var destinationDocumentObject = new JObject();
                var destinationDocumentObjectpropCount = 0;
                if (bodysourceDocumentdocumentContent != null)
                {
                    destinationDocumentObject["documentContent"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentContent);
                    destinationDocumentObjectpropCount++;
                }

                if (bodysourceDocumentdocumentName != null)
                {
                    destinationDocumentObject["documentName"] = ExpressionConverter.ConvertO(bodysourceDocumentdocumentName);
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
