// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Characterization tests for the remaining <see cref="ExpressionConverter"/> public
    /// overloads: HttpMethod, integer URL encoding, and the enum-based overloads.
    /// </summary>
    public class ExpressionConverterOverloadTests
    {
        [Fact]
        public void Convert_HttpMethod_ReturnsMethodName()
        {
            Assert.Equal("GET", ExpressionConverter.Convert(() => System.Net.Http.HttpMethod.Get));
        }

        [Fact]
        public void ConvertWithUrlEncodingWithInt_Once_WrapsInEncodeUriComponent()
        {
            Assert.Equal("@{encodeURIComponent(42)}", ExpressionConverter.ConvertWithUrlEncodingWithInt(() => 42, 1));
        }

        [Fact]
        public void ConvertWithUrlEncodingWithInt_Twice_NestsEncodeUriComponent()
        {
            Assert.Equal(
                "@{encodeURIComponent(encodeURIComponent(42))}",
                ExpressionConverter.ConvertWithUrlEncodingWithInt(() => 42, 2));
        }

        [Fact]
        public void Convert_Enum_ReturnsEnumMemberValue()
        {
            Assert.Equal("Running", ExpressionConverter.Convert(() => FlowStatus.Running));
        }

        [Fact]
        public void ConvertWithUrlEncoding_Enum_WrapsEncodedMemberValue()
        {
            Assert.Equal(
                "@{encodeURIComponent('Running')}",
                ExpressionConverter.ConvertWithUrlEncoding(() => FlowStatus.Running, 1));
        }
    }
}
