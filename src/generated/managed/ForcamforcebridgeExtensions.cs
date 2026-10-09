//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Forcamforcebridge
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ForcamforcebridgeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "forcamforcebridge")]
        [WorkflowExpressionFactory(nameof(__BuildTicketClasses))]
        public IBodyWorkflowAction<TicketClassList> TicketClasses([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TicketClassList> __BuildTicketClasses(WorkflowExpression<string> limit = null, WorkflowExpression<string> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TicketClassList>(() =>
            {
                var apiCallPath = "/tickets/classes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<TicketClassList>(callPayload);
            });
        }
    }

    public class ForcamforcebridgeTriggers([ConnectionName] string connectionId)
    {
    }

    public class TicketClassList
    {
        [JsonProperty("numberOfTicketClasses")]
        public double NumberOfTicketClasses { get; set; }

        [JsonProperty("ticketClasses")]
        public TicketClass[] TicketClasses { get; set; }
    }

    public class TicketClass
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sequence")]
        public double Sequence { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Forcamforcebridge;

    public partial class WorkflowManagedActions
    {
        public ForcamforcebridgeActions Forcamforcebridge(string connectionId) => new ForcamforcebridgeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ForcamforcebridgeTriggers Forcamforcebridge(string connectionId) => new ForcamforcebridgeTriggers(connectionId);
    }
}