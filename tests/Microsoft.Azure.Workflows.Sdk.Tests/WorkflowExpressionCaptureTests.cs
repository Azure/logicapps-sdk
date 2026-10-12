// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk.Build;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Xunit;
    using static WorkflowExpressionTestSource;

    public class WorkflowExpressionCaptureTests
    {
        private int instanceOffset;
        private int InstanceAutoOffset { get; set; }
        private int InstanceComputedOffset => 5;

        [Fact]
        public void ScalarCapturesAreSnapshottedAsCSharp()
        {
            var id = Guid.Parse("00000000-0000-0000-0000-000000000001");
            var date = new DateTime(2026, 10, 6, 1, 0, 0, DateTimeKind.Utc);
            var suffix = "!";
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "hello");
            var action = WorkflowActions.BuiltIn.Compose(() => previous.Output + suffix + id.ToString("N") + date.Kind);
            suffix = "?";
            previous.WithName("Late");
            var source = Input(action);
            Assert.Equal(
                new[]
                {
                    NormalizeExpression("\"!\""),
                    NormalizeExpression("""new global::System.Guid("00000000-0000-0000-0000-000000000001")"""),
                    NormalizeExpression("new global::System.DateTime(639268452000000000L, global::System.DateTimeKind.Utc)"),
                },
                CaptureInitializers(source));
            AssertReturnExpression(
                """(outputs("Late")).ToObject<string>() + __capture0 + __capture1.ToString("N") + __capture2.Kind""",
                source);
            Assert.DoesNotContain(""" = "?";""", source);
            Assert.DoesNotContain("JsonTextReader", source);
        }

        [Fact]
        public void InstanceFieldsAndAutoPropertiesAreSnapshotted()
        {
            this.instanceOffset = 2;
            this.InstanceAutoOffset = 3;
            var action = WorkflowActions.BuiltIn.Compose(() => this.instanceOffset + InstanceAutoOffset);
            this.instanceOffset = 20;
            this.InstanceAutoOffset = 30;

            var source = Input(action);
            Assert.DoesNotContain(nameof(this.instanceOffset), source);
            Assert.DoesNotContain(nameof(this.InstanceAutoOffset), source);
            Assert.Equal(
                new[] { NormalizeExpression("(global::System.Int32)(2)"), NormalizeExpression("(global::System.Int32)(3)") },
                CaptureInitializers(source));
            AssertReturnExpression("__capture0 + __capture1", source);
            Assert.DoesNotContain("(20)", source);
            Assert.DoesNotContain("(30)", source);
        }

        [Theory]
        [InlineData("() => InstanceComputedOffset", "executable getter")]
        [InlineData("() => GetOffset()", "Instance method")]
        [InlineData("() => { instanceOffset++; return instanceOffset; }", "snapshots")]
        [InlineData("() => values.Count", "mutable objects")]
        public void UnsupportedInstanceDependenciesFailDuringAuthoring(string lambda, string message)
        {
            var source = $$"""
                using Microsoft.Azure.Workflows.Sdk;
                public class Consumer {
                    private int instanceOffset = 1;
                    private int InstanceComputedOffset => 2;
                    private System.Collections.Generic.List<int> values = new();
                    private int GetOffset() => 3;
                    public void Build() {
                        WorkflowActions.BuiltIn.Compose({{lambda}});
                    }
                }
                """;
            var compilation = CSharpCompilation.Create("Consumer", new[] { CSharpSyntaxTree.ParseText(source, path: "Consumer.cs") },
                References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            Assert.Contains(ExpressionCompiler.Transform(compilation).Diagnostics,
                diagnostic => diagnostic.GetMessage().Contains(message, StringComparison.OrdinalIgnoreCase));
        }

        [Theory]
        [InlineData("captured = 2")]
        [InlineData("captured += 2")]
        [InlineData("System.Threading.Interlocked.Increment(ref captured)")]
        [InlineData("int.TryParse(\"1\", out captured)")]
        public void CaptureWritesAndByReferenceUsesFailDuringAuthoring(string expression)
        {
            var source = $$"""
                using Microsoft.Azure.Workflows.Sdk;
                public class Consumer {
                    public void Build() {
                        var captured = 1;
                        WorkflowActions.BuiltIn.Compose(() => { {{expression}}; return captured; });
                    }
                }
                """;
            var compilation = CSharpCompilation.Create("Consumer", new[] { CSharpSyntaxTree.ParseText(source) },
                References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            Assert.Contains(ExpressionCompiler.Transform(compilation).Diagnostics, diagnostic => diagnostic.GetMessage().Contains("snapshots"));
        }
    }
}
