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
        public IBodyWorkflowAction<SendSecureMessageResponse> SendSecureMessageAsync(Expression<Func<string>> requestfrom, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret, Expression<Func<string[]>> requestto = null, Expression<Func<string[]>> requestcc = null, Expression<Func<string[]>> requestbcc = null, Expression<Func<string>> requestsubject = null, Expression<Func<Attachment[]>> requestattachments = null, Expression<Func<string>> requesthtmlBody = null, Expression<Func<string>> requesttextBody = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v{0}/Email", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(v, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Key"] = CSharpExpressionConverter.ConvertO(xAPIKey);
            callPayload.Headers["X-API-Secret"] = CSharpExpressionConverter.ConvertO(xAPISecret);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["From"] = CSharpExpressionConverter.ConvertToken(requestfrom);
            if (requestto != null)
            {
                request["To"] = CSharpExpressionConverter.ConvertToken(requestto);
                requestpropCount++;
            }

            if (requestcc != null)
            {
                request["Cc"] = CSharpExpressionConverter.ConvertToken(requestcc);
                requestpropCount++;
            }

            if (requestbcc != null)
            {
                request["Bcc"] = CSharpExpressionConverter.ConvertToken(requestbcc);
                requestpropCount++;
            }

            if (requestsubject != null)
            {
                request["Subject"] = CSharpExpressionConverter.ConvertToken(requestsubject);
                requestpropCount++;
            }

            if (requestattachments != null)
            {
                request["Attachments"] = CSharpExpressionConverter.ConvertToken(requestattachments);
                requestpropCount++;
            }

            if (requesthtmlBody != null)
            {
                request["HtmlBody"] = CSharpExpressionConverter.ConvertToken(requesthtmlBody);
                requestpropCount++;
            }

            if (requesttextBody != null)
            {
                request["TextBody"] = CSharpExpressionConverter.ConvertToken(requesttextBody);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v{0}/{1}/Track", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(v, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Key"] = CSharpExpressionConverter.ConvertO(xAPIKey);
            callPayload.Headers["X-API-Secret"] = CSharpExpressionConverter.ConvertO(xAPISecret);
            return new ApiConnectionAction<TrackMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IWorkflowAction RetractMessageAsync(Expression<Func<string>> transactionId, Expression<Func<string>> v, Expression<Func<string>> xAPIKey, Expression<Func<string>> xAPISecret)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v{0}/{1}/Retract", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(v, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Key"] = CSharpExpressionConverter.ConvertO(xAPIKey);
            callPayload.Headers["X-API-Secret"] = CSharpExpressionConverter.ConvertO(xAPISecret);
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