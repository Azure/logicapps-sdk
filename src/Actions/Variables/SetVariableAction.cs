// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The SetVariable action sets a workflow variable to a new value.
    /// </summary>
    public class SetVariableAction : VariableActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetVariableAction"/> class.
        /// </summary>
        /// <param name="variableName">The variable name.</param>
        /// <param name="value">The value to set.</param>
        public SetVariableAction(string variableName, JToken value)
            : base(variableName, value)
        {
        }

        /// <summary>
        /// Gets the operation type.
        /// </summary>
        protected override FlowTemplateOperationType OperationType => FlowTemplateOperationType.SetVariable;
    }
}
