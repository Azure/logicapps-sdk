// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.Azure.Workflows.Sdk.Build;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public sealed class SchemaGeneratorTests
{
    [Fact]
    public void Catalog_generates_deterministic_syntax_and_real_SDK_boundaries_without_invoking_delegates()
    {
        var schema = Fixture();
        var files = WorkflowSchemaGenerator.Generate(schema);
        Assert.Equal(new[] { "PayloadModel.g.cs", "CatalogDestinations.g.cs" }, files.Keys);
        Assert.Equal(files.ToArray(), WorkflowSchemaGenerator.Generate(schema).ToArray());
        foreach (var file in files)
            Assert.Empty(CSharpSyntaxTree.ParseText(file.Value).GetDiagnostics());

        var api = CSharpSyntaxTree.ParseText(files["CatalogDestinations.g.cs"]).GetRoot();
        using var document = JsonDocument.Parse(schema);
        var operations = document.RootElement.GetProperty("operations").EnumerateArray().ToArray();
        var methods = api.DescendantNodes().OfType<MethodDeclarationSyntax>().ToArray();
        Assert.Equal(operations.Length, methods.Length);
        foreach (var operation in operations)
        {
            var method = Assert.Single(methods, m => m.Identifier.ValueText == operation.GetProperty("name").GetString());
            Assert.Equal("global::Microsoft.Azure.Workflows.Sdk.ComposeAction<global::Newtonsoft.Json.Linq.JToken>",
                method.ReturnType.ToString());
            var call = Assert.IsType<InvocationExpressionSyntax>(method.ExpressionBody!.Expression);
            Assert.StartsWith("global::Microsoft.Azure.Workflows.Sdk.WorkflowSchemaRuntime.", call.Expression.ToString());
            Assert.Single(method.DescendantNodes().OfType<InvocationExpressionSyntax>());
            Assert.Empty(method.DescendantNodes().OfType<LambdaExpressionSyntax>());
            Assert.Null(method.Body);
            var parameters = operation.GetProperty("parameters").EnumerateArray().ToArray();
            Assert.Equal(parameters.Length, method.ParameterList.Parameters.Count);
            for (var index = 0; index < parameters.Length; index++)
            {
                var parameter = method.ParameterList.Parameters[index];
                Assert.Equal(parameters[index].GetProperty("name").GetString(), parameter.Identifier.ValueText);
                Assert.Equal("null", parameter.Default!.Value.ToString());
                var attributes = parameter.AttributeLists.SelectMany(a => a.Attributes).ToArray();
                Assert.Equal(2, attributes.Length);
                Assert.Equal("global::Microsoft.Azure.Workflows.Sdk.WorkflowExpressionAttribute", attributes[0].Name.ToString());
                Assert.Equal("global::Microsoft.Azure.Workflows.Sdk.WorkflowDestinationAttribute", attributes[1].Name.ToString());
                var literal = Assert.IsType<LiteralExpressionSyntax>(attributes[1].ArgumentList!.Arguments[0].Expression);
                Assert.Equal(parameters[index].GetProperty("schema").GetRawText(), literal.Token.ValueText);
                Assert.Contains(call.DescendantNodes().OfType<LiteralExpressionSyntax>(),
                    item => item.Token.ValueText == literal.Token.ValueText);
            }
        }
        Assert.Contains("Object(new string[] { \"name\", \"count\", \"label\" }", files["CatalogDestinations.g.cs"]);
        Assert.Contains("Object(new string[] { \"ContentData\", \"ContentType\", \"Label\" }", files["CatalogDestinations.g.cs"]);
        Assert.Contains("Path(\"/items/{0}/{1}\"", files["CatalogDestinations.g.cs"]);
    }

    [Fact]
    public void Model_carries_exact_authoritative_schema_wire_names_and_only_explicit_defaults()
    {
        var fixture = Fixture();
        var source = WorkflowSchemaGenerator.Generate(fixture)["PayloadModel.g.cs"];
        var model = Assert.Single(CSharpSyntaxTree.ParseText(source).GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>());
        Assert.Contains(model.Modifiers, m => m.IsKind(SyntaxKind.SealedKeyword));
        Assert.Empty(model.Members.OfType<ConstructorDeclarationSyntax>());
        var attribute = Assert.Single(model.AttributeLists.SelectMany(a => a.Attributes));
        Assert.Equal("global::Microsoft.Azure.Workflows.Sdk.WorkflowModelSchemaAttribute", attribute.Name.ToString());
        Assert.Equal("1", attribute.ArgumentList!.Arguments[0].Expression.ToString());
        using var document = JsonDocument.Parse(fixture);
        Assert.Equal(document.RootElement.GetProperty("models")[0].GetProperty("schema").GetRawText(),
            Assert.IsType<LiteralExpressionSyntax>(attribute.ArgumentList.Arguments[1].Expression).Token.ValueText);
        var name = Assert.Single(model.Members.OfType<PropertyDeclarationSyntax>(), p => p.Identifier.ValueText == "Name");
        Assert.Null(name.Initializer);
        Assert.Equal("string", name.Type.ToString());
        Assert.Equal("display_name", Assert.IsType<LiteralExpressionSyntax>(
            name.AttributeLists[0].Attributes[0].ArgumentList!.Arguments[0].Expression).Token.ValueText);
        var enabled = Assert.Single(model.Members.OfType<PropertyDeclarationSyntax>(), p => p.Identifier.ValueText == "Enabled");
        Assert.Equal("bool", enabled.Type.ToString());
        Assert.Equal("true", enabled.Initializer!.Value.ToString());
    }

    [Theory]
    [InlineData("version", "version")]
    [InlineData("missing-models", "models")]
    [InlineData("namespace", "identifier")]
    [InlineData("class", "identifier")]
    [InlineData("reserved-file", "file name")]
    [InlineData("duplicate-model", "Duplicate")]
    [InlineData("file-collision", "collision")]
    [InlineData("duplicate-operation", "Duplicate")]
    [InlineData("duplicate-parameter", "Duplicate")]
    [InlineData("type-injection", "unsafe")]
    [InlineData("parameter-injection", "identifier")]
    [InlineData("missing-transforms", "content")]
    [InlineData("node-version", "content")]
    [InlineData("unknown-kind", "content")]
    [InlineData("unknown-property", "content")]
    [InlineData("bad-nullable", "content")]
    [InlineData("empty-destination", "destination")]
    [InlineData("repeated-base64", "content")]
    [InlineData("reversed-transforms", "content")]
    [InlineData("unknown-transform", "content")]
    [InlineData("unsupported-pass-through", "content")]
    [InlineData("missing-profile", "content")]
    [InlineData("unknown-profile", "content")]
    [InlineData("value-arity", "exactly one")]
    [InlineData("misplaced-path", "Only path")]
    [InlineData("path-order", "placeholders")]
    [InlineData("path-count", "count")]
    [InlineData("path-format", "placeholders")]
    [InlineData("path-brace", "brace")]
    [InlineData("missing-enum-policy", "content")]
    [InlineData("duplicate-enum-value", "content")]
    [InlineData("missing-enum-values", "content")]
    [InlineData("member-conflict", "payload")]
    [InlineData("missing-items", "items")]
    [InlineData("misplaced-clr", "content")]
    [InlineData("missing-clr", "PayloadModel")]
    [InlineData("duplicate-clr", "PayloadModel")]
    [InlineData("non-scalar-default", "PayloadModel")]
    [InlineData("wrong-default", "PayloadModel")]
    [InlineData("null-default", "PayloadModel")]
    [InlineData("lossy-default", "PayloadModel")]
    [InlineData("runtime-object-kind", "content")]
    public void Invalid_metadata_is_rejected_by_mutating_the_real_schema(string mutation, string diagnostic)
    {
        var root = JsonNode.Parse(Fixture())!.AsObject();
        var operations = root["operations"]!.AsArray();
        var first = operations[0]!.AsObject();
        var parameters = first["parameters"]!.AsArray();
        var schema = parameters[0]!["schema"]!.AsObject();
        var model = root["models"]![0]!;
        var properties = model["schema"]!["properties"]!;
        JsonObject Operation(string name) => operations.Single(o => o!["name"]!.GetValue<string>() == name)!.AsObject();
        JsonObject Schema(string name) => Operation(name)["parameters"]![0]!["schema"]!.AsObject();
        switch (mutation)
        {
            case "version": root["version"] = 2; break;
            case "missing-models": root.Remove("models"); break;
            case "namespace": root["namespace"] = "Catalog; class Injected {}"; break;
            case "class": root["className"] = "class"; break;
            case "reserved-file": root["className"] = "CON"; break;
            case "duplicate-model": root["models"]!.AsArray().Add(model.DeepClone()); break;
            case "file-collision": root["className"] = "payloadmodel"; break;
            case "duplicate-operation": operations.Add(first.DeepClone()); break;
            case "duplicate-parameter": Operation("Fields")["parameters"]!.AsArray().Add(Operation("Fields")["parameters"]![0]!.DeepClone()); break;
            case "type-injection": parameters[0]!["type"] = "object> x) { throw null; } //"; break;
            case "parameter-injection": parameters[0]!["name"] = "x = null) => Evil("; break;
            case "missing-transforms": schema.Remove("transforms"); break;
            case "node-version": schema["version"] = 2; break;
            case "unknown-kind": schema["kind"] = "guess"; break;
            case "unknown-property": schema["encodeByName"] = true; break;
            case "bad-nullable": schema["nullable"] = "true"; break;
            case "empty-destination": schema["destination"] = ""; break;
            case "repeated-base64": schema["transforms"] = new JsonArray("base64", "base64"); break;
            case "reversed-transforms": schema["transforms"] = new JsonArray("url", "base64"); break;
            case "unknown-transform": schema["transforms"] = new JsonArray("encode"); break;
            case "unsupported-pass-through": schema["inputEncoding"] = "base64"; break;
            case "missing-profile": Schema("EncodeJson").Remove("serializerProfile"); break;
            case "unknown-profile": Schema("EncodeJson")["serializerProfile"] = "ambient"; break;
            case "value-arity": parameters.Clear(); break;
            case "misplaced-path": first["path"] = "/items/{0}"; break;
            case "path-order": Operation("Path")["path"] = "/items/{1}/{0}"; break;
            case "path-count": Operation("Path")["path"] = "/items/{0}"; break;
            case "path-format": Operation("Path")["path"] = "/items/{0:N}/{1}"; break;
            case "path-brace": Operation("Path")["path"] = "/items/{0}/{1}}"; break;
            case "missing-enum-policy": Schema("EncodeEnum").Remove("enumPolicy"); break;
            case "duplicate-enum-value": Schema("ClosedEnum")["enumValues"] = new JsonArray("a", "a"); break;
            case "missing-enum-values": Schema("ClosedEnum").Remove("enumValues"); break;
            case "member-conflict":
                Schema("Nested")["transforms"] = new JsonArray("base64");
                Schema("Nested")["serializerProfile"] = "compact-json-v1";
                break;
            case "missing-items": Schema("Nested")["properties"]!["items"]!.AsObject().Remove("items"); break;
            case "misplaced-clr": schema["clrName"] = "Content"; break;
            case "missing-clr": properties["enabled"]!.AsObject().Remove("clrType"); break;
            case "duplicate-clr": properties["enabled"]!["clrName"] = "Name"; break;
            case "non-scalar-default": properties["enabled"]!["default"] = new JsonObject(); break;
            case "wrong-default": properties["enabled"]!["default"] = "true"; break;
            case "null-default": properties["enabled"]!["default"] = null; break;
            case "lossy-default":
                properties["display_name"]!["kind"] = "any";
                properties["display_name"]!["clrType"] = "object";
                properties["display_name"]!["default"] = JsonNode.Parse("0.123456789012345678901234567890123");
                break;
            case "runtime-object-kind": schema["runtimeObject"] = true; break;
            default: throw new InvalidOperationException(mutation);
        }
        var error = Assert.Throws<InvalidDataException>(() => WorkflowSchemaGenerator.Generate(root.ToJsonString()));
        Assert.Contains(diagnostic, error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("\"version\": 1,", "\"version\": 1, \"version\": 1,")]
    [InlineData("\"nullable\": true,", "\"nullable\": true, \"nullable\": false,")]
    [InlineData("\"destination\": \"content\",", "\"destination\": \"content\", \"destination\": \"other\",")]
    public void Duplicate_JSON_keys_are_rejected_even_when_the_values_agree(string original, string replacement)
    {
        var error = Assert.Throws<InvalidDataException>(() => WorkflowSchemaGenerator.Generate(
            Fixture().Replace(original, replacement, StringComparison.Ordinal)));
        Assert.Contains("Duplicate JSON key", error.Message);
    }

    [Theory]
    [InlineData("")]
    [InlineData("null")]
    [InlineData("{")]
    [InlineData("[]")]
    public void Malformed_documents_produce_schema_diagnostics(string input)
    {
        Assert.Throws<InvalidDataException>(() => WorkflowSchemaGenerator.Generate(input));
    }

    [Theory]
    [InlineData("@csharp{Evil()}")]
    [InlineData("#{Evil()}")]
    public void Metadata_literals_round_trip_quotes_controls_and_expression_markers_without_source_injection(string marker)
    {
        var root = JsonNode.Parse(Fixture())!;
        var schema = root["operations"]![0]!["parameters"]![0]!["schema"]!;
        schema["destination"] = "\"\r\n\\\u2028" + marker + "\u2029";
        var files = WorkflowSchemaGenerator.Generate(root.ToJsonString());
        var syntax = CSharpSyntaxTree.ParseText(files["CatalogDestinations.g.cs"]);
        Assert.Empty(syntax.GetDiagnostics());
        var attribute = syntax.GetRoot().DescendantNodes().OfType<AttributeSyntax>()
            .First(a => a.Name.ToString().EndsWith("WorkflowDestinationAttribute", StringComparison.Ordinal));
        var literal = Assert.IsType<LiteralExpressionSyntax>(attribute.ArgumentList!.Arguments[0].Expression);
        Assert.Equal(schema.ToJsonString(), literal.Token.ValueText);
    }

    [Theory]
    [InlineData("string", "\"quoted\\ntext\"", "\"quoted\\ntext\"")]
    [InlineData("bool", "false", "false")]
    [InlineData("int", "-2147483648", "-2147483648")]
    [InlineData("object", "1.25", "1.25M")]
    [InlineData("string", "null", "null")]
    public void Explicit_scalar_model_defaults_use_safe_CSharp_literals(string type, string json, string expected)
    {
        var root = JsonNode.Parse(Fixture())!;
        var property = root["models"]![0]!["schema"]!["properties"]!["display_name"]!;
        property["clrType"] = type;
        property["kind"] = "any";
        property["default"] = JsonNode.Parse(json);
        var source = WorkflowSchemaGenerator.Generate(root.ToJsonString())["PayloadModel.g.cs"];
        Assert.Empty(CSharpSyntaxTree.ParseText(source).GetDiagnostics());
        var name = CSharpSyntaxTree.ParseText(source).GetRoot().DescendantNodes().OfType<PropertyDeclarationSyntax>()
            .Single(p => p.Identifier.ValueText == "Name");
        Assert.Equal(expected, name.Initializer!.Value.ToString());
    }

    [Theory]
    [InlineData("string")]
    [InlineData("bool")]
    [InlineData("int")]
    [InlineData("object")]
    [InlineData("byte[]")]
    [InlineData("System.Uri")]
    [InlineData("System.Net.Http.HttpMethod")]
    [InlineData("PayloadModel")]
    public void Only_explicitly_supported_parameter_types_are_rendered(string type)
    {
        var root = JsonNode.Parse(Fixture())!;
        root["operations"]![0]!["parameters"]![0]!["type"] = type;
        var source = WorkflowSchemaGenerator.Generate(root.ToJsonString())["CatalogDestinations.g.cs"];
        var expected = type.StartsWith("System.", StringComparison.Ordinal) ? "global::" + type : type;
        Assert.Contains($"global::System.Func<{expected}> content = null", source);
        Assert.Empty(CSharpSyntaxTree.ParseText(source).GetDiagnostics());
    }

    private static string Fixture([CallerFilePath] string sourceFile = "") =>
        File.ReadAllText(Path.Combine(Path.GetDirectoryName(sourceFile)!, "Fixtures", "catalog-destinations.schema.json"));
}
