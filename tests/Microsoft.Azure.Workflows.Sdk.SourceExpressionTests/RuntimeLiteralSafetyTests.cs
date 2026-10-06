#nullable disable
namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

[CollectionDefinition("Runtime serialization globals", DisableParallelization = true)]
public sealed class RuntimeSerializationCollection { }

[Collection("Runtime serialization globals")]
public class RuntimeLiteralSafetyTests
{
    private static Func<T> Literal<T>(T value) => SourceExpression.Literal(1, value);

    private static string Native(object value, string declaredType, string prefix = "", string suffix = "")
    {
        var descriptor = SourceExpression.Create<object>(1, "native", [prefix, suffix],
            [SourceBinding.Capture(value, declaredType)]);
        var text = ((JValue)WorkflowActions.BuiltIn.Compose(descriptor).GetActionDefinition("test").Inputs).Value<string>();
        Assert.StartsWith("#{", text);
        return ConsumerCompilation.NativeBody(text);
    }

    [Fact]
    public void Base64AndSharedSerializationIgnoreAmbientDefaultSettings()
    {
        var original = JsonConvert.DefaultSettings;
        var factoryCalls = 0;
        var converter = new AmbientConverter();
        var payload = new JObject { ["MixedCase"] = new JArray(1, true, "text") };
        var action = new ServicebusActions("connection").SendMessage(Literal("queue"), Literal<JToken>(payload));
        var baseline = action.GetActionDefinition("test").ToJson();
        try
        {
            JsonConvert.DefaultSettings = () =>
            {
                factoryCalls++;
                return new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() },
                    Converters = { converter },
                };
            };
            var definition = action.GetActionDefinition("test");
            Assert.Equal("#{base64(\"{\\\"MixedCase\\\":[1,true,\\\"text\\\"]}\")}",
                definition.Inputs.ToJToken()["body"]["ContentData"].Value<string>());
            Assert.Equal(baseline, definition.ToJson());
            Assert.Equal(0, factoryCalls);
            Assert.Equal(0, converter.Calls);
        }
        finally
        {
            JsonConvert.DefaultSettings = original;
        }
    }

    [Fact]
    public void CapturedSerializationHooksAreNeverInvoked()
    {
        HookedValue.Calls = 0;
        var value = new HookedValue();
        Assert.Throws<NotSupportedException>(() => Literal(value));
        Assert.Throws<NotSupportedException>(() => SourceBinding.Capture(value, SourceExpression.TypeName(typeof(HookedValue))));
        Assert.Throws<NotSupportedException>(() => Literal(new Dictionary<string, object> { ["value"] = value }));
        Assert.Throws<NotSupportedException>(() => Literal<JToken>(new HookedToken("unsafe")));
        Assert.Equal(0, HookedValue.Calls);
    }

    [Fact]
    public void CapturedJsonUriDoesNotInvokeSubclassToString()
    {
        HookedValue.Calls = 0;
        var token = new JValue(new HookedUri("https://example.test/path"));
        var descriptor = Literal<JToken>(token);
        var json = WorkflowActions.BuiltIn.Compose(descriptor).GetActionDefinition("test").Inputs.ToJson();
        Assert.Equal("\"https://example.test/path\"", json);
        Assert.Equal(0, HookedValue.Calls);
    }

    [Theory]
    [InlineData("\u0085")]
    [InlineData("\u2028")]
    [InlineData("\u2029")]
    [InlineData("before\u0085\u2028\u2029after")]
    [InlineData("\"\\\n\r\t\0é😀")]
    public void NativeStringLiteralsRoundTripThroughCSharp(string value)
    {
        var expression = Native(value, "string");
        Assert.DoesNotContain("\u0085", expression);
        Assert.DoesNotContain("\u2028", expression);
        Assert.DoesNotContain("\u2029", expression);
        Assert.Equal(value, Evaluate(expression));
    }

    [Theory]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void NonFiniteDoubleCapturesAreExplicitlyRejected(double value)
    {
        Assert.Throws<NotSupportedException>(() => Literal(value));
        Assert.Throws<NotSupportedException>(() => SourceBinding.Capture(value, "double"));
    }

    [Theory]
    [InlineData(float.NaN)]
    [InlineData(float.PositiveInfinity)]
    [InlineData(float.NegativeInfinity)]
    public void NonFiniteSingleCapturesAreExplicitlyRejected(float value)
    {
        Assert.Throws<NotSupportedException>(() => Literal(value));
        Assert.Throws<NotSupportedException>(() => SourceBinding.Capture(value, "float"));
    }

    [Fact]
    public void NonFiniteJsonValuesCannotBypassCaptureValidation()
    {
        Assert.Throws<NotSupportedException>(() => Literal<JToken>(new JValue(double.NaN)));
        Assert.Throws<NotSupportedException>(() => Literal<JToken>(new JObject { ["nested"] = float.PositiveInfinity }));
    }

    [Fact]
    public void FiniteFloatCapturesPreserveBitsAndInvariantCulture()
    {
        var old = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
            foreach (var value in new[] { double.Epsilon, double.MaxValue, double.MinValue, 1.2345678901234567, -0.0d })
                Assert.Equal(BitConverter.DoubleToInt64Bits(value), BitConverter.DoubleToInt64Bits((double)Evaluate(Native(value, "double"))));
            foreach (var value in new[] { float.Epsilon, float.MaxValue, float.MinValue, 1.2345678f, -0.0f })
                Assert.Equal(BitConverter.SingleToInt32Bits(value), BitConverter.SingleToInt32Bits((float)Evaluate(Native(value, "float"))));
        }
        finally
        {
            CultureInfo.CurrentCulture = old;
        }
    }

    [Theory]
    [InlineData("global::System.IComparable", "comparable")]
    [InlineData("global::System.IConvertible", "convertible")]
    [InlineData("object", "object")]
    [InlineData("string", "string")]
    public void CapturedDeclaredStringTypeControlsOverloadResolution(string declaredType, string expected)
    {
        var members = """
            private static string Pick(string value) => "string";
            private static string Pick(object value) => "object";
            private static string Pick(global::System.IComparable value) => "comparable";
            private static string Pick(global::System.IConvertible value) => "convertible";
            """;
        Assert.Equal(expected, Evaluate(Native("text", declaredType, "Pick(", ")"), members));
    }

    [Fact]
    public void CapturedDeclaredCollectionAndNullableTypesControlOverloads()
    {
        var listMembers = """
            private static string Pick(global::System.Collections.Generic.List<int> value) => "list";
            private static string Pick(global::System.Collections.Generic.IEnumerable<int> value) => "enumerable";
            """;
        Assert.Equal("enumerable", Evaluate(Native(new List<int> { 1 },
            "global::System.Collections.Generic.IEnumerable<int>", "Pick(", ")"), listMembers));
        var nullableMembers = """
            private static string Pick(int value) => "integer";
            private static string Pick(int? value) => "nullable";
            """;
        Assert.Equal("nullable", Evaluate(Native(7, "int?", "Pick(", ")"), nullableMembers));
    }

    private static object Evaluate(string expression, string members = "")
    {
        var syntax = CSharpSyntaxTree.ParseText("public static class Evaluator { public static object Run() => " + expression + "; " + members + " }");
        var references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")).Split(Path.PathSeparator)
            .Distinct(StringComparer.OrdinalIgnoreCase).Select(path => MetadataReference.CreateFromFile(path));
        var compilation = CSharpCompilation.Create("RuntimeLiteral_" + Guid.NewGuid().ToString("N"), [syntax], references,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        using var stream = new MemoryStream();
        var emitted = compilation.Emit(stream);
        Assert.True(emitted.Success, string.Join(Environment.NewLine, emitted.Diagnostics));
        return Assembly.Load(stream.ToArray()).GetType("Evaluator").GetMethod("Run").Invoke(null, null);
    }

    private sealed class AmbientConverter : JsonConverter
    {
        public int Calls;
        public override bool CanConvert(Type objectType) => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Calls++;
            writer.WriteValue("ambient");
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) =>
            throw new InvalidOperationException("Ambient deserialization must not run.");
    }

    [JsonConverter(typeof(HookedConverter))]
    private sealed class HookedValue
    {
        public static int Calls;
        public string Value { get { Calls++; return "unsafe"; } }
        public override string ToString() { Calls++; return "unsafe"; }
        [OnSerializing] private void Serializing(StreamingContext context) => Calls++;
    }

    private sealed class HookedConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            HookedValue.Calls++;
            writer.WriteValue("unsafe");
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) =>
            throw new InvalidOperationException("Custom deserialization must not run.");
    }

    private sealed class HookedToken(string value) : JValue(value)
    {
        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
        {
            HookedValue.Calls++;
            base.WriteTo(writer, converters);
        }
    }

    private sealed class HookedUri(string value) : Uri(value)
    {
        public override string ToString()
        {
            HookedValue.Calls++;
            return "unsafe";
        }
    }
}
