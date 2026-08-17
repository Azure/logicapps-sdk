// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Stubs;

    /// <summary>
    /// GOAL specification for the remaining converter overloads, mirroring
    /// <c>ExpressionConverterOverloadTests</c>: HttpMethod, integer URL encoding, and enums.
    /// </summary>
    public class CSharpExpressionConverterOverloadTests
    {
        [Fact]
        public void Convert_HttpMethod_EmitsMethodNameString()
        {
            // LA: GET
            Assert.Equal("\"GET\"", CSharpExpressionConverter.Convert(() => System.Net.Http.HttpMethod.Get));
        }

        [Fact]
        public void ConvertWithUrlEncodingWithInt_Once_WrapsInEncodeUriComponentCall()
        {
            // LA: @{encodeURIComponent(42)}
            Assert.Equal("encodeURIComponent(42)", CSharpExpressionConverter.ConvertWithUrlEncodingWithInt(() => 42, 1));
        }

        [Fact]
        public void ConvertWithUrlEncodingWithInt_Twice_NestsEncodeUriComponentCall()
        {
            // LA: @{encodeURIComponent(encodeURIComponent(42))}
            Assert.Equal(
                "encodeURIComponent(encodeURIComponent(42))",
                CSharpExpressionConverter.ConvertWithUrlEncodingWithInt(() => 42, 2));
        }

        [Fact]
        public void Convert_Enum_EmitsMemberValueString()
        {
            // LA: Running
            Assert.Equal("\"Running\"", CSharpExpressionConverter.Convert(() => FlowStatus.Running));
        }

        [Fact]
        public void ConvertWithUrlEncoding_Enum_WrapsEncodedMemberValueCall()
        {
            // LA: @{encodeURIComponent('Running')}
            Assert.Equal(
                "encodeURIComponent(\"Running\")",
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => FlowStatus.Running, 1));
        }
    }
}
