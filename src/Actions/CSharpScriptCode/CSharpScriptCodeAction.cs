// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// The compose action allows combining multiple inputs into a single output.
    /// </summary>
    public class CSharpScriptCode(string methodName) : IWorkflowAction
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string MethodName { get; private set; } = methodName;

        /// <summary>
        /// Gets the action definition for this nested workflow action.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateAction"/> representing the nested workflow call.</returns>
        public FlowTemplateAction GetActionDefinition()
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.CSharpScriptCode,
                Inputs = new CSharpScriptCodeActionInput
                {
                    CodeFile = this.MethodName,
                },
            };
        }

        /// <summary>
        /// Sets the name of the nested flow action.
        /// </summary>
        /// <param name="name"></param>
        public void WithName(string name)
        {
            this.Name = name;
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
        public CSharpScriptCode(string methodName) : base(methodName)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body of the action.
        /// </summary>
        public T Body { get; private set; }
    }
}
