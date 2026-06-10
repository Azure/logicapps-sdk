//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.EdifactOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EdifactOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "edifactOperations")]
        public IBodyWorkflowAction<EdifactDecodeOutput> EdifactDecode(Expression<Func<object>> messageToDecode, Expression<Func<int>> componentSeparator = null, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> escapeCharacter = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<EdifactDecodeSegmentTerminatorSuffixType>> segmentTerminatorSuffix = null, Expression<Func<EdifactDecodeDecimalPointIndicatorType>> decimalPointIndicator = null, Expression<Func<EdifactDecodePayloadCharacterSetType>> payloadCharacterSet = null, Expression<Func<object>> b2bTrackingId = null, Expression<Func<string>> fallbackAgreementName = null)
        {
            var parameters = new JObject();
            parameters["messageToDecode"] = ExpressionConverter.ConvertO(messageToDecode);
            if (componentSeparator != null)
            {
                parameters["componentSeparator"] = ExpressionConverter.ConvertO(componentSeparator);
            }

            if (dataElementSeparator != null)
            {
                parameters["dataElementSeparator"] = ExpressionConverter.ConvertO(dataElementSeparator);
            }

            if (escapeCharacter != null)
            {
                parameters["escapeCharacter"] = ExpressionConverter.ConvertO(escapeCharacter);
            }

            if (repetitionSeparator != null)
            {
                parameters["repetitionSeparator"] = ExpressionConverter.ConvertO(repetitionSeparator);
            }

            if (segmentTerminator != null)
            {
                parameters["segmentTerminator"] = ExpressionConverter.ConvertO(segmentTerminator);
            }

            if (segmentTerminatorSuffix != null)
            {
                parameters["segmentTerminatorSuffix"] = ExpressionConverter.ConvertO(segmentTerminatorSuffix);
            }

            if (decimalPointIndicator != null)
            {
                parameters["decimalPointIndicator"] = ExpressionConverter.ConvertO(decimalPointIndicator);
            }

            if (payloadCharacterSet != null)
            {
                parameters["payloadCharacterSet"] = ExpressionConverter.ConvertO(payloadCharacterSet);
            }

            if (b2bTrackingId != null)
            {
                parameters["b2bTrackingId"] = ExpressionConverter.ConvertO(b2bTrackingId);
            }

            if (fallbackAgreementName != null)
            {
                parameters["fallbackAgreementName"] = ExpressionConverter.ConvertO(fallbackAgreementName);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/edifactOperations", operationId: "EdifactDecode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<EdifactDecodeOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "edifactOperations")]
        public IBodyWorkflowAction<EdifactEncodeOutput> EdifactEncode(Expression<Func<object>> messageToEncode, Expression<Func<EdifactEncodeSenderIdentityType>> senderIdentity = null, Expression<Func<EdifactEncodeReceiverIdentityType>> receiverIdentity = null, Expression<Func<string>> agreementName = null, Expression<Func<object>> b2bTrackingId = null)
        {
            var parameters = new JObject();
            parameters["messageToEncode"] = ExpressionConverter.ConvertO(messageToEncode);
            if (senderIdentity != null)
            {
                parameters["senderIdentity"] = ExpressionConverter.ConvertO(senderIdentity);
            }

            if (receiverIdentity != null)
            {
                parameters["receiverIdentity"] = ExpressionConverter.ConvertO(receiverIdentity);
            }

            if (agreementName != null)
            {
                parameters["agreementName"] = ExpressionConverter.ConvertO(agreementName);
            }

            if (b2bTrackingId != null)
            {
                parameters["b2bTrackingId"] = ExpressionConverter.ConvertO(b2bTrackingId);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/edifactOperations", operationId: "edifactEncode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<EdifactEncodeOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "edifactOperations")]
        public IBodyWorkflowAction<EdifactBatchEncodeOutput> EdifactBatchEncode(Expression<Func<EdifactBatchEncodeBatchMessageType>> batchMessage, Expression<Func<EdifactBatchEncodeSenderIdentityType>> senderIdentity = null, Expression<Func<EdifactBatchEncodeReceiverIdentityType>> receiverIdentity = null, Expression<Func<string>> agreementName = null, Expression<Func<object>> b2bTrackingId = null)
        {
            var parameters = new JObject();
            parameters["batchMessage"] = ExpressionConverter.ConvertO(batchMessage);
            if (senderIdentity != null)
            {
                parameters["senderIdentity"] = ExpressionConverter.ConvertO(senderIdentity);
            }

            if (receiverIdentity != null)
            {
                parameters["receiverIdentity"] = ExpressionConverter.ConvertO(receiverIdentity);
            }

            if (agreementName != null)
            {
                parameters["agreementName"] = ExpressionConverter.ConvertO(agreementName);
            }

            if (b2bTrackingId != null)
            {
                parameters["b2bTrackingId"] = ExpressionConverter.ConvertO(b2bTrackingId);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/edifactOperations", operationId: "edifactBatchEncode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<EdifactBatchEncodeOutput>(input);
        }
    }

    public class EdifactOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class EdifactDecodeOutput
    {
        [JsonProperty("interchange")]
        public EdifactDecodeOutputInterchangeType Interchange { get; set; }

        [JsonProperty("b2bTrackingId")]
        public JToken B2bTrackingId { get; set; }
    }

    public class EdifactDecodeOutputInterchangeType
    {
        [JsonProperty("isInterchangeWithGroups")]
        public JToken IsInterchangeWithGroups { get; set; }

        [JsonProperty("unbProperties")]
        public EdifactDecodeOutputInterchangeTypeUnbPropertiesType UnbProperties { get; set; }

        [JsonProperty("receivedAcknowledgements")]
        public EdifactDecodeOutputInterchangeTypeReceivedAcknowledgementsTypeItem[] ReceivedAcknowledgements { get; set; }

        [JsonProperty("generatedAcknowledgements")]
        public EdifactDecodeOutputInterchangeTypeGeneratedAcknowledgementsType GeneratedAcknowledgements { get; set; }

        [JsonProperty("interchangeControlNumber")]
        public JToken InterchangeControlNumber { get; set; }

        [JsonProperty("delimiterSetProperties")]
        public EdifactDecodeOutputInterchangeTypeDelimiterSetPropertiesType DelimiterSetProperties { get; set; }

        [JsonProperty("agreement")]
        public EdifactDecodeOutputInterchangeTypeAgreementType Agreement { get; set; }

        [JsonProperty("interchangeErrors")]
        public EdifactDecodeOutputInterchangeTypeInterchangeErrorsTypeItem[] InterchangeErrors { get; set; }

        [JsonProperty("isFailedInterChange")]
        public bool IsFailedInterChange { get; set; }

        [JsonProperty("functionalGroups")]
        public EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItem[] FunctionalGroups { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeUnbPropertiesType
    {
        [JsonProperty("unb2Dot1")]
        public JToken Unb2Dot1 { get; set; }

        [JsonProperty("unb2Dot2")]
        public JToken Unb2Dot2 { get; set; }

        [JsonProperty("unb2Dot3")]
        public JToken Unb2Dot3 { get; set; }

        [JsonProperty("unb2Dot4")]
        public JToken Unb2Dot4 { get; set; }

        [JsonProperty("unb3Dot1")]
        public JToken Unb3Dot1 { get; set; }

        [JsonProperty("unb3Dot2")]
        public JToken Unb3Dot2 { get; set; }

        [JsonProperty("unb3Dot3")]
        public JToken Unb3Dot3 { get; set; }

        [JsonProperty("unb3Dot4")]
        public JToken Unb3Dot4 { get; set; }

        [JsonProperty("unb11")]
        public JToken Unb11 { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeReceivedAcknowledgementsTypeItem
    {
        [JsonProperty("technicalAcknowledgement")]
        public EdifactDecodeOutputInterchangeTypeReceivedAcknowledgementsTypeItemTechnicalAcknowledgementType TechnicalAcknowledgement { get; set; }

        [JsonProperty("functionalAcknowledgement")]
        public EdifactDecodeOutputInterchangeTypeReceivedAcknowledgementsTypeItemFunctionalAcknowledgementType FunctionalAcknowledgement { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeReceivedAcknowledgementsTypeItemTechnicalAcknowledgementType
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeReceivedAcknowledgementsTypeItemFunctionalAcknowledgementType
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeGeneratedAcknowledgementsType
    {
        [JsonProperty("technicalAcknowledgement")]
        public EdifactDecodeOutputInterchangeTypeGeneratedAcknowledgementsTypeTechnicalAcknowledgementType TechnicalAcknowledgement { get; set; }

        [JsonProperty("functionalAcknowledgement")]
        public EdifactDecodeOutputInterchangeTypeGeneratedAcknowledgementsTypeFunctionalAcknowledgementType FunctionalAcknowledgement { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeGeneratedAcknowledgementsTypeTechnicalAcknowledgementType
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeGeneratedAcknowledgementsTypeFunctionalAcknowledgementType
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeDelimiterSetPropertiesType
    {
        [JsonProperty("componentSeparator")]
        public JToken ComponentSeparator { get; set; }

        [JsonProperty("dataElementSeparator")]
        public JToken DataElementSeparator { get; set; }

        [JsonProperty("repetitionSeparator")]
        public JToken RepetitionSeparator { get; set; }

        [JsonProperty("replacementCharacter")]
        public JToken ReplacementCharacter { get; set; }

        [JsonProperty("segmentTerminator")]
        public JToken SegmentTerminator { get; set; }

        [JsonProperty("segmentTerminatorSuffix")]
        public JToken SegmentTerminatorSuffix { get; set; }

        [JsonProperty("escapeCharacter")]
        public JToken EscapeCharacter { get; set; }

        [JsonProperty("decimalPointIndicator")]
        public JToken DecimalPointIndicator { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeAgreementType
    {
        [JsonProperty("senderPartnerName")]
        public JToken SenderPartnerName { get; set; }

        [JsonProperty("receiverPartnerName")]
        public JToken ReceiverPartnerName { get; set; }

        [JsonProperty("senderQualifier")]
        public JToken SenderQualifier { get; set; }

        [JsonProperty("senderIdentifier")]
        public JToken SenderIdentifier { get; set; }

        [JsonProperty("receiverQualifier")]
        public JToken ReceiverQualifier { get; set; }

        [JsonProperty("receiverIdentifier")]
        public JToken ReceiverIdentifier { get; set; }

        [JsonProperty("agreementName")]
        public JToken AgreementName { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeInterchangeErrorsTypeItem
    {
        [JsonProperty("explicitLoopId")]
        public JToken ExplicitLoopId { get; set; }

        [JsonProperty("segmentId")]
        public JToken SegmentId { get; set; }

        [JsonProperty("positionInTransactionSet")]
        public JToken PositionInTransactionSet { get; set; }

        [JsonProperty("errorCode")]
        public JToken ErrorCode { get; set; }

        [JsonProperty("errorDescription")]
        public JToken ErrorDescription { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItem
    {
        [JsonProperty("functionalGroupControlNumber")]
        public JToken FunctionalGroupControlNumber { get; set; }

        [JsonProperty("ungProperties")]
        public EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemUngPropertiesType UngProperties { get; set; }

        [JsonProperty("transactionSets")]
        public EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItem[] TransactionSets { get; set; }

        [JsonProperty("functionalGroupErrors")]
        public EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemFunctionalGroupErrorsTypeItem[] FunctionalGroupErrors { get; set; }

        [JsonProperty("isFailedFunctionalGroup")]
        public bool IsFailedFunctionalGroup { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemUngPropertiesType
    {
        [JsonProperty("ung1")]
        public JToken Ung1 { get; set; }

        [JsonProperty("ung2Dot1")]
        public JToken Ung2Dot1 { get; set; }

        [JsonProperty("ung2Dot2")]
        public JToken Ung2Dot2 { get; set; }

        [JsonProperty("ung3Dot1")]
        public JToken Ung3Dot1 { get; set; }

        [JsonProperty("ung3Dot2")]
        public JToken Ung3Dot2 { get; set; }

        [JsonProperty("ung4Dot1")]
        public JToken Ung4Dot1 { get; set; }

        [JsonProperty("ung4Dot2")]
        public JToken Ung4Dot2 { get; set; }
        public JToken Ung5 { get; set; }
        public JToken Ung6 { get; set; }

        [JsonProperty("ung7Dot1")]
        public JToken Ung7Dot1 { get; set; }

        [JsonProperty("ung7Dot2")]
        public JToken Ung7Dot2 { get; set; }

        [JsonProperty("ung7Dot3")]
        public JToken Ung7Dot3 { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItem
    {
        [JsonProperty("transactionSetControlNumber")]
        public JToken TransactionSetControlNumber { get; set; }

        [JsonProperty("unhProperties")]
        public EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemUnhPropertiesType UnhProperties { get; set; }

        [JsonProperty("transactionSetContent")]
        public JToken TransactionSetContent { get; set; }

        [JsonProperty("messageType")]
        public JToken MessageType { get; set; }

        [JsonProperty("transactionSetErrors")]
        public EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemTransactionSetErrorsTypeItem[] TransactionSetErrors { get; set; }

        [JsonProperty("isFailedTransactionSet")]
        public bool IsFailedTransactionSet { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemUnhPropertiesType
    {
        [JsonProperty("unh1")]
        public JToken Unh1 { get; set; }

        [JsonProperty("unh2Dot1")]
        public JToken Unh2Dot1 { get; set; }

        [JsonProperty("unh2Dot2")]
        public JToken Unh2Dot2 { get; set; }

        [JsonProperty("unh2Dot3")]
        public JToken Unh2Dot3 { get; set; }

        [JsonProperty("unh2Dot4")]
        public JToken Unh2Dot4 { get; set; }

        [JsonProperty("unh2Dot5")]
        public JToken Unh2Dot5 { get; set; }

        [JsonProperty("unh2Dot6")]
        public JToken Unh2Dot6 { get; set; }

        [JsonProperty("unh2Dot7")]
        public JToken Unh2Dot7 { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemTransactionSetErrorsTypeItem
    {
        [JsonProperty("explicitLoopId")]
        public JToken ExplicitLoopId { get; set; }

        [JsonProperty("segmentId")]
        public JToken SegmentId { get; set; }

        [JsonProperty("positionInTransactionSet")]
        public JToken PositionInTransactionSet { get; set; }

        [JsonProperty("errorCode")]
        public JToken ErrorCode { get; set; }

        [JsonProperty("errorDescription")]
        public JToken ErrorDescription { get; set; }
    }

    public class EdifactDecodeOutputInterchangeTypeFunctionalGroupsTypeItemFunctionalGroupErrorsTypeItem
    {
        [JsonProperty("explicitLoopId")]
        public JToken ExplicitLoopId { get; set; }

        [JsonProperty("segmentId")]
        public JToken SegmentId { get; set; }

        [JsonProperty("positionInTransactionSet")]
        public JToken PositionInTransactionSet { get; set; }

        [JsonProperty("errorCode")]
        public JToken ErrorCode { get; set; }

        [JsonProperty("errorDescription")]
        public JToken ErrorDescription { get; set; }
    }

    public enum EdifactDecodeSegmentTerminatorSuffixType
    {
        NotSpecified,
        None,
        CR,
        LF,
        CRLF
    }

    public enum EdifactDecodeDecimalPointIndicatorType
    {
        NotSpecified,
        Comma,
        Decimal
    }

    public enum EdifactDecodePayloadCharacterSetType
    {
        Legacy,
        UTF8,
        Spec
    }

    public class EdifactEncodeOutput
    {
        [JsonProperty("isInterchangeWithGroups")]
        public JToken IsInterchangeWithGroups { get; set; }

        [JsonProperty("encodedMessageContent")]
        public JToken EncodedMessageContent { get; set; }

        [JsonProperty("agreement")]
        public EdifactEncodeOutputAgreementType Agreement { get; set; }

        [JsonProperty("delimiterSet")]
        public EdifactEncodeOutputDelimiterSetType DelimiterSet { get; set; }

        [JsonProperty("interchangeProperties")]
        public EdifactEncodeOutputInterchangePropertiesType InterchangeProperties { get; set; }

        [JsonProperty("b2bTrackingId")]
        public JToken B2bTrackingId { get; set; }
    }

    public class EdifactEncodeOutputAgreementType
    {
        [JsonProperty("senderPartnerName")]
        public JToken SenderPartnerName { get; set; }

        [JsonProperty("receiverPartnerName")]
        public JToken ReceiverPartnerName { get; set; }

        [JsonProperty("senderQualifier")]
        public JToken SenderQualifier { get; set; }

        [JsonProperty("senderIdentifier")]
        public JToken SenderIdentifier { get; set; }

        [JsonProperty("receiverQualifier")]
        public JToken ReceiverQualifier { get; set; }

        [JsonProperty("receiverIdentifier")]
        public JToken ReceiverIdentifier { get; set; }

        [JsonProperty("agreementName")]
        public JToken AgreementName { get; set; }
    }

    public class EdifactEncodeOutputDelimiterSetType
    {
        [JsonProperty("componentSeparator")]
        public JToken ComponentSeparator { get; set; }

        [JsonProperty("dataElementSeparator")]
        public JToken DataElementSeparator { get; set; }

        [JsonProperty("repetitionSeparator")]
        public JToken RepetitionSeparator { get; set; }

        [JsonProperty("replacementCharacter")]
        public JToken ReplacementCharacter { get; set; }

        [JsonProperty("segmentTerminator")]
        public JToken SegmentTerminator { get; set; }

        [JsonProperty("segmentTerminatorSuffix")]
        public JToken SegmentTerminatorSuffix { get; set; }

        [JsonProperty("escapeCharacter")]
        public JToken EscapeCharacter { get; set; }

        [JsonProperty("decimalPointIndicator")]
        public JToken DecimalPointIndicator { get; set; }
    }

    public class EdifactEncodeOutputInterchangePropertiesType
    {
        [JsonProperty("interchangeControlNumber")]
        public JToken InterchangeControlNumber { get; set; }

        [JsonProperty("functionalGroups")]
        public EdifactEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItem[] FunctionalGroups { get; set; }

        [JsonProperty("unbProperties")]
        public EdifactEncodeOutputInterchangePropertiesTypeUnbPropertiesType UnbProperties { get; set; }
    }

    public class EdifactEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItem
    {
        [JsonProperty("groupControlNumber")]
        public JToken GroupControlNumber { get; set; }

        [JsonProperty("transactionSets")]
        public EdifactEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemTransactionSetsTypeItem[] TransactionSets { get; set; }

        [JsonProperty("ungProperties")]
        public EdifactEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemUngPropertiesType UngProperties { get; set; }
    }

    public class EdifactEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemTransactionSetsTypeItem
    {
        [JsonProperty("transactionSetControlNumber")]
        public JToken TransactionSetControlNumber { get; set; }

        [JsonProperty("unhProperties")]
        public EdifactEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemTransactionSetsTypeItemUnhPropertiesType UnhProperties { get; set; }
    }

    public class EdifactEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemTransactionSetsTypeItemUnhPropertiesType
    {
        [JsonProperty("unh1")]
        public JToken Unh1 { get; set; }

        [JsonProperty("unh2Dot1")]
        public JToken Unh2Dot1 { get; set; }

        [JsonProperty("unh2Dot2")]
        public JToken Unh2Dot2 { get; set; }

        [JsonProperty("unh2Dot3")]
        public JToken Unh2Dot3 { get; set; }

        [JsonProperty("unh2Dot4")]
        public JToken Unh2Dot4 { get; set; }

        [JsonProperty("unh2Dot5")]
        public JToken Unh2Dot5 { get; set; }

        [JsonProperty("unh2Dot6")]
        public JToken Unh2Dot6 { get; set; }

        [JsonProperty("unh2Dot7")]
        public JToken Unh2Dot7 { get; set; }
    }

    public class EdifactEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemUngPropertiesType
    {
        [JsonProperty("ung1")]
        public JToken Ung1 { get; set; }

        [JsonProperty("ung2Dot1")]
        public JToken Ung2Dot1 { get; set; }

        [JsonProperty("ung2Dot2")]
        public JToken Ung2Dot2 { get; set; }

        [JsonProperty("ung3Dot1")]
        public JToken Ung3Dot1 { get; set; }

        [JsonProperty("ung3Dot2")]
        public JToken Ung3Dot2 { get; set; }

        [JsonProperty("ung4Dot1")]
        public JToken Ung4Dot1 { get; set; }

        [JsonProperty("ung4Dot2")]
        public JToken Ung4Dot2 { get; set; }
        public JToken Ung5 { get; set; }
        public JToken Ung6 { get; set; }

        [JsonProperty("ung7Dot1")]
        public JToken Ung7Dot1 { get; set; }

        [JsonProperty("ung7Dot2")]
        public JToken Ung7Dot2 { get; set; }

        [JsonProperty("ung7Dot3")]
        public JToken Ung7Dot3 { get; set; }
    }

    public class EdifactEncodeOutputInterchangePropertiesTypeUnbPropertiesType
    {
        [JsonProperty("unb2Dot1")]
        public JToken Unb2Dot1 { get; set; }

        [JsonProperty("unb2Dot2")]
        public JToken Unb2Dot2 { get; set; }

        [JsonProperty("unb2Dot3")]
        public JToken Unb2Dot3 { get; set; }

        [JsonProperty("unb2Dot4")]
        public JToken Unb2Dot4 { get; set; }

        [JsonProperty("unb3Dot1")]
        public JToken Unb3Dot1 { get; set; }

        [JsonProperty("unb3Dot2")]
        public JToken Unb3Dot2 { get; set; }

        [JsonProperty("unb3Dot3")]
        public JToken Unb3Dot3 { get; set; }

        [JsonProperty("unb3Dot4")]
        public JToken Unb3Dot4 { get; set; }

        [JsonProperty("unb11")]
        public JToken Unb11 { get; set; }
    }

    public class EdifactEncodeSenderIdentityType
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EdifactEncodeReceiverIdentityType
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EdifactBatchEncodeOutput
    {
        [JsonProperty("isInterchangeWithGroups")]
        public JToken IsInterchangeWithGroups { get; set; }

        [JsonProperty("encodedMessageContent")]
        public JToken EncodedMessageContent { get; set; }

        [JsonProperty("batchName")]
        public JToken BatchName { get; set; }

        [JsonProperty("partitionName")]
        public JToken PartitionName { get; set; }

        [JsonProperty("failedMessages")]
        public EdifactBatchEncodeOutputFailedMessagesTypeItem[] FailedMessages { get; set; }

        [JsonProperty("agreement")]
        public EdifactBatchEncodeOutputAgreementType Agreement { get; set; }

        [JsonProperty("delimiterSet")]
        public EdifactBatchEncodeOutputDelimiterSetType DelimiterSet { get; set; }

        [JsonProperty("interchangeProperties")]
        public EdifactBatchEncodeOutputInterchangePropertiesType InterchangeProperties { get; set; }

        [JsonProperty("b2bTrackingId")]
        public JToken B2bTrackingId { get; set; }
    }

    public class EdifactBatchEncodeOutputFailedMessagesTypeItem
    {
        [JsonProperty("messageId")]
        public JToken MessageId { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }

    public class EdifactBatchEncodeOutputAgreementType
    {
        [JsonProperty("senderPartnerName")]
        public JToken SenderPartnerName { get; set; }

        [JsonProperty("receiverPartnerName")]
        public JToken ReceiverPartnerName { get; set; }

        [JsonProperty("senderQualifier")]
        public JToken SenderQualifier { get; set; }

        [JsonProperty("senderIdentifier")]
        public JToken SenderIdentifier { get; set; }

        [JsonProperty("receiverQualifier")]
        public JToken ReceiverQualifier { get; set; }

        [JsonProperty("receiverIdentifier")]
        public JToken ReceiverIdentifier { get; set; }

        [JsonProperty("agreementName")]
        public JToken AgreementName { get; set; }
    }

    public class EdifactBatchEncodeOutputDelimiterSetType
    {
        [JsonProperty("componentSeparator")]
        public JToken ComponentSeparator { get; set; }

        [JsonProperty("dataElementSeparator")]
        public JToken DataElementSeparator { get; set; }

        [JsonProperty("repetitionSeparator")]
        public JToken RepetitionSeparator { get; set; }

        [JsonProperty("replacementCharacter")]
        public JToken ReplacementCharacter { get; set; }

        [JsonProperty("segmentTerminator")]
        public JToken SegmentTerminator { get; set; }

        [JsonProperty("segmentTerminatorSuffix")]
        public JToken SegmentTerminatorSuffix { get; set; }

        [JsonProperty("escapeCharacter")]
        public JToken EscapeCharacter { get; set; }

        [JsonProperty("decimalPointIndicator")]
        public JToken DecimalPointIndicator { get; set; }
    }

    public class EdifactBatchEncodeOutputInterchangePropertiesType
    {
        [JsonProperty("interchangeControlNumber")]
        public JToken InterchangeControlNumber { get; set; }

        [JsonProperty("functionalGroups")]
        public EdifactBatchEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItem[] FunctionalGroups { get; set; }

        [JsonProperty("unbProperties")]
        public EdifactBatchEncodeOutputInterchangePropertiesTypeUnbPropertiesType UnbProperties { get; set; }
    }

    public class EdifactBatchEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItem
    {
        [JsonProperty("groupControlNumber")]
        public JToken GroupControlNumber { get; set; }

        [JsonProperty("transactionSets")]
        public EdifactBatchEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemTransactionSetsTypeItem[] TransactionSets { get; set; }

        [JsonProperty("ungProperties")]
        public EdifactBatchEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemUngPropertiesType UngProperties { get; set; }
    }

    public class EdifactBatchEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemTransactionSetsTypeItem
    {
        [JsonProperty("transactionSetControlNumber")]
        public JToken TransactionSetControlNumber { get; set; }

        [JsonProperty("unhProperties")]
        public EdifactBatchEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemTransactionSetsTypeItemUnhPropertiesType UnhProperties { get; set; }
    }

    public class EdifactBatchEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemTransactionSetsTypeItemUnhPropertiesType
    {
        [JsonProperty("unh1")]
        public JToken Unh1 { get; set; }

        [JsonProperty("unh2Dot1")]
        public JToken Unh2Dot1 { get; set; }

        [JsonProperty("unh2Dot2")]
        public JToken Unh2Dot2 { get; set; }

        [JsonProperty("unh2Dot3")]
        public JToken Unh2Dot3 { get; set; }

        [JsonProperty("unh2Dot4")]
        public JToken Unh2Dot4 { get; set; }

        [JsonProperty("unh2Dot5")]
        public JToken Unh2Dot5 { get; set; }

        [JsonProperty("unh2Dot6")]
        public JToken Unh2Dot6 { get; set; }

        [JsonProperty("unh2Dot7")]
        public JToken Unh2Dot7 { get; set; }
    }

    public class EdifactBatchEncodeOutputInterchangePropertiesTypeFunctionalGroupsTypeItemUngPropertiesType
    {
        [JsonProperty("ung1")]
        public JToken Ung1 { get; set; }

        [JsonProperty("ung2Dot1")]
        public JToken Ung2Dot1 { get; set; }

        [JsonProperty("ung2Dot2")]
        public JToken Ung2Dot2 { get; set; }

        [JsonProperty("ung3Dot1")]
        public JToken Ung3Dot1 { get; set; }

        [JsonProperty("ung3Dot2")]
        public JToken Ung3Dot2 { get; set; }

        [JsonProperty("ung4Dot1")]
        public JToken Ung4Dot1 { get; set; }

        [JsonProperty("ung4Dot2")]
        public JToken Ung4Dot2 { get; set; }
        public JToken Ung5 { get; set; }
        public JToken Ung6 { get; set; }

        [JsonProperty("ung7Dot1")]
        public JToken Ung7Dot1 { get; set; }

        [JsonProperty("ung7Dot2")]
        public JToken Ung7Dot2 { get; set; }

        [JsonProperty("ung7Dot3")]
        public JToken Ung7Dot3 { get; set; }
    }

    public class EdifactBatchEncodeOutputInterchangePropertiesTypeUnbPropertiesType
    {
        [JsonProperty("unb2Dot1")]
        public JToken Unb2Dot1 { get; set; }

        [JsonProperty("unb2Dot2")]
        public JToken Unb2Dot2 { get; set; }

        [JsonProperty("unb2Dot3")]
        public JToken Unb2Dot3 { get; set; }

        [JsonProperty("unb2Dot4")]
        public JToken Unb2Dot4 { get; set; }

        [JsonProperty("unb3Dot1")]
        public JToken Unb3Dot1 { get; set; }

        [JsonProperty("unb3Dot2")]
        public JToken Unb3Dot2 { get; set; }

        [JsonProperty("unb3Dot3")]
        public JToken Unb3Dot3 { get; set; }

        [JsonProperty("unb3Dot4")]
        public JToken Unb3Dot4 { get; set; }

        [JsonProperty("unb11")]
        public JToken Unb11 { get; set; }
    }

    public class EdifactBatchEncodeBatchMessageType
    {
        [JsonProperty("batchName")]
        public string BatchName { get; set; }

        [JsonProperty("partitionName")]
        public string PartitionName { get; set; }

        [JsonProperty("items")]
        public EdifactBatchEncodeBatchMessageTypeItemsTypeItem[] Items { get; set; }
    }

    public class EdifactBatchEncodeBatchMessageTypeItemsTypeItem
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class EdifactBatchEncodeSenderIdentityType
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EdifactBatchEncodeReceiverIdentityType
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.EdifactOperations;

    public partial class WorkflowServiceProviderActions
    {
        public EdifactOperationsActions EdifactOperations(string connectionId) => new EdifactOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public EdifactOperationsTriggers EdifactOperations(string connectionId) => new EdifactOperationsTriggers(connectionId);
    }
}