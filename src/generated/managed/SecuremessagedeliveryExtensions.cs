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
        public IBodyWorkflowAction<SendSecureMessageResponse> SendSecureMessageAsync([WorkflowExpression] Func<string> requestfrom, [WorkflowExpression] Func<string> v, [WorkflowExpression] Func<string> xAPIKey, [WorkflowExpression] Func<string> xAPISecret, [WorkflowExpression] Func<string[]> requestto = null, [WorkflowExpression] Func<string[]> requestcc = null, [WorkflowExpression] Func<string[]> requestbcc = null, [WorkflowExpression] Func<string> requestsubject = null, [WorkflowExpression] Func<Attachment[]> requestattachments = null, [WorkflowExpression] Func<string> requesthtmlBody = null, [WorkflowExpression] Func<string> requesttextBody = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v{0}/Email", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(v, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = SourceExpressionConverter.ConvertO(xAPIKey);
                callPayload.Headers["X-API-Secret"] = SourceExpressionConverter.ConvertO(xAPISecret);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["From"] = SourceExpressionConverter.ConvertToken(requestfrom);
                if (requestto != null)
                {
                    request["To"] = SourceExpressionConverter.ConvertToken(requestto);
                    requestpropCount++;
                }

                if (requestcc != null)
                {
                    request["Cc"] = SourceExpressionConverter.ConvertToken(requestcc);
                    requestpropCount++;
                }

                if (requestbcc != null)
                {
                    request["Bcc"] = SourceExpressionConverter.ConvertToken(requestbcc);
                    requestpropCount++;
                }

                if (requestsubject != null)
                {
                    request["Subject"] = SourceExpressionConverter.ConvertToken(requestsubject);
                    requestpropCount++;
                }

                if (requestattachments != null)
                {
                    request["Attachments"] = SourceExpressionConverter.ConvertToken(requestattachments);
                    requestpropCount++;
                }

                if (requesthtmlBody != null)
                {
                    request["HtmlBody"] = SourceExpressionConverter.ConvertToken(requesthtmlBody);
                    requestpropCount++;
                }

                if (requesttextBody != null)
                {
                    request["TextBody"] = SourceExpressionConverter.ConvertToken(requesttextBody);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSecureMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IBodyWorkflowAction<TrackMessageResponse> TrackMessageAsync([WorkflowExpression] Func<string> transactionId, [WorkflowExpression] Func<string> v, [WorkflowExpression] Func<string> xAPIKey, [WorkflowExpression] Func<string> xAPISecret)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v{0}/{1}/Track", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(v, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = SourceExpressionConverter.ConvertO(xAPIKey);
                callPayload.Headers["X-API-Secret"] = SourceExpressionConverter.ConvertO(xAPISecret);
                return callPayload;
            }

            return new ApiConnectionAction<TrackMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securemessagedelivery")]
        public IWorkflowAction RetractMessageAsync([WorkflowExpression] Func<string> transactionId, [WorkflowExpression] Func<string> v, [WorkflowExpression] Func<string> xAPIKey, [WorkflowExpression] Func<string> xAPISecret)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v{0}/{1}/Retract", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(v, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Key"] = SourceExpressionConverter.ConvertO(xAPIKey);
                callPayload.Headers["X-API-Secret"] = SourceExpressionConverter.ConvertO(xAPISecret);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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