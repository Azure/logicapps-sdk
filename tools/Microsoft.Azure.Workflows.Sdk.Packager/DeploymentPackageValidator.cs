// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

using System.Text.Json;

internal static class DeploymentPackageValidator
{
    public static void Validate(string stagingDirectory)
    {
        var errors = new List<string>();
        RequireFile(stagingDirectory, "host.json", errors);

        var workerRoot = Path.Combine(stagingDirectory, "lib", "codeful");
        var workerConfigPath = Path.Combine(workerRoot, "worker.config.json");
        RequireFile(stagingDirectory, Path.Combine("lib", "codeful", "worker.config.json"), errors);

        if (File.Exists(workerConfigPath))
        {
            ValidateWorkerConfig(workerRoot, workerConfigPath, errors);
        }

        var localSettings = Directory
            .EnumerateFiles(stagingDirectory, "local.settings.json", SearchOption.AllDirectories)
            .Select(path => Path.GetRelativePath(stagingDirectory, path))
            .ToArray();

        if (localSettings.Length > 0)
        {
            errors.Add($"local.settings.json must not be packaged: {string.Join(", ", localSettings)}");
        }

        if (errors.Count > 0)
        {
            throw new InvalidOperationException(
                "The deployment package is invalid:" +
                Environment.NewLine +
                string.Join(Environment.NewLine, errors.Select(error => $" - {error}")));
        }
    }

    private static void ValidateWorkerConfig(
        string workerRoot,
        string workerConfigPath,
        List<string> errors)
    {
        try
        {
            using var document = JsonDocument.Parse(File.ReadAllText(workerConfigPath));
            var description = document.RootElement.GetProperty("description");
            var language = description.GetProperty("language").GetString();
            if (!string.Equals(language, "dotnet", StringComparison.Ordinal))
            {
                errors.Add("lib/codeful/worker.config.json must declare description.language as 'dotnet'.");
            }

            var workerPath = description.GetProperty("defaultWorkerPath").GetString();
            if (string.IsNullOrWhiteSpace(workerPath))
            {
                errors.Add("lib/codeful/worker.config.json must declare description.defaultWorkerPath.");
            }
            else if (!File.Exists(Path.Combine(workerRoot, workerPath)))
            {
                workerPath = workerPath
                    .Replace('\\', Path.DirectorySeparatorChar)
                    .Replace('/', Path.DirectorySeparatorChar);

                if (File.Exists(Path.Combine(workerRoot, workerPath)))
                {
                    return;
                }

                errors.Add(
                    $"lib/codeful/worker.config.json references missing worker assembly '{workerPath}'.");
            }
        }
        catch (Exception exception) when (exception is JsonException or KeyNotFoundException or InvalidOperationException)
        {
            errors.Add($"lib/codeful/worker.config.json is invalid: {exception.Message}");
        }
    }

    private static void RequireFile(string stagingDirectory, string relativePath, List<string> errors)
    {
        if (!File.Exists(Path.Combine(stagingDirectory, relativePath)))
        {
            errors.Add($"Required file '{relativePath.Replace('\\', '/')}' is missing.");
        }
    }
}
