// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionEvaluation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    /// <summary>
    /// Statically parses a serialized C# workflow expression (as produced by the
    /// <c>CSharpExpressionConverter</c>) and infers which workflow data it references — the
    /// trigger, action outputs (<c>outputs("A")</c> / <c>body("A")</c>), variables and agent
    /// parameters — <b>without executing it</b>.
    ///
    /// This is the "dependency pre-scan" the evaluator needs to fetch async workflow data in
    /// parallel before running the (synchronous) script; it also powers workflow dependency-graph
    /// construction and design-time validation.
    ///
    /// Because the converter always emits action/variable names as <b>string literals</b>, a
    /// purely syntactic walk resolves every name in converter output. Names that are not literals
    /// (only possible for hand-authored expressions) are reported via
    /// <see cref="WorkflowExpressionReferences.Unresolved"/> rather than guessed.
    /// </summary>
    public static class WorkflowExpressionReferenceExtractor
    {
        private sealed record AccessorDescriptor(WorkflowReferenceKind Kind, int? NameArgumentIndex);

        /// <summary>
        /// The known workflow-data accessors, mirroring <see cref="WorkflowExpressionGlobals"/>.
        /// A <see cref="AccessorDescriptor.NameArgumentIndex"/> of <c>null</c> means the accessor
        /// takes no name (the trigger). This table is the single source of truth for matching —
        /// adding an accessor requires no walker changes.
        /// </summary>
        private static readonly IReadOnlyDictionary<string, AccessorDescriptor> Accessors =
            new Dictionary<string, AccessorDescriptor>(StringComparer.Ordinal)
            {
                ["triggerOutputs"] = new AccessorDescriptor(WorkflowReferenceKind.Trigger, null),
                ["triggerBody"] = new AccessorDescriptor(WorkflowReferenceKind.Trigger, null),
                ["outputs"] = new AccessorDescriptor(WorkflowReferenceKind.Action, 0),
                ["body"] = new AccessorDescriptor(WorkflowReferenceKind.Action, 0),
                ["variables"] = new AccessorDescriptor(WorkflowReferenceKind.Variable, 0),
                ["agentparameters"] = new AccessorDescriptor(WorkflowReferenceKind.AgentParameter, 0),
            };

        /// <summary>
        /// Extracts the references from a serialized C# expression string.
        /// </summary>
        public static WorkflowExpressionReferences Extract(string expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            return Extract(SyntaxFactory.ParseExpression(expression));
        }

        /// <summary>
        /// Extracts the references from an already-parsed expression syntax tree. This overload
        /// lets the evaluator avoid re-parsing when it already has the tree from compilation.
        /// </summary>
        public static WorkflowExpressionReferences Extract(ExpressionSyntax root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            var triggerReferenced = false;
            var actions = new HashSet<string>(StringComparer.Ordinal);
            var variables = new HashSet<string>(StringComparer.Ordinal);
            var agentParameters = new HashSet<string>(StringComparer.Ordinal);
            var unresolved = new List<UnresolvedReference>();

            // A single walk over every invocation node transparently covers all nesting contexts
            // (arguments, string interpolations, ternaries, indexer/?. chains, LINQ lambdas).
            foreach (var invocation in root.DescendantNodesAndSelf().OfType<InvocationExpressionSyntax>())
            {
                var name = GetBareCalleeName(invocation.Expression);
                if (name == null || !Accessors.TryGetValue(name, out var descriptor))
                {
                    continue;
                }

                if (descriptor.NameArgumentIndex is null)
                {
                    triggerReferenced = true;
                    continue;
                }

                var index = descriptor.NameArgumentIndex.Value;
                var arguments = invocation.ArgumentList.Arguments;
                if (index >= arguments.Count)
                {
                    // Arity mismatch (e.g. outputs()) — record but do not guess.
                    unresolved.Add(new UnresolvedReference(descriptor.Kind, invocation.ToString(), invocation.Span));
                    continue;
                }

                var argument = arguments[index].Expression;
                if (TryResolveConstantString(argument, out var value))
                {
                    Add(descriptor.Kind, value, actions, variables, agentParameters);
                }
                else
                {
                    unresolved.Add(new UnresolvedReference(descriptor.Kind, argument.ToString(), argument.Span));
                }
            }

            return new WorkflowExpressionReferences(triggerReferenced, actions, variables, agentParameters, unresolved);
        }

        /// <summary>
        /// Returns the identifier of a bare (unqualified) call such as <c>outputs("A")</c>, or
        /// <c>null</c> for member-access calls (<c>x.outputs(...)</c>). Bare-only matching mirrors
        /// the free-function globals model and avoids false positives from unrelated user methods.
        /// </summary>
        private static string GetBareCalleeName(ExpressionSyntax callee) =>
            callee is IdentifierNameSyntax identifier ? identifier.Identifier.ValueText : null;

        private static void Add(
            WorkflowReferenceKind kind,
            string value,
            HashSet<string> actions,
            HashSet<string> variables,
            HashSet<string> agentParameters)
        {
            switch (kind)
            {
                case WorkflowReferenceKind.Action:
                    actions.Add(value);
                    break;
                case WorkflowReferenceKind.Variable:
                    variables.Add(value);
                    break;
                case WorkflowReferenceKind.AgentParameter:
                    agentParameters.Add(value);
                    break;
            }
        }

        /// <summary>
        /// Resolves an argument to a constant string: a string literal (tier 1), or a trivially
        /// constant expression — parentheses and literal <c>+</c> concatenation (tier 2). Anything
        /// else (a variable, nested accessor, interpolation, method call) is unresolved.
        /// </summary>
        private static bool TryResolveConstantString(ExpressionSyntax expression, out string value)
        {
            switch (expression)
            {
                case LiteralExpressionSyntax literal when literal.IsKind(SyntaxKind.StringLiteralExpression):
                    value = literal.Token.ValueText;
                    return true;

                case ParenthesizedExpressionSyntax parenthesized:
                    return TryResolveConstantString(parenthesized.Expression, out value);

                case BinaryExpressionSyntax binary when binary.IsKind(SyntaxKind.AddExpression):
                    if (TryResolveConstantString(binary.Left, out var left) &&
                        TryResolveConstantString(binary.Right, out var right))
                    {
                        value = left + right;
                        return true;
                    }

                    break;
            }

            value = null;
            return false;
        }
    }
}
