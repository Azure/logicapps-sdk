// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// Runtime configuration for a workflow operation.
    /// </summary>
    public sealed class FlowTemplateOperationRuntimeConfiguration
    {
        [JsonProperty(Required = Required.Default)]
        public FlowConcurrencyConfiguration Concurrency { get; set; }

        [JsonProperty(Required = Required.Default)]
        public FlowSecureDataConfiguration SecureData { get; set; }
    }

    /// <summary>
    /// Concurrency configuration for a workflow operation.
    /// </summary>
    public sealed class FlowConcurrencyConfiguration
    {
        [JsonProperty(Required = Required.Default)]
        public int? Runs { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int? MaximumWaitingRuns { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int? Repetitions { get; set; }
    }

    /// <summary>
    /// Secure-data configuration for a workflow operation.
    /// </summary>
    public sealed class FlowSecureDataConfiguration
    {
        [JsonProperty(Required = Required.Always)]
        public string[] Properties { get; set; }
    }

    /// <summary>
    /// Correlation configuration for a workflow trigger.
    /// </summary>
    public sealed class FlowTemplateCorrelation
    {
        [JsonProperty(Required = Required.Default)]
        public string ClientTrackingId { get; set; }
    }
}
