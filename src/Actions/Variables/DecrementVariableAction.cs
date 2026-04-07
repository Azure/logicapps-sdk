// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The DecrementVariable action decrements a numeric workflow variable by a specified value.
    /// </summary>
    public class DecrementVariableAction : VariableActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecrementVariableAction"/> class.
        /// </summary>
        /// <param name="variableName">The variable name.</param>
        /// <param name="value">The value to decrement by.</param>
        public DecrementVariableAction(string variableName, JToken value)
            : base(variableName, value)
        {
        }

        /// <summary>
        /// Gets the operation type.
        /// </summary>
        protected override FlowTemplateOperationType OperationType => FlowTemplateOperationType.DecrementVariable;
    }
}
