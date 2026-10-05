//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgridpublish
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureeventgridpublishActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureeventgridpublish")]
        [WorkflowExpressionFactory(nameof(__BuildPublishEvent))]
        public IWorkflowAction PublishEvent([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPublishEvent(WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/eventGrid/api/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzureeventgridpublishTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodyInputItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("eventTime")]
        public string EventTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgridpublish;

    public partial class WorkflowManagedActions
    {
        public AzureeventgridpublishActions Azureeventgridpublish(string connectionId) => new AzureeventgridpublishActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureeventgridpublishTriggers Azureeventgridpublish(string connectionId) => new AzureeventgridpublishTriggers(connectionId);
    }
}
