namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Reflection;
using System.Text.Json;
using Microsoft.Azure.Workflows.Sdk.Build;

public sealed class ConnectorValidationCommandTests
{
    [Fact]
    public void Command_preserves_unchanged_output_and_invalidates_failed_manifests()
    {
        var directory = Path.Combine(Path.GetTempPath(), "sdk-connector-validation-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);
        try
        {
            var sourcePath = Path.Combine(directory, "connector.cs");
            var source = """
                using System;
                namespace Microsoft.Azure.Workflows.Sdk {
                    public class WorkflowExpressionAttribute : Attribute {}
                    public static class SourceExpression {
                        internal static void Validate(Delegate expression, string parameterName, bool required = false) {}
                    }
                    public class Connector {
                        public object Call([WorkflowExpression] Func<string> value) { return value; }
                    }
                }
                """;
            File.WriteAllText(sourcePath, source);
            var list = Path.Combine(directory, "connectors.txt");
            File.WriteAllLines(list, [sourcePath]);
            var manifest = Path.Combine(directory, "manifest.json");
            File.WriteAllText(manifest, JsonSerializer.Serialize(new
            {
                sources = new[] { sourcePath },
                references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!).Split(Path.PathSeparator),
            }));
            var output = Path.Combine(directory, "output");
            var args = new[] { "inject-connector-validation", manifest, list, output };
            Assert.Equal(0, Invoke(args));
            var outputList = Path.Combine(output, "compiled-files.txt");
            var compiled = Assert.Single(File.ReadAllLines(outputList));
            Assert.StartsWith(output + Path.DirectorySeparatorChar, compiled);
            Assert.Contains("required: true", File.ReadAllText(compiled));
            var stamp = File.GetLastWriteTimeUtc(compiled);
            Assert.Equal(0, Invoke(args));
            Assert.Equal(stamp, File.GetLastWriteTimeUtc(compiled));

            File.WriteAllText(sourcePath, source.Replace("Func<string> value)", "Func<string> value = null)"));
            Assert.Equal(0, Invoke(args));
            Assert.Contains("required: false", File.ReadAllText(compiled));

            File.Delete(compiled);
            Assert.Equal(0, Invoke(args));
            Assert.True(File.Exists(compiled));

            File.WriteAllText(sourcePath, source.Replace("return value;", "SourceExpression.Validate(value, nameof(value)); return value;"));
            Assert.Equal(1, Invoke(args));
            Assert.False(File.Exists(outputList));

            File.WriteAllText(sourcePath, source);
            Assert.Equal(0, Invoke(args));
            File.WriteAllLines(list, [Path.Combine(directory, "missing.cs")]);
            Assert.Equal(1, Invoke(args));
            Assert.False(File.Exists(outputList));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    private static int Invoke(string[] args) => (int)typeof(ConnectorValidationTransformer).Assembly
        .GetType("Microsoft.Azure.Workflows.Sdk.Build.Program")!
        .GetMethod("Main", BindingFlags.Public | BindingFlags.Static)!.Invoke(null, [args])!;
}
