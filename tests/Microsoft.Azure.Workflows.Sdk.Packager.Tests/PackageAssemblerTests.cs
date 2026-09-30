// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager.Tests;

using System.IO.Compression;

public sealed class PackageAssemblerTests : IDisposable
{
    private readonly string testDirectory = Path.Combine(
        Path.GetTempPath(),
        "logicapps-sdk-packager-tests",
        Guid.NewGuid().ToString("N"));

    [Fact]
    public void AssemblesValidDeploymentRootAndDeterministicZip()
    {
        var logicAppRoot = Path.Combine(this.testDirectory, "source");
        var workerPublish = Path.Combine(this.testDirectory, "publish");
        var staging = Path.Combine(this.testDirectory, "staging");
        var packagePath = Path.Combine(this.testDirectory, "package.zip");

        Directory.CreateDirectory(logicAppRoot);
        Directory.CreateDirectory(workerPublish);
        Directory.CreateDirectory(staging);

        File.WriteAllText(Path.Combine(logicAppRoot, "host.json"), """{"version":"2.0"}""");
        File.WriteAllText(Path.Combine(logicAppRoot, "connections.json"), "{}");
        File.WriteAllText(Path.Combine(logicAppRoot, "local.settings.json"), "secret");
        File.WriteAllText(Path.Combine(logicAppRoot, "Workflow.cs"), "source");
        var previousPackagePath = Path.Combine(logicAppRoot, "Artifacts", "package.zip");
        Directory.CreateDirectory(Path.GetDirectoryName(previousPackagePath)!);
        File.WriteAllText(previousPackagePath, "previous package");
        Directory.CreateDirectory(Path.Combine(logicAppRoot, "maps"));
        File.WriteAllText(Path.Combine(logicAppRoot, "maps", "order.xslt"), "map");

        File.WriteAllText(
            Path.Combine(workerPublish, "worker.config.json"),
            """
            {
              "description": {
                "language": "dotnet-isolated",
                "defaultWorkerPath": "Worker.dll"
              }
            }
            """);
        File.WriteAllText(Path.Combine(workerPublish, "Worker.dll"), "worker");
        File.WriteAllText(Path.Combine(workerPublish, "local.settings.json"), "secret");

        WorkerConfigNormalizer.Normalize(workerPublish);
        PackageAssembler.Assemble(
            logicAppRoot,
            workerPublish,
            staging,
            DeploymentAssetFilter.Create(logicAppRoot),
            previousPackagePath);
        DeploymentPackageValidator.Validate(staging);
        DeterministicZipWriter.Create(staging, packagePath);

        using var archive = ZipFile.OpenRead(packagePath);
        var entries = archive.Entries.Select(entry => entry.FullName).OrderBy(value => value).ToArray();

        Assert.Contains("host.json", entries);
        Assert.Contains("connections.json", entries);
        Assert.Contains("maps/order.xslt", entries);
        Assert.Contains("lib/codeful/worker.config.json", entries);
        Assert.Contains("lib/codeful/Worker.dll", entries);
        Assert.DoesNotContain("local.settings.json", entries);
        Assert.DoesNotContain("lib/codeful/local.settings.json", entries);
        Assert.DoesNotContain("Workflow.cs", entries);
        Assert.DoesNotContain("Artifacts/package.zip", entries);
        Assert.All(archive.Entries, entry => Assert.Equal(1980, entry.LastWriteTime.Year));
    }

    [Fact]
    public void ValidationRejectsMissingWorkerAssembly()
    {
        var staging = Path.Combine(this.testDirectory, "staging");
        var workerRoot = Path.Combine(staging, "lib", "codeful");
        Directory.CreateDirectory(workerRoot);
        File.WriteAllText(Path.Combine(staging, "host.json"), "{}");
        File.WriteAllText(
            Path.Combine(workerRoot, "worker.config.json"),
            """
            {
              "description": {
                "language": "dotnet",
                "defaultWorkerPath": "Missing.dll"
              }
            }
            """);

        var exception = Assert.Throws<InvalidOperationException>(
            () => DeploymentPackageValidator.Validate(staging));

        Assert.Contains("Missing.dll", exception.Message);
    }

    public void Dispose()
    {
        if (Directory.Exists(this.testDirectory))
        {
            Directory.Delete(this.testDirectory, recursive: true);
        }
    }
}
