//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hellosign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HellosignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        public IBodyWorkflowAction<RequestResponse> CreateRequest(Expression<Func<string>> templateId, Expression<Func<testModeInput>> testMode = null, Expression<Func<string>> subject = null, Expression<Func<string>> message = null, Expression<Func<string>> signingRedirectUrl = null, Expression<Func<bool>> allowDecline = null, Expression<Func<object>> signers = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_testMode = WorkflowExpression.Compile(testMode, nameof(testMode), required: false);
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: false);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: false);
            var __workflow_signingRedirectUrl = WorkflowExpression.Compile(signingRedirectUrl, nameof(signingRedirectUrl), required: false);
            var __workflow_allowDecline = WorkflowExpression.Compile(allowDecline, nameof(allowDecline), required: false);
            var __workflow_signers = WorkflowExpression.Compile(signers, nameof(signers), required: false);
            return new DeferredBodyAction<RequestResponse>(() =>
            {
                var apiCallPath = "/v3/signature_request/send_with_template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_testMode != null)
                    callPayload.Queries["test_mode"] = ExpressionConverter.Convert(__workflow_testMode);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(__workflow_subject);
                if (__workflow_message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(__workflow_message);
                if (__workflow_signingRedirectUrl != null)
                    callPayload.Queries["signing_redirect_url"] = ExpressionConverter.Convert(__workflow_signingRedirectUrl);
                if (__workflow_allowDecline != null)
                    callPayload.Queries["allow_decline"] = ExpressionConverter.Convert(__workflow_allowDecline);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_signers);
                return new ApiConnectionAction<RequestResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        public IBodyWorkflowAction<RequestResponse> GetRequest(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<RequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/signature_request/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RequestResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        public IWorkflowAction CancelRequest(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/signature_request/cancel/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class HellosignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RequestResponse[]> OnNewRequest(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/request_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<RequestResponse[]> OnRequestCompleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/complete_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<RequestResponse[]> OnRequestDeclined(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/decline_trigger/v3/signature_request/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RequestResponse[]>(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
