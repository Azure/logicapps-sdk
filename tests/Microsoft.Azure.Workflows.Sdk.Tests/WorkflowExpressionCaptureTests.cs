// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
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
            var action = WorkflowActions.BuiltIn.Compose(
                () => previous.Output + suffix + id.ToString("N") + date.Kind);
            suffix = "?";
            previous.WithName("Late");

            var source = NormalizeNode(ReturnExpression(Input(action)));
            Assert.Contains("""outputs("Late").ToObject<string>()""", source);
            Assert.Contains("\"!\"", source);
            Assert.Contains("""new global::System.Guid("00000000-0000-0000-0000-000000000001")""", source);
            Assert.Contains("new global::System.DateTime(639268452000000000L, global::System.DateTimeKind.Utc)", source);
            Assert.DoesNotContain("\"?\"", source);
        }

        [Fact]
        public void InstanceFieldsAndAutoPropertiesAreSnapshotted()
        {
            this.instanceOffset = 2;
            this.InstanceAutoOffset = 3;
            var action = WorkflowActions.BuiltIn.Compose(() => this.instanceOffset + this.InstanceAutoOffset);
            this.instanceOffset = 20;
            this.InstanceAutoOffset = 30;

            AssertReturnExpression("2 + 3", Input(action));
        }

        [Fact]
        public void CapturesPreserveTheirStaticClrTypes()
        {
            int? optional = 5;
            object boxed = 7;
            double number = 1;

            AssertReturnExpression(
                "((int?)5).GetValueOrDefault()",
                Input(WorkflowActions.BuiltIn.Compose(() => optional.GetValueOrDefault())));
            AssertReturnExpression(
                "((object)7).ToString()",
                Input(WorkflowActions.BuiltIn.Compose(() => boxed.ToString())));
            AssertReturnExpression(
                "(1d).ToString(\"R\")",
                Input(WorkflowActions.BuiltIn.Compose(() => number.ToString("R"))));
        }

        [Fact]
        public void NullableNullAndUnnamedEnumCapturesRemainTyped()
        {
            int? optional = null;
            var role = (MessageRole)99;

            AssertReturnExpression(
                "(int?)null ?? 7",
                Input(WorkflowActions.BuiltIn.Compose(() => optional ?? 7)));
            AssertReturnExpression(
                "((global::Microsoft.Azure.Workflows.Sdk.MessageRole)99).ToString(\"D\")",
                Input(WorkflowActions.BuiltIn.Compose(() => role.ToString("D"))));
        }

        [Fact]
        public void NonFiniteCapturesRemainValidCSharpConstants()
        {
            var notANumber = double.NaN;

            AssertReturnExpression(
                "double.IsNaN(double.NaN)",
                Input(WorkflowActions.BuiltIn.Compose(() => double.IsNaN(notANumber))));
        }

        [Fact]
        public void ExecutableInstanceDependenciesAreRejected()
        {
            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose(() => this.InstanceComputedOffset));
            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose(() => this.GetOffset()));
        }

        [Fact]
        public void MutableCapturesAreRejected()
        {
            var values = new[] { 1, 2 };
            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose(() => values));

            var list = new List<int> { 1, 2 };
            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose(() => list.Count));
        }

        private int GetOffset() => 3;
    }
}
