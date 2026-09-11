// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System;
    using Microsoft.Azure.Workflows.Sdk;
    
    /// <summary>
    /// GOAL specification for method-call function mappings and literal rendering,
    /// mirroring <c>FunctionMappingTests</c>. The C# model prefers native BCL calls and
    /// operators over Logic App workflow functions.
    /// </summary>
    public class CSharpFunctionMappingTests
    {
        // -------------------- Function mappings --------------------

        [Fact]
        public void Convert_WorkflowFunctionsToJson_EmitsJsonCall()
        {
            // LA: @json('{"k":1}')
            string input = "{\"k\":1}";
            Assert.Equal(
                "json(\"{\\\"k\\\":1}\")",
                CSharpExpressionConverter.ConvertO(() => WorkflowFunctions.ToJson<string>(input)));
        }

        [Fact]
        public void Convert_StringConcatArray_EmitsStringConcatCall()
        {
            // LA: abc
            Assert.Equal(
                "string.Concat(new[] { \"a\", \"b\", \"c\" })",
                CSharpExpressionConverter.ConvertO(() => string.Concat(new[] { "a", "b", "c" })));
        }

        [Fact]
        public void Convert_StringFormatArray_EmitsStringFormatCall()
        {
            // LA: abc
            string a = "a", b = "b", c = "c";
            Assert.Equal(
                "string.Format(\"{0}{1}{2}\", new object[] { \"a\", \"b\", \"c\" })",
                CSharpExpressionConverter.ConvertO(() => string.Format("{0}{1}{2}", new object[] { a, b, c })));
        }

        [Fact]
        public void Convert_ObjectToString_EmitsToStringCall()
        {
            // LA: @string('hi')  (C# uses the native object.ToString())
            object o = "hi";
            Assert.Equal("\"hi\".ToString()", CSharpExpressionConverter.ConvertO(() => o.ToString()));
        }

        [Fact]
        public void Convert_ObjectInterpolation_EmitsJsonSerializeCall()
        {
            // LA: @{concat('{', '"Name":', '"', 'n', '"', ',', '"Count":', 2, '}')}
            // IMPROVEMENT: instead of fragile hand-built JSON-via-concat, the C# model
            // serializes the object with a real serializer.
            Assert.Equal(
                "JsonConvert.SerializeObject(new global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Poco { Name = \"n\", Count = 2 })",
                CSharpExpressionConverter.ConvertO(() => $"{new Poco { Name = "n", Count = 2 }}"));
        }

        [Fact]
        public void Convert_JTokenToObject_EmitsTypedReadCall()
        {
            // LA: @variables('myVar')  (LA silently drops the ToObject<T>() call)
            // The C# model keeps the typed read so the runtime value type is preserved.
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => "myVar", value: () => "v");
            Assert.Equal(
                "variables(\"myVar\").ToObject<string>()",
                CSharpExpressionConverter.ConvertO(() => variable.Value.ToObject<string>()));
        }

        [Fact]
        public void Convert_StringFormat_ColonFormat_EmitsStringFormatCall()
        {
            // IMPROVEMENT: the LA converter THROWS FormatException on the "{0:00}" specifier;
            // native string.Format handles it fine.
            int a = 1;
            Assert.Equal(
                "string.Format(\"{0:00}\", 1)",
                CSharpExpressionConverter.ConvertO(() => string.Format("{0:00}", a)));
        }

        // -------------------- Literal rendering --------------------

        [Fact]
        public void Convert_NullLiteralArgument_EmitsNullKeyword()
        {
            // LA: @equals('a', null)
            string s = "a";
            Assert.Equal("\"a\" == null", CSharpExpressionConverter.ConvertO(() => s == null));
        }

        [Fact]
        public void Convert_DateTimeLiteral_EmitsDateTimeParse()
        {
            // LA: @equals(2020-01-02T03:04:05.0000000Z, 2020-01-02T03:04:05.0000000Z)
            // C# has no DateTime literal, so an inlined value round-trips through Parse.
            DateTime d1 = new DateTime(2020, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime d2 = d1;
            Assert.Equal(
                "DateTime.Parse(\"2020-01-02T03:04:05.0000000Z\") == DateTime.Parse(\"2020-01-02T03:04:05.0000000Z\")",
                CSharpExpressionConverter.ConvertO(() => d1 == d2));
        }

        [Fact]
        public void Convert_GuidLiteral_EmitsGuidParse()
        {
            // LA: @equals(00000000-..., 00000000-...)
            Guid g1 = Guid.Empty, g2 = Guid.Empty;
            Assert.Equal(
                "Guid.Parse(\"00000000-0000-0000-0000-000000000000\") == Guid.Parse(\"00000000-0000-0000-0000-000000000000\")",
                CSharpExpressionConverter.ConvertO(() => g1 == g2));
        }
    }
}
