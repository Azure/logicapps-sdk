// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json;

    /// <summary>
    /// Characterization tests for <see cref="ExpressionConverter.ConvertO{T}"/> (the
    /// <c>ComplexObjectConverter</c>, which builds a JSON token) and
    /// Tests structured template and hybrid object conversion.
    /// </summary>
    public class ComplexObjectConverterTests
    {
        private static string Json<T>(System.Linq.Expressions.Expression<System.Func<T>> e) =>
            ExpressionConverter.ConvertO(e).ToString(Formatting.None);

        [Fact]
        public void ConvertO_AnonymousType_BuildsJObject()
        {
            Assert.Equal("{\"a\":\"x\",\"b\":1}", Json(() => new { a = "x", b = 1 }));
        }

        [Fact]
        public void ConvertO_MemberInit_BuildsJObject_RespectingJsonProperty()
        {
            // Tag carries [JsonProperty("renamed")]; Name/Count use their declared names.
            Assert.Equal(
                "{\"Name\":\"n\",\"Count\":2,\"renamed\":\"t\"}",
                Json(() => new Poco { Name = "n", Count = 2, Tag = "t" }));
        }

        [Fact]
        public void ConvertO_Array_BuildsJArray()
        {
            Assert.Equal("[\"a\",\"b\"]", Json(() => new[] { "a", "b" }));
        }

        [Fact]
        public void ConvertO_NestedObjectsAndArrays_BuildNestedJson()
        {
            Assert.Equal(
                "{\"outer\":{\"inner\":5},\"list\":[1,2]}",
                Json(() => new { outer = new { inner = 5 }, list = new[] { 1, 2 } }));
        }

        [Fact]
        public void ConvertO_ConstantsOfAllSupportedTypes_AreConverted()
        {
            Assert.Equal(
                "{\"b\":true,\"l\":10,\"d\":1.5,\"dec\":2.5,\"e\":\"Running\",\"n\":null}",
                Json(() => new { b = true, l = 10L, d = 1.5, dec = 2.5m, e = FlowStatus.Running, n = (string)null }));
        }

        [Fact]
        public void CSharpConvertObject_RewritesStringMembersThroughConverter_AndCompiles()
        {
            var result = CSharpExpressionConverter.ConvertObject(() => new Poco { Name = "hi", Count = 3 });
            Assert.Equal("hi", result.Name);
            Assert.Equal(3, result.Count);
        }
    }
}
