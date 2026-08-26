// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json.Linq;
    using Xunit;

    /// <summary>
    /// Tests for strongly-typed workflow operation results.
    /// </summary>
    public class WorkflowOperationResultTests
    {
        /// <summary>
        /// Verifies that complete operation outputs can be deserialized to a specified type.
        /// </summary>
        [Fact]
        public void GetOutputsReturnsTypedOutputs()
        {
            var result = new WorkflowOperationResult
            {
                Outputs = JObject.Parse("{ 'name': 'Ada', 'customerId': 42 }"),
            };

            var outputs = result.GetOutputs<CustomerOutput>();

            Assert.Equal("Ada", outputs.Name);
            Assert.Equal(42, outputs.CustomerId);
        }

        /// <summary>
        /// Verifies that an operation output body can be deserialized to a specified type.
        /// </summary>
        [Fact]
        public void GetBodyReturnsTypedBody()
        {
            var result = new WorkflowOperationResult
            {
                Outputs = JObject.Parse("{ 'statusCode': 200, 'body': { 'name': 'Ada', 'customerId': 42 } }"),
            };

            var body = result.GetBody<CustomerOutput>();

            Assert.Equal("Ada", body.Name);
            Assert.Equal(42, body.CustomerId);
        }

        /// <summary>
        /// Verifies that absent outputs return the default value.
        /// </summary>
        [Fact]
        public void GetOutputsReturnsDefaultWhenOutputsAreMissing()
        {
            var result = new WorkflowOperationResult();

            Assert.Null(result.GetOutputs<CustomerOutput>());
        }

        /// <summary>
        /// Verifies that an absent body returns the default value.
        /// </summary>
        [Fact]
        public void GetBodyReturnsDefaultWhenBodyIsMissing()
        {
            var result = new WorkflowOperationResult
            {
                Outputs = JObject.Parse("{ 'statusCode': 204 }"),
            };

            Assert.Null(result.GetBody<CustomerOutput>());
        }

        /// <summary>
        /// Verifies that incompatible JSON is not silently converted.
        /// </summary>
        [Fact]
        public void GetOutputsThrowsWhenOutputsAreIncompatible()
        {
            var result = new WorkflowOperationResult
            {
                Outputs = JObject.Parse("{ 'name': 'Ada' }"),
            };

            Assert.Throws<ArgumentException>(() => result.GetOutputs<int>());
        }

        private sealed class CustomerOutput
        {
            public string Name { get; set; }

            public int CustomerId { get; set; }
        }
    }
}
