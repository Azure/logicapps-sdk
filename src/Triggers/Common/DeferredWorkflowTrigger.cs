// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowTrigger : WorkflowTriggerBase
    {
        private readonly Func<WorkflowTriggerBase> factory;

        internal DeferredWorkflowTrigger(
            Func<WorkflowTriggerBase> factory,
            WorkflowTriggerSettings settingsProfile = WorkflowTriggerSettings.None)
            : base(settingsProfile) =>
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));

        protected internal override FlowTemplateTrigger BuildTriggerDefinition(FlowKind? flowKind = null) =>
            this.factory().BuildTriggerDefinition(flowKind);
    }

    internal sealed class DeferredBodyTrigger<T> : DeferredWorkflowTrigger, IBodyWorkflowTrigger<T>
    {
        internal DeferredBodyTrigger(
            Func<WorkflowTriggerBase> factory,
            WorkflowTriggerSettings settingsProfile = WorkflowTriggerSettings.None)
            : base(factory, settingsProfile) { }

        public T TriggerBody => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }

    internal sealed class DeferredOutputTrigger<T> : DeferredWorkflowTrigger, IOutputWorkflowTrigger<T>
    {
        internal DeferredOutputTrigger(
            Func<WorkflowTriggerBase> factory,
            WorkflowTriggerSettings settingsProfile = WorkflowTriggerSettings.None)
            : base(factory, settingsProfile) { }

        public T TriggerOutput => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
}
