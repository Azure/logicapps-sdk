using Microsoft.Azure.Workflows.Sdk;
using Newtonsoft.Json;

var source = WorkflowActions.BuiltIn.Compose<string>(() => "source").WithName("Source");
var helper = WorkflowHelper.Build(source, "!");
var actual = helper.GetActionDefinition("LibraryConsumer").Inputs.ToString()
    .Replace("ToObject<global::System.String>()", "ToObject<string>()", StringComparison.Ordinal);
const string expected = "#{outputs(\"Source\").ToObject<string>() + \"!\"}";
if (actual != expected) throw new InvalidOperationException($"Expected '{expected}', got '{actual}'.");
var transitive = TransitiveWorkflow.Build().GetActionDefinition("LibraryConsumer").Inputs.ToString();
if (transitive != "indirect package reference") throw new InvalidOperationException("Transitive library was not transformed.");
Console.WriteLine(JsonConvert.SerializeObject(new { helper = actual, transitive }));
