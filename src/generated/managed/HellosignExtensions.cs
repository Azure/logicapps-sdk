//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hellosign
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HellosignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRequest))]
        public IBodyWorkflowAction<RequestResponse> CreateRequest([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<testModeInput> testMode = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<string> message = null, [WorkflowExpression] Func<string> signingRedirectUrl = null, [WorkflowExpression] Func<bool> allowDecline = null, [WorkflowExpression] Func<object> signers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestResponse> __BuildCreateRequest(WorkflowValue<string> templateId, WorkflowValue<testModeInput> testMode = null, WorkflowValue<string> subject = null, WorkflowValue<string> message = null, WorkflowValue<string> signingRedirectUrl = null, WorkflowValue<bool> allowDecline = null, WorkflowValue<object> signers = null)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(testMode, nameof(testMode), required: false);
            WorkflowValue.Validate(subject, nameof(subject), required: false);
            WorkflowValue.Validate(message, nameof(message), required: false);
            WorkflowValue.Validate(signingRedirectUrl, nameof(signingRedirectUrl), required: false);
            WorkflowValue.Validate(allowDecline, nameof(allowDecline), required: false);
            WorkflowValue.Validate(signers, nameof(signers), required: false);
            return new DeferredBodyAction<RequestResponse>(() =>
            {
                var apiCallPath = "/v3/signature_request/send_with_template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (testMode != null)
                    callPayload.Queries["test_mode"] = ExpressionConverter.Convert(testMode);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                if (subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(subject);
                if (message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(message);
                if (signingRedirectUrl != null)
                    callPayload.Queries["signing_redirect_url"] = ExpressionConverter.Convert(signingRedirectUrl);
                if (allowDecline != null)
                    callPayload.Queries["allow_decline"] = ExpressionConverter.Convert(allowDecline);
                callPayload.Body = ExpressionConverter.ConvertO(signers);
                return new ApiConnectionAction<RequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        [WorkflowExpressionFactory(nameof(__BuildGetRequest))]
        public IBodyWorkflowAction<RequestResponse> GetRequest([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestResponse> __BuildGetRequest(WorkflowValue<string> requestId)
        {
            WorkflowValue.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<RequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/signature_request/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        [WorkflowExpressionFactory(nameof(__BuildCancelRequest))]
        public IWorkflowAction CancelRequest([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelRequest(WorkflowValue<string> requestId)
        {
            WorkflowValue.Validate(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/signature_request/cancel/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HellosignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RequestResponse[]> OnNewRequest(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/request_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RequestResponse[]> OnRequestCompleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/complete_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RequestResponse[]> OnRequestDeclined(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/decline_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload, triggerName, recurrence);
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
