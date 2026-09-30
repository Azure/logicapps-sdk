#nullable disable
namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Net;
using System.Runtime.Serialization;
using Microsoft.Azure.Workflows.Sdk.Connectors.Acceptmission;
using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob;
using Newtonsoft.Json.Linq;

public class RuntimeDescriptorTests
{
    private static Func<T> Literal<T>(T value) => SourceExpression.Literal(1, value);
    private static Func<T> Native<T>(string[] segments, params SourceBinding[] bindings) =>
        SourceExpression.Create<T>(1, "native", segments, bindings);
    private static Func<T> Template<T>(string[] segments, params SourceBinding[] bindings) =>
        SourceExpression.Create<T>(1, "template", segments, bindings);
    private static JToken Inputs(IWorkflowAction action) =>
        ConsumerCompilation.Token(action.GetActionDefinition("test"));
    private static IOutputWorkflowAction<string> Source(string name = "Source") =>
        WorkflowActions.BuiltIn.Compose<string>(Literal("source")).WithName(name);

    [Theory]
    [InlineData("hello")]
    [InlineData("")]
    [InlineData("say \"hi\" at C:\\temp {triggerBody()}")]
    [InlineData(null)]
    public void StringLiteralsPreserveValues(string value)
    {
        var token = Inputs(WorkflowActions.BuiltIn.Compose<string>(Literal(value)));
        Assert.Equal(value == null ? JTokenType.Null : JTokenType.String, token.Type);
        Assert.Equal(value, token.Value<string>());
    }

    [Fact]
    public void LiteralTokensRetainTypes()
    {
        Assert.Equal(JTokenType.Integer, Inputs(WorkflowActions.BuiltIn.Compose(Literal(5))).Type);
        Assert.Equal(JTokenType.Boolean, Inputs(WorkflowActions.BuiltIn.Compose(Literal(true))).Type);
        Assert.Equal(JTokenType.Float, Inputs(WorkflowActions.BuiltIn.Compose(Literal(2.5m))).Type);
        Assert.Equal(JTokenType.Integer, Inputs(WorkflowActions.BuiltIn.Compose(Literal<object>(5))).Type);
    }

    [Fact]
    public void RawDelegatesFailWithoutExecuting()
    {
        var calls = 0;
        Func<string> raw = () => { calls++; return "unsafe"; };
        Assert.Throws<NotSupportedException>(() => WorkflowActions.BuiltIn.Compose(raw));
        Assert.Throws<NotSupportedException>(() => new AcceptmissionActions("connection").GetcategoriesId(raw));
        Assert.Throws<NotSupportedException>(() => new AzureBlobActions("connection").DeleteBlob(raw, Literal("blob")));
        Assert.Equal(0, calls);
    }

