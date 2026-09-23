using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static class StringCases
{
    [WorkflowCase("Uppercase", "HELLO", FailureIds = new[] { "F119", "F166", "F192" })]
    public static FlowDefinition Uppercase()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output.ToUpperInvariant());
        return Finish("Uppercase", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("Substring", "el", FailureIds = new[] { "F120", "F193" })]
    public static FlowDefinition Substring()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output.Substring(1, 2));
        return Finish("Substring", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("StringLength", "5", FailureIds = new[] { "F167", "F194" })]
    public static FlowDefinition StringLength()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<int>(() => source.Output.Length);
        return Finish("StringLength", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("EmptyStringLength", "0", FailureIds = new[] { "F167", "F194" })]
    public static FlowDefinition EmptyStringLength()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<int>(() => source.Output.Length);
        return Finish("EmptyStringLength", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("NumericFormatting", "{\"plain\":\"3\",\"next\":\"Next: 4\",\"padded\":\"03\",\"braces\":\"{   03}\",\"aligned\":\"Count:    03\",\"invariant\":\"03\"}",
        FailureIds = new[] { "F121", "F122", "F123", "F128", "F132", "F172", "F180" })]
    public static FlowDefinition NumericFormatting()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        var plain = WorkflowActions.BuiltIn.Compose<object>(() => count.Output.ToString()).WithName("Plain");
        var next = WorkflowActions.BuiltIn.Compose<object>(() => $"Next: {count.Output + 1}").WithName("Next");
        var padded = WorkflowActions.BuiltIn.Compose<object>(() => string.Format("{0:00}", count.Output)).WithName("Padded");
        var braces = WorkflowActions.BuiltIn.Compose<object>(() => string.Format("{{{0,5:00}}}", count.Output)).WithName("Braces");
        var aligned = WorkflowActions.BuiltIn.Compose<object>(() => $"Count: {count.Output,5:00}").WithName("Aligned");
        var invariant = WorkflowActions.BuiltIn.Compose<object>(() => string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:00}", count.Output)).WithName("Invariant");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { plain = plain.Output, next = next.Output,
            padded = padded.Output, braces = braces.Output, aligned = aligned.Output, invariant = invariant.Output });
        return Finish("NumericFormatting", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count, plain, next, padded, braces, aligned, invariant);
    }

    [WorkflowCase("InvariantDecimalFormatting", "1,234.50", FailureIds = new[] { "F124" })]
    public static FlowDefinition InvariantDecimalFormatting()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var amount = WorkflowActions.BuiltIn.Compose<decimal>(() => 1234.5m).WithName("Amount");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:N2}", amount.Output));
        return Finish("InvariantDecimalFormatting", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), amount);
    }

    [WorkflowCase("NativeStringCombinations", "{\"upperConcat\":\"HELLOworld\",\"reordered\":\"world/hello/world\",\"plus\":\"Name: hello\",\"concat\":\"Name: hello\",\"format\":\"Name: hello\"}",
        FailureIds = new[] { "F125", "F127", "F130", "F131", "F169", "F170", "F171" })]
    public static FlowDefinition NativeStringCombinations()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var other = WorkflowActions.BuiltIn.Compose<string>(() => "world").WithName("Other");
        var upperConcat = WorkflowActions.BuiltIn.Compose<object>(() => string.Concat(source.Output.ToUpperInvariant(), other.Output)).WithName("UpperConcat");
        var reordered = WorkflowActions.BuiltIn.Compose<object>(() => string.Format("{1}/{0}/{1}", source.Output, other.Output)).WithName("Reordered");
        var plus = WorkflowActions.BuiltIn.Compose<object>(() => "Name: " + source.Output).WithName("Plus");
        var concat = WorkflowActions.BuiltIn.Compose<object>(() => string.Concat("Name: ", source.Output)).WithName("Concat");
        var format = WorkflowActions.BuiltIn.Compose<object>(() => string.Format("Name: {0}", source.Output)).WithName("Format");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { upperConcat = upperConcat.Output, reordered = reordered.Output,
            plus = plus.Output, concat = concat.Output, format = format.Output });
        return Finish("NativeStringCombinations", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source, other, upperConcat, reordered, plus, concat, format);
    }

    [WorkflowCase("ArgumentOrder", "B/A/B", FailureIds = new[] { "F179" },
        Description = "Native expression and values preserved; runtime getter read counts are not instrumented.")]
    public static FlowDefinition ArgumentOrder()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "A").WithName("Source");
        var other = WorkflowActions.BuiltIn.Compose<string>(() => "B").WithName("Other");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => string.Format("{1}/{0}/{1}", source.Output, other.Output));
        return Finish("ArgumentOrder", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source, other);
    }

    [WorkflowCase("CustomToString", "Model: Display:3", FailureIds = new[] { "F129" })]
    public static FlowDefinition CustomToString()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => $"Model: {new DisplayModel { Id = count.Output }}");
        return Finish("CustomToString", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count);
    }

    [WorkflowCase("PropertyPattern", "true", FailureIds = new[] { "F182" })]
    public static FlowDefinition PropertyPattern()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output is { Length: > 2 });
        return Finish("PropertyPattern", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("NativeRange", "he", FailureIds = new[] { "F183" })]
    public static FlowDefinition NativeRange()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output[..2]);
        return Finish("NativeRange", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("NativeSwitch", "positive", FailureIds = new[] { "F174" })]
    public static FlowDefinition NativeSwitch()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => count.Output switch { > 0 => "positive", _ => "other" });
        return Finish("NativeSwitch", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count);
    }

    [WorkflowCase("TemplateReferences", "{\"direct\":\"hello\",\"pair\":\"First: hello; second: world\",\"name\":\"Name: hello\",\"braces\":\"{Name}: hello; again: hello\"}",
        FailureIds = new[] { "F145", "F149", "F151", "F153", "F154" })]
    public static FlowDefinition TemplateReferences()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var other = WorkflowActions.BuiltIn.Compose<string>(() => "world").WithName("Other");
        var direct = WorkflowActions.BuiltIn.Compose<object>(() => source.Output).WithName("Direct");
        var pair = WorkflowActions.BuiltIn.Compose<object>(() => $"First: {source.Output}; second: {other.Output}").WithName("Pair");
        var name = WorkflowActions.BuiltIn.Compose<object>(() => $"Name: {source.Output}").WithName("Name");
        var braces = WorkflowActions.BuiltIn.Compose<object>(() => $"{{Name}}: {source.Output}; again: {source.Output}").WithName("Braces");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { direct = direct.Output, pair = pair.Output, name = name.Output, braces = braces.Output });
        return Finish("TemplateReferences", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source, other, direct, pair, name, braces);
    }

    [WorkflowCase("RawMultilineInterpolation", "{{Name}}: hello", FailureIds = new[] { "F175" })]
    public static FlowDefinition RawMultilineInterpolation()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => $$$"""
            {{Name}}: {{{source.Output}}}
            """);
        return Finish("RawMultilineInterpolation", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("RawInlineInterpolation", "{{Name}}: hello", FailureIds = new[] { "F176" })]
    public static FlowDefinition RawInlineInterpolation()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => $$$"""{{Name}}: {{{source.Output}}}""");
        return Finish("RawInlineInterpolation", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("F177VerbatimInterpolation", "{Name}: hello", FailureIds = new[] { "F177" },
        Description = "Both SDKs passed this exact value on the earlier real host; source spelling alone is not a runtime defect.")]
    public static FlowDefinition VerbatimInterpolation()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => $@"{{Name}}: {source.Output}");
        return Finish("F177VerbatimInterpolation", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("RegularInterpolation", "{Name}: hello", FailureIds = new[] { "F178" })]
    public static FlowDefinition RegularInterpolation()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => $"{{Name}}: {source.Output}");
        return Finish("RegularInterpolation", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }
}
