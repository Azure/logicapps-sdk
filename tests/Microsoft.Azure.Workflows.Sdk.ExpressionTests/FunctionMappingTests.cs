// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using System;
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Characterization tests for method-call function mappings and literal rendering
    /// paths in the <c>LogicConverter</c> / <c>LogicExpressionRenderer</c>.
    /// </summary>
    public class FunctionMappingTests
    {
        // -------------------- Function mappings --------------------

        [Fact]
        public void Convert_WorkflowFunctionsToJson_EmitsJsonFunction()
        {
            string input = "{\"k\":1}";
            Assert.Equal("@json('{\"k\":1}')", ExpressionConverter.Convert(() => WorkflowFunctions.ToJson<string>(input)));
        }

        [Fact]
        public void Convert_StringConcatArray_EmitsConcatText()
        {
            Assert.Equal("abc", ExpressionConverter.Convert(() => string.Concat(new[] { "a", "b", "c" })));
        }

        [Fact]
        public void Convert_StringFormatArray_EmitsConcatText()
        {
            string a = "a", b = "b", c = "c";
            Assert.Equal("abc", ExpressionConverter.Convert(() => string.Format("{0}{1}{2}", new object[] { a, b, c })));
        }

        [Fact]
        public void Convert_ObjectToString_EmitsStringFunction()
        {
            // Static type must be object for the object.ToString() overload to be matched.
            object o = "hi";
            Assert.Equal("@string('hi')", ExpressionConverter.Convert(() => o.ToString()));
        }

        [Fact]
        public void Convert_MemberInit_BuildsJsonObjectViaConcat()
        {
            Assert.Equal(
                "@{concat('{', '\"Name\":', '\"', 'n', '\"', ',', '\"Count\":', 2, '}')}",
                ExpressionConverter.Convert(() => $"{new Poco { Name = "n", Count = 2 }}"));
        }

        [Fact]
        public void Convert_JTokenToObject_IsPassThrough()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => "myVar", value: () => "v");
            Assert.Equal("@variables('myVar')", ExpressionConverter.Convert(() => variable.Value.ToObject<string>()));
        }

        [Fact]
        public void Convert_StringFormat_ColonFormat_IsNotSupported()
        {
            int a = 1;
            Assert.Throws<FormatException>(() => ExpressionConverter.Convert(() => string.Format("{0:00}", a)));
        }

        // -------------------- Literal rendering --------------------

        [Fact]
        public void Convert_NullLiteralArgument_RendersNull()
        {
            string s = "a";
            Assert.Equal("@equals('a', null)", ExpressionConverter.Convert(() => s == null));
        }

        [Fact]
        public void Convert_DateTimeLiteral_RendersIso8601()
        {
            DateTime d1 = new DateTime(2020, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime d2 = d1;
            Assert.Equal(
                "@equals(2020-01-02T03:04:05.0000000Z, 2020-01-02T03:04:05.0000000Z)",
                ExpressionConverter.Convert(() => d1 == d2));
        }

        [Fact]
        public void Convert_OtherLiteralType_RendersViaToString()
        {
            Guid g1 = Guid.Empty, g2 = Guid.Empty;
            Assert.Equal(
                "@equals(00000000-0000-0000-0000-000000000000, 00000000-0000-0000-0000-000000000000)",
                ExpressionConverter.Convert(() => g1 == g2));
        }
    }
}
