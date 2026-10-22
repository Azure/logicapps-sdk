// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowTrigger<TConfiguration> :
        WorkflowTriggerBase<TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        private readonly Func<WorkflowTriggerBase<TConfiguration>> factory;

        internal DeferredWorkflowTrigger(Func<WorkflowTriggerBase<TConfiguration>> factory)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        internal override FlowTemplateTrigger BuildTriggerDefinition(FlowKind? flowKind = null) =>
            this.factory().BuildTriggerDefinition(flowKind);
    }

    internal sealed class DeferredBodyTrigger<T, TConfiguration> :
        DeferredWorkflowTrigger<TConfiguration>,
        IBodyWorkflowTrigger<T, TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredBodyTrigger(Func<WorkflowTriggerBase<TConfiguration>> factory)
            : base(factory) { }

        public T TriggerBody => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }

    internal sealed class DeferredOutputTrigger<T, TConfiguration> :
        DeferredWorkflowTrigger<TConfiguration>,
        IOutputWorkflowTrigger<T, TConfiguration>
        where TConfiguration : class, IWorkflowOperationConfiguration, new()
    {
        internal DeferredOutputTrigger(Func<WorkflowTriggerBase<TConfiguration>> factory)
            : base(factory) { }

        public T TriggerOutput => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
}
