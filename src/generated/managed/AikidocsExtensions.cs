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
        public IBodyWorkflowAction<ValidateConnectionResponse> ValidateConnectGoodService([WorkflowExpression] Func<string> bodymessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ValidateConnectionResponse> ValidateConnectBadService([WorkflowExpression] Func<string> bodymessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<AppendDocumentResponse> WordAppendDocuments([WorkflowExpression] Func<string[]> bodyappendDocumentList = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractContentByHeadingResponse> WordExtractContentByHeading([WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null, [WorkflowExpression] Func<string> bodyheadingStyleName = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractSectionByTitleResponse> WordExtractContentByTitle([WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null, [WorkflowExpression] Func<string> bodyheadingText = null, [WorkflowExpression] Func<string> bodyheadingStyleName = null, [WorkflowExpression] Func<string[]> bodyheadingEscapeStyleNames = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ExtractContentByBookMarksResponse> WordExtractContentByBookmarks([WorkflowExpression] Func<string> bodystartBookMark = null, [WorkflowExpression] Func<string> bodyendBookMark = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<InsertDocumentResponse> WordInsertDocuments([WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null, [WorkflowExpression] Func<string[]> bodyinsertDocumentList = null, [WorkflowExpression] Func<string> bodybookmarkName = null, [WorkflowExpression] Func<bool> bodydeleteBookmark = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aikidocs")]
        public IBodyWorkflowAction<ApplyStylesResponse> WordApplyStyleToDocument([WorkflowExpression] Func<string> bodysourceDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodysourceDocumentdocumentName = null, [WorkflowExpression] Func<string> bodydestinationDocumentdocumentContent = null, [WorkflowExpression] Func<string> bodydestinationDocumentdocumentName = null)
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