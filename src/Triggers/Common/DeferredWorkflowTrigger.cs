// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowTrigger<TConfiguration> :
        WorkflowTriggerBase,
        IWorkflowTrigger<TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        private readonly Func<WorkflowTriggerBase> factory;

        internal DeferredWorkflowTrigger(Func<WorkflowTriggerBase> factory)
            : this(factory, new TConfiguration())
        {
        }

        private DeferredWorkflowTrigger(
            Func<WorkflowTriggerBase> factory,
            TConfiguration configuration)
            : base(configuration)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this.Configuration = configuration;
        }

        public TConfiguration Configuration { get; }

        internal override FlowTemplateTrigger BuildTriggerDefinition(FlowKind? flowKind = null) =>
            this.factory().BuildTriggerDefinition(flowKind);
    }

    internal sealed class DeferredBodyTrigger<T, TConfiguration> :
        DeferredWorkflowTrigger<TConfiguration>,
        IBodyWorkflowTrigger<T, TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredBodyTrigger(Func<WorkflowTriggerBase> factory)
            : base(factory) { }

        public T TriggerBody => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }

    internal sealed class DeferredOutputTrigger<T, TConfiguration> :
        DeferredWorkflowTrigger<TConfiguration>,
        IOutputWorkflowTrigger<T, TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredOutputTrigger(Func<WorkflowTriggerBase> factory)
            : base(factory) { }

        public T TriggerOutput => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
}
