// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionEvaluation
{
    using System.Collections.Generic;
    using Microsoft.CodeAnalysis.Text;

    /// <summary>
    /// The kind of workflow data a serialized C# expression can reference.
    /// </summary>
    public enum WorkflowReferenceKind
    {
        /// <summary>The workflow trigger (e.g. <c>triggerOutputs()</c>).</summary>
        Trigger,

        /// <summary>A named action's result (e.g. <c>outputs("Compose")</c> / <c>body("Compose")</c>).</summary>
        Action,

        /// <summary>A workflow variable (e.g. <c>variables("counter")</c>).</summary>
        Variable,

        /// <summary>An agent parameter (e.g. <c>agentparameters("temperature")</c>).</summary>
        AgentParameter,

        /// <summary>A workflow parameter (e.g. <c>parameters("connectionString")</c>).</summary>
        Parameter,

        /// <summary>A ForEach item or iteration reference (e.g. <c>item()</c>, <c>items("loop")</c>).</summary>
        Item,

        /// <summary>Workflow metadata (e.g. <c>workflow()</c>).</summary>
        Workflow,
    }

    /// <summary>
    /// An accessor call whose name argument could not be statically resolved to a constant
    /// (e.g. <c>outputs(variables("which"))</c>). Callers decide how to handle these — for
    /// pre-fetch, the conservative fallback is to fetch all available data.
    /// </summary>
    public sealed record UnresolvedReference(WorkflowReferenceKind Kind, string ArgumentText, TextSpan Span);

    /// <summary>
    /// The set of workflow data a serialized C# expression references, produced by
    /// <see cref="WorkflowExpressionReferenceExtractor"/> without executing the expression.
    /// Used to drive pre-fetch, dependency-graph construction and design-time validation.
    /// </summary>
    public sealed class WorkflowExpressionReferences
    {
        internal WorkflowExpressionReferences(
            bool triggerReferenced,
            IReadOnlyCollection<string> actions,
            IReadOnlyCollection<string> variables,
            IReadOnlyCollection<string> agentParameters,
            IReadOnlyList<UnresolvedReference> unresolved)
        {
            this.TriggerReferenced = triggerReferenced;
            this.Actions = actions;
            this.Variables = variables;
            this.AgentParameters = agentParameters;
            this.Unresolved = unresolved;
        }

        /// <summary>Gets a value indicating whether the trigger is referenced.</summary>
        public bool TriggerReferenced { get; }

        /// <summary>Gets the names of the actions referenced via <c>outputs()</c> / <c>body()</c>.</summary>
        public IReadOnlyCollection<string> Actions { get; }

        /// <summary>Gets the names of the variables referenced via <c>variables()</c>.</summary>
        public IReadOnlyCollection<string> Variables { get; }

        /// <summary>Gets the names of the agent parameters referenced via <c>agentparameters()</c>.</summary>
        public IReadOnlyCollection<string> AgentParameters { get; }

        /// <summary>Gets the accessor calls whose name argument could not be resolved to a constant.</summary>
        public IReadOnlyList<UnresolvedReference> Unresolved { get; }

        /// <summary>
        /// Gets a value indicating whether any referenced accessor had a name argument that could
        /// not be resolved statically. When <c>true</c>, callers should apply a conservative
        /// fallback (e.g. fetch all data).
        /// </summary>
        public bool HasDynamicReferences => this.Unresolved.Count > 0;
    }
}
