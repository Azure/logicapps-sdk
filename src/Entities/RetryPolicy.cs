//-----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//-----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The retry policy.
    /// </summary>
    public class RetryPolicy
    {
        /// <summary>
        /// Gets or sets the retry policy type.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public RetryType? Type { get; set; }

        /// <summary>
        /// Gets or sets the interval between retries.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public TimeSpan? Interval { get; set; }

        /// <summary>
        /// Gets or sets the number of times a retry should be attempted.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public int? Count { get; set; }

        /// <summary>
        ///  Gets or sets the minimum time delay for the exponential retry.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public TimeSpan? MinimumInterval { get; set; }

        /// <summary>
        ///  Gets or sets maximum time delay for the exponential retry.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public TimeSpan? MaximumInterval { get; set; }
    }
}
