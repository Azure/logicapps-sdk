// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    public class ServiceProviderAction : IWorkflowAction
    {
        /// <summary>
        /// API connection action input containing the details of the API call.
        /// </summary>
        private readonly ServiceProviderActionInput serviceProviderActionInput;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        public ServiceProviderAction(ServiceProviderActionInput serviceProviderActionInput)
        {
            this.serviceProviderActionInput = serviceProviderActionInput;
        }

        /// <summary>
        /// Gets the action definition as a JToken.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public FlowTemplateAction GetActionDefinition(string flowName)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.ServiceProvider,
                Inputs = this.serviceProviderActionInput.ToJToken(),
            };
        }
    }
}
