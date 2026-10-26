//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eventhubs
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EventhubsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendEvent(Expression<Func<string>> eventHubName, Expression<Func<string>> eventDatacontent = null, Expression<Func<string>> partitionKey = null)
        {
            var __workflow_eventHubName = WorkflowExpression.Compile(eventHubName, nameof(eventHubName), required: true);
            var __workflow_eventDatacontent = WorkflowExpression.Compile(eventDatacontent, nameof(eventDatacontent), required: false);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events", __workflow_eventHubName.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> SendEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> partitionKey, Expression<Func<SendEvent[]>> events = null)
        {
            var __workflow_eventHubName = WorkflowExpression.Compile(eventHubName, nameof(eventHubName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_events = WorkflowExpression.Compile(events, nameof(events), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events/batch", __workflow_eventHubName.WithUrlEncoding(1)));
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
        public IBodyWorkflowTrigger<Event[], ApiConnectionTriggerConfiguration> OnNewEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> contentType = null, Expression<Func<string>> contentSchema = null, Expression<Func<string>> consumerGroupName = null, Expression<Func<string>> minimumPartitionKey = null, Expression<Func<string>> maximumPartitionKey = null, Expression<Func<int>> maximumEventsCount = null, FlowRecurrence recurrence = null)
        {
            var __workflow_eventHubName = WorkflowExpression.Compile(eventHubName, nameof(eventHubName), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_contentSchema = WorkflowExpression.Compile(contentSchema, nameof(contentSchema), required: false);
            var __workflow_consumerGroupName = WorkflowExpression.Compile(consumerGroupName, nameof(consumerGroupName), required: false);
            var __workflow_minimumPartitionKey = WorkflowExpression.Compile(minimumPartitionKey, nameof(minimumPartitionKey), required: false);
            var __workflow_maximumPartitionKey = WorkflowExpression.Compile(maximumPartitionKey, nameof(maximumPartitionKey), required: false);
            var __workflow_maximumEventsCount = WorkflowExpression.Compile(maximumEventsCount, nameof(maximumEventsCount), required: false);
            return new DeferredBodyTrigger<Event[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events/batch/head", __workflow_eventHubName.WithUrlEncoding(1)));
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