//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eventhubs
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EventhubsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        [WorkflowExpressionFactory(nameof(__BuildSendEvent))]
        public IWorkflowAction SendEvent([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> eventDatacontent = null, [WorkflowExpression] Func<string> partitionKey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEvent(WorkflowExpression<string> eventHubName, WorkflowExpression<string> eventDatacontent = null, WorkflowExpression<string> partitionKey = null)
        {
            WorkflowExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            WorkflowExpression.Validate(eventDatacontent, nameof(eventDatacontent), required: false);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(eventHubName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (partitionKey != null)
                    callPayload.Queries["partitionKey"] = ExpressionConverter.Convert(partitionKey);
                var eventData = new JObject();
                var eventDatapropCount = 0;
                if (eventDatacontent != null)
                {
                    eventData["ContentData"] = ExpressionConverter.ConvertO(eventDatacontent);
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
        [WorkflowExpressionFactory(nameof(__BuildSendEvents))]
        public IWorkflowAction SendEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<SendEvent[]> events = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEvents(WorkflowExpression<string> eventHubName, WorkflowExpression<string> partitionKey, WorkflowExpression<SendEvent[]> events = null)
        {
            WorkflowExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowExpression.Validate(events, nameof(events), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events/batch", ExpressionConverter.ConvertWithUrlEncoding(eventHubName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partitionKey"] = ExpressionConverter.Convert(partitionKey);
                callPayload.Body = ExpressionConverter.ConvertO(events);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class EventhubsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewEvents))]
        public IBodyWorkflowTrigger<Event[]> OnNewEvents([WorkflowExpression] Func<string> eventHubName,[WorkflowExpression] Func<string> contentType = null,[WorkflowExpression] Func<string> contentSchema = null,[WorkflowExpression] Func<string> consumerGroupName = null,[WorkflowExpression] Func<string> minimumPartitionKey = null,[WorkflowExpression] Func<string> maximumPartitionKey = null,[WorkflowExpression] Func<int> maximumEventsCount = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<Event[]> __BuildOnNewEvents(WorkflowExpression<string> eventHubName,WorkflowExpression<string> contentType = null,WorkflowExpression<string> contentSchema = null,WorkflowExpression<string> consumerGroupName = null,WorkflowExpression<string> minimumPartitionKey = null,WorkflowExpression<string> maximumPartitionKey = null,WorkflowExpression<int> maximumEventsCount = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(contentSchema, nameof(contentSchema), required: false);
            WorkflowExpression.Validate(consumerGroupName, nameof(consumerGroupName), required: false);
            WorkflowExpression.Validate(minimumPartitionKey, nameof(minimumPartitionKey), required: false);
            WorkflowExpression.Validate(maximumPartitionKey, nameof(maximumPartitionKey), required: false);
            WorkflowExpression.Validate(maximumEventsCount, nameof(maximumEventsCount), required: false);
            return new DeferredBodyTrigger<Event[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events/batch/head", ExpressionConverter.ConvertWithUrlEncoding(eventHubName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentType"] = Convert.ToString("application/octet-stream");
                if (contentType != null)
                    callPayload.Queries["contentType"] = ExpressionConverter.Convert(contentType);
                if (contentSchema != null)
                    callPayload.Queries["contentSchema"] = ExpressionConverter.Convert(contentSchema);
                callPayload.Queries["consumerGroupName"] = Convert.ToString("$Default");
                if (consumerGroupName != null)
                    callPayload.Queries["consumerGroupName"] = ExpressionConverter.Convert(consumerGroupName);
                if (minimumPartitionKey != null)
                    callPayload.Queries["minimumPartitionKey"] = ExpressionConverter.Convert(minimumPartitionKey);
                if (maximumPartitionKey != null)
                    callPayload.Queries["maximumPartitionKey"] = ExpressionConverter.Convert(maximumPartitionKey);
                callPayload.Queries["maximumEventsCount"] = Convert.ToString(50);
                if (maximumEventsCount != null)
                    callPayload.Queries["maximumEventsCount"] = ExpressionConverter.Convert(maximumEventsCount);
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