    [Fact]
    public void MulticastDelegateIsNotAcceptedAsMetadata()
    {
        var calls = 0;
        Func<string> raw = () => { calls++; return "unsafe"; };
        raw += Literal("safe");
        Assert.Throws<NotSupportedException>(() => WorkflowActions.BuiltIn.Compose(raw));
        Assert.Equal(0, calls);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    public void UnsupportedVersionsAreExplicit(int version) =>
        Assert.Throws<NotSupportedException>(() => SourceExpression.Literal(version, "value"));

    [Theory]
    [InlineData("block")]
    [InlineData("async")]
    [InlineData("unknown")]
    public void UnsupportedKindsAreExplicit(string kind) =>
        Assert.Throws<NotSupportedException>(() => SourceExpression.Create<int>(1, kind, ["1"], []));

    [Fact]
    public void MalformedSegmentCountFails() =>
        Assert.Throws<ArgumentException>(() => SourceExpression.Create<string>(1, "native", [], []));

    [Fact]
    public void DescriptorCannotBeExecuted() =>
        Assert.Throws<InvalidOperationException>(() => Literal("text")());

    [Fact]
    public void NativePreservesSourceAndUsesFinalActionIdentity()
    {
        var source = Source();
        var action = WorkflowActions.BuiltIn.Compose(Native<string>(
            ["", ".ToUpperInvariant() /* retained */ + ", ""],
            SourceBinding.Output(source, "string"), SourceBinding.Capture("!", "string")));
        source.Name = "Final";
        Assert.Equal("#{outputs(\"Final\").ToObject<string>().ToUpperInvariant() /* retained */ + \"!\"}", Inputs(action).Value<string>());
    }

    [Fact]
    public void LegacyDirectReferenceUsesCSharpIdentityEscapingAndOneEnvelope()
    {
        var source = Source();
        var action = WorkflowActions.BuiltIn.Compose(Template<string>(["@", ""], SourceBinding.Output(source, "string")));
        source.Name = "O'Brien";
        Assert.Equal("#{outputs(\"O'Brien\").ToObject<string>()}", Inputs(action).Value<string>());
    }

    [Theory]
    [InlineData("prefix @{", "}")]
    [InlineData("@", "['name']")]
    [InlineData("@", "?['name']")]
    public void LegacyComplexTemplateWithoutNativeSourceCannotEmitExecutableTemplates(string prefix, string suffix)
    {
        var expression = Template<string>([prefix, suffix], SourceBinding.Output(Source(), "string"));
        Assert.Throws<NotSupportedException>(() => Inputs(WorkflowActions.BuiltIn.Compose(expression)));
        Assert.Throws<NotSupportedException>(() => Inputs(new AcceptmissionActions("connection").GetcategoriesId(expression)));
        Assert.Throws<NotSupportedException>(() => Inputs(new ServicebusActions("connection").SendMessage(
            Literal("queue"), SourceExpression.Token(1, expression))));
    }

    [Fact]
    public void LegacyComplexTemplateWithoutNativeSourceCannotBeWrappedByJson()
    {
        var expression = Template<string>(["{\"name\":\"@{", "}\"}"], SourceBinding.Output(Source(), "string"));
        Assert.Throws<NotSupportedException>(() => Inputs(
            WorkflowActions.BuiltIn.Compose(SourceExpression.Json<JToken>(1, expression))));
    }

    [Fact]
    public void ReturnedDefinitionIsASnapshot()
    {
        var source = Source();
        var action = WorkflowActions.BuiltIn.Compose(Template<string>(["@", ""], SourceBinding.Output(source, "string")));
        var first = action.GetActionDefinition("test");
        source.Name = "New";
        Assert.Equal("#{outputs(\"Source\").ToObject<string>()}", JToken.FromObject(first.Inputs).Value<string>());
        Assert.Equal("#{outputs(\"New\").ToObject<string>()}", Inputs(action).Value<string>());
    }

    [Fact]
    public void CapturedJsonAndListsAreSnapshots()
    {
        var json = new JObject { ["n"] = 1 };
        var list = new List<int> { 1, 2 };
        var jsonAction = WorkflowActions.BuiltIn.Compose(Literal(json));
        var listAction = WorkflowActions.BuiltIn.Compose(Native<int>(["", "[0]"], SourceBinding.Capture(list, "global::System.Collections.Generic.List<int>")));
        json["n"] = 9;
        list[0] = 9;
        Assert.Equal(1, Inputs(jsonAction)["n"].Value<int>());
        Assert.Contains("{ 1, 2 }[0]", Inputs(listAction).Value<string>());
    }

    [Fact]
    public void CallerCannotMutateDescriptorArrays()
    {
        var segments = new[] { "1 + ", "" };
        var bindings = new[] { SourceBinding.Capture(2, "int") };
        var descriptor = SourceExpression.Create<int>(1, "native", segments, bindings);
        segments[0] = "unsafe";
        bindings[0] = SourceBinding.Capture(99, "int");
        Assert.Equal("#{1 + 2}", Inputs(WorkflowActions.BuiltIn.Compose(descriptor)).Value<string>());
    }

    [Fact]
    public void CaptureDescriptorPreservesLiteralTokenRatherThanTemplateQuotes()
    {
        Func<T> Captured<T>(T value, string type) =>
            SourceExpression.Create<T>(1, "capture", ["", ""], [SourceBinding.Capture(value, type)]);
        Assert.Equal("hello", Inputs(WorkflowActions.BuiltIn.Compose(Captured("hello", "string"))).Value<string>());
        Assert.Equal(JTokenType.Integer, Inputs(WorkflowActions.BuiltIn.Compose(Captured(7, "int"))).Type);
        Assert.Equal(JTokenType.Boolean, Inputs(WorkflowActions.BuiltIn.Compose(Captured(true, "bool"))).Type);
        Assert.Equal(JTokenType.Null, Inputs(WorkflowActions.BuiltIn.Compose(Captured<string>(null, "string"))).Type);
    }

    [Fact]
    public void CaptureDescriptorRejectsArbitraryBindingsAndSegments()
    {
        Assert.Throws<ArgumentException>(() => SourceExpression.Create<string>(1, "capture", ["prefix", ""], [SourceBinding.Capture("text", "string")]));
        Assert.Throws<ArgumentException>(() => SourceExpression.Create<string>(1, "capture", ["", ""], [SourceBinding.Output(Source(), "string")]));
        Assert.Throws<ArgumentException>(() => SourceExpression.Create<string>(1, "capture", [""], []));
    }

    [Fact]
    public void CapturePathSnapshotsAutoPropertyAndFieldChains()
    {
        var model = new CaptureModel { Child = new CaptureLeaf { Text = "before", Count = 3 } };
        var text = SourceExpression.Create<string>(1, "capture", ["", ""],
            [SourceBinding.CapturePath(model, ["Child", "Text"], "string")]);
        var number = SourceExpression.Create<int>(1, "capture", ["", ""],
            [SourceBinding.CapturePath(model, ["Child", "Count"], "int")]);
        model.Child.Text = "after";
        model.Child.Count = 9;
        Assert.Equal("before", Inputs(WorkflowActions.BuiltIn.Compose(text)).Value<string>());
        Assert.Equal(3, Inputs(WorkflowActions.BuiltIn.Compose(number)).Value<int>());
    }

    [Fact]
    public void CapturePathNullLeafIsLiteralNullButNullIntermediateIsExplicit()
    {
        var model = new CaptureModel { Child = new CaptureLeaf { Text = null } };
        var expression = SourceExpression.Create<string>(1, "capture", ["", ""],
            [SourceBinding.CapturePath(model, ["Child", "Text"], "string")]);
        Assert.Equal(JTokenType.Null, Inputs(WorkflowActions.BuiltIn.Compose(expression)).Type);
        model.Child = null;
        Assert.Throws<NotSupportedException>(() => SourceBinding.CapturePath(model, ["Child", "Text"], "string"));
    }

    [Fact]
    public void CapturePathNeverInvokesCustomGetters()
    {
        var model = new UnsafeCapture();
        var exception = Assert.Throws<NotSupportedException>(() => SourceBinding.CapturePath(model, ["Text"], "string"));
        Assert.Contains("custom getter 'Text'", exception.Message);
        Assert.Equal(0, model.Calls);
    }

    [Fact]
    public void CapturePathRejectsClosureTargetsAndStaticStorage()
    {
        var captured = "value";
        Func<string> closure = () => captured;
        Assert.Throws<NotSupportedException>(() => SourceBinding.CapturePath(closure.Target, ["captured"], "string"));
        Assert.Throws<NotSupportedException>(() => SourceBinding.CapturePath(new CaptureLeaf(), ["StaticText"], "string"));
    }

    [Fact]
    public void CapturePathWorksInsideNativeExpressionsAndStaticHeaders()
    {
        var model = new CaptureModel { Child = new CaptureLeaf { Text = "hello" } };
        var native = Native<string>(["", ".ToUpperInvariant()"], SourceBinding.CapturePath(model, ["Child", "Text"], "string"));
        Assert.Equal("#{\"hello\".ToUpperInvariant()}", Inputs(WorkflowActions.BuiltIn.Compose(native)).Value<string>());
        var headers = new Dictionary<string, string> { ["X-Name"] = "before" };
        var headerDescriptor = SourceExpression.Create<Dictionary<string, string>>(1, "capture", ["", ""],
            [SourceBinding.Capture(headers, "global::System.Collections.Generic.Dictionary<string, string>")]);
        headers["X-Name"] = "after";
        Assert.Equal("before", Inputs(WorkflowActions.BuiltIn.Response(headers: headerDescriptor))["headers"]["X-Name"].Value<string>());
    }

    [Fact]
    public void CustomObjectsDoNotExecuteGettersOrToString()
    {
        var value = new UnsafeCapture();
        Assert.Throws<NotSupportedException>(() => SourceBinding.Capture(value, typeof(UnsafeCapture).FullName));
        Assert.Equal(0, value.Calls);
    }

    [Fact]
    public void CyclicCollectionsAreExplicitlyRejected()
    {
        var values = new List<object>();
        values.Add(values);
        Assert.Throws<NotSupportedException>(() => Literal(values));
    }

    [Fact]
    public void NullNativeCapturePreservesReceiverType()
    {
        var action = WorkflowActions.BuiltIn.Compose(Native<string>(["", "?.ToUpperInvariant()"], SourceBinding.Capture(null, "string")));
        Assert.Equal("#{((string)null)?.ToUpperInvariant()}", Inputs(action).Value<string>());
    }

    [Fact]
    public void TriggerBindingNeverReadsOutput()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
        var action = WorkflowActions.BuiltIn.Compose(Native<int>(["", "[\"n\"].Value<int>()"],
            SourceBinding.Trigger(trigger, "triggerBody", "Newtonsoft.Json.Linq.JToken")));
        Assert.Equal("#{triggerBody()[\"n\"].Value<int>()}", Inputs(action).Value<string>());
        Assert.Throws<ArgumentException>(() => SourceBinding.Trigger(trigger, "arbitrary", "int"));
    }

