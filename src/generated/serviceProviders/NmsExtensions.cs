//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Nms
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class NmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<PeekLockQueueMessagesActionOutput> PeekLockQueueMessagesAction([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<PeekLockQueueMessagesActionInputGetMessagesOptionsType> getMessagesOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                if (getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = SourceExpressionConverter.ConvertToken(getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockQueueMessagesAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<PeekLockQueueMessagesActionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<PeekLockTopicMessagesActionOutput> PeekLockTopicMessagesAction([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<bool> durable, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<PeekLockTopicMessagesActionInputGetMessagesOptionsType> getMessagesOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                serviceProviderParameters["durable"] = SourceExpressionConverter.ConvertToken(durable);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = SourceExpressionConverter.ConvertToken(getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockTopicMessagesAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<PeekLockTopicMessagesActionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<ReceiveQueueMessagesActionOutput> ReceiveQueueMessagesAction([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<ReceiveQueueMessagesActionInputGetMessagesOptionsType> getMessagesOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                if (getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = SourceExpressionConverter.ConvertToken(getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveQueueMessagesAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ReceiveQueueMessagesActionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<ReceiveTopicMessagesActionOutput> ReceiveTopicMessagesAction([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<bool> durable, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<ReceiveTopicMessagesActionInputGetMessagesOptionsType> getMessagesOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                serviceProviderParameters["durable"] = SourceExpressionConverter.ConvertToken(durable);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = SourceExpressionConverter.ConvertToken(getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveTopicMessagesAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ReceiveTopicMessagesActionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<SendMessageActionOutput> SendMessageAction([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<bool> isTopic, [WorkflowExpression] Func<object> contentData, [WorkflowExpression] Func<SendMessageActionInputContentTypeType> contentType, [WorkflowExpression] Func<SendMessageActionInputSendMessageOptionsType> sendMessageOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                serviceProviderParameters["isTopic"] = SourceExpressionConverter.ConvertToken(isTopic);
                serviceProviderParameters["contentData"] = SourceExpressionConverter.ConvertToken(contentData);
                serviceProviderParameters["contentType"] = SourceExpressionConverter.ConvertToken(contentType);
                if (sendMessageOptions != null)
                {
                    serviceProviderParameters["sendMessageOptions"] = SourceExpressionConverter.ConvertToken(sendMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "sendMessageAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<SendMessageActionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<CheckDestinationAccessActionOutput> CheckDestinationAccessAction([WorkflowExpression] Func<CheckDestinationAccessActionInputDestinationTypeType> destinationType, [WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<bool> brokerDoesNotAutoCreateDestinations)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationType"] = SourceExpressionConverter.ConvertToken(destinationType);
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                serviceProviderParameters["brokerDoesNotAutoCreateDestinations"] = SourceExpressionConverter.ConvertToken(brokerDoesNotAutoCreateDestinations);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "checkDestinationAccessAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CheckDestinationAccessActionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<AcknowledgeSessionActionOutput> AcknowledgeSessionAction([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<AcknowledgeSessionActionInputAcknowledgeActionType> acknowledgeAction)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                serviceProviderParameters["acknowledgeAction"] = SourceExpressionConverter.ConvertToken(acknowledgeAction);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "acknowledgeSessionAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<AcknowledgeSessionActionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<DeleteDurableSubscriptionActionOutput> DeleteDurableSubscriptionAction([WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> clientId = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (clientId != null)
                {
                    serviceProviderParameters["clientId"] = SourceExpressionConverter.ConvertToken(clientId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "deleteDurableSubscriptionAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<DeleteDurableSubscriptionActionOutput>(BuildSourceInput);
        }
    }

    public class NmsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PeekLockQueueMessagesTriggerOutput> PeekLockQueueMessagesTrigger([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<PeekLockQueueMessagesTriggerInputGetMessagesOptionsType> getMessagesOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                if (getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = SourceExpressionConverter.ConvertToken(getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockQueueMessagesTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<PeekLockQueueMessagesTriggerOutput>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<PeekLockTopicMessagesTriggerOutput> PeekLockTopicMessagesTrigger([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<bool> durable, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<PeekLockTopicMessagesTriggerInputGetMessagesOptionsType> getMessagesOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                serviceProviderParameters["durable"] = SourceExpressionConverter.ConvertToken(durable);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = SourceExpressionConverter.ConvertToken(getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockTopicMessagesTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<PeekLockTopicMessagesTriggerOutput>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<ReceiveQueueMessagesTriggerOutput> ReceiveQueueMessagesTrigger([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<ReceiveQueueMessagesTriggerInputGetMessagesOptionsType> getMessagesOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                if (getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = SourceExpressionConverter.ConvertToken(getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveQueueMessagesTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveQueueMessagesTriggerOutput>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<ReceiveTopicMessagesTriggerOutput> ReceiveTopicMessagesTrigger([WorkflowExpression] Func<string> destinationName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<bool> durable, [WorkflowExpression] Func<ReceiveTopicMessagesTriggerInputGetMessagesOptionsType> getMessagesOptions = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["durable"] = SourceExpressionConverter.ConvertToken(durable);
                if (getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = SourceExpressionConverter.ConvertToken(getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveTopicMessagesTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveTopicMessagesTriggerOutput>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<PeekLockActiveMqAdvisoryTopicEventsTriggerOutput> PeekLockActiveMqAdvisoryTopicEventsTrigger([WorkflowExpression] Func<PeekLockActiveMqAdvisoryTopicEventsTriggerInputAdvisoryCategoryType> advisoryCategory, [WorkflowExpression] Func<PeekLockActiveMqAdvisoryTopicEventsTriggerInputDestinationTypeType> destinationType = null, [WorkflowExpression] Func<string> destinationName = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["advisoryCategory"] = SourceExpressionConverter.ConvertToken(advisoryCategory);
                if (destinationType != null)
                {
                    serviceProviderParameters["destinationType"] = SourceExpressionConverter.ConvertToken(destinationType);
                }

                if (destinationName != null)
                {
                    serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockActiveMqAdvisoryTopicEventsTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<PeekLockActiveMqAdvisoryTopicEventsTriggerOutput>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<ReceiveActiveMqAdvisoryTopicEventsTriggerOutput> ReceiveActiveMqAdvisoryTopicEventsTrigger([WorkflowExpression] Func<ReceiveActiveMqAdvisoryTopicEventsTriggerInputAdvisoryCategoryType> advisoryCategory, [WorkflowExpression] Func<ReceiveActiveMqAdvisoryTopicEventsTriggerInputDestinationTypeType> destinationType = null, [WorkflowExpression] Func<string> destinationName = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["advisoryCategory"] = SourceExpressionConverter.ConvertToken(advisoryCategory);
                if (destinationType != null)
                {
                    serviceProviderParameters["destinationType"] = SourceExpressionConverter.ConvertToken(destinationType);
                }

                if (destinationName != null)
                {
                    serviceProviderParameters["destinationName"] = SourceExpressionConverter.ConvertToken(destinationName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveActiveMqAdvisoryTopicEventsTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveActiveMqAdvisoryTopicEventsTriggerOutput>(BuildSourceInput);
        }
    }

    public class PeekLockQueueMessagesActionOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public PeekLockQueueMessagesActionOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class PeekLockQueueMessagesActionOutputMessagesTypeItem
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("deliveryMode")]
        public string DeliveryMode { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    public class PeekLockQueueMessagesActionInputGetMessagesOptionsType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }
    }

    public class PeekLockTopicMessagesActionOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public PeekLockTopicMessagesActionOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class PeekLockTopicMessagesActionOutputMessagesTypeItem
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("deliveryMode")]
        public string DeliveryMode { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    public class PeekLockTopicMessagesActionInputGetMessagesOptionsType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }
    }

    public class ReceiveQueueMessagesActionOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public ReceiveQueueMessagesActionOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class ReceiveQueueMessagesActionOutputMessagesTypeItem
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("deliveryMode")]
        public string DeliveryMode { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    public class ReceiveQueueMessagesActionInputGetMessagesOptionsType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }
    }

    public class ReceiveTopicMessagesActionOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public ReceiveTopicMessagesActionOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class ReceiveTopicMessagesActionOutputMessagesTypeItem
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("deliveryMode")]
        public string DeliveryMode { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    public class ReceiveTopicMessagesActionInputGetMessagesOptionsType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }
    }

    public class SendMessageActionOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageActionInputContentTypeType
    {
        Text,
        Bytes
    }

    public class SendMessageActionInputSendMessageOptionsType
    {
        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("deliveryMode")]
        public SendMessageActionInputSendMessageOptionsTypeDeliveryModeType? DeliveryMode { get; set; }

        [JsonProperty("priority")]
        public SendMessageActionInputSendMessageOptionsTypePriorityType? Priority { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("timeToLive")]
        public int? TimeToLive { get; set; }

        [JsonProperty("replyToDestination")]
        public string ReplyToDestination { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageActionInputSendMessageOptionsTypeDeliveryModeType
    {
        Persistent,
        NonPersistent
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendMessageActionInputSendMessageOptionsTypePriorityType
    {
        VeryLow,
        Low,
        AboveLow,
        BelowNormal,
        Normal,
        AboveNormal,
        High,
        VeryHigh,
        Highest
    }

    public class CheckDestinationAccessActionOutput
    {
        [JsonProperty("destinationType")]
        public string DestinationType { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("statusCode")]
        public CheckDestinationAccessActionOutputStatusCodeType StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("probeMethod")]
        public CheckDestinationAccessActionOutputProbeMethodType ProbeMethod { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckDestinationAccessActionOutputStatusCodeType
    {
        Accessible
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckDestinationAccessActionOutputProbeMethodType
    {
        QueueBrowse
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckDestinationAccessActionInputDestinationTypeType
    {
        Queue,
        Topic
    }

    public class AcknowledgeSessionActionOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcknowledgeSessionActionInputAcknowledgeActionType
    {
        Commit,
        Abort
    }

    public class DeleteDurableSubscriptionActionOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class PeekLockQueueMessagesTriggerOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public PeekLockQueueMessagesTriggerOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class PeekLockQueueMessagesTriggerOutputMessagesTypeItem
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("deliveryMode")]
        public string DeliveryMode { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    public class PeekLockQueueMessagesTriggerInputGetMessagesOptionsType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }
    }

    public class PeekLockTopicMessagesTriggerOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public PeekLockTopicMessagesTriggerOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class PeekLockTopicMessagesTriggerOutputMessagesTypeItem
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("deliveryMode")]
        public string DeliveryMode { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    public class PeekLockTopicMessagesTriggerInputGetMessagesOptionsType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }
    }

    public class ReceiveQueueMessagesTriggerOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public ReceiveQueueMessagesTriggerOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class ReceiveQueueMessagesTriggerOutputMessagesTypeItem
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("deliveryMode")]
        public string DeliveryMode { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    public class ReceiveQueueMessagesTriggerInputGetMessagesOptionsType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }
    }

    public class ReceiveTopicMessagesTriggerOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public ReceiveTopicMessagesTriggerOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class ReceiveTopicMessagesTriggerOutputMessagesTypeItem
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("deliveryMode")]
        public string DeliveryMode { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("customProperties")]
        public JToken CustomProperties { get; set; }
    }

    public class ReceiveTopicMessagesTriggerInputGetMessagesOptionsType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("typeHeader")]
        public string TypeHeader { get; set; }

        [JsonProperty("maximumMessagesInBatch")]
        public int? MaximumMessagesInBatch { get; set; }

        [JsonProperty("maximumBatchSizeInMB")]
        public int? MaximumBatchSizeInMB { get; set; }
    }

    public class PeekLockActiveMqAdvisoryTopicEventsTriggerOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItem
    {
        [JsonProperty("advisory")]
        public PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryType Advisory { get; set; }
    }

    public class PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryType
    {
        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("subjectId")]
        public string SubjectId { get; set; }

        [JsonProperty("category")]
        public PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeCategoryType Category { get; set; }

        [JsonProperty("action")]
        public PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeActionType Action { get; set; }

        [JsonProperty("destinationType")]
        public PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeDestinationTypeType DestinationType { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("producerCount")]
        public int ProducerCount { get; set; }

        [JsonProperty("consumerCount")]
        public int ConsumerCount { get; set; }

        [JsonProperty("observedAt")]
        public string ObservedAt { get; set; }

        [JsonProperty("sourceTimestamp")]
        public string SourceTimestamp { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeCategoryType
    {
        Connection,
        Producer,
        Consumer,
        Destination,
        NoConsumer
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeActionType
    {
        Started,
        Stopped,
        Created,
        Destroyed,
        Detected
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeekLockActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeDestinationTypeType
    {
        Queue,
        Topic
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeekLockActiveMqAdvisoryTopicEventsTriggerInputAdvisoryCategoryType
    {
        Connection,
        Producer,
        Consumer,
        Destination,
        NoConsumer
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeekLockActiveMqAdvisoryTopicEventsTriggerInputDestinationTypeType
    {
        Queue,
        Topic
    }

    public class ReceiveActiveMqAdvisoryTopicEventsTriggerOutput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusCodeDescription")]
        public string StatusCodeDescription { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("messages")]
        public ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItem[] Messages { get; set; }
    }

    public class ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItem
    {
        [JsonProperty("advisory")]
        public ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryType Advisory { get; set; }
    }

    public class ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryType
    {
        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("subjectId")]
        public string SubjectId { get; set; }

        [JsonProperty("category")]
        public ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeCategoryType Category { get; set; }

        [JsonProperty("action")]
        public ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeActionType Action { get; set; }

        [JsonProperty("destinationType")]
        public ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeDestinationTypeType DestinationType { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("producerCount")]
        public int ProducerCount { get; set; }

        [JsonProperty("consumerCount")]
        public int ConsumerCount { get; set; }

        [JsonProperty("observedAt")]
        public string ObservedAt { get; set; }

        [JsonProperty("sourceTimestamp")]
        public string SourceTimestamp { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeCategoryType
    {
        Connection,
        Producer,
        Consumer,
        Destination,
        NoConsumer
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeActionType
    {
        Started,
        Stopped,
        Created,
        Destroyed,
        Detected
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveActiveMqAdvisoryTopicEventsTriggerOutputMessagesTypeItemAdvisoryTypeDestinationTypeType
    {
        Queue,
        Topic
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveActiveMqAdvisoryTopicEventsTriggerInputAdvisoryCategoryType
    {
        Connection,
        Producer,
        Consumer,
        Destination,
        NoConsumer
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveActiveMqAdvisoryTopicEventsTriggerInputDestinationTypeType
    {
        Queue,
        Topic
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Nms;

    public partial class WorkflowServiceProviderActions
    {
        public NmsActions Nms(string connectionId) => new NmsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public NmsTriggers Nms(string connectionId) => new NmsTriggers(connectionId);
    }
}