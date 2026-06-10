// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a service provider trigger in a workflow. Service provider triggers fire based
    /// on events from built-in service providers (e.g., Service Bus message received, SQL row inserted).
    /// </summary>
    public class ServiceProviderTrigger : WorkflowTriggerBase
    {
        /// <summary>
        /// The service provider action input containing the trigger configuration.
        /// </summary>
        private readonly ServiceProviderOperationInput serviceProviderTriggerInput;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderTrigger"/> class.
        /// </summary>
        /// <param name="serviceProviderTriggerInput">The service provider action input.</param>
        /// <param name="triggerName">The trigger name.</param>
        internal ServiceProviderTrigger(
            ServiceProviderOperationInput serviceProviderTriggerInput,
            string triggerName = null)
        {
            this.serviceProviderTriggerInput = serviceProviderTriggerInput;
            this.Name = triggerName ?? "ServiceProviderTrigger";
        }

        /// <summary>
        /// Gets the trigger definition as a flow template trigger.
        /// </summary>
        public override FlowTemplateTrigger GetTriggerDefinition()
        {
            return new FlowTemplateTrigger
            {
                Type = FlowTemplateOperationType.ServiceProvider,
                Inputs = this.serviceProviderTriggerInput.ToJToken(),
            };
        }
    }

    /// <summary>
    /// Represents a service provider trigger with a strongly-typed body output. Use this when the
    /// operation manifest declares outputs with a <c>body</c> property (i.e., <c>outputs.properties.body</c>).
    /// </summary>
    /// <typeparam name="T">The type of the body content produced by the trigger at runtime.</typeparam>
    public class ServiceProviderTrigger<T> : ServiceProviderTrigger, IBodyWorkflowTrigger<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderTrigger{T}"/> class.
        /// </summary>
        /// <param name="serviceProviderTriggerInput">The service provider action input.</param>
        /// <param name="triggerName">The trigger name.</param>
        internal ServiceProviderTrigger(
            ServiceProviderOperationInput serviceProviderTriggerInput,
            string triggerName = null)
            : base(serviceProviderTriggerInput, triggerName)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body output of this trigger.
        /// </summary>
        public T TriggerBody { get; private set; }
    }

    /// <summary>
    /// Represents a service provider trigger with a strongly-typed structured output that does
    /// not have a <c>body</c> wrapper. Use this when the operation manifest declares outputs with
    /// properties directly (i.e., <c>outputs.properties</c> exists but has no <c>body</c> key).
    /// </summary>
    /// <typeparam name="T">The type of the output value produced by the trigger at runtime.</typeparam>
    public class ServiceProviderOutputTrigger<T> : ServiceProviderTrigger, IOutputWorkflowTrigger<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderOutputTrigger{T}"/> class.
        /// </summary>
        /// <param name="serviceProviderTriggerInput">The service provider action input.</param>
        /// <param name="triggerName">The trigger name.</param>
        internal ServiceProviderOutputTrigger(
            ServiceProviderOperationInput serviceProviderTriggerInput,
            string triggerName = null)
            : base(serviceProviderTriggerInput, triggerName)
        {
        }

        /// <summary>
        /// Gets the strongly-typed output of this trigger.
        /// </summary>
        public T TriggerOutput { get; private set; }
    }
}
