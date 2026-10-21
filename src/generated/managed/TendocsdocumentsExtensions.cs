//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tendocsdocuments
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TendocsdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiCompareResponse> AiCompare(Expression<Func<string>> requestsourceDocumentfirstFile = null, Expression<Func<string>> requestcomparisonDocumentsecondFile = null, Expression<Func<requestconfigurationprofessionInput>> requestconfigurationprofession = null)
        {
            var __workflow_requestsourceDocumentfirstFile = WorkflowExpression.Compile(requestsourceDocumentfirstFile, nameof(requestsourceDocumentfirstFile), required: false);
            var __workflow_requestcomparisonDocumentsecondFile = WorkflowExpression.Compile(requestcomparisonDocumentsecondFile, nameof(requestcomparisonDocumentsecondFile), required: false);
            var __workflow_requestconfigurationprofession = WorkflowExpression.Compile(requestconfigurationprofession, nameof(requestconfigurationprofession), required: false);
            return new DeferredBodyAction<AiCompareResponse>(() =>
            {
                var apiCallPath = "/ai/v1/tasks/compare";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var sourceDocumentObject = new JObject();
                var sourceDocumentObjectpropCount = 0;
                if (__workflow_requestsourceDocumentfirstFile != null)
                {
                    sourceDocumentObject["file"] = ExpressionConverter.ConvertO(__workflow_requestsourceDocumentfirstFile);
                    sourceDocumentObjectpropCount++;
                }

                if (sourceDocumentObjectpropCount > 0)
                {
                    request["sourceDocument"] = sourceDocumentObject;
                    requestpropCount++;
                }

                var comparisonDocumentObject = new JObject();
                var comparisonDocumentObjectpropCount = 0;
                if (__workflow_requestcomparisonDocumentsecondFile != null)
                {
                    comparisonDocumentObject["file"] = ExpressionConverter.ConvertO(__workflow_requestcomparisonDocumentsecondFile);
                    comparisonDocumentObjectpropCount++;
                }

                if (comparisonDocumentObjectpropCount > 0)
                {
                    request["comparisonDocument"] = comparisonDocumentObject;
                    requestpropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (__workflow_requestconfigurationprofession != null)
                {
                    configurationObject["profession"] = ExpressionConverter.ConvertO(__workflow_requestconfigurationprofession);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiSummaryResponse> AiSummary(Expression<Func<string>> requestdocumentfile = null, Expression<Func<int>> requestconfigurationtargetWordCount = null)
        {
            var __workflow_requestdocumentfile = WorkflowExpression.Compile(requestdocumentfile, nameof(requestdocumentfile), required: false);
            var __workflow_requestconfigurationtargetWordCount = WorkflowExpression.Compile(requestconfigurationtargetWordCount, nameof(requestconfigurationtargetWordCount), required: false);
            return new DeferredBodyAction<AiSummaryResponse>(() =>
            {
                var apiCallPath = "/ai/v1/tasks/summary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_requestdocumentfile != null)
                {
                    documentObject["file"] = ExpressionConverter.ConvertO(__workflow_requestdocumentfile);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    request["document"] = documentObject;
                    requestpropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (__workflow_requestconfigurationtargetWordCount != null)
                {
                    configurationObject["targetWords"] = ExpressionConverter.ConvertO(__workflow_requestconfigurationtargetWordCount);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiTemplateBuilderResponse> AiTemplateBuilder(Expression<Func<string>> requestdescribeTheDocument1000Chars)
        {
            var __workflow_requestdescribeTheDocument1000Chars = WorkflowExpression.Compile(requestdescribeTheDocument1000Chars, nameof(requestdescribeTheDocument1000Chars), required: true);
            return new DeferredBodyAction<AiTemplateBuilderResponse>(() =>
            {
                var apiCallPath = "/ai/v1/tasks/templateBuilder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["description"] = ExpressionConverter.ConvertO(__workflow_requestdescribeTheDocument1000Chars);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> ConversionConvert(Expression<Func<string>> requestdocumentfile = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
        {
            var __workflow_requestdocumentfile = WorkflowExpression.Compile(requestdocumentfile, nameof(requestdocumentfile), required: false);
            var __workflow_requestconfigurationdocumentFormat = WorkflowExpression.Compile(requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/conversion/v1/convert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_requestdocumentfile != null)
                {
                    documentObject["file"] = ExpressionConverter.ConvertO(__workflow_requestdocumentfile);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    request["document"] = documentObject;
                    requestpropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (__workflow_requestconfigurationdocumentFormat != null)
                {
                    configurationObject["documentResponseFormat"] = ExpressionConverter.ConvertO(__workflow_requestconfigurationdocumentFormat);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> DocumentJsonTemplate(Expression<Func<string>> requesttemplatetemplateFile = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
        {
            var __workflow_requesttemplatetemplateFile = WorkflowExpression.Compile(requesttemplatetemplateFile, nameof(requesttemplatetemplateFile), required: false);
            var __workflow_requestconfigurationdocumentFormat = WorkflowExpression.Compile(requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/documents/v1/jsonTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (__workflow_requesttemplatetemplateFile != null)
                {
                    templateObject["file"] = ExpressionConverter.ConvertO(__workflow_requesttemplatetemplateFile);
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
                if (__workflow_requestconfigurationdocumentFormat != null)
                {
                    configurationObject["documentResponseFormat"] = ExpressionConverter.ConvertO(__workflow_requestconfigurationdocumentFormat);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> DocumentTemplate(Expression<Func<string>> requesttemplatetemplateFile = null, Expression<Func<requestimageInputItem[]>> requestimage = null, Expression<Func<requestdocumentInputItem[]>> requestdocument = null, Expression<Func<requesttableInputItem[]>> requesttable = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
        {
            var __workflow_requesttemplatetemplateFile = WorkflowExpression.Compile(requesttemplatetemplateFile, nameof(requesttemplatetemplateFile), required: false);
            var __workflow_requestimage = WorkflowExpression.Compile(requestimage, nameof(requestimage), required: false);
            var __workflow_requestdocument = WorkflowExpression.Compile(requestdocument, nameof(requestdocument), required: false);
            var __workflow_requesttable = WorkflowExpression.Compile(requesttable, nameof(requesttable), required: false);
            var __workflow_requestconfigurationdocumentFormat = WorkflowExpression.Compile(requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/documents/v1/template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (__workflow_requesttemplatetemplateFile != null)
                {
                    templateObject["file"] = ExpressionConverter.ConvertO(__workflow_requesttemplatetemplateFile);
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    request["template"] = templateObject;
                    requestpropCount++;
                }

                if (__workflow_requestimage != null)
                {
                    request["images"] = ExpressionConverter.ConvertO(__workflow_requestimage);
                    requestpropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (textObjectpropCount > 0)
                {
                    request["text"] = textObject;
                    requestpropCount++;
                }

                if (__workflow_requestdocument != null)
                {
                    request["substituteDocuments"] = ExpressionConverter.ConvertO(__workflow_requestdocument);
                    requestpropCount++;
                }

                if (__workflow_requesttable != null)
                {
                    request["tables"] = ExpressionConverter.ConvertO(__workflow_requesttable);
                    requestpropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (__workflow_requestconfigurationdocumentFormat != null)
                {
                    configurationObject["documentresponseformat"] = ExpressionConverter.ConvertO(__workflow_requestconfigurationdocumentFormat);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<InstancesResponse> EnvelopesInstances(Expression<Func<string>> requestdocumentTitle, Expression<Func<string>> requestdocumentIntroduction, Expression<Func<string>> requestrecipientEmail, Expression<Func<string>> requestrecipientFirstName, Expression<Func<string>> requestrecipientLastName, Expression<Func<string>> requestexpiryDate, Expression<Func<bool>> requestsignatureRequired, Expression<Func<string>> requestorgansiationTitle, Expression<Func<string>> requestorganisationEmail, Expression<Func<string>> requestorganisationOwner, Expression<Func<string>> requestdocumentpDFDocument = null, Expression<Func<string>> requestdocumentLogo = null, Expression<Func<string>> requestcheckbox = null, Expression<Func<string>> requestorganisationWebsite = null, Expression<Func<string>> requestorganisationPhone = null, Expression<Func<string>> requestoragnisationOwnerTitle = null, Expression<Func<bool>> requestcomments = null, Expression<Func<string>> requestprojectID = null, Expression<Func<string>> requestcompleteButtonLabel = null, Expression<Func<string>> requestcompleteDocumentLabel = null, Expression<Func<string>> requestincompleteDocumentLabel = null)
        {
            var __workflow_requestdocumentTitle = WorkflowExpression.Compile(requestdocumentTitle, nameof(requestdocumentTitle), required: true);
            var __workflow_requestdocumentIntroduction = WorkflowExpression.Compile(requestdocumentIntroduction, nameof(requestdocumentIntroduction), required: true);
            var __workflow_requestrecipientEmail = WorkflowExpression.Compile(requestrecipientEmail, nameof(requestrecipientEmail), required: true);
            var __workflow_requestrecipientFirstName = WorkflowExpression.Compile(requestrecipientFirstName, nameof(requestrecipientFirstName), required: true);
            var __workflow_requestrecipientLastName = WorkflowExpression.Compile(requestrecipientLastName, nameof(requestrecipientLastName), required: true);
            var __workflow_requestexpiryDate = WorkflowExpression.Compile(requestexpiryDate, nameof(requestexpiryDate), required: true);
            var __workflow_requestsignatureRequired = WorkflowExpression.Compile(requestsignatureRequired, nameof(requestsignatureRequired), required: true);
            var __workflow_requestorgansiationTitle = WorkflowExpression.Compile(requestorgansiationTitle, nameof(requestorgansiationTitle), required: true);
            var __workflow_requestorganisationEmail = WorkflowExpression.Compile(requestorganisationEmail, nameof(requestorganisationEmail), required: true);
            var __workflow_requestorganisationOwner = WorkflowExpression.Compile(requestorganisationOwner, nameof(requestorganisationOwner), required: true);
            var __workflow_requestdocumentpDFDocument = WorkflowExpression.Compile(requestdocumentpDFDocument, nameof(requestdocumentpDFDocument), required: false);
            var __workflow_requestdocumentLogo = WorkflowExpression.Compile(requestdocumentLogo, nameof(requestdocumentLogo), required: false);
            var __workflow_requestcheckbox = WorkflowExpression.Compile(requestcheckbox, nameof(requestcheckbox), required: false);
            var __workflow_requestorganisationWebsite = WorkflowExpression.Compile(requestorganisationWebsite, nameof(requestorganisationWebsite), required: false);
            var __workflow_requestorganisationPhone = WorkflowExpression.Compile(requestorganisationPhone, nameof(requestorganisationPhone), required: false);
            var __workflow_requestoragnisationOwnerTitle = WorkflowExpression.Compile(requestoragnisationOwnerTitle, nameof(requestoragnisationOwnerTitle), required: false);
            var __workflow_requestcomments = WorkflowExpression.Compile(requestcomments, nameof(requestcomments), required: false);
            var __workflow_requestprojectID = WorkflowExpression.Compile(requestprojectID, nameof(requestprojectID), required: false);
            var __workflow_requestcompleteButtonLabel = WorkflowExpression.Compile(requestcompleteButtonLabel, nameof(requestcompleteButtonLabel), required: false);
            var __workflow_requestcompleteDocumentLabel = WorkflowExpression.Compile(requestcompleteDocumentLabel, nameof(requestcompleteDocumentLabel), required: false);
            var __workflow_requestincompleteDocumentLabel = WorkflowExpression.Compile(requestincompleteDocumentLabel, nameof(requestincompleteDocumentLabel), required: false);
            return new DeferredBodyAction<InstancesResponse>(() =>
            {
                var apiCallPath = "/envelopes/v1/instances";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_requestdocumentpDFDocument != null)
                {
                    documentObject["file"] = ExpressionConverter.ConvertO(__workflow_requestdocumentpDFDocument);
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
                request["title"] = ExpressionConverter.ConvertO(__workflow_requestdocumentTitle);
                requestpropCount++;
                request["introduction"] = ExpressionConverter.ConvertO(__workflow_requestdocumentIntroduction);
                if (__workflow_requestdocumentLogo != null)
                {
                    request["logoUrl"] = ExpressionConverter.ConvertO(__workflow_requestdocumentLogo);
                    requestpropCount++;
                }

                requestpropCount++;
                request["email"] = ExpressionConverter.ConvertO(__workflow_requestrecipientEmail);
                requestpropCount++;
                request["firstName"] = ExpressionConverter.ConvertO(__workflow_requestrecipientFirstName);
                requestpropCount++;
                request["lastName"] = ExpressionConverter.ConvertO(__workflow_requestrecipientLastName);
                if (__workflow_requestcheckbox != null)
                {
                    request["checkboxText"] = ExpressionConverter.ConvertO(__workflow_requestcheckbox);
                    requestpropCount++;
                }

                requestpropCount++;
                request["expiry"] = ExpressionConverter.ConvertO(__workflow_requestexpiryDate);
                requestpropCount++;
                request["isSignatureRequired"] = ExpressionConverter.ConvertO(__workflow_requestsignatureRequired);
                requestpropCount++;
                request["organisationTitle"] = ExpressionConverter.ConvertO(__workflow_requestorgansiationTitle);
                if (__workflow_requestorganisationWebsite != null)
                {
                    request["organisationWebsite"] = ExpressionConverter.ConvertO(__workflow_requestorganisationWebsite);
                    requestpropCount++;
                }

                requestpropCount++;
                request["organisationContactEmail"] = ExpressionConverter.ConvertO(__workflow_requestorganisationEmail);
                if (__workflow_requestorganisationPhone != null)
                {
                    request["organisationContactPhone"] = ExpressionConverter.ConvertO(__workflow_requestorganisationPhone);
                    requestpropCount++;
                }

                requestpropCount++;
                request["organisationContactName"] = ExpressionConverter.ConvertO(__workflow_requestorganisationOwner);
                if (__workflow_requestoragnisationOwnerTitle != null)
                {
                    request["organisationContactTitle"] = ExpressionConverter.ConvertO(__workflow_requestoragnisationOwnerTitle);
                    requestpropCount++;
                }

                if (__workflow_requestcomments != null)
                {
                    request["commentsEnabled"] = ExpressionConverter.ConvertO(__workflow_requestcomments);
                    requestpropCount++;
                }

                if (__workflow_requestprojectID != null)
                {
                    request["projectIdentifier"] = ExpressionConverter.ConvertO(__workflow_requestprojectID);
                    requestpropCount++;
                }

                if (__workflow_requestcompleteButtonLabel != null)
                {
                    request["completeButtonLabel"] = ExpressionConverter.ConvertO(__workflow_requestcompleteButtonLabel);
                    requestpropCount++;
                }

                if (__workflow_requestcompleteDocumentLabel != null)
                {
                    request["completeStatusLabel"] = ExpressionConverter.ConvertO(__workflow_requestcompleteDocumentLabel);
                    requestpropCount++;
                }

                if (__workflow_requestincompleteDocumentLabel != null)
                {
                    request["incompleteStatusLabel"] = ExpressionConverter.ConvertO(__workflow_requestincompleteDocumentLabel);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<InstancesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
