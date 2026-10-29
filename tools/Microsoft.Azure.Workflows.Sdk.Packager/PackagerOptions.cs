// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

internal sealed record PackagerOptions(
    string ProjectPath,
    string LogicAppRoot,
    string OutputPath,
    string Configuration,
    string? Framework,
    string DotNetPath,
    bool KeepStaging);

internal sealed record PackageResult(string PackagePath, int FileCount, string? StagingPath);
