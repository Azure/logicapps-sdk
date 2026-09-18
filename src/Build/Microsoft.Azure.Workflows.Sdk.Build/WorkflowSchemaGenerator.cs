// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using System.Text.Json;
using Microsoft.CodeAnalysis.CSharp;

/// <summary>Generates authoring APIs and model metadata from explicit, versioned destination schemas.</summary>
public static class WorkflowSchemaGenerator
{
    private const string Sdk = "global::Microsoft.Azure.Workflows.Sdk.";
    private static readonly HashSet<string> BuiltInTypes = new(StringComparer.Ordinal)
    {
        "string", "bool", "int", "object", "byte[]", "System.Uri", "System.Net.Http.HttpMethod",
    };

    /// <summary>Returns deterministic generated files without loading or executing authoring code.</summary>
    public static IReadOnlyDictionary<string, string> Generate(string schemaJson)
    {
        if (string.IsNullOrWhiteSpace(schemaJson))
            throw Error("$", "A schema document is required.");

        try
        {
            using var document = JsonDocument.Parse(schemaJson, new JsonDocumentOptions { MaxDepth = 128 });
            var root = document.RootElement;
            CheckDuplicates(root, "$");
            Object(root, "$", "version", "namespace", "className", "models", "operations");
            Version(root, "$");
            var ns = Text(root, "namespace", "$");
            foreach (var part in ns.Split('.'))
                Identifier(part, "$.namespace");
            var className = Text(root, "className", "$");
            Identifier(className, "$.className");
            FileName(className, "$.className");

            var models = Array(root, "models", "$");
            var operations = Array(root, "operations", "$");
            var modelNames = new HashSet<string>(StringComparer.Ordinal);
            var fileNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { className };
            foreach (var model in models.EnumerateArray())
            {
                Object(model, "$.models", "name", "schema");
                var name = Text(model, "name", "$.models");
                Identifier(name, "$.models.name");
                FileName(name, "$.models.name");
                if (!modelNames.Add(name) || !fileNames.Add(name))
                    throw Error(name, "Duplicate model name or generated file/class name collision.");
                if (BuiltInTypes.Contains(name))
                    throw Error(name, "A model name conflicts with a built-in type.");
            }

            var files = new Dictionary<string, string>(StringComparer.Ordinal);
            foreach (var model in models.EnumerateArray())
            {
                var name = Text(model, "name", "$.models");
                var schema = Required(model, "schema", name);
                ValidateNode(schema, name, modelNames, modelRoot: true);
                if (Text(schema, "kind", name) != "object")
                    throw Error(name, "A model schema must have kind 'object'.");
                var properties = Required(schema, "properties", name);
                var members = new HashSet<string>(StringComparer.Ordinal);
                var source = Header(ns);
                source.Append('[').Append(Sdk).Append("WorkflowModelSchemaAttribute(1, ")
                    .Append(Literal(schema.GetRawText())).AppendLine(")]");
                source.Append("public sealed class ").Append(name).AppendLine("\n{");
                foreach (var property in properties.EnumerateObject())
                {
                    var destination = Text(property.Value, "destination", name);
                    var clrName = Text(property.Value, "clrName", destination);
                    Identifier(clrName, destination);
                    if (!members.Add(clrName) || clrName == name)
                        throw Error(destination, "Duplicate CLR property name or property named after its containing model.");
                    var clrType = Type(Text(property.Value, "clrType", destination), modelNames, destination);
                    source.Append("    [global::Newtonsoft.Json.JsonPropertyAttribute(")
                        .Append(Literal(property.Name)).AppendLine(")]");
                    source.Append("    public ").Append(clrType).Append(' ').Append(clrName).Append(" { get; set; }");
                    if (property.Value.TryGetProperty("default", out var defaultValue))
                        source.Append(" = ").Append(DefaultLiteral(defaultValue,
                            Text(property.Value, "clrType", destination), destination)).Append(';');
                    source.AppendLine();
                }
                source.AppendLine("}");
                files.Add(name + ".g.cs", source.ToString());
            }

            var api = Header(ns);
            api.Append("public static class ").Append(className).AppendLine("\n{");
            var operationNames = new HashSet<string>(StringComparer.Ordinal);
            foreach (var operation in operations.EnumerateArray())
            {
                Object(operation, "$.operations", "name", "mode", "parameters", "path");
                var name = Text(operation, "name", "$.operations");
                Identifier(name, "$.operations.name");
                if (!operationNames.Add(name) || name == className)
                    throw Error(name, "Duplicate operation name or operation named after its containing class.");
                var mode = Choice(operation, "mode", name, "value", "object", "path");
                var parameters = Array(operation, "parameters", name).EnumerateArray().ToArray();
                if (mode == "value" && parameters.Length != 1)
                    throw Error(name, "Value operations require exactly one parameter.");
                if (mode != "path" && operation.TryGetProperty("path", out _))
                    throw Error(name, "Only path operations may declare a path.");
                var path = mode == "path" ? Text(operation, "path", name) : null;
                if (path != null)
                    ValidatePath(path, parameters.Length, name);

                var names = new HashSet<string>(StringComparer.Ordinal);
                var parameterNames = new List<string>();
                var schemas = new List<string>();
                var declarations = new List<string>();
                foreach (var parameter in parameters)
                {
                    Object(parameter, name, "name", "type", "schema");
                    var parameterName = Text(parameter, "name", name);
                    var schema = Required(parameter, "schema", name + "." + parameterName);
                    ValidateNode(schema, name + "." + parameterName, modelNames);
                    var destination = Text(schema, "destination", name);
                    Identifier(parameterName, destination);
                    if (!names.Add(parameterName))
                        throw Error(destination, "Duplicate parameter name.");
                    var type = Type(Text(parameter, "type", destination), modelNames, destination);
                    parameterNames.Add(parameterName);
                    schemas.Add(Literal(schema.GetRawText()));
                    declarations.Add($"[{Sdk}WorkflowExpressionAttribute, {Sdk}WorkflowDestinationAttribute({schemas[^1]})] global::System.Func<{type}> {parameterName} = null");
                }

                api.Append("    public static ").Append(Sdk)
                    .Append("ComposeAction<global::Newtonsoft.Json.Linq.JToken> ").Append(name).Append('(')
                    .Append(string.Join(", ", declarations)).AppendLine(")");
                api.Append("        => ").Append(Sdk).Append("WorkflowSchemaRuntime.");
                var schemaArray = "new string[] { " + string.Join(", ", schemas) + " }";
                var delegates = "new global::System.Delegate[] { " + string.Join(", ", parameterNames) + " }";
                if (mode == "value")
                    api.Append("Value(").Append(schemas[0]).Append(", ").Append(parameterNames[0]);
                else if (mode == "object")
                    api.Append("Object(new string[] { ").Append(string.Join(", ", parameterNames.Select(Literal)))
                        .Append(" }, ").Append(schemaArray).Append(", ").Append(delegates);
                else
                    api.Append("Path(").Append(Literal(path!)).Append(", ").Append(schemaArray).Append(", ").Append(delegates);
                api.AppendLine(");").AppendLine();
            }
            api.AppendLine("}");
            files.Add(className + ".g.cs", api.ToString());
            return new ReadOnlyDictionary<string, string>(files);
        }
        catch (JsonException exception)
        {
            throw new InvalidDataException($"Invalid workflow schema at {exception.Path ?? "$"}: {exception.Message}", exception);
        }
    }

