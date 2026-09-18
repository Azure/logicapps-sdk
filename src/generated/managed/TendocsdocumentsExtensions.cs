//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tendocsdocuments
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TendocsdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiCompareResponse> AiCompare([WorkflowExpression] Func<string> requestsourceDocumentfirstFile = null, [WorkflowExpression] Func<string> requestcomparisonDocumentsecondFile = null, [WorkflowExpression] Func<requestconfigurationprofessionInput> requestconfigurationprofession = null)
        {
            var apiCallPath = "/ai/v1/tasks/compare";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            var sourceDocumentObject = new JObject();
            var sourceDocumentObjectpropCount = 0;
            if (requestsourceDocumentfirstFile != null)
            {
                sourceDocumentObject["file"] = ExpressionConverter.ConvertO(requestsourceDocumentfirstFile);
                sourceDocumentObjectpropCount++;
            }

            if (sourceDocumentObjectpropCount > 0)
            {
                request["sourceDocument"] = sourceDocumentObject;
                requestpropCount++;
            }

            var comparisonDocumentObject = new JObject();
            var comparisonDocumentObjectpropCount = 0;
            if (requestcomparisonDocumentsecondFile != null)
            {
                comparisonDocumentObject["file"] = ExpressionConverter.ConvertO(requestcomparisonDocumentsecondFile);
                comparisonDocumentObjectpropCount++;
            }

            if (comparisonDocumentObjectpropCount > 0)
            {
                request["comparisonDocument"] = comparisonDocumentObject;
                requestpropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            if (requestconfigurationprofession != null)
            {
                configurationObject["profession"] = ExpressionConverter.ConvertO(requestconfigurationprofession);
                configurationObjectpropCount++;
            }

            var keysObject = new JObject();
            var keysObjectpropCount = 0;
            if (keysObjectpropCount > 0)
            {
                configurationObject["keys"] = keysObject;
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                request["configuration"] = configurationObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<AiCompareResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiSummaryResponse> AiSummary([WorkflowExpression] Func<string> requestdocumentfile = null, [WorkflowExpression] Func<int> requestconfigurationtargetWordCount = null)
        {
            var apiCallPath = "/ai/v1/tasks/summary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (requestdocumentfile != null)
            {
                documentObject["file"] = ExpressionConverter.ConvertO(requestdocumentfile);
                documentObjectpropCount++;
            }

            if (documentObjectpropCount > 0)
            {
                request["document"] = documentObject;
                requestpropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            if (requestconfigurationtargetWordCount != null)
            {
                configurationObject["targetWords"] = ExpressionConverter.ConvertO(requestconfigurationtargetWordCount);
                configurationObjectpropCount++;
            }

            var keysObject = new JObject();
            var keysObjectpropCount = 0;
            if (keysObjectpropCount > 0)
            {
                configurationObject["keys"] = keysObject;
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                request["configuration"] = configurationObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<AiSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiTemplateBuilderResponse> AiTemplateBuilder([WorkflowExpression] Func<string> requestdescribeTheDocument1000Chars)
        {
            var apiCallPath = "/ai/v1/tasks/templateBuilder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["description"] = ExpressionConverter.ConvertO(requestdescribeTheDocument1000Chars);
            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            var keysObject = new JObject();
            var keysObjectpropCount = 0;
            if (keysObjectpropCount > 0)
            {
                configurationObject["keys"] = keysObject;
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                request["configuration"] = configurationObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<AiTemplateBuilderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> ConversionConvert([WorkflowExpression] Func<string> requestdocumentfile = null, [WorkflowExpression] Func<requestconfigurationdocumentFormatInput> requestconfigurationdocumentFormat = null)
        {
            var apiCallPath = "/conversion/v1/convert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (requestdocumentfile != null)
            {
                documentObject["file"] = ExpressionConverter.ConvertO(requestdocumentfile);
                documentObjectpropCount++;
            }

            if (documentObjectpropCount > 0)
            {
                request["document"] = documentObject;
                requestpropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            if (requestconfigurationdocumentFormat != null)
            {
                configurationObject["documentResponseFormat"] = ExpressionConverter.ConvertO(requestconfigurationdocumentFormat);
                configurationObjectpropCount++;
            }

            var keysObject = new JObject();
            var keysObjectpropCount = 0;
            if (keysObjectpropCount > 0)
            {
                configurationObject["keys"] = keysObject;
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                request["configuration"] = configurationObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> DocumentJsonTemplate([WorkflowExpression] Func<string> requesttemplatetemplateFile = null, [WorkflowExpression] Func<requestconfigurationdocumentFormatInput> requestconfigurationdocumentFormat = null)
        {
            var apiCallPath = "/documents/v1/jsonTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            var templateObject = new JObject();
            var templateObjectpropCount = 0;
            if (requesttemplatetemplateFile != null)
            {
                templateObject["file"] = ExpressionConverter.ConvertO(requesttemplatetemplateFile);
                templateObjectpropCount++;
            }

            if (templateObjectpropCount > 0)
            {
                request["template"] = templateObject;
                requestpropCount++;
            }

            var jsonObject = new JObject();
            var jsonObjectpropCount = 0;
            if (jsonObjectpropCount > 0)
            {
                request["json"] = jsonObject;
                requestpropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            if (requestconfigurationdocumentFormat != null)
            {
                configurationObject["documentResponseFormat"] = ExpressionConverter.ConvertO(requestconfigurationdocumentFormat);
                configurationObjectpropCount++;
            }

            var keysObject = new JObject();
            var keysObjectpropCount = 0;
            if (keysObjectpropCount > 0)
            {
                configurationObject["keys"] = keysObject;
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                request["configuration"] = configurationObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> DocumentTemplate([WorkflowExpression] Func<string> requesttemplatetemplateFile = null, [WorkflowExpression] Func<requestimageInputItem[]> requestimage = null, [WorkflowExpression] Func<requestdocumentInputItem[]> requestdocument = null, [WorkflowExpression] Func<requesttableInputItem[]> requesttable = null, [WorkflowExpression] Func<requestconfigurationdocumentFormatInput> requestconfigurationdocumentFormat = null)
        {
            var apiCallPath = "/documents/v1/template";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            var templateObject = new JObject();
            var templateObjectpropCount = 0;
            if (requesttemplatetemplateFile != null)
            {
                templateObject["file"] = ExpressionConverter.ConvertO(requesttemplatetemplateFile);
                templateObjectpropCount++;
            }

            if (templateObjectpropCount > 0)
            {
                request["template"] = templateObject;
                requestpropCount++;
            }

            if (requestimage != null)
            {
                request["images"] = ExpressionConverter.ConvertO(requestimage);
                requestpropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (textObjectpropCount > 0)
            {
                request["text"] = textObject;
                requestpropCount++;
            }

            if (requestdocument != null)
            {
                request["substituteDocuments"] = ExpressionConverter.ConvertO(requestdocument);
                requestpropCount++;
            }

            if (requesttable != null)
            {
                request["tables"] = ExpressionConverter.ConvertO(requesttable);
                requestpropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            if (requestconfigurationdocumentFormat != null)
            {
                configurationObject["documentresponseformat"] = ExpressionConverter.ConvertO(requestconfigurationdocumentFormat);
                configurationObjectpropCount++;
            }

            var keysObject = new JObject();
            var keysObjectpropCount = 0;
            if (keysObjectpropCount > 0)
            {
                configurationObject["keys"] = keysObject;
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                request["configuration"] = configurationObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<InstancesResponse> EnvelopesInstances([WorkflowExpression] Func<string> requestdocumentTitle, [WorkflowExpression] Func<string> requestdocumentIntroduction, [WorkflowExpression] Func<string> requestrecipientEmail, [WorkflowExpression] Func<string> requestrecipientFirstName, [WorkflowExpression] Func<string> requestrecipientLastName, [WorkflowExpression] Func<string> requestexpiryDate, [WorkflowExpression] Func<bool> requestsignatureRequired, [WorkflowExpression] Func<string> requestorgansiationTitle, [WorkflowExpression] Func<string> requestorganisationEmail, [WorkflowExpression] Func<string> requestorganisationOwner, [WorkflowExpression] Func<string> requestdocumentpDFDocument = null, [WorkflowExpression] Func<string> requestdocumentLogo = null, [WorkflowExpression] Func<string> requestcheckbox = null, [WorkflowExpression] Func<string> requestorganisationWebsite = null, [WorkflowExpression] Func<string> requestorganisationPhone = null, [WorkflowExpression] Func<string> requestoragnisationOwnerTitle = null, [WorkflowExpression] Func<bool> requestcomments = null, [WorkflowExpression] Func<string> requestprojectID = null, [WorkflowExpression] Func<string> requestcompleteButtonLabel = null, [WorkflowExpression] Func<string> requestcompleteDocumentLabel = null, [WorkflowExpression] Func<string> requestincompleteDocumentLabel = null)
        {
            var apiCallPath = "/envelopes/v1/instances";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (requestdocumentpDFDocument != null)
            {
                documentObject["file"] = ExpressionConverter.ConvertO(requestdocumentpDFDocument);
                documentObjectpropCount++;
            }

            if (documentObjectpropCount > 0)
            {
                request["document"] = documentObject;
                requestpropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            var keysObject = new JObject();
            var keysObjectpropCount = 0;
            if (keysObjectpropCount > 0)
            {
                configurationObject["keys"] = keysObject;
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                request["configuration"] = configurationObject;
                requestpropCount++;
            }

            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requestdocumentTitle);
            requestpropCount++;
            request["introduction"] = ExpressionConverter.ConvertO(requestdocumentIntroduction);
            if (requestdocumentLogo != null)
            {
                request["logoUrl"] = ExpressionConverter.ConvertO(requestdocumentLogo);
                requestpropCount++;
            }

            requestpropCount++;
            request["email"] = ExpressionConverter.ConvertO(requestrecipientEmail);
            requestpropCount++;
            request["firstName"] = ExpressionConverter.ConvertO(requestrecipientFirstName);
            requestpropCount++;
            request["lastName"] = ExpressionConverter.ConvertO(requestrecipientLastName);
            if (requestcheckbox != null)
            {
                request["checkboxText"] = ExpressionConverter.ConvertO(requestcheckbox);
                requestpropCount++;
            }

            requestpropCount++;
            request["expiry"] = ExpressionConverter.ConvertO(requestexpiryDate);
            requestpropCount++;
            request["isSignatureRequired"] = ExpressionConverter.ConvertO(requestsignatureRequired);
            requestpropCount++;
            request["organisationTitle"] = ExpressionConverter.ConvertO(requestorgansiationTitle);
            if (requestorganisationWebsite != null)
            {
                request["organisationWebsite"] = ExpressionConverter.ConvertO(requestorganisationWebsite);
                requestpropCount++;
            }

            requestpropCount++;
            request["organisationContactEmail"] = ExpressionConverter.ConvertO(requestorganisationEmail);
            if (requestorganisationPhone != null)
            {
                request["organisationContactPhone"] = ExpressionConverter.ConvertO(requestorganisationPhone);
                requestpropCount++;
            }

            requestpropCount++;
            request["organisationContactName"] = ExpressionConverter.ConvertO(requestorganisationOwner);
            if (requestoragnisationOwnerTitle != null)
            {
                request["organisationContactTitle"] = ExpressionConverter.ConvertO(requestoragnisationOwnerTitle);
                requestpropCount++;
            }

            if (requestcomments != null)
            {
                request["commentsEnabled"] = ExpressionConverter.ConvertO(requestcomments);
                requestpropCount++;
            }

            if (requestprojectID != null)
            {
                request["projectIdentifier"] = ExpressionConverter.ConvertO(requestprojectID);
                requestpropCount++;
            }

            if (requestcompleteButtonLabel != null)
            {
                request["completeButtonLabel"] = ExpressionConverter.ConvertO(requestcompleteButtonLabel);
                requestpropCount++;
            }

            if (requestcompleteDocumentLabel != null)
            {
                request["completeStatusLabel"] = ExpressionConverter.ConvertO(requestcompleteDocumentLabel);
                requestpropCount++;
            }

            if (requestincompleteDocumentLabel != null)
            {
                request["incompleteStatusLabel"] = ExpressionConverter.ConvertO(requestincompleteDocumentLabel);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<InstancesResponse>(callPayload);
        }
    }

    public class TendocsdocumentsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AiCompareResponse
    {
        [JsonProperty("differences")]
        public AiCompareResponseDifferencesTypeItem[] Differences { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class AiCompareResponseDifferencesTypeItem
    {
        [JsonProperty("aspect")]
        public string Aspect { get; set; }

        [JsonProperty("detailSummary")]
        public string Summary { get; set; }

        [JsonProperty("detail")]
        public AiCompareResponseDifferencesTypeItemDetailsTypeItem[] Details { get; set; }

        [JsonProperty("importance")]
        public string Importance { get; set; }
    }

    public class AiCompareResponseDifferencesTypeItemDetailsTypeItem
    {
        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("summary")]
        public string DocumentSummary { get; set; }
    }

    public enum requestconfigurationprofessionInput
    {
        Doctor,
        Editor,
        Lawyer,
        General
    }

    public class AiSummaryResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public string Summary { get; set; }

        [JsonProperty("targetWords")]
        public double Target { get; set; }

        [JsonProperty("lengthWords")]
        public double Length { get; set; }
    }

    public class AiTemplateBuilderResponse
    {
        [JsonProperty("title")]
        public string DocumentTitle { get; set; }

        [JsonProperty("filename")]
        public string DocumentFilename { get; set; }

        [JsonProperty("outline")]
        public AiTemplateBuilderResponseOutlineTypeItem[] Outline { get; set; }
    }

    public class AiTemplateBuilderResponseOutlineTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }

        [JsonProperty("subheadings")]
        public AiTemplateBuilderResponseOutlineTypeItemSubheadingsTypeItem[] Subheadings { get; set; }
    }

    public class AiTemplateBuilderResponseOutlineTypeItemSubheadingsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }

        [JsonProperty("subheadings")]
        public JToken[] Subsections { get; set; }
    }

    public enum requestconfigurationdocumentFormatInput
    {
        Original,
        PDF,
        HTML
    }

    public class requestimageInputItem
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("file")]
        public string FileContent { get; set; }
    }

    public class requestdocumentInputItem
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("file")]
        public string FileContent { get; set; }
    }

    public class requesttableInputItem
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("rows")]
        public JToken Rows { get; set; }
    }

    public class InstancesResponse
    {
        [JsonProperty("url")]
        public string DocumentUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tendocsdocuments;

    public partial class WorkflowManagedActions
    {
        public TendocsdocumentsActions Tendocsdocuments(string connectionId) => new TendocsdocumentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TendocsdocumentsTriggers Tendocsdocuments(string connectionId) => new TendocsdocumentsTriggers(connectionId);
    }
}