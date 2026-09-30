// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    /// <summary>
    /// Composes literal text and generated C# fragments into one workflow C# expression.
    /// </summary>
    internal static class WorkflowStringExpressionComposer
    {
        private const string ExpressionMarkerPrefix = "__logicapps_csharp_string_";

        private const string ExpressionMarkerSuffix = "__";

        private static readonly Regex ExpressionMarkerPattern = new Regex(
            $"{Regex.Escape(ExpressionMarkerPrefix)}[a-f0-9]{{32}}{Regex.Escape(ExpressionMarkerSuffix)}",
            RegexOptions.Compiled | RegexOptions.CultureInvariant);

        private static readonly ConcurrentDictionary<string, string> Expressions =
            new ConcurrentDictionary<string, string>();

        /// <summary>
        /// Creates an opaque placeholder for a generated C# expression fragment.
        /// </summary>
        /// <param name="csharpSource">The generated C# source.</param>
        internal static string CreatePlaceholder(string csharpSource)
        {
            var marker = $"{ExpressionMarkerPrefix}{Guid.NewGuid():N}{ExpressionMarkerSuffix}";
            Expressions[marker] = csharpSource;
            return marker;
        }

        /// <summary>
        /// Composes registered expression placeholders and literal text into one C# expression.
        /// </summary>
        /// <param name="value">The string that may contain registered placeholders.</param>
        internal static string Compose(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            var matches = ExpressionMarkerPattern.Matches(value);
            if (matches.Count == 0)
                return value;

            var registeredExpressions = matches
                .Cast<Match>()
                .Where(match => Expressions.TryGetValue(match.Value, out _))
                .Select(match => new KeyValuePair<Match, string>(
                    match,
                    Expressions[match.Value]))
                .ToArray();
            if (registeredExpressions.Length == 0)
                return value;

            var segments = new List<string>();
            var currentIndex = 0;
            foreach (var registeredExpression in registeredExpressions)
            {
                var match = registeredExpression.Key;
                if (match.Index > currentIndex)
                {
                    segments.Add(JsonConvert.SerializeObject(
                        value.Substring(currentIndex, match.Index - currentIndex)));
                }

                segments.Add($"({registeredExpression.Value})");
                currentIndex = match.Index + match.Length;
            }

            if (currentIndex < value.Length)
                segments.Add(JsonConvert.SerializeObject(value.Substring(currentIndex)));

            foreach (var marker in registeredExpressions
                .Select(registeredExpression => registeredExpression.Key.Value)
                .Distinct(StringComparer.Ordinal))
            {
                Expressions.TryRemove(marker, out _);
            }

            return $"#{{{string.Join(" + ", segments)}}}";
        }
    }
}
