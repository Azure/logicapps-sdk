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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestResponse> __BuildCreateRequest(WorkflowExpression<string> templateId, WorkflowExpression<testModeInput> testMode = null, WorkflowExpression<string> subject = null, WorkflowExpression<string> message = null, WorkflowExpression<string> signingRedirectUrl = null, WorkflowExpression<bool> allowDecline = null, WorkflowExpression<object> signers = null)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(testMode, nameof(testMode), required: false);
            WorkflowExpression.Validate(subject, nameof(subject), required: false);
            WorkflowExpression.Validate(message, nameof(message), required: false);
            WorkflowExpression.Validate(signingRedirectUrl, nameof(signingRedirectUrl), required: false);
            WorkflowExpression.Validate(allowDecline, nameof(allowDecline), required: false);
            WorkflowExpression.Validate(signers, nameof(signers), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestResponse> __BuildGetRequest(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hellosign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelRequest(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
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