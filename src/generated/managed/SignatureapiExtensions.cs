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
        public IBodyWorkflowAction<CreateEnvelopeOutput> CreateEnvelope([WorkflowExpression] Func<string> bodyenvelopeTitle = null, [WorkflowExpression] Func<string> bodyenvelopeLabel = null, [WorkflowExpression] Func<string> bodyenvelopeMessage = null, [WorkflowExpression] Func<bodyenvelopeModeInput> bodyenvelopeMode = null, [WorkflowExpression] Func<bodyenvelopeRoutingInput> bodyenvelopeRouting = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodytimestampFormat = null, [WorkflowExpression] Func<bodyenvelopeAttestationInput> bodyenvelopeAttestation = null, [WorkflowExpression] Func<string> bodysendername = null, [WorkflowExpression] Func<string> bodysenderemail = null, [WorkflowExpression] Func<string[]> bodyenvelopeTopics = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(bodyenvelopeTitle, nameof(bodyenvelopeTitle), required: false);
            SourceExpression.Validate(bodyenvelopeLabel, nameof(bodyenvelopeLabel), required: false);
            SourceExpression.Validate(bodyenvelopeMessage, nameof(bodyenvelopeMessage), required: false);
            SourceExpression.Validate(bodyenvelopeMode, nameof(bodyenvelopeMode), required: false);
            SourceExpression.Validate(bodyenvelopeRouting, nameof(bodyenvelopeRouting), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            SourceExpression.Validate(bodytimestampFormat, nameof(bodytimestampFormat), required: false);
            SourceExpression.Validate(bodyenvelopeAttestation, nameof(bodyenvelopeAttestation), required: false);
            SourceExpression.Validate(bodysendername, nameof(bodysendername), required: false);
            SourceExpression.Validate(bodysenderemail, nameof(bodysenderemail), required: false);
            SourceExpression.Validate(bodyenvelopeTopics, nameof(bodyenvelopeTopics), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    body["title"] = SourceExpressionConverter.ConvertToken(bodyenvelopeTitle);
                    bodypropCount++;
                }

                if (bodyenvelopeLabel != null)
                {
                    body["label"] = SourceExpressionConverter.ConvertToken(bodyenvelopeLabel);
                    bodypropCount++;
                }

                if (bodyenvelopeMessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodyenvelopeMessage);
                    bodypropCount++;
                }

                if (bodyenvelopeMode != null)
                {
                    body["mode"] = SourceExpressionConverter.Convert(bodyenvelopeMode);
                    bodypropCount++;
                }

                if (bodyenvelopeRouting != null)
                {
                    body["routing"] = SourceExpressionConverter.Convert(bodyenvelopeRouting);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodytimestampFormat != null)
                {
                    body["timestamp_format"] = SourceExpressionConverter.ConvertToken(bodytimestampFormat);
                    bodypropCount++;
                }

                if (bodyenvelopeAttestation != null)
                {
                    body["attestation"] = SourceExpressionConverter.Convert(bodyenvelopeAttestation);
                    bodypropCount++;
                }

                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (bodysendername != null)
                {
                    senderObject["name"] = SourceExpressionConverter.ConvertToken(bodysendername);
                    senderObjectpropCount++;
                }

                if (bodysenderemail != null)
                {
                    senderObject["email"] = SourceExpressionConverter.ConvertToken(bodysenderemail);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (bodyenvelopeTopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodyenvelopeTopics);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateEnvelopeOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction DeleteEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Envelope> GetEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Envelope>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Capture> GetCapture([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> captureKey)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(captureKey, nameof(captureKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}+alias1", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["captureKey"] = SourceExpressionConverter.ConvertO(captureKey);
                return callPayload;
            }

            return new ApiConnectionAction<Capture>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<StartEnvelopeOutput> StartEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/start", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StartEnvelopeOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddDocument([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodydocumentTitle = null, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            SourceExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentTitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodydocumentTitle);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["file_content"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "pdf";
                bodypropCount++;
                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddDocumentOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddDocumentDocx([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodydocumentTitle = null, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            SourceExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents+alias1", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentTitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodydocumentTitle);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["file_content"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "docx";
                bodypropCount++;
                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddDocumentOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput> AddTemplate([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodydocumentTitle = null, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<string[]> bodytemplateData = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(bodydocumentTitle, nameof(bodydocumentTitle), required: false);
            SourceExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            SourceExpression.Validate(bodytemplateData, nameof(bodytemplateData), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents+alias2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentTitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodydocumentTitle);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["file_content"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                    bodypropCount++;
                }

                body["format"] = "docx";
                bodypropCount++;
                if (bodytemplateData != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodytemplateData);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddDocumentOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddTemplateData([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldName != null)
                {
                    body["field_name"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceSignature([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<double> bodyplaceHeight = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            SourceExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            SourceExpression.Validate(bodyplaceHeight, nameof(bodyplaceHeight), required: false);
            SourceExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            SourceExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            SourceExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-signature-place", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "signature";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["recipient_key"] = SourceExpressionConverter.ConvertToken(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodyplaceHeight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyplaceHeight);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = SourceExpressionConverter.ConvertToken(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = SourceExpressionConverter.ConvertToken(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceInitials([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<double> bodyplaceHeight = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            SourceExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            SourceExpression.Validate(bodyplaceHeight, nameof(bodyplaceHeight), required: false);
            SourceExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            SourceExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            SourceExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-initials-place", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "initials";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["recipient_key"] = SourceExpressionConverter.ConvertToken(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodyplaceHeight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyplaceHeight);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = SourceExpressionConverter.ConvertToken(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = SourceExpressionConverter.ConvertToken(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceTextInput([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<string> bodycaptureAs = null, [WorkflowExpression] Func<string> bodyhint = null, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<bodyrequirementInput> bodyrequirement = null, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodyformatMessage = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            SourceExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            SourceExpression.Validate(bodycaptureAs, nameof(bodycaptureAs), required: false);
            SourceExpression.Validate(bodyhint, nameof(bodyhint), required: false);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            SourceExpression.Validate(bodyrequirement, nameof(bodyrequirement), required: false);
            SourceExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            SourceExpression.Validate(bodyformatMessage, nameof(bodyformatMessage), required: false);
            SourceExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            SourceExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            SourceExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-text-input-place", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "text_input";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["recipient_key"] = SourceExpressionConverter.ConvertToken(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodycaptureAs != null)
                {
                    body["capture_as"] = SourceExpressionConverter.ConvertToken(bodycaptureAs);
                    bodypropCount++;
                }

                if (bodyhint != null)
                {
                    body["hint"] = SourceExpressionConverter.ConvertToken(bodyhint);
                    bodypropCount++;
                }

                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                if (bodyrequirement != null)
                {
                    if (bodyrequirement != null)
                    {
                        body["requirement"] = SourceExpressionConverter.Convert(bodyrequirement);
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
                    body["format"] = SourceExpressionConverter.ConvertToken(bodyformat);
                    bodypropCount++;
                }

                if (bodyformatMessage != null)
                {
                    body["format_message"] = SourceExpressionConverter.ConvertToken(bodyformatMessage);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = SourceExpressionConverter.ConvertToken(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = SourceExpressionConverter.ConvertToken(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceText([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyvalue = null, [WorkflowExpression] Func<double> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            SourceExpression.Validate(bodyfontColor, nameof(bodyfontColor), required: false);
            SourceExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            SourceExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            SourceExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-text-place", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "text";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodyfontSize != null)
                {
                    body["font_size"] = SourceExpressionConverter.ConvertToken(bodyfontSize);
                    bodypropCount++;
                }

                if (bodyfontColor != null)
                {
                    body["font_color"] = SourceExpressionConverter.ConvertToken(bodyfontColor);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = SourceExpressionConverter.ConvertToken(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = SourceExpressionConverter.ConvertToken(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceRecipientCompletedDate([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            SourceExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            SourceExpression.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            SourceExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            SourceExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            SourceExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-recipient-completed-date-place", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "recipient_completed_date";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["recipient_key"] = SourceExpressionConverter.ConvertToken(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodydateFormat != null)
                {
                    body["date_format"] = SourceExpressionConverter.ConvertToken(bodydateFormat);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = SourceExpressionConverter.ConvertToken(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = SourceExpressionConverter.ConvertToken(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction AddPlaceEnvelopeCompletedDate([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyplaceKey = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<double> bodypageNumber = null, [WorkflowExpression] Func<double> bodydistanceFromTop = null, [WorkflowExpression] Func<double> bodydistanceFromLeft = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyplaceKey, nameof(bodyplaceKey), required: false);
            SourceExpression.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            SourceExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            SourceExpression.Validate(bodydistanceFromTop, nameof(bodydistanceFromTop), required: false);
            SourceExpression.Validate(bodydistanceFromLeft, nameof(bodydistanceFromLeft), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/documents/{0}/add-envelope-completed-date-place", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "envelope_completed_date";
                bodypropCount++;
                if (bodyplaceKey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodyplaceKey);
                    bodypropCount++;
                }

                if (bodydateFormat != null)
                {
                    body["date_format"] = SourceExpressionConverter.ConvertToken(bodydateFormat);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                    bodypropCount++;
                }

                if (bodydistanceFromTop != null)
                {
                    body["top"] = SourceExpressionConverter.ConvertToken(bodydistanceFromTop);
                    bodypropCount++;
                }

                if (bodydistanceFromLeft != null)
                {
                    body["left"] = SourceExpressionConverter.ConvertToken(bodydistanceFromLeft);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddRecipientSignerOutput> AddRecipient([WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodyrecipientName = null, [WorkflowExpression] Func<string> bodyrecipientEmail = null, [WorkflowExpression] Func<string> bodyrecipientKey = null, [WorkflowExpression] Func<bodyrecipientCeremonyCreationInput> bodyrecipientCeremonyCreation = null, [WorkflowExpression] Func<bodyrecipientDeliveryTypeInput> bodyrecipientDeliveryType = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(bodyrecipientName, nameof(bodyrecipientName), required: false);
            SourceExpression.Validate(bodyrecipientEmail, nameof(bodyrecipientEmail), required: false);
            SourceExpression.Validate(bodyrecipientKey, nameof(bodyrecipientKey), required: false);
            SourceExpression.Validate(bodyrecipientCeremonyCreation, nameof(bodyrecipientCeremonyCreation), required: false);
            SourceExpression.Validate(bodyrecipientDeliveryType, nameof(bodyrecipientDeliveryType), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "signer";
                bodypropCount++;
                if (bodyrecipientName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyrecipientName);
                    bodypropCount++;
                }

                if (bodyrecipientEmail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyrecipientEmail);
                    bodypropCount++;
                }

                if (bodyrecipientKey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodyrecipientKey);
                    bodypropCount++;
                }

                if (bodyrecipientCeremonyCreation != null)
                {
                    body["ceremony_creation"] = SourceExpressionConverter.Convert(bodyrecipientCeremonyCreation);
                    bodypropCount++;
                }

                if (bodyrecipientDeliveryType != null)
                {
                    body["delivery_type"] = SourceExpressionConverter.Convert(bodyrecipientDeliveryType);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddRecipientSignerOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Recipient> GetRecipient([WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/recipients/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Recipient>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<JToken> CreateCeremonyEmailLink([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodyredirectURL = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            SourceExpression.Validate(bodyredirectURL, nameof(bodyredirectURL), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/recipients/{0}/ceremony", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
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
                    body["redirect_url"] = SourceExpressionConverter.ConvertToken(bodyredirectURL);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<CreateCeremonyCustomOutput> CreateCeremonyCustom([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodyauthenticationauthenticationProvider = null, [WorkflowExpression] Func<string[]> bodyauthenticationauthenticationData = null, [WorkflowExpression] Func<string> bodyredirectURL = null, [WorkflowExpression] Func<string> bodyextraProperties = null)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            SourceExpression.Validate(bodyauthenticationauthenticationProvider, nameof(bodyauthenticationauthenticationProvider), required: false);
            SourceExpression.Validate(bodyauthenticationauthenticationData, nameof(bodyauthenticationauthenticationData), required: false);
            SourceExpression.Validate(bodyredirectURL, nameof(bodyredirectURL), required: false);
            SourceExpression.Validate(bodyextraProperties, nameof(bodyextraProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/recipients/{0}/ceremony+alias1", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
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
                    authenticationObject["provider"] = SourceExpressionConverter.ConvertToken(bodyauthenticationauthenticationProvider);
                    authenticationObjectpropCount++;
                }

                if (bodyauthenticationauthenticationData != null)
                {
                    authenticationObject["data"] = SourceExpressionConverter.ConvertToken(bodyauthenticationauthenticationData);
                    authenticationObjectpropCount++;
                }

                if (authenticationObjectpropCount > 0)
                {
                    body["authentication"] = authenticationObject;
                    bodypropCount++;
                }

                if (bodyredirectURL != null)
                {
                    body["redirect_url"] = SourceExpressionConverter.ConvertToken(bodyredirectURL);
                    bodypropCount++;
                }

                if (bodyextraProperties != null)
                {
                    body["extra"] = SourceExpressionConverter.ConvertToken(bodyextraProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCeremonyCustomOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Envelope> WaitEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integrations/power-platform/envelopes/{0}/wait", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Envelope>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Deliverable> GetDeliverable([WorkflowExpression] Func<string> deliverableId)
        {
            SourceExpression.Validate(deliverableId, nameof(deliverableId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/deliverables/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deliverableId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Deliverable>(BuildSourceInput);
        }
    }

    public class SignatureapiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCreated([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeStarted([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.started";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCompleted([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeFailed([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForEnvelopeCanceled([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.canceled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReleased([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.released";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientSent([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.sent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientCompleted([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientRejected([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.rejected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientBounced([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.bounced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientFailed([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientReplaced([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.replaced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForRecipientResent([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.resent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableGenerated([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/deliverable.generated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateEndpointForDeliverableFailed([WorkflowExpression] Func<string[]> bodytopics = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytopics, nameof(bodytopics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integrations/power-platform/webhooks/deliverable.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopics != null)
                {
                    body["topics"] = SourceExpressionConverter.ConvertToken(bodytopics);
                    bodypropCount++;
                }

                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
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