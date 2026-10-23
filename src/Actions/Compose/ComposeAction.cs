// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    public sealed class ComposeActionConfiguration :
        ITrackedPropertiesConfiguration,
        ISecureInputsAndOutputsConfiguration
    {
        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
    }

    /// <summary>
    /// The compose action allows combining multiple inputs into a single output.
    /// </summary>
    public class ComposeAction : WorkflowActionBase<ComposeActionConfiguration>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public JToken Inputs { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComposeAction"/> class.
        /// </summary>
        /// <param name="inputs">The inputs for the compose action.</param>
        internal ComposeAction(JToken inputs)
        {
            this.Inputs = inputs;
        }

        /// <summary>
        /// Gets the action definition for this compose action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        internal override FlowTemplateAction BuildActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Compose,
                Inputs = this.Inputs,
            };
        }
    }

    /// <summary>
    /// Represents a compose action with a strongly-typed output.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class ComposeAction<T> : ComposeAction, IOutputWorkflowAction<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComposeAction{T}"/> class.
        /// </summary>
        internal ComposeAction(JToken inputs) : base(inputs)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body of the action.
        /// </summary>
        public T Output { get; private set; }
    }
}
