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
        public IBodyWorkflowAction<SendSMSv2Response> SendSMSv2([WorkflowExpression] Func<string> bodyfromPhoneNumber, [WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<bool> bodysmsSendOptionsdeliveryReport = null, [WorkflowExpression] Func<string> bodysmsSendOptionstag = null)
        {
            SourceExpression.Validate(bodyfromPhoneNumber, nameof(bodyfromPhoneNumber), required: true);
            SourceExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodysmsSendOptionsdeliveryReport, nameof(bodysmsSendOptionsdeliveryReport), required: false);
            SourceExpression.Validate(bodysmsSendOptionstag, nameof(bodysmsSendOptionstag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/sms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfromPhoneNumber);
                bodypropCount++;
                body["smsRecipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                var smsSendOptionsObject = new JObject();
                var smsSendOptionsObjectpropCount = 0;
                if (bodysmsSendOptionsdeliveryReport != null)
                {
                    if (bodysmsSendOptionsdeliveryReport != null)
                    {
                        smsSendOptionsObject["enableDeliveryReport"] = SourceExpressionConverter.ConvertToken(bodysmsSendOptionsdeliveryReport);
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
                    smsSendOptionsObject["tag"] = SourceExpressionConverter.ConvertToken(bodysmsSendOptionstag);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendSMSv2Response>(BuildSourceInput);
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