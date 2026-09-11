// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Additional test coverage for edge cases, string escaping,
    /// workflow data in conditional expressions, and URL encoding.
    /// </summary>
    public class CSharpEdgeCaseTests
    {
        // -------------------- String escaping --------------------

        [Fact]
        public void ConvertO_StringWithQuotes_EmitsEscapedQuotes()
        {
            string s = "say \"hello\"";
            Assert.Equal("\"say \\\"hello\\\"\"", CSharpExpressionConverter.ConvertO(() => s));
        }

        [Fact]
        public void ConvertO_StringWithBackslash_EmitsEscapedBackslash()
        {
            string s = @"C:\path\to\file";
            Assert.Equal("\"C:\\\\path\\\\to\\\\file\"", CSharpExpressionConverter.ConvertO(() => s));
        }

        [Fact]
        public void ConvertO_StringWithNewline_EmitsEscapedNewline()
        {
            string s = "line1\nline2";
            Assert.Equal("\"line1\\nline2\"", CSharpExpressionConverter.ConvertO(() => s));
        }

        [Fact]
        public void ConvertO_StringWithTab_EmitsEscapedTab()
        {
            string s = "col1\tcol2";
            Assert.Equal("\"col1\\tcol2\"", CSharpExpressionConverter.ConvertO(() => s));
        }

        [Fact]
        public void ConvertO_InterpolatedStringWithControlCharacters_EmitsEscapedControlCharacters()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "v");

            Assert.Equal(
                "$\"line1\\n{variables(\"myVar\")}\\t\\0\"",
                CSharpExpressionConverter.ConvertO(() => $"line1\n{variable.Value}\t\0"));
        }

        [Fact]
        public void ConvertO_UserMethodNamedOutputs_DoesNotEmitNullSafeIndexer()
        {
            // A user string containing "outputs(" should NOT be misidentified as workflow data.
            // Member access should use dot notation, not ?["..."] indexer.
            string s = "outputs(x)";
            Assert.Equal("\"outputs(x)\".Length", CSharpExpressionConverter.ConvertO(() => s.Length));
        }

        // -------------------- Null handling --------------------

        [Fact]
        public void ConvertO_NullCapturedString_EmitsNull()
        {
            string s = null;
            Assert.Equal("null", CSharpExpressionConverter.ConvertO(() => s));
        }

        [Fact]
        public void ConvertO_NullComparisonRight_EmitsEqualsNull()
        {
            string s = "x";
            Assert.Equal("\"x\" == null", CSharpExpressionConverter.ConvertO(() => s == null));
        }

        [Fact]
        public void ConvertO_NullComparisonLeft_EmitsNullEquals()
        {
            string s = null;
            Assert.Equal("null == \"x\"", CSharpExpressionConverter.ConvertO(() => s == "x"));
        }

        // -------------------- URL encoding with string --------------------

        [Fact]
        public void ConvertWithUrlEncoding_String_Once_WrapsInEncodeUriComponent()
        {
            Assert.Equal(
                "encodeURIComponent(\"a b\")",
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => "a b", 1));
        }

        [Fact]
        public void ConvertWithUrlEncoding_String_Twice_NestsEncodeUriComponent()
        {
            Assert.Equal(
                "encodeURIComponent(encodeURIComponent(\"a b\"))",
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => "a b", 2));
        }

        // -------------------- Workflow data in conditionals --------------------

        [Fact]
        public void ConvertO_TernaryWithWorkflowData_EmitsConditionalWithOutputsCalls()
        {
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "x").WithName("A");
            var http = WorkflowActions.BuiltIn.HttpAction(
                uri: () => new Uri("http://example.com"),
                method: () => System.Net.Http.HttpMethod.Get).WithName("B");

            bool flag = true;
            Assert.Equal(
                "true ? outputs(\"A\") : body(\"B\")",
                CSharpExpressionConverter.ConvertO(() => flag ? compose.Output : http.Body));
        }

        // -------------------- Chained workflow data access --------------------

        [Fact]
        public void ConvertO_TriggerOutputChainedAccess_EmitsNullSafeIndexerChain()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            Assert.Equal(
                "triggerOutputs().ToObject<global::Microsoft.Azure.Workflows.Sdk.HttpRequestTriggerOutput>().Body",
                CSharpExpressionConverter.ConvertO(() => $"{trigger.TriggerOutput.Body}"));
        }

        // -------------------- Empty/edge cases --------------------

        [Fact]
        public void ConvertO_EmptyString_EmitsEmptyQuotedString()
        {
            string s = "";
            Assert.Equal("\"\"", CSharpExpressionConverter.ConvertO(() => s));
        }

        [Fact]
        public void ConvertO_IntZero_EmitsZero()
        {
            int n = 0;
            Assert.Equal("0", CSharpExpressionConverter.ConvertO(() => n));
        }

        [Fact]
        public void ConvertO_BoolFalse_EmitsFalse()
        {
            bool b = false;
            Assert.Equal("false", CSharpExpressionConverter.ConvertO(() => b));
        }

        // -------------------- Nested arithmetic precedence --------------------

        [Fact]
        public void ConvertO_ComplexArithmetic_EmitsOperators()
        {
            int a = 2, b = 3, c = 4;
            Assert.Equal("2 + 3 * 4", CSharpExpressionConverter.ConvertO(() => a + b * c));
        }

        [Fact]
        public void ConvertO_ParenthesizedAdditionInMultiplication_PreservesPrecedence()
        {
            int a = 2, b = 3, c = 4;
            Assert.Equal("(2 + 3) * 4", CSharpExpressionConverter.ConvertO(() => (a + b) * c));
        }

        [Fact]
        public void ConvertO_NegationOfEquality_WrapsInParens()
        {
            int a = 1, b = 2;
            Assert.Equal("!(1 == 2)", CSharpExpressionConverter.ConvertO(() => !(a == b)));
        }

        [Fact]
        public void ConvertO_NestedLogicalOperators_PreservesPrecedence()
        {
            bool a = true, b = false, c = true;
            Assert.Equal("(true || false) && true", CSharpExpressionConverter.ConvertO(() => (a || b) && c));
        }

        [Fact]
        public void ConvertO_StaticGenericMethod_EmitsTypeArguments()
        {
            Assert.Equal("Enumerable.Empty<int>()", CSharpExpressionConverter.ConvertO(() => Enumerable.Empty<int>()));
        }

        // -------------------- NullCoalescing with workflow data --------------------

        [Fact]
        public void ConvertO_NullCoalesceWithString_EmitsCoalesceOperator()
        {
            string a = "hello", b = "fallback";
            Assert.Equal("\"hello\" ?? \"fallback\"", CSharpExpressionConverter.ConvertO(() => a ?? b));
        }
    }
}
