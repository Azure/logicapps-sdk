// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowTrigger : WorkflowTriggerBase
    {
        private readonly Func<IWorkflowTrigger> build;
        internal DeferredWorkflowTrigger(Func<IWorkflowTrigger> build, string name)
        {
            this.build = build;
            this.Name = name ?? "ApiConnectionTrigger";
        }
        public override FlowTemplateTrigger GetTriggerDefinition() => this.build().GetTriggerDefinition();
    }

    internal sealed class DeferredBodyTrigger<T> : DeferredWorkflowTrigger, IBodyWorkflowTrigger<T>
    {
        internal DeferredBodyTrigger(Func<IWorkflowTrigger> build, string name) : base(build, name) { }
        public T TriggerBody => throw new InvalidOperationException("Workflow values are only available inside source-compiled expressions.");
    }

    internal sealed class DeferredOutputTrigger<T> : DeferredWorkflowTrigger, IOutputWorkflowTrigger<T>
    {
        internal DeferredOutputTrigger(Func<IWorkflowTrigger> build, string name) : base(build, name) { }
        public T TriggerOutput => throw new InvalidOperationException("Workflow values are only available inside source-compiled expressions.");
    }
}
