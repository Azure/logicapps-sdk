namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Reflection;
using System.Runtime.ExceptionServices;
using Microsoft.Azure.Workflows.Sdk.Build;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json.Linq;

internal static class ConsumerCompilation
{
    internal const string Fixtures = """
        public static class RuntimeValues
        {
            public const string ConstantText = "constant";
            public static readonly string ReadonlyText = "readonly";
            public static string Text = "hello";
            public static int Calls;
            public static string CurrentText { get { Calls++; return Text; } }
            public static string NextText() { Calls++; return "hello"; }
            public static WireChoice ChoiceResult = WireChoice.First;
            public static WireChoice NextChoice() { Calls++; return ChoiceResult; }
            public static string Accept(WireChoice value) => value.ToString();
            public static System.Collections.Generic.Dictionary<string, string> CreateHeaders() { Calls++; return new() { ["X"] = "value" }; }
        }
        public class LocalLeaf { public string Text { get; set; } }
        public class LocalModel { public LocalLeaf Child { get; set; } }
        public class NamedBody { public string Body { get; set; } }
        public class TriggerNamedModel { public NamedBody TriggerOutput { get; set; } }
        public class OrderSummary { public decimal Total { get; set; } }
        public class ItemsList { [Newtonsoft.Json.JsonProperty("value")] public ListItem[] Value { get; set; } }
        public class ListItem { public System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Linq.JToken> DynamicProperties { get; set; } }
        public class DisplayModel { public int Id { get; set; } public override string ToString() => $"Display:{Id}"; }
        public enum WireChoice
        {
            [System.Runtime.Serialization.EnumMember(Value = "first /+")] First,
            [System.Runtime.Serialization.EnumMember(Value = "second")] Second,
            Unannotated
        }
        public enum AliasChoice
        {
            [System.Runtime.Serialization.EnumMember(Value = "a")] A = 0,
            [System.Runtime.Serialization.EnumMember(Value = "b")] B = 0
        }
        public enum EquivalentAlias
        {
            [System.Runtime.Serialization.EnumMember(Value = "a")] A = 0,
            [System.Runtime.Serialization.EnumMember(Value = "a")] B = 0
        }
        [Flags] public enum Access { Read = 1, Write = 2 }
        public readonly struct Money
        {
            public static int ConstructorCalls;
            public static int OperatorCalls;
            public decimal Value { get; }
            public Money(decimal value) { ConstructorCalls++; Value = value; }
            public static Money operator +(Money a, Money b) { OperatorCalls++; return new Money(a.Value + b.Value); }
        }
        public class GetterModel
        {
            public int Calls;
            public string Text { get { Calls++; throw new InvalidOperationException("Getter executed"); } }
        }
        """;

    internal const string Handles = """
        var source = WorkflowActions.BuiltIn.Compose<string>(input: () => "seed").WithName("Source");
        var other = WorkflowActions.BuiltIn.Compose<string>(input: () => "seed").WithName("Other");
        var count = WorkflowActions.BuiltIn.Compose<int>(input: () => 0).WithName("Count");
        var quantity = WorkflowActions.BuiltIn.Compose<int>(input: () => 0).WithName("Quantity");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(input: () => false).WithName("Flag");
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("Trigger");
        """;

    internal const string CoreHandles = """
        var otherFlag = WorkflowActions.BuiltIn.Compose<bool>(input: () => false).WithName("OtherFlag");
        var amount = WorkflowActions.BuiltIn.Compose<decimal>(input: () => 0m).WithName("Amount");
        var nullableCount = WorkflowActions.BuiltIn.Compose<int?>(input: () => null).WithName("NullableCount");
        var values = WorkflowActions.BuiltIn.Compose<List<int>>(input: () => new List<int>()).WithName("Values");
        var raw = WorkflowActions.BuiltIn.Compose<object>(input: () => (object)null).WithName("Raw");
        var tokenSource = WorkflowActions.BuiltIn.Compose<JToken>(input: () => (JToken)null).WithName("TokenSource");
        var tokenOther = WorkflowActions.BuiltIn.Compose<JToken>(input: () => (JToken)null).WithName("TokenOther");
        var choiceAction = WorkflowActions.BuiltIn.Compose<WireChoice>(input: () => WireChoice.First).WithName("Choice");
        var money = WorkflowActions.BuiltIn.Compose<Money>(input: () => default(Money)).WithName("Money");
        var summary = WorkflowActions.BuiltIn.CustomCode<OrderSummary>(_ => Task.FromResult<OrderSummary>(null)).WithName("GetSummary");
        """;

