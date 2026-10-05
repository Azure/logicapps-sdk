//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signatureapi
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignatureapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEnvelope))]
        public IBodyWorkflowAction<CreateEnvelopeOutput> CreateEnvelope([WorkflowExpression] Func<string> bodyenvelopeTitle = null, [WorkflowExpression] Func<string> bodyenvelopeLabel = null, [WorkflowExpression] Func<string> bodyenvelopeMessage = null, [WorkflowExpression] Func<bodyenvelopeModeInput> bodyenvelopeMode = null, [WorkflowExpression] Func<bodyenvelopeRoutingInput> bodyenvelopeRouting = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodytimestampFormat = null, [WorkflowExpression] Func<bodyenvelopeAttestationInput> bodyenvelopeAttestation = null, [WorkflowExpression] Func<string> bodysendername = null, [WorkflowExpression] Func<string> bodysenderemail = null, [WorkflowExpression] Func<string[]> bodyenvelopeTopics = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEnvelopeOutput> __BuildCreateEnvelope(WorkflowValue<string> bodyenvelopeTitle = null, WorkflowValue<string> bodyenvelopeLabel = null, WorkflowValue<string> bodyenvelopeMessage = null, WorkflowValue<bodyenvelopeModeInput> bodyenvelopeMode = null, WorkflowValue<bodyenvelopeRoutingInput> bodyenvelopeRouting = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<string> bodytimeZone = null, WorkflowValue<string> bodytimestampFormat = null, WorkflowValue<bodyenvelopeAttestationInput> bodyenvelopeAttestation = null, WorkflowValue<string> bodysendername = null, WorkflowValue<string> bodysenderemail = null, WorkflowValue<string[]> bodyenvelopeTopics = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(bodyenvelopeTitle, nameof(bodyenvelopeTitle), required: false);
            WorkflowValue.Validate(bodyenvelopeLabel, nameof(bodyenvelopeLabel), required: false);
            WorkflowValue.Validate(bodyenvelopeMessage, nameof(bodyenvelopeMessage), required: false);
            WorkflowValue.Validate(bodyenvelopeMode, nameof(bodyenvelopeMode), required: false);
            WorkflowValue.Validate(bodyenvelopeRouting, nameof(bodyenvelopeRouting), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            WorkflowValue.Validate(bodytimestampFormat, nameof(bodytimestampFormat), required: false);
            WorkflowValue.Validate(bodyenvelopeAttestation, nameof(bodyenvelopeAttestation), required: false);
            WorkflowValue.Validate(bodysendername, nameof(bodysendername), required: false);
            WorkflowValue.Validate(bodysenderemail, nameof(bodysenderemail), required: false);
            WorkflowValue.Validate(bodyenvelopeTopics, nameof(bodyenvelopeTopics), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<CreateEnvelopeOutput>(() =>
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
                    body["title"] = ExpressionConverter.ConvertO(bodyenvelopeTitle);
                    bodypropCount++;
                }

                if (bodyenvelopeLabel != null)
                {
                    body["label"] = ExpressionConverter.ConvertO(bodyenvelopeLabel);
                    bodypropCount++;
                }

                if (bodyenvelopeMessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodyenvelopeMessage);
                    bodypropCount++;
                }

                if (bodyenvelopeMode != null)
                {
                    body["mode"] = ExpressionConverter.ConvertO(bodyenvelopeMode);
                    bodypropCount++;
                }

                if (bodyenvelopeRouting != null)
                {
                    body["routing"] = ExpressionConverter.ConvertO(bodyenvelopeRouting);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(bodytimeZone);
                    bodypropCount++;
                }

                if (bodytimestampFormat != null)
                {
                    body["timestamp_format"] = ExpressionConverter.ConvertO(bodytimestampFormat);
                    bodypropCount++;
                }

                if (bodyenvelopeAttestation != null)
                {
                    body["attestation"] = ExpressionConverter.ConvertO(bodyenvelopeAttestation);
                    bodypropCount++;
                }

                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (bodysendername != null)
                {
                    senderObject["name"] = ExpressionConverter.ConvertO(bodysendername);
                    senderObjectpropCount++;
                }

                if (bodysenderemail != null)
                {
                    senderObject["email"] = ExpressionConverter.ConvertO(bodysenderemail);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (bodyenvelopeTopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodyenvelopeTopics);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteEnvelope))]
        public IWorkflowAction DeleteEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEnvelope(WorkflowValue<string> envelopeId)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelope))]
        public IBodyWorkflowAction<Envelope> GetEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Envelope> __BuildGetEnvelope(WorkflowValue<string> envelopeId)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<Envelope>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetCapture))]
        public IBodyWorkflowAction<Capture> GetCapture([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> captureKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Capture> __BuildGetCapture(WorkflowValue<string> envelopeId, WorkflowValue<string> captureKey)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(captureKey, nameof(captureKey), required: true);
            return new DeferredBodyAction<Capture>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}+alias1", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["captureKey"] = ExpressionConverter.Convert(captureKey);
                return new ApiConnectionAction<Capture>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [WorkflowExpressionFactory(nameof(__BuildStartEnvelope))]
        public IBodyWorkflowAction<StartEnvelopeOutput> StartEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StartEnvelopeOutput> __BuildStartEnvelope(WorkflowValue<string> envelopeId)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<StartEnvelopeOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/start", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StartEnvelopeOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [WorkflowExpressionFactory(nameof(__BuildAddDocument))]
        public IBodyWorkflowAction<AddDocumentOutput> AddDocument([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodydocumentTitle = null, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddDocumentOutput> __BuildAddDocument(WorkflowValue<string> envelopeId, WorkflowValue<string> bodydocumentTitle = null, WorkflowValue<string> bodyfileContent = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            WorkflowValue.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<AddDocumentOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodydocumentTitle);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["file_content"] = ExpressionConverter.ConvertO(bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "pdf";
                bodypropCount++;
                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddDocumentDocx))]
        public IBodyWorkflowAction<AddDocumentOutput> AddDocumentDocx([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodydocumentTitle = null, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddDocumentOutput> __BuildAddDocumentDocx(WorkflowValue<string> envelopeId, WorkflowValue<string> bodydocumentTitle = null, WorkflowValue<string> bodyfileContent = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            WorkflowValue.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<AddDocumentOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents+alias1", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodydocumentTitle);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["file_content"] = ExpressionConverter.ConvertO(bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "docx";
                bodypropCount++;
                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddTemplate))]
        public IBodyWorkflowAction<AddDocumentOutput> AddTemplate([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodydocumentTitle = null, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<string[]> bodytemplateData = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddDocumentOutput> __BuildAddTemplate(WorkflowValue<string> envelopeId, WorkflowValue<string> bodydocumentTitle = null, WorkflowValue<string> bodyfileContent = null, WorkflowValue<string[]> bodytemplateData = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            WorkflowValue.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            WorkflowValue.Validate(bodytemplateData, nameof(bodytemplateData), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<AddDocumentOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents+alias2", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodydocumentTitle);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["file_content"] = ExpressionConverter.ConvertO(bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "docx";
                bodypropCount++;
                if (bodytemplateData != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodytemplateData);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddTemplateData))]
        public IWorkflowAction AddTemplateData([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddTemplateData(WorkflowValue<string> documentId, WorkflowValue<string> bodyfieldName = null, WorkflowValue<string> bodyvalue = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-data", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldName != null)
                {
                    body["field_name"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(bodyvalue);
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
        [WorkflowExpressionFactory(nameof(__BuildAddPlaceSignature))]
        public IWorkflowAction AddPlaceSignature([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<double> bodyplaceHeight = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceSignature(WorkflowValue<string> documentId, WorkflowValue<string> bodyplaceKey = null, WorkflowValue<string> bodyrecipientKey = null, WorkflowValue<double> bodyplaceHeight = null, WorkflowValue<double> bodypageNumber = null, WorkflowValue<double> bodydistanceFromTop = null, WorkflowValue<double> bodydistanceFromLeft = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowValue.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowValue.Validate(bodyplaceHeight, nameof(bodyplaceHeight), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowValue.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-signature-place", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "signature";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["recipient_key"] = ExpressionConverter.ConvertO(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodyplaceHeight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(bodyplaceHeight);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddPlaceInitials))]
        public IWorkflowAction AddPlaceInitials([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<double> bodyplaceHeight = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceInitials(WorkflowValue<string> documentId, WorkflowValue<string> bodyplaceKey = null, WorkflowValue<string> bodyrecipientKey = null, WorkflowValue<double> bodyplaceHeight = null, WorkflowValue<double> bodypageNumber = null, WorkflowValue<double> bodydistanceFromTop = null, WorkflowValue<double> bodydistanceFromLeft = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowValue.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowValue.Validate(bodyplaceHeight, nameof(bodyplaceHeight), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowValue.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-initials-place", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "initials";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["recipient_key"] = ExpressionConverter.ConvertO(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodyplaceHeight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(bodyplaceHeight);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddPlaceTextInput))]
        public IWorkflowAction AddPlaceTextInput([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<string> bodycaptureAs = null, [WorkflowExpression] Func<string> bodyhint = null, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<bodyrequirementInput> bodyrequirement = null, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodyformatMessage = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceTextInput(WorkflowValue<string> documentId, WorkflowValue<string> bodyplaceKey = null, WorkflowValue<string> bodyrecipientKey = null, WorkflowValue<string> bodycaptureAs = null, WorkflowValue<string> bodyhint = null, WorkflowValue<string> bodyprompt = null, WorkflowValue<bodyrequirementInput> bodyrequirement = null, WorkflowValue<string> bodyformat = null, WorkflowValue<string> bodyformatMessage = null, WorkflowValue<double> bodypageNumber = null, WorkflowValue<double> bodydistanceFromTop = null, WorkflowValue<double> bodydistanceFromLeft = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowValue.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowValue.Validate(bodycaptureAs, nameof(bodycaptureAs), required: false);
            WorkflowValue.Validate(bodyhint, nameof(bodyhint), required: false);
            WorkflowValue.Validate(bodyprompt, nameof(bodyprompt), required: false);
            WorkflowValue.Validate(bodyrequirement, nameof(bodyrequirement), required: false);
            WorkflowValue.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowValue.Validate(bodyformatMessage, nameof(bodyformatMessage), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowValue.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-text-input-place", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "text_input";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["recipient_key"] = ExpressionConverter.ConvertO(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodycaptureAs != null)
                {
                    body["capture_as"] = ExpressionConverter.ConvertO(bodycaptureAs);
                    bodypropCount++;
                }

                if (bodyhint != null)
                {
                    body["hint"] = ExpressionConverter.ConvertO(bodyhint);
                    bodypropCount++;
                }

                if (bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                    bodypropCount++;
                }

                if (bodyrequirement != null)
                {
                    if (bodyrequirement != null)
                    {
                        body["requirement"] = ExpressionConverter.ConvertO(bodyrequirement);
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
                    body["format"] = ExpressionConverter.ConvertO(bodyformat);
                    bodypropCount++;
                }

                if (bodyformatMessage != null)
                {
                    body["format_message"] = ExpressionConverter.ConvertO(bodyformatMessage);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddPlaceText))]
        public IWorkflowAction AddPlaceText([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyvalue = null, [WorkflowExpression] Func<double> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceText(WorkflowValue<string> documentId, WorkflowValue<string> bodyplaceKey = null, WorkflowValue<string> bodyvalue = null, WorkflowValue<double> bodyfontSize = null, WorkflowValue<string> bodyfontColor = null, WorkflowValue<double> bodypageNumber = null, WorkflowValue<double> bodydistanceFromTop = null, WorkflowValue<double> bodydistanceFromLeft = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowValue.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            WorkflowValue.Validate(bodyfontColor, nameof(bodyfontColor), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowValue.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-text-place", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "text";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                    bodypropCount++;
                }

                if (bodyfontSize != null)
                {
                    body["font_size"] = ExpressionConverter.ConvertO(bodyfontSize);
                    bodypropCount++;
                }

                if (bodyfontColor != null)
                {
                    body["font_color"] = ExpressionConverter.ConvertO(bodyfontColor);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddPlaceRecipientCompletedDate))]
        public IWorkflowAction AddPlaceRecipientCompletedDate([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceRecipientCompletedDate(WorkflowValue<string> documentId, WorkflowValue<string> bodyplaceKey = null, WorkflowValue<string> bodyrecipientKey = null, WorkflowValue<string> bodydateFormat = null, WorkflowValue<double> bodypageNumber = null, WorkflowValue<double> bodydistanceFromTop = null, WorkflowValue<double> bodydistanceFromLeft = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowValue.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowValue.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowValue.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-recipient-completed-date-place", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "recipient_completed_date";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["recipient_key"] = ExpressionConverter.ConvertO(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodydateFormat != null)
                {
                    body["date_format"] = ExpressionConverter.ConvertO(bodydateFormat);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddPlaceEnvelopeCompletedDate))]
        public IWorkflowAction AddPlaceEnvelopeCompletedDate([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceEnvelopeCompletedDate(WorkflowValue<string> documentId, WorkflowValue<string> bodyplaceKey = null, WorkflowValue<string> bodydateFormat = null, WorkflowValue<double> bodypageNumber = null, WorkflowValue<double> bodydistanceFromTop = null, WorkflowValue<double> bodydistanceFromLeft = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowValue.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowValue.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-envelope-completed-date-place", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "envelope_completed_date";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodydateFormat != null)
                {
                    body["date_format"] = ExpressionConverter.ConvertO(bodydateFormat);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = ExpressionConverter.ConvertO(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = ExpressionConverter.ConvertO(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildAddRecipient))]
        public IBodyWorkflowAction<AddRecipientSignerOutput> AddRecipient([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodyrecipientName = null, [WorkflowExpression] Func<string> bodyrecipientEmail = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<bodyrecipientCeremonyCreationInput> bodyrecipientCeremonyCreation = null, [WorkflowExpression] Func<bodyrecipientDeliveryTypeInput> bodyrecipientDeliveryType = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddRecipientSignerOutput> __BuildAddRecipient(WorkflowValue<string> envelopeId, WorkflowValue<string> bodyrecipientName = null, WorkflowValue<string> bodyrecipientEmail = null, WorkflowValue<string> bodyrecipientKey = null, WorkflowValue<bodyrecipientCeremonyCreationInput> bodyrecipientCeremonyCreation = null, WorkflowValue<bodyrecipientDeliveryTypeInput> bodyrecipientDeliveryType = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(bodyrecipientName, nameof(bodyrecipientName), required: false);
            WorkflowValue.Validate(bodyrecipientEmail, nameof(bodyrecipientEmail), required: false);
            WorkflowValue.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowValue.Validate(bodyrecipientCeremonyCreation, nameof(bodyrecipientCeremonyCreation), required: false);
            WorkflowValue.Validate(bodyrecipientDeliveryType, nameof(bodyrecipientDeliveryType), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<AddRecipientSignerOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "signer";
                bodypropCount++;
                if (bodyrecipientName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyrecipientName);
                    bodypropCount++;
                }

                if (bodyrecipientEmail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyrecipientEmail);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodyrecipientCeremonyCreation != null)
                {
                    body["ceremony_creation"] = ExpressionConverter.ConvertO(bodyrecipientCeremonyCreation);
                    bodypropCount++;
                }

                if (bodyrecipientDeliveryType != null)
                {
                    body["delivery_type"] = ExpressionConverter.ConvertO(bodyrecipientDeliveryType);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildGetRecipient))]
        public IBodyWorkflowAction<Recipient> GetRecipient([WorkflowExpression] Func<string> recipientId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Recipient> __BuildGetRecipient(WorkflowValue<string> recipientId)
        {
            WorkflowValue.Validate(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<Recipient>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recipients/{0}", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Recipient>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCeremonyEmailLink))]
        public IBodyWorkflowAction<JToken> CreateCeremonyEmailLink([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodyredirectURL = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateCeremonyEmailLink(WorkflowValue<string> recipientId, WorkflowValue<string> bodyredirectURL = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowValue.Validate(bodyredirectURL, nameof(bodyredirectURL), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recipients/{0}/ceremony", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
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
                    body["redirect_url"] = ExpressionConverter.ConvertO(bodyredirectURL);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateCeremonyCustom))]
        public IBodyWorkflowAction<CreateCeremonyCustomOutput> CreateCeremonyCustom([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodyauthenticationauthenticationProvider = null, [WorkflowExpression] Func<string[]> bodyauthenticationauthenticationData = null, [WorkflowExpression] Func<string> bodyredirectURL = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCeremonyCustomOutput> __BuildCreateCeremonyCustom(WorkflowValue<string> recipientId, WorkflowValue<string> bodyauthenticationauthenticationProvider = null, WorkflowValue<string[]> bodyauthenticationauthenticationData = null, WorkflowValue<string> bodyredirectURL = null, WorkflowValue<string> bodyextraProperties = null)
        {
            WorkflowValue.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowValue.Validate(bodyauthenticationauthenticationProvider, nameof(bodyauthenticationauthenticationProvider), required: false);
            WorkflowValue.Validate(bodyauthenticationauthenticationData, nameof(bodyauthenticationauthenticationData), required: false);
            WorkflowValue.Validate(bodyredirectURL, nameof(bodyredirectURL), required: false);
            WorkflowValue.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            return new DeferredBodyAction<CreateCeremonyCustomOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recipients/{0}/ceremony+alias1", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
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
                    authenticationObject["provider"] = ExpressionConverter.ConvertO(bodyauthenticationauthenticationProvider);
                    authenticationObjectpropCount++;
                }

                if (bodyauthenticationauthenticationData != null)
                {
                    authenticationObject["data"] = ExpressionConverter.ConvertO(bodyauthenticationauthenticationData);
                    authenticationObjectpropCount++;
                }

                if (authenticationObjectpropCount > 0)
                {
                    body["authentication"] = authenticationObject;
                    bodypropCount++;
                }

                if (bodyredirectURL != null)
                {
                    body["redirect_url"] = ExpressionConverter.ConvertO(bodyredirectURL);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = ExpressionConverter.ConvertO(bodyextraProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildWaitEnvelope))]
        public IBodyWorkflowAction<Envelope> WaitEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Envelope> __BuildWaitEnvelope(WorkflowValue<string> envelopeId)
        {
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<Envelope>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/envelopes/{0}/wait", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetDeliverable))]
        public IBodyWorkflowAction<Deliverable> GetDeliverable([WorkflowExpression] Func<string> deliverableId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Deliverable> __BuildGetDeliverable(WorkflowValue<string> deliverableId)
        {
            WorkflowValue.Validate(deliverableId, nameof(deliverableId), required: true);
            return new DeferredBodyAction<Deliverable>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/deliverables/{0}", ExpressionConverter.ConvertWithUrlEncoding(deliverableId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Deliverable>(callPayload);
            });
        }
    }

    public class SignatureapiTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeCreated))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCreated([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeCreated(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeStarted))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeStarted([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeStarted(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.started";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeCompleted))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCompleted([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeCompleted(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeFailed))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeFailed([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeFailed(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeCanceled))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCanceled([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeCanceled(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.canceled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientReleased))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReleased([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientReleased(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.released";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientSent))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientSent([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientSent(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.sent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientCompleted))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientCompleted([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientCompleted(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientRejected))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientRejected([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientRejected(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.rejected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientBounced))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientBounced([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientBounced(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.bounced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientFailed))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientFailed([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientFailed(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientReplaced))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReplaced([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientReplaced(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.replaced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientResent))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientResent([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientResent(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.resent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForDeliverableGenerated))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableGenerated([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForDeliverableGenerated(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/deliverable.generated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForDeliverableFailed))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableFailed([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForDeliverableFailed(WorkflowValue<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytopics, nameof(bodytopics), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/deliverable.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = ExpressionConverter.ConvertO(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
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
