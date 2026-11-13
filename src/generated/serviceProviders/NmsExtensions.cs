//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Nms
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class NmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<PeekLockQueueMessagesActionOutput, PeekLockQueueMessagesActionActionConfiguration> PeekLockQueueMessagesAction(Expression<Func<string>> destinationName, Expression<Func<PeekLockQueueMessagesActionInputGetMessagesOptionsType>> getMessagesOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_getMessagesOptions = WorkflowExpression.Compile(getMessagesOptions, nameof(getMessagesOptions), required: false);
            return new DeferredBodyAction<PeekLockQueueMessagesActionOutput, PeekLockQueueMessagesActionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                if (__workflow_getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = ExpressionConverter.ConvertO(__workflow_getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockQueueMessagesAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<PeekLockQueueMessagesActionOutput, PeekLockQueueMessagesActionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<PeekLockTopicMessagesActionOutput, PeekLockTopicMessagesActionActionConfiguration> PeekLockTopicMessagesAction(Expression<Func<string>> destinationName, Expression<Func<bool>> durable, Expression<Func<string>> subscriptionName, Expression<Func<PeekLockTopicMessagesActionInputGetMessagesOptionsType>> getMessagesOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_durable = WorkflowExpression.Compile(durable, nameof(durable), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_getMessagesOptions = WorkflowExpression.Compile(getMessagesOptions, nameof(getMessagesOptions), required: false);
            return new DeferredBodyAction<PeekLockTopicMessagesActionOutput, PeekLockTopicMessagesActionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                serviceProviderParameters["durable"] = ExpressionConverter.ConvertO(__workflow_durable);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = ExpressionConverter.ConvertO(__workflow_getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockTopicMessagesAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<PeekLockTopicMessagesActionOutput, PeekLockTopicMessagesActionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<ReceiveQueueMessagesActionOutput, ReceiveQueueMessagesActionActionConfiguration> ReceiveQueueMessagesAction(Expression<Func<string>> destinationName, Expression<Func<ReceiveQueueMessagesActionInputGetMessagesOptionsType>> getMessagesOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_getMessagesOptions = WorkflowExpression.Compile(getMessagesOptions, nameof(getMessagesOptions), required: false);
            return new DeferredBodyAction<ReceiveQueueMessagesActionOutput, ReceiveQueueMessagesActionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                if (__workflow_getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = ExpressionConverter.ConvertO(__workflow_getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveQueueMessagesAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<ReceiveQueueMessagesActionOutput, ReceiveQueueMessagesActionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<ReceiveTopicMessagesActionOutput, ReceiveTopicMessagesActionActionConfiguration> ReceiveTopicMessagesAction(Expression<Func<string>> destinationName, Expression<Func<bool>> durable, Expression<Func<string>> subscriptionName, Expression<Func<ReceiveTopicMessagesActionInputGetMessagesOptionsType>> getMessagesOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_durable = WorkflowExpression.Compile(durable, nameof(durable), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_getMessagesOptions = WorkflowExpression.Compile(getMessagesOptions, nameof(getMessagesOptions), required: false);
            return new DeferredBodyAction<ReceiveTopicMessagesActionOutput, ReceiveTopicMessagesActionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                serviceProviderParameters["durable"] = ExpressionConverter.ConvertO(__workflow_durable);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = ExpressionConverter.ConvertO(__workflow_getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveTopicMessagesAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<ReceiveTopicMessagesActionOutput, ReceiveTopicMessagesActionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<SendMessageActionOutput, SendMessageActionActionConfiguration> SendMessageAction(Expression<Func<string>> destinationName, Expression<Func<bool>> isTopic, Expression<Func<object>> contentData, Expression<Func<SendMessageActionInputContentTypeType>> contentType, Expression<Func<SendMessageActionInputSendMessageOptionsType>> sendMessageOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_isTopic = WorkflowExpression.Compile(isTopic, nameof(isTopic), required: true);
            var __workflow_contentData = WorkflowExpression.Compile(contentData, nameof(contentData), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_sendMessageOptions = WorkflowExpression.Compile(sendMessageOptions, nameof(sendMessageOptions), required: false);
            return new DeferredBodyAction<SendMessageActionOutput, SendMessageActionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                serviceProviderParameters["isTopic"] = ExpressionConverter.ConvertO(__workflow_isTopic);
                serviceProviderParameters["contentData"] = ExpressionConverter.ConvertO(__workflow_contentData);
                serviceProviderParameters["contentType"] = ExpressionConverter.ConvertO(__workflow_contentType);
                if (__workflow_sendMessageOptions != null)
                {
                    serviceProviderParameters["sendMessageOptions"] = ExpressionConverter.ConvertO(__workflow_sendMessageOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "sendMessageAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<SendMessageActionOutput, SendMessageActionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<CheckDestinationAccessActionOutput, CheckDestinationAccessActionActionConfiguration> CheckDestinationAccessAction(Expression<Func<CheckDestinationAccessActionInputDestinationTypeType>> destinationType, Expression<Func<string>> destinationName, Expression<Func<bool>> brokerDoesNotAutoCreateDestinations)
        {
            var __workflow_destinationType = WorkflowExpression.Compile(destinationType, nameof(destinationType), required: true);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_brokerDoesNotAutoCreateDestinations = WorkflowExpression.Compile(brokerDoesNotAutoCreateDestinations, nameof(brokerDoesNotAutoCreateDestinations), required: true);
            return new DeferredBodyAction<CheckDestinationAccessActionOutput, CheckDestinationAccessActionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationType"] = ExpressionConverter.ConvertO(__workflow_destinationType);
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                serviceProviderParameters["brokerDoesNotAutoCreateDestinations"] = ExpressionConverter.ConvertO(__workflow_brokerDoesNotAutoCreateDestinations);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "checkDestinationAccessAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<CheckDestinationAccessActionOutput, CheckDestinationAccessActionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<AcknowledgeSessionActionOutput, AcknowledgeSessionActionActionConfiguration> AcknowledgeSessionAction(Expression<Func<string>> sessionId, Expression<Func<AcknowledgeSessionActionInputAcknowledgeActionType>> acknowledgeAction)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_acknowledgeAction = WorkflowExpression.Compile(acknowledgeAction, nameof(acknowledgeAction), required: true);
            return new DeferredBodyAction<AcknowledgeSessionActionOutput, AcknowledgeSessionActionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                serviceProviderParameters["acknowledgeAction"] = ExpressionConverter.ConvertO(__workflow_acknowledgeAction);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "acknowledgeSessionAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<AcknowledgeSessionActionOutput, AcknowledgeSessionActionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "nms")]
        public IBodyWorkflowAction<DeleteDurableSubscriptionActionOutput, DeleteDurableSubscriptionActionActionConfiguration> DeleteDurableSubscriptionAction(Expression<Func<string>> subscriptionName, Expression<Func<string>> clientId = null)
        {
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: false);
            return new DeferredBodyAction<DeleteDurableSubscriptionActionOutput, DeleteDurableSubscriptionActionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_clientId != null)
                {
                    serviceProviderParameters["clientId"] = ExpressionConverter.ConvertO(__workflow_clientId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "deleteDurableSubscriptionAction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<DeleteDurableSubscriptionActionOutput, DeleteDurableSubscriptionActionActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class PeekLockQueueMessagesActionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class PeekLockTopicMessagesActionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ReceiveQueueMessagesActionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ReceiveTopicMessagesActionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class SendMessageActionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class CheckDestinationAccessActionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class AcknowledgeSessionActionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeleteDurableSubscriptionActionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public class NmsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PeekLockQueueMessagesTriggerOutput, PeekLockQueueMessagesTriggerTriggerConfiguration> PeekLockQueueMessagesTrigger(Expression<Func<string>> destinationName, Expression<Func<PeekLockQueueMessagesTriggerInputGetMessagesOptionsType>> getMessagesOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_getMessagesOptions = WorkflowExpression.Compile(getMessagesOptions, nameof(getMessagesOptions), required: false);
            return new DeferredBodyTrigger<PeekLockQueueMessagesTriggerOutput, PeekLockQueueMessagesTriggerTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                if (__workflow_getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = ExpressionConverter.ConvertO(__workflow_getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockQueueMessagesTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<PeekLockQueueMessagesTriggerOutput, PeekLockQueueMessagesTriggerTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<PeekLockTopicMessagesTriggerOutput, PeekLockTopicMessagesTriggerTriggerConfiguration> PeekLockTopicMessagesTrigger(Expression<Func<string>> destinationName, Expression<Func<bool>> durable, Expression<Func<string>> subscriptionName, Expression<Func<PeekLockTopicMessagesTriggerInputGetMessagesOptionsType>> getMessagesOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_durable = WorkflowExpression.Compile(durable, nameof(durable), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_getMessagesOptions = WorkflowExpression.Compile(getMessagesOptions, nameof(getMessagesOptions), required: false);
            return new DeferredBodyTrigger<PeekLockTopicMessagesTriggerOutput, PeekLockTopicMessagesTriggerTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                serviceProviderParameters["durable"] = ExpressionConverter.ConvertO(__workflow_durable);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = ExpressionConverter.ConvertO(__workflow_getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockTopicMessagesTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<PeekLockTopicMessagesTriggerOutput, PeekLockTopicMessagesTriggerTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<ReceiveQueueMessagesTriggerOutput, ReceiveQueueMessagesTriggerTriggerConfiguration> ReceiveQueueMessagesTrigger(Expression<Func<string>> destinationName, Expression<Func<ReceiveQueueMessagesTriggerInputGetMessagesOptionsType>> getMessagesOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_getMessagesOptions = WorkflowExpression.Compile(getMessagesOptions, nameof(getMessagesOptions), required: false);
            return new DeferredBodyTrigger<ReceiveQueueMessagesTriggerOutput, ReceiveQueueMessagesTriggerTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                if (__workflow_getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = ExpressionConverter.ConvertO(__workflow_getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveQueueMessagesTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<ReceiveQueueMessagesTriggerOutput, ReceiveQueueMessagesTriggerTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<ReceiveTopicMessagesTriggerOutput, ReceiveTopicMessagesTriggerTriggerConfiguration> ReceiveTopicMessagesTrigger(Expression<Func<string>> destinationName, Expression<Func<string>> subscriptionName, Expression<Func<bool>> durable, Expression<Func<ReceiveTopicMessagesTriggerInputGetMessagesOptionsType>> getMessagesOptions = null)
        {
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_durable = WorkflowExpression.Compile(durable, nameof(durable), required: true);
            var __workflow_getMessagesOptions = WorkflowExpression.Compile(getMessagesOptions, nameof(getMessagesOptions), required: false);
            return new DeferredBodyTrigger<ReceiveTopicMessagesTriggerOutput, ReceiveTopicMessagesTriggerTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["durable"] = ExpressionConverter.ConvertO(__workflow_durable);
                if (__workflow_getMessagesOptions != null)
                {
                    serviceProviderParameters["getMessagesOptions"] = ExpressionConverter.ConvertO(__workflow_getMessagesOptions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveTopicMessagesTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<ReceiveTopicMessagesTriggerOutput, ReceiveTopicMessagesTriggerTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<PeekLockActiveMqAdvisoryTopicEventsTriggerOutput, PeekLockActiveMqAdvisoryTopicEventsTriggerTriggerConfiguration> PeekLockActiveMqAdvisoryTopicEventsTrigger(Expression<Func<PeekLockActiveMqAdvisoryTopicEventsTriggerInputAdvisoryCategoryType>> advisoryCategory, Expression<Func<PeekLockActiveMqAdvisoryTopicEventsTriggerInputDestinationTypeType>> destinationType = null, Expression<Func<string>> destinationName = null)
        {
            var __workflow_advisoryCategory = WorkflowExpression.Compile(advisoryCategory, nameof(advisoryCategory), required: true);
            var __workflow_destinationType = WorkflowExpression.Compile(destinationType, nameof(destinationType), required: false);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: false);
            return new DeferredBodyTrigger<PeekLockActiveMqAdvisoryTopicEventsTriggerOutput, PeekLockActiveMqAdvisoryTopicEventsTriggerTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["advisoryCategory"] = ExpressionConverter.ConvertO(__workflow_advisoryCategory);
                if (__workflow_destinationType != null)
                {
                    serviceProviderParameters["destinationType"] = ExpressionConverter.ConvertO(__workflow_destinationType);
                }

                if (__workflow_destinationName != null)
                {
                    serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "peekLockActiveMqAdvisoryTopicEventsTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<PeekLockActiveMqAdvisoryTopicEventsTriggerOutput, PeekLockActiveMqAdvisoryTopicEventsTriggerTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<ReceiveActiveMqAdvisoryTopicEventsTriggerOutput, ReceiveActiveMqAdvisoryTopicEventsTriggerTriggerConfiguration> ReceiveActiveMqAdvisoryTopicEventsTrigger(Expression<Func<ReceiveActiveMqAdvisoryTopicEventsTriggerInputAdvisoryCategoryType>> advisoryCategory, Expression<Func<ReceiveActiveMqAdvisoryTopicEventsTriggerInputDestinationTypeType>> destinationType = null, Expression<Func<string>> destinationName = null)
        {
            var __workflow_advisoryCategory = WorkflowExpression.Compile(advisoryCategory, nameof(advisoryCategory), required: true);
            var __workflow_destinationType = WorkflowExpression.Compile(destinationType, nameof(destinationType), required: false);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: false);
            return new DeferredBodyTrigger<ReceiveActiveMqAdvisoryTopicEventsTriggerOutput, ReceiveActiveMqAdvisoryTopicEventsTriggerTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["advisoryCategory"] = ExpressionConverter.ConvertO(__workflow_advisoryCategory);
                if (__workflow_destinationType != null)
                {
                    serviceProviderParameters["destinationType"] = ExpressionConverter.ConvertO(__workflow_destinationType);
                }

                if (__workflow_destinationName != null)
                {
                    serviceProviderParameters["destinationName"] = ExpressionConverter.ConvertO(__workflow_destinationName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/nms", operationId: "receiveActiveMqAdvisoryTopicEventsTrigger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<ReceiveActiveMqAdvisoryTopicEventsTriggerOutput, ReceiveActiveMqAdvisoryTopicEventsTriggerTriggerConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class PeekLockQueueMessagesTriggerTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class PeekLockTopicMessagesTriggerTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ReceiveQueueMessagesTriggerTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ReceiveTopicMessagesTriggerTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class PeekLockActiveMqAdvisoryTopicEventsTriggerTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ReceiveActiveMqAdvisoryTopicEventsTriggerTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
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