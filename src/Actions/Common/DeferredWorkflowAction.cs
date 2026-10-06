// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowAction : WorkflowActionBase
    {
        private readonly Func<IWorkflowAction> factory;
        internal DeferredWorkflowAction(Func<IWorkflowAction> factory) => this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) => this.factory().GetActionDefinition(flowName, flowKind);
    }
    internal sealed class DeferredBodyAction<T> : DeferredWorkflowAction, IBodyWorkflowAction<T>
    {
        internal DeferredBodyAction(Func<IWorkflowAction> factory) : base(factory) { }
        public T Body => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
    internal sealed class DeferredOutputAction<T> : DeferredWorkflowAction, IOutputWorkflowAction<T>
    {
        internal DeferredOutputAction(Func<IWorkflowAction> factory) : base(factory) { }
        public T Output => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
    internal sealed class DeferredVariableAction : DeferredWorkflowAction, IVariableWorkflowAction
    {
        internal DeferredVariableAction(string name, Func<IWorkflowAction> factory) : base(factory) => this.VariableName = name;
        public string VariableName { get; }
        public Newtonsoft.Json.Linq.JToken Value => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
}
