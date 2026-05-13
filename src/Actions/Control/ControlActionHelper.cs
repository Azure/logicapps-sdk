// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Collections.Generic;

    /// <summary>
    /// Helper methods for control flow actions that contain nested action graphs.
    /// </summary>
    internal static class ControlActionHelper
    {
        /// <summary>
        /// Traverses the action graph starting from the root node and collects all actions
        /// into a dictionary suitable for use in control flow action definitions.
        /// </summary>
        /// <param name="root">The root action node of the nested action graph.</param>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        /// <returns>A dictionary mapping action names to their FlowTemplateAction definitions.</returns>
        public static Dictionary<string, FlowTemplateAction> CollectActions(IWorkflowAction root, string flowName, FlowKind? flowKind = null)
        {
            if (root == null)
            {
                return null;
            }
            
            var actions = new Dictionary<string, FlowTemplateAction>();
            var visited = new HashSet<string>();
            var queue = new Queue<IWorkflowAction>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (visited.Contains(node.Name))
                {
                    continue;
                }

                visited.Add(node.Name);

                var actionDefinition = node.GetActionDefinition(flowName, flowKind);

                if (node.RunAfterConfig.Count > 0)
                {
                    actionDefinition.RunAfter = new Dictionary<string, FlowStatus[]>(node.RunAfterConfig);
                }

                actions[node.Name] = actionDefinition;

                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return actions;
        }
    }
}
