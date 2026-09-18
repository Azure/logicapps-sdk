//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterevents
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnercentereventsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        public IBodyWorkflowAction<ViewRegistrationResponse> ViewRegistration()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ViewRegistrationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        public IWorkflowAction EventRegistration([WorkflowExpression] Func<string> bodysignatureTokenToMsSignatureHeader = null, [WorkflowExpression] Func<string[]> bodywebhookEvents = null, [WorkflowExpression] Func<string> bodywebhookUrl = null)
        {
            SourceExpression.Validate(bodysignatureTokenToMsSignatureHeader, nameof(bodysignatureTokenToMsSignatureHeader), required: false);
            SourceExpression.Validate(bodywebhookEvents, nameof(bodywebhookEvents), required: false);
            SourceExpression.Validate(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysignatureTokenToMsSignatureHeader != null)
                {
                    body["SignatureTokenToMsSignatureHeader"] = SourceExpressionConverter.ConvertToken(bodysignatureTokenToMsSignatureHeader);
                    bodypropCount++;
                }

                if (bodywebhookEvents != null)
                {
                    body["WebhookEvents"] = SourceExpressionConverter.ConvertToken(bodywebhookEvents);
                    bodypropCount++;
                }

                if (bodywebhookUrl != null)
                {
                    body["WebhookUrl"] = SourceExpressionConverter.ConvertToken(bodywebhookUrl);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterevents")]
        public IBodyWorkflowAction<UpdateRegistrationResponse> UpdateRegistration([WorkflowExpression] Func<string> bodysignatureTokenToMsSignatureHeader = null, [WorkflowExpression] Func<string[]> bodywebhookEvents = null, [WorkflowExpression] Func<string> bodywebhookUrl = null)
        {
            SourceExpression.Validate(bodysignatureTokenToMsSignatureHeader, nameof(bodysignatureTokenToMsSignatureHeader), required: false);
            SourceExpression.Validate(bodywebhookEvents, nameof(bodywebhookEvents), required: false);
            SourceExpression.Validate(bodywebhookUrl, nameof(bodywebhookUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/v1/registration";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysignatureTokenToMsSignatureHeader != null)
                {
                    body["SignatureTokenToMsSignatureHeader"] = SourceExpressionConverter.ConvertToken(bodysignatureTokenToMsSignatureHeader);
                    bodypropCount++;
                }

                if (bodywebhookEvents != null)
                {
                    body["WebhookEvents"] = SourceExpressionConverter.ConvertToken(bodywebhookEvents);
                    bodypropCount++;
                }

                if (bodywebhookUrl != null)
                {
                    body["WebhookUrl"] = SourceExpressionConverter.ConvertToken(bodywebhookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateRegistrationResponse>(BuildSourceInput);
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