    private static bool ValidateNode(JsonElement node, string location, HashSet<string> models,
        bool modelRoot = false, bool modelProperty = false)
    {
        if (node.ValueKind == JsonValueKind.Object &&
            node.TryGetProperty("destination", out var label) && label.ValueKind == JsonValueKind.String)
            location = label.GetString()!;
        Object(node, location, "version", "destination", "kind", "nullable", "optional", "transforms",
            "properties", "items", "enumPolicy", "enumValues", "inputEncoding", "allowAlreadyEncoded",
            "runtimeObject", "serializerProfile", "default", "clrName", "clrType", "additionalProperties");
        Version(node, location);
        Text(node, "destination", location);
        var kind = Choice(node, "kind", location, "text", "number", "boolean", "bytes", "uri",
            "httpMethod", "enum", "json", "object", "array", "any");
        var nullable = Boolean(node, "nullable", location);
        Boolean(node, "optional", location);
        var transforms = Array(node, "transforms", location);
        var base64 = false;
        var url = false;
        foreach (var transform in transforms.EnumerateArray())
        {
            if (transform.ValueKind != JsonValueKind.String)
                throw Error(location, "Transforms must be strings.");
            switch (transform.GetString())
            {
                case "base64" when !base64 && !url:
                    base64 = true;
                    break;
                case "url":
                    url = true;
                    break;
                default:
                    throw Error(location, "Transforms support base64 at most once, before any url transforms.");
            }
        }

        var hasEncoding = node.TryGetProperty("inputEncoding", out _);
        if (kind == "bytes" && url && !base64)
            throw Error(location, "Raw binary requires base64 before URL encoding.");
        var encoding = hasEncoding ? Choice(node, "inputEncoding", location, "raw", "base64") : null;
        if (base64 && !hasEncoding)
            throw Error(location, "Base64 requires explicit inputEncoding metadata.");
        var hasPassThrough = node.TryGetProperty("allowAlreadyEncoded", out _);
        var passThrough = hasPassThrough && Boolean(node, "allowAlreadyEncoded", location);
        if ((hasEncoding || hasPassThrough) && !base64)
            throw Error(location, "Input encoding metadata requires a base64 transform.");
        if (encoding == "base64" && (!passThrough || kind != "text"))
            throw Error(location, "Already-encoded input requires text kind and explicit allowAlreadyEncoded=true.");
        if (passThrough && (!hasEncoding || kind != "text"))
            throw Error(location, "Base64 pass-through requires an explicit text inputEncoding.");

        var hasProfile = node.TryGetProperty("serializerProfile", out _);
        if (hasProfile)
        {
            Choice(node, "serializerProfile", location, "compact-json-v1");
            if (kind is not ("json" or "any" or "object" or "array"))
                throw Error(location, "A serializer profile is only valid for JSON-capable kinds.");
        }
        if ((kind == "json" || ((base64 || url) && kind is ("any" or "object" or "array"))) && !hasProfile)
            throw Error(location, "JSON normalization requires serializerProfile='compact-json-v1'.");
        if (node.TryGetProperty("runtimeObject", out _))
        {
            Boolean(node, "runtimeObject", location);
            if (kind != "object")
                throw Error(location, "runtimeObject is only valid for object destinations.");
        }
        if (node.TryGetProperty("additionalProperties", out _))
        {
            Boolean(node, "additionalProperties", location);
            if (kind != "object")
                throw Error(location, "additionalProperties is only valid for objects.");
        }

        if (kind == "enum")
        {
            var policy = Choice(node, "enumPolicy", location, "open", "closed");
            if (policy == "closed")
            {
                var values = Array(node, "enumValues", location);
                var unique = new HashSet<string>(StringComparer.Ordinal);
                foreach (var value in values.EnumerateArray())
                    if (value.ValueKind != JsonValueKind.String || !unique.Add(value.GetString()!))
                        throw Error(location, "Closed enum values must be unique strings.");
                if (unique.Count == 0)
                    throw Error(location, "Closed enums require at least one wire value.");
            }
            else if (node.TryGetProperty("enumValues", out _))
                throw Error(location, "Only closed enum destinations may specify enumValues.");
        }
        else if (node.TryGetProperty("enumPolicy", out _) || node.TryGetProperty("enumValues", out _))
            throw Error(location, "Enum metadata requires kind 'enum'.");

        var childTransforms = false;
        if (node.TryGetProperty("properties", out var properties))
        {
            if (kind != "object" || properties.ValueKind != JsonValueKind.Object)
                throw Error(location, "properties must be an object dictionary on an object destination.");
            foreach (var property in properties.EnumerateObject())
            {
                if (string.IsNullOrWhiteSpace(property.Name))
                    throw Error(location, "Property wire names must not be empty.");
                childTransforms |= ValidateNode(property.Value, location + "." + property.Name, models,
                    modelProperty: modelRoot);
            }
        }
        else if (kind == "object")
            throw Error(location, "An object destination requires explicit properties metadata.");
        if (node.TryGetProperty("items", out var items))
        {
            if (kind != "array")
                throw Error(location, "items is only valid on array destinations.");
            childTransforms |= ValidateNode(items, location + "[*]", models);
        }
        else if (kind == "array")
            throw Error(location, "An array destination requires an items schema.");
        if ((base64 || url) && childTransforms)
            throw Error(location, "Conflicting whole-value and member transforms have no authoritative precedence.");

        if (modelProperty)
        {
            Identifier(Text(node, "clrName", location), location);
            Type(Text(node, "clrType", location), models, location);
        }
        else if (node.TryGetProperty("clrName", out _) || node.TryGetProperty("clrType", out _))
            throw Error(location, "clrName/clrType are only valid on generated model properties.");
        if (node.TryGetProperty("default", out var defaultValue))
        {
            if (defaultValue.ValueKind is JsonValueKind.Object or JsonValueKind.Array)
                throw Error(location, "Schema defaults must be scalar JSON literals.");
            if (defaultValue.ValueKind == JsonValueKind.Null)
            {
                if (!nullable)
                    throw Error(location, "A null default conflicts with nullable=false.");
            }
            else
            {
                var valid = kind switch
                {
                    "boolean" => defaultValue.ValueKind is JsonValueKind.True or JsonValueKind.False,
                    "number" => defaultValue.ValueKind == JsonValueKind.Number,
                    "text" or "bytes" or "uri" or "httpMethod" or "enum" => defaultValue.ValueKind == JsonValueKind.String,
                    "any" or "json" => true,
                    _ => false,
                };
                if (!valid)
                    throw Error(location, "The default literal does not match the destination kind.");
                if (kind == "enum" && Text(node, "enumPolicy", location) == "closed" &&
                    !node.GetProperty("enumValues").EnumerateArray().Any(v => v.GetString() == defaultValue.GetString()))
                    throw Error(location, "The default is not a declared closed enum wire value.");
            }
        }
        return base64 || url || childTransforms;
    }

