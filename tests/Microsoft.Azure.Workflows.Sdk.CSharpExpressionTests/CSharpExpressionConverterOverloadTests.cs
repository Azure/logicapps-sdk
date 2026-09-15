// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Runtime.Serialization;
    using Microsoft.Azure.Workflows.Sdk;

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
            Assert.Equal("\"GET\"", CSharpExpressionConverter.ConvertCSharp(() => System.Net.Http.HttpMethod.Get));
        }

        [Fact]
        public void ConvertWithUrlEncodingWithInt_Once_WrapsInEncodeUriComponentCall()
        {
            // LA: @{encodeURIComponent(42)}
            Assert.Equal("@{encodeURIComponent(42)}", CSharpExpressionConverter.ConvertWithUrlEncodingWithInt(() => 42, 1));
        }

        [Fact]
        public void ConvertWithUrlEncodingWithInt_Twice_NestsEncodeUriComponentCall()
        {
            // LA: @{encodeURIComponent(encodeURIComponent(42))}
            Assert.Equal(
                "@{encodeURIComponent(encodeURIComponent(42))}",
                CSharpExpressionConverter.ConvertWithUrlEncodingWithInt(() => 42, 2));
        }

        [Fact]
        public void Convert_Enum_EmitsMemberValueString()
        {
            // LA: Running
            Assert.Equal("Running", CSharpExpressionConverter.Convert(() => FlowStatus.Running));
        }

        [Fact]
        public void ConvertWithUrlEncoding_Enum_WrapsEncodedMemberValueCall()
        {
            // LA: @{encodeURIComponent('Running')}
            Assert.Equal(
                "@{encodeURIComponent('Running')}",
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => FlowStatus.Running, 1));
        }

        [Fact]
        public void ConvertFormattedString_WithMultipleArguments_EmitsCompleteCSharpExpression()
        {
            Assert.Equal(
                "/datasets/@{encodeURIComponent('orders')}/items/@{encodeURIComponent(42)}",
                CSharpExpressionConverter.ConvertFormattedString(
                    "/datasets/{0}/items/{1}",
                    CSharpExpressionConverter.ConvertWithUrlEncoding(() => "orders", 1),
                    CSharpExpressionConverter.ConvertWithUrlEncodingWithInt(() => 42, 1)));
        }

        [Fact]
        public void ConvertFormattedString_WithoutArguments_EmitsStringLiteral()
        {
            Assert.Equal(
                "/datasets/static",
                CSharpExpressionConverter.ConvertFormattedString("/datasets/static"));
        }

        [Fact]
        public void ConvertFormattedString_EscapesFormatLiteral()
        {
            Assert.Equal(
                "/datasets/\"@{encodeURIComponent('orders')}\"",
                CSharpExpressionConverter.ConvertFormattedString(
                    "/datasets/\"{0}\"",
                    CSharpExpressionConverter.ConvertWithUrlEncoding(() => "orders", 1)));
        }

        [Fact]
        public void ConvertFormattedString_WithCSharpArgument_EmitsWrappedCSharpExpression()
        {
            Assert.Equal(
                "@csharp{string.Format(System.Globalization.CultureInfo.InvariantCulture, \"/datasets/{0}\", encodeURIComponent(\"orders\".ToUpper()))}",
                CSharpExpressionConverter.ConvertFormattedString(
                    "/datasets/{0}",
                    CSharpExpressionConverter.ConvertWithUrlEncoding(() => "orders".ToUpper(), 1)));
        }

        [Fact]
        public void ConvertGeneratedPath_WithCSharpAndEnumArguments_UsesEnumWireValue()
        {
            Assert.Equal(
                "@csharp{string.Format(System.Globalization.CultureInfo.InvariantCulture, \"/{0}/{1}\", encodeURIComponent(\"orders\".ToUpper()), encodeURIComponent(\"wire-running\"))}",
                CSharpExpressionConverter.ConvertGeneratedPath(
                    "/{0}/{1}",
                    CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(
                        () => "orders".ToUpper(),
                        1),
                    CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(
                        () => WireStatus.Running,
                        1)));
        }

        [Fact]
        public void ConvertFormattedString_NullFormat_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => CSharpExpressionConverter.ConvertFormattedString(null));
        }

        [Fact]
        public void ConvertFormattedString_EmptyArgument_Throws()
        {
            Assert.Throws<ArgumentException>(() => CSharpExpressionConverter.ConvertFormattedString("/{0}", string.Empty));
        }

        private enum WireStatus
        {
            [EnumMember(Value = "wire-running")]
            Running
        }
    }
}
