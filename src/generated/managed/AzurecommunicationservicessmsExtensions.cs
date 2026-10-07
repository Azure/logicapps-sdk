//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurecommunicationservicessms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurecommunicationservicessmsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurecommunicationservicessms")]
        [WorkflowExpressionFactory(nameof(__BuildSendSMSv2))]
        public IBodyWorkflowAction<SendSMSv2Response> SendSMSv2([WorkflowExpression] Func<string> bodyfromPhoneNumber, [WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<bool> bodysmsSendOptionsdeliveryReport = null, [WorkflowExpression] Func<string> bodysmsSendOptionstag = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurecommunicationservicessms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSMSv2Response> __BuildSendSMSv2(WorkflowExpression<string> bodyfromPhoneNumber, WorkflowExpression<bodyrecipientsInputItem[]> bodyrecipients, WorkflowExpression<string> bodymessage, WorkflowExpression<bool> bodysmsSendOptionsdeliveryReport = null, WorkflowExpression<string> bodysmsSendOptionstag = null)
        {
            WorkflowExpression.Validate(bodyfromPhoneNumber, nameof(bodyfromPhoneNumber), required: true);
            WorkflowExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodysmsSendOptionsdeliveryReport, nameof(bodysmsSendOptionsdeliveryReport), required: false);
            WorkflowExpression.Validate(bodysmsSendOptionstag, nameof(bodysmsSendOptionstag), required: false);
            return new DeferredBodyAction<SendSMSv2Response>(() =>
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
                    if (bodysmsSendOptionsdeliveryReport != null)
                    {
                        smsSendOptionsObject["enableDeliveryReport"] = ExpressionConverter.ConvertO(bodysmsSendOptionsdeliveryReport);
                        smsSendOptionsObjectpropCount++;
                    }

                    smsSendOptionsObjectpropCount++;
                }
                else
                {
                    smsSendOptionsObject["enableDeliveryReport"] = false;
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