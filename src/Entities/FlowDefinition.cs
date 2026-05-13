//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a complete workflow definition, combining the workflow's <see cref="Kind"/>
    /// (Stateful, Stateless, or Agent) with its <see cref="Definition"/> containing triggers,
    /// actions, and their execution order. This is the top-level serialization model for a single workflow.
    /// </summary>
    /// <seealso cref="FlowTemplate"/>
    /// <seealso cref="FlowKind"/>
    public class FlowDefinition
    {
        /// <summary>
        /// Gets or sets the workflow kind, which determines the runtime behavior.
        /// <see cref="FlowKind.Stateful"/> workflows persist run state and history;
        /// <see cref="FlowKind.Stateless"/> workflows do not.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public FlowKind? Kind { get; set; }
        
        /// <summary>
        /// Gets or sets the workflow template containing the triggers, actions, and schema
        /// that define the workflow's execution logic.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public FlowTemplate Definition { get; set; }
    }
}
