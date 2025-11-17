//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Indicates the type of retry policy to use.
    /// </summary>
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
