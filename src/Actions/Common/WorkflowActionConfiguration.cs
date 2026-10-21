// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [Flags]
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum WorkflowActionSettings
    {
        None = 0,
        RetryPolicy = 1 << 0,
        TrackedProperties = 1 << 1,
        SecureInputs = 1 << 2,
        SecureOutputs = 1 << 3,
        IterationConcurrency = 1 << 4,
        SecureOutputsLinkedToInputs = 1 << 5,
    }

    internal static class WorkflowActionSettingProfiles
    {
        internal const WorkflowActionSettings None =
            WorkflowActionSettings.None;

        internal const WorkflowActionSettings Tracked =
            WorkflowActionSettings.TrackedProperties;

        internal const WorkflowActionSettings SecureTracked =
            WorkflowActionSettings.SecureInputs |
            WorkflowActionSettings.SecureOutputs |
            WorkflowActionSettings.TrackedProperties;

        internal const WorkflowActionSettings SecureTrackedLinked =
            WorkflowActionSettings.SecureInputs |
            WorkflowActionSettings.TrackedProperties |
            WorkflowActionSettings.SecureOutputsLinkedToInputs;

        internal const WorkflowActionSettings RetrySecureTracked =
            WorkflowActionSettings.RetryPolicy |
            WorkflowActionSettings.SecureInputs |
            WorkflowActionSettings.SecureOutputs |
            WorkflowActionSettings.TrackedProperties;

        internal const WorkflowActionSettings RetryTracked =
            WorkflowActionSettings.RetryPolicy |
            WorkflowActionSettings.TrackedProperties;

        internal const WorkflowActionSettings ForEach =
            WorkflowActionSettings.TrackedProperties |
            WorkflowActionSettings.IterationConcurrency;
    }

    /// <summary>
    /// Configures settings that are projected onto a workflow action definition.
    /// </summary>
    public sealed class WorkflowActionConfiguration
    {
        private readonly WorkflowActionSettings profile;

        internal WorkflowActionConfiguration(WorkflowActionSettings profile)
        {
            this.profile = profile;
        }

        /// <summary>
        /// Gets the configured retry policy.
        /// </summary>
        public RetryPolicy RetryPolicy { get; internal set; }

        /// <summary>
        /// Gets the configured tracked properties.
        /// </summary>
        public IReadOnlyDictionary<string, JToken> TrackedProperties => this.trackedProperties;

        /// <summary>
        /// Gets whether action inputs are secured in run history.
        /// </summary>
        public bool SecureInputs { get; internal set; }

        /// <summary>
        /// Gets whether action outputs are secured in run history.
        /// </summary>
        public bool SecureOutputs { get; internal set; }

        /// <summary>
        /// Gets the maximum number of parallel loop iterations.
        /// </summary>
        public int? MaximumParallelIterations { get; internal set; }

        internal Dictionary<string, JToken> MutableTrackedProperties => this.trackedProperties;

        internal bool SecureOutputsLinkedToInputs =>
            (this.profile & WorkflowActionSettings.SecureOutputsLinkedToInputs) != 0;

        private readonly Dictionary<string, JToken> trackedProperties = new Dictionary<string, JToken>(StringComparer.Ordinal);

        internal void Require(WorkflowActionSettings setting, string operationName)
        {
            var unsupported = setting & ~this.profile;
            if (unsupported != WorkflowActionSettings.None)
            {
                throw new NotSupportedException($"Action '{operationName}' does not support setting(s) '{unsupported}'.");
            }
        }
    }
}
