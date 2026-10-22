// Copyright (c) Microsoft Corporation. All rights reserved.
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowAction<TConfiguration> :
        WorkflowActionBase,
        IWorkflowAction<TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        private readonly Func<WorkflowActionBase> factory;

        internal DeferredWorkflowAction(Func<WorkflowActionBase> factory)
            : this(factory, new TConfiguration())
        {
        }

        private DeferredWorkflowAction(
            Func<WorkflowActionBase> factory,
            TConfiguration configuration)
            : base(configuration)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this.Configuration = configuration;
        }

        public TConfiguration Configuration { get; }

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
        internal DeferredBodyAction(Func<WorkflowActionBase> factory)
            : base(factory) { }

        public T Body => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }

    internal sealed class DeferredOutputAction<T, TConfiguration> :
        DeferredWorkflowAction<TConfiguration>,
        IOutputWorkflowAction<T, TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredOutputAction(Func<WorkflowActionBase> factory)
            : base(factory) { }

        public T Output => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }

    internal sealed class DeferredVariableAction<TConfiguration> :
        DeferredWorkflowAction<TConfiguration>,
        IVariableWorkflowAction<TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredVariableAction(string name, Func<WorkflowActionBase> factory)
            : base(factory) => this.VariableName = name;

        public string VariableName { get; }

        public JToken Value => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
}
