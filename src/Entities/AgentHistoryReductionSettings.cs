// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The agent chat history reduction settings.
    /// </summary>
    public class AgentHistoryReductionSettings
    {
        /// <summary>
        /// Gets or sets the agent history reduction type.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public AgentHistoryReductionType AgentHistoryReductionType { get; set; }

        /// <summary>
        /// Gets or sets tHe count limit for messages when message count reduction is used.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public int MessageCountLimit { get; set; }

        /// <summary>
        /// Gets or sets the maximum token count for token count reduction.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public int MaximumTokenCount { get; set; }
    }
}
