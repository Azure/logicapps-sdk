//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.As2Operations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class As2OperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "as2Operations")]
        public IBodyWorkflowAction<As2EncodeOutput> As2Encode(Expression<Func<object>> messageToEncode, Expression<Func<string>> as2From, Expression<Func<string>> as2To, Expression<Func<string>> contentType = null, Expression<Func<string>> fileName = null, Expression<Func<string>> b2bTrackingId = null)
        {
            var parameters = new JObject();
            parameters["messageToEncode"] = ExpressionConverter.ConvertO(messageToEncode);
            parameters["as2From"] = ExpressionConverter.ConvertO(as2From);
            parameters["as2To"] = ExpressionConverter.ConvertO(as2To);
            if (contentType != null)
            {
                parameters["contentType"] = ExpressionConverter.ConvertO(contentType);
            }

            if (fileName != null)
            {
                parameters["fileName"] = ExpressionConverter.ConvertO(fileName);
            }

            if (b2bTrackingId != null)
            {
                parameters["b2bTrackingId"] = ExpressionConverter.ConvertO(b2bTrackingId);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/as2Operations", operationId: "as2Encode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<As2EncodeOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "as2Operations")]
        public IBodyWorkflowAction<As2DecodeOutput> As2Decode(Expression<Func<object>> messageToDecode, Expression<Func<object>> messageHeaders, Expression<Func<object>> b2bTrackingId = null)
        {
            var parameters = new JObject();
            parameters["messageToDecode"] = ExpressionConverter.ConvertO(messageToDecode);
            parameters["messageHeaders"] = ExpressionConverter.ConvertO(messageHeaders);
            if (b2bTrackingId != null)
            {
                parameters["b2bTrackingId"] = ExpressionConverter.ConvertO(b2bTrackingId);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/as2Operations", operationId: "as2Decode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<As2DecodeOutput>(input);
        }
    }

    public class As2OperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class As2EncodeOutput
    {
        [JsonProperty("messageContent")]
        public JToken MessageContent { get; set; }

        [JsonProperty("messageHeaders")]
        public JToken MessageHeaders { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("agreementName")]
        public string AgreementName { get; set; }

        [JsonProperty("senderPartnerName")]
        public string SenderPartnerName { get; set; }

        [JsonProperty("receiverPartnerName")]
        public string ReceiverPartnerName { get; set; }

        [JsonProperty("micHash")]
        public string MicHash { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("isMessageCompressed")]
        public bool IsMessageCompressed { get; set; }

        [JsonProperty("isMessageEncrypted")]
        public bool IsMessageEncrypted { get; set; }

        [JsonProperty("isMessageSigned")]
        public bool IsMessageSigned { get; set; }

        [JsonProperty("isMdnExpected")]
        public bool IsMdnExpected { get; set; }

        [JsonProperty("mdnType")]
        public string MdnType { get; set; }

        [JsonProperty("receiverUri")]
        public string ReceiverUri { get; set; }

        [JsonProperty("b2bTrackingId")]
        public JToken B2bTrackingId { get; set; }
    }

    public class As2DecodeOutput
    {
        [JsonProperty("messageContent")]
        public JToken MessageContent { get; set; }

        [JsonProperty("messageHeaders")]
        public JToken MessageHeaders { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("agreementName")]
        public string AgreementName { get; set; }

        [JsonProperty("senderPartnerName")]
        public string SenderPartnerName { get; set; }

        [JsonProperty("receiverPartnerName")]
        public string ReceiverPartnerName { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("isMessageCompressed")]
        public bool IsMessageCompressed { get; set; }

        [JsonProperty("isMessageEncrypted")]
        public bool IsMessageEncrypted { get; set; }

        [JsonProperty("isMessageSigned")]
        public bool IsMessageSigned { get; set; }

        [JsonProperty("isDuplicateMessage")]
        public bool IsDuplicateMessage { get; set; }

        [JsonProperty("messageProcessingStatus")]
        public string MessageProcessingStatus { get; set; }

        [JsonProperty("micHash")]
        public string MicHash { get; set; }

        [JsonProperty("messageType")]
        public string MessageType { get; set; }

        [JsonProperty("isMdnExpected")]
        public bool IsMdnExpected { get; set; }

        [JsonProperty("mdnType")]
        public string MdnType { get; set; }

        [JsonProperty("micVerificationStatus")]
        public string MicVerificationStatus { get; set; }

        [JsonProperty("isMdnSigned")]
        public bool IsMdnSigned { get; set; }

        [JsonProperty("originalMessageId")]
        public string OriginalMessageId { get; set; }

        [JsonProperty("originalMessageMicHashFromMdn")]
        public string OriginalMessageMicHashFromMdn { get; set; }

        [JsonProperty("mdnDispositionMode")]
        public string MdnDispositionMode { get; set; }

        [JsonProperty("mdnDispositionType")]
        public string MdnDispositionType { get; set; }

        [JsonProperty("mdnFinalRecipient")]
        public string MdnFinalRecipient { get; set; }

        [JsonProperty("mdnStatusCode")]
        public string MdnStatusCode { get; set; }

        [JsonProperty("outgoingMdnContent")]
        public JToken OutgoingMdnContent { get; set; }

        [JsonProperty("outgoingMdnHeaders")]
        public JToken OutgoingMdnHeaders { get; set; }

        [JsonProperty("errors")]
        public As2DecodeOutputErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("b2bTrackingId")]
        public JToken B2bTrackingId { get; set; }
    }

    public class As2DecodeOutputErrorsTypeItem
    {
        [JsonProperty("error")]
        public As2DecodeOutputErrorsTypeItemErrorType Error { get; set; }
    }

    public class As2DecodeOutputErrorsTypeItemErrorType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.As2Operations;

    public partial class WorkflowServiceProviderActions
    {
        public As2OperationsActions As2Operations(string connectionId) => new As2OperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public As2OperationsTriggers As2Operations(string connectionId) => new As2OperationsTriggers(connectionId);
    }
}