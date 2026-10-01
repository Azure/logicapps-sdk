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
        public IWorkflowAction SendEmail([WorkflowExpression] Func<string> emailMessagefrom = null, [WorkflowExpression] Func<string> emailMessageto = null, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagesubject = null, [WorkflowExpression] Func<string> emailMessagebody = null, [WorkflowExpression] Func<string> emailMessagebcc = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null, [WorkflowExpression] Func<string> emailMessagereadReceipt = null, [WorkflowExpression] Func<string> emailMessagedeliveryReceipt = null, [WorkflowExpression] Func<AttachmentV2[]> emailMessageattachments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SendEmailV3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                if (emailMessagefrom != null)
                {
                    emailMessage["From"] = SourceExpressionConverter.ConvertToken(emailMessagefrom);
                    emailMessagepropCount++;
                }

                if (emailMessageto != null)
                {
                    emailMessage["To"] = SourceExpressionConverter.ConvertToken(emailMessageto);
                    emailMessagepropCount++;
                }

                if (emailMessagecC != null)
                {
                    emailMessage["CC"] = SourceExpressionConverter.ConvertToken(emailMessagecC);
                    emailMessagepropCount++;
                }

                if (emailMessagesubject != null)
                {
                    emailMessage["Subject"] = SourceExpressionConverter.ConvertToken(emailMessagesubject);
                    emailMessagepropCount++;
                }

                if (emailMessagebody != null)
                {
                    emailMessage["Body"] = SourceExpressionConverter.ConvertToken(emailMessagebody);
                    emailMessagepropCount++;
                }

                if (emailMessagebcc != null)
                {
                    emailMessage["Bcc"] = SourceExpressionConverter.ConvertToken(emailMessagebcc);
                    emailMessagepropCount++;
                }

                if (emailMessageimportance != null)
                {
                    emailMessage["Importance"] = SourceExpressionConverter.Convert(emailMessageimportance);
                    emailMessagepropCount++;
                }

                if (emailMessagereadReceipt != null)
                {
                    emailMessage["ReadReceipt"] = SourceExpressionConverter.ConvertToken(emailMessagereadReceipt);
                    emailMessagepropCount++;
                }

                if (emailMessagedeliveryReceipt != null)
                {
                    emailMessage["DeliveryReceipt"] = SourceExpressionConverter.ConvertToken(emailMessagedeliveryReceipt);
                    emailMessagepropCount++;
                }

                if (emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = SourceExpressionConverter.ConvertToken(emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (emailMessagepropCount > 0)
                {
                    callPayload.Body = emailMessage;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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

namespace Microsoft.Azure.Workflows.Sdk
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