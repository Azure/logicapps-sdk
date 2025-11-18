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
        public string Name { get; private set; }

        public ServiceProviderAction(ServiceProviderActionInput serviceProviderActionInput)
        {
            this.serviceProviderActionInput = serviceProviderActionInput;
        }

        public void WithName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the action definition as a JToken.
        /// </summary>
        public FlowTemplateAction GetActionDefinition()
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.ServiceProvider,
                Inputs = this.serviceProviderActionInput.ToJToken(),
            };
        }
    }
}
