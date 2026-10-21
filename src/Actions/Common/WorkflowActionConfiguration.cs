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
    internal enum WorkflowActionSettingProfile
    {
        None = 0,
        RetryPolicy = 1 << 0,
        TrackedProperties = 1 << 1,
        SecureInputs = 1 << 2,
        SecureOutputs = 1 << 3,
        IterationConcurrency = 1 << 4,
        SecureOutputsLinkedToInputs = 1 << 5,
    }

    internal static class WorkflowActionSettingsProfiles
    {
        internal const WorkflowActionSettingProfile None =
            WorkflowActionSettingProfile.None;

        internal const WorkflowActionSettingProfile Tracked =
            WorkflowActionSettingProfile.TrackedProperties;

        internal const WorkflowActionSettingProfile SecureTracked =
            WorkflowActionSettingProfile.SecureInputs |
            WorkflowActionSettingProfile.SecureOutputs |
            WorkflowActionSettingProfile.TrackedProperties;

        internal const WorkflowActionSettingProfile SecureTrackedLinked =
            WorkflowActionSettingProfile.SecureInputs |
            WorkflowActionSettingProfile.TrackedProperties |
            WorkflowActionSettingProfile.SecureOutputsLinkedToInputs;

        internal const WorkflowActionSettingProfile RetrySecureTracked =
            WorkflowActionSettingProfile.RetryPolicy |
            WorkflowActionSettingProfile.SecureInputs |
            WorkflowActionSettingProfile.SecureOutputs |
            WorkflowActionSettingProfile.TrackedProperties;

        internal const WorkflowActionSettingProfile RetryTracked =
            WorkflowActionSettingProfile.RetryPolicy |
            WorkflowActionSettingProfile.TrackedProperties;

        internal const WorkflowActionSettingProfile ForEach =
            WorkflowActionSettingProfile.TrackedProperties |
            WorkflowActionSettingProfile.IterationConcurrency;
    }

    /// <summary>
    /// Configures settings that are projected onto a workflow action definition.
    /// </summary>
    public sealed class WorkflowActionConfiguration
    {
        private readonly WorkflowActionSettingProfile profile;

        internal WorkflowActionConfiguration(WorkflowActionSettingProfile profile)
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
            (this.profile & WorkflowActionSettingProfile.SecureOutputsLinkedToInputs) != 0;

        private readonly Dictionary<string, JToken> trackedProperties = new Dictionary<string, JToken>(StringComparer.Ordinal);

        internal void Require(WorkflowActionSettingProfile setting, string operationName)
        {
            var unsupported = setting & ~this.profile;
            if (unsupported != WorkflowActionSettingProfile.None)
            {
                throw new NotSupportedException($"Action '{operationName}' does not support setting(s) '{unsupported}'.");
            }
        }
    }
}
