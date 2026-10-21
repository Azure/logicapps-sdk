// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides the base implementation for workflow trigger nodes. Concrete trigger types (such as
    /// HTTP request triggers, recurrence triggers, and conversational agent triggers) inherit from
    /// this class to get automatic support for the fluent chaining API and name generation.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class implements <see cref="IWorkflowTrigger"/> and all four <see cref="IChainableNode.Then(IWorkflowAction)">Then</see>
    /// overloads. When <c>.Then()</c> is called on a trigger, the action is added to <see cref="Children"/>.
    /// Note that the <c>Then</c> overloads accepting <see cref="FlowStatus"/>[] or <see cref="RunAfter"/>[]
    /// throw <see cref="InvalidOperationException"/>, because run-after conditions cannot be specified
    /// on the first action directly after a trigger.
    /// </para>
    /// <para>
    /// Subclasses must implement <see cref="BuildTriggerDefinition"/> to produce the
    /// <see cref="FlowTemplateTrigger"/> that represents this trigger in the serialized workflow definition.
    /// The public <see cref="GetTriggerDefinition"/> method then applies common trigger configuration.
    /// </para>
    /// </remarks>
    /// <seealso cref="IWorkflowTrigger"/>
    /// <seealso cref="WorkflowActionBase"/>
    public abstract class WorkflowTriggerBase : IWorkflowTrigger
    {
        /// <summary>
        /// Initializes a workflow trigger without optional settings.
        /// </summary>
        protected WorkflowTriggerBase()
            : this(WorkflowTriggerSettingProfile.None)
        {
        }

        /// <summary>
        /// Initializes a new workflow trigger.
        /// </summary>
        /// <param name="settingsProfile">The settings supported by the trigger.</param>
        internal WorkflowTriggerBase(
            WorkflowTriggerSettingProfile settingsProfile = WorkflowTriggerSettingProfile.None)
        {
            this.Configuration = new WorkflowTriggerConfiguration(settingsProfile);
        }

        /// <summary>
        /// Gets or sets the name of the trigger.
        /// </summary>
        public string Name { get; set; } = Utility.GetUniqueOperationName(isTrigger: true);

        /// <summary>
        /// Gets the child action nodes that run after this trigger.
        /// </summary>
        public List<IWorkflowAction> Children { get; } = new List<IWorkflowAction>();

        /// <inheritdoc/>
        public WorkflowTriggerConfiguration Configuration { get; }

        /// <summary>
        /// Gets the trigger definition for the workflow.
        /// </summary>
        /// <param name="flowKind">The kind of workflow containing the trigger.</param>
        public FlowTemplateTrigger GetTriggerDefinition(FlowKind? flowKind = null)
        {
            var definition = this.BuildTriggerDefinition(flowKind)
                ?? throw new InvalidOperationException($"Trigger '{this.Name}' returned a null definition.");

            if (this.Configuration.RetryPolicy != null)
            {
                WorkflowOperationConfiguration.ValidateRetryPolicy(this.Configuration.RetryPolicy, flowKind);
                WorkflowOperationConfiguration.AddRetryPolicy(definition, this.Configuration.RetryPolicy);
            }

            var secureProperties = WorkflowOperationConfiguration.SecureProperties(this.Configuration.SecureInputs, this.Configuration.SecureOutputs);
            if (secureProperties.Length > 0 || this.Configuration.ConcurrentRuns.HasValue)
            {
                definition.RuntimeConfiguration ??= new FlowTemplateOperationRuntimeConfiguration();
            }

            if (secureProperties.Length > 0)
            {
                definition.RuntimeConfiguration.SecureData =
                    new FlowSecureDataConfiguration { Properties = secureProperties };
            }

            if (this.Configuration.ConcurrentRuns.HasValue)
            {
                if (flowKind == FlowKind.Stateless)
                {
                    throw new InvalidOperationException("Trigger concurrency control is not supported for stateless workflows.");
                }
                definition.RuntimeConfiguration.Concurrency = new FlowConcurrencyConfiguration
                {
                    Runs = this.Configuration.ConcurrentRuns,
                    MaximumWaitingRuns = this.Configuration.MaximumWaitingRuns,
                };
            }

            if (this.Configuration.ClientTrackingId != null)
            {
                definition.Correlation =
                    new FlowTemplateCorrelation { ClientTrackingId = this.Configuration.ClientTrackingId };
            }

            if (this.Configuration.SchemaValidationEnabled)
            {
                var inputs = WorkflowOperationConfiguration.ToObject(definition.Inputs);
                if (inputs["schema"] == null || inputs["schema"].Type == JTokenType.Null)
                {
                    throw new InvalidOperationException("Schema validation requires a request body JSON schema.");
                }
                definition.OperationOptions =
                    (definition.OperationOptions ?? OperationOptions.None) |
                    OperationOptions.EnableSchemaValidation;
            }

            return definition;
        }

        /// <summary>
        /// Builds the operation-specific trigger definition.
        /// </summary>
        /// <param name="flowKind">The kind of workflow containing the trigger.</param>
        protected abstract FlowTemplateTrigger BuildTriggerDefinition(FlowKind? flowKind = null);

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Action cannot be null.");
            }
            this.Children.Add(action);
            return new OperationChain(this, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter)
        {
            throw new InvalidOperationException("Run-after conditions cannot be specified on the first action after a trigger. The first action runs when the trigger fires.");
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, RunAfter[] runAfter)
        {
            throw new InvalidOperationException("Run-after conditions cannot be specified on the first action after a trigger. The first action runs when the trigger fires.");
        }

        /// <inheritdoc/>
        public OperationChain Then(Func<IChainableNode, OperationChain[]> branches)
        {
            if (branches == null)
            {
                throw new ArgumentNullException(nameof(branches));
            }

            var branchesArr = branches.Invoke(this)
                ?? throw new InvalidOperationException("Branches must not be null.");

            if (branchesArr.Length == 0)
            {
                throw new InvalidOperationException("At least one branch is required.");
            }

            var allEnds = new List<IWorkflowOperation>();

            foreach (var branch in branchesArr)
            {
                if (branch == null)
                {
                    throw new InvalidOperationException("Null branch is not allowed.");
                }

                if (!object.ReferenceEquals(this, branch.Start))
                {
                    throw new InvalidOperationException("All branches must share the same root as the parent chain.");
                }

                foreach (var end in branch.Ends)
                {
                    if (!allEnds.Contains(end))
                    {
                        allEnds.Add(end);
                    }
                }
            }

            return new OperationChain(this, allEnds.ToArray());
        }

        /// <inheritdoc/>
        public IWorkflowOperation GetRootOperation()
        {
            return this;
        }
    }
}
