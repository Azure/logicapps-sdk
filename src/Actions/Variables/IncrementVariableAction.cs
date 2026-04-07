// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The IncrementVariable action increments a numeric workflow variable by a specified value.
    /// </summary>
    public class IncrementVariableAction : VariableActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncrementVariableAction"/> class.
        /// </summary>
        /// <param name="variableName">The variable name.</param>
        /// <param name="value">The value to increment by.</param>
        public IncrementVariableAction(string variableName, JToken value)
            : base(variableName, value)
        {
        }

        /// <summary>
        /// Gets the operation type.
        /// </summary>
        protected override FlowTemplateOperationType OperationType => FlowTemplateOperationType.IncrementVariable;
    }
}
