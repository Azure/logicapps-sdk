// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System;
    using System.Linq;
    using Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Stubs;

    /// <summary>
    /// GOAL specification for arbitrary expressions that are natively supported by C# but
    /// that the Logic App converter cannot express at all (it would throw
    /// NotSupportedException / NotImplementedException, or emit degenerate output). These
    /// demonstrate the expressive range unlocked by evaluating serialized C# at runtime.
    ///
    /// Every lambda is a valid <c>Expression&lt;Func&lt;T&gt;&gt;</c> tree (so constructs
    /// not allowed in expression trees — <c>?.</c>, ranges/indices, patterns, collection
    /// expressions — are intentionally avoided). Operands are captured locals, which the
    /// converter inlines as literals, consistent with the rest of the spec.
    /// </summary>
    public class CSharpNativeExpressionTests
    {
        // -------------------- String-producing expressions --------------------

        [Fact]
        public void Convert_StringToUpper_EmitsToUpperCall()
        {
            string s = "hello";
            Assert.Equal("\"hello\".ToUpper()", CSharpExpressionConverter.Convert(() => s.ToUpper()));
        }

        [Fact]
        public void Convert_StringSubstring_EmitsSubstringCall()
        {
            string s = "hello";
            Assert.Equal("\"hello\".Substring(1, 3)", CSharpExpressionConverter.Convert(() => s.Substring(1, 3)));
        }

        [Fact]
        public void Convert_NullCoalescing_EmitsCoalesceOperator()
        {
            string s = "hello";
            Assert.Equal("\"hello\" ?? \"fallback\"", CSharpExpressionConverter.Convert(() => s ?? "fallback"));
        }

        [Fact]
        public void Convert_StringJoin_EmitsStringJoinCall()
        {
            Assert.Equal(
                "string.Join(\", \", new[] { \"a\", \"b\", \"c\" })",
                CSharpExpressionConverter.Convert(() => string.Join(", ", new[] { "a", "b", "c" })));
        }

        [Fact]
        public void Convert_Ternary_EmitsConditionalOperator()
        {
            int n = 5;
            Assert.Equal(
                "5 > 0 ? \"positive\" : \"non-positive\"",
                CSharpExpressionConverter.Convert(() => n > 0 ? "positive" : "non-positive"));
        }

        [Fact]
        public void Convert_ChainedStringConcat_EmitsPlusOperators()
        {
            string first = "John", last = "Doe";
            Assert.Equal(
                "\"John\" + \" \" + \"Doe\"",
                CSharpExpressionConverter.Convert(() => first + " " + last));
        }

        // -------------------- Boolean-producing expressions --------------------

        [Fact]
        public void Convert_StringContains_EmitsContainsCall()
        {
            string s = "hello";
            Assert.Equal("\"hello\".Contains(\"ell\")", CSharpExpressionConverter.Convert(() => s.Contains("ell")));
        }

        [Fact]
        public void Convert_StartsWithAndEndsWith_EmitsAndedCalls()
        {
            string s = "hello";
            Assert.Equal(
                "\"hello\".StartsWith(\"he\") && \"hello\".EndsWith(\"lo\")",
                CSharpExpressionConverter.Convert(() => s.StartsWith("he") && s.EndsWith("lo")));
        }

        [Fact]
        public void Convert_MixedComparisonAndLogic_EmitsOperators()
        {
            int a = 7, b = 3, c = 2, d = 2;
            Assert.Equal(
                "7 > 3 || 2 == 2",
                CSharpExpressionConverter.Convert(() => a > b || c == d));
        }

        [Fact]
        public void Convert_Negation_EmitsNotOperator()
        {
            bool flag = true;
            Assert.Equal("!true", CSharpExpressionConverter.Convert(() => !flag));
        }

        // -------------------- Int-producing expressions --------------------

        [Fact]
        public void Convert_StringLength_EmitsLengthAccess()
        {
            string s = "hello";
            Assert.Equal("\"hello\".Length", CSharpExpressionConverter.Convert(() => s.Length));
        }

        [Fact]
        public void Convert_MathMax_EmitsMathMaxCall()
        {
            int a = 3, b = 7;
            Assert.Equal("Math.Max(3, 7)", CSharpExpressionConverter.Convert(() => Math.Max(a, b)));
        }

        [Fact]
        public void Convert_LinqMax_EmitsLinqMaxCall()
        {
            Assert.Equal(
                "new[] { 3, 1, 2 }.Max()",
                CSharpExpressionConverter.Convert(() => new[] { 3, 1, 2 }.Max()));
        }

        [Fact]
        public void Convert_ArithmeticPrecedence_EmitsUnparenthesizedByPrecedence()
        {
            int a = 3, b = 7, c = 2;
            Assert.Equal("3 * 7 + 2", CSharpExpressionConverter.Convert(() => a * b + c));
        }

        [Fact]
        public void Convert_BitwiseAnd_EmitsAmpersandOperator()
        {
            int x = 12, y = 10;
            Assert.Equal("12 & 10", CSharpExpressionConverter.Convert(() => x & y));
        }

        // -------------------- Double-producing expressions --------------------

        [Fact]
        public void Convert_MathRound_EmitsMathRoundCall()
        {
            double x = 3.14159;
            Assert.Equal("Math.Round(3.14159, 2)", CSharpExpressionConverter.Convert(() => Math.Round(x, 2)));
        }

        [Fact]
        public void Convert_MathPow_EmitsMathPowCall()
        {
            double b = 2, e = 10;
            Assert.Equal("Math.Pow(2, 10)", CSharpExpressionConverter.Convert(() => Math.Pow(b, e)));
        }
    }
}
