using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

internal static class CaseSupport
{
    // Only connect operations here: never invoke a value callback to obtain its result.
    internal static FlowDefinition Finish(string name, IWorkflowTrigger trigger,
        IWorkflowAction result, IWorkflowAction response, params IWorkflowAction[] seeds)
    {
        IChainableNode chain = trigger;
        foreach (var seed in seeds) chain = chain.Then(seed);
        chain.Then(result).Then(response);
        return WorkflowFactory.CreateStatefulWorkflow(name, trigger);
    }

    internal static FlowDefinition Proof(string name)
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<string>(() => "authoring-contract passed");
        return Finish(name, trigger, result.WithName("Result"),
            WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    internal static void Require(bool condition, string message)
    {
        if (!condition) throw new InvalidOperationException(message);
    }
}

public sealed class LocalLeaf { public string? Text { get; set; } }
public sealed class LocalModel { public LocalLeaf Child { get; set; } = new(); }
public sealed class NamedBody { public string Body { get; set; } = ""; }
public sealed class TriggerNamedModel { public NamedBody TriggerOutput { get; set; } = new(); }
public sealed class OrderSummary { public decimal Total { get; set; } }
public sealed class ItemsList { [JsonProperty("value")] public ListItem[] Value { get; set; } = []; }
public sealed class ListItem { public Dictionary<string, JToken> DynamicProperties { get; set; } = new(); }
public sealed class DisplayModel
{
    public int Id { get; set; }
    public override string ToString() => $"Display:{Id}";
}
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
[Flags] public enum Access { Read = 1, Write = 2 }
public readonly struct Money
{
    public static int ConstructorCalls;
    public static int OperatorCalls;
    public decimal Value { get; }
    public Money(decimal value) { ConstructorCalls++; Value = value; }
    public static Money operator +(Money a, Money b) { OperatorCalls++; return new Money(a.Value + b.Value); }
}
public static class RuntimeValues
{
    public static int Calls;
    public static WireChoice NextChoice() { Calls++; return WireChoice.First; }
    public static string Accept(WireChoice value) => value.ToString();
    public static Dictionary<string, string> CreateHeaders() { Calls++; return new() { ["X"] = "value" }; }
    public static AgentPromptMessage[] NextMessages() { Calls++; return []; }
    public static System.Net.HttpStatusCode NextStatus() { Calls++; return System.Net.HttpStatusCode.Accepted; }
}