    [Fact]
    public void GeneratedManagedPathAndPayloadAreDeferred()
    {
        var source = Source();
        var connector = new AcceptmissionActions("connection");
        var pathAction = connector.GetcategoriesId(Template<string>(["@", ""], SourceBinding.Output(source, "string")));
        var bodyAction = connector.Postcategories(
            bodytitle: SourceExpression.Create<string>(1, "template", ["Title @{", "}"],
                [SourceBinding.Output(source, "string")], nativeSegments: ["$\"Title {", "}\""]), bodyposition: Literal(3));
        source.Name = "Final";
        Assert.Equal("#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/general/v1/categories/{0}\", encodeURIComponent(outputs(\"Final\").ToObject<string>()))}", Inputs(pathAction)["path"].Value<string>());
        Assert.Equal("#{$\"Title {outputs(\"Final\").ToObject<string>()}\"}", Inputs(bodyAction)["body"]["title"].Value<string>());
        Assert.Equal(JTokenType.Integer, Inputs(bodyAction)["body"]["position"].Type);
    }

    [Fact]
    public void GeneratedNativePathUsesSingleEnvelope()
    {
        var source = Source();
        var action = new AcceptmissionActions("connection").GetcategoriesId(
            Native<string>(["", ".ToUpperInvariant()"], SourceBinding.Output(source, "string")));
        source.Name = "Final";
        var path = Inputs(action)["path"].Value<string>();
        Assert.StartsWith("#{string.Format(", path);
        Assert.Contains("encodeURIComponent(outputs(\"Final\").ToObject<string>().ToUpperInvariant())", path);
        Assert.Equal(1, path.Split("#{").Length - 1);
    }

