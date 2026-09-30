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
        public IBodyWorkflowAction<AiCompareResponse> AiCompare([WorkflowExpression] Func<string> requestsourceDocumentfirstFile = null, [WorkflowExpression] Func<string> requestcomparisonDocumentsecondFile = null, [WorkflowExpression] Func<requestconfigurationprofessionInput> requestconfigurationprofession = null)
        {
            SourceExpression.Validate(requestsourceDocumentfirstFile, nameof(requestsourceDocumentfirstFile), required: false);
            SourceExpression.Validate(requestcomparisonDocumentsecondFile, nameof(requestcomparisonDocumentsecondFile), required: false);
            SourceExpression.Validate(requestconfigurationprofession, nameof(requestconfigurationprofession), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    sourceDocumentObject["file"] = SourceExpressionConverter.ConvertToken(requestsourceDocumentfirstFile);
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
                    comparisonDocumentObject["file"] = SourceExpressionConverter.ConvertToken(requestcomparisonDocumentsecondFile);
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
                    configurationObject["profession"] = SourceExpressionConverter.Convert(requestconfigurationprofession);
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
                return callPayload;
            }

            return new ApiConnectionAction<AiCompareResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiSummaryResponse> AiSummary([WorkflowExpression] Func<string> requestdocumentFile = null, [WorkflowExpression] Func<int> requestconfigurationtargetWordCount = null)
        {
            SourceExpression.Validate(requestdocumentFile, nameof(requestdocumentFile), required: false);
            SourceExpression.Validate(requestconfigurationtargetWordCount, nameof(requestconfigurationtargetWordCount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ai/v1/tasks/summary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (requestdocumentFile != null)
                {
                    documentObject["file"] = SourceExpressionConverter.ConvertToken(requestdocumentFile);
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
                    configurationObject["targetWords"] = SourceExpressionConverter.ConvertToken(requestconfigurationtargetWordCount);
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
                return callPayload;
            }

            return new ApiConnectionAction<AiSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiTemplateBuilderResponse> AiTemplateBuilder([WorkflowExpression] Func<string> requestdescribeTheDocument1000Chars)
        {
            SourceExpression.Validate(requestdescribeTheDocument1000Chars, nameof(requestdescribeTheDocument1000Chars), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ai/v1/tasks/templateBuilder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["description"] = SourceExpressionConverter.ConvertToken(requestdescribeTheDocument1000Chars);
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
                return callPayload;
            }

            return new ApiConnectionAction<AiTemplateBuilderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> ConversionConvert([WorkflowExpression] Func<string> requestdocumentFile = null, [WorkflowExpression] Func<requestconfigurationdocumentFormatInput> requestconfigurationdocumentFormat = null)
        {
            SourceExpression.Validate(requestdocumentFile, nameof(requestdocumentFile), required: false);
            SourceExpression.Validate(requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversion/v1/convert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (requestdocumentFile != null)
                {
                    documentObject["file"] = SourceExpressionConverter.ConvertToken(requestdocumentFile);
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
                    configurationObject["documentResponseFormat"] = SourceExpressionConverter.Convert(requestconfigurationdocumentFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> DocumentJsonTemplate([WorkflowExpression] Func<string> requesttemplatetemplateFile = null, [WorkflowExpression] Func<requestconfigurationdocumentFormatInput> requestconfigurationdocumentFormat = null)
        {
            SourceExpression.Validate(requesttemplatetemplateFile, nameof(requesttemplatetemplateFile), required: false);
            SourceExpression.Validate(requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    templateObject["file"] = SourceExpressionConverter.ConvertToken(requesttemplatetemplateFile);
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
                    configurationObject["documentResponseFormat"] = SourceExpressionConverter.Convert(requestconfigurationdocumentFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> DocumentTemplate([WorkflowExpression] Func<string> requesttemplatetemplateFile = null, [WorkflowExpression] Func<requestimageInputItem[]> requestimage = null, [WorkflowExpression] Func<requestdocumentInputItem[]> requestdocument = null, [WorkflowExpression] Func<requesttableInputItem[]> requesttable = null, [WorkflowExpression] Func<requestconfigurationdocumentFormatInput> requestconfigurationdocumentFormat = null)
        {
            SourceExpression.Validate(requesttemplatetemplateFile, nameof(requesttemplatetemplateFile), required: false);
            SourceExpression.Validate(requestimage, nameof(requestimage), required: false);
            SourceExpression.Validate(requestdocument, nameof(requestdocument), required: false);
            SourceExpression.Validate(requesttable, nameof(requesttable), required: false);
            SourceExpression.Validate(requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    templateObject["file"] = SourceExpressionConverter.ConvertToken(requesttemplatetemplateFile);
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    request["template"] = templateObject;
                    requestpropCount++;
                }

                if (requestimage != null)
                {
                    request["images"] = SourceExpressionConverter.ConvertToken(requestimage);
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
                    request["substituteDocuments"] = SourceExpressionConverter.ConvertToken(requestdocument);
                    requestpropCount++;
                }

                if (requesttable != null)
                {
                    request["tables"] = SourceExpressionConverter.ConvertToken(requesttable);
                    requestpropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (requestconfigurationdocumentFormat != null)
                {
                    configurationObject["documentresponseformat"] = SourceExpressionConverter.Convert(requestconfigurationdocumentFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<InstancesResponse> EnvelopesInstances([WorkflowExpression] Func<string> requestdocumentTitle, [WorkflowExpression] Func<string> requestdocumentIntroduction, [WorkflowExpression] Func<string> requestrecipientEmail, [WorkflowExpression] Func<string> requestrecipientFirstName, [WorkflowExpression] Func<string> requestrecipientLastName, [WorkflowExpression] Func<string> requestexpiryDate, [WorkflowExpression] Func<bool> requestsignatureRequired, [WorkflowExpression] Func<string> requestorgansiationTitle, [WorkflowExpression] Func<string> requestorganisationEmail, [WorkflowExpression] Func<string> requestorganisationOwner, [WorkflowExpression] Func<string> requestdocumentpDFDocument = null, [WorkflowExpression] Func<string> requestdocumentLogo = null, [WorkflowExpression] Func<string> requestcheckbox = null, [WorkflowExpression] Func<string> requestorganisationWebsite = null, [WorkflowExpression] Func<string> requestorganisationPhone = null, [WorkflowExpression] Func<string> requestoragnisationOwnerTitle = null, [WorkflowExpression] Func<bool> requestcomments = null, [WorkflowExpression] Func<string> requestprojectId = null, [WorkflowExpression] Func<string> requestcompleteButtonLabel = null, [WorkflowExpression] Func<string> requestcompleteDocumentLabel = null, [WorkflowExpression] Func<string> requestincompleteDocumentLabel = null)
        {
            SourceExpression.Validate(requestdocumentTitle, nameof(requestdocumentTitle), required: true);
            SourceExpression.Validate(requestdocumentIntroduction, nameof(requestdocumentIntroduction), required: true);
            SourceExpression.Validate(requestrecipientEmail, nameof(requestrecipientEmail), required: true);
            SourceExpression.Validate(requestrecipientFirstName, nameof(requestrecipientFirstName), required: true);
            SourceExpression.Validate(requestrecipientLastName, nameof(requestrecipientLastName), required: true);
            SourceExpression.Validate(requestexpiryDate, nameof(requestexpiryDate), required: true);
            SourceExpression.Validate(requestsignatureRequired, nameof(requestsignatureRequired), required: true);
            SourceExpression.Validate(requestorgansiationTitle, nameof(requestorgansiationTitle), required: true);
            SourceExpression.Validate(requestorganisationEmail, nameof(requestorganisationEmail), required: true);
            SourceExpression.Validate(requestorganisationOwner, nameof(requestorganisationOwner), required: true);
            SourceExpression.Validate(requestdocumentpDFDocument, nameof(requestdocumentpDFDocument), required: false);
            SourceExpression.Validate(requestdocumentLogo, nameof(requestdocumentLogo), required: false);
            SourceExpression.Validate(requestcheckbox, nameof(requestcheckbox), required: false);
            SourceExpression.Validate(requestorganisationWebsite, nameof(requestorganisationWebsite), required: false);
            SourceExpression.Validate(requestorganisationPhone, nameof(requestorganisationPhone), required: false);
            SourceExpression.Validate(requestoragnisationOwnerTitle, nameof(requestoragnisationOwnerTitle), required: false);
            SourceExpression.Validate(requestcomments, nameof(requestcomments), required: false);
            SourceExpression.Validate(requestprojectId, nameof(requestprojectId), required: false);
            SourceExpression.Validate(requestcompleteButtonLabel, nameof(requestcompleteButtonLabel), required: false);
            SourceExpression.Validate(requestcompleteDocumentLabel, nameof(requestcompleteDocumentLabel), required: false);
            SourceExpression.Validate(requestincompleteDocumentLabel, nameof(requestincompleteDocumentLabel), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    documentObject["file"] = SourceExpressionConverter.ConvertToken(requestdocumentpDFDocument);
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
                request["title"] = SourceExpressionConverter.ConvertToken(requestdocumentTitle);
                requestpropCount++;
                request["introduction"] = SourceExpressionConverter.ConvertToken(requestdocumentIntroduction);
                if (requestdocumentLogo != null)
                {
                    request["logoUrl"] = SourceExpressionConverter.ConvertToken(requestdocumentLogo);
                    requestpropCount++;
                }

                requestpropCount++;
                request["email"] = SourceExpressionConverter.ConvertToken(requestrecipientEmail);
                requestpropCount++;
                request["firstName"] = SourceExpressionConverter.ConvertToken(requestrecipientFirstName);
                requestpropCount++;
                request["lastName"] = SourceExpressionConverter.ConvertToken(requestrecipientLastName);
                if (requestcheckbox != null)
                {
                    request["checkboxText"] = SourceExpressionConverter.ConvertToken(requestcheckbox);
                    requestpropCount++;
                }

                requestpropCount++;
                request["expiry"] = SourceExpressionConverter.ConvertToken(requestexpiryDate);
                requestpropCount++;
                request["isSignatureRequired"] = SourceExpressionConverter.ConvertToken(requestsignatureRequired);
                requestpropCount++;
                request["organisationTitle"] = SourceExpressionConverter.ConvertToken(requestorgansiationTitle);
                if (requestorganisationWebsite != null)
                {
                    request["organisationWebsite"] = SourceExpressionConverter.ConvertToken(requestorganisationWebsite);
                    requestpropCount++;
                }

                requestpropCount++;
                request["organisationContactEmail"] = SourceExpressionConverter.ConvertToken(requestorganisationEmail);
                if (requestorganisationPhone != null)
                {
                    request["organisationContactPhone"] = SourceExpressionConverter.ConvertToken(requestorganisationPhone);
                    requestpropCount++;
                }

                requestpropCount++;
                request["organisationContactName"] = SourceExpressionConverter.ConvertToken(requestorganisationOwner);
                if (requestoragnisationOwnerTitle != null)
                {
                    request["organisationContactTitle"] = SourceExpressionConverter.ConvertToken(requestoragnisationOwnerTitle);
                    requestpropCount++;
                }

                if (requestcomments != null)
                {
                    request["commentsEnabled"] = SourceExpressionConverter.ConvertToken(requestcomments);
                    requestpropCount++;
                }

                if (requestprojectId != null)
                {
                    request["projectIdentifier"] = SourceExpressionConverter.ConvertToken(requestprojectId);
                    requestpropCount++;
                }

                if (requestcompleteButtonLabel != null)
                {
                    request["completeButtonLabel"] = SourceExpressionConverter.ConvertToken(requestcompleteButtonLabel);
                    requestpropCount++;
                }

                if (requestcompleteDocumentLabel != null)
                {
                    request["completeStatusLabel"] = SourceExpressionConverter.ConvertToken(requestcompleteDocumentLabel);
                    requestpropCount++;
                }

                if (requestincompleteDocumentLabel != null)
                {
                    request["incompleteStatusLabel"] = SourceExpressionConverter.ConvertToken(requestincompleteDocumentLabel);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InstancesResponse>(BuildSourceInput);
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