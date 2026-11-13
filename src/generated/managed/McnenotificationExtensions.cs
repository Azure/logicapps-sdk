//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mcnenotification
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class McnenotificationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mcnenotification")]
        public IBodyWorkflowAction<SendFromTemplateResponse, ApiConnectionActionConfiguration> SendFromTemplate(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendFromTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/notifications/template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendFromTemplateResponse>(callPayload);
            });
        }
    }

    public class McnenotificationTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendFromTemplateResponse
    {
        [JsonProperty("id")]
        public string NotificationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(string template, BodyInputRecipientType recipient)
        {
            this.Template = template;
            this.Recipient = recipient;
        }

        [JsonProperty("template_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Template { get; set; }

        [JsonProperty("recipient", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRecipientType Recipient { get; set; }

        [JsonProperty("variables")]
        public JToken TemplateVariables { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("notification_id")]
        public string NotificationId { get; set; }
    }

    public class BodyInputRecipientType
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        [JsonProperty("teams")]
        public string TeamsAddress { get; set; }

        [JsonProperty("sms")]
        public string SmsNumber { get; set; }

        [JsonProperty("whatsapp")]
        public string WhatsAppNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mcnenotification;

    public partial class WorkflowManagedActions
    {
        public McnenotificationActions Mcnenotification(string connectionId) => new McnenotificationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public McnenotificationTriggers Mcnenotification(string connectionId) => new McnenotificationTriggers(connectionId);
    }
}