// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents an action that performs a service provider operation in a workflow.
    /// </summary>
    public class ServiceProviderAction : WorkflowActionBase
    {
        /// <summary>
        /// Service provider action input containing the details of the API call.
        /// </summary>
        private readonly Func<ServiceProviderOperationInput> serviceProviderActionInput;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderAction"/> class.
        /// </summary>
        /// <param name="serviceProviderActionInput">The service provider action input.</param>
        internal ServiceProviderAction(Func<ServiceProviderOperationInput> serviceProviderActionInput)
        {
            this.serviceProviderActionInput = serviceProviderActionInput;
        }

        /// <summary>
        /// Gets the action definition for this service provider action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.ServiceProvider,
                Inputs = this.serviceProviderActionInput().ToJToken(),
            };
        }
    }

    /// <summary>
    /// Represents a service provider action with a strongly-typed output body. Use this when the
    /// operation manifest declares outputs with a <c>body</c> property (i.e., <c>outputs.properties.body</c>).
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class ServiceProviderAction<T> : ServiceProviderAction, IBodyWorkflowAction<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderAction{T}"/> class.
        /// </summary>
        /// <param name="serviceProviderActionInput">The service provider action input.</param>
        internal ServiceProviderAction(Func<ServiceProviderOperationInput> serviceProviderActionInput)
            : base(serviceProviderActionInput)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body output of this action.
        /// </summary>
        public T Body { get; private set; }
    }

    /// <summary>
    /// Represents a service provider action with a strongly-typed structured output that does
    /// not have a <c>body</c> wrapper. Use this when the operation manifest declares outputs with
    /// properties directly (i.e., <c>outputs.properties</c> exists but has no <c>body</c> key).
    /// </summary>
    /// <typeparam name="T">The type of the output value returned by the action.</typeparam>
    public class ServiceProviderOutputAction<T> : ServiceProviderAction, IOutputWorkflowAction<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderOutputAction{T}"/> class.
        /// </summary>
        /// <param name="serviceProviderActionInput">The service provider action input.</param>
        internal ServiceProviderOutputAction(Func<ServiceProviderOperationInput> serviceProviderActionInput)
            : base(serviceProviderActionInput)
        {
        }

        /// <summary>
        /// Gets the strongly-typed output of this action.
        /// </summary>
        public T Output { get; private set; }
    }
}