    private static readonly MetadataReference[] References =
        ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!).Split(Path.PathSeparator)
        .Concat([typeof(WorkflowActions).Assembly.Location, typeof(JToken).Assembly.Location])
        .Distinct(StringComparer.OrdinalIgnoreCase)
        .Select(p => MetadataReference.CreateFromFile(p)).ToArray();

    internal static string Source(string body, string extra = "", string imports = "") => $$"""
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Threading.Tasks;
        using Microsoft.Azure.Workflows.Sdk;
        using Newtonsoft.Json.Linq;
        {{imports}}
        public static class Consumer
        {
            public static FlowTemplateAction Build()
            {
                {{body}}
            }
            {{extra}}
        }
        {{Fixtures}}
        """;

    internal static CSharpCompilation Compile(string source) => CSharpCompilation.Create(
        "SourceConsumer_" + Guid.NewGuid().ToString("N"),
        [CSharpSyntaxTree.ParseText(source, new CSharpParseOptions(LanguageVersion.CSharp13), "Consumer.cs")],
        References,
        new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

    internal static TransformationResult Transform(string source) =>
        ExpressionCompilationTransformer.Transform(Compile(source));

    internal static Assembly Load(CSharpCompilation compilation)
    {
        using var stream = new MemoryStream();
        var result = compilation.Emit(stream);
        Assert.True(result.Success, string.Join(Environment.NewLine, result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error)));
        return Assembly.Load(stream.ToArray());
    }

    internal static object? Invoke(Assembly assembly, string type, string method, params object?[] args)
    {
        try
        {
            return assembly.GetType(type)!.GetMethod(method)!.Invoke(null, args);
        }
        catch (TargetInvocationException exception) when (exception.InnerException != null)
        {
            ExceptionDispatchInfo.Capture(exception.InnerException).Throw();
            throw;
        }
    }

    internal static (FlowTemplateAction Definition, Assembly Assembly, TransformationResult Transformation)
        Build(string source)
    {
        var prepared = Prepare(source);
        return ((FlowTemplateAction)Invoke(prepared.Assembly, "Consumer", "Build")!, prepared.Assembly, prepared.Transformation);
    }

    internal static (Assembly Assembly, TransformationResult Transformation) Prepare(string source)
    {
        var original = Compile(source);
        Assert.Empty(original.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error));
        var transformed = ExpressionCompilationTransformer.Transform(original);
        Assert.Empty(transformed.Diagnostics);
        Assert.Contains("SourceExpression.", transformed.Sources["Consumer.cs"]);
        var assembly = Load(Compile(transformed.Sources["Consumer.cs"]));
        return (assembly, transformed);
    }

    internal static JToken? Input(string expression, string setup = "", string after = "", string resultType = "object")
    {
        var result = Build(Source($$"""
            {{Handles}}
            {{setup}}
            var action = WorkflowActions.BuiltIn.Compose<{{resultType}}>(input: () => {{expression}});
            {{after}}
            return action.GetActionDefinition("Catalog");
            """));
        return Token(result.Definition);
    }

    internal static JToken Token(FlowTemplateAction definition) => JToken.Parse(definition.Inputs.ToJson());

    internal static string Native(string expression, string setup = "", string after = "", string resultType = "object") =>
        Assert.IsType<JValue>(Input(expression, setup, after, resultType)).Value<string>()!;

    internal static void EqualSource(string expected, string actual)
    {
        Assert.StartsWith("@csharp{", actual);
        Assert.EndsWith("}", actual);
        // Namespace qualification and insignificant trivia are permitted by catalog section 14.1.
        static SyntaxNode Normalize(string text)
        {
            var expression = SyntaxFactory.ParseExpression(text[8..^1]);
            Assert.Empty(expression.GetDiagnostics());
            return new SourceTypeNormalizer().Visit(expression)!;
        }
        Assert.True(SyntaxFactory.AreEquivalent(Normalize(expected), Normalize(actual)),
            $"Native source differs from the approved contract.{Environment.NewLine}Expected: {expected}{Environment.NewLine}Actual: {actual}");
    }

    private sealed class SourceTypeNormalizer : CSharpSyntaxRewriter
    {
        // Compare the resulting trees, never flattened text: operator nesting still carries precedence.
        public override SyntaxNode? VisitParenthesizedExpression(ParenthesizedExpressionSyntax node) =>
            Visit(node.Expression);

        public override SyntaxNode? VisitAliasQualifiedName(AliasQualifiedNameSyntax node) =>
            node.Alias.Identifier.ValueText == "global" ? Visit(node.Name) : base.VisitAliasQualifiedName(node);

        public override SyntaxNode? VisitQualifiedName(QualifiedNameSyntax node)
        {
            var visited = base.VisitQualifiedName(node)!;
            var keyword = visited.ToString() switch
            {
                "System.Boolean" => SyntaxKind.BoolKeyword,
                "System.Byte" => SyntaxKind.ByteKeyword,
                "System.SByte" => SyntaxKind.SByteKeyword,
                "System.Int16" => SyntaxKind.ShortKeyword,
                "System.UInt16" => SyntaxKind.UShortKeyword,
                "System.Int32" => SyntaxKind.IntKeyword,
                "System.UInt32" => SyntaxKind.UIntKeyword,
                "System.Int64" => SyntaxKind.LongKeyword,
                "System.UInt64" => SyntaxKind.ULongKeyword,
                "System.Single" => SyntaxKind.FloatKeyword,
                "System.Double" => SyntaxKind.DoubleKeyword,
                "System.Decimal" => SyntaxKind.DecimalKeyword,
                "System.Char" => SyntaxKind.CharKeyword,
                "System.String" => SyntaxKind.StringKeyword,
                "System.Object" => SyntaxKind.ObjectKeyword,
                _ => SyntaxKind.None,
            };
            return keyword == SyntaxKind.None ? visited : SyntaxFactory.PredefinedType(SyntaxFactory.Token(keyword));
        }
    }
}

