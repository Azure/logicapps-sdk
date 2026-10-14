//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smtp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SmtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smtp")]
        public IWorkflowAction SendEmail(Expression<Func<string>> emailMessagefrom = null, Expression<Func<string>> emailMessageto = null, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagesubject = null, Expression<Func<string>> emailMessagebody = null, Expression<Func<string>> emailMessagebcc = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null, Expression<Func<string>> emailMessagereadReceipt = null, Expression<Func<string>> emailMessagedeliveryReceipt = null, Expression<Func<AttachmentV2[]>> emailMessageattachments = null)
        {
            var __workflow_emailMessagefrom = emailMessagefrom == null ? null : WorkflowExpression.Compile(emailMessagefrom);
            WorkflowExpression.Validate(__workflow_emailMessagefrom, nameof(emailMessagefrom), required: false);
            var __workflow_emailMessageto = emailMessageto == null ? null : WorkflowExpression.Compile(emailMessageto);
            WorkflowExpression.Validate(__workflow_emailMessageto, nameof(emailMessageto), required: false);
            var __workflow_emailMessagecC = emailMessagecC == null ? null : WorkflowExpression.Compile(emailMessagecC);
            WorkflowExpression.Validate(__workflow_emailMessagecC, nameof(emailMessagecC), required: false);
            var __workflow_emailMessagesubject = emailMessagesubject == null ? null : WorkflowExpression.Compile(emailMessagesubject);
            WorkflowExpression.Validate(__workflow_emailMessagesubject, nameof(emailMessagesubject), required: false);
            var __workflow_emailMessagebody = emailMessagebody == null ? null : WorkflowExpression.Compile(emailMessagebody);
            WorkflowExpression.Validate(__workflow_emailMessagebody, nameof(emailMessagebody), required: false);
            var __workflow_emailMessagebcc = emailMessagebcc == null ? null : WorkflowExpression.Compile(emailMessagebcc);
            WorkflowExpression.Validate(__workflow_emailMessagebcc, nameof(emailMessagebcc), required: false);
            var __workflow_emailMessageimportance = emailMessageimportance == null ? null : WorkflowExpression.Compile(emailMessageimportance);
            WorkflowExpression.Validate(__workflow_emailMessageimportance, nameof(emailMessageimportance), required: false);
            var __workflow_emailMessagereadReceipt = emailMessagereadReceipt == null ? null : WorkflowExpression.Compile(emailMessagereadReceipt);
            WorkflowExpression.Validate(__workflow_emailMessagereadReceipt, nameof(emailMessagereadReceipt), required: false);
            var __workflow_emailMessagedeliveryReceipt = emailMessagedeliveryReceipt == null ? null : WorkflowExpression.Compile(emailMessagedeliveryReceipt);
            WorkflowExpression.Validate(__workflow_emailMessagedeliveryReceipt, nameof(emailMessagedeliveryReceipt), required: false);
            var __workflow_emailMessageattachments = emailMessageattachments == null ? null : WorkflowExpression.Compile(emailMessageattachments);
            WorkflowExpression.Validate(__workflow_emailMessageattachments, nameof(emailMessageattachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SendEmailV3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                if (__workflow_emailMessagefrom != null)
                {
                    emailMessage["From"] = ExpressionConverter.ConvertO(__workflow_emailMessagefrom);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageto != null)
                {
                    emailMessage["To"] = ExpressionConverter.ConvertO(__workflow_emailMessageto);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagecC != null)
                {
                    emailMessage["CC"] = ExpressionConverter.ConvertO(__workflow_emailMessagecC);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagesubject != null)
                {
                    emailMessage["Subject"] = ExpressionConverter.ConvertO(__workflow_emailMessagesubject);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagebody != null)
                {
                    emailMessage["Body"] = ExpressionConverter.ConvertO(__workflow_emailMessagebody);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagebcc != null)
                {
                    emailMessage["Bcc"] = ExpressionConverter.ConvertO(__workflow_emailMessagebcc);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageimportance != null)
                {
                    emailMessage["Importance"] = ExpressionConverter.ConvertO(__workflow_emailMessageimportance);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagereadReceipt != null)
                {
                    emailMessage["ReadReceipt"] = ExpressionConverter.ConvertO(__workflow_emailMessagereadReceipt);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagedeliveryReceipt != null)
                {
                    emailMessage["DeliveryReceipt"] = ExpressionConverter.ConvertO(__workflow_emailMessagedeliveryReceipt);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = ExpressionConverter.ConvertO(__workflow_emailMessageattachments);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
