//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Indicates the type of retry policy to use.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RetryType
    {
        /// <summary>
        /// Indicates that the retry type is not specified.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// Indicates that no retry type should be used.
        /// </summary>
        None,

        /// <summary>
        /// Fixed interval retry strategy.
        /// </summary>
        Fixed,

        /// <summary>
        /// Exponential random retry strategy.
        /// </summary>
        Exponential,
    }
}
