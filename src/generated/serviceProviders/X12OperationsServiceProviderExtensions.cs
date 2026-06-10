//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.X12Operations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class X12OperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "x12Operations")]
        public IBodyWorkflowAction<X12EncodeOutput> X12Encode(Expression<Func<object>> messageToEncode, Expression<Func<X12EncodeSenderIdentityType>> senderIdentity = null, Expression<Func<X12EncodeReceiverIdentityType>> receiverIdentity = null, Expression<Func<string>> agreementName = null, Expression<Func<string>> b2bTrackingId = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["messageToEncode"] = ExpressionConverter.ConvertO(messageToEncode);
            if (senderIdentity != null)
            {
                serviceProviderParameters["senderIdentity"] = ExpressionConverter.ConvertO(senderIdentity);
            }

            if (receiverIdentity != null)
            {
                serviceProviderParameters["receiverIdentity"] = ExpressionConverter.ConvertO(receiverIdentity);
            }

            if (agreementName != null)
            {
                serviceProviderParameters["agreementName"] = ExpressionConverter.ConvertO(agreementName);
            }

            if (b2bTrackingId != null)
            {
                serviceProviderParameters["b2bTrackingId"] = ExpressionConverter.ConvertO(b2bTrackingId);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/x12Operations", operationId: "x12Encode", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<X12EncodeOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "x12Operations")]
        public IBodyWorkflowAction<X12BatchEncodeOutput> X12BatchEncode(Expression<Func<X12BatchEncodeBatchMessageType>> batchMessage, Expression<Func<X12BatchEncodeSenderIdentityType>> senderIdentity = null, Expression<Func<X12BatchEncodeReceiverIdentityType>> receiverIdentity = null, Expression<Func<string>> agreementName = null, Expression<Func<object>> b2bTrackingId = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["batchMessage"] = ExpressionConverter.ConvertO(batchMessage);
            if (senderIdentity != null)
            {
                serviceProviderParameters["senderIdentity"] = ExpressionConverter.ConvertO(senderIdentity);
            }

            if (receiverIdentity != null)
            {
                serviceProviderParameters["receiverIdentity"] = ExpressionConverter.ConvertO(receiverIdentity);
            }

            if (agreementName != null)
            {
                serviceProviderParameters["agreementName"] = ExpressionConverter.ConvertO(agreementName);
            }

            if (b2bTrackingId != null)
            {
                serviceProviderParameters["b2bTrackingId"] = ExpressionConverter.ConvertO(b2bTrackingId);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/x12Operations", operationId: "x12BatchEncode", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<X12BatchEncodeOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "x12Operations")]
        public IBodyWorkflowAction<X12DecodeOutput> X12Decode(Expression<Func<object>> messageToDecode, Expression<Func<string>> b2bTrackingId = null, Expression<Func<string>> fallbackAgreementName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["messageToDecode"] = ExpressionConverter.ConvertO(messageToDecode);
            if (b2bTrackingId != null)
            {
                serviceProviderParameters["b2bTrackingId"] = ExpressionConverter.ConvertO(b2bTrackingId);
            }

            if (fallbackAgreementName != null)
            {
                serviceProviderParameters["fallbackAgreementName"] = ExpressionConverter.ConvertO(fallbackAgreementName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/x12Operations", operationId: "x12Decode", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<X12DecodeOutput>(serviceProviderInput);
        }
    }

    public class X12OperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class X12EncodeOutput
    {
        [JsonProperty("encodedMessageContent")]
        public JToken EncodedMessageContent { get; set; }

        [JsonProperty("agreement")]
        public X12EncodeOutputAgreementType Agreement { get; set; }

        [JsonProperty("delimiterSet")]
        public X12EncodeOutputDelimiterSetType DelimiterSet { get; set; }

        [JsonProperty("interchangeProperties")]
        public X12EncodeOutputInterchangePropertiesType InterchangeProperties { get; set; }

        [JsonProperty("b2bTrackingId")]
        public JToken B2bTrackingId { get; set; }
    }

    public class X12EncodeOutputAgreementType
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

    public class X12EncodeOutputDelimiterSetType
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
    }

    public class X12EncodeOutputInterchangePropertiesType
    {
        [JsonProperty("interchangeControlNumber")]
        public JToken InterchangeControlNumber { get; set; }

        [JsonProperty("interchangeGroups")]
        public X12EncodeOutputInterchangePropertiesTypeInterchangeGroupsTypeItem[] InterchangeGroups { get; set; }

        [JsonProperty("isa05")]
        public JToken Isa05 { get; set; }

        [JsonProperty("isa06")]
        public JToken Isa06 { get; set; }

        [JsonProperty("isa07")]
        public JToken Isa07 { get; set; }

        [JsonProperty("isa08")]
        public JToken Isa08 { get; set; }

        [JsonProperty("isa09")]
        public JToken Isa09 { get; set; }

        [JsonProperty("isa10")]
        public JToken Isa10 { get; set; }

        [JsonProperty("isa11")]
        public JToken Isa11 { get; set; }

        [JsonProperty("isa12")]
        public JToken Isa12 { get; set; }

        [JsonProperty("isa13")]
        public JToken Isa13 { get; set; }

        [JsonProperty("isa14")]
        public JToken Isa14 { get; set; }

        [JsonProperty("isa15")]
        public JToken Isa15 { get; set; }
    }

    public class X12EncodeOutputInterchangePropertiesTypeInterchangeGroupsTypeItem
    {
        [JsonProperty("groupControlNumber")]
        public JToken GroupControlNumber { get; set; }

        [JsonProperty("transactionSets")]
        public X12EncodeOutputInterchangePropertiesTypeInterchangeGroupsTypeItemTransactionSetsTypeItem[] TransactionSets { get; set; }

        [JsonProperty("gs1")]
        public JToken Gs1 { get; set; }

        [JsonProperty("gs2")]
        public JToken Gs2 { get; set; }

        [JsonProperty("gs3")]
        public JToken Gs3 { get; set; }

        [JsonProperty("gs4")]
        public JToken Gs4 { get; set; }

        [JsonProperty("gs5")]
        public JToken Gs5 { get; set; }

        [JsonProperty("gs6")]
        public JToken Gs6 { get; set; }

        [JsonProperty("gs7")]
        public JToken Gs7 { get; set; }

        [JsonProperty("gs8")]
        public JToken Gs8 { get; set; }
    }

    public class X12EncodeOutputInterchangePropertiesTypeInterchangeGroupsTypeItemTransactionSetsTypeItem
    {
        [JsonProperty("transactionSetControlNumber")]
        public JToken TransactionSetControlNumber { get; set; }

        [JsonProperty("st01")]
        public JToken St01 { get; set; }

        [JsonProperty("st02")]
        public JToken St02 { get; set; }

        [JsonProperty("se01")]
        public JToken Se01 { get; set; }

        [JsonProperty("se02")]
        public JToken Se02 { get; set; }
    }

    public class X12EncodeSenderIdentityType
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class X12EncodeReceiverIdentityType
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class X12BatchEncodeOutput
    {
        [JsonProperty("encodedMessageContent")]
        public JToken EncodedMessageContent { get; set; }

        [JsonProperty("agreement")]
        public X12BatchEncodeOutputAgreementType Agreement { get; set; }

        [JsonProperty("delimiterSet")]
        public X12BatchEncodeOutputDelimiterSetType DelimiterSet { get; set; }

        [JsonProperty("interchangeProperties")]
        public X12BatchEncodeOutputInterchangePropertiesType InterchangeProperties { get; set; }

        [JsonProperty("b2bTrackingId")]
        public JToken B2bTrackingId { get; set; }
    }

    public class X12BatchEncodeOutputAgreementType
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

    public class X12BatchEncodeOutputDelimiterSetType
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
    }

    public class X12BatchEncodeOutputInterchangePropertiesType
    {
        [JsonProperty("interchangeControlNumber")]
        public JToken InterchangeControlNumber { get; set; }

        [JsonProperty("interchangeGroups")]
        public X12BatchEncodeOutputInterchangePropertiesTypeInterchangeGroupsTypeItem[] InterchangeGroups { get; set; }

        [JsonProperty("isa05")]
        public JToken Isa05 { get; set; }

        [JsonProperty("isa06")]
        public JToken Isa06 { get; set; }

        [JsonProperty("isa07")]
        public JToken Isa07 { get; set; }

        [JsonProperty("isa08")]
        public JToken Isa08 { get; set; }

        [JsonProperty("isa09")]
        public JToken Isa09 { get; set; }

        [JsonProperty("isa10")]
        public JToken Isa10 { get; set; }

        [JsonProperty("isa11")]
        public JToken Isa11 { get; set; }

        [JsonProperty("isa12")]
        public JToken Isa12 { get; set; }

        [JsonProperty("isa13")]
        public JToken Isa13 { get; set; }

        [JsonProperty("isa14")]
        public JToken Isa14 { get; set; }

        [JsonProperty("isa15")]
        public JToken Isa15 { get; set; }
    }

    public class X12BatchEncodeOutputInterchangePropertiesTypeInterchangeGroupsTypeItem
    {
        [JsonProperty("groupControlNumber")]
        public JToken GroupControlNumber { get; set; }

        [JsonProperty("transactionSets")]
        public X12BatchEncodeOutputInterchangePropertiesTypeInterchangeGroupsTypeItemTransactionSetsTypeItem[] TransactionSets { get; set; }

        [JsonProperty("gs1")]
        public JToken Gs1 { get; set; }

        [JsonProperty("gs2")]
        public JToken Gs2 { get; set; }

        [JsonProperty("gs3")]
        public JToken Gs3 { get; set; }

        [JsonProperty("gs4")]
        public JToken Gs4 { get; set; }

        [JsonProperty("gs5")]
        public JToken Gs5 { get; set; }

        [JsonProperty("gs6")]
        public JToken Gs6 { get; set; }

        [JsonProperty("gs7")]
        public JToken Gs7 { get; set; }

        [JsonProperty("gs8")]
        public JToken Gs8 { get; set; }
    }

    public class X12BatchEncodeOutputInterchangePropertiesTypeInterchangeGroupsTypeItemTransactionSetsTypeItem
    {
        [JsonProperty("transactionSetControlNumber")]
        public JToken TransactionSetControlNumber { get; set; }

        [JsonProperty("st01")]
        public JToken St01 { get; set; }

        [JsonProperty("st02")]
        public JToken St02 { get; set; }

        [JsonProperty("se01")]
        public JToken Se01 { get; set; }

        [JsonProperty("se02")]
        public JToken Se02 { get; set; }
    }

    public class X12BatchEncodeBatchMessageType
    {
        [JsonProperty("batchName")]
        public string BatchName { get; set; }

        [JsonProperty("partitionName")]
        public string PartitionName { get; set; }

        [JsonProperty("items")]
        public X12BatchEncodeBatchMessageTypeItemsTypeItem[] Items { get; set; }
    }

    public class X12BatchEncodeBatchMessageTypeItemsTypeItem
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class X12BatchEncodeSenderIdentityType
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class X12BatchEncodeReceiverIdentityType
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class X12DecodeOutput
    {
        [JsonProperty("interchange")]
        public X12DecodeOutputInterchangeType Interchange { get; set; }

        [JsonProperty("b2bTrackingId")]
        public JToken B2bTrackingId { get; set; }
    }

    public class X12DecodeOutputInterchangeType
    {
        [JsonProperty("isaProperties")]
        public X12DecodeOutputInterchangeTypeIsaPropertiesType IsaProperties { get; set; }

        [JsonProperty("ieaProperties")]
        public X12DecodeOutputInterchangeTypeIeaPropertiesType IeaProperties { get; set; }

        [JsonProperty("receivedAcknowledgement")]
        public X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItem[] ReceivedAcknowledgement { get; set; }

        [JsonProperty("generatedTechnicalAcknowledgement")]
        public X12DecodeOutputInterchangeTypeGeneratedTechnicalAcknowledgementType GeneratedTechnicalAcknowledgement { get; set; }

        [JsonProperty("isFailedInterchange")]
        public bool IsFailedInterchange { get; set; }

        [JsonProperty("interchangeControlNumber")]
        public JToken InterchangeControlNumber { get; set; }

        [JsonProperty("delimiterSetProperties")]
        public X12DecodeOutputInterchangeTypeDelimiterSetPropertiesType DelimiterSetProperties { get; set; }

        [JsonProperty("agreement")]
        public X12DecodeOutputInterchangeTypeAgreementType Agreement { get; set; }

        [JsonProperty("functionalGroups")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItem[] FunctionalGroups { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeIsaPropertiesType
    {
        [JsonProperty("isa1")]
        public JToken Isa1 { get; set; }

        [JsonProperty("isa2")]
        public JToken Isa2 { get; set; }

        [JsonProperty("isa3")]
        public JToken Isa3 { get; set; }

        [JsonProperty("isa4")]
        public JToken Isa4 { get; set; }

        [JsonProperty("isa5")]
        public JToken Isa5 { get; set; }

        [JsonProperty("isa6")]
        public JToken Isa6 { get; set; }

        [JsonProperty("isa7")]
        public JToken Isa7 { get; set; }

        [JsonProperty("isa8")]
        public JToken Isa8 { get; set; }

        [JsonProperty("isa9")]
        public JToken Isa9 { get; set; }

        [JsonProperty("isa10")]
        public JToken Isa10 { get; set; }

        [JsonProperty("isa11")]
        public JToken Isa11 { get; set; }

        [JsonProperty("isa12")]
        public JToken Isa12 { get; set; }

        [JsonProperty("isa13")]
        public JToken Isa13 { get; set; }

        [JsonProperty("isa14")]
        public JToken Isa14 { get; set; }

        [JsonProperty("isa15")]
        public JToken Isa15 { get; set; }

        [JsonProperty("isa16")]
        public JToken Isa16 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeIeaPropertiesType
    {
        [JsonProperty("iea1")]
        public JToken Iea1 { get; set; }

        [JsonProperty("iea2")]
        public JToken Iea2 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItem
    {
        [JsonProperty("acknowledgementContent")]
        public JToken AcknowledgementContent { get; set; }

        [JsonProperty("acknowledgementType")]
        public JToken AcknowledgementType { get; set; }

        [JsonProperty("functionalAcknowledgementProperties")]
        public X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemFunctionalAcknowledgementPropertiesType FunctionalAcknowledgementProperties { get; set; }

        [JsonProperty("technicalAcknowledgementProperties")]
        public X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemTechnicalAcknowledgementPropertiesType TechnicalAcknowledgementProperties { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemFunctionalAcknowledgementPropertiesType
    {
        [JsonProperty("header")]
        public X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemFunctionalAcknowledgementPropertiesTypeHeaderType Header { get; set; }

        [JsonProperty("ak2Loop")]
        public X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemFunctionalAcknowledgementPropertiesTypeAk2LoopType Ak2Loop { get; set; }

        [JsonProperty("trailer")]
        public X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemFunctionalAcknowledgementPropertiesTypeTrailerType Trailer { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemFunctionalAcknowledgementPropertiesTypeHeaderType
    {
        [JsonProperty("ak101")]
        public JToken Ak101 { get; set; }

        [JsonProperty("ak102")]
        public JToken Ak102 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemFunctionalAcknowledgementPropertiesTypeAk2LoopType
    {
        [JsonProperty("ak201")]
        public JToken Ak201 { get; set; }

        [JsonProperty("ak202")]
        public JToken Ak202 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemFunctionalAcknowledgementPropertiesTypeTrailerType
    {
        [JsonProperty("ak901")]
        public JToken Ak901 { get; set; }

        [JsonProperty("ak902")]
        public JToken Ak902 { get; set; }

        [JsonProperty("ak903")]
        public JToken Ak903 { get; set; }

        [JsonProperty("ak904")]
        public JToken Ak904 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeReceivedAcknowledgementTypeItemTechnicalAcknowledgementPropertiesType
    {
        [JsonProperty("ta101")]
        public JToken Ta101 { get; set; }

        [JsonProperty("ta102")]
        public JToken Ta102 { get; set; }

        [JsonProperty("ta103")]
        public JToken Ta103 { get; set; }

        [JsonProperty("ta104")]
        public JToken Ta104 { get; set; }

        [JsonProperty("ta105")]
        public JToken Ta105 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeGeneratedTechnicalAcknowledgementType
    {
        [JsonProperty("ta101")]
        public JToken Ta101 { get; set; }

        [JsonProperty("ta102")]
        public JToken Ta102 { get; set; }

        [JsonProperty("ta103")]
        public JToken Ta103 { get; set; }

        [JsonProperty("ta104")]
        public JToken Ta104 { get; set; }

        [JsonProperty("ta105")]
        public JToken Ta105 { get; set; }

        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeDelimiterSetPropertiesType
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

    public class X12DecodeOutputInterchangeTypeAgreementType
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

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItem
    {
        [JsonProperty("groupControlNumber")]
        public JToken GroupControlNumber { get; set; }

        [JsonProperty("isFailedFunctionalGroup")]
        public bool IsFailedFunctionalGroup { get; set; }

        [JsonProperty("gsProperties")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGsPropertiesType GsProperties { get; set; }

        [JsonProperty("geProperties")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGePropertiesType GeProperties { get; set; }

        [JsonProperty("generatedFunctionalAcknowledgement")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGeneratedFunctionalAcknowledgementType GeneratedFunctionalAcknowledgement { get; set; }

        [JsonProperty("transactionSets")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItem[] TransactionSets { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGsPropertiesType
    {
        [JsonProperty("gs1")]
        public JToken Gs1 { get; set; }

        [JsonProperty("gs2")]
        public JToken Gs2 { get; set; }

        [JsonProperty("gs3")]
        public JToken Gs3 { get; set; }

        [JsonProperty("gs4")]
        public JToken Gs4 { get; set; }

        [JsonProperty("gs5")]
        public JToken Gs5 { get; set; }

        [JsonProperty("gs6")]
        public JToken Gs6 { get; set; }

        [JsonProperty("gs7")]
        public JToken Gs7 { get; set; }

        [JsonProperty("gs8")]
        public JToken Gs8 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGePropertiesType
    {
        [JsonProperty("ge1")]
        public JToken Ge1 { get; set; }

        [JsonProperty("ge2")]
        public JToken Ge2 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGeneratedFunctionalAcknowledgementType
    {
        [JsonProperty("header")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGeneratedFunctionalAcknowledgementTypeHeaderType Header { get; set; }

        [JsonProperty("trailer")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGeneratedFunctionalAcknowledgementTypeTrailerType Trailer { get; set; }

        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("acknowledgementType")]
        public JToken AcknowledgementType { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGeneratedFunctionalAcknowledgementTypeHeaderType
    {
        [JsonProperty("ak101")]
        public JToken Ak101 { get; set; }

        [JsonProperty("ak102")]
        public JToken Ak102 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemGeneratedFunctionalAcknowledgementTypeTrailerType
    {
        [JsonProperty("ak901")]
        public JToken Ak901 { get; set; }

        [JsonProperty("ak902")]
        public JToken Ak902 { get; set; }

        [JsonProperty("ak903")]
        public JToken Ak903 { get; set; }

        [JsonProperty("ak904")]
        public JToken Ak904 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItem
    {
        [JsonProperty("transactionSetErrors")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemTransactionSetErrorsTypeItem[] TransactionSetErrors { get; set; }

        [JsonProperty("transactionSetControlNumber")]
        public JToken TransactionSetControlNumber { get; set; }

        [JsonProperty("isFailedTransactionSet")]
        public bool IsFailedTransactionSet { get; set; }

        [JsonProperty("messageType")]
        public JToken MessageType { get; set; }

        [JsonProperty("stProperties")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemStPropertiesType StProperties { get; set; }

        [JsonProperty("seProperties")]
        public X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemSePropertiesType SeProperties { get; set; }

        [JsonProperty("transactionSetContent")]
        public JToken TransactionSetContent { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemTransactionSetErrorsTypeItem
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

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemStPropertiesType
    {
        [JsonProperty("st1")]
        public JToken St1 { get; set; }

        [JsonProperty("st2")]
        public JToken St2 { get; set; }

        [JsonProperty("st3")]
        public JToken St3 { get; set; }
    }

    public class X12DecodeOutputInterchangeTypeFunctionalGroupsTypeItemTransactionSetsTypeItemSePropertiesType
    {
        [JsonProperty("se1")]
        public JToken Se1 { get; set; }

        [JsonProperty("se2")]
        public JToken Se2 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.X12Operations;

    public partial class WorkflowServiceProviderActions
    {
        public X12OperationsActions X12Operations(string connectionId) => new X12OperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public X12OperationsTriggers X12Operations(string connectionId) => new X12OperationsTriggers(connectionId);
    }
}