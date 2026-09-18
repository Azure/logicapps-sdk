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
        public IWorkflowAction SendEvent([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> eventDatacontent = null, [WorkflowExpression] Func<string> partitionKey = null)
        {
            SourceExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            SourceExpression.Validate(eventDatacontent, nameof(eventDatacontent), required: false);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventHubName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (partitionKey != null)
                    callPayload.Queries["partitionKey"] = SourceExpressionConverter.ConvertO(partitionKey);
                var eventData = new JObject();
                var eventDatapropCount = 0;
                if (eventDatacontent != null)
                {
                    eventData["ContentData"] = SourceExpressionConverter.ConvertToken(eventDatacontent);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventhubs")]
        public IWorkflowAction SendEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<SendEvent[]> events = null)
        {
            SourceExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(events, nameof(events), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events/batch", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventHubName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partitionKey"] = SourceExpressionConverter.ConvertO(partitionKey);
                callPayload.Body = SourceExpressionConverter.ConvertToken(events);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class EventhubsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Event[]> OnNewEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> contentSchema = null, [WorkflowExpression] Func<string> consumerGroupName = null, [WorkflowExpression] Func<string> minimumPartitionKey = null, [WorkflowExpression] Func<string> maximumPartitionKey = null, [WorkflowExpression] Func<int> maximumEventsCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(contentSchema, nameof(contentSchema), required: false);
            SourceExpression.Validate(consumerGroupName, nameof(consumerGroupName), required: false);
            SourceExpression.Validate(minimumPartitionKey, nameof(minimumPartitionKey), required: false);
            SourceExpression.Validate(maximumPartitionKey, nameof(maximumPartitionKey), required: false);
            SourceExpression.Validate(maximumEventsCount, nameof(maximumEventsCount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events/batch/head", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventHubName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentType"] = Convert.ToString("application/octet-stream");
                if (contentType != null)
                    callPayload.Queries["contentType"] = SourceExpressionConverter.ConvertO(contentType);
                if (contentSchema != null)
                    callPayload.Queries["contentSchema"] = SourceExpressionConverter.ConvertO(contentSchema);
                callPayload.Queries["consumerGroupName"] = Convert.ToString("$Default");
                if (consumerGroupName != null)
                    callPayload.Queries["consumerGroupName"] = SourceExpressionConverter.ConvertO(consumerGroupName);
                if (minimumPartitionKey != null)
                    callPayload.Queries["minimumPartitionKey"] = SourceExpressionConverter.ConvertO(minimumPartitionKey);
                if (maximumPartitionKey != null)
                    callPayload.Queries["maximumPartitionKey"] = SourceExpressionConverter.ConvertO(maximumPartitionKey);
                callPayload.Queries["maximumEventsCount"] = Convert.ToString(50);
                if (maximumEventsCount != null)
                    callPayload.Queries["maximumEventsCount"] = SourceExpressionConverter.ConvertO(maximumEventsCount);
                return callPayload;
            }

            return new ApiConnectionTrigger<Event[]>(BuildSourceInput, triggerName, recurrence);
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