    internal static void ValidateModelSchema(JsonElement schema, IEnumerable<string> modelNames)
    {
        CheckDuplicates(schema, "$");
        ValidateNode(schema, "$", new HashSet<string>(modelNames, StringComparer.Ordinal), modelRoot: true);
        foreach (var property in schema.GetProperty("properties").EnumerateObject())
            if (property.Value.TryGetProperty("default", out var value))
                DefaultLiteral(value, Text(property.Value, "clrType", property.Name), property.Name);
    }

    internal static string ModelDefaultLiteral(JsonElement value, string clrType, string destination) =>
        DefaultLiteral(value, clrType, destination);

    private static string DefaultLiteral(JsonElement value, string type, string location)
    {
        if (value.ValueKind == JsonValueKind.Null && type is not ("bool" or "int"))
            return "null";
        if (value.ValueKind == JsonValueKind.String && type is ("string" or "object"))
            return Literal(value.GetString()!);
        if (value.ValueKind is (JsonValueKind.True or JsonValueKind.False) && type is ("bool" or "object"))
            return value.GetBoolean() ? "true" : "false";
        if (value.ValueKind == JsonValueKind.Number)
        {
            if (type is ("int" or "object") && value.TryGetInt32(out var integer))
                return integer.ToString(CultureInfo.InvariantCulture);
            if (type == "object" && value.TryGetDecimal(out var number))
            {
                var literal = number.ToString(CultureInfo.InvariantCulture);
                if (CanonicalNumber(value.GetRawText()) == CanonicalNumber(literal))
                    return literal + "M";
            }
        }
        throw Error(location, $"The scalar default cannot be represented safely as CLR type '{type}'.");
    }

