// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Input model for the InitializeVariable action.
    /// </summary>
    public class InitializeVariableActionInput
    {
        /// <summary>
        /// Gets or sets the array of variable definitions to initialize.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public VariableDefinitionEntry[] Variables { get; set; }
    }

    /// <summary>
    /// A single variable definition entry used in InitializeVariable.
    /// </summary>
    public class VariableDefinitionEntry
    {
        /// <summary>
        /// Gets or sets the variable name.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the variable type (e.g., integer, float, boolean, string, array, object).
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the initial value.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Value { get; set; }
    }

    /// <summary>
    /// Input model for variable modification actions (Set, Increment, Decrement, Append).
    /// </summary>
    public class VariableActionInput
    {
        /// <summary>
        /// Gets or sets the variable name.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value to apply.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Value { get; set; }
    }
}
