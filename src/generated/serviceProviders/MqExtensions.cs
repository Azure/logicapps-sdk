//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Mq
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class MqActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildBrowseMessage))]
        public IBodyWorkflowAction<BrowseMessageOutput> BrowseMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> includeInfo, [WorkflowExpression] Func<BrowseMessageInputGetMessageOptionsType> getMessageOptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowseMessageOutput> __BuildBrowseMessage(WorkflowExpression<string> queueName, WorkflowExpression<bool> includeInfo, WorkflowExpression<BrowseMessageInputGetMessageOptionsType> getMessageOptions = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(includeInfo, nameof(includeInfo), required: true);
            WorkflowExpression.Validate(getMessageOptions, nameof(getMessageOptions), required: false);
            return new DeferredBodyAction<BrowseMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
                if (getMessageOptions != null)
                {
                    serviceProviderParameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "browseMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<BrowseMessageOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildBrowseBatch))]
        public IBodyWorkflowAction<BrowseBatchOutput> BrowseBatch([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> includeInfo, [WorkflowExpression] Func<BrowseBatchInputGetMessageOptionsType> getMessageOptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowseBatchOutput> __BuildBrowseBatch(WorkflowExpression<string> queueName, WorkflowExpression<bool> includeInfo, WorkflowExpression<BrowseBatchInputGetMessageOptionsType> getMessageOptions = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(includeInfo, nameof(includeInfo), required: true);
            WorkflowExpression.Validate(getMessageOptions, nameof(getMessageOptions), required: false);
            return new DeferredBodyAction<BrowseBatchOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
                if (getMessageOptions != null)
                {
                    serviceProviderParameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "browseBatch", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<BrowseBatchOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildReceiveMessage))]
        public IBodyWorkflowAction<ReceiveMessageOutput> ReceiveMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> includeInfo, [WorkflowExpression] Func<ReceiveMessageInputGetMessageOptionsType> getMessageOptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReceiveMessageOutput> __BuildReceiveMessage(WorkflowExpression<string> queueName, WorkflowExpression<bool> includeInfo, WorkflowExpression<ReceiveMessageInputGetMessageOptionsType> getMessageOptions = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(includeInfo, nameof(includeInfo), required: true);
            WorkflowExpression.Validate(getMessageOptions, nameof(getMessageOptions), required: false);
            return new DeferredBodyAction<ReceiveMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
                if (getMessageOptions != null)
                {
                    serviceProviderParameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "receiveMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ReceiveMessageOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildReceiveBatch))]
        public IBodyWorkflowAction<ReceiveBatchOutput> ReceiveBatch([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> includeInfo, [WorkflowExpression] Func<ReceiveBatchInputGetMessageOptionsType> getMessageOptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReceiveBatchOutput> __BuildReceiveBatch(WorkflowExpression<string> queueName, WorkflowExpression<bool> includeInfo, WorkflowExpression<ReceiveBatchInputGetMessageOptionsType> getMessageOptions = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(includeInfo, nameof(includeInfo), required: true);
            WorkflowExpression.Validate(getMessageOptions, nameof(getMessageOptions), required: false);
            return new DeferredBodyAction<ReceiveBatchOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
                if (getMessageOptions != null)
                {
                    serviceProviderParameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "receiveBatch", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ReceiveBatchOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageOutput> SendMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<SendMessageInputSendMessageOptionsType> sendMessageOptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageOutput> __BuildSendMessage(WorkflowExpression<string> queueName, WorkflowExpression<string> message, WorkflowExpression<SendMessageInputSendMessageOptionsType> sendMessageOptions = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: true);
            WorkflowExpression.Validate(sendMessageOptions, nameof(sendMessageOptions), required: false);
            return new DeferredBodyAction<SendMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["message"] = ExpressionConverter.ConvertO(message);
                if (sendMessageOptions != null)
                {
                    serviceProviderParameters["sendMessageOptions"] = ExpressionConverter.ConvertO(sendMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "sendMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<SendMessageOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildSendBatch))]
        public IBodyWorkflowAction<SendBatchOutput> SendBatch([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<SendBatchInputMessageListTypeItem[]> messageList, [WorkflowExpression] Func<SendBatchInputSendMessageOptionsType> sendMessageOptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendBatchOutput> __BuildSendBatch(WorkflowExpression<string> queueName, WorkflowExpression<SendBatchInputMessageListTypeItem[]> messageList, WorkflowExpression<SendBatchInputSendMessageOptionsType> sendMessageOptions = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(messageList, nameof(messageList), required: true);
            WorkflowExpression.Validate(sendMessageOptions, nameof(sendMessageOptions), required: false);
            return new DeferredBodyAction<SendBatchOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["messageList"] = ExpressionConverter.ConvertO(messageList);
                if (sendMessageOptions != null)
                {
                    serviceProviderParameters["sendMessageOptions"] = ExpressionConverter.ConvertO(sendMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "sendBatch", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<SendBatchOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteMessage))]
        public IBodyWorkflowAction<CompleteMessageOutput> CompleteMessage([WorkflowExpression] Func<string> operationConnectionId, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> uniqueId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<CompleteMessageInputCompleteActionType> completeAction)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompleteMessageOutput> __BuildCompleteMessage(WorkflowExpression<string> operationConnectionId, WorkflowExpression<string> queueName, WorkflowExpression<string> uniqueId, WorkflowExpression<string> messageId, WorkflowExpression<CompleteMessageInputCompleteActionType> completeAction)
        {
            WorkflowExpression.Validate(operationConnectionId, nameof(operationConnectionId), required: true);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(uniqueId, nameof(uniqueId), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(completeAction, nameof(completeAction), required: true);
            return new DeferredBodyAction<CompleteMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["connectionId"] = ExpressionConverter.ConvertO(operationConnectionId);
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["uniqueId"] = ExpressionConverter.ConvertO(uniqueId);
                serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(messageId);
                serviceProviderParameters["completeAction"] = ExpressionConverter.ConvertO(completeAction);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "completeMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CompleteMessageOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteBatch))]
        public IBodyWorkflowAction<CompleteBatchOutput> CompleteBatch([WorkflowExpression] Func<string> operationConnectionId, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<CompleteBatchInputCompleteActionType> completeAction)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompleteBatchOutput> __BuildCompleteBatch(WorkflowExpression<string> operationConnectionId, WorkflowExpression<string> queueName, WorkflowExpression<CompleteBatchInputCompleteActionType> completeAction)
        {
            WorkflowExpression.Validate(operationConnectionId, nameof(operationConnectionId), required: true);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(completeAction, nameof(completeAction), required: true);
            return new DeferredBodyAction<CompleteBatchOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["connectionId"] = ExpressionConverter.ConvertO(operationConnectionId);
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["completeAction"] = ExpressionConverter.ConvertO(completeAction);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "completeBatch", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CompleteBatchOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildMoveMessageToDeadLetterQueue))]
        public IBodyWorkflowAction<MoveMessageToDeadLetterQueueOutput> MoveMessageToDeadLetterQueue([WorkflowExpression] Func<object> message, [WorkflowExpression] Func<int> reasonCode, [WorkflowExpression] Func<string> deadLetterQueueName = null, [WorkflowExpression] Func<MoveMessageToDeadLetterQueueInputSendMessageOptionsType> sendMessageOptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MoveMessageToDeadLetterQueueOutput> __BuildMoveMessageToDeadLetterQueue(WorkflowExpression<object> message, WorkflowExpression<int> reasonCode, WorkflowExpression<string> deadLetterQueueName = null, WorkflowExpression<MoveMessageToDeadLetterQueueInputSendMessageOptionsType> sendMessageOptions = null)
        {
            WorkflowExpression.Validate(message, nameof(message), required: true);
            WorkflowExpression.Validate(reasonCode, nameof(reasonCode), required: true);
            WorkflowExpression.Validate(deadLetterQueueName, nameof(deadLetterQueueName), required: false);
            WorkflowExpression.Validate(sendMessageOptions, nameof(sendMessageOptions), required: false);
            return new DeferredBodyAction<MoveMessageToDeadLetterQueueOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["message"] = ExpressionConverter.ConvertO(message);
                serviceProviderParameters["reasonCode"] = ExpressionConverter.ConvertO(reasonCode);
                if (deadLetterQueueName != null)
                {
                    serviceProviderParameters["deadLetterQueueName"] = ExpressionConverter.ConvertO(deadLetterQueueName);
                }

                if (sendMessageOptions != null)
                {
                    serviceProviderParameters["sendMessageOptions"] = ExpressionConverter.ConvertO(sendMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "moveMessageToDeadLetterQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<MoveMessageToDeadLetterQueueOutput>(serviceProviderInput);
            });
        }
    }

    public class MqTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildPollAvailable))]
        public IBodyWorkflowTrigger<PollAvailableOutput> PollAvailable([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> waitIntervalInSeconds = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollAvailableOutput> __BuildPollAvailable(WorkflowExpression<string> queueName, WorkflowExpression<int> waitIntervalInSeconds = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(waitIntervalInSeconds, nameof(waitIntervalInSeconds), required: false);
            return new DeferredBodyTrigger<PollAvailableOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                if (waitIntervalInSeconds != null)
                {
                    serviceProviderParameters["waitIntervalInSeconds"] = ExpressionConverter.ConvertO(waitIntervalInSeconds);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "pollAvailable", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<PollAvailableOutput>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildPollBrowseMessages))]
        public IBodyWorkflowTrigger<PollBrowseMessagesOutput> PollBrowseMessages([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> includeInfo, [WorkflowExpression] Func<PollBrowseMessagesInputGetMessageOptionsType> getMessageOptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollBrowseMessagesOutput> __BuildPollBrowseMessages(WorkflowExpression<string> queueName, WorkflowExpression<bool> includeInfo, WorkflowExpression<PollBrowseMessagesInputGetMessageOptionsType> getMessageOptions = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(includeInfo, nameof(includeInfo), required: true);
            WorkflowExpression.Validate(getMessageOptions, nameof(getMessageOptions), required: false);
            return new DeferredBodyTrigger<PollBrowseMessagesOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
                if (getMessageOptions != null)
                {
                    serviceProviderParameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "pollBrowseMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<PollBrowseMessagesOutput>(serviceProviderInput);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildPollMessages))]
        public IBodyWorkflowTrigger<PollMessagesOutput> PollMessages([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> includeInfo, [WorkflowExpression] Func<PollMessagesInputGetMessageOptionsType> getMessageOptions = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollMessagesOutput> __BuildPollMessages(WorkflowExpression<string> queueName, WorkflowExpression<bool> includeInfo, WorkflowExpression<PollMessagesInputGetMessageOptionsType> getMessageOptions = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(includeInfo, nameof(includeInfo), required: true);
            WorkflowExpression.Validate(getMessageOptions, nameof(getMessageOptions), required: false);
            return new DeferredBodyTrigger<PollMessagesOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["includeInfo"] = ExpressionConverter.ConvertO(includeInfo);
                if (getMessageOptions != null)
                {
                    serviceProviderParameters["getMessageOptions"] = ExpressionConverter.ConvertO(getMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mq", operationId: "pollMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<PollMessagesOutput>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }
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

    [JsonConverter(typeof(StringEnumConverter))]
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PollBrowseMessagesOutputMessagesTypeItemMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PollBrowseMessagesOutputMessagesTypeItemPriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PollBrowseMessagesOutputMessagesTypeItemPersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    [JsonConverter(typeof(StringEnumConverter))]
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

    public class PollBrowseMessagesInputGetMessageOptionsType
    {
        [JsonProperty("format")]
        public PollBrowseMessagesInputGetMessageOptionsTypeFormatType? Format { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int? WaitIntervalInSeconds { get; set; }

        [JsonProperty("browseLockedTimeoutInSeconds")]
        public int? BrowseLockedTimeoutInSeconds { get; set; }

        [JsonProperty("pollingIntervalInSeconds")]
        public int? PollingIntervalInSeconds { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PollBrowseMessagesInputGetMessageOptionsTypeFormatType
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

    [JsonConverter(typeof(StringEnumConverter))]
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PollMessagesOutputMessagesTypeItemMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PollMessagesOutputMessagesTypeItemPriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PollMessagesOutputMessagesTypeItemPersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    [JsonConverter(typeof(StringEnumConverter))]
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

    public class PollMessagesInputGetMessageOptionsType
    {
        [JsonProperty("format")]
        public PollMessagesInputGetMessageOptionsTypeFormatType? Format { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int? WaitIntervalInSeconds { get; set; }

        [JsonProperty("maximizeThroughput")]
        public bool? MaximizeThroughput { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PollMessagesInputGetMessageOptionsTypeFormatType
    {
        String,
        Binary
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

    [JsonConverter(typeof(StringEnumConverter))]
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseMessageOutputMessageTypeMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseMessageOutputMessageTypePriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseMessageOutputMessageTypePersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    [JsonConverter(typeof(StringEnumConverter))]
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

    public class BrowseMessageInputGetMessageOptionsType
    {
        [JsonProperty("format")]
        public BrowseMessageInputGetMessageOptionsTypeFormatType? Format { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int? WaitIntervalInSeconds { get; set; }

        [JsonProperty("browseLockedTimeoutInSeconds")]
        public int? BrowseLockedTimeoutInSeconds { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseMessageInputGetMessageOptionsTypeFormatType
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

    [JsonConverter(typeof(StringEnumConverter))]
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseBatchOutputMessagesTypeItemMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseBatchOutputMessagesTypeItemPriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseBatchOutputMessagesTypeItemPersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    [JsonConverter(typeof(StringEnumConverter))]
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

    public class BrowseBatchInputGetMessageOptionsType
    {
        [JsonProperty("format")]
        public BrowseBatchInputGetMessageOptionsTypeFormatType? Format { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int? WaitIntervalInSeconds { get; set; }

        [JsonProperty("browseLockedTimeoutInSeconds")]
        public int? BrowseLockedTimeoutInSeconds { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseBatchInputGetMessageOptionsTypeFormatType
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

    [JsonConverter(typeof(StringEnumConverter))]
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveMessageOutputMessageTypeMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveMessageOutputMessageTypePriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveMessageOutputMessageTypePersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    [JsonConverter(typeof(StringEnumConverter))]
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

    public class ReceiveMessageInputGetMessageOptionsType
    {
        [JsonProperty("format")]
        public ReceiveMessageInputGetMessageOptionsTypeFormatType? Format { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int? WaitIntervalInSeconds { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveMessageInputGetMessageOptionsTypeFormatType
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

    [JsonConverter(typeof(StringEnumConverter))]
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveBatchOutputMessagesTypeItemMessageTypeType
    {
        Datagram,
        Request,
        Reply
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveBatchOutputMessagesTypeItemPriorityType
    {
        [EnumMember(Value = "As Published")]
        AsPublished,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined,
        [EnumMember(Value = "As Parent")]
        AsParent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveBatchOutputMessagesTypeItemPersistenceType
    {
        None,
        Persistent,
        [EnumMember(Value = "As Queue Defined")]
        AsQueueDefined
    }

    [JsonConverter(typeof(StringEnumConverter))]
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

    public class ReceiveBatchInputGetMessageOptionsType
    {
        [JsonProperty("format")]
        public ReceiveBatchInputGetMessageOptionsTypeFormatType? Format { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }

        [JsonProperty("waitIntervalInSeconds")]
        public int? WaitIntervalInSeconds { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveBatchInputGetMessageOptionsTypeFormatType
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

    public class SendMessageInputSendMessageOptionsType
    {
        [JsonProperty("messageItem")]
        public JToken MessageItem { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("messageType")]
        public SendMessageInputSendMessageOptionsTypeMessageTypeType? MessageType { get; set; }

        [JsonProperty("format")]
        public SendMessageInputSendMessageOptionsTypeFormatType? Format { get; set; }

        [JsonProperty("encoding")]
        public int? Encoding { get; set; }

        [JsonProperty("codePage")]
        public int? CodePage { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("priority")]
        public SendMessageInputSendMessageOptionsTypePriorityType? Priority { get; set; }

        [JsonProperty("persistence")]
        public SendMessageInputSendMessageOptionsTypePersistenceType? Persistence { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("report")]
        public SendMessageInputSendMessageOptionsTypeReportType? Report { get; set; }

        [JsonProperty("flags")]
        public SendMessageInputSendMessageOptionsTypeFlagsType? Flags { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putApplicationType")]
        public SendMessageInputSendMessageOptionsTypePutApplicationTypeType? PutApplicationType { get; set; }

        [JsonProperty("putDateTime")]
        public string PutDateTime { get; set; }

        [JsonProperty("cicsBridgeHeader")]
        public JToken CicsBridgeHeader { get; set; }

        [JsonProperty("imsBridgeHeader")]
        public JToken ImsBridgeHeader { get; set; }

        [JsonProperty("ruleAndFormattingVersion2Header")]
        public JToken RuleAndFormattingVersion2Header { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageInputSendMessageOptionsTypeMessageTypeType
    {
        Request,
        Reply,
        Datagram
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageInputSendMessageOptionsTypeFormatType
    {
        String,
        Binary
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageInputSendMessageOptionsTypePriorityType
    {
        AsPublished,
        AsParent,
        AsQueueDefined
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageInputSendMessageOptionsTypePersistenceType
    {
        Persistent,
        AsQueueDefinition,
        AsParent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageInputSendMessageOptionsTypeReportType
    {
        None,
        PassCorrelator,
        PassMessageId,
        PassDiscardAndExpiry,
        DiscardMessage
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageInputSendMessageOptionsTypeFlagsType
    {
        None,
        SegmentationAllowed,
        Segment,
        LastSegment,
        MessageInAGroup,
        LastMessageInAGroup
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageInputSendMessageOptionsTypePutApplicationTypeType
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

    public class SendBatchInputMessageListTypeItem
    {
        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("binaryContentData")]
        public JToken BinaryContentData { get; set; }

        [JsonProperty("format")]
        public SendBatchInputMessageListTypeItemFormatType? Format { get; set; }

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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendBatchInputMessageListTypeItemFormatType
    {
        String,
        Binary
    }

    public class SendBatchInputSendMessageOptionsType
    {
        [JsonProperty("messageType")]
        public SendBatchInputSendMessageOptionsTypeMessageTypeType? MessageType { get; set; }

        [JsonProperty("encoding")]
        public int? Encoding { get; set; }

        [JsonProperty("codePage")]
        public int? CodePage { get; set; }

        [JsonProperty("persistence")]
        public SendBatchInputSendMessageOptionsTypePersistenceType? Persistence { get; set; }

        [JsonProperty("priority")]
        public SendBatchInputSendMessageOptionsTypePriorityType? Priority { get; set; }

        [JsonProperty("replyToQueue")]
        public string ReplyToQueue { get; set; }

        [JsonProperty("replyToQueueManager")]
        public string ReplyToQueueManager { get; set; }

        [JsonProperty("report")]
        public SendBatchInputSendMessageOptionsTypeReportType? Report { get; set; }

        [JsonProperty("flags")]
        public SendBatchInputSendMessageOptionsTypeFlagsType? Flags { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putApplicationType")]
        public SendBatchInputSendMessageOptionsTypePutApplicationTypeType? PutApplicationType { get; set; }

        [JsonProperty("putDateTime")]
        public string PutDateTime { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendBatchInputSendMessageOptionsTypeMessageTypeType
    {
        Request,
        Reply,
        Datagram
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendBatchInputSendMessageOptionsTypePersistenceType
    {
        Persistent,
        AsQueueDefinition,
        AsParent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendBatchInputSendMessageOptionsTypePriorityType
    {
        AsPublished,
        AsParent,
        AsQueueDefined
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendBatchInputSendMessageOptionsTypeReportType
    {
        None,
        PassCorrelator,
        PassMessageId,
        PassDiscardAndExpiry,
        DiscardMessage
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendBatchInputSendMessageOptionsTypeFlagsType
    {
        None,
        SegmentationAllowed,
        Segment,
        LastSegment,
        MessageInAGroup,
        LastMessageInAGroup
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendBatchInputSendMessageOptionsTypePutApplicationTypeType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompleteMessageInputCompleteActionType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompleteBatchInputCompleteActionType
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

    public class MoveMessageToDeadLetterQueueInputSendMessageOptionsType
    {
        [JsonProperty("putApplicationName")]
        public string PutApplicationName { get; set; }

        [JsonProperty("putApplicationType", DefaultValueHandling = DefaultValueHandling.Include)]
        [System.ComponentModel.DefaultValue(MoveMessageToDeadLetterQueueInputSendMessageOptionsTypePutApplicationTypeType.NoContext)]
        public MoveMessageToDeadLetterQueueInputSendMessageOptionsTypePutApplicationTypeType? PutApplicationType { get; set; } = MoveMessageToDeadLetterQueueInputSendMessageOptionsTypePutApplicationTypeType.NoContext;

        [JsonProperty("putDateTime")]
        public string PutDateTime { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MoveMessageToDeadLetterQueueInputSendMessageOptionsTypePutApplicationTypeType
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
        Sib,
        NoContext
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