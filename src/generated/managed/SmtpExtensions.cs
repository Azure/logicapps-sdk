//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smtp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smtp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendEmail(Expression<Func<EmailMessageInput>> emailMessage)
        {
            var __workflow_emailMessage = WorkflowExpression.Compile(emailMessage, nameof(emailMessage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SendEmailV3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_emailMessage);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SmtpTriggers([ConnectionName] string connectionId)
    {
    }

    public class EmailMessageInput
    {
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Bcc { get; set; }
        public EmailMessageInputImportanceType? Importance { get; set; }
        public string ReadReceipt { get; set; }
        public string DeliveryReceipt { get; set; }
        public AttachmentV2[] Attachments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmailMessageInputImportanceType
    {
        Normal,
        Low,
        High
    }

    public class AttachmentV2
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ContentData { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
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