// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The input model for the Terminate action.
    /// </summary>
    public class TerminateActionInput
    {
        /// <summary>
        /// Gets or sets the run status (e.g., Failed, Succeeded, Cancelled).
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string RunStatus { get; set; }

        /// <summary>
        /// Gets or sets the run error details.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public TerminateRunError RunError { get; set; }
    }

    /// <summary>
    /// The error details for the Terminate action.
    /// </summary>
    public class TerminateRunError
    {
        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Message { get; set; }
    }
}
