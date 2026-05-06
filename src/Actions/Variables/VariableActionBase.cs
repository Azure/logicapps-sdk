// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Base class for variable modification actions (Set, Increment, Decrement, Append).
    /// All share the same input shape: <c>{ name, value }</c>.
    /// </summary>
    public abstract class VariableActionBase : WorkflowActionBase
    {
        private readonly string variableName;
        private readonly JToken value;

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableActionBase"/> class.
        /// </summary>
        /// <param name="variableName">The variable name.</param>
        /// <param name="value">The value to apply.</param>
        protected VariableActionBase(string variableName, JToken value)
        {
            this.variableName = variableName;
            this.value = value;
        }

        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the operation type for this variable action.
        /// </summary>
        protected abstract FlowTemplateOperationType OperationType { get; }

        /// <summary>
        /// Gets the action definition for this variable action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName)
        {
            return new FlowTemplateAction
            {
                Type = this.OperationType,
                Inputs = new VariableActionInput
                {
                    Name = this.variableName,
                    Value = this.value,
                },
            };
        }
    }
}
