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
        public IBodyWorkflowAction<SendSecureMessageResponse, ApiConnectionActionConfiguration> SendSecureMessageAsync(Expression<Func<SendSecureMessageAsyncInput>> request, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            var __workflow_v = WorkflowExpression.Compile(v, nameof(v), required: true);
            var __workflow_xAPIKey = WorkflowExpression.Compile(xAPIKey, nameof(xAPIKey), required: true);
            var __workflow_xAPISecret = WorkflowExpression.Compile(xAPISecret, nameof(xAPISecret), required: true);
            return new DeferredBodyAction<SendSecureMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v{0}/Email", __workflow_v.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(__workflow_xAPIKey);
                callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(__workflow_xAPISecret);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<SendSecureMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IBodyWorkflowAction<TrackMessageResponse, ApiConnectionActionConfiguration> TrackMessageAsync(Expression<Func<string>> transactionId, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            var __workflow_v = WorkflowExpression.Compile(v, nameof(v), required: true);
            var __workflow_xAPIKey = WorkflowExpression.Compile(xAPIKey, nameof(xAPIKey), required: true);
            var __workflow_xAPISecret = WorkflowExpression.Compile(xAPISecret, nameof(xAPISecret), required: true);
            return new DeferredBodyAction<TrackMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v{0}/{1}/Track", __workflow_v.WithUrlEncoding(1), __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(__workflow_xAPIKey);
                callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(__workflow_xAPISecret);
                return new ApiConnectionAction<TrackMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetractMessageAsync(Expression<Func<string>> transactionId, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            var __workflow_v = WorkflowExpression.Compile(v, nameof(v), required: true);
            var __workflow_xAPIKey = WorkflowExpression.Compile(xAPIKey, nameof(xAPIKey), required: true);
            var __workflow_xAPISecret = WorkflowExpression.Compile(xAPISecret, nameof(xAPISecret), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v{0}/{1}/Retract", __workflow_v.WithUrlEncoding(1), __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(__workflow_xAPIKey);
                callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(__workflow_xAPISecret);
                return new ApiConnectionAction(callPayload);
            });
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

    public class SendSecureMessageAsyncInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }
        public string[] To { get; set; }
        public string[] Cc { get; set; }
        public string[] Bcc { get; set; }
        public string Subject { get; set; }
        public Attachment[] Attachments { get; set; }
        public string HtmlBody { get; set; }
        public string TextBody { get; set; }
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