// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Entities;
    using Microsoft.Azure.Workflows.Sdk.Runtime;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Defers agent input rendering while retaining the agent tool authoring surface.
    /// </summary>
    internal sealed class DeferredAgentAction : DeferredWorkflowAction, IAgentWorkflowAction
    {
        private readonly Dictionary<string, Func<string, FlowKind?, FlowTemplateActionToolBranch>> tools =
            new Dictionary<string, Func<string, FlowKind?, FlowTemplateActionToolBranch>>();

        internal DeferredAgentAction(Func<WorkflowActionBase> factory)
            : base(factory, WorkflowActionSettingProfiles.RetryTracked)
        {
        }

        /// <inheritdoc />
        public IAgentWorkflowAction AddTool<T>(
            Func<IAgentToolContext<T>, IWorkflowAction> tool,
            string description,
            T parameters)
            where T : class
        {
            if (tool == null)
            {
                throw new ArgumentNullException(nameof(tool), "The tool definition callback cannot be null.");
            }

            var toolContext = new AgentToolContext<T>(parameters);
            var rootAction = tool.Invoke(toolContext)
                ?? throw new InvalidOperationException("The tool definition callback must return an action.");

            this.AddTool(rootAction, description, parameters);
            return this;
        }

        /// <inheritdoc />
        public IAgentWorkflowAction AddTool<T>(
            Func<IAgentToolContext<T>, OperationChain> tool,
            string description,
            T parameters)
            where T : class
        {
            if (tool == null)
            {
                throw new ArgumentNullException(nameof(tool), "The tool definition callback cannot be null.");
            }

            var toolContext = new AgentToolContext<T>(parameters);
            var toolChain = tool.Invoke(toolContext)
                ?? throw new InvalidOperationException("The tool definition callback must return an operation chain.");
            var rootAction = toolChain.GetRootOperation() as IWorkflowAction
                ?? throw new InvalidOperationException("The first operation in a tool definition must be an action, not a trigger.");

            this.AddTool(rootAction, description, parameters);
            return this;
        }

        /// <inheritdoc />
        protected internal override FlowTemplateAction BuildActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            var definition = base.BuildActionDefinition(flowName, flowKind);
            definition.Tools = this.tools.ToDictionary(pair => pair.Key, pair => pair.Value(flowName, flowKind));
            return definition;
        }

        private void AddTool<T>(IWorkflowAction rootAction, string description, T parameters)
            where T : class
        {
            var toolName = "Tool" + (this.tools.Count + 1);
            this.tools.Add(
                toolName,
                (flowName, flowKind) => BuildToolBranch(rootAction, description, parameters, flowName, flowKind));
        }

        private static FlowTemplateActionToolBranch BuildToolBranch<T>(
            IWorkflowAction rootAction,
            string description,
            T parameters,
            string flowName,
            FlowKind? flowKind)
            where T : class
        {
            var actions = new Dictionary<string, FlowTemplateAction>();
            var visited = new Dictionary<string, IWorkflowAction>();
            var queue = new Queue<IWorkflowAction>();
            queue.Enqueue(rootAction);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (visited.ContainsKey(node.Name))
                {
                    if (!object.ReferenceEquals(visited[node.Name], node))
                    {
                        throw new InvalidOperationException(
                            $"Duplicate action name '{node.Name}' detected. Action names must be unique within a tool definition.");
                    }

                    continue;
                }

                visited.Add(node.Name, node);

                var definition = node.GetActionDefinition(flowName, flowKind);
                if (node.RunAfterConfig.Count > 0)
                {
                    definition.RunAfter = new Dictionary<string, FlowStatus[]>(node.RunAfterConfig);
                }

                actions[node.Name] = definition;

                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }

            var toolBranch = new FlowTemplateActionToolBranch
            {
                Actions = actions,
                Description = description,
            };

            if (parameters != null)
            {
                var descriptionToken = new JObject();
                toolBranch.AgentParameterSchema = TypeGenerator.GenerateSchema(parameters.GetType(), descriptionToken);
            }

            return toolBranch;
        }
    }
}
