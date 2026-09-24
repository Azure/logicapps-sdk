// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Newtonsoft.Json.Linq;

    public class StructuredInputSerializationTests
    {
        [Fact]
        public void NativeMemberInitializer_PreservesJsonPropertyNamesAndRuntimeValues()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var action = WorkflowActions.BuiltIn.Response(
                responseBody: () => new Poco { Name = "n", Count = 2, Tag = source.Output });
            var body = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"]["body"];

            using var compiled = EmittedExpressionCompiler.Compile(body.Value<string>());
            var value = Assert.IsType<Poco>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Source"] = "runtime" }));
            Assert.True(JToken.DeepEquals(JObject.Parse(
                """{"Name":"n","Count":2,"renamed":"runtime"}"""), JToken.FromObject(value)));
        }

        [Fact]
        public void NestedPayload_PreservesPrimitiveTypesNullAndEnumWireValue()
        {
            var action = WorkflowActions.BuiltIn.Response(responseBody: () => new
            {
                nested = new { b = true, l = 10L, d = 1.5, dec = 2.5m, e = FlowStatus.Running, n = (string)null },
                list = new[] { 1, 2 },
            });
            var body = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"]["body"];
            var expected = JObject.Parse(
                """{"nested":{"b":true,"l":10,"d":1.5,"dec":2.5,"e":"Running","n":null},"list":[1,2]}""");

            Assert.True(JToken.DeepEquals(expected, body), body.ToString());
        }
    }
}
