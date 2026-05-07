// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a concrete workflow operation (action or trigger) with a name and child nodes.
    /// </summary>
    public interface IWorkflowOperation : IChainableNode
    {
        /// <summary>
        /// Gets or sets the name of the workflow operation.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the child action nodes that run after this operation.
        /// </summary>
        List<IWorkflowAction> Children { get; }
    }
}
