//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterevents
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
        public IWorkflowAction EventRegistration(Expression<Func<string>> bodysignatureTokenToMsSignatureHeader = null, Expression<Func<string[]>> bodywebhookEvents = null, Expression<Func<string>> bodywebhookUrl = null)
        {
            var __workflow_bodysignatureTokenToMsSignatureHeader = WorkflowExpression.Compile(bodysignatureTokenToMsSignatureHeader, nameof(bodysignatureTokenToMsSignatureHeader), required: false);
            var __workflow_bodywebhookEvents = WorkflowExpression.Compile(bodywebhookEvents, nameof(bodywebhookEvents), required: false);
            var __workflow_bodywebhookUrl = WorkflowExpression.Compile(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysignatureTokenToMsSignatureHeader != null)
                {
                    body["SignatureTokenToMsSignatureHeader"] = ExpressionConverter.ConvertO(__workflow_bodysignatureTokenToMsSignatureHeader);
                    bodypropCount++;
                }

                if (__workflow_bodywebhookEvents != null)
                {
                    body["WebhookEvents"] = ExpressionConverter.ConvertO(__workflow_bodywebhookEvents);
                    bodypropCount++;
                }

                if (__workflow_bodywebhookUrl != null)
                {
                    body["WebhookUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        public IBodyWorkflowAction<UpdateRegistrationResponse> UpdateRegistration(Expression<Func<string>> bodysignatureTokenToMsSignatureHeader = null, Expression<Func<string[]>> bodywebhookEvents = null, Expression<Func<string>> bodywebhookUrl = null)
        {
            var __workflow_bodysignatureTokenToMsSignatureHeader = WorkflowExpression.Compile(bodysignatureTokenToMsSignatureHeader, nameof(bodysignatureTokenToMsSignatureHeader), required: false);
            var __workflow_bodywebhookEvents = WorkflowExpression.Compile(bodywebhookEvents, nameof(bodywebhookEvents), required: false);
            var __workflow_bodywebhookUrl = WorkflowExpression.Compile(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            return new DeferredBodyAction<UpdateRegistrationResponse>(() =>
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysignatureTokenToMsSignatureHeader != null)
                {
                    body["SignatureTokenToMsSignatureHeader"] = ExpressionConverter.ConvertO(__workflow_bodysignatureTokenToMsSignatureHeader);
                    bodypropCount++;
                }

                if (__workflow_bodywebhookEvents != null)
                {
                    body["WebhookEvents"] = ExpressionConverter.ConvertO(__workflow_bodywebhookEvents);
                    bodypropCount++;
                }

                if (__workflow_bodywebhookUrl != null)
                {
                    body["WebhookUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateRegistrationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
