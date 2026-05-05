// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// The compose action allows combining multiple inputs into a single output.
    /// </summary>
    public class CSharpScriptCode(Delegate callback) : WorkflowActionBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string MethodName { get; private set; } = callback.Method.Name;

        /// <summary>
        /// Gets the action definition for this nested workflow action.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateAction"/> representing the nested workflow call.</returns>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            ScriptExecutor.SaveCustomCodeMethodInfo(
                workflowName: flowName,
                callback: callback);

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.CSharpScriptCode,
                Inputs = new CSharpScriptCodeActionInput
                {
                    UserFunctionName = callback.Method.Name,
                },
            };
        }
    }

    /// <summary>
    /// Represents a nested workflow action with a strongly-typed output body.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class CSharpScriptCode<T> : CSharpScriptCode, IBodyWorkflowAction<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSharpScriptCode{T}"/> class.
        /// </summary>
        public CSharpScriptCode(Func<WorkflowContext, Task<T>> callback) : base(callback)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body of the action.
        /// </summary>
        public T Body { get; private set; }
    }
}
