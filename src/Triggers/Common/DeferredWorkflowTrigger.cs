// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowTrigger : WorkflowTriggerBase
    {
        private readonly Func<IWorkflowTrigger> factory;
        internal DeferredWorkflowTrigger(Func<IWorkflowTrigger> factory, string name)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this.Name = name ?? "ApiConnectionTrigger";
        }
        public override FlowTemplateTrigger GetTriggerDefinition() => this.factory().GetTriggerDefinition();
    }
    internal sealed class DeferredBodyTrigger<T> : DeferredWorkflowTrigger, IBodyWorkflowTrigger<T>
    {
        internal DeferredBodyTrigger(Func<IWorkflowTrigger> factory, string name) : base(factory, name) { }
        public T TriggerBody => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
    internal sealed class DeferredOutputTrigger<T> : DeferredWorkflowTrigger, IOutputWorkflowTrigger<T>
    {
        internal DeferredOutputTrigger(Func<IWorkflowTrigger> factory, string name) : base(factory, name) { }
        public T TriggerOutput => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
}
