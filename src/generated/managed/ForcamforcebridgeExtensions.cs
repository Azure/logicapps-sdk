//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Forcamforcebridge
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ForcamforcebridgeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "forcamforcebridge")]
        public IBodyWorkflowAction<TicketClassList> TicketClasses(Expression<Func<string>> limit = null, Expression<Func<string>> offset = null)
        {
            var apiCallPath = "/tickets/classes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<TicketClassList>(callPayload);
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