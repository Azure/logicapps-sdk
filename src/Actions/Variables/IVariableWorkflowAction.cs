// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Extends IWorkflowAction to support variable actions whose values can be referenced in expressions.
    /// When <see cref="Value"/> is accessed in an expression tree, it is converted to the Logic Apps
    /// expression <c>variables('variableName')</c>.
    /// </summary>
    public interface IVariableWorkflowAction : IWorkflowAction
    {
        /// <summary>
        /// Gets the variable value placeholder. When used in expression trees, this is
        /// converted to the Logic Apps expression <c>variables('variableName')</c>.
        /// </summary>
        JToken Value { get; }

        /// <summary>
        /// Gets the name of the variable.
        /// </summary>
        string VariableName { get; }
    }
}
