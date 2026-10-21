// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [Flags]
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum WorkflowTriggerSettings
    {
        None = 0,
        RetryPolicy = 1 << 0,
        SecureInputs = 1 << 1,
        SecureOutputs = 1 << 2,
        Concurrency = 1 << 3,
        Correlation = 1 << 4,
        SchemaValidation = 1 << 5,
    }

    internal static class WorkflowTriggerSettingProfiles
    {
        internal const WorkflowTriggerSettings None =
            WorkflowTriggerSettings.None;

        internal const WorkflowTriggerSettings Request =
            WorkflowTriggerSettings.SecureInputs |
            WorkflowTriggerSettings.SecureOutputs |
            WorkflowTriggerSettings.Concurrency |
            WorkflowTriggerSettings.Correlation |
            WorkflowTriggerSettings.SchemaValidation;

        internal const WorkflowTriggerSettings Scheduled =
            WorkflowTriggerSettings.Concurrency |
            WorkflowTriggerSettings.Correlation;

        internal const WorkflowTriggerSettings ManagedConnector =
            WorkflowTriggerSettings.RetryPolicy |
            WorkflowTriggerSettings.SecureInputs |
            WorkflowTriggerSettings.SecureOutputs |
            WorkflowTriggerSettings.Concurrency |
            WorkflowTriggerSettings.Correlation;
    }

    /// <summary>
    /// Configures settings that are projected onto a workflow trigger definition.
    /// </summary>
    public sealed class WorkflowTriggerConfiguration
    {
        private readonly WorkflowTriggerSettings profile;

        internal WorkflowTriggerConfiguration(WorkflowTriggerSettings profile)
        {
            this.profile = profile;
        }

        /// <summary>
        /// Gets the configured retry policy.
        /// </summary>
        public RetryPolicy RetryPolicy { get; internal set; }

        /// <summary>
        /// Gets whether trigger inputs are secured in run history.
        /// </summary>
        public bool SecureInputs { get; internal set; }

        /// <summary>
        /// Gets whether trigger outputs are secured in run history.
        /// </summary>
        public bool SecureOutputs { get; internal set; }

        /// <summary>
        /// Gets the maximum number of concurrent workflow runs.
        /// </summary>
        public int? ConcurrentRuns { get; internal set; }

        /// <summary>
        /// Gets the maximum number of waiting workflow runs.
        /// </summary>
        public int? MaximumWaitingRuns { get; internal set; }

        /// <summary>
        /// Gets the client tracking identifier expression.
        /// </summary>
        public string ClientTrackingId { get; internal set; }

        /// <summary>
        /// Gets whether request schema validation is enabled.
        /// </summary>
        public bool SchemaValidationEnabled { get; internal set; }

        internal void Require(WorkflowTriggerSettings setting, string operationName)
        {
            var unsupported = setting & ~this.profile;
            if (unsupported != WorkflowTriggerSettings.None)
            {
                throw new NotSupportedException($"Trigger '{operationName}' does not support setting(s) '{unsupported}'.");
            }
        }
    }
}
