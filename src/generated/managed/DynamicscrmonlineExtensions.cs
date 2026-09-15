//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicscrmonline
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicscrmonlineActions([ConnectionName] string connectionId)
    {
    }

    public class DynamicscrmonlineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnNewItems(Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/tables/{1}/onnewitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicscrmonline;

    public partial class WorkflowManagedActions
    {
        public DynamicscrmonlineActions Dynamicscrmonline(string connectionId) => new DynamicscrmonlineActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynamicscrmonlineTriggers Dynamicscrmonline(string connectionId) => new DynamicscrmonlineTriggers(connectionId);
    }
}