    [Fact]
    public void GeneratedServiceProviderPayloadIsDeferred()
    {
        var source = Source();
        var action = new AzureBlobActions("connection").DeleteBlob(
            Template<string>(["@", ""], SourceBinding.Output(source, "string")), Literal("blob"));
        source.Name = "Final";
        Assert.Equal("#{outputs(\"Final\").ToObject<string>()}", Inputs(action)["parameters"]["containerName"].Value<string>());
        Assert.Equal("blob", Inputs(action)["parameters"]["blobName"].Value<string>());
    }

    [Theory]
    [InlineData("hello", "#{base64(\"hello\")}")]
    [InlineData("", "#{base64(\"\")}")]
    [InlineData("aGVsbG8=", "#{base64(\"aGVsbG8=\")}")]
    public void Base64MetadataEncodesWholeLiteralOnce(string text, string expected)
    {
        var action = new ServicebusActions("connection").SendMessage(Literal("queue"), Literal<JToken>(new JValue(text)));
        Assert.Equal(expected, Inputs(action)["body"]["ContentData"].Value<string>());
    }

    [Fact]
    public void Base64MetadataDistinguishesBytesNumbersObjectsAndNull()
    {
        var connector = new ServicebusActions("connection");
        string Content(JToken value) => Inputs(connector.SendMessage(Literal("queue"), Literal(value)))["body"]["ContentData"].Value<string>();
        Assert.Equal("AAH/", Content(new JValue(new byte[] { 0, 1, 255 })));
        Assert.Equal("#{base64(\"42\")}", Content(new JValue(42)));
        Assert.Equal("#{base64(\"true\")}", Content(new JValue(true)));
        Assert.Equal("#{base64(\"{\\\"n\\\":1}\")}", Content(new JObject { ["n"] = 1 }));
        Assert.Null(Content(JValue.CreateNull()));
    }

