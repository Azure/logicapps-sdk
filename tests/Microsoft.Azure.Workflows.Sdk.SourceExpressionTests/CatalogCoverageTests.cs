namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Reflection;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;

public sealed class CatalogCoverageTests
{
    [Fact]
    public void Coverage_contains_exactly_the_326_original_catalog_case_ids()
    {
        var catalog = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Fixtures", "approved-catalog.md"));
        var caseSection = catalog[..catalog.IndexOf("### 14.9", StringComparison.Ordinal)];
        var ids = Regex.Matches(caseSection, @"(?m)^\| ([A-Z]+[0-9]+[a-z]?) \||^### ([A-Z]+[0-9]+[a-z]?):")
            .Select(m => m.Groups[1].Success ? m.Groups[1].Value : m.Groups[2].Value).ToArray();
        Assert.Equal(326, ids.Length);
        Assert.Equal(ids.Length, ids.Distinct().Count());
        using var document = JsonDocument.Parse(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "catalog-coverage.json")));
        var cases = document.RootElement.GetProperty("cases").EnumerateArray().ToArray();
        Assert.Equal(326, cases.Length);
        Assert.Equal(ids.Order(), cases.Select(c => c.GetProperty("id").GetString()!).Order());

        var tests = DiscoverMappedTests();
        var ledgerTests = new HashSet<(string Id, string Test)>();
        foreach (var row in cases)
        {
            var id = row.GetProperty("id").GetString()!;
            var status = row.GetProperty("status").GetString();
            Assert.Contains(status, new[] { "locally-covered", "externally-verified", "backend-required", "not-implemented" });
            Assert.False(string.IsNullOrWhiteSpace(row.GetProperty("original").GetString()));
            var mapped = row.GetProperty("tests").EnumerateArray().Select(t => t.GetString()!).ToArray();
            foreach (var test in mapped)
            {
                Assert.Contains((id, test), tests);
                ledgerTests.Add((id, test));
            }
            if (status == "locally-covered")
            {
                Assert.NotEmpty(mapped);
                Assert.Contains("local", row.GetProperty("verification").GetString()!, StringComparison.OrdinalIgnoreCase);
                Assert.Equal(JsonValueKind.Null, row.GetProperty("coverageGap").ValueKind);
                Assert.Contains(row.GetProperty("localFeatureState").GetString(),
                    new[] { "contract-verified", "unsupported-form-rejection-verified", "validation-rejection-verified" });
            }
            else if (status == "externally-verified")
            {
                Assert.Empty(mapped);
                Assert.Equal("external-contract-verified", row.GetProperty("localFeatureState").GetString());
                Assert.Equal(JsonValueKind.Null, row.GetProperty("coverageGap").ValueKind);
                var evidence = row.GetProperty("externalValidation");
                var kind = evidence.GetProperty("evidenceKind").GetString();
                Assert.Contains(kind, new[] { "external-package-validation", "actual-local-logicapps-runtime", "actual-local-logicapps-codeful-runtime" });
                Assert.Contains(evidence.GetProperty("status").GetString(), new[] { "passed", "negative-case-passed" });
                if (kind == "external-package-validation")
                    Assert.NotEmpty(evidence.GetProperty("logLines").EnumerateArray());
                else if (kind == "actual-local-logicapps-runtime")
                {
                    Assert.Contains(id, new[] { "S14", "F08" });
                    Assert.Equal(new[] { "en-US", "fr-FR" }, evidence.GetProperty("cultures").EnumerateArray().Select(c => c.GetString()));
                    Assert.Equal(2, evidence.GetProperty("observations").GetArrayLength());
                }
                else
                {
                    Assert.Equal("X06", id);
                    Assert.Equal(1, evidence.GetProperty("reportedProbeExitCode").GetInt32());
                    Assert.Equal("failed", evidence.GetProperty("overallProbeOutcome").GetString());
                    Assert.Equal("{\"Next\":4,\"Label\":\"A\"}", evidence.GetProperty("decodedJson").GetString());
                    Assert.Single(evidence.GetProperty("observations").EnumerateArray());
                }
            }
            else
            {
                var gap = row.GetProperty("coverageGap");
                Assert.Contains(gap.GetProperty("category").GetString(), new[]
                {
                    "uncovered-local-variant", "local-feature-target-unverified", "external-backend-gate",
                    "external-schema-gate", "external-build-gate", "external-deployment-gate", "observed-local-contract-gap",
                });
                Assert.False(string.IsNullOrWhiteSpace(gap.GetProperty("reason").GetString()));
                var failed = row.GetProperty("testResult").GetProperty("failed").GetInt32() > 0;
                Assert.Equal(failed ? "observed-contract-gap" : "not-assessed", gap.GetProperty("implementationSupport").GetString());
                Assert.Equal(failed ? "contract-failure-observed" : "not-assessed", row.GetProperty("localFeatureState").GetString());
            }
        }

        Assert.All(tests, test => Assert.Contains(test.Id, ids));
        Assert.Equal(tests.OrderBy(t => t.Id).ThenBy(t => t.Test),
            ledgerTests.OrderBy(t => t.Id).ThenBy(t => t.Test));
    }

    [Fact]
    public void Actual_host_evidence_hashes_and_observations_are_preserved_without_claiming_xunit_host_execution()
    {
        var directory = Path.Combine(AppContext.BaseDirectory, "Fixtures", "host-runtime-1.170.91");
        using var manifest = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "manifest.json")));
        Assert.Equal(1, manifest.RootElement.GetProperty("version").GetInt32());
        Assert.Equal("actual-local-logicapps-runtime", manifest.RootElement.GetProperty("evidenceKind").GetString());
        var files = manifest.RootElement.GetProperty("artifacts").EnumerateArray().ToArray();
        Assert.Equal(13, files.Length);
        Assert.Equal(files.Length, files.Select(file => file.GetProperty("file").GetString()).Distinct().Count());
        foreach (var file in files)
        {
            var name = file.GetProperty("file").GetString()!;
            Assert.Equal(Path.GetFileName(name), name);
            Assert.Equal(file.GetProperty("sha256").GetString(),
                Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(Path.Combine(directory, name)))));
        }
        using var template = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "TemplateProbe.workflow.json")));
        using var literal = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "LiteralProbe.workflow.json")));
        Assert.Equal("Received request: @{triggerBody()}",
            template.RootElement.GetProperty("definition").GetProperty("actions").GetProperty("Response").GetProperty("inputs").GetProperty("body").GetString());
        Assert.Equal("@@csharp{1 + 2}",
            literal.RootElement.GetProperty("definition").GetProperty("actions").GetProperty("Response").GetProperty("inputs").GetProperty("body").GetString());
        var expected = new Dictionary<string, (string Input, string Body)>
        {
            ["null"] = ("null", "Received request: "),
            ["string"] = ("\"hello\"", "Received request: hello"),
            ["integer"] = ("42", "Received request: 42"),
            ["boolean"] = ("true", "Received request: True"),
            ["object"] = ("{\"n\":1}", "Received request: {\"n\":1}"),
            ["array"] = ("[1,2]", "Received request: [1,2]")
        };
        var processIds = new HashSet<int>();
        foreach (var culture in new[] { "en-US", "fr-FR" })
        {
            using var run = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, culture + ".json")));
            var record = run.RootElement;
            Assert.Equal("4.1052.200.26352", record.GetProperty("runtime").GetString());
            Assert.Equal("1.170.91", record.GetProperty("extensionBundle").GetProperty("version").GetString());
            var instrumentation = record.GetProperty("cultureInstrumentation");
            Assert.Equal(culture, instrumentation.GetProperty("culture").GetString());
            Assert.Equal(culture, instrumentation.GetProperty("defaultThreadCulture").GetString());
            Assert.True(processIds.Add(instrumentation.GetProperty("processId").GetInt32()));
            foreach (var definition in record.GetProperty("definitions").EnumerateArray())
                Assert.Equal(definition.GetProperty("sha256").GetString(),
                    Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(
                        Path.Combine(directory, definition.GetProperty("name").GetString() + ".workflow.json")))));
            var observations = record.GetProperty("templateResults").EnumerateArray().ToArray();
            Assert.Equal(6, observations.Length);
            Assert.Equal(expected.Keys.Order(), observations.Select(o => o.GetProperty("inputKind").GetString()!).Order());
            foreach (var observation in observations)
            {
                var sample = expected[observation.GetProperty("inputKind").GetString()!];
                Assert.Equal(sample.Input, observation.GetProperty("inputJson").GetString());
                Assert.Equal(sample.Body, observation.GetProperty("body").GetString());
                Assert.Equal(200, observation.GetProperty("status").GetInt32());
                Assert.True(observation.GetProperty("passed").GetBoolean());
            }
            var response = record.GetProperty("literalResult");
            Assert.Equal(200, response.GetProperty("status").GetInt32());
            Assert.Equal("@csharp{1 + 2}", response.GetProperty("body").GetString());
            Assert.True(response.GetProperty("passed").GetBoolean());
        }
        var excerpt = File.ReadAllLines(Path.Combine(directory, "native-validation.log.txt"));
        Assert.Equal(2, excerpt.Length);
        foreach (var line in excerpt)
        {
            Assert.Matches(@"^\[[^\]]+\] Workflow '(NativeProbe|ConditionProbe)' validation and creation failed\.", line);
            Assert.Contains("character '{'", line);
            Assert.DoesNotMatch(@"(?i)https?://|callback|sig=|code=|secret|password", line);
        }
        VerifyNativePreviewEvidence();
    }

    private static void VerifyNativePreviewEvidence()
    {
        var directory = Path.Combine(AppContext.BaseDirectory, "Fixtures", "host-native-preview");
        using var manifest = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "manifest.json")));
        using var observations = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "observations.json")));
        Assert.Equal(1, manifest.RootElement.GetProperty("reportedProbeExitCode").GetInt32());
        Assert.Equal("failed", manifest.RootElement.GetProperty("overallOutcome").GetString());
        var artifacts = manifest.RootElement.GetProperty("artifacts").EnumerateArray().ToArray();
        Assert.Equal(12, artifacts.Length);
        Assert.Equal(12, artifacts.Select(file => file.GetProperty("file").GetString()).Distinct().Count());
        foreach (var artifact in artifacts)
        {
            var file = artifact.GetProperty("file").GetString()!;
            Assert.Equal(Path.GetFileName(file), file);
            Assert.DoesNotMatch(@"(?i)\.(dll|zip|nupkg)$", file);
            Assert.Equal(artifact.GetProperty("sha256").GetString(),
                Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(Path.Combine(directory, file)))));
        }
        var record = observations.RootElement;
        Assert.Equal("4.51.100.26305", record.GetProperty("runtime").GetString());
        foreach (var definition in record.GetProperty("definitions").EnumerateArray())
            Assert.Equal(definition.GetProperty("sha256").GetString(),
                Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(
                    Path.Combine(directory, definition.GetProperty("name").GetString() + ".workflow.json")))));
        var results = record.GetProperty("results").EnumerateArray().ToDictionary(item => item.GetProperty("name").GetString()!);
        Assert.Equal(7, results.Count);
        Assert.Equal(5, results.Values.Count(item => item.GetProperty("passed").GetBoolean()));
        foreach (var branch in new[] { "true", "false" })
        {
            var condition = results["condition-" + branch];
            Assert.False(condition.GetProperty("passed").GetBoolean());
            Assert.Equal(502, condition.GetProperty("status").GetInt32());
            using var failure = JsonDocument.Parse(condition.GetProperty("body").GetString()!);
            Assert.Equal("NoResponse", failure.RootElement.GetProperty("error").GetProperty("code").GetString());
            var control = results["template-condition-control-" + branch];
            Assert.True(control.GetProperty("passed").GetBoolean());
            Assert.Equal(200, control.GetProperty("status").GetInt32());
            Assert.Equal(branch == "true" ? "yes" : "no", control.GetProperty("body").GetString());
        }
        var encoded = results["encoded-json"];
        Assert.True(encoded.GetProperty("passed").GetBoolean());
        Assert.Equal(200, encoded.GetProperty("status").GetInt32());
        Assert.Equal("eyJOZXh0Ijo0LCJMYWJlbCI6IkEifQ==", encoded.GetProperty("body").GetString());
        Assert.Equal("{\"Next\":4,\"Label\":\"A\"}",
            System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encoded.GetProperty("body").GetString()!)));
        using var workflow = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "EncodedJsonProbe.workflow.json")));
        var actions = workflow.RootElement.GetProperty("definition").GetProperty("actions");
        Assert.Equal(3, actions.GetProperty("Count").GetProperty("inputs").GetInt32());
        Assert.Equal("A", actions.GetProperty("Source").GetProperty("inputs").GetString());
        var expression = actions.GetProperty("Encoded").GetProperty("inputs").GetString()!;
        Assert.Contains("JsonSerializer.Create(", expression);
        Assert.DoesNotContain("Microsoft.Azure.Workflows.Sdk", expression);
        Assert.Equal("@outputs('Encoded')", actions.GetProperty("Response").GetProperty("inputs").GetProperty("body").GetString());
    }

    [Fact]
    public void External_package_evidence_is_hashed_and_not_invented_xunit_execution()
    {
        var fixtures = Path.Combine(AppContext.BaseDirectory, "Fixtures");
        using var provenance = JsonDocument.Parse(File.ReadAllText(Path.Combine(fixtures, "package-final-provenance.json")));
        using var cases = JsonDocument.Parse(File.ReadAllText(Path.Combine(fixtures, "package-final-pk-evidence.json")));
        var record = provenance.RootElement;
        Assert.Equal(0, record.GetProperty("validation").GetProperty("exitCode").GetInt32());
        Assert.Equal(record.GetProperty("packageSha256").GetString(), cases.RootElement.GetProperty("packageSha256").GetString());
        Assert.Equal(record.GetProperty("validation").GetProperty("logSha256").GetString(),
            Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(Path.Combine(fixtures, "package-final-validation.log.txt")))));
        Assert.Equal(record.GetProperty("validatorSha256").GetString(),
            Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(Path.Combine(fixtures, "package-validator.ps1.txt")))));
        var log = File.ReadAllLines(Path.Combine(fixtures, "package-final-validation.log.txt"));
        foreach (var item in cases.RootElement.GetProperty("cases").EnumerateArray()
            .Where(item => item.GetProperty("id").GetString() != "PK13" &&
                item.GetProperty("status").GetString() is "passed" or "negative-case-passed"))
        foreach (var line in item.GetProperty("logLines").EnumerateArray())
            Assert.StartsWith("CHECK ", log[line.GetInt32() - 1]);
        var packageCases = cases.RootElement.GetProperty("cases").EnumerateArray()
            .ToDictionary(item => item.GetProperty("id").GetString()!);
        Assert.Equal("passed", packageCases["PK02"].GetProperty("status").GetString());
        Assert.Equal("negative-case-passed", packageCases["PK12"].GetProperty("status").GetString());
        Assert.Equal("passed", packageCases["PK13"].GetProperty("status").GetString());
        Assert.Equal("partial", packageCases["PK17"].GetProperty("status").GetString());
        Assert.Contains("Other CLI/IDE platforms", packageCases["PK17"].GetProperty("unverified").GetString()!);
        Assert.Empty(record.GetProperty("failedChecks").EnumerateArray());
        Assert.True(record.GetProperty("sharedOutputsUnchanged").GetBoolean());
        var directory = Path.Combine(fixtures, "package-expanded");
        string Hash(string file) => Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(file)));
        using var imported = JsonDocument.Parse(File.ReadAllText(Path.Combine(fixtures, "package-final-snapshot.json")));
        Assert.Equal(1, imported.RootElement.GetProperty("version").GetInt32());
        var artifacts = imported.RootElement.GetProperty("artifacts").EnumerateArray().ToArray();
        Assert.Equal(166, imported.RootElement.GetProperty("artifactCount").GetInt32());
        Assert.Equal(166, artifacts.Length);
        Assert.Equal(166, artifacts.Select(file => file.GetProperty("file").GetString()).Distinct().Count());
        foreach (var artifact in artifacts)
        {
            var relative = artifact.GetProperty("file").GetString()!;
            Assert.StartsWith("Fixtures\\package-", relative);
            Assert.DoesNotContain("..", relative.Split('\\'));
            Assert.Equal(artifact.GetProperty("sha256").GetString(),
                Hash(Path.Combine(AppContext.BaseDirectory, Path.Combine(relative.Split('\\')))));
        }
        Assert.Equal(record.GetProperty("expandedEvidenceSha256").GetString(),
            Hash(Path.Combine(directory, "expanded-pk-evidence.json")));
        Assert.Equal(record.GetProperty("matrixValidatorSha256").GetString(),
            Hash(Path.Combine(directory, "matrix-validator.ps1.txt")));
        Assert.Equal(record.GetProperty("repositoryWorker").GetProperty("logSha256").GetString(),
            Hash(Path.Combine(fixtures, "package-final-repository-worker.log.txt")));
        Assert.Equal(cases.RootElement.GetProperty("provenanceSha256").GetString(),
            Hash(Path.Combine(fixtures, "package-final-provenance.json")));
        var byOriginal = artifacts.GroupBy(item => item.GetProperty("original").GetString()!, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(group => group.Key, group => group.Last().GetProperty("file").GetString()!, StringComparer.OrdinalIgnoreCase);
        foreach (var artifact in record.GetProperty("artifacts").EnumerateArray())
            Assert.Equal(artifact.GetProperty("sha256").GetString(),
                Hash(Path.Combine(AppContext.BaseDirectory, Path.Combine(byOriginal[artifact.GetProperty("path").GetString()!].Split('\\')))));
        using var expanded = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "expanded-pk-evidence.json")));
        var matrix = expanded.RootElement;
        Assert.Equal("passed", matrix.GetProperty("outcome").GetString());
        Assert.Empty(matrix.GetProperty("failedChecks").EnumerateArray());
        Assert.Equal(97, matrix.GetProperty("commands").GetArrayLength());
        Assert.Equal(39, matrix.GetProperty("cases").GetArrayLength());
        foreach (var name in new[] { "packageSha256", "runtimeSha256", "compilerSha256" })
            Assert.Equal(cases.RootElement.GetProperty(name).GetString(), matrix.GetProperty(name).GetString());
        Assert.Equal(97, matrix.GetProperty("commands").EnumerateArray()
            .Select(item => item.GetProperty("log").GetString()).Distinct().Count());
        foreach (var command in matrix.GetProperty("commands").EnumerateArray())
        {
            var original = command.GetProperty("log").GetString()!;
            var expectedHash = command.GetProperty("logSha256").GetString();
            Assert.Equal(expectedHash, Hash(Path.Combine(directory, "logs", original.Split('\\').Last())));
        }
        foreach (var fixture in matrix.GetProperty("fixtureSha256").EnumerateObject())
        {
            var parts = fixture.Name.Split("\\MatrixFixtures\\", StringSplitOptions.None);
            var snapshot = parts.Length == 2
                ? Path.Combine(directory, "MatrixFixtures", Path.Combine(parts[1].Split('\\')))
                : Path.Combine(directory, "Consumer.Program.cs.txt");
            if (parts.Length != 2)
                Assert.EndsWith("\\Consumer\\Program.cs", fixture.Name);
            Assert.Equal(fixture.Value.GetString(), Hash(snapshot));
        }
        var counterSource = Path.Combine(directory, "Consumer.Program.cs.txt");
        Assert.Equal(packageCases["PK02"].GetProperty("details").GetProperty("consumerSourceSha256").GetString(), Hash(counterSource));
        var counterChecks = packageCases["PK02"].GetProperty("checks").EnumerateArray().Select(item => item.GetString()).ToArray();
        Assert.Contains("Zero reads at the first expression-body operation through serialization", counterChecks);
        Assert.Contains("Positive counter control observes one read", counterChecks);
        Assert.Contains("observedSource.OutputReads != 0", File.ReadAllText(counterSource));
        Assert.Contains("observedSource.OutputReads != 1", File.ReadAllText(counterSource));
        VerifyActualIdeEvidence(fixtures, record, cases.RootElement, byOriginal);
    }

    private static void VerifyActualIdeEvidence(string fixtures, JsonElement packageProvenance, JsonElement package,
        IReadOnlyDictionary<string, string> snapshots)
    {
        var directory = Path.Combine(fixtures, "package-ide");
        string Hash(string file) => Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(file)));
        Assert.Equal(packageProvenance.GetProperty("actualIdeSha256").GetString(), Hash(Path.Combine(directory, "provenance.json")));
        using var provenance = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "provenance.json")));
        using var observations = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "actual-ide-evidence.json")));
        var record = provenance.RootElement;
        var ide = observations.RootElement;
        Assert.Equal("passed", record.GetProperty("status").GetString());
        Assert.Equal("passed", ide.GetProperty("status").GetString());
        Assert.Equal("actual-vscode-extension-host-validation", ide.GetProperty("evidenceKind").GetString());
        Assert.Equal("1.137.0", ide.GetProperty("vscodeVersion").GetString());
        Assert.Equal("ms-dotnettools.csharp", ide.GetProperty("extension").GetProperty("id").GetString());
        Assert.Equal("2.160.4", ide.GetProperty("extension").GetProperty("version").GetString());
        foreach (var name in new[] { "packageSha256", "runtimeSha256", "compilerSha256" })
            Assert.Equal(package.GetProperty(name).GetString(), record.GetProperty(name).GetString());
        foreach (var artifact in record.GetProperty("artifacts").EnumerateArray())
            Assert.Equal(artifact.GetProperty("sha256").GetString(),
                Hash(Path.Combine(AppContext.BaseDirectory, Path.Combine(snapshots[artifact.GetProperty("path").GetString()!].Split('\\')))));
        Assert.Equal(0, record.GetProperty("restore").GetProperty("exitCode").GetInt32());
        Assert.Equal(0, record.GetProperty("launch").GetProperty("exitCode").GetInt32());
        Assert.Contains("--extensionTestsPath", record.GetProperty("launch").GetProperty("argv").EnumerateArray().Select(item => item.GetString()));
        var sourcePath = Path.Combine(directory, "LanguageServiceFixture", "Program.cs");
        Assert.Equal(ide.GetProperty("sourceSha256").GetString()!.ToUpperInvariant(), Hash(sourcePath));
        var broken = File.ReadAllText(sourcePath).Replace("+ suffix", "+ missingName", StringComparison.Ordinal);
        var index = broken.IndexOf("missingName", StringComparison.Ordinal);
        Assert.True(index >= 0);
        var prefix = broken[..index].Split('\n');
        foreach (var stage in new[] { "beforeBuild", "afterBuild" })
        {
            Assert.Equal("Compose", ide.GetProperty(stage + "HoverWord").GetString());
            Assert.Contains("WorkflowBuiltInActions.Compose(Func<string> inputs)", ide.GetProperty(stage + "Hover").GetRawText());
            foreach (var label in new[] { "Compose", "ToUpperInvariant" })
                Assert.Contains(ide.GetProperty(stage + label + "Completion").EnumerateArray(), item => item.GetProperty("label").GetString() == label);
            var error = Assert.Single(ide.GetProperty(stage + "InvalidDiagnostics").EnumerateArray(),
                item => item.GetProperty("severity").GetInt32() == 0);
            Assert.Equal("CS0103", error.GetProperty("code").GetString());
            Assert.EndsWith("/LanguageServiceFixture/Program.cs", new Uri(error.GetProperty("uri").GetString()!).AbsolutePath);
            var range = error.GetProperty("range");
            Assert.Equal(prefix.Length - 1, range.GetProperty("start").GetProperty("line").GetInt32());
            Assert.Equal(prefix[^1].Length, range.GetProperty("start").GetProperty("character").GetInt32());
            Assert.Equal(prefix[^1].Length + "missingName".Length, range.GetProperty("end").GetProperty("character").GetInt32());
        }
        var commands = ide.GetProperty("commands").EnumerateArray().ToArray();
        Assert.Equal(3, commands.Length);
        Assert.All(commands, command => Assert.Equal(0, command.GetProperty("exitCode").GetInt32()));
        Assert.Equal("vscode.tasks.executeTask", commands[0].GetProperty("surface").GetString());
        Assert.Equal("@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant() + \"!\"}\r\n",
            commands[1].GetProperty("stdout").GetString());
        Assert.Equal("counter-control", commands[2].GetProperty("argv").EnumerateArray().Last().GetString());
        Assert.Equal("read\n", File.ReadAllText(Path.Combine(directory, "authoring-executed.txt")));
        Assert.Contains("Built application emits exact CB01 without getter execution; explicit getter positive control writes one entry.",
            ide.GetProperty("checks").EnumerateArray().Select(item => item.GetString()));
    }

    private static HashSet<(string Id, string Test)> DiscoverMappedTests()
    {
        var result = new HashSet<(string, string)>();
        foreach (var type in typeof(CatalogCoverageTests).Assembly.GetTypes())
        foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            var traits = method.CustomAttributes.Where(a => a.AttributeType == typeof(TraitAttribute));
            foreach (var attribute in traits.Where(a => (string?)a.ConstructorArguments[0].Value == "Catalog"))
                result.Add(((string)attribute.ConstructorArguments[1].Value!, type.Name + "." + method.Name));

            foreach (var attribute in method.GetCustomAttributes<InlineDataAttribute>())
            {
                var data = attribute.GetData(method).Single();
                if (data?.FirstOrDefault() is string id && Regex.IsMatch(id, @"^[A-Z]+[0-9]+[a-z]?$"))
                    result.Add((id, type.Name + "." + method.Name));
            }
        }

        return result;
    }
}
