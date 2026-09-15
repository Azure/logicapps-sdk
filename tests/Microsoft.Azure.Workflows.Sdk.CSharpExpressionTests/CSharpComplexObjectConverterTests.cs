// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// GOAL specification for object payloads, mirroring <c>ComplexObjectConverterTests</c>.
    ///
    /// Key insight of the C# model: object payloads no longer need the JSON-building
    /// machinery of the LA <c>ComplexObjectConverter</c>. The emitted C# is simply the
    /// native object-initializer source, compiled and (if a JSON payload is needed)
    /// serialized at runtime.
    ///
    /// NOTE: the exact source formatting below (member order, numeric suffixes such as
    /// <c>10L</c>/<c>2.5m</c>, and <c>(string)null</c>) is a target to be finalized during
    /// converter design; these tests pin a concrete, reviewable starting point.
    /// </summary>
    public class CSharpComplexObjectConverterTests
    {
        [Fact]
        public void ConvertO_AnonymousType_EmitsAnonymousInitializer()
        {
            // LA JSON: {"a":"x","b":1}
            Assert.Equal(
                "new { a = \"x\", b = 1 }",
                CSharpExpressionConverter.ConvertCSharp(() => new { a = "x", b = 1 }));
        }

        [Fact]
        public void ConvertO_MemberInit_EmitsObjectInitializer()
        {
            // LA JSON: {"Name":"n","Count":2,"renamed":"t"}
            Assert.Equal(
                "new Poco { Name = \"n\", Count = 2, Tag = \"t\" }",
                CSharpExpressionConverter.ConvertCSharp(() => new Poco { Name = "n", Count = 2, Tag = "t" }));
        }

        [Fact]
        public void ConvertO_Array_EmitsArrayInitializer()
        {
            // LA JSON: ["a","b"]
            Assert.Equal(
                "new[] { \"a\", \"b\" }",
                CSharpExpressionConverter.ConvertCSharp(() => new[] { "a", "b" }));
        }

        [Fact]
        public void ConvertO_NestedObjectsAndArrays_EmitsNestedInitializers()
        {
            // LA JSON: {"outer":{"inner":5},"list":[1,2]}
            Assert.Equal(
                "new { outer = new { inner = 5 }, list = new[] { 1, 2 } }",
                CSharpExpressionConverter.ConvertCSharp(() => new { outer = new { inner = 5 }, list = new[] { 1, 2 } }));
        }

        [Fact]
        public void ConvertO_ConstantsOfAllSupportedTypes_EmitsTypedInitializer()
        {
            // LA JSON: {"b":true,"l":10,"d":1.5,"dec":2.5,"e":"Running","n":null}
            Assert.Equal(
                "new { b = true, l = 10L, d = 1.5, dec = 2.5m, e = FlowStatus.Running, n = (string)null }",
                CSharpExpressionConverter.ConvertCSharp(() => new { b = true, l = 10L, d = 1.5, dec = 2.5m, e = FlowStatus.Running, n = (string)null }));
        }

        [Fact]
        public void ConvertObject_EmitsObjectInitializer()
        {
            // LA: ConvertObject rewrites string members through the converter and re-compiles.
            // The C# model just emits the initializer source.
            Assert.Equal(
                "new Poco { Name = \"hi\", Count = 3 }",
                CSharpExpressionConverter.ConvertCSharp(() => new Poco { Name = "hi", Count = 3 }));
        }
    }
}
