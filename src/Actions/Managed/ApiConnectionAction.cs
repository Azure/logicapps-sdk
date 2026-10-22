// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    public sealed class ApiConnectionActionConfiguration :
        IWorkflowOperationConfiguration,
        IRetryPolicyConfigurationHolder,
        ITrackedPropertiesConfigurationHolder,
        ISecureInputsConfigurationHolder,
        ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    /// <summary>
    /// Represents an action that performs an API connection operation in a workflow.
    /// </summary>
    public class ApiConnectionAction : WorkflowActionBase<ApiConnectionActionConfiguration>
    {
        /// <summary>
        /// API connection action input.
        /// </summary>
        private readonly ApiConnectionActionInput apiConnectionActionInput;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiConnectionAction"/> class.
        /// </summary>
        /// <param name="apiConnectionActionInput">The API connection action input.</param>
        internal ApiConnectionAction(ApiConnectionActionInput apiConnectionActionInput)
        {
            this.apiConnectionActionInput = apiConnectionActionInput;
        }

        /// <summary>
        /// Gets the action definition for this API connection action.
        /// </summary>
        /// <returns>
        /// A <see cref="FlowTemplateAction"/> representing the API connection operation to be performed in the workflow.
        /// </returns>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        internal override FlowTemplateAction BuildActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.ApiConnection,
                Inputs = this.apiConnectionActionInput,
            };
        }
    }

    /// <summary>
    /// Represents an API connection action with a strongly-typed output body.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class ApiConnectionAction<T> :
        ApiConnectionAction,
        IBodyWorkflowAction<T, ApiConnectionActionConfiguration>
    {
        internal ApiConnectionAction(ApiConnectionActionInput apiConnectionActionInput)
            : base(apiConnectionActionInput)
        {
        }

        public T Body { get; private set; }
    }
}
