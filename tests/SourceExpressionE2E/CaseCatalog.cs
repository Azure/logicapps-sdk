namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

public sealed class CaseResult
{
    public WorkflowCaseAttribute Case { get; init; }
    public string Method { get; init; }
    public string GenerationStatus { get; init; }
    public bool GenerationExpectationMet { get; init; }
    public string ErrorType { get; init; }
    public string Error { get; init; }
    public string CompileSourceSha256 { get; init; }
    public string CompileBuildLog { get; init; }
    [JsonIgnore]
    public FlowDefinition Workflow { get; init; }
}

public static class CaseCatalog
{
    public static readonly JsonSerializerSettings JsonSettings = new()
    {
        ContractResolver = new CamelCasePropertyNamesContractResolver(),
        Formatting = Formatting.Indented,
    };

    public static CaseResult[] Build()
    {
        var entries = typeof(CaseCatalog).Assembly.GetTypes()
            .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
            .Select(method => (Method: method, Case: method.GetCustomAttribute<WorkflowCaseAttribute>()))
            .Where(entry => entry.Case != null)
            .OrderBy(entry => entry.Case.Id, StringComparer.Ordinal)
            .ToArray();
        if (entries.Length == 0)
            throw new InvalidOperationException("No workflow cases were compiled.");
        if (entries.Select(entry => entry.Case.Id).Distinct(StringComparer.OrdinalIgnoreCase).Count() != entries.Length)
            throw new InvalidOperationException("Workflow case IDs must be unique, ignoring case.");
        if (entries.Any(entry => !System.Text.RegularExpressions.Regex.IsMatch(entry.Case.Id, "^[A-Za-z][A-Za-z0-9_-]*$")))
            throw new InvalidOperationException("Workflow case IDs must be safe workflow and directory names.");

        var built = entries.Select(entry =>
        {
            if (entry.Method.GetParameters().Length != 0 || entry.Method.ReturnType != typeof(FlowDefinition))
                throw new InvalidOperationException($"Invalid workflow case signature: {entry.Method}");
            var methodName = entry.Method.DeclaringType.FullName + "." + entry.Method.Name;
            try
            {
                var workflow = (FlowDefinition)entry.Method.Invoke(null, null);
                if (workflow == null || workflow.Name != entry.Case.Id)
                    throw new InvalidOperationException($"Factory must return the named workflow '{entry.Case.Id}'.");
                // Serialization is part of generation and can also reject unsupported captures.
                ValidateRuntimeSafety(JObject.Parse(workflow.ToJson()), entry.Case.Id);
                return new CaseResult
                {
                    Case = entry.Case, Method = methodName, Workflow = workflow,
                    GenerationStatus = "Generated",
                    GenerationExpectationMet = string.IsNullOrEmpty(entry.Case.ExpectedGenerationError),
                };
            }
            catch (Exception error) when (error is TargetInvocationException || error is NotSupportedException ||
                error is InvalidOperationException || error is JsonException)
            {
                var actual = error is TargetInvocationException { InnerException: not null } invocation ? invocation.InnerException : error;
                Console.Error.WriteLine($"[{entry.Case.Id}] Definition generation rejected: {actual.GetType().Name}: {actual.Message}");
                return new CaseResult
                {
                    Case = entry.Case, Method = methodName,
                    GenerationStatus = "Rejected",
                    GenerationExpectationMet = !string.IsNullOrEmpty(entry.Case.ExpectedGenerationError)
                        && actual.Message.Contains(entry.Case.ExpectedGenerationError, StringComparison.Ordinal),
                    ErrorType = actual.GetType().FullName, Error = actual.Message,
                };
            }
        }).ToArray();
        var rejectionPath = Environment.GetEnvironmentVariable("E2E_COMPILE_REJECTIONS");
        if (string.IsNullOrEmpty(rejectionPath)) return built;
        var rejected = JsonConvert.DeserializeObject<CaseResult[]>(File.ReadAllText(rejectionPath))
            ?? throw new InvalidOperationException("Compile rejection evidence is empty.");
        if (rejected.Any(result => result.Case == null || result.GenerationStatus != "CompileRejected" ||
            result.GenerationExpectationMet || string.IsNullOrEmpty(result.Error) ||
            string.IsNullOrEmpty(result.CompileSourceSha256) || string.IsNullOrEmpty(result.CompileBuildLog)))
            throw new InvalidOperationException("Invalid compile rejection evidence.");
        var all = built.Concat(rejected).OrderBy(result => result.Case.Id, StringComparer.Ordinal).ToArray();
        if (all.Select(result => result.Case.Id).Distinct(StringComparer.OrdinalIgnoreCase).Count() != all.Length)
            throw new InvalidOperationException("Compile rejection evidence overlaps compiled workflow IDs.");
        return all;
    }