    [Fact]
    public void Base64LegacyInterpolationWithNativeSourceResolvesFinalName()
    {
        var source = Source();
        var content = SourceExpression.Token(1, SourceExpression.Create<string>(1, "template", ["Name: @{", "}"],
            [SourceBinding.Output(source, "string")], nativeSegments: ["$\"Name: {", "}\""]));
        var action = new ServicebusActions("connection").SendMessage(Literal("queue"), content);
        source.Name = "Final";
        Assert.Equal("#{base64($\"Name: {outputs(\"Final\").ToObject<string>()}\")}", Inputs(action)["body"]["ContentData"].Value<string>());
    }

    [Fact]
    public void MixedGeneratedPathPromotesTemplateReferenceToTypedNative()
    {
        var source = Source();
        var action = new ServicebusActions("connection").CloseSessionInQueue(
            Native<string>(["", ".ToUpperInvariant()"], SourceBinding.Output(source, "string")),
            Template<string>(["@", ""], SourceBinding.Output(source, "string")));
        source.Name = "Final";
        var path = Inputs(action)["path"].Value<string>();
        Assert.StartsWith("#{", path);
        Assert.Contains("encodeURIComponent(encodeURIComponent(outputs(\"Final\").ToObject<string>().ToUpperInvariant()))", path);
        Assert.Contains("encodeURIComponent(outputs(\"Final\").ToObject<string>())", path);
        Assert.DoesNotContain("@{", path);
    }

    [Fact]
    public void MixedGeneratedPathUsesCompilerNativeSegmentsForInterpolation()
    {
        var source = Source();
        var nativeSegments = new[] { "$\"prefix {", "}\"" };
        var interpolation = SourceExpression.Create<string>(1, "template", ["prefix @{", "}"],
            [SourceBinding.Output(source, "string")], nativeSegments: nativeSegments);
        nativeSegments[0] = "changed";
        var action = new ServicebusActions("connection").CloseSessionInQueue(
            Native<string>(["RuntimeValues.NextText()"]), interpolation);
        source.Name = "Final";
        var path = Inputs(action)["path"].Value<string>();
        Assert.Contains("encodeURIComponent($\"prefix {outputs(\"Final\").ToObject<string>()}\")", path);
        Assert.Equal("#{$\"prefix {outputs(\"Final\").ToObject<string>()}\"}", Inputs(WorkflowActions.BuiltIn.Compose(interpolation)).Value<string>());
        Assert.DoesNotContain("changed", path);
        Assert.DoesNotContain("@{", path);
    }

    [Fact]
    public void MixedGeneratedPathUsesCompilerNativeSegmentsForNavigation()
    {
        var source = WorkflowActions.BuiltIn.Compose(Literal<JToken>(new JObject())).WithName("Source");
        var navigation = SourceExpression.Create<string>(1, "template", ["@", "?['name']"],
            [SourceBinding.Output(source, "Newtonsoft.Json.Linq.JToken")],
            nativeSegments: ["", "[\"name\"].Value<string>()"]);
        var action = new ServicebusActions("connection").CloseSessionInQueue(
            Native<string>(["RuntimeValues.NextText()"]), navigation);
        source.Name = "Final";
        Assert.Contains("encodeURIComponent(outputs(\"Final\")[\"name\"].Value<string>())", Inputs(action)["path"].Value<string>());
    }

    [Fact]
    public void NativeSegmentsValidateShapeAndWorkWithTypeWitness()
    {
        Assert.Throws<ArgumentException>(() => SourceExpression.Create<string>(1, "template", ["literal"], [],
            nativeSegments: ["wrong", "count"]));
        Assert.Throws<ArgumentException>(() => SourceExpression.Create<string>(1, "native", ["literal"], [],
            nativeSegments: ["not a template"]));
        var calls = 0;
        var descriptor = SourceExpression.Create(1, "template", ["text"], [],
            typeWitness: () => { calls++; return "never"; }, nativeSegments: ["\"text\""]);
        Assert.Equal("#{\"text\"}", Inputs(WorkflowActions.BuiltIn.Compose(descriptor)).Value<string>());
        Assert.Equal(0, calls);
    }

