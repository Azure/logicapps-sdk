//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventHub
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class EventHubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IWorkflowAction<SendEventActionConfiguration> SendEvent(Expression<Func<string>> eventHubName, Expression<Func<SendEventInputEventDataType>> eventData, Expression<Func<string>> partitionKey = null)
        {
            var __workflow_eventHubName = WorkflowExpression.Compile(eventHubName, nameof(eventHubName), required: true);
            var __workflow_eventData = WorkflowExpression.Compile(eventData, nameof(eventData), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: false);
            return new DeferredWorkflowAction<SendEventActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(__workflow_eventHubName);
                serviceProviderParameters["eventData"] = ExpressionConverter.ConvertO(__workflow_eventData);
                if (__workflow_partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<SendEventActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IWorkflowAction<SendEventsActionConfiguration> SendEvents(Expression<Func<string>> eventHubName, Expression<Func<SendEventsInputEventDatasTypeItem[]>> eventDatas, Expression<Func<string>> partitionKey = null)
        {
            var __workflow_eventHubName = WorkflowExpression.Compile(eventHubName, nameof(eventHubName), required: true);
            var __workflow_eventDatas = WorkflowExpression.Compile(eventDatas, nameof(eventDatas), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: false);
            return new DeferredWorkflowAction<SendEventsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(__workflow_eventHubName);
                serviceProviderParameters["eventDatas"] = ExpressionConverter.ConvertO(__workflow_eventDatas);
                if (__workflow_partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<SendEventsActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IWorkflowAction<ReplicateEventsActionConfiguration> ReplicateEvents(Expression<Func<string>> eventHubName, Expression<Func<bool>> skipAlreadyReplicated)
        {
            var __workflow_eventHubName = WorkflowExpression.Compile(eventHubName, nameof(eventHubName), required: true);
            var __workflow_skipAlreadyReplicated = WorkflowExpression.Compile(skipAlreadyReplicated, nameof(skipAlreadyReplicated), required: true);
            return new DeferredWorkflowAction<ReplicateEventsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(__workflow_eventHubName);
                serviceProviderParameters["skipAlreadyReplicated"] = ExpressionConverter.ConvertO(__workflow_skipAlreadyReplicated);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "replicateEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ReplicateEventsActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class SendEventActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class SendEventsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ReplicateEventsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public class EventHubTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveEventsOutputItem[], ReceiveEventsTriggerConfiguration> ReceiveEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> consumerGroup = null)
        {
            var __workflow_eventHubName = WorkflowExpression.Compile(eventHubName, nameof(eventHubName), required: true);
            var __workflow_consumerGroup = WorkflowExpression.Compile(consumerGroup, nameof(consumerGroup), required: false);
            return new DeferredBodyTrigger<ReceiveEventsOutputItem[], ReceiveEventsTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(__workflow_eventHubName);
                if (__workflow_consumerGroup != null)
                {
                    serviceProviderParameters["consumerGroup"] = ExpressionConverter.ConvertO(__workflow_consumerGroup);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<ReceiveEventsOutputItem[], ReceiveEventsTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IWorkflowTrigger<ReceiveEventsForReplicationTriggerConfiguration> ReceiveEventsForReplication(Expression<Func<string>> eventHubName, Expression<Func<string>> consumerGroup = null)
        {
            var __workflow_eventHubName = WorkflowExpression.Compile(eventHubName, nameof(eventHubName), required: true);
            var __workflow_consumerGroup = WorkflowExpression.Compile(consumerGroup, nameof(consumerGroup), required: false);
            return new DeferredWorkflowTrigger<ReceiveEventsForReplicationTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(__workflow_eventHubName);
                if (__workflow_consumerGroup != null)
                {
                    serviceProviderParameters["consumerGroup"] = ExpressionConverter.ConvertO(__workflow_consumerGroup);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEventsForReplication", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveEventsForReplicationTriggerConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class ReceiveEventsTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }
    }

    public sealed class ReceiveEventsForReplicationTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }
    }

    public class ReceiveEventsOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
    }

    public class SendEventInputEventDataType
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
    }

    public class SendEventsInputEventDatasTypeItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventHub;

    public partial class WorkflowServiceProviderActions
    {
        public EventHubActions EventHub(string connectionId) => new EventHubActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public EventHubTriggers EventHub(string connectionId) => new EventHubTriggers(connectionId);
    }
}