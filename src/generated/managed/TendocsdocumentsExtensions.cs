//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tendocsdocuments
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TendocsdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiCompareResponse> AiCompare(Expression<Func<string>> requestsourceDocumentfirstFile = null, Expression<Func<string>> requestcomparisonDocumentsecondFile = null, Expression<Func<requestconfigurationprofessionInput>> requestconfigurationprofession = null)
        {
            var __workflow_requestsourceDocumentfirstFile = requestsourceDocumentfirstFile == null ? null : WorkflowExpression.Compile(requestsourceDocumentfirstFile);
            WorkflowExpression.Validate(__workflow_requestsourceDocumentfirstFile, nameof(requestsourceDocumentfirstFile), required: false);
            var __workflow_requestcomparisonDocumentsecondFile = requestcomparisonDocumentsecondFile == null ? null : WorkflowExpression.Compile(requestcomparisonDocumentsecondFile);
            WorkflowExpression.Validate(__workflow_requestcomparisonDocumentsecondFile, nameof(requestcomparisonDocumentsecondFile), required: false);
            var __workflow_requestconfigurationprofession = requestconfigurationprofession == null ? null : WorkflowExpression.Compile(requestconfigurationprofession);
            WorkflowExpression.Validate(__workflow_requestconfigurationprofession, nameof(requestconfigurationprofession), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiSummaryResponse> AiSummary(Expression<Func<string>> requestdocumentfile = null, Expression<Func<int>> requestconfigurationtargetWordCount = null)
        {
            var __workflow_requestdocumentfile = requestdocumentfile == null ? null : WorkflowExpression.Compile(requestdocumentfile);
            WorkflowExpression.Validate(__workflow_requestdocumentfile, nameof(requestdocumentfile), required: false);
            var __workflow_requestconfigurationtargetWordCount = requestconfigurationtargetWordCount == null ? null : WorkflowExpression.Compile(requestconfigurationtargetWordCount);
            WorkflowExpression.Validate(__workflow_requestconfigurationtargetWordCount, nameof(requestconfigurationtargetWordCount), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiTemplateBuilderResponse> AiTemplateBuilder(Expression<Func<string>> requestdescribeTheDocument1000Chars)
        {
            var __workflow_requestdescribeTheDocument1000Chars = requestdescribeTheDocument1000Chars == null ? null : WorkflowExpression.Compile(requestdescribeTheDocument1000Chars);
            WorkflowExpression.Validate(__workflow_requestdescribeTheDocument1000Chars, nameof(requestdescribeTheDocument1000Chars), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> ConversionConvert(Expression<Func<string>> requestdocumentfile = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
        {
            var __workflow_requestdocumentfile = requestdocumentfile == null ? null : WorkflowExpression.Compile(requestdocumentfile);
            WorkflowExpression.Validate(__workflow_requestdocumentfile, nameof(requestdocumentfile), required: false);
            var __workflow_requestconfigurationdocumentFormat = requestconfigurationdocumentFormat == null ? null : WorkflowExpression.Compile(requestconfigurationdocumentFormat);
            WorkflowExpression.Validate(__workflow_requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> DocumentJsonTemplate(Expression<Func<string>> requesttemplatetemplateFile = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
        {
            var __workflow_requesttemplatetemplateFile = requesttemplatetemplateFile == null ? null : WorkflowExpression.Compile(requesttemplatetemplateFile);
            WorkflowExpression.Validate(__workflow_requesttemplatetemplateFile, nameof(requesttemplatetemplateFile), required: false);
            var __workflow_requestconfigurationdocumentFormat = requestconfigurationdocumentFormat == null ? null : WorkflowExpression.Compile(requestconfigurationdocumentFormat);
            WorkflowExpression.Validate(__workflow_requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string> DocumentTemplate(Expression<Func<string>> requesttemplatetemplateFile = null, Expression<Func<requestimageInputItem[]>> requestimage = null, Expression<Func<requestdocumentInputItem[]>> requestdocument = null, Expression<Func<requesttableInputItem[]>> requesttable = null, Expression<Func<requestconfigurationdocumentFormatInput>> requestconfigurationdocumentFormat = null)
        {
            var __workflow_requesttemplatetemplateFile = requesttemplatetemplateFile == null ? null : WorkflowExpression.Compile(requesttemplatetemplateFile);
            WorkflowExpression.Validate(__workflow_requesttemplatetemplateFile, nameof(requesttemplatetemplateFile), required: false);
            var __workflow_requestimage = requestimage == null ? null : WorkflowExpression.Compile(requestimage);
            WorkflowExpression.Validate(__workflow_requestimage, nameof(requestimage), required: false);
            var __workflow_requestdocument = requestdocument == null ? null : WorkflowExpression.Compile(requestdocument);
            WorkflowExpression.Validate(__workflow_requestdocument, nameof(requestdocument), required: false);
            var __workflow_requesttable = requesttable == null ? null : WorkflowExpression.Compile(requesttable);
            WorkflowExpression.Validate(__workflow_requesttable, nameof(requesttable), required: false);
            var __workflow_requestconfigurationdocumentFormat = requestconfigurationdocumentFormat == null ? null : WorkflowExpression.Compile(requestconfigurationdocumentFormat);
            WorkflowExpression.Validate(__workflow_requestconfigurationdocumentFormat, nameof(requestconfigurationdocumentFormat), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<InstancesResponse> EnvelopesInstances(Expression<Func<string>> requestdocumentTitle, Expression<Func<string>> requestdocumentIntroduction, Expression<Func<string>> requestrecipientEmail, Expression<Func<string>> requestrecipientFirstName, Expression<Func<string>> requestrecipientLastName, Expression<Func<string>> requestexpiryDate, Expression<Func<bool>> requestsignatureRequired, Expression<Func<string>> requestorgansiationTitle, Expression<Func<string>> requestorganisationEmail, Expression<Func<string>> requestorganisationOwner, Expression<Func<string>> requestdocumentpDFDocument = null, Expression<Func<string>> requestdocumentLogo = null, Expression<Func<string>> requestcheckbox = null, Expression<Func<string>> requestorganisationWebsite = null, Expression<Func<string>> requestorganisationPhone = null, Expression<Func<string>> requestoragnisationOwnerTitle = null, Expression<Func<bool>> requestcomments = null, Expression<Func<string>> requestprojectID = null, Expression<Func<string>> requestcompleteButtonLabel = null, Expression<Func<string>> requestcompleteDocumentLabel = null, Expression<Func<string>> requestincompleteDocumentLabel = null)
        {
            var __workflow_requestdocumentTitle = requestdocumentTitle == null ? null : WorkflowExpression.Compile(requestdocumentTitle);
            WorkflowExpression.Validate(__workflow_requestdocumentTitle, nameof(requestdocumentTitle), required: true);
            var __workflow_requestdocumentIntroduction = requestdocumentIntroduction == null ? null : WorkflowExpression.Compile(requestdocumentIntroduction);
            WorkflowExpression.Validate(__workflow_requestdocumentIntroduction, nameof(requestdocumentIntroduction), required: true);
            var __workflow_requestrecipientEmail = requestrecipientEmail == null ? null : WorkflowExpression.Compile(requestrecipientEmail);
            WorkflowExpression.Validate(__workflow_requestrecipientEmail, nameof(requestrecipientEmail), required: true);
            var __workflow_requestrecipientFirstName = requestrecipientFirstName == null ? null : WorkflowExpression.Compile(requestrecipientFirstName);
            WorkflowExpression.Validate(__workflow_requestrecipientFirstName, nameof(requestrecipientFirstName), required: true);
            var __workflow_requestrecipientLastName = requestrecipientLastName == null ? null : WorkflowExpression.Compile(requestrecipientLastName);
            WorkflowExpression.Validate(__workflow_requestrecipientLastName, nameof(requestrecipientLastName), required: true);
            var __workflow_requestexpiryDate = requestexpiryDate == null ? null : WorkflowExpression.Compile(requestexpiryDate);
            WorkflowExpression.Validate(__workflow_requestexpiryDate, nameof(requestexpiryDate), required: true);
            var __workflow_requestsignatureRequired = requestsignatureRequired == null ? null : WorkflowExpression.Compile(requestsignatureRequired);
            WorkflowExpression.Validate(__workflow_requestsignatureRequired, nameof(requestsignatureRequired), required: true);
            var __workflow_requestorgansiationTitle = requestorgansiationTitle == null ? null : WorkflowExpression.Compile(requestorgansiationTitle);
            WorkflowExpression.Validate(__workflow_requestorgansiationTitle, nameof(requestorgansiationTitle), required: true);
            var __workflow_requestorganisationEmail = requestorganisationEmail == null ? null : WorkflowExpression.Compile(requestorganisationEmail);
            WorkflowExpression.Validate(__workflow_requestorganisationEmail, nameof(requestorganisationEmail), required: true);
            var __workflow_requestorganisationOwner = requestorganisationOwner == null ? null : WorkflowExpression.Compile(requestorganisationOwner);
            WorkflowExpression.Validate(__workflow_requestorganisationOwner, nameof(requestorganisationOwner), required: true);
            var __workflow_requestdocumentpDFDocument = requestdocumentpDFDocument == null ? null : WorkflowExpression.Compile(requestdocumentpDFDocument);
            WorkflowExpression.Validate(__workflow_requestdocumentpDFDocument, nameof(requestdocumentpDFDocument), required: false);
            var __workflow_requestdocumentLogo = requestdocumentLogo == null ? null : WorkflowExpression.Compile(requestdocumentLogo);
            WorkflowExpression.Validate(__workflow_requestdocumentLogo, nameof(requestdocumentLogo), required: false);
            var __workflow_requestcheckbox = requestcheckbox == null ? null : WorkflowExpression.Compile(requestcheckbox);
            WorkflowExpression.Validate(__workflow_requestcheckbox, nameof(requestcheckbox), required: false);
            var __workflow_requestorganisationWebsite = requestorganisationWebsite == null ? null : WorkflowExpression.Compile(requestorganisationWebsite);
            WorkflowExpression.Validate(__workflow_requestorganisationWebsite, nameof(requestorganisationWebsite), required: false);
            var __workflow_requestorganisationPhone = requestorganisationPhone == null ? null : WorkflowExpression.Compile(requestorganisationPhone);
            WorkflowExpression.Validate(__workflow_requestorganisationPhone, nameof(requestorganisationPhone), required: false);
            var __workflow_requestoragnisationOwnerTitle = requestoragnisationOwnerTitle == null ? null : WorkflowExpression.Compile(requestoragnisationOwnerTitle);
            WorkflowExpression.Validate(__workflow_requestoragnisationOwnerTitle, nameof(requestoragnisationOwnerTitle), required: false);
            var __workflow_requestcomments = requestcomments == null ? null : WorkflowExpression.Compile(requestcomments);
            WorkflowExpression.Validate(__workflow_requestcomments, nameof(requestcomments), required: false);
            var __workflow_requestprojectID = requestprojectID == null ? null : WorkflowExpression.Compile(requestprojectID);
            WorkflowExpression.Validate(__workflow_requestprojectID, nameof(requestprojectID), required: false);
            var __workflow_requestcompleteButtonLabel = requestcompleteButtonLabel == null ? null : WorkflowExpression.Compile(requestcompleteButtonLabel);
            WorkflowExpression.Validate(__workflow_requestcompleteButtonLabel, nameof(requestcompleteButtonLabel), required: false);
            var __workflow_requestcompleteDocumentLabel = requestcompleteDocumentLabel == null ? null : WorkflowExpression.Compile(requestcompleteDocumentLabel);
            WorkflowExpression.Validate(__workflow_requestcompleteDocumentLabel, nameof(requestcompleteDocumentLabel), required: false);
            var __workflow_requestincompleteDocumentLabel = requestincompleteDocumentLabel == null ? null : WorkflowExpression.Compile(requestincompleteDocumentLabel);
            WorkflowExpression.Validate(__workflow_requestincompleteDocumentLabel, nameof(requestincompleteDocumentLabel), required: false);
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
            });
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
