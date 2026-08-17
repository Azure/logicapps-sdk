// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Characterization tests for <see cref="ExpressionConverter"/>. These lock in the current
    /// behavior of converting strongly-typed C# lambdas into Logic App expression strings.
    ///
    /// Note: the C# compiler constant-folds expressions whose operands are all literals
    /// (e.g. <c>1 &lt; 2</c> becomes the constant <c>true</c>), which bypasses the operator
    /// translation entirely. To exercise the operator/function logic, operands are captured
    /// local variables (which the converter inlines as literals) rather than raw literals.
    /// </summary>
    public class ExpressionConverterTests
    {
        // -------------------- Literals / constant folding --------------------

        [Fact]
        public void Convert_StringLiteral_ReturnsRawString()
        {
            Assert.Equal("hello", ExpressionConverter.Convert(() => "hello"));
        }

        [Fact]
        public void Convert_BoolConstant_ReturnsStringifiedValue()
        {
            // A top-level literal node renders via Value.ToString() rather than "@true".
            Assert.Equal("True", ExpressionConverter.Convert(() => true));
        }

        [Fact]
        public void Convert_IntExpression_UsesConcatenatingVisitor()
        {
            // Func<int> uses the simple concatenating Visitor; "1 + 2" is constant-folded to 3.
            Assert.Equal("3", ExpressionConverter.Convert(() => 1 + 2));
        }

        [Fact]
        public void Convert_DoubleExpression_UsesConcatenatingVisitor()
        {
            Assert.Equal("4", ExpressionConverter.Convert(() => 1.5 + 2.5));
        }

        // -------------------- Comparison operators --------------------

        [Fact]
        public void Convert_LessThan_EmitsLess()
        {
            int a = 1, b = 2;
            Assert.Equal("@less(1, 2)", ExpressionConverter.Convert(() => a < b));
        }

        [Fact]
        public void Convert_LessThanOrEqual_EmitsLessOrEquals()
        {
            int a = 1, b = 2;
            Assert.Equal("@lessOrEquals(1, 2)", ExpressionConverter.Convert(() => a <= b));
        }

        [Fact]
        public void Convert_Equal_EmitsEquals()
        {
            int a = 1, b = 2;
            Assert.Equal("@equals(1, 2)", ExpressionConverter.Convert(() => a == b));
        }

        [Fact]
        public void Convert_NotEqual_EmitsNotEquals()
        {
            int a = 1, b = 2;
            Assert.Equal("@not(equals(1, 2))", ExpressionConverter.Convert(() => a != b));
        }

        [Fact]
        public void Convert_GreaterThan_IsNotSupported()
        {
            // Known gap: ExpressionExtensions.Visit does not map GreaterThan, even though
            // ConvertBinaryFunction handles it. Locks the current behavior.
            int a = 1, b = 2;
            Assert.Throws<NotSupportedException>(() => ExpressionConverter.Convert(() => a > b));
        }

        [Fact]
        public void Convert_GreaterThanOrEqual_IsNotSupported()
        {
            // Known gap: see Convert_GreaterThan_IsNotSupported.
            int a = 1, b = 2;
            Assert.Throws<NotSupportedException>(() => ExpressionConverter.Convert(() => a >= b));
        }

        // -------------------- Logical operators --------------------

        [Fact]
        public void Convert_AndAlso_EmitsAnd()
        {
            bool t = true, f = false;
            Assert.Equal("@and(true, false)", ExpressionConverter.Convert(() => t && f));
        }

        [Fact]
        public void Convert_OrElse_EmitsOr()
        {
            bool t = true, f = false;
            Assert.Equal("@or(true, false)", ExpressionConverter.Convert(() => t || f));
        }

        // -------------------- Arithmetic functions --------------------
        // Wrapped in an equality so the outer expression is a Func<bool> routed through the
        // LogicConverter (a bare Func<int> would use the concatenating Visitor instead).

        [Fact]
        public void Convert_Add_EmitsAdd()
        {
            int a = 1, b = 2;
            Assert.Equal("@equals(add(1, 2), 3)", ExpressionConverter.Convert(() => (a + b) == 3));
        }

        [Fact]
        public void Convert_Subtract_EmitsSubtract()
        {
            int a = 1, b = 2;
            Assert.Equal("@equals(subtract(1, 2), 3)", ExpressionConverter.Convert(() => (a - b) == 3));
        }

        [Fact]
        public void Convert_Multiply_EmitsMultiply()
        {
            int a = 1, b = 2;
            Assert.Equal("@equals(multiply(1, 2), 3)", ExpressionConverter.Convert(() => (a * b) == 3));
        }

        [Fact]
        public void Convert_Divide_EmitsDivide()
        {
            int a = 1, b = 2;
            Assert.Equal("@equals(divide(1, 2), 3)", ExpressionConverter.Convert(() => (a / b) == 3));
        }

        [Fact]
        public void Convert_Modulo_EmitsMod()
        {
            int a = 1, b = 2;
            Assert.Equal("@equals(mod(1, 2), 3)", ExpressionConverter.Convert(() => (a % b) == 3));
        }

        [Fact]
        public void Convert_AddDouble_EmitsAdd()
        {
            double a = 1.5, b = 2.5;
            Assert.Equal("@equals(add(1.5, 2.5), 4)", ExpressionConverter.Convert(() => (a + b) == 4.0));
        }

        // -------------------- Conditional --------------------

        [Fact]
        public void Convert_Conditional_EmitsIf()
        {
            int a = 1, b = 2;
            string x = "hello", y = "world";
            Assert.Equal("@if(less(1, 2), 'hello', 'world')", ExpressionConverter.Convert(() => a < b ? x : y));
        }

        // -------------------- String functions --------------------

        [Fact]
        public void Convert_StringConcat_AllLiterals_FoldsToPlainText()
        {
            // Both operands inline to literals, so concat renders them directly (no @{}).
            string a = "hello", b = "world";
            Assert.Equal("helloworld", ExpressionConverter.Convert(() => a + b));
        }

        [Fact]
        public void Convert_StringFormat_SingleArg_EmitsConcatText()
        {
            string name = "world";
            Assert.Equal("Hello world!", ExpressionConverter.Convert(() => string.Format("Hello {0}!", name)));
        }

        [Fact]
        public void Convert_StringFormat_TwoArgs_EmitsConcatText()
        {
            string a = "hello", b = "world";
            Assert.Equal("hello-world", ExpressionConverter.Convert(() => string.Format("{0}-{1}", a, b)));
        }

        [Fact]
        public void Convert_StringConcatMethod_Literals_FoldsToPlainText()
        {
            Assert.Equal("ab", ExpressionConverter.Convert(() => string.Concat("a", "b")));
        }

        [Fact]
        public void Convert_IntToString_IsNotSupported()
        {
            // Known gap: only object.ToString() is matched; Int32's ToString override is not.
            int a = 1;
            Assert.Throws<NotImplementedException>(() => ExpressionConverter.Convert(() => a.ToString()));
        }

        // -------------------- Uri --------------------

        [Fact]
        public void Convert_Uri_ReturnsRawString()
        {
            Assert.Equal(
                "http://example.com/path",
                ExpressionConverter.Convert(() => new Uri("http://example.com/path")));
        }

        // -------------------- URL encoding / base64 wrappers --------------------

        [Fact]
        public void ConvertWithUrlEncoding_Once_WrapsInEncodeUriComponent()
        {
            Assert.Equal(
                "@{encodeURIComponent('a b')}",
                ExpressionConverter.ConvertWithUrlEncoding(() => "a b", 1));
        }

        [Fact]
        public void ConvertWithUrlEncoding_Twice_NestsEncodeUriComponent()
        {
            Assert.Equal(
                "@{encodeURIComponent(encodeURIComponent('a b'))}",
                ExpressionConverter.ConvertWithUrlEncoding(() => "a b", 2));
        }

        [Fact]
        public void ConvertOWithBase64_WrapsInBase64()
        {
            Assert.Equal("@base64('hello')", ExpressionConverter.ConvertOWithBase64<string>(() => "hello"));
        }

        // -------------------- Workflow context member access --------------------

        [Fact]
        public void Convert_VariableValue_Interpolated_EmitsVariablesFunction()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "v");

            Assert.Equal("@{variables('myVar')}", ExpressionConverter.Convert(() => $"{variable.Value}"));
        }

        [Fact]
        public void Convert_VariableValue_InConcat_EmitsInlineVariablesFunction()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "v");

            Assert.Equal(
                "prefix-@{variables('myVar')}",
                ExpressionConverter.Convert(() => $"prefix-{variable.Value}"));
        }

        // -------------------- Not-yet-implemented overloads --------------------

        [Fact]
        public void Convert_StringArray_IsNotImplemented()
        {
            Expression<Func<string[]>> e = () => new[] { "a", "b" };
            Assert.Throws<NotImplementedException>(() => ExpressionConverter.Convert(e));
        }
    }
}
