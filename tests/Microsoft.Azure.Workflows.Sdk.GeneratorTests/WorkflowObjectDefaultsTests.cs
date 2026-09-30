// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.GeneratorTests;

using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json.Linq;

public class WorkflowObjectDefaultsTests
{
    private const string ModelDeclarations =
        """
        public sealed class DefaultedInput
        {
            [JsonProperty("enabled"), DefaultValue(true)]
            public bool? Enabled { get; set; } = true;

            [JsonProperty("count"), DefaultValue(5)]
            public int? Count { get; set; } = 5;

            [JsonProperty("mode"), DefaultValue(DefaultMode.Replace)]
            public DefaultMode? Mode { get; set; } = DefaultMode.Replace;

            [JsonProperty("payload"), DefaultValue("{\"name\":\"default\"}")]
            public JToken Payload { get; set; } = JToken.Parse("{\"name\":\"default\"}");

            [JsonProperty("unconfigured")]
            public string Unconfigured { get; set; }
        }

        public enum DefaultMode
        {
            [EnumMember(Value = "merge")] Merge,
            [EnumMember(Value = "replace")] Replace,
        }

        public sealed class ParameterizedDefaultedInput
        {
            public ParameterizedDefaultedInput(int value) => Value = value;
            [JsonProperty("value"), DefaultValue(5)]
            public int Value { get; set; } = 5;
        }

        public sealed class CustomConstructorInput
        {
            public CustomConstructorInput() => throw new InvalidOperationException();
            [JsonProperty("value")]
            public int Value { get; set; }
        }
        """;

    [Theory]
    [InlineData("new DefaultedInput { Enabled = false }", false, 5)]
    [InlineData("new DefaultedInput { Count = 0 }", true, 0)]
    [InlineData("new DefaultedInput()", true, 5)]
    public void DefaultsApplyOnlyToUnboundMembers(string expression, bool enabled, int count)
    {
        var converted = Assert.IsType<JObject>(EvaluateGeneratedExpression(expression));

        Assert.Equal(enabled, converted.Value<bool>("enabled"));
        Assert.Equal(count, converted.Value<int>("count"));
        Assert.Equal("replace", converted.Value<string>("mode"));
        Assert.Equal("default", converted["payload"]!.Value<string>("name"));
        Assert.Null(converted["unconfigured"]);
    }

    [Fact]
    public void ExplicitNullAndEnumValuesOverrideDefaults()
    {
        var converted = Assert.IsType<JObject>(EvaluateGeneratedExpression(
            "new DefaultedInput { Payload = null, Mode = DefaultMode.Merge }"));

        Assert.Equal(JTokenType.Null, converted["payload"]!.Type);
        Assert.Equal("merge", converted.Value<string>("mode"));
    }

    [Theory]
    [InlineData("new GetChatCompletionsInputMessagesTypeItem[] { new GetChatCompletionsInputMessagesTypeItem { Content = \"hello\" } }")]
    [InlineData("new[] { new GetChatCompletionsInputMessagesTypeItem { Content = \"hello\" } }")]
    [InlineData("new GetChatCompletionsInputMessagesTypeItem[] { new() { Content = \"hello\" } }")]
    public void GeneratedServiceProviderInputArraysPreserveDefaults(string expression)
    {
        var converted = Assert.IsType<JArray>(EvaluateGeneratedExpression(expression));

        var message = Assert.Single(converted);
        Assert.Equal("User", message.Value<string>("role"));
        Assert.Equal("hello", message.Value<string>("content"));
    }

    [Fact]
    public void NullObjectArrayElementsRemainNull()
    {
        var converted = Assert.IsType<JArray>(EvaluateGeneratedExpression("new DefaultedInput[] { null }"));

        Assert.Equal(JTokenType.Null, Assert.Single(converted).Type);
    }

    [Theory]
    [InlineData("new ParameterizedDefaultedInput(42)", "ParameterizedDefaultedInput")]
    [InlineData("new CustomConstructorInput()", "CustomConstructorInput")]
    public void CustomConstructorsRemainUnsupported(string expression, string typeName)
    {
        var result = Generate(expression);

        var diagnostic = Assert.Single(result.Diagnostics.Where(item => item.Id == "LAEXP003"));
        Assert.Contains(typeName, diagnostic.GetMessage());
    }

    private static GeneratorDriverRunResult Generate(string expression) =>
        WorkflowExpressionInterceptorGeneratorTests.RunGenerator(
            $$"""
            using System;
            using System.ComponentModel;
            using System.Runtime.Serialization;
            using Microsoft.Azure.Workflows.Sdk;
            using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai;
            using Newtonsoft.Json;
            using Newtonsoft.Json.Linq;

            public static class Workflow
            {
                public static void Build() => WorkflowActions.BuiltIn.Compose(() => {{expression}});
            }

            {{ModelDeclarations}}
            """);

    private static JToken EvaluateGeneratedExpression(string expression)
    {
        var result = Generate(expression);
        Assert.DoesNotContain(result.Diagnostics, diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        var generated = Assert.Single(Assert.Single(result.Results).GeneratedSources).SourceText;
        var factory = CSharpSyntaxTree.ParseText(generated).GetRoot()
            .DescendantNodes().OfType<InvocationExpressionSyntax>()
            .Single(invocation => invocation.Expression is MemberAccessExpressionSyntax
            {
                Name.Identifier.ValueText: "FromCSharp",
            });
        var source = Assert.IsType<LiteralExpressionSyntax>(factory.ArgumentList.Arguments[0].Expression).Token.ValueText;
        Assert.DoesNotContain("DefaultedInput", source);
        Assert.DoesNotContain("GetChatCompletionsInputMessagesTypeItem", source);

        var syntaxTree = CSharpSyntaxTree.ParseText(
            $$"""
            public static class Evaluation
            {
                public static object Run() => {{source}};
            }
            """);
        var references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator)
            .Select(path => MetadataReference.CreateFromFile(path));
        var compilation = CSharpCompilation.Create(
            $"GeneratedDefaults_{Guid.NewGuid():N}",
            [syntaxTree],
            references,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        using var assemblyStream = new MemoryStream();
        var emitResult = compilation.Emit(assemblyStream);
        Assert.True(emitResult.Success, string.Join(Environment.NewLine, emitResult.Diagnostics));
        var assembly = Assembly.Load(assemblyStream.ToArray());
        return Assert.IsAssignableFrom<JToken>(assembly.GetType("Evaluation")!.GetMethod("Run")!.Invoke(null, null));
    }
}
