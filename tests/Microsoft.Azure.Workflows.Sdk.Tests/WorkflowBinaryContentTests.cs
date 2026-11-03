// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Xunit;

    public class WorkflowBinaryContentTests
    {
        [Fact]
        public void RawBytesSerializeAsBase64()
        {
            Assert.Equal(
                "AQID",
                JToken.FromObject(WorkflowBinaryContent.FromBytes(new byte[] { 1, 2, 3 })).Value<string>());
        }

        [Fact]
        public void ContentEnvelopePassesThroughBase64Content()
        {
            var envelope = new JObject
            {
                ["$content-type"] = "application/octet-stream",
                ["$content"] = "AQID",
            };

            Assert.Equal(
                "AQID",
                JToken.FromObject(WorkflowBinaryContent.FromWorkflowContent(envelope)).Value<string>());
        }

        [Fact]
        public void WorkflowTextAndJsonUseRuntimeBase64Semantics()
        {
            Assert.Equal(
                Convert.ToBase64String(Encoding.UTF8.GetBytes("message")),
                JToken.FromObject(WorkflowBinaryContent.FromWorkflowContent("message")).Value<string>());
            Assert.Equal(
                Convert.ToBase64String(Encoding.UTF8.GetBytes("""{"value":1}""")),
                JToken.FromObject(
                    WorkflowBinaryContent.FromWorkflowContent(
                        JObject.Parse("""{"value":1}"""))).Value<string>());
        }

        [Fact]
        public void ExplicitBase64PassesThroughAndValidates()
        {
            Assert.Equal(
                "AQID",
                JToken.FromObject(WorkflowBinaryContent.FromBase64("AQID")).Value<string>());
            Assert.Throws<ArgumentException>(() => WorkflowBinaryContent.FromBase64("invalid"));
        }

        [Fact]
        public void NestedBinaryContentSerializesAsBase64String()
        {
            var token = JObject.FromObject(new BinaryInput
            {
                Content = WorkflowBinaryContent.FromBytes(new byte[] { 1, 2, 3 }),
            });

            Assert.Equal("AQID", token["content"].Value<string>());
        }

        private sealed class BinaryInput
        {
            [JsonProperty("content")]
            public WorkflowBinaryContent Content { get; set; }
        }
    }
}
