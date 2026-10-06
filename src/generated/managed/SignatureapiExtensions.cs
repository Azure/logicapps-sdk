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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEnvelopeOutput> __BuildCreateEnvelope(WorkflowExpression<string> bodyenvelopeTitle = null, WorkflowExpression<string> bodyenvelopeLabel = null, WorkflowExpression<string> bodyenvelopeMessage = null, WorkflowExpression<bodyenvelopeModeInput> bodyenvelopeMode = null, WorkflowExpression<bodyenvelopeRoutingInput> bodyenvelopeRouting = null, WorkflowExpression<string> bodylanguage = null, WorkflowExpression<string> bodytimeZone = null, WorkflowExpression<string> bodytimestampFormat = null, WorkflowExpression<bodyenvelopeAttestationInput> bodyenvelopeAttestation = null, WorkflowExpression<string> bodysendername = null, WorkflowExpression<string> bodysenderemail = null, WorkflowExpression<string[]> bodyenvelopeTopics = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(bodyenvelopeTitle, nameof(bodyenvelopeTitle), required: false);
            WorkflowExpression.Validate(bodyenvelopeLabel, nameof(bodyenvelopeLabel), required: false);
            WorkflowExpression.Validate(bodyenvelopeMessage, nameof(bodyenvelopeMessage), required: false);
            WorkflowExpression.Validate(bodyenvelopeMode, nameof(bodyenvelopeMode), required: false);
            WorkflowExpression.Validate(bodyenvelopeRouting, nameof(bodyenvelopeRouting), required: false);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            WorkflowExpression.Validate(bodytimestampFormat, nameof(bodytimestampFormat), required: false);
            WorkflowExpression.Validate(bodyenvelopeAttestation, nameof(bodyenvelopeAttestation), required: false);
            WorkflowExpression.Validate(bodysendername, nameof(bodysendername), required: false);
            WorkflowExpression.Validate(bodysenderemail, nameof(bodysenderemail), required: false);
            WorkflowExpression.Validate(bodyenvelopeTopics, nameof(bodyenvelopeTopics), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEnvelope(WorkflowExpression<string> envelopeId)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Envelope> __BuildGetEnvelope(WorkflowExpression<string> envelopeId)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Capture> __BuildGetCapture(WorkflowExpression<string> envelopeId, WorkflowExpression<string> captureKey)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowExpression.Validate(captureKey, nameof(captureKey), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StartEnvelopeOutput> __BuildStartEnvelope(WorkflowExpression<string> envelopeId)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddDocumentOutput> __BuildAddDocument(WorkflowExpression<string> envelopeId, WorkflowExpression<string> bodydocumentTitle = null, WorkflowExpression<string> bodyfileContent = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowExpression.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            WorkflowExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddDocumentOutput> __BuildAddDocumentDocx(WorkflowExpression<string> envelopeId, WorkflowExpression<string> bodydocumentTitle = null, WorkflowExpression<string> bodyfileContent = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowExpression.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            WorkflowExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddDocumentOutput> __BuildAddTemplate(WorkflowExpression<string> envelopeId, WorkflowExpression<string> bodydocumentTitle = null, WorkflowExpression<string> bodyfileContent = null, WorkflowExpression<string[]> bodytemplateData = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowExpression.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            WorkflowExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            WorkflowExpression.Validate(bodytemplateData, nameof(bodytemplateData), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddTemplateData(WorkflowExpression<string> documentId, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceSignature(WorkflowExpression<string> documentId, WorkflowExpression<string> bodyplaceKey = null, WorkflowExpression<string> bodyrecipientKey = null, WorkflowExpression<double> bodyplaceHeight = null, WorkflowExpression<double> bodypageNumber = null, WorkflowExpression<double> bodydistanceFromTop = null, WorkflowExpression<double> bodydistanceFromLeft = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowExpression.Validate(bodyplaceHeight, nameof(bodyplaceHeight), required: false);
            WorkflowExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceInitials(WorkflowExpression<string> documentId, WorkflowExpression<string> bodyplaceKey = null, WorkflowExpression<string> bodyrecipientKey = null, WorkflowExpression<double> bodyplaceHeight = null, WorkflowExpression<double> bodypageNumber = null, WorkflowExpression<double> bodydistanceFromTop = null, WorkflowExpression<double> bodydistanceFromLeft = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowExpression.Validate(bodyplaceHeight, nameof(bodyplaceHeight), required: false);
            WorkflowExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceTextInput(WorkflowExpression<string> documentId, WorkflowExpression<string> bodyplaceKey = null, WorkflowExpression<string> bodyrecipientKey = null, WorkflowExpression<string> bodycaptureAs = null, WorkflowExpression<string> bodyhint = null, WorkflowExpression<string> bodyprompt = null, WorkflowExpression<bodyrequirementInput> bodyrequirement = null, WorkflowExpression<string> bodyformat = null, WorkflowExpression<string> bodyformatMessage = null, WorkflowExpression<double> bodypageNumber = null, WorkflowExpression<double> bodydistanceFromTop = null, WorkflowExpression<double> bodydistanceFromLeft = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowExpression.Validate(bodycaptureAs, nameof(bodycaptureAs), required: false);
            WorkflowExpression.Validate(bodyhint, nameof(bodyhint), required: false);
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            WorkflowExpression.Validate(bodyrequirement, nameof(bodyrequirement), required: false);
            WorkflowExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowExpression.Validate(bodyformatMessage, nameof(bodyformatMessage), required: false);
            WorkflowExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceText(WorkflowExpression<string> documentId, WorkflowExpression<string> bodyplaceKey = null, WorkflowExpression<string> bodyvalue = null, WorkflowExpression<double> bodyfontSize = null, WorkflowExpression<string> bodyfontColor = null, WorkflowExpression<double> bodypageNumber = null, WorkflowExpression<double> bodydistanceFromTop = null, WorkflowExpression<double> bodydistanceFromLeft = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowExpression.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            WorkflowExpression.Validate(bodyfontColor, nameof(bodyfontColor), required: false);
            WorkflowExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceRecipientCompletedDate(WorkflowExpression<string> documentId, WorkflowExpression<string> bodyplaceKey = null, WorkflowExpression<string> bodyrecipientKey = null, WorkflowExpression<string> bodydateFormat = null, WorkflowExpression<double> bodypageNumber = null, WorkflowExpression<double> bodydistanceFromTop = null, WorkflowExpression<double> bodydistanceFromLeft = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowExpression.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            WorkflowExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPlaceEnvelopeCompletedDate(WorkflowExpression<string> documentId, WorkflowExpression<string> bodyplaceKey = null, WorkflowExpression<string> bodydateFormat = null, WorkflowExpression<double> bodypageNumber = null, WorkflowExpression<double> bodydistanceFromTop = null, WorkflowExpression<double> bodydistanceFromLeft = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            WorkflowExpression.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            WorkflowExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            WorkflowExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddRecipientSignerOutput> __BuildAddRecipient(WorkflowExpression<string> envelopeId, WorkflowExpression<string> bodyrecipientName = null, WorkflowExpression<string> bodyrecipientEmail = null, WorkflowExpression<string> bodyrecipientKey = null, WorkflowExpression<bodyrecipientCeremonyCreationInput> bodyrecipientCeremonyCreation = null, WorkflowExpression<bodyrecipientDeliveryTypeInput> bodyrecipientDeliveryType = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowExpression.Validate(bodyrecipientName, nameof(bodyrecipientName), required: false);
            WorkflowExpression.Validate(bodyrecipientEmail, nameof(bodyrecipientEmail), required: false);
            WorkflowExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            WorkflowExpression.Validate(bodyrecipientCeremonyCreation, nameof(bodyrecipientCeremonyCreation), required: false);
            WorkflowExpression.Validate(bodyrecipientDeliveryType, nameof(bodyrecipientDeliveryType), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Recipient> __BuildGetRecipient(WorkflowExpression<string> recipientId)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateCeremonyEmailLink(WorkflowExpression<string> recipientId, WorkflowExpression<string> bodyredirectURL = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowExpression.Validate(bodyredirectURL, nameof(bodyredirectURL), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCeremonyCustomOutput> __BuildCreateCeremonyCustom(WorkflowExpression<string> recipientId, WorkflowExpression<string> bodyauthenticationauthenticationProvider = null, WorkflowExpression<string[]> bodyauthenticationauthenticationData = null, WorkflowExpression<string> bodyredirectURL = null, WorkflowExpression<string> bodyextraProperties = null)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowExpression.Validate(bodyauthenticationauthenticationProvider, nameof(bodyauthenticationauthenticationProvider), required: false);
            WorkflowExpression.Validate(bodyauthenticationauthenticationData, nameof(bodyauthenticationauthenticationData), required: false);
            WorkflowExpression.Validate(bodyredirectURL, nameof(bodyredirectURL), required: false);
            WorkflowExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Envelope> __BuildWaitEnvelope(WorkflowExpression<string> envelopeId)
        {
            WorkflowExpression.Validate(envelopeId, nameof(envelopeId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Deliverable> __BuildGetDeliverable(WorkflowExpression<string> deliverableId)
        {
            WorkflowExpression.Validate(deliverableId, nameof(deliverableId), required: true);
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
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCreated([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeCreated(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeStarted))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeStarted([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeStarted(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeCompleted))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCompleted([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeCompleted(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeFailed))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeFailed([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeFailed(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForEnvelopeCanceled))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCanceled([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForEnvelopeCanceled(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientReleased))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReleased([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientReleased(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientSent))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientSent([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientSent(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientCompleted))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientCompleted([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientCompleted(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientRejected))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientRejected([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientRejected(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientBounced))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientBounced([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientBounced(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientFailed))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientFailed([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientFailed(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientReplaced))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReplaced([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientReplaced(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForRecipientResent))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientResent([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForRecipientResent(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForDeliverableGenerated))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableGenerated([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForDeliverableGenerated(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateEndpointForDeliverableFailed))]
        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableFailed([WorkflowExpression] Func<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCreateEndpointForDeliverableFailed(WorkflowExpression<string[]> bodytopics = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytopics, nameof(bodytopics), required: false);
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