// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Extension methods for <see cref="IWorkflowTrigger"/> to build flow definitions from workflow graphs.
    /// </summary>
    public static class WorkflowTriggerExtensions
    {
        /// <summary>
        /// Traverses the workflow graph rooted at the trigger node and produces a <see cref="FlowDefinition"/>.
        /// </summary>
        /// <param name="trigger">The root trigger node of the workflow graph.</param>
        /// <param name="flowName">The workflow name.</param>
        /// <param name="flowKind">The kind of flow (Stateful, Stateless, Agent).</param>
        /// <returns>A <see cref="FlowDefinition"/> representing the complete workflow.</returns>
        public static FlowDefinition GetFlowDefinition(this IWorkflowTrigger trigger, string flowName, FlowKind flowKind)
        {
            var actions = new Dictionary<string, FlowTemplateAction>();
            var visited = new Dictionary<string, IWorkflowAction>();

            // BFS traversal of the action graph
            var queue = new Queue<IWorkflowAction>();
            foreach (var child in trigger.Children)
            {
                queue.Enqueue(child);
            }

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (visited.ContainsKey(node.Name))
                {
                    if (!object.ReferenceEquals(visited[node.Name], node))
                    {
                        throw new InvalidOperationException($"Duplicate action name detected: {node.Name}. Action names must be unique within a workflow.");
                    }
                    continue;
                }

                visited.Add(node.Name, node);

                var actionDefinition = node.GetActionDefinition(flowName, flowKind);

                // Set RunAfter from the node's configuration
                if (node.RunAfterConfig.Count > 0)
                {
                    actionDefinition.RunAfter = new Dictionary<string, FlowStatus[]>(node.RunAfterConfig);
                }
                else if (flowKind == FlowKind.Agent)
                {
                    // For agent workflows, first actions run after the trigger
                    actionDefinition.RunAfter = new Dictionary<string, FlowStatus[]>
                    {
                        { trigger.Name, new[] { FlowStatus.Succeeded } }
                    };
                }

                actions[node.Name] = actionDefinition;

                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return new FlowDefinition
            {
                Definition = new FlowTemplate
                {
                    Actions = actions,
                    Triggers = new Dictionary<string, FlowTemplateTrigger>
                    {
                        { trigger.Name, trigger.GetTriggerDefinition() }
                    },
                    Schema = "https://schema.management.azure.com/schemas/2016-06-01/workflowdefinition.json#",
                },
                Kind = flowKind,
            };
        }
    }
}
