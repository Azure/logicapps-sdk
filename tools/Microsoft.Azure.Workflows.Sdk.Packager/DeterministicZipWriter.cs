// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

using System.IO.Compression;

internal static class DeterministicZipWriter
{
    private static readonly DateTimeOffset NormalizedTimestamp =
        new(1980, 1, 1, 0, 0, 0, TimeSpan.Zero);

    public static void Create(string sourceDirectory, string outputPath)
    {
        var outputDirectory = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrEmpty(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
        }

        var temporaryOutputPath = outputPath + ".tmp";
        File.Delete(temporaryOutputPath);

        try
        {
            using (var output = File.Create(temporaryOutputPath))
            using (var archive = new ZipArchive(output, ZipArchiveMode.Create))
            {
                foreach (var file in Directory
                    .EnumerateFiles(sourceDirectory, "*", SearchOption.AllDirectories)
                    .Select(path => new
                    {
                        FullPath = path,
                        RelativePath = Path.GetRelativePath(sourceDirectory, path).Replace('\\', '/'),
                    })
                    .OrderBy(file => file.RelativePath, StringComparer.Ordinal))
                {
                    var entry = archive.CreateEntry(file.RelativePath, CompressionLevel.Optimal);
                    entry.LastWriteTime = NormalizedTimestamp;

                    using var source = File.OpenRead(file.FullPath);
                    using var destination = entry.Open();
                    source.CopyTo(destination);
                }
            }

            File.Move(temporaryOutputPath, outputPath, overwrite: true);
        }
        finally
        {
            File.Delete(temporaryOutputPath);
        }
    }
}
