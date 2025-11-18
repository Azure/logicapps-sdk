//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The retry-able action input.
    /// </summary>
    /// <remarks>This was for swagger-based actions in Classic Designer. This is now obsolete and replaced with manifest-based actions. Retry-able input is not supported by New Designer.</remarks>
    public class RetryableActionInput
    {
        /// <summary>
        /// Gets or sets the operation options.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public OperationOptions? OperationOptions { get; set; }

        /// <summary>
        /// Gets or sets the retry policy.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public RetryPolicy RetryPolicy { get; set; }
    }
}
