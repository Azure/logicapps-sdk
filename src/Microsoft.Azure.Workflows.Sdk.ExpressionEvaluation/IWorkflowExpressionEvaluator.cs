// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionEvaluation
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Evaluates a serialized C# workflow expression string (as produced by the
    /// <c>CSharpExpressionConverter</c>) at runtime, against a set of
    /// <see cref="WorkflowExpressionGlobals"/> that provide workflow data and helper functions.
    /// </summary>
    public interface IWorkflowExpressionEvaluator
    {
        /// <summary>
        /// Evaluates the expression and returns the raw result.
        /// </summary>
        Task<object> EvaluateAsync(string expression, WorkflowExpressionGlobals globals, CancellationToken cancellationToken = default);

        /// <summary>
        /// Evaluates the expression and coerces the result to <typeparamref name="T"/>
        /// (JToken results are read via <c>ToObject&lt;T&gt;()</c>).
        /// </summary>
        Task<T> EvaluateAsync<T>(string expression, WorkflowExpressionGlobals globals, CancellationToken cancellationToken = default);
    }
}
