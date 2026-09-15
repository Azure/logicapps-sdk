//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.As2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class As2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "as2")]
        public IBodyWorkflowAction<MicUpdateResponse[]> AddOrUpdateMicValues(Expression<Func<As2ReplicableMicContent[]>> micContent = null)
        {
            var apiCallPath = "/createOrUpdateMicValues";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(micContent);
            return new ApiConnectionAction<MicUpdateResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "as2")]
        public IBodyWorkflowAction<As2AgreementProperties> ResolveAgreement(Expression<Func<string>> as2From, Expression<Func<string>> as2To)
        {
            var apiCallPath = "/resolveAgreement";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["as2From"] = CSharpExpressionConverter.ConvertO(as2From);
            callPayload.Queries["as2To"] = CSharpExpressionConverter.ConvertO(as2To);
            return new ApiConnectionAction<As2AgreementProperties>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "as2")]
        public IBodyWorkflowAction<As2DecodeResponse> Decode(Expression<Func<string>> body = null)
        {
            var apiCallPath = "/decode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<As2DecodeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "as2")]
        public IBodyWorkflowAction<As2EncodeResponse> Encode(Expression<Func<string>> as2From, Expression<Func<string>> as2To, Expression<Func<string>> fileName = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = "/encode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["as2From"] = CSharpExpressionConverter.ConvertO(as2From);
            callPayload.Queries["as2To"] = CSharpExpressionConverter.ConvertO(as2To);
            if (fileName != null)
                callPayload.Queries["fileName"] = CSharpExpressionConverter.ConvertO(fileName);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<As2EncodeResponse>(callPayload);
        }
    }

    public class As2Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<As2ReplicableMicContent[]> OnCreatedMicValues(Expression<Func<string>> startSyncTime = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/triggers/onCreatedMicValues";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startSyncTime != null)
                callPayload.Queries["startSyncTime"] = CSharpExpressionConverter.ConvertO(startSyncTime);
            return new ApiConnectionTrigger<As2ReplicableMicContent[]>(callPayload, triggerName, recurrence);
        }
    }

    public class MicUpdateResponse
    {
        [JsonProperty("MicUpdateStatus")]
        public MicUpdateResponseStatusOfTheCreateOrUpdateMICActionType StatusOfTheCreateOrUpdateMICAction { get; set; }
        public MicContent ExistingMicContent { get; set; }
        public EipErrorResponseBody ErrorDetails { get; set; }
    }

    public enum MicUpdateResponseStatusOfTheCreateOrUpdateMICActionType
    {
        MicEntryCreated,
        MicEntryUpdated,
        MicContentNotChanged,
        MicUpdateFailed
    }

    public class MicContent
    {
        public string AgreementName { get; set; }
        public string MicValue { get; set; }
        public string MicHashAlgorithm { get; set; }
        public string ChangedTime { get; set; }
        public string MessageId { get; set; }
        public string As2From { get; set; }
        public string As2To { get; set; }
    }

    public class EipErrorResponseBody
    {
        public EipErrorResponseBodyStatusCodeType StatusCode { get; set; }
        public string ErrorMessage { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }
    }

    public enum EipErrorResponseBodyStatusCodeType
    {
        Continue,
        SwitchingProtocols,
        OK,
        Created,
        Accepted,
        NonAuthoritativeInformation,
        NoContent,
        ResetContent,
        PartialContent,
        MultipleChoices,
        Ambiguous,
        MovedPermanently,
        Moved,
        Found,
        Redirect,
        SeeOther,
        RedirectMethod,
        NotModified,
        UseProxy,
        Unused,
        TemporaryRedirect,
        RedirectKeepVerb,
        BadRequest,
        Unauthorized,
        PaymentRequired,
        Forbidden,
        NotFound,
        MethodNotAllowed,
        NotAcceptable,
        ProxyAuthenticationRequired,
        RequestTimeout,
        Conflict,
        Gone,
        LengthRequired,
        PreconditionFailed,
        RequestEntityTooLarge,
        RequestUriTooLong,
        UnsupportedMediaType,
        RequestedRangeNotSatisfiable,
        ExpectationFailed,
        UpgradeRequired,
        InternalServerError,
        NotImplemented,
        BadGateway,
        ServiceUnavailable,
        GatewayTimeout,
        HttpVersionNotSupported
    }

    public class As2ReplicableMicContent
    {
        public string AgreementName { get; set; }
        public string MicValue { get; set; }
        public string MicHashAlgorithm { get; set; }
        public string MicChangedTime { get; set; }
        public string MessageId { get; set; }
        public string As2From { get; set; }
        public string As2To { get; set; }
    }

    public class As2AgreementProperties
    {
        public string AgreementName { get; set; }
        public string GuestPartnerName { get; set; }
        public string HostPartnerName { get; set; }
        public string As2To { get; set; }
        public string As2From { get; set; }
    }

    public class As2DecodeResponse
    {
        public As2DecodedMessage AS2Message { get; set; }
        public As2OutgoingMdn OutgoingMdn { get; set; }
    }

    public class As2DecodedMessage
    {
        public string Content { get; set; }
        public string AS2From { get; set; }
        public string AS2To { get; set; }
        public string AgreementName { get; set; }
        public bool IsMdn { get; set; }
        public bool IsFailedMessage { get; set; }
        public string DispositionType { get; set; }
        public bool IsAS2MessageSigned { get; set; }
        public bool IsAS2MessageCompressed { get; set; }
        public bool IsAS2MessageEncrypted { get; set; }
        public bool IsAS2MessageDuplicate { get; set; }
        public string AS2MessageId { get; set; }
        public string InboundHttpHeaders { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public As2DecodedMessageMicVerificationType MicVerification { get; set; }
        public bool IsNrrEnabled { get; set; }
        public As2DecodedMessageMdnStatusCodeType MdnStatusCode { get; set; }
        public As2DecodedMessageMdnExpectedType MdnExpected { get; set; }
        public string ReceiverPartnerName { get; set; }
        public string SenderPartnerName { get; set; }
        public string OriginalMessageId { get; set; }
    }

    public enum As2DecodedMessageMicVerificationType
    {
        NotApplicable,
        Succeeded,
        Failed
    }

    public enum As2DecodedMessageMdnStatusCodeType
    {
        NotApplicable,
        Accepted,
        Rejected,
        AcceptedWithErrors
    }

    public enum As2DecodedMessageMdnExpectedType
    {
        NotApplicable,
        Expected,
        NotExpected
    }

    public class As2OutgoingMdn
    {
        public string Content { get; set; }
        public JToken OutboundHeaders { get; set; }
        public As2OutgoingMdnMdnTypeType MdnType { get; set; }
        public string ReceiptDeliveryOption { get; set; }
        public As2OutgoingMdnMicVerificationType MicVerification { get; set; }
        public bool IsNrrEnabled { get; set; }
        public As2OutgoingMdnMdnStatusCodeType MdnStatusCode { get; set; }
        public string OriginalMessageId { get; set; }
        public string Error { get; set; }
    }

    public enum As2OutgoingMdnMdnTypeType
    {
        NotConfigured,
        Sync,
        Async
    }

    public enum As2OutgoingMdnMicVerificationType
    {
        NotApplicable,
        Succeeded,
        Failed
    }

    public enum As2OutgoingMdnMdnStatusCodeType
    {
        NotApplicable,
        Accepted,
        Rejected,
        AcceptedWithErrors
    }

    public class As2EncodeResponse
    {
        public As2EncodedMessage AS2Message { get; set; }
    }

    public class As2EncodedMessage
    {
        public string Content { get; set; }
        public string AS2From { get; set; }
        public string AS2To { get; set; }
        public string AgreementName { get; set; }
        public string AS2MessageId { get; set; }
        public string ReceiverPartnerName { get; set; }
        public string SenderPartnerName { get; set; }
        public string Error { get; set; }
        public As2EncodedMessageMdnExpectedType MdnExpected { get; set; }
        public As2EncodedMessageMdnTypeExpectedType MdnTypeExpected { get; set; }
        public bool IsNrrEnabled { get; set; }
        public JToken OutboundHeaders { get; set; }
    }

    public enum As2EncodedMessageMdnExpectedType
    {
        NotApplicable,
        Expected,
        NotExpected
    }

    public enum As2EncodedMessageMdnTypeExpectedType
    {
        NotConfigured,
        Sync,
        Async
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.As2;

    public partial class WorkflowManagedActions
    {
        public As2Actions As2(string connectionId) => new As2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public As2Triggers As2(string connectionId) => new As2Triggers(connectionId);
    }
}