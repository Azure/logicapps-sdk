// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Defines the fluent chaining contract for workflow nodes.
    /// </summary>
    public static class IWorkflowNodeExtensions
    {
        public static IWorkflowAction GetRootAction(this IWorkflowNode node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node is OperationChain chain)
            {
                return chain.GetRootAction();
            }

            if (node is IWorkflowAction action)
            {
                return action;
            }

            throw new InvalidOperationException("The provided node does not contain a valid root action.");
        }
    }
}