    [Fact]
    public void TemplateCompatibilityNormalizesOnceWithoutFreezingBindings()
    {
        var source = Source();
        var template = new[] { "@", "" };
        var bindings = new[] { SourceBinding.Output(source, "string") };
        var expression = SourceExpression.Create<string>(1, "template", template, bindings);
        template[0] = "not source";
        bindings[0] = SourceBinding.Capture("not a reference", "string");
        source.Name = "Final";
        Assert.Equal("#{outputs(\"Final\").ToObject<string>()}", Inputs(WorkflowActions.BuiltIn.Compose(expression)).Value<string>());

        var unsupportedSegments = new[] { "@", "['name']" };
        var unsupported = SourceExpression.Create<string>(1, "template", unsupportedSegments,
            [SourceBinding.Output(source, "string")]);
        unsupportedSegments[1] = "";
        var action = WorkflowActions.BuiltIn.Compose(unsupported);
        Assert.Throws<NotSupportedException>(() => Inputs(action));
    }

    [Fact]
    public void ByteSnapshotIsNotAliasedAcrossReturnedDefinitions()
    {
        var bytes = new byte[] { 1, 2 };
        var action = WorkflowActions.BuiltIn.Compose(Literal(bytes));
        bytes[0] = 9;
        var first = (JValue)action.GetActionDefinition("test").Inputs;
        first.Value<byte[]>()[0] = 8;
        Assert.Equal(new byte[] { 1, 2 }, ((JValue)action.GetActionDefinition("test").Inputs).Value<byte[]>());
    }

    [Fact]
    public void RequiredArgumentsRejectNullButOptionalFieldsAreOmitted()
    {
        var connector = new AcceptmissionActions("connection");
        var error = Assert.Throws<ArgumentException>(() => connector.GetcategoriesId(Literal<string>(null)));
        Assert.Equal("id", error.ParamName);
        Assert.Null(Inputs(connector.Postcategories(bodyposition: Literal(3)))["body"]["title"]);
    }

    [Fact]
    public void HttpScalarsAndHeadersAreDeferred()
    {
        var source = Source();
        var headers = SourceExpression.Object<Dictionary<string, string>>(1, ["X-Name", "X-Native"], [
            Template<string>(["@", ""], SourceBinding.Output(source, "string")),
            Native<string>(["", ".ToUpperInvariant()"], SourceBinding.Output(source, "string"))]);
        var action = WorkflowActions.BuiltIn.HttpAction(Literal(new Uri("https://example.test")), Literal(HttpMethod.Get), headers: headers);
        source.Name = "Final";
        var input = Inputs(action);
        Assert.Equal("GET", input["method"].Value<string>());
        Assert.Equal("#{outputs(\"Final\").ToObject<string>()}", input["headers"]["X-Name"].Value<string>());
        Assert.Equal("#{outputs(\"Final\").ToObject<string>().ToUpperInvariant()}", input["headers"]["X-Native"].Value<string>());
    }

    [Fact]
    public void ExecutableHeadersAreRejectedWithoutEvaluation()
    {
        var action = WorkflowActions.BuiltIn.Response(headers: Native<Dictionary<string, string>>(["RuntimeValues.CreateHeaders()"]));
        Assert.Throws<NotSupportedException>(() => action.GetActionDefinition("test"));
    }

    [Fact]
    public void ResponseStatusHasNarrowNumericNormalization()
    {
        Assert.Equal(202, Inputs(WorkflowActions.BuiltIn.Response(statusCode: Literal(HttpStatusCode.Accepted)))["statusCode"].Value<int>());
        var action = WorkflowActions.BuiltIn.Response(statusCode: Native<HttpStatusCode>(["RuntimeValues.NextStatus()"]));
        Assert.Equal("#{(int)(RuntimeValues.NextStatus())}", Inputs(action)["statusCode"].Value<string>());
    }

    [Fact]
    public void StructuredPayloadPreservesMixedLeaves()
    {
        var source = Source();
        var descriptor = SourceExpression.Object<object>(1, ["enabled", "count", "body", "labels"], [
            Literal(true), Literal(3), Template<string>(["@", ""], SourceBinding.Output(source, "string")),
            SourceExpression.Array<string[]>(1, [Literal("a"), Literal("b")])]);
        var action = WorkflowActions.BuiltIn.Compose(descriptor);
        source.Name = "Final";
        var input = Inputs(action);
        Assert.Equal(JTokenType.Boolean, input["enabled"].Type);
        Assert.Equal(JTokenType.Integer, input["count"].Type);
        Assert.Equal("#{outputs(\"Final\").ToObject<string>()}", input["body"].Value<string>());
        Assert.Equal(new[] { "a", "b" }, input["labels"].Values<string>());
    }

