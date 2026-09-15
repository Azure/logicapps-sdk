//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eventhubs
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EventhubsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        public IWorkflowAction SendEvent(Expression<Func<string>> eventHubName, Expression<Func<string>> eventDatacontent = null, Expression<Func<string>> partitionKey = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventHubName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (partitionKey != null)
                callPayload.Queries["partitionKey"] = CSharpExpressionConverter.ConvertO(partitionKey);
            var eventData = new JObject();
            var eventDatapropCount = 0;
            if (eventDatacontent != null)
            {
                eventData["ContentData"] = CSharpExpressionConverter.ConvertToken(eventDatacontent);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        public IWorkflowAction SendEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> partitionKey, Expression<Func<SendEvent[]>> events = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/events/batch", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventHubName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partitionKey"] = CSharpExpressionConverter.ConvertO(partitionKey);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(events);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class EventhubsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Event[]> OnNewEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> contentType = null, Expression<Func<string>> contentSchema = null, Expression<Func<string>> consumerGroupName = null, Expression<Func<string>> minimumPartitionKey = null, Expression<Func<string>> maximumPartitionKey = null, Expression<Func<int>> maximumEventsCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/events/batch/head", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventHubName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentType"] = Convert.ToString("application/octet-stream");
            if (contentType != null)
                callPayload.Queries["contentType"] = CSharpExpressionConverter.ConvertO(contentType);
            if (contentSchema != null)
                callPayload.Queries["contentSchema"] = CSharpExpressionConverter.ConvertO(contentSchema);
            callPayload.Queries["consumerGroupName"] = Convert.ToString("$Default");
            if (consumerGroupName != null)
                callPayload.Queries["consumerGroupName"] = CSharpExpressionConverter.ConvertO(consumerGroupName);
            if (minimumPartitionKey != null)
                callPayload.Queries["minimumPartitionKey"] = CSharpExpressionConverter.ConvertO(minimumPartitionKey);
            if (maximumPartitionKey != null)
                callPayload.Queries["maximumPartitionKey"] = CSharpExpressionConverter.ConvertO(maximumPartitionKey);
            callPayload.Queries["maximumEventsCount"] = Convert.ToString(50);
            if (maximumEventsCount != null)
                callPayload.Queries["maximumEventsCount"] = CSharpExpressionConverter.ConvertO(maximumEventsCount);
            return new ApiConnectionTrigger<Event[]>(callPayload, triggerName, recurrence);
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