// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Reflection;
    using System.Runtime.Loader;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Newtonsoft.Json.Linq;
    using Xunit.Sdk;

    internal static class EmittedExpressionCompiler
    {
        private static readonly Lazy<MetadataReference[]> References = new(() =>
        {
            var platformAssemblies = (string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")
                ?? throw new InvalidOperationException("Runtime platform assembly paths are unavailable.");
            return platformAssemblies.Split(Path.PathSeparator)
                .Concat(new[]
                {
                    typeof(JToken).Assembly.Location,
                    typeof(WorkflowActions).Assembly.Location,
                    typeof(EmittedExpressionCompiler).Assembly.Location,
                })
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Select(path => MetadataReference.CreateFromFile(path))
                .ToArray();
        });

        public static CompiledExpression Compile(string expression)
        {
            const string prefix = "@csharp{";
            if (expression == null ||
                !expression.StartsWith(prefix, StringComparison.Ordinal) ||
                !expression.EndsWith("}", StringComparison.Ordinal))
            {
                throw new XunitException($"Expected one C# expression envelope, got: {expression}");
            }

            var body = expression.Substring(prefix.Length, expression.Length - prefix.Length - 1);
            var source = $$"""
                using System;
                using System.Collections.Generic;
                using System.Linq;
                using Newtonsoft.Json;
                using Newtonsoft.Json.Linq;

                public static class ExpressionUnderTest
                {
                    public static object Evaluate(IReadOnlyDictionary<string, JToken> values)
                    {
                        JToken outputs(string name) => values[name];
                        string encodeURIComponent(object value) =>
                            Uri.EscapeDataString(Convert.ToString(
                                value, System.Globalization.CultureInfo.InvariantCulture));
                        return (object)({{body}});
                    }
                }
                """;

            var compilation = CSharpCompilation.Create(
                "ExpressionUnderTest_" + Guid.NewGuid().ToString("N"),
                new[] { CSharpSyntaxTree.ParseText(source) },
                References.Value,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            using var stream = new MemoryStream();
            var result = compilation.Emit(stream);
            if (!result.Success)
            {
                var diagnostics = string.Join(
                    Environment.NewLine,
                    result.Diagnostics.Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error));
                throw new XunitException($"Emitted expression did not compile:\n{diagnostics}\nSource:\n{source}");
            }

            var context = new ExpressionLoadContext();
            try
            {
                stream.Position = 0;
                var assembly = context.LoadFromStream(stream);
                var method = assembly.GetType("ExpressionUnderTest", throwOnError: true)
                    .GetMethod("Evaluate", BindingFlags.Public | BindingFlags.Static);
                return new CompiledExpression(
                    context,
                    method.CreateDelegate<Func<IReadOnlyDictionary<string, JToken>, object>>());
            }
            catch
            {
                context.Unload();
                throw;
            }
        }

        private sealed class ExpressionLoadContext : AssemblyLoadContext
        {
            public ExpressionLoadContext() : base(isCollectible: true)
            {
            }

            protected override Assembly Load(AssemblyName name) =>
                Default.Assemblies.FirstOrDefault(assembly =>
                    AssemblyName.ReferenceMatchesDefinition(assembly.GetName(), name));
        }

        internal sealed class CompiledExpression : IDisposable
        {
            private AssemblyLoadContext context;
            private Func<IReadOnlyDictionary<string, JToken>, object> evaluate;

            public CompiledExpression(
                AssemblyLoadContext context,
                Func<IReadOnlyDictionary<string, JToken>, object> evaluate)
            {
                this.context = context;
                this.evaluate = evaluate;
            }

            public object Evaluate(IReadOnlyDictionary<string, JToken> values = null)
            {
                ObjectDisposedException.ThrowIf(this.evaluate == null, this);
                return this.evaluate(values ?? new Dictionary<string, JToken>());
            }

            public void Dispose()
            {
                this.evaluate = null;
                this.context?.Unload();
                this.context = null;
            }
        }
    }
}
