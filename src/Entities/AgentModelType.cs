// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The agent model type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgentModelType
    {
        /// <summary>
        /// Not specified.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// The Azure OpenAI model.
        /// </summary>
        AzureOpenAI,

        /// <summary>
        /// The Foundry Agent model.
        /// </summary>
        FoundryAgentService,
    }
}
