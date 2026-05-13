// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    public class ServiceProviderAction : WorkflowActionBase
    {
        /// <summary>
        /// Service provider action input containing the details of the API call.
        /// </summary>
        private readonly ServiceProviderActionInput serviceProviderActionInput;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderAction"/> class.
        /// </summary>
        /// <param name="serviceProviderActionInput">The service provider action input.</param>
        internal ServiceProviderAction(ServiceProviderActionInput serviceProviderActionInput)
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
                Inputs = this.serviceProviderActionInput.ToJToken(),
            };
        }
    }
}
