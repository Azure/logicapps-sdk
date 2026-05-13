// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Extension methods for enumerable types.
    /// </summary>
    internal static class IEnumerableExtensions
    {
        /// <summary>
        /// Coalesces the enumerable.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        internal static IEnumerable<TSource> CoalesceEnumerable<TSource>(this IEnumerable<TSource> source)
        {
            return source ?? Enumerable.Empty<TSource>();
        }
    }
}
