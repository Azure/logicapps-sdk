// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Collections.Generic;
    using Microsoft.Azure.Workflows.Sdk;
        using Newtonsoft.Json.Linq;

    /// <summary>
    /// GOAL specification for cases the Logic App converter handles incorrectly
    /// (documented in <c>KnownLimitationsTests</c> as degenerate output or thrown
    /// exceptions). Under the native C# model these all become clean, valid, evaluable
    /// expressions — this is a core motivation for the C# converter.
    /// </summary>
    public class CSharpImprovedBehaviorTests
    {
        [Fact]
        public void Convert_ArrayIndexZero_EmitsIndexer()
        {
            // LA BUG: emits the degenerate @{first(System.String[])}.
            string[] arr = { "x", "y" };
            Assert.Equal(
                "new[] { \"x\", \"y\" }[0]",
                CSharpExpressionConverter.ConvertO(() => $"{arr[0]}"));
        }

        [Fact]
        public void Convert_ArrayIndexN_EmitsIndexer()
        {
            // LA BUG: emits the degenerate @{System.String[][1]}.
            string[] arr = { "x", "y" };
            Assert.Equal(
                "new[] { \"x\", \"y\" }[1]",
                CSharpExpressionConverter.ConvertO(() => $"{arr[1]}"));
        }

        [Fact]
        public void Convert_DictionaryIndexer_EmitsIndexer()
        {
            // LA BUG: stringifies the dictionary type into the access target.
            IDictionary<string, string> dict = new Dictionary<string, string> { ["k"] = "v" };
            Assert.Equal(
                "new Dictionary<string, string> { [\"k\"] = \"v\" }[\"k\"]",
                CSharpExpressionConverter.ConvertO(() => dict["k"]));
        }

        [Fact]
        public void Convert_JTokenValueOfT_EmitsTypedValueCall()
        {
            // LA GAP: JToken.Value<T>() throws NotImplementedException.
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => "myVar", value: () => "v");
            Assert.Equal(
                "variables(\"myVar\").Value<string>()",
                CSharpExpressionConverter.ConvertO(() => variable.Value.Value<string>()));
        }

        [Fact]
        public void Convert_CapturedNullValue_EmitsNullKeyword()
        {
            // LA BUG: captured null throws NullReferenceException (value.GetType() in VisitMember).
            string sNull = null;
            Assert.Equal("null == \"x\"", CSharpExpressionConverter.ConvertO(() => sNull == "x"));
        }
    }
}
