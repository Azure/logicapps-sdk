namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Reflection;
using System.Runtime.Loader;
using System.Security.Cryptography;
using System.Text.Json;
using Microsoft.Azure.Workflows.Sdk.Build;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class DeploymentContractTests : IDisposable
{
    private readonly string directory = Path.Combine("out", "test-workspaces", "WorkflowDeploymentTests-" + Guid.NewGuid().ToString("N"));

    public DeploymentContractTests() => Directory.CreateDirectory(directory);

    [Theory]
    [InlineData(false, "null")]
    [InlineData(false, "{\"sources\":[]}")]
    [InlineData(true, "null")]
    [InlineData(true, "{\"version\":99}")]
    [InlineData(true, "{\"version\":1,\"dependencies\":null}")]
    public void Invalid_CLI_manifests_return_failure_instead_of_throwing(bool deployment, string json)
    {
        var path = Path.Combine(directory, "invalid.json");
        File.WriteAllText(path, json);
        string[] arguments = deployment
            ? ["validate-deployment", path, directory]
            : [path, Path.Combine(directory, "compiled")];

        var exitCode = typeof(ExpressionCompilationTransformer).Assembly.EntryPoint!
            .Invoke(null, [arguments]);

        Assert.Equal(1, Assert.IsType<int>(exitCode));
        Assert.False(File.Exists(Path.Combine(directory, "compiled", "compiled-files.txt")));
    }

    [Fact, Trait("Catalog", "SC03"), Trait("Catalog", "SC07")]
    public void Discovered_approved_packaged_helper_executes_the_string_overload_once()
    {
        var (manifest, path, code) = PrepareHelper();
        Assert.Contains(manifest.Dependencies, d => d.MetadataTypeName == "UserFormatting" && d.Member == "Wrap");
        Assert.Empty(WorkflowDeploymentValidator.Validate(manifest, directory, Approve(path)));

        var context = new AssemblyLoadContext("WorkflowApprovedHost-" + Guid.NewGuid(), isCollectible: true);
        try
        {
            using var consumerBytes = new MemoryStream(File.ReadAllBytes(path));
            var consumer = context.LoadFromStream(consumerBytes);
            var probe = Compile($$"""
                using Newtonsoft.Json.Linq;
                public static class Probe
                {
                    public static object Run()
                    {
                        JToken outputs(string name) => new JValue("A");
                        return {{NativeBody(code)}};
                    }
                }
                """).AddReferences(MetadataReference.CreateFromFile(path));
            using var bytes = new MemoryStream();
            var emitted = probe.Emit(bytes);
            Assert.True(emitted.Success, string.Join(Environment.NewLine, emitted.Diagnostics));
            bytes.Position = 0;
            var host = context.LoadFromStream(bytes);
            Assert.Equal("[A]", host.GetType("Probe")!.GetMethod("Run")!.Invoke(null, null));
            Assert.Equal(1, consumer.GetType("UserFormatting")!.GetField("StringCalls")!.GetValue(null));
            Assert.Equal(0, consumer.GetType("UserFormatting")!.GetField("ObjectCalls")!.GetValue(null));
        }
        finally
        {
            context.Unload();
        }
    }

    [Fact, Trait("Catalog", "SC03b")]
    public void Unapproved_helper_blocks_deployment_without_loading_or_invoking_it()
    {
        var (manifest, _, _) = PrepareHelper();
        var error = Assert.Single(WorkflowDeploymentValidator.Validate(manifest, directory, LocalHostProfile()));
        Assert.Equal("WFDEP002", error.Code);
        Assert.Contains(manifest.AssemblyName, error.Message);
        Assert.Contains("UserFormatting", error.Message);
    }

    [Fact]
    public void SDK_helpers_require_host_approval_even_when_the_authoring_worker_references_the_SDK()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose(inputs: () => WorkflowWireRuntime.ToCompactJson(count.Output))
                .GetActionDefinition("SdkDependency");
            """));
        WriteWorkflow(new JObject { ["actions"] = new JObject
        {
            ["Serialize"] = JToken.Parse(result.Definition.ToJson()),
        } });
        var manifest = new WorkflowDependencyManifest
        {
            Dependencies = result.Transformation.Dependencies.ToArray(),
        };

        Assert.Contains(WorkflowDeploymentValidator.Validate(manifest, directory, LocalHostProfile()),
            d => d.Code == "WFDEP002" && d.Message.Contains("Microsoft.Azure.Workflows.Sdk", StringComparison.Ordinal));
    }

    [Fact]
    public void Generated_connector_body_interpolation_preserves_JSON_without_a_model_dependency()
    {
        var result = Build(Source("""
            var weather = new MsnweatherActions("connection")
                .CurrentWeather(() => "98058", () => unitsInput.Imperial).WithName("Weather");
            return WorkflowActions.BuiltIn.Response(responseBody: () => $"{weather.Body}" + "something")
                .GetActionDefinition("Response");
            """, imports: "using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;"));
        EqualSource("""
            #{$"{body("Weather").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create())}" + "something"}
            """, Token(result.Definition)["body"]!.Value<string>()!);
        var weather = JObject.Parse("""{"responses":{"source":{"location":"98058"}},"unknown":[1,true,null]}""");
        Assert.Equal(weather.ToString() + "something", LocalNativeHost.Evaluate(
            Token(result.Definition)["body"]!.Value<string>()!, new() { ["Weather"] = weather }).Value);
        var manifest = new WorkflowDependencyManifest
        {
            Dependencies = result.Transformation.Dependencies.ToArray(),
        };
        Assert.DoesNotContain(manifest.Dependencies, dependency =>
            dependency.MetadataTypeName == "Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather.CurrentWeather");
        WriteWorkflow(new JObject { ["actions"] = new JObject
        {
            ["Response"] = JToken.Parse(result.Definition.ToJson()),
        } });
        Assert.DoesNotContain(WorkflowDeploymentValidator.Validate(manifest, directory, LocalHostProfile()),
            diagnostic => diagnostic.Message.Contains("Msnweather.CurrentWeather", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("ToCompactJson(null)")]
    [InlineData("NormalizeAndEncode(null, \"{}\")")]
    [InlineData("RequireEnumWire(\"a\", null, true, \"value\")")]
    public void Generated_SDK_helpers_without_dependency_records_cannot_bypass_preflight(string call)
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Encode"] = new JObject
        {
            ["type"] = "Compose",
            ["inputs"] = "#{global::Microsoft.Azure.Workflows.Sdk.WorkflowWireRuntime." + call + "}",
        } } });
        var error = Assert.Single(WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile()));
        Assert.Equal("WFDEP003", error.Code);
        Assert.Contains("worker-side SDK deployment alone", error.Message);
    }

    [Fact]
    public void A_native_string_describing_an_SDK_helper_is_not_a_helper_dependency()
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Text"] = new JObject
        {
            ["type"] = "Compose",
            ["inputs"] = "#{\"global::Microsoft.Azure.Workflows.Sdk.WorkflowWireRuntime.ToCompactJson(null)\"}",
        } } });
        Assert.Empty(WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile()));
    }

    [Theory]
    [InlineData("@outputs('Source')")]
    [InlineData("@body('Source')")]
    [InlineData("@variables('message')")]
    [InlineData("@triggerBody()")]
    [InlineData("@triggerOutputs()")]
    [InlineData("@item()")]
    [InlineData("@agentparameters('Name')")]
    [InlineData("@base64('hello')")]
    [InlineData("@json('{}')")]
    [InlineData("@encodeURIComponent('a b')")]
    [InlineData("@listCallbackUrl()")]
    [InlineData("@{outputs('Source')}")]
    [InlineData("Name: @{outputs('Source')}")]
    [InlineData("/items/@{encodeURIComponent(outputs('Source'))}")]
    [InlineData("@csharp{1 + 2}")]
    [InlineData("@csharp{outputs(\"Source\")}")]
    public void Legacy_template_expressions_in_nested_inputs_are_rejected_by_preflight(string expression)
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Legacy"] = new JObject
        {
            ["type"] = "Compose",
            ["inputs"] = new JObject { ["values"] = new JArray(expression) },
        } } });
        var error = Assert.Single(WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile()));
        Assert.Equal("WFDEP010", error.Code);
        Assert.Contains("Standalone template expressions and template interpolation are unsupported", error.Message);
    }

    [Theory]
    [InlineData("actions", "Foreach", "foreach")]
    [InlineData("triggers", "ApiConnection", "splitOn")]
    public void Legacy_templates_outside_operation_inputs_are_also_rejected(string container, string type, string property)
    {
        WriteWorkflow(new JObject { [container] = new JObject { ["Legacy"] = new JObject
        {
            ["type"] = type,
            [property] = "@triggerBody()",
        } } });
        Assert.Equal("WFDEP010", Assert.Single(
            WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile())).Code);
    }

    [Theory]
    [InlineData("@@outputs('Source')")]
    [InlineData("@@{outputs('Source')}")]
    [InlineData("@@csharp{1 + 2}")]
    [InlineData("@@@already")]
    [InlineData("@@")]
    public void Escaped_leading_markers_are_literals_not_legacy_template_expressions(string literal)
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Literal"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = literal,
        } } });
        var profile = LocalHostProfile();
        profile.LiteralMarkerEscapingVerified = true;
        Assert.Empty(WorkflowDeploymentValidator.Validate(new(), directory, profile));
    }

    [Theory]
    [InlineData("#{\"@outputs('Source')\"}")]
    [InlineData("#{\"prefix @{outputs('Source')}\"}")]
    [InlineData("#{\"@listCallbackUrl()\"}")]
    [InlineData("#{\"@json('{}')\"}")]
    [InlineData("#{\"@csharp{1 + 2}\"}")]
    [InlineData("#{\"#r \\\"fixture.dll\\\"\"}")]
    [InlineData("#{\"#load \\\"fixture.csx\\\"\"}")]
    public void Native_quoted_template_looking_text_is_not_rejected_as_legacy_syntax(string expression)
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["NativeLiteral"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = expression,
        } } });
        Assert.Empty(WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile()));
    }

    [Theory]
    [InlineData("#r \"fixture.dll\"")]
    [InlineData("#load \"fixture.csx\"")]
    [InlineData("  #r \"fixture.dll\"")]
    [InlineData("#load \"fixture.csx\"\r\n")]
    public void Native_reference_and_load_directives_are_rejected_without_resolving_files(string directive)
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Directive"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = "#{\n" + directive + "\n1\n}",
        } } });
        var diagnostics = WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile());
        Assert.Contains(diagnostics, diagnostic => diagnostic.Code == "WFDEP006" &&
            diagnostic.Message == "Native expressions cannot use #r or #load directives.");
        Assert.All(diagnostics, diagnostic => Assert.Equal("WFDEP006", diagnostic.Code));
    }

    [Theory]
    [InlineData("#{}")]
    [InlineData("#{ }")]
    [InlineData("#{\r\n\t}")]
    public void Empty_or_whitespace_native_bodies_are_rejected(string expression)
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Empty"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = expression,
        } } });
        var diagnostics = WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile());
        Assert.NotEmpty(diagnostics);
        Assert.All(diagnostics, diagnostic => Assert.Equal("WFDEP006", diagnostic.Code));
    }

    [Theory]
    [InlineData("##{1 + 2}")]
    [InlineData("###{}")]
    [InlineData(" #{1 + 2}")]
    [InlineData("\t#{1 + 2}")]
    [InlineData("prefix #{1 + 2}")]
    public void Non_envelope_hash_literals_are_not_trimmed_interpolated_or_treated_as_escapes(string literal)
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Literal"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = literal,
        } } });
        Assert.Empty(WorkflowDeploymentValidator.Validate(new(), directory));
    }

    [Fact]
    public void Reserved_hash_literal_uses_native_string_expression_and_requires_native_host_capability()
    {
        var literal = Input("\"#{1 + 2}\"")!;
        Assert.Equal("#{\"#{1 + 2}\"}", literal.Value<string>());
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Literal"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = literal,
        } } });
        Assert.Equal("WFDEP009", Assert.Single(WorkflowDeploymentValidator.Validate(new(), directory)).Code);
        Assert.Empty(WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile()));
    }

    [Fact, Trait("Catalog", "SC04"), Trait("Catalog", "DG05")]
    public void Approved_but_missing_helper_is_not_a_successful_deployment()
    {
        var (manifest, path, _) = PrepareHelper();
        var profile = Approve(path);
        File.Delete(path);
        var error = Assert.Single(WorkflowDeploymentValidator.Validate(manifest, directory, profile));
        Assert.Equal("WFDEP003", error.Code);
        Assert.Contains("Missing deployed assembly", error.Message);
        Assert.Contains("UserFormatting", error.Message);
    }

    [Fact, Trait("Catalog", "F05")]
    public void Native_compilation_without_the_Money_assembly_identifies_the_missing_type()
    {
        var expression = Native("new Money(amount.Output)", CoreHandles);
        var host = Compile($$"""
            using Newtonsoft.Json.Linq;
            public static class Probe
            {
                public static object Run()
                {
                    JToken outputs(string name) => new JValue(1m);
                    return {{NativeBody(expression)}};
                }
            }
            """);
        Assert.Contains(host.GetDiagnostics(), d => d.Severity == DiagnosticSeverity.Error &&
            d.GetMessage().Contains("Money", StringComparison.Ordinal));
    }

    [Fact, Trait("Catalog", "F08b"), Trait("Catalog", "DG07")]
    public void Unverified_literal_marker_transport_blocks_deployment()
    {
        var value = Assert.IsType<JValue>(Input("\"@csharp{1 + 2}\""));
        Assert.Equal("@@csharp{1 + 2}", value.Value<string>());
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Literal"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = value,
        } } });
        var error = Assert.Single(WorkflowDeploymentValidator.Validate(new(), directory));
        Assert.Equal("WFDEP004", error.Code);
    }

    [Fact, Trait("Catalog", "I04b")]
    public void Unverified_native_Condition_capability_blocks_deployment_without_rewriting_it()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Control.Condition(expression: () => count.Output == 3,
                trueBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "yes"),
                falseBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "no")).GetActionDefinition("Catalog");
            """));
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Check"] = JToken.Parse(result.Definition.ToJson()) } });
        var error = Assert.Single(WorkflowDeploymentValidator.Validate(new(), directory, LocalHostProfile()));
        Assert.Equal("WFDEP005", error.Code);
        Assert.StartsWith("#{", result.Definition.Expression.Value<string>());
    }

    [Fact]
    public void Hash_mismatch_empty_artifacts_and_invalid_capability_claims_fail_explicitly()
    {
        Assert.Equal("WFDEP007", Assert.Single(WorkflowDeploymentValidator.Validate(new(), directory)).Code);
        var (manifest, path, _) = PrepareHelper();
        var profile = Approve(path);
        profile.ApprovedDependencies[0].Sha256 = new string('0', 64);
        Assert.Contains(WorkflowDeploymentValidator.Validate(manifest, directory, profile), d => d.Code == "WFDEP003");
        profile.NativeConditionsVerified = true;
        profile.Evidence = "";
        Assert.Equal("WFDEP001", Assert.Single(WorkflowDeploymentValidator.Validate(manifest, directory, profile)).Code);
    }

    [Fact]
    public void Plain_literals_do_not_turn_type_names_into_native_dependencies()
    {
        var (manifest, _, _) = PrepareHelper();
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Literal"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = "UserFormatting.Wrap is literal documentation",
        } } });
        Assert.Empty(WorkflowDeploymentValidator.Validate(manifest, directory));
    }

    [Fact]
    public void Validation_never_loads_an_approved_assembly_with_a_throwing_module_initializer()
    {
        var (manifest, path, _) = PrepareHelper("""
            public static class NeverExecuteDuringValidation
            {
                [System.Runtime.CompilerServices.ModuleInitializer]
                public static void Initialize() => throw new System.InvalidOperationException("Module executed");
            }
            """, generateDefinition: false);
        Assert.Empty(WorkflowDeploymentValidator.Validate(manifest, directory, Approve(path)));
    }

    private (WorkflowDependencyManifest Manifest, string Path, string Code) PrepareHelper(string extra = "", bool generateDefinition = true)
    {
        var original = Compile(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<string>(input: () => UserFormatting.Wrap(source.Output)).GetActionDefinition("Catalog");
            """) + """
            public static class UserFormatting
            {
                public static int StringCalls;
                public static int ObjectCalls;
                public static string Wrap(string value) { StringCalls++; return "[" + value + "]"; }
                public static string Wrap(object value) { ObjectCalls++; return "WRONG"; }
            }
            """ + extra);
        var transformed = ExpressionCompilationTransformer.Transform(original);
        Assert.Empty(transformed.Diagnostics);
        var rewritten = original.RemoveAllSyntaxTrees().AddSyntaxTrees(
            CSharpSyntaxTree.ParseText(transformed.Sources["Consumer.cs"], (CSharpParseOptions)original.SyntaxTrees.Single().Options));
        var path = Path.Combine(directory, original.AssemblyName + ".dll");
        var emitted = rewritten.Emit(path);
        Assert.True(emitted.Success, string.Join(Environment.NewLine, emitted.Diagnostics));
        var code = "#{global::UserFormatting.Wrap(outputs(\"Source\").ToObject<string>())}";
        if (generateDefinition)
        {
            var assembly = Load(rewritten);
            var definition = (FlowTemplateAction)Invoke(assembly, "Consumer", "Build")!;
            code = Token(definition).Value<string>()!;
            Assert.Equal(0, assembly.GetType("UserFormatting")!.GetField("StringCalls")!.GetValue(null));
            Assert.Equal(0, assembly.GetType("UserFormatting")!.GetField("ObjectCalls")!.GetValue(null));
        }
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Call"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = code,
        } } });
        return (new WorkflowDependencyManifest
        {
            AssemblyName = original.AssemblyName!,
            Dependencies = transformed.Dependencies.ToArray(),
        }, path, code);
    }

    private WorkflowHostProfile Approve(string path) => new()
    {
        Host = "Local Roslyn test host",
        Evidence = "DeploymentContractTests: not Logic Apps backend certification",
        NativeExpressionsVerified = true,
        ApprovedDependencies =
        [
            new WorkflowApprovedDependency
            {
                Assembly = AssemblyName.GetAssemblyName(path).Name!,
                Sha256 = Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path))),
            },
        ],
    };

    private static WorkflowHostProfile LocalHostProfile() => new()
    {
        Host = "Local Roslyn test host",
        Evidence = "DeploymentContractTests: not Logic Apps backend certification",
        NativeExpressionsVerified = true,
    };

    [Fact]
    public void Unverified_expression_host_blocks_even_dependency_free_native_code()
    {
        WriteWorkflow(new JObject { ["actions"] = new JObject { ["Native"] = new JObject
        {
            ["type"] = "Compose", ["inputs"] = "#{1 + 2}",
        } } });
        Assert.Equal("WFDEP009", Assert.Single(WorkflowDeploymentValidator.Validate(new(), directory)).Code);
    }

    private void WriteWorkflow(JObject definition) =>
        File.WriteAllText(Path.Combine(directory, "workflow.json"), definition.ToString());

    public void Dispose() => Directory.Delete(directory, recursive: true);
}
