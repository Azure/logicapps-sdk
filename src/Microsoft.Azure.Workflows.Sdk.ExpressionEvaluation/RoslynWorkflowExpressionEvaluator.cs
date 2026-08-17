// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionEvaluation
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis.CSharp.Scripting;
    using Microsoft.CodeAnalysis.Scripting;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A <see cref="IWorkflowExpressionEvaluator"/> backed by the Roslyn C# scripting engine.
    ///
    /// Because the serialized form IS C#, a full C# engine gives an exact semantic match with
    /// the converter output (operators, LINQ, JToken, BCL). Compilation is the expensive step,
    /// so each unique expression string is compiled once into a reusable
    /// <see cref="ScriptRunner{T}"/> delegate and cached; execution then only runs the delegate
    /// with a fresh <see cref="WorkflowExpressionGlobals"/>.
    ///
    /// TRUST MODEL: expressions originate from the developer's own compiled workflow and are
    /// treated as trusted (single-tenant worker) — no sandbox / no API allowlist.
    /// </summary>
    public sealed class RoslynWorkflowExpressionEvaluator : IWorkflowExpressionEvaluator
    {
        private readonly ScriptOptions options;
        private readonly ConcurrentDictionary<string, ScriptRunner<object>> runnerCache = new ConcurrentDictionary<string, ScriptRunner<object>>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoslynWorkflowExpressionEvaluator"/> class.
        /// </summary>
        /// <param name="additionalReferences">
        /// Assemblies referenced by expressions beyond the defaults (e.g. the SDK assembly for
        /// <c>FlowStatus</c>, or an assembly that defines POCO payload types).
        /// </param>
        /// <param name="additionalImports">
        /// Namespaces to import beyond the defaults (System, System.Linq, Newtonsoft.Json[.Linq]).
        /// </param>
        public RoslynWorkflowExpressionEvaluator(
            IEnumerable<Assembly> additionalReferences = null,
            IEnumerable<string> additionalImports = null)
        {
            var references = new List<Assembly>
            {
                typeof(object).Assembly,                        // core runtime
                typeof(Enumerable).Assembly,                    // System.Linq
                typeof(Uri).Assembly,                           // System.Private.Uri
                typeof(JToken).Assembly,                        // Newtonsoft.Json
                typeof(WorkflowExpressionGlobals).Assembly,     // the globals host
            };

            if (additionalReferences != null)
            {
                references.AddRange(additionalReferences);
            }

            var imports = new List<string>
            {
                "System",
                "System.Linq",
                "Newtonsoft.Json",
                "Newtonsoft.Json.Linq",
            };

            if (additionalImports != null)
            {
                imports.AddRange(additionalImports);
            }

            this.options = ScriptOptions.Default
                .WithReferences(references.Distinct())
                .WithImports(imports.Distinct());
        }

        /// <inheritdoc />
        public async Task<object> EvaluateAsync(string expression, WorkflowExpressionGlobals globals, CancellationToken cancellationToken = default)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            var runner = this.runnerCache.GetOrAdd(expression, expr =>
                CSharpScript.Create<object>(expr, this.options, typeof(WorkflowExpressionGlobals)).CreateDelegate());

            return await runner(globals, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<T> EvaluateAsync<T>(string expression, WorkflowExpressionGlobals globals, CancellationToken cancellationToken = default)
        {
            var result = await this.EvaluateAsync(expression, globals, cancellationToken).ConfigureAwait(false);
            return Coerce<T>(result);
        }

        private static T Coerce<T>(object result)
        {
            switch (result)
            {
                case T typed:
                    return typed;
                case JToken token:
                    return token.ToObject<T>();
                case null:
                    return default;
                default:
                    return (T)Convert.ChangeType(result, typeof(T), CultureInfo.InvariantCulture);
            }
        }
    }
}
