// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Test variables workflow.
    /// </summary>
    public class VariablesWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the variables workflow definitions.
        /// </summary>
        public FlowPropertiesDefinition[] GetWorkflows()
        {
            var rootNode = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVariable",
                value: () => "variableValue");

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"Variable value after init: {variable.Value}");

            var setVariable = WorkflowActions.BuiltIn.Variables.SetVariable(
                name: () => "myVariable",
                value: () => "newValue");
            
            var compose2 = WorkflowActions.BuiltIn.Compose(inputs: () => $"Variable value after set: {variable.Value}");

            rootNode
                .Then(variable)
                .Then(compose)
                .Then(setVariable)
                .Then(compose2);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("VariablesWorkflow", rootNode) };
        }
    }
}
