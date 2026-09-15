//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signatureapi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignatureapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<CreateEnvelopeOutput> CreateEnvelope(Expression<Func<string>> bodyenvelopeTitle = null, Expression<Func<string>> bodyenvelopeLabel = null, Expression<Func<string>> bodyenvelopeMessage = null, Expression<Func<bodyenvelopeModeInput>> bodyenvelopeMode = null, Expression<Func<bodyenvelopeRoutingInput>> bodyenvelopeRouting = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodytimestampFormat = null, Expression<Func<bodyenvelopeAttestationInput>> bodyenvelopeAttestation = null, Expression<Func<string>> bodysendername = null, Expression<Func<string>> bodysenderemail = null, Expression<Func<string[]>> bodyenvelopeTopics = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = "/envelopes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["draft"] = true;
            bodypropCount++;
            if (bodyenvelopeTitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodyenvelopeTitle);
                bodypropCount++;
            }

            if (bodyenvelopeLabel != null)
            {
                body["label"] = CSharpExpressionConverter.ConvertToken(bodyenvelopeLabel);
                bodypropCount++;
            }

            if (bodyenvelopeMessage != null)
            {
                body["message"] = CSharpExpressionConverter.ConvertToken(bodyenvelopeMessage);
                bodypropCount++;
            }

            if (bodyenvelopeMode != null)
            {
                body["mode"] = CSharpExpressionConverter.Convert(bodyenvelopeMode);
                bodypropCount++;
            }

            if (bodyenvelopeRouting != null)
            {
                body["routing"] = CSharpExpressionConverter.Convert(bodyenvelopeRouting);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = CSharpExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["timezone"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodytimestampFormat != null)
            {
                body["timestamp_format"] = CSharpExpressionConverter.ConvertToken(bodytimestampFormat);
                bodypropCount++;
            }

            if (bodyenvelopeAttestation != null)
            {
                body["attestation"] = CSharpExpressionConverter.Convert(bodyenvelopeAttestation);
                bodypropCount++;
            }

            var senderObject = new JObject();
            var senderObjectpropCount = 0;
            if (bodysendername != null)
            {
                senderObject["name"] = CSharpExpressionConverter.ConvertToken(bodysendername);
                senderObjectpropCount++;
            }

            if (bodysenderemail != null)
            {
                senderObject["email"] = CSharpExpressionConverter.ConvertToken(bodysenderemail);
                senderObjectpropCount++;
            }

            if (senderObjectpropCount > 0)
            {
                body["sender"] = senderObject;
                bodypropCount++;
            }

            if (bodyenvelopeTopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodyenvelopeTopics);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateEnvelopeOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction DeleteEnvelope(Expression<Func<string>> envelopeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Envelope> GetEnvelope(Expression<Func<string>> envelopeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Envelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Capture> GetCapture(Expression<Func<string>> envelopeId, Expression<Func<string>> captureKey)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/envelopes/{0}+alias1", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["captureKey"] = CSharpExpressionConverter.ConvertO(captureKey);
            return new ApiConnectionAction<Capture>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<StartEnvelopeOutput> StartEnvelope(Expression<Func<string>> envelopeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/start", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StartEnvelopeOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddDocument(Expression<Func<string>> envelopeId, Expression<Func<string>> bodydocumentTitle = null, Expression<Func<string>> bodyfileContent = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocumentTitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodydocumentTitle);
                bodypropCount++;
            }

            if (bodyfileContent != null)
            {
                body["file_content"] = CSharpExpressionConverter.ConvertToken(bodyfileContent);
                bodypropCount++;
            }

            body["format"] = "pdf";
            bodypropCount++;
            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddDocumentOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddDocumentDocx(Expression<Func<string>> envelopeId, Expression<Func<string>> bodydocumentTitle = null, Expression<Func<string>> bodyfileContent = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents+alias1", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocumentTitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodydocumentTitle);
                bodypropCount++;
            }

            if (bodyfileContent != null)
            {
                body["file_content"] = CSharpExpressionConverter.ConvertToken(bodyfileContent);
                bodypropCount++;
            }

            body["format"] = "docx";
            bodypropCount++;
            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddDocumentOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddTemplate(Expression<Func<string>> envelopeId, Expression<Func<string>> bodydocumentTitle = null, Expression<Func<string>> bodyfileContent = null, Expression<Func<string[]>> bodytemplateData = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents+alias2", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocumentTitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodydocumentTitle);
                bodypropCount++;
            }

            if (bodyfileContent != null)
            {
                body["file_content"] = CSharpExpressionConverter.ConvertToken(bodyfileContent);
                bodypropCount++;
            }

            body["format"] = "docx";
            bodypropCount++;
            if (bodytemplateData != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodytemplateData);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddDocumentOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddTemplateData(Expression<Func<string>> documentId, Expression<Func<string>> bodyfieldName = null, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-data", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldName != null)
            {
                body["field_name"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = CSharpExpressionConverter.ConvertToken(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceSignature(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<double>> bodyplaceHeight = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-signature-place", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "signature";
            bodypropCount++;
            if (bodyplaceKey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodyplaceKey);
                bodypropCount++;
            }

            if (bodyrecipientKey != null)
            {
                body["recipient_key"] = CSharpExpressionConverter.ConvertToken(bodyrecipientKey);
                bodypropCount++;
            }

            if (bodyplaceHeight != null)
            {
                body["height"] = CSharpExpressionConverter.ConvertToken(bodyplaceHeight);
                bodypropCount++;
            }

            if (bodypageNumber != null)
            {
                body["page"] = CSharpExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
            }

            if (bodydistanceFromTop != null)
            {
                body["top"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromTop);
                bodypropCount++;
            }

            if (bodydistanceFromLeft != null)
            {
                body["left"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromLeft);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceInitials(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<double>> bodyplaceHeight = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-initials-place", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "initials";
            bodypropCount++;
            if (bodyplaceKey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodyplaceKey);
                bodypropCount++;
            }

            if (bodyrecipientKey != null)
            {
                body["recipient_key"] = CSharpExpressionConverter.ConvertToken(bodyrecipientKey);
                bodypropCount++;
            }

            if (bodyplaceHeight != null)
            {
                body["height"] = CSharpExpressionConverter.ConvertToken(bodyplaceHeight);
                bodypropCount++;
            }

            if (bodypageNumber != null)
            {
                body["page"] = CSharpExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
            }

            if (bodydistanceFromTop != null)
            {
                body["top"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromTop);
                bodypropCount++;
            }

            if (bodydistanceFromLeft != null)
            {
                body["left"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromLeft);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceTextInput(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<string>> bodycaptureAs = null, Expression<Func<string>> bodyhint = null, Expression<Func<string>> bodyprompt = null, Expression<Func<bodyrequirementInput>> bodyrequirement = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodyformatMessage = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-text-input-place", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "text_input";
            bodypropCount++;
            if (bodyplaceKey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodyplaceKey);
                bodypropCount++;
            }

            if (bodyrecipientKey != null)
            {
                body["recipient_key"] = CSharpExpressionConverter.ConvertToken(bodyrecipientKey);
                bodypropCount++;
            }

            if (bodycaptureAs != null)
            {
                body["capture_as"] = CSharpExpressionConverter.ConvertToken(bodycaptureAs);
                bodypropCount++;
            }

            if (bodyhint != null)
            {
                body["hint"] = CSharpExpressionConverter.ConvertToken(bodyhint);
                bodypropCount++;
            }

            if (bodyprompt != null)
            {
                body["prompt"] = CSharpExpressionConverter.ConvertToken(bodyprompt);
                bodypropCount++;
            }

            if (bodyrequirement != null)
            {
                if (bodyrequirement != null)
                {
                    body["requirement"] = CSharpExpressionConverter.Convert(bodyrequirement);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["requirement"] = "required";
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                body["format"] = CSharpExpressionConverter.ConvertToken(bodyformat);
                bodypropCount++;
            }

            if (bodyformatMessage != null)
            {
                body["format_message"] = CSharpExpressionConverter.ConvertToken(bodyformatMessage);
                bodypropCount++;
            }

            if (bodypageNumber != null)
            {
                body["page"] = CSharpExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
            }

            if (bodydistanceFromTop != null)
            {
                body["top"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromTop);
                bodypropCount++;
            }

            if (bodydistanceFromLeft != null)
            {
                body["left"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromLeft);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceText(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyvalue = null, Expression<Func<double>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-text-place", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "text";
            bodypropCount++;
            if (bodyplaceKey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodyplaceKey);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = CSharpExpressionConverter.ConvertToken(bodyvalue);
                bodypropCount++;
            }

            if (bodyfontSize != null)
            {
                body["font_size"] = CSharpExpressionConverter.ConvertToken(bodyfontSize);
                bodypropCount++;
            }

            if (bodyfontColor != null)
            {
                body["font_color"] = CSharpExpressionConverter.ConvertToken(bodyfontColor);
                bodypropCount++;
            }

            if (bodypageNumber != null)
            {
                body["page"] = CSharpExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
            }

            if (bodydistanceFromTop != null)
            {
                body["top"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromTop);
                bodypropCount++;
            }

            if (bodydistanceFromLeft != null)
            {
                body["left"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromLeft);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceRecipientCompletedDate(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-recipient-completed-date-place", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "recipient_completed_date";
            bodypropCount++;
            if (bodyplaceKey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodyplaceKey);
                bodypropCount++;
            }

            if (bodyrecipientKey != null)
            {
                body["recipient_key"] = CSharpExpressionConverter.ConvertToken(bodyrecipientKey);
                bodypropCount++;
            }

            if (bodydateFormat != null)
            {
                body["date_format"] = CSharpExpressionConverter.ConvertToken(bodydateFormat);
                bodypropCount++;
            }

            if (bodypageNumber != null)
            {
                body["page"] = CSharpExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
            }

            if (bodydistanceFromTop != null)
            {
                body["top"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromTop);
                bodypropCount++;
            }

            if (bodydistanceFromLeft != null)
            {
                body["left"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromLeft);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceEnvelopeCompletedDate(Expression<Func<string>> documentId, Expression<Func<string>> bodyplaceKey = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<double>> bodypageNumber = null, Expression<Func<double>> bodydistanceFromTop = null, Expression<Func<double>> bodydistanceFromLeft = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-envelope-completed-date-place", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "envelope_completed_date";
            bodypropCount++;
            if (bodyplaceKey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodyplaceKey);
                bodypropCount++;
            }

            if (bodydateFormat != null)
            {
                body["date_format"] = CSharpExpressionConverter.ConvertToken(bodydateFormat);
                bodypropCount++;
            }

            if (bodypageNumber != null)
            {
                body["page"] = CSharpExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
            }

            if (bodydistanceFromTop != null)
            {
                body["top"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromTop);
                bodypropCount++;
            }

            if (bodydistanceFromLeft != null)
            {
                body["left"] = CSharpExpressionConverter.ConvertToken(bodydistanceFromLeft);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddRecipientSignerOutput> AddRecipient(Expression<Func<string>> envelopeId, Expression<Func<string>> bodyrecipientName = null, Expression<Func<string>> bodyrecipientEmail = null, Expression<Func<string>> bodyrecipientKey = null, Expression<Func<bodyrecipientCeremonyCreationInput>> bodyrecipientCeremonyCreation = null, Expression<Func<bodyrecipientDeliveryTypeInput>> bodyrecipientDeliveryType = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "signer";
            bodypropCount++;
            if (bodyrecipientName != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyrecipientName);
                bodypropCount++;
            }

            if (bodyrecipientEmail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyrecipientEmail);
                bodypropCount++;
            }

            if (bodyrecipientKey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodyrecipientKey);
                bodypropCount++;
            }

            if (bodyrecipientCeremonyCreation != null)
            {
                body["ceremony_creation"] = CSharpExpressionConverter.Convert(bodyrecipientCeremonyCreation);
                bodypropCount++;
            }

            if (bodyrecipientDeliveryType != null)
            {
                body["delivery_type"] = CSharpExpressionConverter.Convert(bodyrecipientDeliveryType);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddRecipientSignerOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Recipient> GetRecipient(Expression<Func<string>> recipientId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/recipients/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Recipient>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<JToken> CreateCeremonyEmailLink(Expression<Func<string>> recipientId, Expression<Func<string>> bodyredirectURL = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/recipients/{0}/ceremony", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
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

            if (bodyredirectURL != null)
            {
                body["redirect_url"] = CSharpExpressionConverter.ConvertToken(bodyredirectURL);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<CreateCeremonyCustomOutput> CreateCeremonyCustom(Expression<Func<string>> recipientId, Expression<Func<string>> bodyauthenticationauthenticationProvider = null, Expression<Func<string[]>> bodyauthenticationauthenticationData = null, Expression<Func<string>> bodyredirectURL = null, Expression<Func<string>> bodyextraProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/recipients/{0}/ceremony+alias1", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var authenticationObject = new JObject();
            var authenticationObjectpropCount = 0;
            authenticationObject["type"] = "custom";
            authenticationObjectpropCount++;
            if (bodyauthenticationauthenticationProvider != null)
            {
                authenticationObject["provider"] = CSharpExpressionConverter.ConvertToken(bodyauthenticationauthenticationProvider);
                authenticationObjectpropCount++;
            }

            if (bodyauthenticationauthenticationData != null)
            {
                authenticationObject["data"] = CSharpExpressionConverter.ConvertToken(bodyauthenticationauthenticationData);
                authenticationObjectpropCount++;
            }

            if (authenticationObjectpropCount > 0)
            {
                body["authentication"] = authenticationObject;
                bodypropCount++;
            }

            if (bodyredirectURL != null)
            {
                body["redirect_url"] = CSharpExpressionConverter.ConvertToken(bodyredirectURL);
                bodypropCount++;
            }

            if (bodyextraProperties != null)
            {
                body["extra"] = CSharpExpressionConverter.ConvertToken(bodyextraProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateCeremonyCustomOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Envelope> WaitEnvelope(Expression<Func<string>> envelopeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/envelopes/{0}/wait", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Envelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Deliverable> GetDeliverable(Expression<Func<string>> deliverableId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/deliverables/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(deliverableId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Deliverable>(callPayload);
        }
    }

    public class SignatureapiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCreated(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/envelope.created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeStarted(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/envelope.started";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCompleted(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/envelope.completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeFailed(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/envelope.failed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCanceled(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/envelope.canceled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReleased(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/recipient.released";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientSent(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/recipient.sent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientCompleted(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/recipient.completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientRejected(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/recipient.rejected";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientBounced(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/recipient.bounced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientFailed(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/recipient.failed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReplaced(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/recipient.replaced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientResent(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/recipient.resent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableGenerated(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/deliverable.generated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableFailed(Expression<Func<string[]>> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integrations/power-platform/webhooks/deliverable.failed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytopics != null)
            {
                body["topics"] = CSharpExpressionConverter.ConvertToken(bodytopics);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
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

    public enum EnvelopeMode
    {
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "test")]
        Test
    }

    public enum EnvelopeRouting
    {
        [EnumMember(Value = "parallel")]
        Parallel,
        [EnumMember(Value = "sequential")]
        Sequential
    }

    public enum EnvelopeAttestation
    {
        [EnumMember(Value = "mx_nom151")]
        MxNom151
    }

    public enum bodyenvelopeModeInput
    {
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "test")]
        Test
    }

    public enum bodyenvelopeRoutingInput
    {
        [EnumMember(Value = "parallel")]
        Parallel,
        [EnumMember(Value = "sequential")]
        Sequential
    }

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

    public enum RecipientCeremonyCreation
    {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "manual")]
        Manual
    }

    public enum RecipientDeliveryType
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "none")]
        None
    }

    public enum bodyrecipientCeremonyCreationInput
    {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "manual")]
        Manual
    }

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

    public enum DeliverableType
    {
        [EnumMember(Value = "audit_log")]
        AuditLog
    }

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