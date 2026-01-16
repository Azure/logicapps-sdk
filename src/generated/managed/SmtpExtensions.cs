//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smtp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smtp")]
        public IWorkflowAction SendEmailV3(Expression<Func<string>> emailMessagefrom = null, Expression<Func<string>> emailMessageto = null, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagesubject = null, Expression<Func<string>> emailMessagebody = null, Expression<Func<string>> emailMessagebcc = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null, Expression<Func<string>> emailMessagereadReceipt = null, Expression<Func<string>> emailMessagedeliveryReceipt = null, Expression<Func<AttachmentV2[]>> emailMessageattachments = null)
        {
            var apiCallPath = "/SendEmailV3";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var emailMessage = new JObject();
            var emailMessagepropCount = 0;
            if (emailMessagefrom != null)
            {
                emailMessage["From"] = ExpressionConverter.ConvertO(emailMessagefrom);
                emailMessagepropCount++;
            }

            if (emailMessageto != null)
            {
                emailMessage["To"] = ExpressionConverter.ConvertO(emailMessageto);
                emailMessagepropCount++;
            }

            if (emailMessagecC != null)
            {
                emailMessage["CC"] = ExpressionConverter.ConvertO(emailMessagecC);
                emailMessagepropCount++;
            }

            if (emailMessagesubject != null)
            {
                emailMessage["Subject"] = ExpressionConverter.ConvertO(emailMessagesubject);
                emailMessagepropCount++;
            }

            if (emailMessagebody != null)
            {
                emailMessage["Body"] = ExpressionConverter.ConvertO(emailMessagebody);
                emailMessagepropCount++;
            }

            if (emailMessagebcc != null)
            {
                emailMessage["Bcc"] = ExpressionConverter.ConvertO(emailMessagebcc);
                emailMessagepropCount++;
            }

            if (emailMessageimportance != null)
            {
                emailMessage["Importance"] = ExpressionConverter.ConvertO(emailMessageimportance);
                emailMessagepropCount++;
            }

            if (emailMessagereadReceipt != null)
            {
                emailMessage["ReadReceipt"] = ExpressionConverter.ConvertO(emailMessagereadReceipt);
                emailMessagepropCount++;
            }

            if (emailMessagedeliveryReceipt != null)
            {
                emailMessage["DeliveryReceipt"] = ExpressionConverter.ConvertO(emailMessagedeliveryReceipt);
                emailMessagepropCount++;
            }

            if (emailMessageattachments != null)
            {
                emailMessage["Attachments"] = ExpressionConverter.ConvertO(emailMessageattachments);
                emailMessagepropCount++;
            }

            if (emailMessagepropCount > 0)
            {
                callPayload.Body = emailMessage;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class SmtpTriggers([ConnectionName] string connectionId)
    {
    }

    public enum emailMessageimportanceInput
    {
        Normal,
        Low,
        High
    }

    public class AttachmentV2
    {
        public string ContentData { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string ContentId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smtp;

    public partial class WorkflowManagedActions
    {
        public SmtpActions Smtp(string connectionId) => new SmtpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmtpTriggers Smtp(string connectionId) => new SmtpTriggers(connectionId);
    }
}