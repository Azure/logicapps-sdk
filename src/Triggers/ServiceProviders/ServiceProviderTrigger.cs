// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a service provider trigger in a workflow. Service provider triggers fire based
    /// on events from built-in service providers (e.g., Service Bus message received, SQL row inserted).
    /// </summary>
    public class ServiceProviderTrigger<TConfiguration> :
        WorkflowTriggerBase<TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        /// <summary>
        /// The service provider action input containing the trigger configuration.
        /// </summary>
        private readonly ServiceProviderOperationInput serviceProviderTriggerInput;

        /// <summary>
        /// Whether this trigger uses polling semantics.
        /// </summary>
        private readonly bool isPolling;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderTrigger"/> class.
        /// </summary>
        /// <param name="serviceProviderTriggerInput">The service provider action input.</param>
        /// <param name="isPolling">Whether this trigger uses polling semantics.</param>
        internal ServiceProviderTrigger(
            ServiceProviderOperationInput serviceProviderTriggerInput,
            bool isPolling = false)
        {
            this.serviceProviderTriggerInput = serviceProviderTriggerInput;
            this.isPolling = isPolling;
            this.Name = "ServiceProviderTrigger";
        }

        /// <summary>
        /// Gets the trigger definition as a flow template trigger.
        /// </summary>
        internal override FlowTemplateTrigger BuildTriggerDefinition(FlowKind? flowKind = null)
        {
            return new FlowTemplateTrigger
            {
                Type = FlowTemplateOperationType.ServiceProvider,
                Kind = this.isPolling
                    ? FlowTemplateOperationKind.Polling
                    : null,
                Inputs = this.serviceProviderTriggerInput.ToJToken(),
            };
        }
    }

    /// <summary>
    /// Represents a service provider trigger with a strongly-typed body output. Use this when the
    /// operation manifest declares outputs with a <c>body</c> property (i.e., <c>outputs.properties.body</c>).
    /// </summary>
    /// <typeparam name="T">The type of the body content produced by the trigger at runtime.</typeparam>
    public class ServiceProviderBodyTrigger<T, TConfiguration> :
        ServiceProviderTrigger<TConfiguration>,
        IBodyWorkflowTrigger<T, TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderTrigger{T}"/> class.
        /// </summary>
        /// <param name="serviceProviderTriggerInput">The service provider action input.</param>
        /// <param name="isPolling">Whether this trigger uses polling semantics.</param>
        internal ServiceProviderBodyTrigger(
            ServiceProviderOperationInput serviceProviderTriggerInput,
            bool isPolling = false)
            : base(serviceProviderTriggerInput, isPolling)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body output of this trigger.
        /// </summary>
        public T TriggerBody { get; private set; }
    }

}
