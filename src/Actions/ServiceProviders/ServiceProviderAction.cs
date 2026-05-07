// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    public class ServiceProviderAction : WorkflowActionBase
    {
        /// <summary>
        /// API connection action input containing the details of the API call.
        /// </summary>
        private readonly ServiceProviderActionInput serviceProviderActionInput;

        public ServiceProviderAction(ServiceProviderActionInput serviceProviderActionInput)
        {
            this.serviceProviderActionInput = serviceProviderActionInput;
        }

        /// <summary>
        /// Gets the action definition as a JToken.
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
