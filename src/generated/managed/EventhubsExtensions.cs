//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eventhubs
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EventhubsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        public IWorkflowAction SendEvent(Expression<Func<string>> eventHubName, Expression<Func<string>> eventDatacontent = null, Expression<Func<string>> partitionKey = null)
        {
            var __workflow_eventHubName = eventHubName == null ? null : WorkflowExpression.Compile(eventHubName);
            WorkflowExpression.Validate(__workflow_eventHubName, nameof(eventHubName), required: true);
            var __workflow_eventDatacontent = eventDatacontent == null ? null : WorkflowExpression.Compile(eventDatacontent);
            WorkflowExpression.Validate(__workflow_eventDatacontent, nameof(eventDatacontent), required: false);
            var __workflow_partitionKey = partitionKey == null ? null : WorkflowExpression.Compile(partitionKey);
            WorkflowExpression.Validate(__workflow_partitionKey, nameof(partitionKey), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventHubName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_partitionKey != null)
                    callPayload.Queries["partitionKey"] = ExpressionConverter.Convert(__workflow_partitionKey);
                var eventData = new JObject();
                var eventDatapropCount = 0;
                if (__workflow_eventDatacontent != null)
                {
                    eventData["ContentData"] = ExpressionConverter.ConvertO(__workflow_eventDatacontent);
                    eventDatapropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    eventData["Properties"] = propertiesObject;
                    eventDatapropCount++;
                }

                if (eventDatapropCount > 0)
                {
                    callPayload.Body = eventData;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        public IWorkflowAction SendEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> partitionKey, Expression<Func<SendEvent[]>> events = null)
        {
            var __workflow_eventHubName = eventHubName == null ? null : WorkflowExpression.Compile(eventHubName);
            WorkflowExpression.Validate(__workflow_eventHubName, nameof(eventHubName), required: true);
            var __workflow_partitionKey = partitionKey == null ? null : WorkflowExpression.Compile(partitionKey);
            WorkflowExpression.Validate(__workflow_partitionKey, nameof(partitionKey), required: true);
            var __workflow_events = events == null ? null : WorkflowExpression.Compile(events);
            WorkflowExpression.Validate(__workflow_events, nameof(events), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events/batch", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventHubName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partitionKey"] = ExpressionConverter.Convert(__workflow_partitionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_events);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class EventhubsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Event[]> OnNewEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> contentType = null, Expression<Func<string>> contentSchema = null, Expression<Func<string>> consumerGroupName = null, Expression<Func<string>> minimumPartitionKey = null, Expression<Func<string>> maximumPartitionKey = null, Expression<Func<int>> maximumEventsCount = null, FlowRecurrence recurrence = null)
        {
            var __workflow_eventHubName = eventHubName == null ? null : WorkflowExpression.Compile(eventHubName);
            WorkflowExpression.Validate(__workflow_eventHubName, nameof(eventHubName), required: true);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            var __workflow_contentSchema = contentSchema == null ? null : WorkflowExpression.Compile(contentSchema);
            WorkflowExpression.Validate(__workflow_contentSchema, nameof(contentSchema), required: false);
            var __workflow_consumerGroupName = consumerGroupName == null ? null : WorkflowExpression.Compile(consumerGroupName);
            WorkflowExpression.Validate(__workflow_consumerGroupName, nameof(consumerGroupName), required: false);
            var __workflow_minimumPartitionKey = minimumPartitionKey == null ? null : WorkflowExpression.Compile(minimumPartitionKey);
            WorkflowExpression.Validate(__workflow_minimumPartitionKey, nameof(minimumPartitionKey), required: false);
            var __workflow_maximumPartitionKey = maximumPartitionKey == null ? null : WorkflowExpression.Compile(maximumPartitionKey);
            WorkflowExpression.Validate(__workflow_maximumPartitionKey, nameof(maximumPartitionKey), required: false);
            var __workflow_maximumEventsCount = maximumEventsCount == null ? null : WorkflowExpression.Compile(maximumEventsCount);
            WorkflowExpression.Validate(__workflow_maximumEventsCount, nameof(maximumEventsCount), required: false);
            return new DeferredBodyTrigger<Event[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events/batch/head", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventHubName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentType"] = Convert.ToString("application/octet-stream");
                if (__workflow_contentType != null)
                    callPayload.Queries["contentType"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_contentSchema != null)
                    callPayload.Queries["contentSchema"] = ExpressionConverter.Convert(__workflow_contentSchema);
                callPayload.Queries["consumerGroupName"] = Convert.ToString("$Default");
                if (__workflow_consumerGroupName != null)
                    callPayload.Queries["consumerGroupName"] = ExpressionConverter.Convert(__workflow_consumerGroupName);
                if (__workflow_minimumPartitionKey != null)
                    callPayload.Queries["minimumPartitionKey"] = ExpressionConverter.Convert(__workflow_minimumPartitionKey);
                if (__workflow_maximumPartitionKey != null)
                    callPayload.Queries["maximumPartitionKey"] = ExpressionConverter.Convert(__workflow_maximumPartitionKey);
                callPayload.Queries["maximumEventsCount"] = Convert.ToString(50);
                if (__workflow_maximumEventsCount != null)
                    callPayload.Queries["maximumEventsCount"] = ExpressionConverter.Convert(__workflow_maximumEventsCount);
                return new ApiConnectionTrigger<Event[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendEvent
    {
        [JsonProperty("ContentData")]
        public string Content { get; set; }
        public JToken Properties { get; set; }
    }

    public class Event
    {
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
        public SystemProperties SystemProperties { get; set; }
    }

    public class SystemProperties
    {
        [JsonProperty("EnqueuedTimeUtc")]
        public string EnqueuedTimeInUTC { get; set; }
        public string Offset { get; set; }
        public string PartitionKey { get; set; }
        public int SequenceNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Eventhubs;

    public partial class WorkflowManagedActions
    {
        public EventhubsActions Eventhubs(string connectionId) => new EventhubsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EventhubsTriggers Eventhubs(string connectionId) => new EventhubsTriggers(connectionId);
    }
}
