//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurecommunicationservicessms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurecommunicationservicessmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurecommunicationservicessms")]
        public IBodyWorkflowAction<SendSMSv2Response> SendSMSv2(Expression<Func<string>> bodyfromPhoneNumber, Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients, Expression<Func<string>> bodymessage, Expression<Func<bool>> bodysmsSendOptionsdeliveryReport = null, Expression<Func<string>> bodysmsSendOptionstag = null)
        {
            var apiCallPath = "/v2/sms";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodyfromPhoneNumber);
            bodypropCount++;
            body["smsRecipients"] = ExpressionConverter.ConvertO(bodyrecipients);
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            var smsSendOptionsObject = new JObject();
            var smsSendOptionsObjectpropCount = 0;
            if (bodysmsSendOptionsdeliveryReport != null)
            {
                smsSendOptionsObject["enableDeliveryReport"] = ExpressionConverter.ConvertO(bodysmsSendOptionsdeliveryReport);
                smsSendOptionsObjectpropCount++;
            }

            if (bodysmsSendOptionstag != null)
            {
                smsSendOptionsObject["tag"] = ExpressionConverter.ConvertO(bodysmsSendOptionstag);
                smsSendOptionsObjectpropCount++;
            }

            if (smsSendOptionsObjectpropCount > 0)
            {
                body["smsSendOptions"] = smsSendOptionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendSMSv2Response>(callPayload);
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

    public enum SendSMSv2ResponseValueTypeItemRepeatabilityResultType
    {
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "rejected")]
        Rejected
    }

    public class bodyrecipientsInputItem
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("repeatabilityRequestId")]
        public string RequestId { get; set; }

        [JsonProperty("repeatabilityFirstSent")]
        public string FirstSent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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