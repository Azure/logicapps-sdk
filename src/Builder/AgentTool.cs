// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Runtime;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Represents an agent tool with configurable parameters and actions.
    /// </summary>
    /// <typeparam name="T">The type of the tool parameters.</typeparam>
    public class AgentTool<T> : IAgentToolBuilder<T> where T : class
    {
        /// <summary>
        /// Actions tool branch.
        /// </summary>
        private readonly FlowTemplateActionToolBranch flowTemplateActionToolBranch = new FlowTemplateActionToolBranch()
        {
            Actions = new Dictionary<string, FlowTemplateAction>(),
        };

        /// <summary>
        /// Gets or sets the name of the tool.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the tool.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the tool.
        /// </summary>
        public T Parameters { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTool{T}"/> class.
        /// </summary>
        public AgentTool()
        {
        }

        /// <summary>
        /// Gets the flow template action tool branch with generated schema for parameters.
        /// </summary>
        public (string, FlowTemplateActionToolBranch) GetFlowTemplateActionToolBranch()
        {
            if (this.Parameters != null)
            {
                var desc = new JObject();
                var schema = TypeGenerator.GenerateSchema(this.Parameters.GetType(), desc);
                this.flowTemplateActionToolBranch.AgentParameterSchema = schema;
            }

            this.flowTemplateActionToolBranch.Description = this.Description;

            return (this.Name, this.flowTemplateActionToolBranch);
        }

        /// <summary>
        /// Adds a workflow action to the tool's action branch.
        /// </summary>
        /// <param name="action">The workflow action to add.</param>
        /// <param name="actionName">The name to assign to the action. If not provided, a generated unique name will be used (optional).</param>
        /// <param name="runAfterSpecifications">Specifies dependencies indicating which actions this action should run after and under which conditions (optional).</param>
        public void AddAction(IWorkflowAction action, string actionName = null, params RunAfterSpecification[] runAfterSpecifications)
        {
            var name = actionName;
            if (string.IsNullOrEmpty(name))
            {
                name = Utility.GetUniqueActionName();
                action.WithName(name);
            }

            var definition = action.GetActionDefinition();

            // If runAfterSpecifications are provided, use them to build the RunAfter dictionary.
            if (runAfterSpecifications != null && runAfterSpecifications.Length > 0)
            {
                var runAfterDict = new Dictionary<string, FlowStatus[]>();
                foreach (var spec in runAfterSpecifications)
                {
                    if (spec?.Action?.Name != null && spec.Status != null)
                    {
                        runAfterDict[spec.Action.Name] = spec.Status;
                    }
                }
                if (runAfterDict.Count > 0)
                {
                    definition.RunAfter = runAfterDict;
                }
            }
            // Otherwise, use the default logic for chaining to previous action.
            else
            {
                var previousAction = this.flowTemplateActionToolBranch.Actions.LastOrDefault();
                if (definition.RunAfter == null &&
                    !previousAction.Equals(default(KeyValuePair<string, FlowTemplateAction>)))
                {
                    definition.RunAfter = new Dictionary<string, FlowStatus[]>
                    {
                        { previousAction.Key, new[] { FlowStatus.Succeeded } }
                    };
                }
            }

            this.flowTemplateActionToolBranch.Actions.Add(name, definition);
        }
    }
}
