// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides the base implementation for workflow action nodes. Concrete action types (such as
    /// HTTP actions, Compose actions, and custom code actions) inherit from this class to get
    /// automatic support for the fluent chaining API, name generation, and run-after configuration.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class implements <see cref="IWorkflowAction"/> and all four <see cref="IChainableNode.Then(IWorkflowAction)">Then</see>
    /// overloads. When <c>.Then()</c> is called on an action, the child action is added to <see cref="Children"/>
    /// and its <see cref="IWorkflowAction.RunAfterConfig"/> is updated to reference this action.
    /// </para>
    /// <para>
    /// Subclasses must implement <see cref="BuildActionDefinition"/> to produce the
    /// <see cref="FlowTemplateAction"/> that represents this action in the serialized workflow definition.
    /// The public <see cref="GetActionDefinition"/> method then applies common action configuration.
    /// </para>
    /// </remarks>
    /// <seealso cref="IWorkflowAction"/>
    public abstract class WorkflowActionBase<TConfiguration> :
        IWorkflowAction<TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal WorkflowActionBase()
        {
            this.Configuration = new TConfiguration();
        }

        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        public string Name { get; set; } = Utility.GetUniqueOperationName();

        /// <summary>
        /// Gets the child action nodes that run after this action.
        /// </summary>
        public List<IWorkflowAction> Children { get; } = new List<IWorkflowAction>();

        /// <summary>
        /// Gets the run-after configuration mapping parent action names to required statuses.
        /// </summary>
        public Dictionary<string, FlowStatus[]> RunAfterConfig { get; } = new Dictionary<string, FlowStatus[]>();

        public TConfiguration Configuration { get; }

        /// <summary>
        /// Gets the action definition as a FlowTemplateAction.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            var definition = this.BuildActionDefinition(flowName, flowKind)
                ?? throw new InvalidOperationException($"Action '{this.Name}' returned a null definition.");

            if (this.Configuration is IRetryPolicyConfigurationHolder retry &&
                retry.RetryPolicy != null)
            {
                WorkflowOperationConfiguration.ValidateRetryPolicy(retry.RetryPolicy, flowKind);
                WorkflowOperationConfiguration.AddRetryPolicy(definition, retry.RetryPolicy);
            }

            if (this.Configuration is ITrackedPropertiesConfigurationHolder tracked &&
                tracked.TrackedProperties.Count > 0)
            {
                definition.TrackedProperties = new JObject(
                    tracked.TrackedProperties.Select(
                        pair => new JProperty(pair.Key, pair.Value?.DeepClone())));
            }

            var secureInputs = this.Configuration is ISecureInputsConfigurationHolder inputs && inputs.SecureInputs;
            var secureOutputs =
                this.Configuration is ISecureInputsAndOutputsConfigurationHolder
                    ? secureInputs
                    : this.Configuration is ISecureOutputsConfigurationHolder outputs &&
                        outputs.SecureOutputs;

            var secureProperties = WorkflowOperationConfiguration.SecureProperties(secureInputs, secureOutputs);
            var concurrency = this.Configuration as IIterationConcurrencyConfigurationHolder;
            if (secureProperties.Length > 0 || concurrency?.MaximumParallelIterations.HasValue == true)
            {
                definition.RuntimeConfiguration ??= new FlowTemplateOperationRuntimeConfiguration();
            }

            if (secureProperties.Length > 0)
            {
                definition.RuntimeConfiguration.SecureData =
                    new FlowSecureDataConfiguration { Properties = secureProperties };
            }

            if (concurrency?.MaximumParallelIterations.HasValue == true)
            {
                if (flowKind == FlowKind.Stateless)
                {
                    throw new InvalidOperationException("For Each concurrency control is not supported for stateless workflows.");
                }
                definition.RuntimeConfiguration.Concurrency =
                    new FlowConcurrencyConfiguration { Repetitions = concurrency.MaximumParallelIterations };
            }

            return definition;
        }

        /// <summary>
        /// Builds the operation-specific action definition.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        internal abstract FlowTemplateAction BuildActionDefinition(
            string flowName,
            FlowKind? flowKind = null);

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Action cannot be null.");
            }
            action.RunAfterConfig[this.Name] = new[] { FlowStatus.Succeeded };
            this.Children.Add(action);

            return new OperationChain(this, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Action cannot be null.");
            }
            action.RunAfterConfig[this.Name] = runAfter ?? new[] { FlowStatus.Succeeded };
            this.Children.Add(action);

            return new OperationChain(this, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, RunAfter[] runAfter)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Action cannot be null.");
            }
            foreach (var ra in runAfter.CoalesceEnumerable())
            {
                if (string.IsNullOrEmpty(ra.ActionName))
                {
                    throw new InvalidOperationException($"A run-after dependency references an action with a null or empty name.");
                }
                action.RunAfterConfig[ra.ActionName] = ra.Status ?? new[] { FlowStatus.Succeeded };
            }
            this.Children.Add(action);

            return new OperationChain(this, action);
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
