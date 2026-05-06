// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The AppendToArrayVariable action appends a value to an existing array workflow variable.
    /// </summary>
    public class AppendToArrayVariableAction : VariableActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppendToArrayVariableAction"/> class.
        /// </summary>
        /// <param name="variableName">The variable name.</param>
        /// <param name="value">The value to append to the array.</param>
        public AppendToArrayVariableAction(string variableName, JToken value)
            : base(variableName, value)
        {
        }

        /// <summary>
        /// Gets the operation type.
        /// </summary>
        protected override FlowTemplateOperationType OperationType => FlowTemplateOperationType.AppendToArrayVariable;
    }
}
