// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

using System.Text.Json;
using System.Text.Json.Nodes;

internal static class WorkerConfigNormalizer
{
    public static void Normalize(string workerPublishDirectory)
    {
        var workerConfigPath = Path.Combine(workerPublishDirectory, "worker.config.json");
        if (!File.Exists(workerConfigPath))
        {
            throw new InvalidOperationException(
                $"The published worker did not produce '{workerConfigPath}'.");
        }

        var root = JsonNode.Parse(File.ReadAllText(workerConfigPath)) as JsonObject
            ?? throw new InvalidOperationException($"{workerConfigPath} must contain a JSON object.");
        var description = root["description"] as JsonObject
            ?? throw new InvalidOperationException($"{workerConfigPath} must contain a description object.");

        if (string.Equals(description["language"]?.GetValue<string>(), "dotnet-isolated", StringComparison.Ordinal))
        {
            description["language"] = "dotnet";
            File.WriteAllText(
                workerConfigPath,
                root.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
