//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hellosign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HellosignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        public IBodyWorkflowAction<RequestResponse> CreateRequest([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<testModeInput> testMode = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<string> message = null, [WorkflowExpression] Func<string> signingRedirectUrl = null, [WorkflowExpression] Func<bool> allowDecline = null, [WorkflowExpression] Func<object> signers = null)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(testMode, nameof(testMode), required: false);
            SourceExpression.Validate(subject, nameof(subject), required: false);
            SourceExpression.Validate(message, nameof(message), required: false);
            SourceExpression.Validate(signingRedirectUrl, nameof(signingRedirectUrl), required: false);
            SourceExpression.Validate(allowDecline, nameof(allowDecline), required: false);
            SourceExpression.Validate(signers, nameof(signers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/signature_request/send_with_template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (testMode != null)
                    callPayload.Queries["test_mode"] = SourceExpressionConverter.Convert(testMode);
                callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                if (subject != null)
                    callPayload.Queries["subject"] = SourceExpressionConverter.ConvertO(subject);
                if (message != null)
                    callPayload.Queries["message"] = SourceExpressionConverter.ConvertO(message);
                if (signingRedirectUrl != null)
                    callPayload.Queries["signing_redirect_url"] = SourceExpressionConverter.ConvertO(signingRedirectUrl);
                if (allowDecline != null)
                    callPayload.Queries["allow_decline"] = SourceExpressionConverter.ConvertO(allowDecline);
                callPayload.Body = SourceExpressionConverter.ConvertToken(signers);
                return callPayload;
            }

            return new ApiConnectionAction<RequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        public IBodyWorkflowAction<RequestResponse> GetRequest([WorkflowExpression] Func<string> requestId)
        {
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/signature_request/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        public IWorkflowAction CancelRequest([WorkflowExpression] Func<string> requestId)
        {
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/signature_request/cancel/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class HellosignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RequestResponse[]> OnNewRequest(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/request_trigger/v3/signature_request/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<RequestResponse[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RequestResponse[]> OnRequestCompleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/complete_trigger/v3/signature_request/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<RequestResponse[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RequestResponse[]> OnRequestDeclined(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/decline_trigger/v3/signature_request/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<RequestResponse[]>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class RequestResponse
    {
        [JsonProperty("signature_request_id")]
        public string RequestId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("is_complete")]
        public bool IsComplete { get; set; }

        [JsonProperty("is_declined")]
        public bool IsDeclined { get; set; }

        [JsonProperty("signing_url")]
        public string SigningUrl { get; set; }

        [JsonProperty("details_url")]
        public string DetailsUrl { get; set; }

        [JsonProperty("requester_email_address")]
        public string RequesterEmail { get; set; }

        [JsonProperty("signatures")]
        public RequestResponseSignaturesTypeItem[] Signatures { get; set; }
    }

    public class RequestResponseSignaturesTypeItem
    {
        [JsonProperty("signature_id")]
        public string SignatureId { get; set; }

        [JsonProperty("signer_email_address")]
        public string SignerEmail { get; set; }

        [JsonProperty("signer_name")]
        public string SignerName { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("signed_at")]
        public string SignedDate { get; set; }

        [JsonProperty("last_viewed_at")]
        public string LastViewedDate { get; set; }

        [JsonProperty("last_reminded_at")]
        public string LastRemindedDate { get; set; }
    }

    public enum testModeInput
    {
        Free,
        Paid
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hellosign;

    public partial class WorkflowManagedActions
    {
        public HellosignActions Hellosign(string connectionId) => new HellosignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HellosignTriggers Hellosign(string connectionId) => new HellosignTriggers(connectionId);
    }
}