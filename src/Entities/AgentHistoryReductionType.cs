// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// The agent history reduction type.
    /// </summary>
    public enum AgentHistoryReductionType
    {
        /// <summary>
        /// Not specified.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// Reduce the chat history based on the last N messages.
        /// </summary>
        MessageCountReduction,

        /// <summary>
        /// Reduce the chat history based on the maximum token count.
        /// </summary>
        MaximumTokenCountReduction,
    }
}
