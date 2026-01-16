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
        public IBodyWorkflowAction<RequestResponse> CreateRequest(Expression<Func<string>> templateId, Expression<Func<testModeInput>> testMode = null, Expression<Func<string>> subject = null, Expression<Func<string>> message = null, Expression<Func<string>> signingRedirectUrl = null, Expression<Func<bool>> allowDecline = null, Expression<Func<object>> signers = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        public IBodyWorkflowAction<RequestResponse> GetRequest(Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/v3/signature_request/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        public IWorkflowAction CancelRequest(Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/v3/signature_request/cancel/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class HellosignTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<RequestResponse[]> OnNewRequest()
        {
            var apiCallPath = "/request_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload);
        }

        public IOutputWorkflowTrigger<RequestResponse[]> OnRequestCompleted()
        {
            var apiCallPath = "/complete_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload);
        }

        public IOutputWorkflowTrigger<RequestResponse[]> OnRequestDeclined()
        {
            var apiCallPath = "/decline_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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