//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The status of a flow.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1717:OnlyFlagsEnumsShouldHavePluralNames", Justification = "By design.")]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlowStatus
    {
        /// <summary>
        /// The flow status is not specified.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// The flow status is paused.
        /// </summary>
        Paused,

        /// <summary>
        /// The flow status is running.
        /// </summary>
        Running,

        /// <summary>
        /// The flow status is waiting.
        /// </summary>
        Waiting,

        /// <summary>
        /// The flow status is succeeded.
        /// </summary>
        Succeeded,

        /// <summary>
        /// The flow status is skipped.
        /// </summary>
        Skipped,

        /// <summary>
        /// The flow status is suspended.
        /// </summary>
        Suspended,

        /// <summary>
        /// The flow status is cancelled.
        /// </summary>
        Cancelled,

        /// <summary>
        /// The flow status is failed.
        /// </summary>
        Failed,

        /// <summary>
        /// The flow status is faulted.
        /// </summary>
        Faulted,

        /// <summary>
        /// The flow status is timed out.
        /// </summary>
        TimedOut,

        /// <summary>
        /// The flow status is aborted.
        /// </summary>
        Aborted,

        /// <summary>
        /// The flow status is ignored.
        /// </summary>
        Ignored,

        /// <summary>
        /// The flow status is deleted. This works as a "soft" delete or flag, and the jobs will soon remove it from storage.
        /// </summary>
        Deleted,

        /// <summary>
        /// The flow status is Terminated.
        /// </summary>
        Terminated,

        /// <summary>
        /// The flow status is handed off.
        /// </summary>
        HandedOff,
    }
}
