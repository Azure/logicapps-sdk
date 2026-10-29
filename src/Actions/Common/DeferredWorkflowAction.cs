// Copyright (c) Microsoft Corporation. All rights reserved.
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowAction<TConfiguration> :
        WorkflowActionBase<TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        private readonly Func<WorkflowActionBase<TConfiguration>> factory;

        internal DeferredWorkflowAction(Func<WorkflowActionBase<TConfiguration>> factory)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        internal override FlowTemplateAction BuildActionDefinition(
            string flowName,
            FlowKind? flowKind = null) =>
            this.factory().BuildActionDefinition(flowName, flowKind);
    }

    internal sealed class DeferredBodyAction<T, TConfiguration> :
        DeferredWorkflowAction<TConfiguration>,
        IBodyWorkflowAction<T, TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredBodyAction(Func<WorkflowActionBase<TConfiguration>> factory)
            : base(factory) { }

        public T Body => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }

    internal sealed class DeferredOutputAction<T, TConfiguration> :
        DeferredWorkflowAction<TConfiguration>,
        IOutputWorkflowAction<T, TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredOutputAction(Func<WorkflowActionBase<TConfiguration>> factory)
            : base(factory) { }

        public T Output => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }

    internal sealed class DeferredVariableAction<TConfiguration> :
        DeferredWorkflowAction<TConfiguration>,
        IVariableWorkflowAction<TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredVariableAction(string name, Func<WorkflowActionBase<TConfiguration>> factory)
            : base(factory) => this.VariableName = name;

        public string VariableName { get; }

        public JToken Value => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
}
