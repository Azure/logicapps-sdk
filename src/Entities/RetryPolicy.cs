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
        [JsonConverter(typeof(Iso8601TimeSpanConverter))]
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
        [JsonConverter(typeof(Iso8601TimeSpanConverter))]
        public TimeSpan? MinimumInterval { get; set; }

        /// <summary>
        ///  Gets or sets maximum time delay for the exponential retry.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        [JsonConverter(typeof(Iso8601TimeSpanConverter))]
        public TimeSpan? MaximumInterval { get; set; }

        /// <summary>
        /// Creates a policy that uses the runtime default retry behavior.
        /// </summary>
        public static RetryPolicy Default() => new RetryPolicy { Type = RetryType.Default };

        /// <summary>
        /// Creates a policy that disables retries.
        /// </summary>
        public static RetryPolicy None() => new RetryPolicy { Type = RetryType.None };

        /// <summary>
        /// Creates a fixed-interval retry policy.
        /// </summary>
        public static RetryPolicy Fixed(int count, TimeSpan interval) =>
            new RetryPolicy
            {
                Type = RetryType.Fixed,
                Count = count,
                Interval = interval,
            };

        /// <summary>
        /// Creates an exponential retry policy.
        /// </summary>
        public static RetryPolicy Exponential(
            int count,
            TimeSpan interval,
            TimeSpan? minimumInterval = null,
            TimeSpan? maximumInterval = null) =>
            new RetryPolicy
            {
                Type = RetryType.Exponential,
                Count = count,
                Interval = interval,
                MinimumInterval = minimumInterval,
                MaximumInterval = maximumInterval,
            };
    }
}
