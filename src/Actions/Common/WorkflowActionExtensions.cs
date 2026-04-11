// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Extension methods for <see cref="IWorkflowAction"/>.
    /// </summary>
    public static class WorkflowActionExtensions
    {
        /// <summary>
        /// Gets the root of the chain this action belongs to.
        /// Returns <see cref="IWorkflowAction.ChainRoot"/> if set, otherwise returns the action itself.
        /// </summary>
        /// <param name="action">The action to get the chain root for.</param>
        public static IWorkflowNode GetChainRoot(this IWorkflowAction action)
        {
            return action.ChainRoot ?? action;
        }

        /// <summary>
        /// Gets the chain root as an <see cref="IWorkflowAction"/>.
        /// Returns the chain root if it is an action, otherwise returns the action itself.
        /// Used by control action factories to extract the root action of a branch.
        /// </summary>
        /// <param name="action">The action to get the action chain root for.</param>
        public static IWorkflowAction GetActionChainRoot(this IWorkflowAction action)
        {
            return action.ChainRoot as IWorkflowAction ?? action;
        }
    }
}
