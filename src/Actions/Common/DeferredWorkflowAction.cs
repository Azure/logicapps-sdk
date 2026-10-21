// Copyright (c) Microsoft Corporation. All rights reserved.
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk
{
    internal class DeferredWorkflowAction : WorkflowActionBase
    {
        private readonly Func<IWorkflowAction> factory;

        internal DeferredWorkflowAction(
            Func<IWorkflowAction> factory,
            WorkflowActionSettingProfile settingsProfile = WorkflowActionSettingProfile.None)
            : base(settingsProfile)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override FlowTemplateAction BuildActionDefinition(string flowName, FlowKind? flowKind = null) => this.factory().GetActionDefinition(flowName, flowKind);
    }

    internal sealed class DeferredBodyAction<T> : DeferredWorkflowAction, IBodyWorkflowAction<T>
    {
        internal DeferredBodyAction(
            Func<IWorkflowAction> factory,
            WorkflowActionSettingProfile settingsProfile = WorkflowActionSettingProfile.None)
            : base(factory, settingsProfile) { }

        public T Body => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }

    internal sealed class DeferredOutputAction<T> : DeferredWorkflowAction, IOutputWorkflowAction<T>
    {
        internal DeferredOutputAction(
            Func<IWorkflowAction> factory,
            WorkflowActionSettingProfile settingsProfile = WorkflowActionSettingProfile.None)
            : base(factory, settingsProfile) { }

        public T Output => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
    internal sealed class DeferredVariableAction : DeferredWorkflowAction, IVariableWorkflowAction
    {
        internal DeferredVariableAction(
            string name,
            Func<IWorkflowAction> factory,
            WorkflowActionSettingProfile settingsProfile = WorkflowActionSettingProfile.None)
            : base(factory, settingsProfile) => this.VariableName = name;
        public string VariableName { get; }
        public JToken Value => throw new InvalidOperationException("Workflow data is available only inside a compiled value expression.");
    }
}
