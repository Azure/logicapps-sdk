//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The workflow agent prompt message.
    /// </summary>
    public class AgentPromptMessage
    {
        /// <summary>
        /// Gets or sets the message role name.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public MessageRole Role { get; set; }

        /// <summary>
        /// Gets or sets the message content.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Content { get; set; }
    }
}
