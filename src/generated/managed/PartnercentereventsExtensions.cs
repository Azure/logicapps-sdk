//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterevents
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnercentereventsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        public IBodyWorkflowAction<ViewRegistrationResponse> ViewRegistration()
        {
            var apiCallPath = "/webhooks/v1/registration";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            return new ApiConnectionAction<ViewRegistrationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        [WorkflowExpressionFactory(nameof(__BuildEventRegistration))]
        public IWorkflowAction EventRegistration([WorkflowExpression] Func<string> bodysignatureTokenToMsSignatureHeader = null, [WorkflowExpression] Func<string[]> bodywebhookEvents = null, [WorkflowExpression] Func<string> bodywebhookUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEventRegistration(WorkflowValue<string> bodysignatureTokenToMsSignatureHeader = null, WorkflowValue<string[]> bodywebhookEvents = null, WorkflowValue<string> bodywebhookUrl = null)
        {
            WorkflowValue.Validate(bodysignatureTokenToMsSignatureHeader, nameof(bodysignatureTokenToMsSignatureHeader), required: false);
            WorkflowValue.Validate(bodywebhookEvents, nameof(bodywebhookEvents), required: false);
            WorkflowValue.Validate(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysignatureTokenToMsSignatureHeader != null)
                {
                    body["SignatureTokenToMsSignatureHeader"] = ExpressionConverter.ConvertO(bodysignatureTokenToMsSignatureHeader);
                    bodypropCount++;
                }

                if (bodywebhookEvents != null)
                {
                    body["WebhookEvents"] = ExpressionConverter.ConvertO(bodywebhookEvents);
                    bodypropCount++;
                }

                if (bodywebhookUrl != null)
                {
                    body["WebhookUrl"] = ExpressionConverter.ConvertO(bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRegistration))]
        public IBodyWorkflowAction<UpdateRegistrationResponse> UpdateRegistration([WorkflowExpression] Func<string> bodysignatureTokenToMsSignatureHeader = null, [WorkflowExpression] Func<string[]> bodywebhookEvents = null, [WorkflowExpression] Func<string> bodywebhookUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateRegistrationResponse> __BuildUpdateRegistration(WorkflowValue<string> bodysignatureTokenToMsSignatureHeader = null, WorkflowValue<string[]> bodywebhookEvents = null, WorkflowValue<string> bodywebhookUrl = null)
        {
            WorkflowValue.Validate(bodysignatureTokenToMsSignatureHeader, nameof(bodysignatureTokenToMsSignatureHeader), required: false);
            WorkflowValue.Validate(bodywebhookEvents, nameof(bodywebhookEvents), required: false);
            WorkflowValue.Validate(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            return new DeferredBodyAction<UpdateRegistrationResponse>(() =>
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysignatureTokenToMsSignatureHeader != null)
                {
                    body["SignatureTokenToMsSignatureHeader"] = ExpressionConverter.ConvertO(bodysignatureTokenToMsSignatureHeader);
                    bodypropCount++;
                }

                if (bodywebhookEvents != null)
                {
                    body["WebhookEvents"] = ExpressionConverter.ConvertO(bodywebhookEvents);
                    bodypropCount++;
                }

                if (bodywebhookUrl != null)
                {
                    body["WebhookUrl"] = ExpressionConverter.ConvertO(bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateRegistrationResponse>(callPayload);
            });
        }
    }

    public class PartnercentereventsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ViewRegistrationResponse
    {
        public string[] WebhookEvents { get; set; }
        public string WebhookUrl { get; set; }
    }

    public class UpdateRegistrationResponse
    {
        public string SubscriberId { get; set; }
        public string[] WebhookEvents { get; set; }
        public string WebhookUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterevents;

    public partial class WorkflowManagedActions
    {
        public PartnercentereventsActions Partnercenterevents(string connectionId) => new PartnercentereventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PartnercentereventsTriggers Partnercenterevents(string connectionId) => new PartnercentereventsTriggers(connectionId);
    }
}
