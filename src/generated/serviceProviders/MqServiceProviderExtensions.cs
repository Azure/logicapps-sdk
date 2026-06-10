//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Mq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<BrowseMessageOutput> BrowseMessage(Expression<Func<string>> queueName, Expression<Func<bool>> includeInfo, Expression<Func<BrowseMessageGetMessageOptionsType>> getMessageOptions = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
            if (getMessageOptions != null)
            {
                parameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "browseMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<BrowseMessageOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<BrowseBatchOutput> BrowseBatch(Expression<Func<string>> queueName, Expression<Func<bool>> includeInfo, Expression<Func<BrowseBatchGetMessageOptionsType>> getMessageOptions = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
            if (getMessageOptions != null)
            {
                parameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "browseBatch", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<BrowseBatchOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<ReceiveMessageOutput> ReceiveMessage(Expression<Func<string>> queueName, Expression<Func<bool>> includeInfo, Expression<Func<ReceiveMessageGetMessageOptionsType>> getMessageOptions = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
            if (getMessageOptions != null)
            {
                parameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "receiveMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ReceiveMessageOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<ReceiveBatchOutput> ReceiveBatch(Expression<Func<string>> queueName, Expression<Func<bool>> includeInfo, Expression<Func<ReceiveBatchGetMessageOptionsType>> getMessageOptions = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
            if (getMessageOptions != null)
            {
                parameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "receiveBatch", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ReceiveBatchOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<SendMessageOutput> SendMessage(Expression<Func<string>> queueName, Expression<Func<string>> message, Expression<Func<SendMessageSendMessageOptionsType>> sendMessageOptions = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["message"] = ExpressionConverter.ConvertO(message);
            if (sendMessageOptions != null)
            {
                parameters["sendMessageOptions"] = ExpressionConverter.ConvertO(sendMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "sendMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<SendMessageOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<SendBatchOutput> SendBatch(Expression<Func<string>> queueName, Expression<Func<SendBatchMessageListTypeItem[]>> messageList, Expression<Func<SendBatchSendMessageOptionsType>> sendMessageOptions = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["messageList"] = ExpressionConverter.ConvertO(messageList);
            if (sendMessageOptions != null)
            {
                parameters["sendMessageOptions"] = ExpressionConverter.ConvertO(sendMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "sendBatch", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<SendBatchOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<CompleteMessageOutput> CompleteMessage(Expression<Func<string>> queueName, Expression<Func<string>> uniqueId, Expression<Func<string>> messageId, Expression<Func<CompleteMessageCompleteActionType>> completeAction)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["uniqueId"] = ExpressionConverter.ConvertO(uniqueId);
            parameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            parameters["completeAction"] = ExpressionConverter.ConvertO(completeAction);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "completeMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CompleteMessageOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<CompleteBatchOutput> CompleteBatch(Expression<Func<string>> queueName, Expression<Func<CompleteBatchCompleteActionType>> completeAction)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["completeAction"] = ExpressionConverter.ConvertO(completeAction);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "completeBatch", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CompleteBatchOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        public IBodyWorkflowAction<MoveMessageToDeadLetterQueueOutput> MoveMessageToDeadLetterQueue(Expression<Func<object>> message, Expression<Func<int>> reasonCode, Expression<Func<string>> deadLetterQueueName = null, Expression<Func<MoveMessageToDeadLetterQueueSendMessageOptionsType>> sendMessageOptions = null)
        {
            var parameters = new JObject();
            parameters["message"] = ExpressionConverter.ConvertO(message);
            parameters["reasonCode"] = ExpressionConverter.ConvertO(reasonCode);
            if (deadLetterQueueName != null)
            {
                parameters["deadLetterQueueName"] = ExpressionConverter.ConvertO(deadLetterQueueName);
            }

            if (sendMessageOptions != null)
            {
                parameters["sendMessageOptions"] = ExpressionConverter.ConvertO(sendMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "moveMessageToDeadLetterQueue", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<MoveMessageToDeadLetterQueueOutput>(input);
        }
    }

    public class MqTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PollAvailableOutput> PollAvailable(Expression<Func<string>> queueName, Expression<Func<int>> waitIntervalInSeconds = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (waitIntervalInSeconds != null)
            {
                parameters["waitIntervalInSeconds"] = ExpressionConverter.ConvertO(waitIntervalInSeconds);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "pollAvailable", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<PollAvailableOutput>(input, triggerName);
        }

        public IBodyWorkflowTrigger<PollBrowseMessagesOutput> PollBrowseMessages(Expression<Func<string>> queueName, Expression<Func<bool>> includeInfo, Expression<Func<PollBrowseMessagesGetMessageOptionsType>> getMessageOptions = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
            if (getMessageOptions != null)
            {
                parameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "pollBrowseMessages", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<PollBrowseMessagesOutput>(input, triggerName);
        }

        public IBodyWorkflowTrigger<PollMessagesOutput> PollMessages(Expression<Func<string>> queueName, Expression<Func<bool>> includeInfo, Expression<Func<PollMessagesGetMessageOptionsType>> getMessageOptions = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
            if (getMessageOptions != null)
            {
                parameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "pollMessages", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<PollMessagesOutput>(input, triggerName);
        }
    }

    public class BrowseMessageOutput
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("message")]
        public BrowseMessageOutputMessageType Message { get; set; }
    }

    public class BrowseMessageOutputMessageType
    {
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("report")]
        public BrowseMessageOutputMessageTypeReportType Report { get; set; }

        [JsonProperty("messageType")]
        public BrowseMessageOutputMessageTypeMessageTypeType MessageType { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }

        [JsonProperty("encoding")]
        public int Encoding { get; set; }

        [JsonProperty("codePage")]
        public int CodePage { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("priority")]
        public BrowseMessageOutputMessageTypePriorityType Priority { get; set; }

        [JsonProperty("persistence")]
        public BrowseMessageOutputMessageTypePersistenceType Persistence { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("userIdentifier")]
        public string UserIdentifier { get; set; }

        [JsonProperty("accountingToken")]
        public string AccountingToken { get; set; }

        [JsonProperty("applicationIdData")]
        public string ApplicationIdData { get; set; }

        [JsonProperty("putApplicationType")]
        public string PutApplicationType { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putDate")]
        public string PutDate { get; set; }

        [JsonProperty("putTime")]
        public string PutTime { get; set; }

        [JsonProperty("applicationOriginData")]
        public string ApplicationOriginData { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("flags")]
        public BrowseMessageOutputMessageTypeFlagsType Flags { get; set; }

        [JsonProperty("originalLength")]
        public int OriginalLength { get; set; }
        public string OriginalConnectionId { get; set; }

        [JsonProperty("originalQueueManagerName")]
        public string OriginalQueueManagerName { get; set; }

        [JsonProperty("originalQueueName")]
        public string OriginalQueueName { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    public enum BrowseMessageOutputMessageTypeReportType
    {
        None,
        [EnumMember(Value = "Pass Message ID")]
        PassMessageId,
        [EnumMember(Value = "Pass Correlator ID")]
        PassCorrelatorId,
        [EnumMember(Value = "Pass Discard and Expiry")]
        PassDiscardAndExpiry,
        [EnumMember(Value = "Discard Message")]
        DiscardMessage
    }

    public enum BrowseMessageOutputMessageTypeMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    public enum BrowseMessageOutputMessageTypePriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    public enum BrowseMessageOutputMessageTypePersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    public enum BrowseMessageOutputMessageTypeFlagsType
    {
        None,
        [EnumMember(Value = "Segmentation Inhibited")]
        SegmentationInhibited,
        [EnumMember(Value = "Segmentation Allowed")]
        SegmentationAllowed,
        Segment,
        [EnumMember(Value = "Last Segment")]
        LastSegment,
        [EnumMember(Value = "Message In Group")]
        MessageInGroup,
        [EnumMember(Value = "Last Message In Group")]
        LastMessageInGroup
    }

    public class BrowseMessageGetMessageOptionsType
    {
        [JsonProperty("format")]
        public BrowseMessageGetMessageOptionsTypeFormatType Format { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int WaitIntervalInSeconds { get; set; }

        [JsonProperty("browseLockedTimeoutInSeconds")]
        public int BrowseLockedTimeoutInSeconds { get; set; }
    }

    public enum BrowseMessageGetMessageOptionsTypeFormatType
    {
        String,
        Binary
    }

    public class BrowseBatchOutput
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public BrowseBatchOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class BrowseBatchOutputMessagesTypeItem
    {
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("report")]
        public BrowseBatchOutputMessagesTypeItemReportType Report { get; set; }

        [JsonProperty("messageType")]
        public BrowseBatchOutputMessagesTypeItemMessageTypeType MessageType { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }

        [JsonProperty("encoding")]
        public int Encoding { get; set; }

        [JsonProperty("codePage")]
        public int CodePage { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("priority")]
        public BrowseBatchOutputMessagesTypeItemPriorityType Priority { get; set; }

        [JsonProperty("persistence")]
        public BrowseBatchOutputMessagesTypeItemPersistenceType Persistence { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("userIdentifier")]
        public string UserIdentifier { get; set; }

        [JsonProperty("accountingToken")]
        public string AccountingToken { get; set; }

        [JsonProperty("applicationIdData")]
        public string ApplicationIdData { get; set; }

        [JsonProperty("putApplicationType")]
        public string PutApplicationType { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putDate")]
        public string PutDate { get; set; }

        [JsonProperty("putTime")]
        public string PutTime { get; set; }

        [JsonProperty("applicationOriginData")]
        public string ApplicationOriginData { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("flags")]
        public BrowseBatchOutputMessagesTypeItemFlagsType Flags { get; set; }

        [JsonProperty("originalLength")]
        public int OriginalLength { get; set; }
        public string OriginalConnectionId { get; set; }

        [JsonProperty("originalQueueManagerName")]
        public string OriginalQueueManagerName { get; set; }

        [JsonProperty("originalQueueName")]
        public string OriginalQueueName { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    public enum BrowseBatchOutputMessagesTypeItemReportType
    {
        None,
        [EnumMember(Value = "Pass Message ID")]
        PassMessageId,
        [EnumMember(Value = "Pass Correlator ID")]
        PassCorrelatorId,
        [EnumMember(Value = "Pass Discard and Expiry")]
        PassDiscardAndExpiry,
        [EnumMember(Value = "Discard Message")]
        DiscardMessage
    }

    public enum BrowseBatchOutputMessagesTypeItemMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    public enum BrowseBatchOutputMessagesTypeItemPriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    public enum BrowseBatchOutputMessagesTypeItemPersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    public enum BrowseBatchOutputMessagesTypeItemFlagsType
    {
        None,
        [EnumMember(Value = "Segmentation Inhibited")]
        SegmentationInhibited,
        [EnumMember(Value = "Segmentation Allowed")]
        SegmentationAllowed,
        Segment,
        [EnumMember(Value = "Last Segment")]
        LastSegment,
        [EnumMember(Value = "Message In Group")]
        MessageInGroup,
        [EnumMember(Value = "Last Message In Group")]
        LastMessageInGroup
    }

    public class BrowseBatchGetMessageOptionsType
    {
        [JsonProperty("format")]
        public BrowseBatchGetMessageOptionsTypeFormatType Format { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int MaximumBatchSizeInMB { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int WaitIntervalInSeconds { get; set; }

        [JsonProperty("browseLockedTimeoutInSeconds")]
        public int BrowseLockedTimeoutInSeconds { get; set; }
    }

    public enum BrowseBatchGetMessageOptionsTypeFormatType
    {
        String,
        Binary
    }

    public class ReceiveMessageOutput
    {
        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("message")]
        public ReceiveMessageOutputMessageType Message { get; set; }
    }

    public class ReceiveMessageOutputMessageType
    {
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("report")]
        public ReceiveMessageOutputMessageTypeReportType Report { get; set; }

        [JsonProperty("messageType")]
        public ReceiveMessageOutputMessageTypeMessageTypeType MessageType { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }

        [JsonProperty("encoding")]
        public int Encoding { get; set; }

        [JsonProperty("codePage")]
        public int CodePage { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("priority")]
        public ReceiveMessageOutputMessageTypePriorityType Priority { get; set; }

        [JsonProperty("persistence")]
        public ReceiveMessageOutputMessageTypePersistenceType Persistence { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("userIdentifier")]
        public string UserIdentifier { get; set; }

        [JsonProperty("accountingToken")]
        public string AccountingToken { get; set; }

        [JsonProperty("applicationIdData")]
        public string ApplicationIdData { get; set; }

        [JsonProperty("putApplicationType")]
        public string PutApplicationType { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putDate")]
        public string PutDate { get; set; }

        [JsonProperty("putTime")]
        public string PutTime { get; set; }

        [JsonProperty("applicationOriginData")]
        public string ApplicationOriginData { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("flags")]
        public ReceiveMessageOutputMessageTypeFlagsType Flags { get; set; }

        [JsonProperty("originalLength")]
        public int OriginalLength { get; set; }
        public string OriginalConnectionId { get; set; }

        [JsonProperty("originalQueueManagerName")]
        public string OriginalQueueManagerName { get; set; }

        [JsonProperty("originalQueueName")]
        public string OriginalQueueName { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    public enum ReceiveMessageOutputMessageTypeReportType
    {
        None,
        [EnumMember(Value = "Pass Message ID")]
        PassMessageId,
        [EnumMember(Value = "Pass Correlator ID")]
        PassCorrelatorId,
        [EnumMember(Value = "Pass Discard and Expiry")]
        PassDiscardAndExpiry,
        [EnumMember(Value = "Discard Message")]
        DiscardMessage
    }

    public enum ReceiveMessageOutputMessageTypeMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    public enum ReceiveMessageOutputMessageTypePriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    public enum ReceiveMessageOutputMessageTypePersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    public enum ReceiveMessageOutputMessageTypeFlagsType
    {
        None,
        [EnumMember(Value = "Segmentation Inhibited")]
        SegmentationInhibited,
        [EnumMember(Value = "Segmentation Allowed")]
        SegmentationAllowed,
        Segment,
        [EnumMember(Value = "Last Segment")]
        LastSegment,
        [EnumMember(Value = "Message In Group")]
        MessageInGroup,
        [EnumMember(Value = "Last Message In Group")]
        LastMessageInGroup
    }

    public class ReceiveMessageGetMessageOptionsType
    {
        [JsonProperty("format")]
        public ReceiveMessageGetMessageOptionsTypeFormatType Format { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int WaitIntervalInSeconds { get; set; }
    }

    public enum ReceiveMessageGetMessageOptionsTypeFormatType
    {
        String,
        Binary
    }

    public class ReceiveBatchOutput
    {
        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public ReceiveBatchOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class ReceiveBatchOutputMessagesTypeItem
    {
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("report")]
        public ReceiveBatchOutputMessagesTypeItemReportType Report { get; set; }

        [JsonProperty("messageType")]
        public ReceiveBatchOutputMessagesTypeItemMessageTypeType MessageType { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }

        [JsonProperty("encoding")]
        public int Encoding { get; set; }

        [JsonProperty("codePage")]
        public int CodePage { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("priority")]
        public ReceiveBatchOutputMessagesTypeItemPriorityType Priority { get; set; }

        [JsonProperty("persistence")]
        public ReceiveBatchOutputMessagesTypeItemPersistenceType Persistence { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("userIdentifier")]
        public string UserIdentifier { get; set; }

        [JsonProperty("accountingToken")]
        public string AccountingToken { get; set; }

        [JsonProperty("applicationIdData")]
        public string ApplicationIdData { get; set; }

        [JsonProperty("putApplicationType")]
        public string PutApplicationType { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putDate")]
        public string PutDate { get; set; }

        [JsonProperty("putTime")]
        public string PutTime { get; set; }

        [JsonProperty("applicationOriginData")]
        public string ApplicationOriginData { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("flags")]
        public ReceiveBatchOutputMessagesTypeItemFlagsType Flags { get; set; }

        [JsonProperty("originalLength")]
        public int OriginalLength { get; set; }
        public string OriginalConnectionId { get; set; }

        [JsonProperty("originalQueueManagerName")]
        public string OriginalQueueManagerName { get; set; }

        [JsonProperty("originalQueueName")]
        public string OriginalQueueName { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    public enum ReceiveBatchOutputMessagesTypeItemReportType
    {
        None,
        [EnumMember(Value = "Pass Message ID")]
        PassMessageId,
        [EnumMember(Value = "Pass Correlator ID")]
        PassCorrelatorId,
        [EnumMember(Value = "Pass Discard and Expiry")]
        PassDiscardAndExpiry,
        [EnumMember(Value = "Discard Message")]
        DiscardMessage
    }

    public enum ReceiveBatchOutputMessagesTypeItemMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    public enum ReceiveBatchOutputMessagesTypeItemPriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    public enum ReceiveBatchOutputMessagesTypeItemPersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    public enum ReceiveBatchOutputMessagesTypeItemFlagsType
    {
        None,
        [EnumMember(Value = "Segmentation Inhibited")]
        SegmentationInhibited,
        [EnumMember(Value = "Segmentation Allowed")]
        SegmentationAllowed,
        Segment,
        [EnumMember(Value = "Last Segment")]
        LastSegment,
        [EnumMember(Value = "Message In Group")]
        MessageInGroup,
        [EnumMember(Value = "Last Message In Group")]
        LastMessageInGroup
    }

    public class ReceiveBatchGetMessageOptionsType
    {
        [JsonProperty("format")]
        public ReceiveBatchGetMessageOptionsTypeFormatType Format { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int MaximumBatchSizeInMB { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int WaitIntervalInSeconds { get; set; }
    }

    public enum ReceiveBatchGetMessageOptionsTypeFormatType
    {
        String,
        Binary
    }

    public class SendMessageOutput
    {
        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class SendMessageSendMessageOptionsType
    {
        [JsonProperty("messageItem")]
        public JToken MessageItem { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("messageType")]
        public SendMessageSendMessageOptionsTypeMessageTypeType MessageType { get; set; }

        [JsonProperty("format")]
        public SendMessageSendMessageOptionsTypeFormatType Format { get; set; }

        [JsonProperty("encoding")]
        public int Encoding { get; set; }

        [JsonProperty("codePage")]
        public int CodePage { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("priority")]
        public SendMessageSendMessageOptionsTypePriorityType Priority { get; set; }

        [JsonProperty("persistence")]
        public SendMessageSendMessageOptionsTypePersistenceType Persistence { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("report")]
        public SendMessageSendMessageOptionsTypeReportType Report { get; set; }

        [JsonProperty("flags")]
        public SendMessageSendMessageOptionsTypeFlagsType Flags { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putApplicationType")]
        public SendMessageSendMessageOptionsTypePutApplicationTypeType PutApplicationType { get; set; }

        [JsonProperty("putDateTime")]
        public string PutDateTime { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    public enum SendMessageSendMessageOptionsTypeMessageTypeType
    {
        Request,
        Reply,
        Datagram
    }

    public enum SendMessageSendMessageOptionsTypeFormatType
    {
        String,
        Binary
    }

    public enum SendMessageSendMessageOptionsTypePriorityType
    {
        AsPublished,
        AsParent,
        AsQueueDefined
    }

    public enum SendMessageSendMessageOptionsTypePersistenceType
    {
        Persistent,
        AsQueueDefinition,
        AsParent
    }

    public enum SendMessageSendMessageOptionsTypeReportType
    {
        None,
        PassCorrelator,
        PassMessageId,
        PassDiscardAndExpiry,
        DiscardMessage
    }

    public enum SendMessageSendMessageOptionsTypeFlagsType
    {
        None,
        SegmentationAllowed,
        Segment,
        LastSegment,
        MessageInAGroup,
        LastMessageInAGroup
    }

    public enum SendMessageSendMessageOptionsTypePutApplicationTypeType
    {
        Cics,
        ZOs,
        Ims,
        Os2,
        Dos,
        Unix,
        QueueManager,
        ISeries,
        Windows,
        CiscVse,
        Nt,
        Vms,
        Guardian,
        Vos,
        OpenTp1,
        Vm,
        ImsBridge,
        Xcf,
        CicsBridge,
        NotesAgent,
        Tpf,
        User,
        Broker,
        Java,
        Dqm,
        ChannelInitiator,
        Wlm,
        Batch,
        RrsBatch,
        Sib
    }

    public class SendBatchOutput
    {
        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public JToken[] Messages { get; set; }
    }

    public class SendBatchMessageListTypeItem
    {
        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("format")]
        public SendBatchMessageListTypeItemFormatType Format { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    public enum SendBatchMessageListTypeItemFormatType
    {
        String,
        Binary
    }

    public class SendBatchSendMessageOptionsType
    {
        [JsonProperty("messageType")]
        public SendBatchSendMessageOptionsTypeMessageTypeType MessageType { get; set; }

        [JsonProperty("encoding")]
        public int Encoding { get; set; }

        [JsonProperty("codePage")]
        public int CodePage { get; set; }

        [JsonProperty("persistence")]
        public SendBatchSendMessageOptionsTypePersistenceType Persistence { get; set; }

        [JsonProperty("priority")]
        public SendBatchSendMessageOptionsTypePriorityType Priority { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("report")]
        public SendBatchSendMessageOptionsTypeReportType Report { get; set; }

        [JsonProperty("flags")]
        public SendBatchSendMessageOptionsTypeFlagsType Flags { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putApplicationType")]
        public SendBatchSendMessageOptionsTypePutApplicationTypeType PutApplicationType { get; set; }

        [JsonProperty("putDateTime")]
        public string PutDateTime { get; set; }
    }

    public enum SendBatchSendMessageOptionsTypeMessageTypeType
    {
        Request,
        Reply,
        Datagram
    }

    public enum SendBatchSendMessageOptionsTypePersistenceType
    {
        Persistent,
        AsQueueDefinition,
        AsParent
    }

    public enum SendBatchSendMessageOptionsTypePriorityType
    {
        AsPublished,
        AsParent,
        AsQueueDefined
    }

    public enum SendBatchSendMessageOptionsTypeReportType
    {
        None,
        PassCorrelator,
        PassMessageId,
        PassDiscardAndExpiry,
        DiscardMessage
    }

    public enum SendBatchSendMessageOptionsTypeFlagsType
    {
        None,
        SegmentationAllowed,
        Segment,
        LastSegment,
        MessageInAGroup,
        LastMessageInAGroup
    }

    public enum SendBatchSendMessageOptionsTypePutApplicationTypeType
    {
        Cics,
        ZOs,
        Ims,
        Os2,
        Dos,
        Unix,
        QueueManager,
        ISeries,
        Windows,
        CiscVse,
        Nt,
        Vms,
        Guardian,
        Vos,
        OpenTp1,
        Vm,
        ImsBridge,
        Xcf,
        CicsBridge,
        NotesAgent,
        Tpf,
        User,
        Broker,
        Java,
        Dqm,
        ChannelInitiator,
        Wlm,
        Batch,
        RrsBatch,
        Sib
    }

    public class CompleteMessageOutput
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("message")]
        public CompleteMessageOutputMessageType Message { get; set; }
    }

    public class CompleteMessageOutputMessageType
    {
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public enum CompleteMessageCompleteActionType
    {
        Commit,
        Abort
    }

    public class CompleteBatchOutput
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public CompleteBatchOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class CompleteBatchOutputMessagesTypeItem
    {
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public enum CompleteBatchCompleteActionType
    {
        Commit,
        Abort
    }

    public class MoveMessageToDeadLetterQueueOutput
    {
        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class MoveMessageToDeadLetterQueueSendMessageOptionsType
    {
        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putApplicationType")]
        public MoveMessageToDeadLetterQueueSendMessageOptionsTypePutApplicationTypeType PutApplicationType { get; set; }

        [JsonProperty("putDateTime")]
        public string PutDateTime { get; set; }
    }

    public enum MoveMessageToDeadLetterQueueSendMessageOptionsTypePutApplicationTypeType
    {
        Cics,
        ZOs,
        Ims,
        Os2,
        Dos,
        Unix,
        QueueManager,
        ISeries,
        Windows,
        CiscVse,
        Nt,
        Vms,
        Guardian,
        Vos,
        OpenTp1,
        Vm,
        ImsBridge,
        Xcf,
        CicsBridge,
        NotesAgent,
        Tpf,
        User,
        Broker,
        Java,
        Dqm,
        ChannelInitiator,
        Wlm,
        Batch,
        RrsBatch,
        Sib
    }

    public class PollAvailableOutput
    {
        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class PollBrowseMessagesOutput
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public PollBrowseMessagesOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class PollBrowseMessagesOutputMessagesTypeItem
    {
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("report")]
        public PollBrowseMessagesOutputMessagesTypeItemReportType Report { get; set; }

        [JsonProperty("messageType")]
        public PollBrowseMessagesOutputMessagesTypeItemMessageTypeType MessageType { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }

        [JsonProperty("encoding")]
        public int Encoding { get; set; }

        [JsonProperty("codePage")]
        public int CodePage { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("priority")]
        public PollBrowseMessagesOutputMessagesTypeItemPriorityType Priority { get; set; }

        [JsonProperty("persistence")]
        public PollBrowseMessagesOutputMessagesTypeItemPersistenceType Persistence { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("userIdentifier")]
        public string UserIdentifier { get; set; }

        [JsonProperty("accountingToken")]
        public string AccountingToken { get; set; }

        [JsonProperty("applicationIdData")]
        public string ApplicationIdData { get; set; }

        [JsonProperty("putApplicationType")]
        public string PutApplicationType { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putDate")]
        public string PutDate { get; set; }

        [JsonProperty("putTime")]
        public string PutTime { get; set; }

        [JsonProperty("applicationOriginData")]
        public string ApplicationOriginData { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("flags")]
        public PollBrowseMessagesOutputMessagesTypeItemFlagsType Flags { get; set; }

        [JsonProperty("originalLength")]
        public int OriginalLength { get; set; }
        public string OriginalConnectionId { get; set; }

        [JsonProperty("originalQueueManagerName")]
        public string OriginalQueueManagerName { get; set; }

        [JsonProperty("originalQueueName")]
        public string OriginalQueueName { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    public enum PollBrowseMessagesOutputMessagesTypeItemReportType
    {
        None,
        [EnumMember(Value = "Pass Message ID")]
        PassMessageId,
        [EnumMember(Value = "Pass Correlator ID")]
        PassCorrelatorId,
        [EnumMember(Value = "Pass Discard and Expiry")]
        PassDiscardAndExpiry,
        [EnumMember(Value = "Discard Message")]
        DiscardMessage
    }

    public enum PollBrowseMessagesOutputMessagesTypeItemMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    public enum PollBrowseMessagesOutputMessagesTypeItemPriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    public enum PollBrowseMessagesOutputMessagesTypeItemPersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    public enum PollBrowseMessagesOutputMessagesTypeItemFlagsType
    {
        None,
        [EnumMember(Value = "Segmentation Inhibited")]
        SegmentationInhibited,
        [EnumMember(Value = "Segmentation Allowed")]
        SegmentationAllowed,
        Segment,
        [EnumMember(Value = "Last Segment")]
        LastSegment,
        [EnumMember(Value = "Message In Group")]
        MessageInGroup,
        [EnumMember(Value = "Last Message In Group")]
        LastMessageInGroup
    }

    public class PollBrowseMessagesGetMessageOptionsType
    {
        [JsonProperty("format")]
        public PollBrowseMessagesGetMessageOptionsTypeFormatType Format { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int MaximumBatchSizeInMB { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int WaitIntervalInSeconds { get; set; }

        [JsonProperty("browseLockedTimeoutInSeconds")]
        public int BrowseLockedTimeoutInSeconds { get; set; }

        [JsonProperty("pollingIntervalInSeconds")]
        public int PollingIntervalInSeconds { get; set; }
    }

    public enum PollBrowseMessagesGetMessageOptionsTypeFormatType
    {
        String,
        Binary
    }

    public class PollMessagesOutput
    {
        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("reasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("reasonCodeDescription")]
        public string ReasonCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public PollMessagesOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class PollMessagesOutputMessagesTypeItem
    {
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("report")]
        public PollMessagesOutputMessagesTypeItemReportType Report { get; set; }

        [JsonProperty("messageType")]
        public PollMessagesOutputMessagesTypeItemMessageTypeType MessageType { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }

        [JsonProperty("encoding")]
        public int Encoding { get; set; }

        [JsonProperty("codePage")]
        public int CodePage { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("priority")]
        public PollMessagesOutputMessagesTypeItemPriorityType Priority { get; set; }

        [JsonProperty("persistence")]
        public PollMessagesOutputMessagesTypeItemPersistenceType Persistence { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("userIdentifier")]
        public string UserIdentifier { get; set; }

        [JsonProperty("accountingToken")]
        public string AccountingToken { get; set; }

        [JsonProperty("applicationIdData")]
        public string ApplicationIdData { get; set; }

        [JsonProperty("putApplicationType")]
        public string PutApplicationType { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putDate")]
        public string PutDate { get; set; }

        [JsonProperty("putTime")]
        public string PutTime { get; set; }

        [JsonProperty("applicationOriginData")]
        public string ApplicationOriginData { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("flags")]
        public PollMessagesOutputMessagesTypeItemFlagsType Flags { get; set; }

        [JsonProperty("originalLength")]
        public int OriginalLength { get; set; }
        public string OriginalConnectionId { get; set; }

        [JsonProperty("originalQueueManagerName")]
        public string OriginalQueueManagerName { get; set; }

        [JsonProperty("originalQueueName")]
        public string OriginalQueueName { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    public enum PollMessagesOutputMessagesTypeItemReportType
    {
        None,
        [EnumMember(Value = "Pass Message ID")]
        PassMessageId,
        [EnumMember(Value = "Pass Correlator ID")]
        PassCorrelatorId,
        [EnumMember(Value = "Pass Discard and Expiry")]
        PassDiscardAndExpiry,
        [EnumMember(Value = "Discard Message")]
        DiscardMessage
    }

    public enum PollMessagesOutputMessagesTypeItemMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    public enum PollMessagesOutputMessagesTypeItemPriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    public enum PollMessagesOutputMessagesTypeItemPersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    public enum PollMessagesOutputMessagesTypeItemFlagsType
    {
        None,
        [EnumMember(Value = "Segmentation Inhibited")]
        SegmentationInhibited,
        [EnumMember(Value = "Segmentation Allowed")]
        SegmentationAllowed,
        Segment,
        [EnumMember(Value = "Last Segment")]
        LastSegment,
        [EnumMember(Value = "Message In Group")]
        MessageInGroup,
        [EnumMember(Value = "Last Message In Group")]
        LastMessageInGroup
    }

    public class PollMessagesGetMessageOptionsType
    {
        [JsonProperty("format")]
        public PollMessagesGetMessageOptionsTypeFormatType Format { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int MaximumBatchSizeInMB { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int WaitIntervalInSeconds { get; set; }

        [JsonProperty("maximizeThroughput")]
        public bool MaximizeThroughput { get; set; }
    }

    public enum PollMessagesGetMessageOptionsTypeFormatType
    {
        String,
        Binary
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Mq;

    public partial class WorkflowServiceProviderActions
    {
        public MqActions Mq(string connectionId) => new MqActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public MqTriggers Mq(string connectionId) => new MqTriggers(connectionId);
    }
}