/// <summary>
/// Local Roslyn execution evidence only, not a deployed Logic Apps backend.
/// Reads return real Newtonsoft JTokens, and accessor order is observable.
/// </summary>
internal static class LocalNativeHost
{
    internal static (object? Value, string[] Reads, int Calls) Evaluate(
        string envelope, Dictionary<string, JToken?> values, string additionalSource = "", Action<Assembly>? initialize = null)
    {
        Assert.StartsWith("@csharp{", envelope);
        var source = $$"""
            using System;
            using System.Linq;
            using System.Collections.Generic;
            using Newtonsoft.Json.Linq;
            public static class NativeHost
            {
                public static object[] Run(Dictionary<string, JToken> values)
                {
                    var reads = new List<string>();
                    JToken outputs(string name) { reads.Add(name); return values[name]; }
                    JToken body(string name) { reads.Add(name); return values[name]; }
                    JToken triggerBody() { reads.Add("Trigger"); return values["Trigger"]; }
                    JToken agentparameters(string name) { reads.Add("agent:" + name); return values[name]; }
                    string encodeURIComponent(string value) => Uri.EscapeDataString(value);
                    string base64(string value) => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value));
                    JToken json(string value) => JToken.Parse(value);
                    var result = (object)({{envelope[8..^1]}});
                    return new object[] { result, reads.ToArray(), RuntimeValues.Calls };
                }
            }
            {{ConsumerCompilation.Fixtures}}
            {{additionalSource}}
            """;
        var assembly = ConsumerCompilation.Load(ConsumerCompilation.Compile(source));
        initialize?.Invoke(assembly);
        var result = (object[])ConsumerCompilation.Invoke(assembly, "NativeHost", "Run", values)!;
        return (result[0], (string[])result[1], (int)result[2]);
    }
}
