// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json;

    /// <summary>
    /// Tests the unified workflow expression converter facade.
    /// </summary>
    public class ExpressionConverterTests
    {
        [Fact]
        public void Convert_LiteralsRemainBuildTimeValues()
        {
            Assert.Equal("hello", ExpressionConverter.Convert(Tree(() => "hello")));
            Assert.Equal("True", ExpressionConverter.Convert(Tree(() => true)));
            Assert.Equal("3", ExpressionConverter.Convert(Tree(() => 1 + 2)));
            Assert.Equal("GET", ExpressionConverter.Convert(Tree(() => System.Net.Http.HttpMethod.Get)));
            Assert.Equal("Running", ExpressionConverter.Convert(Tree(() => FlowStatus.Running)));
        }

        [Fact]
        public void Convert_NativeExpression_IsWrappedAsCSharp()
        {
            int left = 1;
            int right = 2;

            Assert.Equal(
                "@csharp{1 < 2}",
                ExpressionConverter.Convert(Tree(() => left < right)));
            Assert.Equal(
                "@csharp{1 >= 2}",
                ExpressionConverter.Convert(Tree(() => left >= right)));
        }

        [Fact]
        public void Convert_RuntimeFunctions_AreWrappedAsCSharp()
        {
            Assert.Equal(
                "@{encodeURIComponent('a b')}",
                ExpressionConverter.ConvertWithUrlEncoding(Tree(() => "a b"), 1));
            Assert.Equal(
                "@{encodeURIComponent(encodeURIComponent(42))}",
                ExpressionConverter.ConvertWithUrlEncodingWithInt(Tree(() => 42), 2));
            Assert.Equal(
                "@csharp{base64(\"hello\")}",
                ExpressionConverter.ConvertOWithBase64(Tree(() => "hello")));
        }

        [Fact]
        public void Convert_InlineUrlEncoding_UsesTemplateSubset()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "value");

            Assert.Equal(
                "@{encodeURIComponent(encodeURIComponent(variables('myVar')))}",
                ExpressionConverter.ConvertWithUrlEncoding(
                    Tree(() => variable.Value.ToObject<string>()),
                    2));
            Assert.Equal(
                "@{encodeURIComponent(concat('prefix-', variables('myVar')))}",
                ExpressionConverter.ConvertWithUrlEncoding(
                    Tree(() => "prefix-" + variable.Value.ToObject<string>()),
                    1));
        }

        [Fact]
        public void Convert_WorkflowReference_IsWrappedAsCSharp()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "value");

            Assert.Equal(
                "@csharp{variables(\"myVar\")}",
                ExpressionConverter.Convert(Tree(() => $"{variable.Value}")));
        }

        [Fact]
        public void Convert_ForEachPlaceholder_RemainsRuntimeItemReference()
        {
            var item = new ForEachItemToken();

            Assert.Equal(
                "@csharp{item()}",
                ExpressionConverter.Convert(Tree(() => $"{item}")));
        }

        [Fact]
        public void Compose_InterceptorPreservesArbitraryCSharpSyntax()
        {
            var compose = WorkflowActions.BuiltIn.Compose(
                () => DateTime.UtcNow.DayOfWeek switch
                {
                    DayOfWeek.Saturday or DayOfWeek.Sunday => "weekend",
                    _ => "weekday",
                });

            Assert.Equal(
                "@csharp{DateTime.UtcNow.DayOfWeek switch\r\n{\r\n    DayOfWeek.Saturday or DayOfWeek.Sunday => \"weekend\",\r\n    _ => \"weekday\",\r\n}}",
                (string)(Newtonsoft.Json.Linq.JToken)compose.GetActionDefinition("flow").Inputs);
        }

        [Fact]
        public void Compose_InterceptorBindsFinalWorkflowOperationName()
        {
            var finalName = "DynamicallyNamed";
            var source = WorkflowActions.BuiltIn.Compose(() => "value").WithName(finalName);
            var target = WorkflowActions.BuiltIn.Compose(() => $"{source.Output}");

            Assert.Equal(
                "@csharp{$\"{outputs(\"DynamicallyNamed\")}\"}",
                (string)(Newtonsoft.Json.Linq.JToken)target.GetActionDefinition("flow").Inputs);
        }

        [Fact]
        public void Interceptor_BindsCapturedScalarValues()
        {
            var threshold = 5;
            var dataset = "captured-dataset";
            var compose = WorkflowActions.BuiltIn.Compose(() => threshold + 1);
            var getItems = WorkflowActions.Managed.Sharepointonline("sharepoint").GetItems(
                dataset: () => dataset,
                table: () => "items");

            Assert.Equal(
                "@csharp{5 + 1}",
                (string)(Newtonsoft.Json.Linq.JToken)compose.GetActionDefinition("flow").Inputs);
            Assert.Contains(
                "@{encodeURIComponent(encodeURIComponent('captured-dataset'))}",
                Newtonsoft.Json.Linq.JObject.FromObject(getItems.GetActionDefinition("flow")).ToString());
        }

        [Fact]
        public void ConvertO_ComplexPayload_PreservesLiteralsAndWrapsExpressions()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "value");

            var converted = ExpressionConverter.ConvertO(Tree(
                () => new Poco
                {
                    Name = variable.Value.ToObject<string>(),
                    Count = 2,
                    Tag = "literal",
                }));

            Assert.Equal(
                "{\"Name\":\"@csharp{variables(\\\"myVar\\\").ToObject<string>()}\",\"Count\":2,\"renamed\":\"literal\"}",
                converted.ToString(Formatting.None));
        }

        [Fact]
        public void ConvertO_ArrayLiteral_RemainsJson()
        {
            Assert.Equal(
                "[\"a\",\"b\"]",
                ExpressionConverter.ConvertO(Tree(() => new[] { "a", "b" })).ToString(Formatting.None));
        }

        [Fact]
        public void ConvertObject_StringMembersUseUnifiedConversion()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar",
                value: () => "value");

            var converted = ExpressionConverter.ConvertObject(
                () => new Poco
                {
                    Name = variable.Value.ToObject<string>(),
                    Count = 3,
                });

            Assert.Equal("@csharp{variables(\"myVar\").ToObject<string>()}", converted.Name);
            Assert.Equal(3, converted.Count);
        }

        private static Expression<Func<T>> Tree<T>(Expression<Func<T>> expression) =>
            expression;
    }
}
