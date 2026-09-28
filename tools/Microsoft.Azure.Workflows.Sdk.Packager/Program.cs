// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

internal static class Program
{
    public static async Task<int> Main(string[] args)
    {
        if (args.Contains("--help", StringComparer.OrdinalIgnoreCase))
        {
            Console.WriteLine(CommandLine.Usage);
            return 0;
        }

        try
        {
            var options = CommandLine.Parse(args);
            var result = await new LogicAppPackager().PackAsync(options, CancellationToken.None);

            Console.WriteLine($"Created Logic App deployment package: {result.PackagePath}");
            Console.WriteLine($"Files: {result.FileCount}");
            return 0;
        }
        catch (CommandLineException exception)
        {
            Console.Error.WriteLine(exception.Message);
            Console.Error.WriteLine();
            Console.Error.WriteLine(CommandLine.Usage);
            return 2;
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine($"Packaging failed: {exception.Message}");
            return 1;
        }
    }
}
