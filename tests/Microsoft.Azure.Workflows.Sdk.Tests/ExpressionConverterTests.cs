// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abortionpolicyapiip;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsax;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
    using Newtonsoft.Json.Linq;
    using Xunit;
    using static WorkflowExpressionTestSource;

    public class ExpressionConverterTests
    {
        [Fact]
        public void BoundaryConversionPreservesRawClrSource()
        {
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "value").WithName("Source");
            var objectAction = WorkflowActions.BuiltIn.Compose(() =>
                new SendMessageInputMessageType { MessageId = previous.Output });
            var objectSource = Input(objectAction);
            Assert.DoesNotContain("JToken.FromObject", objectSource);
            Assert.DoesNotContain("JsonSerializer", objectSource);
            AssertReturnExpression(
                """new global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType { MessageId = outputs("Source").ToObject<string>() }""",
                objectSource);
            Assert.Equal(1, objectSource.Split("outputs(\"Source\")").Length - 1);

            var textAction = WorkflowActions.BuiltIn.Compose(() => previous.Output.ToUpperInvariant());
            var textSource = Input(textAction);
            Assert.DoesNotContain("JToken.FromObject", textSource);
            Assert.DoesNotContain("object result =", textSource);
            AssertReturnExpression("""outputs("Source").ToObject<string>().ToUpperInvariant()""", textSource);
            Assert.Equal(1, textSource.Split("outputs(\"Source\")").Length - 1);
        }

        [Fact]
        public void DynamicHeadersAndStatusCodeRemainExpressions()
        {
            var previous = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Flag");
            var response = WorkflowActions.BuiltIn.Response(
                statusCode: () => previous.Output ? System.Net.HttpStatusCode.Accepted : System.Net.HttpStatusCode.BadRequest,
                headers: () => new Dictionary<string, string> { { "X", previous.Output ? "yes" : "no" } });
            var inputs = JObject.FromObject(response.GetActionDefinition("flow").Inputs);
            var statusSource = inputs["StatusCode"].Value<string>();
            AssertReturnExpression(
                """(int)(outputs("Flag").ToObject<bool>() ? global::System.Net.HttpStatusCode.Accepted : global::System.Net.HttpStatusCode.BadRequest)""",
                statusSource);
            var headersSource = inputs["Headers"].Value<string>();
            AssertReturnExpression(
                """new global::System.Collections.Generic.Dictionary<string, string>() { { "X", outputs("Flag").ToObject<bool>() ? "yes" : "no" } }""",
                headersSource);
        }

        [Fact]
        public void VariableNamesAndRequiredDescriptorValidationRemainExplicit()
        {
            var name = "value";
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => name, value: () => 1);
            Assert.Equal("value", variable.VariableName);
            Assert.Throws<ArgumentNullException>(
                () => WorkflowActions.BuiltIn.Compose<string>(null));
        }

        [Theory]
        [InlineData("#{1 + 2}", "#{\"#{1 + 2}\"}")]
        [InlineData("@value", "@@value")]
        [InlineData("@{triggerBody()}", "#{\"@{triggerBody()}\"}")]
        public void LiteralExpressionMarkersRemainData(string value, string expected)
        {
            var action = WorkflowActions.BuiltIn.Compose(() => value);

            Assert.Equal(expected, ((JToken)action.GetActionDefinition("flow").Inputs).Value<string>());
        }

        [Fact]
        public void GeneratedPathsComposeFragmentsBeforeRendering()
        {
            var dataset = "#{dataset}";
            var table = "@{table}";
            var action = new DynamicsaxActions("connection").GetItems(
                () => dataset,
                () => table);
            var path = ((ApiConnectionActionInput)action.GetActionDefinition("flow").Inputs).Path;

            AssertReturnExpression(
                """"
                "/datasets/" +
                    encodeURIComponent(encodeURIComponent("#{dataset}")) +
                    "/tables/" +
                    encodeURIComponent(encodeURIComponent("@{table}")) +
                    "/items"
                """",
                path);
        }

        [Fact]
        public void GeneratedPathsResolveBindingsOnlyWhenConverted()
        {
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "value");
            var action = new AbortionpolicyapiipActions("connection")
                .GetGestationalLimitsbyStatebyZip(() => previous.Output);

            previous.WithName("Renamed");

            AssertReturnExpression(
                """
                "/v1/gestational_limits/zips/" +
                    encodeURIComponent(outputs("Renamed").ToObject<string>())
                """,
                ((ApiConnectionActionInput)action.GetActionDefinition("flow").Inputs).Path);
        }

        [Fact]
        public void GeneratedPathsUseCanonicalFlatConcatenation()
        {
            var action = new MsnweatherActions("connection").CurrentWeather(
                () => "98058",
                () => unitsInput.Imperial);

            Assert.Equal(
                """#{"/current/" + (encodeURIComponent("98058"))}""",
                ((ApiConnectionActionInput)action.GetActionDefinition("flow").Inputs).Path);
        }

    }
}
