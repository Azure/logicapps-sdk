// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

internal sealed class LogicAppPackager
{
    public async Task<PackageResult> PackAsync(PackagerOptions options, CancellationToken cancellationToken)
    {
        var framework = ValidateOptions(options);

        var temporaryRoot = Path.Combine(Path.GetTempPath(), "logicapps-sdk-pack", Guid.NewGuid().ToString("N"));
        var publishDirectory = Path.Combine(temporaryRoot, "publish");
        var stagingDirectory = Path.Combine(temporaryRoot, "staging");

        Directory.CreateDirectory(publishDirectory);
        Directory.CreateDirectory(stagingDirectory);

        try
        {
            await PublishWorkerAsync(options, framework, publishDirectory, cancellationToken);
            WorkerConfigNormalizer.Normalize(publishDirectory);

            var filter = DeploymentAssetFilter.Create(options.LogicAppRoot);
            PackageAssembler.Assemble(
                options.LogicAppRoot,
                publishDirectory,
                stagingDirectory,
                filter,
                options.OutputPath);
            DeploymentPackageValidator.Validate(stagingDirectory);

            DeterministicZipWriter.Create(stagingDirectory, options.OutputPath);
            var fileCount = Directory.EnumerateFiles(stagingDirectory, "*", SearchOption.AllDirectories).Count();

            return new PackageResult(
                PackagePath: options.OutputPath,
                FileCount: fileCount,
                StagingPath: options.KeepStaging ? stagingDirectory : null);
        }
        finally
        {
            if (!options.KeepStaging && Directory.Exists(temporaryRoot))
            {
                try
                {
                    Directory.Delete(temporaryRoot, recursive: true);
                }
                catch (Exception exception)
                {
                    Console.Error.WriteLine(
                        $"Warning: unable to remove temporary packaging directory '{temporaryRoot}': {exception.Message}");
                }
            }
            else if (options.KeepStaging)
            {
                Console.WriteLine($"Preserved staging files at: {stagingDirectory}");
            }
        }
    }

    private static string ValidateOptions(PackagerOptions options)
    {
        if (!File.Exists(options.ProjectPath))
        {
            throw new FileNotFoundException("The SDK project file was not found.", options.ProjectPath);
        }

        ProjectTypeValidator.ValidateCodeFirstProject(options.ProjectPath);

        if (!Directory.Exists(options.LogicAppRoot))
        {
            throw new DirectoryNotFoundException($"The Logic App root '{options.LogicAppRoot}' was not found.");
        }

        var framework = TargetFrameworkResolver.Resolve(options.ProjectPath, options.Framework);
        if (!framework.Equals("net8", StringComparison.OrdinalIgnoreCase) &&
            !framework.Equals("net8.0", StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException(
                $"Target framework '{framework}' is not supported. This initial implementation supports .NET 8 only.");
        }

        if (!options.OutputPath.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException("The output path must end with '.zip'.", nameof(options));
        }

        return framework;
    }

    private static async Task PublishWorkerAsync(
        PackagerOptions options,
        string framework,
        string publishDirectory,
        CancellationToken cancellationToken)
    {
        var arguments = new[]
        {
            "publish",
            options.ProjectPath,
            "--configuration",
            options.Configuration,
            "--framework",
            framework,
            "--output",
            publishDirectory,
            "--nologo",
            "-p:LogicAppFolderToPublish=",
        };

        var result = await ProcessRunner.RunAsync(
            options.DotNetPath,
            arguments,
            Path.GetDirectoryName(options.ProjectPath)!,
            cancellationToken);

        if (result.ExitCode != 0)
        {
            throw new InvalidOperationException(
                $"dotnet publish failed with exit code {result.ExitCode}.{Environment.NewLine}{result.Output}");
        }
    }
}
