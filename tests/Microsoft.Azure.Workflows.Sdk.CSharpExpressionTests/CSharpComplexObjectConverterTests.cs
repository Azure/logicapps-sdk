// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk;
    
    /// <summary>
    /// GOAL specification for object payloads, mirroring <c>ComplexObjectConverterTests</c>.
    ///
    /// Anonymous and runtime-supported payloads use native C# initializers. Payload types
    /// from the SDK or a codeful project are rejected because their assemblies are not
    /// available to the runtime expression engine.
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
                CSharpExpressionConverter.ConvertO(() => new { a = "x", b = 1 }));
        }

        [Fact]
        public void ConvertO_MemberInitForUnavailableType_IsRejected()
        {
            Assert.Throws<NotSupportedException>(
                () => CSharpExpressionConverter.ConvertO(
                    () => new Poco { Name = "n", Count = 2, Tag = "t" }));
        }

        [Fact]
        public void ConvertO_Array_EmitsArrayInitializer()
        {
            // LA JSON: ["a","b"]
            Assert.Equal(
                "new[] { \"a\", \"b\" }",
                CSharpExpressionConverter.ConvertO(() => new[] { "a", "b" }));
        }

        [Fact]
        public void ConvertO_NestedObjectsAndArrays_EmitsNestedInitializers()
        {
            // LA JSON: {"outer":{"inner":5},"list":[1,2]}
            Assert.Equal(
                "new { outer = new { inner = 5 }, list = new[] { 1, 2 } }",
                CSharpExpressionConverter.ConvertO(() => new { outer = new { inner = 5 }, list = new[] { 1, 2 } }));
        }

        [Fact]
        public void ConvertO_ConstantsOfAllSupportedTypes_EmitsTypedInitializer()
        {
            // LA JSON: {"b":true,"l":10,"d":1.5,"dec":2.5,"e":"Running","n":null}
            Assert.Equal(
                "new { b = true, l = 10L, d = 1.5, dec = 2.5m, e = \"Running\", n = (string)null }",
                CSharpExpressionConverter.ConvertO(() => new { b = true, l = 10L, d = 1.5, dec = 2.5m, e = FlowStatus.Running, n = (string)null }));
        }

        [Fact]
        public void ConvertObject_ForUnavailableType_IsRejected()
        {
            Assert.Throws<NotSupportedException>(
                () => CSharpExpressionConverter.ConvertO(() => new Poco { Name = "hi", Count = 3 }));
        }
    }
}
