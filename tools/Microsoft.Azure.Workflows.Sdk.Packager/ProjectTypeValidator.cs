// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

using System.Xml.Linq;

internal static class ProjectTypeValidator
{
    private const string WorkflowsSdkPackage = "Microsoft.Azure.Workflows.Sdk";
    private const string FunctionsWorkerSdkPackage = "Microsoft.Azure.Functions.Worker.Sdk";

    public static void ValidateCodeFirstProject(string projectPath)
    {
        var project = XDocument.Load(projectPath);
        var packageReferences = project
            .Descendants()
            .Where(element => element.Name.LocalName == "PackageReference")
            .Select(element => element.Attribute("Include")?.Value ?? element.Attribute("Update")?.Value)
            .Where(value => !string.IsNullOrWhiteSpace(value))
            .ToHashSet(StringComparer.OrdinalIgnoreCase);
        var projectReferences = project
            .Descendants()
            .Where(element => element.Name.LocalName == "ProjectReference")
            .Select(element => element.Attribute("Include")?.Value)
            .Where(value => !string.IsNullOrWhiteSpace(value))
            .Select(value => Path.GetFileNameWithoutExtension(value))
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        var missingReferences = new[] { WorkflowsSdkPackage, FunctionsWorkerSdkPackage }
            .Where(reference =>
                !packageReferences.Contains(reference) &&
                !projectReferences.Contains(reference))
            .ToArray();

        if (missingReferences.Length == 0)
        {
            return;
        }

        var projectKind = packageReferences.Contains("Microsoft.NET.Sdk.Functions") ||
            packageReferences.Contains("Microsoft.Azure.Workflows.WebJobs.Extension")
                ? "The project appears to be a traditional in-process Logic App Standard project."
                : "The project is not configured as an SDK-based code-first Logic App worker.";

        throw new InvalidOperationException(
            $"{projectKind} The code-first packager requires package or project references to " +
            $"{WorkflowsSdkPackage} and {FunctionsWorkerSdkPackage}. " +
            $"Missing: {string.Join(", ", missingReferences)}. " +
            "Select the code-first worker .csproj, or use the standard Logic App publish/ZIP flow for this project.");
    }
}
