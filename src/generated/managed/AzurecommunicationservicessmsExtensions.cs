//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurecommunicationservicessms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurecommunicationservicessmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurecommunicationservicessms")]
        public IBodyWorkflowAction<SendSMSv2Response, ApiConnectionActionConfiguration> SendSMSv2(Expression<Func<SendSMSv2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSMSv2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/sms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSMSv2Response>(callPayload);
            });
        }
    }

    public class AzurecommunicationservicessmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSMSv2Response
    {
        [JsonProperty("value")]
        public SendSMSv2ResponseValueTypeItem[] Value { get; set; }
    }

    public class SendSMSv2ResponseValueTypeItem
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("httpStatusCode")]
        public int HttpStatusCode { get; set; }

        [JsonProperty("repeatabilityResult")]
        public SendSMSv2ResponseValueTypeItemRepeatabilityResultType RepeatabilityResult { get; set; }

        [JsonProperty("successful")]
        public bool Successful { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendSMSv2ResponseValueTypeItemRepeatabilityResultType
    {
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "rejected")]
        Rejected
    }

    public class SendSMSv2Input
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromPhoneNumber { get; set; }

        [JsonProperty("smsRecipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendSMSv2InputRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("smsSendOptions")]
        public SendSMSv2InputSmsSendOptionsType SmsSendOptions { get; set; }
    }

    public class SendSMSv2InputRecipientsTypeItem
    {
        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }
    }

    public class SendSMSv2InputSmsSendOptionsType
    {
        [JsonProperty("enableDeliveryReport", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeliveryReport { get; set; } = false;

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azurecommunicationservicessms;

    public partial class WorkflowManagedActions
    {
        public AzurecommunicationservicessmsActions Azurecommunicationservicessms(string connectionId) => new AzurecommunicationservicessmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzurecommunicationservicessmsTriggers Azurecommunicationservicessms(string connectionId) => new AzurecommunicationservicessmsTriggers(connectionId);
    }
}