// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using Newtonsoft.Json.Linq;

    // Only SDK-owned definition builders are retained here. User graph factories run once at construction.
    internal class DeferredWorkflowAction : WorkflowActionBase
    {
        private readonly Func<IWorkflowAction> createAction;

        internal DeferredWorkflowAction(Func<IWorkflowAction> createAction) =>
            this.createAction = createAction ?? throw new ArgumentNullException(nameof(createAction));

        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) =>
            this.createAction().GetActionDefinition(flowName, flowKind);
    }

    internal sealed class DeferredOutputAction<T> : DeferredWorkflowAction, IOutputWorkflowAction<T>
    {
        internal DeferredOutputAction(Func<IWorkflowAction> createAction) : base(createAction) { }
        public T Output => throw new InvalidOperationException("Workflow outputs can only be referenced inside source-compiled workflow expressions.");
    }

    internal sealed class DeferredBodyAction<T> : DeferredWorkflowAction, IBodyWorkflowAction<T>
    {
        internal DeferredBodyAction(Func<IWorkflowAction> createAction) : base(createAction) { }
        public T Body => throw new InvalidOperationException("Workflow bodies can only be referenced inside source-compiled workflow expressions.");
    }

    internal sealed class DeferredVariableAction : DeferredWorkflowAction, IVariableWorkflowAction
    {
        private readonly Func<string> name;
        internal DeferredVariableAction(Func<string> name, Func<IWorkflowAction> createAction) : base(createAction) => this.name = name;
        public string VariableName => SourceExpressionConverter.ConvertO(this.name);
        public JToken Value => throw new InvalidOperationException("Workflow variables can only be referenced inside source-compiled workflow expressions.");
    }
}