    private static string CanonicalNumber(string text)
    {
        var parts = text.Split(new[] { 'e', 'E' });
        var exponent = parts.Length == 2
            ? System.Numerics.BigInteger.Parse(parts[1], CultureInfo.InvariantCulture)
            : System.Numerics.BigInteger.Zero;
        var negative = parts[0].StartsWith("-", StringComparison.Ordinal);
        var digits = negative ? parts[0][1..] : parts[0];
        var point = digits.IndexOf('.');
        if (point >= 0)
        {
            exponent -= digits.Length - point - 1;
            digits = digits.Remove(point, 1);
        }
        digits = digits.TrimStart('0');
        if (digits.Length == 0)
            return "0";
        var trimmed = digits.TrimEnd('0');
        exponent += digits.Length - trimmed.Length;
        return (negative ? "-" : "") + trimmed + "e" + exponent.ToString(CultureInfo.InvariantCulture);
    }

    private static void ValidatePath(string path, int count, string location)
    {
        if (!path.StartsWith("/", StringComparison.Ordinal) || path.Any(char.IsControl))
            throw Error(location, "Path formats must start with '/' and contain no control characters.");
        var next = 0;
        for (var index = 0; index < path.Length; index++)
        {
            if (path[index] == '}')
                throw Error(location, "Unmatched path placeholder closing brace.");
            if (path[index] != '{')
                continue;
            var expected = "{" + next.ToString(CultureInfo.InvariantCulture) + "}";
            if (!path.AsSpan(index).StartsWith(expected.AsSpan(), StringComparison.Ordinal))
                throw Error(location, "Path placeholders must be consecutive, ordered, and unformatted: {0}, {1}, ... .");
            index += expected.Length - 1;
            next++;
        }
        if (next != count || count == 0)
            throw Error(location, "Path placeholder count must equal the nonzero parameter count.");
    }