    private static void ValidateRuntimeSafety(JObject workflow, string caseId)
    {
        foreach (var value in workflow.Descendants().OfType<JValue>().Where(value => value.Type == JTokenType.String))
        {
            var text = (string)value;
            if (text.StartsWith("@@", StringComparison.Ordinal) || text.StartsWith("#{", StringComparison.Ordinal))
                continue;
            if (text.StartsWith("@", StringComparison.Ordinal) || text.Contains("@{", StringComparison.Ordinal))
                throw new InvalidOperationException($"E2E expression contract: only C# expressions or escaped literals are permitted at '{value.Path}'.");
        }
        var triggers = (JObject)workflow["definition"]["triggers"];
        if (triggers.Count != 1 || triggers.Properties().Any(property =>
            (string)property.Value["type"] != "Request" || (string)property.Value["kind"] != "Http"))
            throw new InvalidOperationException("E2E safety: only one local HTTP request trigger is permitted.");
        ValidateActions((JObject)workflow["definition"]["actions"], caseId);
        ServiceProviderFixtures.ValidateDefinition(caseId, workflow);
    }

    private static void ValidateActions(JObject actions, string caseId)
    {
        var allowed = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Compose", "Response", "If", "Foreach", "Scope", "Switch", "ParseJson",
            "InitializeVariable", "SetVariable", "IncrementVariable", "DecrementVariable",
            "AppendToStringVariable", "AppendToArrayVariable", "Select", "Query", "Join", "Table",
        };
        foreach (var property in actions.Properties())
        {
            var action = (JObject)property.Value;
            var type = (string)action["type"];
            var seedMethod = (caseId, property.Name) switch
            {
                ("DecimalBodiesAtBoundary", "First" or "Second") => "SeedSummary500",
                ("DecimalBodiesBelowBoundary", "First") => "SeedSummary500",
                ("DecimalBodiesBelowBoundary", "Second") => "SeedSummary49999",
                ("JsonPropertyNavigation" or "TypedBodyLinq", "GetItems") => "SeedItems",
                ("TypedBodyLinqEmpty", "GetItems") => "SeedEmptyItems",
                ("TypedBodyLinqInvalid", "GetItems") => "SeedInvalidItems",
                ("TypedDecimalBody", "GetSummary") => "SeedSummary100",
                _ => null,
            };
            var reviewedSeed = type == "CSharpScriptCode" && seedMethod != null &&
                action["inputs"] is JObject inputs && inputs.Count == 1 &&
                inputs["userFunctionName"] is JValue { Type: JTokenType.String } function &&
                (string)function == seedMethod;
            var reviewedProvider = type == "ServiceProvider" &&
                ServiceProviderFixtures.IsAllowedAction(caseId, property.Name, action);
            if (type == null || (!allowed.Contains(type) && !reviewedSeed && !reviewedProvider))
                throw new InvalidOperationException($"E2E safety: action '{property.Name}' of type '{type}' is not allowed.");
            if (action["actions"] is JObject nested) ValidateActions(nested, caseId);
            if (action["else"]?["actions"] is JObject alternative) ValidateActions(alternative, caseId);
            if (action["default"]?["actions"] is JObject fallback) ValidateActions(fallback, caseId);
            if (action["cases"] is JObject cases)
                foreach (var branch in cases.Properties())
                    if (branch.Value["actions"] is JObject branchActions) ValidateActions(branchActions, caseId);
        }
    }

    public static void Write(string directory, CaseResult[] results)
    {
        Directory.CreateDirectory(directory);
        foreach (var result in results.Where(result => result.Workflow != null))
        {
            var destination = Path.Combine(directory, result.Case.Id);
            Directory.CreateDirectory(destination);
            File.WriteAllText(Path.Combine(destination, "workflow.json"), result.Workflow.ToJson());
        }
        File.WriteAllText(Path.Combine(directory, "generation-results.json"),
            JsonConvert.SerializeObject(results, JsonSettings));
    }
}
