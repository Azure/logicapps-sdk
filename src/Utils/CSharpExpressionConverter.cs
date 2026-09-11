// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;
    using Microsoft.Azure.Workflows.Sdk.Expressions;

    /// <summary>
    /// Converts LINQ expression trees to C# source strings for evaluation by the Logic Apps
    /// runtime C# expression engine. Workflow data references are emitted as free-function
    /// calls that use the runtime workflow globals; all other C# is preserved verbatim.
    /// </summary>
    internal static class CSharpExpressionConverter
    {
        private static readonly CSharpExpressionVisitor Visitor = new CSharpExpressionVisitor();

        /// <summary>Converts an expression to its C# source representation.</summary>
        public static string ConvertO<T>(Expression<Func<T>> e)
        {
            if (e == null) return string.Empty;
            return Visitor.VisitExpression(e.Body, null);
        }

        /// <summary>Converts an enum expression to its quoted member-value string.</summary>
        public static string Convert<T>(Expression<Func<T>> e) where T : Enum
        {
            var value = e.Compile().Invoke();
            return $"\"{Utility.GetEnumMemberValue(value)}\"";
        }

        /// <summary>Wraps an expression in encodeURIComponent calls.</summary>
        public static string ConvertWithUrlEncoding(Expression<Func<string>> e, int times)
        {
            return WrapEncodeUri(ConvertO(e), times);
        }

        /// <summary>Wraps an enum expression in encodeURIComponent calls.</summary>
        public static string ConvertWithUrlEncoding<T>(Expression<Func<T>> e, int times) where T : Enum
        {
            return WrapEncodeUri(Convert(e), times);
        }

        /// <summary>Wraps an int expression in encodeURIComponent calls.</summary>
        public static string ConvertWithUrlEncodingWithInt(Expression<Func<int>> e, int times)
        {
            return WrapEncodeUri(ConvertO(e), times);
        }

        /// <summary>Wraps an expression in a base64() call.</summary>
        public static string ConvertOWithBase64<T>(Expression<Func<T>> e)
        {
            return $"base64({Visitor.VisitExpression(e.Body, null)})";
        }

        private static string WrapEncodeUri(string inner, int times)
        {
            while (times > 0)
            {
                inner = $"encodeURIComponent({inner})";
                times--;
            }
            return inner;
        }
    }
}
