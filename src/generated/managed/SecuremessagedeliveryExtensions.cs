//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Securemessagedelivery
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecuremessagedeliveryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IBodyWorkflowAction<SendSecureMessageResponse> SendSecureMessageAsync([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> requestfrom, [WorkflowExpression] Func<string> v, [WorkflowExpression] Func<string> xAPIKey, [WorkflowExpression] Func<string> xAPISecret, [WorkflowExpression] Func<string[]> requestto = null, [WorkflowExpression] Func<string[]> requestcc = null, [WorkflowExpression] Func<string[]> requestbcc = null, [WorkflowExpression] Func<string> requestsubject = null, [WorkflowExpression] Func<Attachment[]> requestattachments = null, [WorkflowExpression] Func<string> requesthtmlBody = null, [WorkflowExpression] Func<string> requesttextBody = null)
        {
            var apiCallPath = String.Format("/v{0}/Email", ExpressionConverter.ConvertWithUrlEncoding(v, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(xAPIKey);
            callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(xAPISecret);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["From"] = ExpressionConverter.ConvertO(requestfrom);
            if (requestto != null)
            {
                request["To"] = ExpressionConverter.ConvertO(requestto);
                requestpropCount++;
            }

            if (requestcc != null)
            {
                request["Cc"] = ExpressionConverter.ConvertO(requestcc);
                requestpropCount++;
            }

            if (requestbcc != null)
            {
                request["Bcc"] = ExpressionConverter.ConvertO(requestbcc);
                requestpropCount++;
            }

            if (requestsubject != null)
            {
                request["Subject"] = ExpressionConverter.ConvertO(requestsubject);
                requestpropCount++;
            }

            if (requestattachments != null)
            {
                request["Attachments"] = ExpressionConverter.ConvertO(requestattachments);
                requestpropCount++;
            }

            if (requesthtmlBody != null)
            {
                request["HtmlBody"] = ExpressionConverter.ConvertO(requesthtmlBody);
                requestpropCount++;
            }

            if (requesttextBody != null)
            {
                request["TextBody"] = ExpressionConverter.ConvertO(requesttextBody);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SendSecureMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IBodyWorkflowAction<TrackMessageResponse> TrackMessageAsync([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> transactionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> v, [WorkflowExpression] Func<string> xAPIKey, [WorkflowExpression] Func<string> xAPISecret)
        {
            var apiCallPath = String.Format("/v{0}/{1}/Track", ExpressionConverter.ConvertWithUrlEncoding(v, 1), ExpressionConverter.ConvertWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Key"] = ExpressionConverter.Convert(xAPIKey);
            callPayload.Headers["X-API-Secret"] = ExpressionConverter.Convert(xAPISecret);
            return new ApiConnectionAction<TrackMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IWorkflowAction RetractMessageAsync([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> transactionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> v, [WorkflowExpression] Func<string> xAPIKey, [WorkflowExpression] Func<string> xAPISecret)
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