    private static void CheckDuplicates(JsonElement element, string location)
    {
        if (element.ValueKind == JsonValueKind.Object)
        {
            if (element.TryGetProperty("destination", out var destination) && destination.ValueKind == JsonValueKind.String)
                location = destination.GetString()!;
            var names = new HashSet<string>(StringComparer.Ordinal);
            foreach (var property in element.EnumerateObject())
            {
                if (!names.Add(property.Name))
                    throw Error(location, $"Duplicate JSON key '{property.Name}'.");
                CheckDuplicates(property.Value, location + "." + property.Name);
            }
        }
        else if (element.ValueKind == JsonValueKind.Array)
        {
            var index = 0;
            foreach (var item in element.EnumerateArray())
                CheckDuplicates(item, $"{location}[{index++}]");
        }
    }

    private static void Object(JsonElement value, string location, params string[] allowed)
    {
        if (value.ValueKind != JsonValueKind.Object)
            throw Error(location, "Expected an object.");
        foreach (var property in value.EnumerateObject())
            if (!allowed.Contains(property.Name, StringComparer.Ordinal))
                throw Error(location, $"Unknown metadata key '{property.Name}'.");
    }

    private static JsonElement Required(JsonElement value, string name, string location)
    {
        if (!value.TryGetProperty(name, out var property))
            throw Error(location, $"Missing required '{name}'.");
        return property;
    }

    private static string Text(JsonElement value, string name, string location)
    {
        var property = Required(value, name, location);
        if (property.ValueKind != JsonValueKind.String || string.IsNullOrWhiteSpace(property.GetString()))
            throw Error(location, $"'{name}' must be a nonempty string.");
        return property.GetString()!;
    }

    private static JsonElement Array(JsonElement value, string name, string location)
    {
        var property = Required(value, name, location);
        if (property.ValueKind != JsonValueKind.Array)
            throw Error(location, $"'{name}' must be an array.");
        return property;
    }

    private static bool Boolean(JsonElement value, string name, string location)
    {
        var property = Required(value, name, location);
        if (property.ValueKind is not (JsonValueKind.True or JsonValueKind.False))
            throw Error(location, $"'{name}' must be a Boolean.");
        return property.GetBoolean();
    }

    private static void Version(JsonElement value, string location)
    {
        var version = Required(value, "version", location);
        if (version.ValueKind != JsonValueKind.Number || !version.TryGetInt32(out var number) || number != 1)
            throw Error(location, "Unsupported schema version; expected integer version 1.");
    }

    private static string Choice(JsonElement value, string name, string location, params string[] allowed)
    {
        var text = Text(value, name, location);
        if (!allowed.Contains(text, StringComparer.Ordinal))
            throw Error(location, $"Unsupported '{name}' value '{text}'. Expected: {string.Join(", ", allowed)}.");
        return text;
    }

    private static void Identifier(string value, string location)
    {
        if (value.Length == 0 || !value.All(c => char.IsAsciiLetterOrDigit(c) || c == '_') ||
            !SyntaxFacts.IsValidIdentifier(value) || SyntaxFacts.GetKeywordKind(value) != SyntaxKind.None ||
            value is "__arglist" or "__makeref" or "__reftype" or "__refvalue")
            throw Error(location, $"Unsafe C# identifier '{value}'. Use an unescaped identifier.");
    }

    private static void FileName(string name, string location)
    {
        var upper = name.ToUpperInvariant();
        if (upper is "CON" or "PRN" or "AUX" or "NUL" ||
            (upper.Length == 4 && (upper.StartsWith("COM", StringComparison.Ordinal) ||
                upper.StartsWith("LPT", StringComparison.Ordinal)) && upper[3] is >= '1' and <= '9'))
            throw Error(location, $"'{name}' is not a portable generated file name.");
        if (name is "var" or "dynamic" or "nint" or "nuint" or "record")
            throw Error(location, $"'{name}' is not a supported C# declaration name.");
    }

    private static string Type(string value, HashSet<string> models, string location)
    {
        if (BuiltInTypes.Contains(value))
            return value.StartsWith("System.", StringComparison.Ordinal) ? "global::" + value : value;
        if (models.Contains(value))
            return value;
        throw Error(location, $"Unsupported or unsafe CLR type '{value}'.");
    }

    private static StringBuilder Header(string ns) => new StringBuilder()
        .AppendLine("// <auto-generated />")
        .AppendLine("#nullable disable")
        .Append("namespace ").Append(ns).AppendLine(";").AppendLine();

    private static string Literal(string value) => SymbolDisplay.FormatLiteral(value, quote: true);

    private static InvalidDataException Error(string destination, string message) =>
        new($"Invalid workflow schema at '{destination}': {message}");
}