    [Fact]
    public void NativeAnonymousResultIsInferredWithoutExecutingTypeWitness()
    {
        var calls = 0;
        var descriptor = SourceExpression.Create(1, "native", ["new { Next = 3 }"], [],
            typeWitness: () => new { Next = ++calls });
        Assert.Equal("#{new { Next = 3 }}", Inputs(WorkflowActions.BuiltIn.Compose(descriptor)).Value<string>());
        Assert.Throws<InvalidOperationException>(() => descriptor());
        Assert.Equal(0, calls);
    }

    [Fact]
    public void StructuredAnonymousResultsAreInferredWithoutExecutingTypeWitnesses()
    {
        var calls = 0;
        var member = SourceExpression.Object(1, ["Value"], [Literal(7)],
            typeWitness: () => new { Value = ++calls });
        var array = SourceExpression.Array(1, [member],
            typeWitness: () => new[] { new { Value = ++calls } });
        Assert.Equal(7, Inputs(WorkflowActions.BuiltIn.Compose(member))["Value"].Value<int>());
        Assert.Equal(7, Inputs(WorkflowActions.BuiltIn.Compose(array))[0]["Value"].Value<int>());
        Assert.Equal(0, calls);
    }

    [Fact]
    public void TypeNamesSupportConcreteGenericsNestedTypesAndArrays()
    {
        Assert.Equal("global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32[]>",
            SourceExpression.TypeName(typeof(Dictionary<string, int[]>)));
        Assert.Equal("global::System.Int32[,]", SourceExpression.TypeName(typeof(int[,])));
        Assert.EndsWith(".RuntimeDescriptorTests.GenericOuter<global::System.Int32>.Inner<global::System.String>",
            SourceExpression.TypeName(typeof(GenericOuter<int>.Inner<string>)));
        Assert.EndsWith(".RuntimeDescriptorTests.GenericOuter<global::System.Int32>.Leaf",
            SourceExpression.TypeName(typeof(GenericOuter<int>.Leaf)));
        Assert.EndsWith(".RuntimeDescriptorTests.@class", SourceExpression.TypeName(typeof(@class)));
        Assert.Throws<NotSupportedException>(() => SourceExpression.TypeName(typeof(List<>)));
        Assert.Throws<ArgumentNullException>(() => SourceExpression.TypeName(null));
    }

    [Fact]
    public void ControlGraphFactoriesRunOnceAndExpressionsResolveLate()
    {
        var source = Source();
        var calls = 0;
        var action = WorkflowActions.BuiltIn.Control.Condition(
            Native<bool>(["", ".Length > 0"], SourceBinding.Output(source, "string")),
            () => { calls++; return WorkflowActions.BuiltIn.Compose(Literal("yes")); }, null);
        source.Name = "Final";
        var first = action.GetActionDefinition("test");
        _ = action.GetActionDefinition("test");
        Assert.Equal(1, calls);
        Assert.Equal("#{outputs(\"Final\").ToObject<string>().Length > 0}", first.Expression.Value<string>());
    }

    [Fact]
    public void VariableBindingsUseVariableIdentity()
    {
        var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(Literal("message"), Literal("hello"));
        var action = WorkflowActions.BuiltIn.Compose(Template<string>(["@", ""], SourceBinding.Variable(variable, "string")));
        variable.Name = "NotTheVariableName";
        Assert.Equal("#{variables(\"message\").ToObject<string>()}", Inputs(action).Value<string>());
    }

    [Fact]
    public void ForEachRetainsItemBindingsWithoutRebuildingFactory()
    {
        var calls = 0;
        var loop = WorkflowActions.BuiltIn.Control.ForEach(Literal<JToken>(new JArray(1, 2)), item =>
        {
            calls++;
            return WorkflowActions.BuiltIn.Compose(Native<int>(["", ".Value<int>()"],
                SourceBinding.Item(item, "Newtonsoft.Json.Linq.JToken")));
        });
        var definition = loop.GetActionDefinition("test");
        _ = loop.GetActionDefinition("test");
        Assert.Equal(1, calls);
        Assert.Equal("#{item().Value<int>()}", definition.Actions.Values.Single().Inputs.ToJToken().Value<string>());
    }

