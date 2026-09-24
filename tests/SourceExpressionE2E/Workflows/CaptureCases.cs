using Newtonsoft.Json.Linq;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static partial class CaptureCases
{
    [WorkflowCase("PrecomputedString", "helloworld", FailureIds = new[] { "F001", "F083", "F086" },
        Description = "F086 representative only: precomputed value snapshot, not an Expression.Compile/Invoke during generation.")]
    public static FlowDefinition PrecomputedString()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var local = new JValue("world"); var message = "hello" + local;
        var result = WorkflowActions.BuiltIn.Compose<object>(() => message);
        return Finish("PrecomputedString", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("CapturedString", "hello", FailureIds = new[] { "F002" })]
    public static FlowDefinition CapturedString()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        string message = "hello";
        var result = WorkflowActions.BuiltIn.Compose<object>(() => message);
        return Finish("CapturedString", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("CapturedInteger", "7", FailureIds = new[] { "F003" })]
    public static FlowDefinition CapturedInteger()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        int n = 7;
        var result = WorkflowActions.BuiltIn.Compose<object>(() => n);
        return Finish("CapturedInteger", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("PropertySnapshot", "hello", FailureIds = new[] { "F004", "F014" })]
    public static FlowDefinition PropertySnapshot()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var model = new LocalModel { Child = new LocalLeaf { Text = "hello" } };
        var result = WorkflowActions.BuiltIn.Compose<object>(() => model.Child.Text);
        model.Child.Text = "changed";
        return Finish("PropertySnapshot", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("F005NullProperty", "{\"text\":null}", FailureIds = new[] { "F005" },
        Description = "Representative valid object payload. Original scalar-null Compose is invalid on both hosts.")]
    public static FlowDefinition NullProperty()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var model = new LocalLeaf { Text = null };
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { text = model.Text });
        return Finish("F005NullProperty", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("UnrelatedBody", "local", FailureIds = new[] { "F006" })]
    public static FlowDefinition UnrelatedBody()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var unrelated = new NamedBody { Body = "local" };
        var result = WorkflowActions.BuiltIn.Compose<object>(() => unrelated.Body);
        return Finish("UnrelatedBody", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("F007ScalarCapture", "HELLO!", FailureIds = new[] { "F007" })]
    public static FlowDefinition ScalarCapture()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        string suffix = "!";
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output.ToUpperInvariant() + suffix);
        suffix = "changed";
        return Finish("F007ScalarCapture", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("RenamedNativeHandle", "HELLO", FailureIds = new[] { "F008" })]
    public static FlowDefinition RenamedNativeHandle()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output.ToUpperInvariant());
        source.WithName("Renamed");
        return Finish("RenamedNativeHandle", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("EscapedCapture", "A\"\\source.Output", FailureIds = new[] { "F009" })]
    public static FlowDefinition EscapedCapture()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "A").WithName("Source");
        string suffix = "\"\\source.Output";
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output + suffix);
        return Finish("EscapedCapture", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("HelperParameterBinding", "hello!", FailureIds = new[] { "F010" })]
    public static FlowDefinition HelperParameterBinding()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = Create(source, "!");
        return Finish("HelperParameterBinding", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }
    private static IOutputWorkflowAction<string> Create(IOutputWorkflowAction<string> action, string ending)
        => WorkflowActions.BuiltIn.Compose<string>(() => action.Output + ending);

    [WorkflowCase("DistinctRenamedHandles", "[1,2]", FailureIds = new[] { "F011" })]
    public static FlowDefinition DistinctRenamedHandles()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var first = WorkflowActions.BuiltIn.Compose<string>(() => "a").WithName("Temporary");
        var second = WorkflowActions.BuiltIn.Compose<string>(() => "bb").WithName("Temporary");
        var a = WorkflowActions.BuiltIn.Compose<int>(() => first.Output.Length).WithName("FirstLength");
        var b = WorkflowActions.BuiltIn.Compose<int>(() => second.Output.Length).WithName("SecondLength");
        first.WithName("A"); second.WithName("B");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new[] { a.Output, b.Output });
        return Finish("DistinctRenamedHandles", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), first, second, a, b);
    }

    [WorkflowCase("FluentActionName", "HELLO", FailureIds = new[] { "F013" })]
    public static FlowDefinition FluentActionName()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output.ToUpperInvariant()).WithName("Native");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response");
        trigger.Then(source).Then(result).Then(response);
        return WorkflowFactory.CreateStatefulWorkflow("FluentActionName", trigger);
    }

    [WorkflowCase("QuotedFinalName", "{\"direct\":\"hello\",\"native\":\"HELLO\"}", FailureIds = new[] { "F016" })]
    public static FlowDefinition QuotedFinalName()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var direct = WorkflowActions.BuiltIn.Compose<string>(() => source.Output).WithName("Direct");
        var native = WorkflowActions.BuiltIn.Compose<string>(() => source.Output.ToUpperInvariant()).WithName("Native");
        source.WithName("O'Brien");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { direct = direct.Output, native = native.Output });
        return Finish("QuotedFinalName", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source, direct, native);
    }

    [WorkflowCase("CapturedQuote", "'", FailureIds = new[] { "F020" })]
    public static FlowDefinition CapturedQuote()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        char text = '\'';
        var result = WorkflowActions.BuiltIn.Compose<object>(() => text.ToString());
        return Finish("CapturedQuote", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("CapturedNewline", "A\nB", FailureIds = new[] { "F021" })]
    public static FlowDefinition CapturedNewline()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        string text = "a\nb";
        var result = WorkflowActions.BuiltIn.Compose<object>(() => text.ToUpperInvariant());
        return Finish("CapturedNewline", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("LiteralNativeMarker", "#{1 + 2}", FailureIds = new[] { "F023" })]
    public static FlowDefinition LiteralNativeMarker()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => "#{1 + 2}");
        return Finish("LiteralNativeMarker", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("LiteralOldNativeMarker", "@csharp{1 + 2}",
        Description = "The retired expression envelope remains literal user data, not executable C#.")]
    public static FlowDefinition LiteralOldNativeMarker()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => "@csharp{1 + 2}");
        return Finish("LiteralOldNativeMarker", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("LiteralDoubleHashMarker", "##{1 + 2}",
        Description = "Double hash is not an escape sequence; both hashes must survive.")]
    public static FlowDefinition LiteralDoubleHashMarker()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => "##{1 + 2}");
        return Finish("LiteralDoubleHashMarker", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("LiteralEmbeddedNativeMarker", "before #{1 + 2} after",
        Description = "Only a leading hash envelope is executable; embedded hash text stays literal.")]
    public static FlowDefinition LiteralEmbeddedNativeMarker()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => "before #{1 + 2} after");
        return Finish("LiteralEmbeddedNativeMarker", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("LiteralEmbeddedTemplateMarker", "before @{add(1, 2)} after",
        Description = "Authored text must not execute as legacy template interpolation.")]
    public static FlowDefinition LiteralEmbeddedTemplateMarker()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => "before @{add(1, 2)} after");
        return Finish("LiteralEmbeddedTemplateMarker", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("NativeQuotedDirectiveText", "#r \"not-loaded.dll\" #load \"not-loaded.csx\"!",
        Description = "Directive-looking text within C# strings is data and must not load files.")]
    public static FlowDefinition NativeQuotedDirectiveText()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "!").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => "#r \"not-loaded.dll\" #load \"not-loaded.csx\"" + source.Output);
        return Finish("NativeQuotedDirectiveText", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("LiteralTemplateMarker", "@outputs('Source')", FailureIds = new[] { "F024" })]
    public static FlowDefinition LiteralTemplateMarker()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => "@outputs('Source')");
        return Finish("LiteralTemplateMarker", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("RepeatedCallSite", "[1,4]", FailureIds = new[] { "F025" })]
    public static FlowDefinition RepeatedCallSite()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var targets = new List<IOutputWorkflowAction<int>>();
        var seeds = new List<IWorkflowAction>();
        for (var i = 0; i < 2; i++)
        {
            string text = i == 0 ? "a" : "long";
            var source = WorkflowActions.BuiltIn.Compose<string>(() => text).WithName("Source" + i);
            var target = WorkflowActions.BuiltIn.Compose<int>(() => source.Output.Length).WithName("Length" + i);
            targets.Add(target); seeds.Add(source); seeds.Add(target);
        }
        var first = targets[0]; var second = targets[1];
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new[] { first.Output, second.Output });
        return Finish("RepeatedCallSite", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), seeds.ToArray());
    }

    [WorkflowCase("ArraySnapshot", "[1,2]", FailureIds = new[] { "F076" })]
    public static FlowDefinition ArraySnapshot()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var payload = new JArray(1, 2);
        var result = WorkflowActions.BuiltIn.Compose<object>(() => payload);
        payload[0] = 9;
        return Finish("ArraySnapshot", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("ObjectSnapshot", "{\"n\":1}", FailureIds = new[] { "F077" })]
    public static FlowDefinition ObjectSnapshot()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var payload = JObject.Parse("{\"n\":1}");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => payload);
        payload["n"] = 2;
        return Finish("ObjectSnapshot", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("PropertyNativeMethod", "HELLO", FailureIds = new[] { "F078" })]
    public static FlowDefinition PropertyNativeMethod()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var model = new LocalModel { Child = new LocalLeaf { Text = "hello" } };
        var result = WorkflowActions.BuiltIn.Compose<object>(() => model.Child.Text!.ToUpperInvariant());
        return Finish("PropertyNativeMethod", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("UnrelatedTriggerOutput", "local", FailureIds = new[] { "F081" })]
    public static FlowDefinition UnrelatedTriggerOutput()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var model = new TriggerNamedModel { TriggerOutput = new NamedBody { Body = "local" } };
        var result = WorkflowActions.BuiltIn.Compose<object>(() => model.TriggerOutput.Body);
        return Finish("UnrelatedTriggerOutput", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("PrecomputedNativeString", "HELLOWORLD", FailureIds = new[] { "F083" })]
    public static FlowDefinition PrecomputedNativeString()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var localBody = new JValue("world"); var message = "hello" + localBody;
        var result = WorkflowActions.BuiltIn.Compose<object>(() => message.ToUpperInvariant());
        return Finish("PrecomputedNativeString", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("CapturedArrayIndex", "1", FailureIds = new[] { "F113" })]
    public static FlowDefinition CapturedArrayIndex()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var numbers = new[] { 1, 2 };
        var result = WorkflowActions.BuiltIn.Compose<object>(() => numbers[0]);
        numbers[0] = 99;
        return Finish("CapturedArrayIndex", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("CapturedListIndex", "b", FailureIds = new[] { "F114" })]
    public static FlowDefinition CapturedListIndex()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var names = new List<string> { "a", "b" };
        var result = WorkflowActions.BuiltIn.Compose<object>(() => names[1]);
        names[1] = "changed";
        return Finish("CapturedListIndex", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("CapturedDictionaryIndex", "7", FailureIds = new[] { "F115" })]
    public static FlowDefinition CapturedDictionaryIndex()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var lookup = new Dictionary<string, int> { ["k"] = 7 };
        var result = WorkflowActions.BuiltIn.Compose<object>(() => lookup["k"]);
        lookup["k"] = 99;
        return Finish("CapturedDictionaryIndex", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }
}
