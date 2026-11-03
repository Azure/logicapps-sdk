// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

internal static class PackageAssembler
{
    public static void Assemble(
        string logicAppRoot,
        string workerPublishDirectory,
        string stagingDirectory,
        DeploymentAssetFilter filter,
        string outputPath)
    {
        CopyLogicAppAssets(logicAppRoot, stagingDirectory, filter, outputPath);

        var workerDestination = Path.Combine(stagingDirectory, "lib", "codeful");
        CopyDirectory(workerPublishDirectory, workerDestination);
    }

    private static void CopyLogicAppAssets(
        string logicAppRoot,
        string stagingDirectory,
        DeploymentAssetFilter filter,
        string outputPath)
    {
        var normalizedOutputPath = Path.GetFullPath(outputPath);

        foreach (var sourcePath in Directory.EnumerateFiles(logicAppRoot, "*", SearchOption.AllDirectories))
        {
            if (Path.GetFullPath(sourcePath).Equals(normalizedOutputPath, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var relativePath = Path.GetRelativePath(logicAppRoot, sourcePath);
            if (filter.IsExcluded(relativePath))
            {
                continue;
            }

            var destinationPath = Path.Combine(stagingDirectory, relativePath);
            Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);
            File.Copy(sourcePath, destinationPath, overwrite: true);
        }
    }

    private static void CopyDirectory(string sourceDirectory, string destinationDirectory)
    {
        foreach (var sourcePath in Directory.EnumerateFiles(sourceDirectory, "*", SearchOption.AllDirectories))
        {
            var relativePath = Path.GetRelativePath(sourceDirectory, sourcePath);
            if (Path.GetFileName(relativePath).Equals("local.settings.json", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var destinationPath = Path.Combine(destinationDirectory, relativePath);
            Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);
            File.Copy(sourcePath, destinationPath, overwrite: true);
        }
    }
}
