// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk;
    
    /// <summary>
    /// GOAL specification for the future <c>CSharpExpressionConverter</c>. Each test mirrors
    /// a case from the Logic App <c>ExpressionConverterTests</c> and asserts the *target*
    /// C# expression source that the converter should emit (to be compiled/evaluated as C#
    /// at runtime) instead of the Logic App <c>@...</c> string.
    ///
    /// Runtime model: workflow data/functions are free functions in scope
    /// (variables("X"), triggerOutputs(), encodeURIComponent("s"), ...).
    ///
    /// These tests are RED until the converter exists; each comment shows the LA output for
    /// side-by-side comparison. "IMPROVEMENT" marks cases the LA converter cannot handle.
    /// </summary>
    public class CSharpExpressionConverterTests
    {
        // -------------------- Literals / constant folding --------------------

        [Fact]
        public void Convert_StringLiteral_EmitsQuotedString()
        {
            // LA: "hello"
            Assert.Equal("\"hello\"", CSharpExpressionConverter.ConvertO(() => "hello"));
        }

        [Fact]
        public void Convert_BoolConstant_EmitsBoolLiteral()
        {
            // LA: "True"
            Assert.Equal("true", CSharpExpressionConverter.ConvertO(() => true));
        }

        [Fact]
        public void Convert_IntExpression_EmitsFoldedConstant()
        {
            // LA: "3" (compiler folds 1 + 2 before the converter sees it)
            Assert.Equal("3", CSharpExpressionConverter.ConvertO(() => 1 + 2));
        }

        [Fact]
        public void Convert_DoubleExpression_EmitsFoldedConstant()
        {
            // LA: "4"
            Assert.Equal("4", CSharpExpressionConverter.ConvertO(() => 1.5 + 2.5));
        }

        // -------------------- Comparison operators --------------------

        [Fact]
        public void Convert_LessThan_EmitsLessThanOperator()
        {
            // LA: @less(1, 2)
            int a = 1, b = 2;
            Assert.Equal("1 < 2", CSharpExpressionConverter.ConvertO(() => a < b));
        }

        [Fact]
        public void Convert_LessThanOrEqual_EmitsLessThanOrEqualOperator()
        {
            // LA: @lessOrEquals(1, 2)
            int a = 1, b = 2;
            Assert.Equal("1 <= 2", CSharpExpressionConverter.ConvertO(() => a <= b));
        }

        [Fact]
        public void Convert_Equal_EmitsEqualityOperator()
        {
            // LA: @equals(1, 2)
            int a = 1, b = 2;
            Assert.Equal("1 == 2", CSharpExpressionConverter.ConvertO(() => a == b));
        }

        [Fact]
        public void Convert_NotEqual_EmitsInequalityOperator()
        {
            // LA: @not(equals(1, 2))
            int a = 1, b = 2;
            Assert.Equal("1 != 2", CSharpExpressionConverter.ConvertO(() => a != b));
        }

        [Fact]
        public void Convert_GreaterThan_EmitsGreaterThanOperator()
        {
            // IMPROVEMENT: the LA converter THROWS NotSupportedException here; native C# supports it.
            int a = 1, b = 2;
            Assert.Equal("1 > 2", CSharpExpressionConverter.ConvertO(() => a > b));
        }

        [Fact]
        public void Convert_GreaterThanOrEqual_EmitsGreaterThanOrEqualOperator()
        {
            // IMPROVEMENT: the LA converter THROWS NotSupportedException here; native C# supports it.
            int a = 1, b = 2;
            Assert.Equal("1 >= 2", CSharpExpressionConverter.ConvertO(() => a >= b));
        }

        // -------------------- Logical operators --------------------

        [Fact]
        public void Convert_AndAlso_EmitsAndOperator()
        {
            // LA: @and(true, false)
            bool t = true, f = false;
            Assert.Equal("true && false", CSharpExpressionConverter.ConvertO(() => t && f));
        }

        [Fact]
        public void Convert_OrElse_EmitsOrOperator()
        {
            // LA: @or(true, false)
            bool t = true, f = false;
            Assert.Equal("true || false", CSharpExpressionConverter.ConvertO(() => t || f));
        }

        // -------------------- Arithmetic operators --------------------

        [Fact]
        public void Convert_Add_EmitsPlusOperator()
        {
            // LA: @equals(add(1, 2), 3)
            int a = 1, b = 2;
            Assert.Equal("1 + 2 == 3", CSharpExpressionConverter.ConvertO(() => (a + b) == 3));
        }

        [Fact]
        public void Convert_Subtract_EmitsMinusOperator()
        {
            // LA: @equals(subtract(1, 2), 3)
            int a = 1, b = 2;
            Assert.Equal("1 - 2 == 3", CSharpExpressionConverter.ConvertO(() => (a - b) == 3));
        }

        [Fact]
        public void Convert_Multiply_EmitsStarOperator()
        {
            // LA: @equals(multiply(1, 2), 3)
            int a = 1, b = 2;
            Assert.Equal("1 * 2 == 3", CSharpExpressionConverter.ConvertO(() => (a * b) == 3));
        }

        [Fact]
        public void Convert_Divide_EmitsSlashOperator()
        {
            // LA: @equals(divide(1, 2), 3)
            int a = 1, b = 2;
            Assert.Equal("1 / 2 == 3", CSharpExpressionConverter.ConvertO(() => (a / b) == 3));
        }

        [Fact]
        public void Convert_Modulo_EmitsPercentOperator()
        {
            // LA: @equals(mod(1, 2), 3)
            int a = 1, b = 2;
            Assert.Equal("1 % 2 == 3", CSharpExpressionConverter.ConvertO(() => (a % b) == 3));
        }

        [Fact]
        public void Convert_AddDouble_EmitsPlusOperator()
        {
            // LA: @equals(add(1.5, 2.5), 4)
            double a = 1.5, b = 2.5;
            Assert.Equal("1.5 + 2.5 == 4", CSharpExpressionConverter.ConvertO(() => (a + b) == 4.0));
        }

        // -------------------- Conditional --------------------

        [Fact]
        public void Convert_Conditional_EmitsTernaryOperator()
        {
            // LA: @if(less(1, 2), 'hello', 'world')
            int a = 1, b = 2;
            string x = "hello", y = "world";
            Assert.Equal(
                "1 < 2 ? \"hello\" : \"world\"",
                CSharpExpressionConverter.ConvertO(() => a < b ? x : y));
        }

        // -------------------- String functions --------------------

        [Fact]
        public void Convert_StringConcat_EmitsPlusOperator()
        {
            // LA: helloworld  (LA folds both literal operands into plain text)
            string a = "hello", b = "world";
            Assert.Equal("\"hello\" + \"world\"", CSharpExpressionConverter.ConvertO(() => a + b));
        }

        [Fact]
        public void Convert_StringFormat_SingleArg_EmitsStringFormatCall()
        {
            // LA: Hello world!
            string name = "world";
            Assert.Equal(
                "string.Format(\"Hello {0}!\", \"world\")",
                CSharpExpressionConverter.ConvertO(() => string.Format("Hello {0}!", name)));
        }

        [Fact]
        public void Convert_StringFormat_TwoArgs_EmitsStringFormatCall()
        {
            // LA: hello-world
            string a = "hello", b = "world";
            Assert.Equal(
                "string.Format(\"{0}-{1}\", \"hello\", \"world\")",
                CSharpExpressionConverter.ConvertO(() => string.Format("{0}-{1}", a, b)));
        }

        [Fact]
        public void Convert_StringConcatMethod_EmitsStringConcatCall()
        {
            // LA: ab
            Assert.Equal(
                "string.Concat(\"a\", \"b\")",
                CSharpExpressionConverter.ConvertO(() => string.Concat("a", "b")));
        }

        [Fact]
        public void Convert_IntToString_EmitsToStringCall()
        {
            // IMPROVEMENT: the LA converter THROWS NotImplementedException; native C# supports it.
            // Parentheses are required so "1." is not parsed as a double literal.
            int a = 1;
            Assert.Equal("(1).ToString()", CSharpExpressionConverter.ConvertO(() => a.ToString()));
        }

        // -------------------- Uri --------------------

        [Fact]
        public void Convert_Uri_EmitsNewUriExpression()
        {
            // LA: http://example.com/path  (raw string)
            Assert.Equal(
                "new Uri(\"http://example.com/path\")",
                CSharpExpressionConverter.ConvertO(() => new Uri("http://example.com/path")));
        }

        // -------------------- URL encoding / base64 wrappers --------------------

        [Fact]
        public void ConvertWithUrlEncoding_Once_WrapsInEncodeUriComponentCall()
        {
            // LA: @{encodeURIComponent('a b')}
            Assert.Equal(
                "encodeURIComponent(\"a b\")",
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => "a b", 1));
        }

        [Fact]
        public void ConvertWithUrlEncoding_Twice_NestsEncodeUriComponentCall()
        {
            // LA: @{encodeURIComponent(encodeURIComponent('a b'))}
            Assert.Equal(
                "encodeURIComponent(encodeURIComponent(\"a b\"))",
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => "a b", 2));
        }

        [Fact]
        public void ConvertOWithBase64_WrapsInBase64Call()
        {
            // LA: @base64('hello')
            Assert.Equal("base64(\"hello\")", CSharpExpressionConverter.ConvertOWithBase64<string>(() => "hello"));
        }

        // -------------------- Workflow context member access --------------------

        [Fact]
        public void Convert_VariableValue_Interpolated_EmitsVariablesCall()
        {
            // LA: @{variables('myVar')}
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "v");

            // Single-hole interpolation collapses to the bare expression.
            Assert.Equal("variables(\"myVar\")", CSharpExpressionConverter.ConvertO(() => $"{variable.Value}"));
        }

        [Fact]
        public void Convert_VariableValue_InConcat_EmitsInterpolatedString()
        {
            // LA: prefix-@{variables('myVar')}
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "v");

            // Text + hole becomes a C# interpolated string.
            Assert.Equal(
                "$\"prefix-{variables(\"myVar\")}\"",
                CSharpExpressionConverter.ConvertO(() => $"prefix-{variable.Value}"));
        }

        // -------------------- Arrays --------------------

        [Fact]
        public void Convert_StringArray_EmitsArrayInitializer()
        {
            // IMPROVEMENT: the LA converter THROWS NotImplementedException for string[].
            Expression<Func<string[]>> e = () => new[] { "a", "b" };
            Assert.Equal("new[] { \"a\", \"b\" }", CSharpExpressionConverter.ConvertO(e));
        }
    }
}
