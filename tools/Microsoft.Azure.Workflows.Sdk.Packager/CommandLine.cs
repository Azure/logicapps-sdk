// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

internal static class CommandLine
{
    internal const string Usage =
        """
        Usage:
          logicapps-sdk-pack --project <project.csproj> --output <package.zip> [options]

        Options:
          --logic-app-root <path>   Logic App project root. Defaults to the project directory.
          --configuration <value>   Build configuration. Defaults to Release.
          --framework <value>       Target framework. Defaults to the project TFM; .NET 8 is supported.
          --dotnet <path>           dotnet executable path. Defaults to dotnet.
          --keep-staging            Preserve the temporary staging directory for diagnostics.
          --help                    Show this help text.
        """;

    internal static PackagerOptions Parse(string[] args)
    {
        if (args.Length == 0)
        {
            throw new CommandLineException("No arguments were provided.");
        }

        var values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var keepStaging = false;

        for (var index = 0; index < args.Length; index++)
        {
            var argument = args[index];
            if (argument.Equals("--keep-staging", StringComparison.OrdinalIgnoreCase))
            {
                keepStaging = true;
                continue;
            }

            if (!argument.StartsWith("--", StringComparison.Ordinal))
            {
                throw new CommandLineException($"Unexpected argument '{argument}'.");
            }

            if (index + 1 >= args.Length || args[index + 1].StartsWith("--", StringComparison.Ordinal))
            {
                throw new CommandLineException($"Option '{argument}' requires a value.");
            }

            if (!values.TryAdd(argument, args[++index]))
            {
                throw new CommandLineException($"Option '{argument}' was specified more than once.");
            }
        }

        var projectPath = RemoveRequiredValue(values, "--project");
        var outputPath = RemoveRequiredValue(values, "--output");
        var projectFullPath = Path.GetFullPath(projectPath);
        var projectDirectory = Path.GetDirectoryName(projectFullPath)
            ?? throw new CommandLineException($"Unable to determine the directory for '{projectPath}'.");

        var options = new PackagerOptions(
            ProjectPath: projectFullPath,
            LogicAppRoot: Path.GetFullPath(RemoveValue(values, "--logic-app-root") ?? projectDirectory),
            OutputPath: Path.GetFullPath(outputPath),
            Configuration: RemoveValue(values, "--configuration") ?? "Release",
            Framework: RemoveValue(values, "--framework"),
            DotNetPath: RemoveValue(values, "--dotnet") ?? "dotnet",
            KeepStaging: keepStaging);

        if (values.Count > 0)
        {
            throw new CommandLineException($"Unknown option '{values.Keys.First()}'.");
        }

        return options;
    }

    private static string RemoveRequiredValue(Dictionary<string, string> values, string option)
    {
        return RemoveValue(values, option)
            ?? throw new CommandLineException($"Required option '{option}' was not provided.");
    }

    private static string? RemoveValue(Dictionary<string, string> values, string option)
    {
        values.Remove(option, out var value);
        return value;
    }
}

internal sealed class CommandLineException(string message) : Exception(message);