    [Fact]
    public void CaptureRecognizesForEachPlaceholder()
    {
        var loop = WorkflowActions.BuiltIn.Control.ForEach(Literal<JToken>(new JArray(1)), item =>
            WorkflowActions.BuiltIn.Compose(SourceExpression.Create<JToken>(1, "capture", ["", ""],
                [SourceBinding.Capture(item, "Newtonsoft.Json.Linq.JToken")])));
        Assert.Equal("#{item()}", loop.GetActionDefinition("test").Actions.Values.Single().Inputs.ToJToken().Value<string>());
    }

    [Fact]
    public void AgentToolDefinitionsResolveNamesAtDefinitionTime()
    {
        var source = Source();
        var calls = 0;
        var agent = WorkflowActions.BuiltIn.Agent(default, "deployment", null, "connection", null)
            .AddTool<object>(context =>
            {
                calls++;
                return (IWorkflowAction)WorkflowActions.BuiltIn.Compose(
                    Template<string>(["@", ""], SourceBinding.Output(source, "string")));
            }, "description", new object());
        source.Name = "Final";
        var definition = agent.GetActionDefinition("test");
        _ = agent.GetActionDefinition("test");
        Assert.Equal(1, calls);
        Assert.Equal("#{outputs(\"Final\").ToObject<string>()}", definition.Tools.Values.Single().Actions.Values.Single().Inputs.ToJToken().Value<string>());
    }

    [Fact]
    public void AgentParameterBindingDoesNotReadContextGetter()
    {
        var context = new UnsafeAgentContext();
        var expression = Native<string>(["", ".ToUpperInvariant()"], SourceBinding.AgentParameter(context, "name", "string"));
        Assert.Equal("#{agentparameters(\"name\").ToObject<string>().ToUpperInvariant()}",
            Inputs(WorkflowActions.BuiltIn.Compose(expression)).Value<string>());
    }

    [Fact]
    public void EnumWireMappingDoesNotTouchNativeCalls()
    {
        Assert.Equal("first /+", Inputs(WorkflowActions.BuiltIn.Compose(Literal(WireChoice.First))).Value<string>());
        var native = Inputs(WorkflowActions.BuiltIn.Compose(Native<WireChoice>(["RuntimeValues.NextChoice()"]))).Value<string>();
        Assert.Equal(1, native.Split("RuntimeValues.NextChoice()").Length - 1);
        Assert.Contains("switch", native);
        Assert.Equal("#{RuntimeValues.NextChoice() == WireChoice.First}",
            Inputs(WorkflowActions.BuiltIn.Compose(Native<bool>(["RuntimeValues.NextChoice() == WireChoice.First"]))).Value<string>());
    }

    [Fact]
    public void ConflictingEnumAliasesAreRejected() =>
        Assert.Throws<NotSupportedException>(() => Literal(ConflictingAlias.A));

    [Fact]
    public void GraphFactoriesAreNotAnnotated()
    {
        var methods = typeof(WorkflowControlActions).GetMethods();
        Assert.Empty(methods.Single(m => m.Name == "Scope").GetParameters()[0].GetCustomAttributes(typeof(WorkflowExpressionAttribute), false));
        Assert.Single(methods.Single(m => m.Name == "Condition").GetParameters()[0].GetCustomAttributes(typeof(WorkflowExpressionAttribute), false));
        Assert.Empty(methods.Single(m => m.Name == "Condition").GetParameters()[1].GetCustomAttributes(typeof(WorkflowExpressionAttribute), false));
    }

    private sealed class UnsafeCapture
    {
        public int Calls;
        public string Text { get { Calls++; return "unsafe"; } }
        public override string ToString() { Calls++; return "unsafe"; }
    }

    private sealed class UnsafeAgentContext : IAgentToolContext<object>
    {
        public object Parameters => throw new InvalidOperationException("Do not read context getters.");
    }

    private sealed class CaptureModel
    {
        public CaptureLeaf Child { get; set; }
    }

    private sealed class CaptureLeaf
    {
        public static readonly string StaticText = "static";
        public string Text { get; set; }
        public int Count;
    }

    private sealed class GenericOuter<T>
    {
        public sealed class Inner<U> { }
        public sealed class Leaf { }
    }

    private sealed class @class { }

    public enum WireChoice { [EnumMember(Value = "first /+")] First, Second }
    public enum ConflictingAlias { [EnumMember(Value = "a")] A = 0, [EnumMember(Value = "b")] B = 0 }
}
