// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The AppendToStringVariable action appends a string to an existing string workflow variable.
    /// </summary>
    public class AppendToStringVariableAction : VariableActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppendToStringVariableAction"/> class.
        /// </summary>
        /// <param name="variableName">The variable name.</param>
        /// <param name="value">The string value to append.</param>
        public AppendToStringVariableAction(string variableName, JToken value)
            : base(variableName, value)
        {
        }

        /// <summary>
        /// Gets the operation type.
        /// </summary>
        protected override FlowTemplateOperationType OperationType => FlowTemplateOperationType.AppendToStringVariable;
    }
}
