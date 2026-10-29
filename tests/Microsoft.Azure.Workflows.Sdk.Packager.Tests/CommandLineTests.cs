// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager.Tests;

public sealed class CommandLineTests
{
    [Fact]
    public void RejectsUnknownOptionsEvenWhenDotnetIsSpecified()
    {
        var exception = Assert.Throws<CommandLineException>(
            () => CommandLine.Parse(
            [
                "--project",
                "project.csproj",
                "--output",
                "package.zip",
                "--dotnet",
                "dotnet",
                "--bogus",
                "value",
            ]));

        Assert.Contains("--bogus", exception.Message);
    }

    [Fact]
    public void InfersTargetFrameworkFromProject()
    {
        var directory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);

        try
        {
            var projectPath = Path.Combine(directory, "Project.csproj");
            File.WriteAllText(
                projectPath,
                """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <TargetFramework>net8</TargetFramework>
                  </PropertyGroup>
                </Project>
                """);

            Assert.Equal("net8", TargetFrameworkResolver.Resolve(projectPath, requestedFramework: null));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [Fact]
    public void RejectsTraditionalInProcessLogicAppProject()
    {
        var directory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);

        try
        {
            var projectPath = Path.Combine(directory, "Project.csproj");
            File.WriteAllText(
                projectPath,
                """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <TargetFramework>net8.0</TargetFramework>
                  </PropertyGroup>
                  <ItemGroup>
                    <PackageReference Include="Microsoft.NET.Sdk.Functions" Version="4.5.0" />
                    <PackageReference Include="Microsoft.Azure.Workflows.WebJobs.Extension" Version="1.2.0" />
                  </ItemGroup>
                </Project>
                """);

            var exception = Assert.Throws<InvalidOperationException>(
                () => ProjectTypeValidator.ValidateCodeFirstProject(projectPath));

            Assert.Contains("traditional in-process Logic App Standard project", exception.Message);
            Assert.Contains("Microsoft.Azure.Workflows.Sdk", exception.Message);
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [Fact]
    public void AcceptsCodeFirstProjectWithSdkProjectReference()
    {
        var directory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);

        try
        {
            var projectPath = Path.Combine(directory, "Project.csproj");
            File.WriteAllText(
                projectPath,
                """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <TargetFramework>net8</TargetFramework>
                  </PropertyGroup>
                  <ItemGroup>
                    <ProjectReference Include="..\src\Microsoft.Azure.Workflows.Sdk.csproj" />
                    <PackageReference Include="Microsoft.Azure.Functions.Worker.Sdk" Version="1.17.1" />
                  </ItemGroup>
                </Project>
                """);

            ProjectTypeValidator.ValidateCodeFirstProject(projectPath);
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }
}
