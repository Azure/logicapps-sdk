// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    internal class DeferredWorkflowAction : WorkflowActionBase
    {
        private readonly Func<IWorkflowAction> build;
        internal DeferredWorkflowAction(Func<IWorkflowAction> build) => this.build = build;
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) =>
            this.build().GetActionDefinition(flowName, flowKind);
    }

    internal sealed class DeferredBodyAction<T> : DeferredWorkflowAction, IBodyWorkflowAction<T>
    {
        internal DeferredBodyAction(Func<IWorkflowAction> build) : base(build) { }
        public T Body => throw new InvalidOperationException("Workflow values are only available inside source-compiled expressions.");
    }

    internal sealed class DeferredOutputAction<T> : DeferredWorkflowAction, IOutputWorkflowAction<T>
    {
        internal DeferredOutputAction(Func<IWorkflowAction> build) : base(build) { }
        public T Output => throw new InvalidOperationException("Workflow values are only available inside source-compiled expressions.");
    }

    internal sealed class DeferredVariableAction : DeferredWorkflowAction, IVariableWorkflowAction
    {
        internal DeferredVariableAction(string name, Func<IWorkflowAction> build) : base(build) => this.VariableName = name;
        public string VariableName { get; }
        public JToken Value => throw new InvalidOperationException("Workflow variables are only available inside source-compiled expressions.");
    }
}
