// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The InitializeVariable action declares and optionally sets the initial value of a workflow variable.
    /// </summary>
    public class InitializeVariableAction : WorkflowActionBase, IVariableWorkflowAction
    {
        private readonly string variableName;
        private readonly string variableType;
        private readonly JToken initialValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="InitializeVariableAction"/> class.
        /// </summary>
        /// <param name="variableName">The variable name.</param>
        /// <param name="variableType">The variable type (e.g., Integer, Float, Boolean, String, Array, Object).</param>
        /// <param name="initialValue">The initial value.</param>
        internal InitializeVariableAction(string variableName, string variableType, JToken initialValue)
        {
            this.variableName = variableName;
            this.variableType = variableType;
            this.initialValue = initialValue;
        }

        /// <summary>
        /// Gets the name of the variable.
        /// </summary>
        public string VariableName => this.variableName;

        /// <summary>
        /// Gets the variable value placeholder for use in expression trees.
        /// </summary>
        public JToken Value => this.initialValue;

        /// <summary>
        /// Gets the action definition for this InitializeVariable action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.InitializeVariable,
                Inputs = new InitializeVariableActionInput
                {
                    Variables = new[]
                    {
                        new VariableDefinitionEntry
                        {
                            Name = this.variableName,
                            Type = this.variableType,
                            Value = this.initialValue,
                        },
                    },
                },
            };
        }
    }
}
