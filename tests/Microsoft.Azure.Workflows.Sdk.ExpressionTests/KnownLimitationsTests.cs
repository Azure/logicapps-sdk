// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Tests that pin down KNOWN LIMITATIONS / LIKELY BUGS in the expression converter.
    /// These paths are designed for non-literal workflow data (trigger/action outputs);
    /// when they receive an inlined captured value they emit degenerate output or throw.
    /// The assertions lock the current behavior so any future fix is a visible change.
    /// </summary>
    public class KnownLimitationsTests
    {
        [Fact]
        public void Convert_ArrayIndexZero_OnInlinedArray_ProducesDegenerateFirst()
        {
            // BUG: the array literal is stringified instead of emitting a real expression.
            string[] arr = { "x", "y" };
            Assert.Equal("@{first(System.String[])}", ExpressionConverter.Convert(() => $"{arr[0]}"));
        }

        [Fact]
        public void Convert_ArrayIndexN_OnInlinedArray_ProducesDegenerateIndex()
        {
            // BUG: renders "System.String[][1]" — the array literal is stringified.
            string[] arr = { "x", "y" };
            Assert.Equal("@{System.String[][1]}", ExpressionConverter.Convert(() => $"{arr[1]}"));
        }

        [Fact]
        public void Convert_DictionaryIndexer_OnInlinedDictionary_ProducesDegenerateAccess()
        {
            // BUG: the dictionary literal is stringified into the member-access target.
            IDictionary<string, string> dict = new Dictionary<string, string> { ["k"] = "v" };
            Assert.Equal(
                "@System.Collections.Generic.Dictionary`2[System.String,System.String]['k']",
                ExpressionConverter.Convert(() => dict["k"]));
        }

        [Fact]
        public void Convert_JTokenValueOfT_IsNotRecognized()
        {
            // GAP: JToken.ToObject<T>() is a pass-through, but Value<T>() is not matched
            // (it resolves to the IEnumerable<JToken> extension overload) and throws.
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => "v", value: () => "x");
            Assert.Throws<NotImplementedException>(() => ExpressionConverter.Convert(() => variable.Value.Value<string>()));
        }

        [Fact]
        public void Convert_CapturedNullValue_ThrowsNullReferenceException()
        {
            // BUG: VisitMember calls value.GetType() on the inlined value; a captured null
            // value throws NRE instead of producing a null literal.
            string sNull = null;
            Assert.Throws<NullReferenceException>(() => ExpressionConverter.Convert(() => sNull == "x"));
        }

        [Fact]
        public void Convert_BareAgentParameters_WithoutMemberAccess_ThrowsAtRender()
        {
            // GAP: referencing the whole agentparameters() object (no member access) yields a
            // PartialFunctionCallNode that the renderer refuses to render.
            var ctx = new AgentToolContext<Poco>(new Poco { Name = "n" });
            var ex = Assert.Throws<NotSupportedException>(() => ExpressionConverter.Convert(() => $"{ctx.Parameters}"));
            Assert.Contains("PartialFunctionCallNode", ex.Message);
        }

        [Fact]
        public void Convert_ArrayNode_ThrowsAtRender()
        {
            // GAP: an array-valued node reaches the renderer, which has no ArrayNode support.
            var ex = Assert.Throws<NotSupportedException>(() => ExpressionConverter.Convert(() => new[] { "a", "b" } == null));
            Assert.Contains("ArrayNode", ex.Message);
        }

        [Fact]
        public void Convert_NumericLambda_WithMemberAccess_IsNotSupported()
        {
            // LIMITATION: the Func<int>/Func<double> Convert overloads use a minimal visitor
            // that only understands constants; captured-variable member access is rejected.
            double da = 1.5, db = 2.5;
            var ex = Assert.Throws<NotSupportedException>(() => ExpressionConverter.Convert(() => da + db));
            Assert.Contains("MemberExpression", ex.Message);
        }
    }
}
