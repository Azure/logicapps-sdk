// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Helper methods for control flow actions that contain nested action graphs.
    /// </summary>
    internal static class ControlActionHelper
    {
        /// <summary>
        /// Traverses the action graph starting from the root node and collects all actions
        /// into a dictionary suitable for use in control flow action definitions.
        /// The method enforces scope isolation: every RunAfter dependency must reference
        /// an action within the collected scope, and duplicate action names are rejected.
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

            // BFS to discover all action nodes reachable from the root.
            var collectedActions = new List<IWorkflowAction>();
            var collectedActionsMap = new Dictionary<string, IWorkflowAction>();
            var queue = new Queue<IWorkflowAction>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var action = queue.Dequeue();

                if (collectedActionsMap.TryGetValue(action.Name, out var existing))
                {
                    if (!object.ReferenceEquals(existing, action))
                    {
                        throw new InvalidOperationException($"Duplicate action name '{action.Name}' detected. Action names must be unique within each scope.");
                    }

                    continue;
                }

                collectedActionsMap[action.Name] = action;
                collectedActions.Add(action);

                foreach (var child in action.Children)
                {
                    queue.Enqueue(child);
                }
            }

            // Validate RunAfterConfig scope isolation and build action definitions.
            var actions = new Dictionary<string, FlowTemplateAction>();
            foreach (var action in collectedActions)
            {
                var isRoot = object.ReferenceEquals(action, root);
                if (isRoot && action.RunAfterConfig.Count > 0)
                {
                    throw new InvalidOperationException($"The first action '{action.Name}' inside a scope cannot have run-after dependencies on other actions.");
                }

                var outOfScopeDependencies = action.RunAfterConfig.Keys
                    .Where(dep => !collectedActionsMap.ContainsKey(dep));
                
                if (outOfScopeDependencies.Any())
                {
                    var deps = string.Join(", ", outOfScopeDependencies);
                    throw new InvalidOperationException($"Action '{action.Name}' depends on actions outside the current scope: {deps}. All run-after dependencies must reference actions within the same scope.");
                }

                var actionDefinition = action.GetActionDefinition(flowName, flowKind);
                if (action.RunAfterConfig.Count > 0)
                {
                    actionDefinition.RunAfter = new Dictionary<string, FlowStatus[]>(action.RunAfterConfig);
                }
                actions[action.Name] = actionDefinition;
            }

            return actions;
        }
    }
}
