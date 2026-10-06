using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static class EnumCases
{
    [WorkflowCase("EnumClrToString", "First", FailureIds = new[] { "F063", "F186" })]
    public static FlowDefinition EnumClrToString()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => WireChoice.First.ToString());
        return Finish("EnumClrToString", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("EnumComparisonTrue", "true", FailureIds = new[] { "F064" })]
    public static FlowDefinition EnumComparisonTrue()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var choiceAction = WorkflowActions.BuiltIn.Compose<WireChoice>(() => WireChoice.First).WithName("Choice");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => choiceAction.Output == WireChoice.First);
        return Finish("EnumComparisonTrue", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), choiceAction);
    }

    [WorkflowCase("EnumComparisonFalse", "false", FailureIds = new[] { "F064" })]
    public static FlowDefinition EnumComparisonFalse()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var choiceAction = WorkflowActions.BuiltIn.Compose<WireChoice>(() => WireChoice.Second).WithName("Choice");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => choiceAction.Output == WireChoice.First);
        return Finish("EnumComparisonFalse", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), choiceAction);
    }

    [WorkflowCase("EnumNativeArgument", "First", FailureIds = new[] { "F066", "F187" })]
    public static FlowDefinition EnumNativeArgument()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var choiceAction = WorkflowActions.BuiltIn.Compose<WireChoice>(() => WireChoice.First).WithName("Choice");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => RuntimeValues.Accept(choiceAction.Output));
        return Finish("EnumNativeArgument", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), choiceAction);
    }

    [WorkflowCase("EnumKnownTrue", "first /+", FailureIds = new[] { "F067", "F069" })]
    public static FlowDefinition EnumKnownTrue()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Flag");
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => flag.Output ? WireChoice.First : WireChoice.Second);
        return Finish("EnumKnownTrue", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag);
    }

    [WorkflowCase("EnumKnownFalse", "second", FailureIds = new[] { "F067", "F069" })]
    public static FlowDefinition EnumKnownFalse()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => flag.Output ? WireChoice.First : WireChoice.Second);
        return Finish("EnumKnownFalse", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag);
    }

    [WorkflowCase("EnumNestedConditional", "Unannotated", FailureIds = new[] { "F068" })]
    public static FlowDefinition EnumNestedConditional()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
        var otherFlag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("OtherFlag");
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => flag.Output ? WireChoice.First : (otherFlag.Output ? WireChoice.Second : WireChoice.Unannotated));
        return Finish("EnumNestedConditional", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag, otherFlag);
    }

    [WorkflowCase("NullableEnumObject", "{\"choice\":null}", FailureIds = new[] { "F070" },
        Description = "Representative valid object; original literal-null Compose is not deployable.")]
    public static FlowDefinition NullableEnumObject()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        WireChoice? choice = null;
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { choice });
        return Finish("NullableEnumObject", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("NullableEnumWire", "second", FailureIds = new[] { "F071" })]
    public static FlowDefinition NullableEnumWire()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Flag");
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => (WireChoice)(flag.Output ? (WireChoice?)WireChoice.Second : null));
        return Finish("NullableEnumWire", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag);
    }

    [WorkflowCase("NullableEnumNumber", "1", FailureIds = new[] { "F071" })]
    public static FlowDefinition NullableEnumNumber()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Flag");
        var result = WorkflowActions.BuiltIn.Compose<int>(() => (int)(WireChoice)(flag.Output ? (WireChoice?)WireChoice.Second : null));
        return Finish("NullableEnumNumber", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag);
    }

    [WorkflowCase("NullableEnumFailure", "", FailureIds = new[] { "F071" }, ExpectedRunStatus = "Failed",
        ExpectedHttpStatus = 502, ExpectedActionError = "Nullable object must have a value.")]
    public static FlowDefinition NullableEnumFailure()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => (WireChoice)(flag.Output ? (WireChoice?)WireChoice.Second : null));
        return Finish("NullableEnumFailure", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag);
    }

    [WorkflowCase("CapturedEnumWire", "first /+", FailureIds = new[] { "F072" })]
    public static FlowDefinition CapturedEnumWire()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var choice = WireChoice.First;
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => choice);
        return Finish("CapturedEnumWire", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("FlagsEnumWire", "Read, Write", FailureIds = new[] { "F073" })]
    public static FlowDefinition FlagsEnumWire()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var access = Access.Read | Access.Write;
        var result = WorkflowActions.BuiltIn.Compose<Access>(() => access);
        return Finish("FlagsEnumWire", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("EnumRuntimeMethod", "first /+", FailureIds = new[] { "F074" })]
    public static FlowDefinition RuntimeEnumMethod()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        RuntimeValues.Calls = 0;
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => RuntimeValues.NextChoice());
        var definition = Finish("EnumRuntimeMethod", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
        Require(RuntimeValues.Calls == 0, "Enum method executed during generation.");
        return definition;
    }

    [WorkflowCase("EnumRuntimeConditional", "first /+", FailureIds = new[] { "F065" })]
    public static FlowDefinition RuntimeEnumConditional()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Flag");
        RuntimeValues.Calls = 0;
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => flag.Output ? WireChoice.First : RuntimeValues.NextChoice());
        var definition = Finish("EnumRuntimeConditional", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag);
        Require(RuntimeValues.Calls == 0, "Unselected enum method executed during generation.");
        return definition;
    }

    [WorkflowCase("EnumRuntimeConditionalFallback", "first /+", FailureIds = new[] { "F065" })]
    public static FlowDefinition RuntimeEnumConditionalFallback()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
        RuntimeValues.Calls = 0;
        var result = WorkflowActions.BuiltIn.Compose<WireChoice>(() => flag.Output ? WireChoice.First : RuntimeValues.NextChoice());
        var definition = Finish("EnumRuntimeConditionalFallback", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag);
        Require(RuntimeValues.Calls == 0, "Fallback enum method executed during generation.");
        return definition;
    }
}
