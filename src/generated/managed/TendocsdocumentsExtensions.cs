//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tendocsdocuments
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TendocsdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiCompareResponse> AiCompare(Expression<Func<string>> requestsourceDocumentfirstFile = null, Expression<Func<string>> requestcomparisonDocumentsecondFile = null, Expression<Func<requestconfigurationprofessionInput>> requestconfigurationprofession = null)
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
                sourceDocumentObject["file"] = CSharpExpressionConverter.ConvertToken(requestsourceDocumentfirstFile);
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
                comparisonDocumentObject["file"] = CSharpExpressionConverter.ConvertToken(requestcomparisonDocumentsecondFile);
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
                configurationObject["profession"] = CSharpExpressionConverter.Convert(requestconfigurationprofession);
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
        public IBodyWorkflowAction<AiSummaryResponse> AiSummary(Expression<Func<string>> requestdocumentfile = null, Expression<Func<int>> requestconfigurationtargetWordCount = null)
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
                documentObject["file"] = CSharpExpressionConverter.ConvertToken(requestdocumentfile);
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
                configurationObject["targetWords"] = CSharpExpressionConverter.ConvertToken(requestconfigurationtargetWordCount);
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
        public IBodyWorkflowAction<AiTemplateBuilderResponse> AiTemplateBuilder(Expression<Func<string>> requestdescribeTheDocument1000Chars)
        {
            var apiCallPath = "/ai/v1/tasks/templateBuilder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["description"] = CSharpExpressionConverter.ConvertToken(requestdescribeTheDocument1000Chars);
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
        public IBodyWorkflowAction<string> ConversionConvert(Expression<Func<string>> requestdocumentfile = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
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
                documentObject["file"] = CSharpExpressionConverter.ConvertToken(requestdocumentfile);
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
                configurationObject["documentResponseFormat"] = CSharpExpressionConverter.Convert(requestconfigurationdocumentFormat);
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
        public IBodyWorkflowAction<string> DocumentJsonTemplate(Expression<Func<string>> requesttemplatetemplateFile = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
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
                templateObject["file"] = CSharpExpressionConverter.ConvertToken(requesttemplatetemplateFile);
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
                configurationObject["documentResponseFormat"] = CSharpExpressionConverter.Convert(requestconfigurationdocumentFormat);
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
        public IBodyWorkflowAction<string> DocumentTemplate(Expression<Func<string>> requesttemplatetemplateFile = null, Expression<Func<requestimageInputItem[]>> requestimage = null, Expression<Func<requestdocumentInputItem[]>> requestdocument = null, Expression<Func<requesttableInputItem[]>> requesttable = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
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
                templateObject["file"] = CSharpExpressionConverter.ConvertToken(requesttemplatetemplateFile);
                templateObjectpropCount++;
            }

            if (templateObjectpropCount > 0)
            {
                request["template"] = templateObject;
                requestpropCount++;
            }

            if (requestimage != null)
            {
                request["images"] = CSharpExpressionConverter.ConvertToken(requestimage);
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
                request["substituteDocuments"] = CSharpExpressionConverter.ConvertToken(requestdocument);
                requestpropCount++;
            }

            if (requesttable != null)
            {
                request["tables"] = CSharpExpressionConverter.ConvertToken(requesttable);
                requestpropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            if (requestconfigurationdocumentFormat != null)
            {
                configurationObject["documentresponseformat"] = CSharpExpressionConverter.Convert(requestconfigurationdocumentFormat);
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
        public IBodyWorkflowAction<InstancesResponse> EnvelopesInstances(Expression<Func<string>> requestdocumentTitle, Expression<Func<string>> requestdocumentIntroduction, Expression<Func<string>> requestrecipientEmail, Expression<Func<string>> requestrecipientFirstName, Expression<Func<string>> requestrecipientLastName, Expression<Func<string>> requestexpiryDate, Expression<Func<bool>> requestsignatureRequired, Expression<Func<string>> requestorgansiationTitle, Expression<Func<string>> requestorganisationEmail, Expression<Func<string>> requestorganisationOwner, Expression<Func<string>> requestdocumentpDFDocument = null, Expression<Func<string>> requestdocumentLogo = null, Expression<Func<string>> requestcheckbox = null, Expression<Func<string>> requestorganisationWebsite = null, Expression<Func<string>> requestorganisationPhone = null, Expression<Func<string>> requestoragnisationOwnerTitle = null, Expression<Func<bool>> requestcomments = null, Expression<Func<string>> requestprojectID = null, Expression<Func<string>> requestcompleteButtonLabel = null, Expression<Func<string>> requestcompleteDocumentLabel = null, Expression<Func<string>> requestincompleteDocumentLabel = null)
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
                documentObject["file"] = CSharpExpressionConverter.ConvertToken(requestdocumentpDFDocument);
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
            request["title"] = CSharpExpressionConverter.ConvertToken(requestdocumentTitle);
            requestpropCount++;
            request["introduction"] = CSharpExpressionConverter.ConvertToken(requestdocumentIntroduction);
            if (requestdocumentLogo != null)
            {
                request["logoUrl"] = CSharpExpressionConverter.ConvertToken(requestdocumentLogo);
                requestpropCount++;
            }

            requestpropCount++;
            request["email"] = CSharpExpressionConverter.ConvertToken(requestrecipientEmail);
            requestpropCount++;
            request["firstName"] = CSharpExpressionConverter.ConvertToken(requestrecipientFirstName);
            requestpropCount++;
            request["lastName"] = CSharpExpressionConverter.ConvertToken(requestrecipientLastName);
            if (requestcheckbox != null)
            {
                request["checkboxText"] = CSharpExpressionConverter.ConvertToken(requestcheckbox);
                requestpropCount++;
            }

            requestpropCount++;
            request["expiry"] = CSharpExpressionConverter.ConvertToken(requestexpiryDate);
            requestpropCount++;
            request["isSignatureRequired"] = CSharpExpressionConverter.ConvertToken(requestsignatureRequired);
            requestpropCount++;
            request["organisationTitle"] = CSharpExpressionConverter.ConvertToken(requestorgansiationTitle);
            if (requestorganisationWebsite != null)
            {
                request["organisationWebsite"] = CSharpExpressionConverter.ConvertToken(requestorganisationWebsite);
                requestpropCount++;
            }

            requestpropCount++;
            request["organisationContactEmail"] = CSharpExpressionConverter.ConvertToken(requestorganisationEmail);
            if (requestorganisationPhone != null)
            {
                request["organisationContactPhone"] = CSharpExpressionConverter.ConvertToken(requestorganisationPhone);
                requestpropCount++;
            }

            requestpropCount++;
            request["organisationContactName"] = CSharpExpressionConverter.ConvertToken(requestorganisationOwner);
            if (requestoragnisationOwnerTitle != null)
            {
                request["organisationContactTitle"] = CSharpExpressionConverter.ConvertToken(requestoragnisationOwnerTitle);
                requestpropCount++;
            }

            if (requestcomments != null)
            {
                request["commentsEnabled"] = CSharpExpressionConverter.ConvertToken(requestcomments);
                requestpropCount++;
            }

            if (requestprojectID != null)
            {
                request["projectIdentifier"] = CSharpExpressionConverter.ConvertToken(requestprojectID);
                requestpropCount++;
            }

            if (requestcompleteButtonLabel != null)
            {
                request["completeButtonLabel"] = CSharpExpressionConverter.ConvertToken(requestcompleteButtonLabel);
                requestpropCount++;
            }

            if (requestcompleteDocumentLabel != null)
            {
                request["completeStatusLabel"] = CSharpExpressionConverter.ConvertToken(requestcompleteDocumentLabel);
                requestpropCount++;
            }

            if (requestincompleteDocumentLabel != null)
            {
                request["incompleteStatusLabel"] = CSharpExpressionConverter.ConvertToken(requestincompleteDocumentLabel);
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