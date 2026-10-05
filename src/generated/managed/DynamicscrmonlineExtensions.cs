//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicscrmonline
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicscrmonlineActions([ConnectionName] string connectionId)
    {
    }

    public class DynamicscrmonlineTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnNewItems))]
        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnNewItems(WorkflowValue<string> dataset, WorkflowValue<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/tables/{1}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
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
