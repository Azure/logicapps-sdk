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
        public IBodyWorkflowAction<CreateEnvelopeOutput, ApiConnectionActionConfiguration> CreateEnvelope(Expression<Func<CreateEnvelopeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEnvelopeOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEnvelopeOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Envelope, ApiConnectionActionConfiguration> GetEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<Envelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Capture, ApiConnectionActionConfiguration> GetCapture(Expression<Func<string>> envelopeId, Expression<Func<string>> captureKey)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_captureKey = WorkflowExpression.Compile(captureKey, nameof(captureKey), required: true);
            return new DeferredBodyAction<Capture, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}+alias1", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["captureKey"] = ExpressionConverter.Convert(__workflow_captureKey);
                return new ApiConnectionAction<Capture>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<StartEnvelopeOutput, ApiConnectionActionConfiguration> StartEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<StartEnvelopeOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/start", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StartEnvelopeOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput, ApiConnectionActionConfiguration> AddDocument(Expression<Func<string>> envelopeId, Expression<Func<AddDocumentBodyInput>> body)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddDocumentOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddDocumentOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput, ApiConnectionActionConfiguration> AddDocumentDocx(Expression<Func<string>> envelopeId, Expression<Func<AddDocumentDocxBodyInput>> body)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddDocumentOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents+alias1", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddDocumentOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddDocumentOutput, ApiConnectionActionConfiguration> AddTemplate(Expression<Func<string>> envelopeId, Expression<Func<AddTemplateBodyInput>> body)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddDocumentOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents+alias2", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddDocumentOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddTemplateData(Expression<Func<string>> documentId, Expression<Func<AddTemplateDataBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integrations/power-platform/documents/{0}/add-data", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPlaceSignature(Expression<Func<string>> documentId, Expression<Func<AddPlaceSignatureBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integrations/power-platform/documents/{0}/add-signature-place", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPlaceInitials(Expression<Func<string>> documentId, Expression<Func<AddPlaceInitialsBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integrations/power-platform/documents/{0}/add-initials-place", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPlaceTextInput(Expression<Func<string>> documentId, Expression<Func<AddPlaceTextInputBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integrations/power-platform/documents/{0}/add-text-input-place", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPlaceText(Expression<Func<string>> documentId, Expression<Func<AddPlaceTextBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integrations/power-platform/documents/{0}/add-text-place", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPlaceRecipientCompletedDate(Expression<Func<string>> documentId, Expression<Func<AddPlaceRecipientCompletedDateBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integrations/power-platform/documents/{0}/add-recipient-completed-date-place", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPlaceEnvelopeCompletedDate(Expression<Func<string>> documentId, Expression<Func<AddPlaceEnvelopeCompletedDateBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integrations/power-platform/documents/{0}/add-envelope-completed-date-place", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<AddRecipientSignerOutput, ApiConnectionActionConfiguration> AddRecipient(Expression<Func<string>> envelopeId, Expression<Func<AddRecipientBodyInput>> body)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddRecipientSignerOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddRecipientSignerOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Recipient, ApiConnectionActionConfiguration> GetRecipient(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<Recipient, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/recipients/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Recipient>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateCeremonyEmailLink(Expression<Func<string>> recipientId, Expression<Func<CreateCeremonyEmailLinkBodyInput>> body)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/recipients/{0}/ceremony", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<CreateCeremonyCustomOutput, ApiConnectionActionConfiguration> CreateCeremonyCustom(Expression<Func<string>> recipientId, Expression<Func<CreateCeremonyCustomBodyInput>> body)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCeremonyCustomOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/recipients/{0}/ceremony+alias1", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCeremonyCustomOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Envelope, ApiConnectionActionConfiguration> WaitEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<Envelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integrations/power-platform/envelopes/{0}/wait", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signatureapi")]
        public IBodyWorkflowAction<Deliverable, ApiConnectionActionConfiguration> GetDeliverable(Expression<Func<string>> deliverableId)
        {
            var __workflow_deliverableId = WorkflowExpression.Compile(deliverableId, nameof(deliverableId), required: true);
            return new DeferredBodyAction<Deliverable, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deliverables/{0}", __workflow_deliverableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Deliverable>(callPayload);
            });
        }
    }

    public class SignatureapiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForEnvelopeCreated(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForEnvelopeStarted(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.started";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForEnvelopeCompleted(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForEnvelopeFailed(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForEnvelopeCanceled(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/envelope.canceled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForRecipientReleased(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.released";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForRecipientSent(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.sent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForRecipientCompleted(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForRecipientRejected(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.rejected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForRecipientBounced(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.bounced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForRecipientFailed(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForRecipientReplaced(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.replaced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForRecipientResent(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/recipient.resent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForDeliverableGenerated(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/deliverable.generated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateEndpointForDeliverableFailed(Expression<Func<CreateEndpointForDeliverableFailedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integrations/power-platform/webhooks/deliverable.failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
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
        public CreateEnvelopeEnvelopeModeResponse Mode { get; set; }

        [JsonProperty("routing")]
        public CreateEnvelopeEnvelopeRoutingResponse Routing { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timestamp_format")]
        public string TimestampFormat { get; set; }

        [JsonProperty("attestation")]
        public CreateEnvelopeEnvelopeAttestationResponse Attestation { get; set; }

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
    public enum CreateEnvelopeEnvelopeModeResponse
    {
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "test")]
        Test
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeEnvelopeRoutingResponse
    {
        [EnumMember(Value = "parallel")]
        Parallel,
        [EnumMember(Value = "sequential")]
        Sequential
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeEnvelopeAttestationResponse
    {
        [EnumMember(Value = "mx_nom151")]
        MxNom151
    }

    public class CreateEnvelopeBodyInput
    {
        [JsonProperty("draft", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool DraftEnvelope { get; set; } = true;

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EnvelopeTitle { get; set; }

        [JsonProperty("label")]
        public string EnvelopeLabel { get; set; }

        [JsonProperty("message")]
        public string EnvelopeMessage { get; set; }

        [JsonProperty("mode")]
        public CreateEnvelopeEnvelopeMode? EnvelopeMode { get; set; }

        [JsonProperty("routing")]
        public CreateEnvelopeEnvelopeRouting? EnvelopeRouting { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }

        [JsonProperty("timestamp_format")]
        public string TimestampFormat { get; set; }

        [JsonProperty("attestation")]
        public CreateEnvelopeEnvelopeAttestation? EnvelopeAttestation { get; set; }

        [JsonProperty("sender")]
        public BodyInputSenderType Sender { get; set; }

        [JsonProperty("topics")]
        public string[] EnvelopeTopics { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeEnvelopeMode
    {
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "test")]
        Test
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeEnvelopeRouting
    {
        [EnumMember(Value = "parallel")]
        Parallel,
        [EnumMember(Value = "sequential")]
        Sequential
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeEnvelopeAttestation
    {
        [EnumMember(Value = "mx_nom151")]
        MxNom151
    }

    public class BodyInputSenderType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
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
        public CreateEnvelopeEnvelopeModeResponse Mode { get; set; }

        [JsonProperty("routing")]
        public CreateEnvelopeEnvelopeRoutingResponse Routing { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timestamp_format")]
        public string TimestampFormat { get; set; }

        [JsonProperty("attestation")]
        public CreateEnvelopeEnvelopeAttestationResponse Attestation { get; set; }

        [JsonProperty("topics")]
        public string[] Topics { get; set; }
    }

    public class EnvelopeDeliverable
    {
        [JsonProperty("id")]
        public string DeliverableId { get; set; }
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

    public class AddDocumentBodyInput
    {
        [JsonProperty("title")]
        public string DocumentTitle { get; set; }

        [JsonProperty("file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string FileFormat { get; set; } = "pdf";

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class AddDocumentDocxBodyInput
    {
        [JsonProperty("title")]
        public string DocumentTitle { get; set; }

        [JsonProperty("file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string FileFormat { get; set; } = "docx";

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class AddTemplateBodyInput
    {
        [JsonProperty("title")]
        public string DocumentTitle { get; set; }

        [JsonProperty("file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string FileFormat { get; set; } = "docx";

        [JsonProperty("data")]
        public string[] TemplateData { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class AddTemplateDataBodyInput
    {
        [JsonProperty("field_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class AddPlaceSignatureBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string PlaceType { get; set; } = "signature";

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceKey { get; set; }

        [JsonProperty("recipient_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientKey { get; set; }

        [JsonProperty("height")]
        public double? PlaceHeight { get; set; }

        [JsonProperty("page")]
        public double? PageNumber { get; set; }

        [JsonProperty("top")]
        public double? DistanceFromTop { get; set; }

        [JsonProperty("left")]
        public double? DistanceFromLeft { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class AddPlaceInitialsBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string PlaceType { get; set; } = "initials";

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceKey { get; set; }

        [JsonProperty("recipient_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientKey { get; set; }

        [JsonProperty("height")]
        public double? PlaceHeight { get; set; }

        [JsonProperty("page")]
        public double? PageNumber { get; set; }

        [JsonProperty("top")]
        public double? DistanceFromTop { get; set; }

        [JsonProperty("left")]
        public double? DistanceFromLeft { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class AddPlaceTextInputBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string PlaceType { get; set; } = "text_input";

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceKey { get; set; }

        [JsonProperty("recipient_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientKey { get; set; }

        [JsonProperty("capture_as")]
        public string CaptureAs { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("requirement", DefaultValueHandling = DefaultValueHandling.Include)]
        public PlaceRequirement? Requirement { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Signatureapi.PlaceRequirement.Required;

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("format_message")]
        public string FormatMessage { get; set; }

        [JsonProperty("page")]
        public double? PageNumber { get; set; }

        [JsonProperty("top")]
        public double? DistanceFromTop { get; set; }

        [JsonProperty("left")]
        public double? DistanceFromLeft { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaceRequirement
    {
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "optional")]
        Optional
    }

    public class AddPlaceTextBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string PlaceType { get; set; } = "text";

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceKey { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty("font_size")]
        public double? FontSize { get; set; }

        [JsonProperty("font_color")]
        public string FontColor { get; set; }

        [JsonProperty("page")]
        public double? PageNumber { get; set; }

        [JsonProperty("top")]
        public double? DistanceFromTop { get; set; }

        [JsonProperty("left")]
        public double? DistanceFromLeft { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class AddPlaceRecipientCompletedDateBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string PlaceType { get; set; } = "recipient_completed_date";

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceKey { get; set; }

        [JsonProperty("recipient_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientKey { get; set; }

        [JsonProperty("date_format")]
        public string DateFormat { get; set; }

        [JsonProperty("page")]
        public double? PageNumber { get; set; }

        [JsonProperty("top")]
        public double? DistanceFromTop { get; set; }

        [JsonProperty("left")]
        public double? DistanceFromLeft { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class AddPlaceEnvelopeCompletedDateBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string PlaceType { get; set; } = "envelope_completed_date";

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceKey { get; set; }

        [JsonProperty("date_format")]
        public string DateFormat { get; set; }

        [JsonProperty("page")]
        public double? PageNumber { get; set; }

        [JsonProperty("top")]
        public double? DistanceFromTop { get; set; }

        [JsonProperty("left")]
        public double? DistanceFromLeft { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
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
        public AddRecipientRecipientCeremonyCreationResponse CeremonyCreation { get; set; }

        [JsonProperty("delivery_type")]
        public AddRecipientRecipientDeliveryTypeResponse DeliveryType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddRecipientRecipientCeremonyCreationResponse
    {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "manual")]
        Manual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddRecipientRecipientDeliveryTypeResponse
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "none")]
        None
    }

    public class AddRecipientBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string RecipientType { get; set; } = "signer";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientEmail { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientKey { get; set; }

        [JsonProperty("ceremony_creation")]
        public AddRecipientRecipientCeremonyCreation? RecipientCeremonyCreation { get; set; }

        [JsonProperty("delivery_type")]
        public AddRecipientRecipientDeliveryType? RecipientDeliveryType { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddRecipientRecipientCeremonyCreation
    {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "manual")]
        Manual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddRecipientRecipientDeliveryType
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
        public AddRecipientRecipientCeremonyCreationResponse CeremonyCreation { get; set; }

        [JsonProperty("delivery_type")]
        public AddRecipientRecipientDeliveryTypeResponse DeliveryType { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }
    }

    public class CreateCeremonyEmailLinkBodyInput
    {
        [JsonProperty("authentication", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCeremonyEmailLinkBodyInputAuthenticationType Authentication { get; set; } = new CreateCeremonyEmailLinkBodyInputAuthenticationType();

        [JsonProperty("redirect_url")]
        public string RedirectURL { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class CreateCeremonyEmailLinkBodyInputAuthenticationType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CeremonyType { get; set; } = "email_link";
    }

    public class CreateCeremonyCustomOutput
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CreateCeremonyCustomBodyInput
    {
        [JsonProperty("authentication", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCeremonyCustomBodyInputAuthenticationType Authentication { get; set; } = new CreateCeremonyCustomBodyInputAuthenticationType();

        [JsonProperty("redirect_url")]
        public string RedirectURL { get; set; }

        [JsonProperty("extra")]
        public string ExtraProperties { get; set; }
    }

    public class CreateCeremonyCustomBodyInputAuthenticationType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CeremonyType { get; set; } = "custom";

        [JsonProperty("provider", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthenticationProvider { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] AuthenticationData { get; set; }
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

    public class CreateEndpointForDeliverableFailedBodyInput
    {
        [JsonProperty("topics")]
        public string[] Topics { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EndpointURL { get; set; } = "#{listCallbackUrl()}";
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