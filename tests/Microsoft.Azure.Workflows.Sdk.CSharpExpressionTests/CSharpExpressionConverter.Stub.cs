// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Stubs
{
    using System;
    using System.Linq.Expressions;
    using System.Net.Http;

    /// <summary>
    /// Placeholder for the future <c>CSharpExpressionConverter</c>.
    ///
    /// This stub exists only so the goal tests in this project can compile and
    /// express the *target* public API and the *target* emitted C# expression
    /// source for each lambda. Every method throws <see cref="NotImplementedException"/>;
    /// the goal tests are therefore RED by design and will turn green as the real
    /// converter is implemented (at which point this stub is deleted and the tests
    /// re-pointed at the production type in <c>src</c>).
    ///
    /// Unlike the Logic App <c>ExpressionConverter</c> (which emits <c>@...</c> strings
    /// and returns <c>JToken</c>/<c>JArray</c> for some overloads), every method here
    /// returns the emitted <b>C# expression source string</b> — that is the whole point
    /// of this converter: produce C# that is compiled and evaluated at runtime.
    /// </summary>
    internal static class CSharpExpressionConverter
    {
        private static string NotYet() =>
            throw new NotImplementedException("CSharpExpressionConverter is not implemented yet. This is a goal-setting stub.");

        public static string Convert(Expression<Func<string>> e) => NotYet();

        public static string Convert(Expression<Func<bool>> e) => NotYet();

        public static string Convert(Expression<Func<int>> e) => NotYet();

        public static string Convert(Expression<Func<double>> e) => NotYet();

        public static string Convert(Expression<Func<Uri>> e) => NotYet();

        public static string Convert(Expression<Func<HttpMethod>> e) => NotYet();

        public static string Convert<T>(Expression<Func<T>> e) where T : Enum => NotYet();

        // In the LA world this returns a JArray; in the C# world it emits array source.
        public static string Convert(Expression<Func<string[]>> e) => NotYet();

        public static string ConvertWithUrlEncoding(Expression<Func<string>> e, int times) => NotYet();

        public static string ConvertWithUrlEncoding<T>(Expression<Func<T>> e, int times) where T : Enum => NotYet();

        public static string ConvertWithUrlEncodingWithInt(Expression<Func<int>> e, int times) => NotYet();

        public static string ConvertOWithBase64<T>(Expression<Func<T>> e) => NotYet();

        // Object payloads: emit native C# object-initializer source (no JSON-concat).
        public static string ConvertO<T>(Expression<Func<T>> e) => NotYet();

        public static string ConvertObject<T>(Expression<Func<T>> e) => NotYet();
    }
}
