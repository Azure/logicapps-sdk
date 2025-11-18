// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The agent chat completion settings.
    /// </summary>
    public class AgentChatCompletionSettings
    {
        /// <summary>
        /// Gets or sets the max tokens.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Gets or sets the frequency penalty.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Gets or sets the presense penalty.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public double? Temperature { get; set; }

        /// <summary>
        /// Gets or sets the topP.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public double? TopP { get; set; }

        /// <summary>
        /// Gets or sets the list of built-in tools.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string[] BuiltInTools { get; set; }
    }
}
