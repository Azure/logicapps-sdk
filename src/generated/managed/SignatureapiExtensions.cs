//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signatureapi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignatureapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<CreateEnvelopeOutput> CreateEnvelope(Expression<Func<string>> bodyenvelopeTitle = null, Expression<Func<string>> bodyenvelopeLabel = null, Expression<Func<string>> bodyenvelopeMessage = null, Expression<Func<bodyenvelopeModeInput>> bodyenvelopeMode = null, Expression<Func<bodyenvelopeRoutingInput>> bodyenvelopeRouting = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodytimestampFormat = null, Expression<Func<bodyenvelopeAttestationInput>> bodyenvelopeAttestation = null, Expression<Func<string>> bodysendername = null, Expression<Func<string>> bodysenderemail = null, Expression<Func<string[]>> bodyenvelopeTopics = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_bodyenvelopeTitle = WorkflowExpression.Compile(bodyenvelopeTitle, nameof(bodyenvelopeTitle), required: false);
            var __workflow_bodyenvelopeLabel = WorkflowExpression.Compile(bodyenvelopeLabel, nameof(bodyenvelopeLabel), required: false);
            var __workflow_bodyenvelopeMessage = WorkflowExpression.Compile(bodyenvelopeMessage, nameof(bodyenvelopeMessage), required: false);
            var __workflow_bodyenvelopeMode = WorkflowExpression.Compile(bodyenvelopeMode, nameof(bodyenvelopeMode), required: false);
            var __workflow_bodyenvelopeRouting = WorkflowExpression.Compile(bodyenvelopeRouting, nameof(bodyenvelopeRouting), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodytimestampFormat = WorkflowExpression.Compile(bodytimestampFormat, nameof(bodytimestampFormat), required: false);
            var __workflow_bodyenvelopeAttestation = WorkflowExpression.Compile(bodyenvelopeAttestation, nameof(bodyenvelopeAttestation), required: false);
            var __workflow_bodysendername = WorkflowExpression.Compile(bodysendername, nameof(bodysendername), required: false);
            var __workflow_bodysenderemail = WorkflowExpression.Compile(bodysenderemail, nameof(bodysenderemail), required: false);
            var __workflow_bodyenvelopeTopics = WorkflowExpression.Compile(bodyenvelopeTopics, nameof(bodyenvelopeTopics), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<CreateEnvelopeOutput>(() =>
            {
                var apiCallPath = "/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["draft"] = true;
                bodypropCount++;
                if (__workflow_bodyenvelopeTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopeTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyenvelopeLabel != null)
                {
                    body["label"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopeLabel);
                    bodypropCount++;
                }

                if (__workflow_bodyenvelopeMessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopeMessage);
                    bodypropCount++;
                }

                if (__workflow_bodyenvelopeMode != null)
                {
                    body["mode"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopeMode);
                    bodypropCount++;
                }

                if (__workflow_bodyenvelopeRouting != null)
                {
                    body["routing"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopeRouting);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodytimestampFormat != null)
                {
                    body["timestamp_format"] = ExpressionConverter.ConvertO(__workflow_bodytimestampFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyenvelopeAttestation != null)
                {
                    body["attestation"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopeAttestation);
                    bodypropCount++;
                }

                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (__workflow_bodysendername != null)
                {
                    senderObject["name"] = ExpressionConverter.ConvertO(__workflow_bodysendername);
                    senderObjectpropCount++;
                }

                if (__workflow_bodysenderemail != null)
                {
                    senderObject["email"] = ExpressionConverter.ConvertO(__workflow_bodysenderemail);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (__workflow_bodyenvelopeTopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopeTopics);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateEnvelopeOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction DeleteEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Envelope> GetEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<Envelope>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Capture> GetCapture(Expression<Func<string>> envelopeId, Expression<Func<string>> captureKey)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_captureKey = WorkflowExpression.Compile(captureKey, nameof(captureKey), required: true);
            return new DeferredBodyAction<Capture>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}+alias1", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["captureKey"] = ExpressionConverter.Convert(__workflow_captureKey);
                return new ApiConnectionAction<Capture>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<StartEnvelopeOutput> StartEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<StartEnvelopeOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/start", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StartEnvelopeOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddDocument(Expression<Func<string>> envelopeId, Expression<Func<string>> bodydocumentTitle = null, Expression<Func<string>> bodyfileContent = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodydocumentTitle = WorkflowExpression.Compile(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<AddDocumentOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodydocumentTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfileContent != null)
                {
                    body["file_content"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "pdf";
                bodypropCount++;
                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddDocumentOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddDocumentDocx(Expression<Func<string>> envelopeId, Expression<Func<string>> bodydocumentTitle = null, Expression<Func<string>> bodyfileContent = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodydocumentTitle = WorkflowExpression.Compile(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<AddDocumentOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents+alias1", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodydocumentTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfileContent != null)
                {
                    body["file_content"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "docx";
                bodypropCount++;
                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddDocumentOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddTemplate(Expression<Func<string>> envelopeId, Expression<Func<string>> bodydocumentTitle = null, Expression<Func<string>> bodyfileContent = null, Expression<Func<string[]>> bodytemplateData = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodydocumentTitle = WorkflowExpression.Compile(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: false);
            var __workflow_bodytemplateData = WorkflowExpression.Compile(bodytemplateData, nameof(bodytemplateData), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<AddDocumentOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents+alias2", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodydocumentTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfileContent != null)
                {
                    body["file_content"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "docx";
                bodypropCount++;
                if (__workflow_bodytemplateData != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodytemplateData);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddDocumentOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddTemplateData(Expression<Func<string>> documentId, Expression<Func<string>> bodyfieldName = null, Expression<Func<string>> bodyvalue = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-data", ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldName != null)
                {
                    body["field_name"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceSignature(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<double>> bodyplaceHeight = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyplaceKey = WorkflowExpression.Compile(bodyplaceKey, nameof(bodyplaceKey), required: false);
            var __workflow_bodyrecipientKey = WorkflowExpression.Compile(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            var __workflow_bodyplaceHeight = WorkflowExpression.Compile(bodyplaceHeight, nameof(bodyplaceHeight), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodydistanceFromTop = WorkflowExpression.Compile(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            var __workflow_bodydistanceFromLeft = WorkflowExpression.Compile(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-signature-place", ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "signature";
                bodypropCount++;
                if (__workflow_bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodyplaceKey);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientKey != null)
                {
                    body["recipient_key"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientKey);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceHeight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyplaceHeight);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromTop);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceInitials(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<double>> bodyplaceHeight = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyplaceKey = WorkflowExpression.Compile(bodyplaceKey, nameof(bodyplaceKey), required: false);
            var __workflow_bodyrecipientKey = WorkflowExpression.Compile(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            var __workflow_bodyplaceHeight = WorkflowExpression.Compile(bodyplaceHeight, nameof(bodyplaceHeight), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodydistanceFromTop = WorkflowExpression.Compile(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            var __workflow_bodydistanceFromLeft = WorkflowExpression.Compile(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-initials-place", ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "initials";
                bodypropCount++;
                if (__workflow_bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodyplaceKey);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientKey != null)
                {
                    body["recipient_key"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientKey);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceHeight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyplaceHeight);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromTop);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceTextInput(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<string>> bodycaptureAs = null, Expression<Func<string>> bodyhint = null, Expression<Func<string>> bodyprompt = null, Expression<Func<bodyrequirementInput>> bodyrequirement = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodyformatMessage = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyplaceKey = WorkflowExpression.Compile(bodyplaceKey, nameof(bodyplaceKey), required: false);
            var __workflow_bodyrecipientKey = WorkflowExpression.Compile(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            var __workflow_bodycaptureAs = WorkflowExpression.Compile(bodycaptureAs, nameof(bodycaptureAs), required: false);
            var __workflow_bodyhint = WorkflowExpression.Compile(bodyhint, nameof(bodyhint), required: false);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: false);
            var __workflow_bodyrequirement = WorkflowExpression.Compile(bodyrequirement, nameof(bodyrequirement), required: false);
            var __workflow_bodyformat = WorkflowExpression.Compile(bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodyformatMessage = WorkflowExpression.Compile(bodyformatMessage, nameof(bodyformatMessage), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodydistanceFromTop = WorkflowExpression.Compile(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            var __workflow_bodydistanceFromLeft = WorkflowExpression.Compile(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-text-input-place", ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "text_input";
                bodypropCount++;
                if (__workflow_bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodyplaceKey);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientKey != null)
                {
                    body["recipient_key"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientKey);
                    bodypropCount++;
                }

                if (__workflow_bodycaptureAs != null)
                {
                    body["capture_as"] = ExpressionConverter.ConvertO(__workflow_bodycaptureAs);
                    bodypropCount++;
                }

                if (__workflow_bodyhint != null)
                {
                    body["hint"] = ExpressionConverter.ConvertO(__workflow_bodyhint);
                    bodypropCount++;
                }

                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                if (__workflow_bodyrequirement != null)
                {
                    if (__workflow_bodyrequirement != null)
                    {
                        body["requirement"] = ExpressionConverter.ConvertO(__workflow_bodyrequirement);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["requirement"] = "required";
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                    bodypropCount++;
                }

                if (__workflow_bodyformatMessage != null)
                {
                    body["format_message"] = ExpressionConverter.ConvertO(__workflow_bodyformatMessage);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromTop);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceText(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyvalue = null, Expression<Func<double>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyplaceKey = WorkflowExpression.Compile(bodyplaceKey, nameof(bodyplaceKey), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodyfontSize = WorkflowExpression.Compile(bodyfontSize, nameof(bodyfontSize), required: false);
            var __workflow_bodyfontColor = WorkflowExpression.Compile(bodyfontColor, nameof(bodyfontColor), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodydistanceFromTop = WorkflowExpression.Compile(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            var __workflow_bodydistanceFromLeft = WorkflowExpression.Compile(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-text-place", ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "text";
                bodypropCount++;
                if (__workflow_bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodyplaceKey);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodyfontSize != null)
                {
                    body["font_size"] = ExpressionConverter.ConvertO(__workflow_bodyfontSize);
                    bodypropCount++;
                }

                if (__workflow_bodyfontColor != null)
                {
                    body["font_color"] = ExpressionConverter.ConvertO(__workflow_bodyfontColor);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromTop);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceRecipientCompletedDate(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyplaceKey = WorkflowExpression.Compile(bodyplaceKey, nameof(bodyplaceKey), required: false);
            var __workflow_bodyrecipientKey = WorkflowExpression.Compile(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            var __workflow_bodydateFormat = WorkflowExpression.Compile(bodydateFormat, nameof(bodydateFormat), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodydistanceFromTop = WorkflowExpression.Compile(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            var __workflow_bodydistanceFromLeft = WorkflowExpression.Compile(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-recipient-completed-date-place", ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "recipient_completed_date";
                bodypropCount++;
                if (__workflow_bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodyplaceKey);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientKey != null)
                {
                    body["recipient_key"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientKey);
                    bodypropCount++;
                }

                if (__workflow_bodydateFormat != null)
                {
                    body["date_format"] = ExpressionConverter.ConvertO(__workflow_bodydateFormat);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromTop);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceEnvelopeCompletedDate(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyplaceKey = WorkflowExpression.Compile(bodyplaceKey, nameof(bodyplaceKey), required: false);
            var __workflow_bodydateFormat = WorkflowExpression.Compile(bodydateFormat, nameof(bodydateFormat), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodydistanceFromTop = WorkflowExpression.Compile(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            var __workflow_bodydistanceFromLeft = WorkflowExpression.Compile(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-envelope-completed-date-place", ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "envelope_completed_date";
                bodypropCount++;
                if (__workflow_bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodyplaceKey);
                    bodypropCount++;
                }

                if (__workflow_bodydateFormat != null)
                {
                    body["date_format"] = ExpressionConverter.ConvertO(__workflow_bodydateFormat);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromTop);
                    bodypropCount++;
                }

                if (__workflow_bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(__workflow_bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddRecipientSignerOutput> AddRecipient(Expression<Func<string>> envelopeId, Expression<Func<string>> bodyrecipientName = null, Expression<Func<string>> bodyrecipientEmail = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<bodyrecipientCeremonyCreationInput>> bodyrecipientCeremonyCreation = null, Expression<Func<bodyrecipientDeliveryTypeInput>> bodyrecipientDeliveryType = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodyrecipientName = WorkflowExpression.Compile(bodyrecipientName, nameof(bodyrecipientName), required: false);
            var __workflow_bodyrecipientEmail = WorkflowExpression.Compile(bodyrecipientEmail, nameof(bodyrecipientEmail), required: false);
            var __workflow_bodyrecipientKey = WorkflowExpression.Compile(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            var __workflow_bodyrecipientCeremonyCreation = WorkflowExpression.Compile(bodyrecipientCeremonyCreation, nameof(bodyrecipientCeremonyCreation), required: false);
            var __workflow_bodyrecipientDeliveryType = WorkflowExpression.Compile(bodyrecipientDeliveryType, nameof(bodyrecipientDeliveryType), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<AddRecipientSignerOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "signer";
                bodypropCount++;
                if (__workflow_bodyrecipientName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientName);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientEmail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientKey);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientCeremonyCreation != null)
                {
                    body["ceremony_creation"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientCeremonyCreation);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientDeliveryType != null)
                {
                    body["delivery_type"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientDeliveryType);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddRecipientSignerOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Recipient> GetRecipient(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<Recipient>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recipients/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Recipient>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<JToken> CreateCeremonyEmailLink(Expression<Func<string>> recipientId, Expression<Func<string>> bodyredirectURL = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_bodyredirectURL = WorkflowExpression.Compile(bodyredirectURL, nameof(bodyredirectURL), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recipients/{0}/ceremony", ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var authenticationObject = new JObject();
                var authenticationObjectpropCount = 0;
                authenticationObject["type"] = "email_link";
                authenticationObjectpropCount++;
                if (authenticationObjectpropCount > 0)
                {
                    body["authentication"] = authenticationObject;
                    bodypropCount++;
                }

                if (__workflow_bodyredirectURL != null)
                {
                    body["redirect_url"] = ExpressionConverter.ConvertO(__workflow_bodyredirectURL);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<CreateCeremonyCustomOutput> CreateCeremonyCustom(Expression<Func<string>> recipientId, Expression<Func<string>> bodyauthenticationauthenticationProvider = null, Expression<Func<string[]>> bodyauthenticationauthenticationData = null, Expression<Func<string>> bodyredirectURL = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_bodyauthenticationauthenticationProvider = WorkflowExpression.Compile(bodyauthenticationauthenticationProvider, nameof(bodyauthenticationauthenticationProvider), required: false);
            var __workflow_bodyauthenticationauthenticationData = WorkflowExpression.Compile(bodyauthenticationauthenticationData, nameof(bodyauthenticationauthenticationData), required: false);
            var __workflow_bodyredirectURL = WorkflowExpression.Compile(bodyredirectURL, nameof(bodyredirectURL), required: false);
            var __workflow_bodyextraProperties = WorkflowExpression.Compile(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<CreateCeremonyCustomOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recipients/{0}/ceremony+alias1", ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var authenticationObject = new JObject();
                var authenticationObjectpropCount = 0;
                authenticationObject["type"] = "custom";
                authenticationObjectpropCount++;
                if (__workflow_bodyauthenticationauthenticationProvider != null)
                {
                    authenticationObject["provider"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationauthenticationProvider);
                    authenticationObjectpropCount++;
                }

                if (__workflow_bodyauthenticationauthenticationData != null)
                {
                    authenticationObject["data"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationauthenticationData);
                    authenticationObjectpropCount++;
                }

                if (authenticationObjectpropCount > 0)
                {
                    body["authentication"] = authenticationObject;
                    bodypropCount++;
                }

                if (__workflow_bodyredirectURL != null)
                {
                    body["redirect_url"] = ExpressionConverter.ConvertO(__workflow_bodyredirectURL);
                    bodypropCount++;
                }

                if (__workflow_bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(__workflow_bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCeremonyCustomOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Envelope> WaitEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<Envelope>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/envelopes/{0}/wait", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Deliverable> GetDeliverable(Expression<Func<string>> deliverableId)
        {
            var __workflow_deliverableId = WorkflowExpression.Compile(deliverableId, nameof(deliverableId), required: true);
            return new DeferredBodyAction<Deliverable>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/deliverables/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_deliverableId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Deliverable>(callPayload);
            });
        }
    }

    public class SignatureapiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCreated(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeStarted(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.started";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCompleted(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeFailed(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCanceled(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.canceled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReleased(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.released";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientSent(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.sent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientCompleted(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientRejected(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.rejected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientBounced(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.bounced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientFailed(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReplaced(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.replaced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientResent(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.resent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableGenerated(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/deliverable.generated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableFailed(Expression<Func<string[]>> bodytopics = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytopics = WorkflowExpression.Compile(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/deliverable.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(__workflow_bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateEnvelopeOutput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("sender")]
        public EnvelopeSender Sender { get; set; }

        [JsonProperty("mode")]
        public EnvelopeMode Mode { get; set; }

        [JsonProperty("routing")]
        public EnvelopeRouting Routing { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timestamp_format")]
        public string TimestampFormat { get; set; }

        [JsonProperty("attestation")]
        public EnvelopeAttestation Attestation { get; set; }

        [JsonProperty("topics")]
        public string[] Topics { get; set; }
    }

    public class EnvelopeSender
    {
        [JsonProperty("name")]
        public string SenderName { get; set; }

        [JsonProperty("email")]
        public string SenderEmail { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeMode
    {
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "test")]
        Test
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeRouting
    {
        [EnumMember(Value = "parallel")]
        Parallel,
        [EnumMember(Value = "sequential")]
        Sequential
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeAttestation
    {
        [EnumMember(Value = "mx_nom151")]
        MxNom151
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenvelopeModeInput
    {
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "test")]
        Test
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenvelopeRoutingInput
    {
        [EnumMember(Value = "parallel")]
        Parallel,
        [EnumMember(Value = "sequential")]
        Sequential
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenvelopeAttestationInput
    {
        [EnumMember(Value = "mx_nom151")]
        MxNom151
    }

    public class Envelope
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("sender")]
        public EnvelopeSender Sender { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("deliverable")]
        public EnvelopeDeliverable Deliverable { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("mode")]
        public EnvelopeMode Mode { get; set; }

        [JsonProperty("routing")]
        public EnvelopeRouting Routing { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timestamp_format")]
        public string TimestampFormat { get; set; }

        [JsonProperty("attestation")]
        public EnvelopeAttestation Attestation { get; set; }

        [JsonProperty("topics")]
        public string[] Topics { get; set; }
    }

    public class EnvelopeDeliverable
    {
        [JsonProperty("id")]
        public string DeliverableID { get; set; }
    }

    public class Capture
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class StartEnvelopeOutput
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AddDocumentOutput
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrequirementInput
    {
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "optional")]
        Optional
    }

    public class AddRecipientSignerOutput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("ceremony_creation")]
        public RecipientCeremonyCreation CeremonyCreation { get; set; }

        [JsonProperty("delivery_type")]
        public RecipientDeliveryType DeliveryType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecipientCeremonyCreation
    {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "manual")]
        Manual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecipientDeliveryType
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrecipientCeremonyCreationInput
    {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "manual")]
        Manual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrecipientDeliveryTypeInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "none")]
        None
    }

    public class Recipient
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("envelope_id")]
        public string EnvelopeId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ceremony_creation")]
        public RecipientCeremonyCreation CeremonyCreation { get; set; }

        [JsonProperty("delivery_type")]
        public RecipientDeliveryType DeliveryType { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }
    }

    public class CreateCeremonyCustomOutput
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Deliverable
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public DeliverableType Type { get; set; }

        [JsonProperty("status")]
        public DeliverableStatus Status { get; set; }

        [JsonProperty("file_content")]
        public string FileContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeliverableType
    {
        [EnumMember(Value = "audit_log")]
        AuditLog
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeliverableStatus
    {
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "generated")]
        Generated,
        [EnumMember(Value = "failed")]
        Failed
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signatureapi;

    public partial class WorkflowManagedActions
    {
        public SignatureapiActions Signatureapi(string connectionId) => new SignatureapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SignatureapiTriggers Signatureapi(string connectionId) => new SignatureapiTriggers(connectionId);
    }
}
