// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager.Tests;

public sealed class DeploymentAssetFilterTests : IDisposable
{
    private readonly string testDirectory = Path.Combine(
        Path.GetTempPath(),
        "logicapps-sdk-packager-tests",
        Guid.NewGuid().ToString("N"));

    [Fact]
    public void ExcludesBuildSourceAndLocalSettingsFiles()
    {
        Directory.CreateDirectory(this.testDirectory);
        var filter = DeploymentAssetFilter.Create(this.testDirectory);

        Assert.True(filter.IsExcluded("local.settings.json"));
        Assert.True(filter.IsExcluded("src/Workflow.cs"));
        Assert.True(filter.IsExcluded("obj/project.assets.json"));
        Assert.True(filter.IsExcluded("lib/codeful/old-worker.dll"));
        Assert.False(filter.IsExcluded("host.json"));
        Assert.False(filter.IsExcluded("workflows/orders/workflow.json"));
        Assert.False(filter.IsExcluded("Artifacts/Maps/order.xslt"));
        Assert.False(filter.IsExcluded("Artifacts/Schemas/order.xsd"));
    }

    [Fact]
    public void AppliesFuncIgnoreRulesAndNegation()
    {
        Directory.CreateDirectory(this.testDirectory);
        File.WriteAllText(
            Path.Combine(this.testDirectory, ".funcignore"),
            """
            ignored/**
            secrets
            **/*.secret
            !**/keep.secret
            """);

        var filter = DeploymentAssetFilter.Create(this.testDirectory);

        Assert.True(filter.IsExcluded("ignored/nested/file.json"));
        Assert.True(filter.IsExcluded("secrets/connection.txt"));
        Assert.True(filter.IsExcluded("value.secret"));
        Assert.True(filter.IsExcluded("folder/value.secret"));
        Assert.False(filter.IsExcluded("keep.secret"));
        Assert.False(filter.IsExcluded("folder/keep.secret"));
    }

    public void Dispose()
    {
        if (Directory.Exists(this.testDirectory))
        {
            Directory.Delete(this.testDirectory, recursive: true);
        }
    }
}
