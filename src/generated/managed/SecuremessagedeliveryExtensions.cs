//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Securemessagedelivery
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecuremessagedeliveryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IBodyWorkflowAction<SendSecureMessageResponse> SendSecureMessageAsync(Expression<Func<string>> requestfrom, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret, Expression<Func<string[]>> requestto = null, Expression<Func<string[]>> requestcc = null, Expression<Func<string[]>> requestbcc = null, Expression<Func<string>> requestsubject = null, Expression<Func<Attachment[]>> requestattachments = null, Expression<Func<string>> requesthtmlBody = null, Expression<Func<string>> requesttextBody = null)
        {
            var __workflow_requestfrom = WorkflowExpression.Compile(requestfrom, nameof(requestfrom), required: true);
            var __workflow_v = WorkflowExpression.Compile(v, nameof(v), required: true);
            var __workflow_xAPIKey = WorkflowExpression.Compile(xAPIKey, nameof(xAPIKey), required: true);
            var __workflow_xAPISecret = WorkflowExpression.Compile(xAPISecret, nameof(xAPISecret), required: true);
            var __workflow_requestto = WorkflowExpression.Compile(requestto, nameof(requestto), required: false);
            var __workflow_requestcc = WorkflowExpression.Compile(requestcc, nameof(requestcc), required: false);
            var __workflow_requestbcc = WorkflowExpression.Compile(requestbcc, nameof(requestbcc), required: false);
            var __workflow_requestsubject = WorkflowExpression.Compile(requestsubject, nameof(requestsubject), required: false);
            var __workflow_requestattachments = WorkflowExpression.Compile(requestattachments, nameof(requestattachments), required: false);
            var __workflow_requesthtmlBody = WorkflowExpression.Compile(requesthtmlBody, nameof(requesthtmlBody), required: false);
            var __workflow_requesttextBody = WorkflowExpression.Compile(requesttextBody, nameof(requesttextBody), required: false);
            return new DeferredBodyAction<SendSecureMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v{0}/Email", __workflow_v.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(__workflow_xAPIKey);
                callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(__workflow_xAPISecret);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["From"] = ExpressionConverter.ConvertO(__workflow_requestfrom);
                if (__workflow_requestto != null)
                {
                    request["To"] = ExpressionConverter.ConvertO(__workflow_requestto);
                    requestpropCount++;
                }

                if (__workflow_requestcc != null)
                {
                    request["Cc"] = ExpressionConverter.ConvertO(__workflow_requestcc);
                    requestpropCount++;
                }

                if (__workflow_requestbcc != null)
                {
                    request["Bcc"] = ExpressionConverter.ConvertO(__workflow_requestbcc);
                    requestpropCount++;
                }

                if (__workflow_requestsubject != null)
                {
                    request["Subject"] = ExpressionConverter.ConvertO(__workflow_requestsubject);
                    requestpropCount++;
                }

                if (__workflow_requestattachments != null)
                {
                    request["Attachments"] = ExpressionConverter.ConvertO(__workflow_requestattachments);
                    requestpropCount++;
                }

                if (__workflow_requesthtmlBody != null)
                {
                    request["HtmlBody"] = ExpressionConverter.ConvertO(__workflow_requesthtmlBody);
                    requestpropCount++;
                }

                if (__workflow_requesttextBody != null)
                {
                    request["TextBody"] = ExpressionConverter.ConvertO(__workflow_requesttextBody);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<SendSecureMessageResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IBodyWorkflowAction<TrackMessageResponse> TrackMessageAsync(Expression<Func<string>> transactionId, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            var __workflow_v = WorkflowExpression.Compile(v, nameof(v), required: true);
            var __workflow_xAPIKey = WorkflowExpression.Compile(xAPIKey, nameof(xAPIKey), required: true);
            var __workflow_xAPISecret = WorkflowExpression.Compile(xAPISecret, nameof(xAPISecret), required: true);
            return new DeferredBodyAction<TrackMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v{0}/{1}/Track", __workflow_v.WithUrlEncoding(1), __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(__workflow_xAPIKey);
                callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(__workflow_xAPISecret);
                return new ApiConnectionAction<TrackMessageResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IWorkflowAction RetractMessageAsync(Expression<Func<string>> transactionId, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            var __workflow_v = WorkflowExpression.Compile(v, nameof(v), required: true);
            var __workflow_xAPIKey = WorkflowExpression.Compile(xAPIKey, nameof(xAPIKey), required: true);
            var __workflow_xAPISecret = WorkflowExpression.Compile(xAPISecret, nameof(xAPISecret), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v{0}/{1}/Retract", __workflow_v.WithUrlEncoding(1), __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(__workflow_xAPIKey);
                callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(__workflow_xAPISecret);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class SecuremessagedeliveryTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSecureMessageResponse
    {
        public string TransactionId { get; set; }
        public int NumberOfRecipients { get; set; }
        public int MessageSize { get; set; }
        public string Expiration { get; set; }
        public string ProjectId { get; set; }
        public string ApplicationId { get; set; }
    }

    public class Attachment
    {
        public string AttachmentBase64 { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string ContentId { get; set; }
    }

    public class TrackMessageResponse
    {
        public double Cost { get; set; }
        public AttachmentMetaData[] Attachments { get; set; }
        public string ExpirationDate { get; set; }
        public int MessageId { get; set; }
        public int MessageSize { get; set; }
        public JToken SecurityEnvelope { get; set; }
        public Tracking[] Tracking { get; set; }
        public string Subject { get; set; }
    }

    public class AttachmentMetaData
    {
        public int AttachmentId { get; set; }
        public string FileName { get; set; }
        public JToken ContentId { get; set; }
        public string ContentType { get; set; }
        public JToken SecurityEnvelope { get; set; }
        public Size Size { get; set; }
        public AttachmentTracking Tracking { get; set; }
    }

    public class Size
    {
        public string StdString { get; set; }
    }

    public class AttachmentTracking
    {
        public Recipient[] Recipients { get; set; }
        public string DateOpened { get; set; }
        public string Email { get; set; }
        public string MessageStatusDescription { get; set; }
        public int MessageStatusId { get; set; }
        public string ReceiverField { get; set; }
    }

    public class Recipient
    {
        public int ChecksumValidated { get; set; }
        public bool Delivered { get; set; }
        public string DeliveredDate { get; set; }
        public bool Downloaded { get; set; }
        public string DownloadedDate { get; set; }
        public string Email { get; set; }
    }

    public class Tracking
    {
        public string DateOpened { get; set; }
        public string Email { get; set; }
        public string MessageStatusDescription { get; set; }
        public int MessageStatusId { get; set; }
        public string ReceiverField { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Securemessagedelivery;

    public partial class WorkflowManagedActions
    {
        public SecuremessagedeliveryActions Securemessagedelivery(string connectionId) => new SecuremessagedeliveryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SecuremessagedeliveryTriggers Securemessagedelivery(string connectionId) => new SecuremessagedeliveryTriggers(connectionId);
    }
}
