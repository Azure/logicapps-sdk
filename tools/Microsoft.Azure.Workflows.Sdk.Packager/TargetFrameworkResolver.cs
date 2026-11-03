// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

using System.Xml.Linq;

internal static class TargetFrameworkResolver
{
    public static string Resolve(string projectPath, string? requestedFramework)
    {
        if (!string.IsNullOrWhiteSpace(requestedFramework))
        {
            return requestedFramework;
        }

        var project = XDocument.Load(projectPath);
        var targetFramework = project
            .Descendants()
            .FirstOrDefault(element => element.Name.LocalName == "TargetFramework")
            ?.Value
            .Trim();

        if (!string.IsNullOrWhiteSpace(targetFramework))
        {
            return targetFramework;
        }

        var targetFrameworks = project
            .Descendants()
            .FirstOrDefault(element => element.Name.LocalName == "TargetFrameworks")
            ?.Value
            .Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        if (targetFrameworks is { Length: 1 })
        {
            return targetFrameworks[0];
        }

        throw new InvalidOperationException(
            "Unable to infer a single target framework from the project. Specify --framework explicitly.");
    }
}
