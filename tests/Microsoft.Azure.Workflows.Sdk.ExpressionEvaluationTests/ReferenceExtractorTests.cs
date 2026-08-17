// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionEvaluationTests
{
    using System.Linq;
    using Microsoft.Azure.Workflows.Sdk.ExpressionEvaluation;
    using Xunit;

    /// <summary>
    /// Tests for <see cref="WorkflowExpressionReferenceExtractor"/> — the static (no-execution)
    /// inference of which workflow data (trigger / actions / variables / agent parameters) a
    /// serialized C# expression references.
    /// </summary>
    public class ReferenceExtractorTests
    {
        // -------------------- Actions --------------------

        [Fact]
        public void Outputs_ReferencesAction()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs(\"ComposeInput\")");

            Assert.Equal(new[] { "ComposeInput" }, refs.Actions.OrderBy(x => x));
            Assert.False(refs.TriggerReferenced);
            Assert.Empty(refs.Variables);
            Assert.Empty(refs.AgentParameters);
            Assert.False(refs.HasDynamicReferences);
        }

        [Fact]
        public void Body_ReferencesActionByName()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("body(\"GetItems\")");

            Assert.Equal(new[] { "GetItems" }, refs.Actions);
        }

        [Fact]
        public void OutputsAndBody_OfSameAction_ProduceSingleActionName()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs(\"A\") + body(\"A\")");

            Assert.Equal(new[] { "A" }, refs.Actions);
        }

        [Fact]
        public void MultipleActions_AreAllCollected()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract(
                "outputs(\"ComposeInput\") + variables(\"v\") + body(\"GetItems\")");

            Assert.Equal(new[] { "ComposeInput", "GetItems" }, refs.Actions.OrderBy(x => x));
            Assert.Equal(new[] { "v" }, refs.Variables);
        }

        [Fact]
        public void DuplicateReference_IsDeduplicated()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs(\"A\") + outputs(\"A\")");

            Assert.Equal(new[] { "A" }, refs.Actions);
        }

        // -------------------- Trigger --------------------

        [Fact]
        public void TriggerOutputs_SetsTriggerReferenced()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("triggerOutputs()?[\"Body\"]");

            Assert.True(refs.TriggerReferenced);
            Assert.Empty(refs.Actions);
        }

        [Fact]
        public void TriggerBody_SetsTriggerReferenced()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("triggerBody()");

            Assert.True(refs.TriggerReferenced);
        }

        [Fact]
        public void TriggerAndAction_Comparison_CollectsBoth()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract(
                "triggerOutputs()?[\"Body\"] == outputs(\"ComposeInput\")");

            Assert.True(refs.TriggerReferenced);
            Assert.Equal(new[] { "ComposeInput" }, refs.Actions);
        }

        // -------------------- Variables / agent parameters --------------------

        [Fact]
        public void Variables_ReferencesVariable()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("variables(\"counter\")");

            Assert.Equal(new[] { "counter" }, refs.Variables);
            Assert.Empty(refs.Actions);
        }

        [Fact]
        public void AgentParameters_ReferencesAgentParameter()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("agentparameters(\"Name\")");

            Assert.Equal(new[] { "Name" }, refs.AgentParameters);
        }

        // -------------------- Nesting contexts --------------------

        [Fact]
        public void ReferencesInsideStringInterpolation_AreFound()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract(
                "$\"a {outputs(\"ComposeInput\")} b {body(\"GetItems\")}\"");

            Assert.Equal(new[] { "ComposeInput", "GetItems" }, refs.Actions.OrderBy(x => x));
        }

        [Fact]
        public void ReferencesInsideTernary_AreFound()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract(
                "variables(\"flag\").Value<bool>() ? outputs(\"A\") : outputs(\"B\")");

            Assert.Equal(new[] { "A", "B" }, refs.Actions.OrderBy(x => x));
            Assert.Equal(new[] { "flag" }, refs.Variables);
        }

        [Fact]
        public void NestedAccessor_InnerReferenceIsResolved_OuterIsUnresolved()
        {
            // body("A") resolves; the outer outputs(...) has a non-literal (dynamic) argument.
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs(body(\"A\").ToString())");

            Assert.Equal(new[] { "A" }, refs.Actions);
            Assert.True(refs.HasDynamicReferences);
            Assert.Single(refs.Unresolved);
            Assert.Equal(WorkflowReferenceKind.Action, refs.Unresolved[0].Kind);
        }

        [Fact]
        public void HelperFunctions_AreNotTreatedAsReferences()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("encodeURIComponent(outputs(\"A\"))");

            Assert.Equal(new[] { "A" }, refs.Actions);
            Assert.False(refs.HasDynamicReferences);
        }

        // -------------------- Constant folding (tier 2) --------------------

        [Fact]
        public void LiteralConcatenationArgument_IsFolded()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs(\"Compose\" + \"Input\")");

            Assert.Equal(new[] { "ComposeInput" }, refs.Actions);
            Assert.False(refs.HasDynamicReferences);
        }

        [Fact]
        public void ParenthesizedLiteralArgument_IsResolved()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs((\"A\"))");

            Assert.Equal(new[] { "A" }, refs.Actions);
        }

        // -------------------- Unresolved / dynamic --------------------

        [Fact]
        public void NonLiteralArgument_IsUnresolved_AndNotGuessed()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs(variables(\"which\").ToString())");

            // The inner variables("which") still resolves.
            Assert.Equal(new[] { "which" }, refs.Variables);
            // The outer outputs(...) argument is dynamic.
            Assert.Empty(refs.Actions);
            Assert.True(refs.HasDynamicReferences);
            Assert.Equal(WorkflowReferenceKind.Action, refs.Unresolved[0].Kind);
        }

        [Fact]
        public void MissingArgument_IsRecordedAsUnresolved()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs()");

            Assert.Empty(refs.Actions);
            Assert.True(refs.HasDynamicReferences);
            Assert.Equal(WorkflowReferenceKind.Action, refs.Unresolved[0].Kind);
        }

        // -------------------- Bare-only matching --------------------

        [Fact]
        public void MemberAccessCall_WithSameName_IsNotMatched()
        {
            // x.outputs("A") is a user method, not the free-function accessor.
            var refs = WorkflowExpressionReferenceExtractor.Extract("\"x\".outputs(\"A\")");

            Assert.Empty(refs.Actions);
            Assert.False(refs.HasDynamicReferences);
        }

        [Fact]
        public void PlainExpression_WithNoAccessors_HasNoReferences()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("\"hello\" + \"world\"");

            Assert.False(refs.TriggerReferenced);
            Assert.Empty(refs.Actions);
            Assert.Empty(refs.Variables);
            Assert.Empty(refs.AgentParameters);
            Assert.False(refs.HasDynamicReferences);
        }

        [Fact]
        public void CaseSensitivity_NamesAreDistinct()
        {
            var refs = WorkflowExpressionReferenceExtractor.Extract("outputs(\"A\") + outputs(\"a\")");

            Assert.Equal(new[] { "A", "a" }, refs.Actions.OrderBy(x => x, System.StringComparer.Ordinal));
        }

        // -------------------- Argument validation --------------------

        [Fact]
        public void NullExpression_Throws()
        {
            Assert.Throws<System.ArgumentNullException>(() => WorkflowExpressionReferenceExtractor.Extract((string)null));
        }
    }
}
