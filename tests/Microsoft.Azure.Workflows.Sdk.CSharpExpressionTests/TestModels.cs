// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Collections.Generic;
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Simple POCO used to exercise object/member-init conversion paths.
    /// Mirrors the model in the Logic App expression test project.
    /// </summary>
    public class Poco
    {
        public string Name { get; set; }

        public int Count { get; set; }

        [JsonProperty("renamed")]
        public string Tag { get; set; }

        public NestedPoco Nested { get; set; }

        public List<NestedPoco> Items { get; set; }
    }

    public class NestedPoco
    {
        public string Value { get; set; }
    }

    public class Envelope<T>
    {
        public T Value { get; set; }
    }

    public class OuterPoco
    {
        public class NestedPoco
        {
            public string Value { get; set; }
        }
    }

    internal sealed class TestBodyWorkflowAction<T> : WorkflowActionBase, IBodyWorkflowAction<T>
    {
        internal TestBodyWorkflowAction(string name)
        {
            this.Name = name;
        }

        public T Body { get; }

        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) =>
            new FlowTemplateAction();
    }

    internal sealed class TestBodyWorkflowTrigger<T> : WorkflowTriggerBase, IBodyWorkflowTrigger<T>
    {
        internal TestBodyWorkflowTrigger(string name)
        {
            this.Name = name;
        }

        public T TriggerBody { get; }

        public override FlowTemplateTrigger GetTriggerDefinition() => new FlowTemplateTrigger();
    }
}
