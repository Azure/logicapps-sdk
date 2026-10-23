//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Runtime.Serialization;
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
        [EnumMember(Value = "notSpecified")]
        NotSpecified,

        /// <summary>
        /// Indicates that the runtime default retry policy should be used.
        /// </summary>
        [EnumMember(Value = "default")]
        Default,

        /// <summary>
        /// Indicates that no retry type should be used.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Fixed interval retry strategy.
        /// </summary>
        [EnumMember(Value = "fixed")]
        Fixed,

        /// <summary>
        /// Exponential random retry strategy.
        /// </summary>
        [EnumMember(Value = "exponential")]
        Exponential,
    }
}
