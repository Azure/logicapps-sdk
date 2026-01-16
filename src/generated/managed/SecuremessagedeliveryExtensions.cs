//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Securemessagedelivery
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecuremessagedeliveryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IBodyWorkflowAction<SendSecureMessageResponse> SendSecureMessageAsync(Expression<Func<string>> requestFrom, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret, Expression<Func<string[]>> requestTo = null, Expression<Func<string[]>> requestCc = null, Expression<Func<string[]>> requestBcc = null, Expression<Func<string>> requestSubject = null, Expression<Func<Attachment[]>> requestAttachments = null, Expression<Func<string>> requestHtmlBody = null, Expression<Func<string>> requestTextBody = null)
        {
            var apiCallPath = String.Format("/v{0}/Email", ExpressionConverter.ConvertWithUrlEncoding(v, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(xAPIKey);
            callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(xAPISecret);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["From"] = ExpressionConverter.ConvertO(requestFrom);
            if (requestTo != null)
            {
                request["To"] = ExpressionConverter.ConvertO(requestTo);
                requestpropCount++;
            }

            if (requestCc != null)
            {
                request["Cc"] = ExpressionConverter.ConvertO(requestCc);
                requestpropCount++;
            }

            if (requestBcc != null)
            {
                request["Bcc"] = ExpressionConverter.ConvertO(requestBcc);
                requestpropCount++;
            }

            if (requestSubject != null)
            {
                request["Subject"] = ExpressionConverter.ConvertO(requestSubject);
                requestpropCount++;
            }

            if (requestAttachments != null)
            {
                request["Attachments"] = ExpressionConverter.ConvertO(requestAttachments);
                requestpropCount++;
            }

            if (requestHtmlBody != null)
            {
                request["HtmlBody"] = ExpressionConverter.ConvertO(requestHtmlBody);
                requestpropCount++;
            }

            if (requestTextBody != null)
            {
                request["TextBody"] = ExpressionConverter.ConvertO(requestTextBody);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SendSecureMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IBodyWorkflowAction<TrackMessageResponse> TrackMessageAsync(Expression<Func<string>> transactionId, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret)
        {
            var apiCallPath = String.Format("/v{0}/{1}/Track", ExpressionConverter.ConvertWithUrlEncoding(v, 1), ExpressionConverter.ConvertWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(xAPIKey);
            callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(xAPISecret);
            return new ApiConnectionAction<TrackMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IWorkflowAction RetractMessageAsync(Expression<Func<string>> transactionId, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret)
        {
            var apiCallPath = String.Format("/v{0}/{1}/Retract", ExpressionConverter.ConvertWithUrlEncoding(v, 1), ExpressionConverter.ConvertWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(xAPIKey);
            callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(xAPISecret);
            return new ApiConnectionAction(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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