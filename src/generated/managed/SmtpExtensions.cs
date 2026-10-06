//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smtp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmtpActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smtp")]
        [WorkflowExpressionFactory(nameof(__BuildSendEmail))]
        public IWorkflowAction SendEmail([WorkflowExpression] Func<string> emailMessagefrom = null, [WorkflowExpression] Func<string> emailMessageto = null, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagesubject = null, [WorkflowExpression] Func<string> emailMessagebody = null, [WorkflowExpression] Func<string> emailMessagebcc = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null, [WorkflowExpression] Func<string> emailMessagereadReceipt = null, [WorkflowExpression] Func<string> emailMessagedeliveryReceipt = null, [WorkflowExpression] Func<AttachmentV2[]> emailMessageattachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smtp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEmail(WorkflowExpression<string> emailMessagefrom = null, WorkflowExpression<string> emailMessageto = null, WorkflowExpression<string> emailMessagecC = null, WorkflowExpression<string> emailMessagesubject = null, WorkflowExpression<string> emailMessagebody = null, WorkflowExpression<string> emailMessagebcc = null, WorkflowExpression<emailMessageimportanceInput> emailMessageimportance = null, WorkflowExpression<string> emailMessagereadReceipt = null, WorkflowExpression<string> emailMessagedeliveryReceipt = null, WorkflowExpression<AttachmentV2[]> emailMessageattachments = null)
        {
            WorkflowExpression.Validate(emailMessagefrom, nameof(emailMessagefrom), required: false);
            WorkflowExpression.Validate(emailMessageto, nameof(emailMessageto), required: false);
            WorkflowExpression.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            WorkflowExpression.Validate(emailMessagesubject, nameof(emailMessagesubject), required: false);
            WorkflowExpression.Validate(emailMessagebody, nameof(emailMessagebody), required: false);
            WorkflowExpression.Validate(emailMessagebcc, nameof(emailMessagebcc), required: false);
            WorkflowExpression.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
            WorkflowExpression.Validate(emailMessagereadReceipt, nameof(emailMessagereadReceipt), required: false);
            WorkflowExpression.Validate(emailMessagedeliveryReceipt, nameof(emailMessagedeliveryReceipt), required: false);
            WorkflowExpression.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
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