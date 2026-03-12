// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Workflow builder for constructing a workflow with multiple actions.
    /// </summary>
    public class WorkflowBuilder : IWorkflowBuilder
    {
        /// <summary>
        /// Flow template that holds the workflow definition.
        /// </summary>
        private readonly FlowPropertiesDefinition definition;

        /// <summary>
        /// The name of the action that this workflow runs after.
        /// </summary>
        private string runAfterActionName;

        /// <summary>
        /// The flow name for the workflow.
        /// </summary>
        public string FlowName { get; private set; }

        /// <summary>
        /// The trigger.
        /// </summary>
        public IWorkflowTrigger Trigger { get; private set; }

        /// <summary>
        /// Flow template that holds the workflow definition.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger of the flow.</param>
        /// <param name="flowKind">The workflow kind.</param>
        public WorkflowBuilder(string flowName, IWorkflowTrigger trigger, FlowKind flowKind = FlowKind.Agent)
        {
            this.definition = new FlowPropertiesDefinition
            {
                Definition = new FlowTemplate
                {
                    Actions = new Dictionary<string, FlowTemplateAction>(),
                    Triggers = new Dictionary<string, FlowTemplateTrigger>(),
                    Schema = "https://schema.management.azure.com/schemas/2016-06-01/workflowdefinition.json#",
                },
                Kind = flowKind,
            };
            this.FlowName = flowName;
            this.Trigger = trigger;
            this.runAfterActionName = flowKind == FlowKind.Agent ? trigger.Name : null;
        }

        /// <summary>
        /// Adds a workflow action to the workflow.
        /// </summary>
        /// <param name="action">The workflow action.</param>
        /// <param name="actionName">The action name.</param>
        /// <param name="runAfterSpecifications">The runtime after specifications.</param>
        public void AddAction(IWorkflowAction action, string actionName = null, params RunAfterSpecification[] runAfterSpecifications)
        {
            var name = action.Name ?? actionName;
            if (string.IsNullOrEmpty(name))
            {
                name = Utility.GetUniqueActionName();
            }

            action.Name = name;
            var actionDefinition = action.GetActionDefinition(this.FlowName);

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
                    actionDefinition.RunAfter = runAfterDict;
                }
            }
            else if (actionDefinition.RunAfter == null &&
                     this.runAfterActionName != null &&
                     !this.runAfterActionName.Equals(default(KeyValuePair<string, FlowTemplateAction>)))
            {
                actionDefinition.RunAfter = new Dictionary<string, FlowStatus[]> { { this.runAfterActionName, new[] { FlowStatus.Succeeded } } };
            }

            this.definition.Definition.Actions.Add(name, actionDefinition);

            this.runAfterActionName = name;
        }

        /// <summary>
        /// Adds a workflow action to the workflow.
        /// </summary>
        /// <param name="action">The workflow action.</param>
        public void AddAgent(IWorkflowAction action)
        {
            this.AddAction(action);
        }

        /// <summary>
        /// Gets the flow definition that contains the workflow definition.
        /// </summary>
        public FlowPropertiesDefinition GetFlowDefinition()
        {
            this.definition.Definition.Triggers.Add(this.Trigger.Name, this.Trigger.GetTriggerDefinition());

            return this.definition;
        }
    }

    /// <summary>
    /// Workflow builder for constructing a workflow with multiple actions.
    /// </summary>
    /// <typeparam name="TTriggerOutput">The type of the trigger output.</typeparam>
    public class WorkflowBuilder<TTriggerOutput> : WorkflowBuilder, IWorkflowBuilder<TTriggerOutput>
    {
        /// <summary>
        /// Gets the trigger output.
        /// </summary>
        public TTriggerOutput TriggerOutput { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowBuilder{T}"/> class.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <param name="flowKind">The workflow kind.</param>
        internal WorkflowBuilder(string flowName, IOutputWorkflowTrigger<TTriggerOutput> trigger, FlowKind flowKind) : base(flowName, trigger, flowKind)
        {
            this.TriggerOutput = trigger.TriggerOutput;
        }
    }
}
