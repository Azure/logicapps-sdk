// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Exposes the unified converter's raw C# rendering for source-level tests.
    /// </summary>
    internal static class CSharpExpressionConverter
    {
        public static string ConvertO<T>(Expression<Func<T>> expression) =>
            ExpressionConverter.ConvertToCSharp(expression);

        public static string Convert<T>(Expression<Func<T>> expression)
            where T : Enum =>
            ExpressionConverter.ConvertEnumToCSharp(expression);

        public static string ConvertWithUrlEncoding(Expression<Func<string>> expression, int times) =>
            ExpressionConverter.ConvertToCSharpWithUrlEncoding(expression, times);

        public static string ConvertWithUrlEncoding<T>(Expression<Func<T>> expression, int times)
            where T : Enum
        {
            var value = Utility.GetEnumMemberValue(expression.Compile().Invoke());
            return ExpressionConverter.ConvertToCSharpWithUrlEncoding(() => value, times);
        }

        public static string ConvertWithUrlEncodingWithInt(Expression<Func<int>> expression, int times) =>
            ExpressionConverter.ConvertToCSharpWithUrlEncodingWithInt(expression, times);

        public static string ConvertOWithBase64<T>(Expression<Func<T>> expression) =>
            ExpressionConverter.ConvertToCSharpWithBase64(expression);
    }
}
