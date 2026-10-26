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
        public IBodyWorkflowAction<ViewRegistrationResponse, ApiConnectionActionConfiguration> ViewRegistration()
        {
            return new DeferredBodyAction<ViewRegistrationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                return new ApiConnectionAction<ViewRegistrationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EventRegistration(Expression<Func<EventRegistrationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        public IBodyWorkflowAction<UpdateRegistrationResponse, ApiConnectionActionConfiguration> UpdateRegistration(Expression<Func<UpdateRegistrationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateRegistrationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class EventRegistrationInput
    {
        public string SignatureTokenToMsSignatureHeader { get; set; }
        public string[] WebhookEvents { get; set; }
        public string WebhookUrl { get; set; }
    }

    public class UpdateRegistrationResponse
    {
        public string SubscriberId { get; set; }
        public string[] WebhookEvents { get; set; }
        public string WebhookUrl { get; set; }
    }

    public class UpdateRegistrationInput
    {
        public string SignatureTokenToMsSignatureHeader { get; set; }
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