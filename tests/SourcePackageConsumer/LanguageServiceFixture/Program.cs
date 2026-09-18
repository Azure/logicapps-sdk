using Microsoft.Azure.Workflows.Sdk;

if (args.Contains("counter-control"))
{
    _ = new ObservedSource().Output;
    return;
}

var suffix = "!";
IOutputWorkflowAction<string> source = new ObservedSource { Name = "Source" };
var compose = WorkflowActions.BuiltIn.Compose(inputs: () => source.Output.ToUpperInvariant() + suffix);
var definition = ((WorkflowActionBase)compose).GetActionDefinition("LanguageServiceFixture");
var actual = definition.Inputs?.ToString()
    ?.Replace("ToObject<global::System.String>()", "ToObject<string>()", StringComparison.Ordinal);
if (actual != "@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant() + \"!\"}")
{
    throw new InvalidOperationException($"Unexpected CB01: {actual}");
}

Console.WriteLine(actual);

sealed class ObservedSource : WorkflowActionBase, IOutputWorkflowAction<string>
{
    public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) =>
        new FlowTemplateAction { Type = FlowTemplateOperationType.Compose, Inputs = "source" };

    public string Output
    {
        get
        {
            File.AppendAllText(
                Environment.GetEnvironmentVariable("WORKFLOW_LSP_SENTINEL")
                    ?? throw new InvalidOperationException("Missing counter sentinel path."),
                "read\n");
            return "source";
        }
    }
}
