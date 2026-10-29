// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Packager;

using System.Text.RegularExpressions;

internal sealed class DeploymentAssetFilter
{
    private static readonly HashSet<string> ExcludedDirectoryNames = new(StringComparer.OrdinalIgnoreCase)
    {
        ".git",
        ".vs",
        ".vscode",
        "bin",
        "obj",
        "TestResults",
    };

    private static readonly HashSet<string> ExcludedFileNames = new(StringComparer.OrdinalIgnoreCase)
    {
        ".funcignore",
        "local.settings.json",
    };

    private static readonly HashSet<string> ExcludedExtensions = new(StringComparer.OrdinalIgnoreCase)
    {
        ".cs",
        ".csproj",
        ".sln",
        ".suo",
        ".user",
    };

    private readonly IReadOnlyList<IgnoreRule> ignoreRules;

    private DeploymentAssetFilter(IReadOnlyList<IgnoreRule> ignoreRules)
    {
        this.ignoreRules = ignoreRules;
    }

    public static DeploymentAssetFilter Create(string logicAppRoot)
    {
        var ignoreFile = Path.Combine(logicAppRoot, ".funcignore");
        if (!File.Exists(ignoreFile))
        {
            return new DeploymentAssetFilter([]);
        }

        var rules = File.ReadLines(ignoreFile)
            .Select(IgnoreRule.TryCreate)
            .Where(rule => rule != null)
            .Cast<IgnoreRule>()
            .ToArray();

        return new DeploymentAssetFilter(rules);
    }

    public bool IsExcluded(string relativePath)
    {
        var normalizedPath = Normalize(relativePath);
        var segments = normalizedPath.Split('/', StringSplitOptions.RemoveEmptyEntries);

        if (segments.SkipLast(1).Any(ExcludedDirectoryNames.Contains) ||
            normalizedPath.StartsWith("lib/codeful/", StringComparison.OrdinalIgnoreCase) ||
            normalizedPath.Equals("lib/codeful", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        var fileName = segments.LastOrDefault() ?? normalizedPath;
        if (ExcludedFileNames.Contains(fileName) || ExcludedExtensions.Contains(Path.GetExtension(fileName)))
        {
            return true;
        }

        var excluded = false;
        foreach (var rule in this.ignoreRules)
        {
            if (rule.IsMatch(normalizedPath))
            {
                excluded = !rule.IsNegated;
            }
        }

        return excluded;
    }

    private static string Normalize(string path)
    {
        return path.Replace('\\', '/').TrimStart('/');
    }

    private sealed class IgnoreRule
    {
        private IgnoreRule(Regex expression, bool isNegated)
        {
            this.Expression = expression;
            this.IsNegated = isNegated;
        }

        public bool IsNegated { get; }

        private Regex Expression { get; }

        public bool IsMatch(string path) => this.Expression.IsMatch(path);

        public static IgnoreRule? TryCreate(string line)
        {
            var pattern = line.Trim();
            if (pattern.Length == 0 || pattern.StartsWith('#'))
            {
                return null;
            }

            var isNegated = pattern.StartsWith('!');
            if (isNegated)
            {
                pattern = pattern[1..];
            }

            pattern = Normalize(pattern);
            pattern = pattern.TrimEnd('/');
            if (pattern.Length == 0)
            {
                return null;
            }

            var anchored = line.TrimStart('!').StartsWith('/');
            var containsSlash = pattern.Contains('/');
            var regexBody = ConvertGlobToRegex(pattern);
            var prefix = anchored || containsSlash ? "^" : "(^|.*/)";
            var suffix = "(/.*)?$";

            return new IgnoreRule(
                new Regex(prefix + regexBody + suffix, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant),
                isNegated);
        }

        private static string ConvertGlobToRegex(string pattern)
        {
            var result = new System.Text.StringBuilder();

            for (var index = 0; index < pattern.Length; index++)
            {
                var character = pattern[index];
                if (character == '*' && index + 1 < pattern.Length && pattern[index + 1] == '*')
                {
                    if (index + 2 < pattern.Length && pattern[index + 2] == '/')
                    {
                        result.Append("(?:.*/)?");
                        index += 2;
                    }
                    else
                    {
                        result.Append(".*");
                        index++;
                    }
                }
                else if (character == '*')
                {
                    result.Append("[^/]*");
                }
                else if (character == '?')
                {
                    result.Append("[^/]");
                }
                else
                {
                    result.Append(Regex.Escape(character.ToString()));
                }
            }

            return result.ToString();
        }
    }
}
